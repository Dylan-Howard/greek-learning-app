// Koine.Domain/Entities/Translation.cs
namespace Koine.Domain.Entities
{
    public class Translation
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string LanguageCode { get; set; } = "en";
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        
        // Navigation properties
        public virtual Book Book { get; set; } = null!;
        public virtual ICollection<TranslationUnit> TranslationUnits { get; set; } = new List<TranslationUnit>();
    }
}
