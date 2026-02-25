private static List<object> GetChapter8()
{
    // Matthew 8:25-32
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προσελθόντες", Transliteration = "proselthontes", Gloss = "having come to", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "having come to him"
                },
                new Word { Greek = "ἤγειραν", Transliteration = "ēgeiran", Gloss = "they awoke", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριε", Transliteration = "kyrie", Gloss = "Lord", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "σῶσον", Transliteration = "sōson", Gloss = "save", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἀπολλύμεθα", Transliteration = "apollymetha", Gloss = "we are perishing", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "Lord, save us, we are perishing!"
                }
            },
            Translation = "And they went and woke him, saying, 'Lord, save us, we are perishing!'"
        },
        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "he says", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti", Gloss = "why", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "interj" },
                        new Word { Greek = "δειλοί", Transliteration = "deiloi", Gloss = "afraid", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "are you", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὀλιγόπιστοι", Transliteration = "oligopistoi", Gloss = "O you of little faith", GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "Why are you afraid, O you of little faith?"
                },
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "then", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐγερθεὶς", Transliteration = "egertheis", Gloss = "having arisen", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "having arisen"
                },
                new Word { Greek = "ἐπετίμησεν", Transliteration = "epetimēsen", Gloss = "he rebuked", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀνέμοις", Transliteration = "anemois", Gloss = "winds", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the winds"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θαλάσσῃ", Transliteration = "thalassē", Gloss = "sea", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the sea"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "there was", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γαλήνη", Transliteration = "galēnē", Gloss = "a calm", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μεγάλη", Transliteration = "megalē", Gloss = "great", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a great calm"
                }
            },
            Translation = "And he said to them, 'Why are you afraid, O you of little faith?' Then he rose and rebuked the winds and the sea, and there was a great calm."
        },
        // Verse 27
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἄνθρωποι", Transliteration = "anthrōpoi", Gloss = "men", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "And the men"
                },
                new Word { Greek = "ἐθαύμασαν", Transliteration = "ethaumasan", Gloss = "marveled", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ποταπός", Transliteration = "potapos", Gloss = "what sort of man", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "interj" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "adv" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "even", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἄνεμοι", Transliteration = "anemoi", Gloss = "winds", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the winds"
                                },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θάλασσα", Transliteration = "thalassa", Gloss = "sea", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the sea"
                                },
                                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ὑπακούουσιν", Transliteration = "hypakouousin", Gloss = "they obey", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "that even the winds and the sea obey him?"
                        }
                    },
                    Translation = "What sort of man is this, that even winds and sea obey him?"
                }
            },
            Translation = "And the men marveled, saying, 'What sort of man is this, that even the winds and the sea obey him?'"
        },
        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλθόντος", Transliteration = "elthontos", Gloss = "having come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "when he had come"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "πέραν", Transliteration = "peran", Gloss = "other side", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                    },
                    Translation = "to the other side"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "χώραν", Transliteration = "chōran", Gloss = "region", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "Γαδαρηνῶν", Transliteration = "Gadarēnōn", Gloss = "Gadarenes", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the Gadarenes"
                                }
                            },
                            Translation = "the region of the Gadarenes"
                        }
                    },
                    Translation = "to the region of the Gadarenes"
                },
                new Word { Greek = "ὑπήντησαν", Transliteration = "hypēntēsan", Gloss = "met", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δύο", Transliteration = "dyo", Gloss = "two", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "δαιμονιζόμενοι", Transliteration = "daimonizomenoi", Gloss = "demon-possessed men", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "two demon-possessed men"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "out of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "μνημείων", Transliteration = "mnēmeiōn", Gloss = "tombs", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the tombs"
                        },
                        new Word { Greek = "ἐξερχόμενοι", Transliteration = "exerchomenoi", Gloss = "coming", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "coming out of the tombs"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "ADJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "χαλεποὶ", Transliteration = "chalepoi", Gloss = "fierce", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "λίαν", Transliteration = "lian", Gloss = "extremely", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
                    },
                    Translation = "extremely fierce"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "RESULT_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὥστε", Transliteration = "hōste", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἰσχύειν", Transliteration = "ischyein", Gloss = "to be able", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "τινὰ", Transliteration = "tina", Gloss = "anyone", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "part" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "παρελθεῖν", Transliteration = "parelthein", Gloss = "to pass", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "ὁδοῦ", Transliteration = "hodou", Gloss = "way", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "ἐκείνης", Transliteration = "ekeinēs", Gloss = "that", GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "adv" }
                                            },
                                            Translation = "that way"
                                        }
                                    },
                                    Translation = "through that way"
                                }
                            },
                            Translation = "to pass through that way"
                        }
                    },
                    Translation = "so that no one was able to pass through that way"
                }
            },
            Translation = "When he had come to the other side, to the region of the Gadarenes, two demon-possessed men coming out of the tombs met him. They were so extremely fierce that no one was able to pass through that way."
        },
        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interj" },
                new Word { Greek = "ἔκραξαν", Transliteration = "ekraxan", Gloss = "they cried out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti", Gloss = "What", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "interj" },
                        new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us", GrammarCodes = new List<string> { "PRON", "DAT", "C", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "σοί", Transliteration = "soi", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "υἱὲ", Transliteration = "hyie", Gloss = "Son", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "Son of God"
                        }
                    },
                    Translation = "What have we to do with you, Son of God?"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἦλθες", Transliteration = "ēlthes", Gloss = "have you come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὧδε", Transliteration = "hōde", Gloss = "here", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸ", Transliteration = "pro", Gloss = "before", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "καιροῦ", Transliteration = "kairou", Gloss = "the time", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "before the time"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "βασανίσαι", Transliteration = "basanisai", Gloss = "to torment", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us", GrammarCodes = new List<string> { "PRON", "ACC", "C", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "to torment us"
                        }
                    },
                    Translation = "Have you come here to torment us before the time?"
                }
            },
            Translation = "And behold, they cried out, saying, 'What have we to do with you, Son of God? Have you come here to torment us before the time?'"
        },
        // Verse 30
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "there was", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μακρὰν", Transliteration = "makran", Gloss = "at a distance", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπ᾽", Transliteration = "ap'", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "them", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "from them"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀγέλη", Transliteration = "agelē", Gloss = "a herd", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "χοίρων", Transliteration = "choirōn", Gloss = "of pigs", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "πολλῶν", Transliteration = "pollōn", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adj" }
                            },
                            Translation = "of many pigs"
                        }
                    },
                    Translation = "a herd of many pigs"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βοσκομένη", Transliteration = "boskomenē", Gloss = "feeding", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "feeding"
                }
            },
            Translation = "Now a herd of many pigs was feeding at some distance from them."
        },
        // Verse 31
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δαίμονες", Transliteration = "daimones", Gloss = "demons", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "And the demons"
                },
                new Word { Greek = "παρεκάλουν", Transliteration = "parekaloun", Gloss = "begged", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰ", Transliteration = "ei", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐκβάλλεις", Transliteration = "ekballeis", Gloss = "you cast out", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us", GrammarCodes = new List<string> { "PRON", "ACC", "C", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "If you cast us out"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπόστειλον", Transliteration = "aposteilon", Gloss = "send", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us", GrammarCodes = new List<string> { "PRON", "ACC", "C", "P" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἀγέλην", Transliteration = "agelēn", Gloss = "herd", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                                new Word { Greek = "χοίρων", Transliteration = "choirōn", Gloss = "pigs", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "of the pigs"
                                        }
                                    },
                                    Translation = "the herd of the pigs"
                                }
                            },
                            Translation = "into the herd of the pigs"
                        }
                    },
                    Translation = "send us into the herd of pigs."
                }
            },
            Translation = "And the demons begged him, saying, 'If you cast us out, send us into the herd of pigs.'"
        },
        // Verse 32
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπάγετε", Transliteration = "hypagete", Gloss = "Go", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "Go!"
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
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" }
                            },
                            Translation = "And they"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐξελθόντες", Transliteration = "exelthontes", Gloss = "having come out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "having come out"
                        },
                        new Word { Greek = "ἀπῆλθον", Transliteration = "apēlthon", Gloss = "went", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "χοίρους", Transliteration = "choirous", Gloss = "pigs", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the pigs"
                                }
                            },
                            Translation = "into the pigs"
                        }
                    },
                    Translation = "And they came out and went into the pigs."
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interj" },
                new Word { Greek = "ὥρμησεν", Transliteration = "ōrmēsen", Gloss = "rushed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶσα", Transliteration = "pasa", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀγέλη", Transliteration = "agelē", Gloss = "herd", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the whole herd"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κατὰ", Transliteration = "kata", Gloss = "down", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κρημνοῦ", Transliteration = "krēmnou", Gloss = "steep bank", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the steep bank"
                        }
                    },
                    Translation = "down the steep bank"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θάλασσαν", Transliteration = "thalassan", Gloss = "sea", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the sea"
                        }
                    },
                    Translation = "into the sea"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀπέθανον", Transliteration = "apethanon", Gloss = "perished", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
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
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὕδασιν", Transliteration = "hydasin", Gloss = "waters", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the waters"
                        }
                    },
                    Translation = "in the waters"
                }
            },
            Translation = "And he said to them, 'Go.' And they came out and went into the pigs, and behold, the whole herd rushed down the steep bank into the sea and perished in the waters."
        }
    };
}
// Constructions Identified:
// GEN_ABS: Verse 28 (ἐλθόντος αὐτοῦ)
// RESULT_CLAUSE: Verse 28 (ὥστε μὴ ἰσχύειν...)
// COND_CLAUSE: Verse 31 (εἰ ἐκβάλλεις ἡμᾶς)
// CAUSAL_CLAUSE: Verse 27 (ὅτι καὶ οἱ ἄνεμοι...)
