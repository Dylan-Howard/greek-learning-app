private static List<object> GetChapter18()
{
    // Matthew 18:33-35
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἔδει", Transliteration = "edei", Gloss = "was it necessary",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὲ", Transliteration = "se", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "ACC", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλεῆσαι", Transliteration = "eleēsai", Gloss = "to have mercy on",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "to have mercy on"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "σύνδουλόν", Transliteration = "syndoulon", Gloss = "fellow servant",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "your fellow servant"
                }
            },
            Translation = "And should not you also have had mercy on your fellow servant"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κἀγὼ", Transliteration = "kagō", Gloss = "I also",
                            GrammarCodes = new List<string> { "PRON", "NOM", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "I also"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὲ", Transliteration = "se", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "ACC", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "you"
                },
                new Word { Greek = "ἠλέησα", Transliteration = "ēleēsa", Gloss = "had mercy on",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "as I also had mercy on you?"
        },

        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὀργισθεὶς", Transliteration = "orgistheis", Gloss = "being angry",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "being angry"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "lord",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "his lord"
                },
                new Word { Greek = "παρέδωκεν", Transliteration = "paredōken", Gloss = "delivered",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "βασανισταῖς", Transliteration = "basanistais", Gloss = "torturers",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the torturers"
                }
            },
            Translation = "And being angry his lord delivered him to the torturers"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "until",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "which [time]",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "until"
                },
                new Word { Greek = "ἀποδῷ", Transliteration = "apodō", Gloss = "he should pay",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶν", Transliteration = "pan", Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the [debt]",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὀφειλόμενον", Transliteration = "opheilomenon", Gloss = "being owed",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "N", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "all that was owed"
                }
            },
            Translation = "until he should pay all that was owed."
        },

        // Verse 35
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "So",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πατήρ", Transliteration = "patēr", Gloss = "Father",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me",
                            GrammarCodes = new List<string> { "PRON", "GEN", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "οὐράνιος", Transliteration = "ouranios", Gloss = "heavenly",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "my heavenly Father"
                },
                new Word { Greek = "ποιήσει", Transliteration = "poiēsei", Gloss = "will do",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "to you"
                }
            },
            Translation = "So also my heavenly Father will do to you"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἀφῆτε", Transliteration = "aphēte", Gloss = "you forgive",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕκαστος", Transliteration = "hekastos", Gloss = "each [one]",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "each one"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀδελφῷ", Transliteration = "adelphō", Gloss = "brother",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "his brother"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "των", Transliteration = "tōn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "καρδιῶν", Transliteration = "kardiōn", Gloss = "hearts",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "from your hearts."
                }
            },
            Translation = "if each one of you does not forgive his brother from your heart."
        }
    };
}

/*
Constructions identified:
- PTCP (ὀργισθεὶς): Verse 34 (Adverbial participle of manner/circumstance)
- NOUN_PHRASE Substantive PTCP (τὸ ὀφειλόμενον): Verse 34
*/
