private static List<object> GetChapter26()
{
    // Matthew 26:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐδύνατο", Transliteration = "edynato",
                    Gloss = "was able",
                    GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "τοῦτο", Transliteration = "touto",
                    Gloss = "this",
                    GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" },
                    PartOfSpeech = "adv" }, // RMAC/JSON suggests adv but used as pronoun
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πραθῆναι", Transliteration = "prathēnai",
                            Gloss = "to be sold",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "πολλοῦ", Transliteration = "pollou",
                            Gloss = "for much",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "to be sold for much"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δοθῆναι", Transliteration = "dothēnai",
                            Gloss = "to be given",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "πτωχοῖς", Transliteration = "ptōchois",
                            Gloss = "to the poor",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "to be given to the poor"
                }
            },
            Translation = "For this could have been sold for much and given to the poor."
        },

        // Verse 10
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
                        new Word { Greek = "Γνοὺς", Transliteration = "Gnous",
                            Gloss = "knowing",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "Knowing"
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
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous",
                            Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                },
                new Word { Greek = "εἶπεν", Transliteration = "eipen",
                    Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois",
                    Gloss = "to them",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                    PartOfSpeech = "prep" }, // RMAC/JSON labeled prep, corrected to pronoun
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti",
                            Gloss = "Why",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "interj" },
                        new Word { Greek = "κόπους", Transliteration = "kopous",
                            Gloss = "trouble",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "παρέχετε", Transliteration = "parechete",
                            Gloss = "do you present",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "γυναικί", Transliteration = "gynaiki",
                                    Gloss = "woman",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to the woman"
                        }
                    },
                    Translation = "Why do you trouble the woman?"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔργον", Transliteration = "ergon",
                            Gloss = "work",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "γὰρ", Transliteration = "gar",
                            Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "καλὸν", Transliteration = "kalon",
                            Gloss = "good",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἠργάσατο", Transliteration = "ērgasato",
                            Gloss = "she has done",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis",
                                    Gloss = "toward",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἐμέ", Transliteration = "eme",
                                    Gloss = "me",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "toward me"
                        }
                    },
                    Translation = "for she has done a good work toward me."
                }
            },
            Translation = "But Jesus, knowing this, said to them, 'Why do you trouble the woman? For she has done a good work toward me.'"
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πάντοτε", Transliteration = "pantote",
                    Gloss = "always",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
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
                        new Word { Greek = "πτωχοὺς", Transliteration = "ptōchous",
                            Gloss = "poor",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the poor"
                },
                new Word { Greek = "ἔχετε", Transliteration = "echete",
                    Gloss = "you have",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μεθ᾽", Transliteration = "meth'",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἑαυτῶν", Transliteration = "heautōn",
                            Gloss = "yourselves",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "f" }
                    },
                    Translation = "with yourselves"
                }
            },
            Translation = "For you always have the poor with you,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐμὲ", Transliteration = "eme",
                    Gloss = "me",
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐ", Transliteration = "ou",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "πάντοτε", Transliteration = "pantote",
                    Gloss = "always",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἔχετε", Transliteration = "echete",
                    Gloss = "you have",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "but you do not always have me."
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
                        new Word { Greek = "βαλοῦσα", Transliteration = "balousa",
                            Gloss = "having poured",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "F", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having poured"
                },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "αὕτη", Transliteration = "hautē",
                    Gloss = "this [woman]",
                    GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μύρον", Transliteration = "myron",
                            Gloss = "ointment",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τοῦτο", Transliteration = "touto",
                            Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "this ointment"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi",
                            Gloss = "upon",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "σώματός", Transliteration = "sōmatos",
                                    Gloss = "body",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou",
                                    Gloss = "of me",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "my body"
                        }
                    },
                    Translation = "upon my body"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros",
                            Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐνταφιάσαι", Transliteration = "entaphiasai",
                                    Gloss = "to prepare for burial",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "με", Transliteration = "me",
                                    Gloss = "me",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "to prepare me for burial"
                        }
                    },
                    Translation = "to prepare me for burial"
                },
                new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen",
                    Gloss = "she did",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "For in pouring this ointment upon my body, she did it to prepare me for burial."
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀμὴν", Transliteration = "amēn",
                    Gloss = "Truly",
                    GrammarCodes = new List<string> { "HEB" },
                    PartOfSpeech = "h" },
                new Word { Greek = "λέγω", Transliteration = "legō",
                    Gloss = "I say",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin",
                    Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπου", Transliteration = "hopou",
                            Gloss = "wherever",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐὰν", Transliteration = "ean",
                            Gloss = "ever",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "κηρυχθῇ", Transliteration = "kērychthē",
                            Gloss = "shall be preached",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "εὐαγγέλιον", Transliteration = "euangelion",
                                    Gloss = "gospel",
                                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τοῦτο", Transliteration = "touto",
                                    Gloss = "this",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "this gospel"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en",
                                    Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὅλῳ", Transliteration = "holō",
                                            Gloss = "all",
                                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" },
                                            PartOfSpeech = "adj" },
                                        new Word { Greek = "τῷ", Transliteration = "tō",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "κόσμῳ", Transliteration = "kosmō",
                                            Gloss = "world",
                                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "all the world"
                                }
                            },
                            Translation = "in all the world"
                        }
                    },
                    Translation = "wherever this gospel is preached in the whole world"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λαληθήσεται", Transliteration = "lalēthēsetai",
                            Gloss = "will be told",
                            GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃ", Transliteration = "ho",
                                    Gloss = "what",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen",
                                    Gloss = "she did",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "αὕτη", Transliteration = "hautē",
                                    Gloss = "she",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "what she has done"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis",
                                    Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "μνημόσυνον", Transliteration = "mnēmosynon",
                                            Gloss = "memory",
                                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτῆς", Transliteration = "autēs",
                                            Gloss = "of her",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "memory of her"
                                }
                            },
                            Translation = "in memory of her"
                        }
                    },
                    Translation = "also what this woman has done will be told in memory of her."
                }
            },
            Translation = "Truly, I say to you, wherever this gospel is preached in the whole world, what she has done will also be told in memory of her."
        },

        // Verse 14
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
                        new Word { Greek = "πορευθεὶς", Transliteration = "poreutheis",
                            Gloss = "having gone",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having gone"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἷς", Transliteration = "heis",
                            Gloss = "one",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "δώδεκα", Transliteration = "dōdeka",
                                    Gloss = "twelve",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "of the twelve"
                        }
                    },
                    Translation = "one of the twelve"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the [one]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "λεγόμενος", Transliteration = "legomenos",
                            Gloss = "called",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "Ἰούδας", Transliteration = "Ioudas",
                            Gloss = "Judas",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "Ἰσκαριώτης", Transliteration = "Iskariōtēs",
                            Gloss = "Iscariot",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "who was called Judas Iscariot"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀρχιερεῖς", Transliteration = "archiereis",
                                    Gloss = "chief priests",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the chief priests"
                        }
                    },
                    Translation = "to the chief priests"
                }
            },
            Translation = "Then one of the twelve, called Judas Iscariot, went to the chief priests"
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen",
                    Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti",
                            Gloss = "What",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "interj" },
                        new Word { Greek = "θέλετέ", Transliteration = "thelete",
                            Gloss = "are you willing",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "μοι", Transliteration = "moi",
                            Gloss = "to me",
                            GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "δοῦναι", Transliteration = "dounai",
                            Gloss = "to give",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "What are you willing to give me"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κἀγὼ", Transliteration = "kagō",
                            Gloss = "and I",
                            GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin",
                            Gloss = "to you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "παραδώσω", Transliteration = "paradōsō",
                            Gloss = "will deliver",
                            GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτόν", Transliteration = "auton",
                            Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "and I will deliver him to you?"
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
                                new Word { Greek = "οἱ", Transliteration = "hoi",
                                    Gloss = "they",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" }
                            },
                            Translation = "they"
                        },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἔστησαν", Transliteration = "estēsan",
                            Gloss = "weighed out",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō",
                            Gloss = "to him",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τριάκοντα", Transliteration = "triakonta",
                                    Gloss = "thirty",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἀργύρια", Transliteration = "argyria",
                                    Gloss = "pieces of silver",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "thirty pieces of silver"
                        }
                    },
                    Translation = "And they weighed out for him thirty pieces of silver."
                }
            },
            Translation = "and said, 'What are you willing to give me if I deliver him to you?' And they weighed out for him thirty pieces of silver."
        },

        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo",
                            Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τότε", Transliteration = "tote",
                            Gloss = "then",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "from then"
                },
                new Word { Greek = "ἐζήτει", Transliteration = "ezētei",
                    Gloss = "he sought",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εὐκαιρίαν", Transliteration = "eukairian",
                            Gloss = "opportunity",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "opportunity"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina",
                            Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton",
                            Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "παραδῷ", Transliteration = "paradō",
                            Gloss = "he might deliver",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that he might deliver him"
                }
            },
            Translation = "And from then on he sought an opportunity to deliver him."
        }
    };
}

/*
Constructions identified:
- INF_PHRASE (Verse 9): Complementary infinitives πραθῆναι and δοθῆναι with ἐδύνατο.
- PTCP (Verse 10): Circumstantial participle Γνοὺς.
- CAUSAL_CLAUSE (Verse 10): Introduced by γὰρ.
- PTCP (Verse 12): Circumstantial participle βαλοῦσα.
- PURPOSE_CLAUSE (Verse 12): Articular infinitive πρὸς τὸ ἐνταφιάσαι.
- DEP_CLAUSE (Verse 13): Indefinite temporal/local clause ὅπου ἐὰν κηρυχθῇ.
- APPOS (Verse 14): Identificatory phrase ὁ λεγόμενος Ἰούδας Ἰσκαριώτης.
- PTCP (Verse 14): Circumstantial participle πορευθεὶς.
- PURPOSE_CLAUSE (Verse 16): ἵνα + subjunctive.
*/
