// Koine.Domain/Entities/SyntacticalFeature.cs
namespace Koine.Domain.Entities
{
    public class SyntacticalFeature
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Definition { get; set; }
        public int SortOrder { get; set; }
    }
}
