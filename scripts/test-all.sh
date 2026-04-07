#!/usr/bin/env bash
set -euo pipefail

./scripts/test-unit.sh
./scripts/test-integration.sh
./scripts/test-smoke.sh
./scripts/test-e2e.sh
