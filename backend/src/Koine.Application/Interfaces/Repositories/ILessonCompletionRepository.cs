using Koine.Domain.Entities;

// Koine.Application/Interfaces/Repositories/ILessonCompletionRepository.cs
namespace Koine.Application.Interfaces.Repositories
{
    public interface ILessonCompletionRepository : IRepository<LessonCompletion>
    {
        Task<List<LessonCompletion>> GetByUserIdAsync(int userId);
        Task<LessonCompletion?> GetByUserAndLessonAsync(int userId, int lessonId);
    }
}
