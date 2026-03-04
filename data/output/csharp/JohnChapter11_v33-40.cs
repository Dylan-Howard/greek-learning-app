private static List<object> GetChapter11()
{
    // John 11:33-40
    return new List<object>
    {
        // Verse 33
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
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "εἶδεν", Transliteration = "eiden", Gloss = "saw",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αὐτὴν", Transliteration = "autēn", Gloss = "her",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                                    PartOfSpeech = "prep" }, // RMAC says P-ASF, json says prep
                                new Word { Greek = "κλαίουσαν", Transliteration = "klaiousan", Gloss = "weeping",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "F", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "her weeping"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "συνελθόντας", Transliteration = "synelthontas", Gloss = "having come together",
                                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "M", "P" },
                                            PartOfSpeech = "v" },
                                        new Word { Greek = "αὐτῇ", Transliteration = "autē", Gloss = "with her",
                                            GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "who had come with her"
                                },
                                new Word { Greek = "Ἰουδαίους", Transliteration = "Ioudaious", Gloss = "Jews",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "the Jews who had come with her"
                        },
                        new Word { Greek = "κλαίοντας", Transliteration = "klaiontas", Gloss = "weeping",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "when he saw her weeping, and the Jews who had come with her also weeping"
                },
                new Word { Greek = "ἐνεβριμήσατο", Transliteration = "enebrimēsato", Gloss = "he was deeply moved",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πνεύματι", Transliteration = "pneumati", Gloss = "spirit",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in his spirit"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐτάραξεν", Transliteration = "etaraxen", Gloss = "troubled",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἑαυτὸν", Transliteration = "heauton", Gloss = "himself",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "f" }
            },
            Translation = "When Jesus therefore saw her weeping, and the Jews who had come with her also weeping, he was deeply moved in his spirit and troubled himself."
        },
        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ποῦ", Transliteration = "pou", Gloss = "where",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "τεθείκατε", Transliteration = "tetheikate", Gloss = "have you laid",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "Where have you laid him?"
                }
            },
            Translation = "And he said, \"Where have you laid him?\""
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγουσιν", Transliteration = "legousin", Gloss = "they say",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριε", Transliteration = "kyrie", Gloss = "Lord",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἔρχου", Transliteration = "erchou", Gloss = "come",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἴδε", Transliteration = "ide", Gloss = "see",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "Lord, come and see."
                }
            },
            Translation = "They said to him, \"Lord, come and see.\""
        },
        // Verse 35
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐδάκρυσεν", Transliteration = "edakrysen", Gloss = "wept",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                }
            },
            Translation = "Jesus wept."
        },
        // Verse 36
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔλεγον", Transliteration = "elegon", Gloss = "were saying",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Ἰουδαῖοι", Transliteration = "Ioudaioi", Gloss = "Jews",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the Jews"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἴδε", Transliteration = "ide", Gloss = "see",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "interj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πῶς", Transliteration = "pōs", Gloss = "how",
                                    GrammarCodes = new List<string> { "ADV" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἐφίλει", Transliteration = "ephilei", Gloss = "he loved",
                                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "how he loved him"
                        }
                    },
                    Translation = "See how he loved him!"
                }
            },
            Translation = "So the Jews said, \"See how he loved him!\""
        },
        // Verse 37
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τινὲς", Transliteration = "tines", Gloss = "some",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                    PartOfSpeech = "part" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "them",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "of them"
                },
                new Word { Greek = "εἶπαν", Transliteration = "eipan", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἐδύνατο", Transliteration = "edynato", Gloss = "was able",
                            GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this man",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                                    PartOfSpeech = "adv" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἀνοίξας", Transliteration = "anoixas", Gloss = "having opened",
                                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                                            PartOfSpeech = "v" }
                                    },
                                    Translation = "who opened"
                                },
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
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "τυφλοῦ
