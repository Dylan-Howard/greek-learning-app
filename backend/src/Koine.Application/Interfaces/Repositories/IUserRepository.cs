using Koine.Domain.Entities;

// Koine.Application/Interfaces/Repositories/IUserRepository.cs
namespace Koine.Application.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByEmailAsync(string email);
        Task<User?> GetByUsernameAsync(string username);
    }
}
