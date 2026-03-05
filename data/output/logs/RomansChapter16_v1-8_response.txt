private static List<object> GetChapter16()
{
    // Romans 16:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Συνίστημι", Transliteration = "Synistēmi",
                    Gloss = "I commend",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin",
                    Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "P", "2P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Φοίβην", Transliteration = "Phoibēn",
                            Gloss = "Phoebe",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀδελφὴν", Transliteration = "adelphēn",
                                    Gloss = "sister",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn",
                                    Gloss = "of us",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P", "1P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "our sister"
                        }
                    },
                    Translation = "Phoebe our sister"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὖσαν", Transliteration = "ousan",
                            Gloss = "being",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "F", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διάκονον", Transliteration = "diakonon",
                                    Gloss = "a servant",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs",
                                            Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἐκκλησίας", Transliteration = "ekklēsias",
                                            Gloss = "church",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of the church"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs",
                                            Gloss = "the [one]",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἐν", Transliteration = "en",
                                            Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "Κεγχρεαῖς", Transliteration = "Kenchreais",
                                            Gloss = "Cenchreae",
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "P" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "in Cenchreae"
                                }
                            },
                            Translation = "a servant of the church in Cenchreae"
                        }
                    },
                    Translation = "who is a servant of the church in Cenchreae"
                }
            },
            Translation = "I commend to you Phoebe our sister, who is a servant of the church in Cenchreae,"
        },
        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἵνα", Transliteration = "hina",
                    Gloss = "that",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "αὐτὴν", Transliteration = "autēn",
                    Gloss = "her",
                    GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "προσδέξησθε", Transliteration = "prosdeksēsthe",
                    Gloss = "you may receive",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "κυρίῳ", Transliteration = "kyriō",
                            Gloss = "the Lord",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in the Lord"
                },
                new Word { Greek = "ἀξίως", Transliteration = "axiōs",
                    Gloss = "worthily",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn",
                            Gloss = "of the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἁγίων", Transliteration = "hagiōn",
                            Gloss = "saints",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "of the saints"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "παραστῆτε", Transliteration = "parastēte",
                    Gloss = "help",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῇ", Transliteration = "autē",
                    Gloss = "her",
                    GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" },
                    PartOfSpeech = "prep" },
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
                                new Word { Greek = "ἐν", Transliteration = "en",
                                    Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ᾧ", Transliteration = "hō",
                                    Gloss = "whatever",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "in whatever"
                        },
                        new Word { Greek = "ἂν", Transliteration = "an",
                            Gloss = "[ever]",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn",
                            Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "P", "2P" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "χρῄζῃ", Transliteration = "chrēzē",
                            Gloss = "she may need",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "πράγματι", Transliteration = "pragmati",
                            Gloss = "matter",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in whatever matter she may need you"
                }
            },
            Translation = "that you may receive her in the Lord worthily of the saints, and help her in whatever matter she may need you,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "αὐτὴ", Transliteration = "autē",
                    Gloss = "she",
                    GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προστάτις", Transliteration = "prostatis",
                            Gloss = "a helper",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "πολλῶν", Transliteration = "pollōn",
                            Gloss = "of many",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "a helper of many"
                },
                new Word { Greek = "ἐγενήθη", Transliteration = "egenēthē",
                    Gloss = "has been",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐμοῦ", Transliteration = "emou",
                            Gloss = "of me",
                            GrammarCodes = new List<string> { "PRON", "GEN", "S", "1P" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                            Gloss = "myself",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "of myself"
                }
            },
            Translation = "for she has been a helper of many and of myself as well."
        },
        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀσπάσασθε", Transliteration = "Aspasasthe",
                    Gloss = "Greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Πρίσκαν", Transliteration = "Priskan",
                            Gloss = "Prisca",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "Ἀκύλαν", Transliteration = "Akylan",
                            Gloss = "Aquila",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Prisca and Aquila"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "συνεργούς", Transliteration = "synergous",
                            Gloss = "fellow workers",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "μου", Transliteration = "mou",
                            Gloss = "of me",
                            GrammarCodes = new List<string> { "PRON", "GEN", "S", "1P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "my fellow workers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Χριστῷ", Transliteration = "Christō",
                            Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou",
                            Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in Christ Jesus"
                }
            },
            Translation = "Greet Prisca and Aquila, my fellow workers in Christ Jesus,"
        },
        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οἵτινες", Transliteration = "hoitines",
                    Gloss = "who",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὲρ", Transliteration = "hyper",
                            Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ψυχῆς", Transliteration = "psychēs",
                                    Gloss = "life",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou",
                                    Gloss = "of me",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "S", "1P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "my life"
                        }
                    },
                    Translation = "for my life"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἑαυτῶν", Transliteration = "heautōn",
                            Gloss = "their own",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "f" },
                        new Word { Greek = "τράχηλον", Transliteration = "trachēlon",
                            Gloss = "neck",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "their own necks"
                },
                new Word { Greek = "ὑπέθηκαν", Transliteration = "hypethēkan",
                    Gloss = "laid down",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "who for my life laid down their own necks,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οἷς", Transliteration = "hois",
                    Gloss = "to whom",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "οὐκ", Transliteration = "ouk",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐγὼ", Transliteration = "egō",
                    Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "S", "1P" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "μόνος", Transliteration = "monos",
                    Gloss = "alone",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "εὐχαριστῶ", Transliteration = "eucharistō",
                    Gloss = "give thanks",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶαι", Transliteration = "pasai",
                            Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "αἱ", Transliteration = "hai",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἐκκλησίαι", Transliteration = "ekklēsiai",
                            Gloss = "churches",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐθνῶν", Transliteration = "ethnōn",
                                    Gloss = "Gentiles",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the Gentiles"
                        }
                    },
                    Translation = "all the churches of the Gentiles"
                }
            },
            Translation = "to whom not only I give thanks but also all the churches of the Gentiles."
        },
        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατ᾽", Transliteration = "kat'",
                                    Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "οἶκον", Transliteration = "oikon",
                                    Gloss = "house",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn",
                                    Gloss = "their",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P", "3P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "in their house"
                        },
                        new Word { Greek = "ἐκκλησίαν", Transliteration = "ekklēsian",
                            Gloss = "church",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the church in their house"
                },
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "Greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἐπαίνετον", Transliteration = "Epaineton",
                            Gloss = "Epaenetus",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀγαπητόν", Transliteration = "agapēton",
                                    Gloss = "beloved",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "μου", Transliteration = "mou",
                                    Gloss = "of me",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "S", "1P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "my beloved"
                        }
                    },
                    Translation = "Epaenetus my beloved"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅς", Transliteration = "hos",
                            Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin",
                            Gloss = "is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπαρχὴ", Transliteration = "aparchē",
                                    Gloss = "firstfruit",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs",
                                            Gloss = "of",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "Ἀσίας", Transliteration = "Asias",
                                            Gloss = "Asia",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of Asia"
                                }
                            },
                            Translation = "a firstfruit of Asia"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis",
                                    Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "Χριστόν", Transliteration = "Christon",
                                    Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "for Christ"
                        }
                    },
                    Translation = "who is the firstfruits of Asia for Christ."
                }
            },
            Translation = "Greet also the church in their house. Greet Epaenetus my beloved, who is the firstfruits of Asia for Christ."
        },
        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "Greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "Μαρίαν", Transliteration = "Marian",
                    Gloss = "Mary",
                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἥτις", Transliteration = "hētis",
                            Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "πολλὰ", Transliteration = "polla",
                            Gloss = "much",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἐκοπίασεν", Transliteration = "ekopiasen",
                            Gloss = "worked",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis",
                                    Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμᾶς", Transliteration = "hymas",
                                    Gloss = "you",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "P", "2P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "for you"
                        }
                    },
                    Translation = "who has worked much for you."
                }
            },
            Translation = "Greet Mary, who has worked much for you."
        },
        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "Greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἀνδρόνικον", Transliteration = "Andronikon",
                            Gloss = "Andronicus",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "Ἰουνίαν", Transliteration = "Iounian",
                            Gloss = "Junia",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Andronicus and Junia"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "συγγενεῖς", Transliteration = "syngeneis",
                            Gloss = "kinsmen",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "μου", Transliteration = "mou",
                            Gloss = "of me",
                            GrammarCodes = new List<string> { "PRON", "GEN", "S", "1P" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "συναιχμαλώτους", Transliteration = "synaichmalōtous",
                            Gloss = "fellow prisoners",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou",
                            Gloss = "of me",
                            GrammarCodes = new List<string> { "PRON", "GEN", "S", "1P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "my kinsmen and my fellow prisoners"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἵτινές", Transliteration = "hoitines",
                            Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "εἰσιν", Transliteration = "eisin",
                            Gloss = "are",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἐπίσημοι", Transliteration = "episēmoi",
                            Gloss = "outstanding",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en",
                                    Gloss = "among",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τοῖς", Transliteration = "tois",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀποστόλοις", Transliteration = "apostolois",
                                    Gloss = "apostles",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "among the apostles"
                        }
                    },
                    Translation = "who are well known to the apostles"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἳ", Transliteration = "hoi",
                            Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸ", Transliteration = "pro",
                                    Gloss = "before",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἐμοῦ", Transliteration = "emou",
                                    Gloss = "me",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "S", "1P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "before me"
                        },
                        new Word { Greek = "γέγοναν", Transliteration = "gegonan",
                            Gloss = "have been",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en",
                                    Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "Χριστῷ", Transliteration = "Christō",
                                    Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in Christ"
                        }
                    },
                    Translation = "who also were in Christ before me."
                }
            },
            Translation = "Greet Andronicus and Junia, my kinsmen and my fellow prisoners, who are well known to the apostles and who were in Christ before me."
        },
        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "Greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἀμπλιᾶτον", Transliteration = "Ampliaton",
                            Gloss = "Ampliatus",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀγαπητόν", Transliteration = "agapēton",
                                    Gloss = "beloved",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "μου", Transliteration = "mou",
                                    Gloss = "of me",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "S", "1P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "my beloved"
                        }
                    },
                    Translation = "Ampliatus my beloved"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "κυρίῳ", Transliteration = "kyriō",
                            Gloss = "the Lord",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in the Lord"
                }
            },
            Translation = "Greet Ampliatus, my beloved in the Lord."
        }
    };
}
/*
Identified Constructions:
- APPOS: v1 (tēn adelphēn hēmōn), v3 (tous synergous mou), v5 (ton agapēton mou), v7 (tous syngeneis mou kai synaichmalōtous mou), v8 (ton agapēton mou)
- NOUN_PHRASE (PRED): v1 (diakonon...), v5 (aparchē...)
- NOUN_PHRASE (SUBJ): v4 (pasai hai ekklēsiai...)
- NOUN_PHRASE (OBJ): v1 (Phoibēn), v3 (Priskan kai Akylan), v4 (ton heautōn trachēlon), v5 (tēn... ekklēsian, Epaineton), v7 (Andronikon kai Iounian), v8 (Ampliaton)
- REL_CLAUSE: v2 (en hō...), v4 (hoitines..., hois...), v5 (hos...), v6 (hētis...), v7 (hoitines..., hoi...)
- PURPOSE_CLAUSE: v2 (hina...)
- CAUSAL_CLAUSE: v2 (kai gar...)
*/
