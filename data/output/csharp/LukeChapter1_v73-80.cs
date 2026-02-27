private static List<object> GetChapter1()
{
    // Luke 1:73-80
    return new List<object>
    {
        // Verse 73
        new Phrase
        {
            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
            Content = new List<object>
            {
                new Word { Greek = "ὅρκον", Transliteration = "horkon", Gloss = "the oath", 
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "which", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ὤμοσεν", Transliteration = "ōmosen", Gloss = "he swore", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "Ἀβραὰμ", Transliteration = "Abraam", Gloss = "Abraham", 
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "to Abraham"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πατέρα", Transliteration = "patera", Gloss = "father", 
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us", 
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "our father"
                        }
                    },
                    Translation = "which he swore to Abraham our father"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "PURPOSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "to", 
                            GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δοῦναι", Transliteration = "dounai", Gloss = "grant", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us", 
                            GrammarCodes = new List<string> { "PRON", "DAT", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "to grant us"
                }
            },
            Translation = "the oath which he swore to Abraham our father, to grant us"
        },
        // Verse 74
        new Phrase
        {
            SyntaxCodes = new List<string> { "INF_PHRASE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀφόβως", Transliteration = "aphobōs", Gloss = "fearlessly", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "χειρὸς", Transliteration = "cheiros", Gloss = "the hand", 
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἐχθρῶν", Transliteration = "echthrōn", Gloss = "of enemies", 
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "from the hand of enemies"
                        },
                        new Word { Greek = "ῥυσθέντας", Transliteration = "rhysthentas", Gloss = "having been rescued", 
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "being rescued from the hand of enemies"
                },
                new Word { Greek = "λατρεύειν", Transliteration = "latreuein", Gloss = "to serve", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" }
            },
            Translation = "that we, being rescued from the hand of our enemies, might serve him without fear"
        },
        // Verse 75
        new Phrase
        {
            SyntaxCodes = new List<string> { "PREP_PHRASE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Word { Greek = "ὁσιότητι", Transliteration = "hosiotēti", Gloss = "holiness", 
                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "δικαιοσύνῃ", Transliteration = "dikaiosynē", Gloss = "righteousness", 
                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
            },
            Translation = "in holiness and righteousness"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PREP_PHRASE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐνώπιον", Transliteration = "enōpion", Gloss = "before", 
                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", 
                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
            },
            Translation = "before him"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
            Content = new List<object>
            {
                new Word { Greek = "πάσαις", Transliteration = "pasais", Gloss = "all", 
                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "the", 
                    GrammarCodes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "art" },
                new Word { Greek = "ἡμέραις", Transliteration = "hēmerais", Gloss = "days", 
                    GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us", 
                    GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "pron" }
            },
            Translation = "all our days"
        },
        // Verse 76
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" }, PartOfSpeech = "pron" },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "also", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "παιδίον", Transliteration = "paidion", Gloss = "child", 
                    GrammarCodes = new List<string> { "N", "VOC", "N", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προφήτης", Transliteration = "prophētēs", Gloss = "prophet", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὑψίστου", Transliteration = "hypsistou", Gloss = "of the Most High", 
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "prophet of the Most High"
                },
                new Word { Greek = "κληθήσῃ", Transliteration = "klēthēsē", Gloss = "will be called", 
                    GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "2P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "And you, child, will be called the prophet of the Most High"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "προπορεύσῃ", Transliteration = "proporeusē", Gloss = "you will go before", 
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐνώπιον", Transliteration = "enōpion", Gloss = "before", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "the Lord", 
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "before the Lord"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "PURPOSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἑτοιμάσαι", Transliteration = "hetoimasai", Gloss = "to prepare", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁδοὺς", Transliteration = "hodous", Gloss = "ways", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", 
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "his ways"
                        }
                    },
                    Translation = "to prepare his ways"
                }
            },
            Translation = "for you will go before the Lord to prepare his ways"
        },
        // Verse 77
        new Phrase
        {
            SyntaxCodes = new List<string> { "INF_PHRASE" },
            Content = new List<object>
            {
                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "to", 
                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "δοῦναι", Transliteration = "dounai", Gloss = "give", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γνῶσιν", Transliteration = "gnōsin", Gloss = "knowledge", 
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σωτηρίας", Transliteration = "sōtērias", Gloss = "of salvation", 
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "knowledge of salvation"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "λαῷ", Transliteration = "laō", Gloss = "people", 
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "to his people"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀφέσει", Transliteration = "aphesei", Gloss = "forgiveness", 
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἁμαρτιῶν", Transliteration = "hamartiōn", Gloss = "of sins", 
                            GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "in the forgiveness of their sins"
                }
            },
            Translation = "to give knowledge of salvation to his people in the forgiveness of their sins"
        },
        // Verse 78
        new Phrase
        {
            SyntaxCodes = new List<string> { "PREP_PHRASE" },
            Content = new List<object>
            {
                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", 
                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σπλάγχνα", Transliteration = "splangchna", Gloss = "the tender mercy", 
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἐλέους", Transliteration = "eleous", Gloss = "of mercy", 
                            GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", 
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us", 
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "of our God"
                        }
                    },
                    Translation = "the tender mercy of our God"
                }
            },
            Translation = "through the tender mercy of our God"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", 
                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Word { Greek = "οἷς", Transliteration = "hois", Gloss = "which", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "N", "P" }, PartOfSpeech = "pron" },
                new Word { Greek = "ἐπισκέψεται", Transliteration = "episkepsetai", Gloss = "will visit", 
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "P" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνατολὴ", Transliteration = "anatolē", Gloss = "the sunrise", 
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "from", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὕψους", Transliteration = "hypsous", Gloss = "on high", 
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "from on high"
                        }
                    },
                    Translation = "the sunrise from on high"
                }
            },
            Translation = "whereby the sunrise shall visit us from on high"
        },
        // Verse 79
        new Phrase
        {
            SyntaxCodes = new List<string> { "INF_PHRASE", "PURPOSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐπιφᾶναι", Transliteration = "epiphanai", Gloss = "to give light", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to those", 
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "σκότει", Transliteration = "skotei", Gloss = "darkness", 
                                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "in darkness"
                                },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "σκιᾷ", Transliteration = "skia", Gloss = "the shadow", 
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "θανάτου", Transliteration = "thanatou", Gloss = "of death", 
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the shadow of death"
                                },
                                new Word { Greek = "καθημένοις", Transliteration = "kathēmenois", Gloss = "sitting", 
                                    GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "who sit in darkness and in the shadow of death"
                        }
                    },
                    Translation = "to those who sit in darkness and in the shadow of death"
                }
            },
            Translation = "to give light to those who sit in darkness and in the shadow of death"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INF_PHRASE", "PURPOSE" },
            Content = new List<object>
            {
                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "to", 
                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "κατευθῦναι", Transliteration = "kateuthynai", Gloss = "guide", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "πόδας", Transliteration = "podas", Gloss = "feet", 
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "our feet"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁδὸν", Transliteration = "hodon", Gloss = "the way", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "εἰρήνης", Transliteration = "eirēnēs", Gloss = "of peace", 
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the way of peace"
                        }
                    },
                    Translation = "into the way of peace"
                }
            },
            Translation = "to guide our feet into the way of peace"
        },
        // Verse 80
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
                        new Word { Greek = "Τὸ", Transliteration = "To", Gloss = "The", 
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "παιδίον", Transliteration = "paidion", Gloss = "child", 
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "And the child"
                },
                new Word { Greek = "ηὔξανεν", Transliteration = "ēuxanen", Gloss = "grew", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐκραταιοῦτο", Transliteration = "ekrataiouto", Gloss = "became strong", 
                    GrammarCodes = new List<string> { "V", "IMPF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "πνεύματι", Transliteration = "pneumati", Gloss = "in spirit", 
                    GrammarCodes = new List<string> { "N", "DAT", "N", "S", "DAT_INSTR" }, PartOfSpeech = "n" }
            },
            Translation = "And the child grew and became strong in spirit"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "he was", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐρήμοις", Transliteration = "erēmois", Gloss = "wilderness", 
                            GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "in the wilderness"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "until", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡμέρας", Transliteration = "hēmeras", Gloss = "the day", 
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀναδείξεως", Transliteration = "anadeixeōs", Gloss = "of public appearance", 
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", 
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                                    },
                                    Translation = "of his public appearance"
                                }
                            },
                            Translation = "the day of his public appearance"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "Ἰσραήλ", Transliteration = "Israēl", Gloss = "Israel", 
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "Israel"
                                }
                            },
                            Translation = "to Israel"
                        }
                    },
                    Translation = "until the day of his public appearance to Israel"
                }
            },
            Translation = "and he was in the wilderness until the day of his public appearance to Israel"
        }
    };
}

/* 
Constructions Identified:
- APPOS: Luke 1:73 (τὸν πατέρα ἡμῶν)
- VOC: Luke 1:76 (παιδίον)
- PRED: Luke 1:76 (προφήτης ὑψίστου)
- DAT_INSTR: Luke 1:80 (πνεύματι)
- GEN_DESC: Luke 1:77 (γνῶσιν σωτηρίας), Luke 1:78 (σπλάγχνα ἐλέους), Luke 1:79 (σκιᾷ θανάτου), Luke 1:79 (ὁδὸν εἰρήνης)
- PURPOSE: Luke 1:73, 76, 77, 79 (Infinitive phrases indicating purpose)
*/
