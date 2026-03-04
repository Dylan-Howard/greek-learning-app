private static List<object> GetChapter10()
{
    // John 10:33-40
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀπεκρίθησαν", Transliteration = "apekrithēsan", Gloss = "answered", Grammar_codes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", Grammar_codes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰουδαῖοι", Transliteration = "Ioudaioi", Gloss = "Jews", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the Jews"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "for", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καλοῦ", Transliteration = "kalou", Gloss = "good", Grammar_codes = new List<string> { "ADJ", "GEN", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἔργου", Transliteration = "ergou", Gloss = "work", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a good work"
                        }
                    },
                    Translation = "for a good work"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "λιθάζομέν", Transliteration = "lithazomen", Gloss = "we stone", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "σε", Transliteration = "se", Gloss = "you", Grammar_codes = new List<string> { "PRON", "ACC", "2P", "S" }, PartOfSpeech = "pron" },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "for", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "βλασφημίας", Transliteration = "blasphēmias", Gloss = "blasphemy", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "for blasphemy"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "because", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", Grammar_codes = new List<string> { "PRON", "NOM", "2P", "S" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἄνθρωπος", Transliteration = "anthrōpos", Gloss = "a man", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ὢν", Transliteration = "ōn", Gloss = "being", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "being a man"
                        },
                        new Word { Greek = "ποιεῖς", Transliteration = "poieis", Gloss = "make", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "σεαυτὸν", Transliteration = "seauton", Gloss = "yourself", Grammar_codes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "θεόν", Transliteration = "theon", Gloss = "God", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "because you, being a man, make yourself God"
                }
            },
            Translation = "The Jews answered him, \"It is not for a good work that we are going to stone you but for blasphemy, because you, being a man, make yourself God.\""
        },

        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀπεκρίθη", Transliteration = "apekrithē", Gloss = "answered", Grammar_codes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", Grammar_codes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Jesus"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is it", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γεγραμμένον", Transliteration = "gegrammenon", Gloss = "written", Grammar_codes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", Grammar_codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "νόμῳ", Transliteration = "nomō", Gloss = "law", Grammar_codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", Grammar_codes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "your law"
                        }
                    },
                    Translation = "in your law"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", Grammar_codes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "εἶπα", Transliteration = "eipa", Gloss = "said", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "θεοί", Transliteration = "theoi", Gloss = "gods", Grammar_codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "you are", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "that I said, 'You are gods'?"
                }
            },
            Translation = "Jesus answered them, \"Is it not written in your law, 'I said, you are gods'?\""
        },

        // Verse 35
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
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐκείνους", Transliteration = "ekeinous", Gloss = "them", Grammar_codes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he called", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "θεοὺς", Transliteration = "theous", Gloss = "gods", Grammar_codes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "οὓς", Transliteration = "hous", Gloss = "whom", Grammar_codes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pron" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "λόγος", Transliteration = "logos", Gloss = "word", Grammar_codes = new List<string> { "N
