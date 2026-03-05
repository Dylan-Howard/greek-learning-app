# GNT Seed Data Generation Workflow
## From OpenGNT → C# Seed Files Matching Your App's Style

---

### Overview

This toolkit turns OpenGNT token data into C# seed data files that match
the `FirstJohnTextData.cs` pattern in your app. The process has two steps:

1. **`greek-nt/parse_opengnt.py`** — Downloads and parses the OpenGNT dataset into
   a structured JSON file (one per chapter or book).
2. **`ai_seeding_prompt.py`** — Contains a detailed prompt you paste into
   Claude along with the JSON to generate the final C# code.

---

### Step 1 — Extract Token Data

```bash
pip install requests tqdm

# Extract 1 John Chapter 1
python parse_opengnt.py --book 62 --chapter 1 --out 1john_ch1.json

# Extract all of 1 John
python parse_opengnt.py --book 62 --out 1john_all.json

# Extract Romans Chapter 8
python parse_opengnt.py --book 45 --chapter 8 --out rom8.json
```

The script downloads the OpenGNT zip (~30MB) once and caches it locally as
`opengnt_keyedFeatures_cache.zip`. Subsequent runs use the cache.

**Book numbers:**
```
40=Matt  41=Mark  42=Luke  43=John  44=Acts
45=Rom   46=1Cor  47=2Cor  48=Gal   49=Eph
50=Phil  51=Col   52=1Th   53=2Th   54=1Tim
55=2Tim  56=Tit   57=Phlm  58=Heb   59=Jas
60=1Pet  61=2Pet  62=1Jn   63=2Jn   64=3Jn
65=Jude  66=Rev
```

---

### Step 2 — Generate C# Seed Code with AI

1. Open `ai_seeding_prompt.py` and copy the `USER_PROMPT` string.
2. Start a new Claude conversation.
3. Paste the prompt.
4. At the bottom, inside `<token_data>...</token_data>`, paste the
   contents of the JSON file generated in Step 1.
5. Claude returns a `GetChapter{N}()` method body.

**For large chapters (100+ tokens):** Process in verse ranges if needed.
Add to the prompt: *"Generate only verses 1–10 of this chapter."*

---

### Step 3 — Compile Book-Level Wrappers Deterministically

Use the wrapper compiler to merge chapter-range snippets into a single
book seed class (no AI wrapper prompt needed):

```bash
python3 data/scripts/compile_book_wrappers.py \
  --input-dir data/output/csharp \
  --fallback-log-dir data/output/logs \
  --book 1John \
  --output backend/src/Koine.Infrastructure/Data/Seed/FirstJohnTextData.cs \
  --namespace Koine.Infrastructure.Data.Seed \
  --class-name FirstJohnTextData
```

What it does:
- Finds `BookChapter{N}_v{start}-{end}.cs` snippets.
- Sorts/merges them into `GetChapter{N}()` methods.
- Builds `GetChapters()` automatically.
- Generates `GetVocabulary()` from unique `new Word { Greek = ... }` entries.
- Uses `*_response.txt` fallback snippets when a `.cs` snippet is malformed.

Optional validation mode:

```bash
python3 data/scripts/compile_book_wrappers.py \
  --input-dir data/output/csharp \
  --fallback-log-dir data/output/logs \
  --book 1John \
  --output /tmp/FirstJohnTextData.generated.cs \
  --dry-run
```

If malformed snippets are found, the script warns and skips those ranges.
Use the warning output to regenerate/fix the affected chapter files.

---

### What the AI Produces

For each chapter, Claude will:

- Group words into nested `Phrase` objects with appropriate `SyntaxCodes`
- Label constructions like `TSKS` (Granville-Sharp), `GEN_ABS`, `PERIPH`,
  `DAT_INSTR`, etc.
- Write `Translation` strings at both phrase and clause level
- Preserve all Greek, transliteration, gloss, and grammar data from OpenGNT
- Add verse comments and a construction summary at the end

---

### Quality Tips

- **Review GrammarCodes** — The RMAC → grammar code conversion is mechanical.
  Cross-check unusual forms against a parsing guide like Mounce or Wallace.

- **Review phrase boundaries** — The AI makes intelligent groupings based on
  syntax rules, but some edge cases (especially long sentences spanning verses)
  benefit from a human review pass.

- **Supplement with construction detection** — For large-scale annotation of
  constructions (GS rule, genitive absolutes), consider also running the
  rule-based Python detectors described in the previous conversation.

- **OpenGNT vs NA28** — OGNT differs from NA28 in only ~61 main words and
  ~3 verse word orders. See `/mapping_BGB/compare_OGNT_NA28/` in the OpenGNT
  repo for the exact diff list if textual precision matters for your app.

---

### License Note

OpenGNT is licensed CC-BY-SA 4.0. Attribute as:
> "Open Greek New Testament Project by Eliran Wong, https://github.com/eliranwong/OpenGNT"
