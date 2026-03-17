private static List<object> GetChapter6()
{
    // 2 Corinthians 6:17-18
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "διὸ", Transliteration = "dio", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐξέλθατε", Transliteration = "exelthate", Gloss = "go out",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μέσου", Transliteration = "mesou", Gloss = "midst",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "their midst"
                        }
                    },
                    Translation = "from their midst"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀφορίσθητε", Transliteration = "aphoristhēte", Gloss = "be separate",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IMP", "2P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "Therefore go out from their midst and be separate,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "says",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the Lord"
                }
            },
            Translation = "says the Lord,"
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
                        new Word { Greek = "ἀκαθάρτου", Transliteration = "akathartou", Gloss = "unclean thing",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "an unclean thing"
                },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "ἅπτεσθε", Transliteration = "haptesthe", Gloss = "touch",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "and do not touch an unclean thing;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "κἀγὼ", Transliteration = "kagō", Gloss = "and I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "εἰσδέξομαι", Transliteration = "eisdexomai", Gloss = "will receive",
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" },
                    PartOfSpeech = "pron" }
            },
            Translation = "and I will receive you,"
        },
        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἔσομαι", Transliteration = "esomai", Gloss = "I will be",
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "πατέρα", Transliteration = "patera", Gloss = "father",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "as a father"
                }
            },
            Translation = "and I will be to you a father,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἔσεσθέ", Transliteration = "esesthe", Gloss = "will be",
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me",
                    GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "υἱοὺς", Transliteration = "hyious", Gloss = "sons",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "θυγατέρας", Transliteration = "thygateras", Gloss = "daughters",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "as sons and daughters"
                }
            },
            Translation = "and you will be to me sons and daughters,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "says",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "παντοκράτωρ", Transliteration = "pantokratōr", Gloss = "Almighty",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the Lord Almighty"
                }
            },
            Translation = "says the Lord Almighty."
        }
    };
}

/*
Constructions Identified:
- Crasis (καὶ + ἐγώ = κἀγὼ): 6:17
- Prepositional usage of εἴς for predicate nominative/accusative (Semitic influence): 6:18
*/
