// Koine.Application/Study/DTOs/DashboardDto.cs
namespace Koine.Application.Study.DTOs
{
    public record DashboardDto
    {
        public int TotalCards { get; init; }
        public int DueToday { get; init; }
        public int NewCards { get; init; }
        public int LearningCards { get; init; }
        public int ReviewCards { get; init; }
        public int RelearningCards { get; init; }
        public int CurrentStreak { get; init; }
        public List<ReviewHistoryDto> ReviewHistory { get; init; } = new();
    }

    public record ReviewHistoryDto
    {
        public DateOnly Date { get; init; }
        public int Count { get; init; }
    }
}
