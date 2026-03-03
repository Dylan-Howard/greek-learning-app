private static List<object> GetChapter1()
{
    // 3 John 1:9-14
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἔγραψά", Transliteration = "Egrapsa", Gloss = "I wrote", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "τι", Transliteration = "ti", Gloss = "something", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, 
                    PartOfSpeech = "part" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἐκκλησίᾳ", Transliteration = "ekklēsia", Gloss = "church", 
                            GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "to the church"
                }
            },
            Translation = "I wrote something to the church;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", 
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "φιλοπρωτεύων", Transliteration = "philoprotueōn", Gloss = "loving to be first", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, 
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, 
                            PartOfSpeech = "prep" }
                    },
                    Translation = "the one loving to be first among them"
                },
                new Word { Greek = "Διοτρέφης", Transliteration = "Diotrephēs", Gloss = "Diotrephes", 
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, 
                    PartOfSpeech = "n" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐπιδέχεται", Transliteration = "epidechetai", Gloss = "welcomes", 
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us", 
                    GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" }, 
                    PartOfSpeech = "prep" }
            },
            Translation = "but Diotrephes, who loves to be first among them, does not welcome us."
        },

        // Verse 10
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
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because of", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, 
                            PartOfSpeech = "adv" }
                    },
                    Translation = "for this reason"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἔλθω", Transliteration = "elthō", Gloss = "I come", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "if I come"
                },
                new Word { Greek = "ὑπομνήσω", Transliteration = "hypomnēsō", Gloss = "I will bring to mind", 
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἔργα", Transliteration = "erga", Gloss = "works", 
                            GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "his works"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἃ", Transliteration = "ha", Gloss = "which", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, 
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ποιεῖ", Transliteration = "poiei", Gloss = "he does", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "which he does"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "λόγοις", Transliteration = "logois", Gloss = "with words", 
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, 
                                    PartOfSpeech = "n" },
                                new Word { Greek = "πονηροῖς", Transliteration = "ponērois", Gloss = "wicked", 
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, 
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "with wicked words"
                        },
                        new Word { Greek = "φλυαρῶν", Transliteration = "phlyarōn", Gloss = "gossiping against", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, 
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" }, 
                            PartOfSpeech = "prep" }
                    },
                    Translation = "gossiping against us with wicked words"
                }
            },
            Translation = "Therefore, if I come, I will bring to mind his works which he does, gossiping against us with wicked words;"
        },
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
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", 
                            GrammarCodes = new List<string> { "ADV" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἀρκούμενος", Transliteration = "arkoumenos", Gloss = "being content", 
                            GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "M", "S" }, 
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "with", 
                                    GrammarCodes = new List<string> { "PREP" }, 
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "τούτοις", Transliteration = "toutois", Gloss = "these things", 
                                    GrammarCodes = new List<string> { "PRON", "DAT", "N", "P" }, 
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "with these things"
                        }
                    },
                    Translation = "and not being content with these things"
                },
                new Word { Greek = "οὔτε", Transliteration = "oute", Gloss = "neither", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he himself", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἐπιδέχεται", Transliteration = "epidechetai", Gloss = "welcomes", 
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀδελφοὺς", Transliteration = "adelphous", Gloss = "brothers", 
                            GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "the brothers"
                }
            },
            Translation = "and not content with these things, he neither welcomes the brothers himself,"
        },
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the [ones]", 
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "βουλομένους", Transliteration = "boulomenous", Gloss = "desiring [to do so]", 
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "ACC", "M", "P" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "those who desire [to do so]"
                },
                new Word { Greek = "κωλύει", Transliteration = "kōlyei", Gloss = "he hinders", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" },
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
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἐκκλησίας", Transliteration = "ekklēsias", Gloss = "church", 
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "out of the church"
                },
                new Word { Greek = "ἐκβάλλει", Transliteration = "ekballei", Gloss = "he throws [them] out", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "and he hinders those who desire to do so and throws them out of the church."
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀγαπητέ", Transliteration = "Agapēte", Gloss = "Beloved", 
                    GrammarCodes = new List<string> { "ADJ", "VOC", "M", "S" }, 
                    PartOfSpeech = "adj" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "μιμοῦ", Transliteration = "mimou", Gloss = "imitate", 
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "S" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "κακὸν", Transliteration = "kakon", Gloss = "evil", 
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, 
                            PartOfSpeech = "adj" }
                    },
                    Translation = "what is evil"
                },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀγαθόν", Transliteration = "agathon", Gloss = "good", 
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, 
                            PartOfSpeech = "adj" }
                    },
                    Translation = "what is good"
                }
            },
            Translation = "Beloved, do not imitate what is evil but what is good."
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", 
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀγαθοποιῶν", Transliteration = "agathopoiōn", Gloss = "doing good", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "the one who does good"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "of", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", 
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "is of God"
                },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "The one who does good is of God;"
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", 
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "κακοποιῶν", Transliteration = "kakopoiōn", Gloss = "doing evil", 
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "the one who does evil"
                },
                new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἑώρακεν", Transliteration = "heōraken", Gloss = "has seen", 
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "θεόν", Transliteration = "theon", Gloss = "God", 
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "God"
                }
            },
            Translation = "the one who does evil has not seen God."
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Δημητρίῳ", Transliteration = "Dēmētriō", Gloss = "to Demetrius", 
                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, 
                    PartOfSpeech = "n" },
                new Word { Greek = "μεμαρτύρηται", Transliteration = "memartyrētai", Gloss = "it is testified", 
                    GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all", 
                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, 
                            PartOfSpeech = "adj" }
                    },
                    Translation = "by all"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῆς", Transliteration = "autēs", Gloss = "itself", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", 
                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, 
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἀληθείας", Transliteration = "alētheias", Gloss = "truth", 
                            GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "by the truth itself"
                }
            },
            Translation = "Demetrius has received a good testimony from everyone, and from the truth itself;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis", Gloss = "we", 
                    GrammarCodes = new List<string> { "PRON", "NOM", "1P", "P" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "also", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "μαρτυροῦμεν", Transliteration = "martyroumen", Gloss = "testify", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "and we also testify,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "οἶδας", Transliteration = "oidas", Gloss = "you know", 
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", 
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
                        new Word { Greek = "μαρτυρία", Transliteration = "martyria", Gloss = "testimony", 
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, 
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us", 
                            GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" }, 
                            PartOfSpeech = "prep" }
                    },
                    Translation = "our testimony"
                },
                new Word { Greek = "ἀληθής", Transliteration = "alēthēs", Gloss = "true", 
                    GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, 
                    PartOfSpeech = "adj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "and you know that our testimony is true."
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Πολλὰ", Transliteration = "Polla", Gloss = "Many things", 
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, 
                            PartOfSpeech = "adj" }
                    },
                    Translation = "many things"
                },
                new Word { Greek = "εἶχον", Transliteration = "eichon", Gloss = "I had", 
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "γράψαι", Transliteration = "grapsai", Gloss = "to write", 
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, 
                    PartOfSpeech = "prep" }
            },
            Translation = "I had many things to write to you,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "θέλω", Transliteration = "thelō", Gloss = "I am willing", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "μέλανος", Transliteration = "melanos", Gloss = "ink", 
                            GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, 
                            PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", 
                            GrammarCodes = new List<string> { "CONJ" }, 
                            PartOfSpeech = "conj" },
                        new Word { Greek = "καλάμου", Transliteration = "kalamou", Gloss = "pen", 
                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "with ink and pen"
                },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you", 
                    GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, 
                    PartOfSpeech = "prep" },
                new Word { Greek = "γράφειν", Transliteration = "graphein", Gloss = "to write", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "but I am not willing to write them to you with ink and pen;"
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐλπίζω", Transliteration = "elpizō", Gloss = "I hope", 
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, 
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", 
                    GrammarCodes = new List<string> { "CONJ" }, 
                    PartOfSpeech = "conj" },
                new Word { Greek = "εὐθέως", Transliteration = "eutheōs", Gloss = "soon", 
                    GrammarCodes = new List<string> { "ADV" }, 
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σε", Transliteration = "se", Gloss = "you", 
                            GrammarCodes = new List<string> { "PRON", "ACC", "2P", "S" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἰδεῖν", Transliteration = "idein", Gloss = "to see", 
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, 
                            PartOfSpeech = "v" }
                    },
                    Translation = "to see you soon"
                }
            },
            Translation = "but I hope to see you soon,"
        },
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
                        new Word { Greek = "στόμα", Transliteration = "stoma", Gloss = "mouth", 
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, 
                            PartOfSpeech = "n" },
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", 
                            GrammarCodes = new List<string> { "PREP" }, 
                            PartOfSpeech = "prep" },
                        new Word { Greek = "στόμα", Transliteration = "stoma", Gloss = "mouth", 
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, 
                            PartOfSpeech = "n" }
                    },
                    Translation = "face to face"
                },
                new Word { Greek = "λαλήσομεν", Transliteration = "lalēsomen", Gloss = "we will speak", 
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "P" }, 
                    PartOfSpeech = "v" }
            },
            Translation = "and we will speak face to face."
        }
    };
}

/*
Constructions identified:
- COND_CLAUSE: v10 (ἐὰν ἔλθω)
- DAT_INSTR: v10 (λόγοις πονηροῖς)
- NOUN_PHRASE as SUBJ (Substantival Participle): v9 (ὁ φιλοπρωτεύων), v11 (ὁ ἀγαθοποιῶν, ὁ κακοποιῶν)
- INF_PHRASE: v14 (σε ἰδεῖν)
*/
