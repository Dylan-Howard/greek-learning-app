private static List<object> GetChapter15()
{
    // Acts 15:25-32
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔδοξεν", Transliteration = "edoxen", Gloss = "it seemed good", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γενομένοις", Transliteration = "genomenois", Gloss = "having become", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὁμοθυμαδὸν", Transliteration = "homothymadon", Gloss = "with one accord", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                    },
                    Translation = "having come to one accord"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκλεξαμένοις", Transliteration = "eklexamenois", Gloss = "having chosen", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "having chosen"
                        },
                        new Word { Greek = "ἄνδρας", Transliteration = "andras", Gloss = "men", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "πέμψαι", Transliteration = "pempzai", Gloss = "to send", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "to you"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "σὺν", Transliteration = "syn", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἀγαπητοῖς", Transliteration = "agapētois", Gloss = "beloved", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "Βαρναβᾷ", Transliteration = "Barnaba", Gloss = "Barnabas", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                        new Word { Greek = "Παύλῳ", Transliteration = "Paulō", Gloss = "Paul", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "our beloved Barnabas and Paul"
                                }
                            },
                            Translation = "with our beloved Barnabas and Paul"
                        }
                    },
                    Translation = "to send chosen men to you with our beloved Barnabas and Paul"
                }
            },
            Translation = "It seemed good to us, having come to one accord, to send chosen men to you with our beloved Barnabas and Paul,"
        },
        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "APPOS" },
            Content = new List<object>
            {
                new Word { Greek = "ἀνθρώποις", Transliteration = "anthrōpois", Gloss = "men", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παραδεδωκόσιν", Transliteration = "paradedōkosin", Gloss = "having risked", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ψυχὰς", Transliteration = "psychas", Gloss = "lives", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "their lives"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "for", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ὀνόματος", Transliteration = "onomatos", Gloss = "name", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "prep" },
                                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "of our Lord Jesus Christ"
                                        }
                                    },
                                    Translation = "the name of our Lord Jesus Christ"
                                }
                            },
                            Translation = "for the name of our Lord Jesus Christ"
                        }
                    },
                    Translation = "who have risked their lives for the name of our Lord Jesus Christ"
                }
            },
            Translation = "men who have risked their lives for the name of our Lord Jesus Christ."
        },
        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀπεστάλκαμεν", Transliteration = "apestalkamen", Gloss = "we have sent", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰούδαν", Transliteration = "Ioudan", Gloss = "Judas", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Σιλᾶν", Transliteration = "Silan", Gloss = "Silas", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Judas and Silas"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "prep" },
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
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "λόγου", Transliteration = "logou", Gloss = "word", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "by word of mouth"
                        },
                        new Word { Greek = "ἀπαγγέλλοντας", Transliteration = "apangellontas", Gloss = "telling", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "αὐτά", Transliteration = "auta", Gloss = "same things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "the same things"
                        }
                    },
                    Translation = "telling the same things by word of mouth"
                }
            },
            Translation = "We have therefore sent Judas and Silas, who themselves will also tell you the same things by word of mouth."
        },
        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔδοξεν", Transliteration = "edoxen", Gloss = "it seemed good", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πνεύματι", Transliteration = "pneumati", Gloss = "Spirit", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἁγίῳ", Transliteration = "hagiō", Gloss = "Holy", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "to the Holy Spirit"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μηδὲν", Transliteration = "mēden", Gloss = "no", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "πλέον", Transliteration = "pleon", Gloss = "greater", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐπιτίθεσθαι", Transliteration = "epitithesthai", Gloss = "to lay upon", GrammarCodes = new List<string> { "V", "PRES", "MID", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "βάρος", Transliteration = "baros", Gloss = "burden", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πλὴν", Transliteration = "plēn", Gloss = "except", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τούτων", Transliteration = "toutōn", Gloss = "these", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "adv" },
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἐπάναγκες", Transliteration = "epanankes", Gloss = "necessaries", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "these essentials"
                                }
                            },
                            Translation = "except these essentials"
                        }
                    },
                    Translation = "to lay upon you no greater burden except these essentials"
                }
            },
            Translation = "For it seemed good to the Holy Spirit and to us to lay upon you no greater burden except these essentials:"
        },
        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "INF_PHRASE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀπέχεσθαι", Transliteration = "apechesthai", Gloss = "to abstain from", GrammarCodes = new List<string> { "V", "PRES", "MID", "INF" }, PartOfSpeech = "v" },
                new Word { Greek = "εἰδωλοθύτων", Transliteration = "eidōlothytōn", Gloss = "things sacrificed to idols", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "αἵματος", Transliteration = "haimatos", Gloss = "blood", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πνικτῶν", Transliteration = "pniktōn", Gloss = "things strangled", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πορνείας", Transliteration = "porneias", Gloss = "sexual immorality", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
            },
            Translation = "that you abstain from things sacrificed to idols, and from blood, and from things strangled, and from sexual immorality"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "which", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "from which"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διατηροῦντες", Transliteration = "diatērountes", Gloss = "keeping", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἑαυτοὺς", Transliteration = "heautous", Gloss = "yourselves", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "f" }
                    },
                    Translation = "keeping yourselves"
                },
                new Word { Greek = "εὖ", Transliteration = "eu", Gloss = "well", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "πράξετε", Transliteration = "praxete", Gloss = "you will do", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "from which, if you keep yourselves, you will do well."
        },
        new Word { Greek = "Ἔρρωσθε", Transliteration = "Errōsthe", Gloss = "Farewell", GrammarCodes = new List<string> { "V", "PERF", "MID", "IMP", "2P", "P" }, PartOfSpeech = "v" },
        // Verse 30
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
                        new Word { Greek = "Οἱ", Transliteration = "Hoi", Gloss = "The", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "on the one hand", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "so", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀπολυθέντες", Transliteration = "apolythentes", Gloss = "having been sent off", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "So when they were sent off"
                },
                new Word { Greek = "κατῆλθον", Transliteration = "katēlthon", Gloss = "they went down", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "Ἀντιόχειαν", Transliteration = "Antiocheian", Gloss = "Antioch", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to Antioch"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συναγαγόντες", Transliteration = "synagagontes", Gloss = "having gathered", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πλῆθος", Transliteration = "plēthos", Gloss = "congregation", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the congregation"
                        }
                    },
                    Translation = "having gathered the congregation"
                },
                new Word { Greek = "ἐπέδωκαν", Transliteration = "epedōkan", Gloss = "they delivered", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐπιστολήν", Transliteration = "epistolēn", Gloss = "letter", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the letter"
                }
            },
            Translation = "So when they were sent off, they went down to Antioch, and having gathered the congregation, they delivered the letter."
        },
        // Verse 31
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
                        new Word { Greek = "ἀναγνόντες", Transliteration = "anagnontes", Gloss = "having read", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "when they had read it"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐχάρησαν", Transliteration = "echarēsan", Gloss = "they rejoiced", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "at", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "παρακλήσει", Transliteration = "paraklēsei", Gloss = "encouragement", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the encouragement"
                        }
                    },
                    Translation = "at the encouragement"
                }
            },
            Translation = "And when they had read it, they rejoiced at its encouragement."
        },
        // Verse 32
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
                        new Word { Greek = "Ἰούδας", Transliteration = "Ioudas", Gloss = "Judas", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Σιλᾶς", Transliteration = "Silas", Gloss = "Silas", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Judas and Silas"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "αὐτοὶ", Transliteration = "autoi", Gloss = "themselves", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προφῆται", Transliteration = "prophētai", Gloss = "prophets", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὄντες", Transliteration = "ontes", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "being themselves prophets"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "λόγου", Transliteration = "logou", Gloss = "word", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "πολλοῦ", Transliteration = "pollou", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "with many words"
                },
                new Word { Greek = "παρεκάλεσαν", Transliteration = "parekalesan", Gloss = "encouraged", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀδελφοὺς", Transliteration = "adelphous", Gloss = "brothers", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the brothers"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐπεστήριξαν", Transliteration = "epestērixan", Gloss = "strengthened", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "And Judas and Silas, who were themselves prophets, encouraged and strengthened the brothers with many words."
        }
    };
}
/*
Constructions identified:
- INF_PHRASE: v.25 (πέμψαι), v.28 (ἐπιτίθεσθαι), v.29 (ἀπέχεσθαι)
- PTCP: v.25 (γενομένοις, ἐκλεξαμένοις), v.26 (παραδεδωκόσιν), v.27 (ἀπαγγέλλοντας), v.29 (διατηροῦντες), v.30 (ἀπολυθέντες, συναγαγόντες), v.31 (ἀναγνόντες), v.32 (ὄντες)
- APPOS: v.26 (ἀνθρώποις... describing Barnabas and Paul)
*/
