private static List<object> GetChapter5()
{
    // Luke 5:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "θάμβος", Transliteration = "thambos", Gloss = "amazement",
                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                    PartOfSpeech = "noun" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "περιέσχεν", Transliteration = "perieschen", Gloss = "seized",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάντας", Transliteration = "pantas", Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adjective" },
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "those",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "article" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "σὺν", Transliteration = "syn", Gloss = "with",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "with him"
                        }
                    },
                    Translation = "all those with him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "at",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "ἄγρᾳ", Transliteration = "agra", Gloss = "catch",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "the catch"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "ἰχθύων", Transliteration = "ichthyōn", Gloss = "fish",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "of the fish"
                        }
                    },
                    Translation = "at the catch of the fish"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "συνέλαβον", Transliteration = "synelabon", Gloss = "they caught",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "which they caught"
                }
            },
            Translation = "For amazement seized him and all those with him at the catch of the fish which they had caught,"
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 9)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁμοίως", Transliteration = "homoiōs", Gloss = "likewise",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adverb" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "Ἰάκωβον", Transliteration = "Iakōbon", Gloss = "James",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "Ἰωάννην", Transliteration = "Iōannēn", Gloss = "John",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "υἱοὺς", Transliteration = "hyious", Gloss = "sons",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "Ζεβεδαίου", Transliteration = "Zebedaiou", Gloss = "of Zebedee",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "sons of Zebedee"
                        }
                    },
                    Translation = "and likewise also James and John, sons of Zebedee"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἳ", Transliteration = "hoi", Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἦσαν", Transliteration = "ēsan", Gloss = "were",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "κοινωνοὶ", Transliteration = "koinōnoi", Gloss = "partners",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "with",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "Σίμωνι", Transliteration = "Simōni", Gloss = "Simon",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "who were partners with Simon."
                }
            },
            Translation = "and likewise also James and John, sons of Zebedee, who were partners with Simon."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "Σίμωνα", Transliteration = "Simōna", Gloss = "Simon",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "to Simon"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "Jesus"
                }
            },
            Translation = "And Jesus said to Simon,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "particle" },
                new Word { Greek = "φοβοῦ", Transliteration = "phobou", Gloss = "be afraid",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "S" },
                    PartOfSpeech = "verb" }
            },
            Translation = "\"Do not be afraid;"
        },
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
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adverb" }
                    },
                    Translation = "from now on"
                },
                new Word { Greek = "ἀνθρώπους", Transliteration = "anthrōpous", Gloss = "men",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                    PartOfSpeech = "noun" },
                new Word { Greek = "ἔσῃ", Transliteration = "esē", Gloss = "you will be",
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "2P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "ζωγρῶν", Transliteration = "zōgrōn", Gloss = "catching",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "verb" }
            },
            Translation = "from now on you will be catching men.\""
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καταγαγόντες", Transliteration = "katagagontes", Gloss = "having brought",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "πλοῖα", Transliteration = "ploia", Gloss = "boats",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "the boats"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "γῆν", Transliteration = "gēn", Gloss = "land",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "to the land"
                        }
                    },
                    Translation = "having brought the boats to the land"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀφέντες", Transliteration = "aphentes", Gloss = "having left",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "everything",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adjective" }
                    },
                    Translation = "having left everything"
                },
                new Word { Greek = "ἠκολούθησαν", Transliteration = "ēkolouthēsan", Gloss = "they followed",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "pronoun" }
            },
            Translation = "And when they had brought their boats to land, they left everything and followed him."
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "it happened",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "while",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "he",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "μιᾷ", Transliteration = "mia", Gloss = "one",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                                    PartOfSpeech = "adjective" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "P" },
                                            PartOfSpeech = "article" },
                                        new Word { Greek = "πόλεων", Transliteration = "poleōn", Gloss = "cities",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "P" },
                                            PartOfSpeech = "noun" }
                                    },
                                    Translation = "of the cities"
                                }
                            },
                            Translation = "in one of the cities"
                        }
                    },
                    Translation = "while he was in one of the cities"
                }
            },
            Translation = "And it happened while he was in one of the cities,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold",
                    GrammarCodes = new List<string> { "INTERJ" },
                    PartOfSpeech = "interjection" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνὴρ", Transliteration = "anēr", Gloss = "a man",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "ADJ_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πλήρης", Transliteration = "plērēs", Gloss = "full",
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                                    PartOfSpeech = "adjective" },
                                new Word { Greek = "λέπρας", Transliteration = "lepras", Gloss = "of leprosy",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "full of leprosy"
                        }
                    },
                    Translation = "a man full of leprosy"
                }
            },
            Translation = "and behold, a man full of leprosy;"
        },
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
                        new Word { Greek = "ἰδὼν", Transliteration = "idōn", Gloss = "having seen",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "Ἰησοῦν", Transliteration = "Iēsoun", Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "having seen Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πεσὼν", Transliteration = "pesōn", Gloss = "falling",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "on",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "πρόσωπον", Transliteration = "prosōpon", Gloss = "face",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "on his face"
                        }
                    },
                    Translation = "falling on his face"
                },
                new Word { Greek = "ἐδεήθη", Transliteration = "edeēthē", Gloss = "he entreated",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "verb" }
            },
            Translation = "when he saw Jesus, he fell on his face and entreated him, saying,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "κύριε", Transliteration = "kyrie", Gloss = "Lord",
                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                    PartOfSpeech = "noun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "θέλῃς", Transliteration = "thelēs", Gloss = "you are willing",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "2P", "S" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "if you are willing"
                },
                new Word { Greek = "δύνασαί", Transliteration = "dynasai", Gloss = "you are able",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "2P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "καθαρίσαι", Transliteration = "katharisai", Gloss = "to cleanse",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                    PartOfSpeech = "verb" }
            },
            Translation = "\"Lord, if you are willing, you are able to make me clean.\""
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκτείνας", Transliteration = "ekteinas", Gloss = "stretching out",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "χεῖρα", Transliteration = "cheira", Gloss = "hand",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "stretching out his hand"
                },
                new Word { Greek = "ἥψατο", Transliteration = "hēpsato", Gloss = "touched",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "verb" }
            },
            Translation = "And stretching out his hand, he touched him, saying,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "θέλω", Transliteration = "thelō", Gloss = "I am willing",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "καθαρίσθητι", Transliteration = "katharisthēti", Gloss = "be cleansed",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IMP", "2P", "S" },
                    PartOfSpeech = "verb" }
            },
            Translation = "\"I am willing; be cleansed.\""
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "εὐθέως", Transliteration = "eutheōs", Gloss = "immediately",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "λέπρα", Transliteration = "lepra", Gloss = "leprosy",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "the leprosy"
                },
                new Word { Greek = "ἀπῆλθεν", Transliteration = "apēlthen", Gloss = "departed",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπ᾽", Transliteration = "ap’", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "from him"
                }
            },
            Translation = "And immediately the leprosy departed from him."
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "παρήγγειλεν", Transliteration = "parēngeilen", Gloss = "commanded",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μηδενὶ", Transliteration = "mēdeni", Gloss = "no one",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" },
                            PartOfSpeech = "adjective" },
                        new Word { Greek = "εἰπεῖν", Transliteration = "eipein", Gloss = "to tell",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "to tell no one"
                }
            },
            Translation = "And he commanded him to tell no one,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all’", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπελθὼν", Transliteration = "apelthōn", Gloss = "having gone",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "having gone"
                },
                new Word { Greek = "δεῖξον", Transliteration = "deixon", Gloss = "show",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "σεαυτὸν", Transliteration = "seauton", Gloss = "yourself",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "ἱερεῖ", Transliteration = "hierei", Gloss = "priest",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "to the priest"
                }
            },
            Translation = "\"but go and show yourself to the priest,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "προσένεγκε", Transliteration = "prosenenke", Gloss = "offer",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "καθαρισμοῦ", Transliteration = "katharismou", Gloss = "cleansing",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "your cleansing"
                        }
                    },
                    Translation = "for your cleansing"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "προσέταξεν", Transliteration = "prosetaxen", Gloss = "commanded",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "Μωϋσῆς", Transliteration = "Mōysēs", Gloss = "Moses",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "as Moses commanded"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "μαρτύριον", Transliteration = "martyrion", Gloss = "a testimony",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "for a testimony to them.\""
                }
            },
            Translation = "and offer for your cleansing, as Moses commanded, for a testimony to them.\""
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "διήρχετο", Transliteration = "diērcheto", Gloss = "spread",
                    GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "more",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "λόγος", Transliteration = "logos", Gloss = "report",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "the report"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "about him"
                }
            },
            Translation = "But the report about him spread even more,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "συνήρχοντο", Transliteration = "synērchonto", Gloss = "were coming together",
                    GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "P" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὄχλοι", Transliteration = "ochloi", Gloss = "crowds",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "πολλοὶ", Transliteration = "polloi", Gloss = "many",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adjective" }
                    },
                    Translation = "many crowds"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀκούειν", Transliteration = "akouein", Gloss = "to hear",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "θεραπεύεσθαι", Transliteration = "therapeuesthai", Gloss = "to be healed",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "INF" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "P" },
                                            PartOfSpeech = "article" },
                                        new Word { Greek = "ἀσθενειῶν", Transliteration = "astheneion", Gloss = "infirmities",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "P" },
                                            PartOfSpeech = "noun" },
                                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                                            PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "their infirmities"
                                }
                            },
                            Translation = "from their infirmities"
                        }
                    },
                    Translation = "to hear and to be healed from their infirmities"
                }
            },
            Translation = "and many crowds were coming together to hear and to be healed from their infirmities."
        },

        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "ὑποχωρῶν", Transliteration = "hypochōrōn", Gloss = "withdrawing",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "P" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "ἐρήμοις", Transliteration = "erēmois", Gloss = "wilderness",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "P" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "the wilderness"
                        }
                    },
                    Translation = "in the wilderness"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "προσευχόμενος", Transliteration = "proseuchomenos", Gloss = "praying",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "verb" }
            },
            Translation = "But he would withdraw to the wilderness and pray."
        }
    };
}

/*
Constructions identified:
- PERIPH: ἔσῃ ζωγρῶν (Luke 5:10)
- PERIPH: ἦν ὑποχωρῶν (Luke 5:16)
- PERIPH: ἦν προσευχόμενος (Luke 5:16)
*/
