using Koine.Application.DTOs.Study;

namespace Koine.Application.Interfaces
{
    public interface IStudyService
    {
        Task<List<VocabularySetDto>> GetUserSetsAsync(int userId);
        Task<VocabularySetDto?> GetSetByIdAsync(int setId, int userId);
        Task<VocabularySetDto> CreateSetAsync(int userId, CreateVocabularySetDto createDto);
        Task<bool> DeleteSetAsync(int setId, int userId);
        Task<bool> UpdateItemMasteryAsync(int itemId, int userId, int masteryLevel);
        Task<bool> AddVocabularyToSetAsync(int setId, int userId, int vocabularyId);
    }
}
