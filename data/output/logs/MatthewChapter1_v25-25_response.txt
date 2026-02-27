private static List<object> GetChapter1()
{
    // Matthew 1:25-25
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "ἐγίνωσκεν", Transliteration = "eginōsken",
                    Gloss = "was knowing",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτὴν", Transliteration = "autēn",
                    Gloss = "her",
                    GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs",
                            Gloss = "until",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "οὗ", Transliteration = "hou",
                            Gloss = "which [time]",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἔτεκεν", Transliteration = "eteken",
                            Gloss = "she gave birth to",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "υἱόν", Transliteration = "huion",
                                    Gloss = "a son",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "a son"
                        }
                    },
                    Translation = "until she had given birth to a son"
                }
            },
            Translation = "and knew her not until she had given birth to a son"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐκάλεσεν", Transliteration = "ekalesen",
                    Gloss = "he called",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὄνομα", Transliteration = "onoma",
                            Gloss = "name",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                            Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "his name"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰησοῦν", Transliteration = "Iēsoun",
                            Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                }
            },
            Translation = "and he called his name Jesus"
        }
    };
}

/*
Constructions:
- TEMP_CLAUSE: 1:25 (ἕως οὗ ἔτεκεν υἱόν)
- Double Accusative: 1:25 (ἐκάλεσεν τὸ ὄνομα ... Ἰησοῦν)
*/
