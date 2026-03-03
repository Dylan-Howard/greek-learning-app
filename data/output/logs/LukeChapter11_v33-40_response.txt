private static List<object> GetChapter11()
{
    // Luke 11:33-40
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Οὐδεὶς", Transliteration = "oudeis", Gloss = "no one", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "λύχνον", Transliteration = "lychnon", Gloss = "lamp", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἅψας", Transliteration = "hapsas", Gloss = "having lit", Grammar_codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "κρύπτην", Transliteration = "kryptēn", Gloss = "a cellar", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "into a cellar"
                },
                new Word { Greek = "τίθησιν", Transliteration = "tithēsin", Gloss = "puts", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὐδὲ", Transliteration = "oude", Gloss = "nor", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "under", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μόδιον", Transliteration = "modion", Gloss = "basket", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "under a basket"
                },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "upon", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "λυχνίαν", Transliteration = "lychnian", Gloss = "lampstand", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "upon the lampstand"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "those", Grammar_codes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "εἰσπορευόμενοι", Transliteration = "eisporeuomenoi", Gloss = "entering", Grammar_codes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "those who enter"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "φῶς", Transliteration = "phōs", Gloss = "light", Grammar_codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the light"
                        },
                        new Word { Greek = "βλέπωσιν", Transliteration = "blepōsin", Gloss = "may see", Grammar_codes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "so that those who enter may see the light"
                }
            },
            Translation = "No one after lighting a lamp puts it in a cellar or under a basket, but on a lampstand, so that those who enter may see the light."
        },
        // Verse 34
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
                        new Word { Greek = "Ὁ", Transliteration = "Ho", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "λύχνος", Transliteration = "lychnos", Gloss = "lamp", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", Grammar_codes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σώματός", Transliteration = "sōmatos", Gloss = "body", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the body"
                        }
                    },
                    Translation = "The lamp of the body"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὀφθαλμός", Transliteration = "ophthalmos", Gloss = "eye", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "your", Grammar_codes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your eye"
                }
            },
            Translation = "The lamp of the body is your eye."
        },
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
                        new Word { Greek = "ὅταν", Transliteration = "hotan", Gloss = "whenever", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὀφθαλμός", Transliteration = "ophthalmos", Gloss = "eye", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "σου", Transliteration = "sou", Gloss = "your", Grammar_codes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "your eye"
                        },
                        new Word { Greek = "ἁπλοῦς", Transliteration = "haplous", Gloss = "clear", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ᾖ", Transliteration = "ē", Gloss = "is", Grammar_codes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "whenever your eye is clear"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅλον", Transliteration = "holon", Gloss = "all", Grammar_codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σῶμά", Transliteration = "sōma", Gloss = "body", Grammar_codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "your", Grammar_codes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your whole body"
                },
                new Word { Greek = "φωτεινόν", Transliteration = "phōteinon", Gloss = "full of light", Grammar_codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "when your eye is healthy, your whole body also is full of light."
        },
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
                        new Word { Greek = "ἐπὰν", Transliteration = "epan", Gloss = "when", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πονηρὸς", Transliteration = "ponēros", Gloss = "evil", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ᾖ", Transliteration = "ē", Gloss = "is", Grammar_codes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "but when it is evil"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σῶμά", Transliteration = "sōma", Gloss = "body", Grammar_codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "your", Grammar_codes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your body"
                },
                new Word { Greek = "σκοτεινόν", Transliteration = "skoteinon", Gloss = "full of darkness", Grammar_codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" }
            },
            Translation = "but when it is evil, your body also is full of darkness."
        },
        // Verse 35
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "σκόπει", Transliteration = "skopei", Gloss = "watch out", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "lest", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "φῶς", Transliteration = "phōs", Gloss = "light", Grammar_codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the (one)", Grammar_codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "σοὶ", Transliteration = "soi", Gloss = "you", Grammar_codes = new List<string> { "PRON", "DAT", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "which is in you"
                        }
                    },
                    Translation = "the light in you"
                },
                new Word { Greek = "σκότος", Transliteration = "skotos", Gloss = "darkness", Grammar_codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἐστίν", Transliteration = "estin", Gloss = "is", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Therefore watch out lest the light in you is darkness."
        },
        // Verse 36
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
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σῶμά", Transliteration = "sōma", Gloss = "body", Grammar_codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "σου", Transliteration = "sou", Gloss = "your", Grammar_codes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "your body"
                        },
                        new Word { Greek = "ὅλον", Transliteration = "holon", Gloss = "whole", Grammar_codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "φωτεινόν", Transliteration = "phōteinon", Gloss = "full of light", Grammar_codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἔχον", Transliteration = "echon", Gloss = "having", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "μέρος", Transliteration = "meros", Gloss = "part", Grammar_codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "τι", Transliteration = "ti", Gloss = "any", Grammar_codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "part" },
                                        new Word { Greek = "σκοτεινόν", Transliteration = "skoteinon", Gloss = "dark", Grammar_codes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "any dark part"
                                }
                            },
                            Translation = "having no part dark"
                        }
                    },
                    Translation = "If therefore your whole body is full of light, having no part dark"
                },
                new Word { Greek = "ἔσται", Transliteration = "estai", Gloss = "it will be", Grammar_codes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "φωτεινὸν", Transliteration = "phōteinon", Gloss = "full of light", Grammar_codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ὅλον", Transliteration = "holon", Gloss = "entirely", Grammar_codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὅταν", Transliteration = "hotan", Gloss = "when", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "λύχνος", Transliteration = "lychnos", Gloss = "lamp", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the lamp"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "with the", Grammar_codes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀστραπῇ", Transliteration = "astrapē", Gloss = "shining", Grammar_codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "with its rays"
                        },
                        new Word { Greek = "φωτίζῃ", Transliteration = "phōtizē", Gloss = "illumines", Grammar_codes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "σε", Transliteration = "se", Gloss = "you", Grammar_codes = new List<string> { "PRON", "ACC", "2P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "as when the lamp illumines you with its rays"
                }
            },
            Translation = "If therefore your whole body is full of light, having no part dark, it will be entirely bright, as when the lamp illumines you with its rays."
        },
        // Verse 37
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "TEMP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἐν", Transliteration = "En", Gloss = "In", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", Grammar_codes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "λαλῆσαι", Transliteration = "lalēsai", Gloss = "speaking", Grammar_codes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "while he was speaking"
                        }
                    },
                    Translation = "Now while he was speaking"
                },
                new Word { Greek = "ἐρωτᾷ", Transliteration = "erōta", Gloss = "asks", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", Grammar_codes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "Φαρισαῖος", Transliteration = "Pharisaios", Gloss = "a Pharisee", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπως", Transliteration = "hopōs", Gloss = "that", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀριστήσῃ", Transliteration = "aristēsē", Gloss = "he might dine", Grammar_codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παρ᾽", Transliteration = "par'", Gloss = "with", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", Grammar_codes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "with him"
                        }
                    },
                    Translation = "to dine with him"
                }
            },
            Translation = "Now while he was speaking, a Pharisee asked him to dine with him."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰσελθὼν", Transliteration = "eiselthōn", Gloss = "having entered", Grammar_codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀνέπεσεν", Transliteration = "anepesen", Gloss = "he reclined", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "And having entered, he reclined at table."
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Φαρισαῖος", Transliteration = "Pharisaios", Gloss = "Pharisee", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "But the Pharisee"
                },
                new Word { Greek = "ἰδὼν", Transliteration = "idōn", Gloss = "having seen", Grammar_codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἐθαύμασεν", Transliteration = "ethaumasen", Gloss = "was amazed", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "πρῶτον", Transliteration = "prōton", Gloss = "first", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐβαπτίσθη", Transliteration = "ebaptisthē", Gloss = "he washed", Grammar_codes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸ", Transliteration = "pro", Gloss = "before", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀρίστου", Transliteration = "aristou", Gloss = "dinner", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "before the dinner"
                        }
                    },
                    Translation = "that he did not first wash before the dinner"
                }
            },
            Translation = "But the Pharisee was amazed when he saw that he did not first wash before the dinner."
        },
        // Verse 39
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "then", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Lord"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him", Grammar_codes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "to him"
                }
            },
            Translation = "Then the Lord said to him,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you", Grammar_codes = new List<string> { "PRON", "NOM", "2P", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "Φαρισαῖοι", Transliteration = "Pharisaioi", Gloss = "Pharisees", Grammar_codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "you Pharisees"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἔξωθεν", Transliteration = "exōthen", Gloss = "outside", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", Grammar_codes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ποτηρίου", Transliteration = "potēriou", Gloss = "cup", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πίνακος", Transliteration = "pinakos", Gloss = "platter", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the outside of the cup and the platter"
                },
                new Word { Greek = "καθαρίζετε", Transliteration = "katharizete", Gloss = "clean", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "Now you Pharisees clean the outside of the cup and the platter,"
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
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the (part)", Grammar_codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἔσωθεν", Transliteration = "esōthen", Gloss = "inside", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", Grammar_codes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "but your inside"
                },
                new Word { Greek = "γέμει", Transliteration = "gemei", Gloss = "is full", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἁρπαγῆς", Transliteration = "harpagēs", Gloss = "of greed", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πονηρίας", Transliteration = "ponērias", Gloss = "evil", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "of greed and evil"
                }
            },
            Translation = "but your inside is full of greed and evil."
        },
        // Verse 40
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἄφρονες", Transliteration = "aphrones", Gloss = "Fools", Grammar_codes = new List<string> { "ADJ", "VOC", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the (one)", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ποιήσας", Transliteration = "poiēsas", Gloss = "having made", Grammar_codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἔξωθεν", Transliteration = "exōthen", Gloss = "outside", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the outside"
                        }
                    },
                    Translation = "He who made the outside"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἔσωθεν", Transliteration = "esōthen", Gloss = "inside", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the inside"
                },
                new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen", Gloss = "did make", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "You fools! Did not He who made the outside make the inside also?"
        }
    };
}

/*
Constructions identified:
- Articular Infinitive (En to lalesai): Luke 11:37
- Dative of Instrument (te astrape): Luke 11:36
*/
