private static List<object> GetChapter5()
{
    // 1 Timothy 5:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Χήρα", Transliteration = "", Gloss = "widow", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "A widow"
                        },
                        new Word { Greek = "καταλεγέσθω", Transliteration = "", Gloss = "to put on a list", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IMP", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "Let a widow be enrolled"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PRT", "NEG" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔλαττον", Transliteration = "", Gloss = "lesser", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐτῶν", Transliteration = "", Gloss = "year", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ἑξήκοντα", Transliteration = "", Gloss = "sixty", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "of sixty years"
                                }
                            },
                            Translation = "less"
                        },
                        new Word { Greek = "γεγονυῖα", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "having been not less than sixty years old"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἑνὸς", Transliteration = "", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἀνδρὸς", Transliteration = "", Gloss = "man", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of one husband"
                        },
                        new Word { Greek = "γυνή", Transliteration = "", Gloss = "woman", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the wife of one husband"
                }
            },
            Translation = "Let a widow be enrolled if she is not less than sixty years old, having been the wife of one husband,"
        },

        // Verse 10
        // (continues verse 9 grammatically as qualifications)
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
                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔργοις", Transliteration = "", Gloss = "work", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "καλοῖς", Transliteration = "", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "good works"
                        }
                    },
                    Translation = "in good works"
                },
                new Word { Greek = "μαρτυρουμένη", Transliteration = "", Gloss = "to testify", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" }
            },
            Translation = "having a reputation for good works"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐτεκνοτρόφησεν", Transliteration = "", Gloss = "to bring up children", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "if she has brought up children"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐξενοδόχησεν", Transliteration = "", Gloss = "to show hospitality", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "if she has shown hospitality"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἁγίων", Transliteration = "", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "πόδας", Transliteration = "", Gloss = "foot", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the feet of the saints"
                        },
                        new Word { Greek = "ἔνιψεν", Transliteration = "", Gloss = "to wash", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "she has washed the feet of the saints"
                }
            },
            Translation = "if she has washed the feet of the saints"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θλιβομένοις", Transliteration = "", Gloss = "to press upon", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἐπήρκεσεν", Transliteration = "", Gloss = "to help", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "she has assisted the afflicted"
                }
            },
            Translation = "if she has assisted the afflicted"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παντὶ", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἔργῳ", Transliteration = "", Gloss = "work", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἀγαθῷ", Transliteration = "", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "to every good work"
                        },
                        new Word { Greek = "ἐπηκολούθησεν", Transliteration = "", Gloss = "to follow after", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "she has devoted herself to every good work"
                }
            },
            Translation = "if she has devoted herself to every good work"
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "νεωτέρας", Transliteration = "", Gloss = "new", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "χήρας", Transliteration = "", Gloss = "widow", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "younger widows"
                        },
                        new Word { Greek = "παραιτοῦ", Transliteration = "", Gloss = "to request", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "But refuse younger widows"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅταν", Transliteration = "", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γὰρ", Transliteration = "", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καταστρηνιάσωσιν", Transliteration = "", Gloss = "to be filled with desires that conflict with dedication to someone", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "against Christ"
                        }
                    },
                    Translation = "for when they feel sensual desires against Christ"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γαμεῖν", Transliteration = "", Gloss = "to marry", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "θέλουσιν", Transliteration = "", Gloss = "to will", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "they want to marry"
                }
            },
            Translation = "But refuse younger widows, for when their sensual desires alienate them from Christ, they want to marry,"
        },

        // Verse 12
        // (continues verse 11 sentence structure)
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "ἔχουσαι", Transliteration = "", Gloss = "to have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "F", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "κρίμα", Transliteration = "", Gloss = "judgment", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πρώτην", Transliteration = "", Gloss = "first", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "πίστιν", Transliteration = "", Gloss = "faith", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "their former faith"
                        },
                        new Word { Greek = "ἠθέτησαν", Transliteration = "", Gloss = "to reject", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "because they have set aside their previous pledge"
                }
            },
            Translation = "incurring judgment because they have set aside their previous pledge."
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἅμα", Transliteration = "", Gloss = "together", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀργαὶ", Transliteration = "", Gloss = "idle", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "μανθάνουσιν", Transliteration = "", Gloss = "to learn", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "they learn to be idlers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περιερχόμεναι", Transliteration = "", Gloss = "to go around", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "F", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "οἰκίας", Transliteration = "", Gloss = "house", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the houses"
                        }
                    },
                    Translation = "going about from house to house"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" }, // Continuation/Contrast
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PRT", "NEG" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μόνον", Transliteration = "", Gloss = "only", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀργαὶ", Transliteration = "", Gloss = "idle", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἀλλὰ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "φλύαροι", Transliteration = "", Gloss = "gossipy", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "περίεργοι", Transliteration = "", Gloss = "meddlesome", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "λαλοῦσαι", Transliteration = "", Gloss = "to speak", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "F", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὰ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PTCP" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "μὴ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PRT", "NEG" }, PartOfSpeech = "prep" },
                                                new Word { Greek = "δέοντα", Transliteration = "", Gloss = "it is a must", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "N", "P" }, PartOfSpeech = "v" }
                                            },
                                            Translation = "what they should not"
                                        }
                                    },
                                    Translation = "what they should not"
                                }
                            },
                            Translation = "saying what they should not"
                        }
                    },
                    Translation = "and not only idlers, but also gossips and busybodies, saying what they should not"
                }
            },
            Translation = "And besides that, they learn to be idlers, going about from house to house, and not only idlers, but also gossips and busybodies, saying what they should not."
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Βούλομαι", Transliteration = "", Gloss = "to wish", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "οὖν", Transliteration = "", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "νεωτέρας", Transliteration = "", Gloss = "new", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "γαμεῖν", Transliteration = "", Gloss = "to marry", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "τεκνογονεῖν", Transliteration = "", Gloss = "to have children", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "οἰκοδεσποτεῖν", Transliteration = "", Gloss = "to manage one's home", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "younger widows to marry, bear children, manage their households"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" }, // Purpose/Result
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "μηδεμίαν", Transliteration = "", Gloss = "no one", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "ἀφορμὴν", Transliteration = "", Gloss = "opportunity", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "no occasion"
                                },
                                new Word { Greek = "διδόναι", Transliteration = "", Gloss = "to give", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῷ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἀντικειμένῳ", Transliteration = "", Gloss = "to be an opponent", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "DAT", "M", "S" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "to the adversary"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" }, // "for the sake of reviling"
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "λοιδορίας", Transliteration = "", Gloss = "insult", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "χάριν", Transliteration = "", Gloss = "therefore", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "for slander"
                                }
                            },
                            Translation = "and give the adversary no occasion for slander"
                        }
                    },
                    Translation = "So I would have younger widows marry, bear children, manage their households, and give the adversary no occasion for slander."
                }
            },
            Translation = "So I would have younger widows marry, bear children, manage their households, and give the adversary no occasion for slander."
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἤδη", Transliteration = "", Gloss = "already", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "γάρ", Transliteration = "", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τινες", Transliteration = "", Gloss = "someone", GrammarCodes = new List<string> { "PART", "NOM", "F", "P" }, PartOfSpeech = "part" },
                        new Word { Greek = "ἐξετράπησαν", Transliteration = "", Gloss = "to turn away", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὀπίσω", Transliteration = "", Gloss = "behind", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "σατανᾶ", Transliteration = "", Gloss = "Satan", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "Satan"
                                }
                            },
                            Translation = "after Satan"
                        }
                    },
                    Translation = "some have turned away to follow Satan"
                }
            },
            Translation = "For some have already turned away to follow Satan."
        },

        // Verse 16
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
                        new Word { Greek = "εἴ", Transliteration = "", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τις", Transliteration = "", Gloss = "someone", GrammarCodes = new List<string> { "PART", "NOM", "F", "S" }, PartOfSpeech = "part" },
                                new Word { Greek = "πιστὴ", Transliteration = "", Gloss = "faithful", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "any believing woman"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "VERB_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔχει", Transliteration = "", Gloss = "to have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "χήρας", Transliteration = "", Gloss = "widow", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "has widows"
                        }
                    },
                    Translation = "If any believing woman has relatives who are widows"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπαρκείτω", Transliteration = "", Gloss = "to help", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐταῖς", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "DAT", "F", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "let her care for them"
                },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PRT", "NEG" }, PartOfSpeech = "prep" },
                        new Word { Greek = "βαρείσθω", Transliteration = "", Gloss = "to be burdened", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IMP", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐκκλησία", Transliteration = "", Gloss = "church", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the church"
                        }
                    },
                    Translation = "let the church not be burdened"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ταῖς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὄντως", Transliteration = "", Gloss = "really", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                new Word { Greek = "χήραις", Transliteration = "", Gloss = "widow", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "those who are truly widows"
                        },
                        new Word { Greek = "ἐπαρκέσῃ", Transliteration = "", Gloss = "to help", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "so that it may care for those who are truly widows"
                }
            },
            Translation = "If any believing woman has relatives who are widows, let her care for them. Let the church not be burdened, so that it may care for those who are truly widows."
        }
    };
}