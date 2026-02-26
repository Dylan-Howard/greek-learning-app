// Koine.Application/Study/DTOs/CardDto.cs
using System.Text.Json.Serialization;
using Koine.Domain.Entities;
using Koine.Domain.ValueObjects;

namespace Koine.Application.Study.DTOs
{
    public record CardDto
    {
        public int SessionCardId { get; init; }
        public int VocabularyId { get; init; }
        public int Position { get; init; }
        public int TotalCards { get; init; }

        public CardFront Front { get; init; } = new();
        public CardBack Back { get; init; } = new();

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public InteractionMode InteractionMode { get; init; }

        public string[]? Choices { get; init; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public StudyDirection Direction { get; init; }

        public record CardFront
        {
            public string Root { get; init; } = string.Empty;
            public string? Transliteration { get; init; }
            public string? PartOfSpeech { get; init; }
            public int? Occurrences { get; init; }
        }

        public record CardBack
        {
            public string Gloss { get; init; } = string.Empty;
        }
    }
}
