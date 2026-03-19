# Requirements Document

## Introduction

This feature adds a GraphQL API layer to the Koine backend using the latest GraphQL-dotnet library, and transitions the frontend UI to consume GraphQL instead of the existing REST fetch helpers. The backend GraphQL endpoint will coexist with the existing REST controllers during the transition. The frontend will replace its `src/lib/api/rest/` helpers with GraphQL queries and mutations, using a typed GraphQL client. Auth (Clerk JWT Bearer) must be preserved end-to-end.

## Glossary

- **GraphQL_Server**: The GraphQL endpoint hosted at `/graphql` in `Koine.API`, implemented with the `GraphQL-dotnet` library (latest stable version).
- **Schema**: The GraphQL type system definition that describes all queryable and mutable data.
- **Query**: A read-only GraphQL operation that fetches data.
- **Mutation**: A write GraphQL operation that creates, updates, or deletes data.
- **DataLoader**: A batching and caching utility that prevents N+1 database queries when resolving nested GraphQL fields.
- **GraphQL_Client**: The frontend Apollo Client instance (`@apollo/client`) that sends GraphQL operations to the `GraphQL_Server` and returns typed results.
- **Admin_User**: An authenticated user with the `admin` role claim, permitted to perform content management mutations (create/update/delete books, chapters, and vocabulary).
- **Operation**: A named GraphQL query or mutation document sent from the frontend.
- **Fragment**: A reusable GraphQL selection set shared across multiple Operations.
- **Codegen**: The `graphql-codegen` toolchain that generates TypeScript types and typed hooks from `.graphql` operation files.
- **REST_Layer**: The existing `Koine.API/Controllers/` REST endpoints, which remain in place during the transition.
- **Application_Service**: An interface-backed service in `Koine.Application/Interfaces/` that encapsulates business logic.
- **JWT**: The Clerk-issued JSON Web Token passed as a Bearer token in the `Authorization` header.
- **CurrentUser**: The authenticated user identity resolved from the JWT inside a GraphQL resolver.
- **Resolver**: A function in the `GraphQL_Server` that fetches or mutates data for a specific field.
- **Playground**: The interactive GraphQL IDE (Banana Cake Pop or Altair) served in development for exploring the Schema.

---

## Requirements

### Requirement 1: GraphQL Server Registration

**User Story:** As a backend developer, I want a GraphQL endpoint registered in the ASP.NET Core pipeline, so that clients can send GraphQL operations to the Koine API.

#### Acceptance Criteria

1. THE `GraphQL_Server` SHALL expose a `/graphql` HTTP endpoint that accepts POST requests containing a JSON body with `query`, `operationName`, and `variables` fields.
2. WHEN the application starts in the Development environment, THE `GraphQL_Server` SHALL serve an interactive Playground UI at `/graphql/ui`.
3. WHEN the application starts in the Production environment, THE `GraphQL_Server` SHALL disable the Playground UI.
4. THE `GraphQL_Server` SHALL be registered using the latest stable `GraphQL-dotnet` NuGet package added to `Koine.API.csproj`.
5. THE `GraphQL_Server` SHALL reuse the existing `IServiceCollection` registrations for `Application_Service` instances — no duplicate service registrations are permitted.
6. WHEN a request arrives at `/graphql` without a valid JWT, THE `GraphQL_Server` SHALL return a GraphQL error with code `UNAUTHENTICATED` for fields that require authentication.
7. WHEN a request arrives at `/graphql` with a valid JWT, THE `GraphQL_Server` SHALL resolve `CurrentUser` from the token claims and make it available to all Resolvers.

---

### Requirement 2: Root Query Type

**User Story:** As a frontend developer, I want a unified GraphQL Query type that exposes all read operations, so that I can fetch any data the app needs in a single typed request.

#### Acceptance Criteria

1. THE `Schema` SHALL define a root `Query` type that aggregates fields for all domain areas: reader, books, chapters, vocabulary, lessons, progress, study sets, study sessions, and grammatical/syntactical features.
2. WHEN a client sends a `reader` query with `bookId`, `chapterNumber`, and optional `lang` arguments, THE `GraphQL_Server` SHALL delegate to `IReaderService.RenderChapterAsync` and return a `RenderedChapter` type.
3. WHEN a client sends a `books` query, THE `GraphQL_Server` SHALL delegate to `IBookService.GetAllBooksAsync` and return a list of `Book` types.
4. WHEN a client sends a `book(id: Int!)` query, THE `GraphQL_Server` SHALL delegate to `IBookService.GetBookByIdAsync` and return a nullable `Book` type.
5. WHEN a client sends a `chapters(bookId: Int!)` query, THE `GraphQL_Server` SHALL delegate to `IChapterService.GetChaptersByBookIdAsync` and return a list of `Chapter` types.
6. WHEN a client sends a `vocabulary` query with optional `occurrences` and `comparison` filter arguments, THE `GraphQL_Server` SHALL delegate to `IVocabularyService` and return a list of `Word` types.
7. WHEN a client sends a `lessons` query, THE `GraphQL_Server` SHALL require a valid JWT and delegate to `ILessonService.GetAllLessonsAsync` for the `CurrentUser`.
8. WHEN a client sends a `progress` query, THE `GraphQL_Server` SHALL require a valid JWT and delegate to `IProgressService.GetUserProgressAsync` for the `CurrentUser`.
9. WHEN a client sends a `studySets` query, THE `GraphQL_Server` SHALL require a valid JWT and delegate to `IStudyService.GetUserSetsAsync` for the `CurrentUser`.
10. WHEN a client sends a `studyDashboard` query, THE `GraphQL_Server` SHALL require a valid JWT and delegate to `StudySessionService.GetDashboardAsync`.
11. WHEN a requested resource does not exist, THE `GraphQL_Server` SHALL return `null` for nullable fields and a GraphQL error with code `NOT_FOUND` for non-nullable fields.

---

### Requirement 3: Root Mutation Type

**User Story:** As a frontend developer, I want a unified GraphQL Mutation type that exposes all write operations, so that I can create, update, and delete data through a single typed interface.

#### Acceptance Criteria

1. THE `Schema` SHALL define a root `Mutation` type that aggregates write operations for all domain areas.
2. WHEN a client sends a `startStudySession` mutation with a `StartSessionInput`, THE `GraphQL_Server` SHALL require a valid JWT, delegate to `StudySessionService.StartSessionAsync`, and return a `Session` type.
3. WHEN a client sends a `rateCard` mutation with `sessionId`, `vocabId`, and `rating`, THE `GraphQL_Server` SHALL require a valid JWT, delegate to `StudySessionService.RateCardAsync`, and return a `RateCardResult` type.
4. WHEN a client sends a `completeStudySession` mutation with `sessionId`, THE `GraphQL_Server` SHALL require a valid JWT, delegate to `StudySessionService.CompleteSessionAsync`, and return a `SessionSummary` type.
5. WHEN a client sends a `createVocabularySet` mutation with a `CreateVocabularySetInput`, THE `GraphQL_Server` SHALL require a valid JWT, delegate to `IStudyService.CreateSetAsync`, and return a `VocabularySet` type.
6. WHEN a client sends a `deleteVocabularySet` mutation with `id`, THE `GraphQL_Server` SHALL require a valid JWT, delegate to `IStudyService.DeleteSetAsync`, and return a `Boolean` indicating success.
7. WHEN a client sends an `updateProgress` mutation with a `UserProgressInput`, THE `GraphQL_Server` SHALL require a valid JWT, delegate to `IProgressService.UpdateProgressAsync`, and return a `Boolean` indicating success.
8. WHEN a client sends a `completeLesson` mutation with a `CompleteLessonInput`, THE `GraphQL_Server` SHALL require a valid JWT, delegate to `ILessonService.CompleteLessonAsync`, and return a `LessonCompletionResult` type.
9. WHEN a client sends a `createBook` mutation with a `CreateBookInput`, THE `GraphQL_Server` SHALL require a valid JWT and the `Admin_User` role, delegate to `IBookService.CreateBookAsync`, and return a `Book` type.
10. WHEN a client sends an `updateBook` mutation with `id` and `UpdateBookInput`, THE `GraphQL_Server` SHALL require a valid JWT and the `Admin_User` role, delegate to `IBookService.UpdateBookAsync`, and return a nullable `Book` type.
11. WHEN a client sends a `deleteBook` mutation with `id`, THE `GraphQL_Server` SHALL require a valid JWT and the `Admin_User` role, delegate to `IBookService.DeleteBookAsync`, and return a `Boolean` indicating success.
12. WHEN a client sends a `createChapter` mutation with `bookId` and `CreateChapterInput`, THE `GraphQL_Server` SHALL require a valid JWT and the `Admin_User` role, delegate to `IChapterService.CreateChapterAsync`, and return a `Chapter` type.
13. WHEN a client sends an `updateChapter` mutation with `id` and `UpdateChapterInput`, THE `GraphQL_Server` SHALL require a valid JWT and the `Admin_User` role, delegate to `IChapterService.UpdateChapterAsync`, and return a nullable `Chapter` type.
14. WHEN a client sends a `deleteChapter` mutation with `id`, THE `GraphQL_Server` SHALL require a valid JWT and the `Admin_User` role, delegate to `IChapterService.DeleteChapterAsync`, and return a `Boolean` indicating success.
15. WHEN a client sends a `createVocabulary` mutation with a `CreateVocabularyInput`, THE `GraphQL_Server` SHALL require a valid JWT and the `Admin_User` role, delegate to `IVocabularyService.CreateVocabularyAsync`, and return a `Word` type.
16. WHEN a client sends an `updateVocabulary` mutation with `id` and `UpdateVocabularyInput`, THE `GraphQL_Server` SHALL require a valid JWT and the `Admin_User` role, delegate to `IVocabularyService.UpdateVocabularyAsync`, and return a nullable `Word` type.
17. WHEN a client sends a `deleteVocabulary` mutation with `id`, THE `GraphQL_Server` SHALL require a valid JWT and the `Admin_User` role, delegate to `IVocabularyService.DeleteVocabularyAsync`, and return a `Boolean` indicating success.
18. WHEN an admin mutation is attempted without the `Admin_User` role, THE `GraphQL_Server` SHALL return a GraphQL error with code `FORBIDDEN` and SHALL NOT invoke the underlying `Application_Service`.
19. WHEN a mutation input fails validation, THE `GraphQL_Server` SHALL return a GraphQL error with code `BAD_USER_INPUT` and a descriptive message without executing the underlying `Application_Service`.

---

### Requirement 4: GraphQL Type Definitions

**User Story:** As a backend developer, I want all domain entities represented as strongly-typed GraphQL object types, so that the Schema is self-documenting and clients receive predictable shapes.

#### Acceptance Criteria

1. THE `Schema` SHALL define a `Book` type with at minimum: `id: Int!`, `title: String!`, `abbreviation: String`, and a `chapters: [Chapter!]!` field resolved via a `DataLoader`.
2. THE `Schema` SHALL define a `Chapter` type with at minimum: `id: Int!`, `chapterNumber: Int!`, `bookId: Int!`, and a `words: [Word!]!` field resolved via a `DataLoader`.
3. THE `Schema` SHALL define a `Word` type with at minimum: `id: Int!`, `lemma: String!`, `gloss: String`, `occurrences: Int!`, and `grammaticalFeatures: [GrammaticalFeature!]!`.
4. THE `Schema` SHALL define a `RenderedChapter` type that mirrors the shape returned by `IReaderService.RenderChapterAsync`, including nested `RenderedUnit` types.
5. THE `Schema` SHALL define a `VocabularySet` type with at minimum: `id: Int!`, `name: String!`, and `items: [VocabularySetItem!]!`.
6. THE `Schema` SHALL define `Session`, `Card`, `RateCardResult`, and `SessionSummary` types that mirror the DTOs in `Koine.Application.Study.DTOs`.
7. THE `Schema` SHALL define `GrammaticalFeature` and `SyntacticalFeature` types with at minimum: `id: Int!`, `code: String!`, and `description: String`.
8. THE `Schema` SHALL define `UserProgress` and `Lesson` types that mirror their respective Application DTOs.
9. FOR ALL GraphQL types, non-nullable fields in the corresponding DTO SHALL be represented as non-nullable (`!`) in the `Schema`.

---

### Requirement 5: DataLoader Implementation

**User Story:** As a backend developer, I want DataLoaders for nested entity relationships, so that resolving lists of books, chapters, or words does not produce N+1 database queries.

#### Acceptance Criteria

1. THE `GraphQL_Server` SHALL implement a `ChaptersByBookIdDataLoader` that batches chapter lookups by `bookId` using a single `IChapterService` call per batch.
2. THE `GraphQL_Server` SHALL implement a `WordsByChapterIdDataLoader` that batches word lookups by `chapterId` using a single `IVocabularyService` call per batch.
3. THE `GraphQL_Server` SHALL implement a `GrammaticalFeaturesByIdDataLoader` that batches feature lookups by `id`.
4. WHEN a `Book.chapters` field is resolved for a list of books, THE `ChaptersByBookIdDataLoader` SHALL issue at most one database query regardless of the number of books in the list.
5. WHEN a `Chapter.words` field is resolved for a list of chapters, THE `WordsByChapterIdDataLoader` SHALL issue at most one database query regardless of the number of chapters in the list.
6. THE `GraphQL_Server` SHALL register all DataLoaders with scoped lifetime in the DI container.

---

### Requirement 6: Authentication and Authorization in Resolvers

**User Story:** As a security-conscious developer, I want GraphQL resolvers to enforce the same auth rules as the existing REST controllers, so that protected data cannot be accessed without a valid JWT.

#### Acceptance Criteria

1. THE `GraphQL_Server` SHALL extract the Bearer token from the `Authorization` header on every request and validate it using the existing JWT validation configuration in `Program.cs`.
2. WHEN a resolver is marked as requiring authentication and no valid JWT is present, THE `GraphQL_Server` SHALL return a GraphQL error with code `UNAUTHENTICATED` and SHALL NOT invoke the underlying `Application_Service`.
3. WHEN a resolver resolves `CurrentUser` from a valid JWT, THE `GraphQL_Server` SHALL use the same claim (`ClaimTypes.NameIdentifier`) as the existing REST controllers to extract the user ID.
4. THE `GraphQL_Server` SHALL NOT duplicate JWT validation logic — it SHALL reuse the `IHttpContextAccessor` and the existing ASP.NET Core authentication middleware.
5. WHILE a request is being processed, THE `GraphQL_Server` SHALL make `CurrentUser` available to all child resolvers in the same request via the GraphQL execution context.
6. WHEN a resolver is marked as requiring the `Admin_User` role and the `CurrentUser` does not hold that role, THE `GraphQL_Server` SHALL return a GraphQL error with code `FORBIDDEN` and SHALL NOT invoke the underlying `Application_Service`.

---

### Requirement 7: Frontend GraphQL Client Setup

**User Story:** As a frontend developer, I want Apollo Client configured in the Next.js app, so that I can send operations and receive TypeScript-typed responses with caching, error handling, and React hook integration out of the box.

#### Acceptance Criteria

1. THE `GraphQL_Client` SHALL be implemented using `@apollo/client` (with `graphql` and `graphql-tag` as peer dependencies) and the Apollo instance SHALL be initialised in `frontend/src/lib/api/graphql/client.ts`.
2. THE `GraphQL_Client` SHALL read the GraphQL endpoint URL from `NEXT_PUBLIC_GRAPHQL_URL` environment variable, with a fallback of `http://localhost:5001/graphql`.
3. WHEN a Clerk JWT is available, THE `GraphQL_Client` SHALL attach it as a `Bearer` token in the `Authorization` header of every request via an Apollo `authLink`.
4. THE `GraphQL_Client` SHALL support both server-side (Next.js RSC) and client-side execution contexts — server-side calls SHALL use a plain `HttpLink` without the in-memory cache, mirroring the pattern in `frontend/src/lib/api/rest/client.ts`.
5. THE `GraphQL_Client` SHALL expose typed React hooks (generated by `Codegen`) for use in Client Components, and a plain `query`/`mutate` helper for use in Server Components and Route Handlers.
6. THE `GraphQL_Client` SHALL NOT replace the existing `apiClient` in `frontend/src/lib/api/rest/client.ts` — both clients SHALL coexist during the transition.

---

### Requirement 8: Codegen and Typed Operations

**User Story:** As a frontend developer, I want GraphQL operations to be type-safe and auto-generated with Apollo Client hooks, so that schema changes surface as TypeScript compile errors rather than runtime bugs.

#### Acceptance Criteria

1. THE `Codegen` toolchain SHALL be configured via `frontend/codegen.ts` (or `codegen.yml`) to introspect the `GraphQL_Server` schema and generate TypeScript types into `frontend/src/lib/api/graphql/generated/`.
2. THE `Codegen` SHALL generate a typed React hook for every `.graphql` operation file placed in `frontend/src/lib/api/graphql/queries/` and `frontend/src/lib/api/graphql/mutations/` — query files SHALL produce `useXxxQuery` hooks and mutation files SHALL produce `useXxxMutation` hooks.
3. WHEN the `GraphQL_Server` schema changes, running `npm run codegen` in the `frontend/` directory SHALL regenerate all types and surface any breaking changes as TypeScript errors.
4. THE `Codegen` configuration SHALL use the `@graphql-codegen/typescript`, `@graphql-codegen/typescript-operations`, and `@graphql-codegen/typescript-react-apollo` plugins.
5. THE generated types SHALL use `unknown` instead of `any` for unresolved scalar types.
6. THE `Codegen` script SHALL be added to `frontend/package.json` as `"codegen": "graphql-codegen"`.
7. THE `Codegen` configuration SHALL set `withHooks: true` and `withResultType: true` in the `typescript-react-apollo` plugin options so every operation exports both a typed hook and a typed result interface.

---

### Requirement 9: Frontend Feature Transition — Reader

**User Story:** As a frontend developer, I want the Reader feature to fetch chapter data via GraphQL, so that the reader page benefits from typed, flexible data fetching.

#### Acceptance Criteria

1. THE `GraphQL_Client` SHALL provide a `FetchChapter` operation in `frontend/src/lib/api/graphql/queries/reader.graphql` that fetches `RenderedChapter` data by `bookId`, `chapterNumber`, and `lang`.
2. WHEN the reader page loads, THE reader data-fetching logic SHALL call the `useFetchChapterQuery` Apollo hook instead of the `fetchPage` REST helper in `frontend/src/lib/api/rest/reader.ts`.
3. THE `mapRenderedUnitsToDisplayUnits` mapping function in `frontend/src/lib/api/rest/reader.ts` SHALL be preserved and reused with the GraphQL response payload.
4. IF the GraphQL operation returns errors, THE reader page SHALL display the same error state as the current REST error path.

---

### Requirement 10: Frontend Feature Transition — Study Sessions

**User Story:** As a frontend developer, I want study session operations (start, rate card, complete) to use GraphQL mutations, so that the study flow is driven by a single typed API layer.

#### Acceptance Criteria

1. THE `GraphQL_Client` SHALL provide operation files for: `StartStudySession` mutation, `RateCard` mutation, `CompleteStudySession` mutation, `GetStudyDashboard` query, and `GetStudyProgress` query.
2. WHEN a user starts a study session, THE study feature SHALL call the `useStartStudySessionMutation` Apollo hook instead of the `startSession` REST helper.
3. WHEN a user rates a flashcard, THE study feature SHALL call the `useRateCardMutation` Apollo hook instead of the `rateCard` REST helper.
4. WHEN a user completes a session, THE study feature SHALL call the `useCompleteStudySessionMutation` Apollo hook instead of the `completeSession` REST helper.
5. WHEN the study dashboard loads, THE study feature SHALL call the `useGetStudyDashboardQuery` Apollo hook instead of the `getDashboard` REST helper.

---

### Requirement 11: Frontend Feature Transition — Vocabulary Sets

**User Story:** As a frontend developer, I want vocabulary set CRUD operations to use GraphQL, so that the vocabulary study feature is consistent with the rest of the GraphQL-driven UI.

#### Acceptance Criteria

1. THE `GraphQL_Client` SHALL provide operation files for: `GetVocabularySets` query, `CreateVocabularySet` mutation, `DeleteVocabularySet` mutation, `AddVocabularyToSet` mutation, and `RemoveVocabularyFromSet` mutation.
2. WHEN the vocabulary sets page loads, THE vocabulary feature SHALL call the `useGetVocabularySetsQuery` Apollo hook instead of the `fetchVocabularySets` REST helper.
3. WHEN a user creates a vocabulary set, THE vocabulary feature SHALL call the `useCreateVocabularySetMutation` Apollo hook instead of the `createVocabularySet` REST helper.
4. WHEN a user deletes a vocabulary set, THE vocabulary feature SHALL call the `useDeleteVocabularySetMutation` Apollo hook instead of the `deleteVocabularySet` REST helper.

---

### Requirement 12: Frontend Feature Transition — Lessons

**User Story:** As a frontend developer, I want the Lessons feature to fetch and complete lessons via GraphQL, so that lesson progression is driven by the same typed API layer as the rest of the app.

#### Acceptance Criteria

1. THE `GraphQL_Client` SHALL provide operation files for: `GetLessonTracks` query, `GetLessonsByTrack` query, `GetNextLesson` query, `GetLessonById` query, and `CompleteLesson` mutation.
2. WHEN the lessons page loads, THE lessons feature SHALL call the `useGetLessonTracksQuery` Apollo hook instead of the corresponding REST helper.
3. WHEN a user navigates to a lesson track, THE lessons feature SHALL call the `useGetLessonsByTrackQuery` Apollo hook instead of the corresponding REST helper.
4. WHEN a user completes a lesson, THE lessons feature SHALL call the `useCompleteLessonMutation` Apollo hook instead of the corresponding REST helper.
5. IF the `CompleteLesson` mutation returns errors, THE lessons feature SHALL display the same error state as the current REST error path.

---

### Requirement 13: Frontend Feature Transition — Progress

**User Story:** As a frontend developer, I want the Progress feature to read and update user progress via GraphQL, so that progress data is fetched through the unified typed API layer.

#### Acceptance Criteria

1. THE `GraphQL_Client` SHALL provide operation files for: `GetUserProgress` query, `GetUserLessons` query, `GetUserVocabulary` query, and `UpdateProgress` mutation.
2. WHEN the progress page loads, THE progress feature SHALL call the `useGetUserProgressQuery` Apollo hook instead of the corresponding REST helper.
3. WHEN the progress page loads user lesson history, THE progress feature SHALL call the `useGetUserLessonsQuery` Apollo hook instead of the corresponding REST helper.
4. WHEN the progress page loads user vocabulary history, THE progress feature SHALL call the `useGetUserVocabularyQuery` Apollo hook instead of the corresponding REST helper.
5. WHEN a user action triggers a progress update, THE progress feature SHALL call the `useUpdateProgressMutation` Apollo hook instead of the corresponding REST helper.
6. IF any progress GraphQL operation returns errors, THE progress feature SHALL display the same error state as the current REST error path.

---

### Requirement 14: Error Handling Consistency

**User Story:** As a frontend developer, I want GraphQL errors to be handled consistently with the existing REST error pattern, so that the UI error states remain predictable across both API layers.

#### Acceptance Criteria

1. WHEN the `GraphQL_Server` returns a top-level `errors` array, THE `GraphQL_Client` SHALL map it to an Apollo error result that the calling hook or component can inspect.
2. WHEN a GraphQL error has extension code `UNAUTHENTICATED`, THE frontend SHALL redirect the user to the login page using the same auth redirect logic as the REST layer.
3. WHEN a GraphQL error has extension code `NOT_FOUND`, THE frontend SHALL display a not-found UI state.
4. WHEN a GraphQL error has extension code `FORBIDDEN`, THE frontend SHALL display an access-denied UI state.
5. WHEN a network error occurs during a GraphQL operation, THE `GraphQL_Client` SHALL surface the error through Apollo's standard `error` return value so the calling component can render an appropriate error state.
6. THE `GraphQL_Client` SHALL log all errors using the same `console.error` pattern used in `frontend/src/lib/api/rest/client.ts`.

---

### Requirement 15: Coexistence and Backward Compatibility

**User Story:** As a developer, I want the GraphQL layer to coexist with the existing REST controllers during the transition, so that no existing functionality is broken before the migration is complete.

#### Acceptance Criteria

1. THE `REST_Layer` SHALL remain fully functional after the `GraphQL_Server` is registered — no existing REST controller SHALL be removed or modified as part of this feature.
2. THE `GraphQL_Server` SHALL reuse the same `Application_Service` instances as the `REST_Layer` — no business logic SHALL be duplicated.
3. WHEN both the REST and GraphQL endpoints are running, THE CORS policy SHALL apply to both `/api/*` and `/graphql` routes.
4. THE `GraphQL_Server` registration in `Program.cs` SHALL be additive — it SHALL not alter the existing middleware pipeline order for authentication, CORS, or controller routing.
5. WHERE a frontend feature has been transitioned to GraphQL, THE corresponding REST helper file in `frontend/src/lib/api/rest/` SHALL be retained but MAY be marked with a `// TODO: remove after GraphQL transition complete` comment.
