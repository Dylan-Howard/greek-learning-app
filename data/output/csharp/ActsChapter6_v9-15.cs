private static List<object> GetChapter6()
{
    // Acts 6:9-15
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀνέστησαν", Transliteration = "anestēsan", Gloss = "to get up", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τινες", Transliteration = "tines", Gloss = "someone", 
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, 
                            PartOfSpeech = "part" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "of", 
                                    GrammarCodes = new List<string> { "PREP" }, 
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, 
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "συναγωγῆς", Transliteration = "synagōgēs", Gloss = "synagogue", 
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, 
                                            PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PTCP" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", 
                                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, 
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "λεγομένης", Transliteration = "legomenēs", Gloss = "say", 
                                                    GrammarCodes = new List<string>
