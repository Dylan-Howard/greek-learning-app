private static List<object> GetChapter2()
{
    // Hebrews 2:17-18
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅθεν", Transliteration = "", Gloss = "from where", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "πάντα", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "in all things"
                        },
                        new Word { Greek = "ὤφειλεν", Transliteration = "", Gloss = "to owe", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἀδελφοῖς", Transliteration = "", Gloss = "brother", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "to his brothers"
                                },
                                new Word { Greek = "ὁμοιωθῆναι", Transliteration = "", Gloss = "to make like", GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "to be made like his brothers"
                        }
                    },
                    Translation = "he had to be made like his brothers in all things"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "VERB_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐλεήμων", Transliteration = "", Gloss = "merciful", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "γένηται", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3S" }, PartOfSpeech = "v" },
                                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "πιστὸς", Transliteration = "", Gloss = "faithful", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                                                new Word { Greek = "ἀρχιερεὺς", Transliteration = "", Gloss = "chief priest", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "faithful high priest"
                                        }
                                    },
                                    Translation = "merciful and faithful high priest"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὰ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "πρὸς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὸν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "θεὸν", Transliteration = "", Gloss = "God", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "God"
                                        }
                                    },
                                    Translation = "in the service of God"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" }, // Purpose expressed via Preposition
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὸ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "ἱλάσκεσθαι", Transliteration = "", Gloss = "to make atonement for", GrammarCodes = new List<string> { "V", "PRES", "PASS", "INF" }, PartOfSpeech = "v" },
                                                new Phrase
                                                {
                                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                                    Content = new List<object>
                                                    {
                                                        new Word { Greek = "τὰς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, PartOfSpeech = "art" },
                                                        new Word { Greek = "ἁμαρτίας", Transliteration = "", Gloss = "sin", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                                                        new Phrase
                                                        {
                                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                                                            Content = new List<object>
                                                            {
                                                                new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                                                new Word { Greek = "λαοῦ", Transliteration = "", Gloss = "people", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                                            },
                                                            Translation = "of the people"
                                                        }
                                                    },
                                                    Translation = "the sins of the people"
                                                }
                                            },
                                            Translation = "to make propitiation for the sins of the people"
                                        }
                                    },
                                    Translation = "to make propitiation for the sins of the people"
                                }
                            },
                            Translation = "he might become a merciful and faithful high priest in the service of God, to make propitiation for the sins of the people"
                        }
                    },
                    Translation = "so that he might become a merciful and faithful high priest in the service of God, to make propitiation for the sins of the people"
                }
            },
            Translation = "Therefore he had to be made like his brothers in every respect, so that he might become a merciful and faithful high priest in the service of God, to make propitiation for the sins of the people."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "γὰρ", Transliteration = "", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE", "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ᾧ", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "because"
                        },
                        new Word { Greek = "πέπονθεν", Transliteration = "", Gloss = "to experience", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸς", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "πειρασθείς", Transliteration = "", Gloss = "to test", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "because he himself has suffered when tempted"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δύναται", Transliteration = "", Gloss = "to be able", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "πειραζομένοις", Transliteration = "", Gloss = "to test", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "those who are being tempted"
                                },
                                new Word { Greek = "βοηθῆσαι", Transliteration = "", Gloss = "to help", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "to help those who are being tempted"
                        }
                    },
                    Translation = "he is able to help those who are being tempted"
                }
            },
            Translation = "For because he himself has suffered when tempted, he is able to help those who are being tempted."
        }
    };
}