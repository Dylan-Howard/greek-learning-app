private static List<object> GetChapter2()
{
    // Hebrews 2:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τὸν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "ACC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "βραχύ", Transliteration = "", Gloss = "little", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "τι", Transliteration = "", Gloss = "someone", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" }
                            },
                            Translation = "a little"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παρ᾽", Transliteration = "", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ἀγγέλους", Transliteration = "", Gloss = "angel", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "than the angels"
                        },
                        new Word { Greek = "ἠλαττωμένον", Transliteration = "", Gloss = "to make lower than", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "made lower a little than the angels"
                },
                new Word { Greek = "βλέπομεν", Transliteration = "", Gloss = "to see", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "Ἰησοῦν", Transliteration = "", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
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
                                new Word { Greek = "διὰ", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "πάθημα", Transliteration = "", Gloss = "suffering", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "θανάτου", Transliteration = "", Gloss = "death", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the suffering of death"
                                }
                            },
                            Translation = "because of the suffering of death"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δόξῃ", Transliteration = "", Gloss = "glory", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "τιμῇ", Transliteration = "", Gloss = "honor", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "with glory and honor"
                        },
                        new Word { Greek = "ἐστεφανωμένον", Transliteration = "", Gloss = "to crown", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "crowned with glory and honor because of the suffering of death"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπως", Transliteration = "", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "χάριτι", Transliteration = "", Gloss = "grace", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "θεοῦ", Transliteration = "", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "by the grace of God"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὲρ", Transliteration = "", Gloss = "above", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "παντὸς", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "for everyone"
                        },
                        new Word { Greek = "γεύσηται", Transliteration = "", Gloss = "to taste", GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "θανάτου", Transliteration = "", Gloss = "death", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "so that by the grace of God he might taste death for everyone"
                }
            },
            Translation = "But we see him who for a little while was made lower than the angels, namely Jesus, crowned with glory and honor because of the suffering of death, so that by the grace of God he might taste death for everyone."
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἔπρεπεν", Transliteration = "", Gloss = "to be proper", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "γὰρ", Transliteration = "", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "αὐτῷ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" },
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
                                new Word { Greek = "δι᾽", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὃν", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "for whom"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "πάντα", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "all things"
                        }
                    },
                    Translation = "for whom are all things"
                },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
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
                                new Word { Greek = "δι᾽", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "οὗ", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "through whom"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "πάντα", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "all things"
                        }
                    },
                    Translation = "and through whom are all things"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πολλοὺς", Transliteration = "", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" },
                                        new Word { Greek = "υἱοὺς", Transliteration = "", Gloss = "son", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "many sons"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "δόξαν", Transliteration = "", Gloss = "glory", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "to glory"
                                },
                                new Word { Greek = "ἀγαγόντα", Transliteration = "", Gloss = "to bring", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "in bringing many sons to glory"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἀρχηγὸν", Transliteration = "", Gloss = "author", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "σωτηρίας", Transliteration = "", Gloss = "salvation", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "αὐτῶν", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "the founder of their salvation"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "παθημάτων", Transliteration = "", Gloss = "suffering", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "through suffering"
                        },
                        new Word { Greek = "τελειῶσαι", Transliteration = "", Gloss = "to perfect", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to make the founder of their salvation perfect through suffering"
                }
            },
            Translation = "For it was fitting that he, for whom and by whom all things exist, in bringing many sons to glory, should make the founder of their salvation perfect through suffering."
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
                        new Word { Greek = "ὅ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "τε", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "γὰρ", Transliteration = "", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἁγιάζων", Transliteration = "", Gloss = "to sanctify", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "For he who sanctifies"
                },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἁγιαζόμενοι", Transliteration = "", Gloss = "to sanctify", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "those who are sanctified"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξ", Transliteration = "", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ἑνὸς", Transliteration = "", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "are all from one source"
                },
                new Word { Greek = "πάντες", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" }
            },
            Translation = "For he who sanctifies and those who are sanctified all have one source."
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
                        new Word { Greek = "δι᾽", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ἣν", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "αἰτίαν", Transliteration = "", Gloss = "charge", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "That is why"
                },
                new Word { Greek = "οὐκ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PRT", "NEG" }, PartOfSpeech = "particle" },
                new Word { Greek = "ἐπαισχύνεται", Transliteration = "", Gloss = "to be ashamed of", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
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
                                new Word { Greek = "ἀδελφοὺς", Transliteration = "", Gloss = "brother", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "αὐτοὺς", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "them brothers"
                        },
                        new Word { Greek = "καλεῖν", Transliteration = "", Gloss = "to call", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to call them brothers"
                }
            },
            Translation = "That is why he is not ashamed to call them brothers,"
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγων", Transliteration = "", Gloss = "say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" }, // Quote 1
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπαγγελῶ", Transliteration = "", Gloss = "to tell", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ὄνομά", Transliteration = "", Gloss = "name", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "σου", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "your name"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἀδελφοῖς", Transliteration = "", Gloss = "brother", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "μου", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "to my brothers"
                        }
                    },
                    Translation = "I will tell of your name to my brothers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" }, // Quote 2
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "μέσῳ", Transliteration = "", Gloss = "middle", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "ἐκκλησίας", Transliteration = "", Gloss = "church", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "in the midst of the congregation"
                        },
                        new Word { Greek = "ὑμνήσω", Transliteration = "", Gloss = "to sing hymns", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "σε", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "I will sing your praise"
                }
            },
            Translation = "saying, 'I will tell of your name to my brothers; in the midst of the congregation I will sing your praise.'"
        },
        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "πάλιν", Transliteration = "", Gloss = "again", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adjective" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐγὼ", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "VERB_PHRASE", "PERIPH" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔσομαι", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "πεποιθὼς", Transliteration = "", Gloss = "to convince", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "I will put my trust"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπ᾽", Transliteration = "", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "αὐτῷ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "in him"
                        }
                    },
                    Translation = "I will put my trust in him"
                },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "πάλιν", Transliteration = "", Gloss = "again", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adjective" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἰδοὺ", Transliteration = "", Gloss = "look!", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interjection" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐγὼ", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "τὰ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "παιδία", Transliteration = "", Gloss = "child", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "I and the children"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἅ", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "μοι", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "ἔδωκεν", Transliteration = "", Gloss = "to give", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὁ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "θεός", Transliteration = "", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "God"
                                }
                            },
                            Translation = "God has given me"
                        }
                    },
                    Translation = "Behold, I and the children God has given me"
                }
            },
            Translation = "And again, 'I will put my trust in him.' And again, 'Behold, I and the children God has given me.'"
        },
        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἐπεὶ", Transliteration = "", Gloss = "since", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "οὖν", Transliteration = "", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "παιδία", Transliteration = "", Gloss = "child", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the children"
                        },
                        new Word { Greek = "κεκοινώνηκεν", Transliteration = "", Gloss = "to share in", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αἵματος", Transliteration = "", Gloss = "blood", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "σαρκός", Transliteration = "", Gloss = "flesh", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "blood and flesh"
                        }
                    },
                    Translation = "Since therefore the children share in flesh and blood"
                },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "αὐτὸς", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "παραπλησίως", Transliteration = "", Gloss = "in just the same way", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adjective" },
                new Word { Greek = "μετέσχεν", Transliteration = "", Gloss = "to share in", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "αὐτῶν", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "the same things"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "θανάτου", Transliteration = "", Gloss = "death", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "through death"
                        },
                        new Word { Greek = "καταργήσῃ", Transliteration = "", Gloss = "to nullify", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "κράτος", Transliteration = "", Gloss = "power", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the power"
                                },
                                new Word { Greek = "ἔχοντα", Transliteration = "", Gloss = "to have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "θανάτου", Transliteration = "", Gloss = "death", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "of death"
                                }
                            },
                            Translation = "the one who has the power of death"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦτ᾽", Transliteration = "", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "adverb" },
                                new Word { Greek = "ἔστιν", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "διάβολον", Transliteration = "", Gloss = "devilish", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adjective" }
                                    },
                                    Translation = "the devil"
                                }
                            },
                            Translation = "that is, the devil"
                        }
                    },
                    Translation = "that through death he might destroy the one who has the power of death, that is, the devil"
                }
            },
            Translation = "Since therefore the children share in flesh and blood, he himself likewise partook of the same things, that through death he might destroy the one who has the power of death, that is, the devil,"
        },
        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" }, // Continuation of Purpose from v14 logically, but syntactically structured as coordinate
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἀπαλλάξῃ", Transliteration = "", Gloss = "to set free", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "τούτους", Transliteration = "", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅσοι", Transliteration = "", Gloss = "how great", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_CAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "φόβῳ", Transliteration = "", Gloss = "fear", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "θανάτου", Transliteration = "", Gloss = "death", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "through fear of death"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "παντὸς", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ζῆν", Transliteration = "", Gloss = "to be alive", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" }
                            },
                            Translation = "lifelong"
                        },
                        new Word { Greek = "ἔνοχοι", Transliteration = "", Gloss = "subject to", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἦσαν", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "δουλείας", Transliteration = "", Gloss = "slavery", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "who through fear of death were subject to lifelong slavery"
                }
            },
            Translation = "and deliver all those who through fear of death were subject to lifelong slavery."
        },
        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PRT", "NEG" }, PartOfSpeech = "preposition" },
                new Word { Greek = "γὰρ", Transliteration = "", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "δήπου", Transliteration = "", Gloss = "surely", GrammarCodes = new List<string> { "PRT" }, PartOfSpeech = "preposition" },
                new Word { Greek = "ἀγγέλων", Transliteration = "", Gloss = "angel", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "noun" },
                new Word { Greek = "ἐπιλαμβάνεται", Transliteration = "", Gloss = "to take hold", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "ἀλλὰ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σπέρματος", Transliteration = "", Gloss = "seed", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "Ἀβραὰμ", Transliteration = "", Gloss = "Abraham", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the offspring of Abraham"
                },
                new Word { Greek = "ἐπιλαμβάνεται", Transliteration = "", Gloss = "to take hold", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "For surely it is not angels that he helps, but he helps the offspring of Abraham."
        }
    };
}