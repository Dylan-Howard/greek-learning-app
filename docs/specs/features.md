# Feature Specifications

## 1. Reader
The Reader is the core interactive component for studying Ancient Greek texts.

### Key Functionality
- **Text Rendering**: High-fidelity display of Greek NT/OT text with proper diacritics and spacing.
- **Morphology Lookup**: Clicking a word triggers an asynchronous lookup of its morphological features (Parsing: Case, Number, Gender, Tense, Mood, Voice).
- **Translation Display**: Users can toggle between various translations or view interlinear data for individual words or phrases.
- **Navigation**: Simple chapter-based and book-based navigation (e.g., Matthew 1 -> Matthew 2).
- **Personalization**: Highlighting words based on the user's known vocabulary or study status.

### Core Entities
- `Book`, `Chapter`, `TranslationUnit`, `Word`, `GrammaticalFeature`, `SyntacticalFeature`.

---

## 2. Flashcards (SRS)
The Flashcards feature uses a Spaced Repetition System (SRS) to help users memorize vocabulary.

### Key Functionality
- **Vocabulary Sets**: Users can subscribe to pre-defined sets (e.g., "Mounce Chapter 3", "Top 50 Nouns").
- **SRS Algorithm**: Tracks user performance (e.g., 0-5 rating) and calculates the next review date based on a spaced repetition algorithm (e.g., SM-2).
- **Study Sessions**: Interactive sessions where cards are presented, flipped, and rated.
- **Progress Analytics**: Visual feedback on mastery levels and review schedules.

### Core Entities
- `Vocabulary`, `VocabularySet`, `VocabularySetItem`, `UserCardProgress`, `StudySession`.

---

## 3. Lessons
Structured learning tracks that guide the user through Greek grammar and syntax.

### Key Functionality
- **Lesson Tracks**: Curated paths of learning (e.g., "Introduction to Nouns", "The Active Indicative System").
- **Content Blocks**: Lessons consist of explanations, examples, and interactive exercises.
- **Completion Tracking**: Users earn progress badges and unlock subsequent lessons upon completion.
- **Integration**: Lessons often link to specific texts in the Reader for practical application.

### Core Entities
- `Lesson`, `LessonTrack`, `LessonCompletion`.

---

## 4. Practice
General drills and translation exercises outside of formal lessons.

### Key Functionality
- **Grammar Drills**: Targeted practice on specific concepts (e.g., "Identify the Genitive case in these 10 sentences").
- **Translation Exercises**: Translating short phrases or verses from Greek to English (or vice versa) with immediate feedback.
- **Vocabulary Quizzes**: Simple multiple-choice or written quizzes for active recall.

### Core Entities
- `UserProgress`, `StudySession`, `UserSetting`.
