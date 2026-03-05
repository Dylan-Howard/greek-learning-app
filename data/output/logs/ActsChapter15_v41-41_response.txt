private static List<object> GetChapter15()
{
    // Acts 15:41-41
    return new List<object>
    {
        // Verse 41
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "διήρχετο", Transliteration = "Diērcheto", 
                    Gloss = "he went through", 
                    GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", 
                    Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", 
                                    Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Συρίαν", Transliteration = "Syrian", 
                                    Gloss = "Syria", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "Syria"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", 
                            Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", 
                                    Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Κιλικίαν", Transliteration = "Kilikian", 
                                    Gloss = "Cilicia", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "Cilicia"
                        }
                    },
                    Translation = "Syria and Cilicia"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπιστηρίζων", Transliteration = "epistērizōn", 
                            Gloss = "strengthening", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, 
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas", 
                                    Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐκκλησίας", Transliteration = "ekklēsias", 
                                    Gloss = "churches", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the churches"
                        }
                    },
                    Translation = "strengthening the churches"
                }
            },
            Translation = "And he went through Syria and Cilicia, strengthening the churches."
        }
    };
}

// Constructions identified:
// None.
