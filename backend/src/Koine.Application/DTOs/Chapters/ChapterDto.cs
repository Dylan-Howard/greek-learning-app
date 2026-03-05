// Koine.Application/DTOs/Chapters/ChapterDto.cs
namespace Koine.Application.DTOs.Chapters
{
    public class ChapterDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int ChapterIndex { get; set; }
        public string? Title { get; set; }
        public List<UnitNodeDto> UnitTree { get; set; } = new();
        public DateTime CreatedAt { get; set; }
    }
}
