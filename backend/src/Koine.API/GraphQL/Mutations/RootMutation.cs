using System.Security.Claims;
using GraphQL;
using GraphQL.Types;
using Koine.API.GraphQL.Types;
using Koine.API.GraphQL.Types.InputTypes;
using Koine.Application.DTOs.Books;
using Koine.Application.DTOs.Chapters;
using Koine.Application.DTOs.Lessons;
using Koine.Application.DTOs.Progress;
using Koine.Application.DTOs.Study;
using Koine.Application.DTOs.Vocabulary;
using Koine.Application.Interfaces;
using Koine.Application.Study.DTOs;
using Koine.Application.Study.Ports;
using Koine.Domain.Entities;

namespace Koine.API.GraphQL.Mutations;

/// <summary>
/// Root mutation type — aggregates all domain write operations.
/// User mutations require the "Authenticated" policy; admin mutations require "AdminOnly".
/// </summary>
public class RootMutation : ObjectGraphType
{
    /// <summary>
    /// Initialises all mutation fields, delegating resolution to the
    /// corresponding Application Service.
    /// </summary>
    public RootMutation(
        IStudySessionService studySessionService,
        IStudyService studyService,
        IProgressService progressService,
        ILessonService lessonService,
        IBookService bookService,
        IChapterService chapterService,
        IVocabularyService vocabularyService,
        IHttpContextAccessor http)
    {
        Name = "Mutation";
        Description = "Root mutation type for the Koine GraphQL API.";

        // ── startStudySession ──────────────────────────────────────────────
        Field<NonNullGraphType<SessionType>>("startStudySession")
            .Description("Starts a new spaced-repetition study session for the authenticated user.")
            .Argument<NonNullGraphType<StartSessionInputType>>("input", "Session configuration.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var input = ctx.GetArgument<StartSessionRequest>("input");
                ValidateNonEmpty(input.Pool.ToString(), "pool");
                ValidateNonEmpty(input.Direction.ToString(), "direction");
                ValidateNonEmpty(input.Mode.ToString(), "mode");
                ValidateNonEmpty(input.Source.ToString(), "source");
                return (object?)await studySessionService.StartSessionAsync(input, ctx.CancellationToken);
            });

        // ── rateCard ───────────────────────────────────────────────────────
        Field<RateCardResultType>("rateCard")
            .Description("Records a rating for a card in the given session.")
            .Argument<NonNullGraphType<IdGraphType>>("sessionId", "The session GUID.")
            .Argument<NonNullGraphType<IntGraphType>>("vocabularyId", "The vocabulary ID of the card.")
            .Argument<NonNullGraphType<IntGraphType>>("rating", "Rating value: 1=Again, 2=Hard, 3=Good, 4=Easy.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var sessionIdRaw = ctx.GetArgument<string>("sessionId");
                if (!Guid.TryParse(sessionIdRaw, out var sessionId))
                    throw new ExecutionError("sessionId must be a valid GUID.") { Code = "BAD_USER_INPUT" };

                var ratingInt = ctx.GetArgument<int>("rating");
                if (ratingInt < 1 || ratingInt > 4)
                    throw new ExecutionError("rating must be between 1 and 4.") { Code = "BAD_USER_INPUT" };

                var vocabularyId = ctx.GetArgument<int>("vocabularyId");
                var rating = (Rating)ratingInt;
                return (object?)await studySessionService.RateCardAsync(sessionId, vocabularyId, rating, ctx.CancellationToken);
            });

        // ── completeStudySession ───────────────────────────────────────────
        Field<SessionSummaryType>("completeStudySession")
            .Description("Completes the given study session and returns a summary.")
            .Argument<NonNullGraphType<IdGraphType>>("sessionId", "The session GUID.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var sessionIdRaw = ctx.GetArgument<string>("sessionId");
                if (!Guid.TryParse(sessionIdRaw, out var sessionId))
                    throw new ExecutionError("sessionId must be a valid GUID.") { Code = "BAD_USER_INPUT" };

                return (object?)await studySessionService.CompleteSessionAsync(sessionId, ctx.CancellationToken);
            });

        // ── createVocabularySet ────────────────────────────────────────────
        Field<NonNullGraphType<VocabularySetType>>("createVocabularySet")
            .Description("Creates a new vocabulary set for the authenticated user.")
            .Argument<NonNullGraphType<CreateVocabularySetInputType>>("input", "Vocabulary set details.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var input = ctx.GetArgument<CreateVocabularySetDto>("input");
                ValidateNonEmpty(input.Title, "title");
                var userId = ResolveUserId(http);
                return (object?)await studyService.CreateSetAsync(userId, input);
            });

        // ── deleteVocabularySet ────────────────────────────────────────────
        Field<NonNullGraphType<BooleanGraphType>>("deleteVocabularySet")
            .Description("Deletes a vocabulary set owned by the authenticated user.")
            .Argument<NonNullGraphType<IntGraphType>>("id", "The vocabulary set ID.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var id = ctx.GetArgument<int>("id");
                var userId = ResolveUserId(http);
                return (object?)await studyService.DeleteSetAsync(id, userId);
            });

        // ── addVocabularyToSet ─────────────────────────────────────────────
        Field<NonNullGraphType<BooleanGraphType>>("addVocabularyToSet")
            .Description("Adds a vocabulary word to a set owned by the authenticated user.")
            .Argument<NonNullGraphType<IntGraphType>>("setId", "The vocabulary set ID.")
            .Argument<NonNullGraphType<IntGraphType>>("vocabularyId", "The vocabulary word ID to add.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var setId = ctx.GetArgument<int>("setId");
                var vocabularyId = ctx.GetArgument<int>("vocabularyId");
                var userId = ResolveUserId(http);
                return (object?)await studyService.AddVocabularyToSetAsync(setId, userId, vocabularyId);
            });

        // ── removeVocabularyFromSet ────────────────────────────────────────
        Field<NonNullGraphType<BooleanGraphType>>("removeVocabularyFromSet")
            .Description("Removes a vocabulary word from a set owned by the authenticated user.")
            .Argument<NonNullGraphType<IntGraphType>>("setId", "The vocabulary set ID.")
            .Argument<NonNullGraphType<IntGraphType>>("vocabularyId", "The vocabulary word ID to remove.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var setId = ctx.GetArgument<int>("setId");
                var vocabularyId = ctx.GetArgument<int>("vocabularyId");
                var userId = ResolveUserId(http);
                return (object?)await studyService.RemoveVocabularyFromSetAsync(setId, userId, vocabularyId);
            });

        // ── updateProgress ─────────────────────────────────────────────────
        Field<NonNullGraphType<BooleanGraphType>>("updateProgress")
            .Description("Updates the authenticated user's overall progress record.")
            .Argument<NonNullGraphType<UserProgressInputType>>("input", "Progress data.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var raw = ctx.GetArgument<Dictionary<string, object>>("input");
                var completedLessonIds = raw.TryGetValue("completedLessonIds", out var ids)
                    ? ((IEnumerable<object>)ids).Select(x => Convert.ToInt32(x)).ToList()
                    : new List<int>();
                var totalExperience = raw.TryGetValue("totalExperience", out var xp)
                    ? Convert.ToInt32(xp)
                    : 0;

                var progressDto = new UserProgressDto
                {
                    CompletedLessonIds = completedLessonIds,
                    TotalExperience = totalExperience,
                    UpdatedAt = DateTime.UtcNow
                };
                var userId = ResolveUserId(http);
                return (object?)await progressService.UpdateProgressAsync(userId, progressDto);
            });

        // ── completeLesson ─────────────────────────────────────────────────
        Field<LessonCompletionResultType>("completeLesson")
            .Description("Marks a lesson as completed for the authenticated user.")
            .Argument<NonNullGraphType<CompleteLessonInputType>>("input", "Lesson completion details.")
            .AuthorizeWithPolicy("Authenticated")
            .ResolveAsync(async ctx =>
            {
                var input = ctx.GetArgument<CompleteLessonDto>("input");
                var userId = ResolveUserId(http);
                return (object?)await lessonService.CompleteLessonAsync(userId, input);
            });

        // ── createBook (admin) ─────────────────────────────────────────────
        Field<NonNullGraphType<BookType>>("createBook")
            .Description("Creates a new book in the corpus. Requires admin role.")
            .Argument<NonNullGraphType<CreateBookInputType>>("input", "Book details.")
            .AuthorizeWithPolicy("AdminOnly")
            .ResolveAsync(async ctx =>
            {
                var input = ctx.GetArgument<CreateBookDto>("input");
                ValidateNonEmpty(input.Title, "title");
                ValidateNonEmpty(input.LanguageCode, "languageCode");
                return (object?)await bookService.CreateBookAsync(input);
            });

        // ── updateBook (admin) ─────────────────────────────────────────────
        Field<BookType>("updateBook")
            .Description("Updates an existing book. Requires admin role.")
            .Argument<NonNullGraphType<IntGraphType>>("id", "The book ID.")
            .Argument<NonNullGraphType<UpdateBookInputType>>("input", "Updated book details.")
            .AuthorizeWithPolicy("AdminOnly")
            .ResolveAsync(async ctx =>
            {
                var id = ctx.GetArgument<int>("id");
                var input = ctx.GetArgument<UpdateBookDto>("input");
                return (object?)await bookService.UpdateBookAsync(id, input);
            });

        // ── deleteBook (admin) ─────────────────────────────────────────────
        Field<NonNullGraphType<BooleanGraphType>>("deleteBook")
            .Description("Deletes a book from the corpus. Requires admin role.")
            .Argument<NonNullGraphType<IntGraphType>>("id", "The book ID.")
            .AuthorizeWithPolicy("AdminOnly")
            .ResolveAsync(async ctx =>
            {
                var id = ctx.GetArgument<int>("id");
                return (object?)await bookService.DeleteBookAsync(id);
            });

        // ── createChapter (admin) ──────────────────────────────────────────
        Field<NonNullGraphType<ChapterType>>("createChapter")
            .Description("Creates a new chapter within a book. Requires admin role.")
            .Argument<NonNullGraphType<IntGraphType>>("bookId", "The parent book ID.")
            .Argument<NonNullGraphType<CreateChapterInputType>>("input", "Chapter details.")
            .AuthorizeWithPolicy("AdminOnly")
            .ResolveAsync(async ctx =>
            {
                var bookId = ctx.GetArgument<int>("bookId");
                var input = ctx.GetArgument<CreateChapterDto>("input");
                if (input.ChapterIndex <= 0)
                    throw new ExecutionError("chapterIndex must be greater than 0.") { Code = "BAD_USER_INPUT" };
                return (object?)await chapterService.CreateChapterAsync(bookId, input);
            });

        // ── updateChapter (admin) ──────────────────────────────────────────
        Field<ChapterType>("updateChapter")
            .Description("Updates an existing chapter. Requires admin role.")
            .Argument<NonNullGraphType<IntGraphType>>("id", "The chapter ID.")
            .Argument<NonNullGraphType<UpdateChapterInputType>>("input", "Updated chapter details.")
            .AuthorizeWithPolicy("AdminOnly")
            .ResolveAsync(async ctx =>
            {
                var id = ctx.GetArgument<int>("id");
                var input = ctx.GetArgument<UpdateChapterDto>("input");
                return (object?)await chapterService.UpdateChapterAsync(id, input);
            });

        // ── deleteChapter (admin) ──────────────────────────────────────────
        Field<NonNullGraphType<BooleanGraphType>>("deleteChapter")
            .Description("Deletes a chapter. Requires admin role.")
            .Argument<NonNullGraphType<IntGraphType>>("id", "The chapter ID.")
            .AuthorizeWithPolicy("AdminOnly")
            .ResolveAsync(async ctx =>
            {
                var id = ctx.GetArgument<int>("id");
                return (object?)await chapterService.DeleteChapterAsync(id);
            });

        // ── createVocabulary (admin) ───────────────────────────────────────
        Field<NonNullGraphType<VocabularyResultType>>("createVocabulary")
            .Description("Adds a new vocabulary word to the corpus. Requires admin role.")
            .Argument<NonNullGraphType<CreateVocabularyInputType>>("input", "Vocabulary word details.")
            .AuthorizeWithPolicy("AdminOnly")
            .ResolveAsync(async ctx =>
            {
                var input = ctx.GetArgument<CreateVocabularyDto>("input");
                ValidateNonEmpty(input.Root, "root");
                ValidateNonEmpty(input.Gloss, "gloss");
                return (object?)await vocabularyService.CreateVocabularyAsync(input);
            });

        // ── updateVocabulary (admin) ───────────────────────────────────────
        Field<VocabularyResultType>("updateVocabulary")
            .Description("Updates an existing vocabulary word. Requires admin role.")
            .Argument<NonNullGraphType<IntGraphType>>("id", "The vocabulary ID.")
            .Argument<NonNullGraphType<UpdateVocabularyInputType>>("input", "Updated vocabulary details.")
            .AuthorizeWithPolicy("AdminOnly")
            .ResolveAsync(async ctx =>
            {
                var id = ctx.GetArgument<int>("id");
                var input = ctx.GetArgument<UpdateVocabularyDto>("input");
                return (object?)await vocabularyService.UpdateVocabularyAsync(id, input);
            });

        // ── deleteVocabulary (admin) ───────────────────────────────────────
        Field<NonNullGraphType<BooleanGraphType>>("deleteVocabulary")
            .Description("Deletes a vocabulary word from the corpus. Requires admin role.")
            .Argument<NonNullGraphType<IntGraphType>>("id", "The vocabulary ID.")
            .AuthorizeWithPolicy("AdminOnly")
            .ResolveAsync(async ctx =>
            {
                var id = ctx.GetArgument<int>("id");
                return (object?)await vocabularyService.DeleteVocabularyAsync(id);
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

    /// <summary>
    /// Throws a <see cref="ExecutionError"/> with code <c>BAD_USER_INPUT</c> when
    /// <paramref name="value"/> is null or whitespace.
    /// </summary>
    private static void ValidateNonEmpty(string? value, string fieldName)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ExecutionError($"{fieldName} must not be empty.") { Code = "BAD_USER_INPUT" };
    }
}
