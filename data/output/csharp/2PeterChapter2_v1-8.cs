private static List<object> GetChapter2()
{
    // 2 Peter 2:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἐγένοντο", Transliteration = "Egenonto", Gloss = "arose", Grammar_Codes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ψευδοπροφῆται", Transliteration = "pseudoprophētai", Gloss = "false prophets", Grammar_Codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "false prophets"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", Grammar_Codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "λαῷ", Transliteration = "laō", Gloss = "people", Grammar_Codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the people"
                        }
                    },
                    Translation = "among the people"
                }
            },
            Translation = "But false prophets also arose among the people,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you", Grammar_Codes = new List<string> { "PRON", "DAT", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "among you"
                },
                new Word { Greek = "ἔσονται", Transliteration = "esontai", Gloss = "will be", Grammar_Codes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ψευδοδιδάσκαλοι", Transliteration = "pseudodidaskaloi", Gloss = "false teachers", Grammar_Codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "false teachers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἵτινες", Transliteration = "hoitines", Gloss = "who", Grammar_Codes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "παρεισάξουσιν", Transliteration = "pareisaxousin", Gloss = "will secretly bring in", Grammar_Codes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αἱρέσεις", Transliteration = "haireseis", Gloss = "heresies", Grammar_Codes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἀπωλείας", Transliteration = "apōleias", Gloss = "of destruction", Grammar_Codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "destructive heresies"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "even", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἀγοράσαντα", Transliteration = "agorasanta", Gloss = "having bought", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "verb" },
                                        new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "them", Grammar_Codes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pronoun" },
                                        new Word { Greek = "δεσπότην", Transliteration = "despotēn", Gloss = "Master", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the Master who bought them"
                                },
                                new Word { Greek = "ἀρνούμενοι", Transliteration = "arnoumenoi", Gloss = "denying", Grammar_Codes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "denying even the Master who bought them"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπάγοντες", Transliteration = "epagontes", Gloss = "bringing upon", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" },
                                new Word { Greek = "ἑαυτοῖς", Transliteration = "heautois", Gloss = "themselves", Grammar_Codes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ταχινὴν", Transliteration = "tachinēn", Gloss = "swift", Grammar_Codes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adjective" },
                                        new Word { Greek = "ἀπώλειαν", Transliteration = "apōleian", Gloss = "destruction", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "swift destruction"
                                }
                            },
                            Translation = "bringing upon themselves swift destruction"
                        }
                    },
                    Translation = "who will secretly bring in destructive heresies, even denying the Master who bought them, bringing upon themselves swift destruction."
                }
            },
            Translation = "just as there will also be false teachers among you, who will secretly bring in destructive heresies, even denying the Master who bought them, bringing upon themselves swift destruction."
        },
        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "πολλοὶ", Transliteration = "polloi", Gloss = "many", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "ἐξακολουθήσουσιν", Transliteration = "exakolouthēsousin", Gloss = "will follow", Grammar_Codes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "their", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "the", Grammar_Codes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἀσελγείαις", Transliteration = "aselgeiais", Gloss = "sensuality", Grammar_Codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "their sensuality"
                }
            },
            Translation = "And many will follow their sensuality,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "because of", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "οὓς", Transliteration = "hous", Gloss = "whom", Grammar_Codes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "because of whom"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ὁδὸς", Transliteration = "hodos", Gloss = "way", Grammar_Codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of the", Grammar_Codes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἀληθείας", Transliteration = "alētheias", Gloss = "truth", Grammar_Codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "of the truth"
                        }
                    },
                    Translation = "the way of truth"
                },
                new Word { Greek = "βλασφημηθήσεται", Transliteration = "blasphēmēthēsetai", Gloss = "will be maligned", Grammar_Codes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "because of whom the way of truth will be maligned."
        },
        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "πλεονεξίᾳ", Transliteration = "pleonexia", Gloss = "greed", Grammar_Codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in greed"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πλαστοῖς", Transliteration = "plastois", Gloss = "exploitative", Grammar_Codes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "λόγοις", Transliteration = "logois", Gloss = "words", Grammar_Codes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "with exploitative words"
                },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", Grammar_Codes = new List<string> { "PRON", "ACC", "P" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "ἐμπορεύσονται", Transliteration = "emporeusontai", Gloss = "they will exploit", Grammar_Codes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" }
            },
            Translation = "And in greed they will exploit you with exploitative words."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οἷς", Transliteration = "hois", Gloss = "for whom", Grammar_Codes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "κρίμα", Transliteration = "krima", Gloss = "judgment", Grammar_Codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the judgment"
                },
                new Word { Greek = "ἔκπαλαι", Transliteration = "ekpalai", Gloss = "long ago", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                new Word { Greek = "ἀργεῖ", Transliteration = "argei", Gloss = "is idle", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἀπώλεια", Transliteration = "apōleia", Gloss = "destruction", Grammar_Codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "their", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "their destruction"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                new Word { Greek = "νυστάζει", Transliteration = "nystazei", Gloss = "is slumbering", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "for whom the judgment from long ago is not idle, and their destruction is not slumbering."
        },
        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Εἰ", Transliteration = "Ei", Gloss = "For if", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀγγέλων", Transliteration = "angelōn", Gloss = "angels", Grammar_Codes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ἁμαρτησάντων", Transliteration = "hamartēsantōn", Gloss = "having sinned", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "angels when they sinned"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                new Word { Greek = "ἐφείσατο", Transliteration = "epheisato", Gloss = "spared", Grammar_Codes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "σειραῖς", Transliteration = "seirais", Gloss = "with chains", Grammar_Codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ζόφου", Transliteration = "zophou", Gloss = "of darkness", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "in chains of gloomy darkness"
                        },
                        new Word { Greek = "ταρταρώσας", Transliteration = "tartarōsas", Gloss = "casting into Tartarus", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "casting them into Tartarus"
                },
                new Word { Greek = "παρέδωκεν", Transliteration = "paredōken", Gloss = "he delivered", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "κρίσιν", Transliteration = "krisin", Gloss = "judgment", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "for judgment"
                },
                new Word { Greek = "τηρουμένους", Transliteration = "tēroumenous", Gloss = "being kept", Grammar_Codes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "verb" }
            },
            Translation = "For if God did not spare angels when they sinned, but cast them into Tartarus and committed them to chains of gloomy darkness to be kept until the judgment;"
        },
        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 4)
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀρχαίου", Transliteration = "archaiou", Gloss = "ancient", Grammar_Codes = new List<string> { "ADJ", "GEN", "M", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "κόσμου", Transliteration = "kosmou", Gloss = "world", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the ancient world"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                new Word { Greek = "ἐφείσατο", Transliteration = "epheisato", Gloss = "spared", Grammar_Codes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὄγδοον", Transliteration = "ogdoon", Gloss = "eighth", Grammar_Codes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "Νῶε", Transliteration = "Nōe", Gloss = "Noah", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "APPOS" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "δικαιοσύνης", Transliteration = "dikaiosynēs", Gloss = "of righteousness", Grammar_Codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "κήρυκα", Transliteration = "kēryka", Gloss = "herald", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "a herald of righteousness"
                                }
                            },
                            Translation = "a herald of righteousness"
                        }
                    },
                    Translation = "Noah, a herald of righteousness, with seven others"
                },
                new Word { Greek = "ἐφύλαξεν", Transliteration = "ephylaxen", Gloss = "he preserved", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατακλυσμὸν", Transliteration = "kataklysmon", Gloss = "a flood", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κόσμῳ", Transliteration = "kosmō", Gloss = "upon the world", Grammar_Codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἀσεβῶν", Transliteration = "asebōn", Gloss = "of ungodly people", Grammar_Codes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "upon the world of the ungodly"
                        },
                        new Word { Greek = "ἐπάξας", Transliteration = "epaxas", Gloss = "bringing", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "bringing a flood upon the world of the ungodly"
                }
            },
            Translation = "and did not spare the ancient world, but preserved Noah, a herald of righteousness, with seven others, when he brought a flood upon the world of the ungodly;"
        },
        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 4)
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πόλεις", Transliteration = "poleis", Gloss = "cities", Grammar_Codes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "Σοδόμων", Transliteration = "Sodomōn", Gloss = "of Sodom", Grammar_Codes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "Γομόρρας", Transliteration = "Gomorrhas", Gloss = "Gomorrah", Grammar_Codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the cities of Sodom and Gomorrah"
                        },
                        new Word { Greek = "τεφρώσας", Transliteration = "tephrōsas", Gloss = "turning to ashes", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "by turning the cities of Sodom and Gomorrah to ashes"
                },
                new Word { Greek = "καταστροφῇ", Transliteration = "katastrophē", Gloss = "with an overthrow", Grammar_Codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                new Word { Greek = "κατέκρινεν", Transliteration = "katekrinen", Gloss = "he condemned them", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπόδειγμα", Transliteration = "hypodeigma", Gloss = "an example", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μελλόντων", Transliteration = "mellontōn", Gloss = "of those about", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "verb" },
                                new Word { Greek = "ἀσεβεῖν", Transliteration = "asebein", Gloss = "to live ungodly lives", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" }
                            },
                            Translation = "of what is going to happen to the ungodly"
                        },
                        new Word { Greek = "τεθεικὼς", Transliteration = "tetheikōs", Gloss = "having made", Grammar_Codes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "making them an example of what is going to happen to the ungodly"
                }
            },
            Translation = "and if by turning the cities of Sodom and Gomorrah to ashes he condemned them to extinction, making them an example of what is going to happen to the ungodly;"
        },
        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 4)
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δίκαιον", Transliteration = "dikaion", Gloss = "righteous", Grammar_Codes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "Λὼτ", Transliteration = "Lōt", Gloss = "Lot", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "righteous Lot"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καταπονούμενον", Transliteration = "kataponoumenon", Gloss = "greatly distressed", Grammar_Codes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "article" },
                                                new Word { Greek = "ἀθέσμων", Transliteration = "athesmōn", Gloss = "unprincipled men", Grammar_Codes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" }
                                            },
                                            Translation = "of the unprincipled men"
                                        },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                                new Word { Greek = "ἀσελγείᾳ", Transliteration = "aselgeia", Gloss = "sensuality", Grammar_Codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                                            },
                                            Translation = "in sensuality"
                                        },
                                        new Word { Greek = "ἀναστροφῆς", Transliteration = "anastrophēs", Gloss = "conduct", Grammar_Codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the sensual conduct of unprincipled men"
                                }
                            },
                            Translation = "by the sensual conduct of unprincipled men"
                        }
                    },
                    Translation = "greatly distressed by the sensual conduct of unprincipled men"
                },
                new Word { Greek = "ἐρρύσατο", Transliteration = "errysato", Gloss = "he rescued", Grammar_Codes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "and if he rescued righteous Lot, greatly distressed by the sensual conduct of unprincipled men"
        },
        // Verse 8
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
                        new Word { Greek = "βλέμματι", Transliteration = "blemmati", Gloss = "by what he saw", Grammar_Codes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἀκοῇ", Transliteration = "akoē", Gloss = "heard", Grammar_Codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "for as that righteous man lived among them day after day, he was tormenting his righteous soul over their lawless deeds that he saw and heard"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "δίκαιος", Transliteration = "dikaios", Gloss = "righteous man", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "the righteous man"
                },
                new Word { Greek = "ἐγκατοικῶν", Transliteration = "enkatoikōn", Gloss = "dwelling", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", Grammar_Codes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "among them"
                },
                new Word { Greek = "ἡμέραν", Transliteration = "hēmeran", Gloss = "day", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "after", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ἡμέρας", Transliteration = "hēmeras", Gloss = "day", Grammar_Codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "after day"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ψυχὴν", Transliteration = "psychēn", Gloss = "soul", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "δικαίαν", Transliteration = "dikaian", Gloss = "righteous", Grammar_Codes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "his righteous soul"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνόμοις", Transliteration = "anomois", Gloss = "by lawless", Grammar_Codes = new List<string> { "ADJ", "DAT", "N", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἔργοις", Transliteration = "ergois", Gloss = "deeds", Grammar_Codes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "because of their lawless deeds"
                },
                new Word { Greek = "ἐβασάνιζεν", Transliteration = "ebasanizen", Gloss = "he was tormenting", Grammar_Codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "(for as that righteous man lived among them day after day, he was tormenting his righteous soul over their lawless deeds that he saw and heard)"
        }
    };
}

/*
Constructions identified:
- 2 Pet 2:1: REL_CLAUSE (οἵτινες παρεισάξουσιν...)
- 2 Pet 2:2: CAUSAL_CLAUSE (δι᾽ οὓς ἡ ὁδὸς...)
- 2 Pet 2:3: REL_CLAUSE (οἷς τὸ κρίμα...)
- 2 Pet 2:4: COND_CLAUSE (Εἰ γὰρ ὁ θεὸς...) - Protasis of a long conditional sentence continuing through verse 8.
- 2 Pet 2:5: APPOS (δικαιοσύνης κήρυκα) - Appositive to Noah.
- 2 Pet 2:8: DAT_INSTR (βλέμματι καὶ ἀκοῇ) - Dative of means/instrument.
*/
