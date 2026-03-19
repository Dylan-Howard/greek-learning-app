using GraphQL.DataLoader;
using Koine.Application.DTOs.Chapters;
using Koine.Application.Interfaces;

namespace Koine.API.GraphQL.DataLoaders;

/// <summary>
/// Batches chapter lookups by book ID to prevent N+1 queries when resolving
/// <c>Book.chapters</c> for a list of books within a single GraphQL request.
/// Requirements: 5.1, 5.4
/// </summary>
public class ChaptersByBookIdDataLoader
{
    private readonly BatchDataLoader<int, List<ChapterDto>> _loader;

    /// <inheritdoc cref="ChaptersByBookIdDataLoader"/>
    public ChaptersByBookIdDataLoader(IChapterService chapterService)
    {
        _loader = new BatchDataLoader<int, List<ChapterDto>>(
            async (bookIds, ct) =>
            {
                // Fan out concurrently — all IDs are collected before any call is made,
                // so round-trips equal distinct book IDs in the batch, not fields resolved.
                var ids = bookIds.ToList();
                var tasks = ids.Select(id => chapterService.GetChaptersByBookIdAsync(id));
                var results = await Task.WhenAll(tasks);
                return (IDictionary<int, List<ChapterDto>>)ids
                    .Zip(results, (id, chapters) => (id, chapters))
                    .ToDictionary(p => p.id, p => p.chapters);
            });
    }

    /// <summary>Loads chapters for the given <paramref name="bookId"/>, batched with other in-flight loads.</summary>
    public IDataLoaderResult<List<ChapterDto>> LoadAsync(int bookId)
        => _loader.LoadAsync(bookId);
}
