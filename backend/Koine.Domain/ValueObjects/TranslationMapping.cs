// GreekParser.Domain/ValueObjects/TranslationMapping.cs
namespace GreekParser.Domain.ValueObjects
{
    public class TranslationMapping
    {
        public string Path { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public int Order { get; set; }
    }
}
