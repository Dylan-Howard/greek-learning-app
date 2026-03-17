private static List<object> GetChapter4()
{
    // Galatians 4:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Λέγω", Transliteration = "Legō",
                    Gloss = "I say",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δέ", Transliteration = "de",
                    Gloss = "then",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐφ᾽", Transliteration = "eph'",
                                    Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ὅσον", Transliteration = "hoson",
                                    Gloss = "as long as",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "k" },
                                new Word { Greek = "χρόνον", Transliteration = "chronon",
                                    Gloss = "time",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "for as long a time"
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
                                new Word { Greek = "κληρονόμος", Transliteration = "klēronomos",
                                    Gloss = "heir",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the heir"
                        },
                        new Word { Greek = "νήπιός", Transliteration = "nēpios",
                            Gloss = "a child",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin",
                            Gloss = "is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "as long as the heir is a child"
                },
                new Word { Greek = "οὐδὲν", Transliteration = "ouden",
                    Gloss = "in nothing",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "διαφέρει", Transliteration = "diapherei",
                    Gloss = "he differs",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δούλου", Transliteration = "doulou",
                    Gloss = "from a slave",
                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κύριος", Transliteration = "kyrios",
                                    Gloss = "lord",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "πάντων", Transliteration = "pantōn",
                                    Gloss = "of all",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "lord of all"
                        },
                        new Word { Greek = "ὤν", Transliteration = "ōn",
                            Gloss = "being",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "though he is lord of all"
                }
            },
            Translation = "I say then, for as long a time as the heir is a child, he differs nothing from a slave, though he is lord of all."
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo",
                            Gloss = "under",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἐπιτρόπους", Transliteration = "epitropous",
                            Gloss = "guardians",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "οἰκονόμους", Transliteration = "oikonomous",
                            Gloss = "managers",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "under guardians and managers"
                },
                new Word { Greek = "ἐστὶν", Transliteration = "estin",
                    Gloss = "he is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄχρι", Transliteration = "achri",
                            Gloss = "until",
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
                                new Word { Greek = "προθεσμίας", Transliteration = "prothesmias",
                                    Gloss = "set time",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou",
                                            Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "πατρός", Transliteration = "patros",
                                            Gloss = "father",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of the father"
                                }
                            },
                            Translation = "the set time of the father"
                        }
                    },
                    Translation = "until the time set by the father"
                }
            },
            Translation = "but he is under guardians and managers until the time set by the father."
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὕτως", Transliteration = "houtōs",
                    Gloss = "even so",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis",
                    Gloss = "we",
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτε", Transliteration = "hote",
                            Gloss = "when",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἦμεν", Transliteration = "ēmen",
                            Gloss = "we were",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "1P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "νήπιοι", Transliteration = "nēpioi",
                            Gloss = "children",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "when we were children"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo",
                            Gloss = "under",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "στοιχεῖα", Transliteration = "stoicheia",
                                    Gloss = "elements",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou",
                                            Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "κόσμου", Transliteration = "kosmou",
                                            Gloss = "world",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of the world"
                                }
                            },
                            Translation = "the elemental principles of the world"
                        }
                    },
                    Translation = "under the elemental principles of the world"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PERIPH" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἤμεθα", Transliteration = "ēmetha",
                            Gloss = "we were",
                            GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "1P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "δεδουλωμένοι", Transliteration = "dedoulōmenoi",
                            Gloss = "having been enslaved",
                            GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "were enslaved"
                }
            },
            Translation = "Even so we, when we were children, were enslaved under the elemental principles of the world."
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτε", Transliteration = "hote",
                            Gloss = "when",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἦλθεν", Transliteration = "ēlthen",
                            Gloss = "came",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
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
                                new Word { Greek = "πλήρωμα", Transliteration = "plērōma",
                                    Gloss = "fullness",
                                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou",
                                            Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "χρόνου", Transliteration = "chronou",
                                            Gloss = "time",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of time"
                                }
                            },
                            Translation = "the fullness of time"
                        }
                    },
                    Translation = "But when the fullness of time came"
                },
                new Word { Greek = "ἐξαπέστειλεν", Transliteration = "exapesteilen",
                    Gloss = "sent forth",
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "υἱὸν", Transliteration = "huion",
                            Gloss = "Son",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                            Gloss = "of Him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "His Son"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γενόμενον", Transliteration = "genomenon",
                            Gloss = "having been born",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek",
                                    Gloss = "of",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "γυναικός", Transliteration = "gynaikos",
                                    Gloss = "a woman",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of a woman"
                        }
                    },
                    Translation = "born of a woman"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γενόμενον", Transliteration = "genomenon",
                            Gloss = "having been born",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὸ", Transliteration = "hypo",
                                    Gloss = "under",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "νόμον", Transliteration = "nomon",
                                    Gloss = "law",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "under the law"
                        }
                    },
                    Translation = "born under the law"
                }
            },
            Translation = "But when the fullness of time came, God sent forth His Son, born of a woman, born under the law,"
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina",
                            Gloss = "in order that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous",
                                    Gloss = "those",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὑπὸ", Transliteration = "hypo",
                                            Gloss = "under",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "νόμον", Transliteration = "nomon",
                                            Gloss = "law",
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "under the law"
                                }
                            },
                            Translation = "those under the law"
                        },
                        new Word { Greek = "ἐξαγοράσῃ", Transliteration = "exagorasē",
                            Gloss = "He might redeem",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "in order that He might redeem those under the law"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina",
                            Gloss = "in order that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "υἱοθεσίαν", Transliteration = "huiothesian",
                                    Gloss = "adoption",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the adoption"
                        },
                        new Word { Greek = "ἀπολάβωμεν", Transliteration = "apolabōmen",
                            Gloss = "we might receive",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "in order that we might receive the adoption as sons."
                }
            },
            Translation = "in order that He might redeem those under the law, in order that we might receive the adoption as sons."
        },

        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ὅτι", Transliteration = "Hoti",
                            Gloss = "because",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δέ", Transliteration = "de",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐστε", Transliteration = "este",
                            Gloss = "you are",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "υἱοí", Transliteration = "huioi",
                            Gloss = "sons",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "And because you are sons"
                },
                new Word { Greek = "ἐξαπέστειλεν", Transliteration = "exapesteilen",
                    Gloss = "sent forth",
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πνεῦμα", Transliteration = "pneuma",
                            Gloss = "Spirit",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "υἱοῦ", Transliteration = "huiou",
                                    Gloss = "Son",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                                    Gloss = "of Him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "of His Son"
                        }
                    },
                    Translation = "the Spirit of His Son"
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
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "καρδίας", Transliteration = "kardias",
                                    Gloss = "hearts",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn",
                                    Gloss = "of us",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "our hearts"
                        }
                    },
                    Translation = "into our hearts"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κρᾶζον", Transliteration = "krazon",
                            Gloss = "crying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "N", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "crying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αββα", Transliteration = "abba",
                            Gloss = "Abba",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "VOC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πατήρ", Transliteration = "patēr",
                                    Gloss = "Father",
                                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "Father"
                        }
                    },
                    Translation = "Abba! Father!"
                }
            },
            Translation = "And because you are sons, God sent forth the Spirit of His Son into our hearts, crying, 'Abba! Father!'"
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "RESULT_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὥστε", Transliteration = "hōste",
                    Gloss = "so that",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐκέτι", Transliteration = "ouketi",
                    Gloss = "no longer",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "εἶ", Transliteration = "ei",
                    Gloss = "you are",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δοῦλος", Transliteration = "doulos",
                    Gloss = "a slave",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "υἱός", Transliteration = "huios",
                    Gloss = "a son",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei",
                            Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "then",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "υἱός", Transliteration = "huios",
                            Gloss = "a son",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "and if a son"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "κληρονόμος", Transliteration = "klēronomos",
                    Gloss = "an heir",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia",
                            Gloss = "through",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou",
                            Gloss = "God",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "through God"
                }
            },
            Translation = "So you are no longer a slave but a son; and if a son, then an heir through God."
        },

        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀλλὰ", Transliteration = "Alla",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "τότε", Transliteration = "tote",
                    Gloss = "then",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "μὲν", Transliteration = "men",
                    Gloss = "indeed",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐκ", Transliteration = "ouk",
                            Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "εἰδότες", Transliteration = "eidotes",
                            Gloss = "knowing",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "θεὸν", Transliteration = "theon",
                            Gloss = "God",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "not knowing God"
                },
                new Word { Greek = "ἐδουλεύσατε", Transliteration = "edouleusate",
                    Gloss = "you served",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois",
                            Gloss = "those",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "DAT_MANNER" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "φύσει", Transliteration = "physei",
                                            Gloss = "by nature",
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "by nature"
                                },
                                new Word { Greek = "μὴ", Transliteration = "mē",
                                    Gloss = "not",
                                    GrammarCodes = new List<string> { "PART" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "οὖσιν", Transliteration = "ousin",
                                    Gloss = "being",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "P" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "θεοῖς", Transliteration = "theois",
                                    Gloss = "gods",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "which by nature are not gods"
                        }
                    },
                    Translation = "those which by nature are not gods."
                }
            },
            Translation = "But then indeed, not knowing God, you served those which by nature are not gods."
        }
    };
}

/* Identified Constructions:
 * - PERIPH: Galatians 4:3 (ἤμεθα δεδουλωμένοι - Imperfect Middle of εἰμί + Perfect Passive Participle)
 * - DAT_MANNER: Galatians 4:8 (φύσει - dative of nature/manner)
 * - VOC: Galatians 4:6 (αββα ὁ πατήρ - Aramaic vocative/nominative plus Greek nominative as vocative)
 */
