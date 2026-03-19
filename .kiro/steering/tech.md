# Tech Stack

## Backend
- Runtime: .NET 10 (net10.0)
- Framework: ASP.NET Core Web API
- ORM: Entity Framework Core 10 (SQL Server provider)
- Auth: JWT Bearer (`Microsoft.AspNetCore.Authentication.JwtBearer`) + Clerk (frontend-issued tokens)
- API docs: NSwag 14 (`NSwag.AspNetCore`) — OpenAPI spec + Swagger UI
- TS client generation: `nswag run backend/nswa.json` → outputs `frontend/src/api/generated/api-client.ts`
- Testing: NUnit 4, Moq, coverlet

## Frontend
- Framework: Next.js 16 (App Router) + React 19
- Language: TypeScript 5 (strict mode, `nodenext` module resolution)
- UI: MUI v7 (`@mui/material`) with Emotion, custom theme in `frontend/src/theme/`
- Auth: `@clerk/nextjs`
- Testing: Vitest 4 + Testing Library
- Linting: ESLint + `@typescript-eslint`, oxlint

## Infrastructure
- Database: SQL Server (Docker for local dev)
- Containerization: Docker Compose (`docker compose up --build`)
- Frontend: `http://localhost:3000`, Backend: `http://localhost:5001`

---

## Common Commands

### Full stack
```bash
docker compose up --build
```

### Backend
```bash
# Run API
cd backend/src/Koine.API && dotnet run

# Apply migrations
dotnet ef database update --project backend/src/Koine.Infrastructure --startup-project backend/src/Koine.API

# Run tests (single-threaded — required)
dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1
```

### Frontend
```bash
cd frontend
npm run dev          # dev server
npm run build        # production build
npm run test         # vitest run (single pass)
npm run test:coverage
```

### TS client generation
```bash
# From repo root
nswag run backend/nswa.json
```

### Coverage scripts (from repo root)
```bash
./scripts/coverage-backend-focused.sh
./scripts/coverage-backend.sh
./scripts/coverage-frontend.sh
./scripts/coverage-all.sh
```
