using Microsoft.EntityFrameworkCore;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories
{
    public class LessonRepository : Repository<Lesson>, ILessonRepository
    {
        public LessonRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<List<Lesson>> GetAllOrderedAsync()
        {
            return await _dbSet
                .Include(l => l.Track)
                .OrderBy(l => l.TrackId)
                .ThenBy(l => l.LessonIndex)
                .ToListAsync();
        }

        public async Task<List<Lesson>> GetByTrackIdAsync(int trackId)
        {
            return await _dbSet
                .Include(l => l.Track)
                .Where(l => l.TrackId == trackId)
                .OrderBy(l => l.LessonIndex)
                .ToListAsync();
        }

        public async Task<List<Lesson>> GetByTypeAsync(string lessonType)
        {
            return await _dbSet
                .Include(l => l.Track)
                .Where(l => l.LessonType == lessonType)
                .OrderBy(l => l.LessonIndex)
                .ToListAsync();
        }
    }
}
