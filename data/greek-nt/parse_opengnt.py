#!/usr/bin/env python3
"""
OpenGNT Parser with Verse Range Support

Parses OpenGNT token data and exports to JSON format compatible with
the AI seeding prompt for C# code generation.

Usage:
    python parse_opengnt.py --book 62 --chapter 1 --out output.json
    python parse_opengnt.py --book 62 --chapter 1 --start-verse 1 --end-verse 8 --out output.json
    python parse_opengnt.py --book 62 --out 1john_all.json

Requirements:
    pip install requests tqdm
"""

import argparse
import json
import os
import re
import sys
import zipfile
from io import BytesIO
from pathlib import Path
from typing import Dict, List, Optional

try:
    import requests
    from tqdm import tqdm
except ImportError:
    print("Error: Required packages not installed.")
    print("Run: pip install requests tqdm")
    sys.exit(1)


# OpenGNT data URL - Updated location
OPENGNT_URL = "https://github.com/eliranwong/OpenGNT/raw/master/OpenGNT_keyedFeatures.csv.zip"
CACHE_FILE = "opengnt_keyedFeatures_cache.zip"

# Book number to name mapping
BOOK_NAMES = {
    40: "Matthew", 41: "Mark", 42: "Luke", 43: "John", 44: "Acts",
    45: "Romans", 46: "1 Corinthians", 47: "2 Corinthians", 48: "Galatians", 49: "Ephesians",
    50: "Philippians", 51: "Colossians", 52: "1 Thessalonians", 53: "2 Thessalonians", 54: "1 Timothy",
    55: "2 Timothy", 56: "Titus", 57: "Philemon", 58: "Hebrews", 59: "James",
    60: "1 Peter", 61: "2 Peter", 62: "1 John", 63: "2 John", 64: "3 John",
    65: "Jude", 66: "Revelation"
}

# RMAC to Grammar Code mapping
GRAMMAR_MAP = {
    'N': 'N',           # Noun
    'V': 'V',           # Verb
    'T': 'ART',         # Article
    'R': 'PRON',        # Pronoun
    'A': 'ADJ',         # Adjective
    'D': 'ADV',         # Adverb
    'P': 'PREP',        # Preposition
    'C': 'CONJ',        # Conjunction
    'I': 'INTERJ',      # Interjection
    'X': 'PART',        # Particle
}


def download_opengnt(force=False):
    """Download and cache the OpenGNT zip file"""
    cache_path = Path(CACHE_FILE)
    
    if cache_path.exists() and not force:
        print(f"✓ Using cached OpenGNT data: {CACHE_FILE}")
        return cache_path
    
    # The OpenGNT repository may provide either a zip (preferred) or a raw TSV/CSV.
    print(f"📥 Downloading OpenGNT data from GitHub...")
    
    # Try to download the TSV file directly
    urls = [
        # Zip file (current canonical location on master)
        "https://raw.githubusercontent.com/eliranwong/OpenGNT/master/OpenGNT_keyedFeatures.csv.zip",
        "https://github.com/eliranwong/OpenGNT/raw/master/OpenGNT_keyedFeatures.csv.zip",
        # Fallbacks (legacy raw TSV)
        "https://raw.githubusercontent.com/eliranwong/OpenGNT/main/opengnt_keyedFeatures.txt",
        "https://github.com/eliranwong/OpenGNT/raw/main/opengnt_keyedFeatures.txt",
        "https://raw.githubusercontent.com/eliranwong/OpenGNT/master/opengnt_keyedFeatures.txt",
        "https://github.com/eliranwong/OpenGNT/raw/master/opengnt_keyedFeatures.txt",
    ]
    
    for i, url in enumerate(urls, 1):
        print(f"   Attempt {i}/{len(urls)}: {url}")
        
        try:
            response = requests.get(url, stream=True, timeout=30)
            response.raise_for_status()
            
            total_size = int(response.headers.get('content-length', 0))

            if url.lower().endswith(".zip"):
                # Save zip directly
                with open(cache_path, 'wb') as f, tqdm(
                    desc="Downloading",
                    total=total_size,
                    unit='B',
                    unit_scale=True,
                    unit_divisor=1024,
                ) as pbar:
                    for chunk in response.iter_content(chunk_size=8192):
                        f.write(chunk)
                        pbar.update(len(chunk))
            else:
                # Save as TSV/CSV directly, then create a zip wrapper
                tsv_file = cache_path.parent / "opengnt_keyedFeatures.txt"
                with open(tsv_file, 'wb') as f, tqdm(
                    desc="Downloading",
                    total=total_size,
                    unit='B',
                    unit_scale=True,
                    unit_divisor=1024,
                ) as pbar:
                    for chunk in response.iter_content(chunk_size=8192):
                        f.write(chunk)
                        pbar.update(len(chunk))

                with zipfile.ZipFile(cache_path, 'w', zipfile.ZIP_DEFLATED) as zf:
                    zf.write(tsv_file, 'opengnt_keyedFeatures.txt')

                tsv_file.unlink()

            print(f"✓ Downloaded and cached: {CACHE_FILE}")
            return cache_path
        
        except requests.RequestException as e:
            print(f"   ✗ Failed: {e}")
            if i < len(urls):
                print(f"   Trying next URL...")
            continue
    
    # All URLs failed
    print(f"\n✗ Error: Could not download OpenGNT data from any source")
    print(f"\nTroubleshooting:")
    print(f"  1. Check your internet connection")
    print(f"  2. Visit https://github.com/eliranwong/OpenGNT manually")
    print(f"  3. Download OpenGNT_keyedFeatures.csv.zip and place it next to this script")
    print(f"  4. Or check if the repository has been moved/renamed")
    sys.exit(1)


def parse_rmac_code(rmac: str) -> Dict[str, str]:
    """
    Parse RMAC (Robinson's Morphological Analysis Code) into components
    
    Example RMAC codes:
    - N-NSM: Noun, Nominative, Singular, Masculine
    - V-PAI-3S: Verb, Present, Active, Indicative, 3rd Person, Singular
    - RA-NSF: Article (definite), Nominative, Singular, Feminine
    """
    parts = rmac.split('-')
    result = {}
    
    if not parts:
        return result
    
    # Part of speech
    pos = parts[0][0] if parts[0] else ''
    result['pos'] = GRAMMAR_MAP.get(pos, pos)
    
    if len(parts) < 2:
        return result
    
    # For verbs: Tense-Voice-Mood-Person-Number
    if pos == 'V':
        if len(parts[1]) >= 3:
            # Tense
            tense_map = {
                'P': 'PRES', 'I': 'IMPF', 'F': 'FUT',
                'A': 'AOR', 'X': 'PERF', 'Y': 'PLPF'
            }
            result['tense'] = tense_map.get(parts[1][0], parts[1][0])
            
            # Voice
            voice_map = {
                'A': 'ACT', 'M': 'MID', 'P': 'PASS', 'E': 'MP'
            }
            result['voice'] = voice_map.get(parts[1][1], parts[1][1])
            
            # Mood
            mood_map = {
                'I': 'IND', 'S': 'SUBJ', 'O': 'OPT',
                'M': 'IMP', 'N': 'INF', 'P': 'PTCP'
            }
            result['mood'] = mood_map.get(parts[1][2], parts[1][2])
        
        # Person and Number (if present)
        if len(parts) > 2:
            person_num = parts[2]
            if len(person_num) >= 2:
                result['person'] = person_num[0] + 'P'  # 1P, 2P, 3P
                result['number'] = 'S' if person_num[1] == 'S' else 'P'
    
    # For nominals: Case-Gender-Number
    elif pos in ['N', 'A', 'R', 'T']:
        if len(parts[1]) >= 3:
            # Case
            case_map = {
                'N': 'NOM', 'G': 'GEN', 'D': 'DAT',
                'A': 'ACC', 'V': 'VOC'
            }
            result['case'] = case_map.get(parts[1][0], parts[1][0])
            
            # Number
            result['number'] = 'S' if parts[1][1] == 'S' else 'P'
            
            # Gender
            gender_map = {'M': 'M', 'F': 'F', 'N': 'N'}
            result['gender'] = gender_map.get(parts[1][2], parts[1][2])
    
    return result


def _select_data_file(zf: zipfile.ZipFile) -> str:
    """Pick the best data file inside the zip."""
    candidates = zf.namelist()
    # Prefer keyedFeatures files with known extensions
    for name in candidates:
        lower = name.lower()
        if "keyedfeatures" in lower and lower.endswith((".txt", ".tsv", ".csv")):
            return name
    # Fallback: first file
    if candidates:
        return candidates[0]
    return ""


def _detect_delimiter(sample: str) -> str:
    """Detect delimiter between tab and comma, default to tab."""
    if "\t" in sample and "," not in sample:
        return "\t"
    if "," in sample and "\t" not in sample:
        return ","
    try:
        import csv
        dialect = csv.Sniffer().sniff(sample, delimiters="\t,")
        return dialect.delimiter
    except Exception:
        return "\t"


def _split_bracketed(value: str) -> List[str]:
    value = value.strip()
    if value.startswith("〔") and value.endswith("〕"):
        value = value[1:-1]
    if not value:
        return []
    return value.split("｜")


def _parse_keyed_features_row(parts: List[str], line_num: int) -> Optional[Dict]:
    # Expected columns (tab-delimited): see OpenGNT_keyedFeatures.csv
    if len(parts) < 9:
        return None

    # Book/Chapter/Verse
    bcv = _split_bracketed(parts[4])
    if len(bcv) < 3:
        return None
    book_str, chapter_str, verse_str = bcv[0], bcv[1], bcv[2]
    if not (book_str.isdigit() and chapter_str.isdigit() and verse_str.isdigit()):
        return None

    # Word number from OpenTextWord_KEY (e.g., 40.1.1.w1)
    word_key_parts = _split_bracketed(parts[5])
    if len(word_key_parts) < 3:
        return None
    word_key = word_key_parts[2]
    match = re.search(r"w(\d+)", word_key)
    if not match:
        return None

    # Morph column with Greek + RMAC (e.g., BIMNRSTWH=Βίβλος=G0976=N-NSF;)
    morph_parts = _split_bracketed(parts[7])
    if not morph_parts:
        return None
    morph_entry = next((m for m in morph_parts if m.strip()), "")
    morph_entry = morph_entry.split(";")[0].strip()
    if not morph_entry:
        return None
    morph_tokens = morph_entry.split("=")
    if len(morph_tokens) < 2:
        return None
    greek = morph_tokens[1].strip()
    rmac = morph_tokens[-1].strip()
    if not greek or not rmac:
        return None

    # Gloss column (take first gloss if present)
    gloss_parts = _split_bracketed(parts[8])
    gloss = gloss_parts[0].strip() if gloss_parts else ""

    try:
        book = int(book_str)
        chapter = int(chapter_str)
        verse = int(verse_str)
        word_num = int(match.group(1))
    except ValueError:
        print(f"⚠️  Warning: Skipping malformed line {line_num}: invalid numeric field")
        return None

    grammar = parse_rmac_code(rmac)
    return {
        'book': book,
        'chapter': chapter,
        'verse': verse,
        'word_num': word_num,
        'greek': greek,
        'rmac': rmac,
        'lemma': greek,
        'transliteration': '',
        'gloss': gloss,
        'grammar': grammar,
        'pos': grammar.get('pos', ''),
    }


def load_opengnt_data(zip_path: Path) -> List[Dict]:
    """Load and parse the OpenGNT TSV/CSV data from the zip file"""
    print(f"📖 Loading OpenGNT data...")
    
    tokens = []
    
    try:
        with zipfile.ZipFile(zip_path, 'r') as zf:
            data_filename = _select_data_file(zf)
            if not data_filename:
                print(f"✗ Error: No data file found in zip")
                sys.exit(1)

            with zf.open(data_filename) as f:
                content = f.read().decode('utf-8')

            # Determine delimiter
            sample = content[:10000]
            delimiter = _detect_delimiter(sample)

            import csv
            reader = csv.reader(content.splitlines(), delimiter=delimiter)
            for line_num, parts in enumerate(reader, 1):
                if not parts:
                    continue
                if parts[0].startswith('#'):
                    continue
                # Header row detection for keyedFeatures CSV
                if parts[0].strip() == "FEATURESsort1":
                    continue

                # New keyedFeatures format
                if parts[0].strip().isdigit() and len(parts) >= 9 and parts[4].startswith("〔"):
                    token = _parse_keyed_features_row(parts, line_num)
                    if token:
                        tokens.append(token)
                    else:
                        print(f"⚠️  Warning: Skipping malformed line {line_num}: invalid keyedFeatures row")
                    continue

                if len(parts) < 6:
                    continue

                try:
                    # Parse the reference: BBCCVVWW (book, chapter, verse, word)
                    ref = parts[0].strip()
                    if len(ref) < 8 or not ref[:8].isdigit():
                        print(f"⚠️  Warning: Skipping malformed line {line_num}: invalid ref '{ref}'")
                        continue
                    book = int(ref[0:2])
                    chapter = int(ref[2:4])
                    verse = int(ref[4:6])
                    word_num = int(ref[6:8])

                    # Parse grammar codes
                    rmac = parts[2]
                    grammar = parse_rmac_code(rmac)

                    token = {
                        'book': book,
                        'chapter': chapter,
                        'verse': verse,
                        'word_num': word_num,
                        'greek': parts[1],              # Greek word
                        'rmac': rmac,                   # Full RMAC code
                        'lemma': parts[3],              # Lemma
                        'transliteration': parts[4],    # Transliteration
                        'gloss': parts[5],              # English gloss
                        'grammar': grammar,             # Parsed grammar components
                        'pos': grammar.get('pos', ''),  # Part of speech
                    }

                    tokens.append(token)

                except (ValueError, IndexError) as e:
                    print(f"⚠️  Warning: Skipping malformed line {line_num}: {e}")
                    continue
        
        print(f"✓ Loaded {len(tokens)} tokens")
        return tokens
    
    except Exception as e:
        print(f"✗ Error loading OpenGNT data: {e}")
        sys.exit(1)


def filter_tokens(
    tokens: List[Dict],
    book: int,
    chapter: Optional[int] = None,
    start_verse: Optional[int] = None,
    end_verse: Optional[int] = None
) -> List[Dict]:
    """Filter tokens by book, chapter, and verse range"""
    
    filtered = [t for t in tokens if t['book'] == book]
    
    if chapter is not None:
        filtered = [t for t in filtered if t['chapter'] == chapter]
    
    if start_verse is not None:
        filtered = [t for t in filtered if t['verse'] >= start_verse]
    
    if end_verse is not None:
        filtered = [t for t in filtered if t['verse'] <= end_verse]
    
    return filtered


def format_output(
    tokens: List[Dict],
    book: int,
    chapter: Optional[int],
    start_verse: Optional[int],
    end_verse: Optional[int]
) -> Dict:
    """Format tokens into the structure expected by the AI prompt"""
    
    if not tokens:
        return {
            'book': book,
            'book_name': BOOK_NAMES.get(book, f"Book {book}"),
            'chapter': chapter,
            'start_verse': start_verse,
            'end_verse': end_verse,
            'tokens': [],
            'verse_count': 0,
            'token_count': 0,
        }
    
    # Group by verse
    verses = {}
    for token in tokens:
        v = token['verse']
        if v not in verses:
            verses[v] = []
        verses[v].append(token)
    
    # Format tokens for output
    formatted_tokens = []
    for verse_num in sorted(verses.keys()):
        verse_tokens = verses[verse_num]
        for token in verse_tokens:
            # Build grammar codes list
            grammar_codes = [token['pos']]
            
            grammar = token['grammar']
            
            # Add grammar attributes in order
            if 'tense' in grammar:
                grammar_codes.append(grammar['tense'])
            if 'voice' in grammar:
                grammar_codes.append(grammar['voice'])
            if 'mood' in grammar:
                grammar_codes.append(grammar['mood'])
            if 'person' in grammar:
                grammar_codes.append(grammar['person'])
            if 'case' in grammar:
                grammar_codes.append(grammar['case'])
            if 'gender' in grammar:
                grammar_codes.append(grammar['gender'])
            if 'number' in grammar:
                grammar_codes.append(grammar['number'])
            
            formatted_tokens.append({
                'verse': verse_num,
                'word_num': token['word_num'],
                'greek': token['greek'],
                'transliteration': token['transliteration'],
                'gloss': token['gloss'],
                'grammar_codes': grammar_codes,
                'part_of_speech': token['pos'].lower(),
                'lemma': token['lemma'],
                'rmac': token['rmac']
            })
    
    return {
        'book': book,
        'book_name': BOOK_NAMES.get(book, f"Book {book}"),
        'chapter': chapter,
        'start_verse': start_verse or (min(verses.keys()) if verses else None),
        'end_verse': end_verse or (max(verses.keys()) if verses else None),
        'verse_count': len(verses),
        'token_count': len(formatted_tokens),
        'tokens': formatted_tokens
    }


def main():
    parser = argparse.ArgumentParser(
        description="Parse OpenGNT token data with verse range support",
        formatter_class=argparse.RawDescriptionHelpFormatter,
        epilog="""
Examples:
  # Extract 1 John Chapter 1
  python parse_opengnt.py --book 62 --chapter 1 --out 1john_ch1.json
  
  # Extract 1 John Chapter 1, verses 1-8
  python parse_opengnt.py --book 62 --chapter 1 --start-verse 1 --end-verse 8 --out 1john_ch1_v1-8.json
  
  # Extract all of 1 John
  python parse_opengnt.py --book 62 --out 1john_all.json
  
  # Extract Romans Chapter 8
  python parse_opengnt.py --book 45 --chapter 8 --out rom8.json

Book Numbers:
  40=Matt  41=Mark  42=Luke  43=John  44=Acts
  45=Rom   46=1Cor  47=2Cor  48=Gal   49=Eph
  50=Phil  51=Col   52=1Th   53=2Th   54=1Tim
  55=2Tim  56=Tit   57=Phlm  58=Heb   59=Jas
  60=1Pet  61=2Pet  62=1Jn   63=2Jn   64=3Jn
  65=Jude  66=Rev
        """
    )
    
    parser.add_argument(
        "--book",
        type=int,
        required=True,
        help="Book number (40-66)"
    )
    parser.add_argument(
        "--chapter",
        type=int,
        help="Chapter number (optional, omit for whole book)"
    )
    parser.add_argument(
        "--start-verse",
        type=int,
        help="Starting verse number (optional, default: first verse)"
    )
    parser.add_argument(
        "--end-verse",
        type=int,
        help="Ending verse number (optional, default: last verse)"
    )
    parser.add_argument(
        "--out",
        required=True,
        help="Output JSON file path"
    )
    parser.add_argument(
        "--force-download",
        action="store_true",
        help="Force re-download of OpenGNT data (ignore cache)"
    )
    
    args = parser.parse_args()
    
    # Validate book number
    if args.book < 40 or args.book > 66:
        print(f"✗ Error: Invalid book number {args.book} (must be 40-66)")
        sys.exit(1)
    
    # Validate verse range
    if args.start_verse and args.end_verse and args.start_verse > args.end_verse:
        print(f"✗ Error: start-verse ({args.start_verse}) cannot be greater than end-verse ({args.end_verse})")
        sys.exit(1)
    
    # Print what we're doing
    book_name = BOOK_NAMES.get(args.book, f"Book {args.book}")
    print(f"\n{'='*60}")
    print(f"OpenGNT Parser")
    print(f"{'='*60}")
    print(f"Book:    {book_name} (#{args.book})")
    if args.chapter:
        print(f"Chapter: {args.chapter}")
    if args.start_verse or args.end_verse:
        start = args.start_verse or 1
        end = args.end_verse or "end"
        print(f"Verses:  {start}-{end}")
    print(f"Output:  {args.out}")
    print(f"{'='*60}\n")
    
    # Download/load OpenGNT data
    zip_path = download_opengnt(force=args.force_download)
    
    # Load all tokens
    all_tokens = load_opengnt_data(zip_path)
    
    # Filter tokens
    print(f"🔍 Filtering tokens...")
    filtered = filter_tokens(
        all_tokens,
        book=args.book,
        chapter=args.chapter,
        start_verse=args.start_verse,
        end_verse=args.end_verse
    )
    
    if not filtered:
        print(f"⚠️  Warning: No tokens found matching criteria")
        print(f"   Book {args.book}, Chapter {args.chapter}, Verses {args.start_verse}-{args.end_verse}")
    else:
        print(f"✓ Found {len(filtered)} tokens")
    
    # Format output
    output = format_output(
        filtered,
        book=args.book,
        chapter=args.chapter,
        start_verse=args.start_verse,
        end_verse=args.end_verse
    )
    
    # Save to JSON
    output_path = Path(args.out)
    output_path.parent.mkdir(parents=True, exist_ok=True)
    
    with open(output_path, 'w', encoding='utf-8') as f:
        json.dump(output, f, indent=2, ensure_ascii=False)
    
    print(f"\n✅ Success!")
    print(f"   Wrote {output['token_count']} tokens across {output['verse_count']} verses")
    print(f"   Output: {args.out}")
    print(f"\n{'='*60}\n")


if __name__ == "__main__":
    main()
