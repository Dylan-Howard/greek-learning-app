private static List<object> GetChapter27()
{
    // Acts 27:25-32
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "διὸ", Transliteration = "dio", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εὐθυμεῖτε", Transliteration = "euthymeite", Gloss = "keep up your courage",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄνδρες", Transliteration = "andres", Gloss = "men",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "men"
                }
            },
            Translation = "Therefore keep up your courage, men"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πιστεύω", Transliteration = "pisteuō", Gloss = "I believe",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
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
                    Translation = "God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "so",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "ἔσται", Transliteration = "estai", Gloss = "it will be",
                            GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that it will be so"
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
                                new Word { Greek = "καθ᾽", Transliteration = "kath'", Gloss = "according to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "which",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "τρόπον", Transliteration = "tropon", Gloss = "manner",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "just as"
                        },
                        new Word { Greek = "λελάληταί", Transliteration = "lelālētai", Gloss = "it has been told",
                            GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me",
                            GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "just as it has been told to me"
                }
            },
            Translation = "for I believe God that it will be so, just as it has been told to me."
        },

        // Verse 26
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
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "on",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "νῆσον", Transliteration = "nēson", Gloss = "island",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τινα", Transliteration = "tina", Gloss = "some",
                            GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "on some island"
                },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "δεῖ", Transliteration = "dei", Gloss = "it is necessary",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us",
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἐκπεσεῖν", Transliteration = "ekpesein", Gloss = "to run aground",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                    PartOfSpeech = "v" }
            },
            Translation = "But we must run aground on some island."
        },

        // Verse 27
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
                        new Word { Greek = "Ὡς", Transliteration = "Hōs", Gloss = "When",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τεσσαρεσκαιδεκάτη", Transliteration = "tessareskaidekatē", Gloss = "fourteenth",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "νὺξ", Transliteration = "nyx", Gloss = "night",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the fourteenth night"
                        },
                        new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "had come",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "When the fourteenth night had come"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διαφερομένων", Transliteration = "diapheromenōn", Gloss = "being driven",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "GEN", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "we",
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                            PartOfSpeech = "pron" },
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
                                new Word { Greek = "Ἀδρίᾳ", Transliteration = "Adriā", Gloss = "Adriatic Sea",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in the Adriatic Sea"
                        }
                    },
                    Translation = "as we were being driven across the Adriatic Sea"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "about",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "μέσον", Transliteration = "meson", Gloss = "middle",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "νυκτὸς", Transliteration = "nyktos", Gloss = "night",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the night"
                        }
                    },
                    Translation = "about midnight"
                },
                new Word { Greek = "ὑπενόουν", Transliteration = "hypenooun", Gloss = "suspected",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ναῦται", Transliteration = "nautai", Gloss = "sailors",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the sailors"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προσάγειν", Transliteration = "prosagein", Gloss = "approaching",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "τινά", Transliteration = "tina", Gloss = "some",
                            GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them",
                            GrammarCodes = new List<string> { "PRON", "DAT", "3P", "M", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "χώραν", Transliteration = "chōran", Gloss = "land",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "that they were approaching some land"
                }
            },
            Translation = "When the fourteenth night had come, as we were being driven across the Adriatic Sea, about midnight the sailors suspected that they were approaching some land."
        },

        // Verse 28
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
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βολίσαντες", Transliteration = "bolisantes", Gloss = "taking a sounding",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "taking a sounding"
                },
                new Word { Greek = "εὗρον", Transliteration = "heyron", Gloss = "they found",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὀργυιὰς", Transliteration = "orgyias", Gloss = "fathoms",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "εἴκοσι", Transliteration = "eikosi", Gloss = "twenty",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "twenty fathoms"
                }
            },
            Translation = "And taking a sounding, they found twenty fathoms"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "βραχὺ", Transliteration = "brachy", Gloss = "a little",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διαστήσαντες", Transliteration = "diastēsantes", Gloss = "having gone a little further",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having gone a little further"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "πάλιν", Transliteration = "palin", Gloss = "again",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βολίσαντες", Transliteration = "bolisantes", Gloss = "taking a sounding",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "taking a sounding again"
                },
                new Word { Greek = "εὗρον", Transliteration = "heyron", Gloss = "they found",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὀργυιὰς", Transliteration = "orgyias", Gloss = "fathoms",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "δεκαπέντε", Transliteration = "dekapente", Gloss = "fifteen",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "fifteen fathoms"
                }
            },
            Translation = "and after a little interval, taking a sounding again, they found fifteen fathoms"
        },

        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "φοβούμενοί", Transliteration = "phoboumenoi", Gloss = "fearing",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "τε", Transliteration = "te", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μή", Transliteration = "mē", Gloss = "lest",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "που", Transliteration = "pou", Gloss = "somewhere",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adv" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "against",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τραχεῖς", Transliteration = "tracheis", Gloss = "rough",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "τόπους", Transliteration = "topous", Gloss = "places",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "against rocky places"
                        },
                        new Word { Greek = "ἐκπέσωμεν", Transliteration = "ekpesōmen", Gloss = "we might run aground",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "lest we might run aground somewhere on rocky places"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "πρύμνης", Transliteration = "prymnēs", Gloss = "stern",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "from the stern"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ῥίψαντες", Transliteration = "rhipsantes", Gloss = "letting go",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "letting go"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀγκύρας", Transliteration = "agkyras", Gloss = "anchors",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τέσσαρας", Transliteration = "tessaras", Gloss = "four",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "four anchors"
                },
                new Word { Greek = "ηὔχοντο", Transliteration = "ēychonto", Gloss = "they prayed",
                    GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡμέραν", Transliteration = "hēmeran", Gloss = "day",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "γενέσθαι", Transliteration = "genesthai", Gloss = "to come",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "for day to come"
                }
            },
            Translation = "Fearing that we might run aground somewhere on rocky places, they let go four anchors from the stern and prayed for day to come."
        },

        // Verse 30
        new Phrase
        {
            SyntaxCodes = new List<string> { "GEN_ABS" },
            Content = new List<object>
            {
                new Word { Greek = "Τῶν", Transliteration = "Tōn", Gloss = "the",
                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                    PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ναυτῶν", Transliteration = "nautōn", Gloss = "sailors",
                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ζητούντων", Transliteration = "zētountōn", Gloss = "seeking",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φυγεῖν", Transliteration = "phygein", Gloss = "to flee",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πλοίου", Transliteration = "ploiou", Gloss = "ship",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "from the ship"
                        }
                    },
                    Translation = "to flee from the ship"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χαλασάντων", Transliteration = "chalasantōn", Gloss = "having lowered",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "σκάφην", Transliteration = "skaphēn", Gloss = "lifeboat",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the lifeboat"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θάλασσαν", Transliteration = "thalassan", Gloss = "sea",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "into the sea"
                        }
                    },
                    Translation = "having lowered the lifeboat into the sea"
                },
                new Word { Greek = "προφάσει", Transliteration = "prophasei", Gloss = "under pretense",
                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as though",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
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
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "πρῴρης", Transliteration = "prōrēs", Gloss = "bow",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "from the bow"
                        },
                        new Word { Greek = "ἀγκύρας", Transliteration = "agkyras", Gloss = "anchors",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μελλόντων", Transliteration = "mellontōn", Gloss = "being about to",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἐκτείνειν", Transliteration = "ekteinein", Gloss = "lay out",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "as though they were about to lay out anchors from the bow"
                }
            },
            Translation = "And as the sailors were seeking to flee from the ship and had lowered the lifeboat into the sea under pretense as though they were about to lay out anchors from the bow"
        },

        // Verse 31
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Παῦλος", Transliteration = "Paylos", Gloss = "Paul",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Paul"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἑκατοντάρχῃ", Transliteration = "hekatontarchē", Gloss = "centurion",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the centurion"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "στρατιώταις", Transliteration = "stratiōtais", Gloss = "soldiers",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the soldiers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "COND_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                                    GrammarCodes = new List<string> { "PRT" },
                                    PartOfSpeech = "part" },
                                new Word { Greek = "οὗτοι", Transliteration = "oytoi", Gloss = "these men",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "μείνωσιν", Transliteration = "meinōsin", Gloss = "stay",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "πλοίῳ", Transliteration = "ploiō", Gloss = "ship",
                                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "in the ship"
                                }
                            },
                            Translation = "Unless these men stay in the ship"
                        },
                        new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "σωθῆναι", Transliteration = "sōthēnai", Gloss = "to be saved",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "οὐ", Transliteration = "oy", Gloss = "not",
                            GrammarCodes = new List<string> { "PRT" },
                            PartOfSpeech = "part" },
                        new Word { Greek = "δύνασθε", Transliteration = "dynasthe", Gloss = "you are able",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "Unless these men stay in the ship, you cannot be saved"
                }
            },
            Translation = "Paul said to the centurion and the soldiers, 'Unless these men stay in the ship, you cannot be saved.'"
        },

        // Verse 32
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "Then",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "ἀπέκοψαν", Transliteration = "apekopsan", Gloss = "cut away",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "στρατιῶται", Transliteration = "stratiōtai", Gloss = "soldiers",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the soldiers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "σχοινία", Transliteration = "schoinia", Gloss = "ropes",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "σκάφης", Transliteration = "skaphēs", Gloss = "lifeboat",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the lifeboat"
                        }
                    },
                    Translation = "the ropes of the lifeboat"
                }
            },
            Translation = "Then the soldiers cut away the ropes of the lifeboat"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἴασαν", Transliteration = "eiasan", Gloss = "let",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτὴν", Transliteration = "autēn", Gloss = "it",
                    GrammarCodes = new List<string> { "PRON", "ACC", "3P", "F", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἐκπεσεῖν", Transliteration = "ekpesein", Gloss = "fall off",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                    PartOfSpeech = "v" }
            },
            Translation = "and let it fall off."
        }
    };
}

/*
Constructions identified:
- GEN_ABS: Acts 27:27 (διαφερομένων ἡμῶν)
- GEN_ABS: Acts 27:30 (Τῶν δὲ ναυτῶν ζητούντων ... χαλασάντων)
- COND_CLAUSE: Acts 27:31 (Ἐὰν μὴ οὗτοι μείνωσιν ἐν τῷ πλοίῳ)
- INF_PHRASE: Acts 27:30 (φυγεῖν ἐκ τοῦ πλοίου)
- INF_PHRASE: Acts 27:31 (σωθῆναι)
- VOC: Acts 27:25 (ἄνδρες)
*/
