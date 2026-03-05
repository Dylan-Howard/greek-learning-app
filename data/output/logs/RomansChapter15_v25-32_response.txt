private static List<object> GetChapter15()
{
    // Romans 15:25-32
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Νυνὶ", Transliteration = "Nyni", Gloss = "now",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "πορεύομαι", Transliteration = "poreuomai", Gloss = "I am going",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Ἰερουσαλὴμ", Transliteration = "Ierousalēm", Gloss = "Jerusalem",
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
                        new Word { Greek = "διακονῶν", Transliteration = "diakonōn", Gloss = "ministering",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἁγίοις", Transliteration = "hagiois", Gloss = "saints",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "to the saints"
                        }
                    },
                    Translation = "ministering to the saints"
                }
            },
            Translation = "But now I am going to Jerusalem, ministering to the saints."
        },

        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εὐδόκησαν", Transliteration = "eudokēsan", Gloss = "were pleased",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Μακεδονία", Transliteration = "Makedonia", Gloss = "Macedonia",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "Ἀχαΐα", Transliteration = "Achaia", Gloss = "Achaia",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Macedonia and Achaia"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κοινωνίαν", Transliteration = "koinōnian", Gloss = "contribution",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τινὰ", Transliteration = "tina", Gloss = "a certain",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" },
                                    PartOfSpeech = "part" }
                            },
                            Translation = "a certain contribution"
                        },
                        new Word { Greek = "ποιήσασθαι", Transliteration = "poiēsasthai", Gloss = "to make",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "πτωχοὺς", Transliteration = "ptōchous", Gloss = "poor",
                                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                                            PartOfSpeech = "adj" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "ἁ
