// Koine.Application/DTOs/Features/GrammaticalFeatureDto.cs
namespace Koine.Application.DTOs.Features
{
    public class GrammaticalFeatureDto
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string? Definition { get; set; }
    }
}
