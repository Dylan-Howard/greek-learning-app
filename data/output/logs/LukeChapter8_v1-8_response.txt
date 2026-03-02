private static List<object> GetChapter8()
{
    // Luke 8:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "it happened", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καθεξῆς", Transliteration = "kathexēs", Gloss = "following time", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "in the following time"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        // (continues verse 1)
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "διώδευεν", Transliteration = "diōdeuen", Gloss = "journeyed through", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "πόλιν", Transliteration = "polin", Gloss = "city", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "κώμην", Transliteration = "kōmēn", Gloss = "village", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "through city and village"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κηρύσσων", Transliteration = "kēryssōn", Gloss = "preaching", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "εὐαγγελιζόμενος", Transliteration = "euangelizomenos", Gloss = "preaching the gospel", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "βασιλείαν", Transliteration = "basileian", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "of God"
                                        }
                                    },
                                    Translation = "the kingdom of God"
                                }
                            },
                            Translation = "preaching and bringing good news of the kingdom of God"
                        }
                    },
                    Translation = "and he journeyed through city and village, preaching and bringing good news of the kingdom of God"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "δώδεκα", Transliteration = "dōdeka", Gloss = "twelve", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the twelve"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὺν", Transliteration = "syn", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "with him"
                }
            },
            Translation = "And it happened soon afterward that he journeyed through city and village, preaching and bringing good news of the kingdom of God, and the twelve were with him,"
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γυναῖκές", Transliteration = "gunaikes", Gloss = "women", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "τινες", Transliteration = "tines", Gloss = "certain", GrammarCodes = new List<string> { "PRON", "NOM", "F", "P" }, PartOfSpeech = "pron" }
            },
            Translation = "and certain women"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "αἳ", Transliteration = "hai", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "F", "P" }, PartOfSpeech = "pron" },
                new Word { Greek = "ἦσαν", Transliteration = "ēsan", Gloss = "were", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "τεθεραπευμέναι", Transliteration = "tetherapeumenai", Gloss = "healed", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "F", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "πνευμάτων", Transliteration = "pneumatōn", Gloss = "spirits", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "πονηρῶν", Transliteration = "ponērōn", Gloss = "evil", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀσθενειῶν", Transliteration = "astheneiōn", Gloss = "weaknesses", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "from evil spirits and weaknesses"
                }
            },
            Translation = "who had been healed from evil spirits and weaknesses,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "APPOS" },
            Content = new List<object>
            {
                new Word { Greek = "Μαρία", Transliteration = "Maria", Gloss = "Mary", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "καλουμένη", Transliteration = "kaloumenē", Gloss = "being called", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "Μαγδαληνή", Transliteration = "Magdalēnē", Gloss = "Magdalene", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
            },
            Translation = "Mary, called Magdalene"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀφ᾽", Transliteration = "aph'", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἧς", Transliteration = "hēs", Gloss = "whom", GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δαιμόνια", Transliteration = "daimonia", Gloss = "demons", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "seven demons"
                },
                new Word { Greek = "ἐξεληλύθει", Transliteration = "exelēlythei", Gloss = "had gone out", GrammarCodes = new List<string> { "V", "PLPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "from whom seven demons had gone out,"
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "Ἰωάννα", Transliteration = "Iōanna", Gloss = "Joanna", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γυνὴ", Transliteration = "gunē", Gloss = "wife", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Χουζᾶ", Transliteration = "Chuza", Gloss = "of Chuza", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπιτρόπου", Transliteration = "epitropou", Gloss = "steward", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Ἡρῴδου", Transliteration = "Hērōdou", Gloss = "of Herod", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "steward of Herod"
                        }
                    },
                    Translation = "wife of Chuza steward of Herod"
                }
            },
            Translation = "and Joanna, wife of Chuza steward of Herod,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "Σουσάννα", Transliteration = "Sousanna", Gloss = "Susanna", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἕτεραι", Transliteration = "heterai", Gloss = "others", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "πολλαí", Transliteration = "pollai", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" }
            },
            Translation = "and Susanna and many others,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "αἵτινες", Transliteration = "haitines", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "F", "P" }, PartOfSpeech = "pron" },
                new Word { Greek = "διηκόνουν", Transliteration = "diēkonoun", Gloss = "were serving", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὑπαρχόντων", Transliteration = "hyparchontōn", Gloss = "possessions", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "N", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐταῖς", Transliteration = "autais", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "F", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "from their possessions"
                }
            },
            Translation = "who were serving them from their possessions."
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "GEN_ABS" },
            Content = new List<object>
            {
                new Word { Greek = "Συνιόντος", Transliteration = "Syniontos", Gloss = "gathering", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὄχλου", Transliteration = "ochlou", Gloss = "crowd", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "πολλοῦ", Transliteration = "pollou", Gloss = "great", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a great crowd"
                }
            },
            Translation = "And when a great crowd was gathering"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "GEN_ABS" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "throughout", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "πόλιν", Transliteration = "polin", Gloss = "city", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "from city to city"
                        },
                        new Word { Greek = "ἐπιπορευομένων", Transliteration = "epiporeuomenōn", Gloss = "traveling", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "those throughout the cities traveling"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "to him"
                }
            },
            Translation = "and those from city to city were coming to him,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he spoke", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "παραβολῆς", Transliteration = "parabolēs", Gloss = "parable", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "by a parable"
                }
            },
            Translation = "he spoke by a parable:"
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐξῆλθεν", Transliteration = "exēlthen", Gloss = "went out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σπείρων", Transliteration = "speirōn", Gloss = "one sowing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the sower"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "to", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σπεῖραι", Transliteration = "speirai", Gloss = "sow", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σπόρον", Transliteration = "sporon", Gloss = "seed", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "his seed"
                        }
                    },
                    Translation = "to sow his seed"
                }
            },
            Translation = "The sower went out to sow his seed."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "σπείρειν", Transliteration = "speirein", Gloss = "sowing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" }
            },
            Translation = "And as he sowed"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "some", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "pron" },
                new Word { Greek = "μὲν", Transliteration = "men", Gloss = "on the one hand", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Word { Greek = "ἔπεσεν", Transliteration = "epesen", Gloss = "fell", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρά", Transliteration = "para", Gloss = "beside", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὁδὸν", Transliteration = "hodon", Gloss = "road", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "beside the road"
                }
            },
            Translation = "some fell beside the road"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κατεπατήθη", Transliteration = "katepatēthē", Gloss = "was trampled", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "and was trampled"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "πετεινὰ", Transliteration = "peteina", Gloss = "birds", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "οὐρανοῦ", Transliteration = "ouranou", Gloss = "sky", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the sky"
                        }
                    },
                    Translation = "the birds of the sky"
                },
                new Word { Greek = "κατέφαγεν", Transliteration = "katephagen", Gloss = "ate up", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτό", Transliteration = "auto", Gloss = "it", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" }
            },
            Translation = "and the birds of the sky ate it up."
        },

        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἕτερον", Transliteration = "heteron", Gloss = "other", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "κατέπεσεν", Transliteration = "katepesen", Gloss = "fell down", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "upon", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πέτραν", Transliteration = "petran", Gloss = "rock", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "upon the rock"
                }
            },
            Translation = "And other fell upon the rock,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "φυὲν", Transliteration = "phyen", Gloss = "having grown", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἐξηράνθη", Transliteration = "exēranthē", Gloss = "it withered", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                        new Word { Greek = "ἔχειν", Transliteration = "echein", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἰκμάδα", Transliteration = "ikmada", Gloss = "moisture", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "because it had no moisture"
                }
            },
            Translation = "and having grown it withered because it had no moisture."
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἕτερον", Transliteration = "heteron", Gloss = "other", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἔπεσεν", Transliteration = "epesen", Gloss = "fell", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μέσῳ", Transliteration = "mesō", Gloss = "midst", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀκανθῶν", Transliteration = "akanthōn", Gloss = "thorns", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the thorns"
                        }
                    },
                    Translation = "in the midst of the thorns"
                }
            },
            Translation = "And other fell in the midst of the thorns,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "συμφυεῖσαι", Transliteration = "symphueisai", Gloss = "growing with", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "F", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἱ", Transliteration = "hai", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἄκανθαι", Transliteration = "akanthai", Gloss = "thorns", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the thorns"
                },
                new Word { Greek = "ἀπέπνιξαν", Transliteration = "apepnixan", Gloss = "choked", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτό", Transliteration = "auto", Gloss = "it", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" }
            },
            Translation = "and the thorns, growing up with it, choked it."
        },

        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἕτερον", Transliteration = "heteron", Gloss = "other", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἔπεσεν", Transliteration = "epesen", Gloss = "fell", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "γῆν", Transliteration = "gēn", Gloss = "ground", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγαθὴν", Transliteration = "agathēn", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the good ground"
                        }
                    },
                    Translation = "into the good ground"
                }
            },
            Translation = "And other fell into the good ground,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "φυὲν", Transliteration = "phyen", Gloss = "having grown", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen", Gloss = "produced", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καρπὸν", Transliteration = "karpon", Gloss = "fruit", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἑκατονταπλασίονα", Transliteration = "hekatontaplasiona", Gloss = "hundredfold", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "fruit a hundredfold."
                }
            },
            Translation = "and having grown it produced fruit a hundredfold."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pron" },
                new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἐφώνει", Transliteration = "ephōnei", Gloss = "he called out", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Saying these things he called out,"
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὦτα", Transliteration = "ōta", Gloss = "ears", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "ears"
                        },
                        new Word { Greek = "ἀκούειν", Transliteration = "akouein", Gloss = "to hear", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "He who has ears to hear"
                },
                new Word { Greek = "ἀκουέτω", Transliteration = "akouetō", Gloss = "let him hear", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "He who has ears to hear, let him hear!"
        }
    };
}

/*
Constructions identified:
- PERIPH: Verse 2 (ἦσαν τεθεραπευμέναι - pluperfect passive periphrastic)
- APPOS: Verse 2 (Μαρία ἡ καλουμένη Μαγδαληνή)
- APPOS: Verse 3 (γυνὴ Χουζᾶ ἐπιτρόπου Ἡρῴδου)
- GEN_ABS: Verse 4 (Συνιόντος δὲ ὄχλου πολλοῦ)
- GEN_ABS: Verse 4 (τῶν... ἐπιπορευομένων - continuation of genitive absolute)
- PURPOSE_CLAUSE: Verse 5 (τοῦ σπεῖραι - articular infinitive of purpose)
- TEMP_CLAUSE: Verse 5 (ἐν τῷ σπείρειν - temporal articular infinitive)
- CAUSAL_CLAUSE: Verse 6 (διὰ τὸ μὴ ἔχειν - causal articular infinitive)
*/
