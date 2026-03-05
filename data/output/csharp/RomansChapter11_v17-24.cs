private static List<object> GetChapter11()
{
    // Romans 11:17-24
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
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Εἰ", Transliteration = "Ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δέ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τινες", Transliteration = "tines", Gloss = "some", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "part" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κλάδων", Transliteration = "kladōn", Gloss = "branches", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the branches"
                                }
                            },
                            Translation = "some of the branches"
                        },
                        new Word { Greek = "ἐξεκλάσθησαν", Transliteration = "exeklasthēsan", Gloss = "were broken off", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "But if some of the branches were broken off"
                },
                new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀγριέλαιος", Transliteration = "agrielaios", Gloss = "wild olive tree", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὢν", Transliteration = "ōn", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "being a wild olive tree"
                },
                new Word { Greek = "ἐνεκεντρίσθης", Transliteration = "enekentristhēs", Gloss = "were grafted in", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "among them"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "συγκοινωνὸς", Transliteration = "synkoinōnos", Gloss = "a sharer", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ῥίζης", Transliteration = "rhizēs", Gloss = "root", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πιότητος", Transliteration = "piotētos", Gloss = "richness", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the richness"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐλαίας", Transliteration = "elaias", Gloss = "olive tree", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the olive tree"
                        }
                    },
                    Translation = "of the root of the richness of the olive tree"
                },
                new Word { Greek = "ἐγένου", Transliteration = "egenou", Gloss = "became", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "2P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "But if some of the branches were broken off, and you, being a wild olive tree, were grafted in among them and became a sharer of the root of the richness of the olive tree,"
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "do not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "κατακαυχῶ", Transliteration = "katakauchō", Gloss = "boast over", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "κλάδων", Transliteration = "kladōn", Gloss = "branches", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the branches"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "κατακαυχᾶσαι", Transliteration = "katakauchasai", Gloss = "you boast", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "but if you boast"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ῥίζαν", Transliteration = "rhizan", Gloss = "root", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the root"
                },
                new Word { Greek = "βαστάζεις", Transliteration = "bastazeis", Gloss = "bear", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ῥίζα", Transliteration = "rhiza", Gloss = "root", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the root"
                },
                new Word { Greek = "σέ", Transliteration = "se", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" }, PartOfSpeech = "prep" }
            },
            Translation = "Do not boast over the branches; but if you do boast, it is not you who support the root, but the root supports you."
        },

        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐρεῖς", Transliteration = "ereis", Gloss = "you will say", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐξεκλάσθησαν", Transliteration = "exeklasthēsan", Gloss = "were broken off", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κλάδοι", Transliteration = "kladoi", Gloss = "branches", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "branches"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐγκεντρισθῶ", Transliteration = "enkentristhō", Gloss = "might be grafted in", GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "1P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "in order that I might be grafted in"
                }
            },
            Translation = "You will say then, \"Branches were broken off in order that I might be grafted in.\""
        },

        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καλῶς", Transliteration = "kalōs", Gloss = "rightly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "for", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀπιστίᾳ", Transliteration = "apistia", Gloss = "unbelief", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "for their unbelief"
                },
                new Word { Greek = "ἐξεκλάσθησαν", Transliteration = "exeklasthēsan", Gloss = "they were broken off", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "by", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πίστει", Transliteration = "pistei", Gloss = "faith", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "by faith"
                },
                new Word { Greek = "ἕστηκας", Transliteration = "hestēkas", Gloss = "stand", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "do not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ὑψηλὰ", Transliteration = "hypsēla", Gloss = "haughty", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "φρόνει", Transliteration = "phronei", Gloss = "think", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "φοβοῦ", Transliteration = "phobou", Gloss = "fear", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Rightly so. They were broken off for their unbelief, but you stand by faith. Do not be haughty, but fear."
        },

        // Verse 21
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
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "God"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "φύσιν", Transliteration = "physin", Gloss = "nature", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "natural"
                                },
                                new Word { Greek = "κλάδων", Transliteration = "kladōn", Gloss = "branches", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the natural branches"
                        },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐφείσατο", Transliteration = "epheisato", Gloss = "did spare", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "For if God did not spare the natural branches"
                },
                new Word { Greek = "μή", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "πως", Transliteration = "pōs", Gloss = "somehow", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "οὐδὲ", Transliteration = "oude", Gloss = "neither", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "σοῦ", Transliteration = "sou", Gloss = "you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "φείσεται", Transliteration = "pheidsetai", Gloss = "will he spare", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "For if God did not spare the natural branches, neither will he spare you."
        },

        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἴδε", Transliteration = "ide", Gloss = "behold", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "interj" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χρηστότητα", Transliteration = "chrēstotēta", Gloss = "kindness", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀποτομίαν", Transliteration = "apotomian", Gloss = "severity", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the kindness and severity of God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "toward", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "on the one hand", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "those who", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "πεσόντας", Transliteration = "pesontas", Gloss = "fell", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "those who fell"
                        }
                    },
                    Translation = "toward those who fell"
                },
                new Word { Greek = "ἀποτομία", Transliteration = "apotomia", Gloss = "severity", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "toward", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but on the other hand", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σὲ", Transliteration = "se", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "but toward you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χρηστότης", Transliteration = "chrēstotēs", Gloss = "kindness", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the kindness of God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐπιμένῃς", Transliteration = "epimenēs", Gloss = "you continue", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "in", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "χρηστότητι", Transliteration = "chrēstotēti", Gloss = "kindness", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in his kindness"
                        }
                    },
                    Translation = "if you continue in his kindness"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπεὶ", Transliteration = "epei", Gloss = "otherwise", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐκκοπήσῃ", Transliteration = "ekkopēsē", Gloss = "will be cut off", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "otherwise you also will be cut off"
                }
            },
            Translation = "Note then the kindness and the severity of God: severity toward those who have fallen, but God's kindness toward you, provided you continue in his kindness. Otherwise you also will be cut off."
        },

        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "κἀκεῖνοι", Transliteration = "kakeinoi", Gloss = "and they", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐπιμένωσιν", Transliteration = "epimenōsin", Gloss = "they stay", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "in", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀπιστίᾳ", Transliteration = "apistia", Gloss = "unbelief", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in their unbelief"
                        }
                    },
                    Translation = "if they do not continue in their unbelief"
                },
                new Word { Greek = "ἐγκεντρισθήσονται", Transliteration = "enkentristhēsontai", Gloss = "will be grafted in", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "δυνατὸς", Transliteration = "dynatos", Gloss = "able", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "God"
                },
                new Word { Greek = "πάλιν", Transliteration = "palin", Gloss = "again", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐγκεντρίσαι", Transliteration = "enkentrisai", Gloss = "to graft in", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτούς", Transliteration = "autous", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "prep" }
            },
            Translation = "And even they, if they do not continue in their unbelief, will be grafted in, for God is able to graft them in again."
        },

        // Verse 24
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
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                                new Word { Greek = "φύσιν", Transliteration = "physin", Gloss = "nature", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "natural"
                                        },
                                        new Word { Greek = "ἀγριελαίου", Transliteration = "agrielaiou", Gloss = "wild olive tree", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the natural wild olive tree"
                                }
                            },
                            Translation = "from what is by nature a wild olive tree"
                        },
                        new Word { Greek = "ἐξεκόπης", Transliteration = "exekopēs", Gloss = "were cut off", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παρά", Transliteration = "para", Gloss = "contrary to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "φύσιν", Transliteration = "physin", Gloss = "nature", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "contrary to nature"
                        },
                        new Word { Greek = "ἐνεκεντρίσθης", Transliteration = "enekentristhēs", Gloss = "were grafted in", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "καλλιέλαιον", Transliteration = "kallielaion", Gloss = "cultivated olive tree", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "into a cultivated olive tree"
                        }
                    },
                    Translation = "For if you were cut from what is by nature a wild olive tree, and grafted, contrary to nature, into a cultivated olive tree"
                },
                new Word { Greek = "πόσῳ", Transliteration = "posō", Gloss = "how much", GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" }, PartOfSpeech = "q" },
                new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "more", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "οὗτοι", Transliteration = "houtoi", Gloss = "these", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "φύσιν", Transliteration = "physin", Gloss = "nature", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "natural"
                        }
                    },
                    Translation = "the natural branches"
                },
                new Word { Greek = "ἐγκεντρισθήσονται", Transliteration = "enkentristhēsontai", Gloss = "will be grafted", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "into their", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἰδίᾳ", Transliteration = "idia", Gloss = "own", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐλαίᾳ", Transliteration = "elaia", Gloss = "olive tree", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "into their own olive tree"
                }
            },
            Translation = "For if you were cut from what is by nature a wild olive tree, and grafted, contrary to nature, into a cultivated olive tree, how much more will these, the natural branches, be grafted back into their own olive tree."
        }
    };
}

/*
Constructions identified:
- COND_CLAUSE: v17, v18, v21, v22, v23, v24
- PTCP: v17 (ὢν), v22 (πεσόντας)
- PURPOSE_CLAUSE: v19 (ἵνα + subjunctive)
- CAUSAL_CLAUSE: v22 (ἐπεὶ)
- DAT_INSTR: v20 (τῇ ἀπιστίᾳ, τῇ πίστει)
*/
