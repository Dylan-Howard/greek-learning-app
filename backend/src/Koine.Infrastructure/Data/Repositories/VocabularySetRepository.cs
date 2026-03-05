using Microsoft.EntityFrameworkCore;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories
{
    public class VocabularySetRepository : Repository<VocabularySet>, IVocabularySetRepository
    {
        public VocabularySetRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<List<VocabularySet>> GetVisibleToUserAsync(int userId)
        {
            return await _dbSet
                .Include(vs => vs.Items)
                .Where(vs => vs.IsSystem || vs.OwnerUserId == userId)
                .OrderByDescending(vs => vs.IsSystem)
                .ThenBy(vs => vs.Title)
                .ToListAsync();
        }

        public async Task<VocabularySet?> GetByIdWithItemsAsync(int setId)
        {
            return await _dbSet
                .Include(vs => vs.Items)
                .ThenInclude(i => i.Vocabulary)
                .FirstOrDefaultAsync(vs => vs.Id == setId);
        }

        public async Task<VocabularySet?> GetBySlugAsync(string slug)
        {
            return await _dbSet
                .Include(vs => vs.Items)
                .FirstOrDefaultAsync(vs => vs.Slug == slug);
        }

        public async Task<List<VocabularySet>> GetSystemSetsAsync()
        {
            return await _dbSet
                .Where(vs => vs.IsSystem)
                .Include(vs => vs.Items)
                .ToListAsync();
        }
    }
}
