// Koine.Application/Interfaces/IBookService.cs (Enhanced)
using Koine.Application.DTOs.Books;

namespace Koine.Application.Interfaces
{
    public interface IBookService
    {
        Task<List<BookDto>> GetAllBooksAsync();
        Task<BookDto?> GetBookByIdAsync(int bookId);
        Task<BookDto> CreateBookAsync(CreateBookDto createDto);
        Task<BookDto?> UpdateBookAsync(int bookId, UpdateBookDto updateDto);
        Task<bool> DeleteBookAsync(int bookId);
    }
}
