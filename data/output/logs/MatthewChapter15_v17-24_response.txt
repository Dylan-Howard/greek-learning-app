private static List<object> GetChapter15()
{
    // Matthew 15:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "no", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "νοεῖτε", Transliteration = "noeite", Gloss = "to understand", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πᾶν", Transliteration = "pan", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "εἰσπορευόμενον", Transliteration = "eisporeuomenon", Gloss = "to go in", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "the thing entering"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "στόμα", Transliteration = "stoma", Gloss = "mouth", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "the mouth"
                                        }
                                    },
                                    Translation = "into the mouth"
                                }
                            },
                            Translation = "everything entering into the mouth"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "VERB_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "κοιλίαν", Transliteration = "koilian", Gloss = "any and all internal organs", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "the stomach"
                                        }
                                    },
                                    Translation = "into the stomach"
                                },
                                new Word { Greek = "χωρεῖ", Transliteration = "chōrei", Gloss = "to go", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "goes into the stomach"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "VERB_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "ἀφεδρῶνα", Transliteration = "aphedrōna", Gloss = "latrine", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "into the latrine"
                                },
                                new Word { Greek = "ἐκβάλλεται", Transliteration = "ekballetai", Gloss = "to take out", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "is cast out"
                        }
                    },
                    Translation = "that everything entering into the mouth goes into the stomach and is cast out"
                }
            },
            Translation = "Do you not understand that everything that enters into the mouth goes into the stomach and is cast out into the latrine?"
        },
        // Verse 18
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
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκπορευόμενα", Transliteration = "ekporeuomena", Gloss = "to go out", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "N", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "the things proceeding out"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "στόματος", Transliteration = "stomatos", Gloss = "mouth", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the mouth"
                                }
                            },
                            Translation = "out of the mouth"
                        }
                    },
                    Translation = "But the things proceeding out of the mouth"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "καρδίας", Transliteration = "kardias", Gloss = "heart", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the heart"
                        }
                    },
                    Translation = "from the heart"
                },
                new Word { Greek = "ἐξέρχεται", Transliteration = "exerchetai", Gloss = "to go out", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "κἀκεῖνα", Transliteration = "kakeina", Gloss = "and that one", GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "κοινοῖ", Transliteration = "koinoi", Gloss = "to make unclean", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἄνθρωπον", Transliteration = "anthrōpon", Gloss = "human being", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the person"
                }
            },
            Translation = "But the things proceeding out of the mouth come out from the heart, and those things defile the person."
        },
        // Verse 19
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
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "καρδίας", Transliteration = "kardias", Gloss = "heart", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the heart"
                        }
                    },
                    Translation = "For out of the heart"
                },
                new Word { Greek = "ἐξέρχονται", Transliteration = "exerchontai", Gloss = "to go out", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διαλογισμοὶ", Transliteration = "dialogismoi", Gloss = "thought", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "πονηροί", Transliteration = "ponēroi", Gloss = "bad", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "φόνοι", Transliteration = "phonoi", Gloss = "murder", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "μοιχεῖαι", Transliteration = "moicheiai", Gloss = "adultery", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "πορνεῖαι", Transliteration = "porneiai", Gloss = "sexual immorality", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "κλοπαί", Transliteration = "klopai", Gloss = "theft", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ψευδομαρτυρίαι", Transliteration = "pseudomartyriai", Gloss = "false testimony", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "βλασφημίαι", Transliteration = "blasphēmiai", Gloss = "blasphemy", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "evil thoughts, murders, adulteries, sexual immoralities, thefts, false testimonies, blasphemies"
                }
            },
            Translation = "For out of the heart come evil thoughts, murders, adulteries, sexual immoralities, thefts, false testimonies, blasphemies."
        },
        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ταῦτά", Transliteration = "tauta", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κοινοῦντα", Transliteration = "koinounta", Gloss = "to make unclean", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "the things defiling"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἄνθρωπον", Transliteration = "anthrōpon", Gloss = "human being", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the person"
                        }
                    },
                    Translation = "the things that defile the person"
                }
            },
            Translation = "These are the things that defile the person;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀνίπτοις", Transliteration = "aniptois", Gloss = "unwashed", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "χερσὶν", Transliteration = "chersin", Gloss = "hand", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "with unwashed hands"
                        },
                        new Word { Greek = "φαγεῖν", Transliteration = "phagein", Gloss = "to eat", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "to eat with unwashed hands"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "no", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "κοινοῖ", Transliteration = "koinoi", Gloss = "to make unclean", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἄνθρωπον", Transliteration = "anthrōpon", Gloss = "human being", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the person"
                }
            },
            Translation = "but to eat with unwashed hands does not defile the person."
        },
        // Verse 21
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
                        new Word { Greek = "ἐξελθὼν", Transliteration = "exelthōn", Gloss = "to go out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἐκεῖθεν", Transliteration = "ekeithen", Gloss = "from there", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                    },
                    Translation = "going out from there"
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
                new Word { Greek = "ἀνεχώρησεν", Transliteration = "anechōrēsen", Gloss = "to withdraw", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "μέρη", Transliteration = "merē", Gloss = "part", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "Τύρου", Transliteration = "Tyrou", Gloss = "Tyre", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                        new Word { Greek = "Σιδῶνος", Transliteration = "Sidōnos", Gloss = "Sidon", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of Tyre and Sidon"
                                }
                            },
                            Translation = "the regions of Tyre and Sidon"
                        }
                    },
                    Translation = "into the regions of Tyre and Sidon"
                }
            },
            Translation = "And going out from there, Jesus withdrew into the regions of Tyre and Sidon."
        },
        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "look!", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γυνὴ", Transliteration = "gynē", Gloss = "woman", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Χαναναία", Transliteration = "Chananaia", Gloss = "Canaanite", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a Canaanite woman"
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
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὁρίων", Transliteration = "oriōn", Gloss = "region", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἐκείνων", Transliteration = "ekeinōn", Gloss = "that", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "adv" }
                            },
                            Translation = "those regions"
                        }
                    },
                    Translation = "from those regions"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξελθοῦσα", Transliteration = "exelthousa", Gloss = "to go out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "having come out"
                },
                new Word { Greek = "ἔκραζεν", Transliteration = "ekrazen", Gloss = "call out", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγουσα", Transliteration = "legousa", Gloss = "say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλέησόν", Transliteration = "eleēson", Gloss = "to have mercy on", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "με", Transliteration = "me", Gloss = "I", GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "κύριε", Transliteration = "kyrie", Gloss = "lord", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "υἱὸς", Transliteration = "huios", Gloss = "son", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Δαυίδ", Transliteration = "Dauid", Gloss = "David", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Son of David"
                        }
                    },
                    Translation = "Have mercy on me, Lord, Son of David!"
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
                                new Word { Greek = "θυγάτηρ", Transliteration = "thygatēr", Gloss = "daughter", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "I", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "my daughter"
                        },
                        new Word { Greek = "κακῶς", Transliteration = "kakōs", Gloss = "badly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "δαιμονίζεται", Transliteration = "daimonizetai", Gloss = "to be demon-possessed", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "My daughter is badly demon-possessed."
                }
            },
            Translation = "And behold, a Canaanite woman from those regions, having come out, was crying out, saying: 'Have mercy on me, Lord, Son of David! My daughter is badly demon-possessed.'"
        },
        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "no", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἀπεκρίθη", Transliteration = "apekrithē", Gloss = "to answer", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῇ", Transliteration = "autē", Gloss = "he", GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "λόγον", Transliteration = "logon", Gloss = "word", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "But he did not answer her a word."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προσελθόντες", Transliteration = "proselthontes", Gloss = "to come to", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "having come"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciple", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "his disciples"
                },
                new Word { Greek = "ἠρώτουν", Transliteration = "ērōtoun", Gloss = "to ask", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" },
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
                        new Word { Greek = "ἀπόλυσον", Transliteration = "apolyson", Gloss = "to release", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτήν", Transliteration = "autēn", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "Release her"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "κράζει", Transliteration = "krazei", Gloss = "call out", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὄπισθεν", Transliteration = "opisthen", Gloss = "from behind", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "I", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "because she cries out behind us"
                }
            },
            Translation = "And having come, his disciples were asking him, saying: 'Release her, because she cries out behind us.'"
        },
        // Verse 24
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀποκριθεὶς", Transliteration = "apokritheis", Gloss = "to answer", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "answering"
                },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "say", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "no", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀπεστάλην", Transliteration = "apestalēn", Gloss = "to send", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "no", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "πρόβατα", Transliteration = "probata", Gloss = "sheep", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                                new Word { Greek = "ἀπολωλότα", Transliteration = "apolōlota", Gloss = "to destroy", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "ACC", "N", "P" }, PartOfSpeech = "v" }
                                            },
                                            Translation = "the lost"
                                        },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "οἴκου", Transliteration = "oikou", Gloss = "house", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "Ἰσραήλ", Transliteration = "Israēl", Gloss = "Israel", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "of the house of Israel"
                                        }
                                    },
                                    Translation = "the lost sheep of the house of Israel"
                                }
                            },
                            Translation = "except to the lost sheep of the house of Israel"
                        }
                    },
                    Translation = "I was not sent except to the lost sheep of the house of Israel."
                }
            },
            Translation = "But he answering said: 'I was not sent except to the lost sheep of the house of Israel.'"
        }
    };
}
/*
Constructions identified:
- DAT_INSTR: ἀνίπτοις χερσὶν (v20)
- GEN_DESC: οἴκου Ἰσραήλ (v24)
*/
