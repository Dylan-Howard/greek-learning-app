// Koine.Infrastructure/Data/Repositories/UserProgressRepository.cs
using Microsoft.EntityFrameworkCore;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories
{
    public class UserProgressRepository : Repository<UserProgress>, IUserProgressRepository
    {
        public UserProgressRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<UserProgress?> GetByUserIdAsync(int userId)
        {
            return await _dbSet
                .FirstOrDefaultAsync(up => up.UserId == userId);
        }

        public async Task<UserProgress> GetOrCreateByUserIdAsync(int userId)
        {
            var progress = await GetByUserIdAsync(userId);
            
            if (progress == null)
            {
                progress = new UserProgress
                {
                    UserId = userId,
                    CompletedLessonIdsJson = "[]",
                    GrammaticalFeatureProgressJson = "{}",
                    SyntacticalFeatureProgressJson = "{}",
                    VocabularyProgressJson = "{}",
                    UpdatedAt = DateTime.UtcNow
                };
                
                await AddAsync(progress);
                await _context.SaveChangesAsync();
            }
            
            return progress;
        }
    }
}
