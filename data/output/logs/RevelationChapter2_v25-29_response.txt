private static List<object> GetChapter2()
{
    // Revelation 2:25-29
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πλὴν", Transliteration = "plēn",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho",
                            Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἔχετε", Transliteration = "echete",
                            Gloss = "you have",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "what you have"
                },
                new Word { Greek = "κρατήσατε", Transliteration = "kratēsate",
                    Gloss = "hold fast",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄχρις", Transliteration = "achris",
                            Gloss = "until",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "οὗ", Transliteration = "hou",
                            Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἂν", Transliteration = "an",
                            Gloss = "[particle]",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἥξω", Transliteration = "hēxō",
                            Gloss = "I come",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "until I come"
                }
            },
            Translation = "Only hold fast what you have until I come."
        },
        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai",
                    Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho",
                                    Gloss = "the [one]",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "νικῶν", Transliteration = "nikōn",
                                    Gloss = "overcoming",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "the one who overcomes"
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
                                new Word { Greek = "ὁ", Transliteration = "ho",
                                    Gloss = "the [one]",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "τηρῶν", Transliteration = "tērōn",
                                    Gloss = "keeping",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "the one who keeps"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἄχρι", Transliteration = "achri",
                                    Gloss = "until",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τέλους", Transliteration = "telous",
                                    Gloss = "end",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "until the end"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἔργα", Transliteration = "erga",
                                    Gloss = "works",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou",
                                    Gloss = "of me",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "my works"
                        }
                    },
                    Translation = "the one who overcomes and keeps my works until the end"
                },
                new Word { Greek = "δώσω", Transliteration = "dōsō",
                    Gloss = "I will give",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō",
                    Gloss = "to him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξουσίαν", Transliteration = "exousian",
                            Gloss = "authority",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "authority"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi",
                            Gloss = "over",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῶν", Transliteration = "tōn",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἐθνῶν", Transliteration = "ethnōn",
                            Gloss = "nations",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "over the nations"
                }
            },
            Translation = "And the one who overcomes and keeps my works until the end, I will give him authority over the nations,"
        },
        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ποιμανεῖ", Transliteration = "poimanei",
                    Gloss = "he will shepherd",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοὺς", Transliteration = "autous",
                    Gloss = "them",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ῥάβδῳ", Transliteration = "rhabdō",
                            Gloss = "a rod",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "σιδηρᾷ", Transliteration = "sidēra",
                            Gloss = "iron",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "with a rod of iron"
                }
            },
            Translation = "and he will shepherd them with a rod of iron,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὡς", Transliteration = "hōs",
                    Gloss = "as",
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
                        new Word { Greek = "σκεύη", Transliteration = "skeuē",
                            Gloss = "vessels",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τὰ", Transliteration = "ta",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κεραμικὰ", Transliteration = "keramika",
                            Gloss = "potter's",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the potter's vessels"
                },
                new Word { Greek = "συντρίβεται", Transliteration = "syntribetai",
                    Gloss = "are broken to pieces",
                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "as the potter's vessels are broken to pieces,"
        },
        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὡς", Transliteration = "hōs",
                    Gloss = "as",
                    GrammarCodes = new List<string> { "ADJ" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "κἀγὼ", Transliteration = "kagō",
                    Gloss = "I also",
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "εἴληφα", Transliteration = "eilēpha",
                    Gloss = "have received",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρὰ", Transliteration = "para",
                            Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πατρός", Transliteration = "patros",
                            Gloss = "Father",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou",
                            Gloss = "of me",
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "from my Father"
                }
            },
            Translation = "even as I myself have received from my Father."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "δώσω", Transliteration = "dōsō",
                    Gloss = "I will give",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō",
                    Gloss = "to him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀστέρα", Transliteration = "astera",
                            Gloss = "star",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "τὸν", Transliteration = "ton",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πρωϊνόν", Transliteration = "prōinon",
                            Gloss = "morning",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the morning star"
                }
            },
            Translation = "And I will give him the morning star."
        },
        // Verse 29
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
                        new Word { Greek = "Ὁ", Transliteration = "Ho",
                            Gloss = "The [one]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἔχων", Transliteration = "echōn",
                            Gloss = "having",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "οὖς", Transliteration = "ous",
                            Gloss = "an ear",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "He who has an ear"
                },
                new Word { Greek = "ἀκουσάτω", Transliteration = "akousatō",
                    Gloss = "let him hear",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti",
                            Gloss = "what",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "interj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πνεῦμα", Transliteration = "pneuma",
                                    Gloss = "Spirit",
                                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the Spirit"
                        },
                        new Word { Greek = "λέγει", Transliteration = "legei",
                            Gloss = "says",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ταῖς", Transliteration = "tais",
                                    Gloss = "to the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐκκλησίαις", Transliteration = "ekklēsiais",
                                    Gloss = "churches",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to the churches"
                        }
                    },
                    Translation = "what the Spirit says to the churches"
                }
            },
            Translation = "He who has an ear, let him hear what the Spirit says to the churches."
        }
    };
}

// Identified Constructions:
// DAT_INSTR: v27 (ἐν ῥάβδῳ σιδηρᾷ)
// PTCP: v26 (ὁ νικῶν, ὁ τηρῶν), v29 (Ὁ ἔχων)
