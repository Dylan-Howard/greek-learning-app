I am continuing in **Plan Mode**. I have completed a thorough analysis of the `GreekLearningApp-TextService`. Below is the enhanced, full version of the codebase inventory and architectural analysis.

---

# GreekLearningApp-TextService: Full Inventory & Analysis

## 1. API Endpoints Inventory

The service is an Azure Functions application (Isolated Worker) on .NET 8, using HTTP triggers and SQL Bindings. All endpoints use `AuthorizationLevel.Anonymous`.

### Text & Structural Hierarchy
| Function | Route | Method | Model (Request/Response) |
| :--- | :--- | :--- | :--- |
| `GetTexts` | `texts` | GET | `IEnumerable<Koine.GetText.Text>` |
| `GetText` | `texts/{textId}` | GET | `Koine.GetText.Text` |
| `PostText` | `texts` | POST | `Koine.PostText.Text` (Input: title) |
| `GetChapters` | `chapters` | GET | `IEnumerable<Koine.GetChapter.Chapter>` |
| `GetChapter` | `chapters/{chapterId}` | GET | `Koine.GetChapter.Chapter` |
| `GetChaptersByTextId`| `texts/{textId}/chapters` | GET | `IEnumerable<Koine.GetChapter.Chapter>` |
| `GetUnitsByChapter` | `chapters/{chapterId}/units`| GET | `IEnumerable<Koine.GetUnit.Unit>` |
| `GetWordsByChapter` | `chapters/{chapterId}/words`| GET | `IEnumerable<KoineTexts.Word>` |
| `GetWordsByBook` | `books/{textId}/words` | GET | `IEnumerable<KoineTexts.Word>` |

### Units & Tokens
| Function | Route | Method | Model (Request/Response) |
| :--- | :--- | :--- | :--- |
| `GetUnits` | `units` | GET | `IEnumerable<Koine.GetUnit.Unit>` (Top 1000) |
| `GetUnit` | `units/{unitId}` | GET | `Koine.GetUnit.Unit` |
| `PostUnit` | `units` | POST | `Koine.PostUnit.Unit` |
| `GetTranslation` | `units/{unitId}/translation`| GET | `KoineTexts.Translation` |

### Linguistics (Morphology & Words)
| Function | Route | Method | Model (Request/Response) |
| :--- | :--- | :--- | :--- |
| `GetWords` | `words` | GET | `IEnumerable<KoineTexts.Word>` (Supports `occurances` filter) |
| `GetWord` | `words/{rootId}` | GET | `KoineTexts.Word` |
| `UpdateWord` | `words/update` | POST | `Koine.UpdateWord.Word` |
| `GetMorphologyDetails`| `morphologies/{id}/details`| GET | `Koine.GetMorphology.MorphologyDetails` |
| `GetMorphologyAbbrev` | `morphologies/{id}/abbreviation`| GET | `Koine.GetMorphology.MorphologyDetails` |
| `GetMorphologyByUnit` | `units/{unitId}/morphology` | GET | `Koine.GetMorphology.Morphology` |

---

## 2. Core Business Logic & DTOs

### Logic Characteristics
- **Embedded SQL Logic:** The "Business Logic" resides in the `commandText` of `SqlInput` attributes. For example, word filtering is handled via LINQ on the result set in `GetWords`, while complex entity relationships are resolved via SQL `JOIN`s.
- **Minimal Validation:** Uses basic C# null checks. No formal validation framework (FluentValidation) is present.
- **DTO Fragmentation:** Each function file defines its own DTOs (e.g., `Text` is defined in `GetText.cs`, `PostText.cs`, and `Texts.cs`).

### Key DTO: `MorphologyDetails`
This is the most critical DTO for UI display, consolidating linguistic IDs into readable strings.
```csharp
public class MorphologyDetails {
    public int MorphologyId { get; set; }
    public required string Content { get; set; }
    public required string PosName { get; set; }
    public string? CaseName { get; set; }
    public string? TenseName { get; set; }
    public string? VoiceName { get; set; }
    public string? MoodName { get; set; }
    public string? PersonName { get; set; }
    public string? NumberName { get; set; }
    public string? GenderName { get; set; }
    public string? PatternName { get; set; }
    public string? DegreeName { get; set; }
    public string RootName { get; set; }
}
```

---

## 3. Database Interactions

### SQL Bindings Strategy
- **Reads:** `SqlInput` attributes with parameters (e.g., `@Id={unitId}`).
- **Writes:** `SqlOutput` attributes. The function returns an `OutputType` object containing the entity to persist and the `HttpResponseData`.
- **Complex Query (Preservation Candidate):**
```sql
SELECT mph.morphologyId, mph.[content], pos.[name] AS 'posName', 
       cse.[name] AS 'caseName', tns.[name] AS 'tenseName', 
       voc.[name] AS 'voiceName', moo.[name] AS 'moodName', 
       per.[name] AS 'personName', num.[name] AS 'numberName', 
       pat.[name] AS 'patternName', gen.[name] AS 'genderName', 
       deg.[name] AS 'degreeName', roo.[content] AS 'rootName' 
FROM [dbo].[Morphology] mph 
LEFT JOIN [dbo].[GrammaticalForm] pos ON pos.[grammarId] = mph.[posId] 
... 
LEFT JOIN [dbo].[Root] roo ON roo.[rootId] = mph.[rootId] 
WHERE mph.[morphologyId] = @Id
```

---

## 4. Units Data Model (CRITICAL)

### Structure
The `Unit` table is the "glue" of the system, linking structural text position to linguistic metadata.

| Column | Type | Description |
| :--- | :--- | :--- |
| `unitId` | `INT (PK)` | Auto-incrementing ID. |
| `unitGUID` | `UNIQUEIDENTIFIER`| Public identifier. |
| `unitPlacement`| `INT` | Sequence number within a verse. |
| `content` | `NVARCHAR(48)` | The actual Greek token (word/punctuation). |
| `morphologyId` | `INT (FK)` | Link to grammatical metadata. |
| `verseId` | `INT (FK)` | Link to text structural hierarchy. |

### Performance & Usage Concerns
1. **Join Depth:** Fetching a chapter's full text requires joining `Chapter` -> `Verse` -> `Unit` -> `Morphology` -> `GrammaticalForm` (up to 10 joins per unit).
2. **Data Duplication:** `content` is stored directly in `Unit`, but `Root` also has `content`. `Unit` content is the inflected form; `Root` content is the lemma.
3. **Write Pattern:** New units are posted one-by-one (`PostUnit`). For bulk text import, this is inefficient.

---

## 5. Implementation Plan

1.  **EF Core Migration:** Define a centralized `KoineDbContext` using the Fluent API to map the relationships defined in `setupDatabase.sql`.
2.  **DTO Consolidation:** Create a shared project for DTOs to replace the fragmented classes in the Azure Functions.
3.  **Repository Layer:** Implement an `ITextRepository` that uses Compiled Queries in EF Core to mitigate the performance cost of deep joins for `Unit` and `Morphology` data.
4.  **Bulk Operations:** Add a `BulkPostUnits` endpoint to handle importing entire chapters efficiently.
5.  **Validation:** Integrate `FluentValidation` middleware to replace manual null checks.
6.  **Fix Logic Bug:** Correct the mapping in `GetMorphologyDetails` where `patternId` and `genderId` appear to be crossed in some join queries.

**Presentation for Approval:**
Does this enhanced analysis provide the level of detail you need to proceed with the unified backend implementation?