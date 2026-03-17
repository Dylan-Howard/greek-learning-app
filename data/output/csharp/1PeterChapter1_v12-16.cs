using System.Text.Json;

namespace GreekParser.Infrastructure.Data.Seed
{
    public class Word
    {
        public string Greek { get; set; } = string.Empty;
        public string Transliteration { get; set; } = string.Empty;
        public string Gloss { get; set; } = string.Empty;
        public List<string> GrammarCodes { get; set; } = new();
        public string PartOfSpeech { get; set; } = string.Empty;
    }

    public class Phrase
    {
        public List<string> SyntaxCodes { get; set; } = new();
        public List<object> Content { get; set; } = new(); // Can be Word or Phrase
        public string Translation { get; set; } = string.Empty;
    }

    public static class FirstPeterTextData
    {
        private static List<object> GetChapter1()
        {
            // 1 Peter 1:12-16
            return new List<object>
            {
                // Verse 12
                new Phrase
                {
                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οἷς", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pron" },
                        new Word { Greek = "ἀπεκαλύφθη", Transliteration = "", Gloss = "to reveal", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "οὐχ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἑαυτοῖς", Transliteration = "", Gloss = "himself", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "f" },
                                new Word { Greek = "ὑμῖν", Transliteration = "", Gloss = "see you", GrammarCodes = new List<string> { "PRON", "DAT", "P" }, PartOfSpeech = "prep" },
                                new Word { Greek = "δὲ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "διηκόνουν", Transliteration = "", Gloss = "to serve", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                                new Word { Greek = "αὐτὰ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "prep" }
                            },
                            Translation = "that not to themselves but to you they were serving these things"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἃ", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "N", "P" }, PartOfSpeech = "pron" },
                                new Word { Greek = "νῦν", Transliteration = "", Gloss = "now", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἀνηγγέλη", Transliteration = "", Gloss = "to tell", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                new Word { Greek = "ὑμῖν", Transliteration = "", Gloss = "see you", GrammarCodes = new List<string> { "PRON", "DAT", "P" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "διὰ", Transliteration = "", Gloss = "through", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῶν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                                new Word { Greek = "εὐαγγελισαμένων", Transliteration = "", Gloss = "to preach the gospel", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" },
                                                new Word { Greek = "ὑμᾶς", Transliteration = "", Gloss = "see you", GrammarCodes = new List<string> { "PRON", "ACC", "P" }, PartOfSpeech = "prep" }
                                            },
                                            Translation = "those who preached the good news to you"
                                        }
                                    },
                                    Translation = "through those who preached the good news to you"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_INSTR" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "πνεύματι", Transliteration = "", Gloss = "wind", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "ἁγίῳ", Transliteration = "", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adj" }
                                            },
                                            Translation = "the Holy Spirit"
                                        },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PTCP" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἀποσταλέντι", Transliteration = "", Gloss = "to send", GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "DAT", "N", "S" }, PartOfSpeech = "v" },
                                                new Phrase
                                                {
                                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                                    Content = new List<object>
                                                    {
                                                        new Word { Greek = "ἀπ᾽", Transliteration = "", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                                        new Word { Greek = "οὐρανοῦ", Transliteration = "", Gloss = "sky", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                                    },
                                                    Translation = "from heaven"
                                                }
                                            },
                                            Translation = "sent from heaven"
                                        }
                                    },
                                    Translation = "by the Holy Spirit sent from heaven"
                                }
                            },
                            Translation = "which now have been announced to you through those who preached the good news to you by the Holy Spirit sent from heaven"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "εἰς", Transliteration = "", Gloss = "to", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "ἃ", Transliteration = "", Gloss = "who", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pron" }
                                    },
                                    Translation = "into which things"
                                },
                                new Word { Greek = "ἐπιθυμοῦσιν", Transliteration = "", Gloss = "to long for", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                                new Word { Greek = "ἄγγελοι", Transliteration = "", Gloss = "angel", GrammarCodes = new List<string> { "N", "NOM", "M", "P" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "INF_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "παρακύψαι", Transliteration = "", Gloss = "to bend over", GrammarCodes = new List<string> { "V", "AOR", "ACT", "INF" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "to look"
                                }
                            },
                            Translation = "into which things angels long to look"
                        }
                    },
                    Translation = "To whom it was revealed that not to themselves but to you they were serving these things..."
                },

                // Verse 13
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Διὸ", Transliteration = "", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀναζωσάμενοι", Transliteration = "", Gloss = "to gird", GrammarCodes = new List<string> { "V", "AOR", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὰς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ὀσφύας", Transliteration = "", Gloss = "waist", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_DESC" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τῆς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "διανοίας", Transliteration = "", Gloss = "mind", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "ὑμῶν", Transliteration = "", Gloss = "see you", GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "prep" }
                                            },
                                            Translation = "of your mind"
                                        }
                                    },
                                    Translation = "the loins of your mind"
                                }
                            },
                            Translation = "girding up the loins of your mind"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "νήφοντες", Transliteration = "", Gloss = "to be self-controlled", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "being sober"
                        },
                        new Word { Greek = "τελείως", Transliteration = "", Gloss = "perfectly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἐλπίσατε", Transliteration = "", Gloss = "to hope", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπὶ", Transliteration = "", Gloss = "on", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PTCP" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "φερομένην", Transliteration = "", Gloss = "to bring", GrammarCodes = new List<string> { "V", "PRES", "PASS", "PTCP", "ACC", "F", "S" }, PartOfSpeech = "v" },
                                                new Word { Greek = "ὑμῖν", Transliteration = "", Gloss = "see you", GrammarCodes = new List<string> { "PRON", "DAT", "P" }, PartOfSpeech = "prep" }
                                            },
                                            Translation = "being brought to you"
                                        },
                                        new Word { Greek = "χάριν", Transliteration = "", Gloss = "grace", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the grace"
                                }
                            },
                            Translation = "on the grace being brought to you"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀποκαλύψει", Transliteration = "", Gloss = "revelation", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "GEN_OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "Ἰησοῦ", Transliteration = "", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "Χριστοῦ", Transliteration = "", Gloss = "Christ", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "of Jesus Christ"
                                        }
                                    },
                                    Translation = "the revelation of Jesus Christ"
                                }
                            },
                            Translation = "at the revelation of Jesus Christ"
                        }
                    },
                    Translation = "Therefore, preparing your minds for action, and being sober-minded, set your hope fully on the grace that will be brought to you at the revelation of Jesus Christ."
                },

                // Verse 14
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
                                new Word { Greek = "ὡς", Transliteration = "", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τέκνα", Transliteration = "", Gloss = "child", GrammarCodes = new List<string> { "N", "NOM", "N", "P" }, PartOfSpeech = "n" },
                                        new Word { Greek = "ὑπακοῆς", Transliteration = "", Gloss = "obedience", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "obedient children"
                                }
                            },
                            Translation = "As obedient children"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "", Gloss = "no", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                                new Word { Greek = "συσχηματιζόμενοι", Transliteration = "", Gloss = "to conform to a pattern", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ταῖς", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "πρότερον", Transliteration = "", Gloss = "before", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                                new Phrase
                                                {
                                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                                    Content = new List<object>
                                                    {
                                                        new Word { Greek = "τῇ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                                        new Word { Greek = "ἀγνοίᾳ", Transliteration = "", Gloss = "ignorance", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                                        new Word { Greek = "ὑμῶν", Transliteration = "", Gloss = "see you", GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "prep" }
                                                    },
                                                    Translation = "your ignorance"
                                                }
                                            },
                                            Translation = "in your ignorance"
                                        },
                                        new Word { Greek = "ἐπιθυμίαις", Transliteration = "", Gloss = "desire", GrammarCodes = new List<string> { "N", "DAT", "F", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "to the passions of your former ignorance"
                                }
                            },
                            Translation = "do not be conformed to the passions of your former ignorance"
                        },

                        // Verse 15 (continues clause)
                        // (continues verse 14)
                        new Word { Greek = "ἀλλὰ", Transliteration = "", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "κατὰ", Transliteration = "", Gloss = "against", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "καλέσαντα", Transliteration = "", Gloss = "to call", GrammarCodes = new List<string> { "V", "AOR", "ACT", "PTCP", "ACC", "M", "S" }, PartOfSpeech = "v" },
                                        new Word { Greek = "ὑμᾶς", Transliteration = "", Gloss = "see you", GrammarCodes = new List<string> { "PRON", "ACC", "P" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "ἅγιον", Transliteration = "", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "S" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "the Holy One who called you"
                                }
                            },
                            Translation = "but as he who called you is holy"
                        },
                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "αὐτοὶ", Transliteration = "", Gloss = "he", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἅγιοι", Transliteration = "", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "in", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "πάσῃ", Transliteration = "", Gloss = "all", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" }, PartOfSpeech = "adj" },
                                        new Word { Greek = "ἀναστροφῇ", Transliteration = "", Gloss = "way of life", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "all your conduct"
                                }
                            },
                            Translation = "in all your conduct"
                        },
                        new Word { Greek = "γενήθητε", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IMP", "2P", "P" }, PartOfSpeech = "v" }
                    },
                    Translation = "As obedient children, do not be conformed to the passions of your former ignorance, but as he who called you is holy, you also be holy in all your conduct"
                },

                // Verse 16
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "διότι", Transliteration = "", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γέγραπται", Transliteration = "", Gloss = "to write", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἅγιοι", Transliteration = "", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ἔσεσθε", Transliteration = "", Gloss = "to be", GrammarCodes = new List<string> { "V", "FUT", "MID", "IND", "2P", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὅτι", Transliteration = "", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                        new Word { Greek = "ἐγὼ", Transliteration = "", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "S" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "ἅγιος", Transliteration = "", Gloss = "holy", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                                    },
                                    Translation = "for I am holy"
                                }
                            },
                            Translation = "You shall be holy, for I am holy"
                        }
                    },
                    Translation = "since it is written, \"You shall be holy, for I am holy.\""
                }
            };
        }
    }
}

// Constructions identified:
// 1:12 - REL_CLAUSE (multiple)
// 1:12 - PREP_PHRASE (Dat Instr) ἐν πνεύματι
// 1:12 - INF_PHRASE παρακύψαι
// 1:13 - PTCP (Instrumental/Manner) ἀναζωσάμενοι, νήφοντες
// 1:14 - PTCP (Imperatival/Manner) συσχηματιζόμενοι
// 1:15 - NOUN_PHRASE (Substantival Participle) τὸν καλέσαντα
// 1:16 - CAUSAL_CLAUSE διότι, ὅτι