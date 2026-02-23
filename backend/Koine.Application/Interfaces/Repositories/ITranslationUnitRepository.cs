using Koine.Domain.Entities;

// Koine.Application/Interfaces/Repositories/ITranslationUnitRepository.cs
namespace Koine.Application.Interfaces.Repositories
{
    public interface ITranslationUnitRepository : IRepository<TranslationUnit>
    {
        Task<List<TranslationUnit>> GetByChapterAndTranslationAsync(int chapterId, int translationId);
    }
}
