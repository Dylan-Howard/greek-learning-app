private static List<object> GetChapter14()
{
    // Revelation 14:9-16
    return new List<object>
    {
        // Verse 9
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
                        new Word { Greek = "Καὶ", Transliteration = "", Gloss = "And", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                        new Word { Greek = "ἄλλος", Transliteration = "", Gloss = "another", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" },
                        new Word { Greek = "ἄγγελος", Transliteration = "", Gloss = "angel", GrammarCodes = new List<string> { "N", "NOM", "M", "S" }, PartOfSpeech = "n" },
                        new Word { Greek = "τρίτος", Transliteration = "", Gloss = "third", GrammarCodes = new List<string> { "ADJ", "NOM", "M", "S" }, PartOfSpeech = "adj" }
                    },
                    Translation = "And another angel, a third"
                },
                new Word { Greek = "ἠκολούθησεν", Transliteration = "", Gloss = "followed", GrammarCodes = new List<string> { "V", "AOR", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "", Gloss = "them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "pronoun" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "PTCP" },
                    Content = new List<object>
                    {
                        new Word { Greek = "λέγων", Transliteration = "", Gloss = "saying", GrammarCodes = new List<string> { "V", "PRES", "ACT", "PTCP", "NOM", "M", "S" }, PartOfSpeech = "v" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "PREP_PHRASE", "DAT_INSTR" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ἐν", Transliteration = "", Gloss = "with", GrammarCodes = new List<string> { "PREP" }, PartOfSpeech = "prep" },
                                new Word { Greek = "φωνῇ", Transliteration = "", Gloss = "voice", GrammarCodes = new List<string> { "N", "DAT", "F", "S" }, PartOfSpeech = "n" },
                                new Word { Greek = "μεγάλῃ", Transliteration = "", Gloss = "loud", GrammarCodes = new List<string> { "ADJ", "DAT", "F", "S" }, PartOfSpeech = "adj" }
                            },
                            Translation = "with a loud voice"
                        },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "COND_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "εἴ", Transliteration = "", Gloss = "If", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "τις", Transliteration = "", Gloss = "anyone", GrammarCodes = new List<string> { "PRON", "NOM", "M", "S" }, PartOfSpeech = "pronoun" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "προσκυνεῖ", Transliteration = "", Gloss = "worships", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὸ", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "N", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "θηρίον", Transliteration = "", Gloss = "beast", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" }
                                            },
                                            Translation = "the beast"
                                        },
                                        new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὴν", Transliteration = "", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "εἰκόνα", Transliteration = "", Gloss = "image", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                                new Word { Greek = "αὐτοῦ", Transliteration = "", Gloss = "its", GrammarCodes = new List<string> { "PRON", "GEN", "N", "S" }, PartOfSpeech = "pronoun" }
                                            },
                                            Translation = "its image"
                                        }
                                    },
                                    Translation = "worships the beast and its image"
                                },
                                new Word { Greek = "καὶ", Transliteration = "", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "VERB_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "λαμβάνει", Transliteration = "", Gloss = "receives", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                                        new Word { Greek = "χάραγμα", Transliteration = "", Gloss = "a mark", GrammarCodes = new List<string> { "N", "ACC", "N", "S" }, PartOfSpeech = "n" },
                                        new Phrase
                                        {
                                            Content = new List<object>
                                            {
                               
