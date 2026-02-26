# Koine Project Structure - Refactoring Plan

## Executive Summary

This document outlines the migration from the current structure to a clean, hexagonal architecture that supports the planned feature expansion (Reader, Flashcards, Lessons, Practice Questions).

---

## Current Structure (Before Refactoring)

### Backend (Clean - Minimal Changes Needed)

```
backend/
├── Koine.sln
├── Koine.Domain/              # ✅ Good - keep as-is
│   ├── Entities/
│   ├── Enums/
│   └── ValueObjects/
│
├── Koine.Application/         # ✅ Good - add feature folders
│   ├── DTOs/
│   ├── Interfaces/
│   ├── Services/
│   └── Mappers/
│
├── Koine.Infrastructure/      # ✅ Good - add Azure services
│   ├── Data/
│   ├── Migrations/
│   └── Services/
│
├── Koine.API/                 # ✅ Good - add GraphQL
│   ├── Controllers/
│   ├── Middleware/
│   └── Filters/
│
└── Koine.Tests/               # ✅ Good - expand coverage
```

### Frontend (Needs Restructuring)

```
frontend/
├── src/
│   ├── app/                   # ❌ Mixed concerns, no clear feature separation
│   │   ├── (client)/
│   │   ├── about/
│   │   ├── lessons/
│   │   ├── modules/           # ❌ Ambiguous name
│   │   ├── onboarding/
│   │   ├── reader/
│   │   ├── services/          # ❌ Should be in src/lib/
│   │   ├── sets/
│   │   ├── vocabulary/
│   │   └── welcome/
│   ├── proxy.ts               # ❌ Should be in lib/
│   └── types/                 # ❌ Should have more structure
├── public/                    # ✅ Good
└── [config files]             # ✅ Good
```

**Problems:**
- No clear separation between app routes, business logic, and utilities
- `modules/` folder name is ambiguous (domain models? UI components?)
- Services mixed with app routes instead of in `src/lib/`
- No feature-based organization for components
- Types are flat, not organized by domain

---

## Goal Structure (After Refactoring)

### Backend (Enhanced Hexagonal Architecture)

```
backend/
├── Koine.sln
│
├── src/
│   ├── Koine.Domain/
│   │   ├── Entities/
│   │   │   ├── Text/              # 🆕 Feature grouping
│   │   │   │   ├── Book.cs
│   │   │   │   ├── Chapter.cs
│   │   │   │   ├── TranslationUnit.cs
│   │   │   │   └── Translation.cs
│   │   │   ├── Features/
│   │   │   │   ├── GrammaticalFeature.cs
│   │   │   │   └── SyntacticalFeature.cs
│   │   │   ├── Flashcards/        # 🆕
│   │   │   │   ├── Flashcard.cs
│   │   │   │   └── FlashcardReview.cs
│   │   │   ├── Lessons/
│   │   │   │   ├── Lesson.cs
│   │   │   │   ├── LessonModule.cs
│   │   │   │   ├── LessonTrack.cs
│   │   │   │   └── LessonCompletion.cs
│   │   │   ├── Practice/          # 🆕
│   │   │   │   ├── Question.cs
│   │   │   │   ├── QuestionTemplate.cs
│   │   │   │   └── UserAnswer.cs
│   │   │   ├── Vocabulary/
│   │   │   │   ├── Vocabulary.cs
│   │   │   │   ├── VocabularySet.cs
│   │   │   │   └── VocabularySetItem.cs
│   │   │   └── Users/
│   │   │       ├── User.cs
│   │   │       ├── UserProgress.cs
│   │   │       └── UserSetting.cs
│   │   ├── Enums/
│   │   └── ValueObjects/
│   │       ├── SrsParameters.cs   # 🆕 FSRS state
│   │       ├── MediaReference.cs  # 🆕 Images/videos
│   │       └── QuestionDifficulty.cs # 🆕
│   │
│   ├── Koine.Application/
│   │   ├── DTOs/
│   │   │   ├── Text/
│   │   │   ├── Flashcards/        # 🆕
│   │   │   ├── Lessons/
│   │   │   ├── Practice/          # 🆕
│   │   │   ├── Vocabulary/
│   │   │   └── Users/
│   │   ├── Interfaces/
│   │   │   ├── IAuthService.cs
│   │   │   ├── Text/
│   │   │   ├── Flashcards/        # 🆕
│   │   │   │   ├── IFlashcardService.cs
│   │   │   │   └── ISrsService.cs
│   │   │   ├── Lessons/
│   │   │   ├── Practice/          # 🆕
│   │   │   │   ├── IQuestionGenerationService.cs
│   │   │   │   └── IGradingService.cs
│   │   │   └── Repositories/
│   │   ├── Services/
│   │   │   ├── Text/
│   │   │   │   ├── ReaderService.cs
│   │   │   │   ├── TranslationService.cs
│   │   │   │   └── ChapterService.cs
│   │   │   ├── Flashcards/        # 🆕
│   │   │   │   ├── FlashcardService.cs
│   │   │   │   ├── SrsService.cs
│   │   │   │   └── FlashcardImageService.cs
│   │   │   ├── Lessons/
│   │   │   │   ├── LessonService.cs
│   │   │   │   └── LessonProgressService.cs
│   │   │   ├── Practice/          # 🆕
│   │   │   │   ├── QuestionGenerationService.cs
│   │   │   │   ├── QuestionBankService.cs
│   │   │   │   └── GradingService.cs
│   │   │   └── Vocabulary/
│   │   └── Mappers/
│   │
│   ├── Koine.Infrastructure/
│   │   ├── Data/
│   │   │   ├── Context/
│   │   │   │   └── KoineDbContext.cs
│   │   │   ├── Repositories/
│   │   │   ├── Configurations/
│   │   │   └── Seed/
│   │   ├── Migrations/
│   │   └── Services/
│   │       ├── Auth/               # 🆕
│   │       │   ├── ClerkAuthService.cs
│   │       │   └── ClerkClient.cs
│   │       ├── Storage/            # 🆕
│   │       │   ├── BlobStorageService.cs
│   │       │   └── MediaService.cs
│   │       └── Cache/              # 🆕
│   │           └── RedisCacheService.cs
│   │
│   └── Koine.API/
│       ├── Controllers/           # Keep REST for migration
│       ├── GraphQL/               # 🆕 Primary API
│       │   ├── Queries/
│       │   │   ├── TextQueries.cs
│       │   │   ├── FlashcardQueries.cs
│       │   │   ├── LessonQueries.cs
│       │   │   └── PracticeQueries.cs
│       │   ├── Mutations/
│       │   │   ├── FlashcardMutations.cs
│       │   │   ├── LessonMutations.cs
│       │   │   └── PracticeMutations.cs
│       │   ├── Types/
│       │   ├── DataLoaders/
│       │   └── Subscriptions/
│       ├── Middleware/
│       │   ├── AuthMiddleware.cs  # 🆕 Clerk integration
│       │   └── ErrorHandlingMiddleware.cs
│       └── Filters/
│
├── tests/
│   └── Koine.Tests/
│       ├── Unit/
│       │   ├── Text/
│       │   ├── Flashcards/        # 🆕
│       │   ├── Lessons/
│       │   └── Practice/          # 🆕
│       └── Integration/
│
└── docs/
    ├── architecture/              # 🆕
    │   ├── ADR-001-hexagonal.md
    │   ├── ADR-002-graphql.md
    │   ├── ADR-003-clerk-auth.md
    │   └── system-overview.md
    ├── features/                  # 🆕
    │   ├── reader.md
    │   ├── flashcards.md
    │   ├── lessons.md
    │   └── practice.md
    ├── api/
    │   ├── graphql-schema.md      # 🆕
    │   └── rest-api.md
    └── development-roadmap.md     # 🆕
```

### Frontend (Clean Next.js 14 App Router Structure)

```
frontend/
├── src/
│   ├── app/                       # App Router - ROUTES ONLY
│   │   ├── (auth)/                # 🆕 Auth-required routes
│   │   │   ├── layout.tsx
│   │   │   ├── reader/
│   │   │   │   └── [[...page]]/
│   │   │   │       └── page.tsx
│   │   │   ├── flashcards/        # 🆕
│   │   │   │   ├── page.tsx
│   │   │   │   └── [cardId]/
│   │   │   │       └── page.tsx
│   │   │   ├── lessons/
│   │   │   │   ├── page.tsx
│   │   │   │   └── [trackSlug]/
│   │   │   │       ├── page.tsx
│   │   │   │       └── [lessonId]/
│   │   │   │           └── page.tsx
│   │   │   ├── practice/          # 🆕
│   │   │   │   ├── page.tsx
│   │   │   │   └── [sessionId]/
│   │   │   │       └── page.tsx
│   │   │   ├── vocabulary/
│   │   │   │   └── page.tsx
│   │   │   └── profile/
│   │   │       └── page.tsx
│   │   ├── (public)/              # 🆕 Public routes
│   │   │   ├── layout.tsx
│   │   │   ├── page.tsx           # Landing page
│   │   │   ├── about/
│   │   │   │   └── page.tsx
│   │   │   ├── welcome/
│   │   │   │   └── page.tsx
│   │   │   └── resources/         # 🆕
│   │   │       └── page.tsx
│   │   ├── api/                   # 🆕 API routes
│   │   │   └── webhooks/
│   │   │       └── clerk/
│   │   │           └── route.ts
│   │   ├── layout.tsx             # Root layout
│   │   ├── not-found.tsx
│   │   └── error.tsx
│   │
│   ├── components/                # 🆕 Organized UI components
│   │   ├── ui/                    # Primitives (shadcn/ui)
│   │   │   ├── button.tsx
│   │   │   ├── card.tsx
│   │   │   └── ...
│   │   ├── features/              # Feature-specific components
│   │   │   ├── reader/
│   │   │   │   ├── ReaderInterface.tsx
│   │   │   │   ├── ReaderPageControls.tsx
│   │   │   │   ├── ReaderPageUnit.tsx
│   │   │   │   ├── WordDetails.tsx
│   │   │   │   └── Navigation/
│   │   │   │       ├── Nav.tsx
│   │   │   │       ├── Sidebar.tsx
│   │   │   │       ├── DetailsMenu.tsx
│   │   │   │       └── SettingsMenu.tsx
│   │   │   ├── flashcards/        # 🆕
│   │   │   │   ├── FlashcardDeck.tsx
│   │   │   │   ├── FlashcardItem.tsx
│   │   │   │   ├── SrsScheduler.tsx
│   │   │   │   └── FlashcardStats.tsx
│   │   │   ├── lessons/
│   │   │   │   ├── LessonCard.tsx
│   │   │   │   ├── LessonProgress.tsx
│   │   │   │   ├── LessonModule.tsx
│   │   │   │   └── VideoPlayer.tsx # 🆕
│   │   │   ├── practice/          # 🆕
│   │   │   │   ├── QuestionCard.tsx
│   │   │   │   ├── MultipleChoice.tsx
│   │   │   │   ├── FillBlank.tsx
│   │   │   │   └── GradingFeedback.tsx
│   │   │   └── vocabulary/
│   │   │       ├── VocabularyTable.tsx
│   │   │       └── VocabularySetCard.tsx
│   │   ├── layout/                # Layout components
│   │   │   ├── Header.tsx
│   │   │   ├── Footer.tsx
│   │   │   └── Sidebar.tsx
│   │   └── shared/                # Shared components
│   │       ├── Loading.tsx
│   │       ├── ErrorBoundary.tsx
│   │       └── Skeletons.tsx
│   │
│   ├── lib/                       # 🆕 Business logic & utilities
│   │   ├── api/                   # API clients
│   │   │   ├── graphql/           # 🆕 GraphQL client
│   │   │   │   ├── client.ts
│   │   │   │   ├── queries/
│   │   │   │   │   ├── reader.ts
│   │   │   │   │   ├── flashcards.ts
│   │   │   │   │   ├── lessons.ts
│   │   │   │   │   └── practice.ts
│   │   │   │   └── mutations/
│   │   │   │       ├── flashcards.ts
│   │   │   │       ├── lessons.ts
│   │   │   │       └── practice.ts
│   │   │   └── rest/              # Legacy REST (for migration)
│   │   │       ├── reader.ts
│   │   │       ├── lessons.ts
│   │   │       └── vocabulary.ts
│   │   ├── services/              # Business logic
│   │   │   ├── reader/
│   │   │   │   ├── transliteration.ts
│   │   │   │   └── tts.ts
│   │   │   ├── flashcards/        # 🆕
│   │   │   │   └── fsrs.ts        # FSRS algorithm
│   │   │   └── auth/              # 🆕
│   │   │       └── clerk.ts
│   │   ├── hooks/                 # React hooks
│   │   │   ├── useReader.ts
│   │   │   ├── useFlashcards.ts   # 🆕
│   │   │   ├── useLessons.ts
│   │   │   ├── usePractice.ts     # 🆕
│   │   │   └── useAuth.ts         # 🆕
│   │   ├── stores/                # 🆕 State management (Zustand)
│   │   │   ├── readerStore.ts
│   │   │   ├── flashcardStore.ts
│   │   │   └── userStore.ts
│   │   ├── utils/                 # Pure utilities
│   │   │   ├── formatting.ts
│   │   │   ├── validation.ts
│   │   │   └── constants.ts
│   │   └── types/                 # TypeScript types
│   │       ├── api.ts
│   │       ├── domain/
│   │       │   ├── text.ts
│   │       │   ├── flashcard.ts   # 🆕
│   │       │   ├── lesson.ts
│   │       │   ├── practice.ts    # 🆕
│   │       │   └── user.ts
│   │       └── graphql.ts         # 🆕 Generated types
│   │
│   └── styles/                    # Global styles
│       ├── globals.css
│       └── theme.css
│
├── public/                        # Static assets
│   ├── images/
│   └── icons/
│
├── .env.local.example             # 🆕
├── next.config.mjs
├── package.json
├── tsconfig.json
└── README.md
```

---

## Key Improvements

### Backend
1. ✅ **Feature-based organization** within existing projects (no premature splitting)
2. ✅ **Clear separation** of Text, Flashcards, Lessons, Practice domains
3. ✅ **GraphQL layer** added alongside REST for migration
4. ✅ **Azure services** properly abstracted in Infrastructure
5. ✅ **Comprehensive documentation** structure

### Frontend
1. ✅ **Route groups** for auth vs public pages
2. ✅ **Components separated** by feature, not mixed with routes
3. ✅ **Business logic in `lib/`** (services, hooks, stores)
4. ✅ **GraphQL client** with typed queries/mutations
5. ✅ **Type safety** with organized domain types
6. ✅ **No more ambiguous folder names** (`modules/` → `lib/types/domain/`)

---

## Migration Complexity Assessment

| Area | Complexity | Estimated Time | Notes |
|------|-----------|----------------|-------|
| Backend restructuring | Low | 2 hours | Mostly moving files within existing structure |
| Frontend restructuring | Medium | 4-6 hours | More files to move, imports to update |
| Import updates | Medium | 2-3 hours | Automated script + manual verification |
| Testing after migration | High | 4-6 hours | Ensure nothing broke |
| **Total** | | **12-17 hours** | Can be done incrementally |

---

## Rollout Strategy

### Phase 1: Documentation & Planning (1 day)
- Create ADRs
- Update README
- Document current vs goal

### Phase 2: Backend Enhancement (2 days)
- Add feature folders to Domain/Application
- Implement Azure services stubs
- Add GraphQL foundation

### Phase 3: Frontend Restructuring (3 days)
- Execute git mv script
- Fix imports
- Test all routes

### Phase 4: Feature Development (12-16 weeks)
- See DEVELOPMENT_ROADMAP.md for detailed sprints

---

## Decision Log

### Why not split backend into bounded contexts yet?
- Solo developer needs velocity
- Premature abstraction increases maintenance
- Current 4-project structure handles 5-7 features comfortably
- Can split later when team grows or complexity hits threshold

### Why GraphQL alongside REST?
- Gradual migration reduces risk
- Frontend can adopt feature-by-feature
- REST controllers stay for admin tools
- Deprecate REST once frontend migrated

### Why feature-based folders in frontend?
- Aligns with App Router mental model
- Makes finding related code trivial
- Reduces decision fatigue for contributors
- Scales better than flat structure

### Why Clerk instead of Auth0/Azure AD B2C?
- Generous free tier (10k MAUs)
- Excellent DX
- Built-in social login
- Simple role management
- Good Next.js integration