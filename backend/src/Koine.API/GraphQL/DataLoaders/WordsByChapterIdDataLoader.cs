using GraphQL.DataLoader;
using Koine.Application.DTOs.Vocabulary;
using Koine.Application.Interfaces;

namespace Koine.API.GraphQL.DataLoaders;

/// <summary>
/// Batches word lookups by chapter ID to prevent N+1 queries when resolving
/// <c>Chapter.words</c> for a list of chapters within a single GraphQL request.
/// Requirements: 5.2, 5.5
/// </summary>
public class WordsByChapterIdDataLoader
{
    private readonly BatchDataLoader<int, List<SimpleWordDto>> _loader;

    /// <inheritdoc cref="WordsByChapterIdDataLoader"/>
    public WordsByChapterIdDataLoader(IVocabularyService vocabularyService)
    {
        _loader = new BatchDataLoader<int, List<SimpleWordDto>>(
            async (chapterIds, ct) =>
            {
                var ids = chapterIds.ToList();
                var tasks = ids.Select(id => vocabularyService.GetWordsByChapterIdAsync(id));
                var results = await Task.WhenAll(tasks);
                return (IDictionary<int, List<SimpleWordDto>>)ids
                    .Zip(results, (id, words) => (id, words))
                    .ToDictionary(p => p.id, p => p.words);
            });
    }

    /// <summary>Loads words for the given <paramref name="chapterId"/>, batched with other in-flight loads.</summary>
    public IDataLoaderResult<List<SimpleWordDto>> LoadAsync(int chapterId)
        => _loader.LoadAsync(chapterId);
}
