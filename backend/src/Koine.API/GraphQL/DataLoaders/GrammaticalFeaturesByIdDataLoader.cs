using GraphQL.DataLoader;
using Koine.Application.DTOs.Features;
using Koine.Application.Interfaces;

namespace Koine.API.GraphQL.DataLoaders;

/// <summary>
/// Batches grammatical feature lookups by ID to prevent N+1 queries when resolving
/// feature data for multiple words within a single GraphQL request.
/// Requirements: 5.3, 5.6
/// </summary>
public class GrammaticalFeaturesByIdDataLoader
{
    private readonly BatchDataLoader<int, GrammaticalFeatureDto?> _loader;

    /// <inheritdoc cref="GrammaticalFeaturesByIdDataLoader"/>
    public GrammaticalFeaturesByIdDataLoader(IGrammaticalFeatureService featureService)
    {
        _loader = new BatchDataLoader<int, GrammaticalFeatureDto?>(
            async (featureIds, ct) =>
            {
                var ids = featureIds.ToList();
                var tasks = ids.Select(id => featureService.GetFeatureByIdAsync(id));
                var results = await Task.WhenAll(tasks);
                // Missing IDs map to null so callers can handle not-found gracefully.
                return (IDictionary<int, GrammaticalFeatureDto?>)ids
                    .Zip(results, (id, feature) => (id, feature))
                    .ToDictionary(p => p.id, p => p.feature);
            });
    }

    /// <summary>Loads a grammatical feature by <paramref name="featureId"/>, batched with other in-flight loads.</summary>
    public IDataLoaderResult<GrammaticalFeatureDto?> LoadAsync(int featureId)
        => _loader.LoadAsync(featureId);
}
