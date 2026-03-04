private static List<object> GetChapter8()
{
    // Romans 8:33-39
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τίς", Transliteration = "tis",
                    Gloss = "who?",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "interj" },
                new Word { Greek = "ἐγκαλέσει", Transliteration = "enkalesei",
                    Gloss = "will bring charges",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "kata",
                            Gloss = "against",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἐκλεκτῶν", Transliteration = "eklektōn",
                            Gloss = "chosen ones",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou",
                            Gloss = "of God",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "against God's elect"
                }
            },
            Translation = "Who shall bring any charge against God's elect?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "θεὸς", Transliteration = "theos",
                    Gloss = "God",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the [one]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δικαιῶν", Transliteration = "dikaiōn",
                            Gloss = "justifying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "is the one who justifies"
                }
            },
            Translation = "It is God who justifies."
        },

        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τίς", Transliteration = "tis",
                    Gloss = "who?",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "interj" },
                new Word { Greek = "ὁ", Transliteration = "ho",
                    Gloss = "the [one]",
                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                    PartOfSpeech = "art" },
                new Word { Greek = "κατακρινῶν", Transliteration = "katakrinōn",
                    Gloss = "condemning",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "Who is the one who condemns?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Χριστὸς", Transliteration = "Christos",
                            Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous",
                            Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Christ Jesus"
                },
                new Word { Greek = "ὁ", Transliteration = "ho",
                    Gloss = "the [one]",
                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                    PartOfSpeech = "art" },
                new Word { Greek = "ἀποθανών", Transliteration = "apothanōn",
                    Gloss = "having died",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "μᾶλλον", Transliteration = "mallon",
                    Gloss = "rather",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐγερθείς", Transliteration = "egertheis",
                    Gloss = "having been raised",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos",
                            Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "καί", Transliteration = "kai",
                            Gloss = "indeed",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin",
                            Gloss = "is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en",
                                    Gloss = "at",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "δεξιᾷ", Transliteration = "dexia",
                                    Gloss = "right hand",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou",
                                    Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "at the right hand of God"
                        }
                    },
                    Translation = "who is at the right hand of God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos",
                            Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐντυγχάνει", Transliteration = "entynchanei",
                            Gloss = "intercedes",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὲρ", Transliteration = "hyper",
                                    Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn",
                                    Gloss = "us",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "for us"
                        }
                    },
                    Translation = "who also intercedes for us"
                }
            },
            Translation = "Christ Jesus is the one who died—more than that, who was raised—who is at the right hand of God, who indeed is interceding for us."
        },

        // Verse 35
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τίς", Transliteration = "tis",
                    Gloss = "who?",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "interj" },
                new Word { Greek = "ἡμᾶς", Transliteration = "hēmas",
                    Gloss = "us",
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "χωρίσει", Transliteration = "chōrisei",
                    Gloss = "shall separate",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo",
                            Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῆς", Transliteration = "tēs",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀγάπης", Transliteration = "agapēs",
                            Gloss = "love",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τοῦ", Transliteration = "tou",
                            Gloss = "of the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Χριστοῦ", Transliteration = "Christou",
                            Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "from the love of Christ"
                }
            },
            Translation = "Who shall separate us from the love of Christ?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "θλῖψις", Transliteration = "thlipsis",
                    Gloss = "tribulation",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἢ", Transliteration = "ē",
                    Gloss = "or",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "στενοχωρία", Transliteration = "stenochōria",
                    Gloss = "distress",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἢ", Transliteration = "ē",
                    Gloss = "or",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "διωγμὸς", Transliteration = "diōgmos",
                    Gloss = "persecution",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἢ", Transliteration = "ē",
                    Gloss = "or",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "λιμὸς", Transliteration = "limos",
                    Gloss = "famine",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἢ", Transliteration = "ē",
                    Gloss = "or",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "γυμνότης", Transliteration = "gymnotēs",
                    Gloss = "nakedness",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἢ", Transliteration = "ē",
                    Gloss = "or",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "κίνδυνος", Transliteration = "kindynos",
                    Gloss = "danger",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἢ", Transliteration = "ē",
                    Gloss = "or",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "μάχαιρα", Transliteration = "machaira",
                    Gloss = "sword",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                    PartOfSpeech = "n" }
            },
            Translation = "Shall tribulation, or distress, or persecution, or famine, or nakedness, or danger, or sword?"
        },

        // Verse 36
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθὼς", Transliteration = "kathōs",
                            Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "γέγραπται", Transliteration = "gegraptai",
                            Gloss = "it is written",
                            GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "as it is written"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti",
                            Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἕνεκεν", Transliteration = "heneken",
                                    Gloss = "for the sake of",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "σοῦ", Transliteration = "sou",
                                    Gloss = "you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "for your sake"
                        },
                        new Word { Greek = "θανατούμεθα", Transliteration = "thanatoumetha",
                            Gloss = "we are being put to death",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "1P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅλην", Transliteration = "holēn",
                                    Gloss = "all",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἡμέραν", Transliteration = "hēmeran",
                                    Gloss = "day",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "all the day long"
                        }
                    },
                    Translation = "For your sake we are being killed all the day long"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλογίσθημεν", Transliteration = "elogisthēmen",
                            Gloss = "we were regarded",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "1P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ὡς", Transliteration = "hōs",
                            Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρόβατα", Transliteration = "probata",
                                    Gloss = "sheep",
                                    GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "σφαγῆς", Transliteration = "sphagēs",
                                    Gloss = "of slaughter",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "sheep for slaughter"
                        }
                    },
                    Translation = "we were regarded as sheep to be slaughtered"
                }
            },
            Translation = "As it is written, \"For your sake we are being killed all the day long; we are regarded as sheep to be slaughtered.\""
        },

        // Verse 37
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τούτοις", Transliteration = "toutois",
                            Gloss = "these",
                            GrammarCodes = new List<string> { "PRON", "DAT", "N", "P" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "πᾶσιν", Transliteration = "pasin",
                            Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "N", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "in all these things"
                },
                new Word { Greek = "ὑπερνικῶμεν", Transliteration = "hypernikōmen",
                    Gloss = "we are more than conquerors",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia",
                            Gloss = "through",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou",
                            Gloss = "the [one]",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀγαπήσαντος", Transliteration = "agapēsantos",
                            Gloss = "having loved",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἡμᾶς", Transliteration = "hēmas",
                            Gloss = "us",
                            GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "through him who loved us"
                }
            },
            Translation = "No, in all these things we are more than conquerors through him who loved us."
        },

        // Verse 38
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πέπεισμαι", Transliteration = "pepeismai",
                    Gloss = "I am persuaded",
                    GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti",
                            Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "οὔτε", Transliteration = "oute",
                            Gloss = "neither",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "θάνατος", Transliteration = "thanatos",
                            Gloss = "death",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "οὔτε", Transliteration = "oute",
                            Gloss = "nor",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ζωὴ", Transliteration = "zōē",
                            Gloss = "life",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "οὔτε", Transliteration = "oute",
                            Gloss = "nor",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἄγγελοι", Transliteration = "angeloi",
                            Gloss = "angels",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "οὔτε", Transliteration = "oute",
                            Gloss = "nor",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἀρχαὶ", Transliteration = "archai",
                            Gloss = "rulers",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "οὔτε", Transliteration = "oute",
                            Gloss = "nor",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐνεστῶτα", Transliteration = "enestōta",
                            Gloss = "things present",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "N", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "οὔτε", Transliteration = "oute",
                            Gloss = "nor",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μέλλοντα", Transliteration = "mellonta",
                            Gloss = "things to come",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "οὔτε", Transliteration = "oute",
                            Gloss = "nor",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δυνάμεις", Transliteration = "dynameis",
                            Gloss = "powers",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "that neither death nor life, nor angels nor rulers, nor things present nor things to come, nor powers"
                }
            },
            Translation = "For I am persuaded that neither death nor life, nor angels nor rulers, nor things present nor things to come, nor powers,"
        },

        // Verse 39
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 38)
                new Word { Greek = "οὔτε", Transliteration = "oute",
                    Gloss = "nor",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὕψωμα", Transliteration = "hypsōma",
                    Gloss = "height",
                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "οὔτε", Transliteration = "oute",
                    Gloss = "nor",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "βάθος", Transliteration = "bathos",
                    Gloss = "depth",
                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "οὔτε", Transliteration = "oute",
                    Gloss = "nor",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τις", Transliteration = "tis",
                            Gloss = "any",
                            GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" },
                            PartOfSpeech = "part" },
                        new Word { Greek = "κτίσις", Transliteration = "ktisis",
                            Gloss = "creation",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἑτέρα", Transliteration = "hetera",
                            Gloss = "other",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "any other created thing"
                },
                new Word { Greek = "δυνήσεται", Transliteration = "dynēsetai",
                    Gloss = "will be able",
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἡμᾶς", Transliteration = "hēmas",
                    Gloss = "us",
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "χωρίσαι", Transliteration = "chōrisai",
                    Gloss = "to separate",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo",
                            Gloss = "from",
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
                                new Word { Greek = "ἀγάπης", Transliteration = "agapēs",
                                    Gloss = "love",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou",
                                    Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the love of God"
                        }
                    },
                    Translation = "from the love of God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῆς", Transliteration = "tēs",
                            Gloss = "the [one]",
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                            PartOfSpeech = "art" },
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
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τῷ", Transliteration = "tō",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κυρίῳ", Transliteration = "kyriō",
                                    Gloss = "Lord",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn",
                                    Gloss = "of us",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "in Christ Jesus our Lord"
                        }
                    },
                    Translation = "which is in Christ Jesus our Lord"
                }
            },
            Translation = "nor height nor depth, nor any other created thing, will be able to separate us from the love of God in Christ Jesus our Lord."
        }
    };
}

/*
Constructions identified:
- Romans 8:33-34, 35: Rhetorical questions (Interrogative τίς).
- Romans 8:33, 34, 37: Substantival Participles (ὁ δικαιῶν, ὁ κατακρινῶν, τοῦ ἀγαπήσαντος).
- Romans 8:36: Scriptural Citation (καθὼς γέγραπται).
- Romans 8:38-39: Polysyndeton (repeated οὔτε).
*/
