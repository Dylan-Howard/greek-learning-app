# MVP Monolith Verification Report

**Date:** February 25, 2026  
**Scope:** Legacy microservices (`GreekLearningApp-ReaderService`, `GreekLearningApp-TextService`, `GreekLearningApp-UserService`, `GreekLearningApp-StudyService`) vs MVP monolith (`backend/Koine.API` + `GreekLearningApp-Frontend`).

## Verification Method

1. Inventory legacy routes from Azure Function `HttpTrigger` declarations and Go router handlers.
2. Inventory monolith routes from ASP.NET controller route attributes.
3. Compare legacy routes against:
   - Monolith API routes
   - Current frontend API usage in `GreekLearningApp-Frontend/src/app/services`
4. Validate implementation by running:
   - backend NUnit suite
   - frontend Vitest suite
   - frontend production build

## Route/Feature Parity (Core MVP)

| Legacy Capability | Legacy Route | MVP Monolith Route | Status |
|---|---|---|---|
| Reader render chapter | `GET /api/reader` (Go ReaderService) | `GET /api/reader` | Pass |
| Text selection options | `GET /selections/{textId}` | `GET /api/selections/{textId}` | Pass |
| List texts | `GET /texts` | `GET /api/books` | Pass (renamed model) |
| Get text | `GET /texts/{textId}` | `GET /api/books/{id}` | Pass (renamed model) |
| List chapters for text | `GET /texts/{textId}/chapters` | `GET /api/books/{bookId}/chapters` | Pass |
| Get chapter | `GET /chapters/{chapterId}` | `GET /api/chapters/{id}` | Pass |
| Chapter words | `GET /chapters/{chapterId}/words` | `GET /api/chapters/{id}/words` | Pass |
| Vocabulary list | `GET /words` | `GET /api/words` | Pass |
| Vocabulary item | `GET /words/{rootId}` | `GET /api/words/{id}` | Pass |
| Update word | `POST /words/update` | `POST /api/words/update` | Pass |
| Lessons list | `GET /lessons` | `GET /api/lessons` | Pass |
| Lesson by ID | `GET /lessons/{lessonId}` | `GET /api/lessons/{id}` | Pass |
| Grammatical forms list | `GET /grammaticalForms` | `GET /api/grammaticalForms` | Pass |
| Grammatical form by ID | `GET /grammaticalForms/{grammarId}` | `GET /api/grammaticalForms/{id}` | Pass |
| Lessons by grammatical form | `GET /grammaticalForms/{grammarId}/lessons` | `GET /api/grammaticalForms/{id}/lessons` | Pass |
| Create grammatical form | `POST /grammaticalForms` | `POST /api/grammaticalForms` | Pass |
| Translation create (legacy simple) | `POST /translations` | `POST /api/translations` | Pass (compatibility shim) |
| User fetch | `GET /users/{id}` | `GET /api/users/{id}` | Pass |
| User lessons | `GET /users/{id}/lessons` | `GET /api/users/{id}/lessons` | Pass |
| User words | `GET /users/{id}/words` | `GET /api/users/{id}/words` | Pass |
| User settings | `GET /users/{id}/settings` | `GET /api/users/{id}/settings` | Pass |
| User create/update | `POST /users`, `POST /users/{id}` | `POST /api/users`, `PUT /api/users/{id}` | Pass (method normalized) |
| Study sets by user | `GET /users/{userId}/sets` | `GET /api/study/sets` | Pass (route normalized, user from context) |
| Study set by ID | `GET /users/{userId}/sets/{setId}` | `GET /api/study/sets/{id}` | Pass (route normalized) |

## Intentional MVP Deviations

These are not treated as regressions for current MVP scope:

1. Authentication flow is intentionally deferred.
   - Replaced with dev user switcher (`Dev User 1/2/3`) and local session cookie/storage.
   - TODO markers exist in onboarding and middleware files for next phase.
2. Some legacy TextService endpoints are not exposed as 1:1 routes in monolith:
   - `verses/*`, `units/*`, `morphologies/*`, `sets/*/members*`
   - Current frontend MVP does not depend on these endpoints.
3. Route naming normalized from `texts/*` to `books/*` in monolith and frontend adapters.

## Correctness Verdict

For **MVP core functionality (non-auth)**, the refactor is correct:

1. Core reader, vocabulary, lessons, grammatical forms, selections, and user-progress settings flows are wired and functional.
2. Major regressions found earlier (`/api/selections` and `/api/translations` legacy create) are fixed.
3. Frontend runs in auth-free MVP mode using the hardcoded dev-user session switcher.

## Validation Evidence

1. Backend tests: `50 passed, 0 failed` (`dotnet test backend/Koine.Tests/Koine.Tests.csproj`).
2. Frontend tests: `11 passed, 0 failed` (`npm run test:coverage`).
3. Frontend build: `next build` succeeds.
4. Coverage:
   - Frontend lines: `78.94%`
   - Backend focused MVP service scope: `98.58%` line coverage (`coverage-services.cobertura.xml`)
   - Backend full-monolith snapshot remains below 70% and requires additional non-MVP-layer tests.
