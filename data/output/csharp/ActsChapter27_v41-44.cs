private static List<object> GetChapter27()
{
    // Acts 27:41-44
    return new List<object>
    {
        // Verse 41
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
                        new Word { Greek = "περιπεσόντες", Transliteration = "peripesontes",
                            Gloss = "having fallen into",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" }
                    },
                    Translation = "But having fallen into"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis",
                            Gloss = "into",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τόπον", Transliteration = "topon",
                                    Gloss = "a place",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "διθάλασσον", Transliteration = "dithalasson",
                                    Gloss = "where two seas met",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "a place where two seas met"
                        }
                    },
                    Translation = "into a place where two seas met"
                },
                new Word { Greek = "ἐπέκειλαν", Transliteration = "epekeilan",
                    Gloss = "they ran aground",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
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
                        new Word { Greek = "ναῦν", Transliteration = "naun",
                            Gloss = "ship",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the ship"
                }
            },
            Translation = "But falling into a place where two seas met, they ran the vessel aground."
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
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μὲν", Transliteration = "men",
                            Gloss = "on the one hand",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" }, // Note: RMAC has PRT/PREP, context is particle
                        new Word { Greek = "πρῷρα", Transliteration = "prōra",
                            Gloss = "bow",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the bow"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐρείσασα", Transliteration = "ereisasa",
                            Gloss = "having stuck fast",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "F", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having stuck fast"
                },
                new Word { Greek = "ἔμεινεν", Transliteration = "emeinen",
                    Gloss = "remained",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἀσάλευτος", Transliteration = "asaleutos",
                    Gloss = "immovable",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                    PartOfSpeech = "adj" }
            },
            Translation = "And the bow, sticking fast, remained immovable,"
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
                        new Word { Greek = "ἡ", Transliteration = "hē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "πρύμνα", Transliteration = "prymna",
                            Gloss = "stern",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "but the stern"
                },
                new Word { Greek = "ἐλύετο", Transliteration = "elyeto",
                    Gloss = "was being broken up",
                    GrammarCodes = new List<string> { "V", "IMPF", "PASS", "IND", "3P", "S" },
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
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "βίας", Transliteration = "bias",
                                    Gloss = "force",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "κυμάτων", Transliteration = "kymatōn",
                                            Gloss = "waves",
                                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of the waves"
                                }
                            },
                            Translation = "the force of the waves"
                        }
                    },
                    Translation = "by the force of the waves"
                }
            },
            Translation = "but the stern was being broken up by the force of the waves."
        },

        // Verse 42
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
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Τῶν", Transliteration = "Tōn",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "δὲ", Transliteration = "de",
                                    Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "στρατιωτῶν", Transliteration = "stratiōtōn",
                                    Gloss = "soldiers",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the soldiers"
                        },
                        new Word { Greek = "βουλὴ", Transliteration = "boulē",
                            Gloss = "plan",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the soldiers' plan"
                },
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto",
                    Gloss = "came to be",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina",
                            Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "δεσμώτας", Transliteration = "desmōtas",
                                    Gloss = "prisoners",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the prisoners"
                        },
                        new Word { Greek = "ἀποκτείνωσιν", Transliteration = "apokteinōsin",
                            Gloss = "they should kill",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that they should kill the prisoners"
                }
            },
            Translation = "The soldiers' plan was to kill the prisoners,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μή", Transliteration = "mē",
                    Gloss = "lest",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" }, // RMAC/Data discrepancy: mē is usually a negative particle/conj here
                new Word { Greek = "τις", Transliteration = "tis",
                    Gloss = "any",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "part" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκκολυμβήσας", Transliteration = "ekkolumbēsas",
                            Gloss = "having swum away",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having swum away"
                },
                new Word { Greek = "διαφύγῃ", Transliteration = "diaphygē",
                    Gloss = "should escape",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "lest any should swim away and escape."
        },

        // Verse 43
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
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἑκατοντάρχης", Transliteration = "hekatontarchēs",
                            Gloss = "centurion",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "But the centurion"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βουλόμενος", Transliteration = "boulomenos",
                            Gloss = "wishing",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διασῶσαι", Transliteration = "diasōsai",
                                    Gloss = "to save",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
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
                                        new Word { Greek = "Παῦλον", Transliteration = "Paulon",
                                            Gloss = "Paul",
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "Paul"
                                }
                            },
                            Translation = "to save Paul"
                        }
                    },
                    Translation = "wishing to save Paul"
                },
                new Word { Greek = "ἐκώλυσεν", Transliteration = "ekōlysen",
                    Gloss = "prevented",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοὺς", Transliteration = "autous",
                    Gloss = "them",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "prep" }, // Data note: rmac says P-APM
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou",
                            Gloss = "from the",
                            GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "βουλήματος", Transliteration = "boulēmatos",
                            Gloss = "plan",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "from their plan"
                }
            },
            Translation = "But the centurion, wishing to save Paul, prevented them from their plan."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐκέλευσέν", Transliteration = "ekeleusen",
                    Gloss = "he ordered",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "τε", Transliteration = "te",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "those",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δυναμένους", Transliteration = "dynamenous",
                            Gloss = "being able",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "ACC", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "κολυμβᾶν", Transliteration = "kolumban",
                            Gloss = "to swim",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "those able to swim"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπορίψαντας", Transliteration = "aporipsantas",
                            Gloss = "having thrown themselves overboard",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "πρώτους", Transliteration = "prōtous",
                            Gloss = "first",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "to jump overboard first"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "γῆν", Transliteration = "gēn",
                                    Gloss = "land",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the land"
                        }
                    },
                    Translation = "to the land"
                },
                new Word { Greek = "ἐξιέναι", Transliteration = "exienai",
                    Gloss = "to go out",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                    PartOfSpeech = "v" }
            },
            Translation = "He ordered those who could swim to jump overboard first and make for the land,"
        },

        // Verse 44
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "λοιποὺς", Transliteration = "loipous",
                            Gloss = "rest",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "and the rest"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὓς", Transliteration = "hous",
                            Gloss = "some",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "μὲν", Transliteration = "men",
                            Gloss = "on the one hand",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi",
                                    Gloss = "on",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "σανίσιν", Transliteration = "sanisin",
                                    Gloss = "planks",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "on planks"
                        }
                    },
                    Translation = "some on planks"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὓς", Transliteration = "hous",
                            Gloss = "some",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "on the other hand",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπί", Transliteration = "epi",
                                    Gloss = "on",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τινων", Transliteration = "tinōn",
                                    Gloss = "certain [pieces]",
                                    GrammarCodes = new List<string> { "PART" }, // INDEF PRON
                                    PartOfSpeech = "part" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn",
                                            Gloss = "the [things]",
                                            GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                            PartOfSpeech = "art" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new
