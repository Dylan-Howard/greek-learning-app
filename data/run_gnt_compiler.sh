#!/bin/bash

python3 data/scripts/compile_book_wrappers.py \
  --input-dir data/output/csharp \
  --fallback-log-dir data/output/logs \
  --book 2John \
  --output backend/src/Koine.Infrastructure/Data/Seed/SecondJohnTextData.cs \
  --namespace Koine.Infrastructure.Data.Seed \
  --class-name SecondJohnTextData