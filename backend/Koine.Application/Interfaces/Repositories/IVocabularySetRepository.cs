using Koine.Domain.Entities;

using Koine.Domain.Entities;

namespace Koine.Application.Interfaces.Repositories
{
    public interface IVocabularySetRepository : IRepository<VocabularySet>
    {
        Task<List<VocabularySet>> GetByUserIdAsync(int userId);
        Task<VocabularySet?> GetByIdWithItemsAsync(int setId);
    }
}
