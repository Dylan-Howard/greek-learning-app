using Koine.Domain.Entities;

// Koine.Application/Interfaces/Repositories/IUserProgressRepository.cs
namespace Koine.Application.Interfaces.Repositories
{
    public interface IUserProgressRepository : IRepository<UserProgress>
    {
        Task<UserProgress?> GetByUserIdAsync(int userId);
        Task<UserProgress> GetOrCreateByUserIdAsync(int userId);
    }
}
