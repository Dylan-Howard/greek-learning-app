private static List<object> GetChapter6()
{
    // Romans 6:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰδότες", Transliteration = "eidotes", Gloss = "knowing", 
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "M", "P" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Χριστὸς", Transliteration = "Christos", Gloss = "Christ", 
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, 
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἐγερθεὶς", Transliteration = "egertheis", Gloss = "having been raised", 
                                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, 
                                    PartOfSpeech = "v" }
                            },
                            Translation = "Christ having been raised"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", 
                                    GrammarCodes = new List<string> { "PREP" }, 
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "νεκρῶν", Transliteration = "nekrōn", Gloss = "the dead", 
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, 
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "from the dead"
                        },
                        new Word { Greek = "οὐκέτι", Transliteration = "ouketi", Gloss = "no longer", 
                            GrammarCodes = new List<string> { "ADV" }, 
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἀποθνῄσκει", Transliteration = "apothnēskei", Gloss = "he dies", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "that Christ, having been raised from the dead, no longer dies"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θάνατος", Transliteration = "thanatos", Gloss = "death", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, 
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "over him", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "οὐκέτι", Transliteration = "ouketi", Gloss = "no longer", 
                            GrammarCodes = new List<string> { "ADV" }, 
                            PartOfSpeech = "adj" },
                        new Word { Greek = "κυριεύει", Transliteration = "kyrieuei", Gloss = "lords it", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "death no longer lords it over him"
                }
            },
            Translation = "Knowing that Christ, having been raised from the dead, no longer dies; death no longer lords it over him."
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "the [death] which", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, 
                    PartOfSpeech = "pron" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀπέθανεν", Transliteration = "apethanen", Gloss = "he died", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "to the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἁμαρτίᾳ", Transliteration = "hamartia", Gloss = "sin", 
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "to sin"
                },
                new Word { Greek = "ἀπέθανεν", Transliteration = "apethanen", Gloss = "he died", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "ἐφάπαξ", Transliteration = "ephapax", Gloss = "once for all", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "adj" }
            },
            Translation = "For the death he died, he died to sin once for all"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "the [life] which", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, 
                    PartOfSpeech = "pron" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ζῇ", Transliteration = "zē", Gloss = "he lives", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "ζῇ", Transliteration = "zē", Gloss = "he lives", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", 
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "to God"
                }
            },
            Translation = "but the life he lives, he lives to God"
        },
        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "so", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "λογίζεσθε", Transliteration = "logizesthe", Gloss = "consider", 
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "ἑαυτοὺς", Transliteration = "heautous", Gloss = "yourselves", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, 
                    PartOfSpeech = "f" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, 
                            PartOfSpeech = "v" },
                        new Word { Greek = "νεκροὺς", Transliteration = "nekrous", Gloss = "dead", 
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, 
                            PartOfSpeech = "adj" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed", 
                            GrammarCodes = new List<string> { "PART" }, 
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "to the", 
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἁμαρτίᾳ", Transliteration = "hamartia", Gloss = "sin", 
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to sin"
                        }
                    },
                    Translation = "to be dead indeed to sin"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ζῶντας", Transliteration = "zōntas", Gloss = "living", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" }, 
                            PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", 
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
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                                    GrammarCodes = new List<string> { "PREP" }, 
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "Χριστῷ", Transliteration = "Christō", Gloss = "Christ", 
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, 
                                    PartOfSpeech = "n" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", 
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in Christ Jesus"
                        }
                    },
                    Translation = "but living to God in Christ Jesus"
                }
            },
            Translation = "So you also consider yourselves to be dead indeed to sin, but living to God in Christ Jesus."
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Μὴ", Transliteration = "Mē", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "βασιλευέτω", Transliteration = "basileuetō", Gloss = "let reign", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἁμαρτία", Transliteration = "hamartia", Gloss = "sin", 
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "sin"
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
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θνητῷ", Transliteration = "thnētō", Gloss = "mortal", 
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, 
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "your", 
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, 
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "σώματι", Transliteration = "sōmati", Gloss = "body", 
                                    GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "your mortal body"
                        }
                    },
                    Translation = "in your mortal body"
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
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὑπακούειν", Transliteration = "hypakouein", Gloss = "obey", 
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, 
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "DAT", "F", "P" }, 
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἐπιθυμίαις", Transliteration = "epithymiais", Gloss = "desires", 
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, 
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of it", 
                                            GrammarCodes = new List<string> { "PRON", "GEN", "N", "S" }, 
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "its desires"
                                }
                            },
                            Translation = "to obey its desires"
                        }
                    },
                    Translation = "to obey its desires"
                }
            },
            Translation = "Therefore do not let sin reign in your mortal body, that you should obey its desires."
        },
        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μηδὲ", Transliteration = "mēde", Gloss = "neither", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "παριστάνετε", Transliteration = "paristanete", Gloss = "present", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, 
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
                        new Word { Greek = "ὅπλα", Transliteration = "hopla", Gloss = "instruments", 
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, 
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἀδικίας", Transliteration = "adikias", Gloss = "of unrighteousness", 
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "instruments of unrighteousness"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "to the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἁμαρτίᾳ", Transliteration = "hamartia", Gloss = "sin", 
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "to sin"
                }
            },
            Translation = "Neither present your members as instruments of unrighteousness to sin,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "παραστήσατε", Transliteration = "parastēsate", Gloss = "present", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "ἑαυτοὺς", Transliteration = "heautous", Gloss = "yourselves", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, 
                    PartOfSpeech = "f" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", 
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
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡσεὶ", Transliteration = "hōsei", Gloss = "as", 
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
                                new Word { Greek = "νεκρῶν", Transliteration = "nekrōn", Gloss = "the dead", 
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, 
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "from the dead"
                        },
                        new Word { Greek = "ζῶντας", Transliteration = "zōntas", Gloss = "living", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "as those living from the dead"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
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
                        new Word { Greek = "ὅπλα", Transliteration = "hopla", Gloss = "instruments", 
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, 
                            PartOfSpeech = "n" },
                        new Word { Greek = "δικαιοσύνης", Transliteration = "dikaiosynēs", Gloss = "of righteousness", 
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "instruments of righteousness"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", 
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "to God"
                }
            },
            Translation = "but present yourselves to God as those living from the dead, and your members as instruments of righteousness to God."
        },
        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἁμαρτία", Transliteration = "hamartia", Gloss = "sin", 
                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, 
                    PartOfSpeech = "n" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "over you", 
                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "κυριεύσει", Transliteration = "kyrieusei", Gloss = "will lord", 
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "For sin will not lord it over you;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "you are", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "under", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "νόμον", Transliteration = "nomon", Gloss = "law", 
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "under law"
                },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "under", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "χάριν", Transliteration = "charin", Gloss = "grace", 
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "under grace"
                }
            },
            Translation = "for you are not under law but under grace."
        },
        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τί", Transliteration = "Ti", Gloss = "What", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, 
                    PartOfSpeech = "interj" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἁμαρτήσωμεν", Transliteration = "hamartēsōmen", Gloss = "shall we sin", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", 
                            GrammarCodes = new List<string> { "PART" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἐσμὲν", Transliteration = "esmen", Gloss = "we are", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, 
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "under", 
                                    GrammarCodes = new List<string> { "PREP" }, 
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "νόμον", Transliteration = "nomon", Gloss = "law", 
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "under law"
                        },
                        new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "under", 
                                    GrammarCodes = new List<string> { "PREP" }, 
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "χάριν", Transliteration = "charin", Gloss = "grace", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "under grace"
                        }
                    },
                    Translation = "because we are not under law but under grace?"
                }
            },
            Translation = "What then? Shall we sin because we are not under law but under grace?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "γένοιτο", Transliteration = "genoito", Gloss = "let it be", 
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "OPT", "3P", "S" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "By no means!"
        },
        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "οἴδατε", Transliteration = "oidate", Gloss = "do you know", 
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ᾧ", Transliteration = "hō", Gloss = "to whom", 
                                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, 
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "παριστάνετε", Transliteration = "paristanete", Gloss = "you present", 
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, 
                                    PartOfSpeech = "v" },
                                new Word { Greek = "ἑαυτοὺς", Transliteration = "heautous", Gloss = "yourselves", 
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, 
                                    PartOfSpeech = "f" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "δούλους", Transliteration = "doulous", Gloss = "slaves", 
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, 
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "as slaves"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", 
                                            GrammarCodes = new List<string> { "PREP" }, 
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "ὑπακοήν", Transliteration = "hypakoēn", Gloss = "obedience", 
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, 
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "for obedience"
                                }
                            },
                            Translation = "to whom you present yourselves as slaves for obedience"
                        },
                        new Word { Greek = "δοῦλοί", Transliteration = "douloi", Gloss = "slaves", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, 
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "you are", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, 
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ᾧ", Transliteration = "hō", Gloss = "whom", 
                                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, 
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "ὑπακούετε", Transliteration = "hypakouete", Gloss = "you obey", 
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, 
                                    PartOfSpeech = "v" }
                            },
                            Translation = "whom you obey"
                        },
                        new Word { Greek = "ἤτοι", Transliteration = "ētoi", Gloss = "whether", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἁμαρτίας", Transliteration = "hamartias", Gloss = "of sin", 
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of sin"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", 
                                    GrammarCodes = new List<string> { "PREP" }, 
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "θάνατον", Transliteration = "thanaton", Gloss = "death", 
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to death"
                        },
                        new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπακοῆς", Transliteration = "hypakoēs", Gloss = "of obedience", 
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of obedience"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", 
                                    GrammarCodes = new List<string> { "PREP" }, 
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "δικαιοσύνην", Transliteration = "dikaiosynēn", Gloss = "righteousness", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to righteousness"
                        }
                    },
                    Translation = "that to whom you present yourselves as slaves for obedience, you are slaves of the one whom you obey, whether of sin leading to death, or of obedience leading to righteousness?"
                }
            },
            Translation = "Do you not know that if you present yourselves to anyone as obedient slaves, you are slaves of the one whom you obey, either of sin, which leads to death, or of obedience, which leads to righteousness?"
        }
    };
}
// Constructions Identified:
// Verse 10: PRED_ADJ / ADV usage (ἐφάπαξ)
// Verse 11: INF_PHRASE (εἶναι νεκροὺς...)
// Verse 13: NOUN_PHRASE complements (ὅπλα ἀδικίας / δικαιοσύνης)
// Verse 16: REL_CLAUSE (ᾧ παριστάνετε...)
