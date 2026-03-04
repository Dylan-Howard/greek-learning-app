private static List<object> GetChapter4()
{
    // John 4:25-32
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Λέγει", Transliteration = "Legei", Gloss = "says",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γυνή", Transliteration = "gynē", Gloss = "woman",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the woman"
                }
            },
            Translation = "The woman said to him,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE", "OBJ" },
            Content = new List<object>
            {
                new Word { Greek = "οἶδα", Transliteration = "oida", Gloss = "I know",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "Μεσσίας", Transliteration = "Messias", Gloss = "Messiah",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἔρχεται", Transliteration = "erchetai", Gloss = "is coming",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "λεγόμενος", Transliteration = "legomenos", Gloss = "being called",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "χριστός", Transliteration = "christos", Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the one called Christ"
                }
            },
            Translation = "I know that Messiah is coming, the one called Christ;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅταν", Transliteration = "hotan", Gloss = "whenever",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἔλθῃ", Transliteration = "elthē", Gloss = "he comes",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἐκεῖνος", Transliteration = "ekeinos", Gloss = "that one",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pron" }
            },
            Translation = "when that one comes,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀναγγελεῖ", Transliteration = "anangelei", Gloss = "he will tell",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us",
                    GrammarCodes = new List<string> { "PRON", "DAT", "P" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἅπαντα", Transliteration = "hapanta", Gloss = "all things",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                    PartOfSpeech = "adj" }
            },
            Translation = "he will tell us all things."
        },

        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "says",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῇ", Transliteration = "autē", Gloss = "to her",
                    GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" },
                    PartOfSpeech = "pron" },
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
            Translation = "Jesus said to her,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγώ", Transliteration = "egō", Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "εἰμι", Transliteration = "eimi", Gloss = "am",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "λαλῶν", Transliteration = "lalōn", Gloss = "speaking",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "the one speaking to you."
                }
            },
            Translation = "I who speak to you am he."
        },

        // Verse 27
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
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "upon",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τούτῳ", Transliteration = "toutō", Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "upon this"
                },
                new Word { Greek = "ἦλθαν", Transliteration = "ēlthan", Gloss = "came",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "his disciples"
                }
            },
            Translation = "And upon this his disciples came;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐθαύμαζον", Transliteration = "ethaumazon", Gloss = "they were marvelling",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "and they were marvelling"
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
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "γυναικὸς", Transliteration = "gynaikos", Gloss = "a woman",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "with a woman"
                },
                new Word { Greek = "ἐλάλει", Transliteration = "elalei", Gloss = "he was speaking",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "because he was speaking with a woman."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐδεὶς", Transliteration = "oudeis", Gloss = "no one",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "μέντοι", Transliteration = "mentoi", Gloss = "however",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "However, no one said,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE", "OBJ" },
            Content = new List<object>
            {
                new Word { Greek = "τί", Transliteration = "ti", Gloss = "what",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ζητεῖς", Transliteration = "zēteis", Gloss = "do you seek",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "\"What do you seek?\""
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE", "OBJ" },
            Content = new List<object>
            {
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "τί", Transliteration = "ti", Gloss = "why",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "λαλεῖς", Transliteration = "laleis", Gloss = "do you speak",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετ᾽", Transliteration = "met'", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῆς", Transliteration = "autēs", Gloss = "her",
                            GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "with her?"
                }
            },
            Translation = "or, \"Why do you speak with her?\""
        },

        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀφῆκεν", Transliteration = "aphēken", Gloss = "left",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
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
                        new Word { Greek = "ὑδρίαν", Transliteration = "hydrian", Gloss = "water jar",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῆς", Transliteration = "autēs", Gloss = "of her",
                            GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "her water jar"
                },
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
                }
            },
            Translation = "Therefore the woman left her water jar,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀπῆλθεν", Transliteration = "apēlthen", Gloss = "went away",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πόλιν", Transliteration = "polin", Gloss = "city",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "into the city"
                }
            },
            Translation = "and went away into the city"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "says",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀνθρώποις", Transliteration = "anthrōpois", Gloss = "people",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the people,"
                }
            },
            Translation = "and said to the people,"
        },

        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "δεῦτε", Transliteration = "deute", Gloss = "come",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἴδετε", Transliteration = "idete", Gloss = "see",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἄνθρωπον", Transliteration = "anthrōpon", Gloss = "a man",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" }
            },
            Translation = "\"Come, see a man"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "who",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "εἶπέν", Transliteration = "eipen", Gloss = "told",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "μοι", Transliteration = "moi", Gloss = "me",
                    GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all things",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ὅσα", Transliteration = "hosa", Gloss = "as many as",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἐποίησα", Transliteration = "epoiēsa", Gloss = "I did",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "who told me all that I ever did."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μήτι", Transliteration = "mēti", Gloss = "can it be",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "part" },
                new Word { Greek = "οὗτός", Transliteration = "houtos", Gloss = "this",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "χριστός", Transliteration = "christos", Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the Christ?"
                }
            },
            Translation = "Can this be the Christ?\""
        },

        // Verse 30
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐξῆλθον", Transliteration = "exēlthon", Gloss = "they went out",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "out of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πόλεως", Transliteration = "poleōs", Gloss = "city",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the city"
                        }
                    },
                    Translation = "out of the city"
                }
            },
            Translation = "They went out of the city"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἤρχοντο", Transliteration = "ērchonto", Gloss = "they were coming",
                    GrammarCodes = new List<string> { "V", "IMPF", "MP", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "to him."
                }
            },
            Translation = "and were coming to him."
        },

        // Verse 31
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἐν", Transliteration = "En", Gloss = "In",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μεταξὺ", Transliteration = "metaxy", Gloss = "meanwhile",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "In the meanwhile"
                },
                new Word { Greek = "ἠρώτων", Transliteration = "ērōtōn", Gloss = "were asking",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the disciples"
                }
            },
            Translation = "In the meanwhile the disciples were asking him,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "saying,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE", "OBJ" },
            Content = new List<object>
            {
                new Word { Greek = "ῥαββί", Transliteration = "rhabbi", Gloss = "Rabbi",
                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "φάγε", Transliteration = "phage", Gloss = "eat",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "\"Rabbi, eat.\""
        },

        // Verse 32
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" }
                    },
                    Translation = "He"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                    PartOfSpeech = "pron" }
            },
            Translation = "But he said to them,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "βρῶσιν", Transliteration = "brōsin", Gloss = "food",
                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἔχω", Transliteration = "echō", Gloss = "have",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "φαγεῖν", Transliteration = "phagein", Gloss = "to eat",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                    PartOfSpeech = "v" }
            },
            Translation = "\"I have food to eat"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἣν", Transliteration = "hēn", Gloss = "which",
                    GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "part" },
                new Word { Greek = "οἴδατε", Transliteration = "oidate", Gloss = "know",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "which you do not know.\""
        }
    };
}

/*
Constructions identified:
- NOUN_PHRASE (APPOS): Messiah, the one called Christ (v25)
- PTCP (PRED): the one speaking to you (v26)
- CAUSAL_CLAUSE: because he was speaking with a woman (v27)
- REL_CLAUSE: who told me all things (v29)
- REL_CLAUSE: which you do not know (v32)
*/
