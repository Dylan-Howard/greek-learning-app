private static List<object> GetChapter16()
{
    // Romans 16:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Οὐρβανὸν", Transliteration = "Ourbanon",
                            Gloss = "Urbanus",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "συνεργὸν", Transliteration = "synergon",
                                    Gloss = "fellow worker",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn",
                                    Gloss = "of us",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "our fellow worker"
                        }
                    },
                    Translation = "Urbanus, our fellow worker"
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
                        new Word { Greek = "Χριστῷ", Transliteration = "Christō",
                            Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in Christ"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Στάχυν", Transliteration = "Stachyn",
                            Gloss = "Stachys",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀγαπητόν", Transliteration = "agapēton",
                            Gloss = "beloved",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "μου", Transliteration = "mou",
                            Gloss = "of me",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "Stachys my beloved"
                }
            },
            Translation = "Greet Urbanus, our fellow worker in Christ, and Stachys my beloved."
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἀπελλῆν", Transliteration = "Apellēn",
                            Gloss = "Apelles",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δόκιμον", Transliteration = "dokimon",
                            Gloss = "approved",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "Apelles the approved"
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
                        new Word { Greek = "Χριστῷ", Transliteration = "Christō",
                            Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in Christ"
                }
            },
            Translation = "Greet Apelles, who is approved in Christ."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "those",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek",
                                    Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "the [household]",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Ἀριστοβούλου", Transliteration = "Aristoboulou",
                                    Gloss = "of Aristobulus",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "from those of Aristobulus"
                        }
                    },
                    Translation = "those of the household of Aristobulus"
                }
            },
            Translation = "Greet those who belong to the household of Aristobulus."
        },
        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἡρῳδίωνα", Transliteration = "Hērōdiōna",
                            Gloss = "Herodion",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "συγγενῆ", Transliteration = "syngenē",
                            Gloss = "kinsman",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "μου", Transliteration = "mou",
                            Gloss = "of me",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "Herodion my kinsman"
                }
            },
            Translation = "Greet Herodion, my kinsman."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "those",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek",
                                    Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "the [household]",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Ναρκίσσου", Transliteration = "Narkissou",
                                    Gloss = "of Narcissus",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "from those of Narcissus"
                        }
                    },
                    Translation = "those of the household of Narcissus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "who",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὄντας", Transliteration = "ontas",
                            Gloss = "are",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" },
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
                                new Word { Greek = "κυρίῳ", Transliteration = "kyriō",
                                    Gloss = "the Lord",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in the Lord"
                        }
                    },
                    Translation = "who are in the Lord"
                }
            },
            Translation = "Greet those in the household of Narcissus who are in the Lord."
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Τρύφαιναν", Transliteration = "Tryphainan",
                            Gloss = "Tryphena",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai",
                            Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "Τρυφῶσαν", Transliteration = "Tryphōsan",
                            Gloss = "Tryphosa",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Tryphena and Tryphosa"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰς", Transliteration = "tas",
                            Gloss = "who",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κοπιώσας", Transliteration = "kopiōsas",
                            Gloss = "labor",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "F", "P" },
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
                                new Word { Greek = "κυρίῳ", Transliteration = "kyriō",
                                    Gloss = "the Lord",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in the Lord"
                        }
                    },
                    Translation = "who labor in the Lord"
                }
            },
            Translation = "Greet Tryphena and Tryphosa, who labor in the Lord."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Περσίδα", Transliteration = "Persida",
                            Gloss = "Persis",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τὴν", Transliteration = "tēn",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀγαπητήν", Transliteration = "agapētēn",
                            Gloss = "beloved",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the beloved Persis"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἥτις", Transliteration = "hētis",
                            Gloss = "who",
                            GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "πολλὰ", Transliteration = "polla",
                            Gloss = "much",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἐκοπίασεν", Transliteration = "ekopiasen",
                            Gloss = "labored",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
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
                                new Word { Greek = "κυρίῳ", Transliteration = "kyriō",
                                    Gloss = "the Lord",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in the Lord"
                        }
                    },
                    Translation = "who has labored much in the Lord"
                }
            },
            Translation = "Greet the beloved Persis, who has labored much in the Lord."
        },
        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ῥοῦφον", Transliteration = "Rouphon",
                            Gloss = "Rufus",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἐκλεκτὸν", Transliteration = "eklekton",
                            Gloss = "chosen",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en",
                                    Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "κυρίῳ", Transliteration = "kyriō",
                                    Gloss = "the Lord",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in the Lord"
                        }
                    },
                    Translation = "Rufus, chosen in the Lord"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "μητέρα", Transliteration = "mētera",
                            Gloss = "mother",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                            Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "his mother"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐμοῦ", Transliteration = "emou",
                    Gloss = "mine",
                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                    PartOfSpeech = "pron" }
            },
            Translation = "Greet Rufus, chosen in the Lord, and his mother and mine."
        },
        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "Ἀσύγκριτον", Transliteration = "Asynkriton",
                    Gloss = "Asyncritus",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "Φλέγοντα", Transliteration = "Phlegonta",
                    Gloss = "Phlegon",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "Ἑρμῆν", Transliteration = "Hermēn",
                    Gloss = "Hermes",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "Πατροβᾶν", Transliteration = "Patroban",
                    Gloss = "Patrobas",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "Ἑρμᾶν", Transliteration = "Herman",
                    Gloss = "Hermas",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "σὺν", Transliteration = "syn",
                                    Gloss = "with",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτοῖς", Transliteration = "autois",
                                    Gloss = "them",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "with them"
                        },
                        new Word { Greek = "ἀδελφούς", Transliteration = "adelphous",
                            Gloss = "brothers",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the brothers with them"
                }
            },
            Translation = "Greet Asyncritus, Phlegon, Hermes, Patrobas, Hermas, and the brothers with them."
        },
        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "Φιλόλογον", Transliteration = "Philologon",
                    Gloss = "Philologus",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "Ἰουλίαν", Transliteration = "Ioulian",
                    Gloss = "Julia",
                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "Νηρέα", Transliteration = "Nērea",
                    Gloss = "Nereus",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀδελφὴν", Transliteration = "adelphēn",
                            Gloss = "sister",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                            Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "his sister"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "Ὀλυμπᾶν", Transliteration = "Olympan",
                    Gloss = "Olympas",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "σὺν", Transliteration = "syn",
                                    Gloss = "with",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτοῖς", Transliteration = "autois",
                                    Gloss = "them",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "with them"
                        },
                        new Word { Greek = "πάντας", Transliteration = "pantas",
                            Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἁγίους", Transliteration = "agious",
                            Gloss = "saints",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "all the saints with them"
                }
            },
            Translation = "Greet Philologus, Julia, Nereus and his sister, and Olympas, and all the saints with them."
        },
        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάσασθε", Transliteration = "aspasasthe",
                    Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἀλλήλους", Transliteration = "allēlous",
                    Gloss = "one another",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "φιλήματι", Transliteration = "philēmati",
                            Gloss = "a kiss",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἁγίῳ", Transliteration = "hagiō",
                            Gloss = "holy",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "with a holy kiss"
                }
            },
            Translation = "Greet one another with a holy kiss."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσπάζονται", Transliteration = "aspazontai",
                    Gloss = "greet",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas",
                    Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἱ", Transliteration = "hai",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἐκκλησίαι", Transliteration = "ekklēsiai",
                            Gloss = "churches",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "πᾶσαι", Transliteration = "pasai",
                            Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou",
                                    Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of Christ"
                        }
                    },
                    Translation = "all the churches of Christ"
                }
            },
            Translation = "All the churches of Christ greet you."
        }
    };
}

/*
Constructions Identified:
- APPOS: v9 (τὸν συνεργὸν ἡμῶν), v10 (τὸν δόκιμον), v11 (τὸν συγγενῆ μου), v13 (τὸν ἐκλεκτόν), v15 (τὴν ἀδελφὴν αὐτοῦ).
- PREP_PHRASE as attributive: v9 (ἐν Χριστῷ), v10 (ἐν Χριστῷ), v11 (ἐν κυρίῳ), v13 (ἐν κυρίῳ).
- REL_CLAUSE (implied or with participle): v11 (ὄντας ἐν κυρίῳ), v12 (κοπιώσας ἐν κυρίῳ).
- REL_CLAUSE (with relative pronoun): v12 (ἥτις ... ἐκοπίασεν).
- Generic substantive use of article + prepositional phrase: v10 (τοὺς ἐκ τῶν Ἀριστοβούλου), v11 (τοὺς ἐκ τῶν Ναρκίσσου).
*/
