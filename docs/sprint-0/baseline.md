# Sprint 0 Baseline (2026-03-05)

## Repo State Before Sprint 0 Restructure

- Dirty files before implementation:
  - `docs/PROJECT_STRUCTURE.md`
  - `docs/ROADMAP.md`
- Top-level app paths:
  - Frontend: `GreekLearningApp-Frontend/`
  - Backend: `backend/Koine.API`, `backend/Koine.Application`, `backend/Koine.Domain`, `backend/Koine.Infrastructure`, `backend/Koine.Tests`

## Baseline Validation

- Backend tests: `dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1`
  - Result: Passed (70/70)
- Frontend tests: `cd GreekLearningApp-Frontend && npm run test -- --run`
  - Result: Passed (24/24)

## Baseline Drift Highlights

- Root `README.md` still describes legacy microservices/Azure Functions architecture.
- Steering docs contain conflicting Supabase-first and monolith-.NET directives.
- Path drift exists across scripts/docs (`frontend` and backend direct child projects).
