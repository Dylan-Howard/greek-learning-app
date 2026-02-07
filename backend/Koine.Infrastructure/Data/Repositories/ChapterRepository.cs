// GreekParser.Infrastructure/Data/Repositories/ChapterRepository.cs
using Microsoft.EntityFrameworkCore;
using GreekParser.Application.Interfaces.Repositories;
using GreekParser.Domain.Entities;
using GreekParser.Infrastructure.Data.Context;

namespace GreekParser.Infrastructure.Data.Repositories
{
    public class ChapterRepository : Repository<Chapter>, IChapterRepository
    {
        public ChapterRepository(GreekParserDbContext context) : base(context)
        {
        }

        public async Task<Chapter?> GetByBookAndIndexAsync(int bookId, int chapterIndex)
        {
            return await _dbSet
                .FirstOrDefaultAsync(c => c.BookId == bookId && c.ChapterIndex == chapterIndex);
        }

        public async Task<List<Chapter>> GetByBookIdAsync(int bookId)
        {
            return await _dbSet
                .Where(c => c.BookId == bookId)
                .OrderBy(c => c.ChapterIndex)
                .ToListAsync();
        }
    }
}
