private static List<object> GetChapter2()
{
    // 1 Corinthians 2:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Κἀγὼ", Transliteration = "kagō", Gloss = "And I", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλθὼν", Transliteration = "elthōn", Gloss = "having come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "to you"
                        }
                    },
                    Translation = "when I came to you"
                },
                new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers", GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "noun" },
                new Word { Greek = "ἦλθον", Transliteration = "ēlthon", Gloss = "I came", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθ᾽", Transliteration = "kath'", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ὑπεροχὴν", Transliteration = "hyperochēn", Gloss = "superiority", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "λόγου", Transliteration = "logou", Gloss = "of speech", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "σοφίας", Transliteration = "sophias", Gloss = "wisdom", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "of speech or wisdom"
                        }
                    },
                    Translation = "with superiority of speech or wisdom"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καταγγέλλων", Transliteration = "katangellōn", Gloss = "proclaiming", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "P" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "μυστήριον", Transliteration = "mystērion", Gloss = "mystery", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "the mystery of God"
                        }
                    },
                    Translation = "proclaiming to you the mystery of God"
                }
            },
            Translation = "And I, when I came to you, brothers, did not come with superiority of speech or wisdom, proclaiming to you the mystery of God."
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἔκρινά", Transliteration = "ekrina", Gloss = "I decided", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τι", Transliteration = "ti", Gloss = "anything", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "εἰδέναι", Transliteration = "eidenai", Gloss = "to know", GrammarCodes = new List<string> { "V", "PERF", "ACT", "INF" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "among you"
                        }
                    },
                    Translation = "to know anything among you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Ἰησοῦν", Transliteration = "Iēsoun", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "Χριστὸν", Transliteration = "Christon", Gloss = "Christ", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "Jesus Christ"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦτον", Transliteration = "touton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "ἐσταυρωμένον", Transliteration = "estaurōmenon", Gloss = "having been crucified", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "him crucified"
                        }
                    },
                    Translation = "except Jesus Christ and him crucified"
                }
            },
            Translation = "For I decided to know nothing among you except Jesus Christ and him crucified."
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "κἀγὼ", Transliteration = "kagō", Gloss = "And I", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ἀσθενείᾳ", Transliteration = "astheneia", Gloss = "weakness", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in weakness"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "φόβῳ", Transliteration = "phobō", Gloss = "fear", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in fear"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "τρόμῳ", Transliteration = "tromō", Gloss = "trembling", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "πολλῷ", Transliteration = "pollō", Gloss = "much", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "in much trembling"
                },
                new Word { Greek = "ἐγενόμην", Transliteration = "egenomēn", Gloss = "I was", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "with you"
                }
            },
            Translation = "And I was with you in weakness and in fear and in much trembling."
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "λόγος", Transliteration = "logos", Gloss = "speech", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "my", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "my speech"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "κήρυγμά", Transliteration = "kerygma", Gloss = "preaching", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "my", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "my preaching"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "πειθοῖς", Transliteration = "peithois", Gloss = "persuasive", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "σοφίας", Transliteration = "sophias", Gloss = "of wisdom", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "λόγοις", Transliteration = "logois", Gloss = "words", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "words of wisdom"
                        }
                    },
                    Translation = "with persuasive words of wisdom"
                },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ἀποδείξει", Transliteration = "apodeixei", Gloss = "demonstration", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πνεύματος", Transliteration = "pneumatos", Gloss = "of Spirit", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "δυνάμεως", Transliteration = "dynameōs", Gloss = "power", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "of Spirit and power"
                        }
                    },
                    Translation = "with demonstration of the Spirit and of power"
                }
            },
            Translation = "And my speech and my preaching were not with persuasive words of wisdom, but with demonstration of the Spirit and of power,"
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "πίστις", Transliteration = "pistis", Gloss = "faith", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "your faith"
                },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "ᾖ", Transliteration = "ē", Gloss = "might be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "σοφίᾳ", Transliteration = "sophia", Gloss = "wisdom", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ἀνθρώπων", Transliteration = "anthrōpōn", Gloss = "of men", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in the wisdom of men"
                },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "δυνάμει", Transliteration = "dynamei", Gloss = "power", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in the power of God"
                }
            },
            Translation = "so that your faith might not be in the wisdom of men but in the power of God."
        },

        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Σοφίαν", Transliteration = "Sophian", Gloss = "Wisdom", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "yet", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "λαλοῦμεν", Transliteration = "laloumen", Gloss = "we speak", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "τελείοις", Transliteration = "teleiois", Gloss = "mature", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "among the mature"
                },
                new Word { Greek = "σοφίαν", Transliteration = "sophian", Gloss = "a wisdom", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "yet", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "αἰῶνος", Transliteration = "aiōnos", Gloss = "age", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "τούτου", Transliteration = "toutou", Gloss = "this", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "of this age"
                },
                new Word { Greek = "οὐδὲ", Transliteration = "oude", Gloss = "nor", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἀρχόντων", Transliteration = "archontōn", Gloss = "rulers", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "αἰῶνος", Transliteration = "aiōnos", Gloss = "age", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "τούτου", Transliteration = "toutou", Gloss = "this", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "of this age"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "who", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "καταργουμένων", Transliteration = "katargoumenōn", Gloss = "are coming to nothing", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "who are coming to nothing"
                        }
                    },
                    Translation = "of the rulers of this age, who are coming to nothing"
                }
            },
            Translation = "Yet among the mature we do speak wisdom, although it is not a wisdom of this age or of the rulers of this age, who are coming to nothing."
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "λαλοῦμεν", Transliteration = "laloumen", Gloss = "we speak", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "σοφίαν", Transliteration = "sophian", Gloss = "wisdom", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "God's wisdom"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "μυστηρίῳ", Transliteration = "mystēriō", Gloss = "mystery", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in a mystery"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἀποκεκρυμμένην", Transliteration = "apokekrymmenēn", Gloss = "having been hidden", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "ACC", "F", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "the hidden wisdom"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἣν", Transliteration = "hēn", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "προώρισεν", Transliteration = "proōrisen", Gloss = "predestined", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "God"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸ", Transliteration = "pro", Gloss = "before", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "αἰώνων", Transliteration = "aiōnōn", Gloss = "ages", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "before the ages"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "δόξαν", Transliteration = "doxan", Gloss = "glory", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "our", GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "for our glory"
                        }
                    },
                    Translation = "which God predestined before the ages for our glory"
                }
            },
            Translation = "But we speak God's wisdom in a mystery, the hidden wisdom which God predestined before the ages for our glory."
        },

        // Verse 8
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
                        new Word { Greek = "ἣν", Transliteration = "hēn", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "which"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐδεὶς", Transliteration = "oudeis", Gloss = "no one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἀρχόντων", Transliteration = "archontōn", Gloss = "rulers", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "αἰῶνος", Transliteration = "aiōnos", Gloss = "age", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "τούτου", Transliteration = "toutou", Gloss = "this", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "of this age"
                                }
                            },
                            Translation = "of the rulers of this age"
                        }
                    },
                    Translation = "none of the rulers of this age"
                },
                new Word { Greek = "ἔγνωκεν", Transliteration = "egnōken", Gloss = "has understood", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἔγνωσαν", Transliteration = "egnōsan", Gloss = "they had understood", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "would have", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "κύριον", Transliteration = "kyrion", Gloss = "Lord", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "δόξης", Transliteration = "doxēs", Gloss = "glory", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "of glory"
                                }
                            },
                            Translation = "the Lord of glory"
                        },
                        new Word { Greek = "ἐσταύρωσαν", Transliteration = "estaurōsan", Gloss = "crucified", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "for if they had understood, they would not have crucified the Lord of glory"
                }
            },
            Translation = "None of the rulers of this age has understood this, for if they had understood it, they would not have crucified the Lord of glory."
        }
    };
}

/*
Constructions identified:
- GEN_SUBJ / GEN_DESC: "μυστήριον τοῦ θεοῦ" (v1), "σοφίας λόγου" (v1), "σοφίας λόγοις" (v4), "πειθοῖς σοφίας" (v4), "ἀποδείξει πνεύματος" (v4), "σοφίᾳ ἀνθρώπων" (v5), "δυνάμει θεοῦ" (v5), "ἀρχόντων τοῦ αἰῶνος" (v6, v8), "θεοῦ σοφίαν" (v7), "κύριον τῆς δόξης" (v8)
- COND_CLAUSE: Second-class conditional (contrary to fact) in v8 (εἰ ... ἔγνωσαν ... οὐκ ἂν ... ἐσταύρωσαν)
- PTCP (adverbial/circumstantial): ἐλθὼν (v1), καταγγέλλων (v1), καταργουμένων (v6)
- PTCP (adjectival/attributive): ἐσταυρωμένον (v2), ἀποκεκρυμμένην (v7)
*/
