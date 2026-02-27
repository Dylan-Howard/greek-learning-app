private static List<object> GetChapter7()
{
    // Luke 7:49-50
    return new List<object>
    {
        // Verse 49
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἤρξαντο", Transliteration = "ērxanto",
                            Gloss = "began",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "λέγειν", Transliteration = "legein",
                            Gloss = "to say",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "began to say"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi",
                            Gloss = "the [ones]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "συνανακείμενοι", Transliteration = "synanakeimenoi",
                            Gloss = "reclining at table with [him]",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "those reclining with him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "ἑαυτοῖς", Transliteration = "heautois",
                            Gloss = "themselves",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "among themselves"
                }
            },
            Translation = "And those who were reclining at table with him began to say among themselves,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τίς", Transliteration = "tis",
                            Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "Who"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὗτός", Transliteration = "houtos",
                            Gloss = "this [man]",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "this"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin",
                    Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos",
                            Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "even",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adverb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "VERB_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀφίησιν", Transliteration = "aphiesin",
                                    Gloss = "forgives",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἁμαρτίας", Transliteration = "hamartias",
                                            Gloss = "sins",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                            PartOfSpeech = "noun" }
                                    },
                                    Translation = "sins"
                                }
                            },
                            Translation = "forgives sins"
                        }
                    },
                    Translation = "who even forgives sins?"
                }
            },
            Translation = "“Who is this, who even forgives sins?”"
        },
        // Verse 50
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen",
                    Gloss = "he said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "γυναῖκα", Transliteration = "gynaika",
                                    Gloss = "woman",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "the woman"
                        }
                    },
                    Translation = "to the woman"
                }
            },
            Translation = "And he said to the woman,"
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
                        new Word { Greek = "ἡ", Transliteration = "hē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "πίστις", Transliteration = "pistis",
                            Gloss = "faith",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "σου", Transliteration = "sou",
                            Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "S", "2P" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "Your faith"
                },
                new Word { Greek = "σέσωκέν", Transliteration = "sesōken",
                    Gloss = "has saved",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "σε", Transliteration = "se",
                    Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "S", "2P" },
                    PartOfSpeech = "pronoun" }
            },
            Translation = "“Your faith has saved you;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πορεύου", Transliteration = "poreuou",
                    Gloss = "go",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis",
                            Gloss = "into",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "εἰρήνην", Transliteration = "eirēnēn",
                            Gloss = "peace",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "in peace"
                }
            },
            Translation = "go in peace.”"
        }
    };
}

/*
Constructions identified:
- Substantive Participle: οἱ συνανακείμενοι (Verse 49)
- Direct Speech: Τίς οὗτός ἐστιν... (Verse 49), Ἡ πίστις σου... (Verse 50)
- Relative Clause: ὃς καὶ ἁμαρτίας ἀφίησιν (Verse 49)
*/
