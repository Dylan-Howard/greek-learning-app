// Koine.Domain/ValueObjects/TranslationMapping.cs
namespace Koine.Domain.ValueObjects
{
    public class TranslationMapping
    {
        public string Path { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public int Order { get; set; }
    }
}
