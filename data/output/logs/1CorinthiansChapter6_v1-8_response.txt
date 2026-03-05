private static List<object> GetChapter6()
{
    // 1 Corinthians 6:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τολμᾷ", Transliteration = "Tolma", Gloss = "to dare", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "τις", Transliteration = "tis", Gloss = "someone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "part" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "of you"
                },
                new Word { Greek = "πρᾶγμα", Transliteration = "pragma", Gloss = "thing", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔχων", Transliteration = "echōn", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἕτερον", Transliteration = "heteron", Gloss = "another", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "the other"
                                }
                            },
                            Translation = "against another"
                        }
                    },
                    Translation = "having a matter against another"
                },
                new Word { Greek = "κρίνεσθαι", Transliteration = "krinesthai", Gloss = "to be judged", GrammarCodes = new List<string> { "V", "PRES", "PASS", "INF" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "before", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀδίκων", Transliteration = "adikōn", Gloss = "unjust", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the unrighteous"
                        }
                    },
                    Translation = "before the unrighteous"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐχὶ", Transliteration = "ouchi", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "before", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἁγίων", Transliteration = "hagiōn", Gloss = "saints", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the saints"
                        }
                    },
                    Translation = "before the saints"
                }
            },
            Translation = "Does any one of you, having a matter against another, dare to go to law before the unrighteous, and not before the saints?"
        },

        // Verse 2
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "οἴδατε", Transliteration = "oidate", Gloss = "do you know", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἅγιοι", Transliteration = "hagioi", Gloss = "saints", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the saints"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κόσμον", Transliteration = "kosmon", Gloss = "world", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the world"
                        },
                        new Word { Greek = "κρινοῦσιν", Transliteration = "krinousin", Gloss = "will judge", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "that the saints will judge the world"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "by you"
                        },
                        new Word { Greek = "κρίνεται", Transliteration = "krinetai", Gloss = "is judged", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κόσμος", Transliteration = "kosmos", Gloss = "world", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the world"
                        }
                    },
                    Translation = "if the world is judged by you"
                },
                new Word { Greek = "ἀνάξιοί", Transliteration = "anaxioi", Gloss = "unworthy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "are you", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κριτηρίων", Transliteration = "kritēriōn", Gloss = "of courts", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἐλαχίστων", Transliteration = "elachistōn", Gloss = "smallest", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "of the smallest courts"
                }
            },
            Translation = "Or do you not know that the saints will judge the world? And if the world is judged by you, are you unworthy to judge the smallest matters?"
        },

        // Verse 3
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "οἴδατε", Transliteration = "oidate", Gloss = "do you know", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀγγέλους", Transliteration = "angelous", Gloss = "angels", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "κρινοῦμεν", Transliteration = "krinoumen", Gloss = "we will judge", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "that we will judge angels"
                },
                new Word { Greek = "μήτι", Transliteration = "mēti", Gloss = "how much more", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "γε", Transliteration = "ge", Gloss = "indeed", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "βιωτικά", Transliteration = "biōtika", Gloss = "things of this life", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
            },
            Translation = "Do you not know that we will judge angels? How much more, then, things of this life!"
        },

        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "βιωτικὰ", Transliteration = "biōtika", Gloss = "of this life", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "μὲν", Transliteration = "men", Gloss = "on the one hand", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "κριτήρια", Transliteration = "kritēria", Gloss = "courts", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἔχητε", Transliteration = "echēte", Gloss = "you have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "if you have"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "those", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐξουθενημένους", Transliteration = "exouthenēmenous", Gloss = "despised", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "those who are least esteemed"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐκκλησίᾳ", Transliteration = "ekklēsia", Gloss = "church", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the church"
                        }
                    },
                    Translation = "in the church"
                },
                new Word { Greek = "τούτους", Transliteration = "toutous", Gloss = "these", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "καθίζετε", Transliteration = "kathizete", Gloss = "you appoint", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "If then you have judgments of things pertaining to this life, do you appoint those who are least esteemed in the church to judge?"
        },

        // Verse 5
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
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐντροπὴν", Transliteration = "entropēn", Gloss = "shame", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to shame"
                },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "so", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἔνι", Transliteration = "eni", Gloss = "is there", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
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
                new Word { Greek = "οὐδεὶς", Transliteration = "oudeis", Gloss = "no one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "σοφός", Transliteration = "sophos", Gloss = "wise", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "δυνήσεται", Transliteration = "dynēsetai", Gloss = "will be able", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "διακρῖναι", Transliteration = "diakrinai", Gloss = "to decide", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἀνὰ", Transliteration = "ana", Gloss = "between", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μέσον", Transliteration = "meson", Gloss = "middle", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀδελφοῦ", Transliteration = "adelphou", Gloss = "brother", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "his brother"
                        }
                    },
                    Translation = "who will be able to decide between his brothers"
                }
            },
            Translation = "I say this to your shame. Is it so, that there is not even one wise man among you who will be able to decide between his brothers?"
        },

        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀδελφὸς", Transliteration = "adelphos", Gloss = "brother", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀδελφοῦ", Transliteration = "adelphou", Gloss = "brother", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "with brother"
                },
                new Word { Greek = "κρίνεται", Transliteration = "krinetai", Gloss = "goes to law", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "before", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀπίστων", Transliteration = "apistōn", Gloss = "unbelievers", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "before unbelievers"
                }
            },
            Translation = "But brother goes to law with brother, and that before unbelievers!"
        },

        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἤδη", Transliteration = "Ēdē", Gloss = "already", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "μὲν", Transliteration = "men", Gloss = "on the one hand", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὅλως", Transliteration = "holōs", Gloss = "completely", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἥττημα", Transliteration = "hēttēma", Gloss = "defeat", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "for you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "it is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "κρίματα", Transliteration = "krimata", Gloss = "lawsuits", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἔχετε", Transliteration = "echete", Gloss = "you have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μεθ᾽", Transliteration = "meth'", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἑαυτῶν", Transliteration = "heautōn", Gloss = "one another", GrammarCodes = new List<string> { "PRON", "GEN", "3P", "P" }, PartOfSpeech = "f" }
                            },
                            Translation = "with one another"
                        }
                    },
                    Translation = "that you have lawsuits with one another"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "for", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τί", Transliteration = "ti", Gloss = "why", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "interj" },
                        new Word { Greek = "οὐχὶ", Transliteration = "ouchi", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "rather", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἀδικεῖσθε", Transliteration = "adikeisthe", Gloss = "be wronged", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "Why not rather be wronged?"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "for", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τί", Transliteration = "ti", Gloss = "why", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "interj" },
                        new Word { Greek = "οὐχὶ", Transliteration = "ouchi", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "rather", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἀποστερεῖσθε", Transliteration = "apostereisthe", Gloss = "be defrauded", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "Why not rather be defrauded?"
                }
            },
            Translation = "Actually, then, it is already a defeat for you, that you have lawsuits with one another. Why not rather be wronged? Why not rather be defrauded?"
        },

        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἀδικεῖτε", Transliteration = "adikete", Gloss = "wrong", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀποστερεῖτε", Transliteration = "apostereite", Gloss = "defraud", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἀδελφούς", Transliteration = "adelphous", Gloss = "brothers", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" }
            },
            Translation = "On the contrary, you yourselves wrong and defraud, and that your own brothers."
        }
    };
}

/*
Constructions identified:
- GEN_DESC: ὑμῶν (v1), τοῦ ἀδελφοῦ αὐτοῦ (v5)
- PREP_PHRASE: πρὸς τὸν ἕτερον (v1), ἐπὶ τῶν ἀδίκων (v1), ἐπὶ τῶν ἁγίων (v1), ἐν ὑμῖν (v2, v5), ἐν τῇ ἐκκλησίᾳ (v4), πρὸς ἐντροπὴν (v5), μετὰ ἀδελφοῦ (v6), ἐπὶ ἀπίστων (v6), μεθ᾽ ἑαυτῶν (v7)
- NOUN_PHRASE: τὸν ἕτερον (v1), τῶν ἀδίκων (v1), τῶν ἁγίων (v1), οἱ ἅγιοι (v2), τὸν κόσμον (v2), ὁ κόσμος (v2), κριτηρίων ἐλαχίστων (v2), τοὺς ἐξουθενημένους (v4), τῇ ἐκκλησίᾳ (v4), τοῦ ἀδελφοῦ αὐτοῦ (v5)
- REL_CLAUSE: ὃς δυνήσεται... (v5)
- COND_CLAUSE: εἰ ἐν ὑμῖν κρίνεται ὁ κόσμος (v2), ἐὰν ἔχητε (v4)
- PTCP: ἔχων (v1), ἐξουθενημένους (v4)
*/
