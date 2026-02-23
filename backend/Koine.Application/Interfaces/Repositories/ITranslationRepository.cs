using Koine.Domain.Entities;

// Koine.Application/Interfaces/Repositories/ITranslationRepository.cs
namespace Koine.Application.Interfaces.Repositories
{
    public interface ITranslationRepository : IRepository<Translation>
    {
        Task<Translation?> GetByBookAndLanguageAsync(int bookId, string languageCode);
    }
}
