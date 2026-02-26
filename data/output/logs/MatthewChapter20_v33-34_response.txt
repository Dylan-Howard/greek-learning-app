private static List<object> GetChapter20()
{
    // Matthew 20:33-34
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγουσιν", Transliteration = "legousin",
                    Gloss = "they say",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō",
                    Gloss = "to him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "κύριε", Transliteration = "kyrie",
                    Gloss = "Lord",
                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina",
                            Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἀνοιγῶσιν", Transliteration = "anoigōsin",
                            Gloss = "may be opened",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὀφθαλμοὶ", Transliteration = "ophthalmoi",
                                    Gloss = "eyes",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn",
                                    Gloss = "of us",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "our eyes"
                        }
                    },
                    Translation = "that our eyes may be opened"
                }
            },
            Translation = "They say to him, 'Lord, that our eyes may be opened.'"
        },
        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σπλαγχνισθεὶς", Transliteration = "splanchnistheis",
                            Gloss = "having compassion",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having compassion"
                },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous",
                            Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                },
                new Word { Greek = "ἥψατο", Transliteration = "hēpsato",
                    Gloss = "touched",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὀμμάτων", Transliteration = "ommatōn",
                            Gloss = "eyes",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn",
                            Gloss = "of them",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "their eyes"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εὐθέως", Transliteration = "eutheōs",
                    Gloss = "immediately",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἀνέβλεψαν", Transliteration = "aneblepsan",
                    Gloss = "they recovered sight",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἠκολούθησαν", Transliteration = "ēkolouthēsan",
                    Gloss = "they followed",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō",
                    Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "And Jesus, moved with compassion, touched their eyes, and immediately they recovered their sight and followed him."
        }
    };
}

/*
Constructions identified:
- VOC (Vocative address): "κύριε" in 20:33
- PURPOSE_CLAUSE (ἵνα + subjunctive): 20:33
- PTCP (Adverbial participle): "σπλαγχνισθεὶς" in 20:34
*/
