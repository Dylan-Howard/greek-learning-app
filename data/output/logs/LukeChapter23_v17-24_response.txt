private static List<object> GetChapter23()
{
    // Luke 23:18-24
    return new List<object>
    {
        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀνέκραγον", Transliteration = "Anekragon", Gloss = "they cried out",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "παμπληθεὶ", Transliteration = "pamplēthei", Gloss = "all together",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἶρε", Transliteration = "aire", Gloss = "away with",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦτον", Transliteration = "touton", Gloss = "this man",
                                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                                    PartOfSpeech = "adv" }
                            },
                            Translation = "this man"
                        }
                    },
                    Translation = "Away with this man"
                },
                new Word { Greek = "ἀπόλυσον", Transliteration = "apolyson", Gloss = "release",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us",
                            GrammarCodes = new List<string> { "PRON", "DAT", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "to us"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Βαραββᾶν", Transliteration = "Barabban", Gloss = "Barabbas",
                            GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Barabbas"
                }
            },
            Translation = "But they all cried out together, saying, 'Away with this man, and release to us Barabbas'"
        },
        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅστις", Transliteration = "hostis", Gloss = "who",
                    GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                    PartOfSpeech = "pron" },
                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because of",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "στάσιν", Transliteration = "stasin", Gloss = "insurrection",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "τινὰ", Transliteration = "tina", Gloss = "a certain",
                                    GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" },
                                    PartOfSpeech = "part" }
                            },
                            Translation = "a certain insurrection"
                        }
                    },
                    Translation = "because of a certain insurrection"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γενομένην", Transliteration = "genomenēn", Gloss = "having started",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "ACC", "F", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having started"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "πόλει", Transliteration = "polei", Gloss = "city",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "the city"
                        }
                    },
                    Translation = "in the city"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "φόνον", Transliteration = "phonon", Gloss = "murder",
                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                    PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βληθεὶς", Transliteration = "blētheis", Gloss = "having been cast",
                            GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having been cast"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "into",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "φυλακῇ", Transliteration = "phylakē", Gloss = "prison",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "prison"
                        }
                    },
                    Translation = "into prison"
                }
            },
            Translation = "one who had been cast into prison for an insurrection started in the city and for murder"
        },
        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "πάλιν", Transliteration = "palin", Gloss = "again",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "Πιλᾶτος", Transliteration = "Pilatos", Gloss = "Pilate",
                            GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                            PartOfSpeech = "n" }
                    },
                    Translation = "Pilate"
                },
                new Word { Greek = "προσεφώνησεν", Transliteration = "prosephōnēsen", Gloss = "addressed",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them",
                    GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" },
                    PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θέλων", Transliteration = "thelōn", Gloss = "desiring",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "desiring"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπολῦσαι", Transliteration = "apolysai", Gloss = "to release",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "Ἰησοῦν", Transliteration = "Iēsoun", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "ACC", "M", "S" },
                                    PartOfSpeech = "n" }
                            },
                            Translation = "Jesus"
                        }
                    },
                    Translation = "to release Jesus"
                }
            },
            Translation = "Pilate addressed them once more, desiring to release Jesus"
        },
        // Verse 21
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the [ones]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" }
                    },
                    Translation = "they"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐπεφώνουν", Transliteration = "epephōnoun", Gloss = "kept shouting",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Word { Greek = "σταύρου", Transliteration = "staurou", Gloss = "crucify",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "σταύρου", Transliteration = "staurou", Gloss = "crucify",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" },
                    PartOfSpeech = "v" },
                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "prep" }
            },
            Translation = "but they kept shouting, 'Crucify, crucify him!'"
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [man]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "S" },
                            PartOfSpeech = "art" }
                    },
                    Translation = "he"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "τρίτον", Transliteration = "triton", Gloss = "a third time",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτούς", Transliteration = "autous", Gloss = "them",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "to them"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti", Gloss = "what",
                            GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" },
                            PartOfSpeech = "interj" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "κακὸν", Transliteration = "kakon", Gloss = "evil",
                            GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                            PartOfSpeech = "adj" },
                        new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen", Gloss = "did",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this man",
                            GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" },
                            PartOfSpeech = "adv" }
                    },
                    Translation = "Why, what evil has this man done?"
                },
                new Word { Greek = "οὐδὲν", Transliteration = "ouden", Gloss = "no",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "αἴτιον", Transliteration = "aition", Gloss = "ground",
                    GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" },
                    PartOfSpeech = "adj" },
                new Word { Greek = "θανάτου", Transliteration = "thanatou", Gloss = "for death",
                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "εὗρον", Transliteration = "heuron", Gloss = "I have found",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him",
                            GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "in him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παιδεύσας", Transliteration = "paideusas", Gloss = "having punished",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" },
                            PartOfSpeech = "v" }
                    },
                    Translation = "having punished"
                },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him",
                    GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                    PartOfSpeech = "prep" },
                new Word { Greek = "ἀπολύσω", Transliteration = "apolysō", Gloss = "I will release",
                    GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" },
                    PartOfSpeech = "v" }
            },
            Translation = "A third time he said to them, 'Why, what evil has this man done? I have found in him no guilt deserving death. I will therefore punish and release him'"
        },
        // Verse 23
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the [ones]",
                            GrammarCodes = new List<string> { "ART", "NOM", "M", "P" },
                            PartOfSpeech = "art" }
                    },
                    Translation = "they"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἐπέκειντο", Transliteration = "epekeinto", Gloss = "were urgent",
                    GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φωναῖς", Transliteration = "phōnais", Gloss = "with voices",
                            GrammarCodes = new List<string> { "N", "DAT", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "μεγάλαις", Transliteration = "megalais", Gloss = "loud",
                            GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" },
                            PartOfSpeech = "adj" }
                    },
                    Translation = "with loud voices"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἰτούμενοι", Transliteration = "aitoumenoi", Gloss = "asking",
                            GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "that he",
                            GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "σταυρωθῆναι", Transliteration = "staurōthēnai", Gloss = "be crucified",
                                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "INF" },
                                    PartOfSpeech = "v" }
                            },
                            Translation = "should be crucified"
                        }
                    },
                    Translation = "asking that he should be crucified"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "κατίσχυον", Transliteration = "katischyon", Gloss = "prevailed",
                    GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αἱ", Transliteration = "hai", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "P" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "φωναὶ", Transliteration = "phōnai", Gloss = "voices",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "P" },
                            PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them",
                            GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                            PartOfSpeech = "prep" }
                    },
                    Translation = "their voices"
                }
            },
            Translation = "But they were urgent, demanding with loud voices that he should be crucified. And their voices prevailed"
        },
        // Verse 24
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "so",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "Πιλᾶτος", Transliteration = "Pilatos", Gloss = "Pilate",
                    GrammarCodes = new List<string> { "N", "NOM", "M", "S" },
                    PartOfSpeech = "n" },
                new Word { Greek = "ἐπέκρινεν", Transliteration = "epek rinen", Gloss = "gave sentence",
                    GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" },
                    PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "γενέσθαι", Transliteration = "genesthai", Gloss = "to be granted",
                            GrammarCodes = new List<string> { "V", "AOR", "MID", "INF" },
                            PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "ACC", "N", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "αἴτημα", Transliteration = "aitēma", Gloss = "demand",
                                    GrammarCodes = new List<string> { "N", "ACC", "N", "S" },
                                    PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them",
                                    GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" },
                                    PartOfSpeech = "prep" }
                            },
                            Translation = "their demand"
                        }
                    },
                    Translation = "that their demand should be granted"
                }
            },
            Translation = "So Pilate gave sentence that their demand should be granted"
        }
    };
}
/*
Constructions identified:
- DAT_MANNER: φωναῖς μεγάλαις (v23)
- INF_PHRASE (subject of indirect command/request): γενέσθαι τὸ αἴτημα αὐτῶν (v24)
*/
