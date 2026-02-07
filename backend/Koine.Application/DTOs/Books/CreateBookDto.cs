// GreekParser.Application/DTOs/Books/CreateBookDto.cs
namespace GreekParser.Application.DTOs.Books
{
    public class CreateBookDto
    {
        public string Title { get; set; } = string.Empty;
        public string LanguageCode { get; set; } = "grc";
    }
}
