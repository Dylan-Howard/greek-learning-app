private static List<object> GetChapter14()
{
    // 1 Corinthians 14:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", Grammar_codes = new List<string> { "PRON", "NOM", "2P", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "μὲν", Transliteration = "men", Gloss = "on the one hand", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "καλῶς", Transliteration = "kalōs", Gloss = "well", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "εὐχαριστεῖς", Transliteration = "eucharisteis", Gloss = "you give thanks", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἕτερος", Transliteration = "heteros", Gloss = "other", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "the other person"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "οἰκοδομεῖται", Transliteration = "oikodomeitai", Gloss = "is built up", Grammar_codes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "For you indeed give thanks well, but the other person is not built up."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Εὐχαριστῶ", Transliteration = "Eucharistō", Gloss = "I thank", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", Grammar_codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", Grammar_codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "God"
                },
                new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "than all", Grammar_codes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", Grammar_codes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "more", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γλώσσαις", Transliteration = "glōssais", Gloss = "in tongues", Grammar_codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in tongues"
                },
                new Word { Greek = "λαλῶ", Transliteration = "lalō", Gloss = "I speak", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "I thank God, I speak in tongues more than all of you."
        },

        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ἐκκλησίᾳ", Transliteration = "ekklēsia", Gloss = "church", Grammar_codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in the church"
                },
                new Word { Greek = "θέλω", Transliteration = "thelō", Gloss = "I desire", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πέντε", Transliteration = "pente", Gloss = "five", Grammar_codes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "λόγους", Transliteration = "logous", Gloss = "words", Grammar_codes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "five words"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", Grammar_codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "νοΐ", Transliteration = "noi", Gloss = "mind", Grammar_codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", Grammar_codes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "with my mind"
                        },
                        new Word { Greek = "λαλῆσαι", Transliteration = "lalēsai", Gloss = "to speak", Grammar_codes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to speak five words with my mind"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "ἄλλους", Transliteration = "allous", Gloss = "others", Grammar_codes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "κατηχήσω", Transliteration = "katēchēsō", Gloss = "I might instruct", Grammar_codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "so that I may also instruct others"
                },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "than", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μυρίους", Transliteration = "myrious", Gloss = "ten thousand", Grammar_codes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "λόγους", Transliteration = "logous", Gloss = "words", Grammar_codes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "ten thousand words"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "γλώσσῃ", Transliteration = "glōssē", Gloss = "a tongue", Grammar_codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in a tongue"
                }
            },
            Translation = "Nevertheless, in the church I would rather speak five words with my mind, that I may also instruct others, than ten thousand words in a tongue."
        },

        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀδελφοί", Transliteration = "Adelphoi", Gloss = "Brothers", Grammar_codes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "noun" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "παιδία", Transliteration = "paidia", Gloss = "children", Grammar_codes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "noun" },
                new Word { Greek = "γίνεσθε", Transliteration = "ginesthe", Gloss = "be", Grammar_codes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "in the", Grammar_codes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "φρεσὶν", Transliteration = "phresin", Gloss = "thinking", Grammar_codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in your thinking"
                },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "in", Grammar_codes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "κακίᾳ", Transliteration = "kakia", Gloss = "evil", Grammar_codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in evil"
                },
                new Word { Greek = "νηπιάζετε", Transliteration = "nēpiazete", Gloss = "be infants", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "in the", Grammar_codes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "article" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "φρεσὶν", Transliteration = "phresin", Gloss = "thinking", Grammar_codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" },
                new Word { Greek = "τέλειοι", Transliteration = "teleioi", Gloss = "mature", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "γίνεσθε", Transliteration = "ginesthe", Gloss = "be", Grammar_codes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "P" }, PartOfSpeech = "verb" }
            },
            Translation = "Brothers, do not be children in your thinking. Be infants in evil, but in your thinking be mature."
        },

        // Verse 21
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
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "In", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", Grammar_codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "νόμῳ", Transliteration = "nomō", Gloss = "Law", Grammar_codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "In the Law"
                },
                new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it is written", Grammar_codes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ἑτερογλώσσοις", Transliteration = "heteroglōssois", Gloss = "those of strange tongues", Grammar_codes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "by people of strange tongues"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "χείλεσιν", Transliteration = "cheilesin", Gloss = "lips", Grammar_codes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἑτέρων", Transliteration = "heterōn", Gloss = "of others", Grammar_codes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "by the lips of strangers"
                        },
                        new Word { Greek = "λαλήσω", Transliteration = "lalēsō", Gloss = "I will speak", Grammar_codes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", Grammar_codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "λαῷ", Transliteration = "laō", Gloss = "people", Grammar_codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "τούτῳ", Transliteration = "toutō", Gloss = "this", Grammar_codes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "to this people"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "οὐδ᾽", Transliteration = "oud'", Gloss = "not even", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "thus", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "εἰσακούσονταί", Transliteration = "eisakousontai", Gloss = "they will listen", Grammar_codes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "to me", Grammar_codes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "that by people of strange tongues and by the lips of strangers I will speak to this people, and even then they will not listen to me"
                },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "says", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "the Lord", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
            },
            Translation = "In the Law it is written: 'By people of strange tongues and by the lips of strangers I will speak to this people, and even then they will not listen to me,' says the Lord."
        },

        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὥστε", Transliteration = "hōste", Gloss = "Thus", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἱ", Transliteration = "hai", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "F", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "γλῶσσαι", Transliteration = "glōssai", Gloss = "tongues", Grammar_codes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "tongues"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "σημεῖόν", Transliteration = "sēmeion", Gloss = "a sign", Grammar_codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "for a sign"
                },
                new Word { Greek = "εἰσιν", Transliteration = "eisin", Gloss = "are", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the", Grammar_codes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "πιστεύουσιν", Transliteration = "pisteuousin", Gloss = "believers", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to those who believe"
                },
                new Word { Greek = "ἀλλά", Transliteration = "alla", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the", Grammar_codes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἀπίστοις", Transliteration = "apistois", Gloss = "unbelievers", Grammar_codes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "to unbelievers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "προφητεία", Transliteration = "prophēteia", Gloss = "prophecy", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "prophecy"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "is not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the", Grammar_codes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἀπίστοις", Transliteration = "apistois", Gloss = "unbelievers", Grammar_codes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "to unbelievers"
                },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the", Grammar_codes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "πιστεύουσιν", Transliteration = "pisteuousin", Gloss = "believers", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to those who believe"
                }
            },
            Translation = "Thus tongues are for a sign, not to those who believe but to unbelievers; but prophecy is not for unbelievers but for those who believe."
        },

        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἐὰν", Transliteration = "Ean", Gloss = "If", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "συνέλθῃ", Transliteration = "synelthē", Gloss = "comes together", Grammar_codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἐκκλησία", Transliteration = "ekklēsia", Gloss = "church", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ὅλη", Transliteration = "holē", Gloss = "whole", Grammar_codes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "the whole church"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "αὐτὸ", Transliteration = "auto", Gloss = "same place", Grammar_codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "to the same place"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "λαλῶσιν", Transliteration = "lalōsin", Gloss = "should speak", Grammar_codes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γλώσσαις", Transliteration = "glōssais", Gloss = "in tongues", Grammar_codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in tongues"
                },
                new Word { Greek = "εἰσέλθωσιν", Transliteration = "eiselthōsin", Gloss = "should enter", Grammar_codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἰδιῶται", Transliteration = "idiōtai", Gloss = "uninstructed people", Grammar_codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἄπιστοι", Transliteration = "apistoi", Gloss = "unbelievers", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "ἐροῦσιν", Transliteration = "erousin", Gloss = "will they say", Grammar_codes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "μαίνεσθε", Transliteration = "mainesthe", Gloss = "you are out of your minds", Grammar_codes = new List<string> { "V", "PRES", "MP", "IND", "2P", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "that you are out of your minds"
                }
            },
            Translation = "If, therefore, the whole church comes together and all speak in tongues, and uninstructed people or unbelievers enter, will they not say that you are out of your minds?"
        },

        // Verse 24
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "If", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "προφητεύωσιν", Transliteration = "prophēteuōsin", Gloss = "should prophesy", Grammar_codes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "εἰσέλθῃ", Transliteration = "eiselthē", Gloss = "should enter", Grammar_codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "τις", Transliteration = "tis", Gloss = "someone", Grammar_codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "ἄπιστος", Transliteration = "apistos", Gloss = "an unbeliever", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἰδιώτης", Transliteration = "idiōtēs", Gloss = "an uninstructed person", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                new Word { Greek = "ἐλέγχεται", Transliteration = "elenchetai", Gloss = "he is convicted", Grammar_codes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all", Grammar_codes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "by all"
                },
                new Word { Greek = "ἀνακρίνεται", Transliteration = "anakrinetai", Gloss = "he is examined", Grammar_codes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all", Grammar_codes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "by all"
                }
            },
            Translation = "But if all prophesy, and an unbeliever or uninstructed person enters, he is convicted by all, he is called to account by all."
        }
    };
}

/* Identified Constructions:
 * v19: PURPOSE_CLAUSE (ἵνα + subjunctive)
 * v21: CAUSAL_CLAUSE (ὅτι as direct discourse/citation)
 * v22: NOUN_PHRASE/IND_OBJ (Substantival participles)
 * v23: COND_CLAUSE (Ἐὰν + subjunctive)
 * v24: COND_CLAUSE (ἐὰν + subjunctive)
 */
