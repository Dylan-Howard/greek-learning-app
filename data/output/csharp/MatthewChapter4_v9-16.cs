private static List<object> GetChapter4()
{
    // Matthew 4:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταῦτά", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "adv" },
                        new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "all these things"
                },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "δώσω", Transliteration = "dōsō", Gloss = "I will give", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πεσὼν", Transliteration = "pesōn", Gloss = "falling down", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "falling down"
                        },
                        new Word { Greek = "προσκυνήσῃς", Transliteration = "proskynēsēs", Gloss = "you worship", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "μοι", Transliteration = "moi", Gloss = "me", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "if falling down you worship me"
                }
            },
            Translation = "And he said to him, 'All these things I will give to you, if falling down you worship me.'"
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "then", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "says", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
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
                new Word { Greek = "ὕπαγε", Transliteration = "hypage", Gloss = "go away", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σατανᾶ", Transliteration = "satana", Gloss = "Satan", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it is written", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" }
                    },
                    Translation = "for it is written"
                },
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
                                new Word { Greek = "κύριον", Transliteration = "kyrion", Gloss = "Lord", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεόν", Transliteration = "theon", Gloss = "God", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "the Lord your God"
                        },
                        new Word { Greek = "προσκυνήσεις", Transliteration = "proskynēseis", Gloss = "you shall worship", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "You shall worship the Lord your God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μόνῳ", Transliteration = "monō", Gloss = "only", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "λατρεύσεις", Transliteration = "latreuseis", Gloss = "you shall serve", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "and him only you shall serve"
                }
            },
            Translation = "Then Jesus says to him, 'Go away, Satan! For it is written: \"You shall worship the Lord your God and him only you shall serve.\""
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τότε", Transliteration = "Tote", Gloss = "then", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀφίησιν", Transliteration = "aphiēsin", Gloss = "leaves", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "διάβολος", Transliteration = "diabolos", Gloss = "devil", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the devil"
                }
            },
            Translation = "Then the devil leaves him"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄγγελοι", Transliteration = "angeloi", Gloss = "angels", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "angels"
                },
                new Word { Greek = "προσῆλθον", Transliteration = "prosēlthon", Gloss = "came", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "διηκόνουν", Transliteration = "diēkonoun", Gloss = "were ministering", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" }
            },
            Translation = "and behold, angels came and were ministering to him"
        },

        // Verse 12
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
                        new Word { Greek = "Ἀκούσας", Transliteration = "Akousas", Gloss = "having heard", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "Having heard"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "OBJ_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Ἰωάννης", Transliteration = "Iōannēs", Gloss = "John", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "John"
                        },
                        new Word { Greek = "παρεδόθη", Transliteration = "paredothē", Gloss = "was handed over", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "that John was handed over"
                },
                new Word { Greek = "ἀνεχώρησεν", Transliteration = "anechōrēsen", Gloss = "he withdrew", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
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
                                new Word { Greek = "Γαλιλαίαν", Transliteration = "Galilaian", Gloss = "Galilee", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Galilee"
                        }
                    },
                    Translation = "into Galilee"
                }
            },
            Translation = "Now when he heard that John had been handed over, he withdrew into Galilee"
        },

        // Verse 13
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
                        new Word { Greek = "καταλιπὼν", Transliteration = "katalipōn", Gloss = "leaving", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Ναζαρὰ", Transliteration = "Nazara", Gloss = "Nazareth", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Nazareth"
                        }
                    },
                    Translation = "leaving Nazareth"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλθὼν", Transliteration = "elthōn", Gloss = "coming", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "coming"
                },
                new Word { Greek = "κατῴκησεν", Transliteration = "katōkēsen", Gloss = "he lived", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Καφαρναοὺμ", Transliteration = "Kapharnaoum", Gloss = "Capernaum", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "παραθαλασσίαν", Transliteration = "parathalassian", Gloss = "beside the sea", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "Capernaum by the sea"
                        }
                    },
                    Translation = "in Capernaum by the sea"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁρίοις", Transliteration = "horiois", Gloss = "territory", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "Ζαβουλὼν", Transliteration = "Zaboulōn", Gloss = "of Zebulun", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "Νεφθαλίμ", Transliteration = "Nephthalim", Gloss = "Naphtali", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the territory of Zebulun and Naphtali"
                        }
                    },
                    Translation = "in the territory of Zebulun and Naphtali"
                }
            },
            Translation = "And leaving Nazareth, he came and lived in Capernaum by the sea, in the territory of Zebulun and Naphtali"
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πληρωθῇ", Transliteration = "plērōthē", Gloss = "it might be fulfilled", GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the [word]", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ῥηθὲν", Transliteration = "rhēthen", Gloss = "spoken", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "spoken"
                        }
                    },
                    Translation = "what was spoken"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Ἠσαΐου", Transliteration = "Esaiou", Gloss = "Isaiah", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "προφήτου", Transliteration = "prophētou", Gloss = "prophet", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Isaiah the prophet"
                        }
                    },
                    Translation = "through Isaiah the prophet"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντος", Transliteration = "legontos", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                }
            },
            Translation = "in order that what was spoken through Isaiah the prophet might be fulfilled, saying:"
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γῆ", Transliteration = "gē", Gloss = "land", GrammarCodes = new List<string> { "N", "VOC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Ζαβουλὼν", Transliteration = "Zaboulōn", Gloss = "of Zebulun", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Land of Zebulun"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γῆ", Transliteration = "gē", Gloss = "land", GrammarCodes = new List<string> { "N", "VOC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Νεφθαλίμ", Transliteration = "Nephthalim", Gloss = "of Naphtali", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "land of Naphtali"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁδὸν", Transliteration = "hodon", Gloss = "way", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "θαλάσσης", Transliteration = "thalassēs", Gloss = "of the sea", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the way of the sea"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πέραν", Transliteration = "peran", Gloss = "beyond", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Ἰορδάνου", Transliteration = "Iordanou", Gloss = "Jordan", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Jordan"
                        }
                    },
                    Translation = "beyond the Jordan"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Γαλιλαία", Transliteration = "Galilaia", Gloss = "Galilee", GrammarCodes = new List<string> { "N", "VOC", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐθνῶν", Transliteration = "ethnōn", Gloss = "Gentiles", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the Gentiles"
                        }
                    },
                    Translation = "Galilee of the Gentiles"
                }
            },
            Translation = "Land of Zebulun and land of Naphtali, the way of the sea, beyond the Jordan, Galilee of the Gentiles—"
        },

        // Verse 16
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "λαὸς", Transliteration = "laos", Gloss = "people", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "καθήμενος", Transliteration = "kathēmenos", Gloss = "sitting", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "σκότει", Transliteration = "skotei", Gloss = "darkness", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "in darkness"
                                }
                            },
                            Translation = "sitting in darkness"
                        }
                    },
                    Translation = "the people sitting in darkness"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φῶς", Transliteration = "phōs", Gloss = "a light", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μέγα", Transliteration = "mega", Gloss = "great", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a great light"
                },
                new Word { Greek = "εἶδεν", Transliteration = "eiden", Gloss = "saw", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "the people sitting in darkness saw a great light"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the [ones]", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "καθημένοις", Transliteration = "kathēmenois", Gloss = "sitting", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "χώρᾳ", Transliteration = "chōra", Gloss = "the region", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "σκιᾷ", Transliteration = "skia", Gloss = "shadow", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "θανάτου", Transliteration = "thanatou", Gloss = "of death", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in the region and shadow of death"
                        }
                    },
                    Translation = "to those sitting in the region and shadow of death"
                },
                new Word { Greek = "φῶς", Transliteration = "phōs", Gloss = "light", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἀνέτειλεν", Transliteration = "aneteilen", Gloss = "has dawned", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "upon them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" }
            },
            Translation = "and to those sitting in the region and shadow of death light has dawned upon them."
        }
    };
}
// Constructions identified:
// 4:10 - APP (ὁ Ἰησοῦς as Subject in INDEP_CLAUSE)
// 4:13 - APP (Καφαρναοὺμ τὴν παραθαλασσίαν)
// 4:15 - VOC (γῆ Ζαβουλὼν ... Γαλιλαία τῶν ἐθνῶν)
// 4:16 - PERIPH-like (ὁ λαὸς ὁ καθήμενος - attributive participle as substantive)
