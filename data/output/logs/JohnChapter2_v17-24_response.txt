private static List<object> GetChapter2()
{
    // John 2:17-24
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐμνήσθησαν", Transliteration = "emnēsthēsan", Gloss = "remembered", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "his disciples"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PERIPH" },
                            Content = new List<object>
                            {
                                new Word { Greek = "γεγραμμένον", Transliteration = "gegrammenon", Gloss = "written", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "ἐστίν", Transliteration = "estin", Gloss = "it is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "it is written"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ζῆλος", Transliteration = "zēlos", Gloss = "zeal", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "for the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "οἴκου", Transliteration = "oikou", Gloss = "house", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "for your house"
                                }
                            },
                            Translation = "zeal for your house"
                        },
                        new Word { Greek = "καταφάγεταί", Transliteration = "kataphagetai", Gloss = "will consume", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "με", Transliteration = "me", Gloss = "me", GrammarCodes = new List<string> { "PRON", "ACC", "1P", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "that it is written, 'Zeal for your house will consume me.'"
                }
            },
            Translation = "His disciples remembered that it was written, 'Zeal for your house will consume me.'"
        },
        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἀπεκρίθησαν", Transliteration = "apekrithēsan", Gloss = "answered", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰουδαῖοι", Transliteration = "Ioudaioi", Gloss = "Jews", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "the Jews"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "εἶπαν", Transliteration = "eipan", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" },
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
                                new Word { Greek = "τί", Transliteration = "ti", Gloss = "what", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "σημεῖον", Transliteration = "sēmeion", Gloss = "sign", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "what sign"
                        },
                        new Word { Greek = "δεικνύεις", Transliteration = "deiknyeis", Gloss = "do you show", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "P" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "since", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "ποιεῖς", Transliteration = "poieis", Gloss = "you do", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "since you do these things"
                        }
                    },
                    Translation = "What sign do you show us for doing these things?"
                }
            },
            Translation = "So the Jews said to him, 'What sign do you show us for doing these things?'"
        },
        // Verse 19
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἀπεκρίθη", Transliteration = "apekrithē", Gloss = "answered", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λύσατε", Transliteration = "lysate", Gloss = "destroy", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ναὸν", Transliteration = "naon", Gloss = "temple", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "τοῦτον", Transliteration = "touton", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "this temple"
                        }
                    },
                    Translation = "Destroy this temple"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
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
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τρισὶν", Transliteration = "trisin", Gloss = "three", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "ἡμέραις", Transliteration = "hēmerais", Gloss = "days", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "in three days"
                        },
                        new Word { Greek = "ἐγερῶ", Transliteration = "egerō", Gloss = "I will raise", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "it", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "and in three days I will raise it up"
                }
            },
            Translation = "Jesus answered them, 'Destroy this temple, and in three days I will raise it up.'"
        },
        // Verse 20
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπαν", Transliteration = "eipan", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰουδαῖοι", Transliteration = "Ioudaioi", Gloss = "Jews", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" }
                    },
                    Translation = "the Jews"
                },
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
                                new Word { Greek = "τεσσεράκοντα", Transliteration = "tesserakonta", Gloss = "forty", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "P" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "ἓξ", Transliteration = "hex", Gloss = "six", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "P" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "ἔτεσιν", Transliteration = "etesin", Gloss = "years", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "for forty-six years"
                        },
                        new Word { Greek = "οἰκοδομήθη", Transliteration = "oikodomēthē", Gloss = "was being built", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ναὸς", Transliteration = "naos", Gloss = "temple", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "οὗτος", Transliteration = "houtos", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "this temple"
                        }
                    },
                    Translation = "It has taken forty-six years to build this temple"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "τρισὶν", Transliteration = "trisin", Gloss = "three", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἡμέραις", Transliteration = "hēmerais", Gloss = "days", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "in three days"
                },
                new Word { Greek = "ἐγερεῖς", Transliteration = "egereis", Gloss = "will raise", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "it", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" }
            },
            Translation = "The Jews then said, 'It has taken forty-six years to build this temple, and will you raise it up in three days?'"
        },
        // Verse 21
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐκεῖνος", Transliteration = "ekeinos", Gloss = "he", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἔλεγεν", Transliteration = "elegen", Gloss = "was speaking", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "about", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ναοῦ", Transliteration = "naou", Gloss = "temple", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the temple"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σώματος", Transliteration = "sōmatos", Gloss = "body", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "of his body"
                        }
                    },
                    Translation = "about the temple of his body"
                }
            },
            Translation = "But he was speaking about the temple of his body."
        },
        // Verse 22
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτε", Transliteration = "hote", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἠγέρθη", Transliteration = "ēgerthē", Gloss = "he was raised", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "νεκρῶν", Transliteration = "nekrōn", Gloss = "dead", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "from the dead"
                        }
                    },
                    Translation = "When therefore he was raised from the dead"
                },
                new Word { Greek = "ἐμνήσθησαν", Transliteration = "emnēsthēsan", Gloss = "remembered", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "μαθηταὶ", Transliteration = "mathētai", Gloss = "disciples", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "his disciples"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἔλεγεν", Transliteration = "elegen", Gloss = "he had said", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "that he had said this"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἐπίστευσαν", Transliteration = "episteusan", Gloss = "they believed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "γραφῇ", Transliteration = "graphē", Gloss = "Scripture", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "the Scripture"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "λόγῳ", Transliteration = "logō", Gloss = "word", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "had spoken", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "which Jesus had spoken"
                        }
                    },
                    Translation = "the word that Jesus had spoken"
                }
            },
            Translation = "When therefore he was raised from the dead, his disciples remembered that he had said this, and they believed the Scripture and the word that Jesus had spoken."
        },
        // Verse 23
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ὡς", Transliteration = "Hōs", Gloss = "Now when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "he was", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "Ἱεροσολύμοις", Transliteration = "Hierosolymois", Gloss = "Jerusalem", GrammarCodes = new List<string> { "N", "DAT", "N", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "in Jerusalem"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "at", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "πάσχα", Transliteration = "pascha", Gloss = "Passover", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "at the Passover"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "during", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἑορτῇ", Transliteration = "heortē", Gloss = "feast", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "during the feast"
                        }
                    },
                    Translation = "Now when he was in Jerusalem at the Passover Feast"
                },
                new Word { Greek = "πολλοὶ", Transliteration = "polloi", Gloss = "many", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adjective" },
                new Word { Greek = "ἐπίστευσαν", Transliteration = "episteusan", Gloss = "believed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὄνομα", Transliteration = "onoma", Gloss = "name", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "of him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "his name"
                        }
                    },
                    Translation = "in his name"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θεωροῦντες", Transliteration = "theōrountes", Gloss = "seeing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "σημεῖα", Transliteration = "sēmeia", Gloss = "signs", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἃ", Transliteration = "ha", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pronoun" },
                                        new Word { Greek = "ἐποίει", Transliteration = "epoiei", Gloss = "he was doing", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                                    },
                                    Translation = "which he was doing"
                                }
                            },
                            Translation = "the signs which he was doing"
                        }
                    },
                    Translation = "seeing the signs which he was doing"
                }
            },
            Translation = "Now when he was in Jerusalem at the Passover Feast, many believed in his name when they saw the signs which he was doing."
        },
        // Verse 24
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "αὐτὸς", Transliteration = "autos", Gloss = "he", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                new Word { Greek = "ἐπίστευεν", Transliteration = "episteuen", Gloss = "was entrusting", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "himself", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "because", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "γινώσκειν", Transliteration = "ginōskein", Gloss = "knew", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "verb" },
                                new Word { Greek = "πάντας", Transliteration = "pantas", Gloss = "everyone", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" }
                            },
                            Translation = "because he knew everyone"
                        }
                    },
                    Translation = "because he knew everyone"
                }
            },
            Translation = "But Jesus on his part did not entrust himself to them, because he knew all people."
        }
    };
}

/*
Constructions identified:
- PERIPH: γεγραμμένον ἐστίν (v17)
- APPOS: τοῦ σώματος αὐτοῦ (v21)
- TEMP_CLAUSE: ὅτε οὖν ἠγέρθη... (v22), Ὡς δὲ ἦν... (v23)
- INF_PHRASE (Articular Infinitive as Object of Preposition): διὰ τὸ αὐτὸν γινώσκειν (v24)
*/
