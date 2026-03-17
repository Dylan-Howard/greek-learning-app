private static List<object> GetChapter2()
{
    // Ephesians 2:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἔργων", Transliteration = "ergōn", Gloss = "works",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "of works"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μή", Transliteration = "mē", Gloss = "not",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τις", Transliteration = "tis", Gloss = "anyone",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "part" },
                        new Word { Greek = "καυχήσηται", Transliteration = "kauchēsētai", Gloss = "may boast",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "so that no one may boast"
                }
            },
            Translation = "not of works, so that no one may boast."
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐσμεν", Transliteration = "esmen", Gloss = "we are",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ποίημα", Transliteration = "poiēma", Gloss = "workmanship",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "For we are his workmanship"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κτισθέντες", Transliteration = "ktisthentes", Gloss = "created",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
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
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἔργοις", Transliteration = "ergois", Gloss = "works",
                                    GrammarCodes = new List<string> { "N", "DAT", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἀγαθοῖς", Transliteration = "agathois", Gloss = "good",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "N", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "for good works"
                        }
                    },
                    Translation = "created in Christ Jesus for good works"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἷς", Transliteration = "hois", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "DAT", "N", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "προητοίμασεν", Transliteration = "proētoimasen", Gloss = "prepared beforehand",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεός", Transliteration = "theos", Gloss = "God",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "which God prepared beforehand"
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
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "N", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "in them"
                        },
                        new Word { Greek = "περιπατήσωμεν", Transliteration = "peripatēsōmen", Gloss = "we should walk",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that we should walk in them"
                }
            },
            Translation = "For we are his workmanship, created in Christ Jesus for good works, which God prepared beforehand, that we should walk in them."
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Διὸ", Transliteration = "Dio", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "μνημονεύετε", Transliteration = "mnēmoneuete", Gloss = "remember",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ποτὲ", Transliteration = "pote", Gloss = "formerly",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἔθνη", Transliteration = "ethnē", Gloss = "Gentiles",
                                    GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the Gentiles"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "σαρκί", Transliteration = "sarki", Gloss = "flesh",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in the flesh"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the ones",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "λεγόμενοι", Transliteration = "legomenoi", Gloss = "called",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "M", "P" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "ἀκροβυστία", Transliteration = "akrobystia", Gloss = "uncircumcision",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "called uncircumcision"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "λεγομένης", Transliteration = "legomenēs", Gloss = "so-called",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "GEN", "F", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "περιτομῆς", Transliteration = "peritomēs", Gloss = "circumcision",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "by the so-called circumcision"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "σαρκὶ", Transliteration = "sarki", Gloss = "flesh",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "χειροποιήτου", Transliteration = "cheiropoiētou", Gloss = "made by hands",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "made by hands in the flesh"
                        },

                        // Verse 12
                        // (continues verse 11)
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἦτε", Transliteration = "ēte", Gloss = "you were",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "at the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "καιρῷ", Transliteration = "kairō", Gloss = "time",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἐκείνῳ", Transliteration = "ekeinō", Gloss = "that",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "at that time"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "χωρὶς", Transliteration = "chōris", Gloss = "without",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "without Christ"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπηλλοτριωμένοι", Transliteration = "apēllotriōmenoi", Gloss = "alienated",
                                    GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "P" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "from the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "πολιτείας", Transliteration = "politeias", Gloss = "commonwealth",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "Ἰσραὴλ", Transliteration = "Israēl", Gloss = "Israel",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "from the commonwealth of Israel"
                                }
                            },
                            Translation = "alienated from the commonwealth of Israel"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "ξένοι", Transliteration = "xenoi", Gloss = "strangers",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "to the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "διαθηκῶν", Transliteration = "diathēkōn", Gloss = "covenants",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐπαγγελίας", Transliteration = "epangelias", Gloss = "promise",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "and strangers to the covenants of promise"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐλπίδα", Transliteration = "elpida", Gloss = "hope",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                                    GrammarCodes = new List<string> { "ADV" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἔχοντες", Transliteration = "echontes", Gloss = "having",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "having no hope"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "ἄθεοι", Transliteration = "atheoi", Gloss = "without God",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "κόσμῳ", Transliteration = "kosmō", Gloss = "world",
                                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "in the world"
                                }
                            },
                            Translation = "and without God in the world"
                        }
                    },
                    Translation = "Therefore remember that you were at that time without Christ, alienated from the commonwealth of Israel and strangers to the covenants of promise, having no hope and without God in the world."
                }
            },
            Translation = "Therefore remember that at one time you Gentiles in the flesh... were without Christ."
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "νυνὶ", Transliteration = "nyni", Gloss = "now",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
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
                },
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἵ", Transliteration = "hoi", Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ποτε", Transliteration = "pote", Gloss = "once",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὄντες", Transliteration = "ontes", Gloss = "being",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "μακρὰν", Transliteration = "makran", Gloss = "far off",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "who once were far off"
                },
                new Word { Greek = "ἐγενήθητε", Transliteration = "egenēthēte", Gloss = "have been brought",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἐγγὺς", Transliteration = "engys", Gloss = "near",
                    GrammarCodes = new List<string> { "ADJ" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "αἵματι", Transliteration = "haimati", Gloss = "blood",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "by the blood of Christ"
                }
            },
            Translation = "But now in Christ Jesus you who once were far off have been brought near by the blood of Christ."
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Αὐτὸς", Transliteration = "Autos", Gloss = "He himself",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
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
                        new Word { Greek = "εἰρήνη", Transliteration = "eirēnē", Gloss = "peace",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us",
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "our peace"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ποιήσας", Transliteration = "poiēsas", Gloss = "who made",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀμφότερα", Transliteration = "amphotera", Gloss = "both",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἓν", Transliteration = "hen", Gloss = "one",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "who made both one"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "μεσότοιχον", Transliteration = "mesotoichon", Gloss = "dividing wall",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "φραγμοῦ", Transliteration = "phragmou", Gloss = "partition",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the dividing wall of partition"
                        },
                        new Word { Greek = "λύσας", Transliteration = "lysas", Gloss = "having broken down",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "and having broken down the dividing wall of partition"
                },

                // Verse 15
                // (continues verse 14)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἔχθραν", Transliteration = "echthran", Gloss = "hostility",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "σαρκὶ", Transliteration = "sarki", Gloss = "flesh",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "in his flesh"
                        }
                    },
                    Translation = "the hostility in his flesh"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "νόμον", Transliteration = "nomon", Gloss = "law",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐντολῶν", Transliteration = "entolōn", Gloss = "commandments",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "P" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "δόγμασιν", Transliteration = "dogmasin", Gloss = "ordinances",
                                            GrammarCodes = new List<string> { "N", "DAT", "N", "P" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "in ordinances"
                                }
                            },
                            Translation = "the law of commandments in ordinances"
                        },
                        new Word { Greek = "καταργήσας", Transliteration = "katargēsas", Gloss = "having abolished",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having abolished the law of commandments in ordinances"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δύο", Transliteration = "dyo", Gloss = "two",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "κτίσῃ", Transliteration = "ktisē", Gloss = "he might create",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "himself",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                                    PartOfSpeech = "f" }
                            },
                            Translation = "in himself"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἕνα", Transliteration = "hena", Gloss = "one",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "καινὸν", Transliteration = "kainon", Gloss = "new",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἄνθρωπον", Transliteration = "anthrōpon", Gloss = "man",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "into one new man"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ποιῶν", Transliteration = "poiōn", Gloss = "making",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "εἰρήνην", Transliteration = "eirēnēn", Gloss = "peace",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "making peace"
                        },

                        // Verse 16
                        // (continues verse 14)
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἀποκαταλλάξῃ", Transliteration = "apokatallaxē", Gloss = "he might reconcile",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀμφοτέρους", Transliteration = "amphoterous", Gloss = "both",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἑνὶ", Transliteration = "heni", Gloss = "one",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "σώματι", Transliteration = "sōmati", Gloss = "body",
                                    GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in one body"
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
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "σταυροῦ", Transliteration = "staurou", Gloss = "cross",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "through the cross"
                        }
                    },
                    Translation = "so that he might create in himself the two into one new man, making peace, and might reconcile both in one body to God through the cross"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀποκτείνας", Transliteration = "apokteinas", Gloss = "having killed",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἔχθραν", Transliteration = "echthran", Gloss = "hostility",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "it",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "in it"
                        }
                    },
                    Translation = "having killed the hostility in it"
                }
            },
            Translation = "For he himself is our peace, who made the both one and having broken down the dividing wall of partition... so that he might create in himself one new man... and might reconcile both in one body to God."
        }
    };
}

/*
Constructions identified:
- PURPOSE_CLAUSE (ἵνα μή τις καυχήσηται) - Verse 9
- REL_CLAUSE (οἷς προητοίμασεν ὁ θεός) - Verse 10
- PURPOSE_CLAUSE (ἵνα ἐν αὐτοῖς περιπατήσωμεν) - Verse 10
- APPOS (τὰ ἔθνη ἐν σαρκί modifying ὑμεῖς) - Verse 11
- PTCP (λεγόμενοι / λεγομένης used as adjectival modifiers) - Verse 11
- PTCP (ἀπηλλοτριωμένοι, ἔχοντες adjectival modifiers of ἦτε) - Verse 12
- REL_CLAUSE (οἵ ποτε ὄντες μακρὰν) - Verse 13
- PTCP (ποιήσας, λύσας substantival or adjectival) - Verse 14
- PTCP (καταργήσας, ποιῶν, ἀποκτείνας) - Verse 15-16
- PURPOSE_CLAUSE (ἵνα... κτίσῃ... καὶ ἀποκαταλλάξῃ) - Verse 15-16
*/
