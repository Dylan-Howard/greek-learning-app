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
                new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "μὲν", Transliteration = "men", Gloss = "on the one hand", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "καλῶς", Transliteration = "kalōs", Gloss = "well", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "εὐχαριστεῖς", Transliteration = "eucharisteis", Gloss = "you give thanks", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἕτερος", Transliteration = "heteros", Gloss = "other", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "the other person"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "οἰκοδομεῖται", Transliteration = "oikodomeitai", Gloss = "is built up", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "For you indeed give thanks well, but the other person is not built up."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Εὐχαριστῶ", Transliteration = "Eucharistō", Gloss = "I thank", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "God"
                },
                new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "than all", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "more", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γλώσσαις", Transliteration = "glōssais", Gloss = "in tongues", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in tongues"
                },
                new Word { Greek = "λαλῶ", Transliteration = "lalō", Gloss = "I speak", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "I thank God, I speak in tongues more than all of you."
        },

        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ἐκκλησίᾳ", Transliteration = "ekklēsia", Gloss = "church", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in the church"
                },
                new Word { Greek = "θέλω", Transliteration = "thelō", Gloss = "I desire", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
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
                                new Word { Greek = "πέντε", Transliteration = "pente", Gloss = "five", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "λόγους", Transliteration = "logous", Gloss = "words", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "five words"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "νοΐ", Transliteration = "noi", Gloss = "mind", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "with my mind"
                        },
                        new Word { Greek = "λαλῆσαι", Transliteration = "lalēsai", Gloss = "to speak", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to speak five words with my mind"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "ἄλλους", Transliteration = "allous", Gloss = "others", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "κατηχήσω", Transliteration = "katēchēsō", Gloss = "I might instruct", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "so that I may also instruct others"
                },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "than", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μυρίους", Transliteration = "myrious", Gloss = "ten thousand", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "λόγους", Transliteration = "logous", Gloss = "words", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "ten thousand words"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "γλώσσῃ", Transliteration = "glōssē", Gloss = "a tongue", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
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
                new Word { Greek = "Ἀδελφοί", Transliteration = "Adelphoi", Gloss = "Brothers", GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "noun" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "παιδία", Transliteration = "paidia", Gloss = "children", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "noun" },
                new Word { Greek = "γίνεσθε", Transliteration = "ginesthe", Gloss = "be", GrammarCodes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "in the", GrammarCodes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "φρεσὶν", Transliteration = "phresin", Gloss = "thinking", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in your thinking"
                },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "in", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "κακίᾳ", Transliteration = "kakia", Gloss = "evil", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in evil"
                },
                new Word { Greek = "νηπιάζετε", Transliteration = "nēpiazete", Gloss = "be infants", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "in the", GrammarCodes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "article" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "φρεσὶν", Transliteration = "phresin", Gloss = "thinking", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" },
                new Word { Greek = "τέλειοι", Transliteration = "teleioi", Gloss = "mature", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "γίνεσθε", Transliteration = "ginesthe", Gloss = "be", GrammarCodes = new List<string> { "V", "PRES", "MP", "IMP", "2P", "P" }, PartOfSpeech = "verb" }
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
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "In", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "νόμῳ", Transliteration = "nomō", Gloss = "Law", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "In the Law"
                },
                new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it is written", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ἑτερογλώσσοις", Transliteration = "heteroglōssois", Gloss = "those of strange tongues", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "by people of strange tongues"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "χείλεσιν", Transliteration = "cheilesin", Gloss = "lips", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἑτέρων", Transliteration = "heterōn", Gloss = "of others", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "by the lips of strangers"
                        },
                        new Word { Greek = "λαλήσω", Transliteration = "lalēsō", Gloss = "I will speak", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "λαῷ", Transliteration = "laō", Gloss = "people", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "τούτῳ", Transliteration = "toutō", Gloss = "this", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "to this people"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "οὐδ᾽", Transliteration = "oud'", Gloss = "not even", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "thus", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "εἰσακούσονταί", Transliteration = "eisakousontai", Gloss = "they will listen", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "to me", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "that by people of strange tongues and by the lips of strangers I will speak to this people, and even then they will not listen to me"
                },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "says", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "the Lord", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
            },
            Translation = "In the Law it is written: 'By people of strange tongues and by the lips of strangers I will speak to this people, and even then they will not listen to me,' says the Lord."
        },

        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὥστε", Transliteration = "hōste", Gloss = "Thus", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἱ", Transliteration = "hai", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "γλῶσσαι", Transliteration = "glōssai", Gloss = "tongues", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "tongues"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "σημεῖόν", Transliteration = "sēmeion", Gloss = "a sign", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "for a sign"
                },
                new Word { Greek = "εἰσιν", Transliteration = "eisin", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "πιστεύουσιν", Transliteration = "pisteuousin", Gloss = "believers", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "to those who believe"
                },
                new Word { Greek = "ἀλλά", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἀπίστοις", Transliteration = "apistois", Gloss = "unbelievers", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "to unbelievers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "προφητεία", Transliteration = "prophēteia", Gloss = "prophecy", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "prophecy"
                },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "is not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἀπίστοις", Transliteration = "apistois", Gloss = "unbelievers", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "to unbelievers"
                },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "πιστεύουσιν", Transliteration = "pisteuousin", Gloss = "believers", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "M", "P" }, PartOfSpeech = "verb" }
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
                new Word { Greek = "Ἐὰν", Transliteration = "Ean", Gloss = "If", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "συνέλθῃ", Transliteration = "synelthē", Gloss = "comes together", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἐκκλησία", Transliteration = "ekklēsia", Gloss = "church", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ὅλη", Transliteration = "holē", Gloss = "whole", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "the whole church"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "αὐτὸ", Transliteration = "auto", Gloss = "same place", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "to the same place"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "λαλῶσιν", Transliteration = "lalōsin", Gloss = "should speak", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γλώσσαις", Transliteration = "glōssais", Gloss = "in tongues", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in tongues"
                },
                new Word { Greek = "εἰσέλθωσιν", Transliteration = "eiselthōsin", Gloss = "should enter", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἰδιῶται", Transliteration = "idiōtai", Gloss = "uninstructed people", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἄπιστοι", Transliteration = "apistoi", Gloss = "unbelievers", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "ἐροῦσιν", Transliteration = "erousin", Gloss = "will they say", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "μαίνεσθε", Transliteration = "mainesthe", Gloss = "you are out of your minds", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "2P", "P" }, PartOfSpeech = "verb" }
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
                new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "If", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "προφητεύωσιν", Transliteration = "prophēteuōsin", Gloss = "should prophesy", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "εἰσέλθῃ", Transliteration = "eiselthē", Gloss = "should enter", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "τις", Transliteration = "tis", Gloss = "someone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "ἄπιστος", Transliteration = "apistos", Gloss = "an unbeliever", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἰδιώτης", Transliteration = "idiōtēs", Gloss = "an uninstructed person", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                new Word { Greek = "ἐλέγχεται", Transliteration = "elenchetai", Gloss = "he is convicted", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "by all"
                },
                new Word { Greek = "ἀνακρίνεται", Transliteration = "anakrinetai", Gloss = "he is examined", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" }
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
