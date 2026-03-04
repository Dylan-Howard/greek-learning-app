private static List<object> GetChapter7()
{
    // Acts 7:57-60
    return new List<object>
    {
        // Verse 57
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
                        new Word { Greek = "κράξαντες", Transliteration = "kraxantes",
                            Gloss = "having called out",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                            Content = new List<object>
                            {
                                new Word { Greek = "φωνῇ", Transliteration = "phōnē",
                                    Gloss = "with a voice",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "μεγάλῃ", Transliteration = "megalē",
                                    Gloss = "great",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "with a loud voice"
                        }
                    },
                    Translation = "But having cried out with a loud voice"
                },
                new Word { Greek = "συνέσχον", Transliteration = "syneschon",
                    Gloss = "they covered",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὦτα", Transliteration = "ōta",
                            Gloss = "ears",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn",
                            Gloss = "of them",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "their ears"
                }
            },
            Translation = "But they cried out with a loud voice and stopped their ears,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὥρμησαν", Transliteration = "hōrmēsan",
                    Gloss = "they rushed",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὁμοθυμαδὸν", Transliteration = "homothymadon",
                    Gloss = "with one accord",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπ᾽", Transliteration = "ep'",
                            Gloss = "upon",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτόν", Transliteration = "auton",
                            Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "upon him"
                }
            },
            Translation = "and rushed with one accord upon him."
        },

        // Verse 58
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
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκβαλόντες", Transliteration = "ekbalontes",
                            Gloss = "having cast out",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having cast [him] out"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔξω", Transliteration = "exō",
                            Gloss = "outside",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῆς", Transliteration = "tēs",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πόλεως", Transliteration = "poleōs",
                            Gloss = "city",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "outside of the city"
                },
                new Word { Greek = "ἐλιθοβόλουν", Transliteration = "elithoboloun",
                    Gloss = "they were stoning",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "And having cast him out of the city, they were stoning him."
        },
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μάρτυρες", Transliteration = "martyres",
                            Gloss = "witnesses",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the witnesses"
                },
                new Word { Greek = "ἀπέθεντο", Transliteration = "apethento",
                    Gloss = "laid aside",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἱμάτια", Transliteration = "himatia",
                            Gloss = "garments",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn",
                            Gloss = "of them",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "their garments"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρὰ", Transliteration = "para",
                            Gloss = "beside",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πόδας", Transliteration = "podas",
                            Gloss = "feet",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "at the feet"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "νεανίου", Transliteration = "neaniou",
                            Gloss = "of a young man",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καλουμένου", Transliteration = "kaloumenou",
                                    Gloss = "being called",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "GEN", "M", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "Σαύλου", Transliteration = "Saulou",
                                    Gloss = "Saul",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "called Saul"
                        }
                    },
                    Translation = "of a young man called Saul"
                }
            },
            Translation = "And the witnesses laid aside their garments at the feet of a young man named Saul."
        },

        // Verse 59
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐλιθοβόλουν", Transliteration = "elithoboloun",
                    Gloss = "they were stoning",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
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
                        new Word { Greek = "Στέφανον", Transliteration = "Stephanon",
                            Gloss = "Stephen",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Stephen"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπικαλούμενον", Transliteration = "epikaloumenon",
                            Gloss = "calling out",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "as he was calling out"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντα", Transliteration = "legonta",
                            Gloss = "saying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "and saying"
                }
            },
            Translation = "And they were stoning Stephen as he called out and said,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριε", Transliteration = "kyrie",
                            Gloss = "Lord",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou",
                            Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Lord Jesus"
                },
                new Word { Greek = "δέξαι", Transliteration = "dexai",
                    Gloss = "receive",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πνεῦμά", Transliteration = "pneuma",
                            Gloss = "spirit",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou",
                            Gloss = "of me",
                            GrammarCodes = new List<string> { "PRON", "GEN", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "my spirit"
                }
            },
            Translation = "Lord Jesus, receive my spirit."
        },

        // Verse 60
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
                        new Word { Greek = "θεὶς", Transliteration = "theis",
                            Gloss = "having placed",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "and having fallen"
                },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γόνατα", Transliteration = "gonata",
                            Gloss = "knees",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "on [his] knees"
                },
                new Word { Greek = "ἔκραξεν", Transliteration = "ekraxen",
                    Gloss = "he cried out",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φωνῇ", Transliteration = "phōnē",
                            Gloss = "with a voice",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μεγάλῃ", Transliteration = "megalē",
                            Gloss = "great",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "with a loud voice"
                }
            },
            Translation = "And having fallen on his knees, he cried out with a loud voice,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριε", Transliteration = "kyrie",
                            Gloss = "Lord",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Lord"
                },
                new Word { Greek = "μὴ", Transliteration = "mē",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "στήσῃς", Transliteration = "stēsēs",
                    Gloss = "set",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois",
                    Gloss = "to them",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταύτην", Transliteration = "tautēn",
                            Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "τὴν", Transliteration = "tēn",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἁμαρτίαν", Transliteration = "hamartian",
                            Gloss = "sin",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "this sin"
                }
            },
            Translation = "Lord, do not hold this sin against them."
        },
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
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦτο", Transliteration = "touto",
                            Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "adv" },
                        new Word { Greek = "εἰπὼν", Transliteration = "eipōn",
                            Gloss = "having said",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "and having said this"
                },
                new Word { Greek = "ἐκοιμήθη", Transliteration = "ekoimēthē",
                    Gloss = "he fell asleep",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "And when he had said this, he fell asleep."
        }
    };
}

/* 
Constructions Identified:
- DAT_MANNER: Acts 7:57 (φωνῇ μεγάλῃ), 7:60 (φωνῇ μεγάλῃ)
- VOC: Acts 7:59 (κύριε Ἰησοῦ), 7:60 (κύριε)
- PTCP: Acts 7:57 (κράξαντες), 7:58 (ἐκβαλόντες, καλουμένου), 7:59 (ἐπικαλούμενον, λέγοντα), 7:60 (θεὶς, εἰπὼν)
- APPOS: Acts 7:58 (καλουμένου Σαύλου)
*/
