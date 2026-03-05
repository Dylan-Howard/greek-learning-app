private static List<object> GetChapter13()
{
    // Romans 13:9-14
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "μοιχεύσεις", Transliteration = "moicheuseis", Gloss = "you shall commit adultery", Grammar_codes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "φονεύσεις", Transliteration = "phoneuseis", Gloss = "you shall murder", Grammar_codes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "κλέψεις", Transliteration = "klepseis", Gloss = "you shall steal", Grammar_codes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐπιθυμήσεις", Transliteration = "epithymēseis", Gloss = "you shall covet", Grammar_codes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴ", Transliteration = "ei", Gloss = "if", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τις", Transliteration = "tis", Gloss = "any", Grammar_codes = new List<string> { "PRON", "NOM", "F", "S" }, PartOfSpeech = "part" },
                        new Word { Greek = "ἑτέρα", Transliteration = "hetera", Gloss = "other", Grammar_codes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐντολή", Transliteration = "entolē", Gloss = "commandment", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "and if there is any other commandment"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", Grammar_codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "λόγῳ", Transliteration = "logō", Gloss = "word", Grammar_codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τούτῳ", Transliteration = "toutō", Gloss = "this", Grammar_codes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "adv" }
                            },
                            Translation = "this word"
                        }
                    },
                    Translation = "in this word"
                },
                new Word { Greek = "ἀνακεφαλαιοῦται", Transliteration = "anakephalaioutai", Gloss = "it is summed up", Grammar_codes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the [saying]", Grammar_codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγαπήσεις", Transliteration = "agapēseis", Gloss = "You shall love", Grammar_codes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "πλησίον", Transliteration = "plēsion", Gloss = "neighbor", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", Grammar_codes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "your neighbor"
                                },
                                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "σεαυτόν", Transliteration = "seauton", Gloss = "yourself", Grammar_codes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "f" }
                            },
                            Translation = "You shall love your neighbor as yourself"
                        }
                    },
                    Translation = "in this: You shall love your neighbor as yourself"
                }
            },
            Translation = "For the commandments, 'You shall not commit adultery, You shall not murder, You shall not steal, You shall not covet,' and any other commandment, are summed up in this word: 'You shall love your neighbor as yourself.'"
        },

        // Verse 10
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
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀγάπη", Transliteration = "agapē", Gloss = "love", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Love"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "to the", Grammar_codes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πλησίον", Transliteration = "plēsion", Gloss = "neighbor", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                    },
                    Translation = "to a neighbor"
                },
                new Word { Greek = "κακὸν", Transliteration = "kakon", Gloss = "evil", Grammar_codes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐργάζεται", Transliteration = "ergazetai", Gloss = "does", Grammar_codes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "πλήρωμα", Transliteration = "plērōma", Gloss = "fulfillment", Grammar_codes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "νόμου", Transliteration = "nomou", Gloss = "of law", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀγάπη", Transliteration = "agapē", Gloss = "love", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "love is the fulfillment of the law"
                }
            },
            Translation = "Love does no wrong to a neighbor; therefore love is the fulfilling of the law."
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", Grammar_codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰδότες", Transliteration = "eidotes", Gloss = "knowing", Grammar_codes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "καιρόν", Transliteration = "kairon", Gloss = "time", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the time"
                        }
                    },
                    Translation = "knowing the time"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ὥρα", Transliteration = "hōra", Gloss = "hour", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἤδη", Transliteration = "ēdē", Gloss = "already", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "for you", Grammar_codes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "from", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὕπνου", Transliteration = "hypnou", Gloss = "sleep", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "out of sleep"
                        },
                        new Word { Greek = "ἐγερθῆναι", Transliteration = "egerthēnai", Gloss = "to wake", Grammar_codes = new List<string> { "V", "AOR", "PASS", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "that it is already the hour for you to wake from sleep"
                },
                new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐγγύτερον", Transliteration = "engyteron", Gloss = "nearer", Grammar_codes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "to us", Grammar_codes = new List<string> { "PRON", "GEN", "1P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σωτηρία", Transliteration = "sōtēria", Gloss = "salvation", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "salvation"
                },
                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "than", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτε", Transliteration = "hote", Gloss = "when", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐπιστεύσαμεν", Transliteration = "episteusamen", Gloss = "we believed", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "when we first believed"
                }
            },
            Translation = "Besides this you know the time, that the hour has come for you to wake from sleep. For salvation is nearer to us now than when we first believed."
        },

        // Verse 12
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
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "νὺξ", Transliteration = "nyx", Gloss = "night", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the night"
                },
                new Word { Greek = "προέκοψεν", Transliteration = "proekopsen", Gloss = "is far gone", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἡμέρα", Transliteration = "hēmera", Gloss = "day", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "but the day"
                },
                new Word { Greek = "ἤγγικεν", Transliteration = "ēngiken", Gloss = "is at hand", Grammar_codes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἀποθώμεθα", Transliteration = "apothōmetha", Gloss = "let us cast off", Grammar_codes = new List<string> { "V", "AOR", "MID", "SUBJ", "1P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἔργα", Transliteration = "erga", Gloss = "works", Grammar_codes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", Grammar_codes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σκότους", Transliteration = "skotous", Gloss = "darkness", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of darkness"
                        }
                    },
                    Translation = "the works of darkness"
                },
                new Word { Greek = "ἐνδυσώμεθα", Transliteration = "endusōmetha", Gloss = "let us put on", Grammar_codes = new List<string> { "V", "AOR", "MID", "SUBJ", "1P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὅπλα", Transliteration = "hopla", Gloss = "armor", Grammar_codes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", Grammar_codes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "φωτός", Transliteration = "phōtos", Gloss = "light", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of light"
                        }
                    },
                    Translation = "the armor of light"
                }
            },
            Translation = "The night is far gone; the day is at hand. So then let us cast off the works of darkness and put on the armor of light."
        },

        // Verse 13
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἡμέρᾳ", Transliteration = "hēmera", Gloss = "day", Grammar_codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in the day"
                },
                new Word { Greek = "εὐσχημόνως", Transliteration = "euschēmonōs", Gloss = "properly", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "περιπατήσωμεν", Transliteration = "peripatēsōmen", Gloss = "let us walk", Grammar_codes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "κώμοις", Transliteration = "kōmois", Gloss = "in orgies", Grammar_codes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μέθαις", Transliteration = "methais", Gloss = "drunkenness", Grammar_codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "κοίταις", Transliteration = "koitais", Gloss = "sexual immorality", Grammar_codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀσελγείαις", Transliteration = "aselgeiais", Gloss = "sensuality", Grammar_codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἔριδι", Transliteration = "eridi", Gloss = "quarreling", Grammar_codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ζήλῳ", Transliteration = "zēlō", Gloss = "jealousy", Grammar_codes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "Let us walk properly as in the daytime, not in orgies and drunkenness, not in sexual immorality and sensuality, not in quarreling and jealousy."
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "But", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐνδύσασθε", Transliteration = "endusasthe", Gloss = "put on", Grammar_codes = new List<string> { "V", "AOR", "MID", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κύριον", Transliteration = "kyrion", Gloss = "Lord", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Ἰησοῦν", Transliteration = "Iēsoun", Gloss = "Jesus", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "Χριστὸν", Transliteration = "Christon", Gloss = "Christ", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Lord Jesus Christ"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σαρκὸς", Transliteration = "sarkos", Gloss = "flesh", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "for the flesh"
                        },
                        new Word { Greek = "πρόνοιαν", Transliteration = "pronoian", Gloss = "provision", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "provision for the flesh"
                },
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", Grammar_codes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ποιεῖσθε", Transliteration = "poieisthe", Gloss = "make", Grammar_codes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to [gratify]", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐπιθυμίας", Transliteration = "epithymias", Gloss = "desires", Grammar_codes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "to gratify its desires"
                }
            },
            Translation = "But put on the Lord Jesus Christ, and make no provision for the flesh, to gratify its desires."
        }
    };
}

/*
Constructions identified:
- Romans 13:9: COND_CLAUSE (εἴ τις ἑτέρα ἐντολή)
- Romans 13:11: PTCP (εἰδότες) used circumstantially
- Romans 13:11: CAUSAL_CLAUSE (introduced by ὅτι)
- Romans 13:11: TEMP_CLAUSE (introduced by ὅτε)
*/
