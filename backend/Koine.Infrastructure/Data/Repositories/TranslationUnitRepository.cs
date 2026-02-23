using Microsoft.EntityFrameworkCore;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories
{
    public class TranslationUnitRepository : Repository<TranslationUnit>, ITranslationUnitRepository
    {
        public TranslationUnitRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<List<TranslationUnit>> GetByChapterAndTranslationAsync(int chapterId, int translationId)
        {
            return await _dbSet
                .Where(tu => tu.ChapterId == chapterId && tu.TranslationId == translationId)
                .OrderBy(tu => tu.DisplayOrder)
                .ToListAsync();
        }
    }
}
