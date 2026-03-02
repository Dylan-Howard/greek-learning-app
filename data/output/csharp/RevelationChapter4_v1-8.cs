private static List<object> GetChapter4()
{
    // Revelation 4:1-8
    return new List<object>
    {
        // Verse 1
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
                        new Word { Greek = "Μετὰ", Transliteration = "Meta", Gloss = "after", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "adv" }
                    },
                    Translation = "After these things"
                },
                new Word { Greek = "εἶδον", Transliteration = "eidon", Gloss = "I saw", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θύρα", Transliteration = "thyra", Gloss = "a door", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἠνεῳγμένη", Transliteration = "ēneōgmenē", Gloss = "having been opened", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "a door standing open"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "οὐρανῷ", Transliteration = "ouranō", Gloss = "heaven", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "heaven"
                        }
                    },
                    Translation = "in heaven"
                }
            },
            Translation = "After these things I saw, and behold, a door standing open in heaven."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "φωνὴ", Transliteration = "phōnē", Gloss = "voice", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πρώτη", Transliteration = "prōtē", Gloss = "first", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the first voice"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἣν", Transliteration = "hēn", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἤκουσα", Transliteration = "ēkousa", Gloss = "I heard", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "which I heard"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σάλπιγγος", Transliteration = "salpingos", Gloss = "of a trumpet", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "λαλούσης", Transliteration = "lalousēs", Gloss = "speaking", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "F", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μετ᾽", Transliteration = "met'", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἐμοῦ", Transliteration = "emou", Gloss = "me", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "with me"
                        }
                    },
                    Translation = "like a trumpet speaking with me"
                },
                new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνάβα", Transliteration = "anaba", Gloss = "come up", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὧδε", Transliteration = "hōde", Gloss = "here", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                    },
                    Translation = "Come up here"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δείξω", Transliteration = "deixō", Gloss = "I will show", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἃ", Transliteration = "ha", Gloss = "the things which", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pron" },
                                new Word { Greek = "δεῖ", Transliteration = "dei", Gloss = "it is necessary", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "γενέσθαι", Transliteration = "genesthai", Gloss = "to take place", GrammarCodes = new List<string> { "V", "AOR", "MID", "INF" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "after", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "adv" }
                                    },
                                    Translation = "after these things"
                                }
                            },
                            Translation = "what must take place after these things"
                        }
                    },
                    Translation = "and I will show you what must take place after these things."
                }
            },
            Translation = "And the first voice, which I heard like a trumpet speaking with me, said, 'Come up here, and I will show you what must take place after these things.'"
        },
        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Εὐθέως", Transliteration = "Eutheōs", Gloss = "Immediately", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐγενόμην", Transliteration = "egenomēn", Gloss = "I was", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "πνεύματι", Transliteration = "pneumati", Gloss = "the Spirit", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in the Spirit"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θρόνος", Transliteration = "thronos", Gloss = "a throne", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "a throne"
                },
                new Word { Greek = "ἔκειτο", Transliteration = "ekeito", Gloss = "was set", GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "οὐρανῷ", Transliteration = "ouranō", Gloss = "heaven", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "heaven"
                        }
                    },
                    Translation = "in heaven"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "upon", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θρόνον", Transliteration = "thronon", Gloss = "throne", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the throne"
                        }
                    },
                    Translation = "upon the throne"
                },
                new Word { Greek = "καθήμενος", Transliteration = "kathēmenos", Gloss = "One sitting", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Immediately I was in the Spirit; and behold, a throne was set in heaven, and One sitting upon the throne."
        },
        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the One", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καθήμενος", Transliteration = "kathēmenos", Gloss = "sitting", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the One sitting"
                },
                new Word { Greek = "ὅμοιος", Transliteration = "homoios", Gloss = "like", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁράσει", Transliteration = "horasei", Gloss = "in appearance", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "λίθῳ", Transliteration = "lithō", Gloss = "to a stone", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἰάσπιδι", Transliteration = "iaspidi", Gloss = "jasper", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σαρδίῳ", Transliteration = "sardiō", Gloss = "sardius", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in appearance like a jasper stone and a sardius"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἶρις", Transliteration = "iris", Gloss = "a rainbow", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "a rainbow"
                },
                new Word { Greek = "κυκλόθεν", Transliteration = "kyklothen", Gloss = "around", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θρόνου", Transliteration = "thronou", Gloss = "throne", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the throne"
                },
                new Word { Greek = "ὅμοιος", Transliteration = "homoios", Gloss = "like", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁράσει", Transliteration = "horasei", Gloss = "in appearance", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σμαραγδίνῳ", Transliteration = "smaragdinō", Gloss = "to an emerald", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "in appearance like an emerald"
                }
            },
            Translation = "And the One sitting was in appearance like a jasper stone and a sardius; and there was a rainbow around the throne, in appearance like an emerald."
        },
        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κυκλόθεν", Transliteration = "kyklothen", Gloss = "around", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θρόνου", Transliteration = "thronou", Gloss = "throne", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the throne"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θρόνους", Transliteration = "thronous", Gloss = "thrones", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "εἴκοσι", Transliteration = "eikosi", Gloss = "twenty", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τέσσαρες", Transliteration = "tessares", Gloss = "four", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "twenty-four thrones"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "upon", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "θρόνους", Transliteration = "thronous", Gloss = "thrones", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the thrones"
                        }
                    },
                    Translation = "upon the thrones"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴκοσι", Transliteration = "eikosi", Gloss = "twenty", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τέσσαρας", Transliteration = "tessaras", Gloss = "four", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "πρεσβυτέρους", Transliteration = "presbyterous", Gloss = "elders", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "twenty-four elders"
                },
                new Word { Greek = "καθημένους", Transliteration = "kathēmenous", Gloss = "sitting", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "περιβεβλημένους", Transliteration = "peribeblēmenous", Gloss = "clothed", GrammarCodes = new List<string> { "V", "PERF", "MID", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἱματίοις", Transliteration = "imatiois", Gloss = "garments", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "λευκοῖς", Transliteration = "leukois", Gloss = "white", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "white garments"
                        }
                    },
                    Translation = "in white garments"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "upon", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "κεφαλὰς", Transliteration = "kephalas", Gloss = "heads", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", GrammarCodes = new List<string> { "PRON", "GEN", "3P", "M", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "their heads"
                        }
                    },
                    Translation = "upon their heads"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "στεφάνους", Transliteration = "stephanous", Gloss = "crowns", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "χρυσοῦς", Transliteration = "chrysous", Gloss = "golden", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "golden crowns"
                }
            },
            Translation = "And around the throne were twenty-four thrones; and upon the thrones I saw twenty-four elders sitting, clothed in white garments, and golden crowns were upon their heads."
        },
        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "out of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θρόνου", Transliteration = "thronou", Gloss = "throne", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the throne"
                        }
                    },
                    Translation = "out of the throne"
                },
                new Word { Greek = "ἐκπορεύονται", Transliteration = "ekporeuontai", Gloss = "proceed", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀστραπαὶ", Transliteration = "astrapai", Gloss = "lightnings", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "φωναὶ", Transliteration = "phōnai", Gloss = "voices", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "βρονταί", Transliteration = "brontai", Gloss = "thunders", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "lightnings and voices and thunders"
                }
            },
            Translation = "And out of the throne proceed lightnings and voices and thunders."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "λαμπάδες", Transliteration = "lampades", Gloss = "lamps", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πυρὸς", Transliteration = "pyros", Gloss = "of fire", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of fire"
                        },
                        new Word { Greek = "καιόμεναι", Transliteration = "kaiomenai", Gloss = "burning", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "F", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "seven lamps of fire burning"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐνώπιον", Transliteration = "enōpion", Gloss = "before", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θρόνου", Transliteration = "thronou", Gloss = "throne", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the throne"
                        }
                    },
                    Translation = "before the throne"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἅ", Transliteration = "ha", Gloss = "which", GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "εἰσιν", Transliteration = "eisin", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "πνεύματα", Transliteration = "pneumata", Gloss = "Spirits", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "the seven Spirits of God"
                        }
                    },
                    Translation = "which are the seven Spirits of God"
                }
            },
            Translation = "And there were seven lamps of fire burning before the throne, which are the seven Spirits of God."
        },
        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐνώπιον", Transliteration = "enōpion", Gloss = "before", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θρόνου", Transliteration = "thronou", Gloss = "throne", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the throne"
                        }
                    },
                    Translation = "before the throne"
                },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as it were", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θάλασσα", Transliteration = "thalassa", Gloss = "a sea", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὑαλίνη", Transliteration = "hyalinē", Gloss = "glassy", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a glassy sea"
                },
                new Word { Greek = "ὁμοία", Transliteration = "homoia", Gloss = "like", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "κρυστάλλῳ", Transliteration = "krystallō", Gloss = "crystal", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "And before the throne there was as it were a glassy sea like crystal."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μέσῳ", Transliteration = "mesō", Gloss = "the midst", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θρόνου", Transliteration = "thronou", Gloss = "throne", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the throne"
                        }
                    },
                    Translation = "in the midst of the throne"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κύκλῳ", Transliteration = "kyklō", Gloss = "around", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θρόνου", Transliteration = "thronou", Gloss = "throne", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the throne"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τέσσαρα", Transliteration = "tessara", Gloss = "four", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ζῷα", Transliteration = "zōa", Gloss = "living creatures", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "four living creatures"
                },
                new Word { Greek = "γέμοντα", Transliteration = "gemonta", Gloss = "full", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὀφθαλμῶν", Transliteration = "ophthalmōn", Gloss = "of eyes", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "of eyes"
                },
                new Word { Greek = "ἔμπροσθεν", Transliteration = "emprosthen", Gloss = "in front", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὄπισθεν", Transliteration = "opisthen", Gloss = "behind", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
            },
            Translation = "And in the midst of the throne, and around the throne, were four living creatures full of eyes in front and behind."
        },
        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ζῷον", Transliteration = "zōon", Gloss = "living creature", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πρῶτον", Transliteration = "prōton", Gloss = "first", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the first living creature"
                },
                new Word { Greek = "ὅμοιον", Transliteration = "homoion", Gloss = "like", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "λέοντι", Transliteration = "leonti", Gloss = "a lion", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δεύτερον", Transliteration = "deuteron", Gloss = "second", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ζῷον", Transliteration = "zōon", Gloss = "living creature", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the second living creature"
                },
                new Word { Greek = "ὅμοιον", Transliteration = "homoion", Gloss = "like", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "μόσχῳ", Transliteration = "moschō", Gloss = "a calf", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj"                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "τρίτον", Transliteration = "triton", Gloss = "third", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ζῷον", Transliteration = "zōon", Gloss = "living creature", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the third living creature"
                },
                new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πρόσωπον", Transliteration = "prosōpon", Gloss = "face", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the face"
                },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀνθρώπου", Transliteration = "anthrōpou", Gloss = "of a man", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "τέταρτον", Transliteration = "tetarton", Gloss = "fourth", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ζῷον", Transliteration = "zōon", Gloss = "living creature", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the fourth living creature"
                },
                new Word { Greek = "ὅμοιον", Transliteration = "homoion", Gloss = "like", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀετῷ", Transliteration = "aetō", Gloss = "an eagle", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "πετομένῳ", Transliteration = "petomenō", Gloss = "flying", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "DAT", "M", "S" }, PartOfSpeech = "v" }
            },
            Translation = "The first living creature was like a lion, and the second living creature like a calf, and the third living creature had a face like a man, and the fourth living creature was like a flying eagle."
        },
        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "τέσσαρα", Transliteration = "tessara", Gloss = "four", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ζῷα", Transliteration = "zōa", Gloss = "living creatures", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the four living creatures"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἓν", Transliteration = "hen", Gloss = "each", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καθ᾽", Transliteration = "kath'", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἓν", Transliteration = "hen", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "one by one"
                        },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", GrammarCodes = new List<string> { "PRON", "GEN", "3P", "N", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "each one of them"
                },
                new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνὰ", Transliteration = "ana", Gloss = "each", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "πτέρυγας", Transliteration = "pterygas", Gloss = "wings", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἕξ", Transliteration = "hex", Gloss = "six", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "six wings each"
                },
                new Word { Greek = "κυκλόθεν", Transliteration = "kyklothen", Gloss = "around", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἔσωθεν", Transliteration = "esōthen", Gloss = "within", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "γέμουσιν", Transliteration = "gemousin", Gloss = "they are full", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ὀφθαλμῶν", Transliteration = "ophthalmōn", Gloss = "of eyes", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
            },
            Translation = "And the four living creatures, each one of them having six wings, are full of eyes around and within;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνάπαυσιν", Transliteration = "anapausin", Gloss = "rest", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "rest"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἔχουσιν", Transliteration = "echousin", Gloss = "they have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡμέρας", Transliteration = "hēmeras", Gloss = "day", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "νυκτὸς", Transliteration = "nyktos", Gloss = "night", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "day and night"
                },
                new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ἅγιος", Transliteration = "hagios", Gloss = "Holy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἅγιος", Transliteration = "hagios", Gloss = "Holy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἅγιος", Transliteration = "hagios", Gloss = "Holy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "παντοκράτωρ", Transliteration = "pantokratōr", Gloss = "Almighty", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Lord God Almighty"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "who", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "who", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὢν", Transliteration = "ōn", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "who", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐρχόμενος", Transliteration = "erchomenos", Gloss = "is to come", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "who was and who is and who is to come"
                }
            },
            Translation = "and day and night they never cease to say, 'Holy, holy, holy, is the Lord God Almighty, who was and is and is to come!'"
        }
    };
}
/*
Constructions identified:
- Revelation 4:1: PREP_PHRASE (Μετὰ ταῦτα)
- Revelation 4:1: REL_CLAUSE (ἣν ἤκουσα)
- Revelation 4:1: PTCP (ὡς σάλπιγγος λαλούσης)
- Revelation 4:1: REL_CLAUSE (ἃ δεῖ γενέσθαι...)
- Revelation 4:2: PREP_PHRASE (ἐν πνεύματι)
- Revelation 4:5: REL_CLAUSE (ἅ εἰσιν τὰ ἑπτὰ πνεύματα...)
- Revelation 4:8: NOUN_PHRASE (ὁ ἦν καὶ ὁ ὢν καὶ ὁ ἐρχόμενος - Substantival participles with article)
*/
