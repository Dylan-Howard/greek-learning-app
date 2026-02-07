// GreekParser.Application/DTOs/Translations/TranslationUnitDto.cs
namespace GreekParser.Application.DTOs.Translations
{
    public class TranslationUnitDto
    {
        public int Id { get; set; }
        public int TranslationId { get; set; }
        public int ChapterId { get; set; }
        public string OriginalUnitPath { get; set; } = string.Empty;
        public string TranslatedText { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public string? ScopeStart { get; set; }
        public string? ScopeEnd { get; set; }
    }
}
