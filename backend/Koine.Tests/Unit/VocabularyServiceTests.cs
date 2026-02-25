using Koine.Application.Interfaces;
using Koine.Application.Interfaces.Repositories;
using Koine.Application.Services;
using Koine.Domain.Entities;
using Moq;
using System.Linq;

namespace Koine.Tests.Unit;

[TestFixture]
public class VocabularyServiceTests
{
    [Test]
    public async Task GetWordsByBookIdAsync_ReturnsOnlyWordsInBook()
    {
        var chapterRepo = new Mock<IChapterRepository>();
        var vocabRepo = new Mock<IVocabularyRepository>();
        var uow = CreateUnitOfWork(chapterRepo, vocabRepo);

        chapterRepo.Setup(r => r.GetByBookIdAsync(4)).ReturnsAsync(new List<Chapter>
        {
            new() { Id = 1, BookId = 4, UnitTreeJson = "[{\"VocabId\":1},{\"Children\":[{\"VocabId\":2}]}]" },
        });

        vocabRepo.Setup(r => r.GetByIdsAsync(It.Is<List<int>>(ids => ids.Count == 2 && ids.Contains(1) && ids.Contains(2))))
            .ReturnsAsync(new List<Vocabulary>
            {
                new() { Id = 1, Root = "logos", Gloss = "word", Occurrences = 300 },
                new() { Id = 2, Root = "agape", Gloss = "love", Occurrences = 120 },
            });

        var service = new VocabularyService(uow.Object);
        var result = await service.GetWordsByBookIdAsync(4);

        Assert.That(result, Has.Count.EqualTo(2));
        Assert.That(result.Select(x => x.RootId), Is.EquivalentTo(new[] { 1, 2 }));
    }

    [Test]
    public async Task GetWordsByChapterIdAsync_ReturnsEmpty_WhenChapterMissing()
    {
        var chapterRepo = new Mock<IChapterRepository>();
        var vocabRepo = new Mock<IVocabularyRepository>();
        var uow = CreateUnitOfWork(chapterRepo, vocabRepo);

        chapterRepo.Setup(r => r.GetByIdAsync(99)).ReturnsAsync((Chapter?)null);

        var service = new VocabularyService(uow.Object);
        var result = await service.GetWordsByChapterIdAsync(99);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public async Task GetSimpleByIdAsync_ReturnsDeterministicGuid()
    {
        var chapterRepo = new Mock<IChapterRepository>();
        var vocabRepo = new Mock<IVocabularyRepository>();
        var uow = CreateUnitOfWork(chapterRepo, vocabRepo);

        vocabRepo.Setup(r => r.GetByIdAsync(5)).ReturnsAsync(new Vocabulary
        {
            Id = 5,
            Root = "pistis",
            Gloss = "faith",
            Occurrences = 10,
        });

        var service = new VocabularyService(uow.Object);
        var first = await service.GetSimpleByIdAsync(5);
        var second = await service.GetSimpleByIdAsync(5);

        Assert.That(first, Is.Not.Null);
        Assert.That(second, Is.Not.Null);
        Assert.That(first!.RootGUID, Is.EqualTo(second!.RootGUID));
    }

    private static Mock<IUnitOfWork> CreateUnitOfWork(
        Mock<IChapterRepository> chapterRepo,
        Mock<IVocabularyRepository> vocabRepo)
    {
        var uow = new Mock<IUnitOfWork>();
        uow.SetupGet(x => x.Chapters).Returns(chapterRepo.Object);
        uow.SetupGet(x => x.Vocabulary).Returns(vocabRepo.Object);
        return uow;
    }
}
