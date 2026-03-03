#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
cd "$ROOT_DIR"

DB_CONTAINER="${DB_CONTAINER:-koine-db}"
DB_NAME="${DB_NAME:-Koine}"
SA_USER="${SA_USER:-sa}"
SA_PASSWORD="${SA_PASSWORD:-YourStrong@Passw0rd}"
SEED_SUCCESS_MARKER="${SEED_SUCCESS_MARKER:-Database seeding completed successfully!}"
SEED_TIMEOUT_SECONDS="${SEED_TIMEOUT_SECONDS:-180}"

echo "Ensuring SQL Server is running..."
docker compose up -d sqlserver >/dev/null

echo "Stopping backend (if running)..."
docker compose stop backend >/dev/null 2>&1 || true

echo "Dropping and recreating database '$DB_NAME'..."
docker exec "$DB_CONTAINER" /opt/mssql-tools18/bin/sqlcmd \
  -S localhost \
  -U "$SA_USER" \
  -P "$SA_PASSWORD" \
  -C \
  -Q "IF DB_ID('$DB_NAME') IS NOT NULL BEGIN ALTER DATABASE [$DB_NAME] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE [$DB_NAME]; END; CREATE DATABASE [$DB_NAME];"

echo "Starting backend..."
docker compose up -d --force-recreate backend >/dev/null

echo "Waiting for seed completion (timeout: ${SEED_TIMEOUT_SECONDS}s)..."
elapsed=0
while (( elapsed < SEED_TIMEOUT_SECONDS )); do
  logs="$(docker compose logs backend --tail=250 2>/dev/null || true)"
  if grep -q "$SEED_SUCCESS_MARKER" <<<"$logs"; then
    echo "Seed completed successfully."
    exit 0
  fi

  if grep -q "An error occurred during database initialization" <<<"$logs"; then
    echo "Seeding failed. Recent backend logs:"
    docker compose logs backend --tail=250
    exit 1
  fi

  sleep 2
  elapsed=$((elapsed + 2))
done

echo "Timed out waiting for seed completion. Recent backend logs:"
docker compose logs backend --tail=250
exit 1
