private static List<object> GetChapter5()
{
    // Galatians 5:25-26
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Εἰ", Transliteration = "Ei", Gloss = "if", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ζῶμεν", Transliteration = "zōmen", Gloss = "we live", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, 
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πνεύματι", Transliteration = "pneumati", Gloss = "by the Spirit", 
                                    GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "by the Spirit"
                        }
                    },
                    Translation = "If we live by the Spirit"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πνεύματι", Transliteration = "pneumati", Gloss = "by the Spirit", 
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "by the Spirit"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "στοιχῶμεν", Transliteration = "stoichōmen", Gloss = "let us walk", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "1P", "P" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "If we live by the Spirit, let us also walk by the Spirit."
        },
        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "part" },
                new Word { Greek = "γινώμεθα", Transliteration = "ginōmetha", Gloss = "let us become", 
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "SUBJ", "1P", "P" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED_ADJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κενόδοξοι", Transliteration = "kenodoxoi", Gloss = "conceited", 
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, 
                            PartOfSpeech = "adj" }
                    },
                    Translation = "conceited"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀλλήλους", Transliteration = "allēlous", Gloss = "one another", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, 
                            PartOfSpeech = "pron" },
                        new Word { Greek = "προκαλούμενοι", Transliteration = "prokaloumenoi", Gloss = "provoking", 
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "provoking one another"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀλλήλοις", Transliteration = "allēlois", Gloss = "one another", 
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, 
                            PartOfSpeech = "pron" },
                        new Word { Greek = "φθονοῦντες", Transliteration = "phthonountes", Gloss = "envying", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "envying one another"
                }
            },
            Translation = "Let us not become conceited, provoking one another, envying one another."
        }
    };
}

/*
Constructions identified:
- DAT_INSTR: Galatians 5:25 (πνεύματι)
- PRED_ADJ: Galatians 5:26 (κενόδοξοι)
*/
