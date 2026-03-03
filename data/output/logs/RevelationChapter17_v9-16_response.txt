private static List<object> GetChapter17()
{
    // Revelation 17:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὧδε", Transliteration = "hōde", Gloss = "here",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "νοῦς", Transliteration = "nous", Gloss = "mind",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "σοφίαν", Transliteration = "sophian", Gloss = "wisdom",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the one having wisdom"
                        }
                    },
                    Translation = "the mind having wisdom"
                }
            },
            Translation = "Here is the mind having wisdom."
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
                        new Word { Greek = "Αἱ", Transliteration = "Hai", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "κεφαλαὶ", Transliteration = "kephalai", Gloss = "heads",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "The seven heads"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ὄρη", Transliteration = "orē", Gloss = "mountains",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "seven mountains"
                },
                new Word { Greek = "εἰσίν", Transliteration = "eisin", Gloss = "are",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "where",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "γυνὴ", Transliteration = "gynē", Gloss = "woman",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the woman"
                        },
                        new Word { Greek = "κάθηται", Transliteration = "kathētai", Gloss = "sits",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "on",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "them",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "on them"
                        }
                    },
                    Translation = "where the woman sits on them"
                }
            },
            Translation = "The seven heads are seven mountains where the woman sits on them."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βασιλεῖς", Transliteration = "basileis", Gloss = "kings",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἑπτά", Transliteration = "hepta", Gloss = "seven",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "seven kings"
                },
                new Word { Greek = "εἰσιν", Transliteration = "eisin", Gloss = "they are",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "And they are seven kings."
        },
        // Verse 10
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
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πέντε", Transliteration = "pente", Gloss = "five",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the five"
                },
                new Word { Greek = "ἔπεσαν", Transliteration = "epesan", Gloss = "have fallen",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "Five have fallen,"
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "εἷς", Transliteration = "heis", Gloss = "one",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the one"
                },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "one is,"
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἄλλος", Transliteration = "allos", Gloss = "other",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the other"
                },
                new Word { Greek = "οὔπω", Transliteration = "oupō", Gloss = "not yet",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἦλθεν", Transliteration = "ēlthen", Gloss = "has come",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "the other has not yet come,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅταν", Transliteration = "hotan", Gloss = "when",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἔλθῃ", Transliteration = "elthē", Gloss = "he comes",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "when he comes"
                },
                new Word { Greek = "ὀλίγον", Transliteration = "oligon", Gloss = "a little",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "δεῖ", Transliteration = "dei", Gloss = "it is necessary",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μεῖναι", Transliteration = "meinai", Gloss = "to remain",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "to remain"
                }
            },
            Translation = "and when he comes, he must remain a little while."
        },
        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θηρίον", Transliteration = "thērion", Gloss = "beast",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was",
                                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                                    GrammarCodes = new List<string> { "ADV" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "which was and is not"
                        }
                    },
                    Translation = "the beast that was and is not"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ὄγδοός", Transliteration = "ogdoos", Gloss = "eighth",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἑπτά", Transliteration = "hepta", Gloss = "seven",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "the seven"
                        }
                    },
                    Translation = "of the seven"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "he is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἀπώλειαν", Transliteration = "apōleian", Gloss = "destruction",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to destruction"
                },
                new Word { Greek = "ὑπάγει", Transliteration = "hypagei", Gloss = "goes",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "And the beast that was and is not, he himself is also an eighth, and is of the seven, and goes to destruction."
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δέκα", Transliteration = "deka", Gloss = "ten",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "κέρατα", Transliteration = "kerata", Gloss = "horns",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἃ", Transliteration = "ha", Gloss = "which",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "εἶδες", Transliteration = "eides", Gloss = "you saw",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "which you saw"
                        }
                    },
                    Translation = "the ten horns that you saw"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δέκα", Transliteration = "deka", Gloss = "ten",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "βασιλεῖς", Transliteration = "basileis", Gloss = "kings",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "ten kings"
                },
                new Word { Greek = "εἰσιν", Transliteration = "eisin", Gloss = "are",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "And the ten horns that you saw are ten kings,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οἵτινες", Transliteration = "hoitines", Gloss = "who",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "βασιλείαν", Transliteration = "basileian", Gloss = "a kingdom",
                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "οὔπω", Transliteration = "oupō", Gloss = "not yet",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἔλαβον", Transliteration = "elabon", Gloss = "have received",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "who have not yet received a kingdom,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐξουσίαν", Transliteration = "exousian", Gloss = "authority",
                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "βασιλεῖς", Transliteration = "basileis", Gloss = "kings",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μίαν", Transliteration = "mian", Gloss = "one",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ὥραν", Transliteration = "hōran", Gloss = "hour",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "one hour"
                },
                new Word { Greek = "λαμβάνουσιν", Transliteration = "lambanousin", Gloss = "they receive",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θηρίου", Transliteration = "thēriou", Gloss = "beast",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the beast"
                        }
                    },
                    Translation = "with the beast"
                }
            },
            Translation = "but they receive authority as kings for one hour with the beast."
        },
        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὗτοι", Transliteration = "houtoi", Gloss = "These",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μίαν", Transliteration = "mian", Gloss = "one",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "γνώμην", Transliteration = "gnōmēn", Gloss = "purpose",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "one purpose"
                },
                new Word { Greek = "ἔχουσιν", Transliteration = "echousin", Gloss = "have",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "These have one purpose,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δύναμιν", Transliteration = "dynamin", Gloss = "power",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐξουσίαν", Transliteration = "exousian", Gloss = "authority",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "their power and authority"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the",
                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θηρίῳ", Transliteration = "thēriō", Gloss = "beast",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the beast"
                },
                new Word { Greek = "διδόασιν", Transliteration = "didoasin", Gloss = "they give",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "and they give their power and authority to the beast."
        },
        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὗτοι", Transliteration = "houtoi", Gloss = "These",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀρνίου", Transliteration = "arniou", Gloss = "Lamb",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the Lamb"
                        }
                    },
                    Translation = "with the Lamb"
                },
                new Word { Greek = "πολεμήσουσιν", Transliteration = "polemēsousin", Gloss = "will make war",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "These will make war with the Lamb,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀρνίον", Transliteration = "arnion", Gloss = "Lamb",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the Lamb"
                },
                new Word { Greek = "νικήσει", Transliteration = "nikēsei", Gloss = "will overcome",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτούς", Transliteration = "autous", Gloss = "them",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "prep" }
            },
            Translation = "and the Lamb will overcome them,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "κυρίων", Transliteration = "kyriōn", Gloss = "of lords",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Lord of lords"
                },
                new Word { Greek = "ἐστὶν", Transliteration = "estin", Gloss = "he is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βασιλεὺς", Transliteration = "basileus", Gloss = "King",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "βασιλέων", Transliteration = "basileōn", Gloss = "of kings",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "King of kings"
                }
            },
            Translation = "because he is Lord of lords and King of kings;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the ones",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μετ᾽", Transliteration = "met'", Gloss = "with",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "with him"
                        }
                    },
                    Translation = "those with him"
                },
                new Word { Greek = "κλητοὶ", Transliteration = "klētoi", Gloss = "called",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐκλεκτοὶ", Transliteration = "eklektoi", Gloss = "chosen",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "πιστοί", Transliteration = "pistoi", Gloss = "faithful",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                    PartOfSpeech = "adj" }
            },
            Translation = "and those with him are called and chosen and faithful."
        },
        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "he says",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me",
                    GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "And he says to me,"
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
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὕδατα", Transliteration = "hydata", Gloss = "waters",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἃ", Transliteration = "ha", Gloss = "which",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "εἶδες", Transliteration = "eides", Gloss = "you saw",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "which you saw"
                        }
                    },
                    Translation = "The waters that you saw"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "where",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πόρνη", Transliteration = "pornē", Gloss = "prostitute",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the prostitute"
                        },
                        new Word { Greek = "κάθηται", Transliteration = "kathētai", Gloss = "sits",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "where the prostitute sits"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λαοὶ", Transliteration = "laoi", Gloss = "peoples",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ὄχλοι", Transliteration = "ochloi", Gloss = "crowds",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "peoples and crowds"
                },
                new Word { Greek = "εἰσὶν", Transliteration = "eisin", Gloss = "are",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἔθνη", Transliteration = "ethnē", Gloss = "nations",
                    GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                    PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "γλῶσσαι", Transliteration = "glōssai", Gloss = "tongues",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                    PartOfSpeech = "n" }
            },
            Translation = "The waters that you saw, where the prostitute sits, are peoples and crowds and nations and tongues."
        },
        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δέκα", Transliteration = "deka", Gloss = "ten",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "κέρατα", Transliteration = "kerata", Gloss = "horns",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἃ", Transliteration = "ha", Gloss = "which",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "εἶδες", Transliteration = "eides", Gloss = "you saw",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "which you saw"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θηρίον", Transliteration = "thērion", Gloss = "beast",
                                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the beast"
                        }
                    },
                    Translation = "the ten horns that you saw and the beast"
                },
                new Word { Greek = "οὗτοι", Transliteration = "houtoi", Gloss = "these",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "μισήσουσιν", Transliteration = "misēsousin", Gloss = "will hate",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πόρνην", Transliteration = "pornēn", Gloss = "prostitute",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the prostitute"
                }
            },
            Translation = "And the ten horns that you saw and the beast, these will hate the prostitute,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἠρημωμένην", Transliteration = "ērēmōmenēn", Gloss = "desolate",
                            GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "ACC", "F", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "desolate"
                },
                new Word { Greek = "ποιήσουσιν", Transliteration = "poiēsousin", Gloss = "they will make",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτὴν", Transliteration = "autēn", Gloss = "her",
                    GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "γυμνὴν", Transliteration = "gymnēn", Gloss = "naked",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                    PartOfSpeech = "adj" }
            },
            Translation = "and they will make her desolate and naked,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "σάρκας", Transliteration = "sarkas", Gloss = "flesh",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῆς", Transliteration = "autēs", Gloss = "of her",
                            GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "her flesh"
                },
                new Word { Greek = "φάγονται", Transliteration = "phagontai", Gloss = "they will eat",
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "and will eat her flesh,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "αὐτὴν", Transliteration = "autēn", Gloss = "her",
                    GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "κατακαύσουσιν", Transliteration = "katakausousin", Gloss = "they will burn up",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "πυρί", Transliteration = "pyri", Gloss = "fire",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "with fire"
                }
            },
            Translation = "and will burn her up with fire."
        }
    };
}

/*
Constructions identified:
- GEN_DESC: Verse 14 (κύριος κυρίων, βασιλεὺς βασιλέων - superlative use of genitive)
- REL_CLAUSE: Verse 9, 11, 12, 15, 16
- CAUSAL_CLAUSE: Verse 14 (introduced by ὅτι)
- TEMP_CLAUSE: Verse 10 (introduced by ὅταν)
- DAT_INSTR: Verse 16 (ἐν πυρί - fire as the instrument of burning)
- INF_PHRASE: Verse 10 (μεῖναι following δεῖ)
*/
