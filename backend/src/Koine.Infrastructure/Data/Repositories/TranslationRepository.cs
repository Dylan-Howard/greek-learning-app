using Microsoft.EntityFrameworkCore;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories
{
    public class TranslationRepository : Repository<Translation>, ITranslationRepository
    {
        public TranslationRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<Translation?> GetByBookAndLanguageAsync(int bookId, string languageCode)
        {
            return await _dbSet
                .FirstOrDefaultAsync(t => t.BookId == bookId && t.LanguageCode == languageCode);
        }
    }
}
