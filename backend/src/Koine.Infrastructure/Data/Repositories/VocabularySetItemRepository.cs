using Microsoft.EntityFrameworkCore;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories
{
    public class VocabularySetItemRepository : Repository<VocabularySetItem>, IVocabularySetItemRepository
    {
        public VocabularySetItemRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<List<VocabularySetItem>> GetBySetIdAsync(int setId)
        {
            return await _dbSet
                .Where(i => i.VocabularySetId == setId)
                .Include(i => i.Vocabulary)
                .ToListAsync();
        }

        public async Task<VocabularySetItem?> GetBySetAndVocabAsync(int setId, int vocabId)
        {
            return await _dbSet
                .FirstOrDefaultAsync(i => i.VocabularySetId == setId && i.VocabularyId == vocabId);
        }
    }
}
