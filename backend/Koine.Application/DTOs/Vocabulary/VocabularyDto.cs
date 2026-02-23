// Koine.Application/DTOs/Vocabulary/VocabularyDto.cs
namespace Koine.Application.DTOs.Vocabulary
{
    public class VocabularyDto
    {
        public int Id { get; set; }
        public string Root { get; set; } = string.Empty;
        public string? Transliteration { get; set; }
        public string Gloss { get; set; } = string.Empty;
        public string? PartOfSpeech { get; set; }
        public int? FrequencyRank { get; set; }
    }
}
