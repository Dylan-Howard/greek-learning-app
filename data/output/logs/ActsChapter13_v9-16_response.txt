private static List<object> GetChapter13()
{
    // Acts 13:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Σαῦλος", Transliteration = "Saulos",
                    Gloss = "Saul",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "δέ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the [one]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "Παῦλος", Transliteration = "Paulos",
                            Gloss = "Paul",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "who is also called Paul"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πλησθεὶς", Transliteration = "plēstheis",
                            Gloss = "having been filled",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πνεύματος", Transliteration = "pneumatos",
                                    Gloss = "of Spirit",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἁγίου", Transliteration = "hagiou",
                                    Gloss = "Holy",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "with the Holy Spirit"
                        }
                    },
                    Translation = "filled with the Holy Spirit"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀτενίσας", Transliteration = "atenisas",
                            Gloss = "having looked intently",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis",
                                    Gloss = "at",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτὸν", Transliteration = "auton",
                                    Gloss = "him",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "at him"
                        }
                    },
                    Translation = "looked intently at him"
                }
            },
            Translation = "But Saul, who is also called Paul, filled with the Holy Spirit, looked intently at him"
        },
        // Verse 10
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
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὦ", Transliteration = "ō",
                            Gloss = "O",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "particle" },
                        new Word { Greek = "πλήρης", Transliteration = "plērēs",
                            Gloss = "full",
                            GrammarCodes = new List<string> { "ADJ", "VOC", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παντὸς", Transliteration = "pantos",
                                    Gloss = "of all",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "δόλου", Transliteration = "dolou",
                                    Gloss = "deceit",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of all deceit"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάσης", Transliteration = "pasēs",
                                    Gloss = "all",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ῥᾳδιουργίας", Transliteration = "rhadiourgias",
                                    Gloss = "trickery",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "all villainy"
                        }
                    },
                    Translation = "O full of all deceit and all villainy"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "υἱὲ", Transliteration = "huie",
                            Gloss = "son",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "διαβόλου", Transliteration = "diabolou",
                            Gloss = "of the devil",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "son of the devil"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐχθρὲ", Transliteration = "echthre",
                            Gloss = "enemy",
                            GrammarCodes = new List<string> { "ADJ", "VOC", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάσης", Transliteration = "pasēs",
                                    Gloss = "of all",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "δικαιοσύνης", Transliteration = "dikaiosynēs",
                                    Gloss = "righteousness",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of all righteousness"
                        }
                    },
                    Translation = "enemy of all righteousness"
                },
                new Word { Greek = "οὐ", Transliteration = "ou",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "particle" },
                new Word { Greek = "παύσῃ", Transliteration = "pausē",
                    Gloss = "will you stop",
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "2P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διαστρέφων", Transliteration = "diastrephōn",
                            Gloss = "subverting",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὁδοὺς", Transliteration = "hodous",
                                    Gloss = "ways",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
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
                                        new Word { Greek = "κυρίου", Transliteration = "kyriou",
                                            Gloss = "Lord",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of the Lord"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὰς", Transliteration = "tas",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "εὐθείας", Transliteration = "eutheias",
                                            Gloss = "straight",
                                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                                            PartOfSpeech = "adj" }
                                    },
                                    Translation = "the straight ones"
                                }
                            },
                            Translation = "the straight ways of the Lord"
                        }
                    },
                    Translation = "perverting the straight ways of the Lord"
                }
            },
            Translation = "and said, 'O full of all deceit and all villainy, you son of the devil, you enemy of all righteousness, will you not stop perverting the straight ways of the Lord?'"
        },
        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "νῦν", Transliteration = "nyn",
                    Gloss = "now",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou",
                    Gloss = "behold",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "particle" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χεὶρ", Transliteration = "cheir",
                            Gloss = "hand",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "κυρίου", Transliteration = "kyriou",
                            Gloss = "of the Lord",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the hand of the Lord"
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
                        new Word { Greek = "σὲ", Transliteration = "se",
                            Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "is upon you"
                }
            },
            Translation = "And now, behold, the hand of the Lord is upon you"
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
                new Word { Greek = "ἔσῃ", Transliteration = "esē",
                    Gloss = "you will be",
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "2P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "τυφλὸς", Transliteration = "typhlos",
                    Gloss = "blind",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "mē",
                            Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "particle" },
                        new Word { Greek = "βλέπων", Transliteration = "blepōn",
                            Gloss = "seeing",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
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
                                new Word { Greek = "ἥλιον", Transliteration = "hēlion",
                                    Gloss = "sun",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the sun"
                        }
                    },
                    Translation = "not seeing the sun"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄχρι", Transliteration = "achri",
                            Gloss = "until",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "καιροῦ", Transliteration = "kairou",
                            Gloss = "a time",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "for a time"
                }
            },
            Translation = "and you will be blind, not seeing the sun for a time"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "παραχρῆμά", Transliteration = "parachrēma",
                    Gloss = "immediately",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "τε", Transliteration = "te",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἔπεσεν", Transliteration = "epesen",
                    Gloss = "fell",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπ᾽", Transliteration = "ep'",
                            Gloss = "upon",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton",
                            Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "upon him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀχλὺς", Transliteration = "achlys",
                            Gloss = "a mist",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "σκότος", Transliteration = "skotos",
                            Gloss = "darkness",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "a mist and darkness"
                }
            },
            Translation = "And immediately there fell on him a mist and darkness"
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
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περιάγων", Transliteration = "periagōn",
                            Gloss = "going about",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "going about"
                },
                new Word { Greek = "ἐζήτει", Transliteration = "ezētei",
                    Gloss = "he sought",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "χειραγωγούς", Transliteration = "cheiragōgous",
                    Gloss = "leaders by the hand",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                    PartOfSpeech = "n" }
            },
            Translation = "and he went about seeking someone to lead him by the hand"
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τότε", Transliteration = "tote",
                    Gloss = "then",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἰδὼν", Transliteration = "idōn",
                            Gloss = "having seen",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀνθύπατος", Transliteration = "anthypatos",
                                    Gloss = "proconsul",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the proconsul"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to",
                                    Gloss = "the thing",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "γεγονὸς", Transliteration = "gegonos",
                                    Gloss = "having happened",
                                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "ACC", "N", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "what had happened"
                        }
                    },
                    Translation = "when the proconsul saw what had happened"
                },
                new Word { Greek = "ἐπίστευσεν", Transliteration = "episteusen",
                    Gloss = "he believed",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκπλησσόμενος", Transliteration = "ekplēssomenos",
                            Gloss = "being amazed",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi",
                                    Gloss = "at",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῇ", Transliteration = "tē",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "διδαχῇ", Transliteration = "didachē",
                                            Gloss = "teaching",
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
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
                                                new Word { Greek = "κυρίου", Transliter
