#!/bin/bash
# GNT Orchestrator Runner (with venv)

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"
cd "$SCRIPT_DIR"

# Activate virtual environment
if [ ! -d "venv" ]; then
    echo "❌ Virtual environment not found"
    echo "   Run: bash setup_macos.sh"
    exit 1
fi

source venv/bin/activate

# Determine prompt file
if [ -f greek-nt/ai_seeding_prompt.py ]; then
    PROMPT_SCRIPT="./greek-nt/ai_seeding_prompt.py"
elif [ -f greek-nt/ai_seeding_prompt_greek.py ]; then
    PROMPT_SCRIPT="./greek-nt/ai_seeding_prompt_greek.py"
else
    echo "❌ Error: No AI prompt file found"
    deactivate
    exit 1
fi

# Run orchestrator
python orchestrate.py \
  --tracker ./docs/tracker.csv \
  --parse-script ./greek-nt/parse_opengnt.py \
  --prompt-script "$PROMPT_SCRIPT" \
  --output-dir ./output \
  "$@"

# Deactivate venv
deactivate
