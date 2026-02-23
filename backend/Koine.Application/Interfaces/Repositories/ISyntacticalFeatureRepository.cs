using Koine.Domain.Entities;

namespace Koine.Application.Interfaces.Repositories
{
    public interface ISyntacticalFeatureRepository : IRepository<SyntacticalFeature>
    {
        Task<SyntacticalFeature?> GetByCodeAsync(string code);
        Task<List<SyntacticalFeature>> GetByIdsAsync(List<int> ids);
    }
}