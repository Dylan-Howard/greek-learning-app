private static List<object> GetChapter10()
{
    // 1 Corinthians 10:25-27
    return new List<object>
    {
        // Verse 25
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
                        new Word { Greek = "Πᾶν", Transliteration = "Pan",
                            Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en",
                                            Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "μακέλλῳ", Transliteration = "makellō",
                                            Gloss = "meat market",
                                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "in the meat market"
                                },
                                new Word { Greek = "πωλούμενον", Transliteration = "pōloumenon",
                                    Gloss = "being sold",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "N", "S" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "being sold"
                        }
                    },
                    Translation = "Everything that is sold in the meat market"
                },
                new Word { Greek = "ἐσθίετε", Transliteration = "esthiete",
                    Gloss = "eat",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μηδὲν", Transliteration = "mēden",
                            Gloss = "nothing",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἀνακρίνοντες", Transliteration = "anakrinontes",
                            Gloss = "examining",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "asking no questions"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia",
                            Gloss = "through",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "συνείδησιν", Transliteration = "syneidēsin",
                                    Gloss = "conscience",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the conscience"
                        }
                    },
                    Translation = "for the sake of conscience"
                }
            },
            Translation = "Eat whatever is sold in the meat market without raising any question on the ground of conscience."
        },

        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "κυρίου", Transliteration = "kyriou",
                            Gloss = "Lord",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the Lord's"
                },
                new Word { Greek = "γὰρ", Transliteration = "gar",
                    Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "γῆ", Transliteration = "gē",
                            Gloss = "earth",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the earth"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πλήρωμα", Transliteration = "plērōma",
                            Gloss = "fullness",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῆς", Transliteration = "autēs",
                            Gloss = "of it",
                            GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "the fullness of it"
                }
            },
            Translation = "For “the earth is the Lord's, and the fullness thereof.”"
        },

        // Verse 27
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
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "καλεῖ", Transliteration = "kalei",
                    Gloss = "invites",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas",
                    Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "P" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀπίστων", Transliteration = "apistōn",
                            Gloss = "unbelievers",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "of the unbelievers"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "θέλετε", Transliteration = "thelete",
                    Gloss = "you wish",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "πορεύεσθαι", Transliteration = "poreuesthai",
                    Gloss = "to go",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "INF" },
                    PartOfSpeech = "v" }
            },
            Translation = "If one of the unbelievers invites you and you want to go,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 27)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶν", Transliteration = "pan",
                            Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παρατιθέμενον", Transliteration = "paratithemenon",
                                    Gloss = "being set before",
                                    GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "N", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "ὑμῖν", Transliteration = "hymin",
                                    Gloss = "to you",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "set before you"
                        }
                    },
                    Translation = "whatever is set before you"
                },
                new Word { Greek = "ἐσθίετε", Transliteration = "esthiete",
                    Gloss = "eat",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μηδὲν", Transliteration = "mēden",
                            Gloss = "nothing",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἀνακρίνοντες", Transliteration = "anakrinontes",
                            Gloss = "examining",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "asking no questions"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia",
                            Gloss = "through",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "συνείδησιν", Transliteration = "syneidēsin",
                                    Gloss = "conscience",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the conscience"
                        }
                    },
                    Translation = "for the sake of conscience"
                }
            },
            Translation = "eat whatever is set before you without raising any question on the ground of conscience."
        }
    };
}

/*
Constructions identified:
- PTCP (attributive): 10:25 (πωλούμενον), 10:27 (παρατιθέμενον)
- PTCP (adverbial/manner): 10:25, 10:27 (ἀνακρίνοντες)
- COND_CLAUSE (1st class): 10:27 (εἴ τις καλεῖ...)
*/
