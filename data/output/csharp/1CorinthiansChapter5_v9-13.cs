private static List<object> GetChapter5()
{
    // 1 Corinthians 5:9-13
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἔγραψα", Transliteration = "Egrapsa", Gloss = "I wrote", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, 
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐπιστολῇ", Transliteration = "epistolē", Gloss = "letter", 
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the letter"
                        }
                    },
                    Translation = "in the letter"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", 
                            GrammarCodes = new List<string> { "ADV" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "συναναμίγνυσθαι", Transliteration = "synanamignysthai", Gloss = "to associate with", 
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "INF" }, 
                            PartOfSpeech = "v" },
                        new Word { Greek = "πόρνοις", Transliteration = "pornois", Gloss = "sexually immoral people", 
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "not to associate with sexually immoral people"
                }
            },
            Translation = "I wrote to you in my letter not to associate with sexually immoral people"
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "πάντως", Transliteration = "pantōs", Gloss = "at all", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "πόρνοις", Transliteration = "pornois", Gloss = "sexually immoral", 
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, 
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", 
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κόσμου", Transliteration = "kosmou", Gloss = "world", 
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, 
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τούτου", Transliteration = "toutou", Gloss = "this", 
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, 
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "of this world"
                        }
                    },
                    Translation = "the sexually immoral of this world"
                },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "πλεονέκταις", Transliteration = "pleonektais", Gloss = "greedy", 
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "the greedy"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἅρπαξιν", Transliteration = "harpaxin", Gloss = "swindlers", 
                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, 
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἰδωλολάτραις", Transliteration = "eidōlolatrais", Gloss = "idolaters", 
                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, 
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπεὶ", Transliteration = "epei", Gloss = "since", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ὠφείλετε", Transliteration = "ōpheilete", Gloss = "you would have", 
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "2P", "P" }, 
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἄρα", Transliteration = "ara", Gloss = "then", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "out of", 
                                            GrammarCodes = new List<string> { "PREP" }, 
                                            PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", 
                                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, 
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "κόσμου", Transliteration = "kosmou", Gloss = "world", 
                                                    GrammarCodes = new List<string> {
