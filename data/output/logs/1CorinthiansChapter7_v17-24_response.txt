private static List<object> GetChapter7()
{
    // 1 Corinthians 7:17-24
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
                        new Word { Greek = "Εἰ", Transliteration = "Ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἑκάστῳ", Transliteration = "hekastō", Gloss = "to each", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "to each one"
                        },
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐμέρισεν", Transliteration = "emerisen", Gloss = "divided", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Lord"
                        }
                    },
                    Translation = "Only as the Lord has assigned to each"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕκαστον", Transliteration = "hekaston", Gloss = "each", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "each one"
                },
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "conj" },
                new Word { Greek = "κέκληκεν", Transliteration = "keklēken", Gloss = "has called", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεός", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "God"
                },
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "so", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "περιπατείτω", Transliteration = "peripateitō", Gloss = "let him walk", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Only as the Lord has assigned to each, as God has called each, in this way let him walk."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "so", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
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
                                new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐκκλησίαις", Transliteration = "ekklēsiais", Gloss = "churches", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "πάσαις", Transliteration = "pasais", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "all the churches"
                        }
                    },
                    Translation = "in all the churches"
                },
                new Word { Greek = "διατάσσομαι", Transliteration = "diatassomai", Gloss = "I direct", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "And so I direct in all the churches."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περιτετμημένος", Transliteration = "peritetmēmenos", Gloss = "circumcised", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "having been circumcised"
                },
                new Word { Greek = "τις", Transliteration = "tis", Gloss = "anyone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "part" },
                new Word { Greek = "ἐκλήθη", Transliteration = "eklēthē", Gloss = "was called", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐπισπάσθω", Transliteration = "epispasthō", Gloss = "let him not seek to remove it", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Was anyone at the time of his call already circumcised? Let him not seek to remove the marks of circumcision."
        },
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
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀκροβυστίᾳ", Transliteration = "akrobystia", Gloss = "uncircumcision", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in uncircumcision"
                },
                new Word { Greek = "κέκληταί", Transliteration = "keklētai", Gloss = "has been called", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "τις", Transliteration = "tis", Gloss = "anyone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "part" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "περιτεμνέσθω", Transliteration = "peritemnesthō", Gloss = "let him not be circumcised", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IMP", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Was anyone at the time of his call uncircumcised? Let him not be circumcised."
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
                        new Word { Greek = "περιτομὴ", Transliteration = "peritomē", Gloss = "circumcision", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "circumcision"
                },
                new Word { Greek = "οὐδέν", Transliteration = "ouden", Gloss = "nothing", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀκροβυστία", Transliteration = "akrobystia", Gloss = "uncircumcision", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "uncircumcision"
                },
                new Word { Greek = "οὐδέν", Transliteration = "ouden", Gloss = "nothing", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τήρησις", Transliteration = "tērēsis", Gloss = "keeping", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐντολῶν", Transliteration = "entolōn", Gloss = "commandments", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "of God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "commandments of God"
                        }
                    },
                    Translation = "the keeping of the commandments of God"
                }
            },
            Translation = "For neither circumcision counts for anything nor uncircumcision, but keeping the commandments of God."
        },

        // Verse 20
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
                        new Word { Greek = "ἕκαστος", Transliteration = "hekastos", Gloss = "each one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "each one"
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
                                new Word { Greek = "κλήσει", Transliteration = "klēsei", Gloss = "calling", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the calling"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ᾗ", Transliteration = "hē", Gloss = "in which", GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" }, PartOfSpeech = "pron" },
                                new Word { Greek = "ἐκλήθη", Transliteration = "eklēthē", Gloss = "he was called", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "in which he was called"
                        }
                    },
                    Translation = "in the calling in which he was called"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ταύτῃ", Transliteration = "tautē", Gloss = "this", GrammarCodes = new List<string> { "PRON", "DAT", "F", "S" }, PartOfSpeech = "adv" }
                    },
                    Translation = "in this"
                },
                new Word { Greek = "μενέτω", Transliteration = "menetō", Gloss = "let him remain", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Each one should remain in the condition in which he was called."
        },

        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "δοῦλος", Transliteration = "doulos", Gloss = "bondservant", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ἐκλήθης", Transliteration = "eklēthēs", Gloss = "were you called", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "μή", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "μελέτω", Transliteration = "meletō", Gloss = "let it be a care", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "Were you a bondservant when called? Do not be concerned about it."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "even", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δύνασαι", Transliteration = "dynasai", Gloss = "you are able", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἐλεύθερος", Transliteration = "eleutheros", Gloss = "free", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "γενέσθαι", Transliteration = "genesthai", Gloss = "to become", GrammarCodes = new List<string> { "V", "AOR", "MID", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "but if you can gain your freedom"
                },
                new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "rather", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "χρῆσαι", Transliteration = "chrēsai", Gloss = "avail yourself", GrammarCodes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "But if you can gain your freedom, avail yourself of the opportunity."
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "Lord", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in the Lord"
                        },
                        new Word { Greek = "κληθεὶς", Transliteration = "klētheis", Gloss = "called", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "δοῦλος", Transliteration = "doulos", Gloss = "bondservant", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "For he who was called in the Lord as a bondservant"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπελεύθερος", Transliteration = "apeleutheros", Gloss = "freedman", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "of the Lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "a freedman of the Lord"
                },
                new Word { Greek = "ἐστίν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "For he who was called in the Lord as a bondservant is a freedman of the Lord."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁμοίως", Transliteration = "homoiōs", Gloss = "likewise", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐλεύθερος", Transliteration = "eleutheros", Gloss = "free", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "κληθεὶς", Transliteration = "klētheis", Gloss = "called", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "he who was free when called"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δοῦλός", Transliteration = "doulos", Gloss = "bondservant", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "of Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "is a bondservant of Christ"
                }
            },
            Translation = "Likewise he who was free when called is a bondservant of Christ."
        },

        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τιμῆς", Transliteration = "timēs", Gloss = "with a price", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "with a price"
                },
                new Word { Greek = "ἠγοράσθητε", Transliteration = "ēgorasthēte", Gloss = "you were bought", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "do not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "γίνεσθε", Transliteration = "ginesthe", Gloss = "become", GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δοῦλοι", Transliteration = "douloi", Gloss = "bondservants", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἀνθρώπων", Transliteration = "anthrōpōn", Gloss = "of men", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "bondservants of men"
                }
            },
            Translation = "You were bought with a price; do not become bondservants of men."
        },

        // Verse 24
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
                        new Word { Greek = "ἕκαστος", Transliteration = "hekastos", Gloss = "each one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "each one"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ᾧ", Transliteration = "hō", Gloss = "that in which", GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" }, PartOfSpeech = "pron" },
                                new Word { Greek = "ἐκλήθη", Transliteration = "eklēthē", Gloss = "he was called", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
                            },
                            Translation = "that in which he was called"
                        }
                    },
                    Translation = "in the state in which he was called"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers", GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "brothers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τούτῳ", Transliteration = "toutō", Gloss = "this", GrammarCodes = new List<string> { "PRON", "DAT", "N", "S" }, PartOfSpeech = "adv" }
                    },
                    Translation = "in this"
                },
                new Word { Greek = "μενέτω", Transliteration = "menetō", Gloss = "let him remain", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρὰ", Transliteration = "para", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "θεῷ", Transliteration = "theō", Gloss = "God", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "with God"
                }
            },
            Translation = "So, brothers, in whatever state each was called, there let him remain with God."
        }
    };
}

/*
Constructions identified:
- COND_CLAUSE: v17 (Εἰ μὴ), v21 (εἰ καὶ)
- REL_CLAUSE: v20 (ᾗ ἐκλήθη), v24 (ᾧ ἐκλήθη)
- GEN_OBJ: v19 (ἐντολῶν θεοῦ)
- NOUN_PHRASE/VOC: v24 (ἀδελφοί)
- PTCP: v18 (περιτετμημένος), v22 (κληθεὶς)
*/
