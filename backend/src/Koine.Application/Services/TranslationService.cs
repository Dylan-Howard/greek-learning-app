// Koine.Application/Services/TranslationService.cs
using Koine.Application.DTOs.Translations;
using Koine.Application.Interfaces;
using Koine.Domain.Entities;

namespace Koine.Application.Services
{
    public class TranslationService : ITranslationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TranslationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<TranslationDto>> GetTranslationsByBookIdAsync(int bookId)
        {
            var allTranslations = await _unitOfWork.Translations.GetAllAsync();
            var translations = allTranslations.Where(t => t.BookId == bookId).ToList();

            return translations.Select(t => new TranslationDto
            {
                Id = t.Id,
                BookId = t.BookId,
                LanguageCode = t.LanguageCode,
                Name = t.Name,
                CreatedAt = t.CreatedAt
            }).ToList();
        }

        public async Task<TranslationDto?> GetTranslationByIdAsync(int translationId)
        {
            var translation = await _unitOfWork.Translations.GetByIdAsync(translationId);
            if (translation == null) return null;

            return new TranslationDto
            {
                Id = translation.Id,
                BookId = translation.BookId,
                LanguageCode = translation.LanguageCode,
                Name = translation.Name,
                CreatedAt = translation.CreatedAt
            };
        }

        public async Task<TranslationDto> CreateTranslationAsync(int bookId, CreateTranslationDto createDto)
        {
            var translation = new Translation
            {
                BookId = bookId,
                LanguageCode = createDto.LanguageCode,
                Name = createDto.Name,
                CreatedAt = DateTime.UtcNow
            };

            await _unitOfWork.Translations.AddAsync(translation);
            await _unitOfWork.SaveChangesAsync();

            return new TranslationDto
            {
                Id = translation.Id,
                BookId = translation.BookId,
                LanguageCode = translation.LanguageCode,
                Name = translation.Name,
                CreatedAt = translation.CreatedAt
            };
        }

        public async Task<TranslationDto?> UpdateTranslationAsync(int translationId, UpdateTranslationDto updateDto)
        {
            var translation = await _unitOfWork.Translations.GetByIdAsync(translationId);
            if (translation == null) return null;

            translation.LanguageCode = updateDto.LanguageCode;
            translation.Name = updateDto.Name;

            await _unitOfWork.Translations.UpdateAsync(translation);
            await _unitOfWork.SaveChangesAsync();

            return new TranslationDto
            {
                Id = translation.Id,
                BookId = translation.BookId,
                LanguageCode = translation.LanguageCode,
                Name = translation.Name,
                CreatedAt = translation.CreatedAt
            };
        }

        public async Task<bool> DeleteTranslationAsync(int translationId)
        {
            var translation = await _unitOfWork.Translations.GetByIdAsync(translationId);
            if (translation == null) return false;

            await _unitOfWork.Translations.DeleteAsync(translation);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
