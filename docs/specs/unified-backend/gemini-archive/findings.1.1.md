I've completed my analysis and confirmed that the `ReaderService` does not have direct database access. It's a stateless, anonymous Azure Function that relies on a single `POST /api/reader` endpoint and an external backend API for its "reader" experience.

I've noted potential issues, such as the `fetch` function's `log.Fatalln(err)` which could crash the entire handler if the backend is down. The service is primarily an aggregator, and while it allows an `Authorization` header in its CORS configuration, it doesn't seem to validate it within the Go code.

I'm ready to present my findings.

### Analysis

The `GreekLearningApp-ReaderService` is a lightweight Go-based Azure Function Custom Handler designed to provide a personalized reading experience. It acts as a specialized Backend-for-Frontend (BFF) that orchestrates calls to multiple backend microservices (via an Azure API Management gateway) to render Greek text tailored to a user's current learning progress. 

The service is structurally simple, consisting of a single Go file (`handler.go`) that implements a "Tutor" logic. This logic determines whether to display the original Greek text, add grammatical help (abbreviations and roots), or provide an English translation for each word (unit) based on the user's completed lessons and known vocabulary. Notably, the service is stateless and does not interact with a database directly; instead, it consumes data from a REST API. Error handling is present but relatively rigid, with some upstream failures triggering a process-level fatal error.

### Plan

1. **API Endpoints Inventory**
   - Document `POST /api/reader` (Handled by `handlePageRequest`)
     - Input: `PageRequest { ChapterId: int, UserId: string }`
     - Output: `Page { Selection: SelectionOptions, Title: string, Text: []TextUnit }`
   - Document `ANY /` (Handled by `handleOther`)
     - Purpose: Reflects request URL for debugging or health checks.
   - Note `anonymous` auth level in `function.json` and CORS headers allowing `Authorization`.

2. **Core Business Logic Documentation**
   - Detail the `Tutor` rendering logic:
     - Word-level recognition check against `User.Progress`.
     - `UnitLessons` mapping to map morphology IDs to lesson IDs.
     - Triple-state rendering (Greek, Greek + Help, Translation).
   - List external API dependencies (APIM: `koine.azure-api.net`).

3. **Database Interactions (Zero-State)**
   - Confirm no direct DB access.
   - Explain that data is entirely fetched from upstream REST services.

4. **Key Features Summary**
   - Personalized Reading: Real-time adaptation of text based on user progress.
   - Grammatical Hint Generation: Dynamic string building for word abbreviations.
   - Guest User Support: Fallback logic for unauthenticated users.

5. **Edge Cases & Error Handling Report**
   - Upstream service failure (returns `424 Failed Dependency`).
   - JSON decoding errors (returns `400 Bad Request`).
   - Drastic error handling in `fetch` (`log.Fatalln`) which can lead to service instability if the backend is unavailable.

6. **Present findings for approval.**