private static List<object> GetChapter10()
{
    // Matthew 10:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προσκαλεσάμενος", Transliteration = "proskalesamenos", Gloss = "having called", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "δώδεκα", Transliteration = "dōdeka", Gloss = "twelve", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "μαθητὰς", Transliteration = "mathētas", Gloss = "disciples", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "his twelve disciples"
                        }
                    },
                    Translation = "having called his twelve disciples"
                },
                new Word { Greek = "ἔδωκεν", Transliteration = "edōken", Gloss = "he gave", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξουσίαν", Transliteration = "exousian", Gloss = "authority", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πνευμάτων", Transliteration = "pneumatōn", Gloss = "spirits", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἀκαθάρτων", Transliteration = "akathartōn", Gloss = "unclean", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "over unclean spirits"
                        }
                    },
                    Translation = "authority over unclean spirits"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "RESULT_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὥστε", Transliteration = "hōste", Gloss = "so as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκβάλλειν", Transliteration = "ekballein", Gloss = "to cast out", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "αὐτὰ", Transliteration = "auta", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "to cast them out"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "θεραπεύειν", Transliteration = "therapeuein", Gloss = "to heal", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πᾶσαν", Transliteration = "pasan", Gloss = "every", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "νόσον", Transliteration = "noson", Gloss = "disease", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "every disease"
                                },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πᾶσαν", Transliteration = "pasan", Gloss = "every", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "μαλακίαν", Transliteration = "malakian", Gloss = "sickness", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "every sickness"
                                }
                            },
                            Translation = "to heal every disease and every sickness"
                        }
                    },
                    Translation = "so as to cast them out and to heal every disease and every sickness"
                }
            },
            Translation = "And having called his twelve disciples, he gave them authority over unclean spirits, so as to cast them out and to heal every disease and every sickness."
        },
        // Verse 2
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
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Τῶν", Transliteration = "Tōn", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "δώδεκα", Transliteration = "dōdeka", Gloss = "twelve", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἀποστόλων", Transliteration = "apostolōn", Gloss = "apostles", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the twelve apostles"
                        },
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὀνόματά", Transliteration = "onomata", Gloss = "names", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the names of the twelve apostles"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these", GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" }, PartOfSpeech = "pron" },
                new Word { Greek = "πρῶτος", Transliteration = "prōtos", Gloss = "first", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Σίμων", Transliteration = "Simōn", Gloss = "Simon", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "λεγόμενος", Transliteration = "legomenos", Gloss = "called", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "Πέτρος", Transliteration = "Petros", Gloss = "Peter", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "who is called Peter"
                        }
                    },
                    Translation = "Simon who is called Peter"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἀνδρέας", Transliteration = "Andreas", Gloss = "Andrew", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀδελφὸς", Transliteration = "adelphos", Gloss = "brother", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "his brother"
                        }
                    },
                    Translation = "Andrew his brother"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰάκωβος", Transliteration = "Iakōbos", Gloss = "James", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Ζεβεδαίου", Transliteration = "Zebedaiou", Gloss = "of Zebedee", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "son of Zebedee"
                        }
                    },
                    Translation = "James the son of Zebedee"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰωάννης", Transliteration = "Iōannēs", Gloss = "John", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀδελφὸς", Transliteration = "adelphos", Gloss = "brother", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "his brother"
                        }
                    },
                    Translation = "John his brother"
                }
            },
            Translation = "Now the names of the twelve apostles are these: first, Simon who is called Peter, and Andrew his brother, and James the son of Zebedee, and John his brother;"
        },
        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "APPOS" },
            Content = new List<object>
            {
                new Word { Greek = "Φίλιππος", Transliteration = "Philippos", Gloss = "Philip", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "Βαρθολομαῖος", Transliteration = "Bartholomaios", Gloss = "Bartholomew", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "Θωμᾶς", Transliteration = "Thōmas", Gloss = "Thomas", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Μαθθαῖος", Transliteration = "Maththaios", Gloss = "Matthew", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "τελώνης", Transliteration = "telōnēs", Gloss = "tax collector", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Matthew the tax collector"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰάκωβος", Transliteration = "Iakōbos", Gloss = "James", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἁλφαίου", Transliteration = "Alphaiou", Gloss = "of Alphaeus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "James the son of Alphaeus"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "Θαδδαῖος", Transliteration = "Thaddaios", Gloss = "Thaddaeus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "Philip and Bartholomew; Thomas and Matthew the tax collector; James the son of Alphaeus, and Thaddaeus;"
        },
        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "APPOS" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Σίμων", Transliteration = "Simōn", Gloss = "Simon", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Καναναῖος", Transliteration = "Kananaios", Gloss = "Zealot", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Simon the Zealot"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰούδας", Transliteration = "Ioudas", Gloss = "Judas", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰσκαριώτης", Transliteration = "Iskariōtēs", Gloss = "Iscariot", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "who", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "παραδοὺς", Transliteration = "paradous", Gloss = "betrayed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "who also betrayed him"
                        }
                    },
                    Translation = "Judas Iscariot, who also betrayed him"
                }
            },
            Translation = "Simon the Zealot, and Judas Iscariot, who also betrayed him."
        },
        // Verse 5
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
                        new Word { Greek = "Τούτους", Transliteration = "Toutous", Gloss = "these", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "δώδεκα", Transliteration = "dōdeka", Gloss = "twelve", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "these twelve"
                },
                new Word { Greek = "ἀπέστειλεν", Transliteration = "apesteilen", Gloss = "sent out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παραγγείλας", Transliteration = "parangeilas", Gloss = "having charged", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "having charged them"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὁδὸν", Transliteration = "hodon", Gloss = "road", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἐθνῶν", Transliteration = "ethnōn", Gloss = "of Gentiles", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "into a road of the Gentiles"
                        },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                        new Word { Greek = "ἀπέλθητε", Transliteration = "apelthēte", Gloss = "you should go", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "Go nowhere among the Gentiles"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "πόλιν", Transliteration = "polin", Gloss = "city", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Σαμαριτῶν", Transliteration = "Samaritōn", Gloss = "of Samaritans", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "into a city of the Samaritans"
                        },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                        new Word { Greek = "εἰσέλθητε", Transliteration = "eiselthēte", Gloss = "you should enter", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "and enter no town of the Samaritans"
                }
            },
            Translation = "These twelve Jesus sent out, instructing them, 'Go nowhere among the Gentiles and enter no town of the Samaritans,"
        },
        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πορεύεσθε", Transliteration = "poreuesthe", Gloss = "go", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "rather", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "πρόβατα", Transliteration = "probata", Gloss = "sheep", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἀπολωλότα", Transliteration = "apolōlota", Gloss = "lost", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "ACC", "N", "P" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "lost"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "οἴκου", Transliteration = "oikou", Gloss = "of the house", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "Ἰσραήλ", Transliteration = "Israēl", Gloss = "of Israel", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the house of Israel"
                                }
                            },
                            Translation = "the lost sheep of the house of Israel"
                        }
                    },
                    Translation = "to the lost sheep of the house of Israel"
                }
            },
            Translation = "but go rather to the lost sheep of the house of Israel."
        },
        // Verse 7
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
                        new Word { Greek = "πορευόμενοι", Transliteration = "poreuomenoi", Gloss = "going", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "as you go"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κηρύσσετε", Transliteration = "kēryssete", Gloss = "preach", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἤγγικεν", Transliteration = "ēngiken", Gloss = "has come near", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "βασιλεία", Transliteration = "basileia", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "οὐρανῶν", Transliteration = "ouranōn", Gloss = "heavens", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the heavens"
                                }
                            },
                            Translation = "the kingdom of the heavens"
                        }
                    },
                    Translation = "The kingdom of heaven is at hand"
                }
            },
            Translation = "And proclaim as you go, saying, 'The kingdom of heaven is at hand.'"
        },
        // Verse 8
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
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀσθενοῦντας", Transliteration = "asthenountas", Gloss = "those who are weak", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "the sick"
                        },
                        new Word { Greek = "θεραπεύετε", Transliteration = "therapeuete", Gloss = "heal", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "Heal the sick"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "νεκροὺς", Transliteration = "nekrous", Gloss = "dead", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐγείρετε", Transliteration = "egeirete", Gloss = "raise", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "raise the dead"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λεπροὺς", Transliteration = "leprous", Gloss = "lepers", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "καθαρίζετε", Transliteration = "katharizete", Gloss = "cleanse", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "cleanse lepers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δαιμόνια", Transliteration = "daimonia", Gloss = "demons", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἐκβάλλετε", Transliteration = "ekballete", Gloss = "cast out", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "cast out demons"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δωρεὰν", Transliteration = "dōrean", Gloss = "freely", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ἐλάβετε", Transliteration = "elabete", Gloss = "you received", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "You received without paying"
                },
                new Word { Greek = "δωρεὰν", Transliteration = "dōrean", Gloss = "freely", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "δότε", Transliteration = "dote", Gloss = "give", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "Heal the sick, raise the dead, cleanse lepers, cast out demons. You received without paying; give without pay."
        }
    };
}
/*
Constructions identified:
- GEN_OBJ: "ἐξουσίαν πνευμάτων" (authority over spirits), 10:1
- GEN_DESC: "πνευμάτων ἀκαθάρτων" (unclean spirits), 10:1
- SUBSTANTIVE_PTCP: "ὁ λεγόμενος Πέτρος" (the one called Peter), 10:2
- SUBSTANTIVE_PTCP: "ἀσθενοῦντας" (the sick ones), 10:8
- GEN_RELATION: "ὁ τοῦ Ζεβεδαίου" (the [son] of Zebedee), 10:2; "ὁ τοῦ Ἁλφαίου" (the [son] of Alphaeus), 10:3
*/
