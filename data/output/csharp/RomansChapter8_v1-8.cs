private static List<object> GetChapter8()
{
    // Romans 8:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Οὐδὲν", Transliteration = "Ouden", Gloss = "no", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, Part_of_speech = "adj" },
                new Word { Greek = "ἄρα", Transliteration = "ara", Gloss = "then", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now", GrammarCodes = new List<string> { "ADV" }, Part_of_speech = "adv" },
                new Word { Greek = "κατάκριμα", Transliteration = "katakrima", Gloss = "condemnation", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, Part_of_speech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to those", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, Part_of_speech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                                new Word { Greek = "Χριστῷ", Transliteration = "Christō", Gloss = "Christ", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, Part_of_speech = "n" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "in Christ Jesus"
                        }
                    },
                    Translation = "to those in Christ Jesus"
                }
            },
            Translation = "There is therefore now no condemnation for those who are in Christ Jesus."
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                        new Word { Greek = "νόμος", Transliteration = "nomos", Gloss = "law", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, Part_of_speech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "πνεύματος", Transliteration = "pneumatos", Gloss = "Spirit", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "of the Spirit"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "ζωῆς", Transliteration = "zōēs", Gloss = "life", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "of life"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                                new Word { Greek = "Χριστῷ", Transliteration = "Christō", Gloss = "Christ", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, Part_of_speech = "n" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "in Christ Jesus"
                        }
                    },
                    Translation = "the law of the Spirit of life in Christ Jesus"
                },
                new Word { Greek = "ἠλευθέρωσέν", Transliteration = "ēleutherōsen", Gloss = "set free", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, Part_of_speech = "v" },
                new Word { Greek = "σε", Transliteration = "se", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" }, Part_of_speech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "law", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "the law"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "ἁμαρτίας", Transliteration = "hamartias", Gloss = "sin", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "of sin"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "θανάτου", Transliteration = "thanatou", Gloss = "death", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "the death"
                        }
                    },
                    Translation = "from the law of sin and death"
                }
            },
            Translation = "For the law of the Spirit of life in Christ Jesus has set you free from the law of sin and death."
        },

        // Verse 3
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
                        new Word { Greek = "Τὸ", Transliteration = "To", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                        new Word { Greek = "ἀδύνατον", Transliteration = "adynaton", Gloss = "impossible thing", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, Part_of_speech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "law", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "of the law"
                        }
                    },
                    Translation = "For what the law was powerless to do"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                        new Word { Greek = "ᾧ", Transliteration = "hō", Gloss = "which", GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" }, Part_of_speech = "pron" },
                        new Word { Greek = "ἠσθένει", Transliteration = "ēsthenei", Gloss = "it was weak", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, Part_of_speech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, Part_of_speech = "art" },
                                        new Word { Greek = "σαρκός", Transliteration = "sarkos", Gloss = "flesh", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, Part_of_speech = "n" }
                                    },
                                    Translation = "the flesh"
                                }
                            },
                            Translation = "through the flesh"
                        }
                    },
                    Translation = "in that it was weak through the flesh"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πέμψας", Transliteration = "pempsas", Gloss = "sending", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, Part_of_speech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "ἑαυτοῦ", Transliteration = "heautou", Gloss = "his own", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, Part_of_speech = "pron" },
                                new Word { Greek = "υἱὸν", Transliteration = "huion", Gloss = "Son", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "his own Son"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                                new Word { Greek = "ὁμοιώματι", Transliteration = "homoiōmati", Gloss = "likeness", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, Part_of_speech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "σαρκὸς", Transliteration = "sarkos", Gloss = "of flesh", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, Part_of_speech = "n" },
                                        new Word { Greek = "ἁμαρτίας", Transliteration = "hamartias", Gloss = "of sin", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, Part_of_speech = "n" }
                                    },
                                    Translation = "of sinful flesh"
                                }
                            },
                            Translation = "in the likeness of sinful flesh"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                                new Word { Greek = "ἁμαρτίας", Transliteration = "hamartias", Gloss = "sin", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "concerning sin"
                        }
                    },
                    Translation = "by sending his own Son in the likeness of sinful flesh and as an offering for sin"
                },
                new Word { Greek = "κατέκρινεν", Transliteration = "katekrynen", Gloss = "he condemned", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, Part_of_speech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "ἁμαρτίαν", Transliteration = "hamartian", Gloss = "sin", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "the sin"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "σαρκί", Transliteration = "sarki", Gloss = "flesh", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "the flesh"
                        }
                    },
                    Translation = "in the flesh"
                }
            },
            Translation = "For what the law was powerless to do in that it was weak through the flesh, God did by sending his own Son in the likeness of sinful flesh and for sin, he condemned sin in the flesh."
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "δικαίωμα", Transliteration = "dikaiōma", Gloss = "requirement", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, Part_of_speech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "law", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "of the law"
                        }
                    },
                    Translation = "the requirement of the law"
                },
                new Word { Greek = "πληρωθῇ", Transliteration = "plērōthē", Gloss = "might be fulfilled", GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "S" }, Part_of_speech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                        new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "us", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "P" }, Part_of_speech = "pron" }
                    },
                    Translation = "in us"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "those", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, Part_of_speech = "art" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, Part_of_speech = "adv" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                                new Word { Greek = "σάρκα", Transliteration = "sarka", Gloss = "flesh", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "according to the flesh"
                        },
                        new Word { Greek = "περιπατοῦσιν", Transliteration = "peripatousin", Gloss = "walking", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "P" }, Part_of_speech = "v" },
                        new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                                new Word { Greek = "πνεῦμα", Transliteration = "pneuma", Gloss = "Spirit", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "according to the Spirit"
                        }
                    },
                    Translation = "who walk not according to the flesh but according to the Spirit"
                }
            },
            Translation = "in order that the righteous requirement of the law might be fulfilled in us, who walk not according to the flesh but according to the Spirit."
        },

        // Verse 5
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the ones", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, Part_of_speech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                                new Word { Greek = "σάρκα", Transliteration = "sarka", Gloss = "flesh", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "according to the flesh"
                        },
                        new Word { Greek = "ὄντες", Transliteration = "ontes", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, Part_of_speech = "v" }
                    },
                    Translation = "For those who live according to the flesh"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the things", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, Part_of_speech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "σαρκὸς", Transliteration = "sarkos", Gloss = "flesh", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "of the flesh"
                        }
                    },
                    Translation = "the things of the flesh"
                },
                new Word { Greek = "φρονοῦσιν", Transliteration = "phronousin", Gloss = "set their minds on", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, Part_of_speech = "v" },
                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "those", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, Part_of_speech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                        new Word { Greek = "πνεῦμα", Transliteration = "pneuma", Gloss = "Spirit", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "according to the Spirit"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the things", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, Part_of_speech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "πνεύματος", Transliteration = "pneumatos", Gloss = "Spirit", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "of the Spirit"
                        }
                    },
                    Translation = "the things of the Spirit"
                }
            },
            Translation = "For those who live according to the flesh set their minds on the things of the flesh, but those who live according to the Spirit set their minds on the things of the Spirit."
        },

        // Verse 6
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
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                        new Word { Greek = "φρόνημα", Transliteration = "phronēma", Gloss = "mindset", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, Part_of_speech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "σαρκὸς", Transliteration = "sarkos", Gloss = "flesh", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "of the flesh"
                        }
                    },
                    Translation = "For the mindset of the flesh"
                },
                new Word { Greek = "θάνατος", Transliteration = "thanatos", Gloss = "is death", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, Part_of_speech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                        new Word { Greek = "φρόνημα", Transliteration = "phronēma", Gloss = "mindset", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, Part_of_speech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "πνεύματος", Transliteration = "pneumatos", Gloss = "Spirit", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "of the Spirit"
                        }
                    },
                    Translation = "but the mindset of the Spirit"
                },
                new Word { Greek = "ζωὴ", Transliteration = "zōē", Gloss = "is life", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, Part_of_speech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Word { Greek = "εἰρήνη", Transliteration = "eirēnē", Gloss = "peace", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, Part_of_speech = "n" }
            },
            Translation = "For the mindset of the flesh is death, but the mindset of the Spirit is life and peace."
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "διότι", Transliteration = "dioti", Gloss = "because", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "φρόνημα", Transliteration = "phronēma", Gloss = "mindset", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, Part_of_speech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "σαρκὸς", Transliteration = "sarkos", Gloss = "flesh", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "of the flesh"
                        }
                    },
                    Translation = "the mindset of the flesh"
                },
                new Word { Greek = "ἔχθρα", Transliteration = "echthra", Gloss = "is hostile", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, Part_of_speech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "toward", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                        new Word { Greek = "θεόν", Transliteration = "theon", Gloss = "God", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, Part_of_speech = "n" }
                    },
                    Translation = "toward God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, Part_of_speech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                        new Word { Greek = "νόμῳ", Transliteration = "nomō", Gloss = "law", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, Part_of_speech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, Part_of_speech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "of God"
                        }
                    },
                    Translation = "for to the law of God"
                },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, Part_of_speech = "adv" },
                new Word { Greek = "ὑποτάσσεται", Transliteration = "hypotassetai", Gloss = "it does submit", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, Part_of_speech = "v" },
                new Word { Greek = "οὐδὲ", Transliteration = "oude", Gloss = "nor", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "indeed", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                new Word { Greek = "δύναται", Transliteration = "dynatai", Gloss = "it is able", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, Part_of_speech = "v" }
            },
            Translation = "Because the mindset of the flesh is hostile toward God, for it does not submit to God's law; indeed, it cannot."
        },

        // Verse 8
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "those", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, Part_of_speech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, Part_of_speech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, Part_of_speech = "prep" },
                                new Word { Greek = "σαρκὶ", Transliteration = "sarki", Gloss = "flesh", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, Part_of_speech = "n" }
                            },
                            Translation = "in the flesh"
                        },
                        new Word { Greek = "ὄντες", Transliteration = "ontes", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, Part_of_speech = "v" }
                    },
                    Translation = "Those who are in the flesh"
                },
                new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, Part_of_speech = "n" },
                new Word { Greek = "ἀρέσαι", Transliteration = "aresai", Gloss = "to please", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, Part_of_speech = "v" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, Part_of_speech = "adv" },
                new Word { Greek = "δύνανται", Transliteration = "dynantai", Gloss = "are able", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "P" }, Part_of_speech = "v" }
            },
            Translation = "Those who are in the flesh cannot please God."
        }
    };
}

/*
Identified Constructions:
- 8:3 - REL_CLAUSE (ἐν ᾧ)
- 8:3 - PTCP (πέμψας)
- 8:4 - PURPOSE_CLAUSE (ἵνα ... πληρωθῇ)
- 8:4 - PTCP (περιπατοῦσιν) used substantivally with article
- 8:5 - PTCP (ὄντες) used substantivally with article
- 8:7 - CAUSAL_CLAUSE (διότι)
- 8:8 - PTCP (ὄντες) used substantivally with article
*/
