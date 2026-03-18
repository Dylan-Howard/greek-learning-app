# Design System v2 Migration Tracker

Last Updated: 2026-03-17

## Status Summary
- Demo page: Complete
- Component mapping: In progress
- Page migrations: Not started

## Phase Checklist
- [x] Copy v2 components and theme into `src/design-system-v2/`
- [x] Add `/design-system-v2` demo route
- [x] Enable MUI CSS layer support via `AppRouterCacheProvider` options
- [ ] Finalize component mapping (legacy -> v2)
- [ ] Migrate shared layout components (AppShell/NavRail/BottomNav)
- [ ] Migrate Reader pages
- [ ] Migrate Study pages
- [ ] Migrate Vocabulary pages
- [ ] Migrate Lessons pages
- [ ] Migrate Profile pages
- [ ] Migrate Auth pages
- [ ] Decide on landing/public page migration

## Component Mapping Matrix
| Legacy Component | v2 Component | Status | Notes |
| --- | --- | --- | --- |
| `layout/AppShell` | `design-system-v2/components/layouts/AppShell` | Not started | Layout shell swap |
| `layout/NavRail` | `design-system-v2/components/nav/NavRail` | Not started | Includes avatar badge |
| `features/reader/ReaderInterface` | `design-system-v2/components/reader/*` | Not started | Split across ChapterSelector/VerseDisplay/Sidebar |
| `features/study/FlashCard` | `design-system-v2/components/srs/FlashCard` | Not started | Prop alignment needed |
| `features/study/RatingButtons` | `design-system-v2/components/srs/SRSRatingButtons` | Not started | Rating enum alignment |
| `features/vocabulary/VocabularySetCard` | `design-system-v2/components/vocab/VocabSetCard` | Not started | Data shape match |
| `features/vocabulary/VocabularyTable` | `design-system-v2/components/vocab/VocabWordRow` | Not started | Replace row rendering |
| `shared/auth/SignInForm` | `design-system-v2/components/auth/LoginForm` | Not started | Submit handlers updated |
| `shared/auth/SignUpForm` | `design-system-v2/components/auth/SignUpForm` | Not started | Submit handlers updated |
| `shared/Skeletons` | `design-system-v2/components/shared/LoadingSkeleton` | Not started | Replace skeleton components |
| `shared/feedback/Alert` | MUI v7 Alert | Not started | Use @mui/material Alert |
| `shared/feedback/Dialog` | MUI v7 Dialog | Not started | Update onClose handling |
| `shared/display/Card` | MUI Card + v2 tokens | Not started | Evaluate usage |
| `shared/content/ProseBlock` | v2 `TextBlock`/`PageHeader` | Not started | Map to new patterns |
| `features/landing/*` | No v2 equivalent | Open | Decide keep legacy or redesign |

## Page Migration Checklist
| Page | Path | Status | Notes |
| --- | --- | --- | --- |
| Reader | `src/app/(auth)/reader/[[...page]]/page.tsx` | Not started | Replace ReaderInterface usage |
| Study Home | `src/app/(auth)/study/page.tsx` | Not started | Build using v2 SRS components |
| Study Session | `src/app/(auth)/study/session/page.tsx` | Not started | Swap FlashCard/SRS controls |
| Vocabulary Sets | `src/app/(auth)/vocabulary/sets/page.tsx` | Not started | Use VocabSetCard grid |
| Vocabulary Set | `src/app/(auth)/vocabulary/sets/[setId]/page.tsx` | Not started | Use VocabWordRow table |
| Lessons | `src/app/(auth)/lessons/page.tsx` | Not started | Use LessonCard list |
| Lesson Detail | `src/app/(auth)/lessons/tracks/[trackSlug]/[lessonId]/page.tsx` | Not started | Use LessonBlocks and banner |
| Profile | `src/app/(auth)/profile/page.tsx` | Not started | Use StatCard and ActivityHeatmap |
| Auth Login | `src/app/(public)/welcome/page.tsx` or auth pages | Not started | Decide route mapping |

## Open Questions
- Which landing/public pages should adopt v2 styles versus staying legacy?
- Do any legacy components need to be retained for feature parity?

## Missing v2 Equivalents (Used in App)
**High priority (blocks page migration):**
- Reader navigation stack: `features/reader/Navigation/*` (Nav, Sidebar, DetailsMenu, SettingsMenu, ReaderStudyMenu, WordAudioButton, OptionCheckbox)
- Study flow: `features/study/SessionConfig`, `features/study/MultipleChoiceCard`, `features/study/DashboardStats`
- Inputs wrappers: `shared/inputs/*` (Button w/ loading, TextField w/ count, IconButton, Fab, Select, Switch, Checkbox, ToggleButtonGroup)
- Feedback wrappers: `shared/feedback/Dialog`, `shared/feedback/Alert`
- Skeletons used by reader settings/details: `shared/Skeletons` (DetailsSkeleton, SettingsMenuTabSkeleton)

**Medium priority (used on public/landing):**
- Landing: `features/landing/Hero`, `FeatureSection`, `Footer`
- Onboarding: `shared/OnboardingOptionBox`, `shared/OnboardingIllustrations`

**Lower priority / optional:**
- Display helpers: `shared/display/Card`, `KoineCard`, `ProgressCard`
- Content helpers: `shared/content/ProseBlock`
- Gamification: `shared/ExpGainAnimation` (used in reader nav)

## Proposed v2 Additions
1. **Reader panels and controls**
   - `reader/ReaderTopBar` (title, audio button, controls)
   - `reader/ReaderSettingsPanel` (toggles + options)
   - `reader/ReaderDetailsPanel` (word/lemma detail, audio, parsing)
   - `reader/ReaderStudyPanel` (wraps SRSStudyPanel with context)
2. **Study flow components**
   - `srs/SessionConfigPanel` (port of SessionConfig with v2 tokens)
   - `srs/MultipleChoiceCard` (port with v2 typography + button styling)
   - `srs/StudyDashboardStats` (port of DashboardStats using StatCard + v2 progress)
3. **Input primitives (v2 wrappers)**
   - `shared/inputs/Button` (loading state)
   - `shared/inputs/TextField` (character count)
   - `shared/inputs/Select`, `Checkbox`, `Switch`, `IconButton`, `Fab`, `ToggleButtonGroup`
4. **Feedback primitives**
   - `shared/feedback/Dialog` (v7 onClose reason handling)
   - `shared/feedback/Alert` (consistent tokenized styling)
5. **Misc UI**
   - `shared/Skeletons` (DetailsSkeleton, SettingsMenuTabSkeleton)
   - `landing/Hero`, `landing/FeatureSection`, `landing/Footer` (if adopting v2 on public pages)
   - `shared/ExpGainAnimation` (optional; can be replaced by XPToast/TierUpModal)
