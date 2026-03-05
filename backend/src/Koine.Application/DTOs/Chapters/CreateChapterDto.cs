// Koine.Application/DTOs/Chapters/CreateChapterDto.cs
namespace Koine.Application.DTOs.Chapters
{
    public class CreateChapterDto
    {
        public int ChapterIndex { get; set; }
        public string? Title { get; set; }
        public List<UnitNodeDto> UnitTree { get; set; } = new();
    }
}
