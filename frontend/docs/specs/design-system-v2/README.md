# Greek NT Reader — Component Library

Production-ready Next.js + MUI v7 components for the Greek NT Reader app.

## Stack

| Package | Version |
|---------|---------|
| Next.js | 15 (App Router) |
| React | 19 |
| MUI | **v7** |
| TypeScript | 5.4+ |

## Setup

```bash
npm install
npm run dev
```

Visit http://localhost:3000 — redirects to `/read`.

## MUI v7 Notes

Key changes from v6 applied throughout this codebase:

1. **`Grid`** is now the old `Grid2` API. Use `<Grid size={{ xs: 12, sm: 6 }}>` everywhere.
   Old `Grid` (12-column) is now `GridLegacy`.

2. **`Hidden` removed** — use `sx={{ display: { xs: 'none', md: 'block' } }}` instead.

3. **`Skeleton`, `Alert`** and other formerly-lab components now live in `@mui/material`.

4. **`StyledEngineProvider`** imports from `@mui/material/styles`, not `@mui/material`.

5. **`onBackdropClick`** on `Dialog`/`Modal` removed — handle via `onClose(event, reason)`.

6. **Deep imports banned** — `import { createTheme } from '@mui/material/styles'` only.

7. **`cssVariables: true`** in theme — use `theme.vars.*` for CSS variable references
   in performance-critical sx props.

8. **`AppRouterCacheProvider`** (from `@mui/material-nextjs`) wraps the app in `ThemeProvider.tsx`.
   `enableCssLayer` is set for Tailwind v4 / CSS layer compatibility.

9. **`slotProps`** pattern — used instead of deprecated `InputProps` on `TextField`
   (see `TransliterationSearchInput.tsx`).

10. **TypeScript** — use `TypographyVariantsOptions` / `TypographyVariants` interfaces
    (renamed from v6). Augmentations go in `src/theme/mui.d.ts`.

## Directory Structure

```
src/
├── app/                          # Next.js App Router pages
│   ├── layout.tsx                # Root layout with ThemeProvider
│   ├── page.tsx                  # Root → redirects to /read
│   ├── read/page.tsx             # Greek NT reader
│   ├── study/page.tsx            # Standalone SRS session
│   ├── vocabulary/
│   │   ├── page.tsx              # Vocab sets grid
│   │   ├── master/page.tsx       # All-words searchable table
│   │   └── [setId]/page.tsx      # Set detail + word list
│   ├── lessons/
│   │   ├── page.tsx              # Lesson list
│   │   └── [lessonId]/page.tsx   # Lesson detail with blocks
│   ├── profile/page.tsx          # Profile + progress dashboard
│   └── auth/
│       ├── login/page.tsx
│       ├── signup/page.tsx
│       └── forgot-password/page.tsx
│
├── components/
│   ├── nav/
│   │   ├── NavRail.tsx           # Desktop 72px fixed rail
│   │   ├── BottomNav.tsx         # Mobile 56px bottom bar
│   │   └── UserAvatarBadge.tsx   # Avatar + SVG XP ring + tier badge
│   ├── layouts/
│   │   ├── AppShell.tsx          # Main layout (navrail + content + sidebar)
│   │   ├── AuthShell.tsx         # Centered card auth layout
│   │   └── RTLWrapper.tsx        # LTR/RTL direction context + Emotion cache
│   ├── reader/
│   │   ├── GreekWord.tsx         # Inline word span with SRS underline states
│   │   ├── VerseDisplay.tsx      # Chapter verse renderer
│   │   ├── ChapterSelector.tsx   # Ghost-style book/chapter dropdowns
│   │   └── ChapterNavigator.tsx  # Hover-reveal margin nav arrows
│   ├── sidebar/
│   │   ├── ReaderSidebar.tsx     # Orchestrates detail ↔ study mode
│   │   ├── WordDetailPanel.tsx   # Parsing info for selected word
│   │   └── StudyLaunchPanel.tsx  # Due count + Begin Review button
│   ├── mobile/
│   │   └── BottomSheet.tsx       # 3-snap-point draggable sheet
│   ├── srs/
│   │   ├── FlashCard.tsx         # 3D CSS flip card
│   │   ├── SRSRatingButtons.tsx  # Again/Hard/Good/Easy
│   │   ├── SRSSessionProgress.tsx# Progress bar + counter
│   │   └── SRSStudyPanel.tsx     # Full study session orchestrator
│   ├── vocab/
│   │   ├── VocabSetCard.tsx      # Set summary card with progress
│   │   ├── VocabWordRow.tsx      # Table row for individual word
│   │   └── TransliterationSearchInput.tsx  # Latin→Greek search
│   ├── lessons/
│   │   ├── LessonCard.tsx        # Lesson list item
│   │   ├── LessonBlocks.tsx      # Text/Image/Video/Checkbox/MC/TextInput
│   │   └── LessonCompletionBanner.tsx
│   ├── profile/
│   │   ├── StatCard.tsx          # Metric display card
│   │   └── ActivityHeatmap.tsx   # GitHub-style reading grid
│   ├── gamification/
│   │   ├── XPToast.tsx           # Brief XP earned notification
│   │   └── TierUpModal.tsx       # Tier promotion celebration
│   ├── auth/
│   │   └── AuthForms.tsx         # Login/SignUp/ForgotPassword/GuestCTA
│   └── shared/
│       ├── PageHeader.tsx        # Title + subtitle + actions row
│       ├── EmptyState.tsx        # Empty placeholder with optional CTA
│       ├── LoadingSkeleton.tsx   # Skeleton variants for each section
│       └── ProgressChip.tsx      # SRS status chip (new/due/mastered)
│
└── theme/
    ├── theme.ts                  # MUI v7 createTheme + all design tokens
    ├── ThemeProvider.tsx         # AppRouterCacheProvider wrapper
    └── mui.d.ts                  # TypeScript module augmentation
```

## RTL Support

Wrap any page or subtree with `<RTLWrapper direction="rtl">` for Arabic.
All layout components consume `useDirection()` from this context.

Install `stylis-plugin-rtl` (already in package.json) for automatic CSS-in-JS flipping.

## Connecting Data

All pages contain `DEMO_*` constants with the expected TypeScript shapes.
Replace these with your data-fetching layer (SWR, TanStack Query, server components, etc.).
Every component exports its prop types — use them to type your API responses.
