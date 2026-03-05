private static List<object> GetChapter1()
{
    // 1 Corinthians 1:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πιστὸς", Transliteration = "pistos", Gloss = "faithful", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεός", Transliteration = "theos", Gloss = "God", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the God"
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
                                new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "through", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "whom", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "through whom"
                        },
                        new Word { Greek = "ἐκλήθητε", Transliteration = "eklēthēte", Gloss = "you were called", Grammar_Codes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "κοινωνίαν", Transliteration = "koinōnian", Gloss = "fellowship", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "υἱοῦ", Transliteration = "huiou", Gloss = "Son", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" },
                                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us", Grammar_Codes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "pron" }
                                            },
                                            Translation = "of his Son Jesus Christ our Lord"
                                        }
                                    },
                                    Translation = "fellowship of his Son Jesus Christ our Lord"
                                }
                            },
                            Translation = "into the fellowship of his Son Jesus Christ our Lord"
                        }
                    },
                    Translation = "through whom you were called into the fellowship of his Son Jesus Christ our Lord"
                }
            },
            Translation = "God is faithful, through whom you were called into the fellowship of his Son, Jesus Christ our Lord."
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Παρακαλῶ", Transliteration = "Parakalō", Gloss = "I appeal to", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", Grammar_Codes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "pron" },
                new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers", Grammar_Codes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὀνόματος", Transliteration = "onomatos", Gloss = "name", Grammar_Codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us", Grammar_Codes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "pron" },
                                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of our Lord Jesus Christ"
                                }
                            },
                            Translation = "the name of our Lord Jesus Christ"
                        }
                    },
                    Translation = "by the name of our Lord Jesus Christ"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "that", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "αὐτὸ", Transliteration = "auto", Gloss = "same [thing]", Grammar_Codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" }
                            },
                            Translation = "the same thing"
                        },
                        new Word { Greek = "λέγητε", Transliteration = "legēte", Gloss = "you all speak", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "SUBJ", "2P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "that you all speak the same thing"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "part" },
                        new Word { Greek = "ᾖ", Transliteration = "ē", Gloss = "there be", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you", Grammar_Codes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "among you"
                        },
                        new Word { Greek = "σχίσματα", Transliteration = "schismata", Gloss = "divisions", Grammar_Codes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "and that there be no divisions among you"
                },
                new Word { Greek = "ἦτε", Transliteration = "ēte", Gloss = "you may be", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "SUBJ", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατηρτισμένοι", Transliteration = "katērtismenoi", Gloss = "having been restored", Grammar_Codes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "perfectly joined together"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", Grammar_Codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "same", Grammar_Codes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" },
                                new Word { Greek = "νοῒ", Transliteration = "noï", Gloss = "mind", Grammar_Codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the same mind"
                        }
                    },
                    Translation = "in the same mind"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", Grammar_Codes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "αὐτῇ", Transliteration = "autē", Gloss = "same", Grammar_Codes = new List<string> { "PRON", "DAT", "F", "S" }, PartOfSpeech = "pron" },
                                new Word { Greek = "γνώμῃ", Transliteration = "gnōmē", Gloss = "judgment", Grammar_Codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the same judgment"
                        }
                    },
                    Translation = "and in the same judgment"
                }
            },
            Translation = "I appeal to you, brothers, by the name of our Lord Jesus Christ, that all of you agree, and that there be no divisions among you, but that you be united in the same mind and the same judgment."
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐδηλώθη", Transliteration = "edēlōthē", Gloss = "it was made clear", Grammar_Codes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me", Grammar_Codes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you", Grammar_Codes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "concerning you"
                },
                new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers", Grammar_Codes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "μου", Transliteration = "mou", Gloss = "of me", Grammar_Codes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "those of", Grammar_Codes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "Χλόης", Transliteration = "Chloēs", Gloss = "Chloe", Grammar_Codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Chloe's people"
                        }
                    },
                    Translation = "by those of Chloe"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἔριδες", Transliteration = "erides", Gloss = "quarrels", Grammar_Codes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you", Grammar_Codes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "among you"
                        },
                        new Word { Greek = "εἰσιν", Transliteration = "eisin", Gloss = "are", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "that there are quarrels among you"
                }
            },
            Translation = "For it has been reported to me concerning you, my brothers, by Chloe's people, that there are quarrels among you."
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I mean", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", Grammar_Codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἕκαστος", Transliteration = "hekastos", Gloss = "each", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", Grammar_Codes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "each of you"
                        },
                        new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "says", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "that each of you says"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", Grammar_Codes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "μέν", Transliteration = "men", Gloss = "indeed", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "part" },
                        new Word { Greek = "εἰμι", Transliteration = "eimi", Gloss = "am", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "Παύλου", Transliteration = "Paulou", Gloss = "of Paul", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "I belong to Paul"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", Grammar_Codes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Ἀπολλῶ", Transliteration = "Apollō", Gloss = "of Apollos", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "but I to Apollos"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", Grammar_Codes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Κηφᾶ", Transliteration = "Kēpha", Gloss = "of Cephas", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "but I to Cephas"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", Grammar_Codes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "of Christ", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "but I to Christ"
                }
            },
            Translation = "What I mean is that each one of you says, 'I follow Paul,' or 'I follow Apollos,' or 'I follow Cephas,' or 'I follow Christ.'"
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μεμέρισται", Transliteration = "memeristai", Gloss = "has been divided", Grammar_Codes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Χριστός", Transliteration = "Christos", Gloss = "Christ", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Christ"
                }
            },
            Translation = "Is Christ divided?"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Word { Greek = "Παῦλος", Transliteration = "Paulos", Gloss = "Paul", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἐσταυρώθη", Transliteration = "estaurōthē", Gloss = "was crucified", Grammar_Codes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "on behalf of", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you", Grammar_Codes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "for you"
                }
            },
            Translation = "Was Paul crucified for you?"
        },
        new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
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
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὄνομα", Transliteration = "onoma", Gloss = "name", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "Παύλου", Transliteration = "Paulou", Gloss = "of Paul", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the name of Paul"
                        }
                    },
                    Translation = "into the name of Paul"
                },
                new Word { Greek = "ἐβαπτίσθητε", Transliteration = "ebaptisthēte", Gloss = "were you baptized", Grammar_Codes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "Or were you baptized into the name of Paul?"
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εὐχαριστῶ", Transliteration = "eucharistō", Gloss = "I give thanks", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", Grammar_Codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", Grammar_Codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οὐδένα", Transliteration = "oudena", Gloss = "no one", Grammar_Codes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", Grammar_Codes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "no one of you"
                        },
                        new Word { Greek = "ἐβάπτισα", Transliteration = "ebaptisa", Gloss = "I baptized", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "COND_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "part" },
                                new Word { Greek = "Κρίσπον", Transliteration = "Krispon", Gloss = "Crispus", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "Γάϊον", Transliteration = "Gaïon", Gloss = "Gaius", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "except Crispus and Gaius"
                        }
                    },
                    Translation = "that I baptized none of you except Crispus and Gaius"
                }
            },
            Translation = "I thank God that I baptized none of you except Crispus and Gaius,"
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μή", Transliteration = "mē", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Word { Greek = "τις", Transliteration = "tis", Gloss = "anyone", Grammar_Codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                new Word { Greek = "εἴπῃ", Transliteration = "eipē", Gloss = "may say", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἐμὸν", Transliteration = "emon", Gloss = "my", Grammar_Codes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "ὄνομα", Transliteration = "onoma", Gloss = "name", Grammar_Codes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "my name"
                                }
                            },
                            Translation = "into my name"
                        },
                        new Word { Greek = "ἐβαπτίσθητε", Transliteration = "ebaptisthēte", Gloss = "you were baptized", Grammar_Codes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "that you were baptized into my name"
                }
            },
            Translation = "so that no one may say that you were baptized into my name."
        },

        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐβάπτισα", Transliteration = "ebaptisa", Gloss = "I baptized", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Στεφανᾶ", Transliteration = "Stephana", Gloss = "of Stephanas", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "οἶκον", Transliteration = "oikon", Gloss = "household", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the household of Stephanas"
                }
            },
            Translation = "I did baptize also the household of Stephanas."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λοιπὸν", Transliteration = "loipon", Gloss = "beyond that", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_Codes = new List<string> { "PART" }, PartOfSpeech = "part" },
                new Word { Greek = "οἶδα", Transliteration = "oida", Gloss = "I know", Grammar_Codes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴ", Transliteration = "ei", Gloss = "whether", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τινα", Transliteration = "tina", Gloss = "anyone", Grammar_Codes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἄλλον", Transliteration = "allon", Gloss = "other", Grammar_Codes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐβάπτισα", Transliteration = "ebaptisa", Gloss = "I baptized", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "whether I baptized anyone else"
                }
            },
            Translation = "Beyond that, I do not know whether I baptized anyone else."
        }
    };
}

/*
Identified Constructions:
- 1:9  REL_CLAUSE (δι᾽ οὗ ἐκλήθητε...)
- 1:10 PURPOSE_CLAUSE (ἵνα τὸ αὐτὸ λέγητε...)
- 1:11 CAUSAL_CLAUSE (ὅτι ἔριδες ἐν ὑμῖν εἰσιν)
- 1:12 Parallel INDEP_CLAUSES (ἐγὼ μέν... ἐγὼ δέ...)
- 1:14 COND_CLAUSE (εἰ μὴ Κρίσπον καὶ Γάϊον)
- 1:15 PURPOSE_CLAUSE (ἵνα μή τις εἴπῃ...)
- 1:16 COND_CLAUSE / Indirect Question (εἴ τινα ἄλλον ἐβάπτισα)
*/
