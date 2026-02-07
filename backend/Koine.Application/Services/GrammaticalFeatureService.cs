// GreekParser.Application/Services/GrammaticalFeatureService.cs
using GreekParser.Application.DTOs.Features;
using GreekParser.Application.Interfaces;
using GreekParser.Domain.Entities;

namespace GreekParser.Application.Services
{
    public class GrammaticalFeatureService : IGrammaticalFeatureService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GrammaticalFeatureService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<GrammaticalFeatureDto>> GetAllFeaturesAsync()
        {
            var features = await _unitOfWork.GrammaticalFeatures.GetAllAsync();

            return features.Select(f => new GrammaticalFeatureDto
            {
                Id = f.Id,
                Code = f.Code,
                Name = f.Name,
                Category = f.Category,
                Definition = f.Definition
            }).ToList();
        }

        public async Task<GrammaticalFeatureDto?> GetFeatureByIdAsync(int featureId)
        {
            var feature = await _unitOfWork.GrammaticalFeatures.GetByIdAsync(featureId);
            if (feature == null) return null;

            return new GrammaticalFeatureDto
            {
                Id = feature.Id,
                Code = feature.Code,
                Name = feature.Name,
                Category = feature.Category,
                Definition = feature.Definition
            };
        }

        public async Task<GrammaticalFeatureDto?> GetFeatureByCodeAsync(string code)
        {
            var feature = await _unitOfWork.GrammaticalFeatures.GetByCodeAsync(code);
            if (feature == null) return null;

            return new GrammaticalFeatureDto
            {
                Id = feature.Id,
                Code = feature.Code,
                Name = feature.Name,
                Category = feature.Category,
                Definition = feature.Definition
            };
        }

        public async Task<GrammaticalFeatureDto> CreateFeatureAsync(CreateGrammaticalFeatureDto createDto)
        {
            var feature = new GrammaticalFeature
            {
                Code = createDto.Code,
                Name = createDto.Name,
                Category = createDto.Category,
                Definition = createDto.Definition,
                SortOrder = createDto.SortOrder
            };

            await _unitOfWork.GrammaticalFeatures.AddAsync(feature);
            await _unitOfWork.SaveChangesAsync();

            return new GrammaticalFeatureDto
            {
                Id = feature.Id,
                Code = feature.Code,
                Name = feature.Name,
                Category = feature.Category,
                Definition = feature.Definition
            };
        }

        public async Task<GrammaticalFeatureDto?> UpdateFeatureAsync(int featureId, UpdateGrammaticalFeatureDto updateDto)
        {
            var feature = await _unitOfWork.GrammaticalFeatures.GetByIdAsync(featureId);
            if (feature == null) return null;

            feature.Code = updateDto.Code;
            feature.Name = updateDto.Name;
            feature.Category = updateDto.Category;
            feature.Definition = updateDto.Definition;
            feature.SortOrder = updateDto.SortOrder;

            await _unitOfWork.GrammaticalFeatures.UpdateAsync(feature);
            await _unitOfWork.SaveChangesAsync();

            return new GrammaticalFeatureDto
            {
                Id = feature.Id,
                Code = feature.Code,
                Name = feature.Name,
                Category = feature.Category,
                Definition = feature.Definition
            };
        }

        public async Task<bool> DeleteFeatureAsync(int featureId)
        {
            var feature = await _unitOfWork.GrammaticalFeatures.GetByIdAsync(featureId);
            if (feature == null) return false;

            await _unitOfWork.GrammaticalFeatures.DeleteAsync(feature);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
