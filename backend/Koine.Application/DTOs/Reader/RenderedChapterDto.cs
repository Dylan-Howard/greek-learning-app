// Koine.Application/DTOs/Reader/RenderedChapterDto.cs
namespace Koine.Application.DTOs.Reader
{
    public class RenderedChapterDto
    {
        public int ChapterId { get; set; }
        public string Title { get; set; } = string.Empty;
        public List<RenderedUnitDto> Units { get; set; } = new();
    }
}
