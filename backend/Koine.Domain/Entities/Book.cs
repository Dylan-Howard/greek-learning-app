// Koine.Domain/Entities/Book.cs
namespace Koine.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string LanguageCode { get; set; } = "grc";
        public DateTime CreatedAt { get; set; }
        
        // Navigation properties
        public virtual ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();
        public virtual ICollection<Translation> Translations { get; set; } = new List<Translation>();
    }
}
