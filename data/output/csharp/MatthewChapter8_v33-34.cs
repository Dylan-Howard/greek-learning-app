private static List<object> GetChapter8()
{
    // Matthew 8:33-34
    return new List<object>
    {
        // Verse 33
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "βόσκοντες", Transliteration = "boskontes", Gloss = "ones feeding",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "The herdsmen"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἔφυγον", Transliteration = "ephygon", Gloss = "fled",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "The herdsmen fled,"
        },
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
                        new Word { Greek = "ἀπελθόντες", Transliteration = "apelthontes", Gloss = "having gone",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πόλιν", Transliteration = "polin", Gloss = "city",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "into the city"
                        }
                    },
                    Translation = "having gone into the city"
                },
                new Word { Greek = "ἀπήγγειλαν", Transliteration = "apēngeilan", Gloss = "they told",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "everything",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the [matters]",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "δαιμονιζομένων", Transliteration = "daimonizomenōn", Gloss = "ones being demon-possessed",
                                    GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "GEN", "M", "P" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "of the demon-possessed"
                        }
                    },
                    Translation = "the [matters] of the demon-possessed"
                }
            },
            Translation = "and having gone into the city, they reported everything and what had happened to the demon-possessed."
        },
        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶσα", Transliteration = "pasa", Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πόλις", Transliteration = "polis", Gloss = "city",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "all the city"
                },
                new Word { Greek = "ἐξῆλθεν", Transliteration = "exēlthen", Gloss = "went out",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ὑπάντησιν", Transliteration = "hypantēsin", Gloss = "meeting",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "Jesus"
                        }
                    },
                    Translation = "to meet Jesus"
                }
            },
            Translation = "And behold, all the city went out to meet Jesus,"
        },
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
                        new Word { Greek = "ἰδόντες", Transliteration = "idontes", Gloss = "having seen",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "having seen him"
                },
                new Word { Greek = "παρεκάλεσαν", Transliteration = "parekalesan", Gloss = "they begged",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπως", Transliteration = "hopōs", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μεταβῇ", Transliteration = "metabē", Gloss = "he would depart",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ὁρίων", Transliteration = "horiōn", Gloss = "region",
                                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                                            PartOfSpeech = "pron" }
                                    },
                                    Translation = "their region"
                                }
                            },
                            Translation = "from their region"
                        }
                    },
                    Translation = "that he would depart from their region."
                }
            },
            Translation = "and when they saw him, they begged him that he would depart from their region."
        }
    };
}

/*
Constructions identified:
- Substantival Participle: οἱ βόσκοντες (8:33)
- Adverbial Participle (Temporal): ἀπελθόντες (8:33), ἰδόντες (8:34)
- Substantival Article with Genitive: τὰ τῶν δαιμονιζομένων (8:33)
- Purpose/Content Clause: ὅπως μεταβῇ (8:34)
*/
