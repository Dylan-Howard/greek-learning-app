private static List<object> GetChapter8()
{
    // 1 Corinthians 8:1-8
    return new List<object>
    {
        // Verse 1
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
                        new Word { Greek = "Περὶ", Transliteration = "Peri", Gloss = "about", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "εἰδωλοθύτων", Transliteration = "eidōlothytōn", Gloss = "sacrificed to idols", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the things sacrificed to idols"
                        }
                    },
                    Translation = "Now concerning things sacrificed to idols"
                },
                new Word { Greek = "οἴδαμεν", Transliteration = "oidamen", Gloss = "we know", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "all"
                        },
                        new Word { Greek = "γνῶσιν", Transliteration = "gnōsin", Gloss = "knowledge", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἔχομεν", Transliteration = "echomen", Gloss = "we have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "that we all have knowledge"
                }
            },
            Translation = "Now concerning things sacrificed to idols: we know that we all have knowledge."
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
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γνῶσις", Transliteration = "gnōsis", Gloss = "knowledge", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "knowledge"
                },
                new Word { Greek = "φυσιοῖ", Transliteration = "physioi", Gloss = "puffs up", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Knowledge puffs up,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀγάπη", Transliteration = "agapē", Gloss = "love", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "οἰκοδομεῖ", Transliteration = "oikodomei", Gloss = "builds up", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "but love builds up."
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἴ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τις", Transliteration = "tis", Gloss = "anyone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "part" },
                new Word { Greek = "δοκεῖ", Transliteration = "dokei", Gloss = "thinks", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐγνωκέναι", Transliteration = "egnōkenai", Gloss = "to have known", GrammarCodes = new List<string> { "V", "PERF", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "τι", Transliteration = "ti", Gloss = "something", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "part" }
                    },
                    Translation = "to have known something"
                }
            },
            Translation = "If anyone thinks he has known something,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὔπω", Transliteration = "oupō", Gloss = "not yet", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἔγνω", Transliteration = "egnō", Gloss = "he has known", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δεῖ", Transliteration = "dei", Gloss = "it is necessary", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "γνῶναι", Transliteration = "gnōnai", Gloss = "to know", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "as it is necessary to know"
                }
            },
            Translation = "he does not yet know as it is necessary to know."
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τις", Transliteration = "tis", Gloss = "anyone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "part" },
                new Word { Greek = "ἀγαπᾷ", Transliteration = "agapai", Gloss = "loves", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεόν", Transliteration = "theon", Gloss = "God", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "God"
                }
            },
            Translation = "But if anyone loves God,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this one", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἔγνωσται", Transliteration = "egnōstai", Gloss = "has been known", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπ᾽", Transliteration = "hyp'", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "by him"
                }
            },
            Translation = "this one has been known by him."
        },

        // Verse 4
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
                        new Word { Greek = "Περὶ", Transliteration = "Peri", Gloss = "about", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "βρώσεως", Transliteration = "brōseōs", Gloss = "eating", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the eating"
                        },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "εἰδωλοθύτων", Transliteration = "eidōlothytōn", Gloss = "things sacrificed to idols", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "of things sacrificed to idols"
                        }
                    },
                    Translation = "Therefore, concerning the eating of things sacrificed to idols"
                },
                new Word { Greek = "οἴδαμεν", Transliteration = "oidamen", Gloss = "we know", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "Therefore, concerning the eating of things sacrificed to idols, we know"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐδὲν", Transliteration = "ouden", Gloss = "no", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "εἴδωλον", Transliteration = "eidōlon", Gloss = "idol", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "an idol"
                },
                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "is [nothing] in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Word { Greek = "κόσμῳ", Transliteration = "kosmō", Gloss = "world", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "that an idol is nothing in the world,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐδεὶς", Transliteration = "oudeis", Gloss = "no one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "no God [exists]"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "εἷς", Transliteration = "heis", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "except one"
                }
            },
            Translation = "and that there is no God except one."
        },

        // Verse 5
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἴπερ", Transliteration = "eiper", Gloss = "if indeed", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἰσὶν", Transliteration = "eisin", Gloss = "there are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λεγόμενοι", Transliteration = "legomenoi", Gloss = "being called", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "θεοὶ", Transliteration = "theoi", Gloss = "gods", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "so-called gods"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "whether", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οὐρανῷ", Transliteration = "ouranō", Gloss = "heaven", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "whether in heaven"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴτε", Transliteration = "eite", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "γῆς", Transliteration = "gēs", Gloss = "earth", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "or on earth"
                }
            },
            Translation = "For even if indeed there are so-called gods, whether in heaven or on earth,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὥσπερ", Transliteration = "hōsper", Gloss = "just as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἰσὶν", Transliteration = "eisin", Gloss = "there are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "θεοὶ", Transliteration = "theoi", Gloss = "gods", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "πολλοὶ", Transliteration = "polloi", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κύριοι", Transliteration = "kyrioi", Gloss = "lords", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "πολλοί", Transliteration = "polloi", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
            },
            Translation = "as indeed there are many gods and many lords—"
        },

        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "εἷς", Transliteration = "heis", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πατὴρ", Transliteration = "patēr", Gloss = "Father", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Father"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "whom", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all things", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "all things"
                        }
                    },
                    Translation = "from whom are all things"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis", Gloss = "we", GrammarCodes = new List<string> { "PRON", "NOM", "1P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "for him"
                }
            },
            Translation = "yet for us there is one God, the Father, from whom are all things and for whom we exist,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἷς", Transliteration = "heis", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "Χριστὸς", Transliteration = "Christos", Gloss = "Christ", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οὗ", Transliteration = "hou", Gloss = "whom", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all things", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "all things"
                        }
                    },
                    Translation = "through whom are all things"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis", Gloss = "we", GrammarCodes = new List<string> { "PRON", "NOM", "1P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δι᾽", Transliteration = "di'", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "through him"
                }
            },
            Translation = "and one Lord, Jesus Christ, through whom are all things and through whom we exist."
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀλλ᾽", Transliteration = "All'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "πᾶσιν", Transliteration = "pasin", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "in all"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γνῶσις", Transliteration = "gnōsis", Gloss = "knowledge", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "is the knowledge"
                }
            },
            Translation = "However, not all possess this knowledge."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τινὲς", Transliteration = "tines", Gloss = "some", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "part" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "by the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "συνηθείᾳ", Transliteration = "synētheia", Gloss = "custom", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "until", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἄρτι", Transliteration = "arti", Gloss = "now", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                            },
                            Translation = "until now"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "εἰδώλου", Transliteration = "eidōlou", Gloss = "idol", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the idol"
                        }
                    },
                    Translation = "by their custom until now of the idol"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "εἰδωλόθυτον", Transliteration = "eidōlothyton", Gloss = "sacrificed to idols", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "as sacrificed to an idol"
                },
                new Word { Greek = "ἐσθίουσιν", Transliteration = "esthiousin", Gloss = "they eat", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "But some, through former association with idols, eat food as really offered to an idol,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "συνείδησις", Transliteration = "syneidēsis", Gloss = "conscience", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "their", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "their conscience"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀσθενὴς", Transliteration = "asthenēs", Gloss = "weak", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "οὖσα", Transliteration = "ousa", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "being weak"
                },
                new Word { Greek = "μολύνεται", Transliteration = "molynetai", Gloss = "is defiled", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "and their conscience, being weak, is defiled."
        },

        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "βρῶμα", Transliteration = "brōma", Gloss = "food", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us", GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "παραστήσει", Transliteration = "parastēsei", Gloss = "will commend", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to God"
                }
            },
            Translation = "Food will not commend us to God."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὔτε", Transliteration = "oute", Gloss = "neither", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "φάγωμεν", Transliteration = "phagōmen", Gloss = "we eat", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ὑστερούμεθα", Transliteration = "hysteroumetha", Gloss = "we lack", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "1P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "we are no worse off if we do not eat,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "COND_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὔτε", Transliteration = "oute", Gloss = "nor", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "φάγωμεν", Transliteration = "phagōmen", Gloss = "we eat", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "περισσεύομεν", Transliteration = "perisseuomen", Gloss = "we abound", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "nor are we better off if we eat."
        }
    };
}
/*
Identified Constructions:
- NOUN_PHRASE (Subj/Obj): Throughout verses 1-8.
- PREP_PHRASE: Throughout verses 1-8.
- REL_CLAUSE: 1 Cor 8:6 (ἐξ οὗ, δι᾽ οὗ).
- COND_CLAUSE: 1 Cor 8:2 (εἴ τις), 8:3 (εἰ δέ τις), 8:5 (εἴπερ εἰσὶν), 8:8 (ἐὰν μὴ φάγωμεν).
- DAT_INSTR: 1 Cor 8:7 (τῇ συνηθείᾳ).
- APPOS: 1 Cor 8:6 (ὁ πατὴρ, Ἰησοῦς Χριστὸς).
*/
