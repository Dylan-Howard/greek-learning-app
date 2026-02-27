# Implementation Plan: Design System Migration (MUI v7)

## 1. Pre-Implementation Analysis

### Current State Assessment
- **MUI Version**: 7.3.8 (Upgraded)
- **Theme**: New theme with CSS variable support (`colorSchemes`) implemented in `src/theme/theme.ts`.
- **Global Styles**: Modern MD3/Primer-inspired styles implemented in `src/styles/globals.css`.
- **Components**: UI components have been split into `src/components/ui/` but are currently failing compilation due to TypeScript errors.
- **Root Configuration**: `src/app/layout.tsx` is updated to use the new `ThemeProvider` and `InitColorSchemeScript`.

### Component Usage Mapping
- **UI Components**: Located in `src/components/ui/`.
- **Existing Usage**: Core app pages (e.g., `src/app/(auth)/lessons/page.tsx`) still use standard MUI imports or old theme references.
- **Showcase**: `src/app/showcase/page.tsx` exists to verify component rendering.

### Breaking Change Analysis
- **Grid Migration**: `Grid2` is removed/renamed to `Grid` in MUI v7, but code still references `Grid2`.
- **Theme Variables**: `theme.vars` is used but requires TypeScript augmentation to be recognized as defined.
- **Prop Conflicts**: `DialogComponentProps` redefines `content` which conflicts with base `DialogProps`. `IconButton` is missing `href` in its interface.

### Risk Assessment
- **LOW**: UI components in `src/components/ui/`, `src/app/showcase/`.
- **MEDIUM**: Auth forms (`SignInForm`, `SignUpForm`), Navigation rail (`NavRail`), Layout (`AppShell`).
- **HIGH**: Feature pages (`lessons`, `vocabulary`, `study`) that rely on complex layouts and state.

---

## 2. Implementation Phases

### Phase 1: Foundation Fixes (Current Priority)
1. **Fix Grid Imports**: Replace `Grid2 as Grid` with `Grid` in all UI components and feature pages.
2. **Augment Theme Types**: Update `src/theme/theme.ts` with type declarations for `theme.vars`.
3. **Resolve Component Prop Errors**:
   - Rename `content` to `dialogContent` in `DialogComponent`.
   - Add `href` to `IconButtonProps`.
4. **Validation**: Run `npx tsc --noEmit` until error count is 0.

### Phase 2: Core Layout Migration
1. Update `AppShell` and `NavRail` in `src/app/(auth)` to use the new UI components.
2. Verify responsive behavior and dark mode switching.

### Phase 3: Feature Page Migration (Incremental)
1. **Lessons & Tracks**: Update lesson pages to use new `ProseBlock`, `KoineCard`, and `AcknowledgementButton`.
2. **Vocabulary**: Update tables and cards to use new `Card` and `ProgressCard`.
3. **Study Session**: Update study interface to use new `MultipleChoice` and `GreekTextUnit`.

### Phase 4: Cleanup & Optimization
1. Remove old theme files in `src/components/layout/Theme.tsx`.
2. Final visual audit and performance check.

---

## 3. Testing & Validation Strategy
- **Type Safety**: Continuous monitoring with `tsc`.
- **Visual Regression**: Use the `/showcase` page as a reference for all UI components.
- **Light/Dark Mode**: Verify all color tokens correctly resolve in both modes.

## 4. Rollback Strategy
- Branch: `feature/design-system-migration`
- Backup Tag: `pre-design-system-migration`
- Use `git restore` or `git checkout` to revert specific file changes if regressions occur.
