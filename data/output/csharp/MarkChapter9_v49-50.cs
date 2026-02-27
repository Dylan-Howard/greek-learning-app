private static List<object> GetChapter9()
{
    // Mark 9:49-50
    return new List<object>
    {
        // Verse 49
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
                        new Word { Greek = "Πᾶς", Transliteration = "Pas",
                            Gloss = "everyone",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "everyone"
                },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πυρὶ", Transliteration = "pyri",
                            Gloss = "fire",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "with fire"
                },
                new Word { Greek = "ἁλισθήσεται", Transliteration = "halisthēsetai",
                    Gloss = "will be salted",
                    GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "For everyone will be salted with fire."
        },

        // Verse 50
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καλὸν", Transliteration = "kalon",
                    Gloss = "good",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἅλας", Transliteration = "halas",
                            Gloss = "salt",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the salt"
                }
            },
            Translation = "Salt is good."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐὰν", Transliteration = "ean",
                    Gloss = "if",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἅλας", Transliteration = "halas",
                            Gloss = "salt",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the salt"
                },
                new Word { Greek = "ἄναλον", Transliteration = "analon",
                    Gloss = "not salty",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "γένηται", Transliteration = "genētai",
                    Gloss = "becomes",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "but if the salt has lost its saltiness"
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
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τίνι", Transliteration = "tini",
                            Gloss = "what?",
                            GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" },
                            PartOfSpeech = "interj" }
                    },
                    Translation = "with what"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτὸ", Transliteration = "auto",
                            Gloss = "it",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "it"
                },
                new Word { Greek = "ἀρτύσετε", Transliteration = "artysete",
                    Gloss = "will you season",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "how will you season it?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔχετε", Transliteration = "echete",
                    Gloss = "Have",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἑαυτοῖς", Transliteration = "heautois",
                            Gloss = "yourselves",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                            PartOfSpeech = "f" }
                    },
                    Translation = "in yourselves"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἅλα", Transliteration = "hala",
                            Gloss = "salt",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "salt"
                }
            },
            Translation = "Have salt in yourselves"
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
                new Word { Greek = "εἰρηνεύετε", Transliteration = "eirēneuete",
                    Gloss = "be at peace",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἀλλήλοις", Transliteration = "allēlois",
                            Gloss = "one another",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                            PartOfSpeech = "conj" }
                    },
                    Translation = "with one another"
                }
            },
            Translation = "and be at peace with one another."
        }
    };
}

/*
Constructions Identified:
- DAT_INSTR: πυρὶ (9:49)
- COND_CLAUSE: ἐὰν δὲ τὸ ἅλας ἄναλον γένηται (9:50)
- PRED: καλὸν (9:50), ἄναλον (9:50)
*/
