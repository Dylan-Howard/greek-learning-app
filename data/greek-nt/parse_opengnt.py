"""
parse_opengnt.py
================
Downloads the OpenGNT keyed features CSV and extracts per-verse token data
for a target book, then outputs structured JSON for the AI seeding prompt.

Usage:
    python parse_opengnt.py --book 62 --chapter 1 --out 1john_ch1.json
    python parse_opengnt.py --book 64 --out 3john.json
    python parse_opengnt.py --book 62 --chapter 1 --out debug.json --debug

Book numbers:
    40=Matt, 41=Mark, 42=Luke, 43=John, 44=Acts,
    45=Rom,  46=1Cor, 47=2Cor, 48=Gal,  49=Eph,
    50=Phil, 51=Col,  52=1Th,  53=2Th,  54=1Tim,
    55=2Tim, 56=Tit,  57=Phlm, 58=Heb,  59=Jas,
    60=1Pet, 61=2Pet, 62=1Jn,  63=2Jn,  64=3Jn,
    65=Jude, 66=Rev

Confirmed file structure (TAB-delimited, 11 columns):
    [0]  FEATURESsort1
    [1]  FEATURESsort2
    [2]  mapIDV2
    [3]  mapIDV1
    [4]  BCV       -- e.g. 40|1|1
    [5]  SORT_IDS  -- e.g. 000001|000001|40.1.1.w1
    [6]  LEVINSON  -- e.g. 40.1.1!1|noteMarker||clause|clauseID|otQ|rSp|erSp
    [7]  TANTT     -- e.g. BIMNRSTWH=Greek=G0976=N-NSF;
    [8]  GLOSS     -- e.g. MounceGloss|TyndaleGloss|OpenGNTGloss
    [9]  BGBsort   -- e.g. 1|1|1
    [10] TBESG     -- e.g. TBESG|IT|LT|ST|Espanol

All compound cells are wrapped in Japanese lenticular brackets and use the
fullwidth vertical line (U+FF5C) as the inner separator.
"""

import argparse
import csv
import io
import json
import os
import re
import zipfile
from pathlib import Path

try:
    import requests
    from tqdm import tqdm
    HAS_DEPS = True
except ImportError:
    HAS_DEPS = False
    print("Install deps first: pip install requests tqdm")

OPENGNT_URL = (
    "https://github.com/eliranwong/OpenGNT/raw/master/"
    "OpenGNT_keyedFeatures.csv.zip"
)
CACHE_PATH = (
    Path(os.environ.get("CACHE_DIR", "/app/cache"))
    / "opengnt_keyedFeatures_cache.zip"
)

# Hard-coded column indices from confirmed file layout
COL_BCV      = 4
COL_LEVINSON = 6
COL_TANTT    = 7
COL_GLOSS    = 8

# Fullwidth vertical line U+FF5C used as inner separator
PIPE = "\uff5c"

# Japanese lenticular bracket wrappers U+3014 / U+3015
LBRACKET = "\u3014"
RBRACKET = "\u3015"


def unwrap(val):
    """Strip lenticular bracket wrappers if present."""
    val = val.strip()
    if val.startswith(LBRACKET) and val.endswith(RBRACKET):
        return val[1:-1]
    return val


def split_cell(val):
    """Unwrap and split a compound cell on the fullwidth pipe."""
    return unwrap(val).split(PIPE)


def parse_tantt(raw):
    """
    Parse a TANTT cell, e.g.:
        BIMNRSTWH=Biblios=G0976=N-NSF;
    Returns (greek, strongs, rmac).
    Multiple semicolon-delimited variants may be present; we use the first.
    """
    content = unwrap(raw).strip()
    # Take the first semicolon-delimited entry
    entry = content.split(";")[0].strip()
    parts = entry.split("=")
    greek   = parts[1].strip() if len(parts) > 1 else ""
    strongs = parts[2].strip() if len(parts) > 2 else ""
    rmac    = parts[3].strip() if len(parts) > 3 else ""
    return greek, strongs, rmac


def rmac_to_pos(rmac):
    if not rmac:
        return "unknown"
    # Strip dashes before matching so "R-NSN" -> "RNSN" matches "R" for pronoun
    code = rmac.upper().replace("-", "")
    prefixes = [
        ("RA", "article"),       ("RD", "pronoun"),      ("RI", "pronoun"),
        ("RP", "pronoun"),       ("RR", "pronoun"),       ("R",  "pronoun"),
        ("V",  "verb"),          ("N",  "noun"),           ("A",  "adjective"),
        ("D",  "adverb"),        ("CONJ", "conjunction"),  ("COND", "conjunction"),
        ("PRT",  "particle"),    ("PREP", "preposition"),  ("INJ", "interjection"),
    ]
    for prefix, pos in prefixes:
        if code.startswith(prefix):
            return pos
    return "unknown"


# Nominal suffix expansion: "NSN" -> ["NOM", "N", "S"]
_CASE   = {"N": "NOM", "G": "GEN", "D": "DAT", "A": "ACC", "V": "VOC"}
_GENDER = {"M": "M",   "F": "F",   "N": "N"}
_NUMBER = {"S": "S",   "P": "P",   "D": "DUAL"}
_PERSON = {"1": "1P",  "2": "2P",  "3": "3P"}
_TENSE  = {"P": "PRES", "I": "IMPF", "F": "FUT",  "A": "AOR",
            "R": "PERF", "L": "PLPF", "X": "PERF", "Y": "PLPF"}  # R/L = standard RMAC perfect/pluperfect
_VOICE  = {"A": "ACT",  "M": "MID",  "P": "PASS", "E": "MID", "D": "MID", "N": "MID"}  # N = deponent/middle in V-PNI
_MOOD   = {"I": "IND",  "S": "SUBJ", "O": "OPT",  "M": "IMP",
            "N": "INF",  "P": "PTCP"}

_POS_TAG = {
    "N": "N",     "V": "V",     "A": "ADJ",   "D": "ADV",
    "RA": "ART",  "RD": "PRON", "RI": "PRON", "RP": "PRON",
    "RR": "PRON", "R":  "PRON", "CONJ": "CONJ", "COND": "CONJ",
    "PRT": "PART", "PREP": "PREP", "INJ": "INTERJ",
}


def _expand_nominal(suffix):
    """Expand a 3-char nominal suffix like NSN/GSF/DMP into [case, gender, number]."""
    if len(suffix) == 3:
        case   = _CASE.get(suffix[0])
        number = _NUMBER.get(suffix[1])
        gender = _GENDER.get(suffix[2])
        if case and number and gender:
            return [case, gender, number]
    return [suffix]


def rmac_to_grammar_codes(rmac):
    """
    Convert RMAC to grammar code list matching FirstJohnTextData.cs style.

    Examples:
        "R-NSN"     -> ["PRON", "NOM", "N", "S"]
        "N-NSF"     -> ["N",    "NOM", "F", "S"]
        "V-AAI-3S"  -> ["V",    "AOR", "ACT", "IND", "3P", "S"]
        "V-PAPNSM"  -> ["V",    "PRES", "ACT", "PTCP", "NOM", "M", "S"]
        "CONJ"      -> ["CONJ"]
        "PREP"      -> ["PREP"]
    """
    if not rmac:
        return []

    parts = [p for p in rmac.upper().split("-") if p]
    if not parts:
        return []

    pos_raw = parts[0]
    pos_tag = next(
        (_POS_TAG[k] for k in sorted(_POS_TAG, key=len, reverse=True)
         if pos_raw.startswith(k)),
        pos_raw
    )
    codes = [pos_tag]

    if len(parts) == 1:
        return codes  # indeclinable word

    if pos_tag == "V":
        tvm = parts[1]
        if tvm and tvm[0].isdigit():  # strip 2nd-aorist/perfect prefix e.g. "2RAI" -> "RAI"
            tvm = tvm[1:]
        # Participle cluster is 6 chars: tense+voice+P+case+num+gender (e.g. PAPNSM)
        # Participle clusters are always exactly 6 chars AND mood char (pos 2) is "P"
        # AND the last 3 chars form a valid nominal suffix (case+num+gender).
        # Finite verbs like XAPI have "P" at pos 2 as mood but are only 4 chars,
        # so length check guards against false positives.
        is_participle = (
            len(tvm) == 6
            and tvm[2] == "P"
            and tvm[3] in _CASE
            and tvm[4] in _NUMBER
            and tvm[5] in _GENDER
        )
        if is_participle:
            codes += [_TENSE.get(tvm[0], tvm[0]), _VOICE.get(tvm[1], tvm[1]), "PTCP"]
            codes += _expand_nominal(tvm[3:6])
        else:
            # Finite verb: 3-char tense-voice-mood (e.g. AAI)
            if len(tvm) > 0: codes.append(_TENSE.get(tvm[0], tvm[0]))
            if len(tvm) > 1: codes.append(_VOICE.get(tvm[1], tvm[1]))
            if len(tvm) > 2: codes.append(_MOOD.get(tvm[2],  tvm[2]))
            if len(parts) > 2:
                pn = parts[2]
                # Participle with separate case suffix e.g. V-RPP-NSF: parts[2]="NSF"
                if len(pn) == 3 and pn[0] in _CASE and pn[1] in _NUMBER and pn[2] in _GENDER:
                    codes += _expand_nominal(pn)
                else:
                    # Finite verb person+number e.g. "3S", "1P"
                    if len(pn) > 0: codes.append(_PERSON.get(pn[0], pn[0]))
                    if len(pn) > 1: codes.append(_NUMBER.get(pn[1], pn[1]))
    else:
        # Nominal: parts[1] is the case+number+gender cluster
        codes += _expand_nominal(parts[1])

    return codes


def download_with_progress(url, dest):
    dest.parent.mkdir(parents=True, exist_ok=True)
    resp = requests.get(url, stream=True, timeout=120)
    resp.raise_for_status()
    total = int(resp.headers.get("content-length", 0))
    with open(dest, "wb") as f, tqdm(
        total=total, unit="B", unit_scale=True, desc="Downloading OpenGNT"
    ) as bar:
        for chunk in resp.iter_content(chunk_size=8192):
            f.write(chunk)
            bar.update(len(chunk))


def load_opengnt(cache=CACHE_PATH):
    if not cache.exists():
        print("Cache not found. Downloading from GitHub...")
        download_with_progress(OPENGNT_URL, cache)
    else:
        print(f"Using cached file: {cache}")
    with zipfile.ZipFile(cache) as zf:
        name = [n for n in zf.namelist() if n.endswith(".csv")][0]
        print(f"Reading {name} from zip...")
        return io.StringIO(zf.read(name).decode("utf-8"))


def extract_tokens(fh, target_book, target_chapter=None, debug=False):
    fh.seek(0)
    reader = csv.reader(fh, delimiter="\t")
    headers = next(reader)

    print(f"Detected {len(headers)} columns.")

    if debug:
        print("\n=== HEADERS ===")
        for i, h in enumerate(headers):
            print(f"  [{i:02d}] {repr(h)}")
        first_row = next(reader)
        print("\n=== FIRST DATA ROW (header -> value) ===")
        for i, (h, v) in enumerate(zip(headers, first_row)):
            print(f"  [{i:02d}] {repr(h):<50} -> {repr(v)}")
        # Show parsed TANTT for the first row
        greek, strongs, rmac = parse_tantt(first_row[COL_TANTT])
        print(f"\n  TANTT parsed: greek={repr(greek)} strongs={repr(strongs)} rmac={repr(rmac)}")
        gloss_parts = split_cell(first_row[COL_GLOSS])
        print(f"  GLOSS parts: {gloss_parts}")
        print("=== END DEBUG ===\n")
        # Restart
        fh.seek(0)
        reader = csv.reader(fh, delimiter="\t")
        next(reader)

    results = {}
    word_counters = {}

    for row in reader:
        if not row or len(row) <= COL_TANTT:
            continue

        # Parse book/chapter/verse
        try:
            bcv = split_cell(row[COL_BCV])
            book    = int(bcv[0])
            chapter = int(bcv[1])
            verse   = int(bcv[2])
        except (ValueError, IndexError):
            continue

        if book != target_book:
            continue
        if target_chapter is not None and chapter != target_chapter:
            continue

        # Increment word position counter
        bcv_key = (book, chapter, verse)
        word_counters[bcv_key] = word_counters.get(bcv_key, 0) + 1

        # Parse Greek word, Strong's, and RMAC from TANTT cell
        greek, strongs, rmac = parse_tantt(row[COL_TANTT])

        # Gloss: use OpenGNTGloss (last sub-value), fall back toward Mounce
        gloss_parts = split_cell(row[COL_GLOSS]) if len(row) > COL_GLOSS else []
        gloss = next((g for g in reversed(gloss_parts) if g.strip()), "")

        # Clause ID is sub-value index 4 inside the Levinson column
        clause_id = ""
        if len(row) > COL_LEVINSON:
            lev = split_cell(row[COL_LEVINSON])
            clause_id = lev[4] if len(lev) > 4 else ""

        token = {
            "book":            book,
            "chapter":         chapter,
            "verse":           verse,
            "word_pos":        word_counters[bcv_key],
            "greek":           greek,
            "transliteration": "",      # not present in this file
            "strongs":         strongs,
            "lemma":           strongs,
            "rmac":            rmac,
            "grammar_codes":   rmac_to_grammar_codes(rmac),
            "part_of_speech":  rmac_to_pos(rmac),
            "gloss":           gloss,
            "clause_id":       clause_id,
        }

        results.setdefault(chapter, {}).setdefault(verse, []).append(token)

    return results


BOOK_NAMES = {
    40: "Matthew",         41: "Mark",            42: "Luke",
    43: "John",            44: "Acts",            45: "Romans",
    46: "1 Corinthians",   47: "2 Corinthians",   48: "Galatians",
    49: "Ephesians",       50: "Philippians",     51: "Colossians",
    52: "1 Thessalonians", 53: "2 Thessalonians", 54: "1 Timothy",
    55: "2 Timothy",       56: "Titus",           57: "Philemon",
    58: "Hebrews",         59: "James",           60: "1 Peter",
    61: "2 Peter",         62: "1 John",          63: "2 John",
    64: "3 John",          65: "Jude",            66: "Revelation",
}


def build_output(tokens, book, chapter):
    return {
        "meta": {
            "book_number":    book,
            "book_name":      BOOK_NAMES.get(book, f"Book {book}"),
            "chapter_filter": chapter,
            "source":         "OpenGNT (eliranwong/OpenGNT) — CC-BY-SA 4.0",
            "note": (
                "Feed 'chapters' into the AI seeding prompt to generate "
                "a C# seed data file matching FirstJohnTextData.cs style."
            ),
        },
        "chapters": {
            str(ch): {str(vs): vv for vs, vv in sorted(ch_data.items())}
            for ch, ch_data in sorted(tokens.items())
        },
    }


def main():
    parser = argparse.ArgumentParser(
        description="Extract OpenGNT token data for a book/chapter into JSON."
    )
    parser.add_argument("--book",    type=int, default=62,
                        help="Book number (default: 62 = 1 John)")
    parser.add_argument("--chapter", type=int, default=None,
                        help="Chapter number (omit for all chapters)")
    parser.add_argument("--out",     type=str, default=None,
                        help="Output JSON path")
    parser.add_argument("--cache",   type=str, default=str(CACHE_PATH),
                        help="Path to cached zip file")
    parser.add_argument("--debug",   action="store_true",
                        help="Print header/first-row breakdown and TANTT parse result")
    args = parser.parse_args()

    if not HAS_DEPS:
        print("Please install: pip install requests tqdm")
        return

    fh = load_opengnt(Path(args.cache))

    print(f"Extracting book={args.book}, chapter={args.chapter}...")
    tokens = extract_tokens(fh, args.book, args.chapter, debug=args.debug)

    total  = sum(len(vv) for ch in tokens.values() for vv in ch.values())
    verses = sum(len(ch) for ch in tokens.values())
    print(f"Extracted {total} tokens across {verses} verses.")

    if total == 0:
        print("WARNING: 0 tokens extracted.")
        print("Run with --debug to inspect the raw column layout.")
        return

    if args.out is None:
        ch_str = f"_ch{args.chapter}" if args.chapter else ""
        args.out = f"book{args.book}{ch_str}_tokens.json"

    with open(args.out, "w", encoding="utf-8") as f:
        json.dump(build_output(tokens, args.book, args.chapter),
                  f, ensure_ascii=False, indent=2)
    print(f"Written to {args.out}")
    print("\nNext step: paste the JSON into the AI seeding prompt.")


if __name__ == "__main__":
    main()