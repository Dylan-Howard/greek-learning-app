private static List<object> GetChapter2()
{
    // Matthew 2:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "GEN_ABS", "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Τοῦ", Transliteration = "Tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "γεννηθέντος", Transliteration = "gennēthentos", Gloss = "having been born", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "Now after Jesus was born"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "Βηθλέεμ", Transliteration = "Bethleem", Gloss = "Bethlehem", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "Ἰουδαίας", Transliteration = "Ioudaias", Gloss = "Judea", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "of Judea"
                        }
                    },
                    Translation = "in Bethlehem of Judea"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "ἡμέραις", Transliteration = "hēmerais", Gloss = "days", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Ἡρῴδου", Transliteration = "Hērōdou", Gloss = "Herod", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "βασιλέως", Transliteration = "basileōs", Gloss = "king", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the king"
                                }
                            },
                            Translation = "of Herod the king"
                        }
                    },
                    Translation = "in the days of Herod the king"
                },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μάγοι", Transliteration = "magoi", Gloss = "wise men", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "ἀνατολῶν", Transliteration = "anatolōn", Gloss = "east", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "from the east"
                        }
                    },
                    Translation = "wise men from the east"
                },
                new Word { Greek = "παρεγένοντο", Transliteration = "paregenonto", Gloss = "came", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "Ἱεροσόλυμα", Transliteration = "Hierosolyma", Gloss = "Jerusalem", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "noun" }
                    },
                    Translation = "to Jerusalem"
                }
            },
            Translation = "Now after Jesus was born in Bethlehem of Judea in the days of Herod the king, behold, wise men from the east came to Jerusalem,"
        },
        // Verse 2
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
                        new Word { Greek = "λέγοντες", Transliteration = "legontes", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ποῦ", Transliteration = "pou", Gloss = "where", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "τεχθεὶς", Transliteration = "techtheis", Gloss = "having been born", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "βασιλεὺς", Transliteration = "basileus", Gloss = "king", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "Ἰουδαίων", Transliteration = "Ioudaiōn", Gloss = "Jews", GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" }, PartOfSpeech = "adjective" }
                                    },
                                    Translation = "of the Jews"
                                }
                            },
                            Translation = "he who has been born king of the Jews"
                        }
                    },
                    Translation = "Where is he who has been born king of the Jews?"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἴδομεν", Transliteration = "eidomen", Gloss = "we saw", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἀστέρα", Transliteration = "astera", Gloss = "star", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "his star"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἀνατολῇ", Transliteration = "anatolē", Gloss = "east", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "in the east"
                        }
                    },
                    Translation = "For we saw his star in the east"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "ἤλθομεν", Transliteration = "ēlthomen", Gloss = "we have come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προσκυνῆσαι", Transliteration = "proskynēsai", Gloss = "to worship", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "verb" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "to worship him"
                }
            },
            Translation = "saying, 'Where is he who has been born king of the Jews? For we saw his star in the east and have come to worship him.'"
        },
        // Verse 3
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
                        new Word { Greek = "ἀκούσας", Transliteration = "akousas", Gloss = "having heard", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "When he heard this"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "βασιλεὺς", Transliteration = "basileus", Gloss = "king", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "Ἡρῴδης", Transliteration = "Hērōdēs", Gloss = "Herod", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "Herod the king"
                },
                new Word { Greek = "ἐταράχθη", Transliteration = "etarachthē", Gloss = "was troubled", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πᾶσα", Transliteration = "pasa", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "Ἱεροσόλυμα", Transliteration = "Hierosolyma", Gloss = "Jerusalem", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                    },
                    Translation = "all Jerusalem"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετ᾽", Transliteration = "met'", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "with him"
                }
            },
            Translation = "When Herod the king heard this, he was troubled, and all Jerusalem with him;"
        },
        // Verse 4
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συναγαγὼν", Transliteration = "synagagōn", Gloss = "having gathered together", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάντας", Transliteration = "pantas", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adjective" },
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἀρχιερεῖς", Transliteration = "archiereis", Gloss = "chief priests", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "γραμματεῖς", Transliteration = "grammateis", Gloss = "scribes", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "λαοῦ", Transliteration = "laou", Gloss = "people", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "of the people"
                                }
                            },
                            Translation = "all the chief priests and scribes of the people"
                        }
                    },
                    Translation = "and gathering together all the chief priests and scribes of the people,"
                },
                new Word { Greek = "ἐπυνθάνετο", Transliteration = "epynthaneto", Gloss = "he inquired", GrammarCodes = new List<string> { "V", "IMPF", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρ᾽", Transliteration = "par'", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "them", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "of them"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ποῦ", Transliteration = "pou", Gloss = "where", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "χριστὸς", Transliteration = "christos", Gloss = "Christ", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the Christ"
                        },
                        new Word { Greek = "γεννᾶται", Transliteration = "gennatai", Gloss = "was to be born", GrammarCodes = new List<string> { "V", "PRES", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "where the Christ was to be born."
                }
            },
            Translation = "and gathering together all the chief priests and scribes of the people, he inquired of them where the Christ was to be born."
        },
        // Verse 5
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
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "they", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "article" }
                    },
                    Translation = "They"
                },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Word { Greek = "εἶπαν", Transliteration = "eipan", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "Βηθλέεμ", Transliteration = "Bethleem", Gloss = "Bethlehem", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "Ἰουδαίας", Transliteration = "Ioudaias", Gloss = "Judea", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "of Judea"
                        }
                    },
                    Translation = "In Bethlehem of Judea"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "so", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "γέγραπται", Transliteration = "gegraptai", Gloss = "it has been written", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "προφήτου", Transliteration = "prophētou", Gloss = "prophet", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the prophet"
                                }
                            },
                            Translation = "through the prophet"
                        }
                    },
                    Translation = "for so it has been written through the prophet:"
                }
            },
            Translation = "They said to him, 'In Bethlehem of Judea, for so it has been written through the prophet:'"
        },
        // Verse 6
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σὺ", Transliteration = "sy", Gloss = "you", GrammarCodes = new List<string> { "PRON", "NOM", "2P", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "Βηθλέεμ", Transliteration = "Bethleem", Gloss = "Bethlehem", GrammarCodes = new List<string> { "N", "VOC", "F", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "γῆ", Transliteration = "gē", Gloss = "land", GrammarCodes = new List<string> { "N", "VOC", "F", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "Ἰούδα", Transliteration = "Iouda", Gloss = "of Judah", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "land of Judah"
                        }
                    },
                    Translation = "And you, Bethlehem, land of Judah,"
                },
                new Word { Greek = "οὐδαμῶς", Transliteration = "oudamōs", Gloss = "by no means", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "ἐλαχίστη", Transliteration = "elachistē", Gloss = "least", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adjective" },
                new Word { Greek = "εἶ", Transliteration = "ei", Gloss = "are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "among", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἡγεμόσιν", Transliteration = "hēgemosin", Gloss = "rulers", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "noun" },
                                new Word { Greek = "Ἰούδα", Transliteration = "Iouda", Gloss = "of Judah", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the rulers of Judah"
                        }
                    },
                    Translation = "among the rulers of Judah;"
                },
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
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "σοῦ", Transliteration = "sou", Gloss = "you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "from you"
                        },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἐξελεύσεται", Transliteration = "exeleusetai", Gloss = "will come", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡγούμενος", Transliteration = "hēgoumenos", Gloss = "a ruler", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "a ruler"
                        }
                    },
                    Translation = "for from you will come a ruler"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅστις", Transliteration = "hostis", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ποιμανεῖ", Transliteration = "poimanei", Gloss = "will shepherd", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "λαόν", Transliteration = "laon", Gloss = "people", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "my", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "my people"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "Ἰσραήλ", Transliteration = "Israēl", Gloss = "Israel", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "Israel"
                        }
                    },
                    Translation = "who will shepherd my people Israel."
                }
            },
            Translation = "And you, Bethlehem, land of Judah, are by no means least among the rulers of Judah; for from you will come a ruler who will shepherd my people Israel."
        },
        // Verse 7
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Τότε", Transliteration = "Tote", Gloss = "Then", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Word { Greek = "Ἡρῴδης", Transliteration = "Hērōdēs", Gloss = "Herod", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                new Word { Greek = "λάθρᾳ", Transliteration = "lathra", Gloss = "secretly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καλέσας", Transliteration = "kalesas", Gloss = "having called", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "article" },
                                new Word { Greek = "μάγους", Transliteration = "magous", Gloss = "wise men", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the wise men"
                        }
                    },
                    Translation = "having secretly called the wise men"
                },
                new Word { Greek = "ἠκρίβωσεν", Transliteration = "ēkribōsen", Gloss = "ascertained", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παρ᾽", Transliteration = "par'", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                        new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "them", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "of them"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "article" },
                        new Word { Greek = "χρόνον", Transliteration = "chronon", Gloss = "time", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "φαινομένου", Transliteration = "phainomenou", Gloss = "appearing", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "ἀστέρος", Transliteration = "asteros", Gloss = "star", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "of the appearing star"
                        }
                    },
                    Translation = "the time of the appearing star"
                }
            },
            Translation = "Then Herod, having secretly called the wise men, ascertained from them the time of the appearing star;"
        },
        // Verse 8
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πέμψας", Transliteration = "pempsas", Gloss = "sending", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "Βηθλέεμ", Transliteration = "Bethleem", Gloss = "Bethlehem", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "to Bethlehem"
                        }
                    },
                    Translation = "sending them to Bethlehem"
                },
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "he said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
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
                                new Word { Greek = "πορευθέντες", Transliteration = "poreuthentes", Gloss = "having gone", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "Go"
                        },
                        new Word { Greek = "ἐξετάσατε", Transliteration = "exetasate", Gloss = "search", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ἀκριβῶς", Transliteration = "akribōs", Gloss = "carefully", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adverb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "περὶ", Transliteration = "peri", Gloss = "concerning", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "παιδίου", Transliteration = "paidiou", Gloss = "child", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "the child"
                                }
                            },
                            Translation = "concerning the child"
                        }
                    },
                    Translation = "Go and search carefully for the child,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπὰν", Transliteration = "epan", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "εὕρητε", Transliteration = "heurēte", Gloss = "you have found", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "and when you have found him"
                },
                new Word { Greek = "ἀπαγγείλατέ", Transliteration = "apangeilate", Gloss = "report", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                new Word { Greek = "μοι", Transliteration = "moi", Gloss = "to me", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅπως", Transliteration = "hopōs", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "κἀγὼ", Transliteration = "kagō", Gloss = "I also", GrammarCodes = new List<string> { "PRON", "NOM", "1P", "S" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐλθὼν", Transliteration = "elthōn", Gloss = "having come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "having come"
                        },
                        new Word { Greek = "προσκυνήσω", Transliteration = "proskynēsō", Gloss = "may worship", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "so that I also, having come, may worship him."
                }
            },
            Translation = "And sending them to Bethlehem he said, 'Go and search carefully for the child, and when you have found him, report to me so that I also, having come, may worship him.'"
        }
    };
}

/* 
Constructions identified:
- GEN_ABS (v1): Τοῦ δὲ Ἰησοῦ γεννηθέντος
- APPOS (v1): τοῦ βασιλέως
- INF_PHRASE (v2): προσκυνῆσαι αὐτῷ (purpose)
- NOUN_PHRASE (v2): ὁ τεχθεὶς βασιλεὺς (substantival participle)
- APPOS (v6): γῆ Ἰούδα
- VOC (v6): σὺ Βηθλέεμ
- REL_CLAUSE (v6): ὅστις ποιμανεῖ...
- APPOS (v6): τὸν Ἰσραήλ
- TEMP_CLAUSE (v8): ἐπὰν δὲ εὕρητε
- PURPOSE_CLAUSE (v8): ὅπως κἀγὼ ἐλθὼν προσκυνήσω αὐτῷ
*/
