private static List<object> GetChapter12()
{
    // Acts 12:25-25
    return new List<object>
    {
        // Verse 25
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
                        new Word { Greek = "Βαρναβᾶς", Transliteration = "Barnabas", 
                            Gloss = "Barnabas", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, 
                            PartOfSpeech = "n" },
                        new Word { Greek = "δὲ", Transliteration = "de", 
                            Gloss = "but", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", 
                            Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Word { Greek = "Σαῦλος", Transliteration = "Saulos", 
                            Gloss = "Saul", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "And Barnabas and Saul"
                },
                new Word { Greek = "ὑπέστρεψαν", Transliteration = "hypestrepsan", 
                    Gloss = "returned", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, 
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
                        new Word { Greek = "Ἰερουσαλὴμ", Transliteration = "Ierousalēm", 
                            Gloss = "Jerusalem", 
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "to Jerusalem"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πληρώσαντες", Transliteration = "plērōsantes", 
                            Gloss = "having fulfilled", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, 
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
                                new Word { Greek = "διακονίαν", Transliteration = "diakonian", 
                                    Gloss = "ministry", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the ministry"
                        }
                    },
                    Translation = "having fulfilled the ministry"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συμπαραλαβόντες", Transliteration = "symparalabontes", 
                            Gloss = "having taken along", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, 
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Ἰωάννην", Transliteration = "Iōannēn", 
                                    Gloss = "John", 
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, 
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", 
                                            Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, 
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἐπικληθέντα", Transliteration = "epiklēthenta", 
                                            Gloss = "who was surnamed", 
                                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "ACC", "M", "S" }, 
                                            PartOfSpeech = "v" },
                                        new Word { Greek = "Μᾶρκον", Transliteration = "Markon", 
                                            Gloss = "Mark", 
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, 
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the one surnamed Mark"
                                }
                            },
                            Translation = "John who was surnamed Mark"
                        }
                    },
                    Translation = "taking along John who was surnamed Mark"
                }
            },
            Translation = "And Barnabas and Saul returned to Jerusalem, having fulfilled the ministry, taking along with them John, who was surnamed Mark."
        }
    };
}

// Constructions identified:
// None (TSKS not applicable without shared article; Attributive participle used in v25).
