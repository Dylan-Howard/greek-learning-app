// Koine.Application/DTOs/Translations/BatchCreateTranslationUnitsDto.cs
namespace Koine.Application.DTOs.Translations
{
    public class BatchCreateTranslationUnitsDto
    {
        public List<CreateTranslationUnitDto> Units { get; set; } = new();
    }
}
