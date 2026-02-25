#!/usr/bin/env python3
"""
Simple OpenGNT Downloader

Downloads the TSV file directly and packages it as a zip for the parser.
"""

import sys
import zipfile
import requests
from pathlib import Path
from tqdm import tqdm

CACHE_FILE = "opengnt_keyedFeatures_cache.zip"
TSV_FILE = "opengnt_keyedFeatures.txt"

def download_tsv():
    """Download the TSV/CSV file (or zip) from GitHub"""
    urls = [
        "https://raw.githubusercontent.com/eliranwong/OpenGNT/master/OpenGNT_keyedFeatures.csv.zip",
        "https://github.com/eliranwong/OpenGNT/raw/master/OpenGNT_keyedFeatures.csv.zip",
        "https://raw.githubusercontent.com/eliranwong/OpenGNT/main/opengnt_keyedFeatures.txt",
        "https://github.com/eliranwong/OpenGNT/raw/main/opengnt_keyedFeatures.txt",
        "https://raw.githubusercontent.com/eliranwong/OpenGNT/master/opengnt_keyedFeatures.txt",
        "https://github.com/eliranwong/OpenGNT/raw/master/opengnt_keyedFeatures.txt",
    ]
    
    print("📥 Downloading OpenGNT data file...")
    
    for i, url in enumerate(urls, 1):
        print(f"\nAttempt {i}/{len(urls)}")
        print(f"URL: {url}")
        
        try:
            response = requests.get(url, stream=True, timeout=30)
            response.raise_for_status()
            
            total_size = int(response.headers.get('content-length', 0))

            if url.lower().endswith(".zip"):
                with open(CACHE_FILE, 'wb') as f, tqdm(
                    desc="Downloading",
                    total=total_size,
                    unit='B',
                    unit_scale=True,
                    unit_divisor=1024,
                ) as pbar:
                    for chunk in response.iter_content(chunk_size=8192):
                        f.write(chunk)
                        pbar.update(len(chunk))
                print(f"✅ Downloaded: {CACHE_FILE}")
                return True

            with open(TSV_FILE, 'wb') as f, tqdm(
                desc="Downloading",
                total=total_size,
                unit='B',
                unit_scale=True,
                unit_divisor=1024,
            ) as pbar:
                for chunk in response.iter_content(chunk_size=8192):
                    f.write(chunk)
                    pbar.update(len(chunk))

            print(f"✅ Downloaded: {TSV_FILE}")
            return True
        
        except Exception as e:
            print(f"❌ Failed: {e}")
            if i < len(urls):
                print("Trying next URL...")
            continue
    
    return False

def create_zip():
    """Package the TSV file into a zip for the parser"""
    print(f"\n📦 Creating cache file...")
    
    try:
        if Path(CACHE_FILE).exists():
            print(f"✅ Cache already exists: {CACHE_FILE}")
            return True
        with zipfile.ZipFile(CACHE_FILE, 'w', zipfile.ZIP_DEFLATED) as zf:
            zf.write(TSV_FILE, TSV_FILE)
        
        print(f"✅ Created: {CACHE_FILE}")
        
        # Clean up TSV
        Path(TSV_FILE).unlink()
        print(f"🗑️  Cleaned up: {TSV_FILE}")
        
        return True
    except Exception as e:
        print(f"❌ Error creating zip: {e}")
        return False

def main():
    print("""
╔═══════════════════════════════════════════════════════════╗
║         OpenGNT Simple Downloader                         ║
╚═══════════════════════════════════════════════════════════╝
""")
    
    # Check if already exists
    if Path(CACHE_FILE).exists():
        print(f"ℹ️  Cache file already exists: {CACHE_FILE}")
        size_mb = Path(CACHE_FILE).stat().st_size / 1024 / 1024
        print(f"   Size: {size_mb:.2f} MB")
        
        response = input("\nDelete and re-download? (y/N): ")
        if response.lower() != 'y':
            print("✅ Using existing cache file")
            return 0
        
        Path(CACHE_FILE).unlink()
        print(f"🗑️  Deleted old cache")
    
    # Download TSV
    if not download_tsv():
        print("\n" + "="*60)
        print("❌ Automatic download failed")
        print("="*60)
        print("\nManual steps:")
        print("1. Visit: https://github.com/eliranwong/OpenGNT")
        print("2. Download: OpenGNT_keyedFeatures.csv.zip (preferred)")
        print("3. Place it in this directory")
        print("4. Run this script again to create the cache zip")
        return 1
    
    # Create zip
    if not create_zip():
        print("\n❌ Failed to create cache file")
        print(f"\nYou can manually create it:")
        print(f"  python -c \"import zipfile; zipfile.ZipFile('{CACHE_FILE}', 'w').write('{TSV_FILE}')\"")
        return 1
    
    # Verify
    size_mb = Path(CACHE_FILE).stat().st_size / 1024 / 1024
    print(f"\n{'='*60}")
    print(f"✅ SUCCESS!")
    print(f"{'='*60}")
    print(f"Cache file: {CACHE_FILE}")
    print(f"Size: {size_mb:.2f} MB")
    print(f"\nYou can now run parse_opengnt.py or the orchestrator")
    
    return 0

if __name__ == "__main__":
    sys.exit(main())
