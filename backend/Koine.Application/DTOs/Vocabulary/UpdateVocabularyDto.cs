// GreekParser.Application/DTOs/Vocabulary/UpdateVocabularyDto.cs
namespace GreekParser.Application.DTOs.Vocabulary
{
    public class UpdateVocabularyDto
    {
        public string Root { get; set; } = string.Empty;
        public string? Transliteration { get; set; }
        public string Gloss { get; set; } = string.Empty;
        public string? PartOfSpeech { get; set; }
        public int? FrequencyRank { get; set; }
    }
}
