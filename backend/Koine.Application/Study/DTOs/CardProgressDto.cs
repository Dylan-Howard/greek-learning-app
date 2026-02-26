// Koine.Application/Study/DTOs/CardProgressDto.cs
using System.Text.Json.Serialization;
using Koine.Domain.Entities;

namespace Koine.Application.Study.DTOs
{
    public record CardProgressDto
    {
        public int VocabularyId { get; init; }
        public string Root { get; init; } = string.Empty;
        public string Gloss { get; init; } = string.Empty;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CardState State { get; init; }

        public float Difficulty { get; init; }
        public float Stability { get; init; }
        public DateTime NextReviewDate { get; init; }
        public int ReviewCount { get; init; }
        public int Lapses { get; init; }
    }
}
