private static List<object> GetChapter26()
{
    // Acts 26:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀγρίππας", Transliteration = "Agrippas", Gloss = "Agrippa",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Παῦλον", Transliteration = "Paulon", Gloss = "Paul",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Paul"
                        }
                    },
                    Translation = "to Paul"
                },
                new Word { Greek = "ἔφη", Transliteration = "ephē", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "But Agrippa said to Paul,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐπιτρέπεταί", Transliteration = "epitrepetai", Gloss = "it is permitted",
                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "2P", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "σεαυτοῦ", Transliteration = "seautou", Gloss = "yourself",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "2P", "S" }, PartOfSpeech = "f" }
                            },
                            Translation = "about yourself"
                        },
                        new Word { Greek = "λέγειν", Transliteration = "legein", Gloss = "to speak",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "to speak about yourself."
                }
            },
            Translation = "It is permitted to you to speak about yourself."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "then",
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Παῦλος", Transliteration = "Paulos", Gloss = "Paul",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Paul"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκτείνας", Transliteration = "ekteinas", Gloss = "having stretched out",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "χεῖρα", Transliteration = "cheira", Gloss = "hand",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the hand"
                        }
                    },
                    Translation = "stretching out his hand"
                },
                new Word { Greek = "ἀπελογεῖτο", Transliteration = "apelogeito", Gloss = "made his defense",
                    GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Then Paul, stretching out his hand, began to make his defense:"
        },
        // Verse 2
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
                        new Word { Greek = "Περὶ", Transliteration = "Peri", Gloss = "about",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all [things]",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "of which",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pron" },
                                new Word { Greek = "ἐγκαλοῦμαι", Transliteration = "enkaloumai", Gloss = "I am accused",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "1P", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by",
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "Ἰουδαίων", Transliteration = "Ioudaiōn", Gloss = "Jews",
                                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "by Jews"
                                }
                            },
                            Translation = "of which I am accused by Jews,"
                        }
                    },
                    Translation = "Concerning all the things of which I am accused by the Jews,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βασιλεῦ", Transliteration = "basileu", Gloss = "O King",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Ἀγρίππα", Transliteration = "Agrippa", Gloss = "Agrippa",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "King Agrippa,"
                },
                new Word { Greek = "ἥγημαι", Transliteration = "hēgēmai", Gloss = "I consider",
                    GrammarCodes = new List<string> { "V", "PERF", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἐμαυτὸν", Transliteration = "emauton", Gloss = "myself",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "1P", "S" }, PartOfSpeech = "f" },
                new Word { Greek = "μακάριον", Transliteration = "makarion", Gloss = "blessed",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "before",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "σοῦ", Transliteration = "sou", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "2P", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μέλλων", Transliteration = "mellōn", Gloss = "being about",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "σήμερον", Transliteration = "sēmeron", Gloss = "today",
                            GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἀπολογεῖσθαι", Transliteration = "apologeisthai", Gloss = "to make defense",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "being about to make my defense before you today,"
                }
            },
            Translation = "Concerning all the things of which I am accused by Jews, King Agrippa, I consider myself blessed since I am about to make my defense before you today,"
        },
        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μάλιστα", Transliteration = "malista", Gloss = "especially",
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "γνώστην", Transliteration = "gnōstēn", Gloss = "expert",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ὄντα", Transliteration = "onta", Gloss = "being",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σε", Transliteration = "se", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "2P", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "of all",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "among",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "Ἰουδαίους", Transliteration = "Ioudaious", Gloss = "Jews",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "among Jews"
                        },
                        new Word { Greek = "ἐθῶν", Transliteration = "ethōn", Gloss = "customs",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "both",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ζητημάτων", Transliteration = "zētēmatōn", Gloss = "controversies",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "of all the customs and controversies among Jews;"
                }
            },
            Translation = "especially because you are an expert in all the customs and controversies among the Jews;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "διὸ", Transliteration = "dio", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "δέομαι", Transliteration = "deomai", Gloss = "I beg",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "μακροθύμως", Transliteration = "makrothymōs", Gloss = "patiently",
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀκοῦσαί", Transliteration = "akousai", Gloss = "to hear",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "me",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "1P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "to hear me"
                }
            },
            Translation = "therefore I beg you to hear me patiently."
        },
        // Verse 4
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
                        new Word { Greek = "Τὴν", Transliteration = "Tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed",
                            GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "βίωσίν", Transliteration = "biōsin", Gloss = "manner of life",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "my",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "1P", "S" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "that",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "νεότητος", Transliteration = "neotētos", Gloss = "youth",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "from youth"
                                }
                            },
                            Translation = "the [life] from youth"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the [one]",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀπ᾽", Transliteration = "ap'", Gloss = "from",
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "ἀρχῆς", Transliteration = "archēs", Gloss = "beginning",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "from the beginning"
                                },
                                new Word { Greek = "γενομένην", Transliteration = "genomenēn", Gloss = "occurring",
                                    GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "ACC", "F", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "occurring from the beginning"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἔθνει", Transliteration = "ethnei", Gloss = "nation",
                                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "1P", "S" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "my nation"
                                }
                            },
                            Translation = "among my nation"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τε", Transliteration = "te", Gloss = "both",
                                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "Ἱεροσολύμοις", Transliteration = "Ierosolymois", Gloss = "Jerusalem",
                                    GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "and in Jerusalem"
                        }
                    },
                    Translation = "My manner of life from my youth, which was from the beginning among my own nation and in Jerusalem,"
                },
                new Word { Greek = "ἴσασιν", Transliteration = "isasin", Gloss = "know",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "οἱ", Transliteration = "oi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰουδαῖοι", Transliteration = "Ioudaioi", Gloss = "Jews",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "all the Jews"
                }
            },
            Translation = "My manner of life from my youth, spent from the beginning among my own nation and in Jerusalem, all the Jews know."
        },
        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προγινώσκοντές", Transliteration = "proginōskontes", Gloss = "knowing beforehand",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "1P", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἄνωθεν", Transliteration = "anōthen", Gloss = "from long ago",
                            GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                    },
                    Translation = "since they have known me from long ago,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "θέλωσιν", Transliteration = "thelōsin", Gloss = "they should be willing",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "μαρτυρεῖν", Transliteration = "martyrein", Gloss = "to testify",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "if they are willing to testify,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "oti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἀκριβεστάτην", Transliteration = "akribestatēn", Gloss = "strictest",
                                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "αἵρεσιν", Transliteration = "airesin", Gloss = "sect",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the",
                                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "ἡμετέρας", Transliteration = "ēmeteras", Gloss = "our",
                                                    GrammarCodes = new List<string> { "ADJ", "GEN", "F", "P" }, PartOfSpeech = "s" },
                                                new Word { Greek = "θρησκείας", Transliteration = "thrēskeias", Gloss = "religion",
                                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "of our religion"
                                        }
                                    },
                                    Translation = "the strictest sect of our religion"
                                }
                            },
                            Translation = "according to the strictest sect of our religion"
                        },
                        new Word { Greek = "ἔζησα", Transliteration = "ezēsa", Gloss = "I lived",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "Φαρισαῖος", Transliteration = "Pharisaios", Gloss = "as a Pharisee",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "that according to the strictest sect of our religion I lived as a Pharisee."
                }
            },
            Translation = "They have known me for a long time, if they are willing to testify, that according to the strictest sect of our religion I lived as a Pharisee."
        },
        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now",
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐλπίδι", Transliteration = "elpidi", Gloss = "hope",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                                new Word { Greek = "πατέρας", Transliteration = "pateras", Gloss = "fathers",
                                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                                new Word { Greek = "ἡμῶν", Transliteration = "ēmōn", Gloss = "of us",
                                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "1P", "P" }, PartOfSpeech = "prep" }
                                            },
                                            Translation = "our fathers"
                                        }
                                    },
                                    Translation = "to our fathers"
                                },
                                new Word { Greek = "ἐπαγγελίας", Transliteration = "epangelias", Gloss = "promise",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "γενομένης", Transliteration = "genomenēs", Gloss = "made",
                                    GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "GEN", "F", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by",
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "God"
                                        }
                                    },
                                    Translation = "by God"
                                }
                            },
                            Translation = "of the promise made by God to our fathers"
                        }
                    },
                    Translation = "for the hope of the promise made by God to our fathers"
                },
                new Word { Greek = "ἕστηκα", Transliteration = "estēka", Gloss = "I stand",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "κρινόμενος", Transliteration = "krinomenos", Gloss = "being judged",
                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
            },
            Translation = "And now I stand here on trial because of the hope in the promise made by God to our fathers,"
        },
        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἣν", Transliteration = "ēn", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "to which"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δωδεκάφυλον", Transliteration = "dōdekapylon", Gloss = "twelve tribes",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἡμῶν", Transliteration = "ēmōn", Gloss = "of us",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "1P", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "our twelve tribes"
                },
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
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἐκτενείᾳ", Transliteration = "ekteneia", Gloss = "earnestness",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "earnestly"
                        },
                        new Word { Greek = "νύκτα", Transliteration = "nykta", Gloss = "night",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἡμέραν", Transliteration = "ēmeran", Gloss = "day",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "λατρεῦον", Transliteration = "latreuon", Gloss = "serving",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "serving earnestly night and day"
                },
                new Word { Greek = "ἐλπίζει", Transliteration = "elpizei", Gloss = "hopes",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καταντῆσαι", Transliteration = "katantēsai", Gloss = "to attain",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
            },
            Translation = "to which our twelve tribes hope to attain, as they earnestly serve God night and day."
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
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἧς", Transliteration = "ēs", Gloss = "which",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "pron" },
                                new Word { Greek = "ἐλπίδος", Transliteration = "elpidos", Gloss = "hope",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "this hope"
                        }
                    },
                    Translation = "Concerning this hope"
                },
                new Word { Greek = "ἐγκαλοῦμαι", Transliteration = "enkaloumai", Gloss = "I am accused",
                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "Ἰουδαίων", Transliteration = "Ioudaiōn", Gloss = "Jews",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "by Jews"
                },
                new Word { Greek = "βασιλεῦ", Transliteration = "basileu", Gloss = "O King",
                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "Concerning this hope I am accused by Jews, O king!"
        },
        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τί", Transliteration = "ti", Gloss = "Why",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "interj" },
                new Word { Greek = "ἄπιστον", Transliteration = "apiston", Gloss = "unbelievable",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "κρίνεται", Transliteration = "krinetai", Gloss = "is it judged",
                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρ᾽", Transliteration = "par'", Gloss = "among",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμῖν", Transliteration = "ymin", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "2P", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "among you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "God"
                        },
                        new Word { Greek = "νεκροὺς", Transliteration = "nekrous", Gloss = "dead [ones]",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐγείρει", Transliteration = "egeirei", Gloss = "raises",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "if God raises the dead?"
                }
            },
            Translation = "Why is it judged unbelievable among you if God raises the dead?"
        }
    };
}

/*
Constructions identified:
- PTCP: Acts 26:1 (ἐκτείνας), 26:2 (μέλλων), 26:3 (ὄντα), 26:5 (προγινώσκοντές), 26:6 (γενομένης, κρινόμενος), 26:7 (λατρεῦον)
- INF_PHRASE: Acts 26:1 (λέγειν), 26:2 (ἀπολογεῖσθαι), 26:3 (ἀκοῦσαί), 26:5 (μαρτυρεῖν), 26:7 (καταντῆσαι)
- GEN_OBJ: Acts 26:6 (τῆς... ἐπαγγελίας) - Objective genitive of the hope.
- GEN_DESC: Acts 26:5 (τῆς ἡμετέρας θρησκείας) - Descriptive genitive.
- VOC: Acts 26:2, 26:7 (βασιλεῦ Ἀγρίππα / βασιλεῦ)
- REL_CLAUSE: Acts 26:2 (ὧν), 26:7 (εἰς ἣν)
- COND_CLAUSE: Acts 26:5 (ἐὰν θέλωσιν), 26:8 (εἰ ὁ θεὸς... ἐγείρει)
*/
