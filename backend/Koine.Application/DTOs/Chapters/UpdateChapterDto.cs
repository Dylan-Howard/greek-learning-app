// Koine.Application/DTOs/Chapters/UpdateChapterDto.cs
namespace Koine.Application.DTOs.Chapters
{
    public class UpdateChapterDto
    {
        public int ChapterIndex { get; set; }
        public string? Title { get; set; }
        public List<UnitNodeDto> UnitTree { get; set; } = new();
    }
}
