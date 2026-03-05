// Koine.Application/Interfaces/ILessonService.cs (Enhanced)
using Koine.Application.DTOs.Lessons;

namespace Koine.Application.Interfaces
{
    public interface ILessonService
    {
        Task<List<LessonTrackDto>> GetLessonTracksAsync(int userId, bool includeLessons = false);
        Task<LessonTrackDto?> GetLessonTrackAsync(string trackSlug, int userId);
        Task<LessonDto?> GetNextLessonAsync(int userId, string trackSlug);
        Task<List<LessonDto>> GetAllLessonsAsync(int userId);
        Task<List<LessonDto>> GetLessonsByTrackAsync(int userId, string trackSlug);
        Task<LessonDto?> GetLessonByIdAsync(int lessonId, int userId);
        Task<LessonCompletionResponseDto?> CompleteLessonAsync(int userId, CompleteLessonDto completionDto);
        Task<LessonDto> CreateLessonAsync(CreateLessonDto createDto);
        Task<LessonDto?> UpdateLessonAsync(int lessonId, UpdateLessonDto updateDto);
        Task<bool> DeleteLessonAsync(int lessonId);
    }
}
