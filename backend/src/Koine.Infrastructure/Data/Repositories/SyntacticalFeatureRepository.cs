using Microsoft.EntityFrameworkCore;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories
{
    public class SyntacticalFeatureRepository : Repository<SyntacticalFeature>, ISyntacticalFeatureRepository
    {
        public SyntacticalFeatureRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<SyntacticalFeature?> GetByCodeAsync(string code)
        {
            return await _dbSet
                .FirstOrDefaultAsync(f => f.Code == code);
        }

        public async Task<List<SyntacticalFeature>> GetByIdsAsync(List<int> ids)
        {
            return await _dbSet
                .Where(f => ids.Contains(f.Id))
                .ToListAsync();
        }
    }
}
