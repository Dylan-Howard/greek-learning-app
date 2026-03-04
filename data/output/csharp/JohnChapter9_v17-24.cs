private static List<object> GetChapter9()
{
    // John 9:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγουσιν", Transliteration = "legousin", Gloss = "they say",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "τυφλῷ", Transliteration = "typhlō", Gloss = "blind [man]",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "to the blind man"
                },
                new Word { Greek = "πάλιν", Transliteration = "palin", Gloss = "again",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" }
            },
            Translation = "They said therefore to the blind man again,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τί", Transliteration = "ti", Gloss = "what",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "2P", "NOM", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "λέγεις", Transliteration = "legeis", Gloss = "say",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "about him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἠνέῳξέν", Transliteration = "ēneōxen", Gloss = "he opened",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "your",
                            GrammarCodes = new List<string> { "PRON", "2P", "GEN", "S" },
                            PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὀφθαλμούς", Transliteration = "ophthalmous", Gloss = "eyes",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the eyes"
                        }
                    },
                    Translation = "that he opened your eyes?"
                }
            },
            Translation = "What do you say about him, since he opened your eyes?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]",
                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                    PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "προφήτης", Transliteration = "prophētēs", Gloss = "prophet",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἐστίν", Transliteration = "estin", Gloss = "he is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that he is a prophet"
                }
            },
            Translation = "But he said, 'He is a prophet.'"
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Οὐκ", Transliteration = "Ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "ἐπίστευσαν", Transliteration = "episteusan", Gloss = "believed",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Ἰουδαῖοι", Transliteration = "Ioudaioi", Gloss = "Jews",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the Jews"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "about him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "he was",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "τυφλὸς", Transliteration = "typhlos", Gloss = "blind",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἀνέβλεψεν", Transliteration = "aneblepsen", Gloss = "received sight",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that he was blind and received sight"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "until",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὅτου", Transliteration = "hotou", Gloss = "when",
                            GrammarCodes = new List<string> { "PRON", "GEN", "N", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἐφώνησαν", Transliteration = "ephōnēsan", Gloss = "they called",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "γονεῖς", Transliteration = "goneis", Gloss = "parents",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "his parents"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the [one]",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀναβλέψαντος", Transliteration = "anablepsantos", Gloss = "having received sight",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "of the one who had received sight"
                        }
                    },
                    Translation = "until they called the parents of the one who had received sight"
                }
            },
            Translation = "The Jews therefore did not believe about him, that he was blind and received sight, until they called his parents."
        },

        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἠρώτησαν", Transliteration = "ērōtēsan", Gloss = "they asked",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "them",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὗτός", Transliteration = "houtos", Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "υἱὸς", Transliteration = "hyios", Gloss = "son",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                                    GrammarCodes = new List<string> { "PRON", "2P", "GEN", "P" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "your son"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "whom",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you",
                                    GrammarCodes = new List<string> { "PRON", "2P", "NOM", "P" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "λέγετε", Transliteration = "legete", Gloss = "say",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "whom you say"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "τυφλὸς", Transliteration = "typhlos", Gloss = "blind",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἐγεννήθη", Transliteration = "egennēthē", Gloss = "was born",
                                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "that he was born blind"
                        }
                    },
                    Translation = "Is this your son, whom you say was born blind?"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πῶς", Transliteration = "pōs", Gloss = "how",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "βλέπει", Transliteration = "blepei", Gloss = "does he see",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἄρτι", Transliteration = "arti", Gloss = "now",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "How then does he now see?"
                }
            },
            Translation = "And they asked them, saying, 'Is this your son, whom you say was born blind? How then does he now see?'"
        },

        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀπεκρίθησαν", Transliteration = "apekrithēsan", Gloss = "answered",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γονεῖς", Transliteration = "goneis", Gloss = "parents",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "his parents"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἶπαν", Transliteration = "eipan", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἴδαμεν", Transliteration = "oidamen", Gloss = "we know",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "οὗτός", Transliteration = "houtos", Gloss = "this",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "υἱὸς", Transliteration = "hyios", Gloss = "son",
                                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us",
                                            GrammarCodes = new List<string> { "PRON", "1P", "GEN", "P" },
                                            PartOfSpeech = "pron" }
                                    },
                                    Translation = "our son"
                                }
                            },
                            Translation = "that this is our son"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "τυφλὸς", Transliteration = "typhlos", Gloss = "blind",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἐγεννήθη", Transliteration = "egennēthē", Gloss = "was born",
                                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "that he was born blind"
                        }
                    },
                    Translation = "We know that this is our son and that he was born blind"
                }
            },
            Translation = "His parents therefore answered and said, 'We know that this is our son and that he was born blind;'"
        },

        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πῶς", Transliteration = "pōs", Gloss = "how",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "βλέπει", Transliteration = "blepei", Gloss = "he sees",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "οἴδαμεν", Transliteration = "oidamen", Gloss = "we know",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "but how he now sees we do not know"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "τίς", Transliteration = "tis", Gloss = "who",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἤνοιξεν", Transliteration = "ēnoixen", Gloss = "opened",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὀφθαλμοὺς", Transliteration = "ophthalmous", Gloss = "eyes",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "his eyes"
                },
                new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis", Gloss = "we",
                    GrammarCodes = new List<string> { "PRON", "1P", "NOM", "P" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "οἴδαμεν", Transliteration = "oidamen", Gloss = "we know",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "or who opened his eyes we do not know"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἐρωτήσατε", Transliteration = "erōtēsate", Gloss = "ask",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡλικίαν", Transliteration = "hēlikian", Gloss = "age",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἔχει", Transliteration = "echei", Gloss = "he has",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "he is of age"
                },
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἑαυτοῦ", Transliteration = "heautou", Gloss = "himself",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "about himself"
                },
                new Word { Greek = "λαλήσει", Transliteration = "lalēsei", Gloss = "he will speak",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "ask him; he is of age; he will speak for himself"
        },

        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "εἶπαν", Transliteration = "eipan", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γονεῖς", Transliteration = "goneis", Gloss = "parents",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "his parents"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐφοβοῦντο", Transliteration = "ephobounto", Gloss = "they feared",
                            GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Ἰουδαίους", Transliteration = "Ioudaious", Gloss = "Jews",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "the Jews"
                        }
                    },
                    Translation = "because they feared the Jews"
                }
            },
            Translation = "His parents said these things because they feared the Jews"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἤδη", Transliteration = "ēdē", Gloss = "already",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "συνετέθειντο", Transliteration = "synetetheinto", Gloss = "had agreed",
                    GrammarCodes = new List<string> { "V", "PLPF", "MID", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Ἰουδαῖοι", Transliteration = "Ioudaioi", Gloss = "Jews",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the Jews"
                }
            },
            Translation = "for already the Jews had agreed"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "that",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐάν", Transliteration = "ean", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "τις", Transliteration = "tis", Gloss = "anyone",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ὁμολογήσῃ", Transliteration = "homologēsē", Gloss = "confess",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "χριστόν", Transliteration = "christon", Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "if anyone should confess him as Christ"
                },
                new Word { Greek = "ἀποσυνάγωγος", Transliteration = "aposynagōgos", Gloss = "put out of the synagogue",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "γένηται", Transliteration = "genētai", Gloss = "he should be",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "that if anyone should confess him as Christ, he should be put out of the synagogue"
        },

        // Verse 23
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
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "for this reason"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γονεῖς", Transliteration = "goneis", Gloss = "parents",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "his parents"
                },
                new Word { Greek = "εἶπαν", Transliteration = "eipan", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἡλικίαν", Transliteration = "hēlikian", Gloss = "age",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἔχει", Transliteration = "echei", Gloss = "he has",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἐπερωτήσατε", Transliteration = "eperōtēsate", Gloss = "ask",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "He is of age, ask him"
                }
            },
            Translation = "For this reason his parents said, 'He is of age, ask him.'"
        },

        // Verse 24
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἐφώνησαν", Transliteration = "Ephōnēsan", Gloss = "they called",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἄνθρωπον", Transliteration = "anthrōpon", Gloss = "man",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the man"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "δευτέρου", Transliteration = "deuterou", Gloss = "second",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "a second time"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "τυφλὸς", Transliteration = "typhlos", Gloss = "blind",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "who had been blind"
                }
            },
            Translation = "So they called the man a second time who had been blind"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἶπαν", Transliteration = "eipan", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δὸς", Transliteration = "dos", Gloss = "give",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "δόξαν", Transliteration = "doxan", Gloss = "glory",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to God"
                        }
                    },
                    Translation = "Give glory to God"
                }
            },
            Translation = "and said to him, 'Give glory to God'"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis", Gloss = "we",
                    GrammarCodes = new List<string> { "PRON", "1P", "NOM", "P" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "οἴδαμεν", Transliteration = "oidamen", Gloss = "know",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἄνθρωπος", Transliteration = "anthrōpos", Gloss = "man",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "this man"
                        },
                        new Word { Greek = "ἁμαρτωλός", Transliteration = "hamartōlos", Gloss = "sinner",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that this man is a sinner"
                }
            },
            Translation = "we know that this man is a sinner"
        }
    };
}
/*
Constructions identified:
- Verse 18: Substantival Participle (τοῦ ἀναβλέψαντος)
- Verse 22: Purpose/Content Clause (ἵνα ... γένηται)
- Verse 22: Conditional Clause (ἐάν τις ... ὁμολογήσῃ)
- Verse 24: Idiomatic Prep Phrase (ἐκ δευτέρου)
*/
