private static List<object> GetChapter15()
{
    // Matthew 15:9-16
    return new List<object>
    {
        // Verse 9
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "μάτην", Transliteration = "matēn", Gloss = "in vain", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "σέβονταί", Transliteration = "sebontai", Gloss = "they worship", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "με", Transliteration = "me", Gloss = "me", GrammarCodes = new List<string> { "PRON", "ACC", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διδάσκοντες", Transliteration = "didaskontes", Gloss = "teaching", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διδασκαλίας", Transliteration = "didaskalias", Gloss = "teachings", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "APPOS" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐντάλματα", Transliteration = "entalmata", Gloss = "commandments", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "noun" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἀνθρώπων", Transliteration = "anthrōpōn", Gloss = "of men", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "noun" }
                                            },
                                            Translation = "of men"
                                        }
                                    },
                                    Translation = "commandments of men"
                                }
                            },
                            Translation = "teachings as commandments of men"
                        }
                    },
                    Translation = "teaching as doctrines the commandments of men"
                }
            },
            Translation = "But in vain they worship me, teaching as doctrines the commandments of men."
        },

        // Verse 10
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
                        new Word { Greek = "προσκαλεσάμενος", Transliteration = "proskalesamenos", Gloss = "having called", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ὄχλον", Transliteration = "ochlon", Gloss = "crowd", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the crowd"
                        }
                    },
                    Translation = "And having called the crowd"
                },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "ἀκούετε", Transliteration = "akouete", Gloss = "Hear", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "συνίετε", Transliteration = "syniete", Gloss = "understand", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" }
            },
            Translation = "And he called the crowd and said to them, 'Hear and understand:'"
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
                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the [thing]", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "εἰσερχόμενον", Transliteration = "eiserchomenon", Gloss = "entering", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "στόμα", Transliteration = "stoma", Gloss = "mouth", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "into the mouth"
                        }
                    },
                    Translation = "Not what goes into the mouth"
                },
                new Word { Greek = "κοινοῖ", Transliteration = "koinoi", Gloss = "defiles", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἄνθρωπον", Transliteration = "anthrōpon", Gloss = "person", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the person"
                },
                new Word { Greek = "ἀλλὰ", Transliteration = "alla", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the [thing]", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἐκπορευόμενον", Transliteration = "ekporeuomenon", Gloss = "coming out", GrammarCodes = new List<string> { "V", "PRES", "MP", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "στόματος", Transliteration = "stomatos", Gloss = "mouth", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "out of the mouth"
                        }
                    },
                    Translation = "what comes out of the mouth"
                },
                new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "κοινοῖ", Transliteration = "koinoi", Gloss = "defiles", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "ἄνθρωπον", Transliteration = "anthrōpon", Gloss = "person", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the person"
                }
            },
            Translation = "It is not what goes into the mouth that defiles a person, but what comes out of the mouth; this defiles a person."
        },

        // Verse 12
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τότε", Transliteration = "Tote", Gloss = "Then", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προσελθόντες", Transliteration = "proselthontes", Gloss = "having approached", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "having come"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "article" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the disciples"
                },
                new Word { Greek = "λέγουσιν", Transliteration = "legousin", Gloss = "said", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "οἶδας", Transliteration = "oidas", Gloss = "Do you know", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "Φαρισαῖοι", Transliteration = "Pharisaioi", Gloss = "Pharisees", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the Pharisees"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀκούσαντες", Transliteration = "akousantes", Gloss = "having heard", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "λόγον", Transliteration = "logon", Gloss = "saying", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the saying"
                                }
                            },
                            Translation = "when they heard the saying"
                        },
                        new Word { Greek = "ἐσκανδαλίσθησαν", Transliteration = "eskandalisthēsan", Gloss = "were offended", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "that the Pharisees were offended when they heard the saying?"
                }
            },
            Translation = "Then the disciples came and said to him, 'Do you know that the Pharisees were offended when they heard this saying?'"
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" }
                    },
                    Translation = "He"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀποκριθεὶς", Transliteration = "apokritheis", Gloss = "answering", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "answered"
                },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "and said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶσα", Transliteration = "pasa", Gloss = "Every", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "φυτεία", Transliteration = "phyteia", Gloss = "plant", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἣν", Transliteration = "hēn", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                                new Word { Greek = "ἐφύτευσεν", Transliteration = "ephyteusen", Gloss = "planted", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "πατήρ", Transliteration = "patēr", Gloss = "Father", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "my", GrammarCodes = new List<string> { "PRON", "GEN", "S" }, PartOfSpeech = "pronoun" },
                                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "οὐράνιος", Transliteration = "ouranios", Gloss = "heavenly", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" }
                                    },
                                    Translation = "my heavenly Father"
                                }
                            },
                            Translation = "which my heavenly Father has not planted"
                        }
                    },
                    Translation = "Every plant which my heavenly Father has not planted"
                },
                new Word { Greek = "ἐκριζωθήσεται", Transliteration = "ekrizōthēsetai", Gloss = "will be uprooted", GrammarCodes = new List<string> { "V", "FUT", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" }
            },
            Translation = "He answered, 'Every plant that my heavenly Father has not planted will be rooted up.'"
        },

        // Verse 14
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἄφετε", Transliteration = "aphete", Gloss = "Leave alone", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτούς", Transliteration = "autous", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "VERB_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τυφλοί", Transliteration = "typhloi", Gloss = "blind", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "εἰσιν", Transliteration = "eisin", Gloss = "they are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ὁδηγοὶ", Transliteration = "hodēgoi", Gloss = "guides", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "τυφλῶν", Transliteration = "typhlōn", Gloss = "of the blind", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "they are blind guides of the blind"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τυφλὸς", Transliteration = "typhlos", Gloss = "a blind [man]", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "τυφλὸν", Transliteration = "typhlon", Gloss = "a blind [man]", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὁδηγῇ", Transliteration = "hodēgē", Gloss = "leads", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "And if a blind man leads a blind man"
                },
                new Word { Greek = "ἀμφότεροι", Transliteration = "amphoteroi", Gloss = "both", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "βόθυνον", Transliteration = "bothynon", Gloss = "a pit", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "into a pit"
                },
                new Word { Greek = "πεσοῦνται", Transliteration = "pesountai", Gloss = "will fall", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "P" }, PartOfSpeech = "verb" }
            },
            Translation = "Let them alone; they are blind guides. And if the blind lead the blind, both will fall into a pit."
        },

        // Verse 15
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
                        new Word { Greek = "Ἀποκριθεὶς", Transliteration = "Apokritheis", Gloss = "answering", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "answered"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "Πέτρος", Transliteration = "Petros", Gloss = "Peter", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "Peter"
                },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "φράσον", Transliteration = "phrason", Gloss = "Explain", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us", GrammarCodes = new List<string> { "PRON", "DAT", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "παραβολὴν", Transliteration = "parabolēn", Gloss = "parable", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ταύτην", Transliteration = "tautēn", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "F", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "this parable"
                }
            },
            Translation = "But Peter said to him, 'Explain this parable to us.'"
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
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the [one]", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" }
                    },
                    Translation = "He"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "ἀκμὴν", Transliteration = "akmēn", Gloss = "still", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adv" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ὑμεῖς", Transliteration = "hymeis", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "P" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "ἀσύνετοί", Transliteration = "asynetoi", Gloss = "without understanding", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "ἐστε", Transliteration = "este", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "P" }, PartOfSpeech = "verb" }
            },
            Translation = "And he said, 'Are you also still without understanding?'"
        }
    };
}

/*
Constructions Identified:
- PTCP (Adverbial): 15:10 (προσκαλεσάμενος), 15:12 (προσελθόντες, ἀκούσαντες), 15:13 (ἀποκριθεὶς), 15:15 (Ἀποκριθεὶς)
- PTCP (Substantival): 15:11 (τὸ εἰσερχόμενον, τὸ ἐκπορευόμενον)
- APPOS: 15:9 (διδασκαλίας ἐντάλματα)
- GEN_OBJ: 15:9 (ἀνθρώπων)
- REL_CLAUSE: 15:13 (ἣν οὐκ ἐφύτευσεν...)
- COND_CLAUSE: 15:14 (τυφλὸς δὲ τυφλὸν ἐὰν ὁδηγῇ)
- CAUSAL_CLAUSE: 15:12 (introduced by ὅτι following οἶδας)
*/
