#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
cd "$ROOT_DIR"

# Full backend coverage across all loaded modules.
DOTNET_ROLL_FORWARD=Major dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1 \
  /p:CollectCoverage=true \
  /p:CoverletOutput=backend/tests/Koine.Tests/TestResults/coverage-current \
  /p:CoverletOutputFormat=cobertura

echo "Backend coverage report: backend/tests/Koine.Tests/TestResults/coverage-current.cobertura.xml"
