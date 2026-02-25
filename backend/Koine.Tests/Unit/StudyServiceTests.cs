using Koine.Application.DTOs.Study;
using Koine.Application.Interfaces;
using Koine.Application.Interfaces.Repositories;
using Koine.Application.Services;
using Koine.Domain.Entities;
using Moq;
using System.Linq;
using System.Text.Json;

namespace Koine.Tests.Unit;

[TestFixture]
public class StudyServiceTests
{
    [Test]
    public async Task GetUserSetsAsync_MapsSystemAndUserSets_WithProgressSummary()
    {
        var setRepo = new Mock<IVocabularySetRepository>();
        var itemRepo = new Mock<IVocabularySetItemRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = CreateUnitOfWork(setRepo, itemRepo, userProgressRepo);

        setRepo.Setup(r => r.GetVisibleToUserAsync(1)).ReturnsAsync(new List<VocabularySet>
        {
            new()
            {
                Id = 10,
                IsSystem = true,
                Slug = "nt-occ-gt-50",
                Title = "System",
                Description = "System Set",
                CreatedAt = DateTime.UtcNow,
                Items = new List<VocabularySetItem>
                {
                    new() { Id = 1, VocabularyId = 101, Vocabulary = new Vocabulary { Id = 101, Root = "logos", Gloss = "word" } },
                    new() { Id = 2, VocabularyId = 102, Vocabulary = new Vocabulary { Id = 102, Root = "agape", Gloss = "love" } },
                },
            },
            new()
            {
                Id = 11,
                OwnerUserId = 1,
                IsSystem = false,
                Slug = "user-1-custom",
                Title = "Custom",
                Description = "Custom Set",
                CreatedAt = DateTime.UtcNow,
                Items = new List<VocabularySetItem>
                {
                    new() { Id = 3, VocabularyId = 103, Vocabulary = new Vocabulary { Id = 103, Root = "zoe", Gloss = "life" } },
                },
            },
        });

        userProgressRepo.Setup(r => r.GetByUserIdAsync(1)).ReturnsAsync(new UserProgress
        {
            UserId = 1,
            VocabularyProgressJson = JsonSerializer.Serialize(new Dictionary<int, Koine.Domain.ValueObjects.VocabularyProgress>
            {
                [101] = new() { MasteryLevel = 90, TimesSeen = 3, LastPracticed = DateTime.UtcNow, NeedsPractice = false },
            }),
        });

        var service = new StudyService(uow.Object);
        var result = await service.GetUserSetsAsync(1);

        Assert.That(result, Has.Count.EqualTo(2));
        Assert.That(result[0].IsSystem || result[1].IsSystem, Is.True);
        var system = result.First(r => r.IsSystem);
        Assert.That(system.TotalCount, Is.EqualTo(2));
        Assert.That(system.KnownCount, Is.EqualTo(1));
    }

    [Test]
    public async Task AddVocabularyToSetAsync_ReturnsFalse_ForSystemSet()
    {
        var setRepo = new Mock<IVocabularySetRepository>();
        var itemRepo = new Mock<IVocabularySetItemRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = CreateUnitOfWork(setRepo, itemRepo, userProgressRepo);

        setRepo.Setup(r => r.GetByIdAsync(5)).ReturnsAsync(new VocabularySet
        {
            Id = 5,
            IsSystem = true,
            Slug = "nt-all-vocab",
            Title = "System",
        });

        var service = new StudyService(uow.Object);
        var success = await service.AddVocabularyToSetAsync(5, 1, 123);

        Assert.That(success, Is.False);
        itemRepo.Verify(r => r.AddAsync(It.IsAny<VocabularySetItem>()), Times.Never);
    }

    [Test]
    public async Task UpdateVocabularyProgressAsync_UpdatesUserProgressJson()
    {
        var setRepo = new Mock<IVocabularySetRepository>();
        var itemRepo = new Mock<IVocabularySetItemRepository>();
        var userProgressRepo = new Mock<IUserProgressRepository>();
        var uow = CreateUnitOfWork(setRepo, itemRepo, userProgressRepo);

        setRepo.Setup(r => r.GetByIdAsync(8)).ReturnsAsync(new VocabularySet
        {
            Id = 8,
            IsSystem = true,
            Slug = "nt-occ-gt-15",
            Title = "System",
        });
        itemRepo.Setup(r => r.GetBySetAndVocabAsync(8, 200)).ReturnsAsync(new VocabularySetItem
        {
            Id = 22,
            VocabularySetId = 8,
            VocabularyId = 200,
        });

        var progress = new UserProgress { UserId = 1, VocabularyProgressJson = "{}" };
        userProgressRepo.Setup(r => r.GetOrCreateByUserIdAsync(1)).ReturnsAsync(progress);

        var service = new StudyService(uow.Object);
        var success = await service.UpdateVocabularyProgressAsync(8, 1, 200, 77);

        Assert.That(success, Is.True);
        var parsed = JsonSerializer.Deserialize<Dictionary<int, Koine.Domain.ValueObjects.VocabularyProgress>>(progress.VocabularyProgressJson);
        Assert.That(parsed, Is.Not.Null);
        Assert.That(parsed!.ContainsKey(200), Is.True);
        Assert.That(parsed[200].MasteryLevel, Is.EqualTo(77));
        userProgressRepo.Verify(r => r.UpdateAsync(It.IsAny<UserProgress>()), Times.Once);
    }

    private static Mock<IUnitOfWork> CreateUnitOfWork(
        Mock<IVocabularySetRepository> setRepo,
        Mock<IVocabularySetItemRepository> itemRepo,
        Mock<IUserProgressRepository> userProgressRepo)
    {
        var uow = new Mock<IUnitOfWork>();
        uow.SetupGet(x => x.VocabularySets).Returns(setRepo.Object);
        uow.SetupGet(x => x.VocabularySetItems).Returns(itemRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(userProgressRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);
        return uow;
    }
}
