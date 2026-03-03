private static List<object> GetChapter11()
{
    // Revelation 11:17-19
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγοντες", Transliteration = "legontes",
                    Gloss = "saying",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εὐχαριστοῦμέν", Transliteration = "eucharistoumen",
                            Gloss = "we give thanks",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "σοι", Transliteration = "soi",
                            Gloss = "to you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "we give thanks to you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριε", Transliteration = "kyrie",
                            Gloss = "Lord",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεὸς", Transliteration = "theos",
                            Gloss = "God",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "VOC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "παντοκράτωρ", Transliteration = "pantokratōr",
                            Gloss = "Almighty",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Lord God Almighty"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the [one]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὢν", Transliteration = "ōn",
                            Gloss = "who is",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the [one]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἦν", Transliteration = "ēn",
                            Gloss = "who was",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "who is and who was"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti",
                            Gloss = "because",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "εἴληφας", Transliteration = "eilēphas",
                            Gloss = "you have taken",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "S" },
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
                                new Word { Greek = "δύναμίν", Transliteration = "dynamin",
                                    Gloss = "power",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "σου", Transliteration = "sou",
                                    Gloss = "of you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "μεγάλην", Transliteration = "megalēn",
                                    Gloss = "great",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "your great power"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἐβασίλευσας", Transliteration = "ebasileusas",
                            Gloss = "began to reign",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "because you have taken your great power and begun to reign"
                }
            },
            Translation = "saying, 'We give thanks to you, Lord God Almighty, who is and who was, because you have taken your great power and begun to reign.'"
        },

        // Verse 18
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
                        new Word { Greek = "τὰ", Transliteration = "ta",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἔθνη", Transliteration = "ethnē",
                            Gloss = "nations",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the nations"
                },
                new Word { Greek = "ὠργίσθησαν", Transliteration = "ōrgisthēsan",
                    Gloss = "were enraged",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἦλθεν", Transliteration = "ēlthen",
                    Gloss = "came",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὀργή", Transliteration = "orgē",
                            Gloss = "wrath",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou",
                            Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "your wrath"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
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
                        new Word { Greek = "καιρὸς", Transliteration = "kairos",
                            Gloss = "time",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "νεκρῶν", Transliteration = "nekrōn",
                                    Gloss = "dead",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "of the dead"
                        }
                    },
                    Translation = "the time of the dead"
                },
                new Word { Greek = "κριθῆναι", Transliteration = "krithēnai",
                    Gloss = "to be judged",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δοῦναι", Transliteration = "dounai",
                            Gloss = "to give",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
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
                                new Word { Greek = "μισθὸν", Transliteration = "misthon",
                                    Gloss = "reward",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the reward"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois",
                                    Gloss = "to the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "δούλοις", Transliteration = "doulois",
                                    Gloss = "servants",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "σου", Transliteration = "sou",
                                    Gloss = "of you",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τοῖς", Transliteration = "tois",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "προφήταις", Transliteration = "prophētais",
                                    Gloss = "prophets",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to your servants the prophets"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois",
                                    Gloss = "to the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἁγίοις", Transliteration = "hagiois",
                                    Gloss = "saints",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "to the saints"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois",
                                    Gloss = "to the [ones]",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "φοβουμένοις", Transliteration = "phoboumenois",
                                    Gloss = "fearing",
                                    GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "DAT", "M", "P" },
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
                                        new Word { Greek = "ὄνομά", Transliteration = "onoma",
                                            Gloss = "name",
                                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "σου", Transliteration = "sou",
                                            Gloss = "of you",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "your name"
                                }
                            },
                            Translation = "to those fearing your name"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "μικροὺς", Transliteration = "mikrous",
                                    Gloss = "small",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "καὶ", Transliteration = "kai",
                                    Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "τοὺς", Transliteration = "tous",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "μεγάλους", Transliteration = "megalous",
                                    Gloss = "great",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "small and great"
                        }
                    },
                    Translation = "to give the reward to your servants the prophets and to the saints and to those who fear your name, small and great"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διαφθεῖραι", Transliteration = "diaphtheirai",
                            Gloss = "to destroy",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous",
                                    Gloss = "the [ones]",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "διαφθείροντας", Transliteration = "diaphtheirontas",
                                    Gloss = "destroying",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" },
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
                                        new Word { Greek = "γῆν", Transliteration = "gēn",
                                            Gloss = "earth",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the earth"
                                }
                            },
                            Translation = "those who destroy the earth"
                        }
                    },
                    Translation = "and to destroy those who destroy the earth"
                }
            },
            Translation = "The nations were enraged, and your wrath came, and the time for the dead to be judged, and for giving the reward to your servants the prophets and saints and those who fear your name, both small and great, and for destroying those who destroy the earth."
        },

        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai",
                    Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἠνοίγη", Transliteration = "ēnoigē",
                    Gloss = "was opened",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ναὸς", Transliteration = "naos",
                            Gloss = "temple",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou",
                                    Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of God"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho",
                                    Gloss = "which [is]",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐν", Transliteration = "en",
                                    Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τῷ", Transliteration = "tō",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "οὐρανῷ", Transliteration = "ouranō",
                                    Gloss = "heaven",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in heaven"
                        }
                    },
                    Translation = "the temple of God in heaven"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ὤφθη", Transliteration = "ōphthē",
                    Gloss = "was seen",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κιβωτὸς", Transliteration = "kibōtos",
                            Gloss = "ark",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "διαθήκης", Transliteration = "diathēkēs",
                                    Gloss = "covenant",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                                    Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "of his covenant"
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
                                new Word { Greek = "τῷ", Transliteration = "tō",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ναῷ", Transliteration = "naō",
                                    Gloss = "temple",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                                    Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "in his temple"
                        }
                    },
                    Translation = "the ark of his covenant in his temple"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐγένοντο", Transliteration = "egenonto",
                    Gloss = "there were",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀστραπαὶ", Transliteration = "astrapai",
                            Gloss = "lightnings",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "φωναὶ", Transliteration = "phōnai",
                            Gloss = "voices",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "βρονταὶ", Transliteration = "brontai",
                            Gloss = "thunders",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "σεισμὸς", Transliteration = "seismos",
                            Gloss = "earthquake",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "χάλαζα", Transliteration = "chalaza",
                            Gloss = "hail",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μεγάλη", Transliteration = "megalē",
                            Gloss = "great",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "lightnings, voices, thunders, an earthquake, and great hail"
                }
            },
            Translation = "Then God's temple in heaven was opened, and the ark of his covenant was seen within his temple. There were flashes of lightning, rumblings, peals of thunder, an earthquake, and heavy hail."
        }
    };
}

// Identified Constructions:
// - Granville-Sharp (TSKS) pattern in v.17: ὁ ὢν καὶ ὁ ἦν (though articles are repeated, it functions as a single title).
// - Objective Genitive (GEN_OBJ) in v.18: καιρὸς τῶν νεκρῶν (time for [judging] the dead).
// - Dative of Interest (IND_OBJ) in v.18: τοῖς δούλοις σου (reward given *to* your servants).
