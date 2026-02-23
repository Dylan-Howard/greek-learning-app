// Koine.Application/DTOs/Features/UpdateGrammaticalFeatureDto.cs
namespace Koine.Application.DTOs.Features
{
    public class UpdateGrammaticalFeatureDto
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string? Definition { get; set; }
        public int SortOrder { get; set; }
    }
}
