#!/usr/bin/env bash
set -euo pipefail

compose_file="${COMPOSE_FILE:-docker-compose.test.yml}"
compose_e2e_file="${COMPOSE_E2E_FILE:-docker-compose.e2e.yml}"

cleanup() {
  docker compose -f "$compose_file" -f "$compose_e2e_file" down --remove-orphans --volumes
}
trap cleanup EXIT

printf "Starting test stack...\n"
docker compose -f "$compose_file" -f "$compose_e2e_file" up -d --build

printf "Waiting for backend and frontend...\n"
./scripts/wait-for-url.sh "http://localhost:5001/api/books" 120
./scripts/wait-for-url.sh "http://localhost:3000" 120

printf "Running Playwright e2e suite (containerized)...\n"
docker compose -f "$compose_file" -f "$compose_e2e_file" run --rm playwright \
  bash -lc "npm --prefix frontend ci && npm --prefix frontend run test:e2e"
