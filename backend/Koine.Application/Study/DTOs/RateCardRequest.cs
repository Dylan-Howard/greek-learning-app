// Koine.Application/Study/DTOs/RateCardRequest.cs
using System.Text.Json.Serialization;
using Koine.Domain.Entities;

namespace Koine.Application.Study.DTOs
{
    public record RateCardRequest
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Rating Rating { get; init; }
    }
}
