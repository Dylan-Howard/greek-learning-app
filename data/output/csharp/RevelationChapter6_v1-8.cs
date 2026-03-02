private static List<object> GetChapter6()
{
    // Revelation 6:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶδον", Transliteration = "eidon", Gloss = "I saw", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτε", Transliteration = "hote", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἤνοιξεν", Transliteration = "ēnoixen", Gloss = "opened", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀρνίον", Transliteration = "arnion", Gloss = "lamb", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Lamb"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μίαν", Transliteration = "mian", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "P" }, PartOfSpeech = "art" },
                                                new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven", GrammarCodes = new List<string> { "ADJ", "GEN", "F", "P" }, PartOfSpeech = "adj" },
                                                new Word { Greek = "σφραγίδων", Transliteration = "sphragidōn", Gloss = "seals", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "the seven seals"
                                        }
                                    },
                                    Translation = "of the seven seals"
                                }
                            },
                            Translation = "one of the seven seals"
                        }
                    },
                    Translation = "when the Lamb opened one of the seven seals"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἤκουσα", Transliteration = "ēkousa", Gloss = "I heard", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἑνὸς", Transliteration = "henos", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "τεσσάρων", Transliteration = "tessarōn", Gloss = "four", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "ζῴων", Transliteration = "zōōn", Gloss = "living creatures", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the four living creatures"
                                }
                            },
                            Translation = "of the four living creatures"
                        }
                    },
                    Translation = "one of the four living creatures"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντος", Transliteration = "legontos", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "φωνὴ", Transliteration = "phōnē", Gloss = "a voice", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "βροντῆς", Transliteration = "brontēs", Gloss = "of thunder", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "a voice of thunder"
                                }
                            },
                            Translation = "as with a voice of thunder"
                        },
                        new Word { Greek = "ἔρχου", Transliteration = "erchou", Gloss = "Come!", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying as with a voice of thunder, 'Come!'"
                }
            },
            Translation = "Now I saw when the Lamb opened one of the seven seals, and I heard one of the four living creatures saying as with a voice of thunder, 'Come!'"
        },
        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶδον", Transliteration = "eidon", Gloss = "I saw", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵππος", Transliteration = "hippos", Gloss = "a horse", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "λευκός", Transliteration = "leukos", Gloss = "white", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a white horse"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καθήμενος", Transliteration = "kathēmenos", Gloss = "sitting", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "it", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "on it"
                        }
                    },
                    Translation = "the one sitting on it"
                },
                new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "τόξον", Transliteration = "toxon", Gloss = "a bow", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐδόθη", Transliteration = "edothē", Gloss = "was given", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "στέφανος", Transliteration = "stephanos", Gloss = "a crown", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐξῆλθεν", Transliteration = "exēlthen", Gloss = "he went out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "νικῶν", Transliteration = "nikōn", Gloss = "conquering", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "νικήσῃ", Transliteration = "nikēsē", Gloss = "he might conquer", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "to conquer"
                }
            },
            Translation = "And I looked, and behold, a white horse! And its rider had a bow, and a crown was given to him, and he came out conquering and to conquer."
        },
        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτε", Transliteration = "hote", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἤνοιξεν", Transliteration = "ēnoixen", Gloss = "he opened", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σφραγῖδα", Transliteration = "sphragida", Gloss = "seal", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "δευτέραν", Transliteration = "deuteran", Gloss = "second", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the second seal"
                        }
                    },
                    Translation = "when he opened the second seal"
                },
                new Word { Greek = "ἤκουσα", Transliteration = "ēkousa", Gloss = "I heard", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δευτέρου", Transliteration = "deuterou", Gloss = "second", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ζῴου", Transliteration = "zōou", Gloss = "living creature", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the second living creature"
                },
                new Word { Greek = "λέγοντος", Transliteration = "legontos", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "N", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἔρχου", Transliteration = "erchou", Gloss = "Come!", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "When he opened the second seal, I heard the second living creature say, 'Come!'"
        },
        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐξῆλθεν", Transliteration = "exēlthen", Gloss = "came out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄλλος", Transliteration = "allos", Gloss = "another", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἵππος", Transliteration = "hippos", Gloss = "horse", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "πυρρός", Transliteration = "pyrros", Gloss = "fiery red", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "another horse, fiery red"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καθημένῳ", Transliteration = "kathēmenō", Gloss = "sitting", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "DAT", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "it", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "on it"
                        }
                    },
                    Translation = "to the one sitting on it"
                },
                new Word { Greek = "ἐδόθη", Transliteration = "edothē", Gloss = "it was granted", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λαβεῖν", Transliteration = "labein", Gloss = "to take", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "εἰρήνην", Transliteration = "eirēnēn", Gloss = "peace", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "peace"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "γῆς", Transliteration = "gēs", Gloss = "earth", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the earth"
                                }
                            },
                            Translation = "from the earth"
                        }
                    },
                    Translation = "to take peace from the earth"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀλλήλους", Transliteration = "allēlous", Gloss = "one another", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σφάξουσιν", Transliteration = "sphaxousin", Gloss = "they would slay", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "so that people should slay one another"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐδόθη", Transliteration = "edothē", Gloss = "was given", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μάχαιρα", Transliteration = "machaira", Gloss = "a sword", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μεγάλη", Transliteration = "megalē", Gloss = "great", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a great sword"
                }
            },
            Translation = "And another horse, fiery red, went out. And it was granted to the one sitting on it to take peace from the earth, so that people should slay one another, and a great sword was given to him."
        },
        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτε", Transliteration = "hote", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἤνοιξεν", Transliteration = "ēnoixen", Gloss = "he opened", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σφραγῖδα", Transliteration = "sphragida", Gloss = "seal", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "τρίτην", Transliteration = "tritēn", Gloss = "third", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the third seal"
                        }
                    },
                    Translation = "when he opened the third seal"
                },
                new Word { Greek = "ἤκουσα", Transliteration = "ēkousa", Gloss = "I heard", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "τρίτου", Transliteration = "tritou", Gloss = "third", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ζῴου", Transliteration = "zōou", Gloss = "living creature", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the third living creature"
                },
                new Word { Greek = "λέγοντος", Transliteration = "legontos", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "N", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἔρχου", Transliteration = "erchou", Gloss = "Come!", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶδον", Transliteration = "eidon", Gloss = "I saw", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵππος", Transliteration = "hippos", Gloss = "a horse", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μέλας", Transliteration = "melas", Gloss = "black", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a black horse"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καθήμενος", Transliteration = "kathēmenos", Gloss = "sitting", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "it", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "on it"
                        }
                    },
                    Translation = "the one sitting on it"
                },
                new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ζυγὸν", Transliteration = "zygon", Gloss = "a pair of scales", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
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
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "χειρὶ", Transliteration = "cheiri", Gloss = "hand", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "his hand"
                        }
                    },
                    Translation = "in his hand"
                }
            },
            Translation = "When he opened the third seal, I heard the third living creature say, 'Come!' And I looked, and behold, a black horse! And its rider had a pair of scales in his hand."
        },
        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἤκουσα", Transliteration = "ēkousa", Gloss = "I heard", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as it were", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "conj" },
                        new Word { Greek = "φωνὴν", Transliteration = "phōnēn", Gloss = "a voice", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "what seemed to be a voice"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μέσῳ", Transliteration = "mesō", Gloss = "the midst", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "τεσσάρων", Transliteration = "tessarōn", Gloss = "four", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ζῴων", Transliteration = "zōōn", Gloss = "living creatures", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the four living creatures"
                        }
                    },
                    Translation = "in the midst of the four living creatures"
                },
                new Word { Greek = "λέγουσαν", Transliteration = "legousan", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "F", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χοῖνιξ", Transliteration = "choinix", Gloss = "a quart", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σίτου", Transliteration = "sitou", Gloss = "of wheat", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "δηναρίου", Transliteration = "dēnariou", Gloss = "for a denarius", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τρεῖς", Transliteration = "treis", Gloss = "three", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "χοίνικες", Transliteration = "choinikes", Gloss = "quarts", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "κριθῶν", Transliteration = "krithōn", Gloss = "of barley", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "δηναρίου", Transliteration = "dēnariou", Gloss = "for a denarius", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "A quart of wheat for a denarius, and three quarts of barley for a denarius"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἔλαιον", Transliteration = "elaion", Gloss = "oil", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the oil"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "οἶνον", Transliteration = "oinon", Gloss = "wine", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the wine"
                },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "do not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἀδικήσῃς", Transliteration = "adikēsēs", Gloss = "damage", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "And I heard what seemed to be a voice in the midst of the four living creatures, saying, 'A quart of wheat for a denarius, and three quarts of barley for a denarius, and do not damage the oil and the wine!'"
        },
        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτε", Transliteration = "hote", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἤνοιξεν", Transliteration = "ēnoixen", Gloss = "he opened", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σφραγῖδα", Transliteration = "sphragida", Gloss = "seal", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "τετάρτην", Transliteration = "tetartēn", Gloss = "fourth", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the fourth seal"
                        }
                    },
                    Translation = "when he opened the fourth seal"
                },
                new Word { Greek = "ἤκουσα", Transliteration = "ēkousa", Gloss = "I heard", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "φωνὴν", Transliteration = "phōnēn", Gloss = "the voice", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "τετάρτου", Transliteration = "tetartou", Gloss = "fourth", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ζῴου", Transliteration = "zōou", Gloss = "living creature", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "of the fourth living creature"
                },
                new Word { Greek = "λέγοντος", Transliteration = "legontos", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "N", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἔρχου", Transliteration = "erchou", Gloss = "Come!", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "When he opened the fourth seal, I heard the voice of the fourth living creature say, 'Come!'"
        },
        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶδον", Transliteration = "eidon", Gloss = "I looked", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵππος", Transliteration = "hippos", Gloss = "a horse", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "χλωρός", Transliteration = "chlōros", Gloss = "pale", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a pale horse"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καθήμενος", Transliteration = "kathēmenos", Gloss = "sitting", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπάνω", Transliteration = "epanō", Gloss = "upon", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "it", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "on it"
                        }
                    },
                    Translation = "the one sitting on it"
                },
                new Word { Greek = "ὄνομα", Transliteration = "onoma", Gloss = "[was] name", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θάνατος", Transliteration = "thanatos", Gloss = "Death", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Death"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ᾅδης", Transliteration = "hadēs", Gloss = "Hades", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Hades"
                },
                new Word { Greek = "ἠκολούθει", Transliteration = "ēkolouthei", Gloss = "followed", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετ᾽", Transliteration = "met'", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "with him"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐδόθη", Transliteration = "edothē", Gloss = "authority was given", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐξουσία", Transliteration = "exousia", Gloss = "authority", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "over", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "τέταρτον", Transliteration = "tetarton", Gloss = "fourth", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "γῆς", Transliteration = "gēs", Gloss = "earth", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the earth"
                                }
                            },
                            Translation = "the fourth of the earth"
                        }
                    },
                    Translation = "over a fourth of the earth"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀποκτεῖναι", Transliteration = "apokteinai", Gloss = "to kill", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ῥομφαίᾳ", Transliteration = "rhomphaia", Gloss = "sword", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "with sword"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "λιμῷ", Transliteration = "limō", Gloss = "famine", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "with famine"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "θανάτῳ", Transliteration = "thanatō", Gloss = "pestilence", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "with pestilence"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θηρίων", Transliteration = "thēriōn", Gloss = "wild beasts", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "γῆς", Transliteration = "gēs", Gloss = "earth", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "of the earth"
                                        }
                                    },
                                    Translation = "the wild beasts of the earth"
                                }
                            },
                            Translation = "by the wild beasts of the earth"
                        }
                    },
                    Translation = "to kill with sword and with famine and with pestilence and by the wild beasts of the earth"
                }
            },
            Translation = "And I looked, and behold, a pale horse! And its rider's name was Death, and Hades followed him. And they were given authority over a fourth of the earth, to kill with sword and with famine and with pestilence and by wild beasts of the earth."
        }
    };
}

/*
Identified Constructions:
- Verse 1, 3, 5, 7: TEMP_CLAUSE (ὅτε + indicative)
- Verse 2, 4: PURPOSE_CLAUSE (ἵνα + subjunctive/indicative)
- Verse 6: NOUN_PHRASE as part of direct speech
- Verse 8: NOUN_PHRASE / PRED (ὄνομα αὐτῷ ὁ θάνατος)
*/
