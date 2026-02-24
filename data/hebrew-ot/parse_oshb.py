"""
parse_oshb.py
=============
Downloads the Open Scriptures Hebrew Bible (OSHB) OSIS XML for a target book
and extracts per-verse token data into a structured JSON, suitable for feeding
into the Hebrew AI seeding prompt to generate C# seed data files.

Usage:
    python parse_oshb.py --book Ruth --out ruth_ch1.json --chapter 1
    python parse_oshb.py --book Ruth --out ruth_all.json

Dependencies:
    pip install requests lxml tqdm

OSHB Morphology Code Reference (abbreviated):
  H   = Hebrew word (prefix)
  A   = Aramaic word (prefix)

  Part of speech (pos codes):
    Np  = proper noun
    Nc  = common noun
    Vq  = verb (qal)
    Vn  = verb (niphal)
    Vp  = verb (piel)
    Vu  = verb (pual)
    Vh  = verb (hiphil)
    Vo  = verb (hophal)
    Vt  = verb (hithpael)
    Vq  = verb (qal)
    Vqp = verb qal perfect
    Vqi = verb qal imperfect
    Vqv = verb qal imperative
    Vqr = verb qal infinitive construct
    Vqs = verb qal infinitive absolute
    Vqh = verb qal participle active
    Pr  = relative pronoun
    Pp  = personal pronoun
    Pd  = demonstrative pronoun
    Pi  = interrogative pronoun
    Px  = indefinite pronoun
    Rd  = definite article (prefix, usually)
    Cc  = conjunction (coordinating)
    Cs  = conjunction (subordinating)
    Td  = definite article (independent)
    Sp  = preposition
    AdvN = negative adverb
    Adv = adverb

  For nouns/adjectives:
    gender: m = masculine, f = feminine, b = both
    number: s = singular, p = plural, d = dual
    state:  a = absolute, c = construct, d = determined

  For verbs:
    stem (see Vq etc above)
    conjugation: p = perfect, i = imperfect, v = imperative,
                 r = inf.construct, s = inf.absolute,
                 h = ptcp.active, p = ptcp.passive
    person: 1, 2, 3
    gender: m, f, c (common)
    number: s, p

OSHB Book Names (OSIS osisID format):
    Gen, Exod, Lev, Num, Deut, Josh, Judg, Ruth, 1Sam, 2Sam,
    1Kgs, 2Kgs, 1Chr, 2Chr, Ezra, Neh, Esth, Job, Ps, Prov,
    Eccl, Song, Isa, Jer, Lam, Ezek, Dan, Hos, Joel, Amos,
    Obad, Jonah, Mic, Nah, Hab, Zeph, Hag, Zech, Mal
"""

import argparse
import io
import json
import os
import re
import zipfile
from pathlib import Path

try:
    import requests
    from lxml import etree
    from tqdm import tqdm
    HAS_DEPS = True
except ImportError:
    HAS_DEPS = False
    print("Install deps: pip install requests lxml tqdm")


# OSHB GitHub raw base for individual book XML files
OSHB_BASE = (
    "https://raw.githubusercontent.com/openscriptures/morphhb/master/wlc/"
)
# Files are named like Ruth.xml, Gen.xml, etc.

CACHE_DIR = Path("oshb_cache")

# Strong's → brief gloss lookup for common words
# (Supplement with BDB/HALOT as needed; this covers ~top 100)
STRONGS_GLOSS = {
    "H1": "father", "H2": "father (poetic)", "H4": "he said", 
    "H120": "man/humankind", "H136": "Lord", "H430": "God/gods",
    "H559": "to say", "H802": "woman/wife", "H834": "who/which/that",
    "H1121": "son", "H1323": "daughter", "H1980": "to go/walk",
    "H2896": "good", "H3068": "LORD (YHWH)", "H3212": "to go",
    "H3588": "because/for/that", "H5869": "eye/spring",
    "H6030": "to answer", "H7121": "to call/read",
    "H7725": "to return/turn back", "H8085": "to hear/obey",
}

# OSHB morph → grammar code list
def oshb_morph_to_grammar_codes(morph: str) -> list:
    """
    Convert an OSHB morphology string like 'HVqp3ms' or 'HNcmsa'
    into a grammar code list matching your C# style.
    """
    if not morph:
        return []
    
    # Strip language prefix (H = Hebrew, A = Aramaic)
    m = morph.lstrip("HA")
    codes = []
    
    # Part of speech
    pos_map = {
        "Np": "N_PROPER", "Nc": "N", "Ng": "N_GEN_TITLE",
        "Vq": "V_QAL",    "Vn": "V_NIPH", "Vp": "V_PIEL",
        "Vu": "V_PUAL",   "Vh": "V_HIPH", "Vo": "V_HOPH",
        "Vt": "V_HITH",   "Vq": "V_QAL",
        "Pr": "PRON_REL", "Pp": "PRON_PERS", "Pd": "PRON_DEM",
        "Pi": "PRON_INTERROG", "Px": "PRON_INDEF",
        "Td": "ART",
        "Cc": "CONJ_COORD", "Cs": "CONJ_SUB",
        "Sp": "PREP",
        "Adv": "ADV", "AdvN": "NEG",
        "Aj": "ADJ",
    }
    
    # Try to match the POS prefix
    for key in sorted(pos_map.keys(), key=len, reverse=True):
        if m.startswith(key):
            codes.append(pos_map[key])
            m = m[len(key):]
            break
    
    # Remaining characters encode conjugation/person/gender/number/state
    # For verbs: conjugation (p/i/v/r/s/h/P), person (1/2/3), gender (m/f/c), number (s/p)
    # For nouns: gender (m/f/b), number (s/p/d), state (a/c/d)
    
    conj_map = {"p":"PERF","i":"IMPF","v":"IMP","r":"INF_CONST",
                "s":"INF_ABS","h":"PTCP_ACT","P":"PTCP_PASS"}
    num_map  = {"s":"S","p":"P","d":"DUAL"}
    gen_map  = {"m":"M","f":"F","c":"C","b":"B"}
    state_map= {"a":"ABS","c":"CONST","d":"DET"}
    per_map  = {"1":"1P","2":"2P","3":"3P"}
    
    for ch in m:
        if ch in conj_map:   codes.append(conj_map[ch])
        elif ch in per_map:  codes.append(per_map[ch])
        elif ch in gen_map:  codes.append(gen_map[ch])
        elif ch in num_map:  codes.append(num_map[ch])
        elif ch in state_map:codes.append(state_map[ch])
    
    return codes


def oshb_morph_to_pos(morph: str) -> str:
    """Coarse POS label from OSHB morph."""
    m = morph.lstrip("HA")
    if m.startswith("V"):    return "verb"
    if m.startswith("Np"):   return "proper noun"
    if m.startswith("Nc"):   return "noun"
    if m.startswith("Aj"):   return "adjective"
    if m.startswith("Adv"):  return "adverb"
    if m.startswith("Pp") or m.startswith("Pr") or m.startswith("Pd"):
        return "pronoun"
    if m.startswith("Sp"):   return "preposition"
    if m.startswith("Cc") or m.startswith("Cs"): return "conjunction"
    if m.startswith("Td"):   return "article"
    if m.startswith("Ne"):   return "negative particle"
    return "particle"


def download_book(book: str, cache: Path = CACHE_DIR) -> str:
    cache.mkdir(exist_ok=True)
    dest = cache / f"{book}.xml"
    if dest.exists():
        print(f"Using cached {dest}")
    else:
        url = OSHB_BASE + f"{book}.xml"
        print(f"Downloading {url}...")
        resp = requests.get(url, timeout=30)
        resp.raise_for_status()
        dest.write_text(resp.text, encoding="utf-8")
        print(f"Saved to {dest}")
    return dest.read_text(encoding="utf-8")


OSIS_NS = "http://www.bibletechnologies.net/2003/OSIS/namespace"

def extract_tokens(xml_text: str, target_chapter: int | None = None) -> dict:
    """
    Parse OSHB OSIS XML and return:
      { chapter_num: { verse_num: [ token_dict, ... ] } }
    """
    root = etree.fromstring(xml_text.encode("utf-8"))
    ns = {"o": OSIS_NS}
    
    results: dict[int, dict[int, list]] = {}
    
    # Verses are <verse> elements with osisID like "Ruth.1.1"
    for verse_el in root.iter(f"{{{OSIS_NS}}}verse"):
        osisID = verse_el.get("osisID", "")
        if not osisID:
            continue
        
        parts = osisID.split(".")
        if len(parts) < 3:
            continue
        
        try:
            chapter = int(parts[1])
            verse   = int(parts[2])
        except ValueError:
            continue
        
        if target_chapter is not None and chapter != target_chapter:
            continue
        
        tokens = []
        word_pos = 1
        
        for w_el in verse_el.iter(f"{{{OSIS_NS}}}w"):
            hebrew   = w_el.text or ""
            # The 'lemma' attribute contains Strong's number(s): "strong:H7725"
            lemma_raw = w_el.get("lemma", "")
            morph_raw = w_el.get("morph", "")
            word_id   = w_el.get("id", "")
            
            # Parse Strong's
            strongs = []
            for part in lemma_raw.split():
                if part.startswith("strong:"):
                    strongs.append(part[7:])
            
            # Parse morphology (may be space-separated for compound forms)
            morphs = morph_raw.replace("strongMorph:", "").replace("oshb:", "").split()
            primary_morph = morphs[0] if morphs else ""
            
            # Gloss from Strong's lookup
            gloss = ""
            for s in strongs:
                if s in STRONGS_GLOSS:
                    gloss = STRONGS_GLOSS[s]
                    break
            
            # Transliteration (simple approximation)
            translit = simple_translit(hebrew)
            
            token = {
                "book":           parts[0],
                "chapter":        chapter,
                "verse":          verse,
                "word_pos":       word_pos,
                "hebrew":         hebrew,
                "transliteration": translit,
                "strongs":        strongs,
                "lemma_raw":      lemma_raw,
                "morph":          primary_morph,
                "all_morph":      morphs,
                "grammar_codes":  oshb_morph_to_grammar_codes(primary_morph),
                "part_of_speech": oshb_morph_to_pos(primary_morph),
                "gloss":          gloss,
                "word_id":        word_id,
            }
            tokens.append(token)
            word_pos += 1
        
        results.setdefault(chapter, {}).setdefault(verse, []).extend(tokens)
    
    return results


# ── Simple Hebrew → SBL-style transliteration ─────────────────────────────────
# Covers the most common characters for display purposes.
# For production use, consider a full SBL transliteration library.
_TRANSLIT = {
    "א":"ʾ",  "ב":"b",  "ג":"g",  "ד":"d",  "ה":"h",
    "ו":"w",  "ז":"z",  "ח":"ḥ",  "ט":"ṭ",  "י":"y",
    "כ":"k",  "ך":"k",  "ל":"l",  "מ":"m",  "ם":"m",
    "נ":"n",  "ן":"n",  "ס":"s",  "ע":"ʿ",  "פ":"p",
    "ף":"p",  "צ":"ṣ",  "ץ":"ṣ",  "ק":"q",  "ר":"r",
    "שׁ":"š", "שׂ":"ś", "ש":"š",  "ת":"t",
    # Basic vowels (nikud)
    "\u05B0":"ǝ", "\u05B1":"ě", "\u05B2":"ă", "\u05B3":"ŏ",
    "\u05B4":"i",  "\u05B5":"e", "\u05B6":"e", "\u05B7":"a",
    "\u05B8":"ā",  "\u05B9":"o", "\u05BA":"o", "\u05BB":"u",
    "\u05BC":"", # dagesh — ignored for simplicity
    "\u05BE":"-",  # maqef
}

def simple_translit(hebrew: str) -> str:
    result = []
    i = 0
    while i < len(hebrew):
        # Try two-char match first (shin with dagesh)
        two = hebrew[i:i+2]
        if two in _TRANSLIT:
            result.append(_TRANSLIT[two])
            i += 2
            continue
        ch = hebrew[i]
        result.append(_TRANSLIT.get(ch, ""))
        i += 1
    return "".join(result).strip("-")


def build_output(tokens: dict, book: str, chapter: int | None) -> dict:
    return {
        "meta": {
            "book_name":     book,
            "chapter_filter": chapter,
            "text_source":   "Westminster Leningrad Codex (WLC) — public domain",
            "morph_source":  "Open Scriptures Hebrew Bible Project (openscriptures/morphhb) — CC-BY 4.0",
            "note": (
                "Feed the 'chapters' data into the Hebrew AI seeding prompt "
                "to generate a C# seed data file for your Hebrew OT app."
            ),
        },
        "chapters": {
            str(ch): {
                str(vs): verses
                for vs, verses in chapter_data.items()
            }
            for ch, chapter_data in sorted(tokens.items())
        },
    }


def main():
    parser = argparse.ArgumentParser(
        description="Extract OSHB token data for a book/chapter into JSON."
    )
    parser.add_argument("--book",    type=str, default="Ruth",
                        help="OSHB book name (default: Ruth). E.g. Gen, Exod, Ps")
    parser.add_argument("--chapter", type=int, default=None,
                        help="Chapter number (omit for all chapters)")
    parser.add_argument("--out",     type=str, default=None,
                        help="Output JSON path")
    parser.add_argument("--cache",   type=str, default=str(CACHE_DIR),
                        help="Directory for cached XML files")
    args = parser.parse_args()

    if not HAS_DEPS:
        print("Please install: pip install requests lxml tqdm")
        return

    global CACHE_DIR
    CACHE_DIR = Path(args.cache)
    
    xml_text = download_book(args.book)
    
    print(f"Extracting {args.book}, chapter={args.chapter}...")
    tokens = extract_tokens(xml_text, args.chapter)

    total = sum(
        len(vv) for ch in tokens.values() for vv in ch.values()
    )
    verse_count = sum(len(ch) for ch in tokens.values())
    print(f"Extracted {total} tokens across {verse_count} verses.")

    output = build_output(tokens, args.book, args.chapter)

    if args.out is None:
        ch_str = f"_ch{args.chapter}" if args.chapter else ""
        args.out = f"{args.book.lower()}{ch_str}_tokens.json"

    with open(args.out, "w", encoding="utf-8") as f:
        json.dump(output, f, ensure_ascii=False, indent=2)
    print(f"Written to {args.out}")
    print()
    print("Next step: paste the JSON into the Hebrew AI seeding prompt.")


if __name__ == "__main__":
    main()
