private static List<object> GetChapter11()
{
    // 1 Corinthians 11:33-34
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ὥστε", Transliteration = "Hōste",
                    Gloss = "so then",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi",
                            Gloss = "brothers",
                            GrammarCodes = new List<string> { "N", "VOC", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou",
                            Gloss = "my",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "my brothers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συνερχόμενοι", Transliteration = "synerchomenoi",
                            Gloss = "coming together",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis",
                                    Gloss = "to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τὸ", Transliteration = "to",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "φαγεῖν", Transliteration = "phagein",
                                    Gloss = "eat",
                                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "to eat"
                        }
                    },
                    Translation = "when you come together to eat"
                },
                new Word { Greek = "ἐκδέχεσθε", Transliteration = "ekdechesthe",
                    Gloss = "wait for",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἀλλήλους", Transliteration = "allēlous",
                    Gloss = "one another",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                    PartOfSpeech = "conj" }
            },
            Translation = "So then, my brothers, when you come together to eat, wait for one another."
        },
        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴ", Transliteration = "ei",
                            Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "τις", Transliteration = "tis",
                            Gloss = "anyone",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "part" },
                        new Word { Greek = "πεινᾷ", Transliteration = "peina",
                            Gloss = "is hungry",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "if anyone is hungry"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en",
                            Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "οἴκῳ", Transliteration = "oikō",
                            Gloss = "house",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "at home"
                },
                new Word { Greek = "ἐσθιέτω", Transliteration = "esthietō",
                    Gloss = "let him eat",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina",
                            Gloss = "so that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē",
                            Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis",
                                    Gloss = "to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "κρίμα", Transliteration = "krima",
                                    Gloss = "judgment",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "for judgment"
                        },
                        new Word { Greek = "συνέρχησθε", Transliteration = "synerchēsthe",
                            Gloss = "you come together",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "SUBJ", "2P", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "so that you do not come together for judgment"
                }
            },
            Translation = "If anyone is hungry, let him eat at home, so that you do not come together for judgment."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de",
                            Gloss = "but",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "λοιπὰ", Transliteration = "loipa",
                            Gloss = "remaining things",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the other things"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs",
                            Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἂν", Transliteration = "an",
                            Gloss = "whenever",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἔλθω", Transliteration = "elthō",
                            Gloss = "I come",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "when I come"
                },
                new Word { Greek = "διατάξομαι", Transliteration = "diataxomai",
                    Gloss = "I will set in order",
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "1P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "About the other things, I will set them in order when I come."
        }
    };
}

/*
Constructions identified:
- VOC (Vocative address): "ἀδελφοί μου" in v33
- PTCP (Participial phrase): "συνερχόμενοι εἰς τὸ φαγεῖν" in v33
- INF_PHRASE (Articular Infinitive): "εἰς τὸ φαγεῖν" in v33
- COND_CLAUSE (First class condition): "εἴ τις πεινᾷ" in v34
- PURPOSE_CLAUSE (Hina + Subjunctive): "ἵνα μὴ εἰς κρίμα συνέρχησθε" in v34
- TEMP_CLAUSE (Temporal clause with ὡς ἂν): "ὡς ἂν ἔλθω" in v34
*/
