using Koine.Domain.Entities;

// Koine.Application/Interfaces/Repositories/IBookRepository.cs
namespace Koine.Application.Interfaces.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<List<Book>> GetAllWithChaptersAsync();
    }
}
