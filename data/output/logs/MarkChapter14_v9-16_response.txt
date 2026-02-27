private static List<object> GetChapter14()
{
    // Mark 14:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀμὴν", Transliteration = "amēn", Gloss = "truly", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I say", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", Grammar_Codes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "wherever", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                        new Word { Greek = "κηρυχθῇ", Transliteration = "kērychthē", Gloss = "it is preached", Grammar_Codes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "εὐαγγέλιον", Transliteration = "euangelion", Gloss = "gospel", Grammar_Codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the gospel"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ὅλον", Transliteration = "holon", Gloss = "all", Grammar_Codes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "κόσμον", Transliteration = "kosmon", Gloss = "world", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "into the whole world"
                        }
                    },
                    Translation = "wherever the gospel is preached in the whole world"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "that which", Grammar_Codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen", Gloss = "she did", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "αὕτη", Transliteration = "hautē", Gloss = "this woman", Grammar_Codes = new List<string> { "PRON", "NOM", "F", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "what she has done"
                },
                new Word { Greek = "λαληθήσεται", Transliteration = "lalēthēsetai", Gloss = "will be told", Grammar_Codes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "μνημόσυνον", Transliteration = "mnēmosynon", Gloss = "a memorial", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτῆς", Transliteration = "autēs", Gloss = "of her", Grammar_Codes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "in memory of her"
                }
            },
            Translation = "Truly I say to you, wherever the gospel is preached in the whole world, what she has done will also be told in memory of her."
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰούδας", Transliteration = "Ioudas", Gloss = "Judas", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "Ἰσκαριὼθ", Transliteration = "Iskariōth", Gloss = "Iscariot", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "εἷς", Transliteration = "heis", Gloss = "one", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "δώδεκα", Transliteration = "dōdeka", Gloss = "twelve", Grammar_Codes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" }
                                    },
                                    Translation = "of the twelve"
                                }
                            },
                            Translation = "one of the twelve"
                        }
                    },
                    Translation = "Judas Iscariot, one of the twelve"
                },
                new Word { Greek = "ἀπῆλθεν", Transliteration = "apēlthen", Gloss = "went away", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἀρχιερεῖς", Transliteration = "archiereis", Gloss = "chief priests", Grammar_Codes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "to the chief priests"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", Grammar_Codes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "παραδοῖ", Transliteration = "paradoi", Gloss = "he might hand over", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", Grammar_Codes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "that he might betray him to them"
                }
            },
            Translation = "And Judas Iscariot, one of the twelve, went to the chief priests in order to betray him to them."
        },

        // Verse 11
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "they", Grammar_Codes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" }
                    },
                    Translation = "And they"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀκούσαντες", Transliteration = "akousantes", Gloss = "having heard", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "when they heard it"
                },
                new Word { Greek = "ἐχάρησαν", Transliteration = "echarēsan", Gloss = "rejoiced", Grammar_Codes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐπηγγείλαντο", Transliteration = "epēngeilanto", Gloss = "promised", Grammar_Codes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", Grammar_Codes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀργύριον", Transliteration = "argyrion", Gloss = "money", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "δοῦναι", Transliteration = "dounai", Gloss = "to give", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to give him money"
                }
            },
            Translation = "And when they heard it, they rejoiced and promised to give him money."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐζήτει", Transliteration = "ezētei", Gloss = "he was seeking", Grammar_Codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πῶς", Transliteration = "pōs", Gloss = "how", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", Grammar_Codes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "εὐκαίρως", Transliteration = "eukairōs", Gloss = "opportunely", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "παραδοῖ", Transliteration = "paradoi", Gloss = "he might hand over", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "how he might betray him conveniently"
                }
            },
            Translation = "And he sought how he might betray him conveniently."
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "on the", Grammar_Codes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "πρώτῃ", Transliteration = "prōtē", Gloss = "first", Grammar_Codes = new List<string> { "ADJ", "DAT", "F", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἡμέρᾳ", Transliteration = "hēmera", Gloss = "day", Grammar_Codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", Grammar_Codes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἀζύμων", Transliteration = "azymōn", Gloss = "unleavened bread", Grammar_Codes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "of Unleavened Bread"
                        }
                    },
                    Translation = "on the first day of Unleavened Bread"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτε", Transliteration = "hote", Gloss = "when", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "πάσχα", Transliteration = "pascha", Gloss = "Passover", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the Passover lamb"
                        },
                        new Word { Greek = "ἔθυον", Transliteration = "ethyon", Gloss = "they sacrificed", Grammar_Codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "when they sacrificed the Passover lamb"
                },
                new Word { Greek = "λέγουσιν", Transliteration = "legousin", Gloss = "said", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", Grammar_Codes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples", Grammar_Codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "his disciples"
                }
            },
            Translation = "And on the first day of Unleavened Bread, when they sacrificed the Passover lamb, his disciples said to him,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ποῦ", Transliteration = "pou", Gloss = "Where", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "θέλεις", Transliteration = "theleis", Gloss = "do you want", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπελθόντες", Transliteration = "apelthontes", Gloss = "having gone", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "that we go"
                },
                new Word { Greek = "ἑτοιμάσωμεν", Transliteration = "hetoimasōmen", Gloss = "we should prepare", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "φάγῃς", Transliteration = "phagēs", Gloss = "you may eat", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "πάσχα", Transliteration = "pascha", Gloss = "Passover", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the Passover"
                        }
                    },
                    Translation = "so that you may eat the Passover?"
                }
            },
            Translation = "\"Where do you want us to go and prepare so that you may eat the Passover?\""
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἀποστέλλει", Transliteration = "apostellei", Gloss = "he sent", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δύο", Transliteration = "dyo", Gloss = "two", Grammar_Codes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "μαθητῶν", Transliteration = "mathētōn", Gloss = "disciples", Grammar_Codes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "of his disciples"
                        }
                    },
                    Translation = "two of his disciples"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "said", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", Grammar_Codes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" }
            },
            Translation = "And he sent two of his disciples and said to them,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὑπάγετε", Transliteration = "hypagete", Gloss = "Go", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "πόλιν", Transliteration = "polin", Gloss = "city", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "into the city"
                }
            },
            Translation = "\"Go into the city,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἀπαντήσει", Transliteration = "apantēsei", Gloss = "will meet", Grammar_Codes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you", Grammar_Codes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄνθρωπος", Transliteration = "anthrōpos", Gloss = "a man", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κεράμιον", Transliteration = "keramion", Gloss = "a jar", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ὕδατος", Transliteration = "hydatos", Gloss = "of water", Grammar_Codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "a jar of water"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "βαστάζων", Transliteration = "bastazōn", Gloss = "carrying", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "carrying"
                        }
                    },
                    Translation = "a man carrying a jar of water"
                }
            },
            Translation = "and a man carrying a jar of water will meet you."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀκολουθήσατε", Transliteration = "akolouthēsate", Gloss = "Follow", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", Grammar_Codes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" }
            },
            Translation = "Follow him,"
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "wherever", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                        new Word { Greek = "εἰσέλθῃ", Transliteration = "eiselthē", Gloss = "he may enter", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "wherever he enters"
                },
                new Word { Greek = "εἴπατε", Transliteration = "eipate", Gloss = "say", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", Grammar_Codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "οἰκοδεσπότῃ", Transliteration = "oikodespotē", Gloss = "master of the house", Grammar_Codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "to the master of the house"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "διδάσκαλος", Transliteration = "didaskalos", Gloss = "Teacher", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the Teacher"
                        },
                        new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "says", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "that the Teacher says"
                }
            },
            Translation = "and wherever he enters, say to the master of the house, 'The Teacher says,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ποῦ", Transliteration = "pou", Gloss = "Where", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "κατάλυμά", Transliteration = "katalyma", Gloss = "guest room", Grammar_Codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", Grammar_Codes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "my guest room"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπου", Transliteration = "hopou", Gloss = "where", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "πάσχα", Transliteration = "pascha", Gloss = "Passover", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the Passover"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "μαθητῶν", Transliteration = "mathētōn", Gloss = "disciples", Grammar_Codes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", Grammar_Codes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "my disciples"
                                }
                            },
                            Translation = "with my disciples"
                        },
                        new Word { Greek = "φάγω", Transliteration = "phagō", Gloss = "I may eat", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "where I may eat the Passover with my disciples?\"'"
                }
            },
            Translation = "\"Where is my guest room, where I may eat the Passover with my disciples?\""
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he", Grammar_Codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", Grammar_Codes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "δείξει", Transliteration = "deixei", Gloss = "will show", Grammar_Codes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνάγαιον", Transliteration = "anagaion", Gloss = "upper room", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "μέγα", Transliteration = "mega", Gloss = "large", Grammar_Codes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adjective" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐστρωμένον", Transliteration = "estrōmenon", Gloss = "furnished", Grammar_Codes = new List<string> { "V", "PERF", "PASS", "PTCP", "ACC", "N", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "furnished"
                        },
                        new Word { Greek = "ἕτοιμον", Transliteration = "hetoimon", Gloss = "ready", Grammar_Codes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "a large upper room, furnished and ready"
                }
            },
            Translation = "And he will show you a large upper room, furnished and ready;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐκεῖ", Transliteration = "ekei", Gloss = "there", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "ἑτοιμάσατε", Transliteration = "hetoimasate", Gloss = "prepare", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "for us", Grammar_Codes = new List<string> { "PRON", "DAT", "1P", "P" }, PartOfSpeech = "pronoun" }
            },
            Translation = "prepare for us there.\""
        },

        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐξῆλθον", Transliteration = "exēlthon", Gloss = "went out", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples", Grammar_Codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the disciples"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἦλθον", Transliteration = "ēlthon", Gloss = "came", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "πόλιν", Transliteration = "polin", Gloss = "city", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "into the city"
                }
            },
            Translation = "And the disciples went out and came into the city"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "εὗρον", Transliteration = "heuron", Gloss = "found", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "just as", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he had said", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", Grammar_Codes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "just as he had told them"
                }
            },
            Translation = "and found it just as he had told them;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἡτοίμασαν", Transliteration = "hētoimasan", Gloss = "they prepared", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "πάσχα", Transliteration = "pascha", Gloss = "Passover", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the Passover"
                }
            },
            Translation = "and they prepared the Passover."
        }
    };
}
/*
Constructions Identified:
- Verse 10: APPOS (Ἰούδας Ἰσκαριὼθ ὁ εἷς τῶν δώδεκα)
- Verse 12: GEN_DESC (τῶν ἀζύμων - day describing the type of feast)
- Verse 13: PTCP (ἄνθρωπος... βαστάζων - substantival/adjectival participle)
- Verse 15: PTCP (ἐστρωμένον - perfect passive participle)
*/
