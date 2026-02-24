# AI Prompt: Generate C# Hebrew OT Seed Data File from OSHB Token JSON
# ====================================================================
# HOW TO USE THIS PROMPT
# ----------------------
# 1. Run parse_oshb.py to extract token JSON for your target book/chapter.
# 2. Open a new Claude conversation.
# 3. Paste this USER_PROMPT, then paste your JSON at the bottom
#    inside the <token_data> block.
# 4. Claude will return a complete C# seed data file for that chapter.
# ====================================================================

SYSTEM_PROMPT = """
You are a biblical Hebrew scholar and senior C# developer producing seed data
for a Hebrew Old Testament study app. Your output is always valid, compilable
C# code following the exact patterns in the reference class provided.
"""

USER_PROMPT = """
## Task

Generate a complete C# seed data file for the chapter described in the token
data below. The file must match the style, structure, and naming conventions
of the Greek reference class, adapted for Hebrew.

---

## Reference C# Models (already defined in the project)

```csharp
public class Word
{
    public string Hebrew { get; set; } = string.Empty;       // replaces Greek
    public string Transliteration { get; set; } = string.Empty;
    public string Gloss { get; set; } = string.Empty;
    public List<string> GrammarCodes { get; set; } = new();
    public string PartOfSpeech { get; set; } = string.Empty;
}

public class Phrase
{
    public List<string> SyntaxCodes { get; set; } = new();
    public List<object> Content { get; set; } = new();
    public string Translation { get; set; } = string.Empty;
}
```

---

## Hebrew Phrase Grouping Rules

**Clause-level containers (top-level SyntaxCodes)**
- `INDEP_CLAUSE` — main/independent clause (wayyiqtol narrative chain)
- `DEP_CLAUSE` — generic subordinate clause
- `REL_CLAUSE` — relative clause (introduced by אֲשֶׁר or שֶׁ)
- `PURPOSE_CLAUSE` — לְמַעַן / לְ + inf.construct
- `RESULT_CLAUSE` — result/consequence
- `COND_CLAUSE` — conditional (אִם / לוּ)
- `TEMP_CLAUSE` — temporal (כַּאֲשֶׁר, בְּ + inf.construct)
- `CAUSAL_CLAUSE` — causal (כִּי, יַעַן)

**Phrase-level containers**
- `NOUN_PHRASE` — noun ± article ± adjective ± genitive construct chain
- `CONST_CHAIN` — construct chain (nomen regens + nomen rectum)
- `PREP_PHRASE` — preposition + object
- `VERB_PHRASE` — verb + complements
- `PTCP_PHRASE` — participial phrase
- `INF_PHRASE` — infinitive construct phrase

**Functional labels (add as second SyntaxCode on noun phrases)**
- `SUBJ`, `OBJ`, `IND_OBJ`, `PRED`, `APPOS`, `VOC`

**Special construction labels**
- `WAYYIQTOL` — wayyiqtol (narrative preterite) — add to INDEP_CLAUSE
- `CASUS_PEND` — casus pendens (hanging nominative / extraposition)
- `INF_ABS_INT` — infinitive absolute for intensification (נָפַל יִפּוֹל)
- `CHIASM` — chiastic structure (note in the Notes comment)
- `HENDIADYS` — two nouns/verbs expressing one concept (note which words)

---

## Hebrew Grammar Code Format

GrammarCodes is a List<string> using these tags:

Parts of speech:
  V         = verb (generic; use stem below to distinguish)
  N         = common noun
  N_PROPER  = proper noun
  ADJ       = adjective
  ADV       = adverb
  PRON_PERS = personal pronoun
  PRON_REL  = relative pronoun
  PRON_DEM  = demonstrative pronoun
  PRON_INTERROG = interrogative pronoun
  PREP      = preposition
  CONJ_COORD = coordinating conjunction (וְ, אוֹ)
  CONJ_SUB  = subordinating conjunction (כִּי, אֲשֶׁר)
  ART       = definite article
  NEG       = negation particle (לֹא, אַל)
  INTERJ    = interjection

Verb stems:
  QAL, NIPH, PIEL, PUAL, HIPH, HOPH, HITH

Verb conjugations:
  PERF, IMPF, IMP, INF_CONST, INF_ABS, PTCP_ACT, PTCP_PASS
  WAYYIQTOL (shorthand for IMPF+waw-consecutive in narrative)

Person:     1P, 2P, 3P
Gender:     M, F, C (common)
Number:     S, P, DUAL
State:      ABS (absolute), CONST (construct), DET (determined/with article)

Order for verbs:   [Stem, Conjugation, Person, Gender, Number]
Order for nominals:[POS, Gender, Number, State]
                   (Article and attached prepositions are noted in grammar codes
                   or as sibling Word nodes)

---

## Handling Hebrew-Specific Features

**Attached prefixes and suffixes**: In OSHB data each fully pointed word is one
token, including its attached preposition (בְּ, לְ, מִ, כְּ) and conjunction (וְ).
When a token clearly has an inseparable prefix, split it into two Word nodes:
  - one for the prefix (PREP or CONJ_COORD), Hebrew = the prefix letter
  - one for the main word
Label the pair inside a PREP_PHRASE or simply list them sequentially if no
grouping is needed.

**Construct chains**: Group nomen regens + nomen rectum in a CONST_CHAIN phrase.

**Pronominal suffixes**: If a noun or verb carries a pronominal suffix, add a
grammar code like `SUFF_3MS` (suffix, 3rd person masculine singular) to the
Word's GrammarCodes, and include the English pronoun in the Gloss.

**Wayyiqtol narrative**: Each new wayyiqtol clause starts a fresh INDEP_CLAUSE
with SyntaxCode `WAYYIQTOL`. Add a line comment `// Narrative chain`.

---

## Translation Guidelines

- Use formal equivalence style (similar to ESV or NASB).
- For narrative Hebrew (Ruth), keep translations crisp and story-like.
- Phrase translations should be minimal and literal.
- Top-level INDEP_CLAUSE translations should be readable English sentences.
- For CONST_CHAINs: translate as a natural English genitive.

---

## Output Format

Return ONLY valid C# code with NO markdown fences and NO explanation text.

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

Include `// Verse {N}` comment before each verse's first Phrase.
After the method, add a brief comment block noting any constructions identified
(WAYYIQTOL chains, CASUS_PEND, INF_ABS_INT, chiasms, etc.).

---

## Token Data

<token_data>
PASTE YOUR JSON OUTPUT FROM parse_oshb.py HERE
</token_data>

---

## Additional Instructions

1. Every Hebrew word in the token data must appear in the output exactly once.
2. Hebrew field: use the `hebrew` value from the JSON (fully pointed).
3. Transliteration field: use the `transliteration` value from the JSON;
   correct obvious errors using your knowledge of the word.
4. Gloss: use the `gloss` from the JSON; if empty, provide a standard BDB gloss
   for the word's root.
5. GrammarCodes: start from `grammar_codes` in the JSON and correct errors.
6. PartOfSpeech: derive from the morph code and your knowledge.
7. The `strongs` array in the JSON gives Strong's numbers for cross-reference.
8. When in doubt about phrase grouping, prefer shallower nesting.
"""

# ====================================================================
# DATASET NOTES FOR HEBREW
# ====================================================================
# Source:   Open Scriptures Hebrew Bible (openscriptures/morphhb)
# Text:     Westminster Leningrad Codex (WLC) — public domain
# Morph:    OSHB morphology — CC-BY 4.0
# License:  WLC = public domain
#           Lemma/morphology = CC-BY 4.0
#           Attribution: "Open Scriptures Hebrew Bible Project"
#           URL: https://github.com/openscriptures/morphhb
#
# NOTE ON STRONGS GLOSSES:
# parse_oshb.py includes only a small built-in glossary.
# For production use, supplement with:
#   - Hebrew Strongs Dictionary (public domain) from:
#     https://github.com/openscriptures/strongs
#   - Or the OSHB companion lexicon (morphhb/lexicon/)
#
# OPTIONAL ENRICHMENT:
# You can also layer in the STEPBible TAHOT dataset for richer
# semantic tags. It's CC-BY 4.0 and provides disambiguated
# Strong's, English glosses, and semantic domains.
# Source: https://github.com/STEPBible/STEPBible-Data
# File:   TAHOT - Translators Amalgamated Hebrew OT
# ====================================================================
