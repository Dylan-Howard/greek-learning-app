private static List<object> GetChapter6()
{
    // Matthew 6:33-34
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ζητεῖτε", Transliteration = "zēteite",
                    Gloss = "seek",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "πρῶτον", Transliteration = "prōton",
                    Gloss = "first",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "βασιλείαν", Transliteration = "basileian",
                            Gloss = "kingdom",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou",
                                    Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of God"
                        }
                    },
                    Translation = "the kingdom of God"
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
                        new Word { Greek = "δικαιοσύνην", Transliteration = "dikaiosynēn",
                            Gloss = "righteousness",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou",
                            Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "his righteousness"
                }
            },
            Translation = "But seek first the kingdom of God and his righteousness"
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
                        new Word { Greek = "ταῦτα", Transliteration = "tauta",
                            Gloss = "these",
                            GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "πάντα", Transliteration = "panta",
                            Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "all these things"
                },
                new Word { Greek = "προστεθήσεται", Transliteration = "prostethēsetai",
                    Gloss = "will be added",
                    GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin",
                    Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "pron" }
            },
            Translation = "and all these things will be added to you"
        },
        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Μὴ", Transliteration = "Mē",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "part" },
                new Word { Greek = "οὖν", Transliteration = "oun",
                    Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "μεριμνήσητε", Transliteration = "merimnēsēte",
                    Gloss = "be anxious",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis",
                            Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "αὔριον", Transliteration = "aurion",
                                    Gloss = "tomorrow",
                                    GrammarCodes = new List<string> { "ADV" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "tomorrow"
                        }
                    },
                    Translation = "about tomorrow"
                }
            },
            Translation = "Therefore do not be anxious about tomorrow"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
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
                new Word { Greek = "αὔριον", Transliteration = "aurion",
                    Gloss = "tomorrow",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "μεριμνήσει", Transliteration = "merimnēsei",
                    Gloss = "will be anxious",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἑαυτῆς", Transliteration = "heautēs",
                    Gloss = "for itself",
                    GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" },
                    PartOfSpeech = "pron" }
            },
            Translation = "for tomorrow will be anxious for itself"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀρκετὸν", Transliteration = "arketon",
                    Gloss = "sufficient",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἡμέρᾳ", Transliteration = "hēmera",
                            Gloss = "day",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "for the day"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κακία", Transliteration = "kakia",
                            Gloss = "evil",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῆς", Transliteration = "autēs",
                            Gloss = "of it",
                            GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "its own trouble"
                }
            },
            Translation = "Sufficient for the day is its own trouble"
        }
    };
}

/*
Constructions identified:
- Substantive use of adverb: ἡ αὔριον (6:34)
- Predicate adjective: ἀρκετὸν (6:34)
- Dative of reference/interest: τῇ ἡμέρᾳ (6:34)
*/
