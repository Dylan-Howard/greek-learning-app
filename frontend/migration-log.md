# Migration Log

## 2026-03-02
- Fixed blocking TS errors:
  - `DialogComponentProps.content` renamed to `dialogContent`.
  - Added `href` support behavior to wrapper `IconButton`.
  - Removed recursive `ThemeOptions` type augmentation.
- Fixed runtime/theme boundary issues:
  - Introduced client-side `AppThemeProvider`.
  - Updated theme/component overrides to safely fallback when `theme.vars` is unavailable.
- Tightened TS compile scope:
  - Updated `tsconfig.json` include/exclude to avoid reference assets entering compile.
- Moved design system artifacts:
  - `design-system/*` -> `docs/specs/design-system/reference/*`.
- Wrapper adoption pass:
  - Replaced direct MUI `Button`, `Fab`, and `TextField` imports across key app and feature pages with `@/components/shared` wrappers.
  - Replaced hardcoded onboarding option border color with theme token.
- Completion pass:
  - Replaced reader audio direct MUI icon button usage with `@/components/shared/IconButton`.
  - Replaced lesson completion direct MUI checkbox usage with `@/components/shared/Checkbox`.
  - Removed remaining reader navigation hardcoded color literals in `OptionCheckbox` and `Sidebar`.
- Removed unused legacy theme file:
  - `src/components/layout/Theme.tsx`.
- Docker workflow updates:
  - Replaced frontend `Dockerfile` with multi-stage production build (includes `npm run build`).
  - Added frontend local dev compose workflow `docker-compose.dev.yml`.
  - Added frontend `README.md` with build/dev compose commands.
