private static List<object> GetChapter6()
{
    // Revelation 6:17-17
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἦλθεν", Transliteration = "", Gloss = "has come",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἡμέρα", Transliteration = "", Gloss = "day",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἡ", Transliteration = "", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μεγάλη", Transliteration = "", Gloss = "great",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὀργῆς", Transliteration = "", Gloss = "wrath",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῶν", Transliteration = "", Gloss = "their",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "of their wrath"
                        }
                    },
                    Translation = "the great day of their wrath"
                }
            },
            Translation = "For the great day of their wrath has come"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τίς", Transliteration = "", Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "who"
                },
                new Word { Greek = "δύναται", Transliteration = "", Gloss = "is able",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σταθῆναι", Transliteration = "", Gloss = "to stand",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "to stand"
                }
            },
            Translation = "and who is able to stand?"
        }
    };
}

/*
Identified Constructions:
- GEN_SUBJ (τῆς ὀργῆς αὐτῶν, verse 17)
*/
