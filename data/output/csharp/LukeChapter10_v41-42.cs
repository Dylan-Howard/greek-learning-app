private static List<object> GetChapter10()
{
    // Luke 10:41-42
    return new List<object>
    {
        // Verse 41
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀποκριθεὶς", Transliteration = "apokritheis",
                            Gloss = "answering",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "answering"
                },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen",
                    Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῇ", Transliteration = "autē",
                    Gloss = "to her",
                    GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" },
                    PartOfSpeech = "preposition" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "κύριος", Transliteration = "kyrios",
                            Gloss = "Lord",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "the Lord"
                }
            },
            Translation = "But the Lord answering said to her,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "VOC" },
            Content = new List<object>
            {
                new Word { Greek = "Μάρθα", Transliteration = "Martha",
                    Gloss = "Martha",
                    GrammarCodes = new List<string> { "N", "VOC", "F", "S" },
                    PartOfSpeech = "noun" },
                new Word { Greek = "Μάρθα", Transliteration = "Martha",
                    Gloss = "Martha",
                    GrammarCodes = new List<string> { "N", "VOC", "F", "S" },
                    PartOfSpeech = "noun" }
            },
            Translation = "Martha, Martha,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μεριμνᾷς", Transliteration = "merimnas",
                            Gloss = "you are anxious",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "θορυβάζῃ", Transliteration = "thorybazē",
                            Gloss = "troubled",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "2P", "S" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "you are anxious and troubled"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri",
                            Gloss = "about",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "πολλά", Transliteration = "polla",
                            Gloss = "many things",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adjective" }
                    },
                    Translation = "about many things"
                }
            },
            Translation = "you are anxious and troubled about many things;"
        },

        // Verse 42
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἑνὸς", Transliteration = "henos",
                            Gloss = "of one thing",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" },
                            PartOfSpeech = "adjective" }
                    },
                    Translation = "of one thing"
                },
                new Word { Greek = "δέ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐστιν", Transliteration = "estin",
                    Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χρεία", Transliteration = "chreia",
                            Gloss = "need",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "need"
                }
            },
            Translation = "but one thing is necessary."
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
                        new Word { Greek = "Μαριὰμ", Transliteration = "Mariam",
                            Gloss = "Mary",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "Mary"
                },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "ἀγαθὴν", Transliteration = "agathēn",
                            Gloss = "good",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                            PartOfSpeech = "adjective" },
                        new Word { Greek = "μερίδα", Transliteration = "merida",
                            Gloss = "portion",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "the good portion"
                },
                new Word { Greek = "ἐξελέξατο", Transliteration = "exelexato",
                    Gloss = "has chosen",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἥτις", Transliteration = "hētis",
                                    Gloss = "which",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "which"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "VERB_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οὐκ", Transliteration = "ouk",
                                    Gloss = "not",
                                    GrammarCodes = new List<string> { "PART" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "ἀφαιρεθήσεται", Transliteration = "aphairethēsetai",
                                    Gloss = "will be taken away",
                                    GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" },
                                    PartOfSpeech = "verb" }
                            },
                            Translation = "will not be taken away"
                        },
                        new Word { Greek = "αὐτῆς", Transliteration = "autēs",
                            Gloss = "from her",
                            GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" },
                            PartOfSpeech = "preposition" }
                    },
                    Translation = "which will not be taken away from her"
                }
            },
            Translation = "For Mary has chosen the good portion, which will not be taken away from her."
        }
    };
}

// Constructions identified:
// VOC: Luke 10:41 (Μάρθα Μάρθα)
