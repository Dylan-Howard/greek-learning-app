private static List<object> GetChapter5()
{
    // John 5:41-47
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Δόξαν", Transliteration = "Doxan", Gloss = "glory",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "glory"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρὰ", Transliteration = "para", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἀνθρώπων", Transliteration = "anthrōpōn", Gloss = "human beings",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "from human beings"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "λαμβάνω", Transliteration = "lambanō", Gloss = "I receive",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "Glory from human beings I do not receive."
        },

        // Verse 42
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἔγνωκα", Transliteration = "egnōka", Gloss = "I know",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" },
                    PartOfSpeech = "prep" },
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
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀγάπην", Transliteration = "agapēn", Gloss = "love",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "the love of God"
                        },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἔχετε", Transliteration = "echete", Gloss = "you have",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἑαυτοῖς", Transliteration = "heautois", Gloss = "yourselves",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "2P", "P" },
                                    PartOfSpeech = "f" }
                            },
                            Translation = "in yourselves"
                        }
                    },
                    Translation = "that the love of God you do not have in yourselves"
                }
            },
            Translation = "But I know you, that you do not have the love of God in yourselves."
        },

        // Verse 43
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐλήλυθα", Transliteration = "elēlytha", Gloss = "I have come",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὀνόματι", Transliteration = "onomati", Gloss = "name",
                                    GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "πατρός", Transliteration = "patros", Gloss = "Father",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "of my Father"
                                }
                            },
                            Translation = "the name of my Father"
                        }
                    },
                    Translation = "in the name of my Father"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "λαμβάνετέ", Transliteration = "lambanete", Gloss = "you receive",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἄλλος", Transliteration = "allos", Gloss = "another",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἔλθῃ", Transliteration = "elthē", Gloss = "he comes",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ὀνόματι", Transliteration = "onomati", Gloss = "name",
                                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἰδίῳ", Transliteration = "idiō", Gloss = "his own",
                                            GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" },
                                            PartOfSpeech = "adj" }
                                    },
                                    Translation = "his own name"
                                }
                            },
                            Translation = "in his own name"
                        },
                        new Word { Greek = "ἐκεῖνον", Transliteration = "ekeinon", Gloss = "that one",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "λήμψεσθε", Transliteration = "lēmpsesthe", Gloss = "you will receive",
                            GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "if another comes in his own name, him you will receive"
                }
            },
            Translation = "I have come in my Father’s name, and you do not receive me; if another comes in his own name, him you will receive."
        },

        // Verse 44
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πῶς", Transliteration = "pōs", Gloss = "how",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "δύνασθε", Transliteration = "dynasthe", Gloss = "are you able",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πιστεῦσαι", Transliteration = "pisteusai", Gloss = "to believe",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "to believe"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λαμβάνοντες", Transliteration = "lambanontes", Gloss = "receiving",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δόξαν", Transliteration = "doxan", Gloss = "glory",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "glory"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παρὰ", Transliteration = "para", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἀλλήλων", Transliteration = "allēlōn", Gloss = "one another",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                                    PartOfSpeech = "conj" }
                            },
                            Translation = "from one another"
                        }
                    },
                    Translation = "receiving glory from one another"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
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
                        new Word { Greek = "δόξαν", Transliteration = "doxan", Gloss = "glory",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "παρὰ", Transliteration = "para", Gloss = "from",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "μόνου", Transliteration = "monou", Gloss = "only
