// Koine.Application/Interfaces/IProgressService.cs
using Koine.Application.DTOs.Progress;
using Koine.Application.DTOs.Users;

namespace Koine.Application.Interfaces
{
    public interface IProgressService
    {
        Task<UserProgressDto?> GetUserProgressAsync(int userId);
        Task<bool> UpdateProgressAsync(int userId, UserProgressDto progressDto);
        Task<List<UserLessonDto>> GetUserLessonsAsync(int userId);
        Task<List<UserWordDto>> GetUserVocabularyAsync(int userId);
    }
}
