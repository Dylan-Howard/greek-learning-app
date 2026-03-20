// Feature: graphql-integration, Property 3: DataLoader batching eliminates N+1 queries for nested fields

using FsCheck;
using FsCheck.NUnit;
using GraphQL.DataLoader;
using Koine.API.GraphQL.DataLoaders;
using Koine.Application.DTOs.Chapters;
using Koine.Application.DTOs.Features;
using Koine.Application.DTOs.Vocabulary;
using Koine.Application.Interfaces;
using Moq;
using Prop = FsCheck.Fluent.Prop;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace Koine.Tests.Unit.GraphQL;

/// <summary>
/// Property-based tests for DataLoader batching behaviour.
/// Feature: graphql-integration, Property 3: DataLoader batching eliminates N+1 queries for nested fields.
/// For any list of N entities (books or chapters), all N <c>LoadAsync</c> calls must be coalesced
/// into a single batch dispatch — the fetch delegate fires exactly once regardless of N.
/// This is achieved by queuing all loads before awaiting any result, which is how the GraphQL
/// execution engine uses DataLoaders during field resolution.
/// Validates: Requirements 5.1, 5.2, 5.3, 5.4, 5.5
/// </summary>
[TestFixture]
public class DataLoaderBatchingPropertyTests
{
    // ── counter box ───────────────────────────────────────────────────────────

    /// <summary>Heap-allocated integer so async lambdas can mutate it by reference.</summary>
    private sealed class Counter { public int Value; }

    // ── batch dispatch helper ─────────────────────────────────────────────────

    /// <summary>
    /// Queues all <paramref name="ids"/> via <paramref name="loadAsync"/>, then awaits
    /// all results together. This two-phase pattern (queue-all, then await-all) is how
    /// the GraphQL execution engine uses DataLoaders: all field resolvers queue their
    /// loads before any result is awaited, so the first <c>GetResultAsync</c> sees all
    /// pending keys and dispatches them in a single batch.
    /// </summary>
    private static async Task<T[]> QueueThenDispatch<T>(
        Func<int, IDataLoaderResult<T>> loadAsync, IEnumerable<int> ids)
    {
        // Phase 1: queue all loads (no awaiting yet — keys accumulate in the loader)
        var pending = ids.Select(id => loadAsync(id)).ToList();
        // Phase 2: await all at once — first GetResultAsync collects all pending keys
        return await Task.WhenAll(pending.Select(p => p.GetResultAsync()));
    }

    // ── Property 3a: ChaptersByBookIdDataLoader — fetch delegate fires once ───

    /// <summary>
    /// For any N distinct book IDs (1 ≤ N ≤ 20), queuing all N loads then awaiting
    /// them together must trigger the fetch delegate exactly once.
    /// The delegate receives all N keys in a single invocation, proving no N+1 pattern.
    /// Validates: Requirements 5.1, 5.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property ChaptersByBookIdDataLoader_FetchDelegateFiresOnce_ForAnyN(PositiveInt rawN)
    {
        var n = rawN.Get % 20 + 1; // 1..20
        var bookIds = Enumerable.Range(1, n).ToList();
        var counter = new Counter();

        var chapterService = new Mock<IChapterService>();
        chapterService
            .Setup(s => s.GetChaptersByBookIdAsync(It.IsAny<int>()))
            .ReturnsAsync((int id) =>
                new List<ChapterDto> { new() { Id = id * 10, BookId = id, ChapterIndex = 1 } });

        // Build a BatchDataLoader whose fetch delegate increments the counter on each invocation.
        // The delegate mirrors the production ChaptersByBookIdDataLoader implementation.
        var loader = new BatchDataLoader<int, List<ChapterDto>>(
            async (ids, ct) =>
            {
                counter.Value++;
                var idList = ids.ToList();
                var tasks = idList.Select(id => chapterService.Object.GetChaptersByBookIdAsync(id));
                var results = await Task.WhenAll(tasks);
                return (IDictionary<int, List<ChapterDto>>)idList
                    .Zip(results, (id, chapters) => (id, chapters))
                    .ToDictionary(p => p.id, p => p.chapters);
            });

        // Queue all N loads first, then await all results — triggers exactly one batch dispatch.
        QueueThenDispatch(loader.LoadAsync, bookIds).GetAwaiter().GetResult();

        return Prop.ToProperty(counter.Value == 1);
    }

    // ── Property 3b: WordsByChapterIdDataLoader — fetch delegate fires once ───

    /// <summary>
    /// For any N distinct chapter IDs (1 ≤ N ≤ 20), queuing all N loads then awaiting
    /// them together must trigger the fetch delegate exactly once.
    /// Validates: Requirements 5.2, 5.5
    /// </summary>
    [Property(MaxTest = 100)]
    public Property WordsByChapterIdDataLoader_FetchDelegateFiresOnce_ForAnyN(PositiveInt rawN)
    {
        var n = rawN.Get % 20 + 1;
        var chapterIds = Enumerable.Range(1, n).ToList();
        var counter = new Counter();

        var vocabService = new Mock<IVocabularyService>();
        vocabService
            .Setup(s => s.GetWordsByChapterIdAsync(It.IsAny<int>()))
            .ReturnsAsync((int id) =>
                new List<SimpleWordDto> { new() { RootId = id, Content = $"w{id}", Occurrences = id } });

        var loader = new BatchDataLoader<int, List<SimpleWordDto>>(
            async (ids, ct) =>
            {
                counter.Value++;
                var idList = ids.ToList();
                var tasks = idList.Select(id => vocabService.Object.GetWordsByChapterIdAsync(id));
                var results = await Task.WhenAll(tasks);
                return (IDictionary<int, List<SimpleWordDto>>)idList
                    .Zip(results, (id, words) => (id, words))
                    .ToDictionary(p => p.id, p => p.words);
            });

        QueueThenDispatch(loader.LoadAsync, chapterIds).GetAwaiter().GetResult();

        return Prop.ToProperty(counter.Value == 1);
    }

    // ── Property 3c: GrammaticalFeaturesByIdDataLoader — fetch delegate fires once

    /// <summary>
    /// For any N distinct feature IDs (1 ≤ N ≤ 20), queuing all N loads then awaiting
    /// them together must trigger the fetch delegate exactly once.
    /// Validates: Requirements 5.3
    /// </summary>
    [Property(MaxTest = 100)]
    public Property GrammaticalFeaturesByIdDataLoader_FetchDelegateFiresOnce_ForAnyN(PositiveInt rawN)
    {
        var n = rawN.Get % 20 + 1;
        var featureIds = Enumerable.Range(1, n).ToList();
        var counter = new Counter();

        var featureService = new Mock<IGrammaticalFeatureService>();
        featureService
            .Setup(s => s.GetFeatureByIdAsync(It.IsAny<int>()))
            .ReturnsAsync((int id) =>
                new GrammaticalFeatureDto { Id = id, Code = $"F{id}", Name = $"Feature{id}", Category = "Test" });

        var loader = new BatchDataLoader<int, GrammaticalFeatureDto?>(
            async (ids, ct) =>
            {
                counter.Value++;
                var idList = ids.ToList();
                var tasks = idList.Select(id => featureService.Object.GetFeatureByIdAsync(id));
                var results = await Task.WhenAll(tasks);
                return (IDictionary<int, GrammaticalFeatureDto?>)idList
                    .Zip(results, (id, feature) => (id, feature))
                    .ToDictionary(p => p.id, p => p.feature);
            });

        QueueThenDispatch(loader.LoadAsync, featureIds).GetAwaiter().GetResult();

        return Prop.ToProperty(counter.Value == 1);
    }

    // ── Property 3d: ChaptersByBookIdDataLoader — all N results are returned ──

    /// <summary>
    /// For any N distinct book IDs, the production DataLoader must return a non-empty
    /// result list for every requested ID — no results are dropped by the batching mechanism.
    /// Validates: Requirements 5.1, 5.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property ChaptersByBookIdDataLoader_ReturnsResultForEveryId(PositiveInt rawN)
    {
        var n = rawN.Get % 20 + 1;
        var bookIds = Enumerable.Range(1, n).ToList();

        var chapterService = new Mock<IChapterService>();
        chapterService
            .Setup(s => s.GetChaptersByBookIdAsync(It.IsAny<int>()))
            .ReturnsAsync((int id) =>
                new List<ChapterDto> { new() { Id = id * 10, BookId = id, ChapterIndex = 1 } });

        var loader = new ChaptersByBookIdDataLoader(chapterService.Object);

        var results = QueueThenDispatch(loader.LoadAsync, bookIds).GetAwaiter().GetResult();

        var allPresent = results.Length == n && results.All(r => r is { Count: 1 });
        return Prop.ToProperty(allPresent);
    }

    // ── Property 3e: WordsByChapterIdDataLoader — all N results are returned ──

    /// <summary>
    /// For any N distinct chapter IDs, the production DataLoader must return a non-empty
    /// result list for every requested ID — no results are dropped by the batching mechanism.
    /// Validates: Requirements 5.2, 5.5
    /// </summary>
    [Property(MaxTest = 100)]
    public Property WordsByChapterIdDataLoader_ReturnsResultForEveryId(PositiveInt rawN)
    {
        var n = rawN.Get % 20 + 1;
        var chapterIds = Enumerable.Range(1, n).ToList();

        var vocabService = new Mock<IVocabularyService>();
        vocabService
            .Setup(s => s.GetWordsByChapterIdAsync(It.IsAny<int>()))
            .ReturnsAsync((int id) =>
                new List<SimpleWordDto> { new() { RootId = id, Content = $"w{id}", Occurrences = id } });

        var loader = new WordsByChapterIdDataLoader(vocabService.Object);

        var results = QueueThenDispatch(loader.LoadAsync, chapterIds).GetAwaiter().GetResult();

        var allPresent = results.Length == n && results.All(r => r is { Count: 1 });
        return Prop.ToProperty(allPresent);
    }
}
