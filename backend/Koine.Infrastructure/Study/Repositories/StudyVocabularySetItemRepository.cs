// Koine.Infrastructure/Study/Repositories/StudyVocabularySetItemRepository.cs
using Koine.Application.Study.Ports;
using Koine.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Koine.Infrastructure.Study.Repositories
{
    public class StudyVocabularySetItemRepository : IVocabularySetItemRepository
    {
        private readonly KoineDbContext _context;

        public StudyVocabularySetItemRepository(KoineDbContext context)
        {
            _context = context;
        }

        public async Task<List<int>> GetVocabularyIdsForSetAsync(int setId, CancellationToken ct)
        {
            return await _context.VocabularySetItems
                .AsNoTracking()
                .Where(i => i.VocabularySetId == setId)
                .Select(i => i.VocabularyId)
                .ToListAsync(ct);
        }
    }
}
