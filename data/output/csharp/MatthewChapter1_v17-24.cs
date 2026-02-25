private static List<object> GetChapter1()
{
    // Matthew 1:17-24
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Πᾶσαι", Transliteration = "Pasai", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αἱ", Transliteration = "hai", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "γενεαὶ", Transliteration = "geneai", Gloss = "generations", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "Ἀβραὰμ", Transliteration = "Abraam", Gloss = "Abraham", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "from Abraham"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "up to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "Δαυὶδ", Transliteration = "Dauid", Gloss = "David", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "until David"
                        }
                    },
                    Translation = "So all the generations from Abraham until David"
                },
                new Word { Greek = "γενεαὶ", Transliteration = "geneai", Gloss = "generations", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "δεκατέσσαρες", Transliteration = "dekatessares", Gloss = "fourteen", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "Δαυὶδ", Transliteration = "Dauid", Gloss = "David", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "from David"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "up to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "μετοικεσίας", Transliteration = "metoikesias", Gloss = "exile", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Βαβυλῶνος", Transliteration = "Babylōnos", Gloss = "Babylon", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the deportation to Babylon"
                        }
                    },
                    Translation = "until the deportation to Babylon"
                },
                new Word { Greek = "γενεαὶ", Transliteration = "geneai", Gloss = "generations", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "δεκατέσσαρες", Transliteration = "dekatessares", Gloss = "fourteen", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "μετοικεσίας", Transliteration = "metoikesias", Gloss = "exile", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Βαβυλῶνος", Transliteration = "Babylōnos", Gloss = "Babylon", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the deportation to Babylon"
                        }
                    },
                    Translation = "from the deportation to Babylon"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "up to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Christ"
                        }
                    },
                    Translation = "until the Christ"
                },
                new Word { Greek = "γενεαὶ", Transliteration = "geneai", Gloss = "generations", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "δεκατέσσαρες", Transliteration = "dekatessares", Gloss = "fourteen", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" }
            },
            Translation = "So all the generations from Abraham until David were fourteen generations, and from David until the deportation to Babylon fourteen generations, and from the deportation to Babylon until the Christ fourteen generations."
        },

        // Verse 18
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
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Τοῦ", Transliteration = "Tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of Jesus Christ"
                        },
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γένεσις", Transliteration = "genesis", Gloss = "birth", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the birth of Jesus Christ"
                },
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "in this way", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μνηστευθείσης", Transliteration = "mnēsteutheisēs", Gloss = "having been betrothed", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "GEN", "F", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "μητρὸς", Transliteration = "mētros", Gloss = "mother", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" },
                                new Word { Greek = "Μαρίας", Transliteration = "Marias", Gloss = "Mary", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "his mother Mary"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Ἰωσήφ", Transliteration = "Iōsēph", Gloss = "Joseph", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "to Joseph"
                        }
                    },
                    Translation = "When his mother Mary had been betrothed to Joseph"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὶν", Transliteration = "prin", Gloss = "before", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "than", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "συνελθεῖν", Transliteration = "synelthein", Gloss = "to come together", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "they", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "before they came together"
                },
                new Word { Greek = "εὑρέθη", Transliteration = "heurēthē", Gloss = "she was found", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "γαστρὶ", Transliteration = "gastri", Gloss = "womb", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "with child"
                },
                new Word { Greek = "ἔχουσα", Transliteration = "echousa", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πνεύματος", Transliteration = "pneumatos", Gloss = "Spirit", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἁγίου", Transliteration = "hagiou", Gloss = "Holy", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the Holy Spirit"
                        }
                    },
                    Translation = "from the Holy Spirit"
                }
            },
            Translation = "Now the birth of Jesus Christ took place in this way. When his mother Mary had been betrothed to Joseph, before they came together she was found to be with child from the Holy Spirit."
        },

        // Verse 19
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
                        new Word { Greek = "Ἰωσὴφ", Transliteration = "Iōsēph", Gloss = "Joseph", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀνὴρ", Transliteration = "anēr", Gloss = "husband", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῆς", Transliteration = "autēs", Gloss = "of her", GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "her husband"
                        }
                    },
                    Translation = "And Joseph her husband"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δίκαιος", Transliteration = "dikaios", Gloss = "just", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ὢν", Transliteration = "ōn", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "being a just man"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                        new Word { Greek = "θέλων", Transliteration = "thelōn", Gloss = "willing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὴν", Transliteration = "autēn", Gloss = "her", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "δειγματίσαι", Transliteration = "deigmatisai", Gloss = "to disgrace", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "unwilling to put her to shame"
                },
                new Word { Greek = "ἐβουλήθη", Transliteration = "eboulēthē", Gloss = "resolved", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "λάθρᾳ", Transliteration = "lathra", Gloss = "secretly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἀπολῦσαι", Transliteration = "apolysai", Gloss = "to divorce", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτήν", Transliteration = "autēn", Gloss = "her", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pron" }
            },
            Translation = "And her husband Joseph, being a just man and unwilling to put her to shame, resolved to divorce her quietly."
        },

        // Verse 20
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
                        new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "as he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἐνθυμηθέντος", Transliteration = "enthymēthentos", Gloss = "considered", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "But as he considered these things"
                },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἄγγελος", Transliteration = "angelos", Gloss = "an angel", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "of the Lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "an angel of the Lord"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατ᾽", Transliteration = "kat'", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὄναρ", Transliteration = "onar", Gloss = "a dream", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in a dream"
                },
                new Word { Greek = "ἐφάνη", Transliteration = "ephanē", Gloss = "appeared", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "Ἰωσὴφ", Transliteration = "Iōsēph", Gloss = "Joseph", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "υἱὸς", Transliteration = "huios", Gloss = "son", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Δαυίδ", Transliteration = "Dauid", Gloss = "of David", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "son of David"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "do not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                                new Word { Greek = "φοβηθῇς", Transliteration = "phobēthēs", Gloss = "fear", GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "2P", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "παραλαβεῖν", Transliteration = "paralabein", Gloss = "to take", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "Μαρίαν", Transliteration = "Marian", Gloss = "Mary", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "γυναῖκά", Transliteration = "gynaika", Gloss = "wife", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "your", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "pron" }
                                    },
                                    Translation = "your wife"
                                }
                            },
                            Translation = "do not fear to take Mary as your wife"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "that which", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "αὐτῇ", Transliteration = "autē", Gloss = "her", GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" }, PartOfSpeech = "pron" }
                                    },
                                    Translation = "in her"
                                },
                                new Word { Greek = "γεννηθὲν", Transliteration = "gennēthen", Gloss = "conceived", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "πνεύματός", Transliteration = "pneumatos", Gloss = "Spirit", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                                new Word { Greek = "ἁγίου", Transliteration = "hagiou", Gloss = "Holy", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "S" }, PartOfSpeech = "adj" }
                                            },
                                            Translation = "is from the Holy Spirit"
                                        }
                                    },
                                    Translation = "is from the Holy Spirit"
                                }
                            },
                            Translation = "for that which is conceived in her is from the Holy Spirit"
                        }
                    },
                    Translation = "saying, 'Joseph, son of David, do not fear to take Mary as your wife, for that which is conceived in her is from the Holy Spirit.'"
                }
            },
            Translation = "But as he considered these things, behold, an angel of the Lord appeared to him in a dream, saying, 'Joseph, son of David, do not fear to take Mary as your wife, for that which is conceived in her is from the Holy Spirit.'"
        },

        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τέξεται", Transliteration = "texetai", Gloss = "she will bear", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "υἱόν", Transliteration = "huion", Gloss = "a son", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καλέσεις", Transliteration = "kaleseis", Gloss = "you shall call", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὄνομα", Transliteration = "onoma", Gloss = "name", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "his name"
                },
                new Word { Greek = "Ἰησοῦν", Transliteration = "Iēsoun", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σώσει", Transliteration = "sōsei", Gloss = "will save", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "λαὸν", Transliteration = "laon", Gloss = "people", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "his people"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἁμαρτιῶν", Transliteration = "hamartiōn", Gloss = "sins", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pron" }
                                    },
                                    Translation = "their sins"
                                }
                            },
                            Translation = "from their sins"
                        }
                    },
                    Translation = "for he will save his people from their sins"
                }
            },
            Translation = "She will bear a son, and you shall call his name Jesus, for he will save his people from their sins."
        },

        // Verse 22
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
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὅλον", Transliteration = "holon", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "Now all this"
                },
                new Word { Greek = "γέγονεν", Transliteration = "gegonen", Gloss = "took place", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "to", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "πληρωθῇ", Transliteration = "plērōthē", Gloss = "fulfill", GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "what", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ῥηθὲν", Transliteration = "rhēthen", Gloss = "was spoken", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "what was spoken"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "the Lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "by the Lord"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "προφήτου", Transliteration = "prophētou", Gloss = "prophet", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the prophet"
                                }
                            },
                            Translation = "through the prophet"
                        },
                        new Word { Greek = "λέγοντος", Transliteration = "legontos", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "to fulfill what was spoken by the Lord through the prophet, saying"
                }
            },
            Translation = "All this took place to fulfill what the Lord had spoken by the prophet:"
        },

        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "παρθένος", Transliteration = "parthenos", Gloss = "virgin", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the virgin"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "γαστρὶ", Transliteration = "gastri", Gloss = "womb", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "with child"
                },
                new Word { Greek = "ἕξει", Transliteration = "hexei", Gloss = "shall be", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τέξεται", Transliteration = "texetai", Gloss = "shall bear", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "υἱόν", Transliteration = "huion", Gloss = "a son", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καλέσουσιν", Transliteration = "kalesousin", Gloss = "they shall call", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὄνομα", Transliteration = "onoma", Gloss = "name", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "his name"
                },
                new Word { Greek = "Ἐμμανουήλ", Transliteration = "Emmanouēl", Gloss = "Immanuel", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅ", Transliteration = "ho", Gloss = "which", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "μεθερμηνευόμενον", Transliteration = "methermēneuomenon", Gloss = "translated", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μεθ᾽", Transliteration = "meth'", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "us", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "with us"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεός", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "God"
                        }
                    },
                    Translation = "which means, God with us"
                }
            },
            Translation = "'Behold, the virgin shall be with child and shall bear a son, and they shall call his name Immanuel' (which means, God with us)."
        },

        // Verse 24
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγερθεὶς", Transliteration = "egertheis", Gloss = "having arisen", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "then", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰωσὴφ", Transliteration = "Iōsēph", Gloss = "Joseph", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Joseph"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὕπνου", Transliteration = "hypnou", Gloss = "sleep", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "sleep"
                        }
                    },
                    Translation = "from sleep"
                },
                new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen", Gloss = "did", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "προσέταξεν", Transliteration = "prosetaxen", Gloss = "commanded", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἄγγελος", Transliteration = "angelos", Gloss = "angel", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "of the Lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the angel of the Lord"
                        }
                    },
                    Translation = "as the angel of the Lord commanded him"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "παρέλαβεν", Transliteration = "parelaben", Gloss = "he took", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γυναῖκα", Transliteration = "gynaika", Gloss = "wife", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "his wife"
                }
            },
            Translation = "When Joseph woke from sleep, he did as the angel of the Lord commanded him; he took his wife."
        }
    };
}

/*
Constructions identified:
- GEN_ABS: Verse 18 (μνηστευθείσης ... Μαρίας), Verse 20 (ταῦτα ... ἐνθυμηθέντος)
- APPOS: Verse 20 (υἱὸς Δαυίδ)
- REL_CLAUSE: Verse 23 (ὅ ἐστιν ...)
*/
