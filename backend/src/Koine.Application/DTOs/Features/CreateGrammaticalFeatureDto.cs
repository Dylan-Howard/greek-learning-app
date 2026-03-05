// Koine.Application/DTOs/Features/CreateGrammaticalFeatureDto.cs
namespace Koine.Application.DTOs.Features
{
    public class CreateGrammaticalFeatureDto
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string? Definition { get; set; }
        public int SortOrder { get; set; }
    }
}
