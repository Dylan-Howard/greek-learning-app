private static List<object> GetChapter5()
{
    // Acts 5:25-32
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
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παραγενόμενος", Transliteration = "paragenomenos",
                            Gloss = "having arrived",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having arrived"
                },
                new Word { Greek = "δέ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τις", Transliteration = "tis",
                            Gloss = "someone",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "part" }
                    },
                    Translation = "someone"
                },
                new Word { Greek = "ἀπήγγειλεν", Transliteration = "apēngeilen",
                    Gloss = "reported",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois",
                    Gloss = "to them",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti",
                            Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἰδοὺ", Transliteration = "idou",
                            Gloss = "look",
                            GrammarCodes = new List<string> { "INTERJ" },
                            PartOfSpeech = "interj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἄνδρες", Transliteration = "andres",
                                    Gloss = "men",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the men"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οὓς", Transliteration = "hous",
                                    Gloss = "whom",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "ἔθεσθε", Transliteration = "ethesthe",
                                    Gloss = "you put",
                                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "2P", "P" },
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
                                        new Word { Greek = "τῇ", Transliteration = "tē",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "φυλακῇ", Transliteration = "phylakē",
                                            Gloss = "prison",
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "in the prison"
                                }
                            },
                            Translation = "whom you put in the prison"
                        },
                        new Word { Greek = "εἰσὶν", Transliteration = "eisin",
                            Gloss = "are",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
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
                                new Word { Greek = "τῷ", Transliteration = "tō",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἱερῷ", Transliteration = "hierō",
                                    Gloss = "temple",
                                    GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in the temple"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἑστῶτες", Transliteration = "hestōtes",
                                    Gloss = "standing",
                                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "M", "P" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "καὶ", Transliteration = "kai",
                                    Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "διδάσκοντες", Transliteration = "didaskontes",
                                    Gloss = "teaching",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
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
                                        new Word { Greek = "λαόν", Transliteration = "laon",
                                            Gloss = "people",
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the people"
                                }
                            },
                            Translation = "standing and teaching the people"
                        }
                    },
                    Translation = "that 'Look, the men whom you put in the prison are in the temple, standing and teaching the people.'"
                }
            },
            Translation = "But someone having arrived reported to them, 'Look, the men whom you put in the prison are in the temple, standing and teaching the people.'"
        },

        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τότε", Transliteration = "Tote",
                    Gloss = "Then",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπελθὼν", Transliteration = "apelthōn",
                            Gloss = "having gone",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having gone"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "στρατηγὸς", Transliteration = "stratēgos",
                            Gloss = "captain",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the captain"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὺν", Transliteration = "syn",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῖς", Transliteration = "tois",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὑπηρέταις", Transliteration = "hypēretais",
                            Gloss = "officers",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "with the officers"
                },
                new Word { Greek = "ἦγεν", Transliteration = "ēgen",
                    Gloss = "was bringing",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοὺς", Transliteration = "autous",
                    Gloss = "them",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐ", Transliteration = "ou",
                            Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "μετὰ", Transliteration = "meta",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "βίας", Transliteration = "bias",
                            Gloss = "force",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "not with force"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐφοβοῦντο", Transliteration = "ephobounto",
                            Gloss = "they were fearing",
                            GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "γὰρ", Transliteration = "gar",
                            Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "λαὸν", Transliteration = "laon",
                                    Gloss = "people",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the people"
                        }
                    },
                    Translation = "for they were fearing the people"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "mē",
                            Gloss = "lest",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "λιθασθῶσιν", Transliteration = "lithasthōsin",
                            Gloss = "they might be stoned",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "lest they should be stoned"
                }
            },
            Translation = "Then the captain with the officers went and brought them, not with force, for they were fearing the people, lest they should be stoned."
        },

        // Verse 27
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
                        new Word { Greek = "Ἀγαγόντες", Transliteration = "Agagontes",
                            Gloss = "having brought",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having brought"
                },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "αὐτοὺς", Transliteration = "autous",
                    Gloss = "them",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἔστησαν", Transliteration = "estēsan",
                    Gloss = "they set",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
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
                        new Word { Greek = "τῷ", Transliteration = "tō",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "συνεδρίῳ", Transliteration = "synedriō",
                            Gloss = "council",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in the council"
                }
            },
            Translation = "And having brought them, they set them in the council;"
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
                new Word { Greek = "ἐπηρώτησεν", Transliteration = "epērōtēsen",
                    Gloss = "questioned",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοὺς", Transliteration = "autous",
                    Gloss = "them",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀρχιερεὺς", Transliteration = "archiereus",
                            Gloss = "high priest",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the high priest"
                }
            },
            Translation = "and the high priest questioned them,"
        },

        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "λέγων", Transliteration = "legōn",
                    Gloss = "saying",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "saying"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "παραγγελίᾳ", Transliteration = "parangelia",
                    Gloss = "with a strict order",
                    GrammarCodes = new List<string> { "N", "DAT", "F", "S", "DAT_MANNER" },
                    PartOfSpeech = "n" },
                new Word { Greek = "παρηγγείλαμεν", Transliteration = "parēngeilamen",
                    Gloss = "did we order",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin",
                    Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "mē",
                            Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "διδάσκειν", Transliteration = "didaskein",
                            Gloss = "to teach",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi",
                                    Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τῷ", Transliteration = "tō",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὀνόματι", Transliteration = "onomati",
                                    Gloss = "name",
                                    GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τούτῳ", Transliteration = "toutō",
                                    Gloss = "this",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "in this name"
                        }
                    },
                    Translation = "not to teach in this name"
                }
            },
            Translation = "'Did we not strictly order you not to teach in this name?'"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou",
                    Gloss = "look",
                    GrammarCodes = new List<string> { "INTERJ" },
                    PartOfSpeech = "interj" },
                new Word { Greek = "πεπληρώκατε", Transliteration = "peplērōkate",
                    Gloss = "you have filled",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" },
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
                        new Word { Greek = "Ἰερουσαλὴμ", Transliteration = "Ierousalēm",
                            Gloss = "Jerusalem",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Jerusalem"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῆς", Transliteration = "tēs",
                            Gloss = "with the",
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "διδαχῆς", Transliteration = "didachēs",
                            Gloss = "teaching",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn",
                            Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "with your teaching"
                }
            },
            Translation = "'And look, you have filled Jerusalem with your teaching,'"
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
                new Word { Greek = "βούλεσθε", Transliteration = "boulesthe",
                    Gloss = "you wish",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπαγαγεῖν", Transliteration = "epagagein",
                            Gloss = "to bring",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐφ᾽", Transliteration = "eph'",
                                    Gloss = "upon",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἡμᾶς", Transliteration = "hēmas",
                                    Gloss = "us",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "upon us"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "αἷμα", Transliteration = "haima",
                                    Gloss = "blood",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the blood"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀνθρώπου", Transliteration = "anthrōpou",
                                    Gloss = "man",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τούτου", Transliteration = "toutou",
                                    Gloss = "this",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "of this man"
                        }
                    },
                    Translation = "to bring upon us the blood of this man"
                }
            },
            Translation = "'and you wish to bring upon us the blood of this man.'"
        },

        // Verse 29
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
                        new Word { Greek = "Ἀποκριθεὶς", Transliteration = "Apokritheis",
                            Gloss = "answering",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "answering"
                },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Πέτρος", Transliteration = "Petros",
                            Gloss = "Peter",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "οἱ", Transliteration = "hoi",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀπόστολοι", Transliteration = "apostoloi",
                            Gloss = "apostles",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Peter and the apostles"
                },
                new Word { Greek = "εἶπαν", Transliteration = "eipan",
                    Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "But Peter and the apostles answering said,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πειθαρχεῖν", Transliteration = "peitharchein",
                            Gloss = "to obey",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "to obey"
                },
                new Word { Greek = "δεῖ", Transliteration = "dei",
                    Gloss = "it is necessary",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "θεῷ", Transliteration = "theō",
                    Gloss = "God",
                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "μᾶλλον", Transliteration = "mallon",
                    Gloss = "rather",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἢ", Transliteration = "ē",
                    Gloss = "than",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀνθρώποις", Transliteration = "anthrōpois",
                    Gloss = "men",
                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                    PartOfSpeech = "n" }
            },
            Translation = "'It is necessary to obey God rather than men.'"
        },

        // Verse 30
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
                        new Word { Greek = "θεὸς", Transliteration = "theos",
                            Gloss = "God",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πατέρων", Transliteration = "paterōn",
                                    Gloss = "fathers",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn",
                                    Gloss = "of us",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "of our fathers"
                        }
                    },
                    Translation = "The God of our fathers"
                },
                new Word { Greek = "ἤγειρεν", Transliteration = "ēgeiren",
                    Gloss = "raised",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "Ἰησοῦν", Transliteration = "Iēsoun",
                    Gloss = "Jesus",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" }
            },
            Translation = "The God of our fathers raised Jesus,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃν", Transliteration = "hon",
                    Gloss = "whom",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis",
                    Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "διεχειρίσασθε", Transliteration = "diecheirisasthe",
                    Gloss = "you killed",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κρεμάσαντες", Transliteration = "kremasantes",
                            Gloss = "having hung",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi",
                                    Gloss = "on",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ξύλου", Transliteration = "xylou",
                                    Gloss = "a tree",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "on a tree"
                        }
                    },
                    Translation = "by hanging him on a tree"
                }
            },
            Translation = "whom you killed by hanging him on a tree."
        },

        // Verse 31
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τοῦτον", Transliteration = "touton",
                    Gloss = "This one",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεὸς", Transliteration = "theos",
                            Gloss = "God",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀρχηγὸν", Transliteration = "archēgon",
                            Gloss = "Leader",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "σωτῆρα", Transliteration = "sōtēra",
                            Gloss = "Savior",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "as Leader and Savior"
                },
                new Word { Greek = "ὕψωσεν", Transliteration = "hypsōsen",
                    Gloss = "exalted",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē",
                            Gloss = "at the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δεξιᾷ", Transliteration = "dexia",
                            Gloss = "right hand",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                            Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "at his right hand"
                }
            },
            Translation = "This one God exalted at his right hand as Leader and Savior,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τοῦ", Transliteration = "tou",
                    Gloss = "to",
                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                    PartOfSpeech = "art" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δοῦναι", Transliteration = "dounai",
                            Gloss = "give",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μετάνοιαν", Transliteration = "metanoian",
                                    Gloss = "repentance",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "repentance"
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
                                new Word { Greek = "Ἰσραὴλ", Transliteration = "Israēl",
                                    Gloss = "Israel",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to Israel"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἄφεσιν", Transliteration = "aphesin",
                                    Gloss = "forgiveness",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἁμαρτιῶν", Transliteration = "hamartiōn",
                                            Gloss = "of sins",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "P" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of sins"
                                }
                            },
                            Translation = "forgiveness of sins"
                        }
                    },
                    Translation = "to give repentance to Israel and forgiveness of sins"
                }
            },
            Translation = "to give repentance to Israel and forgiveness of sins."
        },

        // Verse 32
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis",
                    Gloss = "we",
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "P" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐσμεν", Transliteration = "esmen",
                    Gloss = "are",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μάρτυρες", Transliteration = "martyres",
                            Gloss = "witnesses",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ῥημάτων", Transliteration = "rhēmatōn",
                                    Gloss = "things",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τούτων", Transliteration = "toutōn",
                                    Gloss = "these",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "of these things"
                        }
                    },
                    Translation = "witnesses of these things"
                }
            },
            Translation = "And we are witnesses of these things,"
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
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πνεῦμα", Transliteration = "pneuma",
                            Gloss = "Spirit",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἅγιον", Transliteration = "hagion",
                            Gloss = "Holy",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the Holy Spirit"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho",
                            Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἔδωκεν", Transliteration = "edōken",
                            Gloss = "gave",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θεὸς", Transliteration = "theos",
                                    Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "God"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois",
                                    Gloss = "to those",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πειθαρχοῦσιν", Transliteration = "peitharchousin",
                                    Gloss = "obeying",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "P" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "αὐτῷ", Transliteration = "autō",
                                    Gloss = "him",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "to those who obey him"
                        }
                    },
                    Translation = "whom God has given to those who obey him"
                }
            },
            Translation = "and so is the Holy Spirit, whom God has given to those who obey him."
        }
    };
}

/*
Identified Constructions:
- Acts 5:28: παραγγελίᾳ παρηγγείλαμεν - Cognate dative construction (strictly order).
- Acts 5:30: κρεμάσαντες ἐπὶ ξύλου - Manner/Instrumental participle.
- Acts 5:31: τοῦ δοῦναι - Articular infinitive of purpose.
- Acts 5:31: τῇ δεξιᾷ αὐτοῦ - Dative of instrument.
- Acts 5:32: τοῖς πειθαρχοῦσιν αὐτῷ - Substantival participle used as indirect object.
*/
