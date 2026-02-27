private static List<object> GetChapter12()
{
    // Matthew 12:33-40
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἢ", Transliteration = "Ē", Gloss = "Either", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ποιήσατε", Transliteration = "poiēsate", Gloss = "make", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δένδρον", Transliteration = "dendron", Gloss = "tree", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καλὸν", Transliteration = "kalon", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the good tree"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καρπὸν", Transliteration = "karpon", Gloss = "fruit", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "its", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "καλόν", Transliteration = "kalon", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "its fruit good"
                }
            },
            Translation = "Either make the tree good and its fruit good,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ποιήσατε", Transliteration = "poiēsate", Gloss = "make", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δένδρον", Transliteration = "dendron", Gloss = "tree", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σαπρὸν", Transliteration = "sapron", Gloss = "bad", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the bad tree"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καρπὸν", Transliteration = "karpon", Gloss = "fruit", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "its", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "σαπρόν", Transliteration = "sapron", Gloss = "bad", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "its fruit bad"
                }
            },
            Translation = "or make the tree bad and its fruit bad,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καρποῦ", Transliteration = "karpou", Gloss = "fruit", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "for from the fruit"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δένδρον", Transliteration = "dendron", Gloss = "tree", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the tree"
                },
                new Word { Greek = "γινώσκεται", Transliteration = "ginōsketai", Gloss = "is known", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "for the tree is known by its fruit."
        },

        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γεννήματα", Transliteration = "gennēmata", Gloss = "offspring", GrammarCodes = new List<string> { "N", "VOC", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἐχιδνῶν", Transliteration = "echidnōn", Gloss = "of vipers", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "You brood of vipers!"
                },
                new Word { Greek = "πῶς", Transliteration = "pōs", Gloss = "how", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "δύνασθε", Transliteration = "dynasthe", Gloss = "can you", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀγαθὰ", Transliteration = "agatha", Gloss = "good things", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "λαλεῖν", Transliteration = "lalein", Gloss = "to speak", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "to speak good things"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πονηροὶ", Transliteration = "ponēroi", Gloss = "evil", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ὄντες", Transliteration = "ontes", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "being evil?"
                }
            },
            Translation = "Brood of vipers! How can you speak good things, when you are evil?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "περισσεύματος", Transliteration = "perisseumatos", Gloss = "abundance", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "καρδίας", Transliteration = "kardias", Gloss = "heart", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the heart"
                        }
                    },
                    Translation = "for from the abundance of the heart"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "στόμα", Transliteration = "stoma", Gloss = "mouth", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the mouth"
                },
                new Word { Greek = "λαλεῖ", Transliteration = "lalei", Gloss = "speaks", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "For out of the abundance of the heart the mouth speaks."
        },

        // Verse 35
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀγαθὸς", Transliteration = "agathos", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἄνθρωπος", Transliteration = "anthrōpos", Gloss = "man", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "The good man"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "out of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀγαθοῦ", Transliteration = "agathou", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "θησαυροῦ", Transliteration = "thēsaurou", Gloss = "treasure", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "out of his good treasure"
                },
                new Word { Greek = "ἐκβάλλει", Transliteration = "ekballei", Gloss = "brings forth", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἀγαθά", Transliteration = "agatha", Gloss = "good things", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
            },
            Translation = "The good person out of his good treasure brings forth good,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πονηρὸς", Transliteration = "ponēros", Gloss = "evil", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἄνθρωπος", Transliteration = "anthrōpos", Gloss = "man", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the evil man"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "out of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πονηροῦ", Transliteration = "ponērou", Gloss = "evil", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "θησαυροῦ", Transliteration = "thēsaurou", Gloss = "treasure", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "out of his evil treasure"
                },
                new Word { Greek = "ἐκβάλλει", Transliteration = "ekballei", Gloss = "brings forth", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "πονηρά", Transliteration = "ponēra", Gloss = "evil things", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
            },
            Translation = "and the evil person out of his evil treasure brings forth evil."
        },

        // Verse 36
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πᾶν", Transliteration = "pan", Gloss = "every", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ῥῆμα", Transliteration = "rhēma", Gloss = "word", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἀργὸν", Transliteration = "argon", Gloss = "careless", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "every careless word"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                                new Word { Greek = "λαλήσουσιν", Transliteration = "lalēsousin", Gloss = "will speak", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἄνθρωποι", Transliteration = "anthrōpoi", Gloss = "men", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "men"
                                }
                            },
                            Translation = "that men speak"
                        },
                        new Word { Greek = "ἀποδώσουσιν", Transliteration = "apodōsousin", Gloss = "they will give", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "it", GrammarCodes = new List<string> { "PRON", "GEN", "N", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "concerning it"
                        },
                        new Word { Greek = "λόγον", Transliteration = "logon", Gloss = "account", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἡμέρᾳ", Transliteration = "hēmera", Gloss = "day", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "κρίσεως", Transliteration = "kriseōs", Gloss = "of judgment", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in the day of judgment"
                        }
                    },
                    Translation = "that for every careless word that men speak, they will give an account of it in the day of judgment"
                }
            },
            Translation = "But I tell you that for every careless word that people speak, they will give an account of it in the day of judgment."
        },

        // Verse 37
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
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "λόγων", Transliteration = "logōn", Gloss = "words", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "σου", Transliteration = "sou", Gloss = "your", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "your words"
                        }
                    },
                    Translation = "for by your words"
                },
                new Word { Greek = "δικαιωθήσῃ", Transliteration = "dikaiōthēsē", Gloss = "you will be justified", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "2P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "For by your words you will be justified,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
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
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "λόγων", Transliteration = "logōn", Gloss = "words", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "σου", Transliteration = "sou", Gloss = "your", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "your words"
                        }
                    },
                    Translation = "by your words"
                },
                new Word { Greek = "καταδικασθήσῃ", Transliteration = "katadikasthēsē", Gloss = "you will be condemned", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "2P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "and by your words you will be condemned."
        },

        // Verse 38
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τότε", Transliteration = "Tote", Gloss = "Then", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀπεκρίθησαν", Transliteration = "apekrithēsan", Gloss = "answered", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τινες", Transliteration = "tines", Gloss = "some", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "part" },
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "γραμματέων", Transliteration = "grammateōn", Gloss = "scribes", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Φαρισαίων", Transliteration = "Pharisaiōn", Gloss = "Pharisees", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "some of the scribes and Pharisees"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                }
            },
            Translation = "Then some of the scribes and Pharisees answered him, saying,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "διδάσκαλε", Transliteration = "didaskale", Gloss = "Teacher", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "θέλομεν", Transliteration = "thelomen", Gloss = "we wish", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "σοῦ", Transliteration = "sou", Gloss = "you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "from you"
                        },
                        new Word { Greek = "σημεῖον", Transliteration = "sēmeion", Gloss = "a sign", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἰδεῖν", Transliteration = "idein", Gloss = "to see", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "to see a sign from you"
                }
            },
            Translation = "\"Teacher, we wish to see a sign from you.\""
        },

        // Verse 39
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "he", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀποκριθεὶς", Transliteration = "apokritheis", Gloss = "answering", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "answering"
                },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" }
            },
            Translation = "But he answered them,"
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
                        new Word { Greek = "γενεὰ", Transliteration = "genea", Gloss = "generation", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "πονηρὰ", Transliteration = "ponēra", Gloss = "evil", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μοιχαλὶς", Transliteration = "moichalis", Gloss = "adulterous", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "An evil and adulterous generation"
                },
                new Word { Greek = "σημεῖον", Transliteration = "sēmeion", Gloss = "a sign", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἐπιζητεῖ", Transliteration = "epizētei", Gloss = "seeks", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σημεῖον", Transliteration = "sēmeion", Gloss = "a sign", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "a sign"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "δοθήσεται", Transliteration = "dothēsetai", Gloss = "will be given", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῇ", Transliteration = "autē", Gloss = "to it", GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σημεῖον", Transliteration = "sēmeion", Gloss = "sign", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Ἰωνᾶ", Transliteration = "Iōna", Gloss = "of Jonah", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "APPOS" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "προφήτου", Transliteration = "prophētou", Gloss = "prophet", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the prophet"
                                }
                            },
                            Translation = "the sign of Jonah the prophet"
                        }
                    },
                    Translation = "except the sign of the prophet Jonah"
                }
            },
            Translation = "\"An evil and adulterous generation seeks for a sign, but no sign will be given to it except the sign of the prophet Jonah.\""
        },

        // Verse 40
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
                        new Word { Greek = "ὥσπερ", Transliteration = "hōsper", Gloss = "just as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "Ἰωνᾶς", Transliteration = "Iōnas", Gloss = "Jonah", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κοιλίᾳ", Transliteration = "koilia", Gloss = "belly", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κήτους", Transliteration = "kētous", Gloss = "sea monster", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the sea monster"
                                }
                            },
                            Translation = "in the belly of the sea monster"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τρεῖς", Transliteration = "treis", Gloss = "three", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἡμέρας", Transliteration = "hēmeras", Gloss = "days", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "τρεῖς", Transliteration = "treis", Gloss = "three", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "νύκτας", Transliteration = "nyktas", Gloss = "nights", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "three days and three nights"
                        }
                    },
                    Translation = "for just as Jonah was in the belly of the sea monster three days and three nights"
                },
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "so", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἔσται", Transliteration = "estai", Gloss = "will be", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "υἱὸς", Transliteration = "hyios", Gloss = "Son", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀνθρώπου", Transliteration = "anthrōpou", Gloss = "Man", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of Man"
                        }
                    },
                    Translation = "the Son of Man"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καρδίᾳ", Transliteration = "kardia", Gloss = "heart", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "γῆς", Transliteration = "gēs", Gloss = "earth", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the earth"
                        }
                    },
                    Translation = "in the heart of the earth"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τρεῖς", Transliteration = "treis", Gloss = "three", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἡμέρας", Transliteration = "hēmeras", Gloss = "days", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τρεῖς", Transliteration = "treis", Gloss = "three", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "νύκτας", Transliteration = "nyktas", Gloss = "nights", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "three days and three nights"
                }
            },
            Translation = "for just as Jonah was three days and three nights in the belly of the sea monster, so will the Son of Man be three days and three nights in the heart of the earth."
        }
    };
}

/*
Identified Constructions:
- Double Accusative (Object-Complement): Matthew 12:33 ("make the tree good")
- Vocative: Matthew 12:34 ("γεννήματα ἐχιδνῶν"), 12:38 ("διδάσκαλε")
- Substantival Participle: Matthew 12:34 ("πονηροὶ ὄντες")
- Comparative Clause: Matthew 12:40 ("ὥσπερ... οὕτως")
- Appositive: Matthew 12:39 ("Ἰωνᾶ τοῦ προφήτου")
*/
