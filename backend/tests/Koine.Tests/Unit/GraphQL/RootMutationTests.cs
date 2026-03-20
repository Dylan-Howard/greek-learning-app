using System.Security.Claims;
using GraphQL;
using GraphQL.Execution;
using GraphQL.Types;
using Koine.API.GraphQL.Mutations;
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
using Koine.Domain.ValueObjects;
using Microsoft.AspNetCore.Http;
using Moq;

namespace Koine.Tests.Unit.GraphQL;

/// <summary>
/// Unit tests for RootMutation resolver delegation, authorization metadata, and input validation.
/// Requirements: 3.1–3.19
/// </summary>
[TestFixture]
public class RootMutationTests
{
    // ── test infrastructure ───────────────────────────────────────────────────

    private Mock<IStudySessionService> _sessions = null!;
    private Mock<IStudyService> _study = null!;
    private Mock<IProgressService> _progress = null!;
    private Mock<ILessonService> _lessons = null!;
    private Mock<IBookService> _books = null!;
    private Mock<IChapterService> _chapters = null!;
    private Mock<IVocabularyService> _vocab = null!;
    private Mock<IHttpContextAccessor> _http = null!;
    private RootMutation _mutation = null!;

    [SetUp]
    public void SetUp()
    {
        _sessions = new Mock<IStudySessionService>();
        _study = new Mock<IStudyService>();
        _progress = new Mock<IProgressService>();
        _lessons = new Mock<ILessonService>();
        _books = new Mock<IBookService>();
        _chapters = new Mock<IChapterService>();
        _vocab = new Mock<IVocabularyService>();
        _http = new Mock<IHttpContextAccessor>();

        SetAuthenticatedUser(42);

        _mutation = new RootMutation(
            _sessions.Object, _study.Object, _progress.Object, _lessons.Object,
            _books.Object, _chapters.Object, _vocab.Object, _http.Object);
    }

    private void SetAuthenticatedUser(int userId)
    {
        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.NameIdentifier, userId.ToString())
        }, "Test");
        _http.Setup(h => h.HttpContext)
            .Returns(new DefaultHttpContext { User = new ClaimsPrincipal(identity) });
    }

    /// <summary>Resolves a named field on the mutation and returns the raw result.</summary>
    private async Task<object?> Resolve(string fieldName, Dictionary<string, object?>? args = null)
    {
        var field = _mutation.Fields.First(f => f.Name == fieldName);
        var ctx = new ResolveFieldContext
        {
            Arguments = args?.ToDictionary(
                kv => kv.Key,
                kv => new ArgumentValue(kv.Value, ArgumentSource.Literal))
            ?? new Dictionary<string, ArgumentValue>()
        };
        return await field.Resolver!.ResolveAsync(ctx);
    }

    // ── field existence ───────────────────────────────────────────────────────

    [Test]
    public void RootMutation_HasAllExpectedUserMutationFields()
    {
        var names = _mutation.Fields.Select(f => f.Name).ToHashSet();
        Assert.Multiple(() =>
        {
            Assert.That(names, Does.Contain("startStudySession"));
            Assert.That(names, Does.Contain("rateCard"));
            Assert.That(names, Does.Contain("completeStudySession"));
            Assert.That(names, Does.Contain("createVocabularySet"));
            Assert.That(names, Does.Contain("deleteVocabularySet"));
            Assert.That(names, Does.Contain("updateProgress"));
            Assert.That(names, Does.Contain("completeLesson"));
        });
    }

    [Test]
    public void RootMutation_HasAllExpectedAdminMutationFields()
    {
        var names = _mutation.Fields.Select(f => f.Name).ToHashSet();
        Assert.Multiple(() =>
        {
            Assert.That(names, Does.Contain("createBook"));
            Assert.That(names, Does.Contain("updateBook"));
            Assert.That(names, Does.Contain("deleteBook"));
            Assert.That(names, Does.Contain("createChapter"));
            Assert.That(names, Does.Contain("updateChapter"));
            Assert.That(names, Does.Contain("deleteChapter"));
            Assert.That(names, Does.Contain("createVocabulary"));
            Assert.That(names, Does.Contain("updateVocabulary"));
            Assert.That(names, Does.Contain("deleteVocabulary"));
        });
    }

    [Test]
    public void RootMutation_Name_IsMutation()
    {
        Assert.That(_mutation.Name, Is.EqualTo("Mutation"));
    }

    // ── user mutation delegation ──────────────────────────────────────────────

    [Test]
    public async Task StartStudySession_DelegatesToStudySessionService()
    {
        var expected = new SessionDto
        {
            Id = Guid.NewGuid(),
            TotalCards = 10,
            CardsReviewed = 0,
            StartedAt = DateTime.UtcNow,
            Pool = CardPool.Mixed,
            Direction = StudyDirection.GreekToEnglish,
            Mode = InteractionMode.Flip
        };
        _sessions.Setup(s => s.StartSessionAsync(It.IsAny<StartSessionRequest>(), It.IsAny<CancellationToken>()))
                 .ReturnsAsync(expected);

        var input = new StartSessionRequest
        {
            CardCount = 10,
            Pool = CardPool.Mixed,
            Direction = StudyDirection.GreekToEnglish,
            Mode = InteractionMode.Flip,
            Source = SessionSource.StandardStudy
        };

        var result = await Resolve("startStudySession", new() { ["input"] = input });

        Assert.That(result, Is.EqualTo(expected));
        _sessions.Verify(s => s.StartSessionAsync(It.IsAny<StartSessionRequest>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Test]
    public async Task RateCard_DelegatesToStudySessionService()
    {
        var sessionId = Guid.NewGuid();
        var expected = new RateCardResponse
        {
            NextReviewDate = DateTime.UtcNow.AddDays(1),
            ScheduledDays = 1,
            NewState = CardState.Learning,
            SessionComplete = false
        };
        _sessions.Setup(s => s.RateCardAsync(sessionId, 5, Rating.Good, It.IsAny<CancellationToken>()))
                 .ReturnsAsync(expected);

        var result = await Resolve("rateCard", new()
        {
            ["sessionId"] = sessionId.ToString(),
            ["vocabularyId"] = 5,
            ["rating"] = 3
        });

        Assert.That(result, Is.EqualTo(expected));
        _sessions.Verify(s => s.RateCardAsync(sessionId, 5, Rating.Good, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Test]
    public async Task CompleteStudySession_DelegatesToStudySessionService()
    {
        var sessionId = Guid.NewGuid();
        var expected = new SessionSummaryDto
        {
            TotalReviewed = 10,
            CorrectCount = 8,
            CorrectPercentage = 80.0,
            XpGained = 50,
            TotalExperience = 500,
            FirstCompletionReward = false
        };
        _sessions.Setup(s => s.CompleteSessionAsync(sessionId, It.IsAny<CancellationToken>()))
                 .ReturnsAsync(expected);

        var result = await Resolve("completeStudySession", new()
        {
            ["sessionId"] = sessionId.ToString()
        });

        Assert.That(result, Is.EqualTo(expected));
        _sessions.Verify(s => s.CompleteSessionAsync(sessionId, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Test]
    public async Task CreateVocabularySet_DelegatesToStudyService()
    {
        var expected = new VocabularySetDto { Id = 1, Title = "Core 100", Slug = "core-100" };
        _study.Setup(s => s.CreateSetAsync(42, It.IsAny<CreateVocabularySetDto>()))
              .ReturnsAsync(expected);

        var input = new CreateVocabularySetDto
        {
            Title = "Core 100",
            Description = "Top 100 words",
            VocabularyIds = new List<int> { 1, 2, 3 }
        };

        var result = await Resolve("createVocabularySet", new() { ["input"] = input });

        Assert.That(result, Is.EqualTo(expected));
        _study.Verify(s => s.CreateSetAsync(42, It.IsAny<CreateVocabularySetDto>()), Times.Once);
    }

    [Test]
    public async Task DeleteVocabularySet_DelegatesToStudyService()
    {
        _study.Setup(s => s.DeleteSetAsync(7, 42)).ReturnsAsync(true);

        var result = await Resolve("deleteVocabularySet", new() { ["id"] = 7 });

        Assert.That(result, Is.EqualTo(true));
        _study.Verify(s => s.DeleteSetAsync(7, 42), Times.Once);
    }

    [Test]
    public async Task UpdateProgress_DelegatesToProgressService()
    {
        _progress.Setup(s => s.UpdateProgressAsync(42, It.IsAny<UserProgressDto>()))
                 .ReturnsAsync(true);

        var raw = new Dictionary<string, object>
        {
            ["completedLessonIds"] = new List<object> { 1, 2, 3 },
            ["totalExperience"] = 300
        };

        var result = await Resolve("updateProgress", new() { ["input"] = raw });

        Assert.That(result, Is.EqualTo(true));
        _progress.Verify(s => s.UpdateProgressAsync(42, It.IsAny<UserProgressDto>()), Times.Once);
    }

    [Test]
    public async Task CompleteLesson_DelegatesToLessonService()
    {
        var expected = new LessonCompletionResponseDto
        {
            Message = "Lesson complete!",
            XpGained = 20,
            TotalExperience = 200,
            FirstCompletion = true
        };
        _lessons.Setup(s => s.CompleteLessonAsync(42, It.IsAny<CompleteLessonDto>()))
                .ReturnsAsync(expected);

        var input = new CompleteLessonDto { LessonId = 5, Score = 90 };

        var result = await Resolve("completeLesson", new() { ["input"] = input });

        Assert.That(result, Is.EqualTo(expected));
        _lessons.Verify(s => s.CompleteLessonAsync(42, It.IsAny<CompleteLessonDto>()), Times.Once);
    }

    // ── admin mutation delegation ─────────────────────────────────────────────

    [Test]
    public async Task CreateBook_DelegatesToBookService()
    {
        var expected = new BookDto { Id = 1, Title = "John", LanguageCode = "grc", ChapterCount = 21 };
        _books.Setup(s => s.CreateBookAsync(It.IsAny<CreateBookDto>())).ReturnsAsync(expected);

        var input = new CreateBookDto { Title = "John", LanguageCode = "grc" };

        var result = await Resolve("createBook", new() { ["input"] = input });

        Assert.That(result, Is.EqualTo(expected));
        _books.Verify(s => s.CreateBookAsync(It.IsAny<CreateBookDto>()), Times.Once);
    }

    [Test]
    public async Task UpdateBook_DelegatesToBookService()
    {
        var expected = new BookDto { Id = 1, Title = "John Updated", LanguageCode = "grc", ChapterCount = 21 };
        _books.Setup(s => s.UpdateBookAsync(1, It.IsAny<UpdateBookDto>())).ReturnsAsync(expected);

        var input = new UpdateBookDto { Title = "John Updated", LanguageCode = "grc" };

        var result = await Resolve("updateBook", new() { ["id"] = 1, ["input"] = input });

        Assert.That(result, Is.EqualTo(expected));
        _books.Verify(s => s.UpdateBookAsync(1, It.IsAny<UpdateBookDto>()), Times.Once);
    }

    [Test]
    public async Task DeleteBook_DelegatesToBookService()
    {
        _books.Setup(s => s.DeleteBookAsync(3)).ReturnsAsync(true);

        var result = await Resolve("deleteBook", new() { ["id"] = 3 });

        Assert.That(result, Is.EqualTo(true));
        _books.Verify(s => s.DeleteBookAsync(3), Times.Once);
    }

    [Test]
    public async Task CreateChapter_DelegatesToChapterService()
    {
        var expected = new ChapterDto { Id = 10, BookId = 1, ChapterIndex = 1 };
        _chapters.Setup(s => s.CreateChapterAsync(1, It.IsAny<CreateChapterDto>())).ReturnsAsync(expected);

        var input = new CreateChapterDto { ChapterIndex = 1, Title = "Chapter 1" };

        var result = await Resolve("createChapter", new() { ["bookId"] = 1, ["input"] = input });

        Assert.That(result, Is.EqualTo(expected));
        _chapters.Verify(s => s.CreateChapterAsync(1, It.IsAny<CreateChapterDto>()), Times.Once);
    }

    [Test]
    public async Task UpdateChapter_DelegatesToChapterService()
    {
        var expected = new ChapterDto { Id = 10, BookId = 1, ChapterIndex = 2 };
        _chapters.Setup(s => s.UpdateChapterAsync(10, It.IsAny<UpdateChapterDto>())).ReturnsAsync(expected);

        var input = new UpdateChapterDto { ChapterIndex = 2 };

        var result = await Resolve("updateChapter", new() { ["id"] = 10, ["input"] = input });

        Assert.That(result, Is.EqualTo(expected));
        _chapters.Verify(s => s.UpdateChapterAsync(10, It.IsAny<UpdateChapterDto>()), Times.Once);
    }

    [Test]
    public async Task DeleteChapter_DelegatesToChapterService()
    {
        _chapters.Setup(s => s.DeleteChapterAsync(10)).ReturnsAsync(true);

        var result = await Resolve("deleteChapter", new() { ["id"] = 10 });

        Assert.That(result, Is.EqualTo(true));
        _chapters.Verify(s => s.DeleteChapterAsync(10), Times.Once);
    }

    [Test]
    public async Task CreateVocabulary_DelegatesToVocabularyService()
    {
        var expected = new VocabularyDto { Id = 1, Root = "λόγος", Gloss = "word" };
        _vocab.Setup(s => s.CreateVocabularyAsync(It.IsAny<CreateVocabularyDto>())).ReturnsAsync(expected);

        var input = new CreateVocabularyDto { Root = "λόγος", Gloss = "word" };

        var result = await Resolve("createVocabulary", new() { ["input"] = input });

        Assert.That(result, Is.EqualTo(expected));
        _vocab.Verify(s => s.CreateVocabularyAsync(It.IsAny<CreateVocabularyDto>()), Times.Once);
    }

    [Test]
    public async Task UpdateVocabulary_DelegatesToVocabularyService()
    {
        var expected = new VocabularyDto { Id = 1, Root = "λόγος", Gloss = "word, speech" };
        _vocab.Setup(s => s.UpdateVocabularyAsync(1, It.IsAny<UpdateVocabularyDto>())).ReturnsAsync(expected);

        var input = new UpdateVocabularyDto { Root = "λόγος", Gloss = "word, speech" };

        var result = await Resolve("updateVocabulary", new() { ["id"] = 1, ["input"] = input });

        Assert.That(result, Is.EqualTo(expected));
        _vocab.Verify(s => s.UpdateVocabularyAsync(1, It.IsAny<UpdateVocabularyDto>()), Times.Once);
    }

    [Test]
    public async Task DeleteVocabulary_DelegatesToVocabularyService()
    {
        _vocab.Setup(s => s.DeleteVocabularyAsync(5)).ReturnsAsync(true);

        var result = await Resolve("deleteVocabulary", new() { ["id"] = 5 });

        Assert.That(result, Is.EqualTo(true));
        _vocab.Verify(s => s.DeleteVocabularyAsync(5), Times.Once);
    }

    // ── authorization metadata ────────────────────────────────────────────────

    [Test]
    public void UserMutationFields_HaveAuthenticatedPolicy()
    {
        var userFields = new[]
        {
            "startStudySession", "rateCard", "completeStudySession",
            "createVocabularySet", "deleteVocabularySet", "updateProgress", "completeLesson"
        };

        Assert.Multiple(() =>
        {
            foreach (var name in userFields)
            {
                var field = _mutation.Fields.FirstOrDefault(f => f.Name == name);
                Assert.That(field, Is.Not.Null, $"Field '{name}' should exist");
                var policies = field!.GetPolicies();
                Assert.That(policies?.Contains("Authenticated"), Is.True,
                    $"Field '{name}' should have 'Authenticated' policy");
            }
        });
    }

    [Test]
    public void AdminMutationFields_HaveAdminOnlyPolicy()
    {
        var adminFields = new[]
        {
            "createBook", "updateBook", "deleteBook",
            "createChapter", "updateChapter", "deleteChapter",
            "createVocabulary", "updateVocabulary", "deleteVocabulary"
        };

        Assert.Multiple(() =>
        {
            foreach (var name in adminFields)
            {
                var field = _mutation.Fields.FirstOrDefault(f => f.Name == name);
                Assert.That(field, Is.Not.Null, $"Field '{name}' should exist");
                var policies = field!.GetPolicies();
                Assert.That(policies?.Contains("AdminOnly"), Is.True,
                    $"Field '{name}' should have 'AdminOnly' policy");
            }
        });
    }

    // ── input validation ──────────────────────────────────────────────────────

    [Test]
    public void RateCard_ThrowsBadUserInput_WhenRatingOutOfRange()
    {
        var ex = Assert.ThrowsAsync<ExecutionError>(async () =>
            await Resolve("rateCard", new()
            {
                ["sessionId"] = Guid.NewGuid().ToString(),
                ["vocabularyId"] = 1,
                ["rating"] = 0
            }));

        Assert.That(ex!.Code, Is.EqualTo("BAD_USER_INPUT"));
        _sessions.Verify(s => s.RateCardAsync(
            It.IsAny<Guid>(), It.IsAny<int>(), It.IsAny<Rating>(), It.IsAny<CancellationToken>()),
            Times.Never);
    }

    [Test]
    public void RateCard_ThrowsBadUserInput_WhenRatingIs5()
    {
        var ex = Assert.ThrowsAsync<ExecutionError>(async () =>
            await Resolve("rateCard", new()
            {
                ["sessionId"] = Guid.NewGuid().ToString(),
                ["vocabularyId"] = 1,
                ["rating"] = 5
            }));

        Assert.That(ex!.Code, Is.EqualTo("BAD_USER_INPUT"));
    }

    [Test]
    public void CreateBook_ThrowsBadUserInput_WhenTitleIsEmpty()
    {
        var ex = Assert.ThrowsAsync<ExecutionError>(async () =>
            await Resolve("createBook", new()
            {
                ["input"] = new CreateBookDto { Title = "", LanguageCode = "grc" }
            }));

        Assert.That(ex!.Code, Is.EqualTo("BAD_USER_INPUT"));
        _books.Verify(s => s.CreateBookAsync(It.IsAny<CreateBookDto>()), Times.Never);
    }

    [Test]
    public void CreateBook_ThrowsBadUserInput_WhenTitleIsWhitespace()
    {
        var ex = Assert.ThrowsAsync<ExecutionError>(async () =>
            await Resolve("createBook", new()
            {
                ["input"] = new CreateBookDto { Title = "   ", LanguageCode = "grc" }
            }));

        Assert.That(ex!.Code, Is.EqualTo("BAD_USER_INPUT"));
        _books.Verify(s => s.CreateBookAsync(It.IsAny<CreateBookDto>()), Times.Never);
    }

    [Test]
    public void RateCard_ThrowsBadUserInput_WhenSessionIdIsInvalidGuid()
    {
        var ex = Assert.ThrowsAsync<ExecutionError>(async () =>
            await Resolve("rateCard", new()
            {
                ["sessionId"] = "not-a-guid",
                ["vocabularyId"] = 1,
                ["rating"] = 3
            }));

        Assert.That(ex!.Code, Is.EqualTo("BAD_USER_INPUT"));
    }

    [Test]
    public void CreateVocabulary_ThrowsBadUserInput_WhenRootIsEmpty()
    {
        var ex = Assert.ThrowsAsync<ExecutionError>(async () =>
            await Resolve("createVocabulary", new()
            {
                ["input"] = new CreateVocabularyDto { Root = "", Gloss = "word" }
            }));

        Assert.That(ex!.Code, Is.EqualTo("BAD_USER_INPUT"));
        _vocab.Verify(s => s.CreateVocabularyAsync(It.IsAny<CreateVocabularyDto>()), Times.Never);
    }

    [Test]
    public void CreateChapter_ThrowsBadUserInput_WhenChapterIndexIsZero()
    {
        var ex = Assert.ThrowsAsync<ExecutionError>(async () =>
            await Resolve("createChapter", new()
            {
                ["bookId"] = 1,
                ["input"] = new CreateChapterDto { ChapterIndex = 0 }
            }));

        Assert.That(ex!.Code, Is.EqualTo("BAD_USER_INPUT"));
        _chapters.Verify(s => s.CreateChapterAsync(It.IsAny<int>(), It.IsAny<CreateChapterDto>()), Times.Never);
    }
}
