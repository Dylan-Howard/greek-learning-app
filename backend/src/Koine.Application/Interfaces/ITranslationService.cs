// Koine.Application/Interfaces/ITranslationService.cs
using Koine.Application.DTOs.Translations;

namespace Koine.Application.Interfaces
{
    public interface ITranslationService
    {
        Task<List<TranslationDto>> GetTranslationsByBookIdAsync(int bookId);
        Task<TranslationDto?> GetTranslationByIdAsync(int translationId);
        Task<TranslationDto> CreateTranslationAsync(int bookId, CreateTranslationDto createDto);
        Task<TranslationDto?> UpdateTranslationAsync(int translationId, UpdateTranslationDto updateDto);
        Task<bool> DeleteTranslationAsync(int translationId);
    }
}
