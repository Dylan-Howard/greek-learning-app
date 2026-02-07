// GreekParser.Application/Services/BookService.cs
using System.Text.Json;
using GreekParser.Application.DTOs.Books;
using GreekParser.Application.Interfaces;
using GreekParser.Domain.Entities;

namespace GreekParser.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<BookDto>> GetAllBooksAsync()
        {
            var books = await _unitOfWork.Books.GetAllAsync();
            var chapters = new Dictionary<int, int>();

            foreach (var book in books)
            {
                var chapterList = await _unitOfWork.Chapters.GetByBookIdAsync(book.Id);
                chapters[book.Id] = chapterList.Count;
            }

            return books.Select(b => new BookDto
            {
                Id = b.Id,
                Title = b.Title,
                LanguageCode = b.LanguageCode,
                ChapterCount = chapters.GetValueOrDefault(b.Id, 0)
            }).ToList();
        }

        public async Task<BookDto?> GetBookByIdAsync(int bookId)
        {
            var book = await _unitOfWork.Books.GetByIdAsync(bookId);
            if (book == null) return null;

            var chapters = await _unitOfWork.Chapters.GetByBookIdAsync(bookId);

            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                LanguageCode = book.LanguageCode,
                ChapterCount = chapters.Count
            };
        }

        public async Task<BookDto> CreateBookAsync(CreateBookDto createDto)
        {
            var book = new Book
            {
                Title = createDto.Title,
                LanguageCode = createDto.LanguageCode,
                CreatedAt = DateTime.UtcNow
            };

            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.SaveChangesAsync();

            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                LanguageCode = book.LanguageCode,
                ChapterCount = 0
            };
        }

        public async Task<BookDto?> UpdateBookAsync(int bookId, UpdateBookDto updateDto)
        {
            var book = await _unitOfWork.Books.GetByIdAsync(bookId);
            if (book == null) return null;

            book.Title = updateDto.Title;
            book.LanguageCode = updateDto.LanguageCode;

            await _unitOfWork.Books.UpdateAsync(book);
            await _unitOfWork.SaveChangesAsync();

            var chapters = await _unitOfWork.Chapters.GetByBookIdAsync(bookId);

            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                LanguageCode = book.LanguageCode,
                ChapterCount = chapters.Count
            };
        }

        public async Task<bool> DeleteBookAsync(int bookId)
        {
            var book = await _unitOfWork.Books.GetByIdAsync(bookId);
            if (book == null) return false;

            await _unitOfWork.Books.DeleteAsync(book);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
