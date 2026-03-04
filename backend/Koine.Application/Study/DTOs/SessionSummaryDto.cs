// Koine.Application/Study/DTOs/SessionSummaryDto.cs
using System.Text.Json.Serialization;
using Koine.Domain.Entities;

namespace Koine.Application.Study.DTOs
{
    public record SessionSummaryDto
    {
        public int TotalReviewed { get; init; }
        public int CorrectCount { get; init; }
        public double CorrectPercentage { get; init; }
        public Dictionary<Rating, int> Ratings { get; init; } = new();
        public int XpGained { get; init; }
        public int TotalExperience { get; init; }
        public bool FirstCompletionReward { get; init; }
    }
}
