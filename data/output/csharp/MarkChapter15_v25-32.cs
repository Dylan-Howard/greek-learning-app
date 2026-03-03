private static List<object> GetChapter15()
{
    // Mark 15:25-32
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "it was",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὥρα", Transliteration = "hōra", Gloss = "hour",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τρίτη", Transliteration = "tritē", Gloss = "third",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the third hour"
                }
            },
            Translation = "And it was the third hour"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐσταύρωσαν", Transliteration = "estaurōsan", Gloss = "they crucified",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "and they crucified him"
        },

        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE", "PERIPH" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἐπιγραφὴ", Transliteration = "epigraphē", Gloss = "inscription",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "αἰτίας", Transliteration = "aitias", Gloss = "charge",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "of his charge"
                        }
                    },
                    Translation = "the inscription of his charge"
                },
                new Word { Greek = "ἐπιγεγραμμένη", Transliteration = "epigegrammenē", Gloss = "written",
                    GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "F", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "And the inscription of his charge was written"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
            Content = new List<object>
            {
                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                    PartOfSpeech = "art" },
                new Word { Greek = "βασιλεὺς", Transliteration = "basileus", Gloss = "King",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Ἰουδαίων", Transliteration = "Ioudaiōn", Gloss = "Jews",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "of the Jews"
                }
            },
            Translation = "THE KING OF THE JEWS"
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
                        new Word { Greek = "σὺν", Transliteration = "syn", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "with him"
                },
                new Word { Greek = "σταυροῦσιν", Transliteration = "staurousin", Gloss = "they crucify",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δύο", Transliteration = "dyo", Gloss = "two",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "λῃστάς", Transliteration = "lēstas", Gloss = "robbers",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "two robbers"
                }
            },
            Translation = "And with him they crucify two robbers"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
            Content = new List<object>
            {
                new Word { Greek = "ἕνα", Transliteration = "hena", Gloss = "one",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "on",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "δεξιῶν", Transliteration = "dexiōn", Gloss = "his right",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "F", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "on his right"
                }
            },
            Translation = "one on his right"
        },
        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
            GrammarCodes = new List<string> { "CONJ" },
            PartOfSpeech = "conj" },
        new Phrase
        {
            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
            Content = new List<object>
            {
                new Word { Greek = "ἕνα", Transliteration = "hena", Gloss = "one",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "on",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "εὐωνύμων", Transliteration = "euōnymōn", Gloss = "his left",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "F", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "on his left"
                },
                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "one on his left"
        },

        // Verse 29
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ", "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the ones",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "παραπορευόμενοι", Transliteration = "paraporeuomenoi", Gloss = "passing by",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "those passing by"
                },
                new Word { Greek = "ἐβλασφήμουν", Transliteration = "eblasphēmoun", Gloss = "were blaspheming",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "And those passing by were blaspheming him"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "κινοῦντες", Transliteration = "kinountes", Gloss = "wagging",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κεφαλὰς", Transliteration = "kephalas", Gloss = "heads",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "their heads"
                }
            },
            Translation = "wagging their heads"
        },
        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
            GrammarCodes = new List<string> { "CONJ" },
            PartOfSpeech = "conj" },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "saying"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐὰ", Transliteration = "oua", Gloss = "Aha!",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC", "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "you who",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "καταλύων", Transliteration = "katalyōn", Gloss = "destroy",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ναὸν", Transliteration = "naon", Gloss = "temple",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the temple"
                        }
                    },
                    Translation = "you who destroy the temple"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἰκοδομῶν", Transliteration = "oikodomōn", Gloss = "build it",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τρισὶν", Transliteration = "trisin", Gloss = "three",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἡμέραις", Transliteration = "hēmerais", Gloss = "days",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in three days"
                        }
                    },
                    Translation = "build it in three days"
                }
            },
            Translation = "Aha! You who destroy the temple and build it in three days"
        },

        // Verse 30
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "σῶσον", Transliteration = "sōson", Gloss = "save",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "σεαυτὸν", Transliteration = "seauton", Gloss = "yourself",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "f" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καταβὰς", Transliteration = "katabas", Gloss = "coming down",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "σταυροῦ", Transliteration = "staurou", Gloss = "cross",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "from the cross"
                        }
                    },
                    Translation = "coming down from the cross"
                }
            },
            Translation = "save yourself, and come down from the cross!"
        },

        // Verse 31
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁμοίως", Transliteration = "homoiōs", Gloss = "likewise",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
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
                        new Word { Greek = "ἀρχιερεῖς", Transliteration = "archiereis", Gloss = "chief priests",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the chief priests"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐμπαίζοντες", Transliteration = "empaizontes", Gloss = "mocking",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἀλλήλους", Transliteration = "allēlous", Gloss = "one another",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                                    PartOfSpeech = "conj" }
                            },
                            Translation = "to one another"
                        }
                    },
                    Translation = "mocking him among themselves"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "γραμματέων", Transliteration = "grammateōn", Gloss = "scribes",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the scribes"
                        }
                    },
                    Translation = "with the scribes"
                },
                new Word { Greek = "ἔλεγον", Transliteration = "elegon", Gloss = "were saying",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "Likewise also the chief priests, mocking him among themselves with the scribes, were saying"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἄλλους", Transliteration = "allous", Gloss = "others",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἔσωσεν", Transliteration = "esōsen", Gloss = "he saved",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "Others he saved"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἑαυτὸν", Transliteration = "heauton", Gloss = "himself",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "f" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "δύναται", Transliteration = "dynatai", Gloss = "he is able",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σῶσαι", Transliteration = "sōsai", Gloss = "to save",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "to save"
                }
            },
            Translation = "himself he cannot save"
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "χριστὸς", Transliteration = "christos", Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the Christ"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "βασιλεὺς", Transliteration = "basileus", Gloss = "King of",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "Ἰσραὴλ", Transliteration = "Israēl", Gloss = "Israel",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the King of Israel"
                },
                new Word { Greek = "καταβάτω", Transliteration = "katabatō", Gloss = "let him come down",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "σταυροῦ", Transliteration = "staurou", Gloss = "cross",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "from the cross"
                }
            },
            Translation = "The Christ, the King of Israel, let him come down now from the cross"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "that",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἴδωμεν", Transliteration = "idōmen", Gloss = "we may see",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "πιστεύσωμεν", Transliteration = "pisteusōmen", Gloss = "believe",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "that we may see and believe"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ", "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "those",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "συνεσταυρωμένοι", Transliteration = "synestaurōmenoi", Gloss = "crucified with",
                            GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "those who were crucified"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὺν", Transliteration = "syn", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "with him"
                },
                new Word { Greek = "ὠνείδιζον", Transliteration = "ōneidizon", Gloss = "were reviling",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "And those who were crucified with him were reviling him"
        }
    };
}

/*
Constructions identified:
- PERIPH: Verse 26 (ἦν ... ἐπιγεγραμμένη)
- APPOS: Verse 26 (ὁ βασιλεὺς τῶν Ἰουδαίων), Verse 27 (ἕνα ἐκ δεξιῶν, ἕνα ἐξ εὐωνύμων), Verse 32 (ὁ βασιλεὺς Ἰσραὴλ)
- VOC: Verse 29 (ὁ καταλύων τὸν ναὸν... - nominative as vocative)
*/
