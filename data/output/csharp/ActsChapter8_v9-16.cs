private static List<object> GetChapter8()
{
    // Acts 8:9-16
    return new List<object>
    {
        // Verse 9
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
                        new Word { Greek = "Ἀνὴρ", Transliteration = "", Gloss = "man",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "δέ", Transliteration = "", Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "τις", Transliteration = "", Gloss = "a certain",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὀνόματι", Transliteration = "", Gloss = "by name",
                                    GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "Σίμων", Transliteration = "", Gloss = "Simon",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "named Simon"
                        }
                    },
                    Translation = "But a certain man named Simon"
                },
                new Word { Greek = "προϋπῆρχεν", Transliteration = "", Gloss = "had previously been",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τῇ", Transliteration = "", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "πόλει", Transliteration = "", Gloss = "city",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "in the city"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μαγεύων", Transliteration = "", Gloss = "practicing sorcery",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἐξιστάνων", Transliteration = "", Gloss = "amazing",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "ἔθνος", Transliteration = "", Gloss = "nation",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                    PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "", Gloss = "of",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "article" },
                                        new Word { Greek = "Σαμαρείας", Transliteration = "", Gloss = "Samaria",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "noun" }
                                    },
                                    Translation = "of Samaria"
                                }
                            },
                            Translation = "the people of Samaria"
                        }
                    },
                    Translation = "practicing sorcery and amazing the people of Samaria"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγων", Transliteration = "", Gloss = "saying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἶναί", Transliteration = "", Gloss = "to be",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                                    PartOfSpeech = "verb" },
                                new Word { Greek = "τινα", Transliteration = "", Gloss = "someone",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                    PartOfSpeech = "pronoun" },
                                new Word { Greek = "ἑαυτὸν", Transliteration = "", Gloss = "himself",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                    PartOfSpeech = "pronoun" },
                                new Word { Greek = "μέγαν", Transliteration = "", Gloss = "great",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adjective" }
                            },
                            Translation = "that he himself was someone great"
                        }
                    },
                    Translation = "saying that he himself was someone great"
                }
            },
            Translation = "But a certain man named Simon had previously practiced sorcery in the city and amazed the people of Samaria, saying that he himself was someone great."
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ᾧ", Transliteration = "", Gloss = "to whom",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "προσεῖχον", Transliteration = "", Gloss = "they paid attention",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "πάντες", Transliteration = "", Gloss = "all",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                    PartOfSpeech = "adjective" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "μικροῦ", Transliteration = "", Gloss = "least",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" },
                            PartOfSpeech = "adjective" }
                    },
                    Translation = "from the least"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "μεγάλου", Transliteration = "", Gloss = "greatest",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" },
                            PartOfSpeech = "adjective" }
                    },
                    Translation = "to the greatest"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "", Gloss = "saying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οὗτός", Transliteration = "", Gloss = "This man",
                                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                                    PartOfSpeech = "pronoun" },
                                new Word { Greek = "ἐστιν", Transliteration = "", Gloss = "is",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                                    PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἡ", Transliteration = "", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                                            PartOfSpeech = "article" },
                                        new Word { Greek = "δύναμις", Transliteration = "", Gloss = "power",
                                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                            PartOfSpeech = "noun" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "", Gloss = "of",
                                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                                    PartOfSpeech = "article" },
                                                new Word { Greek = "θεοῦ", Transliteration = "", Gloss = "God",
                                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S
