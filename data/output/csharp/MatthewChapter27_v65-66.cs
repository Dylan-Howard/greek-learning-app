private static List<object> GetChapter27()
{
    // Matthew 27:65-66
    return new List<object>
    {
        // Verse 65
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔφη", Transliteration = "ephē",
                    Gloss = "said",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois",
                            Gloss = "to them",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "to them"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Πιλᾶτος", Transliteration = "Pilatos",
                            Gloss = "Pilate",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Pilate"
                }
            },
            Translation = "Pilate said to them,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔχετε", Transliteration = "echete",
                    Gloss = "you have",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κουστωδίαν", Transliteration = "koustōdian",
                            Gloss = "a guard",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "a guard"
                }
            },
            Translation = "\"You have a guard;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὑπάγετε", Transliteration = "hypagete",
                    Gloss = "go",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "go,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀσφαλίσασθε", Transliteration = "asphalisasthe",
                    Gloss = "make [it] secure",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs",
                            Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "οἴδατε", Transliteration = "oidate",
                            Gloss = "you know",
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "as you know how.\""
                }
            },
            Translation = "make it secure as you know how.\""
        },

        // Verse 66
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
                        new Word { Greek = "οἱ", Transliteration = "hoi",
                            Gloss = "the [ones]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "πορευθέντες", Transliteration = "poreuthentes",
                            Gloss = "having gone",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "But they, having gone,"
                },
                new Word { Greek = "ἠσφαλίσαντο", Transliteration = "ēsphalisanto",
                    Gloss = "made secure",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" },
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
                        new Word { Greek = "τάφον", Transliteration = "taphon",
                            Gloss = "tomb",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the tomb,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σφραγίσαντες", Transliteration = "sphragisantes",
                            Gloss = "sealing",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
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
                                new Word { Greek = "λίθον", Transliteration = "lithon",
                                    Gloss = "stone",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the stone"
                        }
                    },
                    Translation = "sealing the stone"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κουστωδίας", Transliteration = "koustōdias",
                                    Gloss = "guard",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the guard"
                        }
                    },
                    Translation = "with the guard"
                }
            },
            Translation = "But they went and made the tomb secure by sealing the stone and setting the guard."
        }
    };
}

/*
Constructions identified:
- Substantive Participle: οἱ δὲ πορευθέντες (v. 66)
- Attendant Circumstance / Manner Participle: σφραγίσαντες (v. 66)
- Imperative sequence: ἔχετε... ὑπάγετε... ἀσφαλίσασθε (v. 65)
*/
