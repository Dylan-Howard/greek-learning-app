using System.Collections.Generic;

namespace Koine.Infrastructure.Data.Seed
{
    public class Word
    {
        public string Greek { get; set; } = string.Empty;
        public string Transliteration { get; set; } = string.Empty;
        public string Gloss { get; set; } = string.Empty;
        public List<string> GrammarCodes { get; set; } = new();
        public string PartOfSpeech { get; set; } = string.Empty;
    }

    public class Phrase
    {
        public List<string> SyntaxCodes { get; set; } = new();
        public List<object> Content { get; set; } = new(); // Can be Word or Phrase
        public string Translation { get; set; } = string.Empty;
    }

    public class SeedUnitNode
    {
        public string Type { get; set; } = "unit";
        public string? Root { get; set; }
        public List<string>? GrammarCodes { get; set; }
        public List<string>? SyntaxCodes { get; set; }
        public string? Translation { get; set; }
        public List<SeedUnitNode>? Children { get; set; }
        public string? PartOfSpeech { get; set; }
        public string? Gloss { get; set; }
        public string? Transliteration { get; set; }
        
        // For meta nodes
        public string? Content { get; set; }
        public string? Marker { get; set; }
    }
}
