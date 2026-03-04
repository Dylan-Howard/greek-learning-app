private static List<object> GetChapter8()
{
    // Romans 8:25-32
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "βλέπομεν", Transliteration = "blepomen", Gloss = "we see",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "what we do not see"
                },
                new Word { Greek = "ἐλπίζομεν", Transliteration = "elpizomen", Gloss = "we hope for",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "But if we hope for what we do not see,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 25)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "through",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὑπομονῆς", Transliteration = "hypomonēs", Gloss = "perseverance",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "through perseverance"
                },
                new Word { Greek = "ἀπεκδεχόμεθα", Transliteration = "apekdechometha", Gloss = "we wait eagerly for",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "we wait eagerly for it through perseverance."
        },

        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ὡσαύτως", Transliteration = "Hōsautōs", Gloss = "likewise",
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πνεῦμα", Transliteration = "pneuma", Gloss = "Spirit",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Spirit"
                },
                new Word { Greek = "συναντιλαμβάνεται", Transliteration = "synantilambanetai", Gloss = "helps",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀσθενείᾳ", Transliteration = "astheneia", Gloss = "weakness",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us",
                            GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "our weakness"
                }
            },
            Translation = "In the same way, the Spirit also helps our weakness;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 26)
                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τί", Transliteration = "ti", Gloss = "what",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "interj" },
                new Word { Greek = "προσευξώμεθα", Transliteration = "proseuxōmetha", Gloss = "we should pray",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "1P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "καθὸ", Transliteration = "katho", Gloss = "as",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "δεῖ", Transliteration = "dei", Gloss = "it is necessary",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "οἴδαμεν", Transliteration = "oidamen", Gloss = "we know",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "for we do not know what we should pray for as is necessary,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 26)
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτὸ", Transliteration = "auto", Gloss = "itself",
                            GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πνεῦμα", Transliteration = "pneuma", Gloss = "Spirit",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Spirit Himself"
                },
                new Word { Greek = "ὑπερεντυγχάνει", Transliteration = "hyperentynchanei", Gloss = "intercedes",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                    Content = new List<object>
                    {
                        new Word { Greek = "στεναγμοῖς", Transliteration = "stenagmois", Gloss = "with groanings",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἀλαλήτοις", Transliteration = "alalētois", Gloss = "inexpressible",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "with groanings too deep for words"
                }
            },
            Translation = "but the Spirit Himself intercedes for us with inexpressible groanings."
        },

        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐραυνῶν", Transliteration = "eraunōn", Gloss = "searching",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "καρδίας", Transliteration = "kardias", Gloss = "hearts",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the hearts"
                        }
                    },
                    Translation = "And He who searches the hearts"
                },
                new Word { Greek = "οἶδεν", Transliteration = "oiden", Gloss = "knows",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti", Gloss = "what",
                            GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "interj" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "φρόνημα", Transliteration = "phronēma", Gloss = "mind",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πνεύματος", Transliteration = "pneumatos", Gloss = "Spirit",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the Spirit"
                        }
                    },
                    Translation = "what the mind of the Spirit is"
                }
            },
            Translation = "And He who searches the hearts knows what the mind of the Spirit is,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 27)
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "θεὸν", Transliteration = "theon", Gloss = "God",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "according to God"
                },
                new Word { Greek = "ἐντυγχάνει", Transliteration = "entynchanei", Gloss = "He intercedes",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἁγίων", Transliteration = "hagiōn", Gloss = "saints",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "for the saints"
                }
            },
            Translation = "because He intercedes for the saints according to the will of God."
        },

        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Οἴδαμεν", Transliteration = "Oidamen", Gloss = "we know",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "for those",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγαπῶσιν", Transliteration = "agapōsin", Gloss = "loving",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεὸν", Transliteration = "theon", Gloss = "God",
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "God"
                                }
                            },
                            Translation = "for those who love God"
                        },
                        new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all things",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "συνεργεῖ", Transliteration = "synergei", Gloss = "work together",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἀγαθόν", Transliteration = "agathon", Gloss = "good",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "for good"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to those",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to",
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "πρόθεσιν", Transliteration = "prothesin", Gloss = "purpose",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "according to purpose"
                                },
                                new Word { Greek = "κλητοῖς", Transliteration = "klētois", Gloss = "called",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "οὖσιν", Transliteration = "ousin", Gloss = "being",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "to those who are called according to His purpose"
                        }
                    },
                    Translation = "that all things work together for good for those who love God, to those who are called according to His purpose"
                }
            },
            Translation = "And we know that for those who love God all things work together for good, for those who are called according to His purpose."
        },

        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὓς", Transliteration = "hous", Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "προέγνω", Transliteration = "proegnō", Gloss = "He foreknew",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "whom He foreknew"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "προώρισεν", Transliteration = "proōrisen", Gloss = "He predestined",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "ADJ", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συμμόρφους", Transliteration = "symmorphous", Gloss = "conformed",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "to the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "εἰκόνος", Transliteration = "eikonos", Gloss = "image",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "υἱοῦ", Transliteration = "huiou", Gloss = "Son",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of Him",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "of His Son"
                                }
                            },
                            Translation = "to the image of His Son"
                        }
                    },
                    Translation = "conformed to the image of His Son"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "PURPOSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "Him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "πρωτότοκον", Transliteration = "prōtotokon", Gloss = "firstborn",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "πολλοῖς", Transliteration = "pollois", Gloss = "many",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἀδελφοῖς", Transliteration = "adelphois", Gloss = "brothers",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "among many brothers"
                        }
                    },
                    Translation = "so that He might be the firstborn among many brothers"
                }
            },
            Translation = "Because those whom He foreknew, He also predestined to be conformed to the image of His Son, so that He might be the firstborn among many brothers;"
        },

        // Verse 30
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὓς", Transliteration = "hous", Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "προώρισεν", Transliteration = "proōrisen", Gloss = "He predestined",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "and whom He predestined"
                },
                new Word { Greek = "τούτους", Transliteration = "toutous", Gloss = "these",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐκάλεσεν", Transliteration = "ekalesen", Gloss = "He called",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "and these whom He predestined, He also called;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 30)
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὓς", Transliteration = "hous", Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἐκάλεσεν", Transliteration = "ekalesen", Gloss = "He called",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "whom He called"
                },
                new Word { Greek = "τούτους", Transliteration = "toutous", Gloss = "these",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐδικαίωσεν", Transliteration = "edikaiōsen", Gloss = "He justified",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "and whom He called, these He also justified;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 30)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὓς", Transliteration = "hous", Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐδικαίωσεν", Transliteration = "edikaiōsen", Gloss = "He justified",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "and whom He justified"
                },
                new Word { Greek = "τούτους", Transliteration = "toutous", Gloss = "these",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐδόξασεν", Transliteration = "edoxasen", Gloss = "He glorified",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "and whom He justified, these He also glorified."
        },

        // Verse 31
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τί", Transliteration = "Ti", Gloss = "What",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "interj" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐροῦμεν", Transliteration = "eroumen", Gloss = "shall we say",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "adv" }
                    },
                    Translation = "to these things"
                }
            },
            Translation = "What then shall we say to these things?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 31)
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
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "us",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "for us"
                        }
                    },
                    Translation = "If God is for us"
                },
                new Word { Greek = "τίς", Transliteration = "tis", Gloss = "who",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθ᾽", Transliteration = "kath'", Gloss = "against",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "us",
                            GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "against us"
                }
            },
            Translation = "If God is for us, who can be against us?"
        },

        // Verse 32
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅς", Transliteration = "hos", Gloss = "He who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "γε", Transliteration = "ge", Gloss = "indeed",
                            GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἰδίου", Transliteration = "idiou", Gloss = "own",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "υἱοῦ", Transliteration = "huiou", Gloss = "Son",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "His own Son"
                        },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "did not",
                            GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐφείσατο", Transliteration = "epheisato", Gloss = "spare",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "He who indeed did not spare His own Son"
                },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "us",
                            GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "for us all"
                },
                new Word { Greek = "παρέδωκεν", Transliteration = "paredōken", Gloss = "delivered Him up",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "Him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" }
            },
            Translation = "He who indeed did not spare His own Son, but delivered Him up for us all,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 32)
                new Word { Greek = "πῶς", Transliteration = "pōs", Gloss = "how",
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "οὐχὶ", Transliteration = "ouchi", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὺν", Transliteration = "syn", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "Him",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "with Him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all things",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "all things"
                },
                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us",
                    GrammarCodes = new List<string> { "PRON", "DAT", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "χαρίσεται", Transliteration = "charisetai", Gloss = "He will freely give",
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "how will He not also with Him freely give us all things?"
        }
    };
}

/*
Constructions identified:
- Romans 8:26: NOUN_PHRASE [DAT_MANNER] "στεναγμοῖς ἀλαλήτοις"
- Romans 8:28: PTCP [SUBJ] "τοῖς ἀγαπῶσιν τὸν θεὸν"
- Romans 8:29: INF_PHRASE [PURPOSE] "εἰς τὸ εἶναι..."
- Romans 8:31: COND_CLAUSE "εἰ ὁ θεὸς ὑπὲρ ἡμῶν"
*/
