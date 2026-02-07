// GreekParser.Domain/Entities/TranslationUnit.cs
namespace GreekParser.Domain.Entities
{
    public class TranslationUnit
    {
        public int Id { get; set; }
        public int TranslationId { get; set; }
        public int ChapterId { get; set; }
        public string OriginalUnitPath { get; set; } = string.Empty;
        public string TranslatedText { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public string? ScopeStart { get; set; }
        public string? ScopeEnd { get; set; }
        
        // Navigation properties
        public virtual Translation Translation { get; set; } = null!;
        public virtual Chapter Chapter { get; set; } = null!;
    }
}
