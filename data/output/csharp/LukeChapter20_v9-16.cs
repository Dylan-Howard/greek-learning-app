private static List<object> GetChapter20()
{
    // Luke 20:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἤρξατο", Transliteration = "Ērxato",
                    Gloss = "He began",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "λαὸν", Transliteration = "laon",
                            Gloss = "people",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the people"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγειν", Transliteration = "legein",
                            Gloss = "to say",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "παραβολὴν", Transliteration = "parabolēn",
                                    Gloss = "parable",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ταύτην", Transliteration = "tautēn",
                                    Gloss = "this",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "this parable"
                        }
                    },
                    Translation = "to tell this parable"
                }
            },
            Translation = "But He began to tell this parable to the people:"
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
                        new Word { Greek = "ἄνθρωπός", Transliteration = "anthrōpos",
                            Gloss = "a man",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τις", Transliteration = "tis",
                            Gloss = "a certain",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "part" }
                    },
                    Translation = "A certain man"
                },
                new Word { Greek = "ἐφύτευσεν", Transliteration = "ephyteusen",
                    Gloss = "planted",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀμπελῶνα", Transliteration = "ampelōna",
                            Gloss = "a vineyard",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "a vineyard"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐξέδετο", Transliteration = "exedeto",
                    Gloss = "leased",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton",
                    Gloss = "it",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γεωργοῖς", Transliteration = "geōrgois",
                            Gloss = "to farmers",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to vine-growers"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀπεδήμησεν", Transliteration = "apedēmēsen",
                    Gloss = "went away",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χρόνους", Transliteration = "chronous",
                            Gloss = "times",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἱκανούς", Transliteration = "ikanous",
                            Gloss = "sufficient",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "for a long time"
                }
            },
            Translation = "A certain man planted a vineyard, and leased it to vine-growers, and went on a journey for a long time."
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καιρῷ", Transliteration = "kairō",
                            Gloss = "at the season",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "at the harvest time"
                },
                new Word { Greek = "ἀπέστειλεν", Transliteration = "apesteilen",
                    Gloss = "he sent",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γεωργοὺς", Transliteration = "geōrgous",
                            Gloss = "farmers",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the vine-growers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δοῦλον", Transliteration = "doulon",
                            Gloss = "a slave",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "a slave"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina",
                            Gloss = "so that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo",
                                    Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "καρποῦ", Transliteration = "karpou",
                                    Gloss = "fruit",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀμπελῶνος", Transliteration = "ampelōnos",
                                    Gloss = "vineyard",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "from the fruit of the vineyard"
                        },
                        new Word { Greek = "δώσουσιν", Transliteration = "dōsousin",
                            Gloss = "they would give",
                            GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō",
                            Gloss = "to him",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "so that they would give him some of the fruit of the vineyard"
                }
            },
            Translation = "At the harvest time he sent a slave to the vine-growers, so that they would give him some of the fruit of the vineyard;"
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
                        new Word { Greek = "οἱ", Transliteration = "hoi",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "γεωργοὶ", Transliteration = "geōrgoi",
                            Gloss = "farmers",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "but the vine-growers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δείραντες", Transliteration = "deirantes",
                            Gloss = "having beaten",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton",
                            Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "having beaten him"
                },
                new Word { Greek = "ἐξαπέστειλαν", Transliteration = "exapesteilan",
                    Gloss = "they sent away",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "κενόν", Transliteration = "kenon",
                    Gloss = "empty-handed",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                    PartOfSpeech = "adj" }
            },
            Translation = "but the vine-growers beat him and sent him away empty-handed."
        },
        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "προσέθετο", Transliteration = "prosetheto",
                    Gloss = "he added",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πέμψαι", Transliteration = "pempsai",
                            Gloss = "to send",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἕτερον", Transliteration = "heteron",
                                    Gloss = "another",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "δοῦλον", Transliteration = "doulon",
                                    Gloss = "slave",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "another slave"
                        }
                    },
                    Translation = "to send another slave"
                }
            },
            Translation = "And he proceeded to send another slave;"
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
                        new Word { Greek = "οἱ", Transliteration = "hoi",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" }
                    },
                    Translation = "and they"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κἀκεῖνον", Transliteration = "kakeinon",
                            Gloss = "that one also",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "δείραντες", Transliteration = "deirantes",
                            Gloss = "having beaten",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἀτιμάσαντες", Transliteration = "atimasantes",
                            Gloss = "having dishonored",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having beaten and dishonored that one also"
                },
                new Word { Greek = "ἐξαπέστειλαν", Transliteration = "exapesteilan",
                    Gloss = "they sent away",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "κενόν", Transliteration = "kenon",
                    Gloss = "empty-handed",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                    PartOfSpeech = "adj" }
            },
            Translation = "and they beat him also and treated him shamefully, and sent him away empty-handed."
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "προσέθετο", Transliteration = "prosetheto",
                    Gloss = "he added",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πέμψαι", Transliteration = "pempsai",
                            Gloss = "to send",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "τρίτον", Transliteration = "triton",
                            Gloss = "a third",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "to send a third"
                }
            },
            Translation = "And he proceeded to send a third;"
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
                        new Word { Greek = "οἱ", Transliteration = "hoi",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" }
                    },
                    Translation = "and they"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "also",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "τοῦτον", Transliteration = "touton",
                            Gloss = "this one",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "τραυματίσαντες", Transliteration = "traumatisantes",
                            Gloss = "having wounded",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having wounded this one also"
                },
                new Word { Greek = "ἐξέβαλον", Transliteration = "exebalon",
                    Gloss = "they threw out",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "and this one also they wounded and threw out."
        },
        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen",
                    Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κύριος", Transliteration = "kyrios",
                            Gloss = "lord",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τοῦ", Transliteration = "tou",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀμπελῶνος", Transliteration = "ampelōnos",
                            Gloss = "vineyard",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the owner of the vineyard"
                }
            },
            Translation = "Then the owner of the vineyard said,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τί", Transliteration = "ti",
                    Gloss = "What",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "interj" },
                new Word { Greek = "ποιήσω", Transliteration = "poiēsō",
                    Gloss = "shall I do?",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "‘What shall I do?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πέμψω", Transliteration = "pempsō",
                    Gloss = "I will send",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "υἱόν", Transliteration = "huion",
                            Gloss = "son",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou",
                            Gloss = "my",
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀγαπητόν", Transliteration = "agapēton",
                            Gloss = "beloved",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "my beloved son"
                }
            },
            Translation = "I will send my beloved son;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἴσως", Transliteration = "isōs",
                    Gloss = "perhaps",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "τοῦτον", Transliteration = "touton",
                    Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "ἐντραπήσονται", Transliteration = "entrapēsontai",
                    Gloss = "they will respect",
                    GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "perhaps they will respect him.’"
        },
        // Verse 14
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
                        new Word { Greek = "ἰδόντες", Transliteration = "idontes",
                            Gloss = "having seen",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton",
                            Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "But when they saw him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γεωργοὶ", Transliteration = "geōrgoi",
                            Gloss = "farmers",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the vine-growers"
                },
                new Word { Greek = "διελογίζοντο", Transliteration = "dielogizonto",
                    Gloss = "reasoned",
                    GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἀλλήλους", Transliteration = "allēlous",
                            Gloss = "one another",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                            PartOfSpeech = "conj" }
                    },
                    Translation = "with one another"
                },
                new Word { Greek = "λέγοντες", Transliteration = "legontes",
                    Gloss = "saying",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "But when the vine-growers saw him, they reasoned with one another, saying,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὗτός", Transliteration = "houtos",
                    Gloss = "This",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "ἐστιν", Transliteration = "estin",
                    Gloss = "is",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κληρονόμος", Transliteration = "klēronomos",
                            Gloss = "heir",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the heir"
                }
            },
            Translation = "‘This is the heir;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀποκτείνωμεν", Transliteration = "apokteinōmen",
                    Gloss = "let us kill",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "1P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτόν", Transliteration = "auton",
                    Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina",
                            Gloss = "so that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn",
                            Gloss = "ours",
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "γένηται", Transliteration = "genētai",
                            Gloss = "might become",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κληρονομία", Transliteration = "klēronomia",
                                    Gloss = "inheritance",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the inheritance"
                        }
                    },
                    Translation = "so that the inheritance might be ours.’"
                }
            },
            Translation = "let us kill him so that the inheritance might be ours.’"
        },
        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκβαλόντες", Transliteration = "ekbalontes",
                            Gloss = "having thrown out",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton",
                            Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔξω", Transliteration = "exō",
                                    Gloss = "outside",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀμπελῶνος", Transliteration = "ampelōnos",
                                    Gloss = "vineyard",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "outside of the vineyard"
                        }
                    },
                    Translation = "having thrown him out of the vineyard"
                },
                new Word { Greek = "ἀπέκτειναν", Transliteration = "apekteinan",
                    Gloss = "they killed",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "So they threw him out of the vineyard and killed him."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τί", Transliteration = "ti",
                    Gloss = "What",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "interj" },
                new Word { Greek = "οὖν", Transliteration = "oun",
                    Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ποιήσει", Transliteration = "poiēsei",
                    Gloss = "will do",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois",
                    Gloss = "to them",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κύριος", Transliteration = "kyrios",
                            Gloss = "lord",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τοῦ", Transliteration = "tou",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀμπελῶνος", Transliteration = "ampelōnos",
                            Gloss = "vineyard",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the owner of the vineyard"
                }
            },
            Translation = "What, therefore, will the owner of the vineyard do to them?"
        },
        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐλεύσεται", Transliteration = "eleusetai",
                    Gloss = "He will come",
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀπολέσει", Transliteration = "apolesei",
                    Gloss = "will destroy",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γεωργοὺς", Transliteration = "geōrgous",
                            Gloss = "farmers",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τούτους", Transliteration = "toutous",
                            Gloss = "these",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "these vine-growers"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "δώσει", Transliteration = "dōsei",
                    Gloss = "will give",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀμπελῶνα", Transliteration = "ampelōna",
                            Gloss = "vineyard",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the vineyard"
                },
                new Word { Greek = "ἄλλοις", Transliteration = "allois",
                    Gloss = "to others",
                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                    PartOfSpeech = "adj" }
            },
            Translation = "He will come and destroy these vine-growers, and will give the vineyard to others."
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
                        new Word { Greek = "ἀκούσαντες", Transliteration = "akousantes",
                            Gloss = "having heard",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "When they heard this"
                },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἶπαν", Transliteration = "eipan",
                    Gloss = "they said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "mē",
                            Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "γένοιο", Transliteration = "genoito",
                            Gloss = "may it be",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "OPT", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "‘May it never be!’"
                }
            },
            Translation = "When they heard this, they said, ‘May it never be!’"
        }
    };
}

/*
Constructions identified:
- INF_PHRASE (Complementary infinitive): 20:9, 20:11, 20:12
- PURPOSE_CLAUSE (hina + subjunctive/future): 20:10, 20:14
- PTCP (Adverbial/Circumstantial participle): 20:10, 20:11, 20:12, 20:14, 20:15, 20:16
*/
