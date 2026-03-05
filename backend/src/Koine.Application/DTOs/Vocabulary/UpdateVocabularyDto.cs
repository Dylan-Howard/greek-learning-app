// Koine.Application/DTOs/Vocabulary/UpdateVocabularyDto.cs
namespace Koine.Application.DTOs.Vocabulary
{
    public class UpdateVocabularyDto
    {
        public string Root { get; set; } = string.Empty;
        public string? Transliteration { get; set; }
        public string Gloss { get; set; } = string.Empty;
        public string? PartOfSpeech { get; set; }
        public int? Occurrences { get; set; }
    }
}
