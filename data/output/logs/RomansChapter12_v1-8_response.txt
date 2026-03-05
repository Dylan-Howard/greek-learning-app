private static List<object> GetChapter12()
{
    // Romans 12:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Παρακαλῶ", Transliteration = "Parakalō", Gloss = "I appeal to", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers", GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "οἰκτιρμῶν", Transliteration = "oiktirmōn", Gloss = "mercies", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "the mercies"
                        }
                    },
                    Translation = "by the mercies of God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παραστῆσαι", Transliteration = "parastēsai", Gloss = "to present", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "σώματα", Transliteration = "sōmata", Gloss = "bodies", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "your bodies"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "θυσίαν", Transliteration = "thysian", Gloss = "a sacrifice", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ζῶσαν", Transliteration = "zōsan", Gloss = "living", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "F", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "ἁγίαν", Transliteration = "hagian", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "εὐάρεστον", Transliteration = "euareston", Gloss = "acceptable", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "to God"
                                }
                            },
                            Translation = "a living sacrifice, holy and acceptable to God"
                        }
                    },
                    Translation = "to present your bodies as a living sacrifice, holy and acceptable to God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "λογικὴν", Transliteration = "logikēn", Gloss = "spiritual", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "λατρείαν", Transliteration = "latreian", Gloss = "worship", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "which is your spiritual worship"
                }
            },
            Translation = "I appeal to you therefore, brothers, by the mercies of God, to present your bodies as a living sacrifice, holy and acceptable to God, which is your spiritual worship."
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "συσχηματίζεσθε", Transliteration = "syschēmatizesthe", Gloss = "be conformed", GrammarCodes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "αἰῶνι", Transliteration = "aiōni", Gloss = "world", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "τούτῳ", Transliteration = "toutō", Gloss = "this", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "adv" }
                    },
                    Translation = "to this world"
                },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μεταμορφοῦσθε", Transliteration = "metamorphousthe", Gloss = "be transformed", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "by the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀνακαινώσει", Transliteration = "anakainōsei", Gloss = "renewal", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "νοὸς", Transliteration = "noos", Gloss = "mind", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the mind"
                        }
                    },
                    Translation = "by the renewal of the mind"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "so that", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δοκιμάζειν", Transliteration = "dokimazein", Gloss = "testing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τί", Transliteration = "ti", Gloss = "what [is]", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "interj" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θέλημα", Transliteration = "thelēma", Gloss = "will", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "what is the will of God"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγαθὸν", Transliteration = "agathon", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "εὐάρεστον", Transliteration = "euareston", Gloss = "acceptable", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "τέλειον", Transliteration = "teleion", Gloss = "perfect", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "what is good and acceptable and perfect"
                        }
                    },
                    Translation = "so that you may discern what is the will of God, what is good and acceptable and perfect"
                }
            },
            Translation = "Do not be conformed to this world, but be transformed by the renewal of your mind, that by testing you may discern what is the will of God, what is good and acceptable and perfect."
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Λέγω", Transliteration = "Legō", Gloss = "I say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "χάριτος", Transliteration = "charitos", Gloss = "grace", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "δοθείσης", Transliteration = "dotheisēs", Gloss = "given", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "GEN", "F", "S" }, PartOfSpeech = "v" },
                                        new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "given to me"
                                }
                            },
                            Translation = "the grace given to me"
                        }
                    },
                    Translation = "by the grace given to me"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παντὶ", Transliteration = "panti", Gloss = "to everyone", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "who", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὄντι", Transliteration = "onti", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "who is among you"
                        }
                    },
                    Translation = "to everyone who is among you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὑπερφρονεῖν", Transliteration = "hyperphronein", Gloss = "to think too highly", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παρ᾽", Transliteration = "par'", Gloss = "beyond", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                                        new Word { Greek = "δεῖ", Transliteration = "dei", Gloss = "it is necessary", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                        new Word { Greek = "φρονεῖν", Transliteration = "phronein", Gloss = "to think", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "what one ought to think"
                                }
                            },
                            Translation = "beyond what one ought to think"
                        },
                        new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "φρονεῖν", Transliteration = "phronein", Gloss = "to think", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "unto", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σωφρονεῖν", Transliteration = "sōphronein", Gloss = "sober judgment", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "with sober judgment"
                        }
                    },
                    Translation = "not to think of himself more highly than he ought to think, but to think with sober judgment"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἑκάστῳ", Transliteration = "hekastō", Gloss = "to each", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἐμέρισεν", Transliteration = "emerisen", Gloss = "assigned", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μέτρον", Transliteration = "metron", Gloss = "a measure", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "πίστεως", Transliteration = "pisteōs", Gloss = "of faith", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a measure of faith"
                        }
                    },
                    Translation = "each according as God has assigned a measure of faith"
                }
            },
            Translation = "For by the grace given to me I say to everyone among you not to think of himself more highly than he ought to think, but to think with sober judgment, each according to the measure of faith that God has assigned."
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καθάπερ", Transliteration = "kathaper", Gloss = "just as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἑνὶ", Transliteration = "heni", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "σώματι", Transliteration = "sōmati", Gloss = "body", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "one body"
                        }
                    },
                    Translation = "in one body"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πολλὰ", Transliteration = "polla", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "μέλη", Transliteration = "melē", Gloss = "members", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "many members"
                },
                new Word { Greek = "ἔχομεν", Transliteration = "echomen", Gloss = "we have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μέλη", Transliteration = "melē", Gloss = "members", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "αὐτὴν", Transliteration = "autēn", Gloss = "same", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "πρᾶξιν", Transliteration = "praxin", Gloss = "function", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the same function"
                },
                new Word { Greek = "ἔχει", Transliteration = "echei", Gloss = "have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "For as in one body we have many members, and the members all do not have the same function,"
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "so", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "πολλοὶ", Transliteration = "polloi", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "we, though many,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἓν", Transliteration = "hen", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "σῶμά", Transliteration = "sōma", Gloss = "body", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "one body"
                },
                new Word { Greek = "ἐσμεν", Transliteration = "esmen", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "Χριστῷ", Transliteration = "Christō", Gloss = "Christ", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in Christ"
                },
                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "and", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "individually", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καθ᾽", Transliteration = "kath'", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Word { Greek = "εἷς", Transliteration = "heis", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀλλήλων", Transliteration = "allēlōn", Gloss = "of one another", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μέλη", Transliteration = "melē", Gloss = "members", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "members one of another"
                }
            },
            Translation = "so we, though many, are one body in Christ, and individually members one of another."
        },

        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔχοντες", Transliteration = "echontes", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "χαρίσματα", Transliteration = "charismata", Gloss = "gifts", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "χάριν", Transliteration = "charin", Gloss = "grace", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "δοθεῖσαν", Transliteration = "dotheisan", Gloss = "given", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "ACC", "F", "S" }, PartOfSpeech = "v" },
                                        new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "P" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "given to us"
                                }
                            },
                            Translation = "the grace given to us"
                        }
                    },
                    Translation = "according to the grace given to us"
                },
                new Word { Greek = "διάφορα", Transliteration = "diaphora", Gloss = "differing", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "προφητείαν", Transliteration = "prophēteian", Gloss = "prophecy", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἀναλογίαν", Transliteration = "analogian", Gloss = "proportion", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "πίστεως", Transliteration = "pisteōs", Gloss = "faith", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "of faith"
                                        }
                                    },
                                    Translation = "the proportion of faith"
                                }
                            },
                            Translation = "according to the proportion of faith"
                        }
                    },
                    Translation = "if prophecy, let us prophesy according to the proportion of faith;"
                }
            },
            Translation = "Having gifts that differ according to the grace given to us, let us use them: if prophecy, in proportion to our faith;"
        },

        // Verse 7
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
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "διακονίαν", Transliteration = "diakonian", Gloss = "service", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "διακονίᾳ", Transliteration = "diakonia", Gloss = "service", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in our service"
                        }
                    },
                    Translation = "if service, in our serving;"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "διδάσκων", Transliteration = "didaskōn", Gloss = "one who teaches", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "the one who teaches"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "διδασκαλίᾳ", Transliteration = "didaskalia", Gloss = "teaching", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in his teaching"
                        }
                    },
                    Translation = "the one who teaches, in his teaching;"
                }
            },
            Translation = "if service, in our serving; the one who teaches, in his teaching;"
        },

        // Verse 8
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
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "παρακαλῶν", Transliteration = "parakalōn", Gloss = "one who exhorts", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "the one who exhorts"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "παρακλήσει", Transliteration = "paraklēsei", Gloss = "exhortation", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in his exhortation"
                        }
                    },
                    Translation = "the one who exhorts, in his exhortation;"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μεταδιδοὺς", Transliteration = "metadidous", Gloss = "one who contributes", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the one who contributes"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἁπλότητι", Transliteration = "haplotēti", Gloss = "generosity", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in generosity"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "προϊστάμενος", Transliteration = "proistamenos", Gloss = "one who leads", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the one who leads"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "σπουδῇ", Transliteration = "spoudē", Gloss = "zeal", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "with zeal"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐλεῶν", Transliteration = "eleōn", Gloss = "one who does acts of mercy", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the one who does acts of mercy"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἱλαρότητι", Transliteration = "hilarotēti", Gloss = "cheerfulness", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "with cheerfulness"
                }
            },
            Translation = "the one who exhorts, in his exhortation; the one who contributes, in generosity; the one who leads, with zeal; the one who does acts of mercy, with cheerfulness."
        }
    };
}

/*
Constructions identified:
- GEN_SUBJ: τοῦ θεοῦ (v1)
- GEN_OBJ: τοῦ νοὸς (v2), τῆς πίστεως (v6)
- DAT_INSTR: τῇ ἀνακαινώσει (v2)
- APP0S: τὴν λογικὴν λατρείαν ὑμῶν (v1), τὸ ἀγαθὸν καὶ εὐάρεστον καὶ τέλειον (v2)
- PTCP: ζῶσαν (v1), δοθείσης (v3), ὄντι (v3), ἔχοντες (v6), δοθεῖσαν (v6), διδάσκων (v7), παρακαλῶν (v8), μεταδιδοὺς (v8), προϊστάμενος (v8), ἐλεῶν (v8)
*/
