using System.Security.Claims;
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

namespace Koine.Tests.Unit.GraphQL;

/// <summary>
/// Unit tests for RootQuery resolver delegation and error handling.
/// Verifies each field delegates to the correct Application Service method
/// and that NOT_FOUND is returned for missing non-nullable resources.
/// Requirements: 2.1–2.11
/// </summary>
[TestFixture]
public class RootQueryTests
{
    // ── test infrastructure ───────────────────────────────────────────────────

    private Mock<IBookService> _books = null!;
    private Mock<IChapterService> _chapters = null!;
    private Mock<IVocabularyService> _vocab = null!;
    private Mock<IReaderService> _reader = null!;
    private Mock<ILessonService> _lessons = null!;
    private Mock<IProgressService> _progress = null!;
    private Mock<IStudyService> _study = null!;
    private Mock<IStudySessionService> _sessions = null!;
    private Mock<IHttpContextAccessor> _http = null!;
    private RootQuery _query = null!;

    [SetUp]
    public void SetUp()
    {
        _books = new Mock<IBookService>();
        _chapters = new Mock<IChapterService>();
        _vocab = new Mock<IVocabularyService>();
        _reader = new Mock<IReaderService>();
        _lessons = new Mock<ILessonService>();
        _progress = new Mock<IProgressService>();
        _study = new Mock<IStudyService>();
        _sessions = new Mock<IStudySessionService>();
        _http = new Mock<IHttpContextAccessor>();

        // Default: authenticated as user 42
        SetAuthenticatedUser(42);

        _query = new RootQuery(
            _books.Object, _chapters.Object, _vocab.Object, _reader.Object,
            _lessons.Object, _progress.Object, _study.Object, _sessions.Object, _http.Object);
    }

    private void SetAuthenticatedUser(int userId)
    {
        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.NameIdentifier, userId.ToString())
        }, "Test");
        var principal = new ClaimsPrincipal(identity);
        var ctx = new DefaultHttpContext { User = principal };
        _http.Setup(h => h.HttpContext).Returns(ctx);
    }

    private void SetUnauthenticated()
    {
        _http.Setup(h => h.HttpContext).Returns(new DefaultHttpContext());
    }

    /// <summary>Resolves a named field on the query and returns the raw result.</summary>
    private async Task<object?> Resolve(string fieldName, Dictionary<string, object?>? args = null)
    {
        var field = _query.Fields.First(f => f.Name == fieldName);
        var ctx = new ResolveFieldContext
        {
            Arguments = args?.ToDictionary(
                kv => kv.Key,
                kv => new ArgumentValue(kv.Value, ArgumentSource.Literal))
            ?? new Dictionary<string, ArgumentValue>()
        };
        return await field.Resolver!.ResolveAsync(ctx);
    }

    // ── Requirement 2.1: Query type has all expected root fields ──────────────

    [Test]
    public void RootQuery_HasAllExpectedFields()
    {
        var names = _query.Fields.Select(f => f.Name).ToHashSet();
        Assert.Multiple(() =>
        {
            Assert.That(names, Does.Contain("books"));
            Assert.That(names, Does.Contain("book"));
            Assert.That(names, Does.Contain("chapters"));
            Assert.That(names, Does.Contain("vocabulary"));
            Assert.That(names, Does.Contain("reader"));
            Assert.That(names, Does.Contain("lessons"));
            Assert.That(names, Does.Contain("progress"));
            Assert.That(names, Does.Contain("studySets"));
            Assert.That(names, Does.Contain("studyDashboard"));
        });
    }

    [Test]
    public void RootQuery_Name_IsQuery()
    {
        Assert.That(_query.Name, Is.EqualTo("Query"));
    }

    // ── Requirement 2.2: books delegates to IBookService.GetAllBooksAsync ─────

    [Test]
    public async Task Books_DelegatesToBookService_GetAllBooksAsync()
    {
        var expected = new List<BookDto>
        {
            new() { Id = 1, Title = "John", LanguageCode = "grc", ChapterCount = 21 },
            new() { Id = 2, Title = "Mark", LanguageCode = "grc", ChapterCount = 16 },
        };
        _books.Setup(s => s.GetAllBooksAsync()).ReturnsAsync(expected);

        var result = await Resolve("books");

        Assert.That(result, Is.EqualTo(expected));
        _books.Verify(s => s.GetAllBooksAsync(), Times.Once);
    }

    // ── Requirement 2.3: book(id) delegates to IBookService.GetBookByIdAsync ──

    [Test]
    public async Task Book_DelegatesToBookService_GetBookByIdAsync()
    {
        var expected = new BookDto { Id = 5, Title = "Romans", LanguageCode = "grc", ChapterCount = 16 };
        _books.Setup(s => s.GetBookByIdAsync(5)).ReturnsAsync(expected);

        var result = await Resolve("book", new() { ["id"] = 5 });

        Assert.That(result, Is.EqualTo(expected));
        _books.Verify(s => s.GetBookByIdAsync(5), Times.Once);
    }

    [Test]
    public async Task Book_ReturnsNull_WhenBookNotFound()
    {
        _books.Setup(s => s.GetBookByIdAsync(999)).ReturnsAsync((BookDto?)null);

        var result = await Resolve("book", new() { ["id"] = 999 });

        Assert.That(result, Is.Null);
    }

    // ── Requirement 2.4: chapters(bookId) delegates to IChapterService ────────

    [Test]
    public async Task Chapters_DelegatesToChapterService_GetChaptersByBookIdAsync()
    {
        var expected = new List<ChapterDto>
        {
            new() { Id = 10, BookId = 3, ChapterIndex = 1 },
            new() { Id = 11, BookId = 3, ChapterIndex = 2 },
        };
        _chapters.Setup(s => s.GetChaptersByBookIdAsync(3)).ReturnsAsync(expected);

        var result = await Resolve("chapters", new() { ["bookId"] = 3 });

        Assert.That(result, Is.EqualTo(expected));
        _chapters.Verify(s => s.GetChaptersByBookIdAsync(3), Times.Once);
    }

    // ── Requirement 2.5: vocabulary delegates to IVocabularyService ───────────

    [Test]
    public async Task Vocabulary_DelegatesToVocabularyService_GetAllSimpleAsync()
    {
        var expected = new List<SimpleWordDto>
        {
            new() { RootId = 1, Content = "λόγος", Occurrences = 330 },
            new() { RootId = 2, Content = "θεός", Occurrences = 1317 },
        };
        _vocab.Setup(s => s.GetAllSimpleAsync()).ReturnsAsync(expected);

        var result = await Resolve("vocabulary");

        Assert.That(result, Is.EqualTo(expected));
        _vocab.Verify(s => s.GetAllSimpleAsync(), Times.Once);
    }

    [Test]
    public async Task Vocabulary_WithGreaterFilter_ReturnsOnlyWordsAboveThreshold()
    {
        var words = new List<SimpleWordDto>
        {
            new() { RootId = 1, Content = "α", Occurrences = 100 },
            new() { RootId = 2, Content = "β", Occurrences = 500 },
            new() { RootId = 3, Content = "γ", Occurrences = 1000 },
        };
        _vocab.Setup(s => s.GetAllSimpleAsync()).ReturnsAsync(words);

        var result = await Resolve("vocabulary", new() { ["occurrences"] = 200, ["comparison"] = "greater" });

        var list = result as List<SimpleWordDto>;
        Assert.That(list, Is.Not.Null);
        Assert.That(list!.Count, Is.EqualTo(2));
        Assert.That(list.All(w => w.Occurrences > 200), Is.True);
    }

    [Test]
    public async Task Vocabulary_WithLessFilter_ReturnsOnlyWordsBelowThreshold()
    {
        var words = new List<SimpleWordDto>
        {
            new() { RootId = 1, Content = "α", Occurrences = 100 },
            new() { RootId = 2, Content = "β", Occurrences = 500 },
            new() { RootId = 3, Content = "γ", Occurrences = 1000 },
        };
        _vocab.Setup(s => s.GetAllSimpleAsync()).ReturnsAsync(words);

        var result = await Resolve("vocabulary", new() { ["occurrences"] = 600, ["comparison"] = "less" });

        var list = result as List<SimpleWordDto>;
        Assert.That(list, Is.Not.Null);
        Assert.That(list!.Count, Is.EqualTo(2));
        Assert.That(list.All(w => w.Occurrences < 600), Is.True);
    }

    [Test]
    public async Task Vocabulary_WithNoFilter_ReturnsAllWords()
    {
        var words = new List<SimpleWordDto>
        {
            new() { RootId = 1, Content = "α", Occurrences = 100 },
            new() { RootId = 2, Content = "β", Occurrences = 500 },
        };
        _vocab.Setup(s => s.GetAllSimpleAsync()).ReturnsAsync(words);

        var result = await Resolve("vocabulary");

        var list = result as List<SimpleWordDto>;
        Assert.That(list, Has.Count.EqualTo(2));
    }

    // ── Requirement 2.6: reader delegates to IReaderService.RenderChapterAsync ─

    [Test]
    public async Task Reader_DelegatesToReaderService_RenderChapterAsync()
    {
        var expected = new RenderedChapterDto { ChapterId = 3, Title = "John 3", Units = new() };
        _reader.Setup(s => s.RenderChapterAsync(42, 1, 3, "en")).ReturnsAsync(expected);

        var result = await Resolve("reader", new() { ["bookId"] = 1, ["chapterNumber"] = 3 });

        Assert.That(result, Is.EqualTo(expected));
        _reader.Verify(s => s.RenderChapterAsync(42, 1, 3, "en"), Times.Once);
    }

    [Test]
    public async Task Reader_PassesLangArgument_WhenProvided()
    {
        var expected = new RenderedChapterDto { ChapterId = 1, Title = "Ch 1", Units = new() };
        _reader.Setup(s => s.RenderChapterAsync(42, 2, 1, "es")).ReturnsAsync(expected);

        var result = await Resolve("reader", new() { ["bookId"] = 2, ["chapterNumber"] = 1, ["lang"] = "es" });

        _reader.Verify(s => s.RenderChapterAsync(42, 2, 1, "es"), Times.Once);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public async Task Reader_DefaultsLangToEn_WhenLangArgIsNull()
    {
        var expected = new RenderedChapterDto { ChapterId = 2, Title = "Ch 2", Units = new() };
        _reader.Setup(s => s.RenderChapterAsync(42, 1, 2, "en")).ReturnsAsync(expected);

        // No lang arg
        var result = await Resolve("reader", new() { ["bookId"] = 1, ["chapterNumber"] = 2 });

        _reader.Verify(s => s.RenderChapterAsync(42, 1, 2, "en"), Times.Once);
    }

    [Test]
    public async Task Reader_UsesZeroUserId_WhenUnauthenticated()
    {
        SetUnauthenticated();
        // Rebuild query with unauthenticated context
        var query = new RootQuery(
            _books.Object, _chapters.Object, _vocab.Object, _reader.Object,
            _lessons.Object, _progress.Object, _study.Object, _sessions.Object, _http.Object);

        var expected = new RenderedChapterDto { ChapterId = 1, Title = "Ch 1", Units = new() };
        _reader.Setup(s => s.RenderChapterAsync(0, 1, 1, "en")).ReturnsAsync(expected);

        var field = query.Fields.First(f => f.Name == "reader");
        var ctx = new ResolveFieldContext
        {
            Arguments = new Dictionary<string, ArgumentValue>
            {
                ["bookId"] = new ArgumentValue(1, ArgumentSource.Literal),
                ["chapterNumber"] = new ArgumentValue(1, ArgumentSource.Literal)
            }
        };
        await field.Resolver!.ResolveAsync(ctx);

        _reader.Verify(s => s.RenderChapterAsync(0, 1, 1, "en"), Times.Once);
    }

    // ── Requirement 2.7: lessons delegates to ILessonService.GetAllLessonsAsync ─

    [Test]
    public async Task Lessons_DelegatesToLessonService_GetAllLessonsAsync()
    {
        var expected = new List<LessonDto>
        {
            new() { Id = 1, Title = "Intro to Greek", TrackId = 1, Slug = "intro" },
            new() { Id = 2, Title = "Nouns", TrackId = 1, Slug = "nouns" },
        };
        _lessons.Setup(s => s.GetAllLessonsAsync(42)).ReturnsAsync(expected);

        var result = await Resolve("lessons");

        Assert.That(result, Is.EqualTo(expected));
        _lessons.Verify(s => s.GetAllLessonsAsync(42), Times.Once);
    }

    // ── Requirement 2.8: progress delegates to IProgressService ──────────────

    [Test]
    public async Task Progress_DelegatesToProgressService_GetUserProgressAsync()
    {
        var expected = new UserProgressDto
        {
            TotalExperience = 420,
            CompletedLessonIds = new List<int> { 1, 2, 3 },
            UpdatedAt = DateTime.UtcNow
        };
        _progress.Setup(s => s.GetUserProgressAsync(42)).ReturnsAsync(expected);

        var result = await Resolve("progress");

        Assert.That(result, Is.EqualTo(expected));
        _progress.Verify(s => s.GetUserProgressAsync(42), Times.Once);
    }

    [Test]
    public async Task Progress_ReturnsNull_WhenProgressNotFound()
    {
        _progress.Setup(s => s.GetUserProgressAsync(42)).ReturnsAsync((UserProgressDto?)null);

        var result = await Resolve("progress");

        Assert.That(result, Is.Null);
    }

    // ── Requirement 2.9: studySets delegates to IStudyService ────────────────

    [Test]
    public async Task StudySets_DelegatesToStudyService_GetUserSetsAsync()
    {
        var expected = new List<VocabularySetDto>
        {
            new() { Id = 1, Title = "Core 100", Slug = "core-100" },
            new() { Id = 2, Title = "NT Verbs", Slug = "nt-verbs" },
        };
        _study.Setup(s => s.GetUserSetsAsync(42)).ReturnsAsync(expected);

        var result = await Resolve("studySets");

        Assert.That(result, Is.EqualTo(expected));
        _study.Verify(s => s.GetUserSetsAsync(42), Times.Once);
    }

    // ── Requirement 2.10: studyDashboard delegates to StudySessionService ─────

    [Test]
    public async Task StudyDashboard_DelegatesToStudySessionService_GetDashboardAsync()
    {
        var expected = new DashboardDto
        {
            TotalCards = 200,
            DueToday = 15,
            NewCards = 5,
            CurrentStreak = 7,
            ReviewHistory = new()
        };
        _sessions.Setup(s => s.GetDashboardAsync(It.IsAny<CancellationToken>()))
                 .ReturnsAsync(expected);

        var result = await Resolve("studyDashboard");

        Assert.That(result, Is.EqualTo(expected));
        _sessions.Verify(s => s.GetDashboardAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    // ── Requirement 2.11: NOT_FOUND error for missing non-nullable resources ──

    [Test]
    public void StudyDashboard_ThrowsExecutionError_WithNotFoundCode_WhenResultIsNull()
    {
        _sessions.Setup(s => s.GetDashboardAsync(It.IsAny<CancellationToken>()))
                 .ReturnsAsync((DashboardDto?)null!);

        var ex = Assert.ThrowsAsync<ExecutionError>(
            async () => await Resolve("studyDashboard"));

        Assert.That(ex!.Code, Is.EqualTo("NOT_FOUND"));
    }

    // ── Requirement 6.3: CurrentUser claim uses ClaimTypes.NameIdentifier ─────

    [Test]
    public async Task Lessons_ExtractsUserIdFromNameIdentifierClaim()
    {
        SetAuthenticatedUser(99);
        var query = new RootQuery(
            _books.Object, _chapters.Object, _vocab.Object, _reader.Object,
            _lessons.Object, _progress.Object, _study.Object, _sessions.Object, _http.Object);

        _lessons.Setup(s => s.GetAllLessonsAsync(99)).ReturnsAsync(new List<LessonDto>());

        var field = query.Fields.First(f => f.Name == "lessons");
        var ctx = new ResolveFieldContext { Arguments = new Dictionary<string, ArgumentValue>() };
        await field.Resolver!.ResolveAsync(ctx);

        _lessons.Verify(s => s.GetAllLessonsAsync(99), Times.Once);
        _lessons.Verify(s => s.GetAllLessonsAsync(It.Is<int>(id => id != 99)), Times.Never);
    }

    [Test]
    public async Task Progress_ExtractsUserIdFromNameIdentifierClaim()
    {
        SetAuthenticatedUser(77);
        var query = new RootQuery(
            _books.Object, _chapters.Object, _vocab.Object, _reader.Object,
            _lessons.Object, _progress.Object, _study.Object, _sessions.Object, _http.Object);

        _progress.Setup(s => s.GetUserProgressAsync(77)).ReturnsAsync(new UserProgressDto());

        var field = query.Fields.First(f => f.Name == "progress");
        var ctx = new ResolveFieldContext { Arguments = new Dictionary<string, ArgumentValue>() };
        await field.Resolver!.ResolveAsync(ctx);

        _progress.Verify(s => s.GetUserProgressAsync(77), Times.Once);
    }

    // ── Requirement 6.5: authenticated fields have AuthorizeWithPolicy set ────

    [Test]
    public void AuthenticatedFields_HaveAuthorizeWithPolicyMetadata()
    {
        var authenticatedFields = new[] { "lessons", "progress", "studySets", "studyDashboard" };

        Assert.Multiple(() =>
        {
            foreach (var name in authenticatedFields)
            {
                var field = _query.Fields.FirstOrDefault(f => f.Name == name);
                Assert.That(field, Is.Not.Null, $"Field '{name}' should exist");

                // GetPolicies() reads the "Authorization" metadata key set by .AuthorizeWithPolicy(...)
                var policies = field!.GetPolicies();
                Assert.That(policies?.Any(), Is.True,
                    $"Field '{name}' should have authorization metadata");
            }
        });
    }

    [Test]
    public void PublicFields_DoNotHaveAuthorizeMetadata()
    {
        var publicFields = new[] { "books", "book", "chapters", "vocabulary", "reader" };

        Assert.Multiple(() =>
        {
            foreach (var name in publicFields)
            {
                var field = _query.Fields.FirstOrDefault(f => f.Name == name);
                Assert.That(field, Is.Not.Null, $"Field '{name}' should exist");

                var policies = field!.GetPolicies();
                Assert.That(policies?.Any() ?? false, Is.False,
                    $"Public field '{name}' should not have authorization metadata");
            }
        });
    }
}
