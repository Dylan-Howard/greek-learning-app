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

    public static class FirstCorinthiansTextData
    {
        private static List<object> GetChapter7()
        {
            // 1 Corinthians 7:25-32
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
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "Περὶ", Transliteration = "Peri", Gloss = "About", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "F", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "παρθένων", Transliteration = "parthenōn", Gloss = "virgins", GrammarCodes = new List<string> { "N", "GEN", "F", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the virgins"
                                }
                            },
                            Translation = "Now concerning the virgins"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐπιταγὴν", Transliteration = "epitagēn", Gloss = "command", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "of the Lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a command of the Lord"
                        },
                        new Word { Greek = "οὐκ", Transliteration = "ouk", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἔχω", Transliteration = "echō", Gloss = "I have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "Now concerning the virgins, a command of the Lord I do not have,"
                },
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
                                new Word { Greek = "γνώμην", Transliteration = "gnōmēn", Gloss = "an opinion", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "an opinion"
                        },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δίδωμι", Transliteration = "didōmi", Gloss = "I give", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "ἠλεημένος", Transliteration = "ēleēmenos", Gloss = "having received mercy", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ὑπὸ", Transliteration = "hypo", Gloss = "by", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "the Lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "by the Lord"
                                }
                            },
                            Translation = "as one having received mercy from the Lord"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "πιστὸς", Transliteration = "pistos", Gloss = "faithful", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "to be faithful"
                        }
                    },
                    Translation = "but an opinion I give as one having received mercy from the Lord to be faithful."
                },

                // Verse 26
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Νομίζω", Transliteration = "Nomizō", Gloss = "I think", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦτο", Transliteration = "touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "adv" },
                                new Word { Greek = "καλὸν", Transliteration = "kalon", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" },
                                new Word { Greek = "ὑπάρχειν", Transliteration = "hyparchein", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "this to be good"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "διὰ", Transliteration = "dia", Gloss = "on account of", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἐνεστῶσαν", Transliteration = "enestōsan", Gloss = "present", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "ACC", "F", "S" }, PartOfSpeech = "v" },
                                        new Word { Greek = "ἀνάγκην", Transliteration = "anankēn", Gloss = "necessity", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the present necessity"
                                }
                            },
                            Translation = "on account of the present necessity"
                        }
                    },
                    Translation = "I think therefore this to be good on account of the present necessity,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "CAUSAL_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "adj" },
                        new Word { Greek = "καλὸν", Transliteration = "kalon", Gloss = "good", GrammarCodes = new List<string> { "ADJ", "NOM", "N", "S" }, PartOfSpeech = "adj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀνθρώπῳ", Transliteration = "anthrōpō", Gloss = "for a man", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "for a man"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "οὕτως", Transliteration = "houtōs", Gloss = "so", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "to remain so"
                        }
                    },
                    Translation = "that it is good for a man to remain as he is."
                },

                // Verse 27
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "δέδεσαι", Transliteration = "dedesai", Gloss = "Have you been bound", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "γυναικί", Transliteration = "gynaiki", Gloss = "to a wife", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "to a wife"
                        }
                    },
                    Translation = "Have you been bound to a wife?"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ζήτει", Transliteration = "zētei", Gloss = "seek", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "λύσιν", Transliteration = "lysin", Gloss = "release", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "release"
                        }
                    },
                    Translation = "Do not seek release."
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέλυσαι", Transliteration = "lelysai", Gloss = "Have you been loosed", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀπὸ", Transliteration = "apo", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "γυναικός", Transliteration = "gynaikos", Gloss = "a wife", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "from a wife"
                        }
                    },
                    Translation = "Have you been loosed from a wife?"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ζήτει", Transliteration = "zētei", Gloss = "seek", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "γυναῖκα", Transliteration = "gynaika", Gloss = "a wife", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "a wife"
                        }
                    },
                    Translation = "Do not seek a wife."
                },

                // Verse 28
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "also", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γαμήσῃς", Transliteration = "gamēsēs", Gloss = "you should marry", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "But if also you should marry,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἥμαρτες", Transliteration = "hēmartes", Gloss = "you sinned", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "2P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "you did not sin;"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "COND_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἐὰν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "γήμῃ", Transliteration = "gēmē", Gloss = "should marry", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "παρθένος", Transliteration = "parthenos", Gloss = "virgin", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the virgin"
                        }
                    },
                    Translation = "and if the virgin should marry,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "οὐχ", Transliteration = "ouch", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                        new Word { Greek = "ἥμαρτεν", Transliteration = "hēmarten", Gloss = "she sinned", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "she did not sin."
                },
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
                                new Word { Greek = "θλῖψιν", Transliteration = "thlipsin", Gloss = "trouble", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "trouble"
                        },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_REF" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "F", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σαρκὶ", Transliteration = "sarki", Gloss = "flesh", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "in the flesh"
                        },
                        new Word { Greek = "ἕξουσιν", Transliteration = "hexousin", Gloss = "will have", GrammarCodes = new List<string> { "V", "FUT", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "τοιοῦτοι", Transliteration = "toioutoi", Gloss = "such ones", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "P" }, PartOfSpeech = "adv" }
                            },
                            Translation = "such ones"
                        }
                    },
                    Translation = "But trouble in the flesh such ones will have,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐγὼ", Transliteration = "egō", Gloss = "I", GrammarCodes = new List<string> { "PRON", "NOM", "S" }, PartOfSpeech = "prep" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ὑμῶν", Transliteration = "hymōn", Gloss = "you", GrammarCodes = new List<string> { "PRON", "GEN", "P" }, PartOfSpeech = "prep" },
                        new Word { Greek = "φείδομαι", Transliteration = "pheidomai", Gloss = "spare", GrammarCodes = new List<string> { "V", "PRES", "MID", "IND", "1P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "but I spare you."
                },

                // Verse 29
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Τοῦτο", Transliteration = "Touto", Gloss = "this", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "adv" },
                        new Word { Greek = "δέ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "φημι", Transliteration = "phēmi", Gloss = "I say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "VOC" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἀδελφοί", Transliteration = "adelphoi", Gloss = "brothers", GrammarCodes = new List<string> { "N", "VOC", "M", "P" }, PartOfSpeech = "n" }
                            },
                            Translation = "brothers"
                        }
                    },
                    Translation = "But this I say, brothers,"
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
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "καιρὸς", Transliteration = "kairos", Gloss = "time", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the time"
                        },
                        new Word { Greek = "συνεσταλμένος", Transliteration = "synestalmenos", Gloss = "shortened", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ἐστίν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" }
                    },
                    Translation = "the time has been shortened;"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "λοιπόν", Transliteration = "loipon", Gloss = "remaining", GrammarCodes = new List<string> { "ADJ", "ACC", "N", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "for the rest"
                        },
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "even", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "those", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἔχοντες", Transliteration = "echontes", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "γυναῖκας", Transliteration = "gynaikas", Gloss = "wives", GrammarCodes = new List<string> { "N", "ACC", "F", "P" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "wives"
                                }
                            },
                            Translation = "those having wives"
                        },
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἔχοντες", Transliteration = "echontes", Gloss = "having", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "not having"
                        },
                        new Word { Greek = "ὦσιν", Transliteration = "ōsin", Gloss = "may be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "v" },

                        // Verse 30
                        // (continues verse 29)
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "those", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "κλαίοντες", Transliteration = "klaiontes", Gloss = "weeping", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "those weeping"
                        },
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                new Word { Greek = "κλαίοντες", Transliteration = "klaiontes", Gloss = "weeping", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "not weeping"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "those", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "χαίροντες", Transliteration = "chairontes", Gloss = "rejoicing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "those rejoicing"
                        },
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                new Word { Greek = "χαίροντες", Transliteration = "chairontes", Gloss = "rejoicing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "not rejoicing"
                        },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "those", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἀγοράζοντες", Transliteration = "agorazontes", Gloss = "buying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "those buying"
                        },
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                new Word { Greek = "κατέχοντες", Transliteration = "katechontes", Gloss = "possessing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "not possessing"
                        },

                        // Verse 31
                        // (continues verse 29)
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "οἱ", Transliteration = "hoi", Gloss = "those", GrammarCodes = new List<string> { "ART", "NOM", "M", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "χρώμενοι", Transliteration = "chrōmenoi", Gloss = "using", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τὸν", Transliteration = "ton", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κόσμον", Transliteration = "kosmon", Gloss = "world", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "the world"
                                }
                            },
                            Translation = "those using the world"
                        },
                        new Word { Greek = "ὡς", Transliteration = "hōs", Gloss = "as", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                new Word { Greek = "καταχρώμενοι", Transliteration = "katachrōmenoi", Gloss = "using to the full", GrammarCodes = new List<string> { "V", "PRES", "MID", "PTCP", "NOM", "M", "P" }, PartOfSpeech = "v" }
                            },
                            Translation = "not using it to the full"
                        }
                    },
                    Translation = "so that those having wives be as not having, and those weeping as not weeping, and those rejoicing as not rejoicing, and those buying as not possessing, and those using the world as not using it to the full;"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "παράγει", Transliteration = "paragei", Gloss = "passes away", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "γὰρ", Transliteration = "gar", Gloss = "for", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὸ", Transliteration = "to", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "N", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "σχῆμα", Transliteration = "schēma", Gloss = "form", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "n" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                        new Word { Greek = "κόσμου", Transliteration = "kosmou", Gloss = "world", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" },
                                        new Word { Greek = "τούτου", Transliteration = "toutou", Gloss = "this", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "adv" }
                                    },
                                    Translation = "of this world"
                                }
                            },
                            Translation = "the form of this world"
                        }
                    },
                    Translation = "For the form of this world is passing away."
                },

                // Verse 32
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Θέλω", Transliteration = "Thelō", Gloss = "I wish", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "INF_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὑμᾶς", Transliteration = "hymas", Gloss = "you", GrammarCodes = new List<string> { "PRON", "ACC", "P" }, PartOfSpeech = "prep" },
                                new Word { Greek = "ἀμερίμνους", Transliteration = "amerimnous", Gloss = "free from care", GrammarCodes = new List<string> { "ADJ", "ACC", "M", "P" }, PartOfSpeech = "adj" },
                                new Word { Greek = "εἶναι", Transliteration = "einai", Gloss = "to be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "INF" }, PartOfSpeech = "v" }
                            },
                            Translation = "you to be free from care"
                        }
                    },
                    Translation = "But I wish you to be free from care."
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
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "ἄγαμος", Transliteration = "agamos", Gloss = "unmarried man", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the unmarried man"
                        },
                        new Word { Greek = "μεριμνᾷ", Transliteration = "merimna", Gloss = "cares for", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τὰ", Transliteration = "ta", Gloss = "the things", GrammarCodes = new List<string> { "ART", "ACC", "N", "P" }, PartOfSpeech = "art" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the things of the Lord"
                        }
                    },
                    Translation = "The unmarried man cares for the things of the Lord,"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "πῶς", Transliteration = "pōs", Gloss = "how", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἀρέσῃ", Transliteration = "aresē", Gloss = "he may please", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "IND_OBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῷ", Transliteration = "tō", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "S" }, PartOfSpeech = "art" },
                                new Word { Greek = "κυρίῳ", Transliteration = "kyriō", Gloss = "Lord", GrammarCodes = new List<string> { "N", "DAT", "M", "S" }, PartOfSpeech = "n" }
                            },
                            Translation = "the Lord"
                        }
                    },
                    Translation = "how he may please the Lord."
                }
            };
        }
    }
}

// Constructions Identified:
// 1. INF_PHRASE (πιστὸς εἶναι) - 1 Cor 7:25
// 2. INF_PHRASE (τοῦτο καλὸν ὑπάρχειν) - 1 Cor 7:26
// 3. INF_PHRASE (τὸ οὕτως εἶναι) - 1 Cor 7:26
// 4. DAT_REF (γυναικί) - 1 Cor 7:27
// 5. COND_CLAUSE (ἐὰν δὲ καὶ γαμήσῃς) - 1 Cor 7:28
// 6. DAT_REF (τῇ σαρκὶ) - 1 Cor 7:28
// 7. VOC (ἀδελφοί) - 1 Cor 7:29
// 8. PERIPH (συνεσταλμένος ἐστίν) - 1 Cor 7:29
// 9. PURPOSE_CLAUSE (ἵνα... ὦσιν) - 1 Cor 7:29-31
