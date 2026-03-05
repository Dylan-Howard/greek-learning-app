private static List<object> GetChapter16()
{
    // Romans 16:17-23
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Παρακαλῶ", Transliteration = "Parakalō", Gloss = "I urge",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "brothers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σκοπεῖν", Transliteration = "skopein", Gloss = "to watch out for",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "those who",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "διχοστασίας", Transliteration = "dichostasias", Gloss = "divisions",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "σκάνδαλα", Transliteration = "skandala", Gloss = "stumbling blocks",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ποιοῦντας", Transliteration = "poiountas", Gloss = "causing",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "those causing divisions and stumbling blocks"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παρὰ", Transliteration = "para", Gloss = "contrary to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "διδαχὴν", Transliteration = "didachēn", Gloss = "teaching",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the teaching"
                                }
                            },
                            Translation = "contrary to the teaching"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἣν", Transliteration = "hēn", Gloss = "which",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἐμάθετε", Transliteration = "emathete", Gloss = "learned",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "which you learned"
                        }
                    },
                    Translation = "to watch out for those causing divisions and stumbling blocks contrary to the teaching which you learned"
                }
            },
            Translation = "I urge you, brothers, to watch out for those who cause divisions and stumbling blocks contrary to the teaching which you learned,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐκκλίνετε", Transliteration = "ekklinete", Gloss = "turn away",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπ᾽", Transliteration = "ap'", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "them",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "from them"
                }
            },
            Translation = "and turn away from them."
        },

        // Verse 18
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "τοιοῦτοι", Transliteration = "toioutoi", Gloss = "such people",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "For such people"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "Lord",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "our",
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Χριστῷ", Transliteration = "Christō", Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "our Lord Christ"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "δουλεύουσιν", Transliteration = "douleuousin", Gloss = "they serve",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἑαυτῶν", Transliteration = "heautōn", Gloss = "their own",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "f" },
                        new Word { Greek = "κοιλίᾳ", Transliteration = "koilia", Gloss = "appetite",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "their own appetite"
                }
            },
            Translation = "For such people do not serve our Lord Christ, but their own appetite,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "χρηστολογίας", Transliteration = "chrēstologias", Gloss = "smooth talk",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "εὐλογίας", Transliteration = "eulogias", Gloss = "flattery",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "smooth talk and flattery"
                        }
                    },
                    Translation = "through smooth talk and flattery"
                },
                new Word { Greek = "ἐξαπατῶσιν", Transliteration = "exapatōsin", Gloss = "they deceive",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "καρδίας", Transliteration = "kardias", Gloss = "hearts",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀκάκων", Transliteration = "akakōn", Gloss = "innocent",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "of the innocent"
                        }
                    },
                    Translation = "the hearts of the innocent"
                }
            },
            Translation = "and through smooth talk and flattery they deceive the hearts of the innocent."
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
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "your",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὑπακοὴ", Transliteration = "hypakoē", Gloss = "obedience",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "For your obedience"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "πάντας", Transliteration = "pantas", Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "to all"
                },
                new Word { Greek = "ἀφίκετο", Transliteration = "aphiketo", Gloss = "has reached",
                    GrammarCodes = new List<string> { "V", "AOR", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "For your obedience has reached to all."
        },
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
                        new Word { Greek = "ἐφ᾽", Transliteration = "eph'", Gloss = "over",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "over you"
                },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "χαίρω", Transliteration = "chairō", Gloss = "I rejoice",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "Therefore I rejoice over you,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "θέλω", Transliteration = "thelō", Gloss = "I want",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "σοφοὺς", Transliteration = "sophous", Gloss = "wise",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "toward",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἀγαθόν", Transliteration = "agathon", Gloss = "good",
                                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                                            PartOfSpeech = "adj" }
                                    },
                                    Translation = "the good"
                                }
                            },
                            Translation = "toward the good"
                        }
                    },
                    Translation = "you to be wise toward the good"
                },
                new Word { Greek = "ἀκεραίους", Transliteration = "akeraious", Gloss = "innocent",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "toward",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κακόν", Transliteration = "kakon", Gloss = "evil",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "the evil"
                        }
                    },
                    Translation = "toward the evil"
                }
            },
            Translation = "but I want you to be wise toward the good and innocent toward the evil."
        },

        // Verse 20
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "εἰρήνης", Transliteration = "eirēnēs", Gloss = "peace",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of peace"
                        }
                    },
                    Translation = "the God of peace"
                },
                new Word { Greek = "συντρίψει", Transliteration = "syntripsei", Gloss = "will crush",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "σατανᾶν", Transliteration = "satanan", Gloss = "Satan",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Satan"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "under",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πόδας", Transliteration = "podas", Gloss = "feet",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "your",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "your feet"
                        }
                    },
                    Translation = "under your feet"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τάχει", Transliteration = "tachei", Gloss = "haste",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "soon"
                }
            },
            Translation = "The God of peace will soon crush Satan under your feet."
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
                        new Word { Greek = "Ἡ", Transliteration = "Hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "χάρις", Transliteration = "charis", Gloss = "grace",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "our",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of our Lord Jesus"
                        }
                    },
                    Translation = "The grace of our Lord Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μεθ᾽", Transliteration = "meth'", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "be with you"
                }
            },
            Translation = "The grace of our Lord Jesus be with you."
        },

        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀσπάζεται", Transliteration = "Aspazetai", Gloss = "greets",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Τιμόθεος", Transliteration = "Timotheos", Gloss = "Timothy",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "συνεργός", Transliteration = "synergos", Gloss = "fellow worker",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "my",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "my fellow worker"
                        }
                    },
                    Translation = "Timothy my fellow worker"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "Λούκιος", Transliteration = "Loukios", Gloss = "Lucius",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "Ἰάσων", Transliteration = "Iasōn", Gloss = "Jason",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Σωσίπατρος", Transliteration = "Sōsipatros", Gloss = "Sosipater",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "συγγενεῖς", Transliteration = "syggeneis", Gloss = "kinsmen",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "my",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "my kinsmen"
                        }
                    },
                    Translation = "Sosipater my kinsmen"
                }
            },
            Translation = "Timothy, my fellow worker, greets you; and Lucius and Jason and Sosipater, my kinsmen."
        },

        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάζομαι", Transliteration = "aspazomai", Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "Τέρτιος", Transliteration = "Tertios", Gloss = "Tertius",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "who",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γράψας", Transliteration = "grapsas", Gloss = "wrote",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐπιστολὴν", Transliteration = "epistolēn", Gloss = "letter",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the letter"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "Lord",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in the Lord"
                        }
                    },
                    Translation = "who wrote the letter in the Lord"
                }
            },
            Translation = "I, Tertius, who wrote the letter in the Lord, greet you."
        },

        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάζεται", Transliteration = "aspazetai", Gloss = "greets",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Γάϊος", Transliteration = "Gaios", Gloss = "Gaius",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ξένος", Transliteration = "xenos", Gloss = "host",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "my",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "ὅλης", Transliteration = "holēs", Gloss = "whole",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐκκλησίας", Transliteration = "ekklesias", Gloss = "church",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "my host and the whole church"
                        }
                    },
                    Translation = "Gaius my host and the whole church"
                }
            },
            Translation = "Gaius, my host and the whole church, greets you."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάζεται", Transliteration = "aspazetai", Gloss = "greets",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἔραστος", Transliteration = "Erastos", Gloss = "Erastus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "οἰκονόμος", Transliteration = "oikonomos", Gloss = "treasurer",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πόλεως", Transliteration = "poleōs", Gloss = "city",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the city treasurer"
                        }
                    },
                    Translation = "Erastus the city treasurer"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Κούαρτος", Transliteration = "Kouartos", Gloss = "Quartus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀδελφόσ", Transliteration = "adelphos", Gloss = "brother",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the brother"
                        }
                    },
                    Translation = "Quartus the brother"
                }
            },
            Translation = "Erastus, the city treasurer, greets you, and Quartus the brother."
        }
    };
}
/*
Constructions identified:
- REL_CLAUSE: Romans 16:17 (ἣν ὑμεῖς ἐμάθετε)
- INF_PHRASE: Romans 16:17 (σκοπεῖν...), Romans 16:19 (σοφοὺς εἶναι...)
- APPOS: Romans 16:21 (ὁ συνεργός μου, οἱ συγγενεῖς μου), Romans 16:23 (ὁ ξένος μου..., ὁ οἰκονόμος..., ὁ ἀδελφός)
- PTCP: Romans 16:22 (ὁ γράψας...)
*/
