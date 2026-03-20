using System.Security.Claims;
using GraphQL;
using GraphQL.Types;
using Koine.API.GraphQL.Types;
using Koine.Application.Interfaces;
using Koine.Application.Study.Ports;
using Koine.Application.DTOs.Lessons;

namespace Koine.API.GraphQL.Queries;

/// <summary>
/// Root query type — aggregates all public and authenticated query fields.
/// </summary>
public class RootQuery : ObjectGraphType
{
    /// <summary>
    /// Initialises all query fields, delegating resolution to the
    /// corresponding Application Service.
    /// </summary>
    public RootQuery(
        IBookService bookService,
        IChapterService chapterService,
        IVocabularyService vocabularyService,
        IReaderService readerService,
        ILessonService lessonService,
        IProgressService progressService,
        IStudyService studyService,
        IStudySessionService studySessionService,
        IHttpContextAccessor http)
    {
        Name = "Query";
        Description = "Root query type for the Koine GraphQL API.";

        // ── books ──────────────────────────────────────────────────────────
        Field<ListGraphType<BookType>>("books")
            .Description("All books in the corpus.")
            .ResolveAsync(async _ => (object?)await bookService.GetAllBooksAsync());

        // ── book(id) ───────────────────────────────────────────────────────
        Field<BookType>("book")
            .Description("A single book by its integer ID, or null if not found.")
            .Argument<NonNullGraphType<IntGraphType>>("id", "The book ID.")
            .ResolveAsync(async ctx =>
                (object?)await bookService.GetBookByIdAsync(ctx.GetArgument<int>("id")));

        // ── chapters(bookId) ───────────────────────────────────────────────
        Field<ListGraphType<ChapterType>>("chapters")
            .Description("All chapters belonging to the specified book.")
            .Argument<NonNullGraphType<IntGraphType>>("bookId", "The book ID.")
            .ResolveAsync(async ctx =>
                (object?)await chapterService.GetChaptersByBookIdAsync(ctx.GetArgument<int>("bookId")));

        // ── vocabulary(occurrences, comparison) ────────────────────────────
        Field<ListGraphType<WordType>>("vocabulary")
            .Description("Vocabulary words, optionally filtered by occurrence count.")
            .Argument<IntGraphType>("occurrences", "Occurrence threshold for filtering.")
            .Argument<StringGraphType>("comparison", "Filter direction: \"greater\" or \"less\".")
            .ResolveAsync(async ctx =>
            {
                var words = await vocabularyService.GetAllSimpleAsync();

                var occurrences = ctx.GetArgument<int?>("occurrences");
                var comparison = ctx.GetArgument<string?>("comparison");

                if (occurrences.HasValue && !string.IsNullOrEmpty(comparison))
                {
                    words = comparison == "greater"
                        ? words.Where(w => w.Occurrences > occurrences.Value).ToList()
                        : words.Where(w => w.Occurrences < occurrences.Value).ToList();
                }

                return (object?)words;
            });

        // ── reader(bookId, chapterNumber, lang) ────────────────────────────
        Field<RenderedChapterType>("reader")
            .Description("Renders a chapter for reading, with optional language override.")
            .Argument<NonNullGraphType<IntGraphType>>("bookId", "The book ID.")
            .Argument<NonNullGraphType<IntGraphType>>("chapterNumber", "The chapter index (1-based).")
            .Argument<StringGraphType>("lang", "Target language code (defaults to \"en\").")
            .ResolveAsync(async ctx =>
            {
                var userId = ResolveUserId(http);
                var bookId = ctx.GetArgument<int>("bookId");
                var chapterNumber = ctx.GetArgument<int>("chapterNumber");
                var lang = ctx.GetArgument<string?>("lang") ?? "en";
                return (object?)await readerService.RenderChapterAsync(userId, bookId, chapterNumber, lang);
            });

        // ── lessons (authenticated) ────────────────────────────────────────
        Field<ListGraphType<LessonType>>("lessons")
            .Description("All lessons for the authenticated user, with completion status.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var userId = ResolveUserId(http);
                return (object?)await lessonService.GetAllLessonsAsync(userId);
            });

        // ── progress (authenticated) ───────────────────────────────────────
        Field<UserProgressType>("progress")
            .Description("Aggregated progress record for the authenticated user.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var userId = ResolveUserId(http);
                return (object?)await progressService.GetUserProgressAsync(userId);
            });

        // ── studySets (authenticated) ──────────────────────────────────────
        Field<ListGraphType<VocabularySetType>>("studySets")
            .Description("All vocabulary sets belonging to the authenticated user.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var userId = ResolveUserId(http);
                return (object?)await studyService.GetUserSetsAsync(userId);
            });

        // ── studyDashboard (authenticated) ────────────────────────────────
        Field<NonNullGraphType<DashboardType>>("studyDashboard")
            .Description("Study dashboard with card counts and review history for the authenticated user.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var result = await studySessionService.GetDashboardAsync(ctx.CancellationToken);
                if (result == null)
                    throw new ExecutionError("Resource not found.") { Code = "NOT_FOUND" };
                return (object?)result;
            });

        // ── studyProgress (authenticated) ─────────────────────────────────
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<CardProgressType>>>>("studyProgress")
            .Description("Card-level SRS progress records for the authenticated user.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
                (object?)await studySessionService.GetProgressAsync(ctx.CancellationToken));

        // ── lessonTracks (authenticated) ──────────────────────────────────
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<LessonTrackType>>>>("lessonTracks")
            .Description("All lesson tracks with completion metadata for the authenticated user.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var userId = ResolveUserId(http);
                return (object?)await lessonService.GetLessonTracksAsync(userId, includeLessons: true);
            });

        // ── lessonsByTrack (authenticated) ────────────────────────────────
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<LessonType>>>>("lessonsByTrack")
            .Description("All lessons within a specific track for the authenticated user.")
            .Argument<NonNullGraphType<StringGraphType>>("trackSlug", "The track slug.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var userId = ResolveUserId(http);
                var trackSlug = ctx.GetArgument<string>("trackSlug");
                return (object?)await lessonService.GetLessonsByTrackAsync(userId, trackSlug);
            });

        // ── nextLesson (authenticated) ────────────────────────────────────
        Field<LessonType>("nextLesson")
            .Description("The next incomplete lesson in a track for the authenticated user, or null if all complete.")
            .Argument<NonNullGraphType<StringGraphType>>("trackSlug", "The track slug.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var userId = ResolveUserId(http);
                var trackSlug = ctx.GetArgument<string>("trackSlug");
                return (object?)await lessonService.GetNextLessonAsync(userId, trackSlug);
            });

        // ── lessonById (authenticated) ────────────────────────────────────
        Field<LessonType>("lessonById")
            .Description("A single lesson by its ID, with completion status for the authenticated user.")
            .Argument<NonNullGraphType<IntGraphType>>("id", "The lesson ID.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var userId = ResolveUserId(http);
                var id = ctx.GetArgument<int>("id");
                return (object?)await lessonService.GetLessonByIdAsync(id, userId);
            });

        // ── userLessons (authenticated) ───────────────────────────────────
        Field<NonNullGraphType<ListGraphType<NonNullGraphType<LessonType>>>>("userLessons")
            .Description("All lessons the authenticated user has interacted with, with completion status.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var userId = ResolveUserId(http);
                return (object?)await lessonService.GetAllLessonsAsync(userId);
            });
    }

    /// <summary>
    /// Extracts the integer user ID from the current HTTP context's JWT claims.
    /// Falls back to 0 for unauthenticated requests (the service handles anonymous access).
    /// </summary>
    private static int ResolveUserId(IHttpContextAccessor http)
    {
        var claim = http.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        return int.TryParse(claim, out var id) ? id : 0;
    }
}
