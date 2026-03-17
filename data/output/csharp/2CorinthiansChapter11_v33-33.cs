private static List<object> GetChapter11()
{
    // 2 Corinthians 11:33-33
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "θυρίδος", Transliteration = "thyridos", Gloss = "window", 
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "through a window"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "σαργάνῃ", Transliteration = "sarganē", Gloss = "basket", 
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "in a basket"
                },
                new Word { Greek = "ἐχαλάσθην", Transliteration = "echalasthēn", Gloss = "I was lowered", 
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "τείχους", Transliteration = "teichous", Gloss = "wall", 
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the wall"
                        }
                    },
                    Translation = "through the wall"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐξέφυγον", Transliteration = "exephygon", Gloss = "I escaped", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "χεῖρας", Transliteration = "cheiras", Gloss = "hands", 
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, 
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, 
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "his hands"
                }
            },
            Translation = "and through a window in a basket I was lowered through the wall and I escaped his hands"
        }
    };
}

// Constructions Identified:
// (none)
