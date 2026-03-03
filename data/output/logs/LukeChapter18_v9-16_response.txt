private static List<object> GetChapter18()
{
    // Luke 18:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Εἶπεν", Transliteration = "Eipen", Gloss = "he told", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρός", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τινας", Transliteration = "tinas", Gloss = "some", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "part" }
                    },
                    Translation = "to some"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "πεποιθότας", Transliteration = "pepoitotas", Gloss = "having trusted", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐφ᾽", Transliteration = "eph'", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἑαυτοῖς", Transliteration = "heautois", Gloss = "themselves", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "f" }
                            },
                            Translation = "in themselves"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "εἰσὶν", Transliteration = "eisin", Gloss = "they are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                                new Word { Greek = "δίκαιοι", Transliteration = "dikiaioi", Gloss = "righteous", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "that they were righteous"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐξουθενοῦντας", Transliteration = "exouthenountas", Gloss = "treating with contempt", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "λοιποὺς", Transliteration = "loipous", Gloss = "others", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the rest"
                        }
                    },
                    Translation = "who trusted in themselves that they were righteous and treated others with contempt"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "παραβολὴν", Transliteration = "parabolēn", Gloss = "parable", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ταύτην", Transliteration = "tautēn", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "adv" }
                    },
                    Translation = "this parable"
                }
            },
            Translation = "He also told this parable to some who trusted in themselves that they were righteous, and treated others with contempt:"
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
                        new Word { Greek = "Ἄνθρωποι", Transliteration = "Anthrōpoi", Gloss = "men", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "δύο", Transliteration = "dyo", Gloss = "two", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "Two men"
                },
                new Word { Greek = "ἀνέβησαν", Transliteration = "anebēsan", Gloss = "went up", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἱερὸν", Transliteration = "hieron", Gloss = "temple", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to the temple"
                },
                new Word { Greek = "προσεύξασθαι", Transliteration = "proseuxasthai", Gloss = "to pray", GrammarCodes = new List<string> { "V", "AOR", "MID", "INF" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "APPOS" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "εἷς", Transliteration = "heis", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "Φαρισαῖος", Transliteration = "Pharisaios", Gloss = "Pharisee", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the one a Pharisee"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἕτερος", Transliteration = "heteros", Gloss = "other", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "τελώνης", Transliteration = "telōnēs", Gloss = "tax collector", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the other a tax collector"
                        }
                    },
                    Translation = "the one a Pharisee and the other a tax collector"
                }
            },
            Translation = "Two men went up into the temple to pray, the one a Pharisee and the other a tax collector."
        },

        // Verse 11
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
                        new Word { Greek = "Φαρισαῖος", Transliteration = "Pharisaios", Gloss = "Pharisee", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "The Pharisee"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σταθεὶς", Transliteration = "statheis", Gloss = "having stood", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἑαυτὸν", Transliteration = "heauton", Gloss = "himself", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "f" }
                            },
                            Translation = "by himself"
                        }
                    },
                    Translation = "standing by himself"
                },
                new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "προσηύχετο", Transliteration = "prosēucheto", Gloss = "was praying", GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "VOC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεός", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "εὐχαριστῶ", Transliteration = "eucharistō", Gloss = "I thank", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "σοι", Transliteration = "soi", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                new Word { Greek = "εἰμὶ", Transliteration = "eimi", Gloss = "I am", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "ὥσπερ", Transliteration = "hōsper", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "λοιποὶ", Transliteration = "loipoi", Gloss = "rest", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                                new Word { Greek = "ἀνθρώπων", Transliteration = "anthrōpōn", Gloss = "men", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "of men"
                                        }
                                    },
                                    Translation = "the rest of men"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἅρπαγες", Transliteration = "harpages", Gloss = "swindlers", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "ἄδικοι", Transliteration = "adikoi", Gloss = "unjust", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "μοιχοί", Transliteration = "moichoi", Gloss = "adulterers", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "swindlers, unjust, adulterers"
                                },
                                new Word { Greek = "ἢ", Transliteration = "ē", Gloss = "or", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "even", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "adv" },
                                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "τελώνης", Transliteration = "telōnēs", Gloss = "tax collector", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "this tax collector"
                                }
                            },
                            Translation = "that I am not like the rest of men, swindlers, unjust, adulterers, or even like this tax collector"
                        }
                    },
                    Translation = "God, I thank you that I am not like the rest of men, swindlers, unjust, adulterers, or even like this tax collector."
                }
            },
            Translation = "The Pharisee, standing by himself, was praying these things: 'God, I thank you that I am not like the rest of men, swindlers, unjust, adulterers, or even like this tax collector.'"
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "νηστεύω", Transliteration = "nēsteuō", Gloss = "I fast", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὶς", Transliteration = "dis", Gloss = "twice", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "σαββάτου", Transliteration = "sabbatou", Gloss = "week", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "of the week"
                }
            },
            Translation = "I fast twice a week;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀποδεκατῶ", Transliteration = "apodekatō", Gloss = "I give a tenth", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all things", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅσα", Transliteration = "hosa", Gloss = "as many as", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "k" },
                        new Word { Greek = "κτῶμαι", Transliteration = "ktōmai", Gloss = "I get", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "as many as I get"
                }
            },
            Translation = "I give tithes of all that I get."
        },

        // Verse 13
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
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τελώνης", Transliteration = "telōnēs", Gloss = "tax collector", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "But the tax collector"
                },
                new Word { Greek = "μακρόθεν", Transliteration = "makrothen", Gloss = "from a distance", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἑστὼς", Transliteration = "hestōs", Gloss = "having stood", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἤθελεν", Transliteration = "ēthelen", Gloss = "was willing", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὐδὲ", Transliteration = "oude", Gloss = "not even", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
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
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὀφθαλμοὺς", Transliteration = "ophthalmous", Gloss = "eyes", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "his eyes"
                        },
                        new Word { Greek = "ἐπᾶραι", Transliteration = "eparai", Gloss = "to lift up", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "οὐρανόν", Transliteration = "ouranon", Gloss = "heaven", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "to heaven"
                        }
                    },
                    Translation = "to even lift up his eyes to heaven"
                },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἔτυπτεν", Transliteration = "etypten", Gloss = "he was striking", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "στῆθος", Transliteration = "stēthos", Gloss = "breast", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "his breast"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "VOC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θεός", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἱλάσθητί", Transliteration = "hilasthēti", Gloss = "be merciful", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἁμαρτωλῷ", Transliteration = "hamartōlō", Gloss = "sinner", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "the sinner"
                                }
                            },
                            Translation = "God, be merciful to me, the sinner!"
                        }
                    },
                    Translation = "saying, 'God, be merciful to me, the sinner!'"
                }
            },
            Translation = "But the tax collector, standing at a distance, was not even willing to lift up his eyes to heaven, but beat his breast, saying, 'God, be merciful to me, the sinner!'"
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατέβη", Transliteration = "katebē", Gloss = "went down", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this man", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "adv" },
                        new Word { Greek = "δεδικαιωμένος", Transliteration = "dedikaiōmenos", Gloss = "justified", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "οἶκον", Transliteration = "oikon", Gloss = "house", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "to his house"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παρ᾽", Transliteration = "par'", Gloss = "rather than", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἐκεῖνον", Transliteration = "ekeinon", Gloss = "that one", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "adv" }
                            },
                            Translation = "rather than that one"
                        }
                    },
                    Translation = "this man went down to his house justified rather than the other"
                }
            },
            Translation = "I tell you, this man went down to his house justified rather than the other;"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶς", Transliteration = "pas", Gloss = "everyone", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὑψῶν", Transliteration = "hypsōn", Gloss = "exalting", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "ἑαυτὸν", Transliteration = "heauton", Gloss = "himself", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "f" }
                            },
                            Translation = "who exalts himself"
                        }
                    },
                    Translation = "everyone who exalts himself"
                },
                new Word { Greek = "ταπεινωθήσεται", Transliteration = "tapeinōthēsetai", Gloss = "will be humbled", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ταπεινῶν", Transliteration = "tapeinōn", Gloss = "humbling", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἑαυτὸν", Transliteration = "heauton", Gloss = "himself", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "f" }
                    },
                    Translation = "but the one who humbles himself"
                },
                new Word { Greek = "ὑψωθήσεται", Transliteration = "hypsōthēsetai", Gloss = "will be exalted", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "for everyone who exalts himself will be humbled, but the one who humbles himself will be exalted."
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Προσέφερον", Transliteration = "Prosepheron", Gloss = "they were bringing", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "even", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "βρέφη", Transliteration = "brephē", Gloss = "infants", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "their infants"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "them", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἅπτηται", Transliteration = "haptētai", Gloss = "he might touch", GrammarCodes = new List<string> { "V", "PRES", "MID", "SUBJ", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "that he might touch them"
                }
            },
            Translation = "Now they were bringing even infants to him that he might touch them;"
        },
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
                        new Word { Greek = "ἰδόντες", Transliteration = "idontes", Gloss = "having seen", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" }
                    },
                    Translation = "but when they saw it"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the disciples"
                },
                new Word { Greek = "ἐπετίμων", Transliteration = "epetimōn", Gloss = "were rebuking", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" }
            },
            Translation = "and when the disciples saw it, they rebuked them."
        },

        // Verse 16
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
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "But Jesus"
                },
                new Word { Greek = "προσεκαλέσατο", Transliteration = "prosekalesato", Gloss = "called", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὰ", Transliteration = "auta", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἄφετε", Transliteration = "aphete", Gloss = "permit", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "παιδία", Transliteration = "paidia", Gloss = "children", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the children"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἔρχεσθαι", Transliteration = "erchesthai", Gloss = "to come", GrammarCodes = new List<string> { "V", "PRES", "MID", "INF" }, PartOfSpeech = "v" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "πρός", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                                new Word { Greek = "με", Transliteration = "me", Gloss = "me", GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" }, PartOfSpeech = "prep" }
                                            },
                                            Translation = "to me"
                                        }
                                    },
                                    Translation = "to come to me"
                                },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                new Word { Greek = "κωλύετε", Transliteration = "kōlyete", Gloss = "hinder", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                                new Word { Greek = "αὐτά", Transliteration = "auta", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                        new Word { Greek = "τοιούτων", Transliteration = "toioutōn", Gloss = "such ones", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "adv" },
                                        new Word { Greek = "ἐστὶν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "βασιλεία", Transliteration = "basileia", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                                                new Phrase
                                                {
                                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC
