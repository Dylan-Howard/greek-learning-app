# Implementation Plan: Lesson Content Seeding

## Overview

Replace feature-code-driven lesson generation with MDX-file-driven lessons. The implementation proceeds layer by layer: domain entity updates → EF migration → MDX parser → seeder → application/API layer → frontend components.

## Tasks

- [ ] 1. Update `Lesson` entity and `KoineDbContext`
  - Add new nullable properties to `Koine.Domain/Entities/Lesson.cs`: `Description`, `EstimatedMinutes`, `VocabularyCount`, `TagsJson`, `ObjectivesJson`, `StructuredSectionsJson`, `DeletedAt`
  - Add global query filter in `KoineDbContext` to exclude rows where `DeletedAt IS NOT NULL`
  - _Requirements: 7.1, 7.3, 7.4_

- [ ] 2. Generate EF Core migration `AddMdxLessonFields`
  - Run `dotnet ef migrations add AddMdxLessonFields --project backend/src/Koine.Infrastructure --startup-project backend/src/Koine.API`
  - Verify the generated migration adds all seven new nullable columns with no data loss
  - _Requirements: 7.1, 7.2_

- [ ] 3. Implement `MdxParser` in `Koine.Infrastructure/Data/Seed/MdxParser.cs`
  - Define records: `LessonFrontmatter`, `VideoEmbedSection`, `ExternalLectureSection`, `ChecklistSection`, `ResourceItem`, `ResourcesSection`, `StructuredSections`, `ParsedMdx`
  - Implement `MdxParser.TryParse(string mdxContent)` following the parsing algorithm in the design:
    - Extract and deserialize YAML frontmatter block using `YamlDotNet`
    - Strip frontmatter and `import` lines from body
    - Extract `<YouTubeEmbed>`, `<LectureLinkBanner>`, `<ProgressChecklist>`, `<AdditionalResources>` props into `StructuredSections`; strip `<AttributionNote>` without storing
    - Remove all extracted JSX component calls from body; trim result
    - Return `null` on malformed YAML
  - _Requirements: 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 5.1, 5.2, 5.3, 5.4, 5.5_

  - [ ]* 3.1 Write property test: MdxParser is idempotent (Property 1)
    - **Property 1: MdxParser is idempotent**
    - Generate random valid MDX strings; assert two calls to `TryParse` produce byte-identical `ContentMarkdown` and serialized `StructuredSections`
    - **Validates: Requirements 1.6, 10.1**

  - [ ]* 3.2 Write property test: ContentMarkdown contains no JSX (Property 2)
    - **Property 2: ContentMarkdown contains no JSX**
    - Generate MDX with arbitrary JSX component calls; assert output has no lines matching `^import ` and no substrings matching `<[A-Z][A-Za-z]+`
    - **Validates: Requirements 1.3, 10.2**

  - [ ]* 3.3 Write property test: StructuredSections props are preserved verbatim (Property 3)
    - **Property 3: StructuredSections props are preserved verbatim**
    - Assert every string value extracted into `StructuredSections` appears verbatim in the original MDX body
    - **Validates: Requirement 10.3**

  - [ ]* 3.4 Write unit tests for `MdxParser`
    - Parses valid plummer MDX → correct frontmatter fields, clean markdown, `VideoEmbed` populated
    - Parses valid mounce MDX → `ExternalLecture` populated
    - Parses MDX with `<ProgressChecklist>` → `Checklist.Items` populated
    - Parses MDX with `<AdditionalResources>` → `Resources.Items` populated
    - Returns `null` for malformed YAML
    - `ContentMarkdown` contains no JSX tags after parsing
    - `<AttributionNote>` is stripped and not stored
    - _Requirements: 1.2, 1.3, 1.4, 5.1, 5.2, 5.3, 5.4, 5.5_

- [ ] 4. Checkpoint — Ensure all backend unit tests pass
  - Ensure all tests pass, ask the user if questions arise.

- [ ] 5. Implement `MdxLessonSeeder` in `Koine.Infrastructure/Data/Seed/MdxLessonSeeder.cs`
  - Inject `KoineDbContext`, `ILogger`, and content root path (via `IWebHostEnvironment` or config)
  - Implement `SeedAsync()` following the seed algorithm in the design:
    - Soft-delete legacy `grammar-*` / `syntax-*` lessons (set `DeletedAt = UtcNow` where null)
    - For each series `["plummer", "mounce"]` with sort orders `[1, 2]`:
      - Locate all `.mdx` files in `data/lessons/{series}/`
      - Parse `00-course-guide.mdx`; upsert `LessonTrack` (slug, title, description, sortOrder)
      - Seed course guide as `Lesson` with `LessonIndex = 0`, `LessonType = "course-guide"`, slug `{series}-00-course-guide`
      - For each non-course-guide `.mdx`: call `TryParse`, log+skip on null, derive slug, upsert `Lesson` with all fields
      - Collect expected slugs; soft-delete stale `Lesson` records not in the set
  - _Requirements: 2.1, 2.2, 2.3, 2.4, 2.5, 3.1, 3.2, 3.3, 3.4, 3.5, 3.6, 3.7, 3.8, 3.9, 4.1, 4.2, 4.3, 4.4, 4.5, 4.6, 5.6, 8.1, 8.2, 8.3, 9.1, 9.2_

  - [ ]* 5.1 Write property test: seeder upsert is idempotent (Property 4)
    - **Property 4: Seeder upsert is idempotent**
    - Run `MdxLessonSeeder.SeedAsync()` twice on an in-memory/SQLite DB; assert row counts are unchanged on the second run
    - **Validates: Requirements 3.8, 2.4**

  - [ ]* 5.2 Write property test: soft-delete excludes legacy lessons from queries (Property 5)
    - **Property 5: Soft-delete excludes legacy lessons from queries**
    - After seeding, assert any `Lesson` with slug matching `grammar-*` or `syntax-*` has `DeletedAt IS NOT NULL` and is excluded from all EF query results
    - **Validates: Requirement 8.3**

  - [ ]* 5.3 Write property test: stale lesson removal (Property 6)
    - **Property 6: Stale lesson removal**
    - Seed once, remove an MDX file from the test fixture, seed again; assert the corresponding `Lesson` is soft-deleted
    - **Validates: Requirement 3.9**

  - [ ]* 5.4 Write unit tests for `MdxLessonSeeder`
    - Seeds two tracks with correct slugs, titles, sort orders
    - Upserts lesson on second run — no duplicate rows
    - Soft-deletes legacy `grammar-*` lessons
    - Soft-deletes stale lesson when MDX file is removed
    - Skips malformed MDX file and continues
    - Course guide seeded as `LessonIndex = 0`, `LessonType = "course-guide"`
    - _Requirements: 2.1–2.5, 3.1–3.9, 8.3, 9.1, 9.2_

- [ ] 6. Wire `MdxLessonSeeder` into `DatabaseSeeder`
  - Register `MdxLessonSeeder` in DI (in `Program.cs` or the Infrastructure DI extension)
  - In `DatabaseSeeder.cs`: remove `EnsureTrackLessonsAsync` and its grammar/syntax generation logic; replace the `EnsureLessonTracksAndLessonsAsync` call with `MdxLessonSeeder.SeedAsync()`
  - _Requirements: 8.2, 8.4_

- [ ] 7. Checkpoint — Ensure all backend tests pass and seeder runs without errors
  - Ensure all tests pass, ask the user if questions arise.

- [ ] 8. Extend `LessonDto` and add `StructuredSectionsDto` types
  - Add `StructuredSectionsDto`, `VideoEmbedDto`, `ExternalLectureDto`, `ChecklistDto`, `ResourceItemDto`, `ResourcesDto` records to `Koine.Application/DTOs/Lessons/`
  - Extend `LessonDto` with `Description`, `EstimatedMinutes`, `VocabularyCount`, `Tags`, `Objectives`, `StructuredSections` fields
  - _Requirements: 6.1, 6.3, 6.4_

- [ ] 9. Update `LessonService.MapLesson` to populate new DTO fields
  - Deserialize `TagsJson`, `ObjectivesJson`, `StructuredSectionsJson` from the `Lesson` entity into the corresponding `LessonDto` fields
  - Return empty collections / empty `StructuredSectionsDto` when JSON fields are null
  - _Requirements: 6.2, 6.3, 6.4_

- [ ] 10. Extend `LessonType` GraphQL type and add structured section GraphQL types
  - Add new GraphQL `ObjectGraphType` classes in `Koine.API/GraphQL/Types/`: `StructuredSectionsType`, `VideoEmbedType`, `ExternalLectureType`, `ChecklistType`, `ResourcesType`, `ResourceItemType`
  - Extend `LessonType.cs` to expose `description`, `estimatedMinutes`, `vocabularyCount`, `tags`, `objectives`, `structuredSections` fields
  - Existing queries (`lessonById`, `lessonsByTrack`, `lessonTracks`, `nextLesson`, `userLessons`) automatically expose the new fields — no new query fields needed
  - _Requirements: 6.5, 6.6, 6.7_

- [ ] 11. Checkpoint — Ensure all backend tests pass and GraphQL schema is correct
  - Ensure all tests pass, ask the user if questions arise.

- [ ] 12. Update the `GetLessonById` GraphQL query document
  - Extend the `.graphql` query file in `frontend/src/lib/api/graphql/queries/` to include `description`, `estimatedMinutes`, `vocabularyCount`, `tags`, `objectives`, and the full `structuredSections` fragment
  - Regenerate TypeScript types: `nswag run backend/nswa.json` (or GraphQL codegen equivalent)
  - _Requirements: 6.1, 6.5_

- [ ] 13. Implement frontend structured section components
  - Create `VideoEmbed.tsx` in `frontend/src/components/features/lessons/` — responsive 16:9 YouTube iframe using MUI `Box` with aspect-ratio trick; named export
  - Create `ExternalLecture.tsx` — MUI `Card` with link icon, label, optional instructor; named export
  - Create `Checklist.tsx` — MUI `List` with `CheckCircleOutline` icons; renders nothing when `items` is empty; named export
  - Create `Resources.tsx` — MUI `List` of external links with optional description; renders nothing when `items` is empty; named export
  - Export all four from `frontend/src/components/features/lessons/index.ts`
  - Use MUI theme tokens only — no hardcoded style values
  - _Requirements: 5a.1, 5a.2, 5a.3, 5a.4, 5a.5, 5a.6_

  - [ ]* 13.1 Write unit tests for structured section components
    - `VideoEmbed`: renders `<iframe>` with correct `src` containing `videoId`
    - `ExternalLecture`: renders link with correct `href` and label text
    - `Checklist`: renders all items; renders nothing when `items` is empty
    - `Resources`: renders all items with links; renders nothing when `items` is empty
    - _Requirements: 5a.1–5a.5_

  - [ ]* 13.2 Write property test: null section renders no component (Property 7)
    - **Property 7: Frontend renders no structured section component when metadata is null**
    - Generate `LessonDto` with arbitrary null/non-null section combinations; assert rendered output contains `<iframe>` iff `videoEmbed` is non-null, etc.
    - **Validates: Requirement 5a.5**

- [ ] 14. Update `LessonDetailPage` to render structured sections and metadata
  - Consume `structuredSections`, `description`, `estimatedMinutes`, `tags`, `objectives` from the GraphQL query result
  - Render structured section components conditionally in order: `VideoEmbed` → `ExternalLecture` → prose markdown → `Checklist` → `Resources`
  - Show lesson metadata (description, estimated time, tags) in a header area above the content
  - Use optional chaining (`?.`) throughout to guard against null/missing fields
  - _Requirements: 5a.1, 5a.2, 5a.3, 5a.4, 5a.5, 6.2_

- [ ] 15. Final checkpoint — Ensure all tests pass
  - Ensure all tests pass, ask the user if questions arise.

## Notes

- Tasks marked with `*` are optional and can be skipped for faster MVP
- Property tests (3.1–3.3, 5.1–5.3, 13.2) use CsCheck/FsCheck (backend) and fast-check (frontend)
- Run backend tests single-threaded: `dotnet test backend/tests/Koine.Tests/Koine.Tests.csproj -m:1`
- Never hand-edit files in `Koine.Infrastructure/Migrations/` — always use `dotnet ef migrations add`
- The `data/lessons/` directory must be present at the content root for the seeder to run; missing directory logs a warning and returns early without aborting startup
