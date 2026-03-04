private static List<object> GetChapter22()
{
    // Luke 22:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἤγγιζεν", Transliteration = "Ēngizen", Gloss = "was drawing near",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἑορτὴ", Transliteration = "heortē", Gloss = "feast",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀζύμων", Transliteration = "azymōn", Gloss = "unleavened bread",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "of unleavened bread"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the [one]",
                                    GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "λεγομένη", Transliteration = "legomenē", Gloss = "called",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "F", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "πάσχα", Transliteration = "pascha", Gloss = "Passover",
                                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "called the Passover"
                        }
                    },
                    Translation = "the Feast of Unleavened Bread, called the Passover"
                }
            },
            Translation = "Now the Feast of Unleavened Bread, called the Passover, was drawing near."
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐζήτουν", Transliteration = "ezētoun", Gloss = "were seeking",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀρχιερεῖς", Transliteration = "archiereis", Gloss = "chief priests",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γραμματεῖς", Transliteration = "grammateis", Gloss = "scribes",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the chief priests and the scribes"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the [way]",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πῶς", Transliteration = "pōs", Gloss = "how",
                                    GrammarCodes = new List<string> { "ADV" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἀνέλωσιν", Transliteration = "anelōsin", Gloss = "they might kill",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "how they might kill him"
                        }
                    },
                    Translation = "how they might put him to death"
                }
            },
            Translation = "And the chief priests and the scribes were seeking how they might put Him to death,"
        },

        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 2)
                new Word { Greek = "ἐφοβοῦντο", Transliteration = "ephobounto", Gloss = "they were fearing",
                    GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "λαόν", Transliteration = "laon", Gloss = "people",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the people"
                }
            },
            Translation = "for they feared the people."
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Εἰσῆλθεν", Transliteration = "Eisēlthen", Gloss = "entered",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "then",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "σατανᾶς", Transliteration = "satanas", Gloss = "Satan",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Ἰούδαν", Transliteration = "Ioudan", Gloss = "Judas",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the [one]",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "καλούμενον", Transliteration = "kaloumenon", Gloss = "called",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "M", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "Ἰσκαριώτην", Transliteration = "Iskariōtēn", Gloss = "Iscariot",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "called Iscariot"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὄντα", Transliteration = "onta", Gloss = "being",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "of",
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
                                                new Word { Greek = "ἀριθμοῦ", Transliter
