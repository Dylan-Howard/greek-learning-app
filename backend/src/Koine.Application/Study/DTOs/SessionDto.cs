// Koine.Application/Study/DTOs/SessionDto.cs
using System.Text.Json.Serialization;
using Koine.Domain.Entities;
using Koine.Domain.ValueObjects;

namespace Koine.Application.Study.DTOs
{
    public record SessionDto
    {
        public Guid Id { get; init; }

        public int TotalCards { get; init; }

        public int CardsReviewed { get; init; }

        public DateTime StartedAt { get; init; }

        public DateTime? CompletedAt { get; init; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CardPool Pool { get; init; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public StudyDirection Direction { get; init; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public InteractionMode Mode { get; init; }

        public int? VocabularySetId { get; init; }
    }
}
