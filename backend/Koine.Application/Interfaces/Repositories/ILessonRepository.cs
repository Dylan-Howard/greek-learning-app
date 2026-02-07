// GreekParser.Application/Interfaces/Repositories/ILessonRepository.cs
namespace GreekParser.Application.Interfaces.Repositories
{
    public interface ILessonRepository : IRepository<Lesson>
    {
        Task<List<Lesson>> GetAllOrderedAsync();
        Task<List<Lesson>> GetByTypeAsync(string lessonType);
    }
}
