#!/usr/bin/env bash
set -euo pipefail

compose_file="${COMPOSE_FILE:-docker-compose.test.yml}"

cleanup() {
  docker compose -f "$compose_file" down --remove-orphans
}
trap cleanup EXIT

printf "Starting test stack...\n"
docker compose -f "$compose_file" up -d --build

printf "Waiting for backend and frontend...\n"
./scripts/wait-for-url.sh "http://localhost:5001/api/books" 120
./scripts/wait-for-url.sh "http://localhost:3000" 120

printf "Running Playwright e2e suite...\n"
npm --prefix frontend run test:e2e
