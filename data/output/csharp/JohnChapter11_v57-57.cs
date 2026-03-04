private static List<object> GetChapter11()
{
    // John 11:57-57
    return new List<object>
    {
        // Verse 57
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "δεδώκεισαν", Transliteration = "dedōkeisan",
                    Gloss = "had given",
                    GrammarCodes = new List<string> { "V", "PLPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "now",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "ἀρχιερεῖς", Transliteration = "archiereis",
                            Gloss = "chief priests",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "οἱ", Transliteration = "hoi",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "Φαρισαῖοι", Transliteration = "Pharisaioi",
                            Gloss = "Pharisees",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "the chief priests and the Pharisees"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐντολὰς", Transliteration = "entolas",
                            Gloss = "orders",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "orders"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina",
                            Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "COND_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐάν", Transliteration = "ean",
                                    Gloss = "if",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conjunction" },
                                new Word { Greek = "τις", Transliteration = "tis",
                                    Gloss = "anyone",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                                    PartOfSpeech = "pronoun" },
                                new Word { Greek = "γνῷ", Transliteration = "gnō",
                                    Gloss = "should know",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                                    PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ποῦ", Transliteration = "pou",
                                            Gloss = "where",
                                            GrammarCodes = new List<string> { "ADV" },
                                            PartOfSpeech = "adverb" },
                                        new Word { Greek = "ἐστιν", Transliteration = "estin",
                                            Gloss = "he is",
                                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                                            PartOfSpeech = "verb" }
                                    },
                                    Translation = "where he was"
                                }
                            },
                            Translation = "if anyone should know where he was"
                        },
                        new Word { Greek = "μηνύσῃ", Transliteration = "mēnysē",
                            Gloss = "he should report",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "that if anyone should know where he was, he should report it"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπως", Transliteration = "hopōs",
                            Gloss = "so that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "VERB_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πιάσωσιν", Transliteration = "piasōsin",
                                    Gloss = "they might seize",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" },
                                    PartOfSpeech = "verb" },
                                new Word { Greek = "αὐτόν", Transliteration = "auton",
                                    Gloss = "him",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "they might seize him"
                        }
                    },
                    Translation = "so that they might seize him"
                }
            },
            Translation = "Now the chief priests and the Pharisees had given orders that if anyone knew where he was, he should report it, so that they might seize him."
        }
    };
}

/*
Constructions identified:
- COND_CLAUSE: John 11:57
- PURPOSE_CLAUSE: John 11:57
*/
