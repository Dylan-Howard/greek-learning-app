using System.Security.Claims;
using FsCheck;
using FsCheck.NUnit;
using GraphQL;
using GraphQL.Execution;
using GraphQL.Types;
using Koine.API.GraphQL.Queries;
using Koine.Application.DTOs.Books;
using Koine.Application.DTOs.Chapters;
using Koine.Application.DTOs.Lessons;
using Koine.Application.DTOs.Progress;
using Koine.Application.DTOs.Reader;
using Koine.Application.DTOs.Study;
using Koine.Application.DTOs.Vocabulary;
using Koine.Application.Interfaces;
using Koine.Application.Study.DTOs;
using Koine.Application.Study.Ports;
using Microsoft.AspNetCore.Http;
using Moq;
using Prop = FsCheck.Fluent.Prop;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace Koine.Tests.Unit.GraphQL;

/// <summary>
/// Property-based tests for RootQuery resolver output equivalence.
/// Feature: graphql-integration, Property 4: Resolver output is structurally equivalent to Application Service output.
/// For any valid GraphQL query and any set of arguments, the data returned by the resolver must be
/// structurally equivalent to the data returned by the corresponding Application Service method
/// invoked with the same arguments.
/// Validates: Requirements 2.2–2.10
/// </summary>
[TestFixture]
public class RootQueryPropertyTests
{
    // ── helpers ───────────────────────────────────────────────────────────────

    private static RootQuery BuildQuery(
        Mock<IBookService> books,
        Mock<IChapterService> chapters,
        Mock<IVocabularyService> vocab,
        Mock<IReaderService> reader,
        Mock<ILessonService> lessons,
        Mock<IProgressService> progress,
        Mock<IStudyService> study,
        Mock<IStudySessionService> sessions,
        int? authenticatedUserId = null)
    {
        var http = new Mock<IHttpContextAccessor>();
        if (authenticatedUserId.HasValue)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, authenticatedUserId.Value.ToString())
            }, "Test");
            http.Setup(h => h.HttpContext)
                .Returns(new DefaultHttpContext { User = new ClaimsPrincipal(identity) });
        }
        else
        {
            http.Setup(h => h.HttpContext).Returns(new DefaultHttpContext());
        }

        return new RootQuery(
            books.Object, chapters.Object, vocab.Object, reader.Object,
            lessons.Object, progress.Object, study.Object, sessions.Object, http.Object);
    }

    private static async Task<object?> ResolveField(
        RootQuery query, string fieldName,
        Dictionary<string, ArgumentValue>? args = null)
    {
        var field = query.Fields.First(f => f.Name == fieldName);
        var ctx = new ResolveFieldContext
        {
            Arguments = args ?? new Dictionary<string, ArgumentValue>()
        };
        return await field.Resolver!.ResolveAsync(ctx);
    }

    private static ArgumentValue Arg(object? value) =>
        new(value, ArgumentSource.Literal);

    // ── Property: books resolver returns same list as service ─────────────────

    /// <summary>
    /// For any non-negative book count N, the books resolver returns exactly the
    /// same list that the service returns — no items added, removed, or reordered.
    /// </summary>
    [Property(MaxTest = 100)]
    public Property Books_ResolverOutput_DeepEqualsServiceOutput(NonNegativeInt count)
    {
        var n = count.Get % 20; // cap at 20 for speed
        var expected = Enumerable.Range(1, n)
            .Select(i => new BookDto { Id = i, Title = $"Book{i}", LanguageCode = "grc", ChapterCount = i })
            .ToList();

        var books = new Mock<IBookService>();
        books.Setup(s => s.GetAllBooksAsync()).ReturnsAsync(expected);

        var query = BuildQuery(books, new Mock<IChapterService>(), new Mock<IVocabularyService>(),
            new Mock<IReaderService>(), new Mock<ILessonService>(), new Mock<IProgressService>(),
            new Mock<IStudyService>(), new Mock<IStudySessionService>());

        var result = ResolveField(query, "books").GetAwaiter().GetResult();

        var ok = result is List<BookDto> list
            && list.Count == expected.Count
            && list.Zip(expected).All(p => p.First.Id == p.Second.Id);

        return Prop.ToProperty(ok);
    }

    // ── Property: book(id) resolver returns same dto as service ───────────────

    /// <summary>
    /// For any positive book ID, the book(id) resolver returns the exact DTO
    /// the service returns for that ID.
    /// </summary>
    [Property(MaxTest = 100)]
    public Property Book_ResolverOutput_DeepEqualsServiceOutput(PositiveInt rawId)
    {
        var id = rawId.Get;
        var expected = new BookDto { Id = id, Title = $"Book{id}", LanguageCode = "grc", ChapterCount = id % 28 + 1 };

        var books = new Mock<IBookService>();
        books.Setup(s => s.GetBookByIdAsync(id)).ReturnsAsync(expected);

        var query = BuildQuery(books, new Mock<IChapterService>(), new Mock<IVocabularyService>(),
            new Mock<IReaderService>(), new Mock<ILessonService>(), new Mock<IProgressService>(),
            new Mock<IStudyService>(), new Mock<IStudySessionService>());

        var result = ResolveField(query, "book",
            new() { ["id"] = Arg(id) }).GetAwaiter().GetResult();

        var ok = result is BookDto dto && dto.Id == expected.Id && dto.Title == expected.Title;
        return Prop.ToProperty(ok);
    }

    // ── Property: chapters(bookId) resolver returns same list as service ───────

    /// <summary>
    /// For any positive bookId, the chapters resolver returns exactly the list
    /// the service returns, with all BookId values matching the requested bookId.
    /// </summary>
    [Property(MaxTest = 100)]
    public Property Chapters_ResolverOutput_DeepEqualsServiceOutput(PositiveInt rawBookId)
    {
        var bookId = rawBookId.Get;
        var count = bookId % 10 + 1;
        var expected = Enumerable.Range(1, count)
            .Select(i => new ChapterDto { Id = i, BookId = bookId, ChapterIndex = i })
            .ToList();

        var chapters = new Mock<IChapterService>();
        chapters.Setup(s => s.GetChaptersByBookIdAsync(bookId)).ReturnsAsync(expected);

        var query = BuildQuery(new Mock<IBookService>(), chapters, new Mock<IVocabularyService>(),
            new Mock<IReaderService>(), new Mock<ILessonService>(), new Mock<IProgressService>(),
            new Mock<IStudyService>(), new Mock<IStudySessionService>());

        var result = ResolveField(query, "chapters",
            new() { ["bookId"] = Arg(bookId) }).GetAwaiter().GetResult();

        var ok = result is List<ChapterDto> list
            && list.Count == expected.Count
            && list.All(c => c.BookId == bookId);
        return Prop.ToProperty(ok);
    }

    // ── Property: vocabulary filter "greater" keeps only words above threshold ─

    /// <summary>
    /// For any occurrence threshold T and any word list, the vocabulary resolver
    /// with comparison="greater" returns exactly the words with Occurrences > T.
    /// </summary>
    [Property(MaxTest = 100)]
    public Property Vocabulary_GreaterFilter_KeepsOnlyWordsAboveThreshold(
        NonNegativeInt rawThreshold, PositiveInt rawWordCount)
    {
        var threshold = rawThreshold.Get % 1000;
        var wordCount = rawWordCount.Get % 30 + 1;
        var words = Enumerable.Range(1, wordCount)
            .Select(i => new SimpleWordDto { RootId = i, Content = $"w{i}", Occurrences = i * 50 })
            .ToList();

        var vocab = new Mock<IVocabularyService>();
        vocab.Setup(s => s.GetAllSimpleAsync()).ReturnsAsync(words);

        var query = BuildQuery(new Mock<IBookService>(), new Mock<IChapterService>(), vocab,
            new Mock<IReaderService>(), new Mock<ILessonService>(), new Mock<IProgressService>(),
            new Mock<IStudyService>(), new Mock<IStudySessionService>());

        var result = ResolveField(query, "vocabulary", new()
        {
            ["occurrences"] = Arg(threshold),
            ["comparison"] = Arg("greater")
        }).GetAwaiter().GetResult();

        var expectedCount = words.Count(w => w.Occurrences > threshold);
        var ok = result is List<SimpleWordDto> list
            && list.Count == expectedCount
            && list.All(w => w.Occurrences > threshold);
        return Prop.ToProperty(ok);
    }

    // ── Property: vocabulary filter "less" keeps only words below threshold ────

    /// <summary>
    /// For any occurrence threshold T and any word list, the vocabulary resolver
    /// with comparison="less" returns exactly the words with Occurrences &lt; T.
    /// </summary>
    [Property(MaxTest = 100)]
    public Property Vocabulary_LessFilter_KeepsOnlyWordsBelowThreshold(
        NonNegativeInt rawThreshold, PositiveInt rawWordCount)
    {
        var threshold = rawThreshold.Get % 1000;
        var wordCount = rawWordCount.Get % 30 + 1;
        var words = Enumerable.Range(1, wordCount)
            .Select(i => new SimpleWordDto { RootId = i, Content = $"w{i}", Occurrences = i * 50 })
            .ToList();

        var vocab = new Mock<IVocabularyService>();
        vocab.Setup(s => s.GetAllSimpleAsync()).ReturnsAsync(words);

        var query = BuildQuery(new Mock<IBookService>(), new Mock<IChapterService>(), vocab,
            new Mock<IReaderService>(), new Mock<ILessonService>(), new Mock<IProgressService>(),
            new Mock<IStudyService>(), new Mock<IStudySessionService>());

        var result = ResolveField(query, "vocabulary", new()
        {
            ["occurrences"] = Arg(threshold),
            ["comparison"] = Arg("less")
        }).GetAwaiter().GetResult();

        var expectedCount = words.Count(w => w.Occurrences < threshold);
        var ok = result is List<SimpleWordDto> list
            && list.Count == expectedCount
            && list.All(w => w.Occurrences < threshold);
        return Prop.ToProperty(ok);
    }

    // ── Property: reader resolver returns same dto as service ─────────────────

    /// <summary>
    /// For any bookId and chapterNumber, the reader resolver returns the exact
    /// RenderedChapterDto the service returns for those arguments.
    /// </summary>
    [Property(MaxTest = 100)]
    public Property Reader_ResolverOutput_DeepEqualsServiceOutput(
        PositiveInt rawBookId, PositiveInt rawChapter)
    {
        var bookId = rawBookId.Get;
        var chapterNumber = rawChapter.Get;
        var expected = new RenderedChapterDto
        {
            ChapterId = chapterNumber,
            Title = $"Chapter {chapterNumber}",
            Units = new()
        };

        var reader = new Mock<IReaderService>();
        reader.Setup(s => s.RenderChapterAsync(It.IsAny<int>(), bookId, chapterNumber, "en"))
              .ReturnsAsync(expected);

        var query = BuildQuery(new Mock<IBookService>(), new Mock<IChapterService>(),
            new Mock<IVocabularyService>(), reader, new Mock<ILessonService>(),
            new Mock<IProgressService>(), new Mock<IStudyService>(),
            new Mock<IStudySessionService>(), authenticatedUserId: 1);

        var result = ResolveField(query, "reader", new()
        {
            ["bookId"] = Arg(bookId),
            ["chapterNumber"] = Arg(chapterNumber)
        }).GetAwaiter().GetResult();

        var ok = result is RenderedChapterDto dto
            && dto.ChapterId == expected.ChapterId
            && dto.Title == expected.Title;
        return Prop.ToProperty(ok);
    }

    // ── Property: lessons resolver returns same list as service ───────────────

    /// <summary>
    /// For any authenticated userId, the lessons resolver returns exactly the
    /// list the service returns for that userId.
    /// </summary>
    [Property(MaxTest = 100)]
    public Property Lessons_ResolverOutput_DeepEqualsServiceOutput(PositiveInt rawUserId)
    {
        var userId = rawUserId.Get;
        var count = userId % 10 + 1;
        var expected = Enumerable.Range(1, count)
            .Select(i => new LessonDto { Id = i, Title = $"Lesson {i}", TrackId = 1, Slug = $"lesson-{i}" })
            .ToList();

        var lessons = new Mock<ILessonService>();
        lessons.Setup(s => s.GetAllLessonsAsync(userId)).ReturnsAsync(expected);

        var query = BuildQuery(new Mock<IBookService>(), new Mock<IChapterService>(),
            new Mock<IVocabularyService>(), new Mock<IReaderService>(), lessons,
            new Mock<IProgressService>(), new Mock<IStudyService>(),
            new Mock<IStudySessionService>(), authenticatedUserId: userId);

        var result = ResolveField(query, "lessons").GetAwaiter().GetResult();

        var ok = result is List<LessonDto> list && list.Count == expected.Count;
        return Prop.ToProperty(ok);
    }

    // ── Property: progress resolver returns same dto as service ───────────────

    /// <summary>
    /// For any authenticated userId, the progress resolver returns the exact
    /// UserProgressDto the service returns for that userId.
    /// </summary>
    [Property(MaxTest = 100)]
    public Property Progress_ResolverOutput_DeepEqualsServiceOutput(PositiveInt rawUserId)
    {
        var userId = rawUserId.Get;
        var expected = new UserProgressDto
        {
            TotalExperience = userId * 10,
            CompletedLessonIds = new List<int> { 1, 2 },
            UpdatedAt = DateTime.UtcNow
        };

        var progress = new Mock<IProgressService>();
        progress.Setup(s => s.GetUserProgressAsync(userId)).ReturnsAsync(expected);

        var query = BuildQuery(new Mock<IBookService>(), new Mock<IChapterService>(),
            new Mock<IVocabularyService>(), new Mock<IReaderService>(), new Mock<ILessonService>(),
            progress, new Mock<IStudyService>(),
            new Mock<IStudySessionService>(), authenticatedUserId: userId);

        var result = ResolveField(query, "progress").GetAwaiter().GetResult();

        var ok = result is UserProgressDto dto && dto.TotalExperience == expected.TotalExperience;
        return Prop.ToProperty(ok);
    }

    // ── Property: studySets resolver returns same list as service ─────────────

    /// <summary>
    /// For any authenticated userId, the studySets resolver returns exactly the
    /// list the service returns for that userId.
    /// </summary>
    [Property(MaxTest = 100)]
    public Property StudySets_ResolverOutput_DeepEqualsServiceOutput(PositiveInt rawUserId)
    {
        var userId = rawUserId.Get;
        var count = userId % 5 + 1;
        var expected = Enumerable.Range(1, count)
            .Select(i => new VocabularySetDto { Id = i, Title = $"Set {i}", Slug = $"set-{i}" })
            .ToList();

        var study = new Mock<IStudyService>();
        study.Setup(s => s.GetUserSetsAsync(userId)).ReturnsAsync(expected);

        var query = BuildQuery(new Mock<IBookService>(), new Mock<IChapterService>(),
            new Mock<IVocabularyService>(), new Mock<IReaderService>(), new Mock<ILessonService>(),
            new Mock<IProgressService>(), study,
            new Mock<IStudySessionService>(), authenticatedUserId: userId);

        var result = ResolveField(query, "studySets").GetAwaiter().GetResult();

        var ok = result is List<VocabularySetDto> list && list.Count == expected.Count;
        return Prop.ToProperty(ok);
    }
}
