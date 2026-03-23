---
inclusion: always
---

# Project Structure

## Repository Root

```
/
├── backend/                  # .NET solution (Clean Architecture)
├── frontend/                 # Next.js 16 App Router app
├── data/                     # Seed/data transformation scripts (Python)
├── scripts/                  # Coverage and local utility scripts
└── legacy-reader-service/    # Legacy reference only — do not modify
```

---

## Backend (`backend/src/`)

Clean Architecture with four projects and strict unidirectional dependencies:

```
Koine.Domain/           # Entities, enums, value objects — no external dependencies
Koine.Application/      # Interfaces, services, DTOs, mappers — depends on Domain only
Koine.Infrastructure/   # EF DbContext, repositories, migrations, seed data — depends on Domain + Application
Koine.API/              # Controllers, middleware, DI wiring — depends on Application + Infrastructure
```

Dependency direction: `Domain ← Application ← Infrastructure ← API`. Never reference a higher layer from a lower one.

### Key locations

| Path | Purpose |
|---|---|
| `Koine.API/Controllers/` | One controller per resource; inherits `ControllerBase` |
| `Koine.API/Providers/` | `ICurrentUserProvider` — reads identity from `HttpContext` |
| `Koine.Application/Interfaces/` | Service and repository contracts |
| `Koine.Application/Services/` | Business logic implementations |
| `Koine.Application/DTOs/` | Request/response shapes, grouped by domain area |
| `Koine.Application/Study/` | Isolated ports-and-adapters sub-module for study sessions |
| `Koine.Infrastructure/Data/Context/` | `KoineDbContext` |
| `Koine.Infrastructure/Data/Seed/` | `DatabaseSeeder` + per-book text data classes |
| `Koine.Infrastructure/Migrations/` | EF migrations — auto-generated, never hand-edit |
| `backend/tests/Koine.Tests/Unit/` | Unit tests (NUnit + Moq) |
| `backend/tests/Koine.Tests/Integration/` | Integration tests |

### Backend conventions

- New features follow this layer order: Domain entity → Application interface + DTO → Infrastructure implementation → API controller
- Use `ILogger<T>` for all logging — never `Console.Write` in production paths
- XML doc comments on all `public` members
- Use `record` types for immutable DTOs; prefer primary constructors
- EF migrations are auto-generated — never hand-edit files in `Koine.Infrastructure/Migrations/`

---

## Frontend (`frontend/src/`)

Next.js 16 App Router with route groups and feature-scoped components:

```
src/app/
  (auth)/             # Authenticated routes: lessons, reader, study, vocabulary, profile
  (client)/           # Client-only layout (onboarding)
  (public)/           # Unauthenticated routes: welcome, about, auth, legal
src/components/
  features/           # Feature-scoped components (flashcards, reader, lessons, study, vocabulary…)
  layout/             # AppShell, NavRail, providers
  shared/             # Cross-feature reusable UI primitives
  public/             # Components for public/unauthenticated pages
src/lib/
  api/rest/           # REST fetch helpers
  api/graphql/        # GraphQL helpers
  hooks/              # Shared React hooks
  services/           # Domain service logic (auth, flashcards, reader, user)
  stores/             # Client state stores
  types/domain/       # Shared TypeScript domain types
  types/api.ts        # API-level type definitions
  utils/              # Pure utility functions
src/theme/            # MUI theme configuration
src/design-system-v2/ # Design system components (in-progress migration)
src/styles/           # Global styles
src/test/             # Test utilities and setup
```

### Path aliases

- `@/*` → `src/*`
- `@/design-system-v2/*` → `src/design-system-v2/*`

### Frontend conventions

- Named exports only — no default exports anywhere
- Use `src/components/shared/` wrappers (`Button`, `TextField`, etc.) for interactive primitives — not raw MUI
- Use MUI directly for layout primitives (`Box`, `Stack`, `Grid`, `Container`)
- Prefer MUI theme tokens over hardcoded values in `sx` props
- New feature UI goes under `src/components/features/<feature-name>/`
- New routes go under the appropriate App Router group: `(auth)`, `(client)`, or `(public)`
- `strict` TypeScript mode — `any` is banned; use `unknown` + type guards
- `src/design-system-v2/` is an in-progress migration — prefer it over legacy components when available, but do not break existing usage
