private static List<object> GetChapter2()
{
    // Titus 2:9-15
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Δούλους", Transliteration = "", Gloss = "to enslave", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑποτάσσεσθαι", Transliteration = "", Gloss = "to put in subjection", GrammarCodes = new List<string> { "V", "PRES", "PASS", "INF" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἰδίοις", Transliteration = "", Gloss = "one's own", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" },
                                        new Word { Greek = "δεσπόταις", Transliteration = "", Gloss = "master", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "to their own masters"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "πᾶσιν", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "P" }, PartOfSpeech = "adjective" }
                                    },
                                    Translation = "in everything"
                                }
                            },
                            Translation = "to be subject"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εὐαρέστους", Transliteration = "", Gloss = "pleasing", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "εἶναι", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" }
                            },
                            Translation = "to be well-pleasing"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PRT", "NEG" }, PartOfSpeech = "adverb" },
                                new Word { Greek = "ἀντιλέγοντας", Transliteration = "", Gloss = "to speak against", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "not argumentative"
                        },
                        // Verse 10
                        // (continues verse 9)
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "PRT", "NEG" }, PartOfSpeech = "adverb" },
                                new Word { Greek = "νοσφιζομένους", Transliteration = "", Gloss = "to hold back for oneself", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "not pilfering"
                        },
                        new Word { Greek = "ἀλλὰ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πᾶσαν", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adjective" },
                                        new Word { Greek = "πίστιν", Transliteration = "", Gloss = "faith", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "ἀγαθήν", Transliteration = "", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adjective" }
                                    },
                                    Translation = "all good faith"
                                },
                                new Word { Greek = "ἐνδεικνυμένους", Transliteration = "", Gloss = "to show", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "showing all good faith"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἵνα", Transliteration = "", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "κοσμῶσιν", Transliteration = "", Gloss = "to make beautiful", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "verb" },
                                        new Phrase
                                    {
                                        SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                        Content = new List<object>
                                        {
                                            new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                            new Word { Greek = "διδασκαλίαν", Transliteration = "", Gloss = "teaching", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                                            new Phrase
                                            {
                                                SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                                Content = new List<object>
                                                {
                                                    new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                                    new Word { Greek = "τοῦ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                                    new Word { Greek = "σωτῆρος",
