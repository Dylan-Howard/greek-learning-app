using Koine.Domain.Entities;

// Koine.Application/Interfaces/Repositories/ILessonRepository.cs
namespace Koine.Application.Interfaces.Repositories
{
    public interface ILessonRepository : IRepository<Lesson>
    {
        Task<List<Lesson>> GetAllOrderedAsync();
        Task<List<Lesson>> GetByTypeAsync(string lessonType);
    }
}
