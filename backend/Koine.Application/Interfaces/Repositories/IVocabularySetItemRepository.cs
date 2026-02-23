using Koine.Domain.Entities;

using Koine.Domain.Entities;

namespace Koine.Application.Interfaces.Repositories
{
    public interface IVocabularySetItemRepository : IRepository<VocabularySetItem>
    {
        Task<List<VocabularySetItem>> GetBySetIdAsync(int setId);
        Task<VocabularySetItem?> GetBySetAndVocabAsync(int setId, int vocabId);
    }
}
