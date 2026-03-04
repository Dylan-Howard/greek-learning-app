private static List<object> GetChapter4()
{
    // John 4:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ὡς", Transliteration = "Hōs", Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἔγνω", Transliteration = "egnō", Gloss = "knew",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "verb" },
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
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "Jesus"
                        }
                    },
                    Translation = "As therefore Jesus knew"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἤκουσαν", Transliteration = "ēkousan", Gloss = "heard",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Φαρισαῖοι", Transliteration = "Pharisaioi", Gloss = "Pharisees",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "the Pharisees"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πλείονας", Transliteration = "pleionas", Gloss = "more",
                                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                                            PartOfSpeech = "adj" },
                                        new Word { Greek = "μαθητὰς", Transliteration = "mathētas", Gloss = "disciples",
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                            PartOfSpeech = "noun" }
                                    },
                                    Translation = "more disciples"
                                },
                                new Word { Greek = "ποιεῖ", Transliteration = "poiei", Gloss = "makes",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "verb" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "βαπτίζει", Transliteration = "baptizei", Gloss = "baptizes",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "verb" },
                                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "than",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "Ἰωάννης", Transliteration = "Iōannēs", Gloss = "John",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "that Jesus makes and baptizes more disciples than John"
                        }
                    },
                    Translation = "that the Pharisees heard that Jesus makes and baptizes more disciples than John"
                },
                // Verse 2
                // (continues verse 1)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καίτοιγε", Transliteration = "kaitoi-ge", Gloss = "although",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "himself",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "ἐβάπτιζεν", Transliteration = "ebaptizen", Gloss = "was baptizing",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but",
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
                                new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "his disciples"
                        }
                    },
                    Translation = "(although Jesus himself was not baptizing, but his disciples)"
                },
                // Verse 3
                // (continues verse 1)
                new Word { Greek = "ἀφῆκεν", Transliteration = "aphēken", Gloss = "he left",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Ἰουδαίαν", Transliteration = "Ioudaian", Gloss = "Judea",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "Judea"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀπῆλθεν", Transliteration = "apēlthen", Gloss = "went away",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "πάλιν", Transliteration = "palin", Gloss = "again",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Γαλιλαίαν", Transliteration = "Galilaian", Gloss = "Galilee",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "to Galilee"
                }
            },
            Translation = "Now when Jesus knew that the Pharisees had heard that Jesus was making and baptizing more disciples than John (although Jesus himself was not baptizing, but his disciples), he left Judea and went away again into Galilee."
        },
        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἔδει", Transliteration = "Edei", Gloss = "it was necessary",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "διέρχεσθαι", Transliteration = "dierchesthai", Gloss = "to pass through",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "INF" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Σαμαρείας", Transliteration = "Samareias", Gloss = "Samaria",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "through Samaria"
                        }
                    },
                    Translation = "for him to pass through Samaria"
                }
            },
            Translation = "And it was necessary for him to pass through Samaria."
        },
        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἔρχεται", Transliteration = "Erchetai", Gloss = "He comes",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "πόλιν", Transliteration = "polin", Gloss = "a city",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Σαμαρείας", Transliteration = "Samareias", Gloss = "Samaria",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "of Samaria"
                        }
                    },
                    Translation = "to a city of Samaria"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λεγομένην", Transliteration = "legomenēn", Gloss = "called",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "F", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "Συχὰρ", Transliteration = "Sychar", Gloss = "Sychar",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "called Sychar"
                },
                new Word { Greek = "πλησίον", Transliteration = "plēsion", Gloss = "near",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "χωρίου", Transliteration = "chōriou", Gloss = "plot of ground",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "the plot of ground"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἔδωκεν", Transliteration = "edōken", Gloss = "gave",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "Ἰακὼβ", Transliteration = "Iakōb", Gloss = "Jacob",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Ἰωσὴφ", Transliteration = "Iōsēph", Gloss = "Joseph",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "to Joseph"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "υἱῷ", Transliteration = "huiō", Gloss = "son",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "his son"
                        }
                    },
                    Translation = "which Jacob gave to Joseph his son"
                }
            },
            Translation = "So he came to a city of Samaria called Sychar, near the plot of ground that Jacob gave to Joseph his son."
        },
        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐκεῖ", Transliteration = "ekei", Gloss = "there",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πηγὴ", Transliteration = "pēgē", Gloss = "a spring",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Ἰακώβ", Transliteration = "Iakōb", Gloss = "Jacob",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "of Jacob"
                        }
                    },
                    Translation = "Jacob's well"
                }
            },
            Translation = "And Jacob's well was there."
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "Jesus therefore"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κεκοπιακὼς", Transliteration = "kekopiakōs", Gloss = "having become weary",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὁδοιπορίας", Transliteration = "hodoiporias", Gloss = "journey",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "from the journey"
                        }
                    },
                    Translation = "having become weary from his journey"
                },
                new Word { Greek = "ἐκαθέζετο", Transliteration = "ekathezeto", Gloss = "was sitting",
                    GrammarCodes = new List<string> { "V", "IMPF", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "thus",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "on",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πηγῇ", Transliteration = "pēgē", Gloss = "spring",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "by the spring"
                }
            },
            Translation = "Jesus therefore, having become weary from his journey, was sitting thus by the well."
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
                        new Word { Greek = "ὥρα", Transliteration = "hōra", Gloss = "hour",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "the hour"
                },
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "about",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἕκτη", Transliteration = "hektē", Gloss = "sixth",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                    PartOfSpeech = "adj" }
            },
            Translation = "It was about the sixth hour."
        },
        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἔρχεται", Transliteration = "Erchetai", Gloss = "There comes",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γυνὴ", Transliteration = "gunē", Gloss = "a woman",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "a woman"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Σαμαρείας", Transliteration = "Samareias", Gloss = "Samaria",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "of Samaria"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀντλῆσαι", Transliteration = "antlēsai", Gloss = "to draw",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "ὕδωρ", Transliteration = "hudōr", Gloss = "water",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "to draw water"
                }
            },
            Translation = "A woman of Samaria came to draw water."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "says",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῇ", Transliteration = "autē", Gloss = "to her",
                    GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" },
                    PartOfSpeech = "pronoun" },
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
                            PartOfSpeech = "noun" }
                    },
                    Translation = "Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δός", Transliteration = "dos", Gloss = "give",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me",
                            GrammarCodes = new List<string> { "PRON", "1P", "DAT", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "πεῖν", Transliteration = "pein", Gloss = "to drink",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "Give me to drink."
                }
            },
            Translation = "Jesus said to her, 'Give me to drink.'"
        },
        // Verse 8
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "For his disciples"
                },
                new Word { Greek = "ἀπεληλύθεισαν", Transliteration = "apelēlytheisan", Gloss = "had gone away",
                    GrammarCodes = new List<string> { "V", "PLPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πόλιν", Transliteration = "polin", Gloss = "city",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "into the city"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τροφὰς", Transliteration = "trophas", Gloss = "food",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "food"
                        },
                        new Word { Greek = "ἀγοράσωσιν", Transliteration = "agorasōsin", Gloss = "they might buy",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "in order to buy food"
                }
            },
            Translation = "For his disciples had gone away into the city in order to buy food."
        }
    };
}

/*
Constructions identified:
- Verse 2: Parenthetical logic (APPOS used for functional grouping)
- Verse 5: APPOS (τῷ υἱῷ αὐτοῦ)
- Verse 8: PURPOSE_CLAUSE (ἵνα τροφὰς ἀγοράσωσιν)
*/
