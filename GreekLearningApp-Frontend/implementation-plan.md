# Design System Migration Implementation Plan

This plan outlines the methodical implementation of the Material UI v7 design system into the Koine Greek Learning App.

## 1. Pre-Implementation Analysis Summary

- **Current MUI Version:** ^7.3.8 (Already on v7)
- **Current Theme:** Defined in `src/components/layout/Theme.tsx` (Light/Dark themes)
- **Current Global Styles:** `src/styles/globals.css`
- **MUI Usage:** Approximately 28 files use `@mui/material` components.
- **Styling Patterns:** Heavy use of `sx` prop and some custom typography settings in the current theme.

## 2. Risk Assessment & Prioritization

### LOW Risk (Simple components, minimal custom logic)
- `src/app/(public)/about/page.tsx`
- `src/app/(public)/welcome/page.tsx`
- `src/components/features/study/DashboardStats.tsx`
- `src/components/features/vocabulary/VocabularySetCard.tsx`

### MEDIUM Risk (Moderate complexity, interactive elements)
- `src/components/features/study/FlashCard.tsx`
- `src/components/features/study/MultipleChoiceCard.tsx`
- `src/components/features/study/RatingButtons.tsx`
- `src/components/features/study/SessionConfig.tsx`
- `src/components/features/vocabulary/VocabularyTable.tsx`
- `src/app/(auth)/lessons/tracks/[trackSlug]/[lessonId]/LessonCompletionToggle.tsx`

### HIGH Risk (Critical paths, complex layouts, routing integration)
- `src/app/layout.tsx` (Root layout & Theme Provider)
- `src/app/(auth)/study/session/[sessionId]/page.tsx`
- `src/app/(auth)/lessons/tracks/[trackSlug]/[lessonId]/page.tsx`
- `src/components/features/reader/Navigation/Nav.tsx`

## 3. Implementation Phases

### Phase 0: Preparation & Setup
- [ ] Create directory structure:
  - `src/theme/`
  - `src/components/ui/` (categorized: inputs, display, feedback, navigation, layout)
- [ ] Backup current state (git commit recommended).

### Phase 1: Foundation Installation
- [ ] Install new theme to `src/theme/theme.ts`.
- [ ] Install global styles to `src/styles/globals.css`.
- [ ] Split `design-system/components.tsx` into individual files in `src/components/ui/`.
- [ ] Setup barrel exports (`index.ts`) for easy importing.
- [ ] Update `src/app/layout.tsx` to use the new `ThemeProvider` and `colorSchemes`.
- [ ] Create a showcase page at `src/app/showcase/page.tsx` for verification.

### Phase 2: Core Layout & Navigation Migration
- [ ] Migrate `src/app/layout.tsx` (High Risk).
- [ ] Migrate navigation components (`Nav.tsx`, `NavRail.tsx` if applicable).

### Phase 3: Low-Risk Migration
- [ ] Migrate Public pages (About, Welcome).
- [ ] Migrate simple dashboard components.

### Phase 4: Medium-Risk Migration
- [ ] Migrate Study components (FlashCard, MultipleChoiceCard, etc.).
- [ ] Migrate Vocabulary components.

### Phase 5: High-Risk Migration
- [ ] Migrate Session and Lesson pages.
- [ ] Finalize reader components.

### Phase 6: Cleanup & Validation
- [ ] Remove `src/components/layout/Theme.tsx`.
- [ ] Remove unused styles and old MUI component direct imports where applicable.
- [ ] Full application audit (Light/Dark mode, responsive).

## 4. Rollback Strategy
- Use `git checkout .` to revert changes in the current branch.
- Revert to the `pre-migration` tag if necessary.

## 5. Testing Checkpoints
- **After Phase 1:** Verify showcase page renders all components correctly in both modes.
- **After Phase 2:** Ensure the application shell and navigation work across all pages.
- **After each component migration:** Verify visual parity and functionality.
