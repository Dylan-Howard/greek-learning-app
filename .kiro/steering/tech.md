---
inclusion: always
---

# Tech Stack

## Backend

- Runtime: .NET 10 (`net10.0`), ASP.NET Core Web API
- ORM: Entity Framework Core 10 (SQL Server provider) — migrations are auto-generated, never hand-edit files in `Koine.Infrastructure/Migrations/`
- Auth: JWT Bearer (`Microsoft.AspNetCore.Authentication.JwtBearer`) + Clerk (frontend-issued tokens); dev fallback via `DevAuthController` and `X-Dev-User-Id` header
- GraphQL: `GraphQL.NET` library — schema at `Koine.API/GraphQL/Schema/KoineSchema.cs`; endpoint `/graphql`; Playground at `/graphql/ui` (dev only)
- API docs: NSwag 14 (`NSwag.AspNetCore`) — OpenAPI spec + Swagger UI
- TS client generation: `nswag run backend/nswa.json` → outputs `frontend/src/api/generated/api-client.ts` (re-run after any controller/DTO change)
- Testing: NUnit 4, Moq, coverlet — always run single-threaded: `dotnet test ... -m:1`

## Frontend

- Framework: Next.js 16 (App Router) + React 19
- Language: TypeScript 5, strict mode, `nodenext` module resolution — `any` is banned; use `unknown` + type guards
- UI: MUI v7 (`@mui/material`) with Emotion; custom theme at `frontend/src/theme/`
- Auth: `@clerk/nextjs`
- GraphQL client: Apollo Client (`@apollo/client`) — singleton via `getApolloClient()` in `src/lib/api/graphql/client.ts`; server-side uses `createServerClient()` (no cache, SSR mode)
- Testing: Vitest 4 + Testing Library
- Linting: ESLint + `@typescript-eslint`, oxlint
- Path alias: `@/*` → `src/*`

## Infrastructure

- Database: SQL Server (Docker for local dev)
- Local URLs: Frontend `http://localhost:3000`, Backend `http://localhost:5001`
- Full stack: `docker compose up --build`

---

## Architecture — Backend (Clean Architecture)

Strict unidirectional dependency rule: `Domain ← Application ← Infrastructure ← API`. Never reference a higher layer from a lower one.

| Layer | Project | Responsibility |
|---|---|---|
| Domain | `Koine.Domain` | Entities, enums, value objects — zero external dependencies |
| Application | `Koine.Application` | Interfaces, services, DTOs, mappers — depends on Domain only |
| Infrastructure | `Koine.Infrastructure` | EF `KoineDbContext`, repositories, migrations, seed data |
| API | `Koine.API` | Controllers, middleware, DI wiring |

### New feature layer order
Domain entity → Application interface + DTO → Infrastructure implementation → API controller

### Backend conventions
- One controller per resource; inherit `ControllerBase`; use `[ApiController]` + `[Route("api/<resource>")]`
- Controllers catch exceptions, log with `ILogger<T>`, and return `StatusCode(500, new { message = "..." })` — never `Console.Write`
- XML doc comments on all `public` members
- Use `record` types for immutable DTOs; prefer primary constructors
- Use `ICurrentUserProvider` (via `HttpContextCurrentUserProvider`) to read identity — do not read `HttpContext` directly in services

## Architecture — GraphQL (Backend)

The backend exposes a GraphQL API alongside REST, using the `GraphQL.NET` library.

| Path | Purpose |
|---|---|
| `Koine.API/GraphQL/Schema/KoineSchema.cs` | Root schema — wires `RootQuery` + `RootMutation` |
| `Koine.API/GraphQL/Queries/RootQuery.cs` | All query fields; resolvers delegate to Application services |
| `Koine.API/GraphQL/Mutations/RootMutation.cs` | All mutation fields |
| `Koine.API/GraphQL/Types/` | `ObjectGraphType` definitions for each domain type |
| `Koine.API/GraphQL/Types/InputTypes/` | Input types for mutations |
| `Koine.API/GraphQL/DataLoaders/` | Scoped DataLoaders for batching (one per request) |

### GraphQL conventions
- `KoineSchema` is registered as **scoped** via `AddSchema<KoineSchema>` — never singleton
- DataLoaders are **scoped** so each request gets its own batch context
- Authenticated fields use `.AuthorizeWithPolicy("Authenticated")` — never bypass auth in resolvers
- Resolvers call Application service interfaces only — no direct EF/repository access from GraphQL types
- Error codes follow the `ExecutionError` pattern with a `Code` property (e.g. `"NOT_FOUND"`, `"UNAUTHENTICATED"`)
- User identity in resolvers: inject `IHttpContextAccessor` and extract `ClaimTypes.NameIdentifier` — same pattern as `RootQuery.ResolveUserId()`

## Architecture — GraphQL (Frontend)

Apollo Client is the GraphQL client. `.graphql` files live alongside their domain area under `src/lib/api/graphql/`.

| Path | Purpose |
|---|---|
| `src/lib/api/graphql/client.ts` | Apollo client factory — `getApolloClient()` (client-side singleton) and `createServerClient()` (SSR, no cache) |
| `src/lib/api/graphql/queries/` | `.graphql` query documents grouped by domain |
| `src/lib/api/graphql/mutations/` | `.graphql` mutation documents grouped by domain |
| `src/lib/api/graphql/generated/` | Generated TypeScript types — do not hand-edit |

### Apollo conventions
- Client components use the `getApolloClient(getToken, errorHandlers)` singleton; pass `useAuth().getToken` from Clerk for the auth link
- Server components / RSC use `createServerClient()` — `fetchPolicy: 'no-cache'`, `ssrMode: true`
- Error handling is centralised in `buildErrorLink(handlers)` — handle `UNAUTHENTICATED`, `NOT_FOUND`, `FORBIDDEN` codes there, not in individual query call sites
- `NEXT_PUBLIC_GRAPHQL_URL` env var controls the GraphQL endpoint (defaults to `http://localhost:5001/graphql`)

## Architecture — Frontend (Next.js App Router)

| Path | Purpose |
|---|---|
| `src/app/(auth)/` | Authenticated routes (lessons, reader, study, vocabulary, profile) |
| `src/app/(client)/` | Client-only layout (onboarding) |
| `src/app/(public)/` | Unauthenticated routes (welcome, about, auth, legal) |
| `src/components/features/<name>/` | Feature-scoped components |
| `src/components/shared/` | Cross-feature reusable UI primitives (use these wrappers, not raw MUI, for interactive elements) |
| `src/components/layout/` | AppShell, NavRail, providers |
| `src/lib/api/rest/` | REST fetch helpers |
| `src/lib/api/graphql/` | GraphQL helpers |
| `src/lib/hooks/` | Shared React hooks |
| `src/lib/services/` | Domain service logic |
| `src/lib/stores/` | Client state stores |
| `src/lib/types/domain/` | Shared TypeScript domain types |
| `src/design-system-v2/` | In-progress design system migration — prefer over legacy components when available, but do not break existing usage |

### Frontend conventions
- Named exports only — no default exports anywhere
- Use `src/components/shared/` wrappers (`Button`, `TextField`, etc.) for interactive primitives; use MUI directly for layout (`Box`, `Stack`, `Grid`, `Container`)
- Prefer MUI theme tokens over hardcoded values in `sx` props
- New feature UI → `src/components/features/<feature-name>/`
- New routes → appropriate App Router group: `(auth)`, `(client)`, or `(public)`

---

## Common Commands

```bash
# Full stack
docker compose up --build

# Backend — run API
cd backend/src/Koine.API && dotnet run

# Backend — apply migrations
dotnet ef database update --project backend/src/Koine.Infrastructure --startup-project backend/src/Koine.API

# Backend — tests (single-threaded, required)
dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1

# Frontend — dev server (run manually)
cd frontend && npm run dev

# Frontend — production build
cd frontend && npm run build

# Frontend — tests (single pass)
cd frontend && npm run test

# Frontend — coverage
cd frontend && npm run test:coverage

# TS client regeneration (from repo root)
nswag run backend/nswa.json

# Coverage scripts (from repo root)
./scripts/coverage-backend-focused.sh
./scripts/coverage-backend.sh
./scripts/coverage-frontend.sh
./scripts/coverage-all.sh
```

## Environment Variables

### Frontend (`frontend/.env.local`)
- `NEXT_PUBLIC_API_URL` — public API base URL (required)
- `NEXT_PUBLIC_GRAPHQL_URL` — GraphQL endpoint (defaults to `http://localhost:5001/graphql`)
- `INTERNAL_API_URL` — internal server-side API base URL (Docker/local)
- `NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY`, `CLERK_SECRET_KEY`
- `NEXT_PUBLIC_CLERK_SIGN_IN_FALLBACK_REDIRECT_URL`, `NEXT_PUBLIC_CLERK_SIGN_UP_FORCE_REDIRECT_URL`

Template: `frontend/.env.local.example`

### Backend (`appsettings*.json` or env vars)
- `ConnectionStrings__DefaultConnection`
- `JwtSettings__SecretKey`, `JwtSettings__Issuer`, `JwtSettings__Audience`
- `ASPNETCORE_ENVIRONMENT`
