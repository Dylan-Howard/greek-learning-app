// Koine.Application/DTOs/Reader/ReaderRequestDto.cs
namespace Koine.Application.DTOs.Reader
{
    public class ReaderRequestDto
    {
        public int BookId { get; set; }
        public int ChapterIndex { get; set; }
        public string TargetLanguage { get; set; } = "en";
    }
}
