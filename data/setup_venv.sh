#!/bin/bash
# macOS Setup with Virtual Environment
# For Homebrew Python with PEP 668 protection

echo "🍎 macOS Setup with Virtual Environment"
echo ""

# Check if we're in the data directory
if [ ! -f "orchestrate.py" ]; then
    echo "❌ Error: orchestrate.py not found"
    echo "   Please run this script from the data/ directory"
    exit 1
fi

# 1. Create virtual environment
echo "📦 Creating Python virtual environment..."
if [ -d "venv" ]; then
    echo "   ℹ️  Virtual environment already exists"
else
    python3 -m venv venv
    echo "   ✅ Created venv/"
fi

# 2. Activate and install packages
echo ""
echo "📥 Installing packages in virtual environment..."
source venv/bin/activate
pip install requests tqdm
echo "   ✅ Packages installed"

# 3. Verify packages
echo ""
echo "🔍 Verifying installation..."
if python -c "import requests, tqdm" 2>/dev/null; then
    echo "   ✅ Packages available in venv"
else
    echo "   ❌ Package installation failed"
    exit 1
fi

# 4. Check Gemini CLI
echo ""
echo "🔐 Checking Gemini CLI..."
if ! command -v gemini &> /dev/null; then
    echo "   ❌ Gemini CLI not found"
    echo "   Install: npm install -g @google/gemini-cli"
    echo ""
    read -p "Install now? (y/N) " -n 1 -r
    echo
    if [[ $REPLY =~ ^[Yy]$ ]]; then
        npm install -g @google/gemini-cli
    else
        deactivate
        exit 1
    fi
fi

# Check authentication
if ! gemini chat "test" &> /dev/null 2>&1; then
    echo "   ⚠️  Gemini CLI not authenticated"
    echo ""
    read -p "Authenticate now? (y/N) " -n 1 -r
    echo
    if [[ $REPLY =~ ^[Yy]$ ]]; then
        gemini auth login
    else
        echo "   Run later: gemini auth login"
    fi
else
    echo "   ✅ Gemini CLI authenticated"
fi

# 5. Create directories
echo ""
echo "📁 Creating output directories..."
mkdir -p output/json output/csharp output/logs cache
echo "   ✅ Directories created"

# 6. Check required files
echo ""
echo "📋 Checking required files..."

PROMPT_FILE=""
if [ -f greek-nt/ai_seeding_prompt.py ]; then
    PROMPT_FILE="./greek-nt/ai_seeding_prompt.py"
    echo "   ✅ Found: ai_seeding_prompt.py"
elif [ -f greek-nt/ai_seeding_prompt_greek.py ]; then
    PROMPT_FILE="./greek-nt/ai_seeding_prompt_greek.py"
    echo "   ✅ Found: ai_seeding_prompt_greek.py"
else
    echo "   ❌ Missing: greek-nt/ai_seeding_prompt.py"
    deactivate
    exit 1
fi

if [ ! -f greek-nt/parse_opengnt.py ]; then
    echo "   ❌ Missing: greek-nt/parse_opengnt.py"
    deactivate
    exit 1
fi

if [ ! -f tracker.csv ]; then
    echo "   ❌ Missing: tracker.csv"
    deactivate
    exit 1
fi

# 7. Create run script
echo ""
echo "📝 Creating run script..."

cat > run_gnt.sh << 'EOF'
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
  --tracker tracker.csv \
  --parse-script ./greek-nt/parse_opengnt.py \
  --prompt-script "$PROMPT_SCRIPT" \
  --output-dir ./output \
  "$@"

# Deactivate venv
deactivate
EOF

chmod +x run_gnt.sh

# Deactivate for now
deactivate

echo ""
echo "✅ Setup complete!"
echo ""
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
echo "📖 Usage:"
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
echo ""
echo "  ./run_gnt.sh                    # Process all pending"
echo "  ./run_gnt.sh --book 62          # Process 1 John"
echo "  ./run_gnt.sh --dry-run          # Preview"
echo "  ./run_gnt.sh --generate-wrappers # Generate wrappers"
echo ""
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
echo ""
echo "💡 The virtual environment (venv/) has been created with"
echo "   all required packages. The run_gnt.sh script will"
echo "   automatically activate it when needed."
echo ""