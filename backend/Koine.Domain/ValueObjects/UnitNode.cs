// Koine.Domain/ValueObjects/UnitNode.cs
namespace Koine.Domain.ValueObjects
{
    public class UnitNode
    {
        public string Type { get; set; } = string.Empty; // "unit", "meta"
        public string? Id { get; set; }
        public string? Path { get; set; }
        public int? VocabId { get; set; }
        public string? Root { get; set; }
        public List<int>? GramFeatureIds { get; set; }
        public List<int>? SynFeatureIds { get; set; }
        public string? Translation { get; set; }
        public List<UnitNode>? Children { get; set; }
        
        // For meta nodes
        public string? Content { get; set; }
        public string? Marker { get; set; }
    }
}
