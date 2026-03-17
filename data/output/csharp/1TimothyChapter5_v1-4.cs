private static List<object> GetChapter5()
{
    // 1 Timothy 5:1-4
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Πρεσβυτέρῳ", Transliteration = "",
                            Gloss = "older",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "μὴ", Transliteration = "",
                            Gloss = "no",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἐπιπλήξῃς", Transliteration = "",
                            Gloss = "to rebuke",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "Do not rebuke an older man"
                },
                new Word { Greek = "ἀλλὰ", Transliteration = "",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρακάλει", Transliteration = "",
                            Gloss = "to ask",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὡς", Transliteration = "",
                                    Gloss = "as",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "πατέρα", Transliteration = "",
                                    Gloss = "father",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "as a father"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "νεωτέρους", Transliteration = "",
                                    Gloss = "new",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "younger men"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὡς", Transliteration = "",
                                    Gloss = "as",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "ἀδελφούς", Transliteration = "",
                                    Gloss = "brother",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "as brothers"
                        },
                        // Verse 2
                        // (continues verse 1)
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρεσβυτέρας", Transliteration = "",
                                    Gloss = "older",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "older women"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὡς", Transliteration = "",
                                    Gloss = "as",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "μητέρας", Transliteration = "",
                                    Gloss = "mother",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "as mothers"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "νεωτέρας", Transliteration = "",
                                    Gloss = "new",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "younger women"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὡς", Transliteration = "",
                                    Gloss = "as",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "ἀδελφὰς", Transliteration = "",
                                    Gloss = "sister",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "as sisters"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_MANNER" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "",
                                    Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "πάσῃ", Transliteration = "",
                                    Gloss = "all",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἁγνείᾳ", Transliteration = "",
                                    Gloss = "purity",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in all purity"
                        }
                    },
                    Translation = "encourage him as a father, younger men as brothers, older women as mothers, younger women as sisters, in all purity"
                }
            },
            Translation = "Do not rebuke an older man but encourage him as a father, younger men as brothers, older women as mothers, younger women as sisters, in all purity."
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Χήρας", Transliteration = "",
                            Gloss = "widow",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "τίμα", Transliteration = "",
                            Gloss = "to honor",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὄντως", Transliteration = "",
                                    Gloss = "really",
                                    GrammarCodes = new List<string> { "ADJ" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "χήρας", Transliteration = "",
                                    Gloss = "widow",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "widows who are truly widows"
                        }
                    },
                    Translation = "Honor widows who are truly widows"
                }
            },
            Translation = "Honor widows who are truly widows."
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "",
                    Gloss = "if",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "δέ", Transliteration = "",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τις", Transliteration = "",
                            Gloss = "someone",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "part" },
                        new Word { Greek = "χήρα", Transliteration = "",
                            Gloss = "widow",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "any widow"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τέκνα", Transliteration = "",
                                    Gloss = "child",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἢ", Transliteration = "",
                                    Gloss = "either...or",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "ἔκγονα", Transliteration = "",
                                    Gloss = "grandchild",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "children or grandchildren"
                        },
                        new Word { Greek = "ἔχει", Transliteration = "",
                            Gloss = "to have",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "has children or grandchildren"
                }
            },
            Translation = "But if a widow has children or grandchildren"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μανθανέτωσαν", Transliteration = "",
                            Gloss = "to learn",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "πρῶτον", Transliteration = "",
                            Gloss = "first",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὸν", Transliteration = "",
                                                    Gloss = "the",
                                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "ἴδιον", Transliteration = "",
                                                    Gloss = "one's own",
                                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                                    PartOfSpeech = "adj" },
                                                new Word { Greek = "οἶκον", Transliteration = "",
                                                    Gloss = "house",
                                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                                    PartOfSpeech = "n" }
                                            },
                                            Translation = "their own household"
                                        },
                                        new Word { Greek = "εὐσεβεῖν", Transliteration = "",
                                            Gloss = "to worship",
                                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                                            PartOfSpeech = "v" }
                                    },
                                    Translation = "to show godliness to their own household"
                                }
                            },
                            Translation = "to show godliness to their own household"
                        },
                        new Word { Greek = "καὶ", Transliteration = "",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἀμοιβὰς", Transliteration = "",
                                                    Gloss = "repayment",
                                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                                    PartOfSpeech = "n" }
                                            },
                                            Translation = "repayment"
                                        },
                                        new Word { Greek = "ἀποδιδόναι", Transliteration = "",
                                            Gloss = "give",
                                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                                            PartOfSpeech = "v" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῖς", Transliteration = "",
                                                    Gloss = "the",
                                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "προγόνοις", Transliteration = "",
                                                    Gloss = "parents",
                                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                                                    PartOfSpeech = "adj" }
                                            },
                                            Translation = "to their parents"
                                        }
                                    },
                                    Translation = "to make some return to their parents"
                                }
                            },
                            Translation = "to make some return to their parents"
                        }
                    },
                    Translation = "let them first learn to show godliness to their own household and to make some return to their parents"
                }
            },
            Translation = "let them first learn to show godliness to their own household and to make some return to their parents"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τοῦτο", Transliteration = "",
                    Gloss = "this",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "γάρ", Transliteration = "",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐστιν", Transliteration = "",
                            Gloss = "to be",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PRED_ADJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπόδεκτον", Transliteration = "",
                                    Gloss = "pleasing",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "pleasing"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐνώπιον", Transliteration = "",
                                    Gloss = "before",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τοῦ", Transliteration = "",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "",
                                    Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in the sight of God"
                        }
                    },
                    Translation = "is pleasing in the sight of God"
                }
            },
            Translation = "for this is pleasing in the sight of God"
        }
    };
}