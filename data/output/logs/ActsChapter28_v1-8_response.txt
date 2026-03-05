private static List<object> GetChapter28()
{
    // Acts 28:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διασωθέντες", Transliteration = "diasōthentes", Gloss = "having been brought safely through", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "having been brought safely through"
                },
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "then", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἐπέγνωμεν", Transliteration = "epegnōmen", Gloss = "we learned", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Μελίτη", Transliteration = "Melitē", Gloss = "Malta", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Malta"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "νῆσος", Transliteration = "nēsos", Gloss = "island", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the island"
                        },
                        new Word { Greek = "καλεῖται", Transliteration = "kaleitai", Gloss = "is called", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "that the island is called Malta"
                }
            },
            Translation = "And having been brought safely through, then we learned that the island is called Malta."
        },

        // Verse 2
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
                        new Word { Greek = "οἵ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "βάρβαροι", Transliteration = "barbaroi", Gloss = "native people", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "And the native people"
                },
                new Word { Greek = "παρεῖχον", Transliteration = "pareichon", Gloss = "showed", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "no", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "τυχοῦσαν", Transliteration = "tychousan", Gloss = "ordinary", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "F", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "φιλανθρωπίαν", Transliteration = "philanthrōpian", Gloss = "kindness", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "no ordinary kindness"
                },
                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "P" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἅψαντες", Transliteration = "hapsantes", Gloss = "having kindled", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "having kindled"
                        },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πυρὰν", Transliteration = "pyran", Gloss = "a fire", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a fire"
                        },
                        new Word { Greek = "προσελάβοντο", Transliteration = "proselabonto", Gloss = "they welcomed", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάντας", Transliteration = "pantas", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us", GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "all of us"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ὑετὸν", Transliteration = "hyeton", Gloss = "rain", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἐφεστῶτα", Transliteration = "ephestōta", Gloss = "that had come upon us", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "the rain that had come upon us"
                                }
                            },
                            Translation = "because of the rain that had come upon us"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ψῦχος", Transliteration = "psychos", Gloss = "cold", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the cold"
                                }
                            },
                            Translation = "because of the cold"
                        }
                    },
                    Translation = "for they kindled a fire and welcomed us all because of the rain that had come upon us and because of the cold"
                }
            },
            Translation = "The native people showed us no ordinary kindness, for they kindled a fire and welcomed us all because of the rain that had come upon us and because of the cold."
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Συστρέψαντος", Transliteration = "systrepsantos", Gloss = "having gathered", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Παύλου", Transliteration = "Paulou", Gloss = "Paul", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Paul"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "φρυγάνων", Transliteration = "phryganōn", Gloss = "of sticks", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "τι", Transliteration = "ti", Gloss = "a certain", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                                new Word { Greek = "πλῆθος", Transliteration = "plēthos", Gloss = "bundle", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a bundle of sticks"
                        }
                    },
                    Translation = "When Paul had gathered a bundle of sticks"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπιθέντος", Transliteration = "epithentos", Gloss = "having put them", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "and put them"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πυράν", Transliteration = "pyran", Gloss = "fire", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the fire"
                        }
                    },
                    Translation = "on the fire"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔχιδνα", Transliteration = "echidna", Gloss = "a viper", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "a viper"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "because of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θέρμης", Transliteration = "thermēs", Gloss = "heat", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the heat"
                        }
                    },
                    Translation = "because of the heat"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξελθοῦσα", Transliteration = "exelthousa", Gloss = "having come out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "having come out"
                },
                new Word { Greek = "καθῆψεν", Transliteration = "kathēpsen", Gloss = "fastened", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "χειρὸς", Transliteration = "cheiros", Gloss = "hand", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "his hand"
                }
            },
            Translation = "When Paul had gathered a bundle of sticks and put them on the fire, a viper came out because of the heat and fastened on his hand."
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
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "εἶδον", Transliteration = "eidon", Gloss = "saw", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "βάρβαροι", Transliteration = "barbaroi", Gloss = "native people", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the native people"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κρεμάμενον", Transliteration = "kremamenon", Gloss = "hanging", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "ACC", "N", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "hanging"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θηρίον", Transliteration = "thērion", Gloss = "creature", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the creature"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "χειρὸς", Transliteration = "cheiros", Gloss = "hand", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                                    },
                                    Translation = "his hand"
                                }
                            },
                            Translation = "from his hand"
                        }
                    },
                    Translation = "When the native people saw the creature hanging from his hand"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀλλήλους", Transliteration = "allēlous", Gloss = "one another", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "to one another"
                },
                new Word { Greek = "ἔλεγον", Transliteration = "elegon", Gloss = "they said", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάντως", Transliteration = "pantōs", Gloss = "No doubt", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "φονεύς", Transliteration = "phoneus", Gloss = "a murderer", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a murderer"
                        },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἄνθρωπος", Transliteration = "anthrōpos", Gloss = "man", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "this man"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "whom", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "διασωθέντα", Transliteration = "diasōthenta", Gloss = "having been saved", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "though he was saved"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "θαλάσσης", Transliteration = "thalassēs", Gloss = "sea", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "the sea"
                                        }
                                    },
                                    Translation = "from the sea"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "δίκη", Transliteration = "dikē", Gloss = "Justice", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "Justice"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ζῆν", Transliteration = "zēn", Gloss = "to live", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "to live"
                                },
                                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                                new Word { Greek = "εἴασεν", Transliteration = "eiasen", Gloss = "has allowed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "whom, though he was saved from the sea, Justice has not allowed to live."
                        }
                    },
                    Translation = "\"No doubt this man is a murderer, whom, though he was saved from the sea, Justice has not allowed to live.\""
                }
            },
            Translation = "When the native people saw the creature hanging from his hand, they said to one another, \"No doubt this man is a murderer, whom, though he was saved from the sea, Justice has not allowed to live.\""
        },

        // Verse 5
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "He", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀποτινάξας", Transliteration = "apotinaxas", Gloss = "having shaken off", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "He, then, having shaken off"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θηρίον", Transliteration = "thērion", Gloss = "creature", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the creature"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πῦρ", Transliteration = "pyr", Gloss = "fire", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the fire"
                        }
                    },
                    Translation = "into the fire"
                },
                new Word { Greek = "ἔπαθεν", Transliteration = "epathen", Gloss = "suffered", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐδὲν", Transliteration = "ouden", Gloss = "no", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "κακόν", Transliteration = "kakon", Gloss = "harm", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "no harm"
                }
            },
            Translation = "He, then, shook off the creature into the fire and suffered no harm."
        },

        // Verse 6
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "They", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" }
                    },
                    Translation = "But they"
                },
                new Word { Greek = "προσεδόκων", Transliteration = "prosedokōn", Gloss = "were expecting", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "μέλλειν", Transliteration = "mellein", Gloss = "to be about", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "πίμπρασθαι", Transliteration = "pimprasthai", Gloss = "to swell up", GrammarCodes = new List<string> { "V", "PRES", "PASS", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καταπίπτειν", Transliteration = "katapiptsein", Gloss = "to fall down", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἄφνω", Transliteration = "aphnō", Gloss = "suddenly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "νεκρόν", Transliteration = "nekron", Gloss = "dead", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "him to be about to swell up or suddenly fall down dead"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "for", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "πολὺ", Transliteration = "poly", Gloss = "a long time", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "for a long time"
                        },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "they", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "προσδοκώντων", Transliteration = "prosdokōntōn", Gloss = "waiting", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "But when they had waited a long time"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θεωρούντων", Transliteration = "theōrountōn", Gloss = "seeing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "and saw"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μηδὲν", Transliteration = "mēden", Gloss = "nothing", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἄτοπον", Transliteration = "atopon", Gloss = "unusual", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "nothing unusual"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "to him"
                        },
                        new Word { Greek = "γινόμενον", Transliteration = "ginomenon", Gloss = "happening", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "ACC", "N", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "happening to him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μεταβαλόμενοι", Transliteration = "metabalomenoi", Gloss = "having changed their minds", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "they changed their minds"
                },
                new Word { Greek = "ἔλεγον", Transliteration = "elegon", Gloss = "and said", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "θεόν", Transliteration = "theon", Gloss = "a god", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a god"
                        }
                    },
                    Translation = "that he was a god"
                }
            },
            Translation = "They were expecting him to swell up or suddenly fall down dead. But when they had waited a long time and saw nothing unusual happening to him, they changed their minds and said that he was a god."
        },

        // Verse 7
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
                        new Word { Greek = "Ἐν", Transliteration = "En", Gloss = "In", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "around", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "τόπον", Transliteration = "topon", Gloss = "place", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "ἐκεῖνον", Transliteration = "ekeinon", Gloss = "that", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" }
                                            },
                                            Translation = "that place"
                                        }
                                    },
                                    Translation = "around that place"
                                }
                            },
                            Translation = "the neighborhood of that place"
                        }
                    },
                    Translation = "Now in the neighborhood of that place"
                },
                new Word { Greek = "ὑπῆρχεν", Transliteration = "hypērchen", Gloss = "there were", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χωρία", Transliteration = "chōria", Gloss = "lands", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "lands"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "belonging to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πρώτῳ", Transliteration = "prōtō", Gloss = "chief man", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "νήσου", Transliteration = "nēsou", Gloss = "island", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the island"
                        }
                    },
                    Translation = "belonging to the chief man of the island"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὀνόματι", Transliteration = "onomati", Gloss = "by name", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Ποπλίῳ", Transliteration = "Popliō", Gloss = "Publius", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "named Publius"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀναδεξάμενος", Transliteration = "anadexamenos", Gloss = "having received", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "having received"
                        },
                        new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us", GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τρεῖς", Transliteration = "treis", Gloss = "three", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἡμέρας", Transliteration = "hēmeras", Gloss = "days", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "three days"
                        },
                        new Word { Greek = "φιλοφρόνως", Transliteration = "philophronōs", Gloss = "hospitably", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ἐξένισεν", Transliteration = "exenisen", Gloss = "entertained", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "who received us and entertained us hospitably for three days."
                }
            },
            Translation = "Now in the neighborhood of that place were lands belonging to the chief man of the island, named Publius, who received us and entertained us hospitably for three days."
        },

        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "It happened", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πατέρα", Transliteration = "patera", Gloss = "father", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Ποπλίου", Transliteration = "Popliou", Gloss = "Publius", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of Publius"
                        }
                    },
                    Translation = "the father of Publius"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πυρετοῖς", Transliteration = "pyretois", Gloss = "with fever", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "δυσεντερίῳ", Transliteration = "dysenteriō", Gloss = "dysentery", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "with fever and dysentery"
                        },
                        new Word { Greek = "συνεχόμενον", Transliteration = "synechomenon", Gloss = "being afflicted", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "being afflicted with fever and dysentery"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατακεῖσθαι", Transliteration = "katakeisthai", Gloss = "to be lying sick", GrammarCodes = new List<string> { "V", "PRES", "MID", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "lay sick"
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
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "whom", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "whom"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Παῦλος", Transliteration = "Paulos", Gloss = "Paul", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Paul"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰσελθὼν", Transliteration = "eiselthōn", Gloss = "having gone in", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "visited"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "προσευξάμενος", Transliteration = "proseuxamenos", Gloss = "having prayed", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "and prayed"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπιθεὶς", Transliteration = "epitheis", Gloss = "having put", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "and putting"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "χεῖρας", Transliteration = "cheiras", Gloss = "hands", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "his hands"
                        },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "on him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἰάσατο", Transliteration = "iasato", Gloss = "he healed", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "Paul visited him, and after praying and putting his hands on him, healed him."
                }
            },
            Translation = "It happened that the father of Publius lay sick with fever and dysentery. Paul visited him, and after praying and putting his hands on him, healed him."
        }
    };
}

/*
Constructions identified:
- Verse 3: GEN_ABS (Συστρέψαντος... Παύλου) - Genitive absolute construction.
- Verse 6: GEN_ABS (αὐτῶν προσδοκώντων) - Genitive absolute construction.
- Verse 7: DAT_REF (ὀνόματι Ποπλίῳ) - Dative of reference/respect.
- Verse 8: DAT_INSTR (πυρετοῖς καὶ δυσεντερίῳ) - Dative of instrument/cause.
*/
