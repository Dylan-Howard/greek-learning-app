// GreekParser.Application/Interfaces/ILessonService.cs (Enhanced)
namespace GreekParser.Application.Interfaces
{
    public interface ILessonService
    {
        Task<List<LessonDto>> GetAllLessonsAsync(int userId);
        Task<LessonDto?> GetLessonByIdAsync(int lessonId, int userId);
        Task<bool> CompleteLessonAsync(int userId, CompleteLessonDto completionDto);
        Task<LessonDto> CreateLessonAsync(CreateLessonDto createDto);
        Task<LessonDto?> UpdateLessonAsync(int lessonId, UpdateLessonDto updateDto);
        Task<bool> DeleteLessonAsync(int lessonId);
    }
}