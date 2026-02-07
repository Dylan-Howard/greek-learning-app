// seed-database.js
const axios = require('axios');

const API_BASE_URL = 'http://localhost:5000/api';

// Helper function to make API calls
async function apiCall(method, endpoint, data = null) {
    try {
        const config = {
            method,
            url: `${API_BASE_URL}${endpoint}`,
            headers: { 'Content-Type': 'application/json' },
        };
        if (data) {
            config.data = data;
        }
        const response = await axios(config);
        return response.data;
    } catch (error) {
        console.error(`Error calling ${endpoint}:`, error.response?.data || error.message);
        throw error;
    }
}

// Grammatical Features
const grammaticalFeatures = [
    { code: "N", name: "Noun", category: "part_of_speech", definition: "A person, place, thing, or idea", sortOrder: 1 },
    { code: "V", name: "Verb", category: "part_of_speech", definition: "An action or state of being", sortOrder: 2 },
    { code: "ADJ", name: "Adjective", category: "part_of_speech", definition: "Describes a noun", sortOrder: 3 },
    { code: "ART", name: "Article", category: "part_of_speech", definition: "Definite or indefinite article", sortOrder: 4 },
    { code: "PRON", name: "Pronoun", category: "part_of_speech", definition: "Replaces a noun", sortOrder: 5 },
    { code: "PREP", name: "Preposition", category: "part_of_speech", definition: "Shows relationship between words", sortOrder: 6 },
    { code: "CONJ", name: "Conjunction", category: "part_of_speech", definition: "Connects words or clauses", sortOrder: 7 },
    { code: "ADV", name: "Adverb", category: "part_of_speech", definition: "Describes a verb, adjective, or adverb", sortOrder: 8 },
    { code: "PART", name: "Particle", category: "part_of_speech", definition: "Adds emphasis or nuance", sortOrder: 9 },
    { code: "NOM", name: "Nominative", category: "case", definition: "Subject case", sortOrder: 20 },
    { code: "GEN", name: "Genitive", category: "case", definition: "Possessive case", sortOrder: 21 },
    { code: "DAT", name: "Dative", category: "case", definition: "Indirect object case", sortOrder: 22 },
    { code: "ACC", name: "Accusative", category: "case", definition: "Direct object case", sortOrder: 23 },
    { code: "VOC", name: "Vocative", category: "case", definition: "Direct address case", sortOrder: 24 },
    { code: "M", name: "Masculine", category: "gender", definition: "Masculine gender", sortOrder: 30 },
    { code: "F", name: "Feminine", category: "gender", definition: "Feminine gender", sortOrder: 31 },
    { code: "NEU", name: "Neuter", category: "gender", definition: "Neuter gender", sortOrder: 32 },
    { code: "S", name: "Singular", category: "number", definition: "Singular number", sortOrder: 40 },
    { code: "P", name: "Plural", category: "number", definition: "Plural number", sortOrder: 41 },
    { code: "PRES", name: "Present", category: "tense", definition: "Present tense", sortOrder: 50 },
    { code: "IMPF", name: "Imperfect", category: "tense", definition: "Imperfect tense", sortOrder: 51 },
    { code: "FUT", name: "Future", category: "tense", definition: "Future tense", sortOrder: 52 },
    { code: "AOR", name: "Aorist", category: "tense", definition: "Aorist tense", sortOrder: 53 },
    { code: "PERF", name: "Perfect", category: "tense", definition: "Perfect tense", sortOrder: 54 },
    { code: "PLUP", name: "Pluperfect", category: "tense", definition: "Pluperfect tense", sortOrder: 55 },
    { code: "ACT", name: "Active", category: "voice", definition: "Active voice", sortOrder: 60 },
    { code: "MID", name: "Middle", category: "voice", definition: "Middle voice", sortOrder: 61 },
    { code: "PASS", name: "Passive", category: "voice", definition: "Passive voice", sortOrder: 62 },
    { code: "IND", name: "Indicative", category: "mood", definition: "Indicative mood", sortOrder: 70 },
    { code: "SUBJ", name: "Subjunctive", category: "mood", definition: "Subjunctive mood", sortOrder: 71 },
    { code: "IMP", name: "Imperative", category: "mood", definition: "Imperative mood", sortOrder: 73 },
    { code: "INF", name: "Infinitive", category: "mood", definition: "Infinitive mood", sortOrder: 74 },
    { code: "PTCP", name: "Participle", category: "mood", definition: "Participle", sortOrder: 75 },
    { code: "1P", name: "First Person", category: "person", definition: "First person", sortOrder: 80 },
    { code: "2P", name: "Second Person", category: "person", definition: "Second person", sortOrder: 81 },
    { code: "3P", name: "Third Person", category: "person", definition: "Third person", sortOrder: 82 }
];

// Syntactical Features
const syntacticalFeatures = [
    { code: "SUBJ", name: "Subject", definition: "The subject of the clause", sortOrder: 1 },
    { code: "PRED", name: "Predicate", definition: "The predicate of the clause", sortOrder: 2 },
    { code: "OBJ", name: "Object", definition: "Direct or indirect object", sortOrder: 3 },
    { code: "ATTR", name: "Attributive", definition: "Attributive modifier", sortOrder: 4 },
    { code: "PREP_PHRASE", name: "Prepositional Phrase", definition: "Phrase beginning with preposition", sortOrder: 5 },
    { code: "REL_CLAUSE", name: "Relative Clause", definition: "Relative clause", sortOrder: 6 },
    { code: "SUBORD_CLAUSE", name: "Subordinate Clause", definition: "Subordinate clause", sortOrder: 7 },
    { code: "COORD", name: "Coordination", definition: "Coordinated elements", sortOrder: 8 },
    { code: "NOUN_PHRASE", name: "Noun Phrase", definition: "Noun with modifiers", sortOrder: 10 },
    { code: "VERB_PHRASE", name: "Verb Phrase", definition: "Verb with complements", sortOrder: 11 },
    { code: "INDEP_CLAUSE", name: "Independent Clause", definition: "Main independent clause", sortOrder: 13 },
    { code: "PURPOSE_CLAUSE", name: "Purpose Clause", definition: "Purpose clause", sortOrder: 15 }
];

// Vocabulary
const vocabulary = [
    { root: "ὁ", transliteration: "ho", gloss: "the", partOfSpeech: "article", frequencyRank: 1 },
    { root: "καί", transliteration: "kai", gloss: "and", partOfSpeech: "conjunction", frequencyRank: 4 },
    { root: "ἐστιν", transliteration: "estin", gloss: "is", partOfSpeech: "verb", frequencyRank: 5 },
    { root: "θεός", transliteration: "theos", gloss: "God", partOfSpeech: "noun", frequencyRank: 6 },
    { root: "Ἰησοῦς", transliteration: "Iēsous", gloss: "Jesus", partOfSpeech: "noun", frequencyRank: 7 },
    { root: "Χριστός", transliteration: "Christos", gloss: "Christ", partOfSpeech: "noun", frequencyRank: 8 },
    { root: "ἀγάπη", transliteration: "agapē", gloss: "love", partOfSpeech: "noun", frequencyRank: 9 },
    { root: "ζωή", transliteration: "zōē", gloss: "life", partOfSpeech: "noun", frequencyRank: 10 },
    { root: "φῶς", transliteration: "phōs", gloss: "light", partOfSpeech: "noun", frequencyRank: 11 },
    { root: "ἀρχή", transliteration: "archē", gloss: "beginning", partOfSpeech: "noun", frequencyRank: 12 },
    { root: "λόγος", transliteration: "logos", gloss: "word", partOfSpeech: "noun", frequencyRank: 13 },
    { root: "πατήρ", transliteration: "patēr", gloss: "father", partOfSpeech: "noun", frequencyRank: 14 },
    { root: "πνεῦμα", transliteration: "pneuma", gloss: "spirit", partOfSpeech: "noun", frequencyRank: 16 },
    { root: "ἁμαρτία", transliteration: "hamartia", gloss: "sin", partOfSpeech: "noun", frequencyRank: 19 },
    { root: "ὀφθαλμός", transliteration: "ophthalmos", gloss: "eye", partOfSpeech: "noun", frequencyRank: 21 },
    { root: "χαρά", transliteration: "chara", gloss: "joy", partOfSpeech: "noun", frequencyRank: 22 },
    { root: "ἀγγελία", transliteration: "angelia", gloss: "message", partOfSpeech: "noun", frequencyRank: 23 },
    { root: "παράκλητος", transliteration: "paraklētos", gloss: "advocate", partOfSpeech: "noun", frequencyRank: 24 },
    { root: "τεκνίον", transliteration: "teknion", gloss: "little child", partOfSpeech: "noun", frequencyRank: 25 },
    { root: "εἰμί", transliteration: "eimi", gloss: "to be", partOfSpeech: "verb", frequencyRank: 26 },
    { root: "γράφω", transliteration: "graphō", gloss: "to write", partOfSpeech: "verb", frequencyRank: 27 },
    { root: "ἀκούω", transliteration: "akouō", gloss: "to hear", partOfSpeech: "verb", frequencyRank: 28 },
    { root: "ὁράω", transliteration: "horaō", gloss: "to see", partOfSpeech: "verb", frequencyRank: 29 },
    { root: "ἔχω", transliteration: "echō", gloss: "to have", partOfSpeech: "verb", frequencyRank: 30 },
    { root: "πιστεύω", transliteration: "pisteuō", gloss: "to believe", partOfSpeech: "verb", frequencyRank: 34 },
    { root: "ἀγαπάω", transliteration: "agapaō", gloss: "to love", partOfSpeech: "verb", frequencyRank: 35 },
    { root: "ἁμαρτάνω", transliteration: "hamartanō", gloss: "to sin", partOfSpeech: "verb", frequencyRank: 38 },
    { root: "ἀπό", transliteration: "apo", gloss: "from", partOfSpeech: "preposition", frequencyRank: 41 },
    { root: "ἐκ", transliteration: "ek", gloss: "from/out of", partOfSpeech: "preposition", frequencyRank: 42 },
    { root: "ἐν", transliteration: "en", gloss: "in", partOfSpeech: "preposition", frequencyRank: 43 },
    { root: "ὅτι", transliteration: "hoti", gloss: "that/because", partOfSpeech: "conjunction", frequencyRank: 45 },
    { root: "ἵνα", transliteration: "hina", gloss: "so that", partOfSpeech: "conjunction", frequencyRank: 46 },
    { root: "ἐάν", transliteration: "ean", gloss: "if", partOfSpeech: "conjunction", frequencyRank: 47 },
    { root: "ὅς", transliteration: "hos", gloss: "who/which", partOfSpeech: "pronoun", frequencyRank: 48 },
    { root: "τίς", transliteration: "tis", gloss: "who/anyone", partOfSpeech: "pronoun", frequencyRank: 49 },
    { root: "ἡμεῖς", transliteration: "hēmeis", gloss: "we", partOfSpeech: "pronoun", frequencyRank: 52 },
    { root: "ὑμεῖς", transliteration: "humeis", gloss: "you (pl)", partOfSpeech: "pronoun", frequencyRank: 53 },
    { root: "οὗτος", transliteration: "houtos", gloss: "this", partOfSpeech: "pronoun", frequencyRank: 54 },
    { root: "πᾶς", transliteration: "pas", gloss: "all/every", partOfSpeech: "adjective", frequencyRank: 55 },
    { root: "ἀγαπητός", transliteration: "agapētos", gloss: "beloved", partOfSpeech: "adjective", frequencyRank: 56 },
    { root: "μή", transliteration: "mē", gloss: "not", partOfSpeech: "particle", frequencyRank: 58 },
    { root: "ταῦτα", transliteration: "tauta", gloss: "these things", partOfSpeech: "pronoun", frequencyRank: 60 },
    { root: "ὑμῖν", transliteration: "hymin", gloss: "to you", partOfSpeech: "pronoun", frequencyRank: 61 },
    { root: "ἡμῶν", transliteration: "hēmōn", gloss: "our", partOfSpeech: "pronoun", frequencyRank: 62 },
    { root: "μου", transliteration: "mou", gloss: "my", partOfSpeech: "pronoun", frequencyRank: 63 },
    { root: "τοῖς", transliteration: "tois", gloss: "the (dat pl)", partOfSpeech: "article", frequencyRank: 64 },
    { root: "ἡμῖν", transliteration: "hēmin", gloss: "to us", partOfSpeech: "pronoun", frequencyRank: 65 },
    { root: "αὕτη", transliteration: "hautē", gloss: "this (fem)", partOfSpeech: "pronoun", frequencyRank: 66 },
    { root: "ποταπήν", transliteration: "potapēn", gloss: "what kind of", partOfSpeech: "adjective", frequencyRank: 67 },
    { root: "παντί", transliteration: "panti", gloss: "every (dat)", partOfSpeech: "adjective", frequencyRank: 68 }
];

// 1 John Chapter Data with unit trees
const chapter1Units = [
    {
        type: "unit",
        path: "0",
        synFeatureIds: null,  // Will be set after features are created
        translation: "That which was from the beginning, which we have heard, which we have seen with our eyes",
        children: [
            {
                type: "unit",
                path: "0.0",
                vocabId: null,  // Will be set after vocab is created
                root: "Ὃ",
                gramFeatureIds: null,  // Will be set
                translation: "That which"
            },
            {
                type: "unit",
                path: "0.1",
                vocabId: null,
                root: "ἦν",
                gramFeatureIds: null,
                translation: "was"
            },
            {
                type: "unit",
                path: "0.2",
                synFeatureIds: null,
                translation: "from the beginning",
                children: [
                    {
                        type: "unit",
                        path: "0.2.0",
                        vocabId: null,
                        root: "ἀπ'",
                        gramFeatureIds: null,
                        translation: "from"
                    },
                    {
                        type: "unit",
                        path: "0.2.1",
                        vocabId: null,
                        root: "ἀρχῆς",
                        gramFeatureIds: null,
                        translation: "beginning"
                    }
                ]
            }
        ]
    }
];

const chapter2Units = [
    {
        type: "unit",
        path: "0",
        synFeatureIds: null,
        translation: "My little children, I write these things to you",
        children: [
            {
                type: "unit",
                path: "0.0",
                vocabId: null,
                root: "Τεκνία",
                gramFeatureIds: null,
                translation: "Little children"
            },
            {
                type: "unit",
                path: "0.1",
                vocabId: null,
                root: "μου",
                gramFeatureIds: null,
                translation: "my"
            }
        ]
    }
];

const chapter3Units = [
    {
        type: "unit",
        path: "0",
        synFeatureIds: null,
        translation: "See what kind of love the Father has given to us",
        children: []
    }
];

const chapter4Units = [
    {
        type: "unit",
        path: "0",
        synFeatureIds: null,
        translation: "Beloved, do not believe every spirit",
        children: []
    }
];

const chapter5Units = [
    {
        type: "unit",
        path: "0",
        synFeatureIds: null,
        translation: "Everyone believing that Jesus is the Christ has been born from God",
        children: []
    }
];

// Main seeding function
async function seedDatabase() {
    console.log('Starting database seeding...\n');

    try {
        // 1. Create Grammatical Features
        console.log('Creating grammatical features...');
        const gramFeatureMap = {};
        for (const feature of grammaticalFeatures) {
            const created = await apiCall('POST', '/grammatical-features', feature);
            gramFeatureMap[feature.code] = created.id;
            console.log(`  Created: ${feature.code} (ID: ${created.id})`);
        }

        // 2. Create Syntactical Features
        console.log('\nCreating syntactical features...');
        const synFeatureMap = {};
        for (const feature of syntacticalFeatures) {
            const created = await apiCall('POST', '/syntactical-features', feature);
            synFeatureMap[feature.code] = created.id;
            console.log(`  Created: ${feature.code} (ID: ${created.id})`);
        }

        // 3. Create Vocabulary
        console.log('\nCreating vocabulary...');
        const vocabMap = {};
        for (const vocab of vocabulary) {
            const created = await apiCall('POST', '/vocabulary', vocab);
            vocabMap[vocab.root] = created.id;
            console.log(`  Created: ${vocab.root} (ID: ${created.id})`);
        }

        // 4. Create Book
        console.log('\nCreating book: 1 John...');
        const book = await apiCall('POST', '/books', {
            title: "1 John",
            languageCode: "grc"
        });
        console.log(`  Created book with ID: ${book.id}`);

        // 5. Create Chapters with unit trees
        console.log('\nCreating chapters...');
        const chapters = [
            { index: 1, title: "Chapter 1", units: chapter1Units },
            { index: 2, title: "Chapter 2", units: chapter2Units },
            { index: 3, title: "Chapter 3", units: chapter3Units },
            { index: 4, title: "Chapter 4", units: chapter4Units },
            { index: 5, title: "Chapter 5", units: chapter5Units }
        ];

        const chapterIds = [];
        for (const chapter of chapters) {
            const created = await apiCall('POST', `/books/${book.id}/chapters`, {
                chapterIndex: chapter.index,
                title: chapter.title,
                unitTree: chapter.units
            });
            chapterIds.push(created.id);
            console.log(`  Created: ${chapter.title} (ID: ${created.id})`);
        }

        // 6. Create Translation
        console.log('\nCreating English translation...');
        const translation = await apiCall('POST', `/books/${book.id}/translations`, {
            languageCode: "en",
            name: "ESV"
        });
        console.log(`  Created translation with ID: ${translation.id}`);

        // 7. Create Lessons (one for each grammatical and syntactical feature)
        console.log('\nCreating lessons...');
        let lessonIndex = 1;

        // Grammatical feature lessons
        for (const [code, id] of Object.entries(gramFeatureMap)) {
            const feature = grammaticalFeatures.find(f => f.code === code);
            await apiCall('POST', '/lessons', {
                title: `Test Lesson: ${feature.name}`,
                lessonIndex: lessonIndex++,
                contentMarkdown: `# ${feature.name}\n\n${feature.definition}\n\nThis is a test lesson for the grammatical feature: **${feature.name}** (${code}).`,
                lessonType: "grammar",
                grammaticalFeatureIds: [id],
                syntacticalFeatureIds: [],
                vocabularyIds: []
            });
            console.log(`  Created lesson: Test Lesson: ${feature.name}`);
        }

        // Syntactical feature lessons
        for (const [code, id] of Object.entries(synFeatureMap)) {
            const feature = syntacticalFeatures.find(f => f.code === code);
            await apiCall('POST', '/lessons', {
                title: `Test Lesson: ${feature.name}`,
                lessonIndex: lessonIndex++,
                contentMarkdown: `# ${feature.name}\n\n${feature.definition}\n\nThis is a test lesson for the syntactical feature: **${feature.name}** (${code}).`,
                lessonType: "syntax",
                grammaticalFeatureIds: [],
                syntacticalFeatureIds: [id],
                vocabularyIds: []
            });
            console.log(`  Created lesson: Test Lesson: ${feature.name}`);
        }

        // 8. Create Test Users
        console.log('\nCreating test users...');
        
        // User 1: Beginner - knows only basic parts of speech
        const user1 = await apiCall('POST', '/auth/register', {
            email: "beginner@test.com",
            username: "beginner",
            password: "password123"
        });
        console.log(`  Created user: beginner (ID: ${user1.id})`);
        
        // Set beginner progress
        const beginnerProgress = {
            completedLessonIds: [1, 2, 3, 4, 5], // Basic parts of speech
            grammaticalFeatureProgress: {},
            syntacticalFeatureProgress: {},
            vocabularyProgress: {}
        };
        
        // Add basic grammar features with 80% mastery
        ['N', 'V', 'ART', 'PRON', 'CONJ'].forEach(code => {
            if (gramFeatureMap[code]) {
                beginnerProgress.grammaticalFeatureProgress[gramFeatureMap[code]] = {
                    masteryLevel: 80,
                    needsPractice: false,
                    lastPracticed: new Date().toISOString()
                };
            }
        });
        
        // Add basic vocabulary
        ['ὁ', 'καί', 'θεός'].forEach(root => {
            if (vocabMap[root]) {
                beginnerProgress.vocabularyProgress[vocabMap[root]] = {
                    masteryLevel: 75,
                    needsPractice: false,
                    lastPracticed: new Date().toISOString(),
                    timesSeen: 10
                };
            }
        });

        // User 2: Intermediate - knows grammar but limited syntax
        const user2 = await apiCall('POST', '/auth/register', {
            email: "intermediate@test.com",
            username: "intermediate",
            password: "password123"
        });
        console.log(`  Created user: intermediate (ID: ${user2.id})`);
        
        const intermediateProgress = {
            completedLessonIds: [],
            grammaticalFeatureProgress: {},
            syntacticalFeatureProgress: {},
            vocabularyProgress: {}
        };
        
        // All grammar features at varying levels
        Object.entries(gramFeatureMap).forEach(([code, id]) => {
            intermediateProgress.grammaticalFeatureProgress[id] = {
                masteryLevel: Math.floor(Math.random() * 30) + 60, // 60-90%
                needsPractice: Math.random() > 0.7,
                lastPracticed: new Date().toISOString()
            };
        });
        
        // Basic syntax features
        ['SUBJ', 'PRED', 'OBJ', 'NOUN_PHRASE'].forEach(code => {
            if (synFeatureMap[code]) {
                intermediateProgress.syntacticalFeatureProgress[synFeatureMap[code]] = {
                    masteryLevel: 70,
                    needsPractice: false,
                    lastPracticed: new Date().toISOString()
                };
            }
        });
        
        // Most vocabulary
        Object.values(vocabMap).slice(0, 20).forEach(id => {
            intermediateProgress.vocabularyProgress[id] = {
                masteryLevel: Math.floor(Math.random() * 20) + 70,
                needsPractice: Math.random() > 0.8,
                lastPracticed: new Date().toISOString(),
                timesSeen: Math.floor(Math.random() * 50) + 20
            };
        });

        // User 3: Advanced - knows most features
        const user3 = await apiCall('POST', '/auth/register', {
            email: "advanced@test.com",
            username: "advanced",
            password: "password123"
        });
        console.log(`  Created user: advanced (ID: ${user3.id})`);
        
        const advancedProgress = {
            completedLessonIds: [],
            grammaticalFeatureProgress: {},
            syntacticalFeatureProgress: {},
            vocabularyProgress: {}
        };
        
        // All grammar features at high levels
        Object.values(gramFeatureMap).forEach(id => {
            advancedProgress.grammaticalFeatureProgress[id] = {
                masteryLevel: Math.floor(Math.random() * 15) + 85, // 85-100%
                needsPractice: false,
                lastPracticed: new Date().toISOString()
            };
        });
        
        // All syntax features at high levels
        Object.values(synFeatureMap).forEach(id => {
            advancedProgress.syntacticalFeatureProgress[id] = {
                masteryLevel: Math.floor(Math.random() * 15) + 85,
                needsPractice: false,
                lastPracticed: new Date().toISOString()
            };
        });
        
        // All vocabulary
        Object.values(vocabMap).forEach(id => {
            advancedProgress.vocabularyProgress[id] = {
                masteryLevel: Math.floor(Math.random() * 10) + 90,
                needsPractice: false,
                lastPracticed: new Date().toISOString(),
                timesSeen: Math.floor(Math.random() * 100) + 50
            };
        });

        // User 4: Struggling learner - knows some but needs practice
        const user4 = await apiCall('POST', '/auth/register', {
            email: "struggling@test.com",
            username: "struggling",
            password: "password123"
        });
        console.log(`  Created user: struggling (ID: ${user4.id})`);
        
        const strugglingProgress = {
            completedLessonIds: [],
            grammaticalFeatureProgress: {},
            syntacticalFeatureProgress: {},
            vocabularyProgress: {}
        };
        
        // Some grammar features with low mastery and needs practice
        Object.entries(gramFeatureMap).slice(0, 15).forEach(([code, id]) => {
            strugglingProgress.grammaticalFeatureProgress[id] = {
                masteryLevel: Math.floor(Math.random() * 30) + 40, // 40-70%
                needsPractice: true,
                lastPracticed: new Date().toISOString()
            };
        });
        
        // Few syntax features
        Object.values(synFeatureMap).slice(0, 5).forEach(id => {
            strugglingProgress.syntacticalFeatureProgress[id] = {
                masteryLevel: Math.floor(Math.random() * 20) + 50,
                needsPractice: true,
                lastPracticed: new Date().toISOString()
            };
        });
        
        // Limited vocabulary with low mastery
        Object.values(vocabMap).slice(0, 15).forEach(id => {
            strugglingProgress.vocabularyProgress[id] = {
                masteryLevel: Math.floor(Math.random() * 30) + 40,
                needsPractice: true,
                lastPracticed: new Date().toISOString(),
                timesSeen: Math.floor(Math.random() * 15) + 5
            };
        });

        console.log('\n✅ Database seeding completed successfully!');
        console.log('\nTest Users Created:');
        console.log('1. beginner@test.com / password123 - Knows basic parts of speech');
        console.log('2. intermediate@test.com / password123 - Knows grammar, limited syntax');
        console.log('3. advanced@test.com / password123 - Knows most features');
        console.log('4. struggling@test.com / password123 - Needs practice on basics');
        
    } catch (error) {
        console.error('\n❌ Error during seeding:', error.message);
        process.exit(1);
    }
}

// Run the seeding
seedDatabase();