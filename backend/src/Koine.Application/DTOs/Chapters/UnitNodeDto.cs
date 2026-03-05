// Koine.Application/DTOs/Chapters/UnitNodeDto.cs
namespace Koine.Application.DTOs.Chapters
{
    public class UnitNodeDto
    {
        public string Type { get; set; } = string.Empty;
        public string? Id { get; set; }
        public string? Path { get; set; }
        public int? VocabId { get; set; }
        public string? Root { get; set; }
        public List<int>? GramFeatureIds { get; set; }
        public List<int>? SynFeatureIds { get; set; }
        public string? Translation { get; set; }
        public List<UnitNodeDto>? Children { get; set; }
        public string? Content { get; set; }
        public string? Marker { get; set; }
    }
}
