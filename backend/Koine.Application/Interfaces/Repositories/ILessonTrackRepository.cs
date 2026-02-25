using Koine.Domain.Entities;

namespace Koine.Application.Interfaces.Repositories
{
    public interface ILessonTrackRepository : IRepository<LessonTrack>
    {
        Task<List<LessonTrack>> GetAllOrderedAsync();
        Task<LessonTrack?> GetBySlugAsync(string slug);
    }
}
