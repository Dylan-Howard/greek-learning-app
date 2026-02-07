// GreekParser.Application/DTOs/Translations/CreateTranslationDto.cs
namespace GreekParser.Application.DTOs.Translations
{
    public class CreateTranslationDto
    {
        public string LanguageCode { get; set; } = "en";
        public string Name { get; set; } = string.Empty;
    }
}
