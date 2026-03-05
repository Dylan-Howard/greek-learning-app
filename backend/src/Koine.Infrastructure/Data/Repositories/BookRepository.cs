using Microsoft.EntityFrameworkCore;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<List<Book>> GetAllWithChaptersAsync()
        {
            return await _dbSet
                .Include(b => b.Chapters)
                .ToListAsync();
        }
    }
}
