// Koine.Domain/Entities/Vocabulary.cs
namespace Koine.Domain.Entities
{
    public class Vocabulary
    {
        public int Id { get; set; }
        public string Root { get; set; } = string.Empty;
        public string? Transliteration { get; set; }
        public string Gloss { get; set; } = string.Empty;
        public string? PartOfSpeech { get; set; }
        public int? Occurrences { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
