private static List<object> GetChapter3()
{
    // 1 John 3:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἴδετε", Transliteration = "Idete", Gloss = "See",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ποταπὴν", Transliteration = "potapēn", Gloss = "what kind of",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἀγάπην", Transliteration = "agapēn", Gloss = "love",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "what kind of love"
                },
                new Word { Greek = "δέδωκεν", Transliteration = "dedōken", Gloss = "has given",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πατήρ", Transliteration = "patēr", Gloss = "Father",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the Father"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τέκνα", Transliteration = "tekna", Gloss = "children",
                                    GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "children of God"
                        },
                        new Word { Greek = "κληθῶμεν", Transliteration = "klēthōmen", Gloss = "we should be called",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "1P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that we should be called children of God"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐσμέν", Transliteration = "esmen", Gloss = "we are",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "See what kind of love the Father has given to us, that we should be called children of God; and so we are."
        },
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
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "Because of this"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κόσμος", Transliteration = "kosmos", Gloss = "world",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the world"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "part" },
                new Word { Greek = "γινώσκει", Transliteration = "ginōskei", Gloss = "knows",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "pron" },
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
                            PartOfSpeech = "part" },
                        new Word { Greek = "ἔγνω", Transliteration = "egnō", Gloss = "it knew",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "Him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "because it did not know Him"
                }
            },
            Translation = "Because of this the world does not know us, because it did not know Him."
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀγαπητοὶ", Transliteration = "agapētoi", Gloss = "Beloved",
                            GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "Beloved"
                },
                new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τέκνα", Transliteration = "tekna", Gloss = "children",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "children of God"
                },
                new Word { Greek = "ἐσμεν", Transliteration = "esmen", Gloss = "we are",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "Beloved, now we are children of God,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὔπω", Transliteration = "oupō", Gloss = "not yet",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "ἐφανερώθη", Transliteration = "ephanerōthē", Gloss = "it was revealed",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti", Gloss = "what",
                            GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἐσόμεθα", Transliteration = "esometha", Gloss = "we will be",
                            GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "1P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "what we will be"
                }
            },
            Translation = "and it has not yet been revealed what we will be."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οἴδαμεν", Transliteration = "oidamen", Gloss = "we know",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "COND_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "φανερωθῇ", Transliteration = "phanerōthē", Gloss = "He is revealed",
                                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "if He is revealed"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅμοιοι", Transliteration = "homoioi", Gloss = "like",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "Him",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "like Him"
                        },
                        new Word { Greek = "ἐσόμεθα", Transliteration = "esometha", Gloss = "we will be",
                            GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "1P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that if He is revealed, we will be like Him,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ὀψόμεθα", Transliteration = "opsometha", Gloss = "we will see",
                            GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "1P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "Him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "because we will see Him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθώς", Transliteration = "kathōs", Gloss = "just as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "He is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "just as He is."
                }
            },
            Translation = "We know that if He is revealed, we will be like Him, because we will see Him just as He is."
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶς", Transliteration = "pas", Gloss = "everyone",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "who",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "has",
                                    GrammarCodes = new List<string> { "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἐλπίδα", Transliteration = "elpida", Gloss = "hope",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "ταύτην", Transliteration = "tautēn", Gloss = "this",
                                            GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                                            PartOfSpeech = "pron" }
                                    },
                                    Translation = "this hope"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "Him",
                                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                                            PartOfSpeech = "pron" }
                                    },
                                    Translation = "in Him"
                                }
                            },
                            Translation = "who has this hope in Him"
                        }
                    },
                    Translation = "everyone who has this hope in Him"
                },
                new Word { Greek = "ἁγνίζει", Transliteration = "hagnizei", Gloss = "purifies",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἑαυτόν", Transliteration = "heauton", Gloss = "himself",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "just as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐκεῖνος", Transliteration = "ekeinos", Gloss = "He",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἁγνός", Transliteration = "hagnos", Gloss = "pure",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "just as He is pure"
                }
            },
            Translation = "And everyone who has this hope in Him purifies himself, just as He is pure."
        },

        // Verse 4
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
                        new Word { Greek = "Πᾶς", Transliteration = "Pas", Gloss = "Everyone",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "who",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ποιῶν", Transliteration = "poiōn", Gloss = "does",
                                    GrammarCodes = new List<string> { "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἁμαρτίαν", Transliteration = "hamartian", Gloss = "sin",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "sin"
                                }
                            },
                            Translation = "who does sin"
                        }
                    },
                    Translation = "Everyone who does sin"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
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
                },
                new Word { Greek = "ποιεῖ", Transliteration = "poiei", Gloss = "does",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "Everyone who does sin also does lawlessness;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
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
                new Word { Greek = "ἐστὶν", Transliteration = "estin", Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀνομία", Transliteration = "anomia", Gloss = "lawlessness",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "lawlessness"
                }
            },
            Translation = "and sin is lawlessness."
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "οἴδατε", Transliteration = "oidate", Gloss = "you know",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐκεῖνος", Transliteration = "ekeinos", Gloss = "He",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἐφανερώθη", Transliteration = "ephanerōthē", Gloss = "was revealed",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that He was revealed"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἁμαρτίας", Transliteration = "hamartias", Gloss = "sins",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "sins"
                        },
                        new Word { Greek = "ἄρῃ", Transliteration = "arē", Gloss = "He might take away",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "in order that He might take away sins"
                }
            },
            Translation = "And you know that He was revealed in order that He might take away sins,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
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
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "Him",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "in Him"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "part" },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "and in Him there is no sin."
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
                        new Word { Greek = "πᾶς", Transliteration = "pas", Gloss = "everyone",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "who",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "Him",
                                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                                            PartOfSpeech = "pron" }
                                    },
                                    Translation = "in Him"
                                },
                                new Word { Greek = "μένων", Transliteration = "menōn", Gloss = "remains",
                                    GrammarCodes = new List<string> { "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "who remains in Him"
                        }
                    },
                    Translation = "everyone who remains in Him"
                },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "part" },
                new Word { Greek = "ἁμαρτάνει", Transliteration = "hamartanei", Gloss = "sins",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "Everyone who remains in Him does not sin;"
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
                        new Word { Greek = "πᾶς", Transliteration = "pas", Gloss = "everyone",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "who",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἁμαρτάνων", Transliteration = "hamartanōn", Gloss = "sins",
                                    GrammarCodes = new List<string> { "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "who sins"
                        }
                    },
                    Translation = "everyone who sins"
                },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "has not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "part" },
                new Word { Greek = "ἑώρακεν", Transliteration = "heōraken", Gloss = "seen",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "Him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "οὐδὲ", Transliteration = "oude", Gloss = "nor",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἔγνωκεν", Transliteration = "egnōken", Gloss = "known",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "Him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "pron" }
            },
            Translation = "everyone who sins has not seen Him nor known Him."
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Παιδία", Transliteration = "Paidia", Gloss = "Little children",
                            GrammarCodes = new List<string> { "N", "VOC", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Little children"
                },
                new Word { Greek = "μηδεὶς", Transliteration = "mēdeis", Gloss = "no one",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "πλανάτω", Transliteration = "planatō", Gloss = "let lead astray",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "pron" }
            },
            Translation = "Little children, let no one lead you astray;"
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ποιῶν", Transliteration = "poiōn", Gloss = "doing",
                                    GrammarCodes = new List<string> { "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "δικαιοσύνην", Transliteration = "dikaiosynēn", Gloss = "righteousness",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "righteousness"
                                }
                            },
                            Translation = "doing righteousness"
                        }
                    },
                    Translation = "the one doing righteousness"
                },
                new Word { Greek = "δίκαιός", Transliteration = "dikaios", Gloss = "righteous",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "just as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐκεῖνος", Transliteration = "ekeinos", Gloss = "He",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "δίκαιός", Transliteration = "dikaios", Gloss = "righteous",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "just as He is righteous"
                }
            },
            Translation = "the one doing righteousness is righteous, just as He is righteous."
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ποιῶν", Transliteration = "poiōn", Gloss = "doing",
                                    GrammarCodes = new List<string> { "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἁμαρτίαν", Transliteration = "hamartian", Gloss = "sin",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "sin"
                                }
                            },
                            Translation = "doing sin"
                        }
                    },
                    Translation = "the one doing sin"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "διαβόλου", Transliteration = "diabolou", Gloss = "devil",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "of the devil"
                },
                new Word { Greek = "ἐστίν", Transliteration = "estin", Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπ᾽", Transliteration = "ap'", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἀρχῆς", Transliteration = "archēs", Gloss = "beginning",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "from the beginning"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "διάβολος", Transliteration = "diabolos", Gloss = "devil",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "the devil"
                        },
                        new Word { Greek = "ἁμαρτάνει", Transliteration = "hamartanei", Gloss = "sins",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "because the devil has been sinning from the beginning"
                }
            },
            Translation = "The one doing sin is of the devil, because the devil has been sinning from the beginning."
        },
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
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this purpose",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "For this purpose"
                },
                new Word { Greek = "ἐφανερώθη", Transliteration = "ephanerōthē", Gloss = "was revealed",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "υἱὸς", Transliteration = "hyios", Gloss = "Son",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
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
                    Translation = "the Son of God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "λύσῃ", Transliteration = "lysē", Gloss = "He might destroy",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἔργα", Transliteration = "erga", Gloss = "works",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "διαβόλου", Transliteration = "diabolou", Gloss = "devil",
                                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" },
                                            PartOfSpeech = "adj" }
                                    },
                                    Translation = "of the devil"
                                }
                            },
                            Translation = "the works of the devil"
                        }
                    },
                    Translation = "in order that He might destroy the works of the devil"
                }
            },
            Translation = "For this purpose the Son of God was revealed, in order that He might destroy the works of the devil."
        }
    };
}

/*
Constructions identified:
- GEN_DESC: "τέκνα θεοῦ" (v1, v2), "τοῦ θεοῦ" (v8), "τοῦ διαβόλου" (v8)
- VOC: "ἀγαπητοὶ" (v2), "Παιδία" (v7)
- PTCP (Substantive Participles): "ὁ ἔχων" (v3), "ὁ ποιῶν" (v4, v7, v8), "ὁ μένων" (v6), "ὁ ἁμαρτάνων" (v6)
*/
