private static List<object> GetChapter2()
{
    // John 2:25-25
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti",
                            Gloss = "because",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "οὐ", Transliteration = "ou",
                            Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "χρείαν", Transliteration = "chreian",
                                    Gloss = "need",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "need"
                        },
                        new Word { Greek = "εἶχεν", Transliteration = "eichen",
                            Gloss = "to have",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἵνα", Transliteration = "hina",
                                    Gloss = "that",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "τις", Transliteration = "tis",
                                    Gloss = "anyone",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                                    PartOfSpeech = "part" },
                                new Word { Greek = "μαρτυρήσῃ", Transliteration = "martyrēsē",
                                    Gloss = "to testify",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "περὶ", Transliteration = "peri",
                                            Gloss = "about",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "τοῦ", Transliteration = "tou",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἀνθρώπου", Transliteration = "anthrōpou",
                                            Gloss = "human being",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "about man"
                                }
                            },
                            Translation = "that anyone should testify about man"
                        }
                    },
                    Translation = "because He had no need that anyone should testify about man"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτὸς", Transliteration = "autos",
                            Gloss = "he",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "γὰρ", Transliteration = "gar",
                            Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐγίνωσκεν", Transliteration = "eginōsken",
                            Gloss = "to know",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τί", Transliteration = "ti",
                                    Gloss = "what",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" },
                                    PartOfSpeech = "interj" },
                                new Word { Greek = "ἦν", Transliteration = "ēn",
                                    Gloss = "to be",
                                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en",
                                            Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "τῷ", Transliteration = "tō",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἀνθρώπῳ", Transliteration = "anthrōpō",
                                            Gloss = "human being",
                                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "in man"
                                }
                            },
                            Translation = "what was in man"
                        }
                    },
                    Translation = "for He Himself knew what was in man"
                }
            },
            Translation = "and because He had no need that anyone should testify about man, for He Himself knew what was in man."
        }
    };
}

/*
Constructions identified:
- John 2:25: CAUSAL_CLAUSE (introduced by ὅτι)
- John 2:25: PURPOSE_CLAUSE (introduced by ἵνα, functioning as content for χρείαν)
- John 2:25: CAUSAL_CLAUSE (introduced by γὰρ)
- John 2:25: DEP_CLAUSE (indirect question/content of ἐγίνωσκεν)
*/
