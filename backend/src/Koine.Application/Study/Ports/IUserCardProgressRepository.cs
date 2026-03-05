// Koine.Application/Study/Ports/IUserCardProgressRepository.cs
using Koine.Domain.Entities;

namespace Koine.Application.Study.Ports
{
    public record DashboardStatsData(
        int TotalCards,
        int DueToday,
        int NewCards,
        int LearningCards,
        int ReviewCards,
        int RelearningCards,
        int CurrentStreak
    );

    public record ReviewHistoryPoint(DateOnly Date, int Count);

    public interface IUserCardProgressRepository
    {
        Task<List<UserCardProgress>> GetDueCardsAsync(
            int userId,
            int limit,
            IEnumerable<int>? vocabularyIds,
            CancellationToken ct);

        Task<List<UserCardProgress>> GetNewCardsAsync(
            int userId,
            int limit,
            IEnumerable<int>? vocabularyIds,
            CancellationToken ct);

        Task<UserCardProgress?> GetByVocabularyIdAsync(int userId, int vocabularyId, CancellationToken ct);

        Task<List<UserCardProgress>> GetAllForUserAsync(int userId, CancellationToken ct);

        Task UpsertAsync(UserCardProgress progress, CancellationToken ct);

        Task<DashboardStatsData> GetDashboardStatsAsync(int userId, CancellationToken ct);
    }
}
