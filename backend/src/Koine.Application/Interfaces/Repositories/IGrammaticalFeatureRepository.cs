using Koine.Domain.Entities;

// Koine.Application/Interfaces/Repositories/IGrammaticalFeatureRepository.cs
namespace Koine.Application.Interfaces.Repositories
{
    public interface IGrammaticalFeatureRepository : IRepository<GrammaticalFeature>
    {
        Task<GrammaticalFeature?> GetByCodeAsync(string code);
        Task<List<GrammaticalFeature>> GetByIdsAsync(List<int> ids);
    }
}
