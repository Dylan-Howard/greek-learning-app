// GreekParser.Application/Interfaces/Repositories/ITranslationUnitRepository.cs
namespace GreekParser.Application.Interfaces.Repositories
{
    public interface ITranslationUnitRepository : IRepository<TranslationUnit>
    {
        Task<List<TranslationUnit>> GetByChapterAndTranslationAsync(int chapterId, int translationId);
    }
}
