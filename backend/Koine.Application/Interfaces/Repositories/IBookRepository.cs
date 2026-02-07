// GreekParser.Application/Interfaces/Repositories/IBookRepository.cs
namespace GreekParser.Application.Interfaces.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<List<Book>> GetAllWithChaptersAsync();
    }
}
