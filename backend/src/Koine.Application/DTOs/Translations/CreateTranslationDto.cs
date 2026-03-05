// Koine.Application/DTOs/Translations/CreateTranslationDto.cs
namespace Koine.Application.DTOs.Translations
{
    public class CreateTranslationDto
    {
        public string LanguageCode { get; set; } = "en";
        public string Name { get; set; } = string.Empty;
    }
}
