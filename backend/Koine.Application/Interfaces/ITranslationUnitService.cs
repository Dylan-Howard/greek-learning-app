// GreekParser.Application/Interfaces/ITranslationUnitService.cs
namespace GreekParser.Application.Interfaces
{
    public interface ITranslationUnitService
    {
        Task<List<TranslationUnitDto>> GetUnitsByTranslationIdAsync(int translationId);
        Task<TranslationUnitDto?> GetUnitByIdAsync(int unitId);
        Task<TranslationUnitDto> CreateUnitAsync(int translationId, CreateTranslationUnitDto createDto);
        Task<List<TranslationUnitDto>> BatchCreateUnitsAsync(int translationId, BatchCreateTranslationUnitsDto batchDto);
        Task<TranslationUnitDto?> UpdateUnitAsync(int unitId, UpdateTranslationUnitDto updateDto);
        Task<bool> DeleteUnitAsync(int unitId);
    }
}
