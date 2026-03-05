// Koine.Infrastructure/Study/Repositories/StudySessionRepository.cs
using Koine.Application.Study.Ports;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Koine.Infrastructure.Study.Repositories
{
    public class StudySessionRepository : IStudySessionRepository
    {
        private readonly KoineDbContext _context;

        public StudySessionRepository(KoineDbContext context)
        {
            _context = context;
        }

        public async Task<StudySession?> GetByIdAsync(Guid id, CancellationToken ct)
        {
            return await _context.StudySessions
                .Include(s => s.Cards)
                .FirstOrDefaultAsync(s => s.Id == id, ct);
        }

        public async Task SaveAsync(StudySession session, CancellationToken ct)
        {
            var exists = await _context.StudySessions.AnyAsync(s => s.Id == session.Id, ct);
            if (!exists)
            {
                await _context.StudySessions.AddAsync(session, ct);
            }
            else
            {
                _context.StudySessions.Update(session);
            }

            await _context.SaveChangesAsync(ct);
        }

        public async Task<List<ReviewHistoryPoint>> GetReviewHistoryAsync(int userId, int days, CancellationToken ct)
        {
            var startDate = DateTime.UtcNow.Date.AddDays(-days + 1);

            var points = await _context.SessionCards
                .AsNoTracking()
                .Where(c => c.ReviewedAt != null)
                .Join(_context.StudySessions.AsNoTracking(),
                    c => c.SessionId,
                    s => s.Id,
                    (c, s) => new { c, s })
                .Where(x => x.s.UserId == userId && x.c.ReviewedAt!.Value.Date >= startDate)
                .GroupBy(x => x.c.ReviewedAt!.Value.Date)
                .Select(g => new ReviewHistoryPoint(DateOnly.FromDateTime(g.Key), g.Count()))
                .ToListAsync(ct);

            var byDate = points.ToDictionary(p => p.Date);
            var results = new List<ReviewHistoryPoint>();
            for (var i = 0; i < days; i++)
            {
                var date = DateOnly.FromDateTime(startDate.AddDays(i));
                results.Add(byDate.TryGetValue(date, out var point)
                    ? point
                    : new ReviewHistoryPoint(date, 0));
            }

            return results;
        }
    }
}
