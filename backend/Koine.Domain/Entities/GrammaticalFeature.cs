// Koine.Domain/Entities/GrammaticalFeature.cs
namespace Koine.Domain.Entities
{
    public class GrammaticalFeature
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string? Definition { get; set; }
        public int SortOrder { get; set; }
    }
}
