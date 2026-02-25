# Koine SRS Flash Card Feature — Requirements & Design Document

> **Audience:** AI agent performing implementation.  
> **Stack:** .NET 10 · EF Core 9 · MSSQL · Next.js 16+ · MUI v7  
> **Architecture:** Hexagonal (Ports & Adapters) for the Study service.  
> **Algorithm:** FSRS (Free Spaced Repetition Scheduler) v5  
> **Auth:** Hardcoded single user (stub; designed to be replaced by real identity later)  

---

## 1. Overview

This document defines the complete requirements and architecture for a Spaced Repetition System (SRS) flash card service built on top of the existing `Vocabulary` entity in the Koine application. Users study Greek vocabulary cards using the FSRS algorithm, which adaptively schedules each card's next review based on measured recall difficulty.

---

## 2. Functional Requirements

### 2.1 Session Management

- FR-01: Users can start a new study session.
- FR-02: Session configuration is set at start time with these options:
  - **Card count:** 5, 10, 20, or all due cards.
  - **Card pool:** Due cards only, new cards only, or mixed (due + new).
  - **Direction:** Greek → English, English → Greek, or random.
  - **Interaction mode:** Flip (self-rate), Multiple Choice, or Mix.
- FR-03: A session contains an ordered list of cards drawn from the configured pool.
- FR-04: A session tracks total cards, cards reviewed, correct count, and session start/end times.
- FR-05: Sessions can be abandoned mid-way; progress on already-answered cards is persisted.
- FR-06: A session summary screen is shown on completion.

### 2.2 Card Review

- FR-07: Each card presents a **front** face containing one or more of: Greek root, transliteration, part of speech + occurrence frequency hint.
- FR-08: A **speaker button** on the card triggers Web Speech API TTS pronunciation of the Greek root (browser-side only, no backend involvement).
- FR-09: The user reveals the back face (Gloss / English definition).
- FR-10: In **Flip mode**, the user self-rates their recall on a 4-point scale:
  - `Again` (complete blackout)
  - `Hard` (recalled with significant difficulty)
  - `Good` (recalled with some effort)
  - `Easy` (recalled instantly)
- FR-11: In **Multiple Choice mode**, the system generates 3 distractors from other vocabulary items and presents 4 choices. The answer is auto-graded: correct → `Good`, incorrect → `Again`.
- FR-12: In **Mix mode**, the system alternates between flip and multiple choice cards within a session.
- FR-13: After rating, the next scheduled review date is displayed to the user before advancing.

### 2.3 FSRS Scheduling

- FR-14: The system implements the FSRS v5 algorithm to compute the next review interval and updated stability/difficulty values after each review.
- FR-15: FSRS parameters (w0–w18) are stored as application configuration and can be tuned without code changes.
- FR-16: Each `UserCardProgress` record stores: stability (S), difficulty (D), desired retention (R), scheduled days, elapsed days, last review date, review count, and lapses.
- FR-17: A card is "due" when the current date >= `NextReviewDate`.
- FR-18: New cards (never seen) are always eligible to be pulled into a "new cards" pool.

### 2.4 Progress & Statistics

- FR-19: A dashboard screen shows:
  - Total cards in deck.
  - Cards due today.
  - Cards in learning / review / new states.
  - A 7-day review history bar chart.
  - Current streak (consecutive days with at least one review).
- FR-20: Per-card statistics are accessible (times reviewed, current interval, difficulty, stability).

### 2.5 Existing `VocabularyProgress` Migration

- FR-21: The existing `VocabularyProgress` value object (`MasteryLevel`, `NeedsPractice`, `LastPracticed`, `TimesSeen`) must be migrated to the new `UserCardProgress` entity. A migration script must map:
  - `TimesSeen` → `ReviewCount`
  - `LastPracticed` → `LastReviewDate`
  - `MasteryLevel` (0-100) → approximate initial `Stability` via a linear mapping (0→0.1 days, 100→100 days).
  - `NeedsPractice = true` → forces `NextReviewDate = today`.

---

## 3. Non-Functional Requirements

- NFR-01: API response time for fetching next card < 100ms (excluding DB cold start).
- NFR-02: All domain logic (FSRS algorithm, session orchestration) must be unit-testable with no infrastructure dependencies.
- NFR-03: EF migrations must be additive; no destructive changes to existing tables.
- NFR-04: The hardcoded user stub must be isolated behind an `ICurrentUserProvider` port so it can be replaced with real identity in one file change.
- NFR-05: The Next.js frontend is a separate app (`/apps/koine-web`); it communicates with the API only via the defined REST contract.

---

## 4. System Architecture

### 4.1 Solution Structure

```
Koine.sln
├── src/
│   ├── Koine.Domain/                    # Entities, Value Objects, Domain Events (existing)
│   ├── Koine.Application/               # Use cases, ports (interfaces), DTOs
│   │   └── Study/
│   │       ├── Ports/
│   │       │   ├── IStudySessionRepository.cs
│   │       │   ├── IUserCardProgressRepository.cs
│   │       │   ├── IVocabularyRepository.cs        (already exists or add)
│   │       │   └── ICurrentUserProvider.cs
│   │       ├── Services/
│   │       │   ├── FsrsScheduler.cs                (pure algorithm, no I/O)
│   │       │   └── StudySessionService.cs          (orchestrates use cases)
│   │       └── DTOs/
│   │           ├── StartSessionRequest.cs
│   │           ├── SessionDto.cs
│   │           ├── CardDto.cs
│   │           ├── RateCardRequest.cs
│   │           └── DashboardDto.cs
│   ├── Koine.Infrastructure/            # EF, repos, adapters
│   │   └── Study/
│   │       ├── StudyDbContext.cs        (or extend existing AppDbContext)
│   │       ├── Repositories/
│   │       │   ├── StudySessionRepository.cs
│   │       │   └── UserCardProgressRepository.cs
│   │       ├── Configurations/
│   │       │   ├── UserCardProgressConfiguration.cs
│   │       │   └── StudySessionConfiguration.cs
│   │       └── Migrations/             (EF migrations)
│   └── Koine.API/                       # ASP.NET Core 10 Web API (existing)
│       └── Controllers/
│           └── StudyController.cs
│
├── tests/
│   ├── Koine.Application.Tests/
│   │   ├── FsrsSchedulerTests.cs
│   │   └── StudySessionServiceTests.cs
│   └── Koine.API.IntegrationTests/
│       └── StudyControllerTests.cs
│
└── apps/
    └── koine-web/                       # Next.js 16 frontend
        ├── app/
        │   ├── study/
        │   │   ├── page.tsx             # Dashboard
        │   │   ├── session/
        │   │   │   ├── page.tsx         # Session config & start
        │   │   │   └── [sessionId]/
        │   │   │       ├── page.tsx     # Active study session
        │   │   │       └── summary/
        │   │   │           └── page.tsx # Session summary
        │   │   └── progress/
        │   │       └── page.tsx         # Per-card progress list
        │   └── layout.tsx
        ├── components/
        │   ├── FlashCard.tsx
        │   ├── MultipleChoiceCard.tsx
        │   ├── RatingButtons.tsx
        │   ├── SessionConfig.tsx
        │   └── DashboardStats.tsx
        └── lib/
            └── studyApi.ts              # Typed API client
```

### 4.2 Hexagonal Architecture — Dependency Rules

```
[Domain] ← [Application] ← [Infrastructure]
                ↑
            [API / UI]
```

- **Domain layer** has zero dependencies on EF or ASP.NET.
- **Application layer** defines ports (interfaces) only; it never imports Infrastructure.
- **Infrastructure** implements ports and holds all EF/MSSQL specifics.
- **API** wires everything via DI; it never contains business logic.

---

## 5. Domain Model

### 5.1 New Entities

#### `UserCardProgress`

```csharp
// Koine.Domain/Entities/UserCardProgress.cs
public class UserCardProgress
{
    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty;   // stub: always "default-user"
    public int VocabularyId { get; set; }
    public Vocabulary Vocabulary { get; set; } = null!;

    // FSRS core state
    public float Stability { get; set; }        // S: days until 90% retention
    public float Difficulty { get; set; }       // D: 0–10 scale
    public float ElapsedDays { get; set; }
    public float ScheduledDays { get; set; }
    public int ReviewCount { get; set; }
    public int Lapses { get; set; }
    public CardState State { get; set; }        // New, Learning, Review, Relearning
    public DateTime? LastReviewDate { get; set; }
    public DateTime NextReviewDate { get; set; }
}

public enum CardState { New = 0, Learning = 1, Review = 2, Relearning = 3 }
```

#### `StudySession`

```csharp
// Koine.Domain/Entities/StudySession.cs
public class StudySession
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public DateTime StartedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public SessionConfig Config { get; set; } = null!;
    public ICollection<SessionCard> Cards { get; set; } = new List<SessionCard>();
}

public class SessionCard
{
    public int Id { get; set; }
    public Guid SessionId { get; set; }
    public int VocabularyId { get; set; }
    public int Position { get; set; }
    public Rating? GivenRating { get; set; }
    public DateTime? ReviewedAt { get; set; }
    public InteractionMode Mode { get; set; }
    public string? ChoicesJson { get; set; }    // serialized string[] for MC mode
}

public enum Rating { Again = 1, Hard = 2, Good = 3, Easy = 4 }
public enum InteractionMode { Flip, MultipleChoice }
```

#### `SessionConfig` (owned value object on `StudySession`)

```csharp
public class SessionConfig
{
    public int CardCount { get; set; }          // -1 = all due
    public CardPool Pool { get; set; }
    public StudyDirection Direction { get; set; }
    public InteractionMode Mode { get; set; }
}

public enum CardPool { DueOnly, NewOnly, Mixed }
public enum StudyDirection { GreekToEnglish, EnglishToGreek, Random }
```

---

## 6. FSRS v5 Algorithm Specification

The `FsrsScheduler` is a **pure static/stateless class** in the Application layer. It has no I/O and takes a snapshot of current card state plus the rating, and returns the updated state.

### 6.1 Constants & Parameters

FSRS v5 has 19 weights (w0–w18) and a desired retention constant R (default: 0.9).

Default weights (from FSRS v5 paper):

```
w = [0.4072, 1.1829, 3.1262, 15.4722, 7.2102, 0.5316, 1.0651,
     0.0589, 1.5330, 0.1544, 1.0070, 1.9395, 0.1100, 0.2900,
     2.2700, 0.0700, 2.9898, 0.5100, 0.4300]
```

### 6.2 Core Functions

**Initial stability after first rating:**
```
S₀(rating) = w[rating-1]   // w[0]=Again, w[1]=Hard, w[2]=Good, w[3]=Easy
```

**Initial difficulty:**
```
D₀(rating) = w[4] - exp(w[5] * (rating - 1)) + 1
D₀ = clamp(D₀, 1, 10)
```

**Retrievability (probability of recall):**
```
R(t, S) = (1 + FACTOR * t / S) ^ DECAY
FACTOR = 19/81,  DECAY = -0.5
```

**Next interval after review:**
```
nextInterval = (S / FACTOR) * (R^(1/DECAY) - 1)   where R = desiredRetention
interval = round(nextInterval)
interval = clamp(interval, 1, maxInterval=36500)
```

**Stability after successful recall (Good/Easy):**
```
Sᵣ(D, S, R, rating) = S * (
    exp(w[8]) *
    (11 - D) *
    S^(-w[9]) *
    (exp(w[10] * (1 - R)) - 1) *
    hardPenalty *      // w[15] if Hard, else 1
    easyBonus          // w[16] if Easy, else 1
  + 1
)
```

**Stability after forgetting (Again):**
```
Sₗ(D, S, R) = w[11] * D^(-w[12]) * ((S+1)^w[13] - 1) * exp(w[14] * (1-R))
```

**Difficulty update:**
```
ΔD(rating) = -w[6] * (rating - 3)
D' = w[7] * D₀(4) + (1 - w[7]) * (D + ΔD * ((10-D)/9))
D' = clamp(D', 1, 10)
```

### 6.3 State Machine

| Current State | Rating | Next State |
|---|---|---|
| New | Any | Learning |
| Learning | Again | Learning |
| Learning | Hard/Good | Learning |
| Learning | Easy | Review |
| Review | Again | Relearning |
| Review | Hard/Good/Easy | Review |
| Relearning | Again | Relearning |
| Relearning | Good/Easy | Review |

For cards in `Learning`/`Relearning` states, use short fixed intervals (1 min, 10 min) rather than full FSRS interval calculation — the card graduates to `Review` on `Easy` or after passing the learning steps.

### 6.4 `FsrsScheduler` Interface

```csharp
public record FsrsInput(
    UserCardProgress Card,
    Rating Rating,
    DateTime ReviewedAt,
    float DesiredRetention = 0.9f
);

public record FsrsOutput(
    float Stability,
    float Difficulty,
    float ScheduledDays,
    float ElapsedDays,
    CardState NextState,
    DateTime NextReviewDate
);

public static class FsrsScheduler
{
    public static FsrsOutput Schedule(FsrsInput input);
}
```

---

## 7. Application Layer — Use Cases

### 7.1 Ports (Interfaces)

```csharp
// ICurrentUserProvider.cs
public interface ICurrentUserProvider
{
    string GetUserId();
}

// IUserCardProgressRepository.cs
public interface IUserCardProgressRepository
{
    Task<List<UserCardProgress>> GetDueCardsAsync(string userId, int limit, CancellationToken ct);
    Task<List<UserCardProgress>> GetNewCardsAsync(string userId, int limit, CancellationToken ct);
    Task<UserCardProgress?> GetByVocabularyIdAsync(string userId, int vocabularyId, CancellationToken ct);
    Task<List<UserCardProgress>> GetAllForUserAsync(string userId, CancellationToken ct);
    Task UpsertAsync(UserCardProgress progress, CancellationToken ct);
    Task<DashboardStatsData> GetDashboardStatsAsync(string userId, CancellationToken ct);
}

// IStudySessionRepository.cs
public interface IStudySessionRepository
{
    Task<StudySession?> GetByIdAsync(Guid id, CancellationToken ct);
    Task SaveAsync(StudySession session, CancellationToken ct);
    Task<List<ReviewHistoryPoint>> GetReviewHistoryAsync(string userId, int days, CancellationToken ct);
}

// IVocabularyRepository.cs  (extend existing if present)
public interface IVocabularyRepository
{
    Task<List<Vocabulary>> GetByIdsAsync(IEnumerable<int> ids, CancellationToken ct);
    Task<List<Vocabulary>> GetRandomSampleAsync(int count, CancellationToken ct);
}
```

### 7.2 `StudySessionService` — Method Signatures

```csharp
public class StudySessionService(
    ICurrentUserProvider userProvider,
    IUserCardProgressRepository progressRepo,
    IStudySessionRepository sessionRepo,
    IVocabularyRepository vocabRepo)
{
    Task<SessionDto> StartSessionAsync(StartSessionRequest request, CancellationToken ct);
    Task<CardDto> GetNextCardAsync(Guid sessionId, CancellationToken ct);
    Task<RateCardResponse> RateCardAsync(Guid sessionId, int vocabularyId, Rating rating, CancellationToken ct);
    Task<SessionSummaryDto> CompleteSessionAsync(Guid sessionId, CancellationToken ct);
    Task<DashboardDto> GetDashboardAsync(CancellationToken ct);
}
```

**`StartSessionAsync` logic:**
1. Build card pool from config (due cards, new cards, or mix), respect `CardCount` limit.
2. For Multiple Choice cards, pre-generate 3 distractors per card using `GetRandomSampleAsync`; serialize to `ChoicesJson`.
3. Shuffle pool, assign positions.
4. Persist `StudySession` with all `SessionCard` records.
5. Return `SessionDto`.

**`RateCardAsync` logic:**
1. Load session, find `SessionCard` by vocabularyId.
2. Load or create `UserCardProgress` for this card.
3. Call `FsrsScheduler.Schedule(input)`.
4. Update `UserCardProgress` with `FsrsOutput`.
5. Mark `SessionCard.GivenRating` and `ReviewedAt`.
6. Persist both. Return next review date and updated card state.

---

## 8. REST API Contract

Base path: `/api/study`

| Method | Path | Description |
|---|---|---|
| `POST` | `/sessions` | Start a new session |
| `GET` | `/sessions/{id}` | Get session state |
| `GET` | `/sessions/{id}/next-card` | Get next unreviewed card in session |
| `POST` | `/sessions/{id}/cards/{vocabId}/rate` | Submit a rating for a card |
| `POST` | `/sessions/{id}/complete` | Mark session as complete |
| `GET` | `/dashboard` | Get dashboard statistics |
| `GET` | `/progress` | Get all card progress records |

### 8.1 Key DTOs

**`StartSessionRequest`**
```json
{
  "cardCount": 20,
  "pool": "Mixed",
  "direction": "GreekToEnglish",
  "mode": "Mix"
}
```

**`CardDto`** (response from `next-card`)
```json
{
  "sessionCardId": 12,
  "vocabularyId": 42,
  "position": 3,
  "totalCards": 20,
  "front": {
    "root": "λόγος",
    "transliteration": "logos",
    "partOfSpeech": "noun",
    "occurrences": 330
  },
  "back": {
    "gloss": "word, reason, message"
  },
  "interactionMode": "MultipleChoice",
  "choices": ["word, reason, message", "love", "grace", "faith"],
  "direction": "GreekToEnglish"
}
```

**`RateCardRequest`**
```json
{ "rating": "Good" }
```

**`RateCardResponse`**
```json
{
  "nextReviewDate": "2025-03-15T00:00:00Z",
  "scheduledDays": 4,
  "newState": "Review",
  "sessionComplete": false
}
```

**`DashboardDto`**
```json
{
  "totalCards": 500,
  "dueToday": 23,
  "newCards": 150,
  "learningCards": 12,
  "reviewCards": 210,
  "currentStreak": 7,
  "reviewHistory": [
    { "date": "2025-02-18", "count": 30 },
    ...
  ]
}
```

---

## 9. Database Schema

### `UserCardProgress` table

```sql
CREATE TABLE UserCardProgress (
    Id              INT IDENTITY PRIMARY KEY,
    UserId          NVARCHAR(128) NOT NULL,
    VocabularyId    INT NOT NULL REFERENCES Vocabulary(Id),
    Stability       REAL NOT NULL DEFAULT 0,
    Difficulty      REAL NOT NULL DEFAULT 5,
    ElapsedDays     REAL NOT NULL DEFAULT 0,
    ScheduledDays   REAL NOT NULL DEFAULT 0,
    ReviewCount     INT NOT NULL DEFAULT 0,
    Lapses          INT NOT NULL DEFAULT 0,
    State           INT NOT NULL DEFAULT 0,  -- CardState enum
    LastReviewDate  DATETIME2 NULL,
    NextReviewDate  DATETIME2 NOT NULL DEFAULT GETUTCDATE(),
    CONSTRAINT UQ_UserCardProgress UNIQUE (UserId, VocabularyId)
);
CREATE INDEX IX_UCP_Due ON UserCardProgress (UserId, NextReviewDate, State);
```

### `StudySessions` table

```sql
CREATE TABLE StudySessions (
    Id              UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    UserId          NVARCHAR(128) NOT NULL,
    StartedAt       DATETIME2 NOT NULL,
    CompletedAt     DATETIME2 NULL,
    ConfigJson      NVARCHAR(512) NOT NULL   -- serialized SessionConfig
);
```

### `SessionCards` table

```sql
CREATE TABLE SessionCards (
    Id              INT IDENTITY PRIMARY KEY,
    SessionId       UNIQUEIDENTIFIER NOT NULL REFERENCES StudySessions(Id),
    VocabularyId    INT NOT NULL,
    Position        INT NOT NULL,
    GivenRating     INT NULL,
    ReviewedAt      DATETIME2 NULL,
    Mode            INT NOT NULL,
    ChoicesJson     NVARCHAR(MAX) NULL
);
```

---

## 10. Infrastructure — EF Configuration Notes

- Extend the existing `AppDbContext` (do not create a second DbContext unless already separated).
- `SessionConfig` is stored as a serialized JSON column (`ConfigJson`) to avoid a join table.
- `StudySession.Cards` is loaded eagerly in `GetByIdAsync`.
- Use `HasConversion<string>` for enum columns where the string representation aids debugging.
- Add `HasIndex(x => new { x.UserId, x.NextReviewDate })` on `UserCardProgress` for due-card queries.

---

## 11. Hardcoded User Stub

```csharp
// Koine.Infrastructure/Study/HardcodedUserProvider.cs
public class HardcodedUserProvider : ICurrentUserProvider
{
    public string GetUserId() => "default-user";
}
```

Register in DI:
```csharp
builder.Services.AddScoped<ICurrentUserProvider, HardcodedUserProvider>();
```

To replace: implement `ClaimsCurrentUserProvider : ICurrentUserProvider` and swap the registration.

---

## 12. Frontend Architecture

### 12.1 Page Map

| Route | Component | Purpose |
|---|---|---|
| `/study` | `DashboardPage` | Stats, streak, due count, start button |
| `/study/session` | `SessionConfigPage` | Configure and start a session |
| `/study/session/[id]` | `ActiveSessionPage` | Card-by-card review loop |
| `/study/session/[id]/summary` | `SummaryPage` | Session results |
| `/study/progress` | `ProgressPage` | All cards, per-card stats table |

### 12.2 State Management

Use **React state + URL params** only. No Redux or Zustand needed for this scope.

- Active session state lives in the `ActiveSessionPage` component via `useState`.
- On page refresh, the session is re-fetched from the API by `sessionId` from the URL.

### 12.3 Key Components

**`FlashCard`**
- Props: `card: CardDto`, `onReveal: () => void`, `revealed: boolean`
- Shows front face. On reveal, animates a CSS flip (MUI `Box` with `transform: rotateY`).
- Speaker icon (MUI `VolumeUpIcon`) calls `window.speechSynthesis.speak()` with `lang: 'el-GR'`.

**`RatingButtons`**
- Props: `onRate: (rating: Rating) => void`, `disabled: boolean`
- Four MUI `Button` components: Again (red), Hard (orange), Good (blue), Easy (green).
- Only visible after card is revealed.

**`MultipleChoiceCard`**
- Props: `card: CardDto`, `onAnswer: (correct: boolean) => void`
- Renders 4 MUI `Button`s. On click, highlights correct/incorrect, then calls `onAnswer`.

**`DashboardStats`**
- Uses MUI `Grid`, `Card`, `Typography` for stats tiles.
- Uses a `recharts` `BarChart` for the 7-day history (or MUI `LinearProgress` bars if recharts unavailable).

### 12.4 API Client (`lib/studyApi.ts`)

Typed fetch wrapper — one function per endpoint. Uses `NEXT_PUBLIC_API_BASE_URL` env var. All functions are `async` and throw on non-2xx.

### 12.5 MUI Theme

Use MUI v7 `createTheme` with:
- Primary: deep blue (study/focus palette)
- Error: red (Again button)
- Warning: orange (Hard button)
- The flash card surface uses `Paper` with `elevation={4}`.

---

## 13. Testing Strategy

### 13.1 Unit Tests — `FsrsSchedulerTests`

Cover all rating paths × all card states:
- New card, all 4 ratings → verify S, D, interval, next state.
- Review card rated Again → verify lapses++, transition to Relearning.
- Review card rated Easy → verify interval increase and easyBonus applied.
- Edge cases: S near-zero, D clamped at boundaries.

### 13.2 Unit Tests — `StudySessionServiceTests`

Use Moq (or NSubstitute) to mock all ports:
- `StartSessionAsync` with `DueOnly` → only pulls due cards.
- `StartSessionAsync` with `Mixed` and `CardCount=10` → total ≤ 10.
- `RateCardAsync` → `UserCardProgress.UpsertAsync` called once with correct FSRS output.
- `RateCardAsync` on final card → `SessionComplete` flag set.

### 13.3 Integration Tests — `StudyControllerTests`

Use `WebApplicationFactory<Program>` with an in-memory SQLite provider (swap MSSQL for tests only):
- `POST /api/study/sessions` → 201 with session ID.
- `GET /api/study/sessions/{id}/next-card` → 200 with card data.
- Full round-trip: start session → get card → rate card → get next card → complete.

---

## 14. Migration Plan for Existing `VocabularyProgress`

If `VocabularyProgress` data exists in any table, run a one-time EF migration with a SQL `UPDATE` statement that:

1. Creates the `UserCardProgress` table.
2. Inserts rows for each existing `VocabularyProgress` record:
   - `UserId = 'default-user'`
   - `VocabularyId` = FK from parent record
   - `ReviewCount = TimesSeen`
   - `LastReviewDate = LastPracticed`
   - `Stability = MasteryLevel * 1.0` (maps 0–100 to 0–100 days of stability)
   - `NextReviewDate = IF NeedsPractice THEN TODAY ELSE LastPracticed + Stability`
   - `State = IF ReviewCount = 0 THEN New ELSE Review`

If `VocabularyProgress` has no backing table (pure value object), skip step 2 and treat all cards as `New`.

---

## 15. Implementation Prompt Series

See **Section 16** below.

---

## 16. AI Agent Implementation Prompts

Execute these prompts **in order**. Each prompt assumes the previous one is complete and committed.

---

### Prompt 1 — Domain Entities

```
You are implementing the SRS flash card feature for the Koine .NET application.

Task: Add the new domain entities to `Koine.Domain`.

Create the following files exactly as specified in the design document:
- `Koine.Domain/Entities/UserCardProgress.cs` — includes the `CardState` enum
- `Koine.Domain/Entities/StudySession.cs` — includes `SessionCard`, `Rating`, `InteractionMode` enums
- `Koine.Domain/ValueObjects/SessionConfig.cs` — includes `CardPool`, `StudyDirection` enums

Rules:
- No EF, no application references. Pure POCO classes.
- All enums in the same file as their primary entity.
- XML doc comments on each public property.
- `StudySession.Cards` and `SessionConfig` follow the spec exactly.

Do not modify any existing files.
```

---

### Prompt 2 — FSRS Scheduler

```
You are implementing the FSRS v5 algorithm for the Koine SRS feature.

Task: Create `Koine.Application/Study/Services/FsrsScheduler.cs`.

Requirements:
- Implement the static method `FsrsOutput Schedule(FsrsInput input)`.
- Use the exact FSRS v5 formulas specified in Section 6 of the design document.
- Default weights array w[0..18] must be the values listed in the spec.
- Implement the state machine from Section 6.3.
- Cards in New/Learning/Relearning states use short fixed steps:
  - Again: re-queue with 1 minute
  - Hard: re-queue with 5 minutes
  - Good: re-queue with 10 minutes
  - Easy: graduate to Review state with full FSRS interval
- `FsrsInput` and `FsrsOutput` are immutable records in the same file.
- No I/O, no DI — pure static functions only.
- Every formula branch must have an XML doc comment citing which FSRS variable it computes.
```

---

### Prompt 3 — Application Ports & DTOs

```
You are implementing the application layer for the Koine SRS feature.

Task: Create all port interfaces and DTOs under `Koine.Application/Study/`.

Create:
1. `Ports/ICurrentUserProvider.cs`
2. `Ports/IUserCardProgressRepository.cs` — full interface from Section 7.1
3. `Ports/IStudySessionRepository.cs` — full interface from Section 7.1
4. `Ports/IVocabularyRepository.cs` — extend or create per Section 7.1
5. `DTOs/StartSessionRequest.cs` — with data annotations for validation
6. `DTOs/SessionDto.cs`, `CardDto.cs`, `RateCardRequest.cs`, `RateCardResponse.cs`, `DashboardDto.cs`

DTO rules:
- Enums serialized as strings (`[JsonConverter(typeof(JsonStringEnumConverter))]`).
- All DTOs are records.
- `CardDto.Front` and `CardDto.Back` are nested records.
- `choices` on `CardDto` is `string[]?` (null for Flip mode cards).
```

---

### Prompt 4 — `StudySessionService`

```
You are implementing the core use case service for the Koine SRS feature.

Task: Create `Koine.Application/Study/Services/StudySessionService.cs`.

Implement all methods listed in Section 7.2 of the design document:
- `StartSessionAsync`: build card pool, generate MC distractors (call `IVocabularyRepository.GetRandomSampleAsync`
  filtering out the card's own vocabulary), assign positions, persist.
- `GetNextCardAsync`: return the next `SessionCard` where `GivenRating == null`, ordered by `Position`.
  Return null (not error) if all cards are done.
- `RateCardAsync`: run `FsrsScheduler.Schedule`, upsert progress, mark session card, detect completion.
- `CompleteSessionAsync`: set `CompletedAt`, return summary stats.
- `GetDashboardAsync`: aggregate stats from the repository.

Rules:
- Use primary constructor injection.
- All methods accept `CancellationToken`.
- Do not catch exceptions — let them propagate to the controller.
- Multiple Choice card: 3 distractors + 1 correct answer, shuffled randomly, serialized to JSON for `ChoicesJson`.
```

---

### Prompt 5 — EF Infrastructure

```
You are implementing the EF Core infrastructure for the Koine SRS feature.

Task: Wire up persistence in `Koine.Infrastructure/Study/`.

1. Extend the existing `AppDbContext` to include:
   - `DbSet<UserCardProgress> UserCardProgress`
   - `DbSet<StudySession> StudySessions`
   - `DbSet<SessionCard> SessionCards`

2. Create EF entity type configurations:
   - `UserCardProgressConfiguration.cs`:
     - Unique index on (UserId, VocabularyId)
     - Composite index on (UserId, NextReviewDate) for due-card queries
     - Store `State` as int
   - `StudySessionConfiguration.cs`:
     - `Config` stored as JSON column via `HasConversion<string>` + `System.Text.Json`
     - Cascade delete `SessionCards` when `StudySession` is deleted

3. Create `Repositories/UserCardProgressRepository.cs` and `Repositories/StudySessionRepository.cs`
   implementing their respective ports.

4. Create `HardcodedUserProvider.cs` implementing `ICurrentUserProvider`.

5. Generate the EF migration named `AddStudyFeature`:
   - `dotnet ef migrations add AddStudyFeature --project Koine.Infrastructure --startup-project Koine.API`

Rules:
- Do NOT modify any existing migrations.
- All queries use `AsNoTracking()` for reads where the entity is not modified.
- Use `ExecuteUpdateAsync` for bulk operations where appropriate.
```

---

### Prompt 6 — API Controller & DI Registration

```
You are wiring up the REST API for the Koine SRS feature.

Task: Create the controller and register services.

1. Create `Koine.API/Controllers/StudyController.cs`:
   - Inherit from `ControllerBase`
   - Route: `[Route("api/study")]`
   - Inject `StudySessionService` via constructor
   - Implement all 7 endpoints from Section 8 of the design document
   - Use `[HttpPost]`, `[HttpGet]` attributes with correct sub-routes
   - Return `201 Created` for session start with `Location` header
   - Return `404` when session/card not found
   - Return `400` for validation errors (use `[ApiController]` attribute)

2. In `Program.cs` (or `Startup.cs`), register:
   - `builder.Services.AddScoped<ICurrentUserProvider, HardcodedUserProvider>()`
   - `builder.Services.AddScoped<IUserCardProgressRepository, UserCardProgressRepository>()`
   - `builder.Services.AddScoped<IStudySessionRepository, StudySessionRepository>()`
   - `builder.Services.AddScoped<StudySessionService>()`
   - Ensure `JsonStringEnumConverter` is globally registered in `AddControllers().AddJsonOptions(...)`.

3. Apply the EF migration on startup (dev only):
   - In `Program.cs`, call `db.Database.MigrateAsync()` only when `app.Environment.IsDevelopment()`.
```

---

### Prompt 7 — Unit Tests

```
You are writing unit tests for the Koine SRS feature.

Task: Create `tests/Koine.Application.Tests/`.

1. `FsrsSchedulerTests.cs`:
   - Test all 4 ratings for a brand-new card (State=New):
     - Verify correct initial Stability (w[0..3]) for each rating
     - Verify NextState transitions per state machine
   - Test a Review card rated Again:
     - Lapses incremented
     - State becomes Relearning
     - New stability uses the forgetting formula
   - Test a Review card rated Easy:
     - EasyBonus applied (scheduledDays > Good path)
   - Test clamping: D never < 1 or > 10
   - All tests use explicit float tolerance (Assert.InRange or similar)

2. `StudySessionServiceTests.cs` (use NSubstitute or Moq):
   - Mock all 4 ports
   - Test `StartSessionAsync` with `DueOnly` pool:
     - `GetNewCardsAsync` never called
   - Test `StartSessionAsync` with `CardCount=5`:
     - Pool limited to 5 cards
   - Test `RateCardAsync`:
     - `UpsertAsync` called exactly once with correct VocabularyId
     - When it's the last card, `RateCardResponse.SessionComplete == true`
   - Use `[Theory]` with `[InlineData]` for multi-rating tests.
```

---

### Prompt 8 — Next.js Frontend: Project Setup & API Client

```
You are building the Next.js frontend for the Koine SRS feature.

Task: Scaffold `apps/koine-web` and create the typed API client.

1. Initialize Next.js 16 app with TypeScript and App Router:
   `npx create-next-app@latest koine-web --typescript --app --tailwind=false`

2. Install dependencies:
   `npm install @mui/material @mui/icons-material @emotion/react @emotion/styled`

3. Create `apps/koine-web/lib/studyApi.ts`:
   - Base URL from `process.env.NEXT_PUBLIC_API_BASE_URL`
   - Export typed functions:
     - `startSession(req: StartSessionRequest): Promise<SessionDto>`
     - `getNextCard(sessionId: string): Promise<CardDto | null>`
     - `rateCard(sessionId: string, vocabId: number, rating: Rating): Promise<RateCardResponse>`
     - `completeSession(sessionId: string): Promise<SessionSummaryDto>`
     - `getDashboard(): Promise<DashboardDto>`
     - `getProgress(): Promise<CardProgressDto[]>`
   - All types mirror the backend DTOs exactly (TypeScript interfaces in `lib/types.ts`)
   - On non-2xx response, throw an `ApiError` with status and message.

4. Create `apps/koine-web/app/layout.tsx`:
   - Wrap children in MUI `ThemeProvider` with the custom theme (deep blue primary).
   - Include MUI `CssBaseline`.
```

---

### Prompt 9 — Frontend: Dashboard & Session Config Pages

```
You are implementing the study dashboard and session configuration screens.

Task: Create the dashboard and session start pages.

1. `app/study/page.tsx` — Dashboard:
   - Fetch from `getDashboard()` on mount via `useEffect`.
   - Display using MUI `Grid` + `Card` tiles: Total Cards, Due Today, New, Learning, Review, Streak.
   - Display a 7-day review history using a simple MUI `LinearProgress` bar per day
     (label = date, value normalized to max day's count).
   - "Start Study Session" MUI `Button` → navigates to `/study/session`.
   - Loading state: MUI `Skeleton` placeholders.

2. `app/study/session/page.tsx` — Session Config:
   - `SessionConfig` component with MUI controls:
     - `Select` for Card Count (5, 10, 20, All Due).
     - `ToggleButtonGroup` for Pool (Due Only, New Only, Mixed).
     - `ToggleButtonGroup` for Direction (Greek→English, English→Greek, Random).
     - `ToggleButtonGroup` for Mode (Flip, Multiple Choice, Mix).
   - "Start Session" button calls `startSession(config)`, then navigates to `/study/session/{id}`.
   - Show defaults on first render.
```

---

### Prompt 10 — Frontend: Active Session Page

```
You are implementing the core active study session UI.

Task: Create `app/study/session/[sessionId]/page.tsx` and supporting components.

1. `ActiveSessionPage`:
   - On mount, fetch next card via `getNextCard(sessionId)`.
   - Show MUI `LinearProgress` at top for (reviewed / total).
   - Render `FlashCard` or `MultipleChoiceCard` based on `card.interactionMode`.
   - On rating/answer, call `rateCard(...)`, then fetch next card.
   - If `rateCardResponse.sessionComplete`, navigate to `/study/session/{id}/summary`.

2. `components/FlashCard.tsx`:
   - MUI `Paper` elevation=4 as card surface, min height 280px.
   - Front face: large `Typography` for `root` (Greek, serif font if available),
     smaller text for `transliteration` and `partOfSpeech`.
   - MUI `IconButton` with `VolumeUpIcon` that calls:
     ```ts
     const utterance = new SpeechSynthesisUtterance(card.front.root);
     utterance.lang = 'el-GR';
     window.speechSynthesis.speak(utterance);
     ```
   - "Show Answer" MUI `Button` reveals the back.
   - CSS flip animation (rotateY 180deg on reveal) using `sx` prop transitions.
   - After reveal, render `RatingButtons`.

3. `components/MultipleChoiceCard.tsx`:
   - Same front face as FlashCard (with speaker button).
   - 4 MUI `Button`s in a 2×2 Grid for choices.
   - On click: highlight selected (green if correct, red if incorrect),
     disable all other buttons, wait 800ms, then call `onAnswer`.

4. `components/RatingButtons.tsx`:
   - 4 MUI `Button` variants in a row: Again (error), Hard (warning), Good (primary), Easy (success).
   - Each shows the next interval in small text below (from `rateCardResponse.scheduledDays` — preview
     using a client-side estimate before confirming, or show after rating).
   - Disabled until `revealed = true`.
```

---

### Prompt 11 — Frontend: Summary & Progress Pages

```
You are implementing the session summary and card progress screens.

Task: Create the final two pages.

1. `app/study/session/[sessionId]/summary/page.tsx`:
   - Show: Total Reviewed, Correct %, Again count, Hard count, Good count, Easy count.
   - MUI `CircularProgress` style graphic for correct percentage.
   - "Study Again" button → `/study/session` (start new).
   - "Back to Dashboard" button → `/study`.

2. `app/study/progress/page.tsx`:
   - Fetch `getProgress()` on mount.
   - MUI `DataGrid` (or plain `Table`) with columns:
     Greek Word | Gloss | State | Difficulty | Stability | Next Review | Reviews | Lapses
   - Sortable columns.
   - `State` column uses a MUI `Chip` with color: New=default, Learning=warning, Review=success, Relearning=error.
   - Search/filter input above the table (client-side filter on root or gloss).
```

---

### Prompt 12 — Migration Script for `VocabularyProgress`

```
You are writing the data migration for the Koine SRS feature.

Task: Create an EF migration that migrates existing `VocabularyProgress` data.

Add a new EF migration named `MigrateVocabularyProgress` that:

1. In `Up()`, executes a raw SQL statement:
   ```sql
   INSERT INTO UserCardProgress
     (UserId, VocabularyId, Stability, Difficulty, ReviewCount, 
      LastReviewDate, NextReviewDate, State, ElapsedDays, ScheduledDays, Lapses)
   SELECT
     'default-user',
     vp.VocabularyId,                              -- adjust FK column name to match existing schema
     CAST(vp.MasteryLevel AS FLOAT),               -- 0–100 maps directly to stability days
     5.0,                                          -- neutral difficulty
     vp.TimesSeen,
     vp.LastPracticed,
     CASE WHEN vp.NeedsPractice = 1 THEN GETUTCDATE()
          ELSE DATEADD(day, vp.MasteryLevel, vp.LastPracticed) END,
     CASE WHEN vp.TimesSeen = 0 THEN 0 ELSE 2 END, -- 0=New, 2=Review
     0, 0, 0
   FROM VocabularyProgressTable vp               -- replace with actual table name
   WHERE NOT EXISTS (
     SELECT 1 FROM UserCardProgress ucp
     WHERE ucp.UserId = 'default-user' AND ucp.VocabularyId = vp.VocabularyId
   );
   ```

2. `Down()` deletes rows with `UserId = 'default-user'` that were inserted by this migration.

3. Add a code comment at the top: `// Idempotent: safe to re-run; WHERE NOT EXISTS prevents duplicates`.

Note: If the `VocabularyProgress` table does not exist in the schema (pure value object, no table),
make `Up()` a no-op with a comment explaining this, and still create the migration file.
```

---