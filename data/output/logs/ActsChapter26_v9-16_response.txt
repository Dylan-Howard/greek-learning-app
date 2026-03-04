private static List<object> GetChapter26()
{
    // Acts 26:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἐγὼ", Transliteration = "Egō", Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed",
                    GrammarCodes = new List<string> { "PART" },
                    PartOfSpeech = "particle" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "ἔδοξα", Transliteration = "edoxa", Gloss = "I thought",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "ἐμαυτῷ", Transliteration = "emautō", Gloss = "myself",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "against",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "ὄνομα", Transliteration = "onoma", Gloss = "name",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                    PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "of Jesus",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "noun" },
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "article" },
                                        new Word { Greek = "Ναζωραίου", Transliteration = "Nazōraiou", Gloss = "Nazarene",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "noun" }
                                    },
                                    Translation = "of Jesus the Nazarene"
                                }
                            },
                            Translation = "the name"
                        },
                        new Word { Greek = "δεῖν", Transliteration = "dein", Gloss = "to be necessary",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "πολλὰ", Transliteration = "polla", Gloss = "many things",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adjective" },
                        new Word { Greek = "ἐναντία", Transliteration = "enantia", Gloss = "contrary",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" },
                            PartOfSpeech = "adjective" },
                        new Word { Greek = "πρᾶξαι", Transliteration = "praxai", Gloss = "to do",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "to do many things contrary to the name of Jesus of Nazareth"
                }
            },
            Translation = "I myself therefore thought it necessary to do many things contrary to the name of Jesus of Nazareth."
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐποίησα", Transliteration = "epoiēsa", Gloss = "I did",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "Ἱεροσολύμοις", Transliteration = "Hierosolymois", Gloss = "Jerusalem",
                            GrammarCodes = new List<string> { "N", "DAT", "N", "P" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "in Jerusalem"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πολλούς", Transliteration = "pollous", Gloss = "many",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" },
                            PartOfSpeech = "adjective" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "ἁγίων", Transliteration = "hagiōn", Gloss = "saints",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                            PartOfSpeech = "adjective" }
                    },
                    Translation = "and many of the saints"
                },
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "φυλακαῖς", Transliteration = "phylakais", Gloss = "prisons",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "P" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "in prisons"
                },
                new Word { Greek = "κατέκλεισα", Transliteration = "katekleisa", Gloss = "locked up",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "article" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παρὰ", Transliteration = "para", Gloss = "from",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "ἀρχιερέων", Transliteration = "archiereōn", Gloss = "chief priests",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "from the chief priests"
                        },
                        new Word { Greek = "ἐξουσίαν", Transliteration = "exousian", Gloss = "authority",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "the authority"
                },
                new Word { Greek = "λαβὼν", Transliteration = "labōn", Gloss = "having received",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀναιρουμένων", Transliteration = "anairoumenōn", Gloss = "being killed",
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "GEN", "M", "P" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "they",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "and when they were being put to death"
                },
                new Word { Greek = "κατήνεγκα", Transliteration = "katēnenka", Gloss = "I cast",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "ψῆφον", Transliteration = "psēphon", Gloss = "vote",
                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                    PartOfSpeech = "noun" }
            },
            Translation = "And this I did in Jerusalem; I not only locked up many of the saints in prisons, having received authority from the chief priests, but when they were being put to death I cast my vote against them."
        },
        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "throughout",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "πάσας", Transliteration = "pasas", Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                            PartOfSpeech = "adjective" },
                        new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "συναγωγὰς", Transliteration = "synagōgas", Gloss = "synagogues",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "throughout all the synagogues"
                },
                new Word { Greek = "πολλάκις", Transliteration = "pollakis", Gloss = "often",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τιμωρῶν", Transliteration = "timōrōn", Gloss = "punishing",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "them",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "punishing them"
                },
                new Word { Greek = "ἠνάγκαζον", Transliteration = "ēnankazon", Gloss = "I tried to compel",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "βλασφημεῖν", Transliteration = "blasphēmein", Gloss = "to blaspheme",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "περισσῶς", Transliteration = "perissōs", Gloss = "exceedingly",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adverb" },
                new Word { Greek = "τε", Transliteration = "te", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐμμαινόμενος", Transliteration = "emmainomenos", Gloss = "being enraged",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "at them",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "being enraged at them"
                },
                new Word { Greek = "ἐδίωκον", Transliteration = "ediōkon", Gloss = "I pursued",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "even",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "to",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "P" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "ἔξω", Transliteration = "exō", Gloss = "foreign",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" },
                            PartOfSpeech = "adjective" },
                        new Word { Greek = "πόλεις", Transliteration = "poleis", Gloss = "cities",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "P" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "even to foreign cities"
                }
            },
            Translation = "And punishing them often in all the synagogues, I tried to compel them to blaspheme; and being exceedingly enraged at them, I pursued them even to foreign cities."
        },
        // Verse 12
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
                        new Word { Greek = "Ἐν", Transliteration = "En", Gloss = "In",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "οἷς", Transliteration = "hois", Gloss = "which [circumstances]",
                            GrammarCodes = new List<string> { "PRON", "DAT", "N", "P" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "In which"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πορευόμενος", Transliteration = "poreuomenos", Gloss = "journeying",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "Δαμασκὸν", Transliteration = "Damaskon", Gloss = "Damascus",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "to Damascus"
                        }
                    },
                    Translation = "journeying to Damascus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετ᾽", Transliteration = "met'", Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "ἐξουσίας", Transliteration = "exousias", Gloss = "authority",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἐπιτροπῆς", Transliteration = "epitropēs", Gloss = "commission",
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "ἀρχιερέων", Transliteration = "archiereōn", Gloss = "chief priests",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "P" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "with authority and commission from the chief priests"
                }
            },
            Translation = "In this connection, as I was journeying to Damascus with authority and commission from the chief priests,"
        },
        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἡμέρας", Transliteration = "hēmeras", Gloss = "of day",
                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                    PartOfSpeech = "noun" },
                new Word { Greek = "μέσης", Transliteration = "mesēs", Gloss = "mid-",
                    GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" },
                    PartOfSpeech = "adjective" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "along",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "ὁδὸν", Transliteration = "hodon", Gloss = "way",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "along the way"
                },
                new Word { Greek = "εἶδον", Transliteration = "eidon", Gloss = "I saw",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "βασιλεῦ", Transliteration = "basileu", Gloss = "O king",
                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                    PartOfSpeech = "noun" },
                new Word { Greek = "οὐρανόθεν", Transliteration = "ouranothen", Gloss = "from heaven",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "above",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "λαμπρότητα", Transliteration = "lamprotēta", Gloss = "brightness",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the",
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "ἡλίου", Transliteration = "hēliou", Gloss = "sun",
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "above the brightness of the sun"
                },
                new Word { Greek = "περιλάμψαν", Transliteration = "perilampsan", Gloss = "shining around",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "N", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "φῶς", Transliteration = "phōs", Gloss = "a light",
                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                    PartOfSpeech = "noun" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "those",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "article" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "σὺν", Transliteration = "syn", Gloss = "with",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "ἐμοὶ", Transliteration = "emoi", Gloss = "me",
                                    GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "with me"
                        },
                        new Word { Greek = "πορευομένους", Transliteration = "poreuomenous", Gloss = "journeying",
                            GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "ACC", "M", "P" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "those journeying with me"
                }
            },
            Translation = "at midday, O king, I saw on the way a light from heaven, brighter than the sun, shining around me and those who journeyed with me."
        },
        // Verse 14
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
                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all",
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                            PartOfSpeech = "adjective" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "καταπεσόντων", Transliteration = "katapesontōn", Gloss = "having fallen down",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "P" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us",
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "and when we had all fallen"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "F", "S" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "γῆν", Transliteration = "gēn", Gloss = "ground",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "to the ground"
                },
                new Word { Greek = "ἤκουσα", Transliteration = "ēkousa", Gloss = "I heard",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φωνὴν", Transliteration = "phōnēn", Gloss = "a voice",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "λέγουσαν", Transliteration = "legousan", Gloss = "saying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "F", "S" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρός", Transliteration = "pros", Gloss = "to",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "preposition" },
                                new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                                    PartOfSpeech = "pronoun" }
                            },
                            Translation = "to me"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "in the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "article" },
                                new Word { Greek = "Ἑβραΐδι", Transliteration = "Hebraïdi", Gloss = "Hebrew",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" },
                                    PartOfSpeech = "adjective" },
                                new Word { Greek = "διαλέκτῳ", Transliteration = "dialektō", Gloss = "dialect",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "in the Hebrew language"
                        }
                    },
                    Translation = "a voice saying to me in the Hebrew language"
                },
                new Word { Greek = "Σαοὺλ", Transliteration = "Saoul", Gloss = "Saul",
                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                    PartOfSpeech = "noun" },
                new Word { Greek = "Σαούλ", Transliteration = "Saoul", Gloss = "Saul",
                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                    PartOfSpeech = "noun" },
                new Word { Greek = "τί", Transliteration = "ti", Gloss = "why",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "διώκεις", Transliteration = "diōkeis", Gloss = "do you persecute",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "σκληρόν", Transliteration = "sklēron", Gloss = "hard",
                    GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                    PartOfSpeech = "adjective" },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "for you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "against",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "κέντρα", Transliteration = "kentra", Gloss = "goads",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "against the goads"
                },
                new Word { Greek = "λακτίζειν", Transliteration = "laktizein", Gloss = "to kick",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" },
                    PartOfSpeech = "verb" }
            },
            Translation = "And when we had all fallen to the ground, I heard a voice saying to me in the Hebrew language, 'Saul, Saul, why are you persecuting me? It is hard for you to kick against the goads.'"
        },
        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "εἶπα", Transliteration = "eipa", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "τίς", Transliteration = "tis", Gloss = "Who",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "εἶ", Transliteration = "ei", Gloss = "are you",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "κύριε", Transliteration = "kyrie", Gloss = "Lord",
                    GrammarCodes = new List<string> { "N", "VOC", "M", "S" },
                    PartOfSpeech = "noun" },
                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                    GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                    PartOfSpeech = "article" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "And",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "noun" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "ἐγώ", Transliteration = "egō", Gloss = "I",
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "εἰμι", Transliteration = "eimi", Gloss = "am",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "noun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "whom",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "διώκεις", Transliteration = "diōkeis", Gloss = "persecute",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "whom you are persecuting"
                }
            },
            Translation = "And I said, 'Who are you, Lord?' And the Lord said, 'I am Jesus whom you are persecuting.'"
        },
        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "But",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "ἀνάστηθι", Transliteration = "anasthēthi", Gloss = "rise",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "στῆθι", Transliteration = "stēthi", Gloss = "stand",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "upon",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" },
                            PartOfSpeech = "article" },
                        new Word { Greek = "πόδας", Transliteration = "podas", Gloss = "feet",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you",
                            GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "upon your feet"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "preposition" },
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "for this [purpose]"
                },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conjunction" },
                new Word { Greek = "ὤφθην", Transliteration = "ōphthēn", Gloss = "I have appeared",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "1P", "S" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you",
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προχειρίσασθαί", Transliteration = "procheirisasthai", Gloss = "to appoint",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "INF" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "σε", Transliteration = "se", Gloss = "you",
                            GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "ὑπηρέτην", Transliteration = "hypēretēn", Gloss = "a servant",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "noun" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "μάρτυρα", Transliteration = "martyra", Gloss = "a witness",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "to appoint you as a servant and a witness"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "of which",
                            GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "both",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "εἶδές", Transliteration = "eides", Gloss = "you saw",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "με", Transliteration = "me", Gloss = "me",
                            GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "both of the things in which you have seen me"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "and of which",
                            GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" },
                            PartOfSpeech = "pronoun" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conjunction" },
                        new Word { Greek = "ὀφθήσομαί", Transliteration = "ophthēsomai", Gloss = "I will appear",
                            GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "1P", "S" },
                            PartOfSpeech = "verb" },
                        new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you",
                            GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" },
                            PartOfSpeech = "pronoun" }
                    },
                    Translation = "and of those things in which I will appear to you"
                }
            },
            Translation = "But rise and stand upon your feet, for I have appeared to you for this purpose, to appoint you as a servant and a witness both to the things in which you have seen me and to those in which I will appear to you."
        }
    };
}

/*
Identified Constructions:
- GEN_ABS: Acts 26:10 (ἀναιρουμένων τε αὐτῶν)
- GEN_ABS: Acts 26:14 (πάντων τε καταπεσόντων ἡμῶν)
- INF_PHRASE: Acts 26:9 (πρᾶξαι), Acts 26:11 (βλασφημεῖν), Acts 26:14 (λακτίζειν), Acts 26:16 (προχειρίσασθαί)
*/
