private static List<object> GetChapter3()
{
    // 1 Corinthians 3:17-23
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
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τις", Transliteration = "tis", Gloss = "anyone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "part" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ναὸν", Transliteration = "naon", Gloss = "temple", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "the temple of God"
                        },
                        new Word { Greek = "φθείρει", Transliteration = "phtheirei", Gloss = "destroys", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "If anyone destroys the temple of God"
                },
                new Word { Greek = "φθερεῖ", Transliteration = "phtherei", Gloss = "will destroy", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "τοῦτον", Transliteration = "touton", Gloss = "this one", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεός", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "God"
                }
            },
            Translation = "If anyone destroys the temple of God, God will destroy him."
        },
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ναὸς", Transliteration = "naos", Gloss = "temple", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of God"
                        }
                    },
                    Translation = "For the temple of God"
                },
                new Word { Greek = "ἅγιός", Transliteration = "hagios", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἵτινές", Transliteration = "hoitines", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "which you are"
                }
            },
            Translation = "For the temple of God is holy, which you are."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Μηδεὶς", Transliteration = "Mēdeis", Gloss = "no one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἑαυτὸν", Transliteration = "heauton", Gloss = "himself", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "f" },
                new Word { Greek = "ἐξαπατάτω", Transliteration = "exapatatō", Gloss = "let deceive", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Let no one deceive himself."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τις", Transliteration = "tis", Gloss = "anyone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "part" },
                        new Word { Greek = "δοκεῖ", Transliteration = "dokei", Gloss = "thinks", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "σοφὸς", Transliteration = "sophos", Gloss = "wise", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "among you"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "αἰῶνι", Transliteration = "aiōni", Gloss = "age", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "τούτῳ", Transliteration = "toutō", Gloss = "this", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "adv" }
                                    },
                                    Translation = "this age"
                                }
                            },
                            Translation = "in this age"
                        }
                    },
                    Translation = "if anyone thinks he is wise among you in this age"
                },
                new Word { Greek = "μωρὸς", Transliteration = "mōros", Gloss = "foolish", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "γενέσθω", Transliteration = "genesthō", Gloss = "let become", GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γένηται", Transliteration = "genētai", Gloss = "he may become", GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "σοφός", Transliteration = "sophos", Gloss = "wise", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "so that he may become wise"
                }
            },
            Translation = "if anyone thinks he is wise among you in this age, let him become a fool, so that he may become wise."
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
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σοφία", Transliteration = "sophia", Gloss = "wisdom", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κόσμου", Transliteration = "kosmou", Gloss = "world", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τούτου", Transliteration = "toutou", Gloss = "this", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "adv" }
                            },
                            Translation = "of this world"
                        }
                    },
                    Translation = "For the wisdom of this world"
                },
                new Word { Greek = "μωρία", Transliteration = "mōria", Gloss = "foolishness", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρὰ", Transliteration = "para", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "God"
                        }
                    },
                    Translation = "with God"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "For the wisdom of this world is foolishness with God."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it is written", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γάρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δρασσόμενος", Transliteration = "drassomenos", Gloss = "catching", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "He who catches"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "σοφοὺς", Transliteration = "sophous", Gloss = "wise", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "the wise"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πανουργίᾳ", Transliteration = "panourgia", Gloss = "craftiness", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "their", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "their craftiness"
                        }
                    },
                    Translation = "in their craftiness"
                }
            },
            Translation = "For it is written, 'He catches the wise in their craftiness,'"
        },

        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πάλιν", Transliteration = "palin", Gloss = "again", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "γινώσκει", Transliteration = "ginōskei", Gloss = "knows", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "διαλογισμοὺς", Transliteration = "dialogismous", Gloss = "thoughts", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "σοφῶν", Transliteration = "sophōn", Gloss = "wise", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "of the wise"
                        }
                    },
                    Translation = "the thoughts of the wise"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "εἰσὶν", Transliteration = "eisin", Gloss = "they are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "μάταιοι", Transliteration = "mataioi", Gloss = "worthless", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "that they are worthless"
                }
            },
            Translation = "and again, 'The Lord knows the thoughts of the wise, that they are worthless.'"
        },

        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὥστε", Transliteration = "hōste", Gloss = "so", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μηδεὶς", Transliteration = "mēdeis", Gloss = "no one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "καυχάσθω", Transliteration = "kauchasthō", Gloss = "let boast", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀνθρώποις", Transliteration = "anthrōpois", Gloss = "men", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "in men"
                }
            },
            Translation = "So let no one boast in men."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all things", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "yours", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "For all things are yours,"
        },

        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Παῦλος", Transliteration = "Paulos", Gloss = "Paul", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Ἀπολλῶς", Transliteration = "Apollōs", Gloss = "Apollos", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Κηφᾶς", Transliteration = "Kēphas", Gloss = "Cephas", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "κόσμος", Transliteration = "kosmos", Gloss = "world", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ζωὴ", Transliteration = "zōē", Gloss = "life", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "θάνατος", Transliteration = "thanatos", Gloss = "death", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐνεστῶτα", Transliteration = "enestōta", Gloss = "things present", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "N", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μέλλοντα", Transliteration = "mellonta", Gloss = "things to come", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "whether Paul or Apollos or Cephas, or the world or life or death, or things present or things to come"
                },
                new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "yours", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" }
            },
            Translation = "whether Paul or Apollos or Cephas, or the world or life or death, or things present or things to come; all are yours,"
        },

        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ's", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "and you are Christ’s,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Χριστὸς", Transliteration = "Christos", Gloss = "Christ", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God's", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "and Christ is God’s."
        }
    };
}

/*
Constructions identified:
- 1 Cor 3:17: COND_CLAUSE (first class condition)
- 1 Cor 3:17: REL_CLAUSE (οἵτινές ἐστε ὑμεῖς)
- 1 Cor 3:18: COND_CLAUSE (first class condition)
- 1 Cor 3:18: PURPOSE_CLAUSE (ἵνα + subjunctive)
- 1 Cor 3:19: Substantive Participle (ὁ δρασσόμενος)
- 1 Cor 3:20: Object Clause (ὅτι εἰσὶν μάταιοι)
*/
