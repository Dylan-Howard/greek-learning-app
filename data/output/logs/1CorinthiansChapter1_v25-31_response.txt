private static List<object> GetChapter1()
{
    // 1 Corinthians 1:25-31
    return new List<object>
    {
        // Verse 25
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
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μωρὸν", Transliteration = "mōron", Gloss = "foolish", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of God"
                        }
                    },
                    Translation = "the foolishness of God"
                },
                new Word { Greek = "σοφώτερον", Transliteration = "sophōteron", Gloss = "wiser", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀνθρώπων", Transliteration = "anthrōpōn", Gloss = "men", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "than men"
                },
                new Word { Greek = "ἐστὶν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀσθενὲς", Transliteration = "asthenes", Gloss = "weak", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of God"
                        }
                    },
                    Translation = "the weakness of God"
                },
                new Word { Greek = "ἰσχυρότερον", Transliteration = "ischyroteron", Gloss = "stronger", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀνθρώπων", Transliteration = "anthrōpōn", Gloss = "men", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "than men"
                }
            },
            Translation = "For the foolishness of God is wiser than men, and the weakness of God is stronger than men."
        },

        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Βλέπετε", Transliteration = "Blepete", Gloss = "consider", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κλῆσιν", Transliteration = "klēsin", Gloss = "calling", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "your calling"
                },
                new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers", GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "πολλοὶ", Transliteration = "polloi", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "σοφοὶ", Transliteration = "sophoi", Gloss = "wise", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "σάρκα", Transliteration = "sarka", Gloss = "flesh", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "according to the flesh"
                        },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "πολλοὶ", Transliteration = "polloi", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "δυνατοί", Transliteration = "dynatoi", Gloss = "mighty", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "πολλοὶ", Transliteration = "polloi", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "εὐγενεῖς", Transliteration = "eugeneis", Gloss = "noble", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "that not many were wise according to the flesh, not many were mighty, not many were noble."
                }
            },
            Translation = "For consider your calling, brothers: not many of you were wise according to worldly standards, not many were powerful, not many were of noble birth."
        },

        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "μωρὰ", Transliteration = "mōra", Gloss = "foolish", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κόσμου", Transliteration = "kosmou", Gloss = "world", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the world"
                        }
                    },
                    Translation = "the foolish things of the world"
                },
                new Word { Greek = "ἐξελέξατο", Transliteration = "exelexato", Gloss = "chose", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεός", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καταισχύνῃ", Transliteration = "kataischynē", Gloss = "he might shame", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "σοφούς", Transliteration = "sophous", Gloss = "wise", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the wise"
                        }
                    },
                    Translation = "to shame the wise"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀσθενῆ", Transliteration = "asthenē", Gloss = "weak", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κόσμου", Transliteration = "kosmou", Gloss = "world", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the world"
                        }
                    },
                    Translation = "the weak things of the world"
                },
                new Word { Greek = "ἐξελέξατο", Transliteration = "exelexato", Gloss = "chose", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεός", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καταισχύνῃ", Transliteration = "kataischynē", Gloss = "he might shame", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἰσχυρά", Transliteration = "ischyra", Gloss = "strong", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the strong"
                        }
                    },
                    Translation = "to shame the strong"
                }
            },
            Translation = "But God chose what is foolish in the world to shame the wise; God chose what is weak in the world to shame the strong."
        },

        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀγενῆ", Transliteration = "agenē", Gloss = "lowly", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κόσμου", Transliteration = "kosmou", Gloss = "world", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the world"
                        }
                    },
                    Translation = "the lowly things of the world"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐξουθενημένα", Transliteration = "exouthenēmena", Gloss = "despised", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "ACC", "N", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "the despised things"
                },
                new Word { Greek = "ἐξελέξατο", Transliteration = "exelexato", Gloss = "chose", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεός", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ὄντα", Transliteration = "onta", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "N", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "the things that are not"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὄντα", Transliteration = "onta", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "N", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "the things that are"
                        },
                        new Word { Greek = "καταργήσῃ", Transliteration = "katargēsē", Gloss = "he might nullify", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "to bring to nothing things that are"
                }
            },
            Translation = "God chose what is low and despised in the world, even things that are not, to bring to nothing things that are,"
        },

        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅπως", Transliteration = "hopōs", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "καυχήσηται", Transliteration = "kauchēsētai", Gloss = "might boast", GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶσα", Transliteration = "pāsa", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "σὰρξ", Transliteration = "sarx", Gloss = "flesh", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "no human being"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐνώπιον", Transliteration = "enōpion", Gloss = "before", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "God"
                        }
                    },
                    Translation = "in the presence of God"
                }
            },
            Translation = "so that no human being might boast in the presence of God."
        },

        // Verse 30
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
                        new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "from him"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" }, PartOfSpeech = "pron" },
                new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "Χριστῷ", Transliteration = "Christō", Gloss = "Christ", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in Christ Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἐγενήθη", Transliteration = "egenēthē", Gloss = "became", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "σοφία", Transliteration = "sophia", Gloss = "wisdom", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "P" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "θεῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "from God"
                        },
                        new Word { Greek = "δικαιοσύνη", Transliteration = "dikaiosynē", Gloss = "righteousness", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "both", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἁγιασμὸς", Transliteration = "hagiasmos", Gloss = "sanctification", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀπολύτρωσις", Transliteration = "apolytrōsis", Gloss = "redemption", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "who became to us wisdom from God, righteousness and sanctification and redemption,"
                }
            },
            Translation = "And because of him you are in Christ Jesus, who became to us wisdom from God, righteousness and sanctification and redemption,"
        },

        // Verse 31
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it has been written", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "as it is written"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καυχώμενος", Transliteration = "kauchōmenos", Gloss = "one boasting", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the one who boasts"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "Lord", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in the Lord"
                },
                new Word { Greek = "καυχάσθω", Transliteration = "kauchāsthō", Gloss = "let him boast", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "so that, as it is written, \"Let the one who boasts, boast in the Lord.\""
        }
    };
}

/*
Constructions identified:
- Comparative Adjectives with Genitive of Comparison: Verse 25 (σοφώτερον τῶν ἀνθρώπων, ἰσχυρότερον τῶν ἀνθρώπων)
- Adjectival Substantives: Verse 27, 28 (τὰ μωρὰ, τὰ ἀσθενῆ, τὰ ἀγενῆ, τὰ ἐξουθενημένα, τὰ μὴ ὄντα)
- Purpose Clauses (ἵνα/ὅπως + Subjunctive): Verse 27, 28, 29, 31
- Relative Clause: Verse 30 (ὃς ἐγενήθη...)
- Polysyndeton (τε καὶ ... καὶ ... καὶ): Verse 30
*/
