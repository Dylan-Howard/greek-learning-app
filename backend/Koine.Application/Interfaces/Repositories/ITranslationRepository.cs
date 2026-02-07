// GreekParser.Application/Interfaces/Repositories/ITranslationRepository.cs
namespace GreekParser.Application.Interfaces.Repositories
{
    public interface ITranslationRepository : IRepository<Translation>
    {
        Task<Translation?> GetByBookAndLanguageAsync(int bookId, string languageCode);
    }
}
