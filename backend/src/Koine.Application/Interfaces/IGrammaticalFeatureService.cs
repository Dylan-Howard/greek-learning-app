// Koine.Application/Interfaces/IGrammaticalFeatureService.cs
using Koine.Application.DTOs.Features;

namespace Koine.Application.Interfaces
{
    public interface IGrammaticalFeatureService
    {
        Task<List<GrammaticalFeatureDto>> GetAllFeaturesAsync();
        Task<GrammaticalFeatureDto?> GetFeatureByIdAsync(int featureId);
        Task<GrammaticalFeatureDto?> GetFeatureByCodeAsync(string code);
        Task<GrammaticalFeatureDto> CreateFeatureAsync(CreateGrammaticalFeatureDto createDto);
        Task<GrammaticalFeatureDto?> UpdateFeatureAsync(int featureId, UpdateGrammaticalFeatureDto updateDto);
        Task<bool> DeleteFeatureAsync(int featureId);
    }
}
