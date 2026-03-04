private static List<object> GetChapter13()
{
    // Acts 13:41-48
    return new List<object>
    {
        // Verse 41
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἴδετε", Transliteration = "idete", Gloss = "Look", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "VOC", "M", "P" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "καταφρονηταί", Transliteration = "kataphronētai", Gloss = "scoffers", 
                            GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "you scoffers"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "θαυμάσατε", Transliteration = "thaumasate", Gloss = "wonder", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀφανίσθητε", Transliteration = "aphanisthēte", Gloss = "perish", 
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IMP", "2P", "P" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "Look, you scoffers, and wonder and perish!"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "for", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔργον", Transliteration = "ergon", Gloss = "a work", 
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "a work"
                },
                new Word { Greek = "ἐργάζομαι", Transliteration = "ergazomai", Gloss = "am doing", 
                    GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" }, 
                    PartOfSpeech = "pron" },
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
                                new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "P" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἡμέραις", Transliteration = "hēmerais", Gloss = "days", 
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, 
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", 
                                    GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, 
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "your days"
                        }
                    },
                    Translation = "in your days"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔργον", Transliteration = "ergon", Gloss = "a work", 
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "a work"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, 
                            PartOfSpeech = "pron" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", 
                            GrammarCodes = new List<string> { "ADV" }, 
                            PartOfSpeech = "adv" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "no", 
                            GrammarCodes = new List<string> { "ADV" }, 
                            PartOfSpeech = "adv" },
                        new Word { Greek = "πιστεύσητε", Transliteration = "pisteusēte", Gloss = "you will believe", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" }, 
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "COND_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐάν", Transliteration = "ean", Gloss = "if", 
                                    GrammarCodes = new List<string> { "CONJ" }, 
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "τις", Transliteration = "tis", Gloss = "someone", 
                                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, 
                                    PartOfSpeech = "pron" },
                                new Word { Greek = "ἐκδιηγῆται", Transliteration = "ekdiēgētai", Gloss = "should describe", 
                                    GrammarCodes = new List<string> { "V", "PRES", "MP", "SUBJ", "3P", "S" }, 
                                    PartOfSpeech = "v" },
                                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", 
                                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, 
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "if someone should describe it to you"
                        }
                    },
                    Translation = "which you will never believe, even if someone describes it to you"
                }
            },
            Translation = "For I am doing a work in your days, a work which you will never believe, even if someone describes it to you."
        },

        // Verse 42
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
                        new Word { Greek = "Ἐξιόντων", Transliteration = "Exiontōn", Gloss = "going out", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "P" }, 
                            PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "as they", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, 
                            PartOfSpeech = "pron" }
                    },
                    Translation = "As they were going out"
                },
                new Word { Greek = "παρεκάλουν", Transliteration = "parekaloun", Gloss = "they were begging", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "μεταξὺ", Transliteration = "metaxy", Gloss = "next", 
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, 
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "σάββατον", Transliteration = "sabbaton", Gloss = "Sabbath", 
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the next Sabbath"
                        }
                    },
                    Translation = "on the next Sabbath"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λαληθῆναι", Transliteration = "lalēthēnai", Gloss = "to be spoken", 
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" }, 
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", 
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, 
                            PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ῥήματα", Transliteration = "rhēmata", Gloss = "words", 
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, 
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these", 
                                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, 
                                    PartOfSpeech = "pron" }
                            },
                            Translation = "these words"
                        }
                    },
                    Translation = "that these words be spoken to them"
                }
            },
            Translation = "As they were going out, they begged that these words might be spoken to them on the next Sabbath."
        },

        // Verse 43
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
                        new Word { Greek = "λυθείσης", Transliteration = "lytheisēs", Gloss = "having been broken up", 
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "GEN", "F", "S" }, 
                            PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "συναγωγῆς", Transliteration = "synagōgēs", Gloss = "synagogue", 
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the synagogue"
                        }
                    },
                    Translation = "And after the synagogue meeting was broken up"
                },
                new Word { Greek = "ἠκολούθησαν", Transliteration = "ēkolouthēsan", Gloss = "followed", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πολλοὶ", Transliteration = "polloi", Gloss = "many", 
                            GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, 
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", 
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Ἰουδαίων", Transliteration = "Ioudaiōn", Gloss = "Jews", 
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, 
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "of the Jews"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", 
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, 
                                    PartOfSpeech = "art" },
                                new Word { Greek = "σεβομένων", Transliteration = "sebomenōn", Gloss = "devout", 
                                    GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "GEN", "M", "P" }, 
                                    PartOfSpeech = "v" },
                                new Word { Greek = "προσηλύτων", Transliteration = "prosēlytōn", Gloss = "converts", 
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, 
                                    PartOfSpeech = "n" }
                            },
                            Translation = "of the devout converts"
                        }
                    },
                    Translation = "many of the Jews and of the devout converts"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "Παύλῳ", Transliteration = "Paulō", Gloss = "Paul", 
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, 
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "Βαρναβᾷ", Transliteration = "Barnaba", Gloss = "Barnabas", 
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "Paul and Barnabas"
                }
            },
            Translation = "After the synagogue meeting was broken up, many of the Jews and devout converts followed Paul and Barnabas,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οἵτινες", Transliteration = "hoitines", Gloss = "who", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, 
                    PartOfSpeech = "pron" },
                new Word { Greek = "προσλαλοῦντες", Transliteration = "proslalountes", Gloss = "speaking", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, 
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἔπειθον", Transliteration = "epeithon", Gloss = "urged", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "them", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, 
                    PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προσμένειν", Transliteration = "prosmenein", Gloss = "to continue", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, 
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", 
                                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, 
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "χάριτι", Transliteration = "chariti", Gloss = "grace", 
                                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, 
                                            PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of", 
                                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, 
                                                    PartOfSpeech = "art" },
                                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", 
                                                    
