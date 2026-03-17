private static List<object> GetChapter1()
{
    // Hebrews 1:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Πολυμερῶς", Transliteration = "", Gloss = "at many times", GrammarCodes = new List<string> { "ADJ" }, PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πολυτρόπως", Transliteration = "", Gloss = "in various ways", GrammarCodes = new List<string> { "ADJ" }, PartOfSpeech = "adj" },
                new Word { Greek = "πάλαι", Transliteration = "", Gloss = "long ago", GrammarCodes = new List<string> { "ADJ" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεὸς", Transliteration = "", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λαλήσας", Transliteration = "", Gloss = "to speak", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NP", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "πατράσιν", Transliteration = "", Gloss = "father", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "to the fathers"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "προφήταις", Transliteration = "", Gloss = "prophet", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the prophets"
                                }
                            },
                            Translation = "in the prophets"
                        }
                    },
                    Translation = "having spoken to the fathers in the prophets"
                },
                // Verse 2
                // (continues verse 1)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπ᾽", Transliteration = "", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐσχάτου", Transliteration = "", Gloss = "last", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "τῶν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἡμερῶν", Transliteration = "", Gloss = "day", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "τούτων", Transliteration = "", Gloss = "this", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" }
                            },
                            Translation = "these last days"
                        }
                    },
                    Translation = "in these last days"
                },
                new Word { Greek = "ἐλάλησεν", Transliteration = "", Gloss = "to speak", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἡμῖν", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "υἱῷ", Transliteration = "", Gloss = "son", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a Son"
                        }
                    },
                    Translation = "in a Son"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃν", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἔθηκεν", Transliteration = "", Gloss = "to place", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κληρονόμον", Transliteration = "", Gloss = "heir", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "πάντων", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "heir of all things"
                        }
                    },
                    Translation = "whom He appointed heir of all things"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δι᾽", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "οὗ", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "through whom"
                        },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐποίησεν", Transliteration = "", Gloss = "to do", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "αἰῶνας", Transliteration = "", Gloss = "eternity", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the world"
                        }
                    },
                    Translation = "through whom also He made the world"
                },
                // Verse 3
                // (continues verse 2)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὢν", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NP", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀπαύγασμα", Transliteration = "", Gloss = "radiance", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "δόξης", Transliteration = "", Gloss = "glory", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the radiance of His glory"
                                },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "χαρακτὴρ", Transliteration = "", Gloss = "exact representation", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ὑποστάσεως", Transliteration = "", Gloss = "confidence", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "the exact representation of His nature"
                                }
                            },
                            Translation = "being the radiance of His glory and the exact representation of His nature"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "φέρων", Transliteration = "", Gloss = "to bring", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NP", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "τε", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὰ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "πάντα", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "all things"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῷ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ῥήματι", Transliteration = "", Gloss = "word", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "δυνάμεως", Transliteration = "", Gloss = "power", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "by the word of His power"
                                }
                            },
                            Translation = "and upholding all things by the word of His power"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "καθαρισμὸν", Transliteration = "", Gloss = "cleansing", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "τῶν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἁμαρτιῶν", Transliteration = "", Gloss = "sin", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "purification of sins"
                                },
                                new Word { Greek = "ποιησάμενος", Transliteration = "", Gloss = "to do", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NP", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "having made purification of sins"
                        },
                        new Word { Greek = "ἐκάθισεν", Transliteration = "", Gloss = "to place", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "δεξιᾷ", Transliteration = "", Gloss = "the right side", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "μεγαλωσύνης", Transliteration = "", Gloss = "majesty", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the right hand of the Majesty"
                                }
                            },
                            Translation = "at the right hand of the Majesty"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὑψηλοῖς", Transliteration = "", Gloss = "high", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "on high"
                        }
                    },
                    Translation = "who... sat down at the right hand of the Majesty on high"
                },
                // Verse 4
                // (continues verse 3)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοσούτῳ", Transliteration = "", Gloss = "so great", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                                new Word { Greek = "κρείττων", Transliteration = "", Gloss = "better", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "much better"
                        },
                        new Word { Greek = "γενόμενος", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "2", "ACT", "D", "NP", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγγέλων", Transliteration = "", Gloss = "angel", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "than the angels"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅσῳ", Transliteration = "", Gloss = "how great", GrammarCodes = new List<string> { "K" }, PartOfSpeech = "k" },
                                new Word { Greek = "διαφορώτερον", Transliteration = "", Gloss = "different", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "παρ᾽", Transliteration = "", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "αὐτοὺς", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "than they"
                                },
                                new Word { Greek = "κεκληρονόμηκεν", Transliteration = "", Gloss = "to inherit", GrammarCodes = new List<string> { "V", "R", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "ὄνομα", Transliteration = "", Gloss = "name", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "as He has inherited a more excellent name than they"
                        }
                    },
                    Translation = "having become as much better than the angels..."
                }
            },
            Translation = "God, after He spoke long ago to the fathers in the prophets in many portions and in many ways, in these last days has spoken to us in His Son, whom He appointed heir of all things, through whom also He made the world. And He is the radiance of His glory and the exact representation of His nature, and upholds all things by the word of His power. When He had made purification of sins, He sat down at the right hand of the Majesty on high, having become as much better than the angels, as He has inherited a more excellent name than they."
        },
        // Verse 5
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
                        new Word { Greek = "Τίνι", Transliteration = "", Gloss = "who?", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interj" },
                        new Word { Greek = "γὰρ", Transliteration = "", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "εἶπέν", Transliteration = "", Gloss = "say", GrammarCodes = new List<string> { "V", "2", "ACT", "A", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ποτε", Transliteration = "", Gloss = "once", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγγέλων", Transliteration = "", Gloss = "angel", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the angels"
                        }
                    },
                    Translation = "For to which of the angels did He ever say"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "υἱός", Transliteration = "", Gloss = "son", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" }
                            },
                            Translation = "My Son"
                        },
                        new Word { Greek = "εἶ", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "σύ", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐγὼ", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "σήμερον", Transliteration = "", Gloss = "today", GrammarCodes = new List<string> { "ADJ" }, PartOfSpeech = "adj" },
                        new Word { Greek = "γεγέννηκά", Transliteration = "", Gloss = "to become the father of", GrammarCodes = new List<string> { "V", "R", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "σε", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" }
                    },
                    Translation = "You are My Son, today I have begotten You"
                },
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πάλιν", Transliteration = "", Gloss = "again", GrammarCodes = new List<string> { "ADJ" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐγὼ", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἔσομαι", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "FUT", "D", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αὐτῷ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "εἰς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "πατέρα", Transliteration = "", Gloss = "father", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a Father to Him"
                        },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτὸς", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἔσται", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "FUT", "D", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μοι", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "εἰς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "υἱόν", Transliteration = "", Gloss = "son", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a Son to Me"
                        }
                    },
                    Translation = "I will be a Father to Him and He shall be a Son to Me"
                }
            },
            Translation = "For to which of the angels did He ever say, \"You are My Son, today I have begotten You\"? And again, \"I will be a Father to Him and He shall be a Son to Me\"?"
        },
        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅταν", Transliteration = "", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πάλιν", Transliteration = "", Gloss = "again", GrammarCodes = new List<string> { "ADJ" }, PartOfSpeech = "adj" },
                        new Word { Greek = "εἰσαγάγῃ", Transliteration = "", Gloss = "to bring in", GrammarCodes = new List<string> { "V", "2", "ACT", "A", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πρωτότοκον", Transliteration = "", Gloss = "firstborn", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the firstborn"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "οἰκουμένην", Transliteration = "", Gloss = "the world", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the world"
                                }
                            },
                            Translation = "into the world"
                        }
                    },
                    Translation = "And when He again brings the firstborn into the world"
                },
                new Word { Greek = "λέγει", Transliteration = "", Gloss = "say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "προσκυνησάτωσαν", Transliteration = "", Gloss = "to worship", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "3P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῷ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάντες", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἄγγελοι", Transliteration = "", Gloss = "angel", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "θεοῦ", Transliteration = "", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "all the angels of God"
                        }
                    },
                    Translation = "And let all the angels of God worship Him"
                }
            },
            Translation = "And when He again brings the firstborn into the world, He says, \"And let all the angels of God worship Him.\""
        },
        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μὲν", Transliteration = "", Gloss = "often untranslated", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγγέλους", Transliteration = "", Gloss = "angel", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the angels"
                        }
                    },
                    Translation = "of the angels"
                },
                new Word { Greek = "λέγει", Transliteration = "", Gloss = "say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ποιῶν", Transliteration = "", Gloss = "to do", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NP", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "He who makes"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγγέλους", Transliteration = "", Gloss = "angel", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" }
                            },
                            Translation = "His angels"
                        },
                        new Word { Greek = "πνεύματα", Transliteration = "", Gloss = "wind", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "λειτουργοὺς", Transliteration = "", Gloss = "servant", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" }
                            },
                            Translation = "His ministers"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πυρὸς", Transliteration = "", Gloss = "fire", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "φλόγα", Transliteration = "", Gloss = "flame", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a flame of fire"
                        }
                    },
                    Translation = "Who makes His angels winds, and His ministers a flame of fire"
                }
            },
            Translation = "And of the angels He says, \"Who makes His angels winds, and His ministers a flame of fire.\""
        },
        // Verse 8
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
                        new Word { Greek = "πρὸς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "υἱόν", Transliteration = "", Gloss = "son", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Son"
                        }
                    },
                    Translation = "But of the Son He says"
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
                                new Word { Greek = "ὁ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θρόνος", Transliteration = "", Gloss = "throne", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "σου", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" }
                            },
                            Translation = "Your throne"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "VOC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεὸς", Transliteration = "", Gloss = "God", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "O God"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "αἰῶνα", Transliteration = "", Gloss = "eternity", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "αἰῶνος", Transliteration = "", Gloss = "eternity", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "forever and ever"
                                }
                            },
                            Translation = "is forever and ever"
                        },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ῥάβδος", Transliteration = "", Gloss = "rod", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "εὐθύτητος", Transliteration = "", Gloss = "righteousness", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the scepter of righteousness"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ῥάβδος", Transliteration = "", Gloss = "rod", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "βασιλείας", Transliteration = "", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "σου", Transliteration = "", Gloss = "you", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" }
                            },
                            Translation = "is the scepter of Your kingdom"
                        }
                    },
                    Translation = "Your throne, O God, is forever and ever, and the scepter of righteousness is the scepter of Your kingdom"
                }
            },
            Translation = "But of the Son He says, \"Your throne, O God, is forever and ever, and the scepter of righteousness is the scepter of Your kingdom.\""
        }
    };
}
// Constructions identified:
// V1-2: Ptcp 'λαλήσας' modifying 'ὁ θεὸς' in main clause.
// V3: Relative clause 'ὃς...' containing participles 'ὢν', 'φέρων', 'ποιησάμενος' describing the Son.
// V6: Dependent temporal clause with 'ὅταν'.
// V8: Vocative 'ὁ θεὸς' addressed to the Son.