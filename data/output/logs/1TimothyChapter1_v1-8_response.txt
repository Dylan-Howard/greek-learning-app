private static List<object> GetChapter1()
{
    // 1 Timothy 1:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Παῦλος", Transliteration = "Paulos", Gloss = "Paul",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπόστολος", Transliteration = "apostolos", Gloss = "apostle",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of Christ Jesus"
                        }
                    },
                    Translation = "an apostle of Christ Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατ᾽", Transliteration = "kat'", Gloss = "according to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπιταγὴν", Transliteration = "epitagēn", Gloss = "command",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "σωτῆρος", Transliteration = "sōtēros", Gloss = "Savior",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "of God our Savior"
                                }
                            },
                            Translation = "the command of God our Savior"
                        }
                    },
                    Translation = "according to the command of God our Savior"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἐλπίδος", Transliteration = "elpidos", Gloss = "hope",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "our hope"
                        }
                    },
                    Translation = "and Christ Jesus our hope"
                }
            },
            Translation = "Paul, an apostle of Christ Jesus according to the command of God our Savior and Christ Jesus our hope,"
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Τιμοθέῳ", Transliteration = "Timotheō", Gloss = "to Timothy",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "γνησίῳ", Transliteration = "gnēsiō", Gloss = "true",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "τέκνῳ", Transliteration = "teknō", Gloss = "child",
                                    GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "πίστει", Transliteration = "pistei", Gloss = "faith",
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "in the faith"
                                }
                            },
                            Translation = "my true child in the faith"
                        }
                    },
                    Translation = "To Timothy, my true child in the faith"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χάρις", Transliteration = "charis", Gloss = "grace",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἔλεος", Transliteration = "eleos", Gloss = "mercy",
                            GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "εἰρήνη", Transliteration = "eirēnē", Gloss = "peace",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Grace, mercy, and peace"
                },
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
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "πατρὸς", Transliteration = "patros", Gloss = "Father",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "our Lord"
                                }
                            },
                            Translation = "from God the Father and Christ Jesus our Lord"
                        }
                    },
                    Translation = "from God the Father and Christ Jesus our Lord"
                }
            },
            Translation = "To Timothy, my true child in the faith: Grace, mercy, and peace from God the Father and Christ Jesus our Lord."
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καθὼς", Transliteration = "Kathōs", Gloss = "As",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "παρεκάλεσά", Transliteration = "parekalesa", Gloss = "I urged",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "σε", Transliteration = "se", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "ACC", "S" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προσμεῖναι", Transliteration = "prosmeinai", Gloss = "to remain",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "Ἐφέσῳ", Transliteration = "Ephesō", Gloss = "Ephesus",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "at Ephesus"
                        }
                    },
                    Translation = "to remain at Ephesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πορευόμενος", Transliteration = "poreuomenos", Gloss = "going",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "Μακεδονίαν", Transliteration = "Makedonian", Gloss = "Macedonia",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "into Macedonia"
                        }
                    },
                    Translation = "when I was going into Macedonia"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "παραγγείλῃς", Transliteration = "parangeilēs", Gloss = "you might charge",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "τισὶν", Transliteration = "tisin", Gloss = "certain persons",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                            PartOfSpeech = "part" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                                    GrammarCodes = new List<string> { "PART" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἑτεροδιδασκαλεῖν", Transliteration = "heterodidaskalein", Gloss = "to teach different doctrine",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "not to teach any different doctrine"
                        }
                    },
                    Translation = "that you may charge certain persons not to teach any different doctrine"
                }
            },
            Translation = "As I urged you when I was going to Macedonia, remain at Ephesus so that you may charge certain persons not to teach any different doctrine"
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" }, // (continues verse 3)
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μηδὲ", Transliteration = "mēde", Gloss = "nor",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "προσέχειν", Transliteration = "prosechein", Gloss = "to devote oneself",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μύθοις", Transliteration = "mythois", Gloss = "to myths",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "γενεαλογίαις", Transliteration = "genealogiais", Gloss = "genealogies",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἀπεράντοις", Transliteration = "aperantois", Gloss = "endless",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "to myths and endless genealogies"
                        }
                    },
                    Translation = "nor to devote themselves to myths and endless genealogies"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἵτινες", Transliteration = "haitines", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "NOM", "F", "P" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἐκζητήσεις", Transliteration = "ekzētēseis", Gloss = "speculations",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "παρέχουσιν", Transliteration = "parechousin", Gloss = "promote",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "rather",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "than",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἰκονομίαν", Transliteration = "oikonomian", Gloss = "stewardship",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "which is",
                                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by",
                                                    GrammarCodes = new List<string> { "PREP" },
                                                    PartOfSpeech = "prep" },
                                                new Word { Greek = "πίστει", Transliteration = "pistei", Gloss = "faith",
                                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S
