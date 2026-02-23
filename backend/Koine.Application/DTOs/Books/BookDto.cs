// Koine.Application/DTOs/Books/BookDto.cs
namespace Koine.Application.DTOs.Books
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string LanguageCode { get; set; } = string.Empty;
        public int ChapterCount { get; set; }
    }
}
