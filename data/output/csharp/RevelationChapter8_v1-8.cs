private static List<object> GetChapter8()
{
    // Revelation 8:1-8
    return new List<object>
    {
        // Verse 1
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
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅταν", Transliteration = "hotan", Gloss = "when",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἤνοιξεν", Transliteration = "ēnoixen", Gloss = "he opened",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "σφραγῖδα", Transliteration = "sphragida", Gloss = "seal",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἑβδόμην", Transliteration = "hebdomēn", Gloss = "seventh",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "the seventh seal"
                        }
                    },
                    Translation = "when he opened the seventh seal"
                },
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "there was",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "σιγὴ", Transliteration = "sigē", Gloss = "silence",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "οὐρανῷ", Transliteration = "ouranō", Gloss = "heaven",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in heaven"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "for about",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἡμιώριον", Transliteration = "hēmiōrion", Gloss = "half an hour",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "for about half an hour"
                }
            },
            Translation = "And when he opened the seventh seal, there was silence in heaven for about half an hour."
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἶδον", Transliteration = "eidon", Gloss = "I saw",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἀγγέλους", Transliteration = "angelous", Gloss = "angels",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the seven angels"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἳ", Transliteration = "hoi", Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                            PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐνώπιον", Transliteration = "enōpion", Gloss = "before",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "before God"
                        },
                        new Word { Greek = "ἑστήκασιν", Transliteration = "hestēkasin", Gloss = "stand",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "who stand before God"
                }
            },
            Translation = "And I saw the seven angels who stand before God,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐδόθησαν", Transliteration = "edothēsan", Gloss = "were given",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them",
                    GrammarCodes = new List<string> { "PREP" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "σάλπιγγες", Transliteration = "salpinges", Gloss = "trumpets",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "seven trumpets"
                }
            },
            Translation = "and seven trumpets were given to them."
        },

        // Verse 3
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄλλος", Transliteration = "allos", Gloss = "another",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἄγγελος", Transliteration = "angelos", Gloss = "angel",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "another angel"
                },
                new Word { Greek = "ἦλθεν", Transliteration = "ēlthen", Gloss = "came",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐστάθη", Transliteration = "estathē", Gloss = "stood",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "at",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θυσιαστηρίου", Transliteration = "thysiastēriou", Gloss = "altar",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "at the altar"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "λιβανωτὸν", Transliteration = "libanōton", Gloss = "censer",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "χρυσοῦν", Transliteration = "chrysoun", Gloss = "golden",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "a golden censer"
                        }
                    },
                    Translation = "having a golden censer"
                }
            },
            Translation = "And another angel came and stood at the altar, having a golden censer,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐδόθη", Transliteration = "edothē", Gloss = "was given",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him",
                    GrammarCodes = new List<string> { "PREP" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θυμιάματα", Transliteration = "thymiāmata", Gloss = "incense",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "πολλά", Transliteration = "polla", Gloss = "much",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "much incense"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δώσει", Transliteration = "dōsei", Gloss = "he might give",
                            GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "with the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "προσευχαῖς", Transliteration = "proseuchais", Gloss = "prayers",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "P" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἁγίων", Transliteration = "hagiōn", Gloss = "saints",
                                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                            PartOfSpeech = "adj" },
                                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all",
                                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                            PartOfSpeech = "adj" }
                                    },
                                    Translation = "of all the saints"
                                }
                            },
                            Translation = "with the prayers of all the saints"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "on",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θυσιαστήριον", Transliteration = "thysiastērion", Gloss = "altar",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "χρυσοῦν", Transliteration = "chrysoun", Gloss = "golden",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "on the golden altar"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the [one]",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐνώπιον", Transliteration = "enōpion", Gloss = "before",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θρόνου", Transliteration = "thronou", Gloss = "throne",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "which is before the throne"
                        }
                    },
                    Translation = "that he might give it with the prayers of all the saints on the golden altar which is before the throne."
                }
            },
            Translation = "and much incense was given to him, that he might give it with the prayers of all the saints on the golden altar which is before the throne."
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀνέβη", Transliteration = "anebē", Gloss = "rose",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "καπνὸς", Transliteration = "kapnos", Gloss = "smoke",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θυμιαμάτων", Transliteration = "thymiāmatōn", Gloss = "incense",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the incense"
                        }
                    },
                    Translation = "the smoke of the incense"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "with the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "προσευχαῖς", Transliteration = "proseuchais", Gloss = "prayers",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἁγίων", Transliteration = "hagiōn", Gloss = "saints",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "of the saints"
                        }
                    },
                    Translation = "with the prayers of the saints"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "χειρὸς", Transliteration = "cheiros", Gloss = "hand",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀγγέλου", Transliteration = "angelou", Gloss = "angel",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the angel"
                        }
                    },
                    Translation = "from the hand of the angel"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐνώπιον", Transliteration = "enōpion", Gloss = "before",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "before God"
                }
            },
            Translation = "And the smoke of the incense rose with the prayers of the saints from the hand of the angel before God."
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἴληφεν", Transliteration = "eilēphen", Gloss = "took",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἄγγελος", Transliteration = "angelos", Gloss = "angel",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the angel"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "λιβανωτὸν", Transliteration = "libanōton", Gloss = "censer",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the censer"
                }
            },
            Translation = "And the angel took the censer"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐγέμισεν", Transliteration = "egemisen", Gloss = "filled",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "it",
                    GrammarCodes = new List<string> { "PREP" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πυρὸς", Transliteration = "pyros", Gloss = "fire",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the fire"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θυσιαστηρίου", Transliteration = "thysiastēriou", Gloss = "altar",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the altar"
                        }
                    },
                    Translation = "with fire from the altar"
                }
            },
            Translation = "and filled it with fire from the altar"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἔβαλεν", Transliteration = "ebalen", Gloss = "threw",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γῆν", Transliteration = "gēn", Gloss = "earth",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the earth"
                }
            },
            Translation = "and threw it to the earth;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐγένοντο", Transliteration = "egenonto", Gloss = "there were",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "βρονταὶ", Transliteration = "brontai", Gloss = "thunders",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                    PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "φωναὶ", Transliteration = "phōnai", Gloss = "voices",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                    PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀστραπαὶ", Transliteration = "astrapai", Gloss = "lightnings",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                    PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "σεισμός", Transliteration = "seismos", Gloss = "an earthquake",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" }
            },
            Translation = "and there were thunders and voices and lightnings and an earthquake."
        },

        // Verse 6
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἄγγελοι", Transliteration = "angeloi", Gloss = "angels",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the ones",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἔχοντες", Transliteration = "echontes", Gloss = "having",
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
                                        new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven",
                                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                                            PartOfSpeech = "adj" },
                                        new Word { Greek = "σάλπιγγας", Transliteration = "salpingas", Gloss = "trumpets",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the seven trumpets"
                                }
                            },
                            Translation = "the ones having the seven trumpets"
                        }
                    },
                    Translation = "the seven angels who had the seven trumpets"
                },
                new Word { Greek = "ἡτοίμασαν", Transliteration = "hētoimasan", Gloss = "prepared",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "themselves",
                    GrammarCodes = new List<string> { "PREP" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "to",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "σαλπίσωσιν", Transliteration = "salpisōsin", Gloss = "sound [them]",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "to sound them"
                }
            },
            Translation = "And the seven angels who had the seven trumpets prepared themselves to sound them."
        },

        // Verse 7
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πρῶτος", Transliteration = "prōtos", Gloss = "first [angel]",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the first"
                },
                new Word { Greek = "ἐσάλπισεν", Transliteration = "esalpisen", Gloss = "sounded",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "The first sounded,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "there was",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "χάλαζα", Transliteration = "chalaza", Gloss = "hail",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πῦρ", Transliteration = "pyr", Gloss = "fire",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μεμιγμένα", Transliteration = "memigmena", Gloss = "mixed",
                                    GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "N", "P" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "with",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "αἵματι", Transliteration = "haimati", Gloss = "blood",
                                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "with blood"
                                }
                            },
                            Translation = "mixed with blood"
                        }
                    },
                    Translation = "fire mixed with blood"
                }
            },
            Translation = "and there was hail and fire mixed with blood,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐβλήθη", Transliteration = "eblēthē", Gloss = "it was thrown",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γῆν", Transliteration = "gēn", Gloss = "earth",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the earth"
                }
            },
            Translation = "and it was thrown to the earth;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "τρίτον", Transliteration = "triton", Gloss = "third",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "γῆς", Transliteration = "gēs", Gloss = "earth",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the earth"
                        }
                    },
                    Translation = "a third of the earth"
                },
                new Word { Greek = "κατεκάη", Transliteration = "katekāē", Gloss = "was burned up",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "and a third of the earth was burned up,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "τρίτον", Transliteration = "triton", Gloss = "third",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "δένδρων", Transliteration = "dendrōn", Gloss = "trees",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the trees"
                        }
                    },
                    Translation = "a third of the trees"
                },
                new Word { Greek = "κατεκάη", Transliteration = "katekāē", Gloss = "was burned up",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "and a third of the trees were burned up,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶς", Transliteration = "pas", Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "χόρτος", Transliteration = "chortos", Gloss = "grass",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "χλωρὸς", Transliteration = "chlōros", Gloss = "green",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "all green grass"
                },
                new Word { Greek = "κατεκάη", Transliteration = "katekāē", Gloss = "was burned up",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "and all green grass was burned up."
        },

        // Verse 8
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δεύτερος", Transliteration = "deuteros", Gloss = "second",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἄγγελος", Transliteration = "angelos", Gloss = "angel",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the second angel"
                },
                new Word { Greek = "ἐσάλπισεν", Transliteration = "esalpisen", Gloss = "sounded",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "And the second angel sounded,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as it were",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ὄρος", Transliteration = "oros", Gloss = "a mountain",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μέγα", Transliteration = "mega", Gloss = "great",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πυρὶ", Transliteration = "pyri", Gloss = "with fire",
                                    GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "καιόμενον", Transliteration = "kaiomenon", Gloss = "burning",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "N", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "burning with fire"
                        }
                    },
                    Translation = "as it were a great mountain burning with fire"
                },
                new Word { Greek = "ἐβλήθη", Transliteration = "eblēthē", Gloss = "was thrown",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θάλασσαν", Transliteration = "thalassan", Gloss = "sea",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "into the sea"
                }
            },
            Translation = "and as it were a great mountain burning with fire was thrown into the sea;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "became",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "τρίτον", Transliteration = "triton", Gloss = "third",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θαλάσσης", Transliteration = "thalassēs", Gloss = "sea",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the sea"
                        }
                    },
                    Translation = "a third of the sea"
                },
                new Word { Greek = "αἷμα", Transliteration = "haima", Gloss = "blood",
                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                    PartOfSpeech = "n" }
            },
            Translation = "and a third of the sea became blood."
        }
    };
}

/*
Constructions identified:
- TEMP_CLAUSE: Rev 8:1 (ὅταν ἤνοιξεν...)
- REL_CLAUSE: Rev 8:2 (οἳ ἐνώπιον...)
- NOUN_PHRASE (OBJ): Rev 8:1 (τὴν σφραγῖδα τὴν ἑβδόμην), 8:2 (τοὺς ἑπτὰ ἀγγέλους), 8:3 (λιβανωτὸν χρυσοῦν)
- NOUN_PHRASE (SUBJ): Rev 8:2 (ἑπτὰ σάλπιγγες), 8:3 (ἄλλος ἄγγελος, θυμιάματα πολλά), 8:4 (ὁ καπνὸς), 8:5 (ὁ ἄγγελος), 8:6 (οἱ ἑπτὰ ἄγγελοι), 8:7 (ὁ πρῶτος, τὸ τρίτον τῆς γῆς, κτλ.), 8:8 (ὁ δεύτερος ἄγγελος, τὸ τρίτον τῆς θαλάσσης)
- PURPOSE_CLAUSE: Rev 8:3 (ἵνα δώσει...), 8:6 (ἵνα σαλπίσωσιν)
- PTCP: Rev 8:3 (ἔχων), 8:6 (οἱ ἔχοντες), 8:7 (μεμιγμένα), 8:8 (καιόμενον)
- PREP_PHRASE: Rev 8:1 (ἐν τῷ οὐρανῷ), 8:2 (ἐνώπιον τοῦ θεοῦ), 8:3 (ἐπὶ τοῦ θυσιαστηρίου), 8:4 (ἐκ χειρὸς), 8:5 (εἰς τὴν γῆν)
- DAT_INSTR: Rev 8:8 (πυρὶ)
*/
