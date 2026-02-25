private static List<object> GetChapter10()
{
    // Matthew 10:25-32
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀρκετὸν", Transliteration = "arketon", Gloss = "enough", Grammar_Codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", Grammar_Codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μαθητῇ", Transliteration = "mathētē", Gloss = "disciple", Grammar_Codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "for the disciple"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γένηται", Transliteration = "genētai", Gloss = "he might become", Grammar_Codes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "διδάσκαλος", Transliteration = "didaskalos", Gloss = "teacher", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "his teacher"
                        }
                    },
                    Translation = "that he might be as his teacher"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δοῦλος", Transliteration = "doulos", Gloss = "servant", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the servant"
                },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "lord", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "his lord"
                }
            },
            Translation = "It is enough for the disciple that he be as his teacher, and the servant as his lord."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "οἰκοδεσπότην", Transliteration = "oikodespotēn", Gloss = "master of the house", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the master of the house"
                },
                new Word { Greek = "Βεελζεβοὺλ", Transliteration = "Beelzeboul", Gloss = "Beelzebul", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἐπεκάλεσαν", Transliteration = "epekalesan", Gloss = "they called", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "πόσῳ", Transliteration = "posō", Gloss = "how much", Grammar_Codes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "q" },
                new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "more", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "οἰκιακοὺς", Transliteration = "oikiakous", Gloss = "members of the household", Grammar_Codes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "the members of his household"
                }
            },
            Translation = "If they have called the master of the house Beelzebul, how much more those of his household!"
        },

        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Μὴ", Transliteration = "Mē", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "φοβηθῆτε", Transliteration = "phobēthēte", Gloss = "fear", Grammar_Codes = new List<string> { "V", "AOR", "PASS", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτούς", Transliteration = "autous", Gloss = "them", Grammar_Codes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "prep" }
            },
            Translation = "Therefore do not fear them;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐδὲν", Transliteration = "ouden", Gloss = "nothing", Grammar_Codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "κεκαλυμμένον", Transliteration = "kekalymmenon", Gloss = "covered", Grammar_Codes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which", Grammar_Codes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀποκαλυφθήσεται", Transliteration = "apokalyphthēsetai", Gloss = "will be revealed", Grammar_Codes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "which will not be revealed"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κρυπτὸν", Transliteration = "krypton", Gloss = "hidden", Grammar_Codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which", Grammar_Codes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "γνωσθήσεται", Transliteration = "gnōsthēsetai", Gloss = "will be known", Grammar_Codes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "which will not be known"
                }
            },
            Translation = "for nothing is covered that will not be revealed, and hidden that will not be known."
        },

        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what", Grammar_Codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I say", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", Grammar_Codes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", Grammar_Codes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σκοτίᾳ", Transliteration = "skotia", Gloss = "darkness", Grammar_Codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in the darkness"
                        }
                    },
                    Translation = "What I tell you in the darkness"
                },
                new Word { Greek = "εἴπατε", Transliteration = "eipate", Gloss = "speak", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", Grammar_Codes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "φωτί", Transliteration = "phōti", Gloss = "light", Grammar_Codes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in the light"
                }
            },
            Translation = "What I tell you in the darkness, speak in the light;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what", Grammar_Codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "οὖς", Transliteration = "ous", Gloss = "ear", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "into the ear"
                        },
                        new Word { Greek = "ἀκούετε", Transliteration = "akouete", Gloss = "you hear", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "and what you hear in the ear"
                },
                new Word { Greek = "κηρύξατε", Transliteration = "kēryxate", Gloss = "preach", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "on", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "δωμάτων", Transliteration = "dōmatōn", Gloss = "housetops", Grammar_Codes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "on the housetops"
                }
            },
            Translation = "and what you hear in the ear, preach on the housetops."
        },

        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "φοβεῖσθε", Transliteration = "phobeisthe", Gloss = "fear", Grammar_Codes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the [ones]", Grammar_Codes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀποκτεννόντων", Transliteration = "apoktennontōn", Gloss = "killing", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "σῶμα", Transliteration = "sōma", Gloss = "body", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the body"
                                }
                            },
                            Translation = "those who kill the body"
                        }
                    },
                    Translation = "from those who kill the body"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "ψυχὴν", Transliteration = "psychēn", Gloss = "soul", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "but the soul"
                        },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δυναμένων", Transliteration = "dynamenōn", Gloss = "being able", Grammar_Codes = new List<string> { "V", "PRES", "MID", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἀποκτεῖναι", Transliteration = "apokteinai", Gloss = "to kill", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "but are not able to kill the soul"
                }
            },
            Translation = "And do not fear those who kill the body but cannot kill the soul."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "φοβεῖσθε", Transliteration = "phobeisthe", Gloss = "fear", Grammar_Codes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "rather", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the [one]", Grammar_Codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δυνάμενον", Transliteration = "dynamenon", Gloss = "being able", Grammar_Codes = new List<string> { "V", "PRES", "MID", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "both", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "ψυχὴν", Transliteration = "psychēn", Gloss = "soul", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "σῶμα", Transliteration = "sōma", Gloss = "body", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἀπολέσαι", Transliteration = "apolesai", Gloss = "to destroy", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "γεέννῃ", Transliteration = "geennē", Gloss = "hell", Grammar_Codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "in hell"
                                }
                            },
                            Translation = "to destroy both soul and body in hell"
                        }
                    },
                    Translation = "the one who is able to destroy both soul and body in hell"
                }
            },
            Translation = "Rather fear him who is able to destroy both soul and body in hell."
        },

        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐχὶ", Transliteration = "ouchi", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δύο", Transliteration = "dyo", Gloss = "two", Grammar_Codes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "στρουθία", Transliteration = "strouthia", Gloss = "sparrows", Grammar_Codes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "two sparrows"
                },
                new Word { Greek = "ἀσσαρίου", Transliteration = "assariou", Gloss = "for a penny", Grammar_Codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "πωλεῖται", Transliteration = "pōleitai", Gloss = "are sold", Grammar_Codes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Are not two sparrows sold for a penny?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἓν", Transliteration = "hen", Gloss = "one", Grammar_Codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "of", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "them", Grammar_Codes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "of them"
                        }
                    },
                    Translation = "one of them"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "πεσεῖται", Transliteration = "peseitai", Gloss = "will fall", Grammar_Codes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "on", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γῆν", Transliteration = "gēn", Gloss = "ground", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "on the ground"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄνευ", Transliteration = "aneu", Gloss = "without", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πατρὸς", Transliteration = "patros", Gloss = "Father", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", Grammar_Codes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "your Father"
                        }
                    },
                    Translation = "apart from your Father"
                }
            },
            Translation = "And not one of them will fall to the ground apart from your Father."
        },

        // Verse 30
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "your", Grammar_Codes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "even", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἱ", Transliteration = "hai", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "F", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "τρίχες", Transliteration = "triches", Gloss = "hairs", Grammar_Codes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κεφαλῆς", Transliteration = "kephalēs", Gloss = "head", Grammar_Codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the head"
                        }
                    },
                    Translation = "the hairs of the head"
                },
                new Word { Greek = "πᾶσαι", Transliteration = "pasai", Gloss = "all", Grammar_Codes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἠριθμημέναι", Transliteration = "ērithmēmenai", Gloss = "numbered", Grammar_Codes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "F", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "εἰσίν", Transliteration = "eisin", Gloss = "are", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "But even the hairs of your head are all numbered."
        },

        // Verse 31
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "φοβεῖσθε", Transliteration = "phobeisthe", Gloss = "fear", Grammar_Codes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πολλῶν", Transliteration = "pollōn", Gloss = "many", Grammar_Codes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "στρουθίων", Transliteration = "strouthiōn", Gloss = "sparrows", Grammar_Codes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "than many sparrows"
                },
                new Word { Greek = "διαφέρετε", Transliteration = "diapherete", Gloss = "you are worth more", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you", Grammar_Codes = new List<string> { "PRON", "NOM", "2P", "P" }, PartOfSpeech = "prep" }
            },
            Translation = "Fear not, therefore; you are of more value than many sparrows."
        },

        // Verse 32
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Πᾶς", Transliteration = "Pas", Gloss = "everyone", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὅστις", Transliteration = "hostis", Gloss = "whoever", Grammar_Codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ὁμολογήσει", Transliteration = "homologēsei", Gloss = "shall confess", Grammar_Codes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἐμοὶ", Transliteration = "emoi", Gloss = "me", Grammar_Codes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "in me"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔμπροσθεν", Transliteration = "emprosthen", Gloss = "before", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἀνθρώπων", Transliteration = "anthrōpōn", Gloss = "men", Grammar_Codes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "men"
                                }
                            },
                            Translation = "before men"
                        }
                    },
                    Translation = "Everyone therefore who confesses me before men"
                },
                new Word { Greek = "ὁμολογήσω", Transliteration = "homologēsō", Gloss = "I will confess", Grammar_Codes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "κἀγὼ", Transliteration = "kagō", Gloss = "I also", Grammar_Codes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", Grammar_Codes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "in him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔμπροσθεν", Transliteration = "emprosthen", Gloss = "before", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πατρός", Transliteration = "patros", Gloss = "Father", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", Grammar_Codes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the [one]", Grammar_Codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", Grammar_Codes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                                new Word { Greek = "οὐρανοῖς", Transliteration = "ouranois", Gloss = "heavens", Grammar_Codes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "in the heavens"
                                        }
                                    },
                                    Translation = "who is in the heavens"
                                }
                            },
                            Translation = "my Father who is in the heavens"
                        }
                    },
                    Translation = "before my Father who is in the heavens"
                }
            },
            Translation = "Everyone therefore who confesses me before men, I also will confess him before my Father who is in the heavens."
        }
    };
}

/*
Constructions identified:
- PERIPH: Matthew 10:30 (ἠριθμημέναι εἰσίν)
*/
