using Microsoft.EntityFrameworkCore;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories
{
    public class VocabularyRepository : Repository<Vocabulary>, IVocabularyRepository
    {
        public VocabularyRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<List<Vocabulary>> GetByIdsAsync(List<int> ids)
        {
            return await _dbSet
                .Where(v => ids.Contains(v.Id))
                .ToListAsync();
        }

        public async Task<List<Vocabulary>> GetByFrequencyRankAsync(int minRank, int maxRank)
        {
            return await _dbSet
                .Where(v => v.FrequencyRank >= minRank && v.FrequencyRank <= maxRank)
                .OrderBy(v => v.FrequencyRank)
                .ToListAsync();
        }
    }
}
