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

        public async Task<List<Vocabulary>> GetByOccurrencesAsync(int minOccurrences, int maxOccurrences)
        {
            return await _dbSet
                .Where(v => v.Occurrences >= minOccurrences && v.Occurrences <= maxOccurrences)
                .OrderBy(v => v.Occurrences)
                .ToListAsync();
        }
    }
}
