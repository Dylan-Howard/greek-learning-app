namespace Koine.Domain.Entities
{
    public class VocabularySet
    {
        public int Id { get; set; }
        public int? OwnerUserId { get; set; }
        public bool IsSystem { get; set; }
        public string Slug { get; set; } = string.Empty;
        public int? BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? LastPracticed { get; set; }

        // Navigation properties
        public virtual User? OwnerUser { get; set; }
        public virtual ICollection<VocabularySetItem> Items { get; set; } = new List<VocabularySetItem>();
        public virtual Book? Book { get; set; }
    }
}
