private static List<object> GetChapter4()
{
    // Romans 4:25-25
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃς", Transliteration = "hos",
                    Gloss = "who",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "παρεδόθη", Transliteration = "paredothē",
                    Gloss = "was delivered up",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia",
                            Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "παραπτώματα", Transliteration = "paraptōmata",
                                    Gloss = "trespasses",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn",
                                    Gloss = "our",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "our trespasses"
                        }
                    },
                    Translation = "for our trespasses"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "ἠγέρθη", Transliteration = "ēgerthē",
                    Gloss = "was raised",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia",
                            Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "δικαίωσιν", Transliteration = "dikaiōsin",
                                    Gloss = "justification",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn",
                                    Gloss = "our",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "our justification"
                        }
                    },
                    Translation = "for our justification"
                }
            },
            Translation = "who was delivered up for our trespasses and was raised for our justification"
        }
    };
}
/*
Constructions identified:
- REL_CLAUSE: Romans 4:25 (ὃς ...)
- PREP_PHRASE (Causal διὰ): Romans 4:25
*/
