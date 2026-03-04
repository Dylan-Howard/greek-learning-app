private static List<object> GetChapter23()
{
    // Acts 23:25-32
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "γράψας", Transliteration = "grapsas",
                    Gloss = "having written",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπιστολὴν", Transliteration = "epistolēn",
                            Gloss = "a letter",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔχουσαν", Transliteration = "echousan",
                                    Gloss = "having",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "F", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "τύπον", Transliteration = "typon",
                                            Gloss = "content",
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "τοῦτον", Transliteration = "touton",
                                            Gloss = "this",
                                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                            PartOfSpeech = "adv" }
                                    },
                                    Translation = "this content"
                                }
                            },
                            Translation = "having this content"
                        }
                    },
                    Translation = "a letter having this content"
                }
            },
            Translation = "And he wrote a letter having this content:"
        },

        // Verse 26
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
                        new Word { Greek = "Κλαύδιος", Transliteration = "Klaudios",
                            Gloss = "Claudius",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "Λυσίας", Transliteration = "Lysias",
                            Gloss = "Lysias",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Claudius Lysias"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō",
                            Gloss = "to the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κρατίστῳ", Transliteration = "kratistō",
                            Gloss = "most excellent",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἡγεμόνι", Transliteration = "hēgemoni",
                            Gloss = "governor",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "Φήλικι", Transliteration = "Phēliki",
                            Gloss = "Felix",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the most excellent governor Felix"
                },
                new Word { Greek = "χαίρειν", Transliteration = "chairein",
                    Gloss = "greetings",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                    PartOfSpeech = "v" }
            },
            Translation = "Claudius Lysias to the most excellent governor Felix, greetings."
        },

        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Τὸν", Transliteration = "Ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἄνδρα", Transliteration = "andra",
                            Gloss = "man",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τοῦτον", Transliteration = "touton",
                            Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "this man"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συλλημφθέντα", Transliteration = "syllēmphthenta",
                            Gloss = "having been seized",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὸ", Transliteration = "hypo",
                                    Gloss = "by",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Ἰουδαίων", Transliteration = "Ioudaiōn",
                                    Gloss = "Jews",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "by the Jews"
                        }
                    },
                    Translation = "having been seized by the Jews"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μέλλοντα", Transliteration = "mellonta",
                            Gloss = "being about",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀναιρεῖσθαι", Transliteration = "anaireisthai",
                                    Gloss = "to be killed",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "INF" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὑπ᾽", Transliteration = "hyp'",
                                            Gloss = "by",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "αὐτῶν", Transliteration = "autōn",
                                            Gloss = "them",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "by them"
                                }
                            },
                            Translation = "to be killed by them"
                        }
                    },
                    Translation = "and being about to be killed by them"
                },
                new Word { Greek = "ἐπιστὰς", Transliteration = "epistas",
                    Gloss = "having come upon them",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὺν", Transliteration = "syn",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "στρατεύματι", Transliteration = "strateumati",
                            Gloss = "army",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "with the troops"
                },
                new Word { Greek = "ἐξειλάμην", Transliteration = "exeilamēn",
                    Gloss = "I rescued",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μαθὼν", Transliteration = "mathōn",
                            Gloss = "having learned",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "hoti",
                                    Gloss = "that",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "Ῥωμαῖός", Transliteration = "Rhōmaios",
                                    Gloss = "a Roman",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἐστιν", Transliteration = "estin",
                                    Gloss = "he is",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "that he is a Roman"
                        }
                    },
                    Translation = "having learned that he is a Roman"
                }
            },
            Translation = "This man had been seized by the Jews and was about to be killed by them, but I came upon them with the troops and rescued him, having learned that he is a Roman."
        },

        // Verse 28
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
                        new Word { Greek = "βουλόμενός", Transliteration = "boulomenos",
                            Gloss = "wishing",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "τε", Transliteration = "te",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπιγνῶναι", Transliteration = "epignōnai",
                                    Gloss = "to know",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "αἰτίαν", Transliteration = "aitian",
                                            Gloss = "charge",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the charge"
                                }
                            },
                            Translation = "to know the charge"
                        }
                    },
                    Translation = "And wishing to know the charge"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δι᾽", Transliteration = "di'",
                                    Gloss = "on account of",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἣν", Transliteration = "hēn",
                                    Gloss = "which",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "on account of which"
                        },
                        new Word { Greek = "ἐνεκάλουν", Transliteration = "enekaloun",
                            Gloss = "they were accusing",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō",
                            Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "on account of which they were accusing him"
                },
                new Word { Greek = "κατήγαγον", Transliteration = "katēgagon",
                    Gloss = "I brought down",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "συνέδριον", Transliteration = "synedrion",
                            Gloss = "Sanhedrin",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn",
                            Gloss = "their",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "to their Sanhedrin"
                }
            },
            Translation = "And wishing to know the charge on account of which they were accusing him, I brought him down to their Sanhedrin."
        },

        // Verse 29
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
                        new Word { Greek = "ὃν", Transliteration = "hon",
                            Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "εὗρον", Transliteration = "heuron",
                            Gloss = "I found",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐγκαλούμενον", Transliteration = "enkaloumenon",
                                    Gloss = "being accused",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "M", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "περὶ", Transliteration = "peri",
                                            Gloss = "about",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "ζητημάτων", Transliteration = "zētēmatōn",
                                            Gloss = "questions",
                                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "τοῦ", Transliteration = "tou",
                                            Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "νόμου", Transliteration = "nomou",
                                            Gloss = "law",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτῶν", Transliteration = "autōn",
                                            Gloss = "their",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "about questions of their law"
                                }
                            },
                            Translation = "being accused about questions of their law"
                        }
                    },
                    Translation = "I found him to be accused about questions of their law"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μηδὲν", Transliteration = "mēden",
                            Gloss = "nothing",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἄξιον", Transliteration = "axion",
                            Gloss = "worthy",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "θανάτου", Transliteration = "thanatou",
                                    Gloss = "of death",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἢ", Transliteration = "ē",
                                    Gloss = "or",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "δεσμῶν", Transliteration = "desmōn",
                                    Gloss = "of chains",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of death or of chains"
                        },
                        new Word { Greek = "ἔχοντα", Transliteration = "echonta",
                            Gloss = "having",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἔγκλημα", Transliteration = "enklēma",
                            Gloss = "charge",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "but having no charge worthy of death or chains"
                }
            },
            Translation = "I found that he was being accused about questions of their law, but had no charge against him worthy of death or chains."
        },

        // Verse 30
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μηνυθείσης", Transliteration = "mēnytheisēs",
                            Gloss = "having been informed",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "GEN", "F", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "δέ", Transliteration = "de",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μοι", Transliteration = "moi",
                            Gloss = "to me",
                            GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπιβουλῆς", Transliteration = "epiboulēs",
                                    Gloss = "a plot",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "eis",
                                            Gloss = "against",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "τὸν", Transliteration = "ton",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἄνδρα", Transliteration = "andra",
                                            Gloss = "man",
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "against the man"
                                }
                            },
                            Translation = "a plot against the man"
                        },
                        new Word { Greek = "ἔσεσθαι", Transliteration = "esesthai",
                            Gloss = "to be",
                            GrammarCodes = new List<string> { "V", "FUT", "MID", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "And when I was informed that there would be a plot against the man"
                },
                new Word { Greek = "ἐξαυτῆς", Transliteration = "exautēs",
                    Gloss = "immediately",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἔπεμψα", Transliteration = "epempsa",
                    Gloss = "I sent",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "σὲ", Transliteration = "se",
                            Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "to you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παραγγείλας", Transliteration = "parangeilas",
                            Gloss = "having ordered",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κατηγόροις", Transliteration = "katēgorois",
                                    Gloss = "accusers",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the accusers"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "λέγειν", Transliteration = "legein",
                                    Gloss = "to speak",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὰ", Transliteration = "ta",
                                            Gloss = "the things",
                                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                                            PartOfSpeech = "art" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "πρὸς", Transliteration = "pros",
                                                    Gloss = "against",
                                                    GrammarCodes = new List<string> { "PREP" },
                                                    PartOfSpeech = "prep" },
                                                new Word { Greek = "αὐτὸν", Transliteration = "auton",
