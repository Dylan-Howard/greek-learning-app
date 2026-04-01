#!/bin/bash
# run_gnt_compiler.sh
# Runs compile_book_wrappers.py for every New Testament book.
# Halts immediately on any non-zero exit code.

set -euo pipefail

# ---------------------------------------------------------------------------
# Fixed args
# ---------------------------------------------------------------------------
INPUT_DIR="data/output/csharp"
FALLBACK_LOG_DIR="data/output/logs"
OUTPUT_BASE="backend/src/Koine.Infrastructure/Data/Seed"
NAMESPACE="Koine.Infrastructure.Data.Seed"

# ---------------------------------------------------------------------------
# NT books: each entry is "BookArg|OutputFileName|ClassName"
# BookArg      – value passed to --book (must match what the script expects)
# OutputFileName – stem used in the .cs file path (no extension)
# ClassName    – value passed to --class-name
# ---------------------------------------------------------------------------
BOOKS=(
  "Matthew|MatthewTextData|MatthewTextData"
  "Mark|MarkTextData|MarkTextData"
  "Luke|LukeTextData|LukeTextData"
  "John|JohnTextData|JohnTextData"
  "Acts|ActsTextData|ActsTextData"
  "Romans|RomansTextData|RomansTextData"
  "1Corinthians|FirstCorinthiansTextData|FirstCorinthiansTextData"
  "2Corinthians|SecondCorinthiansTextData|SecondCorinthiansTextData"
  "Galatians|GalatiansTextData|GalatiansTextData"
  "Ephesians|EphesiansTextData|EphesiansTextData"
  "Philippians|PhilippiansTextData|PhilippiansTextData"
  "Colossians|ColossiansTextData|ColossiansTextData"
  "1Thessalonians|FirstThessaloniansTextData|FirstThessaloniansTextData"
  "2Thessalonians|SecondThessaloniansTextData|SecondThessaloniansTextData"
  "1Timothy|FirstTimothyTextData|FirstTimothyTextData"
  "2Timothy|SecondTimothyTextData|SecondTimothyTextData"
  "Titus|TitusTextData|TitusTextData"
  "Philemon|PhilemonTextData|PhilemonTextData"
  "Hebrews|HebrewsTextData|HebrewsTextData"
  "James|JamesTextData|JamesTextData"
  "1Peter|FirstPeterTextData|FirstPeterTextData"
  "2Peter|SecondPeterTextData|SecondPeterTextData"
  "1John|FirstJohnTextData|FirstJohnTextData"
  "2John|SecondJohnTextData|SecondJohnTextData"
  "3John|ThirdJohnTextData|ThirdJohnTextData"
  "Jude|JudeTextData|JudeTextData"
  "Revelation|RevelationTextData|RevelationTextData"
)

TOTAL=${#BOOKS[@]}
CURRENT=0

trap 'echo ""; echo "ERROR: Failed on book \"${BOOK_ARG}\" (entry $((CURRENT))/$TOTAL). Aborting." >&2' ERR

for entry in "${BOOKS[@]}"; do
  IFS='|' read -r BOOK_ARG OUTPUT_FILE CLASS_NAME <<< "$entry"
  CURRENT=$((CURRENT + 1))

  echo "[$CURRENT/$TOTAL] Processing: $BOOK_ARG → ${OUTPUT_FILE}.cs"

  python3 data/scripts/compile_book_wrappers.py \
    --input-dir       "$INPUT_DIR" \
    --fallback-log-dir "$FALLBACK_LOG_DIR" \
    --book            "$BOOK_ARG" \
    --output          "${OUTPUT_BASE}/${OUTPUT_FILE}.cs" \
    --namespace       "$NAMESPACE" \
    --class-name      "$CLASS_NAME"
done

echo ""
echo "All $TOTAL NT books processed successfully."