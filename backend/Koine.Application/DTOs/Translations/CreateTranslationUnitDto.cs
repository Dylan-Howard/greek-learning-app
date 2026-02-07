// GreekParser.Application/DTOs/Translations/CreateTranslationUnitDto.cs
namespace GreekParser.Application.DTOs.Translations
{
    public class CreateTranslationUnitDto
    {
        public int ChapterId { get; set; }
        public string OriginalUnitPath { get; set; } = string.Empty;
        public string TranslatedText { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public string? ScopeStart { get; set; }
        public string? ScopeEnd { get; set; }
    }
}
