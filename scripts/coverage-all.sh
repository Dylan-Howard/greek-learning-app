#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"

"$ROOT_DIR/scripts/coverage-backend-focused.sh"
"$ROOT_DIR/scripts/coverage-backend.sh"
"$ROOT_DIR/scripts/coverage-frontend.sh"
