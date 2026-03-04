private static List<object> GetChapter21()
{
    // Acts 21:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Γενομένων", Transliteration = "Genomenōn", Gloss = "having arrived", 
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "us", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "Ἱεροσόλυμα", Transliteration = "Hierosolyma", Gloss = "Jerusalem", 
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "to Jerusalem"
                        }
                    },
                    Translation = "And when we had arrived at Jerusalem"
                },
                new Word { Greek = "ἀσμένως", Transliteration = "asmenōs", Gloss = "gladly", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "ἀπεδέξαντο", Transliteration = "apedexanto", Gloss = "welcomed", 
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the brothers"
                }
            },
            Translation = "And when we had arrived at Jerusalem, the brothers welcomed us gladly."
        },
        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Τῇ", Transliteration = "Tē", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἐπιούσῃ", Transliteration = "epiousē", Gloss = "following [day]", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "F", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "On the following day"
                },
                new Word { Greek = "εἰσῄει", Transliteration = "eisēiei", Gloss = "went in", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "Παῦλος", Transliteration = "Paulos", Gloss = "Paul", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "Paul"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὺν", Transliteration = "syn", Gloss = "with", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "us", 
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "with us"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "Ἰάκωβον", Transliteration = "Iakōbon", Gloss = "James", 
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "to James"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all", 
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "παρεγένοντο", Transliteration = "paregenonto", Gloss = "were present", 
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "πρεσβύτεροι", Transliteration = "presbyteroi", Gloss = "elders", 
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "the elders"
                        }
                    },
                    Translation = "and all the elders were present."
                }
            },
            Translation = "On the following day Paul went in with us to James, and all the elders were present."
        },
        // Verse 19
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
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἀσπασάμενος", Transliteration = "aspasamenos", Gloss = "having greeted", 
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "them", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "After greeting them"
                },
                new Word { Greek = "ἐξηγεῖτο", Transliteration = "exēgeito", Gloss = "he related", 
                    GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθ᾽", Transliteration = "kath'", Gloss = "by", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ἓν", Transliteration = "hen", Gloss = "one", 
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἕκαστον", Transliteration = "hekaston", Gloss = "each [thing]", 
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "one by one"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "of which [things]", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen", Gloss = "did", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", 
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "God"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἔθνεσιν", Transliteration = "ethnesin", Gloss = "Gentiles", 
                                            GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the Gentiles"
                                }
                            },
                            Translation = "among the Gentiles"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "διακονίας", Transliteration = "diakonias", Gloss = "ministry", 
                                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", 
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "his ministry"
                                }
                            },
                            Translation = "through his ministry"
                        }
                    },
                    Translation = "the things that God had done among the Gentiles through his ministry."
                }
            },
            Translation = "After greeting them, he related one by one the things that God had done among the Gentiles through his ministry."
        },
        // Verse 20
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
                        new Word { Greek = "Οἱ", Transliteration = "Hoi", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἀκούσαντες", Transliteration = "akousantes", Gloss = "having heard", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "And when they heard it"
                },
                new Word { Greek = "ἐδόξαζον", Transliteration = "edoxazon", Gloss = "they glorified", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "θεὸν", Transliteration = "theon", Gloss = "God", 
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἶπόν", Transliteration = "eipon", Gloss = "they said", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", 
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "θεωρεῖς", Transliteration = "theōreis", Gloss = "you see", 
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "ἀδελφέ", Transliteration = "adelphe", Gloss = "brother", 
                                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "πόσαι", Transliteration = "posai", Gloss = "how many", 
                                    GrammarCodes = new List<string> { "PRON", "NOM", "F", "P" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "μυριάδες", Transliteration = "myriades", Gloss = "thousands", 
                                    GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "εἰσὶν", Transliteration = "eisin", Gloss = "there are", 
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", 
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", 
                                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                                                new Word { Greek = "Ἰουδαίοις", Transliteration = "Ioudaiois", Gloss = "Jews", 
                                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" }
                                            },
                                            Translation = "the Jews"
                                        }
                                    },
                                    Translation = "among the Jews"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of those", 
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "πεπιστευκότων", Transliteration = "pepisteukotōn", Gloss = "having believed", 
                                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "verb" }
                                    },
                                    Translation = "who have believed"
                                },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all", 
                                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "ζηλωταὶ", Transliteration = "zēlōtai", Gloss = "zealous", 
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "for the", 
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "law", 
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "for the law"
                                },
                                new Word { Greek = "ὑπάρχουσιν", Transliteration = "hyparchousin", Gloss = "they are", 
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "You see, brother, how many thousands there are among the Jews of those who have believed, and they are all zealous for the law."
                        }
                    },
                    Translation = "and they said to him, 'You see, brother, how many thousands there are among the Jews of those who have believed, and they are all zealous for the law."
                }
            },
            Translation = "And when they heard it, they glorified God. And they said to him, 'You see, brother, how many thousands there are among the Jews of those who have believed, and they are all zealous for the law."
        },
        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "κατηχήθησαν", Transliteration = "katēchēthēsan", Gloss = "they have been told", 
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "σοῦ", Transliteration = "sou", Gloss = "you", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "about you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἀποστασίαν", Transliteration = "apostasian", Gloss = "apostasy", 
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "διδάσκεις", Transliteration = "didaskeis", Gloss = "you teach", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "Μωϋσέως", Transliteration = "Mōyseōs", Gloss = "Moses", 
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "from Moses"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "article" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "among", 
                                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", 
                                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "article" },
                                                new Word { Greek = "ἔθνη", Transliteration = "ethnē", Gloss = "Gentiles", 
                                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "noun" }
                                            },
                                            Translation = "the Gentiles"
                                        }
                                    },
                                    Translation = "among the Gentiles"
                                },
                                new Word { Greek = "πάντας", Transliteration = "pantas", Gloss = "all", 
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "Ἰουδαίους", Transliteration = "Ioudaious", Gloss = "Jews", 
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "all the Jews who are among the Gentiles"
                        },
                        new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "telling", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", 
                                    GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                                new Word { Greek = "περιτέμνειν", Transliteration = "peritemnein", Gloss = "to circumcise", 
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "their", 
                                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pronoun" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", 
                                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "article" },
                                                new Word { Greek = "τέκνα", Transliteration = "tekna", Gloss = "children", 
                                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "noun" }
                                            },
                                            Translation = "children"
                                        }
                                    },
                                    Translation = "their children"
                                }
                            },
                            Translation = "not to circumcise their children"
                        },
                        new Word { Greek = "μηδὲ", Transliteration = "mēde", Gloss = "nor", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "according to the", 
                                            GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἔθεσιν", Transliteration = "ethesin", Gloss = "customs", 
                                            GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "according to the customs"
                                },
                                new Word { Greek = "περιπατεῖν", Transliteration = "peripatein", Gloss = "to walk", 
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" }
                            },
                            Translation = "nor to walk according to the customs."
                        }
                    },
                    Translation = "that you teach all the Jews who are among the Gentiles to forsake Moses, telling them not to circumcise their children or walk according to our customs."
                }
            },
            Translation = "and they have been told about you that you teach all the Jews who are among the Gentiles to forsake Moses, telling them not to circumcise their children or walk according to our customs."
        },
        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τί", Transliteration = "ti", Gloss = "What", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is it", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "πάντως", Transliteration = "pantōs", Gloss = "certainly", 
                    GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "ἀκούσονται", Transliteration = "akousontai", Gloss = "they will hear", 
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἐλήλυθας", Transliteration = "elēlythas", Gloss = "you have come", 
                            GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "that you have come"
                }
            },
            Translation = "What then is it? They will certainly hear that you have come."
        },
        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ποίησον", Transliteration = "poiēson", Gloss = "do", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅ", Transliteration = "ho", Gloss = "what", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you", 
                            GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "λέγομεν", Transliteration = "legomen", Gloss = "we tell", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "what we tell you."
                },
                new Word { Greek = "εἰσὶν", Transliteration = "eisin", Gloss = "There are", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "with us", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄνδρες", Transliteration = "andres", Gloss = "men", 
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "τέσσαρες", Transliteration = "tessares", Gloss = "four", 
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "four men"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εὐχὴν", Transliteration = "euchēn", Gloss = "a vow", 
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ἔχοντες", Transliteration = "echontes", Gloss = "having", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐφ᾽", Transliteration = "eph'", Gloss = "on", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ἑαυτῶν", Transliteration = "heautōn", Gloss = "themselves", 
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "on themselves"
                        }
                    },
                    Translation = "who have a vow on themselves."
                }
            },
            Translation = "Do therefore what we tell you. We have four men who are under a vow."
        },
        // Verse 24
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
                        new Word { Greek = "τούτους", Transliteration = "toutous", Gloss = "these", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "παραλαβὼν", Transliteration = "paralabōn", Gloss = "having taken", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "Take these men"
                },
                new Word { Greek = "ἁγνίσθητι", Transliteration = "hagnisthēti", Gloss = "purify yourself", 
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IMP", "2P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὺν", Transliteration = "syn", Gloss = "with", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", 
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "with them"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "δαπάνησον", Transliteration = "dapanēson", Gloss = "pay their expenses", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "for", 
                            GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", 
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "for them"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ξυρήσονται", Transliteration = "xyrēsontai", Gloss = "they may shave", 
                            GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "κεφαλήν", Transliteration = "kephalēn", Gloss = "head", 
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "their heads"
                        }
                    },
                    Translation = "so that they may shave their heads."
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "γνώσονται", Transliteration = "gnōsontai", Gloss = "will know", 
                    GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "everyone", 
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", 
                            GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "the things which", 
                                    GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "κατήχηνται", Transliteration = "katēchēntai", Gloss = "they have been told", 
                                    GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "the things they have been told"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about", 
                                    GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "σοῦ", Transliteration = "sou", Gloss = "you", 
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "about you"
                        },
                        new Word { Greek = "οὐδέν", Transliteration = "ouden", Gloss = "nothing", 
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is [true]", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "that there is nothing in what they have been told about you,"
                },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "στοιχεῖς", Transliteration = "stoicheis", Gloss = "you walk", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", 
                    GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "yourself", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φυλάσσων", Transliteration = "phylassōn", Gloss = "keeping", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "νόμον", Transliteration = "nomon", Gloss = "law", 
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the law"
                        }
                    },
                    Translation = "keeping the law."
                }
            },
            Translation = "Take these men and purify yourself along with them and pay their expenses, so that they may shave their heads. Thus all will know that there is nothing in what they have been told about you, but that you yourself also live in observance of the law."
        }
    };
}

/*
Constructions identified:
- GEN_ABS (Genitive Absolute): Acts 21:17 (Γενομένων ... ἡμῶν)
- Dative of Time: Acts 21:18 (Τῇ ... ἐπιούσῃ)
- Indirect Discourse (with ὅτι): Acts 21:21, 21:22, 21:24
- Purpose Clause (ἵνα + Future/Subjunctive): Acts 21:24
*/
