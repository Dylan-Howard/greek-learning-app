private static List<object> GetChapter1()
{
    // Jude 1:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ὁ", Transliteration = "Ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Μιχαὴλ", Transliteration = "Michaēl", Gloss = "Michael", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀρχάγγελος", Transliteration = "archangelos", Gloss = "archangel", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Michael the archangel"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτε", Transliteration = "hote", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "διαβόλῳ", Transliteration = "diabolō", Gloss = "devil", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "with the devil"
                        },
                        new Word { Greek = "διακρινόμενος", Transliteration = "diakrinomenos", Gloss = "disputing", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "διελέγετο", Transliteration = "dielegeto", Gloss = "he reasoned", GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "Μωϋσέως", Transliteration = "Mōuseōs", Gloss = "of Moses", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "σώματος", Transliteration = "sōmatos", Gloss = "body", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the body of Moses"
                                }
                            },
                            Translation = "about the body of Moses"
                        }
                    },
                    Translation = "when he was disputing with the devil and arguing about the body of Moses"
                },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἐτόλμησεν", Transliteration = "etolmēsen", Gloss = "he dared", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κρίσιν", Transliteration = "krisin", Gloss = "judgment", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἐπενεγκεῖν", Transliteration = "epenenkein", Gloss = "to bring", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "βλασφημίας", Transliteration = "blasphēmias", Gloss = "of blasphemy", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to bring a reviling judgment"
                },
                new Word { Greek = "ἀλλ᾽", Transliteration = "all'", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἐπιτιμήσαι", Transliteration = "epitimēsai", Gloss = "may rebuke", GrammarCodes = new List<string> { "V", "AOR", "ACT", "OPT", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "Lord", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Lord"
                }
            },
            Translation = "But Michael the archangel, when he was disputing with the devil and arguing about the body of Moses, did not dare to bring a reviling judgment, but said, 'The Lord rebuke you.'"
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
                        new Word { Greek = "οὗτοι", Transliteration = "houtoi", Gloss = "these", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "adv" }
                    },
                    Translation = "these men"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅσα", Transliteration = "hosa", Gloss = "whatever", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "k" },
                        new Word { Greek = "μὲν", Transliteration = "men", Gloss = "indeed", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "οἴδασιν", Transliteration = "oidasin", Gloss = "they know", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "whatever they do not know"
                },
                new Word { Greek = "βλασφημοῦσιν", Transliteration = "blasphēmousin", Gloss = "they blaspheme", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅσα", Transliteration = "hosa", Gloss = "whatever", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "k" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "φυσικῶς", Transliteration = "physikōs", Gloss = "naturally", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἄλογα", Transliteration = "aloga", Gloss = "unreasoning", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ζῷα", Transliteration = "zōia", Gloss = "animals", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "unreasoning animals"
                        },
                        new Word { Greek = "ἐπίστανται", Transliteration = "epistantai", Gloss = "they understand", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "whatever they understand naturally like unreasoning animals"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τούτοις", Transliteration = "toutois", Gloss = "these", GrammarCodes = new List<string> { "PRON", "DAT", "N", "P" }, PartOfSpeech = "adv" }
                    },
                    Translation = "by these things"
                },
                new Word { Greek = "φθείρονται", Transliteration = "phtheirontai", Gloss = "they are destroyed", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "But these men blaspheme whatever they do not know, and whatever they understand naturally like unreasoning animals, by these things they are destroyed."
        },
        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὐαὶ", Transliteration = "ouai", Gloss = "woe", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interj" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὁδῷ", Transliteration = "hodō", Gloss = "way", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Κάϊν", Transliteration = "Kain", Gloss = "Cain", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in the way of Cain"
                        },
                        new Word { Greek = "ἐπορεύθησαν", Transliteration = "eporeuthēsan", Gloss = "they went", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πλάνῃ", Transliteration = "planē", Gloss = "error", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Βαλαὰμ", Transliteration = "Balaam", Gloss = "Balaam", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "μισθοῦ", Transliteration = "misthou", Gloss = "for profit", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "abandoned themselves to Balaam's error for profit"
                        },
                        new Word { Greek = "ἐξεχύθησαν", Transliteration = "exechythēsan", Gloss = "they rushed", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀντιλογίᾳ", Transliteration = "antilogia", Gloss = "rebellion", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Κόρε", Transliteration = "Kore", Gloss = "Korah", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in Korah's rebellion"
                        },
                        new Word { Greek = "ἀπώλοντο", Transliteration = "apōlonto", Gloss = "they perished", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "for they went the way of Cain and abandoned themselves for profit to Balaam's error and perished in Korah's rebellion"
                }
            },
            Translation = "Woe to them! For they went the way of Cain and abandoned themselves for profit to Balaam's error and perished in Korah's rebellion."
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὗτοί", Transliteration = "houtoi", Gloss = "these", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "εἰσιν", Transliteration = "eisin", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "at", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀγάπαις", Transliteration = "agapais", Gloss = "love feasts", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "σπιλάδες", Transliteration = "spilades", Gloss = "blemishes", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "blemishes at your love feasts"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συνευωχούμενοι", Transliteration = "syneuōchoumenoi", Gloss = "feasting together", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἀφόβως", Transliteration = "aphobōs", Gloss = "fearlessly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἑαυτοὺς", Transliteration = "heautous", Gloss = "themselves", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "f" },
                        new Word { Greek = "ποιμαίνοντες", Transliteration = "poimainontes", Gloss = "shepherding", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "feasting with you without fear, shepherding themselves"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "νεφέλαι", Transliteration = "nephelai", Gloss = "clouds", GrammarCodes = new List<string> { "N", "NOM", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἄνυδροι", Transliteration = "anydroi", Gloss = "waterless", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "waterless clouds"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀνέμων", Transliteration = "anemōn", Gloss = "winds", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "παραφερόμεναι", Transliteration = "parapheromenai", Gloss = "swept along", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "NOM", "F", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "swept along by winds"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δένδρα", Transliteration = "dendra", Gloss = "trees", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "φθινοπωρινὰ", Transliteration = "phthinopōrina", Gloss = "in late autumn", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἄκαρπα", Transliteration = "akarpa", Gloss = "fruitless", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "fruitless trees in late autumn"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δὶς", Transliteration = "dis", Gloss = "twice", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἀποθανόντα", Transliteration = "apothanonta", Gloss = "dead", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "N", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἐκριζωθέντα", Transliteration = "ekrizōthenta", Gloss = "uprooted", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "N", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "twice dead, uprooted"
                }
            },
            Translation = "These are blemishes at your love feasts, as they feast with you without fear, shepherding themselves; waterless clouds, swept along by winds; fruitless trees in late autumn, twice dead, uprooted;"
        },
        // Verse 13
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
                        new Word { Greek = "κύματα", Transliteration = "kymata", Gloss = "waves", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "ἄγρια", Transliteration = "agria", Gloss = "wild", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "θαλάσσης", Transliteration = "thalassēs", Gloss = "of the sea", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "wild waves of the sea"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπαφρίζοντα", Transliteration = "epaphrizonta", Gloss = "foaming up", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἑαυτῶν", Transliteration = "heautōn", Gloss = "their own", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "f" },
                                new Word { Greek = "αἰσχύνας", Transliteration = "aischynas", Gloss = "shame", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "their own shame"
                        }
                    },
                    Translation = "foaming up their own shame"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀστέρες", Transliteration = "asteres", Gloss = "stars", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "πλανῆται", Transliteration = "planētai", Gloss = "wandering", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "wandering stars"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἷς", Transliteration = "hois", Gloss = "for whom", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pron" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ζόφος", Transliteration = "zophos", Gloss = "gloom", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σκότους", Transliteration = "skotous", Gloss = "darkness", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the gloom of utter darkness"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "for", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αἰῶνα", Transliteration = "aiōna", Gloss = "eternity", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "forever"
                        },
                        new Word { Greek = "τετήρηται", Transliteration = "tetērētai", Gloss = "has been reserved", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "for whom the gloom of utter darkness has been reserved forever"
                }
            },
            Translation = "wild waves of the sea, foaming up their own shame; wandering stars, for whom the gloom of utter darkness has been reserved forever."
        },
        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Προεφήτευσεν", Transliteration = "Proephēteusen", Gloss = "prophesied", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "τούτοις", Transliteration = "toutois", Gloss = "about these", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕβδομος", Transliteration = "hebdomos", Gloss = "seventh", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "Ἀδὰμ", Transliteration = "Adam", Gloss = "Adam", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "from Adam"
                        },
                        new Word { Greek = "Ἑνὼχ", Transliteration = "Enōch", Gloss = "Enoch", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Enoch, the seventh from Adam"
                },
                new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "Behold", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interj" },
                new Word { Greek = "ἦλθεν", Transliteration = "ēlthen", Gloss = "came", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριος", Transliteration = "kyrios", Gloss = "the Lord", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Lord"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἁγίαις", Transliteration = "hagiais", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "μυριάσιν", Transliteration = "myriasin", Gloss = "myriads", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "his holy myriads"
                        }
                    },
                    Translation = "with ten thousands of his holy ones"
                }
            },
            Translation = "It was also about these that Enoch, the seventh from Adam, prophesied, saying, 'Behold, the Lord comes with ten thousands of his holy ones,'"
        },
        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ποιῆσαι", Transliteration = "poiēsai", Gloss = "to execute", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "κρίσιν", Transliteration = "krisin", Gloss = "judgment", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "on all"
                        }
                    },
                    Translation = "to execute judgment on all"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλέγξαι", Transliteration = "elenxai", Gloss = "to convict", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πᾶσαν", Transliteration = "pasan", Gloss = "every", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ψυχὴν", Transliteration = "psychēn", Gloss = "soul", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "all the ungodly"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἔργων", Transliteration = "ergōn", Gloss = "deeds", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ἀσεβείας", Transliteration = "asebeias", Gloss = "of ungodliness", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "all their deeds of ungodliness"
                                }
                            },
                            Translation = "of all their deeds of ungodliness"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "which", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pron" },
                                new Word { Greek = "ἠσέβησαν", Transliteration = "ēsēbēsan", Gloss = "they committed in an ungodly way", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "that they have committed in such an ungodly way"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "σκληρῶν", Transliteration = "sklērōn", Gloss = "harsh things", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "all the harsh things"
                                }
                            },
                            Translation = "of all the harsh things"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "which", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pron" },
                                new Word { Greek = "ἐλάλησαν", Transliteration = "elalēsan", Gloss = "they spoke", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "κατ᾽", Transliteration = "kat'", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "against him"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἁμαρτωλοὶ", Transliteration = "hamartōloi", Gloss = "sinners", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "ἀσεβεῖς", Transliteration = "asebeis", Gloss = "ungodly", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "ungodly sinners"
                                }
                            },
                            Translation = "that ungodly sinners have spoken against him"
                        }
                    },
                    Translation = "and to convict all the ungodly of all their deeds of ungodliness that they have committed in such an ungodly way, and of all the harsh things that ungodly sinners have spoken against him."
                }
            },
            Translation = "to execute judgment on all and to convict all the ungodly of all their deeds of ungodliness that they have committed in such an ungodly way, and of all the harsh things that ungodly sinners have spoken against him."
        },
        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὗτοί", Transliteration = "houtoi", Gloss = "These", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "εἰσιν", Transliteration = "eisin", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γογγυσταὶ", Transliteration = "gongystai", Gloss = "grumblers", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "μεμψίμοιροι", Transliteration = "mempsimoiroi", Gloss = "complainers", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "grumblers, malcontents"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "according to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὰς", Transliteration = "tas", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἐπιθυμίας", Transliteration = "epithymias", Gloss = "desires", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ἑαυτῶν", Transliteration = "heautōn", Gloss = "their own", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "f" }
                                    },
                                    Translation = "their own sinful desires"
                                }
                            },
                            Translation = "according to their own sinful desires"
                        },
                        new Word { Greek = "πορευόμενοι", Transliteration = "poreuomenoi", Gloss = "following", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "following after their own desires"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
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
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "στόμα", Transliteration = "stoma", Gloss = "mouth", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "their mouth"
                        },
                        new Word { Greek = "λαλεῖ", Transliteration = "lalei", Gloss = "speaks", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὑπέρογκα", Transliteration = "hyperonka", Gloss = "loud-mouthed boasts", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "and their mouth speaks loud-mouthed boasts"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θαυμάζοντες", Transliteration = "thaumazontes", Gloss = "showing favoritism", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "πρόσωπα", Transliteration = "prosōpa", Gloss = "to faces", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
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
                                        new Word { Greek = "ὠφελείας", Transliteration = "ōpheleias", Gloss = "of advantage", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "for the sake of advantage"
                                },
                                new Word { Greek = "χάριν", Transliteration = "charin", Gloss = "for the sake of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" }
                            },
                            Translation = "for the sake of advantage"
                        }
                    },
                    Translation = "showing favoritism to people for the sake of advantage"
                }
            },
            Translation = "These are grumblers, malcontents, following their own sinful desires; their mouth utters haughty predicts, showing favoritism to people for the sake of advantage."
        }
    };
}

/*
Constructions Identified:
- Verse 9: TEMP_CLAUSE (ὅτε τῷ διαβόλῳ διακρινόμενος διελέγετο...)
- Verse 12: NOUN_PHRASE PRED (οἱ ... σπιλάδες, νεφέλαι ἄνυδροι, κλπ)
- Verse 14: NOUN_PHRASE SUBJ (ἕβδομος ἀπὸ Ἀδὰμ Ἑνὼχ)
- Verse 15: PURPOSE_CLAUSE / INF_PHRASE (ποιῆσαι κρίσιν...)
- Verse 16: PTCP (πορευόμενοι, θαυμάζοντες)
*/
