private static List<object> GetChapter1()
{
    // Romans 1:1-8
    return new List<object>
    {
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // Verse 1
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Παῦλος", Transliteration = "Paulos", Gloss = "Paul",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "δοῦλος", Transliteration = "doulos", Gloss = "servant",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of Christ Jesus"
                        },
                        new Word { Greek = "κλητὸς", Transliteration = "klētos", Gloss = "called",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἀπόστολος", Transliteration = "apostolos", Gloss = "apostle",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Paul, a servant of Christ Jesus, called to be an apostle"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀφωρισμένος", Transliteration = "aphōrismenos", Gloss = "set apart",
                            GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εὐαγγέλιον", Transliteration = "euangelion", Gloss = "gospel",
                                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the gospel of God"
                                }
                            },
                            Translation = "for the gospel of God"
                        }
                    },
                    Translation = "set apart for the gospel of God"
                },
                // Verse 2
                // (continues verse 1)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "προεπηγγείλατο", Transliteration = "proepēngeilato", Gloss = "promised beforehand",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "προφητῶν", Transliteration = "prophētōn", Gloss = "prophets",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                                    },
                                    Translation = "his prophets"
                                }
                            },
                            Translation = "through his prophets"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "γραφαῖς", Transliteration = "graphais", Gloss = "Scriptures",
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ἁγίαις", Transliteration = "hagiais", Gloss = "holy",
                                            GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "holy Scriptures"
                                }
                            },
                            Translation = "in the holy Scriptures"
                        }
                    },
                    Translation = "which he promised beforehand through his prophets in the holy Scriptures"
                },
                // Verse 3
                // (continues verse 1)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "υἱοῦ", Transliteration = "huiou", Gloss = "Son",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "his Son"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "γενομένου", Transliteration = "genomenou", Gloss = "descended",
                                    GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "σπέρματος", Transliteration = "spermatos", Gloss = "seed",
                                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "Δαυὶδ", Transliteration = "Dauid", Gloss = "David",
                                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "the seed of David"
                                        }
                                    },
                                    Translation = "from the seed of David"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to",
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "σάρκα", Transliteration = "sarka", Gloss = "flesh",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "according to the flesh"
                                }
                            },
                            Translation = "who was descended from the seed of David according to the flesh"
                        }
                    },
                    Translation = "concerning his Son, who was descended from David according to the flesh"
                },
                // Verse 4
                // (continues verse 1)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὁρισθέντος", Transliteration = "horisthentos", Gloss = "designated",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "υἱοῦ", Transliteration = "huiou", Gloss = "Son",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Son of God"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "δυνάμει", Transliteration = "dynamei", Gloss = "power",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in power"
                        },
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
                                        new Word { Greek = "πνεῦμα", Transliteration = "pneuma", Gloss = "Spirit",
                                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ἁγιωσύνης", Transliteration = "hagiōsynēs", Gloss = "holiness",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the Spirit of holiness"
                                }
                            },
                            Translation = "according to the Spirit of holiness"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "by",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀναστάσεως", Transliteration = "anastaseōs", Gloss = "resurrection",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "νεκρῶν", Transliteration = "nekrōn", Gloss = "dead",
                                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "resurrection from the dead"
                                }
                            },
                            Translation = "by resurrection from the dead"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "our",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "pron" }
                                    },
                                    Translation = "our Lord"
                                }
                            },
                            Translation = "Jesus Christ our Lord"
                        }
                    },
                    Translation = "and was designated Son of God in power according to the Spirit of holiness by his resurrection from the dead, Jesus Christ our Lord"
                },
                // Verse 5
                // (continues verse 1)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "through",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἐλάβομεν", Transliteration = "elabomen", Gloss = "we received",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "χάριν", Transliteration = "charin", Gloss = "grace",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "ἀποστολὴν", Transliteration = "apostolēn", Gloss = "apostleship",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "grace and apostleship"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὑπακοὴν", Transliteration = "hypakoēn", Gloss = "obedience",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "πίστεως", Transliteration = "pisteōs", Gloss = "faith",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the obedience of faith"
                                }
                            },
                            Translation = "to bring about the obedience of faith"
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
                                        new Word { Greek = "πᾶσιν", Transliteration = "pasin", Gloss = "all",
                                            GrammarCodes = new List<string> { "ADJ", "DAT", "N", "P" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἔθνεσιν", Transliteration = "ethnesin", Gloss = "nations",
                                            GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "all the nations"
                                }
                            },
                            Translation = "among all the nations"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "for the sake of",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ὀνόματος", Transliteration = "onomatos", Gloss = "name",
                                            GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                                    },
                                    Translation = "his name"
                                }
                            },
                            Translation = "for the sake of his name"
                        }
                    },
                    Translation = "through whom we received grace and apostleship for the obedience of faith among all the nations for the sake of his name"
                },
                // Verse 6
                // (continues verse 1)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οἷς", Transliteration = "hois", Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "DAT", "N", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "are",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κλητοὶ", Transliteration = "klētoi", Gloss = "called",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "called ones of Jesus Christ"
                        }
                    },
                    Translation = "among whom you also are called ones of Jesus Christ"
                },
                // Verse 7
                // (continues verse 1)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶσιν", Transliteration = "pasin", Gloss = "to all",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the ones",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οὖσιν", Transliteration = "ousin", Gloss = "being",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "Ῥώμῃ", Transliteration = "Rhōmē", Gloss = "Rome",
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "in Rome"
                                }
                            },
                            Translation = "who are in Rome"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀγαπητοῖς", Transliteration = "agapētois", Gloss = "beloved",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "beloved of God"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κλητοῖς", Transliteration = "klētois", Gloss = "called",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἁγίοις", Transliteration = "hagiois", Gloss = "saints",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "called to be saints"
                        }
                    },
                    Translation = "To all those in Rome who are beloved of God and called to be saints"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χάρις", Transliteration = "charis", Gloss = "grace",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "εἰρήνη", Transliteration = "eirēnē", Gloss = "peace",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Grace to you and peace"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "πατρὸς", Transliteration = "patros", Gloss = "Father",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "our",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "God our Father"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Lord Jesus Christ"
                        }
                    },
                    Translation = "from God our Father and the Lord Jesus Christ"
                }
            },
            Translation = "Paul, a servant of Christ Jesus, called to be an apostle, set apart for the gospel of God... To all those in Rome who are beloved of God and called to be saints: Grace to you and peace from God our Father and the Lord Jesus Christ."
        },
        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Πρῶτον", Transliteration = "Prōton", Gloss = "First",
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed",
                    GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Word { Greek = "εὐχαριστῶ", Transliteration = "eucharistō", Gloss = "I thank",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "my",
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "my God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Jesus Christ"
                        }
                    },
                    Translation = "through Jesus Christ"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "all of you"
                        }
                    },
                    Translation = "for all of you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πίστις", Transliteration = "pistis", Gloss = "faith",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "your",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "your faith"
                        },
                        new Word { Greek = "καταγγέλλεται", Transliteration = "katangelletai", Gloss = "is proclaimed",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὅλῳ", Transliteration = "holō", Gloss = "all",
                                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κόσμῳ", Transliteration = "kosmō", Gloss = "world",
                                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the whole world"
                                }
                            },
                            Translation = "in the whole world"
                        }
                    },
                    Translation = "because your faith is proclaimed in the whole world"
                }
            },
            Translation = "First, I thank my God through Jesus Christ for all of you, because your faith is proclaimed in the whole world."
        }
    };
}

/*
Constructions Identified:
- NOUN_PHRASE [SUBJ] (v1: Παῦλος δοῦλος...)
- REL_CLAUSE (v2: ὃ προεπηγγείλατο...)
- NOUN_PHRASE [OBJ] (v3: τοῦ υἱοῦ αὐτοῦ)
- PTCP [Appositive] (v3: τοῦ γενομένου...)
- PTCP [Appositive] (v4: τοῦ ὁρισθέντος...)
- NOUN_PHRASE [PRED] (v4: υἱοῦ θεοῦ)
- APPOS (v4: Ἰησοῦ Χριστοῦ...)
- REL_CLAUSE (v5: δι᾽ οὗ...)
- NOUN_PHRASE [OBJ] (v5: χάριν καὶ ἀποστολὴν)
- REL_CLAUSE (v6: ἐν οἷς...)
- NOUN_PHRASE [IND_OBJ] (v7: πᾶσιν τοῖς οὖσιν...)
- NOUN_PHRASE [SUBJ] (v7: χάρις... καὶ εἰρήνη)
- NOUN_PHRASE [IND_OBJ] (v8: τῷ θεῷ μου)
- CAUSAL_CLAUSE (v8: ὅτι ἡ πίστις...)
*/
