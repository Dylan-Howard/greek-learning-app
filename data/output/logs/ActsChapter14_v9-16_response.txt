private static List<object> GetChapter14()
{
    // Acts 14:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this man", Grammar_Codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                new Word { Greek = "ἤκουσεν", Transliteration = "ēkousen", Gloss = "heard", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Παύλου", Transliteration = "Paulou", Gloss = "Paul", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Paul"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λαλοῦντος", Transliteration = "lalountos", Gloss = "speaking", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "speaking"
                }
            },
            Translation = "This man heard Paul speaking."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "who", Grammar_Codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀτενίσας", Transliteration = "atenisas", Gloss = "looking intently", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "at him", Grammar_Codes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pron" }
                    },
                    Translation = "looking intently at him"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἰδὼν", Transliteration = "idōn", Gloss = "seeing", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "seeing"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἔχει", Transliteration = "echei", Gloss = "he had", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "πίστιν", Transliteration = "pistin", Gloss = "faith", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "to", Grammar_Codes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σωθῆναι", Transliteration = "sōthēnai", Gloss = "be healed", Grammar_Codes = new List<string> { "V", "AOR", "PASS", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "to be healed"
                        }
                    },
                    Translation = "that he had faith to be healed"
                }
            },
            Translation = "who, looking intently at him and seeing that he had faith to be healed,"
        },
        // Verse 10
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μεγάλῃ", Transliteration = "megalē", Gloss = "with a loud", Grammar_Codes = new List<string> { "ADJ", "DAT", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "φωνῇ", Transliteration = "phōnē", Gloss = "voice", Grammar_Codes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "with a loud voice"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνάστηθι", Transliteration = "anastēthi", Gloss = "Stand up", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "on", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "πόδας", Transliteration = "podas", Gloss = "feet", Grammar_Codes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", Grammar_Codes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "pron" }
                                    },
                                    Translation = "your feet"
                                }
                            },
                            Translation = "on your feet"
                        },
                        new Word { Greek = "ὀρθός", Transliteration = "orthos", Gloss = "upright", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "Stand up upright on your feet!"
                }
            },
            Translation = "said with a loud voice, 'Stand up upright on your feet!'"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἥλατο", Transliteration = "hēlato", Gloss = "he sprang up", Grammar_Codes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "περιεπάτει", Transliteration = "periepatei", Gloss = "began to walk", Grammar_Codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "And he sprang up and began to walk."
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
                        new Word { Greek = "οἵ", Transliteration = "hoi", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὄχλοι", Transliteration = "ochloi", Gloss = "crowds", Grammar_Codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "And the crowds"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἰδόντες", Transliteration = "idontes", Gloss = "seeing", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what", Grammar_Codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                                new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen", Gloss = "did", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "Παῦλος", Transliteration = "Paulos", Gloss = "Paul", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "what Paul did"
                        }
                    },
                    Translation = "seeing what Paul did"
                },
                new Word { Greek = "ἐπῆραν", Transliteration = "epēran", Gloss = "lifted up", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "φωνὴν", Transliteration = "phōnēn", Gloss = "voice", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "their voice"
                },
                new Word { Greek = "Λυκαονιστὶ", Transliteration = "Lykaonisti", Gloss = "in Lycaonian", Grammar_Codes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                }
            },
            Translation = "And when the crowds saw what Paul had done, they lifted up their voices, saying in Lycaonian,"
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "θεοὶ", Transliteration = "theoi", Gloss = "gods", Grammar_Codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "The gods"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁμοιωθέντες", Transliteration = "homoiōthentes", Gloss = "having become like", Grammar_Codes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἀνθρώποις", Transliteration = "anthrōpois", Gloss = "to men", Grammar_Codes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "having become like men"
                },
                new Word { Greek = "κατέβησαν", Transliteration = "katebēsan", Gloss = "have come down", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us", Grammar_Codes = new List<string> { "PRON", "ACC", "1P", "P" }, PartOfSpeech = "pron" }
                    },
                    Translation = "to us"
                }
            },
            Translation = "The gods, having become like men, have come down to us!"
        },
        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐκάλουν", Transliteration = "ekaloun", Gloss = "They were calling", Grammar_Codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "τε", Transliteration = "te", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Βαρναβᾶν", Transliteration = "Barnaban", Gloss = "Barnabas", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Barnabas"
                },
                new Word { Greek = "Δία", Transliteration = "Dia", Gloss = "Zeus", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Παῦλον", Transliteration = "Paulon", Gloss = "Paul", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "and Paul"
                },
                new Word { Greek = "Ἑρμῆν", Transliteration = "Hermēn", Gloss = "Hermes", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπειδὴ", Transliteration = "epeidē", Gloss = "since", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he", Grammar_Codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was", Grammar_Codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἡγούμενος", Transliteration = "hēgoumenos", Gloss = "leading", Grammar_Codes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "leader"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "λόγου", Transliteration = "logou", Gloss = "of the word", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the word"
                                }
                            },
                            Translation = "the chief speaker"
                        }
                    },
                    Translation = "since he was the chief speaker"
                }
            },
            Translation = "They began calling Barnabas Zeus, and Paul Hermes, because he was the chief speaker."
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
                        new Word { Greek = "ὅ", Transliteration = "ho", Gloss = "The", Grammar_Codes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "τε", Transliteration = "te", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἱερεὺς", Transliteration = "hiereus", Gloss = "priest", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", Grammar_Codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Διὸς", Transliteration = "Dios", Gloss = "Zeus", Grammar_Codes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of Zeus"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the one", Grammar_Codes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὄντος", Transliteration = "ontos", Gloss = "being", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πρὸ", Transliteration = "pro", Gloss = "before", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "πόλεως", Transliteration = "poleōs", Gloss = "city", Grammar_Codes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "the city"
                                        }
                                    },
                                    Translation = "before the city"
                                }
                            },
                            Translation = "whose temple was before the city"
                        }
                    },
                    Translation = "The priest of Zeus, whose temple was before the city"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ταύρους", Transliteration = "taurous", Gloss = "bulls", Grammar_Codes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "στέμματα", Transliteration = "stemmata", Gloss = "garlands", Grammar_Codes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "bulls and garlands"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "to", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "πυλῶνας", Transliteration = "pylōnas", Gloss = "gates", Grammar_Codes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the gates"
                                }
                            },
                            Translation = "to the gates"
                        },
                        new Word { Greek = "ἐνέγκας", Transliteration = "enenkas", Gloss = "having brought", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "having brought bulls and garlands to the gates"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὺν", Transliteration = "syn", Gloss = "with", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", Grammar_Codes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὄχλοις", Transliteration = "ochlois", Gloss = "crowds", Grammar_Codes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the crowds"
                        }
                    },
                    Translation = "with the crowds"
                },
                new Word { Greek = "ἤθελεν", Transliteration = "ēthelen", Gloss = "wanted", Grammar_Codes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "θύειν", Transliteration = "thyein", Gloss = "to sacrifice", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
            },
            Translation = "The priest of Zeus, whose temple was before the city, brought bulls and garlands to the gates and wanted to offer sacrifice with the crowds."
        },
        // Verse 14
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
                        new Word { Greek = "Ἀκούσαντες", Transliteration = "Akousantes", Gloss = "having heard", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "But", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" }
                    },
                    Translation = "But having heard"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", Grammar_Codes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἀπόστολοι", Transliteration = "apostoloi", Gloss = "apostles", Grammar_Codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "Βαρναβᾶς", Transliteration = "Barnabas", Gloss = "Barnabas", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "Παῦλος", Transliteration = "Paulos", Gloss = "Paul", Grammar_Codes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the apostles, Barnabas and Paul"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διαρρήξαντες", Transliteration = "diarrēxantes", Gloss = "having torn", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἱμάτια", Transliteration = "himatia", Gloss = "garments", Grammar_Codes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", Grammar_Codes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "their garments"
                        }
                    },
                    Translation = "having torn their garments"
                },
                new Word { Greek = "ἐξεπήδησαν", Transliteration = "exepēdēsan", Gloss = "rushed out", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὄχλον", Transliteration = "ochlon", Gloss = "crowd", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the crowd"
                        }
                    },
                    Translation = "into the crowd"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κράζοντες", Transliteration = "krazontes", Gloss = "crying out", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "crying out"
                }
            },
            Translation = "But when the apostles, Barnabas and Paul, heard it, they tore their garments and rushed out into the crowd, crying out,"
        },
        // Verse 15
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ἄνδρες", Transliteration = "andres", Gloss = "Men", Grammar_Codes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τί", Transliteration = "ti", Gloss = "why", Grammar_Codes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", Grammar_Codes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ποιεῖτε", Transliteration = "poieite", Gloss = "are you doing", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "Why are you doing these things?"
                }
            },
            Translation = "and saying, 'Men, why are you doing these things?'"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "Also", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis", Gloss = "we", Grammar_Codes = new List<string> { "PRON", "NOM", "1P", "P" }, PartOfSpeech = "pron" },
                new Word { Greek = "ὁμοιοπαθεῖς", Transliteration = "homoiopatheis", Gloss = "of like nature", Grammar_Codes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐσμεν", Transliteration = "esmen", Gloss = "are", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "with you", Grammar_Codes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "pron" },
                new Word { Greek = "ἄνθρωποι", Transliteration = "anthrōpoi", Gloss = "men", Grammar_Codes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
            },
            Translation = "We also are men, of like nature with you,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "εὐαγγελιζόμενοι", Transliteration = "euangelizomenoi", Gloss = "preaching the gospel", Grammar_Codes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "to you", Grammar_Codes = new List<string> { "PRON", "ACC", "2P", "P" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τούτων", Transliteration = "toutōn", Gloss = "these", Grammar_Codes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pron" },
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", Grammar_Codes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ματαίων", Transliteration = "mataiōn", Gloss = "vain things", Grammar_Codes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "these vain things"
                                }
                            },
                            Translation = "from these vain things"
                        },
                        new Word { Greek = "ἐπιστρέφειν", Transliteration = "epistrephein", Gloss = "to turn", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "to", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "θεὸν", Transliteration = "theon", Gloss = "God", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PTCP" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ζῶντα", Transliteration = "zōnta", Gloss = "living", Grammar_Codes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" }
                                            },
                                            Translation = "living"
                                        }
                                    },
                                    Translation = "the living God"
                                }
                            },
                            Translation = "to a living God"
                        }
                    },
                    Translation = "to turn from these vain things to a living God"
                }
            },
            Translation = "preaching to you that you should turn from these vain things to a living God,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "who", Grammar_Codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen", Gloss = "made", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "οὐρανὸν", Transliteration = "ouranon", Gloss = "heaven", Grammar_Codes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the heaven"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γῆν", Transliteration = "gēn", Gloss = "earth", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the earth"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "θάλασσαν", Transliteration = "thalassan", Gloss = "sea", Grammar_Codes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the sea"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", Grammar_Codes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all", Grammar_Codes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the things", Grammar_Codes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", Grammar_Codes = new List<string> { "PRON", "DAT", "N", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "in them"
                        }
                    },
                    Translation = "all that is in them"
                }
            },
            Translation = "who made the heaven and the earth and the sea and all that is in them."
        },
        // Verse 16
        new Phrase
        {
            SyntaxCodes = new List<string> { "REL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὃς", Transliteration = "hos", Gloss = "who", Grammar_Codes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pron" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", Grammar_Codes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "the", Grammar_Codes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "παρῳχημέναις", Transliteration = "parōchēmenais", Gloss = "past", Grammar_Codes = new List<string> { "V", "PERF", "MID", "PTCP", "DAT", "F", "P" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "past"
                                },
                                new Word { Greek = "γενεαῖς", Transliteration = "geneais", Gloss = "generations", Grammar_Codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the past generations"
                        }
                    },
                    Translation = "in past generations"
                },
                new Word { Greek = "εἴασεν", Transliteration = "eiasen", Gloss = "allowed", Grammar_Codes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all", Grammar_Codes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", Grammar_Codes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἔθνη", Transliteration = "ethnē", Gloss = "nations", Grammar_Codes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "all the nations"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πορεύεσθαι", Transliteration = "poreuesthai", Gloss = "to walk", Grammar_Codes = new List<string> { "V", "PRES", "MID", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "in the", Grammar_Codes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὁδοῖς", Transliteration = "hodois", Gloss = "ways", Grammar_Codes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "of them", Grammar_Codes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pron" }
                            },
                            Translation = "in their own ways"
                        }
                    },
                    Translation = "to walk in their own ways"
                }
            },
            Translation = "In past generations he allowed all the nations to walk in their own ways."
        }
    };
}

/*
Constructions identified:
- DAT_MANNER: 14:10 (μεγάλῃ φωνῇ), 14:16 (ταῖς ὁδοῖς αὐτῶν)
- GEN_OBJ: 14:12 (τοῦ λόγου)
- GEN_DESC: 14:13 (τοῦ Διὸς)
- NOUN_PHRASE with PTCP (Attributive): 14:13 (τοῦ ὄντος πρὸ τῆς πόλεως), 14:15 (θεὸν ζῶντα), 14:16 (ταῖς παρῳχημέναις γενεαῖς)
- INF_PHRASE as OBJ: 14:9 (τοῦ σωθῆναι), 14:15 (ἐπιστρέφειν), 14:16 (πορεύεσθαι)
*/
