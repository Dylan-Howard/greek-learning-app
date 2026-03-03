private static List<object> GetChapter1()
{
    // Jude 1:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ὑμεῖς", Transliteration = "Hymeis", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀγαπητοί", Transliteration = "agapētoi", Gloss = "beloved",
                            GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "beloved"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μνήσθητε", Transliteration = "mnēsthēte", Gloss = "remember",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "IMP", "2P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ῥημάτων", Transliteration = "rhēmatōn", Gloss = "words",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "προειρημένων", Transliteration = "proeirēmenōn", Gloss = "having been spoken before",
                                            GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "GEN", "N", "P" },
                                            PartOfSpeech = "v" }
                                    },
                                    Translation = "that were spoken before"
                                }
                            },
                            Translation = "the words that were spoken before"
                        }
                    },
                    Translation = "remember the words that were spoken before"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀποστόλων", Transliteration = "apostolōn", Gloss = "apostles",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of our Lord Jesus Christ"
                                }
                            },
                            Translation = "the apostles of our Lord Jesus Christ"
                        }
                    },
                    Translation = "by the apostles of our Lord Jesus Christ"
                }
            },
            Translation = "But you, beloved, remember the words that were spoken before by the apostles of our Lord Jesus Christ."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἔλεγον", Transliteration = "elegon", Gloss = "they were saying",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐσχάτου", Transliteration = "eschatou", Gloss = "last",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "χρόνου", Transliteration = "chronou", Gloss = "time",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the last time"
                        }
                    },
                    Translation = "in the last time"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔσονται", Transliteration = "esontai", Gloss = "there will be",
                            GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἐμπαῖκται", Transliteration = "empaiktai", Gloss = "scoffers",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πορευόμενοι", Transliteration = "poreuomenoi", Gloss = "following",
                                    GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "ἑαυτῶν", Transliteration = "heautōn", Gloss = "their own",
                                                    GrammarCodes = new List<string> {
