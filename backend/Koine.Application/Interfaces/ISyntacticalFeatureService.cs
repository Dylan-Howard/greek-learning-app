// GreekParser.Application/Interfaces/ISyntacticalFeatureService.cs
namespace GreekParser.Application.Interfaces
{
    public interface ISyntacticalFeatureService
    {
        Task<List<SyntacticalFeatureDto>> GetAllFeaturesAsync();
        Task<SyntacticalFeatureDto?> GetFeatureByIdAsync(int featureId);
        Task<SyntacticalFeatureDto?> GetFeatureByCodeAsync(string code);
        Task<SyntacticalFeatureDto> CreateFeatureAsync(CreateSyntacticalFeatureDto createDto);
        Task<SyntacticalFeatureDto?> UpdateFeatureAsync(int featureId, UpdateSyntacticalFeatureDto updateDto);
        Task<bool> DeleteFeatureAsync(int featureId);
    }
}
