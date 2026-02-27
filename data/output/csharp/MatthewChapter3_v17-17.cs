private static List<object> GetChapter3()
{
    // Matthew 3:17-17
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou",
                    Gloss = "behold",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φωνὴ", Transliteration = "phōnē",
                            Gloss = "a voice",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek",
                                    Gloss = "out of",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τῶν", Transliteration = "tōn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "οὐρανῶν", Transliteration = "ouranōn",
                                    Gloss = "heavens",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "from the heavens"
                        }
                    },
                    Translation = "a voice from the heavens"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγουσα", Transliteration = "legousa",
                            Gloss = "saying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "F", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οὗτός", Transliteration = "houtos",
                                    Gloss = "This",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "ἐστιν", Transliteration = "estin",
                                    Gloss = "is",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὁ", Transliteration = "ho",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "υἱός", Transliteration = "huios",
                                            Gloss = "Son",
                                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "μου", Transliteration = "mou",
                                            Gloss = "of me",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                                            PartOfSpeech = "pron" },
                                        new Word { Greek = "ὁ", Transliteration = "ho",
                                            Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἀγαπητός", Transliteration = "agapētos",
                                            Gloss = "beloved",
                                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                                            PartOfSpeech = "adj" }
                                    },
                                    Translation = "my beloved Son"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                                    Content = new List<object>
                                    {
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἐν", Transliteration
