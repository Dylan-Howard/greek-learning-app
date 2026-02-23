// Koine.Domain/Entities/Chapter.cs
namespace Koine.Domain.Entities
{
    public class Chapter
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int ChapterIndex { get; set; }
        public string? Title { get; set; }
        public string UnitTreeJson { get; set; } = "[]"; // Stored as JSON string
        public DateTime CreatedAt { get; set; }
        
        // Navigation properties
        public virtual Book Book { get; set; } = null!;
        public virtual ICollection<TranslationUnit> TranslationUnits { get; set; } = new List<TranslationUnit>();
    }
}