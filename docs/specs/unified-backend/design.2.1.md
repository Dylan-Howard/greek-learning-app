Based on the feature audits and the current state of the `Koine.Domain` codebase, here is the proposed **Domain Layer Design** for the monolithic backend. This design focuses on Domain-Driven Design (DDD) principles, using Aggregate Roots to define consistency boundaries and Value Objects for immutable data.

---

## 1. Aggregate Roots & Entities

### **User Aggregate**
The `User` aggregate is the root for all user-centric data, including authentication, preferences, and their cumulative learning progress.

```csharp
// Koine.Domain/Entities/User.cs
public class User : AggregateRoot<Guid>
{
    public string Email { get; private set; }
    public string Username { get; private set; }
    public string PasswordHash { get; private set; }
    public UserSettings Settings { get; private set; }
    public UserProgress Progress { get; private set; }

    public void UpdateProgress(int lessonId, bool isComplete)
    {
        Progress = Progress.WithLesson(lessonId, isComplete);
        AddDomainEvent(new UserProgressUpdated(Id, Progress));
    }

    public void ChangeSettings(bool prefersDarkMode, string translation)
    {
        Settings = new UserSettings(prefersDarkMode, translation);
    }
}
```

### **Text Aggregate**
The `Text` aggregate (centered around `Book` and `Chapter`) handles the structural hierarchy of biblical/literary texts. Units are now managed as a JSON Value Object within the `Chapter` entity.

```csharp
// Koine.Domain/Entities/Chapter.cs
public class Chapter : Entity<int>
{
    public int BookId { get; private set; }
    public int ChapterIndex { get; private set; }
    public string? Title { get; private set; }
    
    // The critical JSON storage column
    public ChapterUnits Units { get; private set; } 
    
    public void UpdateUnits(ChapterUnits newUnits)
    {
        Units = newUnits;
        AddDomainEvent(new ChapterUnitsUpdated(Id));
    }
}
```

### **ReadingSession Aggregate**
A new aggregate to track user engagement with a text over time.

```csharp
public class ReadingSession : AggregateRoot<Guid>
{
    public Guid UserId { get; private set; }
    public int ChapterId { get; private set; }
    public DateTime StartedAt { get; private set; }
    public DateTime? CompletedAt { get; private set; }
    public int LastPosition { get; private set; }

    public void CompleteSession()
    {
        CompletedAt = DateTime.UtcNow;
        AddDomainEvent(new ReadingSessionCompleted(this));
    }
}
```

---

## 2. Value Objects (JSON & Immutable Concepts)

### **Units Value Object (JSON Storage)**
Designed for high-performance reading by aggregating all tokens (units) for a chapter into a single JSON blob.

```csharp
public record ChapterUnits(List<UnitToken> Tokens);

public record UnitToken(
    Guid Id,
    int Placement,
    string Content,      // The inflected Greek word
    int MorphologyId,    // Reference to linguistic metadata
    int VerseId,         // Structural reference
    string? RootContent  // Denormalized for the Reader UI
);
```

### **UserProgress Value Object**
```csharp
public record UserProgress(
    IReadOnlyList<LessonProgress> Lessons,
    IReadOnlyList<WordProgress> Vocabulary
) {
    public UserProgress WithLesson(int lessonId, bool isComplete) =>
        this with { Lessons = Lessons.Append(new LessonProgress(lessonId, isComplete)).ToList() };
}
```

---

## 3. Domain Services

### **TextParser Service**
Handles the complex logic of converting raw Greek text into the structured `ChapterUnits` format.
```csharp
public interface ITextParser
{
    Task<ChapterUnits> ParseRawTextAsync(string rawText, int chapterId);
}
```

### **ProgressCalculator Service**
Determines a user's "Readiness Score" for a specific text by comparing `UserProgress` against `ChapterUnits`.
```csharp
public interface IProgressCalculator
{
    double CalculateReadiness(UserProgress userProgress, ChapterUnits chapterUnits);
}
```

---

## 4. Domain Events

| Event | Description |
| :--- | :--- |
| `UserProgressUpdated` | Triggered when a lesson or word is marked as complete. |
| `ReadingSessionCompleted` | Triggered when a user finishes a chapter, potentially updating progress. |
| `TextImported` | Triggered when a new book/chapter is added via the Parser. |

---

## 5. Units JSON Schema Design (CRITICAL)

### **Schema Structure**
To optimize for the **Reader Service**, the JSON is stored in a `Units` column in the `Chapters` table.

```json
[
  {
    "id": "550e8400-e29b-41d4-a716-446655440000",
    "p": 1, 
    "c": "εν",
    "m": 1204,
    "v": 1,
    "r": "εν"
  },
  ...
]
```
*   **Key Mapping:** `p` (Placement), `c` (Content), `m` (MorphologyId), `v` (VerseId), `r` (Root).
*   **Optimization:** Using short keys reduces JSON payload size by ~40% for large chapters.

### **Query Patterns & Indexing**
- **Read Pattern:** `SELECT Units FROM Chapters WHERE Id = @Id`. This eliminates 10+ JOINs per request.
- **Indexing:** In PostgreSQL/SQL Server, use a GIN/JSON index on the `m` (MorphologyId) field if cross-text word searches are required.
- **Computed Columns:** Create a virtual column for `VerseCount` or `WordCount` by extracting from the JSON to allow fast filtering without parsing the whole blob.

### **Migration Strategy**
1.  **Phase 1 (Shadow Write):** Update the `PostUnit` logic to write to both the legacy `Units` table and the new `Chapter.Units` JSON column.
2.  **Phase 2 (Backfill):** Run a script to aggregate existing rows from the `Units` table into JSON blobs for every chapter.
3.  **Phase 3 (Read Switch):** Update the `ReaderService` and `TextService` to read from the JSON column exclusively.
4.  **Phase 4 (Cleanup):** Deprecate and drop the high-volume `Units` table.

This architecture resolves the **Join Depth** performance bottleneck identified in the Text Service audit while keeping the Domain Layer clean and testable.