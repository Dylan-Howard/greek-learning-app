# Requirements Document

## Introduction

Replace the current feature-code-driven lesson generation with textbook-chapter-driven lessons sourced from human-authored MDX files in `data/lessons/`. The two series — `plummer/` (24 chapters + course guide, keyed to Merkle & Plummer's *Beginning with New Testament Greek*) and `mounce/` (33 chapters + course guide, keyed to Mounce's *Basics of Biblical Greek*) — each map to a `LessonTrack`. At seed time, each MDX file is parsed, its frontmatter metadata is stored on the `Lesson` entity, and its body is converted to clean markdown (JSX component calls stripped entirely from the body). Structured section data (video embed, external lecture link, checklist, resources) is extracted from JSX component props and stored as a separate JSON metadata field (`Lesson.StructuredSectionsJson`), completely independent of `ContentMarkdown`. The frontend renders dedicated, on-theme MUI components for each section type when the corresponding metadata is present, without needing a JSX runtime. Legacy feature-code-driven lessons are soft-deleted rather than physically removed, preserving historical data while excluding them from all normal queries.

## Glossary

- **MDX_File**: A `.mdx` file in `data/lessons/{series}/` containing YAML frontmatter and a markdown body with optional JSX component calls.
- **Frontmatter**: The YAML block delimited by `---` at the top of an MDX_File.
- **Series**: One of the two lesson collections: `plummer` or `mounce`.
- **LessonTrack**: A database entity (`Koine.Domain.Entities.LessonTrack`) representing one textbook series.
- **Lesson**: A database entity (`Koine.Domain.Entities.Lesson`) representing one chapter lesson within a LessonTrack.
- **LessonSeeder**: The component responsible for parsing MDX_Files and upserting LessonTrack and Lesson records during application startup.
- **MdxParser**: The component that reads an MDX_File, extracts Frontmatter, and converts the body to clean markdown.
- **StructuredSections**: Structured metadata extracted from JSX component props (video embed info, external lecture link, checklist items, resource links), stored as a separate JSON field (`Lesson.StructuredSectionsJson`) entirely independent of `ContentMarkdown`. The markdown body never contains structured section data.
- **LessonDto**: The application-layer data transfer object returned by the lessons API.
- **ContentMarkdown**: The cleaned markdown body of a lesson, stored in `Lesson.ContentMarkdown`, with JSX component calls removed.
- **CourseGuide**: The `chapter: 0` MDX_File in each series (e.g. `00-course-guide.mdx`), treated as a special overview lesson.
- **Slug**: A URL-safe identifier for a Lesson, derived from the MDX filename (e.g. `plummer-01-alphabet-pronunciation`).

---

## Requirements

### Requirement 1: Parse MDX Files at Seed Time

**User Story:** As a developer, I want the seeder to parse MDX files from `data/lessons/` at application startup, so that lesson content is stored in the database and served without runtime file I/O.

#### Acceptance Criteria

1. WHEN the application starts and the seeder runs, THE LessonSeeder SHALL locate all `.mdx` files under `data/lessons/plummer/` and `data/lessons/mounce/`.
2. WHEN an MDX_File is read, THE MdxParser SHALL extract the YAML Frontmatter block and parse it into a typed model.
3. WHEN an MDX_File is read, THE MdxParser SHALL extract the markdown body, strip all JSX import statements and JSX component calls entirely (not replacing them with any substitute text), and return the remaining prose and table content as ContentMarkdown.
4. IF an MDX_File has malformed YAML Frontmatter, THEN THE LessonSeeder SHALL log a warning with the file path and skip that file without aborting the seed run.
5. IF an MDX_File body contains a JSX component call that carries structured data (e.g. `<YouTubeEmbed>`, `<LectureLinkBanner>`, `<ProgressChecklist>`, `<AdditionalResources>`), THEN THE MdxParser SHALL extract the component's props into StructuredSections metadata and store them in `Lesson.StructuredSectionsJson` — the extracted data SHALL NOT appear in ContentMarkdown.
6. THE MdxParser SHALL produce equivalent output when parsing the same MDX_File twice (idempotent parse).

---

### Requirement 2: Map Series to LessonTracks

**User Story:** As a developer, I want each series directory to map to a distinct LessonTrack record, so that the two textbook series are independently navigable in the application.

#### Acceptance Criteria

1. WHEN the LessonSeeder runs, THE LessonSeeder SHALL upsert a LessonTrack with slug `plummer` for the `data/lessons/plummer/` series.
2. WHEN the LessonSeeder runs, THE LessonSeeder SHALL upsert a LessonTrack with slug `mounce` for the `data/lessons/mounce/` series.
3. THE LessonSeeder SHALL set the LessonTrack `Title` and `Description` from the CourseGuide Frontmatter fields `title` and `description` for that series.
4. WHILE a LessonTrack already exists with the correct slug, THE LessonSeeder SHALL update its `Title` and `Description` if the CourseGuide Frontmatter has changed, without creating a duplicate record.
5. THE LessonSeeder SHALL assign `SortOrder` 1 to the `plummer` track and `SortOrder` 2 to the `mounce` track.

---

### Requirement 3: Seed Lessons from MDX Files

**User Story:** As a developer, I want each MDX file (excluding the course guide) to produce one Lesson record, so that every textbook chapter is individually accessible and completable.

#### Acceptance Criteria

1. WHEN the LessonSeeder processes a series, THE LessonSeeder SHALL create or update one Lesson per non-course-guide MDX_File, ordered by the `chapter` Frontmatter field ascending.
2. THE LessonSeeder SHALL derive the Lesson `Slug` from the series slug and the MDX filename stem (e.g. `plummer-01-alphabet-pronunciation`).
3. THE LessonSeeder SHALL set `Lesson.Title` from the Frontmatter `title` field.
4. THE LessonSeeder SHALL set `Lesson.LessonIndex` to the Frontmatter `chapter` value.
5. THE LessonSeeder SHALL set `Lesson.LessonType` to `"chapter"` for all chapter lessons.
6. THE LessonSeeder SHALL store the cleaned ContentMarkdown in `Lesson.ContentMarkdown`.
7. THE LessonSeeder SHALL store the StructuredSections JSON in a new `Lesson.StructuredSectionsJson` field.
8. WHILE a Lesson with the same Slug already exists in the database, THE LessonSeeder SHALL update all mutable fields rather than inserting a duplicate.
9. IF a Lesson exists in the database for a LessonTrack but no corresponding MDX_File is found on disk, THEN THE LessonSeeder SHALL remove that stale Lesson record.

---

### Requirement 4: Store Lesson Metadata from Frontmatter

**User Story:** As a developer, I want key frontmatter fields stored on the Lesson entity, so that the API can return rich metadata without re-parsing files at runtime.

#### Acceptance Criteria

1. THE LessonSeeder SHALL store the Frontmatter `description` field in a new `Lesson.Description` column.
2. THE LessonSeeder SHALL store the Frontmatter `estimatedMinutes` field in a new `Lesson.EstimatedMinutes` column (nullable integer).
3. THE LessonSeeder SHALL store the Frontmatter `vocabularyCount` field in a new `Lesson.VocabularyCount` column (nullable integer).
4. THE LessonSeeder SHALL store the Frontmatter `tags` array as a JSON string in a new `Lesson.TagsJson` column.
5. THE LessonSeeder SHALL store the Frontmatter `objectives` array as a JSON string in a new `Lesson.ObjectivesJson` column.
6. IF a Frontmatter field is absent from an MDX_File, THEN THE LessonSeeder SHALL store a null or empty-collection default for that field without error.

---

### Requirement 5: Represent Structured Sections

**User Story:** As a developer, I want JSX component data extracted into a typed StructuredSections model stored as metadata, so that the frontend can render video embeds, lecture links, checklists, and resource lists from structured data rather than parsing markdown.

#### Acceptance Criteria

1. WHEN a plummer-series MDX_File contains a `<YouTubeEmbed>` component, THE MdxParser SHALL extract the `videoId` and `title` props into a `VideoEmbed` section within StructuredSections.
2. WHEN a mounce-series MDX_File contains a `<LectureLinkBanner>` component, THE MdxParser SHALL extract the `url`, `label`, and `instructor` props into an `ExternalLecture` section within StructuredSections.
3. WHEN an MDX_File contains a `<ProgressChecklist>` component, THE MdxParser SHALL extract the `items` array into a `Checklist` section within StructuredSections.
4. WHEN an MDX_File contains an `<AdditionalResources>` component, THE MdxParser SHALL extract the `items` array (each with `label`, `url`, and optional `description`) into a `Resources` section within StructuredSections.
5. WHEN an MDX_File contains none of the above components, THE MdxParser SHALL produce an empty StructuredSections object (no null reference).
6. THE LessonSeeder SHALL serialize StructuredSections to JSON and store it in `Lesson.StructuredSectionsJson`, which is a field entirely separate from `Lesson.ContentMarkdown`. The markdown body SHALL never contain structured section data.

---

### Requirement 5a: Frontend Structured Section Components

**User Story:** As a learner, I want the lesson page to render dedicated UI components for each structured section type, so that video embeds, lecture links, checklists, and resource lists are displayed using the app's visual theme rather than as raw text.

#### Acceptance Criteria

1. THE lesson page SHALL render a `VideoEmbed` component when `StructuredSections.VideoEmbed` is non-null, placed in `src/components/features/lessons/`.
2. THE lesson page SHALL render an `ExternalLecture` component when `StructuredSections.ExternalLecture` is non-null, placed in `src/components/features/lessons/`.
3. THE lesson page SHALL render a `Checklist` component when `StructuredSections.Checklist` is non-null and its `items` array is non-empty, placed in `src/components/features/lessons/`.
4. THE lesson page SHALL render a `Resources` component when `StructuredSections.Resources` is non-null and its `items` array is non-empty, placed in `src/components/features/lessons/`.
5. WHEN a structured section metadata field is null or empty, THE lesson page SHALL NOT render the corresponding component.
6. THE structured section components SHALL use MUI theme tokens (colours, spacing, typography) consistent with the rest of the application — no hardcoded style values.

---

### Requirement 6: Expose Enriched Lesson Data via API

**User Story:** As a frontend developer, I want the lessons GraphQL API to return all stored metadata and structured sections, so that the lesson page can render the full lesson experience without additional requests.

#### Acceptance Criteria

1. THE existing `LessonDto` class SHALL be extended with `Description` (string?), `EstimatedMinutes` (int?), `VocabularyCount` (int?), `Tags` (List\<string\>), `Objectives` (List\<string\>), and `StructuredSections` (typed object) fields in addition to existing fields.
2. WHEN a client requests a lesson, THE LessonService SHALL return a LessonDto populated with all metadata fields.
3. THE `LessonDto.StructuredSections` field SHALL be a typed object (not a raw JSON string) deserialized from `Lesson.StructuredSectionsJson`.
4. IF `Lesson.StructuredSectionsJson` is null or empty, THEN THE LessonService SHALL return an empty StructuredSections object in the LessonDto.
5. THE existing `LessonType` GraphQL type (in `Koine.API/GraphQL/Types/LessonType.cs`) SHALL be extended to expose the new `LessonDto` fields (`description`, `estimatedMinutes`, `vocabularyCount`, `tags`, `objectives`, `structuredSections`).
6. THE existing GraphQL queries (`lessonById`, `lessonsByTrack`, `lessonTracks`, `nextLesson`, `userLessons`) SHALL automatically expose the new fields once `LessonDto` and `LessonType` are updated — no new query fields are required.
7. THE REST `LessonsController` SHALL NOT be modified as part of this feature.

---

### Requirement 7: Database Schema Migration

**User Story:** As a developer, I want the new Lesson columns added via an EF Core migration, so that the schema change is tracked and reproducible.

#### Acceptance Criteria

1. THE LessonSeeder SHALL require the following new nullable columns on the `Lessons` table: `Description` (nvarchar(max)), `EstimatedMinutes` (int), `VocabularyCount` (int), `TagsJson` (nvarchar(max)), `ObjectivesJson` (nvarchar(max)), `StructuredSectionsJson` (nvarchar(max)), and `DeletedAt` (datetime2, nullable).
2. WHEN the migration is applied to a database that already has Lesson rows, THE migration SHALL add the new columns with null defaults without data loss.
3. THE Lesson entity class SHALL be updated to include properties for all new columns before the migration is generated.
4. THE `KoineDbContext` SHALL configure a global query filter on the `Lesson` entity so that all normal queries automatically exclude rows where `DeletedAt` is not null.

---

### Requirement 8: Remove Feature-Code-Driven Lesson Generation

**User Story:** As a developer, I want the old grammar/syntax feature-driven lesson generation removed from the seeder, so that the database is not populated with auto-generated placeholder lessons that conflict with the new textbook-chapter lessons.

#### Acceptance Criteria

1. WHEN the LessonSeeder runs, THE LessonSeeder SHALL NOT generate lessons from `GrammaticalFeature` or `SyntacticalFeature` rows.
2. THE LessonSeeder SHALL remove the `EnsureTrackLessonsAsync` method and its grammar/syntax lesson generation logic from `DatabaseSeeder.cs`.
3. WHEN the application starts on a database that contains legacy feature-code-driven lessons (slugs matching `grammar-*` or `syntax-*`), THE LessonSeeder SHALL soft-delete those records by setting `Lesson.DeletedAt` to the current UTC timestamp. THE LessonSeeder SHALL NOT physically remove those rows from the database.
4. THE LessonSeeder SHALL preserve the existing `UpsertTrackLessonAsync` helper or replace it with an equivalent that supports the new MDX-sourced lesson shape.

---

### Requirement 9: CourseGuide Lesson

**User Story:** As a learner, I want the course guide (chapter 0) available as a navigable lesson, so that I can access the series overview and lesson index from within the app.

#### Acceptance Criteria

1. WHEN the LessonSeeder processes a series, THE LessonSeeder SHALL seed the CourseGuide MDX_File as a Lesson with `LessonIndex` 0 and `LessonType` `"course-guide"`.
2. THE LessonSeeder SHALL derive the CourseGuide Lesson `Slug` as `{series}-00-course-guide`.
3. WHEN a client requests the lesson list for a track, THE LessonService SHALL include the CourseGuide lesson in the response, ordered before chapter lessons.

---

### Requirement 10: Round-Trip Content Fidelity

**User Story:** As a developer, I want to verify that parsing and re-serializing lesson content produces stable output, so that repeated seed runs do not corrupt stored content.

#### Acceptance Criteria

1. FOR ALL valid MDX_Files in `data/lessons/`, parsing the file and serializing the resulting ContentMarkdown and StructuredSections to their stored forms SHALL produce byte-identical output on a second parse of the same file.
2. FOR ALL valid MDX_Files, the ContentMarkdown stored in the database SHALL contain no JSX import lines and no JSX component call tags.
3. FOR ALL valid MDX_Files, every prop value extracted into StructuredSections SHALL be present in the original MDX_File body without modification.
