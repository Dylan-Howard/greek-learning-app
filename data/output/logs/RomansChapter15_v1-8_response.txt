private static List<object> GetChapter15()
{
    // Romans 15:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ὀφείλομεν", Transliteration = "Opheilomen", Gloss = "we ought",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis", Gloss = "we",
                            GrammarCodes = new List<string> { "PRON", "NOM", "1P", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δυνατοὶ", Transliteration = "dynatoi", Gloss = "strong",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "we the strong"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀσθενήματα", Transliteration = "asthenēmata", Gloss = "failings",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἀδυνάτων", Transliteration = "adynatōn", Gloss = "weak",
                                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                            PartOfSpeech = "adj" }
                                    },
                                    Translation = "of the weak"
                                }
                            },
                            Translation = "the failings of the weak"
                        },
                        new Word { Greek = "βαστάζειν", Transliteration = "bastazein", Gloss = "to bear",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "to bear the failings of the weak"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "part" },
                new Word { Greek = "ἑαυτοῖς", Transliteration = "heautois", Gloss = "ourselves",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἀρέσκειν", Transliteration = "areskein", Gloss = "to please",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                    PartOfSpeech = "v" }
            },
            Translation = "But we who are strong ought to bear the failings of the weak, and not to please ourselves."
        },

        // Verse 2
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
                        new Word { Greek = "ἕκαστος", Transliteration = "hekastos", Gloss = "each",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us",
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                            PartOfSpeech = "pron" }
                    },
                    Translation = "each of us"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πλησίον", Transliteration = "plēsion", Gloss = "neighbor",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "his neighbor"
                },
                new Word { Greek = "ἀρεσκέτω", Transliteration = "aresketō", Gloss = "let please",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀγαθὸν", Transliteration = "agathon", Gloss = "good",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "what is good"
                        }
                    },
                    Translation = "for his good"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "οἰκοδομήν", Transliteration = "oikodomēn", Gloss = "edification",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to build him up"
                }
            },
            Translation = "Let each of us please his neighbor for his good, to build him up."
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "even",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
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
                        new Word { Greek = "Χριστὸς", Transliteration = "Christos", Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Christ"
                },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "part" },
                new Word { Greek = "ἑαυτῷ", Transliteration = "heautō", Gloss = "himself",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἤρεσεν", Transliteration = "ēresen", Gloss = "pleased",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "as",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it is written",
                            GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "as it is written"
                },
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
                                new Word { Greek = "ὀνειδισμοὶ", Transliteration = "oneidismoi", Gloss = "reproaches",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of those",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ὀνειδιζόντων", Transliteration = "oneidizontōn", Gloss = "reproaching",
                                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "P" },
                                            PartOfSpeech = "v" }
                                    },
                                    Translation = "of those who reproach"
                                }
                            },
                            Translation = "The reproaches of those who reproach"
                        },
                        new Word { Greek = "σε", Transliteration = "se", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἐπέπεσαν", Transliteration = "epepesan", Gloss = "fell",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "upon",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἐμέ", Transliteration = "eme", Gloss = "me",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "upon me"
                        }
                    },
                    Translation = "The reproaches of those who reproached you fell on me."
                }
            },
            Translation = "For Christ did not please himself, but as it is written, “The reproaches of those who reproached you fell on me.”"
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅσα", Transliteration = "hosa", Gloss = "whatever things",
                            GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "προεγράφη", Transliteration = "proegraphē", Gloss = "were written before",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "For whatever was written in former days"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἡμετέραν", Transliteration = "hēmeteran", Gloss = "our",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "διδασκαλίαν", Transliteration = "didaskalian", Gloss = "instruction",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "our instruction"
                        }
                    },
                    Translation = "for our instruction"
                },
                new Word { Greek = "ἐγράφη", Transliteration = "egraphē", Gloss = "was written",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ὑπομονῆς", Transliteration = "hypomonēs", Gloss = "perseverance",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "perseverance"
                                }
                            },
                            Translation = "through perseverance"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "παρακλήσεως", Transliteration = "paraklēseōs", Gloss = "encouragement",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "P" },
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "γραφῶν", Transliteration = "graphōn", Gloss = "Scriptures",
                                                    GrammarCodes = new List<string> { "N", "GEN", "F", "P" },
                               
