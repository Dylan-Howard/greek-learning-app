private static List<object> GetChapter15()
{
    // Romans 15:33-33
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ὁ", Transliteration = "Ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "now",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "θεὸς", Transliteration = "theos",
                            Gloss = "God",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "εἰρήνης", Transliteration = "eirēnēs",
                                    Gloss = "peace",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "of peace"
                        }
                    },
                    Translation = "Now the God of peace"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "πάντων", Transliteration = "pantōn",
                            Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                            PartOfSpeech = "adjective" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn",
                            Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "with you all"
                }
            },
            Translation = "Now the God of peace be with you all."
        },
        new Word { Greek = "ἀμήν", Transliteration = "amēn",
            Gloss = "amen",
            GrammarCodes = new List<string> { "HEB" },
            PartOfSpeech = "particle" }
    };
}

/*
Constructions identified:
- GEN_DESC: τῆς εἰρήνης (v33)
*/
