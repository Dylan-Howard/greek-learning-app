private static List<object> GetChapter1()
{
    // John 1:49-51
    return new List<object>
    {
        // Verse 49
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀπεκρίθη", Transliteration = "apekrithē",
                    Gloss = "answered",
                    GrammarCodes = new List<string> { "V", "AOR", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō",
                    Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "Ναθαναήλ", Transliteration = "Nathanaēl",
                    Gloss = "Nathanael",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "noun" }
            },
            Translation = "Nathanael answered him,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ῥαββί", Transliteration = "rhabbi",
                    Gloss = "Rabbi",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "particle" }
            },
            Translation = "“Rabbi,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "σὺ", Transliteration = "sy",
                    Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "εἶ", Transliteration = "ei",
                    Gloss = "are",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "υἱὸς", Transliteration = "huios",
                            Gloss = "Son",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou",
                                    Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "of God"
                        }
                    },
                    Translation = "the Son of God;"
                }
            },
            Translation = "you are the Son of God!"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "σὺ", Transliteration = "sy",
                    Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βασιλεὺς", Transliteration = "basileus",
                            Gloss = "King",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "εἶ", Transliteration = "ei",
                            Gloss = "are",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "Ἰσραήλ", Transliteration = "Israēl",
                                    Gloss = "Israel",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "of Israel"
                        }
                    },
                    Translation = "the King of Israel"
                }
            },
            Translation = "you are the King of Israel!”"
        },

        // Verse 50
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀπεκρίθη", Transliteration = "apekrithē",
                    Gloss = "answered",
                    GrammarCodes = new List<string> { "V", "AOR", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous",
                    Gloss = "Jesus",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "noun" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen",
                    Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō",
                    Gloss = "to him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "pronoun" }
            },
            Translation = "Jesus answered and said to him,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti",
                    Gloss = "Because",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "εἶπόν", Transliteration = "eipon",
                    Gloss = "I said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "σοι", Transliteration = "soi",
                    Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti",
                            Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "εἶδόν", Transliteration = "eidon",
                            Gloss = "I saw",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "σε", Transliteration = "se",
                            Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" },
                            PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑποκάτω", Transliteration = "hypokatō",
                                    Gloss = "under",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "article" },
                                        new Word { Greek = "συκῆς", Transliteration = "sykēs",
                                            Gloss = "fig tree",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "noun" }
                                    },
                                    Translation = "the fig tree"
                                }
                            },
                            Translation = "under the fig tree"
                        }
                    },
                    Translation = "that I saw you under the fig tree"
                }
            },
            Translation = "“Because I said to you that I saw you under the fig tree,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πιστεύεις", Transliteration = "pisteueis",
                    Gloss = "do you believe",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                    PartOfSpeech = "verb" }
            },
            Translation = "do you believe?"
        },
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
                        new Word { Greek = "μείζω", Transliteration = "meizō",
                            Gloss = "greater things",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adjective" },
                        new Word { Greek = "τούτων", Transliteration = "toutōn",
                            Gloss = "than these",
                            GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "greater things than these"
                },
                new Word { Greek = "ὄψῃ", Transliteration = "opsē",
                    Gloss = "you will see",
                    GrammarCodes = new List<string> { "V", "FUT", "MP", "IND", "2P", "S" },
                    PartOfSpeech = "verb" }
            },
            Translation = "You will see greater things than these.”"
        },

        // Verse 51
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "λέγει", Transliteration = "legei",
                    Gloss = "he said",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō",
                    Gloss = "to him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "pronoun" }
            },
            Translation = "And he said to him,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀμὴν", Transliteration = "amēn",
                    Gloss = "truly",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "particle" },
                new Word { Greek = "ἀμὴν", Transliteration = "amēn",
                    Gloss = "truly",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "particle" },
                new Word { Greek = "λέγω", Transliteration = "legō",
                    Gloss = "I say",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin",
                    Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "pronoun" }
            },
            Translation = "“Truly, truly, I say to you,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὄψεσθε", Transliteration = "opsesthe",
                    Gloss = "you will see",
                    GrammarCodes = new List<string> { "V", "FUT", "MP", "IND", "2P", "P" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "οὐρανὸν", Transliteration = "ouranon",
                            Gloss = "heaven",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀνεῳγότα", Transliteration = "aneōgota",
                                    Gloss = "opened",
                                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "ACC", "M", "S" },
                                    PartOfSpeech = "verb" }
                            },
                            Translation = "opened"
                        }
                    },
                    Translation = "heaven opened"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "ἀγγέλους", Transliteration = "angelous",
                            Gloss = "angels",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou",
                                    Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "of God"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀναβαίνοντας", Transliteration = "anabainontas",
                                    Gloss = "ascending",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" },
                                    PartOfSpeech = "verb" },
                                new Word { Greek = "καὶ", Transliteration = "kai",
                                    Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conjunction" },
                                new Word { Greek = "καταβαίνοντας", Transliteration = "katabainontas",
                                    Gloss = "descending",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" },
                                    PartOfSpeech = "verb" }
                            },
                            Translation = "ascending and descending"
                        }
                    },
                    Translation = "the angels of God ascending and descending"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi",
                            Gloss = "on",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "υἱὸν", Transliteration = "huion",
                                    Gloss = "Son",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "article" },
                                        new Word { Greek = "ἀνθρώπου", Transliteration = "anthrōpou",
                                            Gloss = "Man",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "noun" }
                                    },
                                    Translation = "of Man"
                                }
                            },
                            Translation = "the Son of Man"
                        }
                    },
                    Translation = "on the Son of Man.”"
                }
            },
            Translation = "you will see heaven opened, and the angels of God ascending and descending on the Son of Man.”"
        }
    };
}
/*
Constructions identified:
- Predicate Nominative: John 1:49 (ὁ υἱὸς τοῦ θεοῦ, βασιλεὺς ... τοῦ Ἰσραήλ)
- Causal ὅτι clause: John 1:50 (ὅτι εἶπόν σοι...)
- Content ὅτι clause: John 1:50 (...ὅτι εἶδόν σε...)
- Genitive of Comparison: John 1:50 (τούτων after comparative μείζω)
- Double Accusative (Object-Complement) with Participle: John 1:51 (τὸν οὐρανὸν ἀνεῳγότα)
*/
