// GreekParser.Application/Interfaces/Repositories/IVocabularyRepository.cs
namespace GreekParser.Application.Interfaces.Repositories
{
    public interface IVocabularyRepository : IRepository<Vocabulary>
    {
        Task<List<Vocabulary>> GetByIdsAsync(List<int> ids);
        Task<List<Vocabulary>> GetByFrequencyRankAsync(int minRank, int maxRank);
    }
}
