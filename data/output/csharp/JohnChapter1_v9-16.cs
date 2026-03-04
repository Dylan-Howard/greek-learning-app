private static List<object> GetChapter1()
{
    // John 1:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἦν", Transliteration = "ēn", Gloss = "was",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "φῶς", Transliteration = "phōs", Gloss = "light",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀληθινόν", Transliteration = "alēthinon", Gloss = "true",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the true light"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "φωτίζει", Transliteration = "phōtizei", Gloss = "gives light to",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "every",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἄνθρωπον", Transliteration = "anthrōpon", Gloss = "man",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "every man"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐρχόμενον", Transliteration = "erchomenon", Gloss = "coming",
                                    GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "ACC", "M", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                                    PartOfSpeech = "art" },
