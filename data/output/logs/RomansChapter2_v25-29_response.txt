private static List<object> GetChapter2()
{
    // Romans 2:25-29
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Περιτομὴ", Transliteration = "Peritomē", Gloss = "circumcision",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed",
                    GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὠφελεῖ", Transliteration = "ōphelei", Gloss = "is of value",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "νόμον", Transliteration = "nomon", Gloss = "law",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the law"
                        },
                        new Word { Greek = "πράσσῃς", Transliteration = "prassēs", Gloss = "you practice",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "if you practice the law"
                }
            },
            Translation = "For circumcision indeed is of value if you practice the law"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παραβάτης", Transliteration = "parabatēs", Gloss = "breaker",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "of law",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a breaker of the law"
                        },
                        new Word { Greek = "ᾖς", Transliteration = "ēs", Gloss = "you are",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "but if you are a breaker of the law"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "περιτομή", Transliteration = "peritomē", Gloss = "circumcision",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "your",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your circumcision"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀκροβυστία", Transliteration = "akrobystia", Gloss = "uncircumcision",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "uncircumcision"
                },
                new Word { Greek = "γέγονεν", Transliteration = "gegonen", Gloss = "has become",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "but if you are a breaker of the law, your circumcision has become uncircumcision."
        },
        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀκροβυστία", Transliteration = "akrobystia", Gloss = "uncircumcision",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the uncircumcision"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "δικαιώματα", Transliteration = "dikaiōmata", Gloss = "righteous requirements",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "law",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the law"
                                }
                            },
                            Translation = "the requirements of the law"
                        },
                        new Word { Greek = "φυλάσσῃ", Transliteration = "phylassē", Gloss = "keeps",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "So if the uncircumcision keeps the righteous requirements of the law"
                },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀκροβυστία", Transliteration = "akrobystia", Gloss = "uncircumcision",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "his uncircumcision"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "as",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "περιτομὴν", Transliteration = "peritomēn", Gloss = "circumcision",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "as circumcision"
                },
                new Word { Greek = "λογισθήσεται", Transliteration = "logisthēsetai", Gloss = "will be regarded",
                    GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "will not his uncircumcision be regarded as circumcision?"
        },
        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κρινεῖ", Transliteration = "krinei", Gloss = "will judge",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "by",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "φύσεως", Transliteration = "physeōs", Gloss = "nature",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "by nature"
                        },
                        new Word { Greek = "ἀκροβυστία", Transliteration = "akrobystia", Gloss = "uncircumcision",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the uncircumcision by nature"
                },
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
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "νόμον", Transliteration = "nomon", Gloss = "law",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the law"
                        },
                        new Word { Greek = "τελοῦσα", Transliteration = "telousa", Gloss = "fulfilling",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "fulfilling the law"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὲ", Transliteration = "se", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the one",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "γράμματος", Transliteration = "grammatos", Gloss = "letter",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "περιτομῆς", Transliteration = "peritomēs", Gloss = "circumcision",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "through the letter and circumcision"
                        },
                        new Word { Greek = "παραβάτην", Transliteration = "parabatēn", Gloss = "breaker",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "of law",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "you the breaker of the law through the letter and circumcision"
                }
            },
            Translation = "Then the uncircumcision by nature, fulfilling the law, will judge you the breaker of the law through the letter and circumcision."
        },
        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "φανερῷ", Transliteration = "phanerō", Gloss = "outward",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "in the outward"
                        }
                    },
                    Translation = "the one who is one outwardly"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰουδαῖός", Transliteration = "Ioudaios", Gloss = "Jew",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a Jew"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "For no one is a Jew who is one outwardly"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐδὲ", Transliteration = "oude", Gloss = "nor",
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "φανερῷ", Transliteration = "phanerō", Gloss = "outward",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "outward"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "σαρκὶ", Transliteration = "sarki", Gloss = "flesh",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in the flesh"
                        },
                        new Word { Greek = "περιτομή", Transliteration = "peritomē", Gloss = "circumcision",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "outward circumcision in the flesh"
                }
            },
            Translation = "nor is circumcision outward in the flesh."
        },
        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all’", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κρυπτῷ", Transliteration = "kryptō", Gloss = "hidden",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "in the hidden"
                        }
                    },
                    Translation = "the one who is one inwardly"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰουδαῖος", Transliteration = "Ioudaios", Gloss = "Jew",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a Jew"
                }
            },
            Translation = "But a Jew is one inwardly,"
        },
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
                        new Word { Greek = "περιτομὴ", Transliteration = "peritomē", Gloss = "circumcision",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καρδίας", Transliteration = "kardias", Gloss = "of heart",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "circumcision of the heart"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "πνεύματι", Transliteration = "pneumati", Gloss = "Spirit",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "by the Spirit"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γράμματι", Transliteration = "grammati", Gloss = "letter",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "by the letter"
                }
            },
            Translation = "and circumcision is of the heart, by the Spirit, not by the letter."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "whose",
                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἔπαινος", Transliteration = "epainos", Gloss = "praise",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "praise"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀνθρώπων", Transliteration = "anthrōpōn", Gloss = "men",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "from men"
                },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all’", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "from God"
                }
            },
            Translation = "whose praise is not from men but from God."
        }
    };
}

/* Identified Constructions:
- GEN_OBJ: νόμου (v25), νόμου (v27)
- GEN_DESC: καρδίας (v29)
- GEN_SUBJ: οὗ (v29, relative to epainos)
- PTCP: τελοῦσα (v27)
- COND_CLAUSE: v25, v26 (ean)
*/
