// GreekParser.Application/Services/TranslationUnitService.cs
using GreekParser.Application.DTOs.Translations;
using GreekParser.Application.Interfaces;
using GreekParser.Domain.Entities;

namespace GreekParser.Application.Services
{
    public class TranslationUnitService : ITranslationUnitService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TranslationUnitService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<TranslationUnitDto>> GetUnitsByTranslationIdAsync(int translationId)
        {
            var allUnits = await _unitOfWork.TranslationUnits.GetAllAsync();
            var units = allUnits.Where(u => u.TranslationId == translationId).ToList();

            return units.Select(u => new TranslationUnitDto
            {
                Id = u.Id,
                TranslationId = u.TranslationId,
                ChapterId = u.ChapterId,
                OriginalUnitPath = u.OriginalUnitPath,
                TranslatedText = u.TranslatedText,
                DisplayOrder = u.DisplayOrder,
                ScopeStart = u.ScopeStart,
                ScopeEnd = u.ScopeEnd
            }).ToList();
        }

        public async Task<TranslationUnitDto?> GetUnitByIdAsync(int unitId)
        {
            var unit = await _unitOfWork.TranslationUnits.GetByIdAsync(unitId);
            if (unit == null) return null;

            return new TranslationUnitDto
            {
                Id = unit.Id,
                TranslationId = unit.TranslationId,
                ChapterId = unit.ChapterId,
                OriginalUnitPath = unit.OriginalUnitPath,
                TranslatedText = unit.TranslatedText,
                DisplayOrder = unit.DisplayOrder,
                ScopeStart = unit.ScopeStart,
                ScopeEnd = unit.ScopeEnd
            };
        }

        public async Task<TranslationUnitDto> CreateUnitAsync(int translationId, CreateTranslationUnitDto createDto)
        {
            var unit = new TranslationUnit
            {
                TranslationId = translationId,
                ChapterId = createDto.ChapterId,
                OriginalUnitPath = createDto.OriginalUnitPath,
                TranslatedText = createDto.TranslatedText,
                DisplayOrder = createDto.DisplayOrder,
                ScopeStart = createDto.ScopeStart,
                ScopeEnd = createDto.ScopeEnd
            };

            await _unitOfWork.TranslationUnits.AddAsync(unit);
            await _unitOfWork.SaveChangesAsync();

            return new TranslationUnitDto
            {
                Id = unit.Id,
                TranslationId = unit.TranslationId,
                ChapterId = unit.ChapterId,
                OriginalUnitPath = unit.OriginalUnitPath,
                TranslatedText = unit.TranslatedText,
                DisplayOrder = unit.DisplayOrder,
                ScopeStart = unit.ScopeStart,
                ScopeEnd = unit.ScopeEnd
            };
        }

        public async Task<List<TranslationUnitDto>> BatchCreateUnitsAsync(int translationId, BatchCreateTranslationUnitsDto batchDto)
        {
            var createdUnits = new List<TranslationUnitDto>();

            await _unitOfWork.BeginTransactionAsync();

            try
            {
                foreach (var createDto in batchDto.Units)
                {
                    var unit = new TranslationUnit
                    {
                        TranslationId = translationId,
                        ChapterId = createDto.ChapterId,
                        OriginalUnitPath = createDto.OriginalUnitPath,
                        TranslatedText = createDto.TranslatedText,
                        DisplayOrder = createDto.DisplayOrder,
                        ScopeStart = createDto.ScopeStart,
                        ScopeEnd = createDto.ScopeEnd
                    };

                    await _unitOfWork.TranslationUnits.AddAsync(unit);
                    
                    createdUnits.Add(new TranslationUnitDto
                    {
                        Id = unit.Id,
                        TranslationId = unit.TranslationId,
                        ChapterId = unit.ChapterId,
                        OriginalUnitPath = unit.OriginalUnitPath,
                        TranslatedText = unit.TranslatedText,
                        DisplayOrder = unit.DisplayOrder,
                        ScopeStart = unit.ScopeStart,
                        ScopeEnd = unit.ScopeEnd
                    });
                }

                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
                throw;
            }

            return createdUnits;
        }

        public async Task<TranslationUnitDto?> UpdateUnitAsync(int unitId, UpdateTranslationUnitDto updateDto)
        {
            var unit = await _unitOfWork.TranslationUnits.GetByIdAsync(unitId);
            if (unit == null) return null;

            unit.ChapterId = updateDto.ChapterId;
            unit.OriginalUnitPath = updateDto.OriginalUnitPath;
            unit.TranslatedText = updateDto.TranslatedText;
            unit.DisplayOrder = updateDto.DisplayOrder;
            unit.ScopeStart = updateDto.ScopeStart;
            unit.ScopeEnd = updateDto.ScopeEnd;

            await _unitOfWork.TranslationUnits.UpdateAsync(unit);
            await _unitOfWork.SaveChangesAsync();

            return new TranslationUnitDto
            {
                Id = unit.Id,
                TranslationId = unit.TranslationId,
                ChapterId = unit.ChapterId,
                OriginalUnitPath = unit.OriginalUnitPath,
                TranslatedText = unit.TranslatedText,
                DisplayOrder = unit.DisplayOrder,
                ScopeStart = unit.ScopeStart,
                ScopeEnd = unit.ScopeEnd
            };
        }

        public async Task<bool> DeleteUnitAsync(int unitId)
        {
            var unit = await _unitOfWork.TranslationUnits.GetByIdAsync(unitId);
            if (unit == null) return false;

            await _unitOfWork.TranslationUnits.DeleteAsync(unit);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
