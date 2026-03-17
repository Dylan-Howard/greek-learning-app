private static List<object> GetChapter15()
{
    // 1 Corinthians 15:33-35
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "πλανᾶσθε", Transliteration = "planasthe",
                    Gloss = "be deceived",
                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "IMP", "2P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "Do not be deceived:"
        },
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
                        new Word { Greek = "ὁμιλίαι", Transliteration = "homiliai",
                            Gloss = "company",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "κακαί", Transliteration = "kakai",
                            Gloss = "bad",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "Bad company"
                },
                new Word { Greek = "φθείρουσιν", Transliteration = "phtheirousin",
                    Gloss = "corrupts",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἤθη", Transliteration = "ēthē",
                            Gloss = "morals",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "χρηστὰ", Transliteration = "chrēsta",
                            Gloss = "good",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "good morals"
                }
            },
            Translation = "Bad company corrupts good morals."
        },

        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐκνήψατε", Transliteration = "eknēpsate",
                    Gloss = "wake up",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δικαίως", Transliteration = "dikaiōs",
                    Gloss = "righteously",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "μὴ", Transliteration = "mē",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἁμαρτάνετε", Transliteration = "hamartanete",
                    Gloss = "sin",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "Wake up from your drunken stupor, as is right, and do not go on sinning."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀγνωσίαν", Transliteration = "agnōsian",
                    Gloss = "ignorance",
                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θεοῦ", Transliteration = "theou",
                            Gloss = "of God",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "of God"
                },
                new Word { Greek = "τινες", Transliteration = "tines",
                    Gloss = "some",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                    PartOfSpeech = "part" },
                new Word { Greek = "ἔχουσιν", Transliteration = "echousin",
                    Gloss = "have",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "For some have no knowledge of God."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἐντροπὴν", Transliteration = "entropēn",
                            Gloss = "shame",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to shame"
                },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin",
                    Gloss = "your",
                    GrammarCodes = new List<string> { "PRON", "DAT", "P" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "λαλῶ", Transliteration = "lalō",
                    Gloss = "I speak",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "I say this to your shame."
        },

        // Verse 35
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀλλ᾽", Transliteration = "All’",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐρεῖ", Transliteration = "erei",
                    Gloss = "will say",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "τις", Transliteration = "tis",
                    Gloss = "someone",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "part" }
            },
            Translation = "But someone will say,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πῶς", Transliteration = "pōs",
                    Gloss = "how",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἐγείρονται", Transliteration = "egeirontai",
                    Gloss = "are raised",
                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "νεκροί", Transliteration = "nekroi",
                            Gloss = "dead",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the dead?"
                }
            },
            Translation = "“How are the dead raised?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ποίῳ", Transliteration = "poiō",
                            Gloss = "with what kind of",
                            GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" },
                            PartOfSpeech = "interj" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "σώματι", Transliteration = "sōmati",
                            Gloss = "body",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "With what kind of body"
                },
                new Word { Greek = "ἔρχονται", Transliteration = "erchontai",
                    Gloss = "do they come",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "With what kind of body do they come?”"
        }
    };
}

/*
Constructions identified:
- DAT_INSTR: ποίῳ... σώματι (v35) - Dative of instrument/manner
- GEN_OBJ: ἀγνωσίαν... θεοῦ (v34) - Objective genitive (ignorance of God)
*/
