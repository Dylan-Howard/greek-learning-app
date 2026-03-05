# Sprint 0 Dead Code Inventory (Track-Only)

This inventory records likely dead or cleanup-candidate code. No removals were performed in Sprint 0 by policy.

## Candidates

1. `backend/src/Koine.Application/Class1.cs`
- Reason: template placeholder class with no business usage.
- Evidence: no references found via `rg "Koine.Application.Class1|new Class1"`.
- Target: Sprint 1 cleanup.

2. `backend/src/Koine.Domain/Class1.cs`
- Reason: template placeholder class with no domain usage.
- Evidence: no references found via `rg "Koine.Domain.Class1|new Class1"`.
- Target: Sprint 1 cleanup.

3. `backend/src/Koine.Infrastructure/Class1.cs`
- Reason: template placeholder class with no infrastructure usage.
- Evidence: no references found via `rg "Koine.Infrastructure.Class1|new Class1"`.
- Target: Sprint 1 cleanup.

4. Auth fallback TODO paths in controllers/services
- Reason: explicitly marked temporary (`TODO(next phase)`), but still part of current behavior.
- Evidence: TODO comments in API controllers and auth services.
- Target: Sprint 2 auth hardening.

5. Legacy compatibility route/data paths (`legacy/*` metadata and compatibility shims)
- Reason: migration-era compatibility logic may become removable after parity validation.
- Evidence: explicit `legacy` markers in controllers/tests.
- Target: Post-Sprint 1 parity verification.
