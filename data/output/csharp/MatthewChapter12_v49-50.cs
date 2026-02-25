private static List<object> GetChapter12()
{
    // Matthew 12:49-50
    return new List<object>
    {
        // Verse 49
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκτείνας", Transliteration = "ekteinas", Gloss = "stretching out",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "χεῖρα", Transliteration = "cheira", Gloss = "hand",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "his hand"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "toward",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "μαθητὰς", Transliteration = "mathētas", Gloss = "disciples",
                                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                            PartOfSpeech = "pron" }
                                    },
                                    Translation = "his disciples"
                                }
                            },
                            Translation = "toward his disciples"
                        }
                    },
                    Translation = "stretching out his hand toward his disciples"
                },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "Behold",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "interj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "μήτηρ", Transliteration = "mētēr", Gloss = "mother",
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "my mother"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "my brothers"
                        }
                    },
                    Translation = "Behold, my mother and my brothers!"
                }
            },
            Translation = "And stretching out his hand toward his disciples, he said, 'Behold, my mother and my brothers!'"
        },

        // Verse 50
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅστις", Transliteration = "hostis", Gloss = "whoever",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "[ever]",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "part" },
                        new Word { Greek = "ποιήσῃ", Transliteration = "poiēsē", Gloss = "does",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θέλημα", Transliteration = "thelēma", Gloss = "will",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "πατρός", Transliteration = "patros", Gloss = "Father",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                                            PartOfSpeech = "pron" }
                                    },
                                    Translation = "of my Father"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the [one]",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                                    GrammarCodes = new List<string> { "PREP" },
                                                    PartOfSpeech = "prep" },
                                                new Word { Greek = "οὐρανοῖς", Transliteration = "ourano
