# Implementation Plan: GraphQL Integration

## Overview

Incrementally wire a GraphQL layer into the Koine backend (GraphQL-dotnet code-first) and transition all frontend features to Apollo Client. Backend tasks come first (infrastructure → types → queries → mutations → DataLoaders → auth), followed by frontend setup (Apollo Client → codegen → operation files → feature transitions). Each task builds directly on the previous one; no code is left unintegrated.

## Tasks

- [x] 1. Add GraphQL-dotnet NuGet package and register the endpoint in Program.cs
  - Add the latest stable `GraphQL` and `GraphQL.Server.Transports.AspNetCore` NuGet packages to `Koine.API.csproj`
  - Create `backend/src/Koine.API/GraphQL/Schema/KoineSchema.cs` with a stub `RootQuery` and `RootMutation`
  - Register `KoineSchema`, `RootQuery`, `RootMutation`, and `AddGraphQL(...)` in `Program.cs` after existing service registrations
  - Call `app.UseGraphQL<KoineSchema>("/graphql")` after `app.UseAuthorization()` and `app.UseGraphQLPlayground("/graphql/ui")` in Development only
  - Verify the `/graphql` endpoint accepts a POST with `{"query":"{ __typename }"}` and returns a valid envelope
  - _Requirements: 1.1, 1.2, 1.3, 1.4, 1.5, 15.4_

- [x] 2. Implement GraphQL object types for all domain entities
  - [x] 2.1 Create scalar and simple object types in `Koine.API/GraphQL/Types/`
    - Implement `BookType`, `ChapterType`, `WordType`, `GrammaticalFeatureType`, `SyntacticalFeatureType`
    - Implement `RenderedChapterType`, `RenderedUnitType`
    - Implement `VocabularySetType`, `VocabularySetItemType`
    - Implement `UserProgressType`, `LessonType`, `LessonTrackType`, `LessonCompletionResultType`
    - Implement `SessionType`, `CardType`, `CardFrontType`, `CardBackType`, `RateCardResultType`, `SessionSummaryType`, `DashboardType`, `ReviewHistoryPointType`
    - Map non-nullable DTO fields to `NonNullGraphType<T>` wrappers
    - _Requirements: 4.1, 4.2, 4.3, 4.4, 4.5, 4.6, 4.7, 4.8, 4.9_

  - [x] 2.2 Create input types in `Koine.API/GraphQL/Types/InputTypes/`
    - Implement `StartSessionInputType`, `CreateVocabularySetInputType`, `CompleteLessonInputType`, `UserProgressInputType`
    - Implement `CreateBookInputType`, `UpdateBookInputType`, `CreateChapterInputType`, `UpdateChapterInputType`
    - Implement `CreateVocabularyInputType`, `UpdateVocabularyInputType`
    - _Requirements: 3.2, 3.5, 3.7, 3.8, 3.9, 3.10, 3.12, 3.13, 3.15, 3.16_

  - [x] 2.3 Write unit tests for GraphQL type definitions
    - Assert schema introspection returns all expected root fields and types
    - Assert non-nullable DTO fields map to non-nullable GraphQL fields
    - _Requirements: 4.1–4.9_

- [x] 3. Implement DataLoaders
  - [x] 3.1 Implement `ChaptersByBookIdDataLoader` in `Koine.API/GraphQL/DataLoaders/`
    - Extend `BatchDataLoader<int, List<ChapterDto>>`; call `IChapterService.GetChaptersByBookIdsAsync` once per batch
    - Wire `Book.chapters` field in `BookType` to use this DataLoader
    - _Requirements: 5.1, 5.4_

  - [x] 3.2 Implement `WordsByChapterIdDataLoader`
    - Extend `BatchDataLoader<int, List<WordDto>>`; call `IVocabularyService` once per batch
    - Wire `Chapter.words` field in `ChapterType` to use this DataLoader
    - _Requirements: 5.2, 5.5_

  - [x] 3.3 Implement `GrammaticalFeaturesByIdDataLoader`
    - Extend `BatchDataLoader<int, GrammaticalFeatureDto>`; batch feature lookups by id
    - Register all three DataLoaders with scoped lifetime in `Program.cs`
    - _Requirements: 5.3, 5.6_

  - [ ]* 3.4 Write property test for DataLoader batching (Property 3)
    - **Property 3: DataLoader batching eliminates N+1 queries for nested fields**
    - Generate random lists of N books/chapters; assert service call count = 1 regardless of N using invocation-counting Moq stubs
    - **Validates: Requirements 5.1, 5.2, 5.3, 5.4, 5.5**

- [ ] 4. Implement RootQuery with all domain query fields
  - [ ] 4.1 Implement public query fields in `Koine.API/GraphQL/Queries/RootQuery.cs`
    - Add `books`, `book(id)`, `chapters(bookId)`, `vocabulary(occurrences, comparison)` fields delegating to their respective Application Services
    - Add `reader(bookId, chapterNumber, lang)` field delegating to `IReaderService.RenderChapterAsync`
    - _Requirements: 2.1, 2.2, 2.3, 2.4, 2.5, 2.6_

  - [ ] 4.2 Implement authenticated query fields
    - Add `lessons`, `progress`, `studySets`, `studyDashboard` fields with `AuthorizeWithPolicy("Authenticated")`
    - Resolve `CurrentUser` via `IHttpContextAccessor` using `ClaimTypes.NameIdentifier` (same claim path as REST controllers)
    - Return `null` for nullable not-found fields; return `NOT_FOUND` error for non-nullable not-found fields
    - _Requirements: 2.7, 2.8, 2.9, 2.10, 2.11, 6.1, 6.3, 6.5_

  - [ ] 4.3 Write property test for resolver output equivalence (Property 4)
    - **Property 4: Resolver output is structurally equivalent to Application Service output**
    - Generate random query arguments; assert resolver result deep-equals the Moq service return value
    - **Validates: Requirements 2.2–2.10**

  - [ ] 4.4 Write unit tests for RootQuery
    - Test each field delegates to the correct Application Service method
    - Test `NOT_FOUND` error is returned for missing non-nullable resources
    - _Requirements: 2.1–2.11_

- [ ] 5. Implement authentication and authorization enforcement
  - [ ] 5.1 Configure auth policies and `IHttpContextAccessor` wiring
    - Register `"Authenticated"` and `"AdminOnly"` authorization policies in `Program.cs` reusing existing JWT config
    - Implement `ResolveUserId` helper in `RootQuery` and `RootMutation` using `IHttpContextAccessor` and `ClaimTypes.NameIdentifier`
    - _Requirements: 6.1, 6.2, 6.3, 6.4, 6.5_

  - [ ] 5.2 Write property test for unauthenticated rejection (Property 1)
    - **Property 1: Unauthenticated requests are rejected without invoking services**
    - Generate random protected field names; assert `UNAUTHENTICATED` error returned and service mock never called
    - **Validates: Requirements 1.6, 6.2**

  - [ ] 5.3 Write property test for CurrentUser claim consistency (Property 6)
    - **Property 6: CurrentUser claim extraction is consistent across GraphQL and REST**
    - Generate random JWT payloads with `NameIdentifier` claims; assert GraphQL resolver and REST controller extract identical user IDs
    - **Validates: Requirements 6.3, 6.5**

- [ ] 6. Implement RootMutation with all write operations
  - [ ] 6.1 Implement user mutations in `Koine.API/GraphQL/Mutations/RootMutation.cs`
    - Add `startStudySession`, `rateCard`, `completeStudySession` mutations delegating to `StudySessionService`
    - Add `createVocabularySet`, `deleteVocabularySet` mutations delegating to `IStudyService`
    - Add `updateProgress` mutation delegating to `IProgressService`
    - Add `completeLesson` mutation delegating to `ILessonService`
    - All require `AuthorizeWithPolicy("Authenticated")`
    - _Requirements: 3.2, 3.3, 3.4, 3.5, 3.6, 3.7, 3.8_

  - [ ] 6.2 Implement admin mutations
    - Add `createBook`, `updateBook`, `deleteBook` mutations with `AuthorizeWithPolicy("AdminOnly")`
    - Add `createChapter`, `updateChapter`, `deleteChapter` mutations with `AuthorizeWithPolicy("AdminOnly")`
    - Add `createVocabulary`, `updateVocabulary`, `deleteVocabulary` mutations with `AuthorizeWithPolicy("AdminOnly")`
    - _Requirements: 3.9–3.17_

  - [ ] 6.3 Implement mutation input validation
    - Return `BAD_USER_INPUT` error for missing required fields or constraint violations before invoking any Application Service
    - _Requirements: 3.19_

  - [ ] 6.4 Write property test for non-admin forbidden (Property 2)
    - **Property 2: Non-admin users are forbidden from admin mutations**
    - Generate random admin mutation names and non-admin role claims; assert `FORBIDDEN` error and service not called
    - **Validates: Requirements 3.18, 6.6**

  - [ ] 6.5 Write property test for invalid input rejection (Property 5)
    - **Property 5: Invalid mutation inputs are rejected before service invocation**
    - Generate random invalid input objects; assert `BAD_USER_INPUT` and service not called
    - **Validates: Requirements 3.19**

  - [ ] 6.6 Write unit tests for RootMutation
    - Test each mutation delegates to the correct Application Service
    - Test `FORBIDDEN` is returned for admin mutations called by non-admin users
    - _Requirements: 3.1–3.19_

- [ ] 7. Checkpoint — backend GraphQL layer complete
  - Ensure all tests pass, ask the user if questions arise.
  - Verify schema introspection returns all expected types and fields
  - Verify `/graphql` and `/api/*` both respond correctly (coexistence)

- [ ] 8. Write property test for REST coexistence (Property 7)
  - **Property 7: REST endpoints are unaffected by GraphQL middleware registration**
  - Generate random REST endpoint paths and request bodies; assert response is identical with and without GraphQL middleware
  - **Validates: Requirements 15.1, 15.4**

- [ ] 9. Set up Apollo Client in the frontend
  - [ ] 9.1 Install frontend dependencies
    - Add `@apollo/client`, `graphql`, `graphql-tag` to `frontend/package.json`
    - Add `@graphql-codegen/cli`, `@graphql-codegen/typescript`, `@graphql-codegen/typescript-operations`, `@graphql-codegen/typescript-react-apollo` as dev dependencies
    - _Requirements: 7.1, 8.4_

  - [ ] 9.2 Implement `frontend/src/lib/api/graphql/client.ts`
    - Implement `createServerClient()` — plain `HttpLink`, no in-memory cache, mirrors `rest/client.ts` pattern
    - Implement `getApolloClient()` — singleton with `InMemoryCache` and `authLink` that reads Clerk JWT via `getToken()` and injects `Authorization: Bearer <token>`
    - Read endpoint from `NEXT_PUBLIC_GRAPHQL_URL` with fallback `http://localhost:5001/graphql`
    - Do not remove or modify `frontend/src/lib/api/rest/client.ts`
    - _Requirements: 7.1, 7.2, 7.3, 7.4, 7.6_

  - [ ] 9.3 Add Apollo provider to the Next.js app layout
    - Wrap the authenticated layout in an `ApolloProvider` using `getApolloClient()`
    - _Requirements: 7.5_

  - [ ] 9.4 Write property test for authLink JWT attachment (Property 8)
    - **Property 8: Apollo authLink attaches the Clerk JWT on every request**
    - Generate random JWT strings; assert every outgoing request header contains `Authorization: Bearer <token>`
    - **Validates: Requirements 7.3**

  - [ ] 9.5 Write unit tests for Apollo Client setup
    - Assert `createServerClient()` has no `InMemoryCache`
    - Assert `getApolloClient()` returns the same singleton instance on repeated calls
    - Assert `rest/client.ts` still exports `apiClient` (coexistence check)
    - _Requirements: 7.4, 7.6, 15.5_

- [ ] 10. Configure graphql-codegen and add the codegen script
  - Create `frontend/codegen.ts` with schema URL, document glob, and all three required plugins (`typescript`, `typescript-operations`, `typescript-react-apollo`)
  - Set `withHooks: true`, `withResultType: true`, scalar mappings for `UUID`/`DateTime`/`DateOnly`, and `nonOptionalTypename: false`
  - Add `"codegen": "graphql-codegen"` script to `frontend/package.json`
  - Create the `frontend/src/lib/api/graphql/generated/` directory with a `.gitkeep` placeholder
  - _Requirements: 8.1, 8.2, 8.3, 8.4, 8.5, 8.6, 8.7_

- [ ] 11. Implement frontend error handling via Apollo errorLink
  - Add an `errorLink` to the Apollo Client that inspects `graphQLErrors` and `networkError`
  - Map `UNAUTHENTICATED` → redirect to Clerk sign-in (same path as REST 401 handling)
  - Map `NOT_FOUND` → render not-found UI state
  - Map `FORBIDDEN` → render access-denied UI state
  - Log all errors via `console.error`, matching the pattern in `rest/client.ts`
  - _Requirements: 14.1, 14.2, 14.3, 14.4, 14.5, 14.6_

  - [ ] 11.1 Write property test for error code propagation (Property 10)
    - **Property 10: GraphQL error codes are propagated to the calling component**
    - Generate random GraphQL error arrays with known extension codes; assert `errorLink` maps each to the correct UI state and calls `console.error`
    - **Validates: Requirements 14.1–14.6**

- [ ] 12. Write GraphQL operation files and run codegen
  - [ ] 12.1 Create query operation files
    - `frontend/src/lib/api/graphql/queries/reader.graphql` — `FetchChapter(bookId, chapterNumber, lang)`
    - `frontend/src/lib/api/graphql/queries/books.graphql` — `GetBooks`, `GetBook(id)`
    - `frontend/src/lib/api/graphql/queries/vocabulary.graphql` — `GetVocabulary(occurrences, comparison)`
    - `frontend/src/lib/api/graphql/queries/lessons.graphql` — `GetLessonTracks`, `GetLessonsByTrack`, `GetNextLesson`, `GetLessonById`
    - `frontend/src/lib/api/graphql/queries/progress.graphql` — `GetUserProgress`, `GetUserLessons`, `GetUserVocabulary`
    - `frontend/src/lib/api/graphql/queries/study.graphql` — `GetStudyDashboard`, `GetStudyProgress`, `GetVocabularySets`
    - _Requirements: 9.1, 10.1, 11.1, 12.1, 13.1_

  - [ ] 12.2 Create mutation operation files
    - `frontend/src/lib/api/graphql/mutations/study.graphql` — `StartStudySession`, `RateCard`, `CompleteStudySession`
    - `frontend/src/lib/api/graphql/mutations/lessons.graphql` — `CompleteLesson`
    - `frontend/src/lib/api/graphql/mutations/progress.graphql` — `UpdateProgress`
    - `frontend/src/lib/api/graphql/mutations/vocabulary-sets.graphql` — `CreateVocabularySet`, `DeleteVocabularySet`, `AddVocabularyToSet`, `RemoveVocabularyFromSet`
    - `frontend/src/lib/api/graphql/mutations/admin.graphql` — `CreateBook`, `UpdateBook`, `DeleteBook`, `CreateChapter`, `UpdateChapter`, `DeleteChapter`, `CreateVocabulary`, `UpdateVocabulary`, `DeleteVocabulary`
    - _Requirements: 10.1, 11.1, 12.1, 13.1_

  - [ ] 12.3 Run codegen to generate typed hooks
    - Run `npm run codegen` from `frontend/` to generate `frontend/src/lib/api/graphql/generated/index.ts`
    - Verify generated file contains no `any` types and exports typed hooks for every operation
    - _Requirements: 8.2, 8.5, 8.7_

- [ ] 13. Checkpoint — frontend infrastructure complete
  - Ensure all tests pass, ask the user if questions arise.
  - Verify `npm run codegen` succeeds and `tsc --noEmit` passes with no errors

- [ ] 14. Transition Reader feature to GraphQL
  - Replace `fetchPage` REST helper calls in the reader data-fetching logic with `useFetchChapterQuery` Apollo hook
  - Preserve and reuse `mapRenderedUnitsToDisplayUnits` with the GraphQL response payload unchanged
  - Display the same error state as the current REST error path when the GraphQL operation returns errors
  - Add `// TODO: remove after GraphQL transition complete` comment to `frontend/src/lib/api/rest/reader.ts`
  - _Requirements: 9.1, 9.2, 9.3, 9.4, 15.5_

  - [ ] 14.1 Write property test for mapRenderedUnitsToDisplayUnits equivalence (Property 11)
    - **Property 11: mapRenderedUnitsToDisplayUnits produces identical output from GraphQL and REST payloads**
    - Generate random `RenderedUnit` trees; assert `mapRenderedUnitsToDisplayUnits` output is deeply equal whether input came from GraphQL or REST response shape
    - **Validates: Requirements 9.3**

- [ ] 15. Transition Study Sessions feature to GraphQL
  - Replace `startSession` REST helper with `useStartStudySessionMutation` Apollo hook
  - Replace `rateCard` REST helper with `useRateCardMutation` Apollo hook
  - Replace `completeSession` REST helper with `useCompleteStudySessionMutation` Apollo hook
  - Replace `getDashboard` REST helper with `useGetStudyDashboardQuery` Apollo hook
  - Add `// TODO: remove after GraphQL transition complete` comments to affected REST helper files
  - _Requirements: 10.1, 10.2, 10.3, 10.4, 10.5, 15.5_

- [ ] 16. Transition Vocabulary Sets feature to GraphQL
  - Replace `fetchVocabularySets` REST helper with `useGetVocabularySetsQuery` Apollo hook
  - Replace `createVocabularySet` REST helper with `useCreateVocabularySetMutation` Apollo hook
  - Replace `deleteVocabularySet` REST helper with `useDeleteVocabularySetMutation` Apollo hook
  - Add `// TODO: remove after GraphQL transition complete` comments to affected REST helper files
  - _Requirements: 11.1, 11.2, 11.3, 11.4, 15.5_

- [ ] 17. Transition Lessons feature to GraphQL
  - Replace lesson REST helpers with `useGetLessonTracksQuery`, `useGetLessonsByTrackQuery`, `useGetNextLessonQuery`, `useGetLessonByIdQuery` Apollo hooks
  - Replace lesson completion REST helper with `useCompleteLessonMutation` Apollo hook
  - Display the same error state as the current REST error path when `CompleteLesson` returns errors
  - Add `// TODO: remove after GraphQL transition complete` comments to affected REST helper files
  - _Requirements: 12.1, 12.2, 12.3, 12.4, 12.5, 15.5_

- [ ] 18. Transition Progress feature to GraphQL
  - Replace progress REST helpers with `useGetUserProgressQuery`, `useGetUserLessonsQuery`, `useGetUserVocabularyQuery` Apollo hooks
  - Replace progress update REST helper with `useUpdateProgressMutation` Apollo hook
  - Display the same error state as the current REST error path when any progress operation returns errors
  - Add `// TODO: remove after GraphQL transition complete` comments to affected REST helper files
  - _Requirements: 13.1, 13.2, 13.3, 13.4, 13.5, 13.6, 15.5_

- [ ] 19. Write property test for CORS header consistency (Property 12)
  - **Property 12: CORS headers are present on GraphQL endpoint responses**
  - Generate random allowed-origin values; assert `/graphql` responses include the same CORS headers as `/api/*` responses for the same origin
  - **Validates: Requirements 15.3**

- [ ] 20. Final checkpoint — Ensure all tests pass
  - Ensure all tests pass, ask the user if questions arise.
  - Run `dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1` and verify all backend tests pass
  - Run `npm run test` from `frontend/` and verify all frontend tests pass
  - Run `npm run codegen && tsc --noEmit` from `frontend/` and verify no TypeScript errors

## Notes

- Tasks marked with `*` are optional and can be skipped for faster MVP
- Each task references specific requirements for traceability
- Checkpoints ensure incremental validation at natural boundaries
- Property tests validate universal correctness properties (Properties 1–12 from the design document)
- Unit tests validate specific examples and edge cases
- The REST layer is never removed — both layers coexist throughout
