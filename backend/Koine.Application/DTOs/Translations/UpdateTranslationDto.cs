// GreekParser.Application/DTOs/Translations/UpdateTranslationDto.cs
namespace GreekParser.Application.DTOs.Translations
{
    public class UpdateTranslationDto
    {
        public string LanguageCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
