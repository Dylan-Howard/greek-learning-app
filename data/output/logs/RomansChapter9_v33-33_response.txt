private static List<object> GetChapter9()
{
    // Romans 9:33-33
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "as", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it is written", 
                    GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "as it is written,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "interj" },
                new Word { Greek = "τίθημι", Transliteration = "tithēmi", Gloss = "I place", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Σιὼν", Transliteration = "Siōn", Gloss = "Zion", 
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "in Zion"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λίθον", Transliteration = "lithon", Gloss = "a stone", 
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, 
                            PartOfSpeech = "n" },
                        new Word { Greek = "προσκόμματος", Transliteration = "proskommatos", Gloss = "of stumbling", 
                            GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "a stone of stumbling"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πέτραν", Transliteration = "petran", Gloss = "a rock", 
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, 
                            PartOfSpeech = "n" },
                        new Word { Greek = "σκανδάλου", Transliteration = "skandalou", Gloss = "of offense", 
                            GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "a rock of offense"
                }
            },
            Translation = "Behold, I am laying in Zion a stone of stumbling and a rock of offense,"
        },
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the (one)", 
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, 
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πιστεύων", Transliteration = "pisteuōn", Gloss = "believing", 
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, 
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "on", 
                                            GrammarCodes = new List<string> { "PREP" }, 
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", 
                                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, 
                                            PartOfSpeech = "pron" }
                                    },
                                    Translation = "on him"
                                }
                            },
                            Translation = "believing on him"
                        }
                    },
                    Translation = "the one believing on him"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "adv" },
                new Word { Greek = "καταισχυνθήσεται", Transliteration = "kataischynthēsetai", Gloss = "will be put to shame", 
                    GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "and whoever believes on him will not be put to shame."
        }
    };
}

// Constructions:
// 9:33 - GEN_DESC (λίθον προσκόμματος, πέτραν σκανδάλου)
