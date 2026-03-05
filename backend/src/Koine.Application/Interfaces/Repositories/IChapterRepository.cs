using Koine.Domain.Entities;

// Koine.Application/Interfaces/Repositories/IChapterRepository.cs
namespace Koine.Application.Interfaces.Repositories
{
    public interface IChapterRepository : IRepository<Chapter>
    {
        Task<Chapter?> GetByBookAndIndexAsync(int bookId, int chapterIndex);
        Task<List<Chapter>> GetByBookIdAsync(int bookId);
    }
}
