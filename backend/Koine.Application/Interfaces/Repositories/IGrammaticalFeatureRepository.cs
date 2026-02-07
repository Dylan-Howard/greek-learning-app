// GreekParser.Application/Interfaces/Repositories/IGrammaticalFeatureRepository.cs
namespace GreekParser.Application.Interfaces.Repositories
{
    public interface IGrammaticalFeatureRepository : IRepository<GrammaticalFeature>
    {
        Task<GrammaticalFeature?> GetByCodeAsync(string code);
        Task<List<GrammaticalFeature>> GetByIdsAsync(List<int> ids);
    }
}
