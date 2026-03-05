using Koine.Domain.Entities;

// Koine.Application/Interfaces/Repositories/IVocabularyRepository.cs
namespace Koine.Application.Interfaces.Repositories
{
    public interface IVocabularyRepository : IRepository<Vocabulary>
    {
        Task<List<Vocabulary>> GetByIdsAsync(List<int> ids);
        Task<List<Vocabulary>> GetByOccurrencesAsync(int minOccurrences, int maxOccurrences);
    }
}
