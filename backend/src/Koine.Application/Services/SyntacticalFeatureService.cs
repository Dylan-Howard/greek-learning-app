// Koine.Application/Services/SyntacticalFeatureService.cs
using Koine.Application.DTOs.Features;
using Koine.Application.Interfaces;
using Koine.Domain.Entities;

namespace Koine.Application.Services
{
    public class SyntacticalFeatureService : ISyntacticalFeatureService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SyntacticalFeatureService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<SyntacticalFeatureDto>> GetAllFeaturesAsync()
        {
            var features = await _unitOfWork.SyntacticalFeatures.GetAllAsync();

            return features.Select(f => new SyntacticalFeatureDto
            {
                Id = f.Id,
                Code = f.Code,
                Name = f.Name,
                Definition = f.Definition
            }).ToList();
        }

        public async Task<SyntacticalFeatureDto?> GetFeatureByIdAsync(int featureId)
        {
            var feature = await _unitOfWork.SyntacticalFeatures.GetByIdAsync(featureId);
            if (feature == null) return null;

            return new SyntacticalFeatureDto
            {
                Id = feature.Id,
                Code = feature.Code,
                Name = feature.Name,
                Definition = feature.Definition
            };
        }

        public async Task<SyntacticalFeatureDto?> GetFeatureByCodeAsync(string code)
        {
            var feature = await _unitOfWork.SyntacticalFeatures.GetByCodeAsync(code);
            if (feature == null) return null;

            return new SyntacticalFeatureDto
            {
                Id = feature.Id,
                Code = feature.Code,
                Name = feature.Name,
                Definition = feature.Definition
            };
        }

        public async Task<SyntacticalFeatureDto> CreateFeatureAsync(CreateSyntacticalFeatureDto createDto)
        {
            var feature = new SyntacticalFeature
            {
                Code = createDto.Code,
                Name = createDto.Name,
                Definition = createDto.Definition,
                SortOrder = createDto.SortOrder
            };

            await _unitOfWork.SyntacticalFeatures.AddAsync(feature);
            await _unitOfWork.SaveChangesAsync();

            return new SyntacticalFeatureDto
            {
                Id = feature.Id,
                Code = feature.Code,
                Name = feature.Name,
                Definition = feature.Definition
            };
        }

        public async Task<SyntacticalFeatureDto?> UpdateFeatureAsync(int featureId, UpdateSyntacticalFeatureDto updateDto)
        {
            var feature = await _unitOfWork.SyntacticalFeatures.GetByIdAsync(featureId);
            if (feature == null) return null;

            feature.Code = updateDto.Code;
            feature.Name = updateDto.Name;
            feature.Definition = updateDto.Definition;
            feature.SortOrder = updateDto.SortOrder;

            await _unitOfWork.SyntacticalFeatures.UpdateAsync(feature);
            await _unitOfWork.SaveChangesAsync();

            return new SyntacticalFeatureDto
            {
                Id = feature.Id,
                Code = feature.Code,
                Name = feature.Name,
                Definition = feature.Definition
            };
        }

        public async Task<bool> DeleteFeatureAsync(int featureId)
        {
            var feature = await _unitOfWork.SyntacticalFeatures.GetByIdAsync(featureId);
            if (feature == null) return false;

            await _unitOfWork.SyntacticalFeatures.DeleteAsync(feature);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
