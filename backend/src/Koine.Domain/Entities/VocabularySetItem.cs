namespace Koine.Domain.Entities
{
    public class VocabularySetItem
    {
        public int Id { get; set; }
        public int VocabularySetId { get; set; }
        public int VocabularyId { get; set; }
        public int MasteryLevel { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime? LastSeen { get; set; }

        // Navigation properties
        public virtual VocabularySet VocabularySet { get; set; } = null!;
        public virtual Vocabulary Vocabulary { get; set; } = null!;
    }
}
