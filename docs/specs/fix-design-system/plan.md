# Completion Plan: Sets Routing, Sidebar
  Vocabulary, Profile MVP, and Primer Alignment

  ## Summary

  This plan resolves the reported functional
  bugs and completes a focused Primer-alignment
  pass across high-impact surfaces.

  Confirmed root issues:

  1. sets 404s are caused by route/link
     mismatch.
  2. Sidebar vocabulary list is fetched by
     chapterId only and can mismatch selected
     bookId context.
  3. Profile route is partially inconsistent (/
     profile link vs /profile/profile) and page
     is placeholder-level.
  4. Sidebar switches are custom and visually
     inconsistent with Primer conventions.
  5. There is also a hidden build blocker:
     orphaned showcase.tsx with broken imports
     that currently fails strict tsc.

  ## Missing/Unimplemented Sets Pages
  (Identified)

  1. Missing legacy-compatible route page: /sets
     (currently no src/app/**/sets/page.tsx
     outside vocabulary namespace).
  2. Missing legacy-compatible route page: /
     sets/[setId] (currently no alias route).
  3. No slug-based set details route despite DTO
     slug field (VocabularySetDto.slug) being
     available.
  4. Existing pages are implemented at:

  - sets list
  - set details

  ## Important API/Interface/Route Changes

  1. Add route aliases:

  - /sets -> redirect/render /vocabulary/sets
  - /sets/[setId] -> redirect/render /
    vocabulary/sets/[setId]

  2. Normalize all set links to canonical /
     vocabulary/sets and /vocabulary/sets/
     [setId].
  3. Sidebar vocabulary sourcing interface:

  - Replace chapter-only fetch in settings with
    source tied to active page context (bookId +
    chapter) and/or rendered unit vocabulary
    IDs.

  4. Profile route consistency:

  - Ensure /profile resolves to profile
    dashboard (redirect or move page path).

  5. Replace custom OptionCheckbox switch
     visuals with Primer-aligned switch
     component API in shared UI inputs (reused
     where switches appear).

  ## Implementation Plan

  ## Phase 1: Stabilize Build Baseline

  1. Resolve orphan file error by removing or
     migrating showcase.tsx so only showcase/
     page.tsx remains in app routing.
  2. Re-run tsc to establish clean baseline
     before feature work.

  ## Phase 2: Fix Sets Routing End-to-End

  1. Update all incorrect /sets links to
     canonical vocabulary routes in:

  - vocabulary page
  - vocabulary sets page
  - set details page

  2. Add backward-compatible alias pages:

  - src/app/(auth)/sets/page.tsx
  - src/app/(auth)/sets/[setId]/page.tsx

  3. Alias behavior:

  - Use server redirects to canonical paths to
    preserve bookmarks and old links.

  4. Optional extension in same phase:

  - Add slug route support (/vocabulary/sets/
    [slugOrId]) with numeric/slug resolver.
  - If not implemented now, document as deferred
    explicitly.

  ## Phase 3: Fix Sidebar Vocabulary
  Completeness

  1. Current issue location:

  - SettingsMenu, handleVocabularyFetch.

  2. Replace
     fetchVocabularyByChapter(activeChapterId)
     logic with page-consistent vocabulary
     retrieval:

  - Preferred: derive vocabulary IDs from
    rendered reader units for current page and
    fetch details for those roots.
  - Fallback: introduce
    fetchVocabularyByBook(bookId) + client
    filter by unit IDs if chapter endpoint
    semantics are unreliable.

  3. Ensure vocabulary list reflects all unique
     words present on the current displayed
     reader page for bookId/chapter.
  4. Keep existing search behavior, but change
     filtering to robust prefix/contains
     transliteration match on full token content
     (not strict equal of fixed-length prefix).
  5. Preserve user completion toggle behavior in
     sidebar.

  ## Phase 4: Profile MVP Functional Dashboard

  1. Fix route consistency:

  - Update nav profile destination in Nav to
    canonical profile path or add redirect
    from /profile.

  2. Upgrade Profile page from placeholder to
     MVP functional dashboard:

  - Identity: user id, display name.
  - Progress: completed lessons count, tracked
    vocabulary count.
  - Settings: translation preference and dark-
    mode preference with save.
  - Dev-user context indicator (read-only
    badge).

  3. Wire to existing user service:

  - Read via useUserContext + fetchUser
    lifecycle if needed.
  - Save via updateUser.

  4. Add optimistic UI + error feedback for
     failed saves.

  ## Phase 5: Primer-Style Switches and Broader
  Primer Sweep

  1. Implement shared Primer-aligned switch
     styling in:

  - UI Switch wrapper

  2. Replace custom switch usage:

  - Refactor OptionCheckbox to consume shared
    switch.

  3. Broader high-impact Primer targets
     (implement in this pass):

  - Reader nav structure and control density in
    Nav
  - Sidebar content hierarchy and action rows in
    SettingsMenu
  - Vocabulary set cards and list hierarchy in
    VocabularySetCard
  - Study configuration controls in
    SessionConfig
  - Lessons progress card patterns in lessons
    page
  - About page card/grid system modernization in
    about page

  4. Primer UX/UI target map (element ->
     function):

  - Navigation rail/bottom nav -> primary
    wayfinding and context switching.
  - Sidebar switches -> rapid progress marking
    and personalization.
  - Breadcrumb + headers -> orientation and
    location clarity.
  - Set cards/progress bars -> scanning learning
    progress and entry actions.
  - Study config toggles/selects -> pre-session
    decision making.
  - Profile settings controls -> trust, control,
    and persistence of user preferences.

  ## Phase 6: Validation, Regression, and
  Documentation

  1. Functional validations:

  - /vocabulary/sets loads.
  - Opening “All NT” set from card opens details
    successfully.
  - Legacy /sets and /sets/[setId] links resolve
    via alias.
  - Reader sidebar for 1 John 1 shows full
    vocabulary for displayed page.
  - Profile page reachable from nav and supports
    save flow.

  2. UI validations:

  - Switches visually consistent with Primer in
    sidebar and any reused contexts.
  - High-impact pages align to Primer spacing,
    borders, typography, and interaction cues.

  3. Automated checks:

  - npx tsc --noEmit
  - npm run build
  - npm run test
  - docker compose build (repo root)

  4. Update docs:

  - migration-log.md
  - phase-reports/phase-6.md
  - final-report.md

  ## Test Cases and Scenarios

  1. Sets routing:

  - Visit /sets directly -> redirected/rendered
    vocabulary sets.
  - Visit /sets/1 (or known id) -> redirected/
    rendered set details.
  - Click “See More” from vocabulary page -> no
    404.

  - Open system set card (“All NT”) -> details

  4. Profile MVP:

  - Navigate to profile from reader nav.
  - Edit name/settings and save -> persisted in
    current session and via API call.
  - Simulate API failure -> inline error
    handling.

  5. Primer UI:

  - Switch states: default, hover, focus-
    visible, checked, disabled.
  - Key page visual consistency in light and
    dark modes.

  ## Assumptions and Defaults

  1. Canonical vocabulary set URLs are /
     vocabulary/sets and /vocabulary/sets/
     [setId].
  2. Backward compatibility for old /sets* URLs
     is required and implemented via alias
     routes.
  3. Profile MVP will use existing user APIs and
     context without backend schema migration.
  4. Sidebar vocabulary accuracy is defined as
     “all unique words present on the rendered
     current reader page.”
  5. Primer alignment in this pass prioritizes
     high-impact surfaces, not every minor
     component across the repo.

---------

# Execution Runbook For Immediate
  Implementation

  ## Summary

  Implement in this exact order to minimize
  regressions:

  1. Stabilize build (showcase.tsx conflict).
  2. Fix sets routing and aliases.
  3. Correct sidebar vocabulary source for
     current page.
  4. Implement Profile MVP dashboard + route
     consistency.
  5. Apply Primer-aligned switch redesign and
     high-impact Primer sweep.
  6. Validate all gates and update migration
     docs.

  ## Public Interfaces / Route Changes

  1. Canonical routes remain:

  - /vocabulary/sets
  - /vocabulary/sets/[setId]

  2. Add legacy aliases:

  - /sets -> redirect to /vocabulary/sets
  - /sets/[setId] -> redirect to /vocabulary/
    sets/[setId]

  3. Profile route consistency:

  - Ensure nav points to canonical profile route
    (/profile/profile) or add /profile redirect.

  ## Step-by-Step Implementation

  ## 1. Baseline Build Fix

  1. Remove or migrate src/app/showcase.tsx (or
     exclude it cleanly) so only src/app/
     showcase/page.tsx is compiled.
  2. Verify baseline with npx tsc --noEmit.

  ## 2. Sets 404 Fixes

  1. Update all internal links currently using /
     sets:

  - src/app/(auth)/vocabulary/page.tsx
  - src/app/(auth)/vocabulary/sets/page.tsx
  - src/app/(auth)/vocabulary/sets/[setId]/
    page.tsx

  2. Create alias pages:

  - src/app/(auth)/sets/page.tsx
  - src/app/(auth)/sets/[setId]/page.tsx

  3. Alias pages should server-redirect to
     canonical routes.

  ## 3. Sidebar Vocabulary Completeness

  1. In src/components/features/reader/
     Navigation/SettingsMenu.tsx:

  - Replace chapter-only fetch logic
    (fetchVocabularyByChapter) with page-
    accurate source based on active reader
    context.
  - Use bookId + chapterId context and unique
    vocab roots from displayed reader units.

  2. Improve search matching from strict prefix-
     equality to robust contains/prefix
     transliteration match.
  3. Preserve progress toggle behavior and save/
     cancel flow.

  ## 4. Profile MVP

  1. In src/components/features/reader/
     Navigation/Nav.tsx, fix profile href
     consistency.
  2. Upgrade src/app/(auth)/profile/profile/
     page.tsx:

  - User identity card (name/id).
  - Progress summary (lessons complete,
    vocabulary tracked).
  - Settings form (translation, dark mode) with
    save via existing user API.
  - Error/success feedback and pending state.

  3. Keep within existing data contracts
     (useUserContext, updateUser).

  ## 5. Primer Alignment (Broader Sweep)

  1. Replace custom sidebar switch styling:

  - Refactor src/components/features/reader/
    Navigation/OptionCheckbox.tsx to use a
    shared Primer-style switch from src/
    components/ui/inputs/Switch.tsx.

  2. Update high-impact surfaces for Primer
     consistency:

  - src/components/features/reader/Navigation/
    Nav.tsx
  - src/components/features/reader/Navigation/
    SettingsMenu.tsx
  - src/components/features/vocabulary/
    VocabularySetCard.tsx
  - src/components/features/study/
    SessionConfig.tsx
  - src/app/(auth)/lessons/page.tsx
  - src/app/(public)/about/page.tsx

  3. Standardize:

  - Borders, radius, spacing scale, muted
    backgrounds, secondary text contrast, focus
    states.

  ## 6. Validation + Documentation

  1. Run:

  2. Manual checks:

  - Reader dictionary for 1 John 1 shows all
    vocab on page.
  - Profile page works and saves settings.
  - Switches visually align with Primer
    conventions.

  3. Update docs:
  - final-report.md

  ## Test Scenarios

  1. Route compatibility: direct-load old /sets*
     URLs.
  2. Vocab correctness: compare sidebar
     dictionary count against rendered page
     units for 1 John 1.
  3. Profile persistence: edit settings, save,
     reload, confirm state.
  4. Accessibility: keyboard toggle/focus-
     visible on switches and nav actions.
  5. Theme parity: light/dark checks on updated
     pages.

  ## Assumptions

  1. Canonical set URLs are under /vocabulary/
     sets.
  2. Legacy /sets* compatibility is required.
  3. Profile MVP uses existing API and context
     only.
  4. Primer sweep is high-impact scope, not
     full-site pixel-perfect refactor.
