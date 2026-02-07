// GreekParser.Application/DTOs/Reader/RenderedUnitDto.cs
namespace GreekParser.Application.DTOs.Reader
{
    public class RenderedUnitDto
    {
        public string Type { get; set; } = string.Empty; // "meta", "original", "translated", etc.
        public string? Text { get; set; }
        public string? Original { get; set; }
        public List<string>? Hints { get; set; }
        public int? VocabId { get; set; }
        public string? Marker { get; set; }
        public List<RenderedUnitDto>? Children { get; set; }
    }
}
