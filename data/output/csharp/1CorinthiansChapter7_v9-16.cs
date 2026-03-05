private static List<object> GetChapter7()
{
    // 1 Corinthians 7:9-16
    return new List<object>
    {
        // Verse 9
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
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐγκρατεύονται", Transliteration = "enkrateuontai", Gloss = "they have self-control", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "But if they do not have self-control"
                },
                new Word { Greek = "γαμησάτωσαν", Transliteration = "gamēsatōsan", Gloss = "let them marry", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "But if they do not have self-control, let them marry."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κρεῖττον", Transliteration = "kreitton", Gloss = "better", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "better"
                },
                new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "it is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γαμῆσαι", Transliteration = "gamēsai", Gloss = "to marry", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "to marry"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "than", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πυροῦσθαι", Transliteration = "pyrousthai", Gloss = "to burn", GrammarCodes = new List<string> { "V", "PRES", "PASS", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "than to burn"
                }
            },
            Translation = "For it is better to marry than to burn."
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Τοῖς", Transliteration = "Tois", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "γεγαμηκόσιν", Transliteration = "gegamēkosin", Gloss = "married", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "to the married"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "παραγγέλλω", Transliteration = "parangellō", Gloss = "I give charge", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "But to the married I give charge"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "APPOS" },
            Content = new List<object>
            {
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Lord"
                }
            },
            Translation = "not I, but the Lord"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γυναῖκα", Transliteration = "gunaika", Gloss = "wife", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "a wife"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀνδρὸς", Transliteration = "andros", Gloss = "husband", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "from her husband"
                },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "χωρισθῆναι", Transliteration = "chōristhēnai", Gloss = "to be separated", GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" }, PartOfSpeech = "v" }
            },
            Translation = "that a wife should not be separated from her husband"
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 10)
                new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "even", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "χωρισθῇ", Transliteration = "chōristhē", Gloss = "she is separated", GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "but if indeed she is separated"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μενέτω", Transliteration = "menetō", Gloss = "let her remain", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED_ADJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄγαμος", Transliteration = "agamos", Gloss = "unmarried", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "unmarried"
                }
            },
            Translation = "let her remain unmarried"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀνδρὶ", Transliteration = "andri", Gloss = "husband", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to her husband"
                },
                new Word { Greek = "καταλλαγήτω", Transliteration = "katallagētō", Gloss = "let her be reconciled", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IMP", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "or let her be reconciled to her husband"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄνδρα", Transliteration = "andra", Gloss = "husband", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the husband"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γυναῖκα", Transliteration = "gunaika", Gloss = "wife", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "his wife"
                },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἀφιέναι", Transliteration = "aphienai", Gloss = "to divorce", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
            },
            Translation = "and that the husband should not divorce his wife."
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Τοῖς", Transliteration = "Tois", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "λοιποῖς", Transliteration = "loipois", Gloss = "rest", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "to the rest"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Lord"
                }
            },
            Translation = "But to the rest I say, not the Lord:"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἴ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τις", Transliteration = "tis", Gloss = "any", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "part" },
                        new Word { Greek = "ἀδελφὸς", Transliteration = "adelphos", Gloss = "brother", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "any brother"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γυναῖκα", Transliteration = "gunaika", Gloss = "wife", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἄπιστον", Transliteration = "apiston", Gloss = "unbelieving", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "an unbelieving wife"
                },
                new Word { Greek = "ἔχει", Transliteration = "echei", Gloss = "has", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "αὕτη", Transliteration = "hautē", Gloss = "she", GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" }, PartOfSpeech = "adv" },
                new Word { Greek = "συνευδοκεῖ", Transliteration = "syneudokei", Gloss = "consents", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἰκεῖν", Transliteration = "oikein", Gloss = "to live", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μετ᾽", Transliteration = "met'", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "with him"
                        }
                    },
                    Translation = "to live with him"
                }
            },
            Translation = "if any brother has an unbelieving wife and she consents to live with him"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἀφιέτω", Transliteration = "aphietō", Gloss = "let him divorce", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτήν", Transliteration = "autēn", Gloss = "her", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "prep" }
            },
            Translation = "let him not divorce her."
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γυνὴ", Transliteration = "gunē", Gloss = "woman", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "a woman"
                }
            },
            Translation = "And a woman,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἴ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τις", Transliteration = "tis", Gloss = "any", GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" }, PartOfSpeech = "part" },
                new Word { Greek = "ἔχει", Transliteration = "echei", Gloss = "has", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄνδρα", Transliteration = "andra", Gloss = "husband", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἄπιστον", Transliteration = "apiston", Gloss = "unbelieving", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "an unbelieving husband"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "he", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "adv" },
                new Word { Greek = "συνευδοκεῖ", Transliteration = "syneudokei", Gloss = "consents", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἰκεῖν", Transliteration = "oikein", Gloss = "to live", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μετ᾽", Transliteration = "met'", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτῆς", Transliteration = "autēs", Gloss = "her", GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "with her"
                        }
                    },
                    Translation = "to live with her"
                }
            },
            Translation = "if any has an unbelieving husband and he consents to live with her"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἀφιέτω", Transliteration = "aphietō", Gloss = "let her divorce", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἄνδρα", Transliteration = "andra", Gloss = "husband", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the husband"
                }
            },
            Translation = "let her not divorce the husband."
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἡγίασται", Transliteration = "hēgiastai", Gloss = "is sanctified", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀνὴρ", Transliteration = "anēr", Gloss = "husband", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἄπιστος", Transliteration = "apistos", Gloss = "unbelieving", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the unbelieving husband"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γυναικὶ", Transliteration = "gunaiki", Gloss = "wife", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "through the wife"
                }
            },
            Translation = "For the unbelieving husband is sanctified through the wife,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἡγίασται", Transliteration = "hēgiastai", Gloss = "is sanctified", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γυνὴ", Transliteration = "gunē", Gloss = "wife", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἄπιστος", Transliteration = "apistos", Gloss = "unbelieving", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the unbelieving wife"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀδελφῷ", Transliteration = "adelphō", Gloss = "brother", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "through the brother"
                }
            },
            Translation = "and the unbelieving wife is sanctified through the brother."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐπεὶ", Transliteration = "epei", Gloss = "since", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἄρα", Transliteration = "ara", Gloss = "otherwise", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "τέκνα", Transliteration = "tekna", Gloss = "children", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "your", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your children"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED_ADJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀκάθαρτά", Transliteration = "akatharta", Gloss = "unclean", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "unclean"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "would be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Otherwise your children would be unclean,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED_ADJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἅγιά", Transliteration = "hagia", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "holy"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "they are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "but now they are holy."
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἄπιστος", Transliteration = "apistos", Gloss = "unbeliever", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the unbeliever"
                },
                new Word { Greek = "χωρίζεται", Transliteration = "chōrizetai", Gloss = "separates", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "But if the unbeliever separates,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "χωριζέσθω", Transliteration = "chōrizesthō", Gloss = "let him separate", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IMP", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "let him separate."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "δεδούλωται", Transliteration = "dedoulōtai", Gloss = "is enslaved", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀδελφὸς", Transliteration = "adelphos", Gloss = "brother", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀδελφὴ", Transliteration = "adelphē", Gloss = "sister", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the brother or the sister"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "τοιούτοις", Transliteration = "toioutois", Gloss = "such cases", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "P" }, PartOfSpeech = "adv" }
                    },
                    Translation = "in such cases."
                }
            },
            Translation = "In such cases the brother or sister is not enslaved."
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
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "εἰρήνῃ", Transliteration = "eirēnē", Gloss = "peace", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "but to peace"
                },
                new Word { Greek = "κέκληκεν", Transliteration = "keklēken", Gloss = "has called", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεός", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "God"
                }
            },
            Translation = "But God has called you to peace."
        },

        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τί", Transliteration = "ti", Gloss = "how", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "interj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οἶδας", Transliteration = "oidas", Gloss = "do you know", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γύναι", Transliteration = "gunai", Gloss = "wife", GrammarCodes = new List<string> { "N", "VOC", "F", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἄνδρα", Transliteration = "andra", Gloss = "husband", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the husband"
                        },
                        new Word { Greek = "σώσεις", Transliteration = "sōseis", Gloss = "you will save", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "whether you will save your husband?"
                }
            },
            Translation = "For how do you know, wife, whether you will save your husband?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τί", Transliteration = "ti", Gloss = "how", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "interj" },
                new Word { Greek = "οἶδας", Transliteration = "oidas", Gloss = "do you know", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἄνερ", Transliteration = "aner", Gloss = "husband", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "γυναῖκα", Transliteration = "gunaika", Gloss = "wife", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the wife"
                        },
                        new Word { Greek = "σώσεις", Transliteration = "sōseis", Gloss = "you will save", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "whether you will save your wife?"
                }
            },
            Translation = "Or how do you know, husband, whether you will save your wife?"
        }
    };
}

/*
Constructions identified:
- COND_CLAUSE: 7:9, 7:11, 7:12, 7:13, 7:15
- IND_OBJ (Dative of interest): 7:10 (Τοῖς γεγαμηκόσιν), 7:11 (τῷ ἀνδρὶ), 7:12 (Τοῖς λοιποῖς)
- APPOS: 7:10 (οὐκ ἐγὼ ἀλλ᾽ ὁ κύριος)
- INF_PHRASE as SUBJ/OBJ: 7:9 (γαμῆσαι), 7:10 (χωρισθῆναι), 7:11 (ἀφιέναι), 7:12 (οἰκεῖν), 7:13 (οἰκεῖν)
- VOC: 7:16 (γύναι, ἄνερ)
- CAUSAL_CLAUSE: 7:14 (ἐπεὶ ἄρα...)
*/
