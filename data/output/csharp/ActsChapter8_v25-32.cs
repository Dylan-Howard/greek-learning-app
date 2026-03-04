private static List<object> GetChapter8()
{
    // Acts 8:25-32
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Οἱ", Transliteration = "Hoi", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διαμαρτυράμενοι", Transliteration = "diamartyramenoi", Gloss = "having testified", Grammar_codes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "λαλήσαντες", Transliteration = "lalēsantes", Gloss = "having spoken", Grammar_codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "having testified and spoken"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "λόγον", Transliteration = "logon", Gloss = "word", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the Lord"
                        }
                    },
                    Translation = "the word of the Lord"
                },
                new Word { Greek = "ὑπέστρεφον", Transliteration = "hypestrephon", Gloss = "were returning", Grammar_codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "Ἱεροσόλυμα", Transliteration = "Hierosolyma", Gloss = "Jerusalem", Grammar_codes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "to Jerusalem"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πολλάς", Transliteration = "pollas", Gloss = "many", Grammar_codes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "κώμας", Transliteration = "kōmas", Gloss = "villages", Grammar_codes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "Σαμαριτῶν", Transliteration = "Samaritōn", Gloss = "Samaritans", Grammar_codes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the Samaritans"
                        }
                    },
                    Translation = "and many villages of the Samaritans"
                },
                new Word { Greek = "εὐηγγελίζοντο", Transliteration = "euēngelizonto", Gloss = "they were preaching the gospel", Grammar_codes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "So when they had testified and spoken the word of the Lord, they returned to Jerusalem, preaching the gospel to many villages of the Samaritans."
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
                        new Word { Greek = "Ἄγγελος", Transliteration = "Angelos", Gloss = "an angel", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "of the Lord", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Now an angel of the Lord"
                },
                new Word { Greek = "ἐλάλησεν", Transliteration = "elalēsen", Gloss = "spoke", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "Φίλιππον", Transliteration = "Philippon", Gloss = "Philip", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to Philip"
                },
                new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνάστηθι", Transliteration = "anastēthi", Gloss = "rise", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πορεύου", Transliteration = "poreuou", Gloss = "go", Grammar_codes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "toward", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "μεσημβρίαν", Transliteration = "mesēmbrian", Gloss = "the south", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "toward the south"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ὁδὸν", Transliteration = "hodon", Gloss = "road", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the road"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the [one]", Grammar_codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "καταβαίνουσαν", Transliteration = "katabainousan", Gloss = "descending", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "F", "S" }, PartOfSpeech = "v" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                                new Word { Greek = "Ἰερουσαλὴμ", Transliteration = "Hierousalēm", Gloss = "Jerusalem", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "from Jerusalem"
                                        },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                                new Word { Greek = "Γάζαν", Transliteration = "Gazan", Gloss = "Gaza", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "to Gaza"
                                        }
                                    },
                                    Translation = "that goes down from Jerusalem to Gaza"
                                }
                            },
                            Translation = "to the road that goes down from Jerusalem to Gaza"
                        }
                    },
                    Translation = "\"Rise and go toward the south to the road that goes down from Jerusalem to Gaza.\""
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὕτη", Transliteration = "hautē", Gloss = "this", Grammar_codes = new List<string> { "PRON", "NOM", "F", "S" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ἐστὶν", Transliteration = "estin", Gloss = "is", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἔρημος", Transliteration = "erēmos", Gloss = "desert", Grammar_codes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "This is a desert place."
                }
            },
            Translation = "Now an angel of the Lord spoke to Philip, saying, \"Rise and go toward the south to the road that goes down from Jerusalem to Gaza.\" This is a desert place."
        },

        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀναστὰς", Transliteration = "anastas", Gloss = "having risen", Grammar_codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἐπορεύθη", Transliteration = "eporeuthē", Gloss = "he went", Grammar_codes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνὴρ", Transliteration = "anēr", Gloss = "a man", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Αἰθίοψ", Transliteration = "Aithiops", Gloss = "an Ethiopian", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "εὐνοῦχος", Transliteration = "eunouchos", Gloss = "a eunuch", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "δυνάστης", Transliteration = "dynastēs", Gloss = "a court official", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Κανδάκης", Transliteration = "Kandakēs", Gloss = "of Candace", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "βασιλίσσης", Transliteration = "basilissēs", Gloss = "queen", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Αἰθιόπων", Transliteration = "Aithiopōn", Gloss = "of the Ethiopians", Grammar_codes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "of Candace, queen of the Ethiopians"
                        }
                    },
                    Translation = "an Ethiopian man, a eunuch, a court official of Candace, queen of the Ethiopians"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "who", Grammar_codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was", Grammar_codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "over", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πάσης", Transliteration = "pasēs", Gloss = "all", Grammar_codes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "γάζης", Transliteration = "gazēs", Gloss = "treasury", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτῆς", Transliteration = "autēs", Gloss = "her", Grammar_codes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "all her treasury"
                                }
                            },
                            Translation = "over all her treasury"
                        }
                    },
                    Translation = "who was over all her treasury"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "who", Grammar_codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἐληλύθει", Transliteration = "elēlythei", Gloss = "had come", Grammar_codes = new List<string> { "V", "PLPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "προσκυνήσων", Transliteration = "proskynēsōn", Gloss = "to worship", Grammar_codes = new List<string> { "V", "FUT", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "Ἰερουσαλήμ", Transliteration = "Hierousalēm", Gloss = "Jerusalem", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "to Jerusalem"
                        }
                    },
                    Translation = "who had come to Jerusalem to worship"
                }
            },
            Translation = "And he rose and went. And behold, an Ethiopian, a eunuch, a court official of Candace, queen of the Ethiopians, who was in charge of all her treasure, had come to Jerusalem to worship"
        },

        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "he was", Grammar_codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "τε", Transliteration = "te", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὑποστρέφων", Transliteration = "hypostrephōn", Gloss = "returning", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καθήμενος", Transliteration = "kathēmenos", Gloss = "sitting", Grammar_codes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἅρματος", Transliteration = "harmatos", Gloss = "chariot", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", Grammar_codes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "his chariot"
                        }
                    },
                    Translation = "in his chariot"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀνεγίνωσκεν", Transliteration = "aneginōsken", Gloss = "he was reading", Grammar_codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "προφήτην", Transliteration = "prophētēn", Gloss = "prophet", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Ἠσαΐαν", Transliteration = "Ēsaian", Gloss = "Isaiah", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the prophet Isaiah"
                }
            },
            Translation = "and was returning, seated in his chariot, and he was reading the prophet Isaiah."
        },

        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "spoke", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πνεῦμα", Transliteration = "pneuma", Gloss = "Spirit", Grammar_codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Spirit"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", Grammar_codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Φιλίππῳ", Transliteration = "Philippō", Gloss = "Philip", Grammar_codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to Philip"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρόσελθε", Transliteration = "proselthe", Gloss = "go to", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "κολλήθητι", Transliteration = "kollēthēti", Gloss = "join yourself", Grammar_codes = new List<string> { "V", "AOR", "PASS", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", Grammar_codes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἅρματι", Transliteration = "harmati", Gloss = "chariot", Grammar_codes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τούτῳ", Transliteration = "toutō", Gloss = "this", Grammar_codes = new List<string> { "PRON", "DAT", "N", "S" }, PartOfSpeech = "adv" }
                            },
                            Translation = "to this chariot"
                        }
                    },
                    Translation = "\"Go up and join yourself to this chariot.\""
                }
            },
            Translation = "And the Spirit said to Philip, \"Go up and join yourself to this chariot.\""
        },

        // Verse 30
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "προσδραμὼν", Transliteration = "prosdramōn", Gloss = "having run up", Grammar_codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "so", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Φίλιππος", Transliteration = "Philippos", Gloss = "Philip", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Philip"
                },
                new Word { Greek = "ἤκουσεν", Transliteration = "ēkousen", Gloss = "heard", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", Grammar_codes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀναγινώσκοντος", Transliteration = "anaginōskontos", Gloss = "reading", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Ἠσαΐαν", Transliteration = "Ēsaian", Gloss = "Isaiah", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "προφήτην", Transliteration = "prophētēn", Gloss = "prophet", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Isaiah the prophet"
                        }
                    },
                    Translation = "him reading Isaiah the prophet"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἆρά", Transliteration = "ara", Gloss = "[interrogative]", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γε", Transliteration = "ge", Gloss = "at least", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "γινώσκεις", Transliteration = "ginōskeis", Gloss = "do you understand", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἃ", Transliteration = "ha", Gloss = "what", Grammar_codes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pron" },
                                new Word { Greek = "ἀναγινώσκεις", Transliteration = "anaginōskeis", Gloss = "you are reading", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "what you are reading"
                        }
                    },
                    Translation = "\"Do you understand what you are reading?\""
                }
            },
            Translation = "So Philip ran to him and heard him reading Isaiah the prophet and asked, \"Do you understand what you are reading?\""
        },

        // Verse 31
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" }
                    },
                    Translation = "And he"
                },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πῶς", Transliteration = "pōs", Gloss = "how", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "[potential]", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δυναίμην", Transliteration = "dynaimēn", Gloss = "could I", Grammar_codes = new List<string> { "V", "PRES", "MID", "OPT", "1P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "COND_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "unless", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "μή", Transliteration = "mē", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τις", Transliteration = "tis", Gloss = "someone", Grammar_codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "part" },
                                new Word { Greek = "ὁδηγήσει", Transliteration = "hodēgēsei", Gloss = "guides", Grammar_codes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "με", Transliteration = "me", Gloss = "me", Grammar_codes = new List<string> { "PRON", "ACC", "1P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "unless someone guides me"
                        }
                    },
                    Translation = "\"How can I, unless someone guides me?\""
                },
                new Word { Greek = "παρεκάλεσέν", Transliteration = "parekalesen", Gloss = "he invited", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "τε", Transliteration = "te", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Φίλιππον", Transliteration = "Philippon", Gloss = "Philip", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Philip"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀναβάντα", Transliteration = "anabanta", Gloss = "having come up", Grammar_codes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "καθίσαι", Transliteration = "kathisai", Gloss = "to sit", Grammar_codes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "σὺν", Transliteration = "syn", Gloss = "with", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", Grammar_codes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "with him"
                        }
                    },
                    Translation = "to come up and sit with him"
                }
            },
            Translation = "And he said, \"How can I, unless someone guides me?\" And he invited Philip to come up and sit with him."
        },

        // Verse 32
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
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "περιοχὴ", Transliteration = "periochē", Gloss = "passage", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "γραφῆς", Transliteration = "graphēs", Gloss = "Scripture", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the Scripture"
                        }
                    },
                    Translation = "Now the passage of the Scripture"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἣν", Transliteration = "hēn", Gloss = "which", Grammar_codes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἀνεγίνωσκεν", Transliteration = "aneginōsken", Gloss = "he was reading", Grammar_codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "which he was reading"
                },
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was", Grammar_codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὕτη", Transliteration = "hautē", Gloss = "this", Grammar_codes = new List<string> { "PRON", "NOM", "F", "S" }, PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πρόβατον", Transliteration = "probaton", Gloss = "a sheep", Grammar_codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "σφαγὴν", Transliteration = "sphagēn", Gloss = "slaughter", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "to slaughter"
                        },
                        new Word { Greek = "ἤχθη", Transliteration = "ēchthē", Gloss = "he was led", Grammar_codes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "as a sheep he was led to slaughter"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀμνὸς", Transliteration = "amnos", Gloss = "a lamb", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐναντίον", Transliteration = "enantion", Gloss = "before", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the [one]", Grammar_codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κείραντος", Transliteration = "keirantos", Gloss = "shearing", Grammar_codes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", Grammar_codes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "the one who shears him"
                                }
                            },
                            Translation = "before its shearer"
                        },
                        new Word { Greek = "ἄφωνος", Transliteration = "aphōnos", Gloss = "silent", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "so", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀνοίγει", Transliteration = "anoigei", Gloss = "he opens", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "στόμα", Transliteration = "stoma", Gloss = "mouth", Grammar_codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", Grammar_codes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "his mouth"
                        }
                    },
                    Translation = "so he opens not his mouth"
                }
            },
            Translation = "Now the passage of the Scripture that he was reading was this: \"Like a sheep he was led to the slaughter and like a lamb before its shearer is silent, so he opens not his mouth.\""
        }
    };
}

/*
Constructions identified:
- Acts 8:30: Genitive Absolute-like structure (αὐτοῦ ἀναγινώσκοντος) - though technically a direct object of 'heard'.
- Acts 8:31: Potential Optative with ἂν (ἂν δυναίμην).
- Acts 8:32: Comparative clauses (ὡς... ὡς...).
*/
