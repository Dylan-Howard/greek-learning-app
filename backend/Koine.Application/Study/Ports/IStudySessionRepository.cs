// Koine.Application/Study/Ports/IStudySessionRepository.cs
using Koine.Domain.Entities;

namespace Koine.Application.Study.Ports
{
    public interface IStudySessionRepository
    {
        Task<StudySession?> GetByIdAsync(Guid id, CancellationToken ct);
        Task SaveAsync(StudySession session, CancellationToken ct);
        Task<List<ReviewHistoryPoint>> GetReviewHistoryAsync(int userId, int days, CancellationToken ct);
    }
}
