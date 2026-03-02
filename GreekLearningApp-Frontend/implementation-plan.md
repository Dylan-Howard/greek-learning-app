# Implementation Plan: Design System Migration Completion

## Scope
- Complete the in-progress MUI v7 design system migration.
- Resolve all TypeScript/build blockers.
- Move `design-system/*` assets to docs reference storage.
- Enforce production compile during Docker image build.
- Provide a dedicated Docker Compose dev workflow for frontend local development.

## Policy Decisions
- `design-system/*` is reference-only and must not be part of compile scope.
- Hybrid component policy:
  - Use design-system wrappers for interactive/display primitives (`Button`, `Fab`, `TextField`, `IconButton`, etc.).
  - Keep direct MUI for low-level layout primitives and specialized controls.

## Phases
1. Foundation fixes
   - Theme typing and runtime safety for `theme.vars` usage.
   - Resolve wrapper API conflicts (`DialogComponent`, `IconButton`).
   - Ensure root theming runs in a client boundary.
2. Archive reference assets
   - Move `design-system/` to `docs/specs/design-system/reference/`.
3. Wrapper adoption
   - Migrate active app/features from direct MUI interactive imports to wrapper components.
   - Remove hardcoded color literals where encountered.
4. Docker workflows
   - Switch frontend `Dockerfile` to production multi-stage build with `npm run build`.
   - Add frontend-local `docker-compose.dev.yml` for hot reload.
   - Document commands in frontend `README.md`.
5. Validation
   - `npx tsc --noEmit`
   - `npm run build`
   - `npm run test`
   - `docker compose build` (repo root)

## Rollback
- Revert by phase commit if needed.
- Restore pre-migration state from branch/tag backups if required.
