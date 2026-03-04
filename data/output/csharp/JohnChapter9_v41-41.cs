private static List<object> GetChapter9()
{
    // John 9:41-41
    return new List<object>
    {
        // Verse 41
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen",
                    Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois",
                    Gloss = "to them",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous",
                            Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei",
                            Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "τυφλοὶ", Transliteration = "typhloi",
                            Gloss = "blind",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἦτε", Transliteration = "ēte",
                            Gloss = "you were",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "If you were blind"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk",
                    Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἂν", Transliteration = "an",
                    Gloss = "[potential particle]",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "εἴχετε", Transliteration = "eichete",
                    Gloss = "you would have",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἁμαρτίαν", Transliteration = "hamartian",
                            Gloss = "sin",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "sin"
                }
            },
            Translation = "Jesus said to them, 'If you were blind, you would have no sin;'"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "νῦν", Transliteration = "nyn",
                    Gloss = "now",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "λέγετε", Transliteration = "legete",
                    Gloss = "you say",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti",
                            Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "βλέπομεν", Transliteration = "blepomen",
                            Gloss = "we see",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "that 'We see'"
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
                        new Word { Greek = "ἁμαρτία", Transliteration = "hamartia",
                            Gloss = "sin",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn",
                            Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "your sin"
                },
                new Word { Greek = "μένει", Transliteration = "menei",
                    Gloss = "remains",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "but now you say, 'We see,' your sin remains."
        }
    };
}

// Constructions identified:
// Second Class Conditional (εἰ + imperfect ... ἂν + imperfect): John 9:41
