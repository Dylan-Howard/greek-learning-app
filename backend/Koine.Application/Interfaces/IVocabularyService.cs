// Koine.Application/Interfaces/IVocabularyService.cs (Enhanced)
using Koine.Application.DTOs.Common;
using Koine.Application.DTOs.Vocabulary;

using Koine.Application.DTOs.Common;
using Koine.Application.DTOs.Vocabulary;

namespace Koine.Application.Interfaces
{
    public interface IVocabularyService
    {
        Task<PaginatedResultDto<VocabularyDto>> GetVocabularyAsync(int page = 1, int pageSize = 50);
        Task<PaginatedResultDto<VocabularyDto>> SearchVocabularyAsync(VocabularySearchDto searchDto);
        Task<VocabularyDto?> GetVocabularyByIdAsync(int vocabId);
        Task<List<VocabularyDto>> GetVocabularyForPracticeAsync(int userId, int count = 20);
        Task<VocabularyDto> CreateVocabularyAsync(CreateVocabularyDto createDto);
        Task<VocabularyDto?> UpdateVocabularyAsync(int vocabId, UpdateVocabularyDto updateDto);
        Task<bool> DeleteVocabularyAsync(int vocabId);

        // Simple DTO methods for controller compatibility
        Task<List<SimpleWordDto>> GetAllSimpleAsync();
        Task<SimpleWordDto?> GetSimpleByIdAsync(int id);
        Task<List<SimpleWordDto>> GetWordsByBookIdAsync(int bookId);
        Task<List<SimpleWordDto>> GetWordsByChapterIdAsync(int chapterId);
        Task<bool> UpdateSimpleWordAsync(SimpleWordDto wordDto);
    }
}