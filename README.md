# Koine

Koine is a full-stack Greek learning platform centered on adaptive reading, vocabulary study, and lesson progression.

## Current Architecture

- Frontend: Next.js + React + TypeScript (`frontend/`)
- Backend: .NET monolith (`backend/src/Koine.API`, `Koine.Application`, `Koine.Domain`, `Koine.Infrastructure`)
- Database: SQL Server (Docker for local development)
- Auth: Clerk integration (development fallbacks still being hardened)

## Repository Layout

- `frontend/`: Next.js app
- `backend/`: .NET solution (`src/` + `tests/`)
- `data/`: seed/data transformation scripts
- `docs/`: ADRs, roadmap, architecture notes
- `scripts/`: coverage and local utility scripts
- `legacy-reader-service/`: legacy reference service

## Quick Start

### 1. Start stack

```bash
docker compose up --build
```

- Frontend: `http://localhost:3000`
- Backend: `http://localhost:5001`

### 2. Run tests

```bash
dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1
cd frontend && npm run test -- --run
```

## Environment Variables

### Frontend (`frontend/.env.local`)

- `NEXT_PUBLIC_API_URL`: public API base URL (required)
- `INTERNAL_API_URL`: internal server-side API base URL (Docker/local)
- `NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY`: Clerk publishable key
- `CLERK_SECRET_KEY`: Clerk secret key
- `NEXT_PUBLIC_CLERK_SIGN_IN_FALLBACK_REDIRECT_URL`
- `NEXT_PUBLIC_CLERK_SIGN_UP_FORCE_REDIRECT_URL`

Template: `frontend/.env.local.example`

### Backend

Configured via `appsettings*.json` or environment variables:

- `ConnectionStrings__DefaultConnection`
- `JwtSettings__SecretKey`
- `JwtSettings__Issuer`
- `JwtSettings__Audience`
- `ASPNETCORE_ENVIRONMENT`

## Common Commands

```bash
./scripts/coverage-backend-focused.sh
./scripts/coverage-backend.sh
./scripts/coverage-frontend.sh
./scripts/coverage-all.sh

# Storybook (frontend dev-only)
cd frontend && npm run storybook
```

## Data Utility Notes

Book-level C# seed wrappers can be generated via:

```bash
python3 data/scripts/compile_book_wrappers.py \
  --input-dir data/output/csharp \
  --fallback-log-dir data/output/logs \
  --book 1John \
  --output backend/src/Koine.Infrastructure/Data/Seed/FirstJohnTextData.cs \
  --namespace Koine.Infrastructure.Data.Seed \
  --class-name FirstJohnTextData
```
