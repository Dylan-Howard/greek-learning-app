private static List<object> GetChapter24()
{
    // Matthew 24:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξελθὼν", Transliteration = "exelthōn", Gloss = "having gone out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "having gone out"
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
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἱεροῦ", Transliteration = "hierou", Gloss = "temple", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the temple"
                        }
                    },
                    Translation = "from the temple"
                },
                new Word { Greek = "ἐπορεύετο", Transliteration = "eporeueto", Gloss = "was going", GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "And Jesus, having gone out from the temple, was going away."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "προσῆλθον", Transliteration = "prosēlthon", Gloss = "came to", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "his disciples"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπιδεῖξαι", Transliteration = "epideixai", Gloss = "to show", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "οἰκοδομὰς", Transliteration = "oikodomas", Gloss = "buildings", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἱεροῦ", Transliteration = "hierou", Gloss = "temple", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the temple"
                                }
                            },
                            Translation = "the buildings of the temple"
                        }
                    },
                    Translation = "to show him the buildings of the temple"
                }
            },
            Translation = "And his disciples came to show him the buildings of the temple."
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" }
                    },
                    Translation = "he"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀποκριθεὶς", Transliteration = "apokritheis", Gloss = "answering", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "answering"
                },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Word { Greek = "βλέπετε", Transliteration = "blepete", Gloss = "do you see", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "adv" },
                                new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "all these things"
                        }
                    },
                    Translation = "Do you not see all these things?"
                }
            },
            Translation = "But answering, he said to them, 'Do you not see all these things?'"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀμὴν", Transliteration = "amēn", Gloss = "truly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "h" },
                new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀφεθῇ", Transliteration = "afethē", Gloss = "shall be left", GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὧδε", Transliteration = "hōde", Gloss = "here", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "λίθος", Transliteration = "lithos", Gloss = "a stone", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a stone"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "upon", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "λίθον", Transliteration = "lithon", Gloss = "a stone", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "upon a stone"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "which", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                                new Word { Greek = "καταλυθήσεται", Transliteration = "katalythēsetai", Gloss = "will be thrown down", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "which will not be thrown down"
                        }
                    },
                    Translation = "not one stone shall be left here upon another, which will not be thrown down."
                }
            },
            Translation = "Truly I say to you, not one stone shall be left here upon another, which will not be thrown down."
        },

        // Verse 3
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
                        new Word { Greek = "Καθημένου", Transliteration = "Kathēmenou", Gloss = "sitting", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "And as he was sitting"
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
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὄρους", Transliteration = "orous", Gloss = "mountain", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἐλαιῶν", Transliteration = "elaiōn", Gloss = "olives", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of Olives"
                                }
                            },
                            Translation = "the Mount of Olives"
                        }
                    },
                    Translation = "on the Mount of Olives"
                },
                new Word { Greek = "προσῆλθον", Transliteration = "prosēlthon", Gloss = "came to", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the disciples"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατ᾽", Transliteration = "kat'", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἰδίαν", Transliteration = "idian", Gloss = "private", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "privately"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                }
            },
            Translation = "As he was sitting on the Mount of Olives, the disciples came to him privately, saying,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰπὲ", Transliteration = "eipe", Gloss = "tell", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "us", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πότε", Transliteration = "pote", Gloss = "when", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ἔσται", Transliteration = "estai", Gloss = "will be", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "when will these things be"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti", Gloss = "what", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "interj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σημεῖον", Transliteration = "sēmeion", Gloss = "sign", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the sign"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σῆς", Transliteration = "sēs", Gloss = "your", GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "s" },
                                new Word { Greek = "παρουσίας", Transliteration = "parousias", Gloss = "coming", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of your coming"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "συντελείας", Transliteration = "synteleias", Gloss = "end", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "αἰῶνος", Transliteration = "aiōnos", Gloss = "age", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the age"
                                }
                            },
                            Translation = "end of the age"
                        }
                    },
                    Translation = "what will be the sign of your coming and of the end of the age?"
                }
            },
            Translation = "Tell us, when will these things be, and what will be the sign of your coming and of the end of the age?"
        },

        // Verse 4
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
                        new Word { Greek = "ἀποκριθεὶς", Transliteration = "apokritheis", Gloss = "answering", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "answering"
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
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βλέπετε", Transliteration = "blepete", Gloss = "see to it", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μή", Transliteration = "mē", Gloss = "lest", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τις", Transliteration = "tis", Gloss = "someone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "part" },
                                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" },
                                new Word { Greek = "πλανήσῃ", Transliteration = "planēsē", Gloss = "leads astray", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "lest someone lead you astray"
                        }
                    },
                    Translation = "See to it that no one leads you astray."
                }
            },
            Translation = "And answering, Jesus said to them, 'See to it that no one leads you astray.'"
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πολλοὶ", Transliteration = "polloi", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐλεύσονται", Transliteration = "eleusontai", Gloss = "will come", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὀνόματί", Transliteration = "onomati", Gloss = "name", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "my name"
                        }
                    },
                    Translation = "in my name"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐγώ", Transliteration = "egō", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "εἰμι", Transliteration = "eimi", Gloss = "am", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "χριστός", Transliteration = "christos", Gloss = "Christ", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Christ"
                        }
                    },
                    Translation = "I am the Christ"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πολλοὺς", Transliteration = "pollous", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "πλανήσουσιν", Transliteration = "planēsousin", Gloss = "they will lead astray", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "For many will come in my name, saying, 'I am the Christ,' and they will lead many astray."
        },

        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μελλήσετε", Transliteration = "mellēsete", Gloss = "you will be about", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀκούειν", Transliteration = "akouein", Gloss = "to hear", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "πολέμους", Transliteration = "polemous", Gloss = "wars", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀκοὰς", Transliteration = "akoas", Gloss = "rumors", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "πολέμων", Transliteration = "polemōn", Gloss = "of wars", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "rumors of wars"
                        }
                    },
                    Translation = "to hear of wars and rumors of wars"
                }
            },
            Translation = "And you will hear of wars and rumors of wars."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁρᾶτε", Transliteration = "horate", Gloss = "see", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "θροεῖσθε", Transliteration = "throeisthe", Gloss = "be alarmed", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IMP", "2P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "See that you are not alarmed."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "δεῖ", Transliteration = "dei", Gloss = "it must", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γενέσθαι", Transliteration = "genesthai", Gloss = "to happen", GrammarCodes = new List<string> { "V", "AOR", "MID", "INF" }, PartOfSpeech = "v" }
            },
            Translation = "For it must happen,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὔπω", Transliteration = "oupō", Gloss = "not yet", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐστὶν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "τέλος", Transliteration = "telos", Gloss = "end", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the end"
                }
            },
            Translation = "but the end is not yet."
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγερθήσεται", Transliteration = "egerthēsetai", Gloss = "will rise", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔθνος", Transliteration = "ethnos", Gloss = "nation", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "nation"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἔθνος", Transliteration = "ethnos", Gloss = "nation", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "against nation"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βασιλεία", Transliteration = "basileia", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "kingdom"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "βασιλείαν", Transliteration = "basileian", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "against kingdom"
                }
            },
            Translation = "For nation will rise against nation, and kingdom against kingdom."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἔσονται", Transliteration = "esontai", Gloss = "there will be", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "λιμοὶ", Transliteration = "limoi", Gloss = "famines", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "σεισμοὶ", Transliteration = "seismoi", Gloss = "earthquakes", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τόπους", Transliteration = "topous", Gloss = "places", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "in various places"
                }
            },
            Translation = "And there will be famines and earthquakes in various places."
        },

        // Verse 8
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
                        new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" }, PartOfSpeech = "adv" }
                    },
                    Translation = "But all these things"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀρχὴ", Transliteration = "archē", Gloss = "the beginning", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὠδίνων", Transliteration = "ōdinōn", Gloss = "of birth pains", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the beginning of birth pains"
                }
            },
            Translation = "But all these things are the beginning of birth pains."
        }
    };
}

/*
Identified Constructions:
- Verse 3: GEN_ABS (Καθημένου δὲ αὐτοῦ)
- Verse 1, 2, 3, 4, 5: PTCP (Adverbial/Circumstantial participles: ἐξελθὼν, ἀποκριθεὶς, λέγοντες)
- Verse 1, 6: INF_PHRASE (Complementary/Purpose infinitives: ἐπιδεῖξαι, ἀκούειν, γενέσθαι)
*/
