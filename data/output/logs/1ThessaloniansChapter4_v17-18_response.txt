private static List<object> GetChapter4()
{
    // 1 Thessalonians 4:17-18
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔπειτα", Transliteration = "epeita",
                    Gloss = "then",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis",
                            Gloss = "we",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" },
                            PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ζῶντες", Transliteration = "zōntes",
                                    Gloss = "living",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "who are alive"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "περιλειπόμενοι", Transliteration = "perileipomenoi",
                                    Gloss = "remaining",
                                    GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "P" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "who are left"
                        }
                    },
                    Translation = "we who are alive and remain"
                },
                new Word { Greek = "ἅμα", Transliteration = "hama",
                    Gloss = "together",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
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
                new Word { Greek = "ἁρπαγησόμεθα", Transliteration = "harpagēsometha",
                    Gloss = "we will be caught up",
                    GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "1P", "P" },
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
                        new Word { Greek = "νεφέλαις", Transliteration = "nephelais",
                            Gloss = "clouds",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in the clouds"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἀπάντησιν", Transliteration = "apantēsin",
                            Gloss = "meeting",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κυρίου", Transliteration = "kyriou",
                                    Gloss = "Lord",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the Lord"
                        }
                    },
                    Translation = "to meet the Lord"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis",
                            Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἀέρα", Transliteration = "aera",
                            Gloss = "air",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in the air"
                }
            },
            Translation = "Then we who are alive and remain will be caught up together with them in the clouds to meet the Lord in the air."
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
                new Word { Greek = "οὕτως", Transliteration = "houtōs",
                    Gloss = "so",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "πάντοτε", Transliteration = "pantote",
                    Gloss = "always",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὺν", Transliteration = "syn",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "κυρίῳ", Transliteration = "kyriō",
                            Gloss = "Lord",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "with the Lord"
                },
                new Word { Greek = "ἐσόμεθα", Transliteration = "esometha",
                    Gloss = "we will be",
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "1P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "and so we will always be with the Lord."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "RESULT_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ὥστε", Transliteration = "Hōste",
                    Gloss = "Therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "παρακαλεῖτε", Transliteration = "parakaleite",
                    Gloss = "encourage",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἀλλήλους", Transliteration = "allēlous",
                    Gloss = "one another",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "λόγοις", Transliteration = "logois",
                                    Gloss = "words",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τούτοις", Transliteration = "toutois",
                                    Gloss = "these",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "these words"
                        }
                    },
                    Translation = "with these words"
                }
            },
            Translation = "Therefore encourage one another with these words."
        }
    };
}

/*
Constructions identified:
- NOUN_PHRASE (SUBJ): ἡμεῖς οἱ ζῶντες οἱ περιλειπόμενοι (v17) - Complex subject with multiple attributive participles
- GEN_OBJ: τοῦ κυρίου (v17) - Object of the verbal noun ἀπάντησιν
- DAT_INSTR: ἐν τοῖς λόγοις τούτοις (v18) - Instrumental use of preposition ἐν
- RESULT_CLAUSE: Ὥστε παρακαλεῖτε... (v18) - Introduced by Ὥστε
*/
