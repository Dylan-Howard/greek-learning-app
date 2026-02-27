private static List<object> GetChapter4()
{
    // Luke 4:41-44
    return new List<object>
    {
        // Verse 41
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐξήρχετο", Transliteration = "exērcheto", Gloss = "to go out",
                    GrammarCodes = new List<string> { "V", "IMPF", "MP", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δαιμόνια", Transliteration = "daimonia", Gloss = "demons",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "demons"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "πολλῶν", Transliteration = "pollōn", Gloss = "many",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "from many"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κραυγάζοντα", Transliteration = "kraugazonta", Gloss = "shouting",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "λέγοντα", Transliteration = "legonta", Gloss = "saying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "εἶ", Transliteration = "ei", Gloss = "are",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "υἱὸς", Transliteration = "hyios", Gloss = "son",
                                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                                    PartOfSpeech = "art" },
                                                new Word { Greek =
