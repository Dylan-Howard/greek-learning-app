private static List<object> GetChapter9()
{
    // Luke 9:33-40
    return new List<object>
    {
        // Verse 33
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "it happened", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "And it happened"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "as", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "διαχωρίζεσθαι", Transliteration = "diachōrizesthai", Gloss = "were departing", GrammarCodes = new List<string> { "V", "PRES", "MID", "INF" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "they", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπ᾽", Transliteration = "ap'", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "from him"
                }
            },
            Translation = "as they were departing from him"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εἶπεν", Transliteration = "eipen", Gloss = "said", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Πέτρος", Transliteration = "Petros", Gloss = "Peter", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "Peter"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πρὸς", Transliteration = "pros", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "Ἰησοῦν", Transliteration = "Iēsoun", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "to Jesus"
                }
            },
            Translation = "Peter said to Jesus"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "VOC" },
            Content = new List<object>
            {
                new Word { Greek = "ἐπιστάτα", Transliteration = "epistata", Gloss = "Master", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "Master"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καλόν", Transliteration = "kalon", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "it is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡμᾶς", Transliteration = "hēmas", Gloss = "us", GrammarCodes = new List<string> { "PRON", "ACC", "1P", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ὧδε", Transliteration = "hōde", Gloss = "here", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                    },
                    Translation = "for us to be here"
                }
            },
            Translation = "it is good for us to be here"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ποιήσωμεν", Transliteration = "poiēsōmen", Gloss = "let us make", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "1P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "σκηνὰς", Transliteration = "skēnas", Gloss = "tabernacles", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "τρεῖς", Transliteration = "treis", Gloss = "three", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "P" }, PartOfSpeech = "adj" }
                    },
                    Translation = "three tabernacles"
                }
            },
            Translation = "and let us make three tabernacles"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
            Content = new List<object>
            {
                new Word { Greek = "μίαν", Transliteration = "mian", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "σοὶ", Transliteration = "soi", Gloss = "for you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "S" }, PartOfSpeech = "pronoun" }
            },
            Translation = "one for you"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μίαν", Transliteration = "mian", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "Μωϋσεῖ", Transliteration = "Mōusei", Gloss = "for Moses", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "and one for Moses"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μίαν", Transliteration = "mian", Gloss = "one", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "Ἠλίᾳ", Transliteration = "Ēlia", Gloss = "for Elijah", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "and one for Elijah"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "εἰδὼς", Transliteration = "eidōs", Gloss = "knowing", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pron" },
                        new Word { Greek = "λέγει", Transliteration = "legei", Gloss = "he was saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "what he was saying"
                }
            },
            Translation = "not knowing what he was saying"
        },

        // Verse 34
        new Phrase
        {
            SyntaxCodes = new List<string> { "GEN_ABS" },
            Content = new List<object>
            {
                new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "adv" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "as he", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "λέγοντος", Transliteration = "legontos", Gloss = "was saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "GEN", "M", "S" }, PartOfSpeech = "v" }
            },
            Translation = "But as he was saying these things"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "there came", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "νεφέλη", Transliteration = "nephelē", Gloss = "a cloud", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "a cloud"
                }
            },
            Translation = "a cloud came"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐπεσκίαζεν", Transliteration = "epeskiazen", Gloss = "overshadowed", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτούς", Transliteration = "autous", Gloss = "them", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pronoun" }
            },
            Translation = "and it overshadowed them"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐφοβήθησαν", Transliteration = "ephobēthēsan", Gloss = "they were afraid", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" }
            },
            Translation = "and they were afraid"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "as", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "εἰσελθεῖν", Transliteration = "eiselthein", Gloss = "entered", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοὺς", Transliteration = "autous", Gloss = "they", GrammarCodes = new List<string> { "PRON", "ACC", "M", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "into", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "νεφέλην", Transliteration = "nephelēn", Gloss = "cloud", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "into the cloud"
                }
            },
            Translation = "as they entered into the cloud"
        },

        // Verse 35
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "φωνὴ", Transliteration = "phōnē", Gloss = "a voice", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "a voice"
                },
                new Word { Greek = "ἐγένετο", Transliteration = "egeneto", Gloss = "came", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "out of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τῆς", Transliteration = "tēs", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "νεφέλης", Transliteration = "nephelēs", Gloss = "cloud", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "out of the cloud"
                }
            },
            Translation = "And a voice came out of the cloud"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "λέγουσα", Transliteration = "legousa", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "v" }
            },
            Translation = "saying"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "οὗτός", Transliteration = "houtos", Gloss = "This", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "adv" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "υἱός", Transliteration = "huios", Gloss = "Son", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "my", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "my Son"
                }
            },
            Translation = "This is my Son"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "NOUN_PHRASE", "APPOS" },
            Content = new List<object>
            {
                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "ἐκλελεγμένος", Transliteration = "eklelegmenos", Gloss = "Chosen One", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" }
            },
            Translation = "the Chosen One"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "to him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "ἀκούετε", Transliteration = "akouete", Gloss = "listen", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "listen to him"
        },

        // Verse 36
        new Phrase
        {
            SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐν", Transliteration = "en", Gloss = "when", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "N", "S" }, PartOfSpeech = "art" },
                new Word { Greek = "γενέσθαι", Transliteration = "genesthai", Gloss = "had occurred", GrammarCodes = new List<string> { "V", "AOR", "MID", "INF" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "φωνὴν", Transliteration = "phōnēn", Gloss = "voice", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "the voice"
                }
            },
            Translation = "And when the voice had occurred"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "εὑρέθη", Transliteration = "heurethē", Gloss = "was found", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                new Word { Greek = "μόνος", Transliteration = "monos", Gloss = "alone", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
            },
            Translation = "Jesus was found alone"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "αὐτοὶ", Transliteration = "autoi", Gloss = "they", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "ἐσίγησαν", Transliteration = "esigēsan", Gloss = "kept silent", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "And they kept silent"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐδενὶ", Transliteration = "oudeni", Gloss = "to no one", GrammarCodes = new List<string> { "ADJ", "DAT", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀπήγγειλαν", Transliteration = "apēngeilan", Gloss = "they told", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἐκείναις", Transliteration = "ekeinais", Gloss = "those", GrammarCodes = new List<string> { "PRON", "DAT", "F", "P" }, PartOfSpeech = "adv" },
                        new Word { Greek = "ταῖς", Transliteration = "tais", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἡμέραις", Transliteration = "hēmerais", Gloss = "days", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" }
                    },
                    Translation = "in those days"
                },
                new Word { Greek = "οὐδὲν", Transliteration = "ouden", Gloss = "nothing", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὧν", Transliteration = "hōn", Gloss = "of what", GrammarCodes = new List<string> { "PRON", "GEN", "N", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἑώρακαν", Transliteration = "heōrakan", Gloss = "they had seen", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "of what they had seen"
                }
            },
            Translation = "and told no one in those days anything of what they had seen"
        },

        // Verse 37
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ἐγένετο", Transliteration = "Egeneto", Gloss = "It happened", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "now", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "on the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ἑξῆς", Transliteration = "hexēs", Gloss = "next", GrammarCodes = new List<string> { "ADJ" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἡμέρᾳ", Transliteration = "hēmera", Gloss = "day", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "on the next day"
                }
            },
            Translation = "Now it happened on the next day"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "GEN_ABS" },
            Content = new List<object>
            {
                new Word { Greek = "κατελθόντων", Transliteration = "katelthontōn", Gloss = "when they had come down", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῶν", Transliteration = "autōn", Gloss = "they", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "N", "S" }, PartOfSpeech = "art" },
                        new Word { Greek = "ὄρους", Transliteration = "orous", Gloss = "mountain", GrammarCodes = new List<string> { "N", "GEN", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "from the mountain"
                }
            },
            Translation = "when they had come down from the mountain"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "συνήντησεν", Transliteration = "synēntēsen", Gloss = "met", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "him", GrammarCodes = new List<string> { "PRON", "DAT", "M", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὄχλος", Transliteration = "ochlos", Gloss = "a crowd", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "πολύς", Transliteration = "polys", Gloss = "great", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "a great crowd"
                }
            },
            Translation = "a great crowd met him"
        },

        // Verse 38
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀνὴρ", Transliteration = "anēr", Gloss = "a man", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ὄχλου", Transliteration = "ochlou", Gloss = "crowd", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "from the crowd"
                        }
                    },
                    Translation = "a man from the crowd"
                },
                new Word { Greek = "ἐβόησεν", Transliteration = "ebōēsen", Gloss = "cried out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "And behold, a man from the crowd cried out"
        },
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
            SyntaxCodes = new List<string> { "VOC" },
            Content = new List<object>
            {
                new Word { Greek = "διδάσκαλε", Transliteration = "didaskale", Gloss = "Teacher", GrammarCodes = new List<string> { "N", "VOC", "M", "S" }, PartOfSpeech = "n" }
            },
            Translation = "Teacher"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "δέομαί", Transliteration = "deomai", Gloss = "I beg", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INF_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐπιβλέψαι", Transliteration = "epiblepsai", Gloss = "to look upon", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "epi", Gloss = "upon", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "υἱόν", Transliteration = "huion", Gloss = "son", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "μου", Transliteration = "mou", Gloss = "my", GrammarCodes = new List<string> { "PRON", "GEN", "1P", "S" }, PartOfSpeech = "pronoun" }
                            },
                            Translation = "my son"
                        }
                    },
                    Translation = "to look upon my son"
                }
            },
            Translation = "I beg of you to look upon my son"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μονογενής", Transliteration = "monogenēs", Gloss = "only child", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                new Word { Greek = "μοί", Transliteration = "moi", Gloss = "to me", GrammarCodes = new List<string> { "PRON", "DAT", "1P", "S" }, PartOfSpeech = "pronoun" },
                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "he is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "for he is my only child"
        },

        // Verse 39
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἰδοὺ", Transliteration = "idou", Gloss = "behold", GrammarCodes = new List<string> { "INTERJ" }, PartOfSpeech = "interj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πνεῦμα", Transliteration = "pneuma", Gloss = "a spirit", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "a spirit"
                },
                new Word { Greek = "λαμβάνει", Transliteration = "lambanei", Gloss = "takes", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" }
            },
            Translation = "And behold, a spirit takes him"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐξαίφνης", Transliteration = "exaiphnēs", Gloss = "suddenly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "κράζει", Transliteration = "krazei", Gloss = "he cries out", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
            },
            Translation = "and suddenly he cries out"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "σπαράσσει", Transliteration = "sparassei", Gloss = "it convulses", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτὸν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μετὰ", Transliteration = "meta", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἀφροῦ", Transliteration = "aphrou", Gloss = "foaming", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                    },
                    Translation = "with foaming"
                }
            },
            Translation = "and it convulses him with foaming"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "μόγις", Transliteration = "mogis", Gloss = "scarcely", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                new Word { Greek = "ἀποχωρεῖ", Transliteration = "apochōrei", Gloss = "it departs", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀπ᾽", Transliteration = "ap'", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                        new Word { Greek = "αὐτοῦ", Transliteration = "autou", Gloss = "him", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "from him"
                }
            },
            Translation = "and it scarcely departs from him"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PTCP" },
            Content = new List<object>
            {
                new Word { Greek = "συντρῖβον", Transliteration = "syntribon", Gloss = "bruising", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "N", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτόν", Transliteration = "auton", Gloss = "him", GrammarCodes = new List<string> { "PRON", "ACC", "M", "S" }, PartOfSpeech = "pronoun" }
            },
            Translation = "bruising him"
        },

        // Verse 40
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐδεήθην", Transliteration = "edeēthēn", Gloss = "I begged", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "1P", "S" }, PartOfSpeech = "v" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                        new Word { Greek = "μαθητῶν", Transliteration = "mathētōn", Gloss = "disciples", GrammarCodes = new List<string> { "N", "GEN", "M", "P" }, PartOfSpeech = "n" },
                        new Word { Greek = "σου", Transliteration = "sou", Gloss = "of you", GrammarCodes = new List<string> { "PRON", "GEN", "2P", "S" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "your disciples"
                }
            },
            Translation = "And I begged your disciples"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἐκβάλωσιν", Transliteration = "ekbalōsin", Gloss = "they might cast out", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτό", Transliteration = "auto", Gloss = "it", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" }
            },
            Translation = "that they might cast it out"
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                new Word { Greek = "ἠδυνήθησαν", Transliteration = "ēdynēthēsan", Gloss = "they were able", GrammarCodes = new List<string> { "V", "AOR", "MID", "IND", "3P", "P" }, PartOfSpeech = "v" }
            },
            Translation = "and they were not able"
        }
    };
}

/*
Constructions identified:
- VOC: Luke 9:33 (ἐπιστάτα), 9:38 (διδάσκαλε)
- INF_PHRASE as Subj/Obj: Luke 9:33 (εἶναι), 9:38 (ἐπιβλέψαι)
- Articular Infinitive (Temporal): Luke 9:33 (ἐν τῷ διαχωρίζεσθαι), 9:34 (ἐν τῷ εἰσελθεῖν), 9:36 (ἐν τῷ γενέσθαι)
- GEN_ABS: Luke 9:34 (αὐτοῦ λέγοντος), 9:37 (κατελθόντων αὐτῶν)
- APPOS: Luke 9:33 (μίαν σοὶ...), 9:35 (ὁ ἐκλελεγμένος)
*/
