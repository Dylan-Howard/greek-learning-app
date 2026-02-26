private static List<object> GetChapter5()
{
    // Mark 5:25-32
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
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "γυνὴ", Transliteration = "gunē", Gloss = "a woman", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "And a woman"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὖσα", Transliteration = "ousa", Gloss = "being", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ῥύσει", Transliteration = "rhusei", Gloss = "a flow", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "αἵματος", Transliteration = "haimatos", Gloss = "of blood", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "in a flow of blood"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "δώδεκα", Transliteration = "dōdeka", Gloss = "twelve", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "ἔτη", Transliteration = "etē", Gloss = "years", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "for twelve years"
                        }
                    },
                    Translation = "who had been in a flow of blood for twelve years"
                },
                // Verse 26
                // (continues verse 25)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "πολλὰ", Transliteration = "polla", Gloss = "many things", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "παθοῦσα", Transliteration = "pathousa", Gloss = "having suffered", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑπὸ", Transliteration = "hupo", Gloss = "under", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "πολλῶν", Transliteration = "pollōn", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "ἰατρῶν", Transliteration = "iatrōn", Gloss = "physicians", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "under many physicians"
                        }
                    },
                    Translation = "and having suffered much under many physicians"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "δαπανήσασα", Transliteration = "dapanēsasa", Gloss = "having spent", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the [things]", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "article" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "παρ᾽", Transliteration = "par'", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "αὐτῆς", Transliteration = "autēs", Gloss = "her", GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "belonging to her"
                                },
                                new Word { Greek = "πάντα", Transliteration = "panta", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "all that she had"
                        }
                    },
                    Translation = "and having spent all she had"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "μηδὲν", Transliteration = "mēden", Gloss = "nothing", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ὠφεληθεῖσα", Transliteration = "ōphelētheisa", Gloss = "having been helped", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "and having been helped nothing"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "μᾶλλον", Transliteration = "mallon", Gloss = "rather", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "χεῖρον", Transliteration = "cheiron", Gloss = "worse", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "into the worse"
                        },
                        new Word { Greek = "ἐλθοῦσα", Transliteration = "elthousa", Gloss = "having come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "but rather having grown worse"
                },
                // Verse 27
                // (continues verse 25)
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀκούσασα", Transliteration = "akousasa", Gloss = "having heard", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "about Jesus"
                        }
                    },
                    Translation = "having heard about Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐλθοῦσα", Transliteration = "elthousa", Gloss = "having come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ὄχλῳ", Transliteration = "ochlō", Gloss = "crowd", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "in the crowd"
                        },
                        new Word { Greek = "ὄπισθεν", Transliteration = "opisthen", Gloss = "from behind", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" }
                    },
                    Translation = "having come in the crowd from behind"
                },
                new Word { Greek = "ἥψατο", Transliteration = "hēpsato", Gloss = "she touched", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἱματίου", Transliteration = "himatiou", Gloss = "garment", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "his garment"
                }
            },
            Translation = "And a woman, who had been in a flow of blood for twelve years, and had suffered much under many physicians and spent all she had and was not helped but rather grew worse, having heard about Jesus, came in the crowd from behind and touched his garment."
        },
        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἔλεγεν", Transliteration = "elegen", Gloss = "she was saying", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "COND_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "ἅψωμαι", Transliteration = "hapsōmai", Gloss = "I touch", GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "1P", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "κἂν", Transliteration = "kan", Gloss = "even", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ἱματίων", Transliteration = "himatiōn", Gloss = "garments", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "his garments"
                                }
                            },
                            Translation = "If I touch even his garments"
                        },
                        new Word { Greek = "σωθήσομαι", Transliteration = "sōthēsomai", Gloss = "I will be healed", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "1P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "that \"If I touch even his garments, I will be healed.\""
                }
            },
            Translation = "For she was saying, \"If I touch even his garments, I will be healed.\""
        },
        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "εὐθὺς", Transliteration = "euthus", Gloss = "immediately", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "ἐξηράνθη", Transliteration = "exēranthē", Gloss = "was dried up", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "πηγὴ", Transliteration = "pēgē", Gloss = "fountain", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "αἵματος", Transliteration = "haimatos", Gloss = "blood", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "αὐτῆς", Transliteration = "autēs", Gloss = "of her", GrammarCodes = new List<string> { "PRON", "GEN", "F", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "of her blood"
                        }
                    },
                    Translation = "the fountain of her blood"
                }
            },
            Translation = "And immediately the fountain of her blood was dried up,"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἔγνω", Transliteration = "egnō", Gloss = "she knew", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "σώματι", Transliteration = "sōmati", Gloss = "body", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in [her] body"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἴαται", Transliteration = "iatai", Gloss = "she has been healed", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "μάστιγος", Transliteration = "mastigos", Gloss = "affliction", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "from the affliction"
                        }
                    },
                    Translation = "that she has been healed from the affliction"
                }
            },
            Translation = "and she knew in her body that she had been healed from the affliction."
        },
        // Verse 30
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "εὐθὺς", Transliteration = "euthus", Gloss = "immediately", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "Jesus"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπιγνοὺς", Transliteration = "epignous", Gloss = "having perceived", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ἑαυτῷ", Transliteration = "heautō", Gloss = "himself", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "in himself"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐξ", Transliteration = "ex", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "from him"
                                },
                                new Word { Greek = "δύναμιν", Transliteration = "dunamin", Gloss = "power", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the power"
                        },
                        new Word { Greek = "ἐξελθοῦσαν", Transliteration = "exelthousan", Gloss = "having gone out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "F", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "having perceived in himself the power that had gone out from him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπιστραφεὶς", Transliteration = "epistrapheis", Gloss = "having turned", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ὄχλῳ", Transliteration = "ochlō", Gloss = "crowd", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "in the crowd"
                        }
                    },
                    Translation = "having turned around in the crowd"
                },
                new Word { Greek = "ἔλεγεν", Transliteration = "elegen", Gloss = "was saying", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τίς", Transliteration = "tis", Gloss = "Who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "me", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἥψατο", Transliteration = "hēpsato", Gloss = "touched", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἱματίων", Transliteration = "himatiōn", Gloss = "garments", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "garments"
                        }
                    },
                    Translation = "\"Who touched my garments?\""
                }
            },
            Translation = "And immediately Jesus, perceiving in himself that power had gone out from him, turned around in the crowd and said, \"Who touched my garments?\""
        },
        // Verse 31
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἔλεγον", Transliteration = "elegon", Gloss = "were saying", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "to him"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "his disciples"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "βλέπεις", Transliteration = "blepeis", Gloss = "You see", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ὄχλον", Transliteration = "ochlon", Gloss = "crowd", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the crowd"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "συνθλίβοντά", Transliteration = "sunthlibonta", Gloss = "pressing around", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "σε", Transliteration = "se", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "pressing around you"
                        }
                    },
                    Translation = "\"You see the crowd pressing around you"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "λέγεις", Transliteration = "legeis", Gloss = "you say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τίς", Transliteration = "tis", Gloss = "Who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "me", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "ἥψατο", Transliteration = "hēpsato", Gloss = "touched", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "'Who touched me?'\""
                        }
                    },
                    Translation = "and you say, 'Who touched me?'\""
                }
            },
            Translation = "And his disciples were saying to him, \"You see the crowd pressing around you, and yet you say, 'Who touched me?'\""
        },
        // Verse 32
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "περιεβλέπετο", Transliteration = "perieblepeto", Gloss = "he was looking around", GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἰδεῖν", Transliteration = "idein", Gloss = "to see", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the [woman]", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "ποιήσασαν", Transliteration = "poiēsasan", Gloss = "having done", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "F", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "the one who had done this"
                        }
                    },
                    Translation = "to see the woman who had done this"
                }
            },
            Translation = "And he was looking around to see the woman who had done this."
        }
    };
}
/*
Constructions identified:
- Substantive Participle: τὴν τοῦτο ποιήσασαν (Mark 5:32)
- Dative of Reference: τῷ σώματι (Mark 5:29)
*/
