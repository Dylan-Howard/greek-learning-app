MCP issues detected. Run /mcp list for status.private static List<object> GetChapter2()
{
    // James 2:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὕτως", Transliteration = "", Gloss = "in this way", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "πίστις", Transliteration = "", Gloss = "faith", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "faith"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "μὴ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PRT" }, PartOfSpeech = "particle" },
                        new Word { Greek = "ἔχῃ", Transliteration = "", Gloss = "to have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔργα", Transliteration = "", Gloss = "work", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "works"
                        }
                    },
                    Translation = "if it does not have works"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PRED_ADJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "νεκρά", Transliteration = "", Gloss = "dead", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "dead"
                },
                new Word { Greek = "ἐστιν", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθ᾽", Transliteration = "", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ἑαυτήν", Transliteration = "", Gloss = "himself", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "by itself"
                }
            },
            Translation = "So also faith by itself, if it does not have works, is dead."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀλλ᾽", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐρεῖ", Transliteration = "", Gloss = "say", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τις", Transliteration = "", Gloss = "someone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "someone"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὺ", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "S", "2P" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πίστιν", Transliteration = "", Gloss = "faith", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "faith"
                        },
                        new Word { Greek = "ἔχεις", Transliteration = "", Gloss = "to have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "You have faith"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κἀγὼ", Transliteration = "", Gloss = "and I", GrammarCodes = new List<string> { "PRON", "NOM", "S", "1P" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔργα", Transliteration = "", Gloss = "work", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "works"
                        },
                        new Word { Greek = "ἔχω", Transliteration = "", Gloss = "to have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "and I have works"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δεῖξόν", Transliteration = "", Gloss = "to show", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "μοι", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "DAT", "S", "1P" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "πίστιν", Transliteration = "", Gloss = "faith", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "σου", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "GEN", "S", "2P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "your faith"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "χωρὶς", Transliteration = "", Gloss = "by itself", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἔργων", Transliteration = "", Gloss = "work", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the works"
                                }
                            },
                            Translation = "apart from works"
                        },
                        new Word { Greek = "κἀγώ", Transliteration = "", Gloss = "and I", GrammarCodes = new List<string> { "PRON", "NOM", "S", "1P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "σοι", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "S", "2P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "δείξω", Transliteration = "", Gloss = "to show", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἔργων", Transliteration = "", Gloss = "work", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "μου", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "GEN", "S", "1P" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "my works"
                                }
                            },
                            Translation = "by my works"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "πίστιν", Transliteration = "", Gloss = "faith", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "faith"
                        }
                    },
                    Translation = "Show me your faith apart from your works, and I will show you my faith by my works"
                }
            },
            Translation = "But someone will say, 'You have faith and I have works.' Show me your faith apart from your works, and I will show you my faith by my works."
        },

        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "σὺ", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "S", "2P" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "πιστεύεις", Transliteration = "", Gloss = "to believe", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "εἷς", Transliteration = "", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἐστιν", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
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
                    Translation = "that God is one"
                }
            },
            Translation = "You believe that God is one;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" }, // (continues verse 19)
            Content = new List<object>
            {
                new Word { Greek = "καλῶς", Transliteration = "", Gloss = "rightly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "ποιεῖς", Transliteration = "", Gloss = "to do", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "δαιμόνια", Transliteration = "", Gloss = "demon", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the demons"
                },
                new Word { Greek = "πιστεύουσιν", Transliteration = "", Gloss = "to believe", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "φρίσσουσιν", Transliteration = "", Gloss = "to shudder", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" }
            },
            Translation = "you do well. Even the demons believe—and shudder!"
        },

        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Θέλεις", Transliteration = "", Gloss = "to will", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γνῶναι", Transliteration = "", Gloss = "to know", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἡ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "πίστις", Transliteration = "", Gloss = "faith", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "faith"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "χωρὶς", Transliteration = "", Gloss = "by itself", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἔργων", Transliteration = "", Gloss = "work", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "works"
                                }
                                    },
                                    Translation = "apart from works"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PRED_ADJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀργή", Transliteration = "", Gloss = "idle", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adjective" }
                                    },
                                    Translation = "useless"
                                },
                                new Word { Greek = "ἐστιν", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "that faith apart from works is useless"
                        }
                    },
                    Translation = "to know... that faith apart from works is useless"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὦ", Transliteration = "", Gloss = "Oh!", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interjection" },
                        new Word { Greek = "ἄνθρωπε", Transliteration = "", Gloss = "human being", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "κενέ", Transliteration = "", Gloss = "empty", GrammarCodes = new List<string> { "ADJ", "VOC", "M", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "you foolish person"
                }
            },
            Translation = "Do you want to be shown, you foolish person, that faith apart from works is useless?"
        },

        // Verse 21
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
                        new Word { Greek = "Ἀβραὰμ", Transliteration = "", Gloss = "Abraham", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "πατὴρ", Transliteration = "", Gloss = "father", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἡμῶν", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "GEN", "P", "1P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "our father"
                        }
                    },
                    Translation = "Abraham our father"
                },
                new Word { Greek = "οὐκ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PRT" }, PartOfSpeech = "particle" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξ", Transliteration = "", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔργων", Transliteration = "", Gloss = "work", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "works"
                        }
                    },
                    Translation = "by works"
                },
                new Word { Greek = "ἐδικαιώθη", Transliteration = "", Gloss = "to justify", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνενέγκας", Transliteration = "", Gloss = "to lead up", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Ἰσαὰκ", Transliteration = "", Gloss = "Isaac", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "APPOS" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "υἱὸν", Transliteration = "", Gloss = "son", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "3S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "his son"
                                }
                            },
                            Translation = "Isaac his son"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "θυσιαστήριον", Transliteration = "", Gloss = "altar", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the altar"
                                }
                            },
                            Translation = "on the altar"
                        }
                    },
                    Translation = "when he offered up his son Isaac on the altar"
                }
            },
            Translation = "Was not Abraham our father justified by works when he offered up his son Isaac on the altar?"
        },

        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "βλέπεις", Transliteration = "", Gloss = "to see", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "πίστις", Transliteration = "", Gloss = "faith", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "faith"
                        },
                        new Word { Greek = "συνήργει", Transliteration = "", Gloss = "to work together", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἔργοις", Transliteration = "", Gloss = "work", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "3S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "his works"
                        },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἔργων", Transliteration = "", Gloss = "work", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "works"
                                }
                            },
                            Translation = "by works"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "πίστις", Transliteration = "", Gloss = "faith", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "faith"
                        },
                        new Word { Greek = "ἐτελειώθη", Transliteration = "", Gloss = "to perfect", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "that faith was active along with his works, and faith was completed by his works"
                }
            },
            Translation = "You see that faith was active along with his works, and faith was completed by his works;"
        },

        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐπληρώθη", Transliteration = "", Gloss = "to fulfill", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "γραφὴ", Transliteration = "", Gloss = "a passage of Scripture", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "λέγουσα", Transliteration = "", Gloss = "say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "that says"
                        }
                    },
                    Translation = "the Scripture"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπίστευσεν", Transliteration = "", Gloss = "to believe", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Ἀβραὰμ", Transliteration = "", Gloss = "Abraham", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "Abraham"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "θεῷ", Transliteration = "", Gloss = "God", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "God"
                        },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἐλογίσθη", Transliteration = "", Gloss = "to credit", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "αὐτῷ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "DAT", "M", "3S" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "δικαιοσύνην", Transliteration = "", Gloss = "righteousness", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "righteousness"
                                }
                            },
                            Translation = "as righteousness"
                        }
                    },
                    Translation = "Abraham believed God, and it was counted to him as righteousness"
                },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φίλος", Transliteration = "", Gloss = "friendly", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "θεοῦ", Transliteration = "", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "friend of God"
                },
                new Word { Greek = "ἐκλήθη", Transliteration = "", Gloss = "to call", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "and the Scripture was fulfilled that says, 'Abraham believed God, and it was counted to him as righteousness'—and he was called a friend of God."
        },

        // Verse 24
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁρᾶτε", Transliteration = "", Gloss = "to see", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐξ", Transliteration = "", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἔργων", Transliteration = "", Gloss = "work", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "works"
                                }
                            },
                            Translation = "by works"
                        },
                        new Word { Greek = "δικαιοῦται", Transliteration = "", Gloss = "to justify", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἄνθρωπος", Transliteration = "", Gloss = "human being", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "a person"
                        },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "οὐκ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PRT" }, PartOfSpeech = "particle" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πίστεως", Transliteration = "", Gloss = "faith", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "faith"
                                }
                            },
                            Translation = "by faith"
                        },
                        new Word { Greek = "μόνον", Transliteration = "", Gloss = "only", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" }
                    },
                    Translation = "that a person is justified by works and not by faith alone"
                }
            },
            Translation = "You see that a person is justified by works and not by faith alone."
        }
    };
}

// Constructions identified:
// Verse 17: COND_CLAUSE (ἐὰν ... ἔχῃ)
// Verse 20: INF_PHRASE (γνῶναι), DEP_CLAUSE (ὅτι ...)
// Verse 21: PTCP (ἀνενέγκας) used as temporal/circumstantial
// Verse 22: DEP_CLAUSE (ὅτι ...)
// Verse 23: Direct Citation (ἐπίστευσεν ...), PRED (φίλος)
