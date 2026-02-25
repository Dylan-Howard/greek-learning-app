using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Koine.Infrastructure.Data.Repositories
{
    public class LessonTrackRepository : Repository<LessonTrack>, ILessonTrackRepository
    {
        public LessonTrackRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<List<LessonTrack>> GetAllOrderedAsync()
        {
            return await _dbSet
                .OrderBy(t => t.SortOrder)
                .ThenBy(t => t.Title)
                .ToListAsync();
        }

        public async Task<LessonTrack?> GetBySlugAsync(string slug)
        {
            return await _dbSet.FirstOrDefaultAsync(t => t.Slug == slug);
        }
    }
}
