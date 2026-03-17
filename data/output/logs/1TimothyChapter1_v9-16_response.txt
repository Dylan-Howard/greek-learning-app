private static List<object> GetChapter1()
{
    // 1 Timothy 1:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἰδὼς", Transliteration = "eidōs",
                    Gloss = "knowing",
                    GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "M", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "τοῦτο", Transliteration = "touto",
                    Gloss = "this",
                    GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                    PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti",
                            Gloss = "that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δικαίῳ", Transliteration = "dikaiō",
                                    Gloss = "for a righteous person",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" },
                                    PartOfSpeech = "adj" }
                            },
                            Translation = "for a righteous person"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "νόμος", Transliteration = "nomos",
                                    Gloss = "law",
                                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "law"
                        },
                        new Word { Greek = "οὐ", Transliteration = "ou",
                            Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "κεῖται", Transliteration = "keitai",
                            Gloss = "is laid down",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀνόμοις", Transliteration = "anomois",
                                    Gloss = "for the lawless",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "δὲ", Transliteration = "de",
                                    Gloss = "but",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "καὶ", Transliteration = "kai",
                                    Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "ἀνυποτάκτοις", Transliteration = "anypotaktois",
                                    Gloss = "rebellious",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἀσεβέσιν", Transliteration = "asebesin",
                                    Gloss = "ungodly",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "καὶ", Transliteration = "kai",
                                    Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "ἁμαρτωλοῖς", Transliteration = "hamartōlois",
                                    Gloss = "sinners",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "ἀνοσίοις", Transliteration = "anosiois",
                                    Gloss = "unholy",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "καὶ", Transliteration = "kai",
                                    Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "βεβήλοις", Transliteration = "bebēlois",
                                    Gloss = "profane",
                                    GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "πατρολῴαις", Transliteration = "patrolōais",
                                    Gloss = "those who kill fathers",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai",
                                    Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "μητρολῴαις", Transliteration = "mētrolōais",
                                    Gloss = "those who kill mothers",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἀνδροφόνοις", Transliteration = "androphonois",
                                    Gloss = "murderers",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "but for the lawless and rebellious, for the ungodly and sinners, for the unholy and profane, for those who kill their fathers and mothers, for murderers"
                        }
                    },
                    Translation = "that the law is not laid down for the righteous but for the lawless and rebellious..."
                }
            },
            Translation = "understanding this, that the law is not laid down for the righteous but for the lawless and rebellious..."
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
            Content = new List<object>
            {
                // (continues verse 9)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πόρνοις", Transliteration = "pornois",
                            Gloss = "the sexually immoral",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἀρσενοκοίταις", Transliteration = "arsenokoitais",
                            Gloss = "men who practice homosexuality",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἀνδραποδισταῖς", Transliteration = "andrapodistais",
                            Gloss = "enslavers",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ψεύσταις", Transliteration = "pseustais",
                            Gloss = "liars",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "ἐπιόρκοις", Transliteration = "epiorkois",
                            Gloss = "perjurers",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "M", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "the sexually immoral, men who practice homosexuality, enslavers, liars, perjurers"
                },
                new Word { Greek = "καὶ", Transliteration = "kai",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴ", Transliteration = "ei",
                            Gloss = "if",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "τι", Transliteration = "ti",
                            Gloss = "anything",
                            GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" },
                            PartOfSpeech = "part" },
                        new Word { Greek = "ἕτερον", Transliteration = "heteron",
                            Gloss = "else",
                            GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ὑγιαινούσῃ", Transliteration = "hygiainousē",
                                    Gloss = "sound",
                                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "DAT", "F", "S" },
                                    PartOfSpeech = "v" },
                                new Word { Greek = "διδασκαλίᾳ", Transliteration = "didaskalia",
                                    Gloss = "teaching",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "to sound teaching"
                        },
                        new Word { Greek = "ἀντίκειται", Transliteration = "antikeitai",
                            Gloss = "is contrary",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "and whatever else is contrary to sound teaching"
                }
            },
            Translation = "the sexually immoral, men who practice homosexuality, enslavers, liars, perjurers, and whatever else is contrary to sound teaching"
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "PREP_PHRASE" },
            Content = new List<object>
            {
                new Word { Greek = "κατὰ", Transliteration = "kata",
                    Gloss = "in accordance with",
                    GrammarCodes = new List<string> { "PREP" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "εὐαγγέλιον", Transliteration = "euangelion",
                            Gloss = "gospel",
                            GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "δόξης", Transliteration = "doxēs",
                                    Gloss = "glory",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou",
                                            Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "μακαρίου", Transliteration = "makariou",
                                            Gloss = "blessed",
                                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" },
                                            PartOfSpeech = "adj" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou",
                                            Gloss = "God",
                                            GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "of the blessed God"
                                }
                            },
                            Translation = "of the glory of the blessed God"
                        }
                    },
                    Translation = "the gospel of the glory of the blessed God"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho",
                            Gloss = "with which",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "pron" },
                        new Word { Greek = "ἐπιστεύθην", Transliteration = "episteuthēn",
                            Gloss = "I have been entrusted",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "1P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἐγώ", Transliteration = "egō",
                            Gloss = "I",
                            GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "with which I have been entrusted"
                }
            },
            Translation = "in accordance with the gospel of the glory of the blessed God with which I have been entrusted."
        },

        // Verse 12
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
                        new Word { Greek = "Χάριν", Transliteration = "charin",
                            Gloss = "thanks",
                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "thanks"
                },
                new Word { Greek = "ἔχω", Transliteration = "echō",
                    Gloss = "I have",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō",
                            Gloss = "to the one",
                            GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "ἐνδυναμώσαντί", Transliteration = "endynamōsanti",
                            Gloss = "who strengthened",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "DAT", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "με", Transliteration = "me",
                            Gloss = "me",
                            GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "Χριστῷ", Transliteration = "Christō",
                            Gloss = "Christ",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou",
                            Gloss = "Jesus",
                            GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō",
                                    Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κυρίῳ", Transliteration = "kyriō",
                                    Gloss = "Lord",
                                    GrammarCodes = new List<string> { "N", "DAT", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn",
                                    Gloss = "of us",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "our Lord"
                        }
                    },
                    Translation = "to Christ Jesus our Lord who strengthened me"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti",
                            Gloss = "because",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "πιστόν", Transliteration = "piston",
                            Gloss = "faithful",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "με", Transliteration = "me",
                            Gloss = "me",
                            GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "ἡγήσατο", Transliteration = "hēgēsato",
                            Gloss = "he considered",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "θέμενος", Transliteration = "themenos",
                                    Gloss = "appointing",
                                    GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "S" },
                                    PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "eis",
                                            Gloss = "to",
                                            GrammarCodes = new List<string> { "PREP" },
                                            PartOfSpeech = "prep" },
                                        new Word { Greek = "διακονίαν", Transliteration = "diakonian",
                                            Gloss = "ministry",
                                            GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                            PartOfSpeech = "n" }
                                    },
                                    Translation = "to ministry"
                                }
                            },
                            Translation = "appointing me to his service"
                        }
                    },
                    Translation = "because he considered me faithful, appointing me to his service"
                }
            },
            Translation = "I thank Christ Jesus our Lord, who has strengthened me, because he considered me faithful, appointing me to his service,"
        },

        // Verse 13
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
                        new Word { Greek = "τὸ", Transliteration = "to",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "πρότερον", Transliteration = "proteron",
                            Gloss = "formerly",
                            GrammarCodes = new List<string> { "ADV" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ὄντα", Transliteration = "onta",
                            Gloss = "being",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "βλάσφημον", Transliteration = "blasphēmon",
                                    Gloss = "a blasphemer",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "καὶ", Transliteration = "kai",
                                    Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "διώκτην", Transliteration = "diōktēn",
                                    Gloss = "a persecutor",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai",
                                    Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "ὑβριστήν", Transliteration = "hybristēn",
                                    Gloss = "an insolent man",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "a blasphemer, persecutor, and insolent opponent"
                        }
                    },
                    Translation = "though formerly I was a blasphemer, persecutor, and insolent opponent"
                },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'",
                    Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἠλεήθην", Transliteration = "ēleēthēn",
                    Gloss = "I was shown mercy",
                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti",
                            Gloss = "because",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "ἀγνοῶν", Transliteration = "agnoōn",
                            Gloss = "acting ignorantly",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "ἐποίησα", Transliteration = "epoiēsa",
                            Gloss = "I acted",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en",
                                    Gloss = "in",
                                    GrammarCodes = new List<string> { "PREP" },
                                    PartOfSpeech = "prep" },
                                new Word { Greek = "ἀπιστίᾳ", Transliteration = "apistia",
                                    Gloss = "unbelief",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "in unbelief"
                        }
                    },
                    Translation = "because I acted ignorantly in unbelief"
                }
            },
            Translation = "though formerly I was a blasphemer, persecutor, and insolent opponent. But I received mercy because I had acted ignorantly in unbelief,"
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὑπερεπλεόνασεν", Transliteration = "hyperepleonasen",
                    Gloss = "overflowed",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de",
                    Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē",
                            Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "χάρις", Transliteration = "charis",
                            Gloss = "grace",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou",
                                    Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κυρίου", Transliteration = "kyriou",
                                    Gloss = "Lord",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn",
                                    Gloss = "of us",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "1P", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "of our Lord"
                        }
                    },
                    Translation = "the grace of our Lord"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta",
                            Gloss = "with",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πίστεως", Transliteration = "pisteōs",
                                    Gloss = "faith",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai",
                                    Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "ἀγάπης", Transliteration = "agapēs",
                                    Gloss = "love",
                                    GrammarCodes = new List<string> { "N", "GEN", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῆς", Transliteration = "tēs",
                                            Gloss = "which is",
                                            GrammarCodes = new List<string> { "ART", "GEN", "F", "S" },
                                            PartOfSpeech = "art" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἐν", Transliteration = "en",
                                                    Gloss = "in",
                                                    GrammarCodes = new List<string> { "PREP" },
                                                    PartOfSpeech = "prep" },
