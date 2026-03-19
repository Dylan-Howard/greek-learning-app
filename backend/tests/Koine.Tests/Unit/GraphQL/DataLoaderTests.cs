using GraphQL.DataLoader;
using Koine.API.GraphQL.DataLoaders;
using Koine.Application.DTOs.Chapters;
using Koine.Application.DTOs.Features;
using Koine.Application.DTOs.Vocabulary;
using Koine.Application.Interfaces;
using Moq;

namespace Koine.Tests.Unit.GraphQL;

/// <summary>
/// Unit tests for GraphQL DataLoaders.
/// Verifies correct delegation to Application Services and result mapping.
/// Requirements: 5.1–5.6
/// </summary>
[TestFixture]
public class DataLoaderTests
{
    // ── ChaptersByBookIdDataLoader ────────────────────────────────────────────

    [Test]
    public async Task ChaptersByBookIdDataLoader_ReturnsMappedChapters_ForSingleBookId()
    {
        var chapterService = new Mock<IChapterService>();
        chapterService
            .Setup(s => s.GetChaptersByBookIdAsync(1))
            .ReturnsAsync(new List<ChapterDto>
            {
                new() { Id = 10, BookId = 1, ChapterIndex = 1 },
                new() { Id = 11, BookId = 1, ChapterIndex = 2 },
            });

        var loader = new ChaptersByBookIdDataLoader(chapterService.Object);
        var result = await loader.LoadAsync(1).GetResultAsync();

        Assert.That(result, Has.Count.EqualTo(2));
        Assert.That(result.Select(c => c.Id), Is.EquivalentTo(new[] { 10, 11 }));
    }

    [Test]
    public async Task ChaptersByBookIdDataLoader_BatchesMultipleBookIds_ConcurrentlyInSingleDispatch()
    {
        var chapterService = new Mock<IChapterService>();
        chapterService
            .Setup(s => s.GetChaptersByBookIdAsync(1))
            .ReturnsAsync(new List<ChapterDto> { new() { Id = 10, BookId = 1, ChapterIndex = 1 } });
        chapterService
            .Setup(s => s.GetChaptersByBookIdAsync(2))
            .ReturnsAsync(new List<ChapterDto> { new() { Id = 20, BookId = 2, ChapterIndex = 1 } });
        chapterService
            .Setup(s => s.GetChaptersByBookIdAsync(3))
            .ReturnsAsync(new List<ChapterDto> { new() { Id = 30, BookId = 3, ChapterIndex = 1 } });

        var loader = new ChaptersByBookIdDataLoader(chapterService.Object);

        // Queue three loads and await all — simulates resolving chapters for 3 books
        var results = await Task.WhenAll(
            loader.LoadAsync(1).GetResultAsync(),
            loader.LoadAsync(2).GetResultAsync(),
            loader.LoadAsync(3).GetResultAsync());

        Assert.That(results[0].Single().Id, Is.EqualTo(10));
        Assert.That(results[1].Single().Id, Is.EqualTo(20));
        Assert.That(results[2].Single().Id, Is.EqualTo(30));
    }

    [Test]
    public async Task ChaptersByBookIdDataLoader_ReturnsEmptyList_WhenNoChaptersFound()
    {
        var chapterService = new Mock<IChapterService>();
        chapterService
            .Setup(s => s.GetChaptersByBookIdAsync(99))
            .ReturnsAsync(new List<ChapterDto>());

        var loader = new ChaptersByBookIdDataLoader(chapterService.Object);
        var result = await loader.LoadAsync(99).GetResultAsync();

        Assert.That(result, Is.Empty);
    }

    [Test]
    public async Task ChaptersByBookIdDataLoader_DelegatesCorrectBookId_ToService()
    {
        var chapterService = new Mock<IChapterService>();
        chapterService
            .Setup(s => s.GetChaptersByBookIdAsync(42))
            .ReturnsAsync(new List<ChapterDto> { new() { Id = 420, BookId = 42, ChapterIndex = 1 } });

        var loader = new ChaptersByBookIdDataLoader(chapterService.Object);
        await loader.LoadAsync(42).GetResultAsync();

        chapterService.Verify(s => s.GetChaptersByBookIdAsync(42), Times.Once);
    }

    // ── WordsByChapterIdDataLoader ────────────────────────────────────────────

    [Test]
    public async Task WordsByChapterIdDataLoader_ReturnsMappedWords_ForSingleChapterId()
    {
        var vocabService = new Mock<IVocabularyService>();
        vocabService
            .Setup(s => s.GetWordsByChapterIdAsync(7))
            .ReturnsAsync(new List<SimpleWordDto>
            {
                new() { RootId = 100, Content = "λόγος", Gloss = "word", Occurrences = 330 },
                new() { RootId = 101, Content = "θεός", Gloss = "God", Occurrences = 1317 },
            });

        var loader = new WordsByChapterIdDataLoader(vocabService.Object);
        var result = await loader.LoadAsync(7).GetResultAsync();

        Assert.That(result, Has.Count.EqualTo(2));
        Assert.That(result.Select(w => w.Content), Is.EquivalentTo(new[] { "λόγος", "θεός" }));
    }

    [Test]
    public async Task WordsByChapterIdDataLoader_BatchesMultipleChapterIds_ConcurrentlyInSingleDispatch()
    {
        var vocabService = new Mock<IVocabularyService>();
        vocabService
            .Setup(s => s.GetWordsByChapterIdAsync(1))
            .ReturnsAsync(new List<SimpleWordDto> { new() { RootId = 1, Content = "α", Gloss = "a" } });
        vocabService
            .Setup(s => s.GetWordsByChapterIdAsync(2))
            .ReturnsAsync(new List<SimpleWordDto> { new() { RootId = 2, Content = "β", Gloss = "b" } });

        var loader = new WordsByChapterIdDataLoader(vocabService.Object);

        var results = await Task.WhenAll(
            loader.LoadAsync(1).GetResultAsync(),
            loader.LoadAsync(2).GetResultAsync());

        Assert.That(results[0].Single().Content, Is.EqualTo("α"));
        Assert.That(results[1].Single().Content, Is.EqualTo("β"));
    }

    [Test]
    public async Task WordsByChapterIdDataLoader_ReturnsEmptyList_WhenNoWordsFound()
    {
        var vocabService = new Mock<IVocabularyService>();
        vocabService
            .Setup(s => s.GetWordsByChapterIdAsync(99))
            .ReturnsAsync(new List<SimpleWordDto>());

        var loader = new WordsByChapterIdDataLoader(vocabService.Object);
        var result = await loader.LoadAsync(99).GetResultAsync();

        Assert.That(result, Is.Empty);
    }

    [Test]
    public async Task WordsByChapterIdDataLoader_DelegatesCorrectChapterId_ToService()
    {
        var vocabService = new Mock<IVocabularyService>();
        vocabService
            .Setup(s => s.GetWordsByChapterIdAsync(5))
            .ReturnsAsync(new List<SimpleWordDto>());

        var loader = new WordsByChapterIdDataLoader(vocabService.Object);
        await loader.LoadAsync(5).GetResultAsync();

        vocabService.Verify(s => s.GetWordsByChapterIdAsync(5), Times.Once);
    }

    // ── GrammaticalFeaturesByIdDataLoader ────────────────────────────────────

    [Test]
    public async Task GrammaticalFeaturesByIdDataLoader_ReturnsMappedFeature_ForSingleId()
    {
        var featureService = new Mock<IGrammaticalFeatureService>();
        featureService
            .Setup(s => s.GetFeatureByIdAsync(3))
            .ReturnsAsync(new GrammaticalFeatureDto { Id = 3, Code = "NOM", Name = "Nominative", Category = "Case" });

        var loader = new GrammaticalFeaturesByIdDataLoader(featureService.Object);
        var result = await loader.LoadAsync(3).GetResultAsync();

        Assert.That(result, Is.Not.Null);
        Assert.That(result!.Code, Is.EqualTo("NOM"));
    }

    [Test]
    public async Task GrammaticalFeaturesByIdDataLoader_ReturnsNull_ForMissingId()
    {
        var featureService = new Mock<IGrammaticalFeatureService>();
        featureService
            .Setup(s => s.GetFeatureByIdAsync(999))
            .ReturnsAsync((GrammaticalFeatureDto?)null);

        var loader = new GrammaticalFeaturesByIdDataLoader(featureService.Object);
        var result = await loader.LoadAsync(999).GetResultAsync();

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task GrammaticalFeaturesByIdDataLoader_BatchesMultipleIds_ConcurrentlyInSingleDispatch()
    {
        var featureService = new Mock<IGrammaticalFeatureService>();
        featureService
            .Setup(s => s.GetFeatureByIdAsync(1))
            .ReturnsAsync(new GrammaticalFeatureDto { Id = 1, Code = "NOM", Name = "Nominative", Category = "Case" });
        featureService
            .Setup(s => s.GetFeatureByIdAsync(2))
            .ReturnsAsync(new GrammaticalFeatureDto { Id = 2, Code = "GEN", Name = "Genitive", Category = "Case" });
        featureService
            .Setup(s => s.GetFeatureByIdAsync(3))
            .ReturnsAsync(new GrammaticalFeatureDto { Id = 3, Code = "PRES", Name = "Present", Category = "Tense" });

        var loader = new GrammaticalFeaturesByIdDataLoader(featureService.Object);

        var results = await Task.WhenAll(
            loader.LoadAsync(1).GetResultAsync(),
            loader.LoadAsync(2).GetResultAsync(),
            loader.LoadAsync(3).GetResultAsync());

        Assert.That(results[0]!.Code, Is.EqualTo("NOM"));
        Assert.That(results[1]!.Code, Is.EqualTo("GEN"));
        Assert.That(results[2]!.Code, Is.EqualTo("PRES"));
    }

    [Test]
    public async Task GrammaticalFeaturesByIdDataLoader_DelegatesCorrectId_ToService()
    {
        var featureService = new Mock<IGrammaticalFeatureService>();
        featureService
            .Setup(s => s.GetFeatureByIdAsync(7))
            .ReturnsAsync(new GrammaticalFeatureDto { Id = 7, Code = "ACC", Name = "Accusative", Category = "Case" });

        var loader = new GrammaticalFeaturesByIdDataLoader(featureService.Object);
        await loader.LoadAsync(7).GetResultAsync();

        featureService.Verify(s => s.GetFeatureByIdAsync(7), Times.Once);
    }
}
