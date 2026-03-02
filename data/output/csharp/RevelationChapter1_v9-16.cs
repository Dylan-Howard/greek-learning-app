private static List<object> GetChapter1()
{
    // Revelation 1:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἐγὼ", Transliteration = "Egō", Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "S" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἰωάννης", Transliteration = "Iōannēs", Gloss = "John",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                    },
                    Translation = "John"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀδελφὸς", Transliteration = "adelphos", Gloss = "brother",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "your brother"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συγκοινωνὸς", Transliteration = "synkoinōnos", Gloss = "partner",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" },
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
                                        new Word { Greek = "θλίψει", Transliteration = "thlipsei", Gloss = "tribulation",
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the tribulation"
                                },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "βασιλείᾳ", Transliteration = "basileia", Gloss = "kingdom",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "ὑπομονῇ", Transliteration = "hypomonē", Gloss = "patient endurance",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "in Jesus"
                                }
                            },
                            Translation = "in the tribulation and kingdom and endurance in Jesus"
                        }
                    },
                    Translation = "fellow-sharer"
                },
                new Word { Greek = "ἐγενόμην", Transliteration = "egenomēn", Gloss = "I was",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
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
                                new Word { Greek = "νήσῳ", Transliteration = "nēsō", Gloss = "island",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "καλουμένῃ", Transliteration = "kaloumenē", Gloss = "called",
                                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "DAT", "F", "S" },
                                            PartOfSpeech = "v" },
                                        new Word { Greek = "Πάτμῳ", Transliteration = "Patmō", Gloss = "Patmos",
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the one called Patmos"
                                }
                            },
                            Translation = "the island called Patmos"
                        }
                    },
                    Translation = "on the island"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "on account of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "λόγον", Transliteration = "logon", Gloss = "word",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the word of God"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "μαρτυρίαν", Transliteration = "martyrian", Gloss = "testimony",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "of Jesus",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the testimony of Jesus"
                        }
                    },
                    Translation = "on account of the word of God and the testimony of Jesus"
                }
            },
            Translation = "I, John, your brother and partner in the tribulation and kingdom and patient endurance that are in Jesus, was on the island called Patmos on account of the word of God and the testimony of Jesus."
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγενόμην", Transliteration = "egenomēn", Gloss = "I was",
                    GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "πνεύματι", Transliteration = "pneumati", Gloss = "spirit",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in the Spirit"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "on",
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
                                new Word { Greek = "κυριακῇ", Transliteration = "kyriakē", Gloss = "Lord's",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἡμέρᾳ", Transliteration = "hēmera", Gloss = "day",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the Lord's day"
                        }
                    },
                    Translation = "on the Lord's day"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἤκουσα", Transliteration = "ēkousa", Gloss = "I heard",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὀπίσω", Transliteration = "opisō", Gloss = "behind",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "me",
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "behind me"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φωνὴν", Transliteration = "phōnēn", Gloss = "a voice",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μεγάλην", Transliteration = "megalēn", Gloss = "loud",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "a loud voice"
                },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "like",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "σάλπιγγος", Transliteration = "salpingos", Gloss = "a trumpet",
                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                    PartOfSpeech = "n" }
            },
            Translation = "I was in the Spirit on the Lord's day, and I heard behind me a loud voice like a trumpet,"
        },
        // Verse 11
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
                        new Word { Greek = "λεγούσης", Transliteration = "legousēs", Gloss = "saying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "F", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "βλέπεις", Transliteration = "blepeis", Gloss = "you see",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "What you see"
                },
                new Word { Greek = "γράψον", Transliteration = "grapson", Gloss = "write",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "βιβλίον", Transliteration = "biblion", Gloss = "a book",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in a book"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "πέμψον", Transliteration = "pempson", Gloss = "send",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἐκκλησίαις", Transliteration = "ekklēsiais", Gloss = "churches",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the seven churches"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Ἔφεσον", Transliteration = "Epheson", Gloss = "Ephesus",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to Ephesus"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Σμύρναν", Transliteration = "Smyrnan", Gloss = "Smyrna",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to Smyrna"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Πέργαμον", Transliteration = "Pergamon", Gloss = "Pergamum",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to Pergamum"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Θυάτειρα", Transliteration = "Thuateira", Gloss = "Thyatira",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to Thyatira"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Σάρδεις", Transliteration = "Sardeis", Gloss = "Sardis",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to Sardis"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Φιλαδέλφειαν", Transliteration = "Philadelpheian", Gloss = "Philadelphia",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to Philadelphia"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Λαοδίκειαν", Transliteration = "Laodikeian", Gloss = "Laodicea",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "to Laodicea"
                }
            },
            Translation = "saying, 'Write what you see in a book and send it to the seven churches, to Ephesus and to Smyrna and to Pergamum and to Thyatira and to Sardis and to Philadelphia and to Laodicea.'"
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐπέστρεψα", Transliteration = "epestrepsa", Gloss = "I turned",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "PURPOSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βλέπειν", Transliteration = "blepein", Gloss = "to see",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "φωνὴν", Transliteration = "phōnēn", Gloss = "voice",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the voice"
                        }
                    },
                    Translation = "to see the voice"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἥτις", Transliteration = "hētis", Gloss = "which",
                            GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἐλάλει", Transliteration = "elalei", Gloss = "was speaking",
                            GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μετ᾽", Transliteration = "met'", Gloss = "with",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἐμοῦ", Transliteration = "emou", Gloss = "me",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "with me"
                        }
                    },
                    Translation = "which was speaking with me"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπιστρέψας", Transliteration = "epistrepsas", Gloss = "having turned",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having turned"
                },
                new Word { Greek = "εἶδον", Transliteration = "eidon", Gloss = "I saw",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "λυχνίας", Transliteration = "lychnias", Gloss = "lampstands",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "χρυσᾶς", Transliteration = "chrysas", Gloss = "golden",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "seven golden lampstands"
                }
            },
            Translation = "And I turned to see the voice that was speaking with me, and having turned I saw seven golden lampstands,"
        },
        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "μέσῳ", Transliteration = "mesō", Gloss = "the midst",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "P" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "λυχνιῶν", Transliteration = "lychniōn", Gloss = "lampstands",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the lampstands"
                        }
                    },
                    Translation = "in the midst of the lampstands"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅμοιον", Transliteration = "homoion", Gloss = "one like",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "υἱὸν", Transliteration = "huion", Gloss = "a son",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἀνθρώπου", Transliteration = "anthrōpou", Gloss = "of man",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "one like a son of man"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐνδεδυμένον", Transliteration = "endedymenon", Gloss = "clothed with",
                            GrammarCodes = new List<string> { "V", "PERF", "MID", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ποδήρη", Transliteration = "podērē", Gloss = "a long robe",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "clothed with a long robe"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περιεζωσμένον", Transliteration = "periezōsmenon", Gloss = "girded",
                            GrammarCodes = new List<string> { "V", "PERF", "MID", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "around",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "DAT", "M", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "μαστοῖς", Transliteration = "mastois", Gloss = "chest",
                                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "the chest"
                                }
                            },
                            Translation = "around the chest"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ζώνην", Transliteration = "zōnēn", Gloss = "a sash",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "χρυσᾶν", Transliteration = "chrysan", Gloss = "golden",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "a golden sash"
                        }
                    },
                    Translation = "girded around the chest with a golden sash"
                }
            },
            Translation = "and in the midst of the lampstands one like a son of man, clothed with a long robe and girded around the chest with a golden sash."
        },
        // Verse 14
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
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "κεφαλὴ", Transliteration = "kephalē", Gloss = "head",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "3P", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "his head"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἱ", Transliteration = "hai", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "τρίχες", Transliteration = "triches", Gloss = "hair",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the hair"
                },
                new Word { Greek = "λευκαὶ", Transliteration = "leukai", Gloss = "white",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "like",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἔριον", Transliteration = "erion", Gloss = "wool",
                    GrammarCodes = new List<string> { "N", "NOM", "N", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "λευκὸν", Transliteration = "leukon", Gloss = "white",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "like",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "χιὼν", Transliteration = "chiōn", Gloss = "snow",
                    GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ὀφθαλμοὶ", Transliteration = "ophthalmoi", Gloss = "eyes",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "3P", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "his eyes"
                },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "like",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φλὸξ", Transliteration = "phlox", Gloss = "a flame",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "πυρὸς", Transliteration = "pyros", Gloss = "of fire",
                            GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "a flame of fire"
                }
            },
            Translation = "The hair of his head was white, like white wool, like snow. His eyes were like a flame of fire,"
        },
        // Verse 15
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
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πόδες", Transliteration = "podes", Gloss = "feet",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "3P", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "his feet"
                },
                new Word { Greek = "ὅμοιοι", Transliteration = "homoioi", Gloss = "like",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "χαλκολιβάνῳ", Transliteration = "chalkolibanō", Gloss = "burnished bronze",
                    GrammarCodes = new List<string> { "N", "DAT", "N", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "καμίνῳ", Transliteration = "kaminō", Gloss = "a furnace",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "in a furnace"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πεπυρωμένης", Transliteration = "pepyrōmenēs", Gloss = "refined",
                            GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "GEN", "F", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "refined"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
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
                        new Word { Greek = "φωνὴ", Transliteration = "phōnē", Gloss = "voice",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "3P", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "his voice"
                },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "like",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φωνὴ", Transliteration = "phōnē", Gloss = "the roar",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑδάτων", Transliteration = "hydatōn", Gloss = "of waters",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "πολλῶν", Transliteration = "pollōn", Gloss = "many",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "of many waters"
                        }
                    },
                    Translation = "the roar of many waters"
                }
            },
            Translation = "his feet were like burnished bronze refined in a furnace, and his voice was like the roar of many waters."
        },
        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
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
                                        new Word { Greek = "δεξιᾷ", Transliteration = "dexia", Gloss = "right",
                                            GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                                            PartOfSpeech = "adj" },
                                        new Word { Greek = "χειρὶ", Transliteration = "cheiri", Gloss = "hand",
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                            PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                            GrammarCodes = new List<string> { "PRON", "GEN", "3P", "M", "S" },
                                            PartOfSpeech = "prep" }
                                    },
                                    Translation = "his right hand"
                                }
                            },
                            Translation = "in his right hand"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀστέρας", Transliteration = "asteras", Gloss = "stars",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἑπτὰ", Transliteration = "hepta", Gloss = "seven",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "seven stars"
                        }
                    },
                    Translation = "In his right hand he held seven stars,"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "out of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "στόματος", Transliteration = "stomatos", Gloss = "mouth",
                                    GrammarCodes = new List<string> { "N", "GEN", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "3P", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "his mouth"
                        }
                    },
                    Translation = "out of his mouth"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ῥομφαία", Transliteration = "hromphaia", Gloss = "a sword",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "δίστομος", Transliteration = "distomos", Gloss = "two-edged",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ὀξεῖα", Transliteration = "oxeia", Gloss = "sharp",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "a sharp two-edged sword"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκπορευομένη", Transliteration = "ekporeuomenē", Gloss = "coming out",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "F", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "coming out"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
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
                        new Word { Greek = "ὄψις", Transliteration = "opsis", Gloss = "face",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him",
                            GrammarCodes = new List<string> { "PRON", "GEN", "3P", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "his face"
                },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "like",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἥλιος", Transliteration = "hēlios", Gloss = "sun",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "the sun"
                },
                new Word { Greek = "φαίνει", Transliteration = "phainei", Gloss = "shines",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
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
                                new Word { Greek = "δυνάμει", Transliteration = "dynamei", Gloss = "strength",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of it",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "3P", "M", "S" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "its full strength"
                        }
                    },
                    Translation = "in its full strength"
                }
            },
            Translation = "In his right hand he held seven stars, and from his mouth came a sharp two-edged sword, and his face was like the sun shining in full strength."
        }
    };
}

/*
Constructions identified:
- APPOS: Ἰωάννης ὁ ἀδελφὸς (v9), συγκοινωνὸς (v9)
- GEN_DESC: φλὸξ πυρὸς (v14)
- DAT_INSTR: ἐν πνεύματι (v10) - locative/manner
*/
