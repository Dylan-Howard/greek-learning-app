# AI Prompt: Generate C# GNT Seed Data File from OpenGNT Token JSON
# =================================================================
# HOW TO USE THIS PROMPT
# ----------------------
# 1. Run parse_opengnt.py to extract the token JSON for your target book/chapter.
# 2. Open a new Claude conversation.
# 3. Paste this entire prompt, then paste your JSON data at the bottom
#    inside the <token_data> block.
# 4. Claude will return a complete C# seed data file.
#
# TIP: For large books, process one chapter at a time to stay within
# context limits. Later chapters can reference earlier ones for style.
# =================================================================

SYSTEM_PROMPT = """
You are a biblical Greek scholar and senior C# developer producing seed data
for a Greek New Testament study app. Your output is always valid, compilable
C# code following the exact patterns in the reference class below.
"""

USER_PROMPT = """
## Task

Generate a complete C# seed data file for the chapter described in the token
data below. The file must match the style, structure, and naming conventions
of the reference class exactly.

---

## Reference Class (style to match exactly)

```csharp
// GreekParser.Infrastructure/Data/Seed/FirstJohnTextData.cs
using System.Text.Json;

namespace GreekParser.Infrastructure.Data.Seed
{
    public class Word
    {
        public string Greek { get; set; } = string.Empty;
        public string Transliteration { get; set; } = string.Empty;
        public string Gloss { get; set; } = string.Empty;
        public List<string> GrammarCodes { get; set; } = new();
        public string PartOfSpeech { get; set; } = string.Empty;
    }

    public class Phrase
    {
        public List<string> SyntaxCodes { get; set; } = new();
        public List<object> Content { get; set; } = new(); // Can be Word or Phrase
        public string Translation { get; set; } = string.Empty;
    }

    public static class FirstJohnTextData
    {
        private static List<object> GetChapter1()
        {
            return new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Ὃ", Transliteration = "Ho",
                                    Gloss = "that which",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" },
                                    PartOfSpeech = "pronoun" },
                                new Word { Greek = "ἦν", Transliteration = "ēn",
                                    Gloss = "was",
                                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀπ'", Transliteration = "ap'",
                                            Gloss = "from",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "preposition" },
                                        new Word { Greek = "ἀρχῆς", Transliteration = "archēs",
                                            Gloss = "beginning",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "noun" }
                                    },
                                    Translation = "from the beginning"
                                }
                            },
                            Translation = "That which was from the beginning"
                        }
                    },
                    Translation = "That which was from the beginning, which we have heard..."
                }
            };
        }
    }
}
```

---

## Phrase Grouping Rules

Group words into Phrase objects using these syntactic principles:

**Clause-level containers (top-level SyntaxCodes)**
- `INDEP_CLAUSE` — main/independent clause
- `DEP_CLAUSE` — generic dependent clause
- `REL_CLAUSE` — relative clause (introduced by ὅς, ὅστις, etc.)
- `PURPOSE_CLAUSE` — ἵνα + subjunctive
- `RESULT_CLAUSE` — ὥστε + infinitive or indicative
- `COND_CLAUSE` — conditional (εἰ / ἐάν + apodosis)
- `TEMP_CLAUSE` — temporal clause (ὅτε, ἐπεί, etc.)
- `CAUSAL_CLAUSE` — causal (ὅτι + indicative used causally, ἐπεί, διότι)

**Phrase-level containers**
- `NOUN_PHRASE` — article + noun ± adjective ± genitive
- `PREP_PHRASE` — preposition + object
- `VERB_PHRASE` — verb + direct complements
- `PTCP` — participial phrase
- `INF_PHRASE` — infinitive phrase
- `APPOS` — appositive

**Functional labels (add as second SyntaxCode on noun phrases)**
- `SUBJ` — subject
- `OBJ` — direct object
- `IND_OBJ` — indirect object / dative of interest
- `PRED` — predicate nominative or accusative
- `PRED_ADJ` — predicate adjective

**Special construction labels (add when detectable)**
- `GEN_ABS` — genitive absolute (participle + noun both genitive, outside clause)
- `PERIPH` — periphrastic (εἰμί + participle)
- `TSKS` — Granville-Sharp construction (single article governing two substantives joined by καί)
- `DAT_INSTR` — dative of instrument
- `DAT_MANNER` — dative of manner
- `DAT_REF` — dative of reference
- `GEN_SUBJ` — subjective genitive
- `GEN_OBJ` — objective genitive
- `GEN_DESC` — descriptive/attributive genitive
- `VOC` — vocative address

**Nesting rule:** Nest phrases inside clauses. Nested phrases should only contain
the words that belong to them. Words that don't fall into a sub-phrase sit
directly in the parent Content list. Always include a `Translation` string on
every Phrase.

---

## Grammar Code Format

GrammarCodes is a List<string> where each element is one tag:

Parts of speech:  V, N, ART, PRON, ADJ, ADV, PREP, CONJ, PART
Tense:            PRES, IMPF, AOR, PERF, PLPF, FUT
Voice:            ACT, MID, PASS, MP (middle-passive)
Mood:             IND, SUBJ, OPT, IMP, INF, PTCP
Person:           1P, 2P, 3P
Number:           S, P
Gender:           M, F, N
Case:             NOM, GEN, DAT, ACC, VOC

Order: POS, then for verbs [Tense, Voice, Mood, Person, Number],
       for nominals [Case, Gender, Number].
       For participles: [Tense, Voice, PTCP, Case, Gender, Number].

---

## Translation Guidelines

- Use a formal equivalence style (similar to ESV or NASB).
- Phrase Translations should be minimal and literal (good for interlinear reading).
- Top-level clause Translations should be full readable English.
- Preserve Greek word order in the Translation where it does not obscure meaning.
- For the `Translation` field on NOUN_PHRASE: use the article + noun in English
  (e.g., "the life", "our joy", "the Father").

---

## Output Format

Return ONLY valid C# code with NO markdown fences and NO explanation text.
The output should be the entire static method body for the requested chapter,
following the exact naming pattern:

```
private static List<object> GetChapter{N}()
{
    // {BookName} {Chapter}:{verse range}
    return new List<object>
    {
        ...
    };
}
```

Include one top-level comment per verse: `// Verse {N}` before its first Phrase.
If a verse continues a sentence from the previous verse (e.g., the long sentence
in 1 John 1:1-4), nest the continuation inside the same enclosing Phrase and
add a comment `// (continues verse {N})`.

---

## Token Data

<token_data>
PASTE YOUR JSON OUTPUT FROM parse_opengnt.py HERE
</token_data>

---

## Additional Instructions

1. Every word in the token data must appear in the output exactly once.
2. Do not invent words that are not in the token data.
3. Greek field: use the `greek` value from the JSON (this is the accented form).
4. Transliteration field: use the `transliteration` value from the JSON.
5. Gloss field: use the `gloss` value from the JSON; if it is empty or unhelpful
   (e.g., just a Strong's number), provide a standard English gloss for the lemma.
6. GrammarCodes: start from the `grammar_codes` array in the JSON, but correct
   obvious RMAC parsing errors based on your knowledge of the word's actual form.
7. For PartOfSpeech, use the `part_of_speech` value from the JSON.
8. The clause_id field in the JSON can help you identify clause boundaries —
   words sharing the same clause_id belong to the same clause.
9. When in doubt about phrase grouping, prefer shallower nesting over deeper.
10. After the method body, add a brief comment block listing any constructions
    you identified (TSKS, GEN_ABS, PERIPH, etc.) with their verse references.
"""

# =================================================================
# USAGE NOTES FOR MULTI-CHAPTER BOOKS
# =================================================================
# After generating Chapter 1, you can generate subsequent chapters
# by adding this additional instruction to the prompt:
#
#   "The style of the previously generated GetChapter1() method is
#    the canonical reference. Match its indentation, comment style,
#    and Translation register exactly."
#
# For a full book, generate chapters one at a time and collect the
# static methods, then wrap them all in the outer class manually:
#
#   public static class {BookName}TextData
#   {
#       public static Dictionary<int, List<object>> GetChapters() { ... }
#       private static List<object> GetChapter1() { ... }
#       private static List<object> GetChapter2() { ... }
#       ...
#   }
#
# =================================================================
# PROMPT FOR GENERATING THE GetChapters() DISPATCHER
# =================================================================
# Once all chapter methods are generated, ask Claude:
#
#   "Given these chapter method signatures: GetChapter1() through
#    GetChapter{N}(), write the GetChapters() dispatcher method and
#    the full outer class wrapper for {BookName}TextData, following
#    the FirstJohnTextData style exactly."
# =================================================================
