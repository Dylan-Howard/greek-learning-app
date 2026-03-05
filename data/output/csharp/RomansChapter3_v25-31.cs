private static List<object> GetChapter3()
{
    // Romans 3:25-31
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "whom",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "προέθετο", Transliteration = "proetheto", Gloss = "set forth",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἱλαστήριον", Transliteration = "hilastērion", Gloss = "propitiation",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "as a propitiation"
                },
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
                                new Word { Greek = "πίστεως", Transliteration = "pisteōs", Gloss = "faith",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "faith"
                        }
                    },
                    Translation = "through faith"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "αἵματι", Transliteration = "haimati", Gloss = "blood",
                                    GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "his blood"
                        }
                    },
                    Translation = "in his blood"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔνδειξιν", Transliteration = "endeixin", Gloss = "demonstration",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "δικαιοσύνης", Transliteration = "dikaiosynēs", Gloss = "righteousness",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                            PartOfSpeech = "pron" }
                                    },
                                    Translation = "of his righteousness"
                                }
                            },
                            Translation = "a demonstration of his righteousness"
                        }
                    },
                    Translation = "to show his righteousness"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because of",
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
                                new Word { Greek = "πάρεσιν", Transliteration = "paresin", Gloss = "passing over",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "προγεγονότων", Transliteration = "progegonotōn", Gloss = "previously committed",
                                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "GEN", "N", "P" },
                                            PartOfSpeech = "v" },
                                        new Word { Greek = "ἁμαρτημάτων", Transliteration = "hamartēmatōn", Gloss = "sins",
                                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of formerly committed sins"
                                }
                            },
                            Translation = "the passing over of sins previously committed"
                        }
                    },
                    Translation = "because of the passing over of former sins"
                }
            },
            Translation = "whom God set forth as a propitiation through faith in his blood, to show his righteousness, because of the passing over of formerly committed sins"
        },
        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἀνοχῇ", Transliteration = "anochē", Gloss = "forbearance",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "the forbearance of God"
                        }
                    },
                    Translation = "in the forbearance of God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "for",
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
                                new Word { Greek = "ἔνδειξιν", Transliteration = "endeixin", Gloss = "demonstration",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "δικαιοσύνης", Transliteration = "dikaiosynēs", Gloss = "righteousness",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                                            PartOfSpeech = "pron" }
                                    },
                                    Translation = "of his righteousness"
                                }
                            },
                            Translation = "the demonstration of his righteousness"
                        }
                    },
                    Translation = "for the demonstration of his righteousness"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now",
                                    GrammarCodes = new List<string> { "ADV" },
                                    PartOfSpeech = "adv" },
                                new Word { Greek = "καιρῷ", Transliteration = "kairō", Gloss = "time",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the present time"
                        }
                    },
                    Translation = "at the present time"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "be",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "δίκαιον", Transliteration = "dikaion", Gloss = "just",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "δικαιοῦντα", Transliteration = "dikaiounta", Gloss = "justifying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the [one]",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "πίστεως", Transliteration = "pisteōs", Gloss = "faith",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of faith in Jesus"
                                }
                            },
                            Translation = "the one who has faith in Jesus"
                        }
                    },
                    Translation = "so that he might be just and the justifier of the one who has faith in Jesus"
                }
            },
            Translation = "It was to show his righteousness at the present time, so that he might be just and the justifier of the one who has faith in Jesus."
        },
        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ποῦ", Transliteration = "Pou", Gloss = "where",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then",
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
                        new Word { Greek = "καύχησις", Transliteration = "kauchēsis", Gloss = "boasting",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the boasting"
                }
            },
            Translation = "Where then is boasting?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐξεκλείσθη", Transliteration = "exekleisthē", Gloss = "it was excluded",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "It is excluded."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
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
                        new Word { Greek = "ποίου", Transliteration = "poiou", Gloss = "what kind of",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "law",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "what kind of law"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "N", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἔργων", Transliteration = "ergōn", Gloss = "works",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "of works"
                }
            },
            Translation = "By what kind of law? By a law of works?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐχί", Transliteration = "ouchi", Gloss = "no",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but",
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
                                new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "law",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "πίστεως", Transliteration = "pisteōs", Gloss = "of faith",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the law of faith"
                        }
                    },
                    Translation = "through the law of faith"
                }
            },
            Translation = "No, but through the law of faith."
        },
        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λογιζόμεθα", Transliteration = "logizometha", Gloss = "we hold",
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δικαιοῦσθαι", Transliteration = "dikaiousthai", Gloss = "to be justified",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "INF" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "πίστει", Transliteration = "pistei", Gloss = "by faith",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἄνθρωπον", Transliteration = "anthrōpon", Gloss = "a man",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "that a man is justified by faith"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χωρὶς", Transliteration = "chōris", Gloss = "apart from",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἔργων", Transliteration = "ergōn", Gloss = "works",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "of law",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "works of law"
                        }
                    },
                    Translation = "apart from works of the law"
                }
            },
            Translation = "For we hold that one is justified by faith apart from works of the law."
        },
        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰουδαίων", Transliteration = "Ioudaiōn", Gloss = "of Jews",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "[the God] of Jews"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "God"
                },
                new Word { Greek = "μόνον", Transliteration = "monon", Gloss = "only",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                    PartOfSpeech = "adj" }
            },
            Translation = "Or is God the God of Jews only?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐχὶ", Transliteration = "ouchi", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐθνῶν", Transliteration = "ethnōn", Gloss = "of Gentiles",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "of Gentiles"
                }
            },
            Translation = "Is he not the God of Gentiles also?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ναὶ", Transliteration = "nai", Gloss = "yes",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐθνῶν", Transliteration = "ethnōn", Gloss = "of Gentiles",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "of Gentiles"
                }
            },
            Translation = "Yes, of Gentiles also,"
        },
        // Verse 30
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἴπερ", Transliteration = "eiper", Gloss = "since",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "εἷς", Transliteration = "heis", Gloss = "one",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "God"
                }
            },
            Translation = "since God is one"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "who",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "δικαιώσει", Transliteration = "dikaiōsei", Gloss = "will justify",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περιτομὴν", Transliteration = "peritomēn", Gloss = "circumcision",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "πίστεως", Transliteration = "pisteōs", Gloss = "faith",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "by faith"
                        }
                    },
                    Translation = "the circumcised by faith"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀκροβυστίαν", Transliteration = "akrobystian", Gloss = "uncircumcision",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
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
                                        new Word { Greek = "πίστεως", Transliteration = "pisteōs", Gloss = "faith",
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "faith"
                                }
                            },
                            Translation = "through faith"
                        }
                    },
                    Translation = "the uncircumcised through faith"
                }
            },
            Translation = "who will justify the circumcised by faith and the uncircumcised through faith"
        },
        // Verse 31
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
                        new Word { Greek = "νόμον", Transliteration = "nomon", Gloss = "law",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "law"
                },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "καταργοῦμεν", Transliteration = "katargoumen", Gloss = "we nullify",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" },
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
                                new Word { Greek = "πίστεως", Transliteration = "pisteōs", Gloss = "faith",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "faith"
                        }
                    },
                    Translation = "through this faith"
                }
            },
            Translation = "Do we then overthrow the law by this faith?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "γένοιτο", Transliteration = "genoito", Gloss = "may it be",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "OPT", "3P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "By no means!"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "νόμον", Transliteration = "nomon", Gloss = "law",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "law"
                },
                new Word { Greek = "ἱστάνομεν", Transliteration = "histanomen", Gloss = "we establish",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" },
                    PartOfSpeech = "v" }
            },
            Translation = "On the contrary, we uphold the law."
        }
    };
}

/*
Identified Constructions:
- REL_CLAUSE: v25 (modifying the implied object of v24), v30 (ὃς δικαιώσει)
- INF_PHRASE: v26 (εἰς τὸ εἶναι), v28 (δικαιοῦσθαι)
- COND_CLAUSE: v30 (εἴπερ)
*/
