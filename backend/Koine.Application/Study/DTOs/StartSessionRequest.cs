// Koine.Application/Study/DTOs/StartSessionRequest.cs
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Koine.Domain.Entities;
using Koine.Domain.ValueObjects;

namespace Koine.Application.Study.DTOs
{
    public record StartSessionRequest
    {
        [Range(-1, 100)]
        public int CardCount { get; init; } = 10;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Required]
        public CardPool Pool { get; init; } = CardPool.Mixed;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Required]
        public StudyDirection Direction { get; init; } = StudyDirection.GreekToEnglish;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Required]
        public InteractionMode Mode { get; init; } = InteractionMode.Mix;

        public int? VocabularySetId { get; init; }
    }
}
