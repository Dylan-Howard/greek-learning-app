private static List<object> GetChapter7()
{
    // Matthew 7:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Οὕτως", Transliteration = "Houtōs", Gloss = "so", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶν", Transliteration = "pan", Gloss = "every", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "δένδρον", Transliteration = "dendron", Gloss = "tree", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἀγαθὸν", Transliteration = "agathon", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "every healthy tree"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καρποὺς", Transliteration = "karpous", Gloss = "fruits", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "καλοὺς", Transliteration = "kalous", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "good fruit"
                },
                new Word { Greek = "ποιεῖ", Transliteration = "poiei", Gloss = "bears", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "So every healthy tree bears good fruit,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σαπρὸν", Transliteration = "sapron", Gloss = "diseased", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "δένδρον", Transliteration = "dendron", Gloss = "tree", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the diseased tree"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καρποὺς", Transliteration = "karpous", Gloss = "fruits", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "πονηροὺς", Transliteration = "ponērous", Gloss = "bad", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "bad fruit"
                },
                new Word { Greek = "ποιεῖ", Transliteration = "poiei", Gloss = "bears", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "but the diseased tree bears bad fruit."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "δύναται", Transliteration = "dynatai", Gloss = "is able", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δένδρον", Transliteration = "dendron", Gloss = "tree", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἀγαθὸν", Transliteration = "agathon", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a healthy tree"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καρποὺς", Transliteration = "karpous", Gloss = "fruits", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "πονηροὺς", Transliteration = "ponērous", Gloss = "bad", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "bad fruit"
                        },
                        new Word { Greek = "ποιεῖν", Transliteration = "poiein", Gloss = "to bear", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "to bear bad fruit"
                }
            },
            Translation = "A healthy tree cannot bear bad fruit,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐδὲ", Transliteration = "oude", Gloss = "nor", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δένδρον", Transliteration = "dendron", Gloss = "tree", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σαπρὸν", Transliteration = "sapron", Gloss = "diseased", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a diseased tree"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καρποὺς", Transliteration = "karpous", Gloss = "fruits", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "καλοὺς", Transliteration = "kalous", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "good fruit"
                        },
                        new Word { Greek = "ποιεῖν", Transliteration = "poiein", Gloss = "to bear", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "to bear good fruit"
                }
            },
            Translation = "nor can a diseased tree bear good fruit."
        },

        // Verse 19
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
                        new Word { Greek = "πᾶν", Transliteration = "pan", Gloss = "every", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "δένδρον", Transliteration = "dendron", Gloss = "tree", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ποιοῦν", Transliteration = "poioun", Gloss = "bearing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "καρπὸν", Transliteration = "karpon", Gloss = "fruit", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "καλὸν", Transliteration = "kalon", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "good fruit"
                                }
                            },
                            Translation = "not bearing good fruit"
                        }
                    },
                    Translation = "Every tree that does not bear good fruit"
                },
                new Word { Greek = "ἐκκόπτεται", Transliteration = "ekkoptetai", Gloss = "is cut down", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "πῦρ", Transliteration = "pyr", Gloss = "fire", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "into the fire"
                },
                new Word { Greek = "βάλλεται", Transliteration = "balletai", Gloss = "is thrown", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Every tree that does not bear good fruit is cut down and thrown into the fire."
        },

        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἄρα", Transliteration = "ara", Gloss = "so", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γε", Transliteration = "ge", Gloss = "then", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "καρπῶν", Transliteration = "karpōn", Gloss = "fruits", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "their fruits"
                        }
                    },
                    Translation = "by their fruits"
                },
                new Word { Greek = "ἐπιγνώσεσθε", Transliteration = "epignōsesthe", Gloss = "you will recognize", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτούς", Transliteration = "autous", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "prep" }
            },
            Translation = "Thus you will recognize them by their fruits."
        },

        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Οὐ", Transliteration = "Ou", Gloss = "Not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶς", Transliteration = "pas", Gloss = "everyone", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "who says to me"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "VOC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κύριε", Transliteration = "kyrie", Gloss = "Lord", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "κύριε", Transliteration = "kyrie", Gloss = "Lord", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "'Lord, Lord'"
                        }
                    },
                    Translation = "Not everyone who says to me, 'Lord, Lord,'"
                },
                new Word { Greek = "εἰσελεύσεται", Transliteration = "eiseleusetai", Gloss = "will enter", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "βασιλείαν", Transliteration = "basileian", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "οὐρανῶν", Transliteration = "ouranōn", Gloss = "heavens", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of heaven"
                                }
                            },
                            Translation = "the kingdom of heaven"
                        }
                    },
                    Translation = "into the kingdom of heaven"
                }
            },
            Translation = "Not everyone who says to me, 'Lord, Lord,' will enter the kingdom of heaven,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ποιῶν", Transliteration = "poiōn", Gloss = "doing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θέλημα", Transliteration = "thelēma", Gloss = "will", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_POSS" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "πατρός", Transliteration = "patros", Gloss = "Father", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "my", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" }
                                            },
                                            Translation = "of my Father"
                                        }
                                    },
                                    Translation = "the will of my Father"
                                }
                            },
                            Translation = "the one who does the will of my Father"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                                new Word { Greek = "οὐρανοῖς", Transliteration = "ouranois", Gloss = "heavens", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "the heavens"
                                        }
                                    },
                                    Translation = "in heaven"
                                }
                            },
                            Translation = "who is in heaven"
                        }
                    },
                    Translation = "the one who does the will of my Father who is in heaven"
                }
            },
            Translation = "but the one who does the will of my Father who is in heaven."
        },

        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πολλοὶ", Transliteration = "polloi", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐροῦσίν", Transliteration = "erousin", Gloss = "will say", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκείνῃ", Transliteration = "ekeinē", Gloss = "that", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" }, PartOfSpeech = "adv" },
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἡμέρᾳ", Transliteration = "hēmera", Gloss = "day", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "that day"
                        }
                    },
                    Translation = "on that day"
                }
            },
            Translation = "On that day many will say to me,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "VOC" },
            Content = new List<object>
            {
                new Word { Greek = "κύριε", Transliteration = "kyrie", Gloss = "Lord", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "κύριε", Transliteration = "kyrie", Gloss = "Lord", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "'Lord, Lord,'"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σῷ", Transliteration = "sō", Gloss = "your", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "s" },
                        new Word { Greek = "ὀνόματι", Transliteration = "onomati", Gloss = "name", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in your name"
                },
                new Word { Greek = "ἐπροφητεύσαμεν", Transliteration = "eprophēteusamen", Gloss = "did we [not] prophesy", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "did we not prophesy in your name,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σῷ", Transliteration = "sō", Gloss = "your", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "s" },
                        new Word { Greek = "ὀνόματι", Transliteration = "onomati", Gloss = "name", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in your name"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δαιμόνια", Transliteration = "daimonia", Gloss = "demons", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "demons"
                },
                new Word { Greek = "ἐξεβάλομεν", Transliteration = "exebalomen", Gloss = "did we [not] cast out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "and cast out demons in your name,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σῷ", Transliteration = "sō", Gloss = "your", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "s" },
                        new Word { Greek = "ὀνόματι", Transliteration = "onomati", Gloss = "name", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in your name"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δυνάμεις", Transliteration = "dynameis", Gloss = "mighty works", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "πολλὰς", Transliteration = "pollas", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "many mighty works"
                },
                new Word { Greek = "ἐποιήσαμεν", Transliteration = "epoiēsamen", Gloss = "did we [not] do", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "and do many mighty works in your name?"
        },

        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "then", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ὁμολογήσω", Transliteration = "homologēsō", Gloss = "I will declare", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" }
            },
            Translation = "And then I will declare to them,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐδέποτε", Transliteration = "oudepote", Gloss = "never", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἔγνων", Transliteration = "egnōn", Gloss = "I knew", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" }
            },
            Translation = "'I never knew you;'"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀποχωρεῖτε", Transliteration = "apochōreite", Gloss = "depart", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπ᾽", Transliteration = "ap'", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐμοῦ", Transliteration = "emou", Gloss = "me", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "from me"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the [ones]", GrammarCodes = new List<string> { "ART", "VOC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐργαζόμενοι", Transliteration = "ergazomenoi", Gloss = "working", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "VOC", "M", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἀνομίαν", Transliteration = "anomian", Gloss = "wickedness", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "lawlessness"
                                }
                            },
                            Translation = "you who work lawlessness"
                        }
                    },
                    Translation = "you workers of lawlessness"
                }
            },
            Translation = "depart from me, you workers of lawlessness."
        },

        // Verse 24
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
                        new Word { Greek = "Πᾶς", Transliteration = "Pas", Gloss = "Everyone", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅστις", Transliteration = "hostis", Gloss = "whoever", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                                new Word { Greek = "ἀκούει", Transliteration = "akouei", Gloss = "hears", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "λόγους", Transliteration = "logous", Gloss = "words", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                        new Word { Greek = "τούτους", Transliteration = "toutous", Gloss = "these", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adv" }
                                    },
                                    Translation = "these words"
                                },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "ποιεῖ", Transliteration = "poiei", Gloss = "does", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "αὐτούς", Transliteration = "autous", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "who hears these words of mine and does them"
                        }
                    },
                    Translation = "Everyone then who hears these words of mine and does them"
                },
                new Word { Greek = "ὁμοιωθήσεται", Transliteration = "homoiōthēsetai", Gloss = "will be like", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνδρὶ", Transliteration = "andri", Gloss = "man", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "φρονίμῳ", Transliteration = "phronimō", Gloss = "wise", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "to a wise man"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅστις", Transliteration = "hostis", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ᾠκοδόμησεν", Transliteration = "ōkodomēsen", Gloss = "built", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "οἰκίαν", Transliteration = "oikian", Gloss = "house", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "his house"
                        },
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
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "πέτραν", Transliteration = "petran", Gloss = "rock", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the rock"
                                }
                            },
                            Translation = "on the rock"
                        }
                    },
                    Translation = "who built his house on the rock"
                }
            },
            Translation = "Everyone then who hears these words of mine and does them will be like a wise man who built his house on the rock."
        }
    };
}
/*
Constructions identified:
- v21: Substantive Participle (ὁ λέγων, ὁ ποιῶν)
- v22: Dative of Instrument (τῷ σῷ ὀνόματι)
- v23: Substantive Participle (οἱ ἐργαζόμενοι)
- v24: Relative Clause (ὅστις ἀκούει..., ὅστις ᾠκοδόμησεν...)
*/
