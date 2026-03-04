private static List<object> GetChapter7()
{
    // John 7:9-16
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
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "adv" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "εἰπὼν", Transliteration = "eipōn", Gloss = "having said", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "but having said these things"
                },
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἔμεινεν", Transliteration = "emeinen", Gloss = "he stayed", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Γαλιλαίᾳ", Transliteration = "Galilaia", Gloss = "Galilee", 
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Galilee"
                        }
                    },
                    Translation = "in Galilee"
                }
            },
            Translation = "But after saying these things, he stayed in Galilee."
        },

        // Verse 10
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
                        new Word { Greek = "Ὡς", Transliteration = "Hōs", Gloss = "as", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀνέβησαν", Transliteration = "anebēsan", Gloss = "had gone up", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀδελφοὶ", Transliteration = "adelphoi", Gloss = "brothers", 
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", 
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "his brothers"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἑορτήν", Transliteration = "heortēn", Gloss = "feast", 
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the feast"
                                }
                            },
                            Translation = "to the feast"
                        }
                    },
                    Translation = "But when his brothers had gone up to the feast"
                },
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "then", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "conj" },
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἀνέβη", Transliteration = "anebē", Gloss = "went up", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", 
                    GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "φανερῶς", Transliteration = "phanerōs", Gloss = "publicly", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "κρυπτῷ", Transliteration = "kryptō", Gloss = "secret", 
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "in secret"
                        }
                    },
                    Translation = "as if in secret"
                }
            },
            Translation = "But when his brothers had gone up to the feast, then he also went up, not publicly but as if in secret."
        },

        // Verse 11
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
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Ἰουδαῖοι", Transliteration = "Ioudaioi", Gloss = "Jews", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "So the Jews"
                },
                new Word { Greek = "ἐζήτουν", Transliteration = "ezētoun", Gloss = "were looking for", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἑορτῇ", Transliteration = "heortē", Gloss = "feast", 
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the feast"
                        }
                    },
                    Translation = "at the feast"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἔλεγον", Transliteration = "elegon", Gloss = "they were saying", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ποῦ", Transliteration = "pou", Gloss = "where", 
                            GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἐκεῖνος", Transliteration = "ekeinos", Gloss = "that man", 
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "adv" }
                    },
                    Translation = "\"Where is he?\""
                }
            },
            Translation = "So the Jews were looking for him at the feast and saying, \"Where is he?\""
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γογγυσμὸς", Transliteration = "gongysmos", Gloss = "grumbling", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", 
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "about him"
                        }
                    },
                    Translation = "grumbling about him"
                },
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "there was", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "πολὺς", Transliteration = "polys", Gloss = "much", 
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὄχλοις", Transliteration = "ochlois", Gloss = "crowds", 
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the crowds"
                        }
                    },
                    Translation = "among the crowds"
                }
            },
            Translation = "And there was much grumbling about him among the crowds."
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed", 
                            GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" }
                    },
                    Translation = "some"
                },
                new Word { Greek = "ἔλεγον", Transliteration = "elegon", Gloss = "were saying", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀγαθός", Transliteration = "agathos", Gloss = "good", 
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "he is", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "\"He is a good man.\""
                }
            },
            Translation = "Some said, \"He is a good man.\""
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἄλλοι", Transliteration = "alloi", Gloss = "others", 
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἔλεγον", Transliteration = "elegon", Gloss = "were saying", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "οὔ", Transliteration = "ou", Gloss = "no", 
                    GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πλανᾷ", Transliteration = "plana", Gloss = "he leads astray", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὄχλον", Transliteration = "ochlon", Gloss = "crowd", 
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the crowd"
                }
            },
            Translation = "But others said, \"No, he is leading the crowd astray.\""
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐδεὶς", Transliteration = "oudeis", Gloss = "no one", 
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "μέντοι", Transliteration = "mentoi", Gloss = "however", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "παρρησίᾳ", Transliteration = "parrēsia", Gloss = "openly", 
                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἐλάλει", Transliteration = "elalei", Gloss = "was speaking", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "about him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because of", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "φόβον", Transliteration = "phobon", Gloss = "fear", 
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "Ἰουδαίων", Transliteration = "Ioudaiōn", Gloss = "Jews", 
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "of the Jews"
                                }
                            },
                            Translation = "the fear of the Jews"
                        }
                    },
                    Translation = "for fear of the Jews"
                }
            },
            Translation = "Yet for fear of the Jews no one spoke openly of him."
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἤδη", Transliteration = "Ēdē", Gloss = "already", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἑορτῆς", Transliteration = "heortēs", Gloss = "feast", 
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μεσούσης", Transliteration = "mesousēs", Gloss = "being half over", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "F", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the feast being half over"
                },
                new Word { Greek = "ἀνέβη", Transliteration = "anebē", Gloss = "went up", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἱερὸν", Transliteration = "hieron", Gloss = "temple", 
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the temple"
                        }
                    },
                    Translation = "into the temple"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐδίδασκεν", Transliteration = "edidasken", Gloss = "began to teach", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "About the middle of the feast Jesus went up into the temple and began to teach."
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐθαύμαζον", Transliteration = "ethaumazon", Gloss = "were amazed", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰουδαῖοι", Transliteration = "Ioudaioi", Gloss = "Jews", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "The Jews"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πῶς", Transliteration = "pōs", Gloss = "how", 
                                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this man", 
                                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "adv" },
                                new Word { Greek = "γράμματα", Transliteration = "grammata", Gloss = "learning", 
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "οἶδεν", Transliteration = "oiden", Gloss = "knows", 
                                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", 
                                            GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "μεμαθηκώς", Transliteration = "memathēkōs", Gloss = "having studied", 
                                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "when he has never studied?"
                                }
                            },
                            Translation = "\"How is it that this man has learning, when he has never studied?\""
                        }
                    },
                    Translation = "saying, \"How is it that this man has learning, when he has never studied?\""
                }
            },
            Translation = "The Jews therefore marveled, saying, \"How is it that this man has learning, when he has never studied?\""
        },

        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀπεκρίθη", Transliteration = "apekrithē", Gloss = "answered", 
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
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
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐμὴ", Transliteration = "emē", Gloss = "my", 
                                    GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" }, PartOfSpeech = "s" },
                                new Word { Greek = "διδαχὴ", Transliteration = "didachē", Gloss = "teaching", 
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "my teaching"
                        },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", 
                            GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἐμὴ", Transliteration = "emē", Gloss = "mine", 
                            GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" }, PartOfSpeech = "s" },
                        new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the one", 
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πέμψαντός", Transliteration = "pempsantos", Gloss = "who sent", 
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "με", Transliteration = "me", Gloss = "me", 
                                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "his who sent me"
                        }
                    },
                    Translation = "\"My teaching is not mine, but his who sent me.\""
                }
            },
            Translation = "So Jesus answered them and said, \"My teaching is not mine, but his who sent me.\""
        }
    };
}

/* 
Constructions identified:
- DAT_MANNER: Verse 13 (παρρησίᾳ - with openness/boldness)
- GEN_ABS: Verse 14 (τῆς ἑορτῆς μεσούσης - the feast being half over)
*/
