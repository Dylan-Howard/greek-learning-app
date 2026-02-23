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

        public async Task<List<VocabularySet>> GetByUserIdAsync(int userId)
        {
            return await _dbSet
                .Where(vs => vs.UserId == userId)
                .ToListAsync();
        }

        public async Task<VocabularySet?> GetByIdWithItemsAsync(int setId)
        {
            return await _dbSet
                .Include(vs => vs.Items)
                .ThenInclude(i => i.Vocabulary)
                .FirstOrDefaultAsync(vs => vs.Id == setId);
        }
    }
}
