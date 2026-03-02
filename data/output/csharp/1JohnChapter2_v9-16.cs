private static List<object> GetChapter2()
{
    // 1 John 2:9-16
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
                        new Word { Greek = "Ὁ", Transliteration = "Ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "one saying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "φωτὶ", Transliteration = "phōti", Gloss = "light",
                                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "in the light"
                                },
                                new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "to be in the light"
                        }
                    },
                    Translation = "The one saying to be in the light"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀδελφὸν", Transliteration = "adelphon", Gloss = "brother",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "μισῶν", Transliteration = "misōn", Gloss = "hating",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "the one hating his brother"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "σκοτίᾳ", Transliteration = "skotia", Gloss = "darkness",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in the darkness"
                },
                new Word { Greek = "ἐστὶν", Transliteration = "estin", Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "until",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἄρτι", Transliteration = "arti", Gloss = "now",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "until now"
                }
            },
            Translation = "Whoever says he is in the light and hates his brother is in the darkness until now."
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀγαπῶν", Transliteration = "agapōn", Gloss = "loving",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀδελφὸν", Transliteration = "adelphon", Gloss = "brother",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "his brother"
                        }
                    },
                    Translation = "The one loving his brother"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "φωτὶ", Transliteration = "phōti", Gloss = "light",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in the light"
                },
                new Word { Greek = "μένει", Transliteration = "menei", Gloss = "abides",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "The one loving his brother abides in the light,"
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
                        new Word { Greek = "σκάνδαλον", Transliteration = "skandalon", Gloss = "cause for stumbling",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "cause for stumbling"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "in him"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "and in him there is no cause for stumbling."
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μισῶν", Transliteration = "misōn", Gloss = "hating",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀδελφὸν", Transliteration = "adelphon", Gloss = "brother",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "his brother"
                        }
                    },
                    Translation = "But the one hating his brother"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "σκοτίᾳ", Transliteration = "skotia", Gloss = "darkness",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in the darkness"
                },
                new Word { Greek = "ἐστὶν", Transliteration = "estin", Gloss = "is",
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
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "σκοτίᾳ", Transliteration = "skotia", Gloss = "darkness",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in the darkness"
                },
                new Word { Greek = "περιπατεῖ", Transliteration = "peripatei", Gloss = "walks",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "οἶδεν", Transliteration = "oiden", Gloss = "knows",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ποῦ", Transliteration = "pou", Gloss = "where",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ὑπάγει", Transliteration = "hypagei", Gloss = "he goes",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "where he is going,"
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
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "σκοτία", Transliteration = "skotia", Gloss = "darkness",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the darkness"
                        },
                        new Word { Greek = "ἐτύφλωσεν", Transliteration = "etyphlōsen", Gloss = "blinded",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὀφθαλμοὺς", Transliteration = "ophthalmous", Gloss = "eyes",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "his eyes"
                        }
                    },
                    Translation = "because the darkness blinded his eyes."
                }
            },
            Translation = "But the one hating his brother is in the darkness and walks in the darkness, and does not know where he is going, because the darkness blinded his eyes."
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Γράφω", Transliteration = "Graphō", Gloss = "I am writing",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τεκνία", Transliteration = "teknia", Gloss = "little children",
                            GrammarCodes = new List<string> { "N", "VOC", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "little children"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἀφέωνται", Transliteration = "apheōntai", Gloss = "have been forgiven",
                            GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                            PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αἱ", Transliteration = "hai", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἁμαρτίαι", Transliteration = "hamartiai", Gloss = "sins",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "your sins"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "for the sake of",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ὄνομα", Transliteration = "onoma", Gloss = "name",
                                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                            PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "his name"
                                }
                            },
                            Translation = "on account of his name"
                        }
                    },
                    Translation = "because your sins have been forgiven you for his name's sake."
                }
            },
            Translation = "I am writing to you, little children, because your sins have been forgiven you for his name's sake."
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "γράφω", Transliteration = "graphō", Gloss = "I am writing",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πατέρες", Transliteration = "pateres", Gloss = "fathers",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "fathers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐγνώκατε", Transliteration = "egnōkate", Gloss = "you have known",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the one",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀπ᾽", Transliteration = "ap'", Gloss = "from",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "ἀρχῆς", Transliteration = "archēs", Gloss = "beginning",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "from the beginning"
                                }
                            },
                            Translation = "him who is from the beginning"
                        }
                    },
                    Translation = "because you have known him who is from the beginning."
                }
            },
            Translation = "I am writing to you, fathers, because you have known him who is from the beginning."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "γράφω", Transliteration = "graphō", Gloss = "I am writing",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "νεανίσκοι", Transliteration = "neaniskoi", Gloss = "young men",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "young men"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "νενικήκατε", Transliteration = "nenikēkate", Gloss = "you have overcome",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πονηρόν", Transliteration = "ponēron", Gloss = "evil one",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "the evil one"
                        }
                    },
                    Translation = "because you have overcome the evil one."
                }
            },
            Translation = "I am writing to you, young men, because you have overcome the evil one."
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔγραψα", Transliteration = "egrapsa", Gloss = "I have written",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παιδία", Transliteration = "paidia", Gloss = "children",
                            GrammarCodes = new List<string> { "N", "VOC", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "children"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐγνώκατε", Transliteration = "egnōkate", Gloss = "you have known",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πατέρα", Transliteration = "patera", Gloss = "Father",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the Father"
                        }
                    },
                    Translation = "because you have known the Father."
                }
            },
            Translation = "I have written to you, children, because you have known the Father."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔγραψα", Transliteration = "egrapsa", Gloss = "I have written",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πατέρες", Transliteration = "pateres", Gloss = "fathers",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "fathers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐγνώκατε", Transliteration = "egnōkate", Gloss = "you have known",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the one",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀπ᾽", Transliteration = "ap'", Gloss = "from",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "ἀρχῆς", Transliteration = "archēs", Gloss = "beginning",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "from the beginning"
                                }
                            },
                            Translation = "him who is from the beginning"
                        }
                    },
                    Translation = "because you have known him who is from the beginning."
                }
            },
            Translation = "I have written to you, fathers, because you have known him who is from the beginning."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔγραψα", Transliteration = "egrapsa", Gloss = "I have written",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "νεανίσκοι", Transliteration = "neaniskoi", Gloss = "young men",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "young men"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἰσχυροί", Transliteration = "ischyroi", Gloss = "strong",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "you are",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "you are strong,"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
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
                                        new Word { Greek = "λόγος", Transliteration = "logos", Gloss = "word",
                                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the",
                                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                                                    GrammarCodes = new
