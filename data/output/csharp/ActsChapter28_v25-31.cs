private static List<object> GetChapter28()
{
    // Acts 28:25-31
    return new List<object>
    {
        // Verse 25
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀσύμφωνοι", Transliteration = "asymphōnoi", Gloss = "disagreeable", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὄντες", Transliteration = "ontes", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἀλλήλους", Transliteration = "allēlous", Gloss = "one another", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "conj" }
                            },
                            Translation = "with one another"
                        }
                    },
                    Translation = "And being disagreed with one another"
                },
                new Word { Greek = "ἀπελύοντο", Transliteration = "apelyonto", Gloss = "they departed", GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰπόντος", Transliteration = "eipontos", Gloss = "having spoken", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Παύλου", Transliteration = "Paulou", Gloss = "Paul", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "Paul"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ῥῆμα", Transliteration = "rhēma", Gloss = "word", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἕν", Transliteration = "hen", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "one word"
                        }
                    },
                    Translation = "Paul having spoken one word"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "adj" },
                        new Word { Greek = "καλῶς", Transliteration = "kalōs", Gloss = "rightly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πνεῦμα", Transliteration = "pneuma", Gloss = "Spirit", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἅγιον", Transliteration = "hagion", Gloss = "Holy", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "the Holy Spirit"
                        },
                        new Word { Greek = "ἐλάλησεν", Transliteration = "elalēsen", Gloss = "spoke", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "Ἠσαΐου", Transliteration = "Esaiou", Gloss = "Isaiah", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "προφήτου", Transliteration = "prophētou", Gloss = "prophet", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the prophet"
                                }
                            },
                            Translation = "through Isaiah the prophet"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "πατέρας", Transliteration = "pateras", Gloss = "fathers", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "P" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "your fathers"
                                }
                            },
                            Translation = "to your fathers"
                        }
                    },
                    Translation = "that rightly the Holy Spirit spoke through Isaiah the prophet to your fathers"
                }
            },
            Translation = "And being disagreed with one another they departed, Paul having spoken one word: \"Rightly the Holy Spirit spoke through Isaiah the prophet to your fathers,\""
        },
        // Verse 26
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πορεύθητι", Transliteration = "poreuthēti", Gloss = "go", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "λαὸν", Transliteration = "laon", Gloss = "people", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "τοῦτον", Transliteration = "touton", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "adv" }
                                    },
                                    Translation = "this people"
                                }
                            },
                            Translation = "to this people"
                        }
                    },
                    Translation = "Go to this people"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰπό", Transliteration = "eipe", Gloss = "say", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DAT_MANNER" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀκοῇ", Transliteration = "akoē", Gloss = "with hearing", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "with hearing"
                        },
                        new Word { Greek = "ἀκούσετε", Transliteration = "akousete", Gloss = "you will hear", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "συνῆτε", Transliteration = "synēte", Gloss = "you will understand", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "say: You will surely hear but never understand"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βλέποντες", Transliteration = "blepontes", Gloss = "seeing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "βλέψετε", Transliteration = "blepsete", Gloss = "you will see", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἴδητε", Transliteration = "idēte", Gloss = "you will perceive", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "seeing you will see but never perceive"
                }
            },
            Translation = "saying: \"Go to this people and say: 'You will surely hear but never understand, and you will surely see but never perceive;'\""
        },
        // Verse 27
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐπαχύνθη", Transliteration = "epachynthē", Gloss = "was calloused", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "καρδία", Transliteration = "kardia", Gloss = "heart", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "λαοῦ", Transliteration = "laou", Gloss = "people", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "τούτου", Transliteration = "toutou", Gloss = "this", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "adv" }
                            },
                            Translation = "of this people"
                        }
                    },
                    Translation = "the heart of this people"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "with the", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὠσὶν", Transliteration = "ōsin", Gloss = "ears", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "with their ears"
                        },
                        new Word { Greek = "βαρέως", Transliteration = "bareōs", Gloss = "hard of hearing", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἤκουσαν", Transliteration = "ēkousan", Gloss = "they heard", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "and with their ears they are hard of hearing"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὀφθαλμοὺς", Transliteration = "ophthalmous", Gloss = "eyes", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" },
                                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "their", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "their eyes"
                        },
                        new Word { Greek = "ἐκάμμυσαν", Transliteration = "ekammysan", Gloss = "they have closed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "and their eyes they have closed"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μήποτε", Transliteration = "mēpote", Gloss = "lest", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἴδωσιν", Transliteration = "idōsin", Gloss = "they should see", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "with the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὀφθαλμοῖς", Transliteration = "ophthalmois", Gloss = "eyes", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "with their eyes"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "with the", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὠσὶν", Transliteration = "ōsin", Gloss = "ears", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "with their ears"
                        },
                        new Word { Greek = "ἀκούσωσιν", Transliteration = "akousōsin", Gloss = "they should hear", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "with the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "καρδίᾳ", Transliteration = "kardia", Gloss = "heart", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "with their heart"
                        },
                        new Word { Greek = "συνῶσιν", Transliteration = "synōsin", Gloss = "they should understand", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐπιστρέψωσιν", Transliteration = "epistrepsōsin", Gloss = "they should turn", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἰάσομαι", Transliteration = "iasomai", Gloss = "I will heal", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτούς", Transliteration = "autous", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "prep" }
                    },
                    Translation = "lest they should see with their eyes and hear with their ears and understand with their heart and turn, and I will heal them"
                }
            },
            Translation = "For the heart of this people was calloused, and with their ears they are hard of hearing, and their eyes they have closed; lest they should see with their eyes and hear with their ears and understand with their heart and turn, and I will heal them."
        },
        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "γνωστὸν", Transliteration = "gnōston", Gloss = "known", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἔστω", Transliteration = "estō", Gloss = "let it be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἔθνεσιν", Transliteration = "ethnesin", Gloss = "Gentiles", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "to the Gentiles"
                                }
                            },
                            Translation = "to the Gentiles"
                        },
                        new Word { Greek = "ἀπεστάλη", Transliteration = "apestalē", Gloss = "was sent", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "adv" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σωτήριον", Transliteration = "sōtērion", Gloss = "salvation", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "this salvation of God"
                        }
                    },
                    Translation = "that this salvation of God was sent to the Gentiles"
                },
                new Word { Greek = "αὐτοὶ", Transliteration = "autoi", Gloss = "they", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "prep" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀκούσονται", Transliteration = "akousontai", Gloss = "they will hear", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "Therefore let it be known to you that this salvation of God was sent to the Gentiles; they will also hear."
        },
        // Verse 30
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἐνέμεινεν", Transliteration = "Enemeinen", Gloss = "he remained", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διετίαν", Transliteration = "dietian", Gloss = "two years", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "ὅλην", Transliteration = "holēn", Gloss = "whole", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a whole two years"
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
                                new Word { Greek = "ἰδίῳ", Transliteration = "idiō", Gloss = "his own", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "μισθώματι", Transliteration = "misthōmati", Gloss = "rented house", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "his own rented house"
                        }
                    },
                    Translation = "in his own rented house"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀπεδέχετο", Transliteration = "apedecheto", Gloss = "he welcomed", GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πάντας", Transliteration = "pantas", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the ones", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "εἰσπορευομένους", Transliteration = "eisporeuomenous", Gloss = "coming in", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "ACC", "M", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = " to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "prep" }
                            },
                            Translation = "to him"
                        }
                    },
                    Translation = "all those coming in to him"
                }
            },
            Translation = "And he remained a whole two years in his own rented house, and welcomed all those coming in to him,"
        },
        // Verse 31
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κηρύσσων", Transliteration = "kēryssōn", Gloss = "preaching", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "βασιλείαν", Transliteration = "basileian", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of God"
                                }
                            },
                            Translation = "the kingdom of God"
                        }
                    },
                    Translation = "preaching the kingdom of God"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διδάσκων", Transliteration = "didaskōn", Gloss = "teaching", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the things", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "the Lord Jesus Christ"
                                        }
                                    },
                                    Translation = "concerning the Lord Jesus Christ"
                                }
                            },
                            Translation = "the things concerning the Lord Jesus Christ"
                        }
                    },
                    Translation = "teaching the things concerning the Lord Jesus Christ"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_MANNER" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάσης", Transliteration = "pasēs", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "GEN", "F", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "παρρησίας", Transliteration = "parrēsias", Gloss = "boldness", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "all boldness"
                        }
                    },
                    Translation = "with all boldness"
                },
                new Word { Greek = "ἀκωλύτως", Transliteration = "akōlytōs", Gloss = "without hindrance", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" }
            },
            Translation = "preaching the kingdom of God and teaching the things concerning the Lord Jesus Christ with all boldness and without hindrance."
        }
    };
}

/*
Constructions Identified:
- GEN_ABS (Verse 25): εἰπόντος τοῦ Παύλου ῥῆμα ἕν
- DAT_MANNER (Verse 26): ἀκοῇ
- DAT_INSTR (Verse 27): τοῖς ὠσὶν, τοῖς ὀφθαλμοῖς, τῇ καρδίᾳ
- GEN_DESC (Verse 27): τοῦ λαοῦ τούτου
- GEN_SUBJ (Verse 28): τοῦ θεοῦ
- GEN_DESC (Verse 31): τοῦ θεοῦ
*/
