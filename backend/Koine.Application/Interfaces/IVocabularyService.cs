// GreekParser.Application/Interfaces/IVocabularyService.cs (Enhanced)
namespace GreekParser.Application.Interfaces
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
    }
}