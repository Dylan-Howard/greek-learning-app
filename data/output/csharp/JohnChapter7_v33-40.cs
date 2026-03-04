private static List<object> GetChapter7()
{
    // John 7:33-40
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Εἶπεν", Transliteration = "Eipen", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔτι", Transliteration = "eti", Gloss = "still",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adverb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "χρόνον", Transliteration = "chronon", Gloss = "time",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "μικρὸν", Transliteration = "mikron", Gloss = "little",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adjective" }
                            },
                            Translation = "a little time"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μεθ᾽", Transliteration = "meth’", Gloss = "with",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "with you"
                        },
                        new Word { Greek = "εἰμι", Transliteration = "eimi", Gloss = "I am",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "For a little while longer I am with you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "ὑπάγω", Transliteration = "hypagō", Gloss = "I go",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the [one]",
                                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                            PartOfSpeech = "article" },
                                        new Word { Greek = "πέμψαντά", Transliteration = "pempsanta", Gloss = "having sent",
                                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "M", "S" },
                                            PartOfSpeech = "verb" },
                                        new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                                            GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                                            PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "the [one] who sent me"
                                }
                            },
                            Translation = "to him who sent me"
                        }
                    },
                    Translation = "and I am going to him who sent me"
                }
            },
            Translation = "Jesus therefore said, 'For a little while longer I am with you, and then I am going to him who sent me.'"
        },
        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ζητήσετέ", Transliteration = "zētēsete", Gloss = "you will seek",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "particle" },
                new Word { Greek = "εὑρήσετέ", Transliteration = "heurēsete", Gloss = "you will find",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                    PartOfSpeech = "pronoun" }
            },
            Translation = "You will seek me and will not find me"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "where",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "εἰμὶ", Transliteration = "eimi", Gloss = "am",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I",
                            GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "where I am"
                },
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "particle" },
                new Word { Greek = "δύνασθε", Transliteration = "dynasthe", Gloss = "are able",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "2P", "P" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλθεῖν", Transliteration = "elthein", Gloss = "to come",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "to come"
                }
            },
            Translation = "and where I am, you cannot come"
        },
        // Verse 35
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπον", Transliteration = "eipon", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "Ἰουδαῖοι", Transliteration = "Ioudaioi", Gloss = "Jews",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adjective" }
                    },
                    Translation = "the Jews"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "ἑαυτούς", Transliteration = "heautous", Gloss = "themselves",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "to themselves"
                }
            },
            Translation = "The Jews therefore said to themselves"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ποῦ", Transliteration = "pou", Gloss = "Where",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adverb" },
                new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this [man]",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "μέλλει", Transliteration = "mellei", Gloss = "is about",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πορεύεσθαι", Transliteration = "poreuesthai", Gloss = "to go",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "INF" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "to go"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis", Gloss = "we",
                            GrammarCodes = new List<string> { "PRON", "NOM", "1P", "P" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "particle" },
                        new Word { Greek = "εὑρήσομεν", Transliteration = "heurēsomen", Gloss = "will find",
                            GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "P" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "that we will not find him?"
                }
            },
            Translation = "Where is this man about to go that we will not find him?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "particle" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "διασπορὰν", Transliteration = "diasporan", Gloss = "dispersion",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                            PartOfSpeech = "article" },
                                        new Word { Greek = "Ἑλλήνων", Transliteration = "Hellēnōn", Gloss = "Greeks",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                            PartOfSpeech = "noun" }
                                    },
                                    Translation = "of the Greeks"
                                }
                            },
                            Translation = "the dispersion of the Greeks"
                        }
                    },
                    Translation = "to the dispersion of the Greeks"
                },
                new Word { Greek = "μέλλει", Transliteration = "mellei", Gloss = "is he about",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πορεύεσθαι", Transliteration = "poreuesthai", Gloss = "to go",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "INF" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "to go"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διδάσκειν", Transliteration = "didaskein", Gloss = "to teach",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "Ἕλληνας", Transliteration = "Hellēnas", Gloss = "Greeks",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "noun" }
                                },
                                Translation = "the Greeks"
                        }
                    },
                    Translation = "to teach the Greeks"
                }
            },
            Translation = "He is not about to go to the dispersion of the Greeks and teach the Greeks, is he?"
        },
        // Verse 36
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τίς", Transliteration = "tis", Gloss = "What",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "λόγος", Transliteration = "logos", Gloss = "word",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "this statement"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he said",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "which he said"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ζητήσετέ", Transliteration = "zētēsete", Gloss = "You will seek",
                            GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                            GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "particle" },
                        new Word { Greek = "εὑρήσετέ", Transliteration = "heurēsete", Gloss = "you will find",
                            GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                            GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "where",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conjunction" },
                                new Word { Greek = "εἰμὶ", Transliteration = "eimi", Gloss = "am",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                                    PartOfSpeech = "verb" },
                                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "where I am"
                        },
                        new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "particle" },
                        new Word { Greek = "δύνασθε", Transliteration = "dynasthe", Gloss = "are able",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "2P", "P" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐλθεῖν", Transliteration = "elthein", Gloss = "to come",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                                    PartOfSpeech = "verb" }
                            },
                            Translation = "to come"
                        }
                    },
                    Translation = "'You will seek me and will not find me; and where I am, you cannot come'?"
                }
            },
            Translation = "What is this statement which he said, 'You will seek me and will not find me; and where I am, you cannot come'?"
        },
        // Verse 37
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
                        new Word { Greek = "Ἐν", Transliteration = "En", Gloss = "On",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "ἐσχάτῃ", Transliteration = "eschatē", Gloss = "last",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                                    PartOfSpeech = "adjective" },
                                new Word { Greek = "ἡμέρᾳ", Transliteration = "hēmera", Gloss = "day",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "the last day"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "μεγάλῃ", Transliteration = "megalē", Gloss = "great [day]",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                                    PartOfSpeech = "adjective" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "article" },
                                        new Word { Greek = "ἑορτῆς", Transliteration = "heortēs", Gloss = "feast",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "noun" }
                                    },
                                    Translation = "of the feast"
                                }
                            },
                            Translation = "the great day of the feast"
                        }
                    },
                    Translation = "Now on the last day, the great day of the feast"
                },
                new Word { Greek = "εἱστήκει", Transliteration = "heistēkei", Gloss = "stood",
                    GrammarCodes = new List<string> { "V", "PLPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "Jesus"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "ἔκραξεν", Transliteration = "ekraxen", Gloss = "cried out",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐάν", Transliteration = "ean", Gloss = "If",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "τις", Transliteration = "tis", Gloss = "anyone",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "διψᾷ", Transliteration = "dipsa", Gloss = "is thirsty",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "If anyone is thirsty"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐρχέσθω", Transliteration = "erchesthō", Gloss = "let him come",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "IMP", "3P", "S" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρός", Transliteration = "pros", Gloss = "to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "to me"
                        }
                    },
                    Translation = "let him come to me"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "πινέτω", Transliteration = "pinetō", Gloss = "let him drink",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" },
                    PartOfSpeech = "verb" }
            },
            Translation = "Now on the last day, the great day of the feast, Jesus stood and cried out, saying, 'If anyone is thirsty, let him come to me and drink.'"
        },
        // Verse 38
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
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "The [one]",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "πιστεύων", Transliteration = "pisteuōn", Gloss = "believing",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "preposition" },
                                        new Word { Greek = "ἐμέ", Transliteration = "eme", Gloss = "me",
                                            GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                                            PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "in me"
                                }
                            },
                            Translation = "the one believing in me"
                        }
                    },
                    Translation = "The one who believes in me"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "γραφή", Transliteration = "graphē", Gloss = "Scripture",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "the Scripture"
                        }
                    },
                    Translation = "as the Scripture said"
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
                                new Word { Greek = "ποταμοὶ", Transliteration = "potamoi", Gloss = "rivers",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                                    PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὕδατος", Transliteration = "hydatos", Gloss = "of water",
                                            GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                                            PartOfSpeech = "noun" },
                                        new Word { Greek = "ζῶντος", Transliteration = "zōntos", Gloss = "living",
                                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "N", "S" },
                                            PartOfSpeech = "verb" }
                                    },
                                    Translation = "of living water"
                                }
                            },
                            Translation = "rivers of living water"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "article" },
                                        new Word { Greek = "κοιλίας", Transliteration = "koilias", Gloss = "innermost being",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "noun" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                            PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "his innermost being"
                                }
                            },
                            Translation = "from his innermost being"
                        },
                        new Word { Greek = "ῥεύσουσιν", Transliteration = "rheusousin", Gloss = "will flow",
                            GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "'Rivers of living water will flow from his innermost being.'"
                }
            },
            Translation = "The one who believes in me, as the Scripture said, 'Rivers of living water will flow from his innermost being.'"
        },
        // Verse 39
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "πνεύματος", Transliteration = "pneumatos", Gloss = "Spirit",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "the Spirit"
                        }
                    },
                    Translation = "about the Spirit"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἔμελλον", Transliteration = "emellon", Gloss = "they were about",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "λαμβάνειν", Transliteration = "lambanein", Gloss = "to receive",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                                    PartOfSpeech = "verb" }
                            },
                            Translation = "to receive"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the [ones]",
                                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                            PartOfSpeech = "article" },
                                        new Word { Greek = "πιστεύσαντες", Transliteration = "pisteusantes", Gloss = "having believed",
                                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                                            PartOfSpeech = "verb" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "in",
                                                    GrammarCodes = new List<string> { "PREP" },
                                                    PartOfSpeech = "preposition" },
                                                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him",
                                                    Gram
