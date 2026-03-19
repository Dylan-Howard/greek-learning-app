# Project Structure

## Repository Root
```
/
├── backend/          # .NET solution
├── frontend/         # Next.js app
├── data/             # Seed/data transformation scripts (Python)
├── scripts/          # Coverage and local utility scripts
└── legacy-reader-service/  # Legacy reference only — do not modify
```

---

## Backend (`backend/src/`)

Clean Architecture with four projects:

```
Koine.Domain/           # No dependencies — entities, enums, value objects
Koine.Application/      # Depends on Domain — interfaces, services, DTOs, mappers
Koine.Infrastructure/   # Depends on Domain + Application — EF DbContext, repositories, migrations, seed data
Koine.API/              # Depends on Application + Infrastructure — controllers, middleware, DI wiring
```

Dependency rule: Domain ← Application ← Infrastructure ← API. Never reference a higher layer from a lower one.

### Key backend locations
- `Koine.API/Controllers/` — one controller per resource, inherits `ControllerBase`
- `Koine.API/Providers/` — `ICurrentUserProvider` implementation (reads from `HttpContext`)
- `Koine.Application/Interfaces/` — service and repository contracts
- `Koine.Application/Services/` — business logic implementations
- `Koine.Application/DTOs/` — request/response shapes, grouped by domain area
- `Koine.Application/Study/` — isolated ports-and-adapters sub-module for study sessions
- `Koine.Infrastructure/Data/Context/` — `KoineDbContext`
- `Koine.Infrastructure/Data/Seed/` — `DatabaseSeeder` + per-book text data classes
- `Koine.Infrastructure/Migrations/` — EF migrations (auto-generated, do not hand-edit)
- `backend/tests/Koine.Tests/Unit/` — unit tests (NUnit + Moq)
- `backend/tests/Koine.Tests/Integration/` — integration tests

---

## Frontend (`frontend/src/`)

Next.js App Router with route groups:

```
src/app/
  (auth)/             # Authenticated routes: lessons, reader, study, vocabulary, profile
  (client)/           # Client-only layout (onboarding)
  (public)/           # Unauthenticated routes: welcome, about, auth, legal
src/components/
  features/           # Feature-scoped components (flashcards, reader, lessons, study, vocabulary…)
  layout/             # AppShell, NavRail, providers
  shared/             # Cross-feature reusable components
src/lib/
  api/rest/           # REST fetch helpers
  api/graphql/        # GraphQL helpers (if used)
  services/           # Domain service logic (auth, flashcards, reader, user)
  types/domain/       # Shared TypeScript domain types
  utils/              # Pure utility functions
src/theme/            # MUI theme configuration
src/design-system-v2/ # Design system components (in-progress migration)
```

### Path aliases
- `@/*` → `src/*`
- `@/design-system-v2/*` → `src/design-system-v2/*`

### Component conventions
- Use `src/components/shared/` wrappers (`Button`, `TextField`, etc.) over raw MUI for interactive primitives
- Use MUI directly for layout primitives (`Box`, `Stack`, `Grid`, `Container`)
- Prefer MUI theme tokens over hardcoded values in `sx` props
- Named exports only — no default exports
