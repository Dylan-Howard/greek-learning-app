// Koine.Application/DTOs/Features/SyntacticalFeatureDto.cs
namespace Koine.Application.DTOs.Features
{
    public class SyntacticalFeatureDto
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Definition { get; set; }
    }
}
