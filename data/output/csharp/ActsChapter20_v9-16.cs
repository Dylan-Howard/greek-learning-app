private static List<object> GetChapter20()
{
    // Acts 20:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καθεζόμενος", Transliteration = "kathezomenos",
                    Gloss = "sitting",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δέ", Transliteration = "de",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τις", Transliteration = "tis",
                            Gloss = "a certain",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "part" },
                        new Word { Greek = "νεανίας", Transliteration = "neanias",
                            Gloss = "young man",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                    },
                    Translation = "a certain young man"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὀνόματι", Transliteration = "onomati",
                            Gloss = "by name",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "Εὔτυχος", Transliteration = "Eutychos",
                            Gloss = "Eutychus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "named Eutychus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi",
                            Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῆς", Transliteration = "tēs",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θυρίδος", Transliteration = "thyridos",
                            Gloss = "window",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in the window"
                },
                new Word { Greek = "καταφερόμενος", Transliteration = "katapheromenos",
                    Gloss = "being overcome",
                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὕπνῳ", Transliteration = "hypnō",
                            Gloss = "by sleep",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "βαθεῖ", Transliteration = "bathei",
                            Gloss = "deep",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "by a deep sleep"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διαλεγομένου", Transliteration = "dialegomenou",
                            Gloss = "as was talking",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "GEN", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "τοῦ", Transliteration = "tou",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Παύλου", Transliteration = "Paulou",
                            Gloss = "Paul",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "while Paul was talking"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi",
                            Gloss = "at",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "πλεῖον", Transliteration = "pleion",
                            Gloss = "length",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "still longer"
                },
                new Word { Greek = "κατενεχθεὶς", Transliteration = "katenechtheis",
                    Gloss = "having been overcome",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo",
                            Gloss = "by",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὕπνου", Transliteration = "hypnou",
                            Gloss = "sleep",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "by sleep"
                },
                new Word { Greek = "ἔπεσεν", Transliteration = "epesen",
                    Gloss = "he fell",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo",
                            Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "τριστέγου", Transliteration = "tristegou",
                            Gloss = "third story",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "from the third story"
                },
                new Word { Greek = "κάτω", Transliteration = "katō",
                    Gloss = "down",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἤρθη", Transliteration = "ērthē",
                    Gloss = "was taken up",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "νεκρός", Transliteration = "nekros",
                    Gloss = "dead",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                    PartOfSpeech = "adj" }
            },
            Translation = "And as a certain young man named Eutychus was sitting in the window, being overcome by a deep sleep while Paul was talking still longer, having been overcome by sleep, he fell down from the third story and was taken up dead."
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καταβὰς", Transliteration = "katabas",
                    Gloss = "having gone down",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Παῦλος", Transliteration = "Paulos",
                            Gloss = "Paul",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Paul"
                },
                new Word { Greek = "ἐπέπεσεν", Transliteration = "epepesen",
                    Gloss = "fell upon",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō",
                    Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "συμπεριλαβὼν", Transliteration = "symperilabōn",
                    Gloss = "having embraced",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen",
                    Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "mē",
                            Gloss = "not",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "θορυβεῖσθε", Transliteration = "thorybeisthe",
                            Gloss = "be troubled",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "IMP", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "Do not be troubled"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar",
                            Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ψυχὴ", Transliteration = "psychē",
                                    Gloss = "life",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                                    Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "his life"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en",
                                    Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτῷ", Transliteration = "autō",
                                    Gloss = "him",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "in him"
                        },
                        new Word { Greek = "ἐστιν", Transliteration = "estin",
                            Gloss = "is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "for his life is in him"
                }
            },
            Translation = "But Paul, having gone down, fell upon him, and having embraced him said, 'Do not be troubled, for his life is in him.'"
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀναβὰς", Transliteration = "anabas",
                    Gloss = "having gone up",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "κλάσας", Transliteration = "klasas",
                    Gloss = "having broken",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
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
                        new Word { Greek = "ἄρτον", Transliteration = "arton",
                            Gloss = "bread",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the bread"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "γευσάμενος", Transliteration = "geusamenos",
                    Gloss = "having eaten",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐφ᾽", Transliteration = "eph'",
                            Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἱκανόν", Transliteration = "hikanon",
                            Gloss = "a long time",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "for a long time"
                },
                new Word { Greek = "τε", Transliteration = "te",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὁμιλήσας", Transliteration = "homilēsas",
                    Gloss = "having talked",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄχρι", Transliteration = "achri",
                            Gloss = "until",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐγῆς", Transliteration = "augēs",
                            Gloss = "dawn",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "until dawn"
                },
                new Word { Greek = "οὕτως", Transliteration = "houtōs",
                    Gloss = "so",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἐξῆλθεν", Transliteration = "exēlthen",
                    Gloss = "he departed",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "And when he had gone up and had broken bread and eaten, and had talked with them a long while, even until dawn, so he departed."
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἤγαγον", Transliteration = "ēgagon",
                    Gloss = "they brought",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "παῖδα", Transliteration = "paida",
                            Gloss = "boy",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the boy"
                },
                new Word { Greek = "ζῶντα", Transliteration = "zōnta",
                    Gloss = "alive",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "παρεκλήθησαν", Transliteration = "pareklēthēsan",
                    Gloss = "were comforted",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "ADV" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐ", Transliteration = "ou",
                            Gloss = "not",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "μετρίως", Transliteration = "metriōs",
                            Gloss = "moderately",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "not a little"
                }
            },
            Translation = "And they brought the boy alive, and were not a little comforted."
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἡμεῖς", Transliteration = "Hēmeis",
                    Gloss = "we",
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "P" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "δὲ", Transliteration = "but",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "προελθόντες", Transliteration = "proelthontes",
                    Gloss = "having gone ahead",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πλοῖον", Transliteration = "ploion",
                            Gloss = "ship",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the ship"
                },
                new Word { Greek = "ἀνήχθημεν", Transliteration = "anēchthēmen",
                    Gloss = "set sail",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi",
                            Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Ἆσσον", Transliteration = "Asson",
                            Gloss = "Assos",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "for Assos"
                },
                new Word { Greek = "ἐκεῖθεν", Transliteration = "ekeithen",
                    Gloss = "from there",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "μέλλοντες", Transliteration = "mellontes",
                    Gloss = "intending",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀναλαμβάνειν", Transliteration = "analambanein",
                            Gloss = "to take on board",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
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
                                new Word { Greek = "Παῦλον", Transliteration = "Paulon",
                                    Gloss = "Paul",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "Paul"
                        }
                    },
                    Translation = "to take Paul on board"
                },
                new Word { Greek = "οὕτως", Transliteration = "houtōs",
                    Gloss = "for so",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "διατεταγμένος", Transliteration = "diatetagmenos",
                    Gloss = "having arranged",
                    GrammarCodes = new List<string> { "V", "PERF", "MID", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἦν", Transliteration = "ēn",
                    Gloss = "he had",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "μέλλων", Transliteration = "mellōn",
                    Gloss = "intending",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸς", Transliteration = "autos",
                    Gloss = "he himself",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "πεζεύειν", Transliteration = "pezeuein",
                    Gloss = "to go by land",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                    PartOfSpeech = "v" }
            },
            Translation = "But we, having gone ahead to the ship, set sail for Assos, intending to take Paul on board there; for so he had arranged, intending himself to go by land."
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs",
                            Gloss = "when",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "συνέβαλλεν", Transliteration = "syneballen",
                            Gloss = "he met",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἡμῖν", Transliteration = "hēmin",
                            Gloss = "us",
                            GrammarCodes = new List<string> { "PRON", "DAT", "1P", "P" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis",
                                    Gloss = "at",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Ἆσσον", Transliteration = "Asson",
                                    Gloss = "Assos",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "at Assos"
                        }
                    },
                    Translation = "And when he met us at Assos"
                },
                new Word { Greek = "ἀναλαβόντες", Transliteration = "analabontes",
                    Gloss = "having taken on board",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton",
                    Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἤλθομεν", Transliteration = "ēlthomen",
                    Gloss = "we came",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Μιτυλήνην", Transliteration = "Mitylēnēn",
                            Gloss = "Mitylene",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to Mitylene"
                }
            },
            Translation = "And when he met us at Assos, we took him on board and came to Mitylene."
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "κἀκεῖθεν", Transliteration = "kakeithen",
                    Gloss = "and from there",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἀποπλεύσαντες", Transliteration = "apopleusantes",
                    Gloss = "having sailed away",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἐπιούσῃ", Transliteration = "epiousē",
                            Gloss = "next day",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "F", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "on the following day"
                },
                new Word { Greek = "κατηντήσαμεν", Transliteration = "katēntēsamen",
                    Gloss = "we arrived",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "ADV" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄντικρυς", Transliteration = "antikrys",
                            Gloss = "opposite",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "Χίου", Transliteration = "Chiou",
                            Gloss = "Chios",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "opposite Chios"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἑτέρᾳ", Transliteration = "hetera",
                            Gloss = "next",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the next day"
                },
                new Word { Greek = "παρεβάλομεν", Transliteration = "parebalomen",
                    Gloss = "we crossed over",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Σάμον", Transliteration = "Samon",
                            Gloss = "Samos",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to Samos"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐχομένῃ", Transliteration = "echomenē",
                            Gloss = "following",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "DAT", "F", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "and the following day"
                },
                new Word { Greek = "ἤλθομεν", Transliteration = "ēlthomen",
                    Gloss = "we came",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Μίλητον", Transliteration = "Milēton",
                            Gloss = "Miletus",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to Miletus"
                }
            },
            Translation = "And sailing from there, we arrived opposite Chios the following day; the next day we crossed over to Samos; and the following day we came to Miletus."
        },

        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "κεκρίκει", Transliteration = "kekrikei",
                    Gloss = "had decided",
                    GrammarCodes = new List<string> { "V", "PLPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Παῦλος", Transliteration = "Paulos",
                            Gloss = "Paul",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Paul"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παραπλεῦσαι", Transliteration = "parapleusai",
                            Gloss = "to sail past",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Ἔφεσον", Transliteration = "Epheson",
                                    Gloss = "Ephesus",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "Ephesus"
                        }
                    },
                    Translation = "to sail past Ephesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπως", Transliteration = "hopōs",
                            Gloss = "so that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē",
                            Gloss = "not",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "γένηται", Transliteration = "genētai",
                            Gloss = "it might happen",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō",
                            Gloss = "to him",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "χρονοτριβῆσαι", Transliteration = "chronotribēsai",
                            Gloss = "to spend time",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en",
                                    Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τῇ", Transliteration = "tē",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Ἀσίᾳ", Transliteration = "Asia",
                                    Gloss = "Asia",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in Asia"
                        }
                    },
                    Translation = "so that he might not have to spend time in Asia"
                },
                new Word { Greek = "ἔσπευδεν", Transliteration = "espeuden",
                    Gloss = "he was hurrying",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei",
                            Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δυνατὸν", Transliteration = "dynaton",
                            Gloss = "possible",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "εἴη", Transliteration = "eiē",
                            Gloss = "it might be",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "OPT", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō",
                            Gloss = "for him",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "if it were possible for him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γενέσθαι", Transliteration = "genesthai",
                            Gloss = "to be",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis",
                                    Gloss = "at",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "Ἱεροσόλυμα", Transliteration = "Hierosolyma",
                                    Gloss = "Jerusalem",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "at Jerusalem"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "ACC_TIME" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἡμέραν", Transliteration = "hēmeran",
                                            Gloss = "day",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "on the day"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs",
                                            Gloss = "of",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "πεντηκοστῆς", Transliteration = "pentēkostēs",
                                            Gloss = "Pentecost",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of Pentecost"
                                }
                            },
                            Translation = "on the day of Pentecost"
                        }
                    },
                    Translation = "to be at Jerusalem on the day of Pentecost"
                }
            },
            Translation = "For Paul had decided to sail past Ephesus, so that he might not have to spend time in Asia; for he was hurrying to be at Jerusalem, if it were possible for him, on the day of Pentecost."
        }
    };
}

/*
Constructions Identified:
- GEN_ABS: Acts 20:9 (διαλεγομένου τοῦ Παύλου)
- DAT_INSTR: Acts 20:9 (ὕπνῳ βαθεῖ)
- DAT_REF: Acts 20:9 (ὀνόματι Εὔτυχος), Acts 20:15 (τῇ ἐπιούσῃ, τῇ ἑτέρᾳ, τῇ ἐχομένῃ)
- COND_CLAUSE: Acts 20:16 (εἰ δυνατὸν εἴη αὐτῷ) - Fourth class condition (potential)
- PURPOSE_CLAUSE: Acts 20:16 (ὅπως μὴ γένηται αὐτῷ χρονοτριβῆσαι)
*/
