// Koine.Infrastructure/Study/Repositories/StudyVocabularyRepository.cs
using Koine.Application.Study.Ports;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Koine.Infrastructure.Study.Repositories
{
    public class StudyVocabularyRepository : IVocabularyRepository
    {
        private readonly KoineDbContext _context;

        public StudyVocabularyRepository(KoineDbContext context)
        {
            _context = context;
        }

        public async Task<List<Vocabulary>> GetByIdsAsync(IEnumerable<int> ids, CancellationToken ct)
        {
            var list = ids.ToList();
            return await _context.Vocabularies
                .AsNoTracking()
                .Where(v => list.Contains(v.Id))
                .ToListAsync(ct);
        }

        public async Task<List<Vocabulary>> GetRandomSampleAsync(int count, CancellationToken ct)
        {
            return await _context.Vocabularies
                .AsNoTracking()
                .OrderBy(v => Guid.NewGuid())
                .Take(count)
                .ToListAsync(ct);
        }
    }
}
