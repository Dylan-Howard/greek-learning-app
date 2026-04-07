# Testing Guide

This repo runs a layered test strategy that works both locally and in GitHub Actions.

## Test Layers

- Unit: fast, isolated tests for services and UI logic.
- Integration: .NET API tests with a real SQL Server in Testcontainers.
- Smoke: Playwright checks against the full Docker Compose stack.
- E2E: Playwright flows against the full Docker Compose stack (manual in CI).

## Prerequisites

- Docker Desktop (for integration + smoke + e2e)
- .NET SDK 10.x
- Node 24+

## Local Quick Start

```bash
# Install frontend deps and Playwright browsers
npm --prefix frontend install
npx --prefix frontend playwright install --with-deps

# Unit tests
./scripts/test-unit.sh

# Integration tests (Testcontainers)
./scripts/test-integration.sh

# Smoke tests (full stack + Playwright)
./scripts/test-smoke.sh

# E2E tests (full stack + Playwright, containerized)
./scripts/test-e2e.sh

# All tests
./scripts/test-all.sh
```

## CI Behavior

- PR and `master` pushes run: unit + integration + smoke.
- E2E is manual via GitHub Actions (workflow_dispatch).
- A nightly schedule is included but commented out in `e2e.yml` per request.

## Environment

Playwright uses these defaults if not overridden:

- `PLAYWRIGHT_BASE_URL` (default `http://localhost:3000`)
- `PLAYWRIGHT_API_BASE_URL` (default `http://localhost:5001`)
- `E2E_BYPASS_AUTH=true` to bypass Clerk middleware in the test stack

## Tips

- If the test stack is already running, set `COMPOSE_FILE=docker-compose.test.yml` and reuse it.
- `scripts/test-e2e.sh` uses `docker-compose.e2e.yml` to run Playwright inside a container for deterministic execution.
- For flaky Docker startup, increase the wait time in `scripts/wait-for-url.sh`.

## Troubleshooting

- If integration tests fail to start SQL Server, ensure Docker is running and that ports 1433/5001/3000 are available.
- If Playwright fails with missing browsers, re-run:

```bash
npx --prefix frontend playwright install --with-deps
```
