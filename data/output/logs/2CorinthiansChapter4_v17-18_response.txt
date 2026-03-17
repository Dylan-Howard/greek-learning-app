private static List<object> GetChapter4()
{
    // 2 Corinthians 4:17-18
    return new List<object>
    {
        // Verse 17
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
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "παραυτίκα", Transliteration = "parautika", Gloss = "momentary",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἐλαφρὸν", Transliteration = "elaphron", Gloss = "light",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θλίψεως", Transliteration = "thlipseōs", Gloss = "affliction",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "our",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "of our affliction"
                        }
                    },
                    Translation = "for the light momentary affliction of us"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθ᾽", Transliteration = "kath'", Gloss = "according to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὑπερβολὴν", Transliteration = "hyperbolēn", Gloss = "surpassingness",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὑπερβολὴν", Transliteration = "hyperbolēn", Gloss = "surpassingness",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "beyond all comparison"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἰώνιον", Transliteration = "aiōnion", Gloss = "eternal",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "βάρος", Transliteration = "baros", Gloss = "weight",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δόξης", Transliteration = "doxēs", Gloss = "of glory",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of glory"
                        }
                    },
                    Translation = "an eternal weight of glory"
                },
                new Word { Greek = "κατεργάζεται", Transliteration = "katergazetai", Gloss = "produces",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "for us",
                    GrammarCodes = new List<string> { "PRON", "DAT", "P" },
                    PartOfSpeech = "pron" }
            },
            Translation = "For this light momentary affliction is preparing for us an eternal weight of glory beyond all comparison."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "GEN_ABS" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "part" },
                new Word { Greek = "σκοπούντων", Transliteration = "skopountōn", Gloss = "looking",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "we",
                    GrammarCodes = new List<string> { "PRON", "GEN", "P" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "βλεπόμενα", Transliteration = "blepomena", Gloss = "things seen",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "N", "P" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "the things seen"
                        },
                        new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                                    GrammarCodes = new List<string> { "PART" },
                                    PartOfSpeech = "part" },
                                new Word { Greek = "βλεπόμενα", Transliteration = "blepomena", Gloss = "things not seen",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "N", "P" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "the things not seen"
                        }
                    },
                    Translation = "the things seen but the things not seen"
                }
            },
            Translation = "as we look not to the things that are seen but to the things that are unseen"
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
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "βλεπόμενα", Transliteration = "blepomena", Gloss = "things seen",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "N", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "for the things seen"
                },
                new Word { Greek = "πρόσκαιρα", Transliteration = "proskaira", Gloss = "transient",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" },
                    PartOfSpeech = "adj" }
            },
            Translation = "for the things that are seen are transient"
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
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "part" },
                        new Word { Greek = "βλεπόμενα", Transliteration = "blepomena", Gloss = "things not seen",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "N", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "but the things not seen"
                },
                new Word { Greek = "αἰώνια", Transliteration = "aiōnia", Gloss = "eternal",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" },
                    PartOfSpeech = "adj" }
            },
            Translation = "but the things that are unseen are eternal"
        }
    };
}

/*
Constructions identified:
- GEN_ABS: μὴ σκοπούντων ἡμῶν (v18) - circumstantial participial construction
- ELLIPSIS: Ellipsis of copula (εἰσίν) in v18 clauses (τὰ γὰρ βλεπόμενα πρόσκαιρα...)
*/
