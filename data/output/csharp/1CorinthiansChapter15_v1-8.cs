private static List<object> GetChapter15()
{
    // 1 Corinthians 15:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Γνωρίζω", Transliteration = "Gnōrizō", Gloss = "I make known",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers",
                    GrammarCodes = new List<string> { "N", "VOC", "M", "P" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "εὐαγγέλιον", Transliteration = "euangelion", Gloss = "gospel",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the gospel"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "εὐηγγελισάμην", Transliteration = "euēngelisamēn", Gloss = "I preached",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "1P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "which I preached to you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "παρελάβετε", Transliteration = "parelabete", Gloss = "you received",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "which also you received"
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
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ᾧ", Transliteration = "hō", Gloss = "which",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "in which"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἑστήκατε", Transliteration = "hestēkate", Gloss = "you stand",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "in which also you stand"
                }
            },
            Translation = "Now I make known to you, brothers, the gospel which I preached to you, which also you received, in which also you stand,"
        },
        // Verse 2
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
                        new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "through",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "GEN", "N", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "through which"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "σῴζεσθε", Transliteration = "sōzesthe", Gloss = "you are being saved",
                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DAT_MANNER" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τίνι", Transliteration = "tini", Gloss = "by what",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                            PartOfSpeech = "interj" },
                        new Word { Greek = "λόγῳ", Transliteration = "logō", Gloss = "word",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "by what word"
                },
                new Word { Greek = "εὐηγγελισάμην", Transliteration = "euēngelisamēn", Gloss = "I preached",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "κατέχετε", Transliteration = "katechete", Gloss = "you hold fast",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "if you hold fast"
                },
                new Word { Greek = "ἐκτὸς", Transliteration = "ektos", Gloss = "except",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "εἰκῇ", Transliteration = "eikē", Gloss = "in vain",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἐπιστεύσατε", Transliteration = "episteusate", Gloss = "you believed",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "unless you believed in vain"
                }
            },
            Translation = "through which also you are being saved, if you hold fast to the word I preached to you—unless you believed in vain."
        },
        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "παρέδωκα", Transliteration = "paredōka", Gloss = "I delivered",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "as",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "πρώτοις", Transliteration = "prōtois", Gloss = "first importance",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "N", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "as of first importance"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "παρέλαβον", Transliteration = "parelabon", Gloss = "I received",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "what I also received"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "Χριστὸς", Transliteration = "Christos", Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἀπέθανεν", Transliteration = "apethanen", Gloss = "died",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἁμαρτιῶν", Transliteration = "hamartiōn", Gloss = "sins",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "P" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "our sins"
                                }
                            },
                            Translation = "for our sins"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "γραφὰς", Transliteration = "graphas", Gloss = "Scriptures",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the Scriptures"
                                }
                            },
                            Translation = "according to the Scriptures"
                        }
                    },
                    Translation = "that Christ died for our sins according to the Scriptures"
                }
            },
            Translation = "For I delivered to you as of first importance what I also received: that Christ died for our sins according to the Scriptures,"
        },
        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἐτάφη", Transliteration = "etaphē", Gloss = "He was buried",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἐγήγερται", Transliteration = "egēgertai", Gloss = "He has been raised",
                    GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἡμέρᾳ", Transliteration = "hēmera", Gloss = "day",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "τρίτῃ", Transliteration = "tritē", Gloss = "third",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "on the third day"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "γραφὰς", Transliteration = "graphas", Gloss = "Scriptures",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                    PartOfSpeech = "n" }
                                },
                            Translation = "the Scriptures"
                        }
                    },
                    Translation = "according to the Scriptures"
                }
            },
            Translation = "and that He was buried, and that He was raised on the third day according to the Scriptures,"
        },
        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ὤφθη", Transliteration = "ōphthē", Gloss = "He appeared",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "Κηφᾷ", Transliteration = "Kēpha", Gloss = "to Cephas",
                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "εἶτα", Transliteration = "eita", Gloss = "then",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δώδεκα", Transliteration = "dōdeka", Gloss = "Twelve",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "to the Twelve"
                }
            },
            Translation = "and that He appeared to Cephas, then to the Twelve."
        },
        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔπειτα", Transliteration = "epeita", Gloss = "then",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ὤφθη", Transliteration = "ōphthē", Gloss = "He appeared",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπάνω", Transliteration = "epanō", Gloss = "to more than",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "πεντακοσίοις", Transliteration = "pentakosiois", Gloss = "five hundred",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἀδελφοῖς", Transliteration = "adelphois", Gloss = "brothers",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to more than five hundred brothers"
                },
                new Word { Greek = "ἐφάπαξ", Transliteration = "ephapax", Gloss = "at once",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "of whom"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πλείονες", Transliteration = "pleiones", Gloss = "greater part",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the greater part"
                },
                new Word { Greek = "μένουσιν", Transliteration = "menousin", Gloss = "remain",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "until",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἄρτι", Transliteration = "arti", Gloss = "now",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "until now"
                },
                new Word { Greek = "τινὲς", Transliteration = "tines", Gloss = "some",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                    PartOfSpeech = "part" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐκοιμήθησαν", Transliteration = "ekoimēthēsan", Gloss = "have fallen asleep",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "Then He appeared to more than five hundred brothers at once, most of whom remain until now, but some have fallen asleep."
        },
        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔπειτα", Transliteration = "epeita", Gloss = "then",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ὤφθη", Transliteration = "ōphthē", Gloss = "He appeared",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "Ἰακώβῳ", Transliteration = "Iakōbō", Gloss = "to James",
                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "εἶτα", Transliteration = "eita", Gloss = "then",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀποστόλοις", Transliteration = "apostolois", Gloss = "apostles",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "πᾶσιν", Transliteration = "pasin", Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "to all the apostles"
                }
            },
            Translation = "Then He appeared to James, then to all the apostles."
        },
        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "ADJ_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔσχατον", Transliteration = "eschaton", Gloss = "last",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "of all",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "last of all"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡσπερεὶ", Transliteration = "hōsperei", Gloss = "as to",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἐκτρώματι", Transliteration = "ektrōmati", Gloss = "one untimely born",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "as to one untimely born"
                },
                new Word { Greek = "ὤφθη", Transliteration = "ōphthē", Gloss = "He appeared",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "κἀμοί", Transliteration = "kamoi", Gloss = "to me also",
                    GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "And last of all, as to one untimely born, He appeared to me also."
        }
    };
}
/*
Constructions identified:
- DAT_MANNER: τίνι λόγῳ (v2) - Dative of manner/means identifying the content of the gospel.
- COND_CLAUSE: εἰ κατέχετε (v2), εἰ μὴ εἰκῇ ἐπιστεύσατε (v2) - First class condition.
- CAUSAL_CLAUSE: ὅτι Χριστὸς ἀπέθανεν... (v3) - Content/Causal ὅτι introducing the kerygma.
- DAT_REF: τῇ ἡμέρᾳ τῇ τρίτῃ (v4) - Dative of time/reference.
- DAT_REF: ἔσχατον δὲ πάντων (v8) - Adverbial/Dative of time/order.
*/
