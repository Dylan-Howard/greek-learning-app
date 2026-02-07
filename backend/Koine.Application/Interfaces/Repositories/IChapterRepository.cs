// GreekParser.Application/Interfaces/Repositories/IChapterRepository.cs
namespace GreekParser.Application.Interfaces.Repositories
{
    public interface IChapterRepository : IRepository<Chapter>
    {
        Task<Chapter?> GetByBookAndIndexAsync(int bookId, int chapterIndex);
        Task<List<Chapter>> GetByBookIdAsync(int bookId);
    }
}
