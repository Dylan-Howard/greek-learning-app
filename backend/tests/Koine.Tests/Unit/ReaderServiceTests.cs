using System.Text.Json;
using Koine.Application.Interfaces;
using Koine.Application.Interfaces.Repositories;
using Koine.Application.Services;
using Koine.Domain.Entities;
using Koine.Domain.ValueObjects;
using Moq;

namespace Koine.Tests.Unit;

[TestFixture]
public class ReaderServiceTests
{
    [Test]
    public void RenderChapterAsync_Throws_WhenChapterMissing()
    {
        var unitOfWork = CreateUnitOfWork(out var chapters, out _, out _, out _, out _, out _, out _);
        chapters.Setup(r => r.GetByBookAndIndexAsync(1, 1)).ReturnsAsync((Chapter?)null);
        var service = new ReaderService(unitOfWork.Object);

        Assert.ThrowsAsync<KeyNotFoundException>(async () => await service.RenderChapterAsync(1, 1, 1));
    }

    [Test]
    public void RenderChapterAsync_Throws_WhenTranslationMissing()
    {
        var unitOfWork = CreateUnitOfWork(out var chapters, out var translations, out _, out _, out _, out _, out _);
        chapters.Setup(r => r.GetByBookAndIndexAsync(1, 1)).ReturnsAsync(new Chapter { Id = 11, UnitTreeJson = "[]" });
        translations.Setup(r => r.GetByBookAndLanguageAsync(1, "en")).ReturnsAsync((Translation?)null);
        var service = new ReaderService(unitOfWork.Object);

        Assert.ThrowsAsync<KeyNotFoundException>(async () => await service.RenderChapterAsync(1, 1, 1, "en"));
    }

    [Test]
    public async Task RenderChapterAsync_RendersUnknownVocabulary_AsTranslated()
    {
        var unitTree = new List<UnitNode>
        {
            new() { Type = "unit", Path = "u1", Root = "logos", VocabId = 10 },
        };

        var unitOfWork = CreateReaderFixture(
            unitTree,
            out var translationUnits,
            out var userProgressRepo,
            out _,
            out _);
        translationUnits.Setup(r => r.GetByChapterAndTranslationAsync(11, 21)).ReturnsAsync(new List<TranslationUnit>
        {
            new() { OriginalUnitPath = "u1", TranslatedText = "word", DisplayOrder = 1 },
        });
        userProgressRepo.Setup(r => r.GetByUserIdAsync(1)).ReturnsAsync(new UserProgress
        {
            VocabularyProgressJson = "{}",
            GrammaticalFeatureProgressJson = "{}",
            SyntacticalFeatureProgressJson = "{}",
        });

        var service = new ReaderService(unitOfWork.Object);
        var result = await service.RenderChapterAsync(1, 1, 1, "en");

        Assert.That(result.Units, Has.Count.EqualTo(1));
        Assert.That(result.Units[0].Type, Is.EqualTo("translated"));
        Assert.That(result.Units[0].Text, Is.EqualTo("word"));
    }

    [Test]
    public async Task RenderChapterAsync_RendersHintedWord_WhenGrammarNeedsSupport()
    {
        var unitTree = new List<UnitNode>
        {
            new() { Type = "unit", Path = "u1", Root = "logos", VocabId = 10, GramFeatureIds = new List<int> { 101 } },
        };

        var unitOfWork = CreateReaderFixture(
            unitTree,
            out var translationUnits,
            out var userProgressRepo,
            out var grammaticalFeatures,
            out _);
        translationUnits.Setup(r => r.GetByChapterAndTranslationAsync(11, 21)).ReturnsAsync(new List<TranslationUnit>());
        userProgressRepo.Setup(r => r.GetByUserIdAsync(1)).ReturnsAsync(new UserProgress
        {
            VocabularyProgressJson = JsonSerializer.Serialize(new Dictionary<int, VocabularyProgress>
            {
                [10] = new() { MasteryLevel = 80, NeedsPractice = false, LastPracticed = DateTime.UtcNow, TimesSeen = 2 },
            }),
            GrammaticalFeatureProgressJson = JsonSerializer.Serialize(new Dictionary<int, FeatureProgress>
            {
                [101] = new() { MasteryLevel = 20, NeedsPractice = true, LastPracticed = DateTime.UtcNow },
            }),
            SyntacticalFeatureProgressJson = "{}",
        });

        grammaticalFeatures.Setup(r => r.GetByIdsAsync(It.IsAny<List<int>>()))
            .ReturnsAsync(new List<GrammaticalFeature> { new() { Id = 101, Code = "AOR" } });

        var service = new ReaderService(unitOfWork.Object);
        var result = await service.RenderChapterAsync(1, 1, 1, "en");

        Assert.That(result.Units[0].Type, Is.EqualTo("original_with_hints"));
        Assert.That(result.Units[0].Hints, Is.Not.Empty);
    }

    [Test]
    public async Task RenderChapterAsync_RendersExpandedParent_WhenChildrenExist()
    {
        var unitTree = new List<UnitNode>
        {
            new()
            {
                Type = "unit",
                Path = "parent",
                Root = "parent",
                Children = new List<UnitNode>
                {
                    new() { Type = "unit", Path = "child", Root = "tekna", VocabId = 22 },
                },
            },
        };

        var unitOfWork = CreateReaderFixture(
            unitTree,
            out var translationUnits,
            out var userProgressRepo,
            out _,
            out _);
        translationUnits.Setup(r => r.GetByChapterAndTranslationAsync(11, 21)).ReturnsAsync(new List<TranslationUnit>
        {
            new() { OriginalUnitPath = "parent", TranslatedText = "children", DisplayOrder = 1 },
        });
        userProgressRepo.Setup(r => r.GetByUserIdAsync(1)).ReturnsAsync(new UserProgress
        {
            VocabularyProgressJson = JsonSerializer.Serialize(new Dictionary<int, VocabularyProgress>
            {
                [22] = new() { MasteryLevel = 90, NeedsPractice = false, LastPracticed = DateTime.UtcNow, TimesSeen = 4 },
            }),
            GrammaticalFeatureProgressJson = "{}",
            SyntacticalFeatureProgressJson = "{}",
        });

        var service = new ReaderService(unitOfWork.Object);
        var result = await service.RenderChapterAsync(1, 1, 1, "en");

        Assert.That(result.Units[0].Type, Is.EqualTo("expanded"));
        Assert.That(result.Units[0].Children, Has.Count.EqualTo(1));
        Assert.That(result.Units[0].Text, Is.EqualTo("children"));
    }

    private static Mock<IUnitOfWork> CreateReaderFixture(
        List<UnitNode> unitTree,
        out Mock<ITranslationUnitRepository> translationUnits,
        out Mock<IUserProgressRepository> userProgressRepo,
        out Mock<IGrammaticalFeatureRepository> grammaticalFeatures,
        out Mock<ISyntacticalFeatureRepository> syntacticalFeatures)
    {
        var unitOfWork = CreateUnitOfWork(
            out var chapters,
            out var translations,
            out translationUnits,
            out userProgressRepo,
            out grammaticalFeatures,
            out syntacticalFeatures,
            out _);

        chapters.Setup(r => r.GetByBookAndIndexAsync(1, 1)).ReturnsAsync(new Chapter
        {
            Id = 11,
            BookId = 1,
            ChapterIndex = 1,
            Title = "John 1",
            UnitTreeJson = JsonSerializer.Serialize(unitTree),
        });
        translations.Setup(r => r.GetByBookAndLanguageAsync(1, "en")).ReturnsAsync(new Translation
        {
            Id = 21,
            BookId = 1,
            LanguageCode = "en",
        });
        grammaticalFeatures.Setup(r => r.GetByIdsAsync(It.IsAny<List<int>>())).ReturnsAsync(new List<GrammaticalFeature>());
        syntacticalFeatures.Setup(r => r.GetByIdsAsync(It.IsAny<List<int>>())).ReturnsAsync(new List<SyntacticalFeature>());

        return unitOfWork;
    }

    private static Mock<IUnitOfWork> CreateUnitOfWork(
        out Mock<IChapterRepository> chapters,
        out Mock<ITranslationRepository> translations,
        out Mock<ITranslationUnitRepository> translationUnits,
        out Mock<IUserProgressRepository> userProgress,
        out Mock<IGrammaticalFeatureRepository> grammaticalFeatures,
        out Mock<ISyntacticalFeatureRepository> syntacticalFeatures,
        out Mock<IVocabularyRepository> vocabulary)
    {
        chapters = new Mock<IChapterRepository>();
        translations = new Mock<ITranslationRepository>();
        translationUnits = new Mock<ITranslationUnitRepository>();
        userProgress = new Mock<IUserProgressRepository>();
        grammaticalFeatures = new Mock<IGrammaticalFeatureRepository>();
        syntacticalFeatures = new Mock<ISyntacticalFeatureRepository>();
        vocabulary = new Mock<IVocabularyRepository>();

        var unitOfWork = new Mock<IUnitOfWork>();
        unitOfWork.SetupGet(u => u.Chapters).Returns(chapters.Object);
        unitOfWork.SetupGet(u => u.Translations).Returns(translations.Object);
        unitOfWork.SetupGet(u => u.TranslationUnits).Returns(translationUnits.Object);
        unitOfWork.SetupGet(u => u.UserProgress).Returns(userProgress.Object);
        unitOfWork.SetupGet(u => u.GrammaticalFeatures).Returns(grammaticalFeatures.Object);
        unitOfWork.SetupGet(u => u.SyntacticalFeatures).Returns(syntacticalFeatures.Object);
        unitOfWork.SetupGet(u => u.Vocabulary).Returns(vocabulary.Object);

        return unitOfWork;
    }
}
