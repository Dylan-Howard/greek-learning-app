private static List<object> GetChapter13()
{
    // Matthew 13:25-32
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
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "καθεύδειν", Transliteration = "katheudein", Gloss = "to sleep", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοὺς", Transliteration = "tous", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἀνθρώπους", Transliteration = "anthrōpous", Gloss = "human being", GrammarCodes = new List<string> { "N", "ACC", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the men"
                                }
                            },
                            Translation = "while the men were sleeping"
                        }
                    },
                    Translation = "But while the men were sleeping"
                },
                new Word { Greek = "ἦλθεν", Transliteration = "ēlthen", Gloss = "came", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἐχθρὸς", Transliteration = "echthros", Gloss = "enemy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "his enemy"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐπέσπειρεν", Transliteration = "epespeiren", Gloss = "sowed afterward", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ζιζάνια", Transliteration = "zizania", Gloss = "weeds", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "weeds"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνὰ", Transliteration = "ana", Gloss = "among", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "μέσον", Transliteration = "meson", Gloss = "middle", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σίτου", Transliteration = "sitou", Gloss = "wheat", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the wheat"
                        }
                    },
                    Translation = "among the wheat"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἀπῆλθεν", Transliteration = "apēlthen", Gloss = "went away", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "But while the men were sleeping, his enemy came and sowed weeds among the wheat and went away."
        },

        // Verse 26
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
                        new Word { Greek = "ὅτε", Transliteration = "hote", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐβλάστησεν", Transliteration = "eblastēsen", Gloss = "sprouted", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "χόρτος", Transliteration = "chortos", Gloss = "grass", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the grass"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καρπὸν", Transliteration = "karpon", Gloss = "fruit", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "fruit"
                        },
                        new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen", Gloss = "produced", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "So when the plants sprouted and produced grain"
                },
                new Word { Greek = "τότε", Transliteration = "tote", Gloss = "then", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐφάνη", Transliteration = "ephanē", Gloss = "appeared", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ζιζάνια", Transliteration = "zizania", Gloss = "weeds", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "the weeds"
                }
            },
            Translation = "So when the plants sprouted and produced grain, then the weeds appeared also."
        },

        // Verse 27
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
                        new Word { Greek = "προσελθόντες", Transliteration = "proselthontes", Gloss = "coming to", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" }
                    },
                    Translation = "And coming"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "δοῦλοι", Transliteration = "douloi", Gloss = "servants", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "οἰκοδεσπότου", Transliteration = "oikodespotou", Gloss = "master of the house", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the master"
                        }
                    },
                    Translation = "the servants of the master"
                },
                new Word { Greek = "εἶπον", Transliteration = "eipon", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "κύριε", Transliteration = "kyrie", Gloss = "Lord", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "οὐχὶ", Transliteration = "ouchi", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "καλὸν", Transliteration = "kalon", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "σπέρμα", Transliteration = "sperma", Gloss = "seed", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "good seed"
                        },
                        new Word { Greek = "ἔσπειρας", Transliteration = "espeiras", Gloss = "did you sow", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σῷ", Transliteration = "sō", Gloss = "your", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "s" },
                                new Word { Greek = "ἀγρῷ", Transliteration = "agrō", Gloss = "field", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in your field"
                        },
                        new Word { Greek = "πόθεν", Transliteration = "pothen", Gloss = "from where", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἔχει", Transliteration = "echei", Gloss = "does it have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ζιζάνια", Transliteration = "zizania", Gloss = "weeds", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "'Sir, did you not sow good seed in your field? How then does it have weeds?'"
                }
            },
            Translation = "And the servants of the master came and said to him, 'Sir, did you not sow good seed in your field? How then does it have weeds?'"
        },

        // Verse 28
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "he", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἔφη", Transliteration = "ephē", Gloss = "said", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐχθρὸς", Transliteration = "echthros", Gloss = "enemy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἄνθρωπος", Transliteration = "anthrōpos", Gloss = "man", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "an enemy"
                        },
                        new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ἐποίησεν", Transliteration = "epoiēsen", Gloss = "has done", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "'An enemy has done this.'"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δοῦλοι", Transliteration = "douloi", Gloss = "servants", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "The servants"
                },
                new Word { Greek = "λέγουσιν", Transliteration = "legousin", Gloss = "say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "θέλεις", Transliteration = "theleis", Gloss = "do you want", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "then", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπελθόντες", Transliteration = "apelthontes", Gloss = "going", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                                new Word { Greek = "συλλέξωμεν", Transliteration = "syllexōmen", Gloss = "we should gather", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" }, PartOfSpeech = "v" },
                                new Word { Greek = "αὐτά", Transliteration = "auta", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "us to go and gather them"
                        }
                    },
                    Translation = "'Then do you want us to go and gather them?'"
                }
            },
            Translation = "He said to them, 'An enemy has done this.' So the servants said to him, 'Then do you want us to go and gather them?'"
        },

        // Verse 29
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "he", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "δέ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "φησιν", Transliteration = "phēsin", Gloss = "says", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "οὔ", Transliteration = "ou", Gloss = "no", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μήποτε", Transliteration = "mēpote", Gloss = "lest", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "συλλέγοντες", Transliteration = "syllegontes", Gloss = "gathering", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ζιζάνια", Transliteration = "zizania", Gloss = "weeds", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the weeds"
                                }
                            },
                            Translation = "while gathering the weeds"
                        },
                        new Word { Greek = "ἐκριζώσητε", Transliteration = "ekrizōsēte", Gloss = "you might uproot", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἅμα", Transliteration = "hama", Gloss = "together", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "with them", GrammarCodes = new List<string> { "PRON", "DAT", "N", "P" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σῖτον", Transliteration = "siton", Gloss = "wheat", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the wheat"
                        }
                    },
                    Translation = "'No, lest in gathering the weeds you uproot the wheat along with them.'"
                }
            },
            Translation = "But he said, 'No, lest in gathering the weeds you uproot the wheat along with them.'"
        },

        // Verse 30
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἄφετε", Transliteration = "aphete", Gloss = "allow", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συναυξάνεσθαι", Transliteration = "synauxanesthai", Gloss = "to grow together", GrammarCodes = new List<string> { "V", "PRES", "MP", "INF" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἀμφότερα", Transliteration = "amphotera", Gloss = "both", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "both to grow together"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "until", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θερισμοῦ", Transliteration = "therismou", Gloss = "harvest", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the harvest"
                        }
                    },
                    Translation = "until the harvest"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "καιρῷ", Transliteration = "kairō", Gloss = "time", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "θερισμοῦ", Transliteration = "therismou", Gloss = "harvest", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "of the harvest"
                        }
                    },
                    Translation = "at the time of the harvest"
                },
                new Word { Greek = "ἐρῶ", Transliteration = "erō", Gloss = "I will say", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "to the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "θερισταῖς", Transliteration = "theristais", Gloss = "reapers", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "to the reapers"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "συλλέξατε", Transliteration = "syllexate", Gloss = "gather", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "πρῶτον", Transliteration = "prōton", Gloss = "first", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ζιζάνια", Transliteration = "zizania", Gloss = "weeds", GrammarCodes = new List<string> { "N", "ACC", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "the weeds"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δήσατε", Transliteration = "dēsate", Gloss = "bind", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                        new Word { Greek = "αὐτὰ", Transliteration = "auta", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "δέσμας", Transliteration = "desmas", Gloss = "bundles", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "into bundles"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κατακαῦσαι", Transliteration = "katakausai", Gloss = "burn up", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                                new Word { Greek = "αὐτά", Transliteration = "auta", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "to burn them up"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "σῖτον", Transliteration = "siton", Gloss = "wheat", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "but the wheat"
                        },
                        new Word { Greek = "συναγάγετε", Transliteration = "synagagete", Gloss = "gather", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
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
                                        new Word { Greek = "ἀποθήκην", Transliteration = "apothēkēn", Gloss = "barn", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "my", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "my barn"
                                }
                            },
                            Translation = "into my barn"
                        }
                    },
                    Translation = "'Gather the weeds first and bind them in bundles to be burned, but gather the wheat into my barn.'"
                }
            },
            Translation = "Let both grow together until the harvest, and at harvest time I will tell the reapers, 'Gather the weeds first and bind them in bundles to be burned, but gather the wheat into my barn.'"
        },

        // Verse 31
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
                        new Word { Greek = "Ἄλλην", Transliteration = "allēn", Gloss = "another", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "παραβολὴν", Transliteration = "parabolēn", Gloss = "parable", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Another parable"
                },
                new Word { Greek = "παρέθηκεν", Transliteration = "parethēken", Gloss = "he set before", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγων", Transliteration = "legōn", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "saying"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁμοία", Transliteration = "homoia", Gloss = "like", GrammarCodes = new List<string> { "ADJ", "NOM", "F", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐστὶν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "βασιλεία", Transliteration = "basileia", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "οὐρανῶν", Transliteration = "ouranōn", Gloss = "heavens", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the heavens"
                                }
                            },
                            Translation = "the kingdom of the heavens"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κόκκῳ", Transliteration = "kokkō", Gloss = "to a grain", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "σινάπεως", Transliteration = "sinapeōs", Gloss = "of mustard", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "to a grain of mustard"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃν", Transliteration = "hon", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pron" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PTCP" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "λαβὼν", Transliteration = "labōn", Gloss = "taking", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "taking"
                                },
                                new Word { Greek = "ἄνθρωπος", Transliteration = "anthrōpos", Gloss = "a man", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "ἔσπειρεν", Transliteration = "espeiren", Gloss = "sowed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἀγρῷ", Transliteration = "agrō", Gloss = "field", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "his", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "in his field"
                                }
                            },
                            Translation = "which a man took and sowed in his field"
                        }
                    },
                    Translation = "'The kingdom of heaven is like a grain of mustard seed that a man took and sowed in his field.'"
                }
            },
            Translation = "He put another parable before them, saying, 'The kingdom of heaven is like a grain of mustard seed that a man took and sowed in his field.'"
        },

        // Verse 32
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "μικρότερον", Transliteration = "mikroteron", Gloss = "smaller", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "μέν", Transliteration = "men", Gloss = "indeed", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πάντων", Transliteration = "pantōn", Gloss = "of all", GrammarCodes = new List<string> { "ADJ", "GEN", "N", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "σπερμάτων", Transliteration = "spermatōn", Gloss = "seeds", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "of all seeds"
                        }
                    },
                    Translation = "It is the smallest of all seeds"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅταν", Transliteration = "hotan", Gloss = "when", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐξηθῇ", Transliteration = "auxēthē", Gloss = "it has grown", GrammarCodes = new List<string> { "V", "AOR", "PASS", "SUBJ", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "but when it has grown"
                },
                new Word { Greek = "μεῖζον", Transliteration = "meizon", Gloss = "larger", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "than the", GrammarCodes = new List<string> { "ART", "GEN", "N", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "λαχάνων", Transliteration = "lachanōn", Gloss = "garden plants", GrammarCodes = new List<string> { "N", "GEN", "N", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "than the garden plants"
                },
                new Word { Greek = "ἐστὶν", Transliteration = "estin", Gloss = "it is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "γίνεται", Transliteration = "ginetai", Gloss = "becomes", GrammarCodes = new List<string> { "V", "PRES", "MP", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δένδρον", Transliteration = "dendron", Gloss = "a tree", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "RESULT_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὥστε", Transliteration = "hōste", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐλθεῖν", Transliteration = "elthein", Gloss = "come", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "πετεινὰ", Transliteration = "peteina", Gloss = "birds", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "P" }, PartOfSpeech = "adj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "οὐρανοῦ", Transliteration = "ouranou", Gloss = "air", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "of the air"
                                }
                            },
                            Translation = "the birds of the air"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "κατασκηνοῦν", Transliteration = "kataskēnoun", Gloss = "make nests", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" },
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
                                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κλάδοις", Transliteration = "kladois", Gloss = "branches", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "n" },
                                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "its", GrammarCodes = new List<string> { "PRON", "GEN", "N", "S" }, PartOfSpeech = "prep" }
                                    },
                                    Translation = "its branches"
                                }
                            },
                            Translation = "in its branches"
                        }
                    },
                    Translation = "so that the birds of the air come and make nests in its branches"
                }
            },
            Translation = "It is the smallest of all seeds, but when it has grown it is larger than all the garden plants and becomes a tree, so that the birds of the air come and make nests in its branches."
        }
    };
}

/*
Constructions identified:
- INF_PHRASE (Articular Infinitive): Verse 25 (τῷ καθεύδειν)
- NOUN_PHRASE (Subject of Infinitive): Verse 25 (τοὺς ἀνθρώπους)
- NOUN_PHRASE (Genitive of Possession): Verse 25 (αὐτοῦ ὁ ἐχθρὸς)
- NOUN_PHRASE (Predicate Nominative): Verse 28 (ἐχθρὸς ἄνθρωπος)
- INF_PHRASE (Complementary): Verse 30 (συναυξάνεσθαι)
- NOUN_PHRASE (Indirect Object): Verse 30 (τοῖς θερισταῖς)
- NOUN_PHRASE (Predicate Nominative): Verse 31 (ὁμοία ... ἡ βασιλεία)
- REL_CLAUSE: Verse 31 (ὃν λαβὼν...), Verse 32 (ὃ μικρότερον...)
- RESULT_CLAUSE: Verse 32 (ὥστε ἐλθεῖν...)
*/
