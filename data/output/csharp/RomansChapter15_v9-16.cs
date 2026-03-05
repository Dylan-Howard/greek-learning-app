private static List<object> GetChapter15()
{
    // Romans 15:9-16
    return new List<object>
    {
        // Verse 9
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
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἔθνη", Transliteration = "ethnē", Gloss = "Gentiles", Grammar_codes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "but the Gentiles"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὑπὲρ", Transliteration = "hyper", Gloss = "for the sake of", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐλέους", Transliteration = "eleous", Gloss = "mercy", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "for His mercy"
                },
                new Word { Greek = "δοξάσαι", Transliteration = "doxasai", Gloss = "to glorify", Grammar_codes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεόν", Transliteration = "theon", Gloss = "God", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "God"
                }
            },
            Translation = "and that the Gentiles might glorify God for his mercy,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καθὼς", Transliteration = "kathōs", Gloss = "as", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it is written", Grammar_codes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "as it is written,"
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
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because of", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", Grammar_codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "adv" }
                    },
                    Translation = "Therefore"
                },
                new Word { Greek = "ἐξομολογήσομαί", Transliteration = "exomologēsomai", Gloss = "I will confess", Grammar_codes = new List<string> { "V", "FUT", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σοι", Transliteration = "soi", Gloss = "to you", Grammar_codes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἔθνεσιν", Transliteration = "ethnesin", Gloss = "Gentiles", Grammar_codes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "among the Gentiles"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
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
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", Grammar_codes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὀνόματί", Transliteration = "onomati", Gloss = "name", Grammar_codes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", Grammar_codes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "to your name"
                        }
                    },
                    Translation = "to your name"
                },
                new Word { Greek = "ψαλῶ", Transliteration = "psalō", Gloss = "I will sing", Grammar_codes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "“Therefore I will confess to you among the Gentiles, and sing to your name.”"
        },

        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πάλιν", Transliteration = "palin", Gloss = "again", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "it says", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "εὐφράνθητε", Transliteration = "euphranthēte", Gloss = "rejoice", Grammar_codes = new List<string> { "V", "AOR", "PASS", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ἔθνη", Transliteration = "ethnē", Gloss = "O Gentiles", Grammar_codes = new List<string> { "N", "VOC", "N", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "λαοῦ", Transliteration = "laou", Gloss = "people", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", Grammar_codes = new List<string> { "PRON", "GEN", "3P", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "his people"
                        }
                    },
                    Translation = "with his people"
                }
            },
            Translation = "And again it says, “Rejoice, O Gentiles, with his people.”"
        },

        // Verse 11
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πάλιν", Transliteration = "palin", Gloss = "again", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "αἰνεῖτε", Transliteration = "aineite", Gloss = "praise", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all", Grammar_codes = new List<string> { "ADJ", "VOC", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", Grammar_codes = new List<string> { "ART", "VOC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἔθνη", Transliteration = "ethnē", Gloss = "Gentiles", Grammar_codes = new List<string> { "N", "VOC", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "all you Gentiles"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "κύριον", Transliteration = "kyrion", Gloss = "Lord", Grammar_codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Lord"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐπαινεσάτωσαν", Transliteration = "epainesatōsan", Gloss = "let laud", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IMP", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", Grammar_codes = new List<string> { "PRON", "ACC", "3P", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάντες", Transliteration = "pantes", Gloss = "all", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "λαοί", Transliteration = "laoi", Gloss = "peoples", Grammar_codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "all the peoples"
                }
            },
            Translation = "And again, “Praise the Lord, all you Gentiles, and let all the peoples extol him.”"
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "πάλιν", Transliteration = "palin", Gloss = "again", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "Ἠσαΐας", Transliteration = "Ēsaias", Gloss = "Isaiah", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "says", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ἔσται", Transliteration = "estai", Gloss = "there shall be", Grammar_codes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ῥίζα", Transliteration = "rhiza", Gloss = "root", Grammar_codes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Ἰεσσαὶ", Transliteration = "Iessai", Gloss = "Jesse", Grammar_codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of Jesse"
                        }
                    },
                    Translation = "the root of Jesse"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀνιστάμενος", Transliteration = "anistamenos", Gloss = "rising", Grammar_codes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the one rising"
                },
                new Word { Greek = "ἄρχειν", Transliteration = "archein", Gloss = "to rule", Grammar_codes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                new Word { Greek = "ἐθνῶν", Transliteration = "ethnōn", Gloss = "Gentiles", Grammar_codes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπ᾽", Transliteration = "ep'", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", Grammar_codes = new List<string> { "PRON", "DAT", "3P", "M", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "in him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἔθνη", Transliteration = "ethnē", Gloss = "the Gentiles", Grammar_codes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the Gentiles"
                },
                new Word { Greek = "ἐλπιοῦσιν", Transliteration = "elpiousin", Gloss = "will hope", Grammar_codes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "And again Isaiah says, “The root of Jesse will come, even he who arises to rule the Gentiles; in him will the Gentiles hope.”"
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
                        new Word { Greek = "Ὁ", Transliteration = "Ho", Gloss = "the", Grammar_codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", Grammar_codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "of", Grammar_codes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἐλπίδος", Transliteration = "elpidos", Gloss = "hope", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of hope"
                        }
                    },
                    Translation = "May the God of hope"
                },
                new Word { Greek = "πληρώσαι", Transliteration = "plērōsai", Gloss = "fill", Grammar_codes = new List<string> { "V", "AOR", "ACT", "OPT", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", Grammar_codes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάσης", Transliteration = "pasēs", Gloss = "all", Grammar_codes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "χαρᾶς", Transliteration = "charas", Gloss = "joy", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "εἰρήνης", Transliteration = "eirēnēs", Gloss = "peace", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "with all joy and peace"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", Grammar_codes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πιστεύειν", Transliteration = "pisteuein", Gloss = "believing", Grammar_codes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "believing"
                        }
                    },
                    Translation = "in believing"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "περισσεύειν", Transliteration = "perisseuein", Gloss = "abound", Grammar_codes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", Grammar_codes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", Grammar_codes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἐλπίδι", Transliteration = "elpidi", Gloss = "hope", Grammar_codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "in hope"
                                }
                            },
                            Translation = "that you may abound in hope"
                        }
                    },
                    Translation = "so that you may abound in hope"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "by", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δυνάμει", Transliteration = "dynamei", Gloss = "power", Grammar_codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πνεύματος", Transliteration = "pneumatos", Gloss = "Spirit", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἁγίου", Transliteration = "hagiou", Gloss = "Holy", Grammar_codes = new List<string> { "ADJ", "GEN", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "of the Holy Spirit"
                        }
                    },
                    Translation = "by the power of the Holy Spirit"
                }
            },
            Translation = "May the God of hope fill you with all joy and peace in believing, so that by the power of the Holy Spirit you may abound in hope."
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Πέπεισμαι", Transliteration = "Pepeismai", Gloss = "I am satisfied", Grammar_codes = new List<string> { "V", "PERF", "PASS", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "and", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers", Grammar_codes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "my", Grammar_codes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "my brothers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "even", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "himself", Grammar_codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", Grammar_codes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "prep" }
                    },
                    Translation = "I myself"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you", Grammar_codes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "concerning you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτοὶ", Transliteration = "autoi", Gloss = "yourselves", Grammar_codes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μεστοί", Transliteration = "mestoi", Gloss = "full", Grammar_codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "you are", Grammar_codes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἀγαθωσύνης", Transliteration = "agathōsynēs", Gloss = "of goodness", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "πεπληρωμένοι", Transliteration = "peplērōmenoi", Gloss = "having been filled", Grammar_codes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάσης", Transliteration = "pasēs", Gloss = "all", Grammar_codes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", Grammar_codes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "γνώσεως", Transliteration = "gnōseōs", Gloss = "knowledge", Grammar_codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "with all knowledge"
                        },
                        new Word { Greek = "δυνάμενοι", Transliteration = "dynamenoi", Gloss = "being able", Grammar_codes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἀλλήλους", Transliteration = "allēlous", Gloss = "one another", Grammar_codes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "conj" },
                        new Word { Greek = "νουθετεῖν", Transliteration = "nouthetein", Gloss = "to instruct", Grammar_codes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "that you yourselves are full of goodness, filled with all knowledge and able also to instruct one another."
                }
            },
            Translation = "I myself am satisfied about you, my brothers, that you yourselves are full of goodness, filled with all knowledge and able also to instruct one another."
        },

        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "τολμηρότερον", Transliteration = "tolmēroteron", Gloss = "more boldly", Grammar_codes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἔγραψα", Transliteration = "egrapsa", Gloss = "I have written", Grammar_codes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", Grammar_codes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "in", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μέρους", Transliteration = "merous", Gloss = "part", Grammar_codes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "in part"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", Grammar_codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐπαναμιμνῄσκων", Transliteration = "epanamimnēskōn", Gloss = "reminding", Grammar_codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", Grammar_codes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "as reminding you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because of", Grammar_codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "χάριν", Transliteration = "charin", Gloss = "grace", Grammar_codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "δοθεῖσάν", Transliteration = "dotheisan", Gloss = "given", Grammar_codes = new List<string> { "V", "AOR", "PASS", "PTCP", "ACC", "F", "S" }, PartOfSpeech = "v" },
                                        new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me", Grammar_codes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", Grammar_codes = new List
