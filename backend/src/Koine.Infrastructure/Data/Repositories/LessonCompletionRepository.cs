using Microsoft.EntityFrameworkCore;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories
{
    public class LessonCompletionRepository : Repository<LessonCompletion>, ILessonCompletionRepository
    {
        public LessonCompletionRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<List<LessonCompletion>> GetByUserIdAsync(int userId)
        {
            return await _dbSet
                .Where(lc => lc.UserId == userId)
                .ToListAsync();
        }

        public async Task<LessonCompletion?> GetByUserAndLessonAsync(int userId, int lessonId)
        {
            return await _dbSet
                .FirstOrDefaultAsync(lc => lc.UserId == userId && lc.LessonId == lessonId);
        }
    }
}
