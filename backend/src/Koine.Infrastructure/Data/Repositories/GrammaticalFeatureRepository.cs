using Microsoft.EntityFrameworkCore;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories
{
    public class GrammaticalFeatureRepository : Repository<GrammaticalFeature>, IGrammaticalFeatureRepository
    {
        public GrammaticalFeatureRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<GrammaticalFeature?> GetByCodeAsync(string code)
        {
            return await _dbSet
                .FirstOrDefaultAsync(f => f.Code == code);
        }

        public async Task<List<GrammaticalFeature>> GetByIdsAsync(List<int> ids)
        {
            return await _dbSet
                .Where(f => ids.Contains(f.Id))
                .ToListAsync();
        }
    }
}
