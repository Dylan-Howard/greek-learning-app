// Koine.Infrastructure.Data.Seed/FirstJohnTextData.cs
using System.Text.Json.Serialization;

namespace Koine.Infrastructure.Data.Seed
{
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

    public static class FirstJohnTextData
    {
        public static Dictionary<int, List<SeedUnitNode>> GetChapters()
        {
            return new Dictionary<int, List<SeedUnitNode>>
            {
                { 1, GetChapter1() },
                { 2, GetChapter2() },
                { 3, GetChapter3() },
                { 4, GetChapter4() },
                { 5, GetChapter5() }
            };
        }

        private static List<SeedUnitNode> GetChapter1()
        {
            // 1 John 1:1-5 (simplified for example)
            return new List<SeedUnitNode>
            {
                new SeedUnitNode
                {
                    Type = "unit",
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Translation = "That which was from the beginning, which we have heard, which we have seen with our eyes",
                    Children = new List<SeedUnitNode>
                    {
                        new SeedUnitNode
                        {
                            Type = "unit",
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Translation = "That which was from the beginning",
                            Children = new List<SeedUnitNode>
                            {
                                new SeedUnitNode { Root = "Ὃ", Transliteration = "Ho", Gloss = "that which", GrammarCodes = new List<string> { "PRON", "NOM", "NEUT", "S" }, PartOfSpeech = "pronoun" },
                                new SeedUnitNode { Root = "ἦν", Transliteration = "ēn", Gloss = "was", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                                new SeedUnitNode
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Translation = "from the beginning",
                                    Children = new List<SeedUnitNode>
                                    {
                                        new SeedUnitNode { Root = "ἀπ'", Transliteration = "ap'", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new SeedUnitNode { Root = "ἀρχῆς", Transliteration = "archēs", Gloss = "beginning", GrammarCodes = new List<string> { "NEUT", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                                    }
                                }
                            }
                        },
                        new SeedUnitNode
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Translation = "which we have heard",
                            Children = new List<SeedUnitNode>
                            {
                                new SeedUnitNode { Root = "ὃ", Transliteration = "ho", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "NEUT", "S" }, PartOfSpeech = "pronoun" },
                                new SeedUnitNode { Root = "ἀκηκόαμεν", Transliteration = "akēkoamen", Gloss = "we have heard", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" }
                            }
                        }
                    }
                },
                // Verse 2
                new SeedUnitNode
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Translation = "and the life was manifested",
                    Children = new List<SeedUnitNode>
                    {
                        new SeedUnitNode { Root = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new SeedUnitNode
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Translation = "the life",
                            Children = new List<SeedUnitNode>
                            {
                                new SeedUnitNode { Root = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                                new SeedUnitNode { Root = "ζωὴ", Transliteration = "zōē", Gloss = "life", GrammarCodes = new List<string> { "NEUT", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                            }
                        },
                        new SeedUnitNode { Root = "ἐφανερώθη", Transliteration = "ephanerōthē", Gloss = "was manifested", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                    }
                }
            };
        }

        private static List<SeedUnitNode> GetChapter2() => new List<SeedUnitNode>();
        private static List<SeedUnitNode> GetChapter3() => new List<SeedUnitNode>();
        private static List<SeedUnitNode> GetChapter4() => new List<SeedUnitNode>();
        private static List<SeedUnitNode> GetChapter5() => new List<SeedUnitNode>();

        public static List<(string Root, string Transliteration, string Gloss, string PartOfSpeech, int FrequencyRank)> GetVocabulary()
        {
            return new List<(string, string, string, string, int)>
            {
                ("ὁ", "ho", "the", "article", 1),
                ("ἡ", "hē", "the", "article", 2),
                ("τό", "to", "the", "article", 3),
                ("καί", "kai", "and", "conjunction", 4),
                ("ἐστιν", "estin", "is", "verb", 5),
                ("θεός", "theos", "God", "noun", 6),
                ("Ἰησοῦς", "Iēsous", "Jesus", "noun", 7),
                ("Χριστός", "Christos", "Christ", "noun", 8),
                ("ἀγάπη", "agapē", "love", "noun", 9),
                ("ζωή", "zōē", "life", "noun", 10),
                ("φῶς", "phōs", "light", "noun", 11)
            };
        }
    }
}
