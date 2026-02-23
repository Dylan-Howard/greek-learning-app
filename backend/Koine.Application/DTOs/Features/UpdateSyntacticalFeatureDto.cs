// Koine.Application/DTOs/Features/UpdateSyntacticalFeatureDto.cs
namespace Koine.Application.DTOs.Features
{
    public class UpdateSyntacticalFeatureDto
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Definition { get; set; }
        public int SortOrder { get; set; }
    }
}
