// Koine.Application/DTOs/Books/CreateBookDto.cs
namespace Koine.Application.DTOs.Books
{
    public class CreateBookDto
    {
        public string Title { get; set; } = string.Empty;
        public string LanguageCode { get; set; } = "grc";
    }
}
