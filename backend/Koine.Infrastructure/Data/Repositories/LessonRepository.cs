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
                .OrderBy(l => l.LessonIndex)
                .ToListAsync();
        }

        public async Task<List<Lesson>> GetByTypeAsync(string lessonType)
        {
            return await _dbSet
                .Where(l => l.LessonType == lessonType)
                .OrderBy(l => l.LessonIndex)
                .ToListAsync();
        }
    }
}
