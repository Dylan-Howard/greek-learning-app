// Koine.Application/Study/DTOs/RateCardResponse.cs
using System.Text.Json.Serialization;
using Koine.Domain.Entities;

namespace Koine.Application.Study.DTOs
{
    public record RateCardResponse
    {
        public DateTime NextReviewDate { get; init; }
        public float ScheduledDays { get; init; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CardState NewState { get; init; }

        public bool SessionComplete { get; init; }
    }
}
