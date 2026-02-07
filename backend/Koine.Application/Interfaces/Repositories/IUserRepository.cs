// GreekParser.Application/Interfaces/Repositories/IUserRepository.cs
namespace GreekParser.Application.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByEmailAsync(string email);
        Task<User?> GetByUsernameAsync(string username);
    }
}
