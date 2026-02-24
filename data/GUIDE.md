# Quick Reference: Using Gemini CLI Tool

## Authentication Setup (One-Time)

```bash
# Install the Gemini CLI
npm install -g @google/generative-ai-cli

# Authenticate with your Google account
gemini auth login
```

This will:
1. Open your browser
2. Prompt you to sign in with Google
3. Save credentials locally in `~/.config/gemini/`

## Testing Authentication

```bash
# Quick test
gemini chat "Hello"

# Should respond with AI-generated text
# If you get an error, re-run: gemini auth login
```

## How the Orchestrator Uses the CLI

The orchestrator calls the `gemini` CLI tool like this:

```bash
# The command
gemini chat < prompt.txt

# Or piped
echo "Your prompt here" | gemini chat
```

The CLI tool:
- Reads from stdin
- Uses your authenticated credentials automatically
- Returns the AI response to stdout
- No API key environment variable needed

## Docker Usage Note

When running in Docker, the orchestrator mounts your `~/.config` directory:

```yaml
volumes:
  - ~/.config:/root/.config:ro
```

This allows the Docker container to use your local gemini CLI authentication.

## Troubleshooting

### "Authentication required"
```bash
gemini auth login
```

### "Command not found: gemini"
```bash
npm install -g @google/generative-ai-cli
```

### "Permission denied" in Docker
```bash
# Ensure ~/.config is readable
chmod -R go+rX ~/.config/gemini/
```

### Check authentication status
```bash
# Test with a simple prompt
gemini chat "Hello" 

# If successful, you'll see AI response
# If failed, you'll see auth error
```

## CLI Tool Options

The orchestrator uses basic `gemini chat` without extra flags, but you can explore:

```bash
# See available options
gemini --help
gemini chat --help

# The orchestrator uses default model
# Authentication handles API access automatically
```

## Benefits of CLI vs API Key

1. **Simpler auth** - One-time browser login vs managing API keys
2. **No key management** - No .env files or secret storage needed
3. **Better security** - OAuth tokens instead of static keys
4. **Automatic refresh** - CLI handles token renewal

## For Local Development

```bash
# After authenticating once
gemini auth login

# Just run the orchestrator
python orchestrate_gnt_generation.py --tracker tracker.csv

# No environment variables needed
```

## For Docker

```bash
# Authenticate on host machine first
gemini auth login

# Then run docker-compose
# It will use your local auth via volume mount
docker-compose up gnt-orchestrator
```

---

**That's it!** Authenticate once with `gemini auth login`, and you're ready to go.