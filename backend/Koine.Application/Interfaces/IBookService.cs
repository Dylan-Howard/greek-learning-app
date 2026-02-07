// GreekParser.Application/Interfaces/IBookService.cs (Enhanced)
namespace GreekParser.Application.Interfaces
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
