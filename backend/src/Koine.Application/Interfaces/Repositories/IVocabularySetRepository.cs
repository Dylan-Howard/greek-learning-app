using Koine.Domain.Entities;

namespace Koine.Application.Interfaces.Repositories
{
    public interface IVocabularySetRepository : IRepository<VocabularySet>
    {
        Task<List<VocabularySet>> GetVisibleToUserAsync(int userId);
        Task<VocabularySet?> GetByIdWithItemsAsync(int setId);
        Task<VocabularySet?> GetBySlugAsync(string slug);
        Task<List<VocabularySet>> GetSystemSetsAsync();
    }
}
