#!/usr/bin/env bash
set -euo pipefail

printf "Running backend unit tests...\n"
dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1 --verbosity minimal

printf "Running frontend unit tests...\n"
npm --prefix frontend run test -- --run
