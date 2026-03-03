private static List<object> GetChapter12()
{
    // Luke 12:25-32
    return new List<object>
    {
        // Verse 25
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
                        new Word { Greek = "τίς", Transliteration = "tis",
                            Gloss = "who?",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐξ", Transliteration = "ex",
                                    Gloss = "of",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn",
                                    Gloss = "you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "of you"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μεριμνῶν", Transliteration = "merimnōn",
                                    Gloss = "by worrying",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "verb" }
                            },
                            Translation = "by worrying"
                        }
                    },
                    Translation = "And who of you by worrying"
                },
                new Word { Greek = "δύναται", Transliteration = "dynatai",
                    Gloss = "is able",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi",
                                    Gloss = "to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἡλικίαν", Transliteration = "hēlikian",
                                            Gloss = "stature",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                            PartOfSpeech = "noun" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                                            Gloss = "his",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                            PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "his stature"
                                }
                            },
                            Translation = "to his stature"
                        },
                        new Word { Greek = "προσθεῖναι", Transliteration = "prostheinai",
                            Gloss = "to add",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "πῆχυν", Transliteration = "pēchyn",
                            Gloss = "a cubit",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "to add a cubit to his stature"
                }
            },
            Translation = "And which of you by worrying is able to add a cubit to his stature?"
        },
        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "ei",
                    Gloss = "if",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὖν", Transliteration = "oun",
                    Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐδὲ", Transliteration = "oude",
                    Gloss = "not even",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλάχιστον", Transliteration = "elachiston",
                            Gloss = "the least",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the least"
                },
                new Word { Greek = "δύνασθε", Transliteration = "dynasthe",
                    Gloss = "you are able",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "2P", "P" },
                    PartOfSpeech = "verb" }
            },
            Translation = "If then you are not able to do even a very little thing"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τί", Transliteration = "ti",
                    Gloss = "why",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri",
                            Gloss = "about",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "λοιπῶν", Transliteration = "loipōn",
                                    Gloss = "rest",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "the rest"
                        }
                    },
                    Translation = "about the rest"
                },
                new Word { Greek = "μεριμνᾶτε", Transliteration = "merimnate",
                    Gloss = "do you worry",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "verb" }
            },
            Translation = "why do you worry about the rest?"
        },
        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "κατανοήσατε", Transliteration = "katanoēsate",
                    Gloss = "consider",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κρίνα", Transliteration = "krina",
                            Gloss = "lilies",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "the lilies"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πῶς", Transliteration = "pōs",
                            Gloss = "how",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "αὐξάνει", Transliteration = "auxanei",
                            Gloss = "they grow",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "how they grow"
                }
            },
            Translation = "Consider the lilies, how they grow"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "κοπιᾷ", Transliteration = "kopia",
                    Gloss = "they toil",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "οὐδὲ", Transliteration = "oude",
                    Gloss = "nor",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "νήθει", Transliteration = "nēthei",
                    Gloss = "they spin",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" }
            },
            Translation = "they neither toil nor spin"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγω", Transliteration = "legō",
                    Gloss = "I say",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin",
                    Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "P" },
                    PartOfSpeech = "prep" }
            },
            Translation = "yet I tell you"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐδὲ", Transliteration = "oude",
                    Gloss = "not even",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Σολομὼν", Transliteration = "Solomōn",
                            Gloss = "Solomon",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "Solomon"
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
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάσῃ", Transliteration = "pasē",
                                    Gloss = "all",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "τῇ", Transliteration = "tē",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "δόξῃ", Transliteration = "doxē",
                                    Gloss = "glory",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                                    Gloss = "his",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "all his glory"
                        }
                    },
                    Translation = "in all his glory"
                },
                new Word { Greek = "περιεβάλετο", Transliteration = "periebaleto",
                    Gloss = "was arrayed",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs",
                            Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἓν", Transliteration = "hen",
                                    Gloss = "one",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "τούτων", Transliteration = "toutōn",
                                    Gloss = "of these",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "one of these"
                        }
                    },
                    Translation = "like one of these"
                }
            },
            Translation = "even Solomon in all his glory was not arrayed like one of these"
        },
        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "ei",
                    Gloss = "if",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "δὲ", Transliteration = "de",
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
                        new Word { Greek = "ἀγρῷ", Transliteration = "agrō",
                            Gloss = "the field",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "in the field"
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
                        new Word { Greek = "χόρτον", Transliteration = "chorton",
                            Gloss = "grass",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "the grass"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὄντα", Transliteration = "onta",
                            Gloss = "which is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "σήμερον", Transliteration = "sēmeron",
                            Gloss = "today",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "which is today"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "αὔριον", Transliteration = "aurion",
                    Gloss = "tomorrow",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis",
                            Gloss = "into",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "κλίβανον", Transliteration = "klibanon",
                            Gloss = "the oven",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "into the oven"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βαλλόμενον", Transliteration = "ballomenon",
                            Gloss = "is thrown",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "is thrown"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεὸς", Transliteration = "theos",
                            Gloss = "God",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "God"
                },
                new Word { Greek = "οὕτως", Transliteration = "houtōs",
                    Gloss = "so",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἀμφιέζει", Transliteration = "amphiezei",
                    Gloss = "clothes",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" }
            },
            Translation = "But if God so clothes the grass, which is alive in the field today, and tomorrow is thrown into the oven"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πόσῳ", Transliteration = "posō",
                    Gloss = "how much",
                    GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" },
                    PartOfSpeech = "q" },
                new Word { Greek = "μᾶλλον", Transliteration = "mallon",
                    Gloss = "more",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas",
                    Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὀλιγόπιστοι", Transliteration = "oligopistoi",
                            Gloss = "O you of little faith",
                            GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "O you of little faith"
                }
            },
            Translation = "how much more will he clothe you, O you of little faith!"
        },
        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑμεῖς", Transliteration = "hymeis",
                            Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "NOM", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "you"
                },
                new Word { Greek = "μὴ", Transliteration = "mē",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ζητεῖτε", Transliteration = "zēteite",
                    Gloss = "seek",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti",
                            Gloss = "what",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "interj" },
                        new Word { Greek = "φάγητε", Transliteration = "phagēte",
                            Gloss = "you might eat",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "what you should eat"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti",
                            Gloss = "what",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "interj" },
                        new Word { Greek = "πίητε", Transliteration = "piēte",
                            Gloss = "you might drink",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "what you should drink"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "μὴ", Transliteration = "mē",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "μετεωρίζεσθε", Transliteration = "meteōrizesthe",
                    Gloss = "be anxious",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "verb" }
            },
            Translation = "And do not seek what you are to eat and what you are to drink, nor be worried"
        },
        // Verse 30
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
                        new Word { Greek = "ταῦτα", Transliteration = "tauta",
                            Gloss = "these things",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "all these things"
                },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάντα", Transliteration = "panta",
                            Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "τὰ", Transliteration = "ta",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἔθνη", Transliteration = "ethnē",
                            Gloss = "nations",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                            PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κόσμου", Transliteration = "kosmou",
                                    Gloss = "world",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "of the world"
                        }
                    },
                    Translation = "all the nations of the world"
                },
                new Word { Greek = "ἐπιζητοῦσιν", Transliteration = "epizētousin",
                    Gloss = "seek after",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "verb" }
            },
            Translation = "For all the nations of the world seek after these things"
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
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn",
                            Gloss = "your",
                            GrammarCodes = new List<string> { "PRON", "GEN", "P" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πατὴρ", Transliteration = "patēr",
                            Gloss = "Father",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "but your Father"
                },
                new Word { Greek = "οἶδεν", Transliteration = "oiden",
                    Gloss = "knows",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti",
                            Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "χρῄζετε", Transliteration = "chrēzete",
                            Gloss = "you need",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "τούτων", Transliteration = "toutōn",
                            Gloss = "them",
                            GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "that you need them"
                }
            },
            Translation = "and your Father knows that you need them"
        },
        // Verse 31
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πλὴν", Transliteration = "plēn",
                    Gloss = "instead",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ζητεῖτε", Transliteration = "zēteite",
                    Gloss = "seek",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "βασιλείαν", Transliteration = "basileian",
                            Gloss = "kingdom",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                            Gloss = "his",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "his kingdom"
                }
            },
            Translation = "Instead, seek his kingdom"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταῦτα", Transliteration = "tauta",
                            Gloss = "these things",
                            GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "these things"
                },
                new Word { Greek = "προστεθήσεται", Transliteration = "prostethēsetai",
                    Gloss = "will be added",
                    GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin",
                    Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "P" },
                    PartOfSpeech = "prep" }
            },
            Translation = "and these things will be added to you"
        },
        // Verse 32
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Μὴ", Transliteration = "mē",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "φοβοῦ", Transliteration = "phobou",
                    Gloss = "fear",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "VOC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μικρὸν", Transliteration = "mikron",
                            Gloss = "little",
                            GrammarCodes = new List<string> { "ADJ", "VOC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ποίμνιον", Transliteration = "poimnion",
                            Gloss = "flock",
                            GrammarCodes = new List<string> { "N", "VOC", "N", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "little flock"
                }
            },
            Translation = "Fear not, little flock"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εὐδόκησεν", Transliteration = "eudokēsen",
                    Gloss = "was well pleased",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πατὴρ", Transliteration = "patēr",
                            Gloss = "Father",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn",
                            Gloss = "your",
                            GrammarCodes = new List<string> { "PRON", "GEN", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "your Father"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δοῦναι", Transliteration = "dounai",
                            Gloss = "to give",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin",
                            Gloss = "to you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "P" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "βασιλείαν", Transliteration = "basileian",
                                    Gloss = "kingdom",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "the kingdom"
                        }
                    },
                    Translation = "to give you the kingdom"
                }
            },
            Translation = "for it is your Father's good pleasure to give you the kingdom"
        }
    };
}

/* Identified Constructions:
   - 12:26 COND_CLAUSE (First-class condition)
   - 12:28 PTCP (Attributive participles modifying τὸν χόρτον)
   - 12:30 GEN_DESC / GEN_SUBJ (τοῦ κόσμου, ὁ πατὴρ ὑμῶν)
   - 12:32 VOC (τὸ μικρὸν ποίμνιον)
*/
