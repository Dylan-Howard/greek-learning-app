// GreekParser.Application/DTOs/Translations/BatchCreateTranslationUnitsDto.cs
namespace GreekParser.Application.DTOs.Translations
{
    public class BatchCreateTranslationUnitsDto
    {
        public List<CreateTranslationUnitDto> Units { get; set; } = new();
    }
}
