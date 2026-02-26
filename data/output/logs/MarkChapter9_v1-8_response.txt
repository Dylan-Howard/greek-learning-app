private static List<object> GetChapter9()
{
    // Mark 9:1-8
    return new List<object>
    {
        // Verse 1
        new Phrase
        {
            SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
            Content = new List<object>
            {
                new Word { Greek = "Καὶ", Transliteration = "Kai", Gloss = "and", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                new Word { Greek = "ἔλεγεν", Transliteration = "elegen", Gloss = "he was saying", GrammarCodes = new List<string> { "V", "IMPF", "ACT", "IND", "3P", "S" }, PartOfSpeech = "v" },
                new Word { Greek = "αὐτοῖς", Transliteration = "autois", Gloss = "to them", GrammarCodes = new List<string> { "PRON", "DAT", "M", "P" }, PartOfSpeech = "prep" },
                new Phrase
                {
                    SyntaxCodes = new List<string> { "INDEP_CLAUSE" },
                    Content = new List<object>
                    {
                        new Word { Greek = "ἀμὴν", Transliteration = "amēn", Gloss = "truly", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "h" },
                        new Word { Greek = "λέγω", Transliteration = "legō", Gloss = "I say", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "1P", "S" }, PartOfSpeech = "v" },
                        new Word { Greek = "ὑμῖν", Transliteration = "hymin", Gloss = "to you", GrammarCodes = new List<string> { "PRON", "DAT", "2P", "P" }, PartOfSpeech = "prep" },
                        new Phrase
                        {
                            SyntaxCodes = new List<string> { "DEP_CLAUSE" },
                            Content = new List<object>
                            {
                                new Word { Greek = "ὅτι", Transliteration = "hoti", Gloss = "that", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                new Word { Greek = "εἰσίν", Transliteration = "eisin", Gloss = "there are", GrammarCodes = new List<string> { "V", "PRES", "ACT", "IND", "3P", "P" }, PartOfSpeech = "v" },
                                new Word { Greek = "τινες", Transliteration = "tines", Gloss = "some", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "part" },
                                new Word { Greek = "ὧδε", Transliteration = "hōde", Gloss = "here", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "adj" },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "τῶν", Transliteration = "tōn", Gloss = "of those", GrammarCodes = new List<string> { "ART", "GEN", "M", "P" }, PartOfSpeech = "art" },
                                        new Word { Greek = "ἑστηκότων", Transliteration = "hestēkotōn", Gloss = "standing", GrammarCodes = new List<string> { "V", "PERF", "ACT", "PTCP", "GEN", "M", "P" }, PartOfSpeech = "v" }
                                    },
                                    Translation = "of those standing"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "REL_CLAUSE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "οἵτινες", Transliteration = "hoitines", Gloss = "who", GrammarCodes = new List<string> { "PRON", "NOM", "M", "P" }, PartOfSpeech = "pron" },
                                        new Word { Greek = "οὐ", Transliteration = "ou", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "μὴ", Transliteration = "mē", Gloss = "not", GrammarCodes = new List<string> { "ADV" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "γεύσωνται", Transliteration = "geusōntai", Gloss = "shall taste", GrammarCodes = new List<string> { "V", "AOR", "MID", "SUBJ", "3P", "P" }, PartOfSpeech = "v" },
                                        new Word { Greek = "θανάτου", Transliteration = "thanatou", Gloss = "of death", GrammarCodes = new List<string> { "N", "GEN", "M", "S" }, PartOfSpeech = "n" }
                                    },
                                    Translation = "who shall by no means taste of death"
                                },
                                new Phrase
                                {
                                    SyntaxCodes = new List<string> { "TEMP_CLAUSE" },
                                    Content = new List<object>
                                    {
                                        new Word { Greek = "ἕως", Transliteration = "heōs", Gloss = "until", GrammarCodes = new List<string> { "CONJ" }, PartOfSpeech = "conj" },
                                        new Word { Greek = "ἂν", Transliteration = "an", Gloss = "ever", GrammarCodes = new List<string> { "PART" }, PartOfSpeech = "prep" },
                                        new Word { Greek = "ἴδωσιν", Transliteration = "idōsin", Gloss = "they see", GrammarCodes = new List<string> { "V", "AOR", "ACT", "SUBJ", "3P", "P" }, PartOfSpeech = "v" },
                                        new Phrase
                                        {
                                            SyntaxCodes = new List<string> { "NOUN_PHRASE", "OBJ" },
                                            Content = new List<object>
                                            {
                                                new Word { Greek = "τὴν", Transliteration = "tēn", Gloss = "the", GrammarCodes = new List<string> { "ART", "ACC", "F", "S" }, PartOfSpeech = "art" },
                                                new Word { Greek = "βασιλείαν", Transliteration = "basileian", Gloss = "kingdom", GrammarCodes = new List<string> { "N", "ACC", "F", "S" }, PartOfSpeech = "n" },
                                                new Phrase
                                                {
                                                    SyntaxCodes = new List<string> { "NOUN_PHRASE" },
                                                    Content = new List<object>
