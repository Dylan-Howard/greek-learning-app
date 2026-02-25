private static List<object> GetChapter12()
{
    // Matthew 12:41-48
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἄνδρες", Transliteration = "Andres", Gloss = "men", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "Νινευῖται", Transliteration = "Nineuitai", Gloss = "Ninevites", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "The men of Nineveh"
                },
                new Word { Greek = "ἀναστήσονται", Transliteration = "anastēsontai", Gloss = "will rise up", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κρίσει", Transliteration = "krisei", Gloss = "judgment", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "at the judgment"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γενεᾶς", Transliteration = "geneas", Gloss = "generation", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ταύτης", Transliteration = "tautēs", Gloss = "this", GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "adv" }
                    },
                    Translation = "with this generation"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κατακρινοῦσιν", Transliteration = "katakrinousin", Gloss = "will condemn", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτήν", Transliteration = "autēn", Gloss = "it", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "prep" }
            },
            Translation = "The men of Nineveh will rise up at the judgment with this generation and will condemn it,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μετενόησαν", Transliteration = "metenoēsan", Gloss = "they repented", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "at", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κήρυγμα", Transliteration = "kērygma", Gloss = "preaching", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Ἰωνᾶ", Transliteration = "Iōna", Gloss = "of Jonah", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "at the preaching of Jonah"
                }
            },
            Translation = "because they repented at the preaching of Jonah,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interj" },
                new Word { Greek = "πλεῖον", Transliteration = "pleion", Gloss = "something greater than", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "Ἰωνᾶ", Transliteration = "Iōna", Gloss = "Jonah", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ὧδε", Transliteration = "hōde", Gloss = "is here", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
            },
            Translation = "and behold, something greater than Jonah is here."
        },

        // Verse 42
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
                        new Word { Greek = "βασίλισσα", Transliteration = "basilissa", Gloss = "The queen", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "νότου", Transliteration = "notou", Gloss = "of the south", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "The queen of the south"
                },
                new Word { Greek = "ἐγερθήσεται", Transliteration = "egerthēsetai", Gloss = "will rise up", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κρίσει", Transliteration = "krisei", Gloss = "judgment", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "at the judgment"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γενεᾶς", Transliteration = "geneas", Gloss = "generation", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ταύτης", Transliteration = "tautēs", Gloss = "this", GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "adv" }
                    },
                    Translation = "with this generation"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κατακρινεῖ", Transliteration = "katakrinei", Gloss = "will condemn", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτήν", Transliteration = "autēn", Gloss = "it", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "prep" }
            },
            Translation = "The queen of the south will rise up at the judgment with this generation and will condemn it,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἦλθεν", Transliteration = "ēlthen", Gloss = "she came", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "περάτων", Transliteration = "peratōn", Gloss = "ends", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "γῆς", Transliteration = "gēs", Gloss = "earth", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the earth"
                        }
                    },
                    Translation = "from the ends of the earth"
                }
            },
            Translation = "because she came from the ends of the earth"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀκοῦσαι", Transliteration = "akousai", Gloss = "to hear", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σοφίαν", Transliteration = "sophian", Gloss = "wisdom", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Σολομῶνος", Transliteration = "Solomōnos", Gloss = "of Solomon", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the wisdom of Solomon"
                }
            },
            Translation = "to hear the wisdom of Solomon,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interj" },
                new Word { Greek = "πλεῖον", Transliteration = "pleion", Gloss = "something greater than", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "Σολομῶνος", Transliteration = "Solomōnos", Gloss = "Solomon", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ὧδε", Transliteration = "hōde", Gloss = "is here", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
            },
            Translation = "and behold, something greater than Solomon is here."
        },

        // Verse 43
        new Phrase
        {
            SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ὅταν", Transliteration = "Hotan", Gloss = "When", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀκάθαρτον", Transliteration = "akatharton", Gloss = "unclean", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "πνεῦμα", Transliteration = "pneuma", Gloss = "spirit", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the unclean spirit"
                },
                new Word { Greek = "ἐξέλθῃ", Transliteration = "exelthē", Gloss = "has gone out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀνθρώπου", Transliteration = "anthrōpou", Gloss = "person", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "from the person"
                }
            },
            Translation = "But when the unclean spirit has gone out of the person,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "διέρχεται", Transliteration = "dierchetai", Gloss = "it passes", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀνύδρων", Transliteration = "anydrōn", Gloss = "waterless", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τόπων", Transliteration = "topōn", Gloss = "places", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "through waterless places"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ζητοῦν", Transliteration = "zētoun", Gloss = "seeking", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἀνάπαυσιν", Transliteration = "anapausin", Gloss = "rest", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "seeking rest"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Word { Greek = "εὑρίσκει", Transliteration = "heuriskei", Gloss = "it finds", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "it passes through waterless places seeking rest, and it does not find it."
        },

        // Verse 44
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "Then", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "it says", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
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
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "To", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "οἶκόν", Transliteration = "oikon", Gloss = "house", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "to my house"
                        },
                        new Word { Greek = "ἐπιστρέψω", Transliteration = "epistrepsō", Gloss = "I will return", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅθεν", Transliteration = "hothen", Gloss = "from where", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἐξῆλθον", Transliteration = "exēlthon", Gloss = "I came out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "from where I came out"
                        }
                    },
                    Translation = "I will return to my house from where I came out."
                }
            },
            Translation = "Then it says, 'I will return to my house from where I came out.'"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλθὸν", Transliteration = "elthon", Gloss = "having come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "having come"
                },
                new Word { Greek = "εὑρίσκει", Transliteration = "heuriskei", Gloss = "it finds", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σχολάζοντα", Transliteration = "scholazonta", Gloss = "empty", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σεσαρωμένον", Transliteration = "sesarōmenon", Gloss = "swept", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κεκοσμημένον", Transliteration = "kekosmēmenon", Gloss = "put in order", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" }
            },
            Translation = "And having come, it finds it empty, swept, and put in order."
        },

        // Verse 45
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "Then", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "πορεύεται", Transliteration = "poreuetai", Gloss = "it goes", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "παραλαμβάνει", Transliteration = "paralambanei", Gloss = "takes with", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μεθ᾽", Transliteration = "meth'", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἑαυτοῦ", Transliteration = "heautou", Gloss = "itself", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "f" }
                    },
                    Translation = "with itself"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἕτερα", Transliteration = "hetera", Gloss = "other", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "πνεύματα", Transliteration = "pneumata", Gloss = "spirits", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "πονηρότερα", Transliteration = "ponērotera", Gloss = "more evil", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἑαυτοῦ", Transliteration = "heautou", Gloss = "than itself", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "f" }
                    },
                    Translation = "seven other spirits more evil than itself"
                }
            },
            Translation = "Then it goes and takes with itself seven other spirits more evil than itself,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰσελθόντα", Transliteration = "eiselthonta", Gloss = "having entered", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "N", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "having entered"
                },
                new Word { Greek = "κατοικεῖ", Transliteration = "katoikei", Gloss = "they dwell", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἐκεῖ", Transliteration = "ekei", Gloss = "there", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
            },
            Translation = "and they enter and dwell there;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γίνεται", Transliteration = "ginetai", Gloss = "becomes", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἔσχατα", Transliteration = "eschata", Gloss = "last [state]", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀνθρώπου", Transliteration = "anthrōpou", Gloss = "person", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἐκείνου", Transliteration = "ekeinou", Gloss = "that", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "adv" }
                            },
                            Translation = "of that person"
                        }
                    },
                    Translation = "the last state of that person"
                },
                new Word { Greek = "χείρονα", Transliteration = "cheirona", Gloss = "worse", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "πρώτων", Transliteration = "prōtōn", Gloss = "first", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "than the first"
                }
            },
            Translation = "and the last state of that person becomes worse than the first."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "So", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἔσται", Transliteration = "estai", Gloss = "it will be", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γενεᾷ", Transliteration = "genea", Gloss = "generation", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ταύτῃ", Transliteration = "tautē", Gloss = "this", GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" }, PartOfSpeech = "adv" },
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πονηρᾷ", Transliteration = "ponēra", Gloss = "evil", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "with this evil generation"
                }
            },
            Translation = "So also will it be with this evil generation."
        },

        // Verse 46
        new Phrase
        {
            SyntaxCodes = new List<string> { "GEN_ABS" },
            Content = new List<object>
            {
                new Word { Greek = "Ἔτι", Transliteration = "Eti", Gloss = "While still", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "λαλοῦντος", Transliteration = "lalountos", Gloss = "was speaking", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὄχλοις", Transliteration = "ochlois", Gloss = "crowds", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "to the crowds"
                }
            },
            Translation = "While he was still speaking to the crowds,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μήτηρ", Transliteration = "mētēr", Gloss = "mother", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀδελφοὶ", Transliteration = "adelphoi", Gloss = "brothers", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "his mother and his brothers"
                },
                new Word { Greek = "εἱστήκεισαν", Transliteration = "heistēkeisan", Gloss = "stood", GrammarCodes = new List<string> { "V", "PLPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ἔξω", Transliteration = "exō", Gloss = "outside", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
            },
            Translation = "behold, his mother and his brothers stood outside,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "ζητοῦντες", Transliteration = "zētountes", Gloss = "seeking", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "λαλῆσαι", Transliteration = "lalēsai", Gloss = "to speak", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
            },
            Translation = "seeking to speak to him."
        },

        // Verse 47
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τις", Transliteration = "tis", Gloss = "someone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "part" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" }
            },
            Translation = "And someone said to him,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "Behold", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μήτηρ", Transliteration = "mētēr", Gloss = "mother", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "your mother and your brothers"
                },
                new Word { Greek = "ἔξω", Transliteration = "exō", Gloss = "outside", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἑστήκασιν", Transliteration = "hestēkasin", Gloss = "are standing", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "Behold, your mother and your brothers are standing outside,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "ζητοῦντές", Transliteration = "zētountes", Gloss = "seeking", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "λαλῆσαι", Transliteration = "lalēsai", Gloss = "to speak", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
            },
            Translation = "seeking to speak to you."
        },

        // Verse 48
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" }
                    },
                    Translation = "the one"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "But", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀποκριθεὶς", Transliteration = "apokritheis", Gloss = "having answered", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "having answered"
                },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the one", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "λέγοντι", Transliteration = "legonti", Gloss = "telling", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "to the one telling him"
                }
            },
            Translation = "But answering he said to the one telling him,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τίς", Transliteration = "tis", Gloss = "Who", GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" }, PartOfSpeech = "interj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "μήτηρ", Transliteration = "mētēr", Gloss = "mother", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "my mother?"
                }
            },
            Translation = "Who is my mother?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τίνες", Transliteration = "tines", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "interj" },
                new Word { Greek = "εἰσὶν", Transliteration = "eisin", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "my brothers?"
                }
            },
            Translation = "and who are my brothers?"
        }
    };
}

/*
Constructions identified:
- GEN_ABS: Verse 46 (Ἔτι αὐτοῦ λαλοῦντος)
*/
