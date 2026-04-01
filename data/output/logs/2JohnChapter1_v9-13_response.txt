MCP issues detected. Run /mcp list for status.private static List<object> GetChapter1()
{
    // 2 John 1:9-13
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Πᾶς", Transliteration = "Pas", Gloss = "Everyone", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "προάγων", Transliteration = "proagōn", Gloss = "going on ahead", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "the one going on ahead"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                                new Word { Greek = "μένων", Transliteration = "menōn", Gloss = "staying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "not staying"
                        },
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
                                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "διδαχῇ", Transliteration = "didachē", Gloss = "teaching", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "of Christ"
                                        }
                                    },
                                    Translation = "the teaching of Christ"
                                }
                            },
                            Translation = "in the teaching of Christ"
                        }
                    },
                    Translation = "Everyone going on ahead and not staying in the teaching of Christ"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θεὸν", Transliteration = "theon", Gloss = "God", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "God"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Word { Greek = "ἔχει", Transliteration = "echei", Gloss = "has", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Everyone who goes on ahead and does not stay in the teaching of Christ does not have God."
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
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "μένων", Transliteration = "menōn", Gloss = "staying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "the one staying"
                        },
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
                                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "διδαχῇ", Transliteration = "didachē", Gloss = "teaching", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the teaching"
                                }
                            },
                            Translation = "in the teaching"
                        }
                    },
                    Translation = "The one staying in the teaching"
                },
                new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this one", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "both", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πατέρα", Transliteration = "patera", Gloss = "Father", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Father"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "υἱὸν", Transliteration = "huion", Gloss = "Son", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Son"
                },
                new Word { Greek = "ἔχει", Transliteration = "echei", Gloss = "has", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "the one staying in the teaching, this one has both the Father and the Son."
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἴ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τις", Transliteration = "tis", Gloss = "anyone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "anyone"
                },
                new Word { Greek = "ἔρχεται", Transliteration = "erchetai", Gloss = "comes", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "to you"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταύτην", Transliteration = "tautēn", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "διδαχὴν", Transliteration = "didachēn", Gloss = "teaching", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "this teaching"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Word { Greek = "φέρει", Transliteration = "pherei", Gloss = "brings", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "If anyone comes to you and does not bring this teaching,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "do not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Word { Greek = "λαμβάνετε", Transliteration = "lambanete", Gloss = "receive", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἰκίαν", Transliteration = "oikian", Gloss = "house", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "[your] house"
                        }
                    },
                    Translation = "into your house"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χαίρειν", Transliteration = "chairein", Gloss = "greetings", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "greetings"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "to him"
                },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "do not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Word { Greek = "λέγετε", Transliteration = "legete", Gloss = "say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "do not receive him into your house and do not say 'Greetings' to him,"
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
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
                                new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "the one saying"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "to him"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "χαίρειν", Transliteration = "chairein", Gloss = "greetings", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "greetings"
                        }
                    },
                    Translation = "for the one saying to him 'Greetings'"
                },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κοινωνεῖ", Transliteration = "koinōnei", Gloss = "shares in", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἔργοις", Transliteration = "ergois", Gloss = "works", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "of him"
                        },
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "πονηροῖς", Transliteration = "ponērois", Gloss = "evil", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "his evil works"
                }
            },
            Translation = "for the one who says 'Greetings' to him shares in his evil works."
        },

        // Verse 12
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
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Πολλὰ", Transliteration = "Polla", Gloss = "many things", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "many things"
                        },
                        new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "to you"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "γράφειν", Transliteration = "graphein", Gloss = "to write", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "to write"
                        }
                    },
                    Translation = "Having many things to write to you"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Word { Greek = "ἐβουλήθην", Transliteration = "eboulēthēn", Gloss = "I wished", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "χάρτου", Transliteration = "chartou", Gloss = "paper", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "μέλανος", Transliteration = "melanos", Gloss = "ink", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "paper and ink"
                        }
                    },
                    Translation = "with paper and ink"
                }
            },
            Translation = "Having many things to write to you, I did not wish to do so with paper and ink,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all’", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐλπίζω", Transliteration = "elpizō", Gloss = "I hope", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γενέσθαι", Transliteration = "genesthai", Gloss = "to come", GrammarCodes = new List<string> { "V", "AOR", "MID", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "to you"
                        }
                    },
                    Translation = "to come to you"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "στόμα", Transliteration = "stoma", Gloss = "mouth", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "στόμα", Transliteration = "stoma", Gloss = "mouth", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "to mouth"
                        }
                    },
                    Translation = "mouth to mouth"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λαλῆσαι", Transliteration = "lalēsai", Gloss = "to speak", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "to speak"
                }
            },
            Translation = "but I hope to come to you and to speak face to face,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "χαρὰ", Transliteration = "chara", Gloss = "joy", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "our"
                        }
                    },
                    Translation = "our joy"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PERIPH" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ᾖ", Transliteration = "ē", Gloss = "may be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "πεπληρωμένη", Transliteration = "peplērōmenē", Gloss = "fulfilled", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "may be fulfilled"
                }
            },
            Translation = "so that our joy may be fulfilled."
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀσπάζεταί", Transliteration = "Aspazetai", Gloss = "Greets", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σε", Transliteration = "se", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "τέκνα", Transliteration = "tekna", Gloss = "children", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀδελφῆς", Transliteration = "adelphēs", Gloss = "sister", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "pron" }
                                    },
                                    Translation = "your"
                                },
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐκλεκτῆς", Transliteration = "eklektēs", Gloss = "elect", GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "of your elect sister"
                        }
                    },
                    Translation = "the children of your elect sister"
                }
            },
            Translation = "The children of your elect sister greet you."
        }
    };
}
/*
Constructions identified:
- PERIPH (Periphrastic construction): ᾖ πεπληρωμένη (2 John 1:12)
- GEN_DESC (Descriptive/Attributive Genitive): τοῦ Χριστοῦ (v9), αὐτοῦ (v11), τῆς ἀδελφῆς... τῆς ἐκλεκτῆς (v13), σου (v13)
- GEN_SUBJ (Subjective Genitive): ἡμῶν (v12)
- INF_PHRASE used as direct object or complement: χαίρειν (v10, v11), γράφειν (v12), γενέσθαι (v12), λαλῆσαι (v12)
*/
