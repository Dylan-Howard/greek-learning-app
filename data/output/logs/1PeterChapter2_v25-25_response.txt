MCP issues detected. Run /mcp list for status.private static List<object> GetChapter2()
{
    // 1 Peter 2:25
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἦτε", Transliteration = "", Gloss = "you were", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "2P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "γὰρ", Transliteration = "", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ὡς", Transliteration = "", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρόβατα", Transliteration = "", Gloss = "sheep", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "sheep"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "PERIPH" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πλανώμενοι", Transliteration = "", Gloss = "going astray", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "going astray"
                },
                new Word { Greek = "ἀλλ᾽", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐπεστράφητε", Transliteration = "", Gloss = "you have returned", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "νῦν", Transliteration = "", Gloss = "now", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "TSKS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ποιμένα", Transliteration = "", Gloss = "Shepherd", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "ἐπίσκοπον", Transliteration = "", Gloss = "Overseer", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ψυχῶν", Transliteration = "", Gloss = "souls", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "ὑμῶν", Transliteration = "", Gloss = "your", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "of your souls"
                                }
                            },
                            Translation = "the Shepherd and Overseer of your souls"
                        }
                    },
                    Translation = "to the Shepherd and Overseer of your souls"
                }
            },
            Translation = "For you were straying like sheep, but have now returned to the Shepherd and Overseer of your souls."
        }
    };
}

// Constructions identified:
// 1 Peter 2:25 - PERIPH: ἦτε ... πλανώμενοι (imperfect periphrastic)
// 1 Peter 2:25 - TSKS: τὸν ποιμένα καὶ ἐπίσκοπον (Granville-Sharp: Shepherd and Overseer)
