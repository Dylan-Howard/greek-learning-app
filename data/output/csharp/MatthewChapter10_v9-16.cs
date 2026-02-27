private static List<object> GetChapter10()
{
    // Matthew 10:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Μὴ", Transliteration = "Mē", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "κτήσησθε", Transliteration = "ktēsēsthe", Gloss = "acquire",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χρυσὸν", Transliteration = "chryson", Gloss = "gold",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μηδὲ", Transliteration = "mēde", Gloss = "nor",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἄργυρον", Transliteration = "argyron", Gloss = "silver",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μηδὲ", Transliteration = "mēde", Gloss = "nor",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "χαλκὸν", Transliteration = "chalkon", Gloss = "copper",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "gold nor silver nor copper"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ζώνας", Transliteration = "zōnas", Gloss = "belts",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P", "2P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "your belts"
                        }
                    },
                    Translation = "into your belts"
                }
            },
            Translation = "Acquire no gold nor silver nor copper for your belts,"
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 9 command structure)
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "no",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πήραν", Transliteration = "pēran", Gloss = "bag",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "a bag"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὁδὸν", Transliteration = "hodon", Gloss = "journey",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "for the journey"
                },
                new Word { Greek = "μηδὲ", Transliteration = "mēde", Gloss = "nor",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δύο", Transliteration = "dyo", Gloss = "two",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "χιτῶνας", Transliteration = "chitōnas", Gloss = "tunics",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "two tunics"
                },
                new Word { Greek = "μηδὲ", Transliteration = "mēde", Gloss = "nor",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑποδήματα", Transliteration = "hypodēmata", Gloss = "sandals",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "sandals"
                },
                new Word { Greek = "μηδὲ", Transliteration = "mēde", Gloss = "nor",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ῥάβδον", Transliteration = "rabdon", Gloss = "staff",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "a staff"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄξιος", Transliteration = "axios", Gloss = "worthy",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐργάτης", Transliteration = "ergatēs", Gloss = "worker",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the worker"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "τροφῆς", Transliteration = "trophēs", Gloss = "food",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "his food"
                        }
                    },
                    Translation = "for the worker is worthy of his food"
                }
            },
            Translation = "no bag for your journey, nor two tunics, nor sandals, nor a staff, for the worker is worthy of his food."
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Εἰς", Transliteration = "Eis", Gloss = "into",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἣν", Transliteration = "hēn", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "δ᾽", Transliteration = "d'", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "ever",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πόλιν", Transliteration = "polin", Gloss = "town",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "κώμην", Transliteration = "kōmēn", Gloss = "village",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "town or village"
                        },
                        new Word { Greek = "εἰσέλθητε", Transliteration = "eiselthēte", Gloss = "you enter",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "And whatever town or village you enter"
                },
                new Word { Greek = "ἐξετάσατε", Transliteration = "exetasate", Gloss = "find out",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τίς", Transliteration = "tis", Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "interj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτῇ", Transliteration = "autē", Gloss = "it",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "in it"
                        },
                        new Word { Greek = "ἄξιός", Transliteration = "axios", Gloss = "worthy",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "who in it is worthy"
                },
                new Word { Greek = "κἀκεῖ", Transliteration = "kakei", Gloss = "and there",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "μείνατε", Transliteration = "meinate", Gloss = "stay",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "until",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "ever",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἐξέλθητε", Transliteration = "exelthēte", Gloss = "you leave",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "until you leave"
                }
            },
            Translation = "And whatever town or village you enter, find out who in it is worthy and stay there until you leave."
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰσερχόμενοι", Transliteration = "eiserchomenoi", Gloss = "as you enter",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "οἰκίαν", Transliteration = "oikian", Gloss = "house",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the house"
                                }
                            },
                            Translation = "into the house"
                        }
                    },
                    Translation = "As you enter the house"
                },
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe", Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτήν", Transliteration = "autēn", Gloss = "it",
                    GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "As you enter the house, greet it."
        },

        // Verse 13
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
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ᾖ", Transliteration = "ē", Gloss = "be",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "οἰκία", Transliteration = "oikia", Gloss = "house",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the house"
                        },
                        new Word { Greek = "ἀξία", Transliteration = "axia", Gloss = "worthy",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "And if the house is worthy"
                },
                new Word { Greek = "ἐλθάτω", Transliteration = "elthatō", Gloss = "let come",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "εἰρήνη", Transliteration = "eirēnē", Gloss = "peace",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "P", "2P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "your peace"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "upon",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτήν", Transliteration = "autēn", Gloss = "it",
                            GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "upon it"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ᾖ", Transliteration = "ē", Gloss = "be",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἀξία", Transliteration = "axia", Gloss = "worthy",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "but if it is not worthy"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "εἰρήνη", Transliteration = "eirēnē", Gloss = "peace",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "P", "2P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "your peace"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "ACC", "P", "2P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "to you"
                },
                new Word { Greek = "ἐπιστραφήτω", Transliteration = "epistraphētō", Gloss = "let it return",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IMP", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "And if the house is worthy, let your peace come upon it; but if it is not worthy, let your peace return to you."
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "whoever",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "ever",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "δέξηται", Transliteration = "dexētai", Gloss = "receives",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "ACC", "P", "2P" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "μηδὲ", Transliteration = "mēde", Gloss = "nor",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἀκούσῃ", Transliteration = "akousē", Gloss = "hears",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "λόγους", Transliteration = "logous", Gloss = "words",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P", "2P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "your words"
                        }
                    },
                    Translation = "And whoever does not receive you nor hear your words"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξερχόμενοι", Transliteration = "exerchomenoi", Gloss = "departing",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἔξω", Transliteration = "exō", Gloss = "outside",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "οἰκίας", Transliteration = "oikias", Gloss = "house",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πόλεως", Transliteration = "poleōs", Gloss = "town",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἐκείνης", Transliteration = "ekeinēs", Gloss = "that",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "that house or town"
                        }
                    },
                    Translation = "departing outside that house or town"
                },
                new Word { Greek = "ἐκτινάξατε", Transliteration = "ektinaxate", Gloss = "shake off",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κονιορτὸν", Transliteration = "koniorton", Gloss = "dust",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ποδῶν", Transliteration = "podōn", Gloss = "feet",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P", "2P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "your feet"
                        }
                    },
                    Translation = "the dust of your feet"
                }
            },
            Translation = "And whoever does not receive you nor hear your words, as you depart from that house or town, shake off the dust from your feet."
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀμὴν", Transliteration = "amēn", Gloss = "truly",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "h" },
                new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I say",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "P", "2P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνεκτότερον", Transliteration = "anektoteron", Gloss = "more tolerable",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἔσται", Transliteration = "estai", Gloss = "it will be",
                            GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "γῇ", Transliteration = "gē", Gloss = "land",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "Σοδόμων", Transliteration = "Sodomōn", Gloss = "of Sodom",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "Γομόρρων", Transliteration = "Gomorrōn", Gloss = "Gomorrah",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "for the land of Sodom and Gomorrah"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἡμέρᾳ", Transliteration = "hēmera", Gloss = "day",
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "κρίσεως", Transliteration = "kriseōs", Gloss = "of judgment",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the day of judgment"
                                }
                            },
                            Translation = "on the day of judgment"
                        },
                        new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "than",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πόλει", Transliteration = "polei", Gloss = "town",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἐκείνῃ", Transliteration = "ekeinē", Gloss = "that",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "that town"
                        }
                    },
                    Translation = "it will be more tolerable for the land of Sodom and Gomorrah on the day of judgment than for that town"
                }
            },
            Translation = "Truly I say to you, it will be more tolerable for the land of Sodom and Gomorrah on the day of judgment than for that town."
        },

        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἰδοὺ", Transliteration = "Idou", Gloss = "Behold",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "interj" },
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "S", "1P" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἀποστέλλω", Transliteration = "apostellō", Gloss = "send",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμας", Transliteration = "hymas", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "P", "2P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "πρόβατα", Transliteration = "probata", Gloss = "sheep",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "as sheep"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "μέσῳ", Transliteration = "mesō", Gloss = "the midst",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "λύκων", Transliteration = "lykōn", Gloss = "of wolves",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in the midst of wolves"
                },
                new Word { Greek = "γίνεσθε", Transliteration = "ginesthe", Gloss = "be",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "φρόνιμοι", Transliteration = "phronimoi", Gloss = "wise",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὄφεις", Transliteration = "opheis", Gloss = "serpents",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the serpents"
                        }
                    },
                    Translation = "as serpents"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀκέραιοι", Transliteration = "akeraioi", Gloss = "innocent",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αἱ", Transliteration = "hai", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "περιστεραί", Transliteration = "peristerai", Gloss = "doves",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the doves"
                        }
                    },
                    Translation = "as doves"
                }
            },
            Translation = "Behold, I send you out as sheep in the midst of wolves; therefore be wise as serpents and innocent as doves."
        }
    };
}
/*
Constructions identified:
- Imperatival Subjunctive: Μὴ κτήσησθε (10:9)
- Causal Clause: ἄξιος γὰρ... (10:10)
- Conditional Clause (Third Class): ἐὰν μὲν ᾖ... (10:13)
- Comparative Adjective: ἀνεκτότερον (10:15)
*/
