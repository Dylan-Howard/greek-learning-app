private static List<object> GetChapter3()
{
    // 2 Peter 3:17-18
    return new List<object>
    {
        // Verse 17
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Ὑμεῖς", Transliteration = "Hymeis", Gloss = "you",
                    GrammarCodes = new List<string> { "PRON", "2P", "NOM", "P" },
                    PartOfSpeech = "pronoun" },
                new Word { Greek = "οὖν", Transliteration = "oun", Gloss = "therefore",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "ἀγαπητοί", Transliteration = "agapētoi", Gloss = "beloved",
                    GrammarCodes = new List<string> { "ADJ", "VOC", "M", "P" },
                    PartOfSpeech = "adj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "προγινώσκοντες", Transliteration = "proginōskontes", Gloss = "knowing beforehand",
                            GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "P" },
                            PartOfSpeech = "verb" }
                    },
                    Translation = "knowing [this] beforehand"
                },
                new Word { Greek = "φυλάσσεσθε", Transliteration = "phylassesthe", Gloss = "be on guard",
                    GrammarCodes = new List<string> { "V", "PRES", "MID", "IMP", "2P", "P" },
                    PartOfSpeech = "verb" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PURPOSE_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἵνα", Transliteration = "hina", Gloss = "in order that",
                            GrammarCodes = new List<string> { "CONJ" },
                            PartOfSpeech = "conj" },
                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not",
                            GrammarCodes = new List<string> { "PART" },
                            PartOfSpeech = "particle" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PTCP" },
                            Content = new List<object>
                            {
                                new Word { Greek = "συναπαχθέντες", Transliteration = "synapachthentes", Gloss = "being led away",
                                    GrammarCodes = new List<string> { "V", "AOR", "PASS", "PTCP", "NOM", "M", "P" },
                                    PartOfSpeech = "verb" }
                            },
                            Translation = "being led away"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τῇ", Transliteration = "tē", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "DAT", "F", "S" },
                                    PartOfSpeech = "art" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of the",
                                            GrammarCodes = new List<string> { "ART", "GEN", "M", "P" },
                                            PartOfSpeech = "art" },
                                        new Word { Greek = "ἀθέσμων", Transliteration = "athesmōn", Gloss = "lawless",
                                            GrammarCodes = new List<string> { "ADJ", "GEN", "M", "P" },
                                            PartOfSpeech = "adj" }
                                    },
                                    Translation = "of the lawless"
                                },
                                new Word { Greek = "πλάνῃ", Transliteration = "planē", Gloss = "error",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "by the error of the lawless"
                        },
                        new Word { Greek = "ἐκπέσητε", Transliteration = "ekpēsēte", Gloss = "you might fall",
                            GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "2P", "P" },
                            PartOfSpeech = "verb" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "ἰδίου", Transliteration = "idiou", Gloss = "own",
                                    GrammarCodes = new List<string> { "ADJ", "GEN", "M", "S" },
                                    PartOfSpeech = "adj" },
                                new Word { Greek = "στηριγμοῦ", Transliteration = "stērigmou", Gloss = "steadfastness",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "from your own steadfastness"
                        }
                    },
                    Translation = "lest you fall from your own steadfastness, being led away by the error of lawless men"
                }
            },
            Translation = "You therefore, beloved, knowing these things beforehand, be on guard lest you fall from your own steadfastness, being led away by the error of lawless men."
        },

        // Verse 18
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "αὐξάνετε", Transliteration = "auxanete", Gloss = "grow",
                    GrammarCodes = new List<string> { "V", "PRES", "ACT", "IMP", "2P", "P" },
                    PartOfSpeech = "verb" },
                new Word { Greek = "δὲ", Transliteration = "de", Gloss = "but",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἐν", Transliteration = "en", Gloss = "in",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "χάριτι", Transliteration = "chariti", Gloss = "grace",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "γνώσει", Transliteration = "gnōsei", Gloss = "knowledge",
                                    GrammarCodes = new List<string> { "N", "DAT", "F", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "grace and knowledge"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "TSKS" },
                            Content = new List<object>
                            {
                                new Word { Greek = "τοῦ", Transliteration = "tou", Gloss = "of the",
                                    GrammarCodes = new List<string> { "ART", "GEN", "M", "S" },
                                    PartOfSpeech = "art" },
                                new Word { Greek = "κυρίου", Transliteration = "kyriou", Gloss = "Lord",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "ἡμῶν", Transliteration = "hēmōn", Gloss = "of us",
                                    GrammarCodes = new List<string> { "PRON", "1P", "GEN", "P" },
                                    PartOfSpeech = "pronoun" },
                                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                                    GrammarCodes = new List<string> { "CONJ" },
                                    PartOfSpeech = "conj" },
                                new Word { Greek = "σωτῆρος", Transliteration = "sōtēros", Gloss = "Savior",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "Ἰησοῦ", Transliteration = "Iēsou", Gloss = "Jesus",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "Χριστοῦ", Transliteration = "Christou", Gloss = "Christ",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "of our Lord and Savior Jesus Christ"
                        }
                    },
                    Translation = "in the grace and knowledge of our Lord and Savior Jesus Christ"
                }
            },
            Translation = "But grow in the grace and knowledge of our Lord and Savior Jesus Christ."
        },
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "αὐτῷ", Transliteration = "autō", Gloss = "to him",
                    GrammarCodes = new List<string> { "PRON", "3P", "DAT", "M", "S" },
                    PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "NOUN_PHRASE", "SUBJ" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἡ", Transliteration = "hē", Gloss = "the",
                            GrammarCodes = new List<string> { "ART", "NOM", "F", "S" },
                            PartOfSpeech = "art" },
                        new Word { Greek = "δόξα", Transliteration = "doxa", Gloss = "glory",
                            GrammarCodes = new List<string> { "N", "NOM", "F", "S" },
                            PartOfSpeech = "noun" }
                    },
                    Translation = "the glory"
                },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "both",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Word { Greek = "νῦν", Transliteration = "nyn", Gloss = "now",
                    GrammarCodes = new List<string> { "ADV" },
                    PartOfSpeech = "adv" },
                new Word { Greek = "καὶ", Transliteration = "kai", Gloss = "and",
                    GrammarCodes = new List<string> { "CONJ" },
                    PartOfSpeech = "conj" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PREP_PHRASE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "εἰς", Transliteration = "eis", Gloss = "to",
                            GrammarCodes = new List<string> { "PREP" },
                            PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἡμέραν", Transliteration = "hēmeran", Gloss = "day",
                                    GrammarCodes = new List<string> { "N", "ACC", "F", "S" },
                                    PartOfSpeech = "noun" },
                                new Word { Greek = "αἰῶνος", Transliteration = "aiōnos", Gloss = "of eternity",
                                    GrammarCodes = new List<string> { "N", "GEN", "M", "S" },
                                    PartOfSpeech = "noun" }
                            },
                            Translation = "the day of eternity"
                        }
                    },
                    Translation = "to the day of eternity"
                }
            },
            Translation = "To him be the glory both now and to the day of eternity."
        }
    };
}

/*
Constructions identified:
- DAT_INSTR: 3:17 (τῇ ... πλάνῃ)
- TSKS: 3:18 (τοῦ κυρίου ἡμῶν καὶ σωτῆρος) - Granville Sharp construction linking Lord and Savior to the same person.
- PTCP: 3:17 (προγινώσκοντες, συναπαχθέντες)
*/
