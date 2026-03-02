private static List<object> GetChapter19()
{
    // Luke 19:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "say", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "to him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σήμερον", Transliteration = "sēmeron", Gloss = "today", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "σωτηρία", Transliteration = "sōtēria", Gloss = "salvation", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "salvation"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "οἴκῳ", Transliteration = "oikō", Gloss = "house", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τούτῳ", Transliteration = "toutō", Gloss = "this", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adv" }
                            },
                            Translation = "to this house"
                        },
                        new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "to be", GrammarCodes = new List<string> { "V", "AOR", "MP", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "that today salvation has come to this house"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθότι", Transliteration = "kathoti", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "he also"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "υἱὸς", Transliteration = "huios", Gloss = "son", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Ἀβραάμ", Transliteration = "Abraam", Gloss = "Abraham", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a son of Abraham"
                        },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "since he also is a son of Abraham"
                }
            },
            Translation = "And Jesus said to him, 'Today salvation has come to this house, because he also is a son of Abraham.'"
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἦλθεν", Transliteration = "ēlthen", Gloss = "to come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "υἱὸς", Transliteration = "huios", Gloss = "son", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀνθρώπου", Transliteration = "anthrōpou", Gloss = "human being", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of man"
                        }
                    },
                    Translation = "the Son of Man"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ζητῆσαι", Transliteration = "zētēsai", Gloss = "to look for", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σῶσαι", Transliteration = "sōsai", Gloss = "to save", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀπολωλός", Transliteration = "apolōlos", Gloss = "to destroy", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "ACC", "N", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "that which was lost"
                        }
                    },
                    Translation = "to seek and to save that which was lost"
                }
            },
            Translation = "For the Son of Man came to seek and to save that which was lost."
        },

        // Verse 11
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
                        new Word { Greek = "Ἀκουόντων", Transliteration = "Akouontōn", Gloss = "to hear", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "this", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adv" }
                    },
                    Translation = "As they heard these things"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προσθεὶς", Transliteration = "prostheis", Gloss = "to add to", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "adding"
                },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "say", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παραβολὴν", Transliteration = "parabolēn", Gloss = "parable", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "a parable"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐγγὺς", Transliteration = "engys", Gloss = "near", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                                new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "Ἰερουσαλὴμ", Transliteration = "Ierousalēm", Gloss = "Jerusalem", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "his being near Jerusalem"
                        }
                    },
                    Translation = "because he was near Jerusalem"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δοκεῖν", Transliteration = "dokein", Gloss = "to think", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "their supposing"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "παραχρῆμα", Transliteration = "parachrēma", Gloss = "immediately", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                new Word { Greek = "μέλλει", Transliteration = "mellei", Gloss = "to be about to", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "βασιλεία", Transliteration = "basileia", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "of God"
                                        }
                                    },
                                    Translation = "the kingdom of God"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀναφαίνεσθαι", Transliteration = "anaphainesthai", Gloss = "to appear", GrammarCodes = new List<string> { "V", "PRES", "PASS", "INF" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "to appear"
                                }
                            },
                            Translation = "that the kingdom of God was about to appear immediately"
                        }
                    },
                    Translation = "and because they supposed that the kingdom of God was about to appear immediately"
                }
            },
            Translation = "As they heard these things, he proceeded to tell a parable, because he was near Jerusalem, and they supposed that the kingdom of God was about to appear immediately."
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "say", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
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
                                new Word { Greek = "ἄνθρωπός", Transliteration = "anthrōpos", Gloss = "human being", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τις", Transliteration = "tis", Gloss = "someone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "part" },
                                new Word { Greek = "εὐγενὴς", Transliteration = "eugenēs", Gloss = "of noble birth", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "a certain nobleman"
                        },
                        new Word { Greek = "ἐπορεύθη", Transliteration = "eporeuthē", Gloss = "to come", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "χώραν", Transliteration = "chōran", Gloss = "country", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "μακρὰν", Transliteration = "makran", Gloss = "lengthy", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "into a far country"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "λαβεῖν", Transliteration = "labein", Gloss = "to take", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "ἑαυτῷ", Transliteration = "heautō", Gloss = "himself", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "f" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "βασιλείαν", Transliteration = "basileian", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "a kingdom"
                                },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "ὑποστρέψαι", Transliteration = "hypostrepsai", Gloss = "to turn back toward", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "to receive for himself a kingdom and to return"
                        }
                    },
                    Translation = "A certain nobleman went into a far country to receive for himself a kingdom and to return."
                }
            },
            Translation = "He said therefore, 'A certain nobleman went into a far country to receive for himself a kingdom and to return.'"
        },

        // Verse 13
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
                        new Word { Greek = "καλέσας", Transliteration = "kalesas", Gloss = "to call", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δέκα", Transliteration = "deka", Gloss = "ten", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "δούλους", Transliteration = "doulous", Gloss = "to enslave", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἑαυτοῦ", Transliteration = "heautou", Gloss = "himself", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "f" }
                            },
                            Translation = "ten of his servants"
                        }
                    },
                    Translation = "Calling ten of his servants"
                },
                new Word { Greek = "ἔδωκεν", Transliteration = "edōken", Gloss = "to give", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "he", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "to them"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δέκα", Transliteration = "deka", Gloss = "ten", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "μνᾶς", Transliteration = "mnas", Gloss = "mina", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "ten minas"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "say", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτούς", Transliteration = "autous", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "to them"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πραγματεύσασθε", Transliteration = "pragmateusasthe", Gloss = "to put capital to work", GrammarCodes = new List<string> { "V", "AOR", "MP", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ᾧ", Transliteration = "hō", Gloss = "who", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" },
                                new Word { Greek = "ἔρχομαι", Transliteration = "erchomai", Gloss = "to come", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "1P", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "until I come"
                        }
                    },
                    Translation = "Engage in business until I come."
                }
            },
            Translation = "Calling ten of his servants, he gave them ten minas and said to them, 'Engage in business until I come.'"
        },

        // Verse 14
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πολῖται", Transliteration = "politai", Gloss = "citizen", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "his"
                        }
                    },
                    Translation = "But his citizens"
                },
                new Word { Greek = "ἐμίσουν", Transliteration = "emisoun", Gloss = "to hate", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀπέστειλαν", Transliteration = "apesteilan", Gloss = "to send", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρεσβείαν", Transliteration = "presbeian", Gloss = "delegation", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "a delegation"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὀπίσω", Transliteration = "opisō", Gloss = "behind", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "after him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "no", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Word { Greek = "θέλομεν", Transliteration = "thelomen", Gloss = "to will", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦτον", Transliteration = "touton", Gloss = "this", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adv" },
                                new Word { Greek = "βασιλεῦσαι", Transliteration = "basileusai", Gloss = "to reign as a king", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐφ᾽", Transliteration = "eph'", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "I", GrammarCodes = new List<string> { "PRON", "ACC", "P" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "over us"
                                }
                            },
                            Translation = "this man to reign over us"
                        }
                    },
                    Translation = "We do not want this man to reign over us."
                }
            },
            Translation = "But his citizens hated him and sent a delegation after him, saying, 'We do not want this man to reign over us.'"
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "to be", GrammarCodes = new List<string> { "V", "AOR", "MP", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπανελθεῖν", Transliteration = "epanelthein", Gloss = "to return", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "λαβόντα", Transliteration = "labonta", Gloss = "to take", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "βασιλείαν", Transliteration = "basileian", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "the kingdom"
                                        }
                                    },
                                    Translation = "having received the kingdom"
                                }
                            },
                            Translation = "when he returned, having received the kingdom"
                        }
                    },
                    Translation = "when he returned, having received the kingdom"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "say", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φωνηθῆναι", Transliteration = "phōnēthēnai", Gloss = "to call", GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "he", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "to him"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "δούλους", Transliteration = "doulous", Gloss = "to enslave", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "τούτους", Transliteration = "toutous", Gloss = "this", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adv" }
                            },
                            Translation = "these servants"
                        }
                    },
                    Translation = "to call these servants to him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἷς", Transliteration = "hois", Gloss = "who", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "δεδώκει", Transliteration = "dedōkei", Gloss = "to give", GrammarCodes = new List<string> { "V", "PLPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀργύριον", Transliteration = "argyrion", Gloss = "silver", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the money"
                        }
                    },
                    Translation = "to whom he had given the money"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γνοῖ", Transliteration = "gnoi", Gloss = "to know", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τί", Transliteration = "ti", Gloss = "who?", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "interj" },
                                new Word { Greek = "διεπραγματεύσαντο", Transliteration = "diepragmateusanto", Gloss = "to gain", GrammarCodes = new List<string> { "V", "AOR", "MP", "IND", "3P", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "what they had gained"
                        }
                    },
                    Translation = "so that he might know what they had gained"
                }
            },
            Translation = "And it happened that when he returned, having received the kingdom, he commanded these servants to whom he had given the money to be called to him, so that he might know what they had gained."
        },

        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "παρεγένετο", Transliteration = "paregeneto", Gloss = "to come", GrammarCodes = new List<string> { "V", "AOR", "MP", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πρῶτος", Transliteration = "prōtos", Gloss = "first", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the first"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριε", Transliteration = "kyrie", Gloss = "lord", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Lord"
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
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "μνᾶ", Transliteration = "mna", Gloss = "mina", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "you", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "your"
                                }
                            },
                            Translation = "your mina"
                        },
                        new Word { Greek = "δέκα", Transliteration = "deka", Gloss = "ten", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "προσηργάσατο", Transliteration = "prosērgasato", Gloss = "to earn more", GrammarCodes = new List<string> { "V", "AOR", "MP", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μνᾶς", Transliteration = "mnas", Gloss = "mina", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "minas"
                        }
                    },
                    Translation = "your mina has earned ten minas more"
                }
            },
            Translation = "The first came, saying, 'Lord, your mina has earned ten minas more.'"
        }
    };
}

/*
Identified Constructions:
- GEN_ABS: Luke 19:11 (Ἀκουόντων δὲ αὐτῶν ταῦτα)
- INF_PHRASE (Articular): Luke 19:11 (διὰ τὸ ἐγγὺς εἶναι...)
- INF_PHRASE (Articular): Luke 19:15 (ἐν τῷ ἐπανελθεῖν...)
*/
