using System.Text.Json;
using Koine.Application.DTOs.Progress;
using Koine.Application.Interfaces;
using Koine.Application.Interfaces.Repositories;
using Koine.Application.Services;
using Koine.Domain.Entities;
using Koine.Domain.ValueObjects;
using Moq;

namespace Koine.Tests.Unit;

[TestFixture]
public class ProgressServiceTests
{
    [Test]
    public async Task GetUserProgressAsync_ReturnsNull_WhenNoProgress()
    {
        var unitOfWork = CreateUnitOfWork(out var userProgress, out _, out _, out _);
        userProgress.Setup(r => r.GetByUserIdAsync(1)).ReturnsAsync((UserProgress?)null);
        var service = new ProgressService(unitOfWork.Object);

        var result = await service.GetUserProgressAsync(1);

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task GetUserProgressAsync_MapsJsonPayloads()
    {
        var unitOfWork = CreateUnitOfWork(out var userProgress, out var users, out _, out _);
        var progress = new UserProgress
        {
            UserId = 2,
            CompletedLessonIdsJson = JsonSerializer.Serialize(new List<int> { 10 }),
            GrammaticalFeatureProgressJson = JsonSerializer.Serialize(new Dictionary<int, FeatureProgress>
            {
                [1] = new() { MasteryLevel = 80, NeedsPractice = false, LastPracticed = DateTime.UtcNow },
            }),
            SyntacticalFeatureProgressJson = JsonSerializer.Serialize(new Dictionary<int, FeatureProgress>
            {
                [2] = new() { MasteryLevel = 60, NeedsPractice = true, LastPracticed = DateTime.UtcNow },
            }),
            VocabularyProgressJson = JsonSerializer.Serialize(new Dictionary<int, VocabularyProgress>
            {
                [3] = new() { MasteryLevel = 55, NeedsPractice = true, LastPracticed = DateTime.UtcNow, TimesSeen = 7 },
            }),
            UpdatedAt = DateTime.UtcNow,
        };
        userProgress.Setup(r => r.GetByUserIdAsync(2)).ReturnsAsync(progress);
        users.Setup(r => r.GetByIdAsync(2)).ReturnsAsync(new User { Id = 2, TotalExperience = 500 });

        var service = new ProgressService(unitOfWork.Object);
        var result = await service.GetUserProgressAsync(2);

        Assert.That(result, Is.Not.Null);
        Assert.That(result!.CompletedLessonIds, Is.EqualTo(new List<int> { 10 }));
        Assert.That(result.GrammaticalFeatureProgress[1].MasteryLevel, Is.EqualTo(80));
        Assert.That(result.SyntacticalFeatureProgress[2].NeedsPractice, Is.True);
        Assert.That(result.VocabularyProgress[3].TimesSeen, Is.EqualTo(7));
        Assert.That(result.TotalExperience, Is.EqualTo(500));
    }

    [Test]
    public async Task UpdateProgressAsync_SerializesAndPersists()
    {
        var unitOfWork = CreateUnitOfWork(out var userProgress, out _, out _, out _);
        var progress = new UserProgress { UserId = 7 };
        userProgress.Setup(r => r.GetOrCreateByUserIdAsync(7)).ReturnsAsync(progress);

        var dto = new UserProgressDto
        {
            CompletedLessonIds = new List<int> { 1, 2 },
            GrammaticalFeatureProgress = new Dictionary<int, FeatureProgressDto>
            {
                [11] = new() { MasteryLevel = 90, NeedsPractice = false, LastPracticed = DateTime.UtcNow },
            },
            SyntacticalFeatureProgress = new Dictionary<int, FeatureProgressDto>
            {
                [12] = new() { MasteryLevel = 20, NeedsPractice = true, LastPracticed = DateTime.UtcNow },
            },
            VocabularyProgress = new Dictionary<int, VocabularyProgressDto>
            {
                [13] = new() { MasteryLevel = 40, NeedsPractice = true, LastPracticed = DateTime.UtcNow, TimesSeen = 3 },
            },
        };

        var service = new ProgressService(unitOfWork.Object);
        var success = await service.UpdateProgressAsync(7, dto);

        Assert.That(success, Is.True);
        Assert.That(progress.CompletedLessonIdsJson, Does.Contain("1"));
        Assert.That(progress.GrammaticalFeatureProgressJson, Does.Contain("11"));
        Assert.That(progress.VocabularyProgressJson, Does.Contain("TimesSeen"));
        userProgress.Verify(r => r.UpdateAsync(progress), Times.Once);
        unitOfWork.Verify(u => u.SaveChangesAsync(), Times.Once);
    }

    [Test]
    public async Task GetUserLessonsAsync_MapsCompletionState()
    {
        var unitOfWork = CreateUnitOfWork(out var userProgress, out _, out var lessons, out _);
        userProgress.Setup(r => r.GetByUserIdAsync(1)).ReturnsAsync(new UserProgress
        {
            CompletedLessonIdsJson = JsonSerializer.Serialize(new List<int> { 2 }),
        });
        lessons.Setup(r => r.GetAllAsync()).ReturnsAsync(new List<Lesson>
        {
            new() { Id = 1, Title = "Lesson 1" },
            new() { Id = 2, Title = "Lesson 2" },
        });

        var service = new ProgressService(unitOfWork.Object);
        var result = await service.GetUserLessonsAsync(1);

        Assert.That(result, Has.Count.EqualTo(2));
        Assert.That(result.Single(x => x.LessonId == 2).IsComplete, Is.True);
        Assert.That(result.Single(x => x.LessonId == 1).IsComplete, Is.False);
    }

    [Test]
    public async Task GetUserVocabularyAsync_ReturnsMappedAndUnknownWords()
    {
        var unitOfWork = CreateUnitOfWork(out var userProgress, out _, out _, out var vocabulary);
        userProgress.Setup(r => r.GetByUserIdAsync(1)).ReturnsAsync(new UserProgress
        {
            VocabularyProgressJson = JsonSerializer.Serialize(new Dictionary<int, VocabularyProgress>
            {
                [7] = new() { MasteryLevel = 60, NeedsPractice = true, LastPracticed = DateTime.UtcNow, TimesSeen = 10 },
                [8] = new() { MasteryLevel = 20, NeedsPractice = true, LastPracticed = DateTime.UtcNow, TimesSeen = 2 },
            }),
        });
        vocabulary.Setup(r => r.GetByIdsAsync(It.Is<List<int>>(ids => ids.Contains(7) && ids.Contains(8))))
            .ReturnsAsync(new List<Vocabulary>
            {
                new() { Id = 7, Root = "agape", Gloss = "love" },
            });

        var service = new ProgressService(unitOfWork.Object);
        var result = await service.GetUserVocabularyAsync(1);

        Assert.That(result, Has.Count.EqualTo(2));
        Assert.That(result.Single(x => x.WordId == 7).GreekWord, Is.EqualTo("agape"));
        Assert.That(result.Single(x => x.WordId == 8).GreekWord, Is.EqualTo("Unknown"));
    }

    private static Mock<IUnitOfWork> CreateUnitOfWork(
        out Mock<IUserProgressRepository> userProgress,
        out Mock<IUserRepository> users,
        out Mock<ILessonRepository> lessons,
        out Mock<IVocabularyRepository> vocabulary)
    {
        userProgress = new Mock<IUserProgressRepository>();
        users = new Mock<IUserRepository>();
        lessons = new Mock<ILessonRepository>();
        vocabulary = new Mock<IVocabularyRepository>();

        var unitOfWork = new Mock<IUnitOfWork>();
        unitOfWork.SetupGet(u => u.UserProgress).Returns(userProgress.Object);
        unitOfWork.SetupGet(u => u.Users).Returns(users.Object);
        unitOfWork.SetupGet(u => u.Lessons).Returns(lessons.Object);
        unitOfWork.SetupGet(u => u.Vocabulary).Returns(vocabulary.Object);
        unitOfWork.Setup(u => u.SaveChangesAsync()).ReturnsAsync(1);

        return unitOfWork;
    }
}
