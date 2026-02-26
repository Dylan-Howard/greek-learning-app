private static List<object> GetChapter26()
{
    // Matthew 26:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_TIME" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Τῇ", Transliteration = "Tē", Gloss = "on the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πρώτῃ", Transliteration = "prōtē", Gloss = "first [day]", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀζύμων", Transliteration = "azymōn", Gloss = "unleavened bread", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "of the unleavened bread"
                        }
                    },
                    Translation = "Now on the first day of unleavened bread"
                },
                new Word { Greek = "προσῆλθον", Transliteration = "prosēlthon", Gloss = "came", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the disciples"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ποῦ", Transliteration = "pou", Gloss = "Where", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                                new Word { Greek = "θέλεις", Transliteration = "theleis", Gloss = "do You want", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἑτοιμάσωμέν", Transliteration = "hetoimasōmen", Gloss = "us to prepare", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" }, PartOfSpeech = "v" },
                                        new Word { Greek = "σοι", Transliteration = "soi", Gloss = "for You", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "pron" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "φαγεῖν", Transliteration = "phagein", Gloss = "to eat", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, Part
