// GreekParser.Infrastructure/Data/Seed/FirstJohnTextData.cs
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

    public static class FirstJohnTextData
    {
        public static Dictionary<int, List<object>> GetChapters()
        {
            return new Dictionary<int, List<object>>
            {
                { 1, GetChapter1() },
                { 2, GetChapter2() },
                { 3, GetChapter3() },
                { 4, GetChapter4() },
                { 5, GetChapter5() }
            };
        }

        private static List<object> GetChapter1()
        {
            // 1 John 1:1-10
            return new List<object>
            {
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
                                new Word { Greek = "Ὃ", Transliteration = "Ho", Gloss = "that which", GrammarCodes = new List<string> { "PRON", "NOM", "N", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "ἦν", Transliteration = "ēn", Gloss = "was", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἀπ'", Transliteration = "ap'", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                        new Word { Greek = "ἀρχῆς", Transliteration = "archēs", Gloss = "beginning", GrammarCodes = new List<string> { "N", "GEN", "F", "S" }, PartOfSpeech = "noun" }
                                    },
                                    Translation = "from the beginning"
                                }
                            },
                            Translation = "That which was from the beginning"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "ἀκηκόαμεν", Transliteration = "akēkoamen", Gloss = "we have heard", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "which we have heard"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "REL_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "which", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                                new Word { Greek = "ἑωράκαμεν", Transliteration = "heōrakamen", Gloss = "we have seen", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τοῖς", Transliteration = "tois", Gloss = "the", GrammarCodes = new List<string> { "ART", "DAT", "M", "P" }, PartOfSpeech = "article" },
                                        new Word { Greek = "ὀφθαλμοῖς", Transliteration = "ophthalmois", Gloss = "eyes", GrammarCodes = new List<string> { "N", "DAT", "M", "P" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "our", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "with our eyes"
                                }
                            },
                            Translation = "which we have seen with our eyes"
                        }
                    },
                    Translation = "That which was from the beginning, which we have heard, which we have seen with our eyes"
                },
                // Verse 2
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ζωὴ", Transliteration = "zōē", Gloss = "life", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the life"
                        },
                        new Word { Greek = "ἐφανερώθη", Transliteration = "ephanerōthē", Gloss = "was manifested", GrammarCodes = new List<string> { "V", "AOR", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "and the life was manifested"
                },
                // Verse 3
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ὃ", Transliteration = "ho", Gloss = "what", GrammarCodes = new List<string> { "PRON", "ACC", "N", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἑωράκαμεν", Transliteration = "heōrakamen", Gloss = "we have seen", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἀκηκόαμεν", Transliteration = "akēkoamen", Gloss = "we have heard", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ἀπαγγέλλομεν", Transliteration = "apangellomen", Gloss = "we proclaim", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" }
                    },
                    Translation = "what we have seen and heard we proclaim to you"
                },
                // Verse 4
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "γράφομεν", Transliteration = "graphomen", Gloss = "we write", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ἡμεῖς", Transliteration = "hēmeis", Gloss = "we", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                                        new Word { Greek = "χαρὰ", Transliteration = "chara", Gloss = "joy", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" },
                                        new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "our", GrammarCodes = new List<string> { "PRON", "GEN", "M", "P" }, PartOfSpeech = "pronoun" }
                                    },
                                    Translation = "our joy"
                                },
                                new Word { Greek = "ᾖ", Transliteration = "ē", Gloss = "may be", GrammarCodes = new List<string> { "V", "PRES", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "πεπληρωμένη", Transliteration = "peplērōmenē", Gloss = "made complete", GrammarCodes = new List<string> { "V", "PERF", "PASS", "PTCP", "NOM", "F", "S" }, PartOfSpeech = "verb" }
                            },
                            Translation = "so that our joy may be made complete"
                        }
                    },
                    Translation = "and these things we write so that our joy may be made complete"
                },
                // Verse 5
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἔστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "αὕτη", Transliteration = "hautē", Gloss = "this", GrammarCodes = new List<string> { "PRON", "NOM", "F", "S" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "PRED" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "F", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "ἀγγελία", Transliteration = "angelia", Gloss = "message", GrammarCodes = new List<string> { "N", "NOM", "F", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the message"
                        },
                        new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "θεὸς", Transliteration = "theos", Gloss = "God", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "God"
                        },
                        new Word { Greek = "φῶς", Transliteration = "phōs", Gloss = "light", GrammarCodes = new List<string> { "N", "NOM", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "And this is the message that God is light"
                }
            };
        }

        private static List<object> GetChapter2()
        {
            // Simplified Chapter 2 (verses 1-5)
            return new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Τεκνία", Transliteration = "Teknia", Gloss = "Little children", GrammarCodes = new List<string> { "N", "VOC", "N", "P" }, PartOfSpeech = "noun" },
                        new Word { Greek = "μου", Transliteration = "mou", Gloss = "my", GrammarCodes = new List<string> { "PRON", "GEN", "M", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ταῦτα", Transliteration = "tauta", Gloss = "these things", GrammarCodes = new List<string> { "PRON", "ACC", "N", "P" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "γράφω", Transliteration = "graphō", Gloss = "I write", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "so that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                                new Word { Greek = "ἁμάρτητε", Transliteration = "hamartēte", Gloss = "you may sin", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" }, PartOfSpeech = "verb" }
                            },
                            Translation = "so that you may not sin"
                        }
                    },
                    Translation = "My little children, I write these things to you so that you may not sin"
                },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "ἐάν", Transliteration = "ean", Gloss = "if", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                        new Word { Greek = "τις", Transliteration = "tis", Gloss = "anyone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                        new Word { Greek = "ἁμάρτῃ", Transliteration = "hamartē", Gloss = "should sin", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "παράκλητον", Transliteration = "paraklēton", Gloss = "advocate", GrammarCodes = new List<string> { "N", "ACC", "M", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "ἔχομεν", Transliteration = "echomen", Gloss = "we have", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "and if anyone should sin, we have an advocate"
                }
            };
        }

        private static List<object> GetChapter3()
        {
            // Simplified Chapter 3 (verses 1-3)
            return new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἴδετε", Transliteration = "Idete", Gloss = "See", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ποταπὴν", Transliteration = "potapēn", Gloss = "what kind of", GrammarCodes = new List<string> { "ADJ", "ACC", "F", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "ἀγάπην", Transliteration = "agapēn", Gloss = "love", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "δέδωκεν", Transliteration = "dedōken", Gloss = "has given", GrammarCodes = new List<string> { "V", "PERF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                        new Word { Greek = "ἡμῖν", Transliteration = "hēmin", Gloss = "to us", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "πατὴρ", Transliteration = "patēr", Gloss = "Father", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the Father"
                        }
                    },
                    Translation = "See what kind of love the Father has given to us"
                }
            };
        }

        private static List<object> GetChapter4()
        {
            // Simplified Chapter 4 (verses 1-2)
            return new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Ἀγαπητοί", Transliteration = "Agapētoi", Gloss = "Beloved", GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "particle" },
                        new Word { Greek = "παντὶ", Transliteration = "panti", Gloss = "every", GrammarCodes = new List<string> { "ADJ", "DAT", "N", "S" }, PartOfSpeech = "adjective" },
                        new Word { Greek = "πνεύματι", Transliteration = "pneumati", Gloss = "spirit", GrammarCodes = new List<string> { "N", "DAT", "N", "S" }, PartOfSpeech = "noun" },
                        new Word { Greek = "πιστεύετε", Transliteration = "pisteuete", Gloss = "believe", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" }, PartOfSpeech = "verb" }
                    },
                    Translation = "Beloved, do not believe every spirit"
                }
            };
        }

        private static List<object> GetChapter5()
        {
            // Simplified Chapter 5 (verse 1)
            return new List<object>
            {
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "Πᾶς", Transliteration = "Pas", Gloss = "Everyone", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adjective" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the one", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "πιστεύων", Transliteration = "pisteuōn", Gloss = "believing", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conjunction" },
                                new Word { Greek = "Ἰησοῦς", Transliteration = "Iēsous", Gloss = "Jesus", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" },
                                new Word { Greek = "ἐστιν", Transliteration = "estin", Gloss = "is", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "verb" },
                                new Word { Greek = "ὁ", Transliteration = "ho", Gloss = "the", GrammarCodes = new List<string> { "ART", "NOM", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "Χριστός", Transliteration = "Christos", Gloss = "Christ", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "the one believing that Jesus is the Christ"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐκ", Transliteration = "ek", Gloss = "from", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "preposition" },
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the", GrammarCodes = new List<string> { "ART", "GEN", "M", "S" }, PartOfSpeech = "article" },
                                new Word { Greek = "θεοῦ", Transliteration = "theou", Gloss = "God", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "noun" }
                            },
                            Translation = "from God"
                        },
                        new Word { Greek = "γεγέννηται", Transliteration = "gegennētai", Gloss = "has been born", GrammarCodes = new List<string> { "V", "PERF", "PASS", "IND", "3P", "S" }, PartOfSpeech = "verb" }
                    },
                    Translation = "Everyone believing that Jesus is the Christ has been born from God"
                }
            };
        }

        // Vocabulary extraction
        public static List<(string Root, string Transliteration, string Gloss, string PartOfSpeech, int FrequencyRank)> GetVocabulary()
        {
            var vocab = new List<(string, string, string, string, int)>
            {
                ("ὁ", "ho", "the", "article", 1),
                ("ἡ", "hē", "the", "article", 2),
                ("τό", "to", "the", "article", 3),
                ("καί", "kai", "and", "conjunction", 4),
                ("ἐστιν", "estin", "is", "verb", 5),
                ("θεός", "theos", "God", "noun", 6),
                ("Ἰησοῦς", "Iēsous", "Jesus", "noun", 7),
                ("Χριστός", "Christos", "Christ", "noun", 8),
                ("ἀγάπη", "agapē", "love", "noun", 9),
                ("ζωή", "zōē", "life", "noun", 10),
                ("φῶς", "phōs", "light", "noun", 11),
                ("ἀρχή", "archē", "beginning", "noun", 12),
                ("λόγος", "logos", "word", "noun", 13),
                ("πατήρ", "patēr", "father", "noun", 14),
                ("υἱός", "huios", "son", "noun", 15),
                ("πνεῦμα", "pneuma", "spirit", "noun", 16),
                ("κόσμος", "kosmos", "world", "noun", 17),
                ("ἀδελφός", "adelphos", "brother", "noun", 18),
                ("ἁμαρτία", "hamartia", "sin", "noun", 19),
                ("ἐντολή", "entolē", "commandment", "noun", 20),
                ("ὀφθαλμός", "ophthalmos", "eye", "noun", 21),
                ("χαρά", "chara", "joy", "noun", 22),
                ("ἀγγελία", "angelia", "message", "noun", 23),
                ("παράκλητος", "paraklētos", "advocate", "noun", 24),
                ("τεκνίον", "teknion", "little child", "noun", 25),
                ("εἰμί", "eimi", "to be", "verb", 26),
                ("γράφω", "graphō", "to write", "verb", 27),
                ("ἀκούω", "akouō", "to hear", "verb", 28),
                ("ὁράω", "horaō", "to see", "verb", 29),
                ("ἔχω", "echō", "to have", "verb", 30),
                ("λέγω", "legō", "to say", "verb", 31),
                ("ποιέω", "poieō", "to do/make", "verb", 32),
                ("δίδωμι", "didōmi", "to give", "verb", 33),
                ("πιστεύω", "pisteuō", "to believe", "verb", 34),
                ("ἀγαπάω", "agapaō", "to love", "verb", 35),
                ("μένω", "menō", "to remain", "verb", 36),
                ("γινώσκω", "ginōskō", "to know", "verb", 37),
                ("ἁμαρτάνω", "hamartanō", "to sin", "verb", 38),
                ("φανερόω", "phaneroō", "to manifest", "verb", 39),
                ("γεννάω", "gennaō", "to beget/bear", "verb", 40),
                ("ἀπό", "apo", "from", "preposition", 41),
                ("ἐκ", "ek", "from/out of", "preposition", 42),
                ("ἐν", "en", "in", "preposition", 43),
                ("πρός", "pros", "to/toward", "preposition", 44),
                ("ὅτι", "hoti", "that/because", "conjunction", 45),
                ("ἵνα", "hina", "so that/in order that", "conjunction", 46),
                ("ἐάν", "ean", "if", "conjunction", 47),
                ("ὅς", "hos", "who/which", "pronoun", 48),
                ("τίς", "tis", "who/what/which", "pronoun", 49),
                ("ἐγώ", "egō", "I", "pronoun", 50),
                ("σύ", "su", "you", "pronoun", 51),
                ("ἡμεῖς", "hēmeis", "we", "pronoun", 52),
                ("ὑμεῖς", "humeis", "you (pl)", "pronoun", 53),
                ("οὗτος", "houtos", "this", "pronoun", 54),
                ("πᾶς", "pas", "all/every", "adjective", 55),
                ("ἀγαπητός", "agapētos", "beloved", "adjective", 56),
                ("ἀληθής", "alēthēs", "true", "adjective", 57),
                ("μή", "mē", "not", "particle", 58),
                ("οὐ", "ou", "not", "particle", 59)
            };

            return vocab;
        }
    }
}