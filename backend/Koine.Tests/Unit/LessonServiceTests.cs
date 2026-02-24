using Koine.Application.DTOs.Lessons;
using Koine.Application.Interfaces;
using Koine.Application.Interfaces.Repositories;
using Koine.Application.Services;
using Koine.Domain.Entities;
using Moq;

namespace Koine.Tests.Unit;

[TestFixture]
public class LessonServiceTests
{
    [Test]
    public async Task GetAllLessonsAsync_MapsCompletionState()
    {
        var lessonRepo = new Mock<ILessonRepository>();
        var completionRepo = new Mock<ILessonCompletionRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = new Mock<IUnitOfWork>();

        lessonRepo.Setup(r => r.GetAllOrderedAsync()).ReturnsAsync(new List<Lesson>
        {
            new()
            {
                Id = 1,
                Title = "Lesson 1",
                GrammaticalFeatureIdsJson = "[1,2]",
                SyntacticalFeatureIdsJson = "[]",
                VocabularyIdsJson = "[3]"
            },
            new()
            {
                Id = 2,
                Title = "Lesson 2",
                GrammaticalFeatureIdsJson = "[]",
                SyntacticalFeatureIdsJson = "[4]",
                VocabularyIdsJson = "[]"
            },
        });
        completionRepo.Setup(r => r.GetByUserIdAsync(7)).ReturnsAsync(new List<LessonCompletion>
        {
            new() { UserId = 7, LessonId = 2 }
        });

        uow.SetupGet(x => x.Lessons).Returns(lessonRepo.Object);
        uow.SetupGet(x => x.LessonCompletions).Returns(completionRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(userProgressRepo.Object);

        var service = new LessonService(uow.Object);
        var result = await service.GetAllLessonsAsync(7);

        Assert.That(result, Has.Count.EqualTo(2));
        Assert.That(result.Single(x => x.Id == 2).IsCompleted, Is.True);
        Assert.That(result.Single(x => x.Id == 1).IsCompleted, Is.False);
    }

    [Test]
    public async Task CompleteLessonAsync_ReturnsFalse_WhenLessonMissing()
    {
        var lessonRepo = new Mock<ILessonRepository>();
        var completionRepo = new Mock<ILessonCompletionRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = new Mock<IUnitOfWork>();

        lessonRepo.Setup(r => r.GetByIdAsync(123)).ReturnsAsync((Lesson?)null);
        uow.SetupGet(x => x.Lessons).Returns(lessonRepo.Object);
        uow.SetupGet(x => x.LessonCompletions).Returns(completionRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(userProgressRepo.Object);

        var service = new LessonService(uow.Object);
        var result = await service.CompleteLessonAsync(1, new CompleteLessonDto { LessonId = 123, Score = 90 });

        Assert.That(result, Is.False);
    }

    [Test]
    public async Task CompleteLessonAsync_UpdatesProgressAndCreatesCompletion()
    {
        var lessonRepo = new Mock<ILessonRepository>();
        var completionRepo = new Mock<ILessonCompletionRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = new Mock<IUnitOfWork>();

        lessonRepo.Setup(r => r.GetByIdAsync(5)).ReturnsAsync(new Lesson
        {
            Id = 5,
            GrammaticalFeatureIdsJson = "[10]",
            SyntacticalFeatureIdsJson = "[11]",
            VocabularyIdsJson = "[12]",
        });
        completionRepo.Setup(r => r.GetByUserAndLessonAsync(7, 5)).ReturnsAsync((LessonCompletion?)null);
        userProgressRepo.Setup(r => r.GetOrCreateByUserIdAsync(7)).ReturnsAsync(new UserProgress
        {
            UserId = 7,
            CompletedLessonIdsJson = "[]",
            GrammaticalFeatureProgressJson = "{}",
            SyntacticalFeatureProgressJson = "{}",
            VocabularyProgressJson = "{}",
        });
        uow.SetupGet(x => x.Lessons).Returns(lessonRepo.Object);
        uow.SetupGet(x => x.LessonCompletions).Returns(completionRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(userProgressRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new LessonService(uow.Object);
        var result = await service.CompleteLessonAsync(7, new CompleteLessonDto { LessonId = 5, Score = 100 });

        Assert.That(result, Is.True);
        completionRepo.Verify(r => r.AddAsync(It.IsAny<LessonCompletion>()), Times.Once);
        userProgressRepo.Verify(r => r.UpdateAsync(It.Is<UserProgress>(p => p.CompletedLessonIdsJson.Contains("5"))), Times.Once);
    }

    [Test]
    public async Task GetLessonByIdAsync_ReturnsNull_WhenMissing()
    {
        var lessonRepo = new Mock<ILessonRepository>();
        var completionRepo = new Mock<ILessonCompletionRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = new Mock<IUnitOfWork>();

        lessonRepo.Setup(r => r.GetByIdAsync(404)).ReturnsAsync((Lesson?)null);
        uow.SetupGet(x => x.Lessons).Returns(lessonRepo.Object);
        uow.SetupGet(x => x.LessonCompletions).Returns(completionRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(userProgressRepo.Object);

        var service = new LessonService(uow.Object);
        var result = await service.GetLessonByIdAsync(404, 1);

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task GetLessonByIdAsync_ReturnsCompletedState_WhenCompletionExists()
    {
        var lessonRepo = new Mock<ILessonRepository>();
        var completionRepo = new Mock<ILessonCompletionRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = new Mock<IUnitOfWork>();

        lessonRepo.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(new Lesson
        {
            Id = 1,
            Title = "Lesson",
            GrammaticalFeatureIdsJson = "[]",
            SyntacticalFeatureIdsJson = "[]",
            VocabularyIdsJson = "[]",
        });
        completionRepo.Setup(r => r.GetByUserAndLessonAsync(5, 1)).ReturnsAsync(new LessonCompletion { UserId = 5, LessonId = 1 });
        uow.SetupGet(x => x.Lessons).Returns(lessonRepo.Object);
        uow.SetupGet(x => x.LessonCompletions).Returns(completionRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(userProgressRepo.Object);

        var service = new LessonService(uow.Object);
        var result = await service.GetLessonByIdAsync(1, 5);

        Assert.That(result, Is.Not.Null);
        Assert.That(result!.IsCompleted, Is.True);
    }

    [Test]
    public async Task CompleteLessonAsync_UpdatesExistingCompletion_WhenAlreadyCompleted()
    {
        var lessonRepo = new Mock<ILessonRepository>();
        var completionRepo = new Mock<ILessonCompletionRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = new Mock<IUnitOfWork>();

        var existing = new LessonCompletion { UserId = 1, LessonId = 2, Score = 10 };
        lessonRepo.Setup(r => r.GetByIdAsync(2)).ReturnsAsync(new Lesson
        {
            Id = 2,
            GrammaticalFeatureIdsJson = "[]",
            SyntacticalFeatureIdsJson = "[]",
            VocabularyIdsJson = "[]",
        });
        completionRepo.Setup(r => r.GetByUserAndLessonAsync(1, 2)).ReturnsAsync(existing);
        userProgressRepo.Setup(r => r.GetOrCreateByUserIdAsync(1)).ReturnsAsync(new UserProgress
        {
            UserId = 1,
            CompletedLessonIdsJson = "[2]",
            GrammaticalFeatureProgressJson = "{}",
            SyntacticalFeatureProgressJson = "{}",
            VocabularyProgressJson = "{}",
        });

        uow.SetupGet(x => x.Lessons).Returns(lessonRepo.Object);
        uow.SetupGet(x => x.LessonCompletions).Returns(completionRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(userProgressRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new LessonService(uow.Object);
        var result = await service.CompleteLessonAsync(1, new CompleteLessonDto { LessonId = 2, Score = 99 });

        Assert.That(result, Is.True);
        Assert.That(existing.Score, Is.EqualTo(99));
        completionRepo.Verify(r => r.UpdateAsync(existing), Times.Once);
    }

    [Test]
    public async Task CreateLessonAsync_ReturnsCreatedDto()
    {
        var lessonRepo = new Mock<ILessonRepository>();
        var completionRepo = new Mock<ILessonCompletionRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = new Mock<IUnitOfWork>();

        lessonRepo.Setup(r => r.AddAsync(It.IsAny<Lesson>()))
            .ReturnsAsync((Lesson l) =>
            {
                l.Id = 66;
                return l;
            });
        uow.SetupGet(x => x.Lessons).Returns(lessonRepo.Object);
        uow.SetupGet(x => x.LessonCompletions).Returns(completionRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(userProgressRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new LessonService(uow.Object);
        var result = await service.CreateLessonAsync(new CreateLessonDto
        {
            Title = "Created",
            LessonIndex = 1,
            ContentMarkdown = "## content",
            LessonType = "grammar",
            GrammaticalFeatureIds = new List<int> { 1 },
            SyntacticalFeatureIds = new List<int>(),
            VocabularyIds = new List<int> { 2 },
        });

        Assert.That(result.Id, Is.EqualTo(66));
        Assert.That(result.IsCompleted, Is.False);
    }

    [Test]
    public async Task UpdateLessonAsync_ReturnsNull_WhenMissing()
    {
        var lessonRepo = new Mock<ILessonRepository>();
        var completionRepo = new Mock<ILessonCompletionRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = new Mock<IUnitOfWork>();

        lessonRepo.Setup(r => r.GetByIdAsync(13)).ReturnsAsync((Lesson?)null);
        uow.SetupGet(x => x.Lessons).Returns(lessonRepo.Object);
        uow.SetupGet(x => x.LessonCompletions).Returns(completionRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(userProgressRepo.Object);

        var service = new LessonService(uow.Object);
        var result = await service.UpdateLessonAsync(13, new UpdateLessonDto
        {
            Title = "Updated",
            LessonIndex = 2,
            ContentMarkdown = "x",
            LessonType = "grammar",
            GrammaticalFeatureIds = new List<int>(),
            SyntacticalFeatureIds = new List<int>(),
            VocabularyIds = new List<int>(),
        });

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task UpdateLessonAsync_UpdatesWhenFound()
    {
        var lessonRepo = new Mock<ILessonRepository>();
        var completionRepo = new Mock<ILessonCompletionRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = new Mock<IUnitOfWork>();
        var lesson = new Lesson { Id = 3, Title = "Old", LessonType = "grammar" };

        lessonRepo.Setup(r => r.GetByIdAsync(3)).ReturnsAsync(lesson);
        uow.SetupGet(x => x.Lessons).Returns(lessonRepo.Object);
        uow.SetupGet(x => x.LessonCompletions).Returns(completionRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(userProgressRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new LessonService(uow.Object);
        var result = await service.UpdateLessonAsync(3, new UpdateLessonDto
        {
            Title = "New",
            LessonIndex = 4,
            ContentMarkdown = "md",
            LessonType = "vocab",
            GrammaticalFeatureIds = new List<int> { 7 },
            SyntacticalFeatureIds = new List<int>(),
            VocabularyIds = new List<int>(),
        });

        Assert.That(result, Is.Not.Null);
        Assert.That(lesson.Title, Is.EqualTo("New"));
        lessonRepo.Verify(r => r.UpdateAsync(lesson), Times.Once);
    }

    [Test]
    public async Task DeleteLessonAsync_ReturnsFalse_WhenMissing()
    {
        var lessonRepo = new Mock<ILessonRepository>();
        var completionRepo = new Mock<ILessonCompletionRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = new Mock<IUnitOfWork>();

        lessonRepo.Setup(r => r.GetByIdAsync(8)).ReturnsAsync((Lesson?)null);
        uow.SetupGet(x => x.Lessons).Returns(lessonRepo.Object);
        uow.SetupGet(x => x.LessonCompletions).Returns(completionRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(userProgressRepo.Object);

        var service = new LessonService(uow.Object);
        var result = await service.DeleteLessonAsync(8);

        Assert.That(result, Is.False);
    }

    [Test]
    public async Task DeleteLessonAsync_DeletesWhenFound()
    {
        var lessonRepo = new Mock<ILessonRepository>();
        var completionRepo = new Mock<ILessonCompletionRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = new Mock<IUnitOfWork>();
        var lesson = new Lesson { Id = 9 };

        lessonRepo.Setup(r => r.GetByIdAsync(9)).ReturnsAsync(lesson);
        uow.SetupGet(x => x.Lessons).Returns(lessonRepo.Object);
        uow.SetupGet(x => x.LessonCompletions).Returns(completionRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(userProgressRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new LessonService(uow.Object);
        var result = await service.DeleteLessonAsync(9);

        Assert.That(result, Is.True);
        lessonRepo.Verify(r => r.DeleteAsync(lesson), Times.Once);
    }
}
