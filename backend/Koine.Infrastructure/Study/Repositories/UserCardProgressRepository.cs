// Koine.Infrastructure/Study/Repositories/UserCardProgressRepository.cs
using Koine.Application.Study.Ports;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Koine.Infrastructure.Study.Repositories
{
    public class UserCardProgressRepository : IUserCardProgressRepository
    {
        private readonly KoineDbContext _context;

        public UserCardProgressRepository(KoineDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserCardProgress>> GetDueCardsAsync(
            int userId,
            int limit,
            IEnumerable<int>? vocabularyIds,
            CancellationToken ct)
        {
            var query = _context.UserCardProgresses
                .AsNoTracking()
                .Include(p => p.Vocabulary)
                .Where(p => p.UserId == userId && p.NextReviewDate <= DateTime.UtcNow);

            if (vocabularyIds != null)
            {
                var ids = vocabularyIds.ToList();
                query = query.Where(p => ids.Contains(p.VocabularyId));
            }

            return await query
                .OrderBy(p => p.NextReviewDate)
                .Take(limit)
                .ToListAsync(ct);
        }

        public async Task<List<UserCardProgress>> GetNewCardsAsync(
            int userId,
            int limit,
            IEnumerable<int>? vocabularyIds,
            CancellationToken ct)
        {
            var existing = _context.UserCardProgresses
                .AsNoTracking()
                .Where(p => p.UserId == userId);

            var vocabQuery = _context.Vocabularies.AsNoTracking();

            if (vocabularyIds != null)
            {
                var ids = vocabularyIds.ToList();
                vocabQuery = vocabQuery.Where(v => ids.Contains(v.Id));
            }

            var newVocab = await vocabQuery
                .Where(v => !existing.Any(p => p.VocabularyId == v.Id))
                .OrderBy(v => v.Id)
                .Take(limit)
                .ToListAsync(ct);

            var now = DateTime.UtcNow;
            return newVocab.Select(v => new UserCardProgress
            {
                UserId = userId,
                VocabularyId = v.Id,
                Vocabulary = v,
                Stability = 0f,
                Difficulty = 5f,
                ElapsedDays = 0f,
                ScheduledDays = 0f,
                ReviewCount = 0,
                Lapses = 0,
                State = CardState.New,
                LastReviewDate = null,
                NextReviewDate = now
            }).ToList();
        }

        public async Task<UserCardProgress?> GetByVocabularyIdAsync(int userId, int vocabularyId, CancellationToken ct)
        {
            return await _context.UserCardProgresses
                .Include(p => p.Vocabulary)
                .FirstOrDefaultAsync(p => p.UserId == userId && p.VocabularyId == vocabularyId, ct);
        }

        public async Task<List<UserCardProgress>> GetAllForUserAsync(int userId, CancellationToken ct)
        {
            return await _context.UserCardProgresses
                .AsNoTracking()
                .Where(p => p.UserId == userId)
                .ToListAsync(ct);
        }

        public async Task UpsertAsync(UserCardProgress progress, CancellationToken ct)
        {
            var existing = await _context.UserCardProgresses
                .FirstOrDefaultAsync(p => p.UserId == progress.UserId && p.VocabularyId == progress.VocabularyId, ct);

            if (existing == null)
            {
                await _context.UserCardProgresses.AddAsync(progress, ct);
            }
            else
            {
                existing.Stability = progress.Stability;
                existing.Difficulty = progress.Difficulty;
                existing.ElapsedDays = progress.ElapsedDays;
                existing.ScheduledDays = progress.ScheduledDays;
                existing.ReviewCount = progress.ReviewCount;
                existing.Lapses = progress.Lapses;
                existing.State = progress.State;
                existing.LastReviewDate = progress.LastReviewDate;
                existing.NextReviewDate = progress.NextReviewDate;
            }

            await _context.SaveChangesAsync(ct);
        }

        public async Task<DashboardStatsData> GetDashboardStatsAsync(int userId, CancellationToken ct)
        {
            var now = DateTime.UtcNow.Date;

            var totalVocab = await _context.Vocabularies.CountAsync(ct);
            var totalProgress = await _context.UserCardProgresses.CountAsync(p => p.UserId == userId, ct);
            var dueToday = await _context.UserCardProgresses
                .CountAsync(p => p.UserId == userId && p.NextReviewDate.Date <= now, ct);

            var newCards = Math.Max(totalVocab - totalProgress, 0);
            var learning = await _context.UserCardProgresses
                .CountAsync(p => p.UserId == userId && p.State == CardState.Learning, ct);
            var review = await _context.UserCardProgresses
                .CountAsync(p => p.UserId == userId && p.State == CardState.Review, ct);
            var relearning = await _context.UserCardProgresses
                .CountAsync(p => p.UserId == userId && p.State == CardState.Relearning, ct);

            var reviewedDates = await _context.SessionCards
                .AsNoTracking()
                .Where(c => c.ReviewedAt != null)
                .Join(_context.StudySessions.AsNoTracking(),
                    c => c.SessionId,
                    s => s.Id,
                    (c, s) => new { c, s })
                .Where(x => x.s.UserId == userId)
                .Select(x => x.c.ReviewedAt!.Value.Date)
                .Distinct()
                .ToListAsync(ct);

            var streak = 0;
            var cursor = now;
            while (reviewedDates.Contains(cursor))
            {
                streak += 1;
                cursor = cursor.AddDays(-1);
            }

            return new DashboardStatsData(
                totalVocab,
                dueToday,
                newCards,
                learning,
                review,
                relearning,
                streak
            );
        }
    }
}
