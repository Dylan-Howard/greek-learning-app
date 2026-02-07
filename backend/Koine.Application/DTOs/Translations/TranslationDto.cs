// GreekParser.Application/DTOs/Translations/TranslationDto.cs
namespace GreekParser.Application.DTOs.Translations
{
    public class TranslationDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string LanguageCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
