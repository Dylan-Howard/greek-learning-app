#!/usr/bin/env bash
set -euo pipefail

printf "Running backend integration tests...\n"
dotnet test backend/tests/Koine.IntegrationTests/Koine.IntegrationTests.csproj -m:1 --verbosity minimal
