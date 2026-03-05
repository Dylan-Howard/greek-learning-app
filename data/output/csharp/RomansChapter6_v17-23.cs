private static List<object> GetChapter6()
{
    // Romans 6:17-23
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "χάρις", Transliteration = "charis", Gloss = "grace",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἦτε", Transliteration = "ēte", Gloss = "you were",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δοῦλοι", Transliteration = "douloi", Gloss = "slaves",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἁμαρτίας", Transliteration = "hamartias", Gloss = "sin",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of sin"
                                }
                            },
                            Translation = "slaves of sin"
                        }
                    },
                    Translation = "because you were slaves of sin"
                },
                new Word { Greek = "ὑπηκούσατε", Transliteration = "hypēkousate", Gloss = "you obeyed",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "καρδίας", Transliteration = "kardias", Gloss = "heart",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "from the heart"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "which",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "παρεδόθητε", Transliteration = "paredothēte", Gloss = "you were delivered",
                                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "P" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τύπον", Transliteration = "typon", Gloss = "standard",
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "διδαχῆς", Transliteration = "didachēs", Gloss = "of teaching",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "standard of teaching"
                                }
                            },
                            Translation = "the standard of teaching to which you were delivered"
                        }
                    },
                    Translation = "to that standard of teaching"
                }
            },
            Translation = "But thanks be to God, that though you were slaves of sin, you became obedient from the heart to the standard of teaching to which you were delivered."
        },

        // Verse 18
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
                        new Word { Greek = "ἐλευθερωθέντες", Transliteration = "eleutherōthentes", Gloss = "having been set free",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἁμαρτίας", Transliteration = "hamartias", Gloss = "sin",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the sin"
                                }
                            },
                            Translation = "from sin"
                        }
                    },
                    Translation = "having been set free from sin"
                },
                new Word { Greek = "ἐδουλώθητε", Transliteration = "edoulōthēte", Gloss = "you became slaves",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δικαιοσύνῃ", Transliteration = "dikaiosynē", Gloss = "righteousness",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to righteousness"
                }
            },
            Translation = "And having been set free from sin, you became slaves to righteousness."
        },

        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀνθρώπινον", Transliteration = "anthrōpinon", Gloss = "in human terms",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I am speaking",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀσθένειαν", Transliteration = "astheneian", Gloss = "weakness",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "σαρκὸς", Transliteration = "sarkos", Gloss = "flesh",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "of your flesh"
                                }
                            },
                            Translation = "the weakness of your flesh"
                        }
                    },
                    Translation = "on account of the weakness of your flesh"
                }
            },
            Translation = "I am speaking in human terms because of the weakness of your flesh."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὥσπερ", Transliteration = "hōsper", Gloss = "for just as",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "παρεστήσατε", Transliteration = "parestēsate", Gloss = "you presented",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μέλη", Transliteration = "melē", Gloss = "members",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "your members"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δοῦλα", Transliteration = "doula", Gloss = "as slaves",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "to the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀκαθαρσίᾳ", Transliteration = "akatharsia", Gloss = "impurity",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to impurity"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "to the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀνομίᾳ", Transliteration = "anomia", Gloss = "lawlessness",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to lawlessness"
                        }
                    },
                    Translation = "slaves to impurity and to lawlessness"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀνομίαν", Transliteration = "anomian", Gloss = "lawlessness",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "lawlessness"
                        }
                    },
                    Translation = "leading to more lawlessness"
                }
            },
            Translation = "For just as you presented your members as slaves to impurity and to lawlessness leading to more lawlessness,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "so",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "παραστήσατε", Transliteration = "parastēsate", Gloss = "present",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μέλη", Transliteration = "melē", Gloss = "members",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "your members"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δοῦλα", Transliteration = "doula", Gloss = "as slaves",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "to the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "δικαιοσύνῃ", Transliteration = "dikaiosynē", Gloss = "righteousness",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to righteousness"
                        }
                    },
                    Translation = "slaves to righteousness"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἁγιασμόν", Transliteration = "hagiasmon", Gloss = "sanctification",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "leading to sanctification"
                }
            },
            Translation = "so now present your members as slaves to righteousness leading to sanctification."
        },

        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτε", Transliteration = "hote", Gloss = "when",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "δοῦλοι", Transliteration = "douloi", Gloss = "slaves",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἦτε", Transliteration = "ēte", Gloss = "you were",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἁμαρτίας", Transliteration = "hamartias", Gloss = "sin",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "of sin"
                }
            },
            Translation = "For when you were slaves of sin,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐλεύθεροι", Transliteration = "eleutheroi", Gloss = "free",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἦτε", Transliteration = "ēte", Gloss = "you were",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "to the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δικαιοσύνῃ", Transliteration = "dikaiosynē", Gloss = "righteousness",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in regard to righteousness"
                }
            },
            Translation = "you were free in regard to righteousness."
        },

        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τίνα", Transliteration = "tina", Gloss = "what",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "interj" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "καρπὸν", Transliteration = "karpon", Gloss = "benefit",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "what fruit therefore"
                },
                new Word { Greek = "εἴχετε", Transliteration = "eichete", Gloss = "were you deriving",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "then",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐφ᾽", Transliteration = "eph'", Gloss = "from which",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "οἷς", Transliteration = "hois", Gloss = "which things",
                            GrammarCodes = new List<string> { "PRON", "DAT", "N", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἐπαισχύνεσθε", Transliteration = "epaischynesthe", Gloss = "you are ashamed",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "from the things of which you are now ashamed"
                }
            },
            Translation = "Therefore what benefit were you then deriving from the things of which you are now ashamed?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "for the",
                    GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                    PartOfSpeech = "art" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "τέλος", Transliteration = "telos", Gloss = "outcome",
                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἐκείνων", Transliteration = "ekeinōn", Gloss = "of those things",
                    GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "θάνατος", Transliteration = "thanatos", Gloss = "is death",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" }
            },
            Translation = "For the outcome of those things is death."
        },

        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "νυνὶ", Transliteration = "nyni", Gloss = "but now",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλευθερωθέντες", Transliteration = "eleutherōthentes", Gloss = "having been set free",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἁμαρτίας", Transliteration = "hamartias", Gloss = "sin",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "sin"
                                }
                            },
                            Translation = "from sin"
                        }
                    },
                    Translation = "having been set free from sin"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δουλωθέντες", Transliteration = "doulōthentes", Gloss = "having become slaves",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to God"
                        }
                    },
                    Translation = "and having become slaves to God"
                },
                new Word { Greek = "ἔχετε", Transliteration = "echete", Gloss = "you have",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "καρπὸν", Transliteration = "karpon", Gloss = "fruit",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "your fruit"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "unto",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἁγιασμόν", Transliteration = "hagiasmon", Gloss = "sanctification",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "unto sanctification"
                },
                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "and the",
                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                    PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "τέλος", Transliteration = "telos", Gloss = "outcome",
                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ζωὴν", Transliteration = "zōēn", Gloss = "life",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αἰώνιον", Transliteration = "aiōnion", Gloss = "eternal",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "eternal life"
                }
            },
            Translation = "But now, having been set free from sin and having become slaves to God, you have your fruit unto sanctification, and the outcome is eternal life."
        },

        // Verse 23
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
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ὀψώνια", Transliteration = "opsōnia", Gloss = "wages",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἁμαρτίας", Transliteration = "hamartias", Gloss = "sin",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of sin"
                        }
                    },
                    Translation = "For the wages of sin"
                },
                new Word { Greek = "θάνατος", Transliteration = "thanatos", Gloss = "is death",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" }
            },
            Translation = "For the wages of sin is death,"
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
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "χάρισμα", Transliteration = "charisma", Gloss = "free gift",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of God"
                        }
                    },
                    Translation = "but the free gift of God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ζωὴ", Transliteration = "zōē", Gloss = "life",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αἰώνιος", Transliteration = "aiōnios", Gloss = "eternal",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "eternal life"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Χριστῷ", Transliteration = "Christō", Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "Lord",
                                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hymōn", Gloss = "of us",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "our Lord"
                                }
                            },
                            Translation = "Christ Jesus our Lord"
                        }
                    },
                    Translation = "in Christ Jesus our Lord"
                }
            },
            Translation = "but the free gift of God is eternal life in Christ Jesus our Lord."
        }
    };
}

/*
Constructions identified:
- Romans 6:17: REL_CLAUSE (ὃν παρεδόθητε...)
- Romans 6:18: PTCP (ἐλευθερωθέντες...) used adverbially (causal/circumstantial)
- Romans 6:19: GEN_DESC (τῆς σαρκὸς ὑμῶν)
- Romans 6:21: REL_CLAUSE (ἐφ᾽ οἷς νῦν ἐπαισχύνεσθε)
- Romans 6:22: APPOS (ζωὴν αἰώνιον appositive to τέλος)
- Romans 6:23: GEN_OBJ (ὀψώνια τῆς ἁμαρτίας)
- Romans 6:23: GEN_SUBJ (χάρισμα τοῦ θεοῦ)
*/
