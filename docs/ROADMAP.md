# Koine Development Roadmap

**Project Vision:** A comprehensive Greek and Hebrew language learning platform with text reading, SRS study workflows, structured lessons, and shared quiz/practice capabilities.

**Development Philosophy:** Incremental delivery, feature-complete sprints, dog-food principle (use while building).

**Last Updated:** 2026-03-05

---

## Status Legend

- `✅ Complete`
- `🟡 In Progress`
- `🟠 Partial / Out-of-order`
- `⬜ Planned`

---

## Sprint Overview

| Sprint | Duration | Focus | Status |
|--------|----------|-------|--------|
| Sprint 0 | 1 week | Foundation & Architecture | 🟡 In Progress |
| Sprint 1 | 2 weeks | Reader MVP Hardening | 🟡 In Progress |
| Sprint 2 | 2 weeks | Auth & Azure Migration | ⬜ Planned |
| Sprint 3 | 2 weeks | Flashcard/Study MVP | 🟠 Partial / Out-of-order |
| Sprint 4 | 2 weeks | Flashcard/Study Enhancement | ⬜ Planned |
| Sprint 5 | 2 weeks | Lessons System Phase 1 | 🟠 Partial / Out-of-order |
| Sprint 6 | 2 weeks | Lessons System Phase 2 | ⬜ Planned |
| Sprint 7 | 2 weeks | Questions Engine Foundation | ⬜ Planned |
| Sprint 8 | 2 weeks | Questions Engine Enhancement | ⬜ Planned |
| Sprint 9 | 2 weeks | Admin Portal & Content Ops | ⬜ Planned |
| Sprint 10 | 2-3 weeks | Polish & Launch Prep | ⬜ Planned |

**Total Timeline:** Target remains ~22 weeks, but sequence is now explicitly progress-driven.

---

## Current State Snapshot (2026-03-05)

### Already Implemented (Cross-sprint)

- Backend reader stack and endpoints are live (`ReaderController`, books/chapters/translations/units).
- Vocabulary set API surface exists (`VocabularySetsController`, set item/progress operations).
- Study/session foundations exist (`StudyController`, `StudySessionsController`, FSRS scheduler, progress endpoints).
- Lessons foundations exist (`LessonsController`, track/list/detail/complete flow).
- Frontend routes exist for reader, vocabulary sets, lessons, and study sessions.
- Occurrence-based vocabulary data seeding is in place (`greeknt-occurrences.json` + seeder integration).
- Baseline backend and frontend unit/service tests exist.

### Still Missing or Incomplete

- Reader production hardening (render edge-case validation, performance pass, integration test coverage).
- Reader desktop default UX behavior (study tab default-open behavior).
- Reader footer source/copyright attribution implementation.
- Full auth hardening and production cloud migration.
- Full questions/quiz engine and admin operations tooling.

---

## Sprint 0: Foundation & Architecture

**Goal:** Keep architecture/docs aligned with actual implementation.

**complete-phase-0**

### Completed

- [x] Core architecture ADRs and system docs authored.
- [x] Monolith backend structure established.
- [x] Local database and compose-based development environment established.

### Remaining

- [x] Complete backend folder/namespace cleanup per target structure.
- [x] Complete frontend folder/namespace cleanup per target structure.
- [x] Finalize environment variable docs and setup docs consistency.
- [x] Resolve remaining documentation drift across `README.md`, steering docs, and roadmap.
- [x] Dead code inventory created; removals deferred to next sprint by policy.

**Exit Criteria:** Foundational docs reflect current architecture and no longer conflict with implementation reality.

---

## Sprint 1: Reader MVP Hardening (Current Sprint)

**Goal:** Close production-readiness gaps for Reader MVP and vocabulary-set workflow.

### Items Already Done

- [x] Reader route and core rendering flow implemented.
- [x] Vocabulary sets CRUD + progress endpoints implemented.
- [x] Vocabulary sets list/detail frontend integration implemented.
- [x] Occurrence count seeding pipeline integrated.
- [x] Baseline API client error handling/tests in place.

### Must-Ship Remaining Scope

#### Backend

- [ ] Validate/fix text rendering edge cases (punctuation, unit boundaries, formatting consistency).
- [ ] Add integration tests for reader and vocabulary-set endpoints.
- [ ] Run reader query/performance pass and add missing indexes where justified.
- [ ] Verify stable behavior across representative NT chapters.

#### Frontend

- [ ] Set `Study` sidebar panel as default-open on desktop reader.
- [ ] Add source/copyright attribution store and muted footer display in reader.
- [ ] Complete reader mobile QA pass and fix critical bugs.
- [ ] Ensure no console/runtime errors in core reader flow.

#### Quality Gate

- [ ] Resolve all P1 reader bugs.
- [ ] Confirm no regressions in study and vocabulary-set progression flows.

### Explicitly Deferred Beyond Sprint 1

- Keyboard shortcuts and advanced reader interaction polish.
- Additional details panel enrichment beyond MVP.
- Non-critical UX animations and visual polish.

### Sprint 1 Exit Criteria

- Reader can load and render supported chapters without known critical defects.
- Vocabulary set list/detail/progress flow works end-to-end.
- Integration tests exist and pass for critical reader + vocab-set API paths.
- Reader flow is stable on desktop and mobile.

### Sprint 1 Progress Log

| Date | Area | Update | Status |
|------|------|--------|--------|
| 2026-03-05 | Planning | Sprint 1 scope narrowed to Reader MVP hardening and lock criteria defined. | ✅ |
| 2026-03-05 | Roadmap | Roadmap refreshed to reflect out-of-order progress and current implementation state. | ✅ |

---

## Sprint 2: Auth & Azure Migration

**Goal:** Production-grade authentication and cloud data reliability.

- [ ] Complete auth strategy hardening and remove dev-only fallback assumptions.
- [ ] Finish cloud DB migration tasks and environment consistency checks.
- [ ] Ensure user progress persistence and account lifecycle flows are robust.
- [ ] Add migration/runbook documentation.

**Exit Criteria:** Auth and cloud DB are production-ready for core reader/study/lesson flows.

---

## Sprint 3: Flashcard/Study MVP

**Status Note:** Core study/session foundations were started early; this sprint completes MVP productization.

- [ ] Complete user-facing study deck flow and due-card ergonomics.
- [ ] Finalize SRS workflow behavior and session summaries.
- [ ] Ensure seed coverage for practical study usage.
- [ ] Expand test coverage for study APIs and key frontend flows.

---

## Sprint 4: Flashcard/Study Enhancement

- [ ] Collections/deck enhancements and session controls.
- [ ] Improved analytics and progress visualizations.
- [ ] Performance tuning for larger sets.

---

## Sprint 5: Lessons System Phase 1

**Status Note:** Lessons endpoints/pages exist; sprint focuses on completion and quality.

- [ ] Finalize lesson/module domain behaviors and progression rules.
- [ ] Harden lesson completion and path progress tracking.
- [ ] Expand lesson content and acceptance tests.

---

## Sprint 6: Lessons System Phase 2

- [ ] Rich media/content improvements.
- [ ] Better lesson navigation and continuity features.
- [ ] Broader curriculum expansion.

---

## Sprint 7: Questions Engine Foundation

**Goal:** Introduce a shared questions engine usable by both Study and Lessons quiz modules.

### Core Engine

- [ ] Create shared question domain (`Question`, `QuestionAttempt`, `QuestionSession`, `QuestionType`).
- [ ] Add reusable engine APIs for session generation, submission, and scoring.
- [ ] Integrate engine into Study service and Lessons quiz modules.

### Required Question Types

- [ ] Drag-and-drop.
- [ ] Multiple choice.
- [ ] Fill in the blank (translation-oriented).

### Grading Foundation

- [ ] Implement rule-based grading baseline.
- [ ] Define grading provider interface (`ITranslationGrader`) for future AI grading plug-in.

**Exit Criteria:** Shared engine is live and used in both Study and Lessons contexts for MVP quizzes.

---

## Sprint 8: Questions Engine Enhancement

**Goal:** Improve question quality, adaptivity, and grading intelligence.

- [ ] Add adaptive difficulty and weak-area targeting.
- [ ] Improve distractor quality and explanations.
- [ ] Implement AI translation grading provider for fill-in-the-blank answers.
- [ ] Add analytics dashboards for question outcomes and mastery trends.

---

## Sprint 9: Admin Portal & Content Operations

**Goal:** Provide internal tooling for content management and publishing workflows.

### Admin Panels

- [ ] Lessons content editor.
- [ ] Study/question bank editor.
- [ ] Vocabulary set and metadata editor.
- [ ] User/admin management and audit logs.

### Related Content System

- [ ] Add `RelatedContent` tagging model and CRUD.
- [ ] Add admin workflows to attach related tags/resources.
- [ ] Surface related content tags/resources in Reader `Details` panel.

**Exit Criteria:** Admins can safely manage content and related-content metadata without direct database edits.

---

## Sprint 10: Polish & Launch Prep

- [ ] End-to-end quality pass (critical paths and device matrix).
- [ ] CI/CD hardening and deployment runbooks.
- [ ] Performance tuning and reliability checks.
- [ ] User and developer documentation completion.

---

## Planned Public Interfaces (Upcoming)

### Questions Engine Interfaces

- `Question`
- `QuestionAttempt`
- `QuestionSession`
- `QuestionType` (`DragDrop`, `MultipleChoice`, `FillBlankTranslation`)
- `ITranslationGrader` (rule-based and AI-backed providers)

### Planned API Surface Additions

- `/api/questions/*`
- `/api/lessons/{id}/quiz/*`
- Study session hooks for question-based flows
- Related-content endpoints for details panel retrieval and tagging workflows

---

## Acceptance Test Scenarios (Roadmap-level)

### Reader MVP

- Rendering correctness for punctuation, nested unit boundaries, and verse transitions.
- Reader loads/changes chapters without regression or runtime errors.
- Desktop default-open study panel behavior is consistent.
- Mobile reader usability passes baseline QA.

### Vocabulary Sets

- Set list/detail endpoints return expected counts/progress.
- Progress updates persist and are reflected in UI.
- Error states are handled without breaking core flow.

### Questions Engine (Future)

- Shared engine serves both Study and Lessons quiz contexts.
- Each question type can be delivered, answered, and graded.
- Fill-blank translation grading supports both baseline and AI-backed modes.

### Admin & Related Content (Future)

- Admin CRUD and publishing workflow validated.
- Related tags/resources appear correctly in Reader Details panel.

---

## Key Risks and Mitigation

| Risk | Impact | Likelihood | Mitigation |
|------|--------|------------|------------|
| Sprint spillover from out-of-order work | Medium | High | Keep sprint exit criteria strict and focus on must-ship scope |
| Reader quality regressions | High | Medium | Add integration coverage and chapter-level regression checks |
| Scope creep in questions/admin phases | High | Medium | Keep Sprint 7/8/9 contracts explicit and defer non-critical UX extras |
| Documentation drift | Medium | High | Update roadmap and steering docs as part of sprint definition-of-done |

---

## Notes

- Sprint timing remains flexible; exit criteria and quality gates are authoritative.
- Reader MVP hardening takes priority before adding more UX extras.
- Questions Engine is intentionally shared across Study and Lessons to avoid duplicate logic.
- Admin-related content tooling is prioritized as a future operational capability, not Sprint 1 scope.
