# Design System v2 Migration Tracker

Last Updated: 2026-03-18

## Status Summary
- Demo page: Complete
- Component mapping: Mostly complete
- Page migrations: Complete

## Phase Checklist
- [x] Copy v2 components and theme into `src/design-system-v2/`
- [x] Add `/design-system-v2` demo route
- [x] Enable MUI CSS layer support via `AppRouterCacheProvider` options
- [ ] Finalize component mapping (legacy -> v2)
- [x] Migrate shared layout components (AppShell/NavRail/BottomNav)
- [x] Migrate Reader pages
- [x] Migrate Study pages
- [x] Migrate Vocabulary pages
- [x] Migrate Lessons pages
- [x] Migrate Profile pages
- [x] Migrate Auth pages
- [x] Decide on landing/public page migration

## Component Mapping Matrix
| Legacy Component | v2 Component | Status | Notes |
| --- | --- | --- | --- |
| `layout/AppShell` | `design-system-v2/components/layouts/AppShell` | Complete | AppShellV2 wrapper |
| `layout/NavRail` | `design-system-v2/components/nav/NavRail` | Complete | Route map updated |
| `features/reader/ReaderInterface` | `design-system-v2/components/reader/*` | Complete | ReaderV2Client + adapters |
| `features/study/FlashCard` | `design-system-v2/components/srs/FlashCard` | Complete | Study session swap |
| `features/study/RatingButtons` | `design-system-v2/components/srs/SRSRatingButtons` | Complete | Rating enum aligned |
| `features/study/SessionConfig` | `design-system-v2/components/srs/SessionConfigPanel` | Complete | v2 panel added |
| `features/study/DashboardStats` | `design-system-v2/components/srs/StudyDashboardStats` | Complete | v2 dashboard added |
| `features/study/MultipleChoiceCard` | `design-system-v2/components/srs/MultipleChoiceCard` | Complete | v2 MC card added |
| `features/vocabulary/VocabularySetCard` | `design-system-v2/components/vocab/VocabSetCard` | Complete | Data shape mapped |
| `features/vocabulary/VocabularyTable` | `design-system-v2/components/vocab/VocabWordRow` | Complete | Table rendering updated |
| `shared/auth/SignInForm` | `design-system-v2/components/auth/LoginForm` | Complete | Auth pages now use v2 AuthForms |
| `shared/auth/SignUpForm` | `design-system-v2/components/auth/SignUpForm` | Complete | Auth pages now use v2 AuthForms |
| `shared/Skeletons` | `design-system-v2/components/shared/LoadingSkeleton` | Complete | Added details/settings skeletons |
| `shared/feedback/Alert` | `design-system-v2/components/shared/Alert` | Complete | MUI v7 Alert wrapper |
| `shared/feedback/Dialog` | `design-system-v2/components/shared/Dialog` | Complete | v7 onClose reason handling |
| `shared/display/Card` | `design-system-v2/components/shared/Card` | Complete | Tokenized v2 card helpers |
| `shared/content/ProseBlock` | `design-system-v2/components/shared/ProseBlock` | Complete | Tokenized prose container |
| `shared/OnboardingOptionBox` | `design-system-v2/components/onboarding/OnboardingOptionBox` | Complete | v2 onboarding option box |
| `shared/OnboardingIllustrations` | `design-system-v2/components/onboarding/OnboardingIllustrations` | Complete | v2 re-export for assets |
| `features/landing/*` | No v2 equivalent | Open | Legacy landing components only used in showcase |

## Page Migration Checklist
| Page | Path | Status | Notes |
| --- | --- | --- | --- |
| Reader | `src/app/(auth)/reader/[[...page]]/page.tsx` | Complete | ReaderV2Client + v2 components |
| Study Home | `src/app/(auth)/study/page.tsx` | Complete | StudyDashboardStats v2 |
| Study Session | `src/app/(auth)/study/session/page.tsx` | Complete | SessionConfigPanel v2 |
| Vocabulary Sets | `src/app/(auth)/vocabulary/sets/page.tsx` | Complete | VocabSetCard grid |
| Vocabulary Set | `src/app/(auth)/vocabulary/sets/[setId]/page.tsx` | Complete | VocabWordRow table |
| Lessons | `src/app/(auth)/lessons/page.tsx` | Complete | LessonTrackCard v2 |
| Lesson Detail | `src/app/(auth)/lessons/tracks/[trackSlug]/[lessonId]/page.tsx` | Complete | TextBlock applied |
| Profile | `src/app/(auth)/profile/page.tsx` | Complete | StatCard + ActivityHeatmap |
| Auth Login | `src/app/(public)/auth/*` | Complete | v2 AuthForms + public routes |

## Open Questions
- Do any legacy components need to be retained for feature parity?
- Should the legacy landing showcase components be kept or removed?

## Missing v2 Equivalents (Used in App)
**Remaining:**
- Gamification: `shared/ExpGainAnimation` (used in legacy reader nav)

**Legacy/Showcase-only:**
- Landing: `features/landing/Hero`, `FeatureSection`, `Footer` (no v2 equivalent; showcase only)

## Proposed v2 Additions
1. **Reader panels and controls**
   - `reader/ReaderTopBar` (title, audio button, controls)
   - `reader/ReaderSettingsPanel` (toggles + options)
   - `reader/ReaderDetailsPanel` (word/lemma detail, audio, parsing)
   - `reader/ReaderStudyPanel` (wraps SRSStudyPanel with context)
2. **Study flow components**
   - `srs/SessionConfigPanel` (implemented)
   - `srs/MultipleChoiceCard` (implemented)
   - `srs/StudyDashboardStats` (implemented)
3. **Input primitives**
   - Use MUI v7 components directly (no v2 wrappers)
4. **Feedback primitives**
   - v2 Alert/Dialog wrappers now available
5. **Misc UI**
   - `shared/ExpGainAnimation` optional; can be replaced by XPToast/TierUpModal

## Design System v2-only Features Not Yet Implemented
- `gamification/XPToast` and `gamification/TierUpModal` not wired to real XP events.
- `profile/ActivityHeatmap` uses empty data (no backend activity feed).
- `lessons/LessonCompletionBanner` not wired to completion flow.
- `reader/BottomSheet` + mobile word details do not fetch real SRS status.
- `srs/SRSSessionProgress` intervals are placeholders (backend does not provide interval strings).
