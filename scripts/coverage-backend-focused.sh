#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
cd "$ROOT_DIR"

# Focused coverage for MVP parity-critical service layer.
DOTNET_ROLL_FORWARD=Major dotnet test backend/Koine.Tests/Koine.Tests.csproj -m:1 \
  /p:CollectCoverage=true \
  /p:CoverletOutput=backend/Koine.Tests/TestResults/coverage-services \
  /p:CoverletOutputFormat=cobertura \
  /p:Include="[Koine.Application]Koine.Application.Services.BookService*%2c[Koine.Application]Koine.Application.Services.ChapterService*%2c[Koine.Application]Koine.Application.Services.TranslationService*%2c[Koine.Application]Koine.Application.Services.UserService*%2c[Koine.Application]Koine.Application.Services.LessonService*" \
  /p:Threshold=70 \
  /p:ThresholdType=line \
  /p:ThresholdStat=total

echo "Focused backend coverage report: backend/Koine.Tests/backend/Koine.Tests/TestResults/coverage-services.cobertura.xml"
