// GreekParser.Application/Interfaces/Repositories/IUserProgressRepository.cs
namespace GreekParser.Application.Interfaces.Repositories
{
    public interface IUserProgressRepository : IRepository<UserProgress>
    {
        Task<UserProgress?> GetByUserIdAsync(int userId);
        Task<UserProgress> GetOrCreateByUserIdAsync(int userId);
    }
}
