private static List<object> GetChapter25()
{
    // Acts 25:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συνελθόντων", Transliteration = "synelthontōn", Gloss = "to come together", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "they", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "prep" }, // Correction: PRON
                        new Word { Greek = "ἐνθάδε", Transliteration = "enthade", Gloss = "here", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" } // Correction: ADV
                    },
                    Translation = "Therefore when they had come together here"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀναβολὴν", Transliteration = "anabolēn", Gloss = "delay", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μηδεμίαν", Transliteration = "mēdemian", Gloss = "no one", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "no delay"
                },
                new Word { Greek = "ποιησάμενος", Transliteration = "poiēsamenos", Gloss = "having made", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἑξῆς", Transliteration = "hexēs", Gloss = "next", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                    },
                    Translation = "on the next day"
                },
                new Word { Greek = "καθίσας", Transliteration = "kathisas", Gloss = "having sat", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "βήματος", Transliteration = "bēmatos", Gloss = "judicial court", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the judgment seat"
                        }
                    },
                    Translation = "on the judgment seat"
                },
                new Word { Greek = "ἐκέλευσα", Transliteration = "ekeleusa", Gloss = "I ordered", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀχθῆναι", Transliteration = "achthēnai", Gloss = "to be brought", GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἄνδρα", Transliteration = "andra", Gloss = "man", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the man"
                        }
                    },
                    Translation = "the man to be brought"
                }
            },
            Translation = "Therefore, when they had come together here, without any delay, on the next day I sat on the judgment seat and ordered the man to be brought."
        },
        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "whom", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "Concerning whom"
                },
                new Word { Greek = "σταθέντες", Transliteration = "statherntes", Gloss = "having stood up", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "κατήγοροι", Transliteration = "katēgoroi", Gloss = "accusers", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the accusers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐδεμίαν", Transliteration = "oudemian", Gloss = "no", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "αἰτίαν", Transliteration = "aitian", Gloss = "charge", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "no charge"
                },
                new Word { Greek = "ἔφερον", Transliteration = "epheron", Gloss = "were bringing", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "of which", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "prep" }, // Correction: PRON
                        new Word { Greek = "ὑπενόουν", Transliteration = "hypenooun", Gloss = "was supposing", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "πονηρῶν", Transliteration = "ponērōn", Gloss = "evil", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "of such evil things as I was supposing"
                }
            },
            Translation = "When the accusers stood up, they brought no charge against him of such evils as I supposed."
        },
        // Verse 19
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
                        new Word { Greek = "ζητήματα", Transliteration = "zētēmata", Gloss = "questions", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "δέ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τινα", Transliteration = "tina", Gloss = "certain", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "part" } // Correction: PRON
                    },
                    Translation = "But certain questions"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἰδίας", Transliteration = "idias", Gloss = "their own", GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "δεισιδαιμονίας", Transliteration = "deisidaimonias", Gloss = "religion", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "their own religion"
                        }
                    },
                    Translation = "about their own religion"
                },
                new Word { Greek = "εἶχον", Transliteration = "eichon", Gloss = "they had", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" } // Correction: PRON
                    },
                    Translation = "with him"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περί", Transliteration = "peri", Gloss = "about", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τινος", Transliteration = "tinos", Gloss = "a certain", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "part" }, // Correction: PRON
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τεθνηκότος", Transliteration = "tethnēkotos", Gloss = "having died", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "a certain Jesus, who was dead"
                        }
                    },
                    Translation = "and about a certain Jesus, who was dead"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "whom", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἔφασκεν", Transliteration = "ephasken", Gloss = "was claiming", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Παῦλος", Transliteration = "Paulos", Gloss = "Paul", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Paul"
                        },
                        new Word { Greek = "ζῆν", Transliteration = "zēn", Gloss = "to be alive", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "whom Paul claimed to be alive"
                }
            },
            Translation = "but they had certain questions against him about their own religion and about a certain Jesus, who had died, whom Paul claimed to be alive."
        },
        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀπορούμενος", Transliteration = "aporoumenos", Gloss = "being at a loss", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "prep" }, // Correction: PRON
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τούτων", Transliteration = "toutōn", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "adv" } // Correction: PRON
                            },
                            Translation = "about these things"
                        },
                        new Word { Greek = "ζήτησιν", Transliteration = "zētēsin", Gloss = "inquiry", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the inquiry about these things"
                },
                new Word { Greek = "ἔλεγον", Transliteration = "elegon", Gloss = "I was saying", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "prep" }, // Correction: CONJ
                        new Word { Greek = "βούλοιτο", Transliteration = "bouloito", Gloss = "he would wish", GrammarCodes = new List<string> { "V", "PRES", "MID", "OPT", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "πορεύεσθαι", Transliteration = "poreuesthai", Gloss = "to go", GrammarCodes = new List<string> { "V", "PRES", "MID", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "Ἱεροσόλυμα", Transliteration = "Hierosolyma", Gloss = "Jerusalem", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "to Jerusalem"
                        },
                        new Word { Greek = "κἀκεῖ", Transliteration = "kakei", Gloss = "and there", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "κρίνεσθαι", Transliteration = "krinesthai", Gloss = "to be judged", GrammarCodes = new List<string> { "V", "PRES", "PASS", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τούτων", Transliteration = "toutōn", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "adv" } // Correction: PRON
                            },
                            Translation = "about these things"
                        }
                    },
                    Translation = "if he would be willing to go to Jerusalem and there be judged about these things"
                }
            },
            Translation = "Being at a loss how to investigate these things, I asked whether he would be willing to go to Jerusalem and there be judged about these matters."
        },
        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Παύλου", Transliteration = "Paulou", Gloss = "Paul", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Paul"
                        },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐπικαλεσαμένου", Transliteration = "epikalesamenou", Gloss = "having appealed", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "But when Paul had appealed"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τηρηθῆναι", Transliteration = "tērēthēnai", Gloss = "to be kept", GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" } // Correction: PRON
                    },
                    Translation = "that he be kept"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "Σεβαστοῦ", Transliteration = "Sebastou", Gloss = "Augustus", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "the Emperor's"
                                },
                                new Word { Greek = "διάγνωσιν", Transliteration = "diagnōsin", Gloss = "decision", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Emperor's decision"
                        }
                    },
                    Translation = "for the Emperor's decision"
                },
                new Word { Greek = "ἐκέλευσα", Transliteration = "ekeleusa", Gloss = "I ordered", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τηρεῖσθαι", Transliteration = "tēreisthai", Gloss = "to be kept", GrammarCodes = new List<string> { "V", "PRES", "PASS", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" } // Correction: PRON
                    },
                    Translation = "him to be kept"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "until", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "prep" }, // Correction: CONJ
                        new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "in which", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἀναπέμψω", Transliteration = "anapempsō", Gloss = "I might send", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" } // Correction: PRON
                    },
                    Translation = "until I might send him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "Καίσαρα", Transliteration = "Kaisara", Gloss = "Caesar", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to Caesar"
                }
            },
            Translation = "But when Paul had appealed to be kept for the decision of Augustus, I ordered him to be kept until I could send him to Caesar."
        },
        // Verse 22
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
                        new Word { Greek = "Ἀγρίππας", Transliteration = "Agrippas", Gloss = "Agrippa", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Agrippa"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "then", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Φῆστον", Transliteration = "Phēston", Gloss = "Festus", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Festus"
                        }
                    },
                    Translation = "to Festus"
                },
                new Word { Greek = "ἐβουλόμην", Transliteration = "eboulomēn", Gloss = "I was wishing", GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "myself", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "prep" }, // Correction: PRON
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀνθρώπου", Transliteration = "anthrōpou", Gloss = "man", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the man"
                        },
                        new Word { Greek = "ἀκοῦσαι", Transliteration = "akousai", Gloss = "to hear", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "to hear the man"
                }
            },
            Translation = "Then Agrippa said to Festus, \"I also would like to hear the man myself.\""
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 22)
                new Word { Greek = "αὔριον", Transliteration = "aurion", Gloss = "tomorrow", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }, // Correction: ADV
                new Word { Greek = "φησίν", Transliteration = "phēsin", Gloss = "he said", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἀκούσῃ", Transliteration = "akousē", Gloss = "you shall hear", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" } // Correction: PRON
            },
            Translation = "\"Tomorrow,\" he said, \"you shall hear him.\""
        },
        // Verse 23
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
                        new Word { Greek = "Τῇ", Transliteration = "Tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐπαύριον", Transliteration = "epaurion", Gloss = "next day", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                    },
                    Translation = "Therefore on the next day"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλθόντος", Transliteration = "elthontos", Gloss = "having come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Ἀγρίππα", Transliteration = "Agrippa", Gloss = "Agrippa", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Agrippa"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Βερνίκης", Transliteration = "Bernikēs", Gloss = "Bernice", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Bernice"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πολλῆς", Transliteration = "pollēs", Gloss = "much", GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "φαντασίας", Transliteration = "phantasias", Gloss = "pomp", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "great pomp"
                                }
                            },
                            Translation = "with great pomp"
                        }
                    },
                    Translation = "when Agrippa and Bernice had come with great pomp"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἰσελθόντων", Transliteration = "eiselthontōn", Gloss = "having entered", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀκροατήριον", Transliteration = "akroatērion", Gloss = "audience room", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the audience hall"
                        }
                    },
                    Translation = "into the audience hall"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σύν", Transliteration = "syn", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "both", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "χιλιάρχοις", Transliteration = "chiliarchois", Gloss = "military officers", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "commanders"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀνδράσιν", Transliteration = "andrasin", Gloss = "men", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "κατ᾽", Transliteration = "kat'", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "ἐξοχὴν", Transliteration = "exochēn", Gloss = "prominence", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of prominence"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "πόλεως", Transliteration = "poleōs", Gloss = "city", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the city"
                                }
                            },
                            Translation = "the prominent men of the city"
                        }
                    },
                    Translation = "with the commanders and the prominent men of the city"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κελεύσαντος", Transliteration = "keleusantos", Gloss = "having ordered", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Φήστου", Transliteration = "Phēstou", Gloss = "Festus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Festus"
                        }
                    },
                    Translation = "at the command of Festus"
                },
                new Word { Greek = "ἤχθη", Transliteration = "ēchthē", Gloss = "was brought", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Παῦλος", Transliteration = "Paulos", Gloss = "Paul", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Paul"
                }
            },
            Translation = "So on the next day, when Agrippa and Bernice had come with great pomp, and had entered the audience hall with the commanders and the prominent men of the city, at the command of Festus, Paul was brought in."
        },
        // Verse 24
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καί", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "φησιν", Transliteration = "phēsin", Gloss = "said", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Φῆστος", Transliteration = "Phēstos", Gloss = "Festus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Festus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἀγρίππα", Transliteration = "Agrippa", Gloss = "Agrippa", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "βασιλεῦ", Transliteration = "basileu", Gloss = "king", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "VOC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "συμπαρόντες", Transliteration = "symparontes", Gloss = "present with", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "VOC", "M", "P" }, PartOfSpeech = "v" },
                                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "us", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "P" }, PartOfSpeech = "prep" } // Correction: PRON
                            },
                            Translation = "who are present with us"
                        },
                        new Word { Greek = "ἄνδρες", Transliteration = "andres", Gloss = "men", GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "King Agrippa and all you men present with us"
                },
                new Word { Greek = "θεωρεῖτε", Transliteration = "theōreite", Gloss = "you see", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "τοῦτον", Transliteration = "touton", Gloss = "this man", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "adv" }, // Correction: PRON
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "whom", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἅπαν", Transliteration = "hapan", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πλῆθος", Transliteration = "plēthos", Gloss = "multitude", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "Ἰουδαίων", Transliteration = "Ioudaiōn", Gloss = "Jews", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "of the Jews"
                                }
                            },
                            Translation = "the whole multitude of the Jews"
                        },
                        new Word { Greek = "ἐνέτυχόν", Transliteration = "enetychon", Gloss = "petitioned", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "μοι", Transliteration = "moi", Gloss = "me", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "prep" }, // Correction: PRON
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τε", Transliteration = "te", Gloss = "both", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "Ἱεροσολύμοις", Transliteration = "Hierosolymois", Gloss = "Jerusalem", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "both in Jerusalem"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐνθάδε", Transliteration = "enthade", Gloss = "here", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "βοῶντες", Transliteration = "boōntes", Gloss = "crying out", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" }, // Correction: PART
                                new Word { Greek = "δεῖν", Transliteration = "dein", Gloss = "to be necessary", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" }, // Correction: PRON
                                new Word { Greek = "ζῆν", Transliteration = "zēn", Gloss = "to live", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "μηκέτι", Transliteration = "mēketi", Gloss = "no longer", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" } // Correction: ADV
                            },
                            Translation = "that he ought not to live any longer"
                        }
                    },
                    Translation = "about whom the whole multitude of the Jews petitioned me, both in Jerusalem and here, crying out that he ought not to live any longer"
                }
            },
            Translation = "And Festus said: \"King Agrippa and all men who are here present with us, you see this man about whom the whole multitude of the Jews petitioned me, both in Jerusalem and here, crying out that he ought not to live any longer.\""
        }
    };
}

/*
Constructions identified:
- GEN_ABS: Verse 17 (συνελθόντων... αὐτῶν)
- GEN_ABS: Verse 21 (Παύλου... ἐπικαλεσαμένου)
- GEN_ABS: Verse 23 (ἐλθόντος... Ἀγρίππα καὶ... Βερνίκης)
- GEN_ABS: Verse 23 (κελεύσαντος τοῦ Φήστου)
- VOC: Verse 24 (Ἀγρίππα βασιλεῦ καὶ πάντες... ἄνδρες)
*/
