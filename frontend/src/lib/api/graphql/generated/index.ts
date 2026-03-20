import { gql } from '@apollo/client';
import * as Apollo from '@apollo/client';
export type Maybe<T> = T | null;
export type InputMaybe<T> = Maybe<T>;
export type Exact<T extends { [key: string]: unknown }> = { [K in keyof T]: T[K] };
export type MakeOptional<T, K extends keyof T> = Omit<T, K> & { [SubKey in K]?: Maybe<T[SubKey]> };
export type MakeMaybe<T, K extends keyof T> = Omit<T, K> & { [SubKey in K]: Maybe<T[SubKey]> };
export type MakeEmpty<T extends { [key: string]: unknown }, K extends keyof T> = { [_ in K]?: never };
export type Incremental<T> = T | { [P in keyof T]?: P extends ' $fragmentName' | '__typename' ? T[P] : never };
const defaultOptions = {} as const;
/** All built-in and custom scalars, mapped to their actual values */
export type Scalars = {
  ID: { input: string; output: string; }
  String: { input: string; output: string; }
  Boolean: { input: boolean; output: boolean; }
  Int: { input: number; output: number; }
  Float: { input: number; output: number; }
};

/** A book in the corpus (e.g. a NT book). */
export type Book = {
  __typename?: 'Book';
  chapterCount: Scalars['Int']['output'];
  /** Chapters in this book, resolved via ChaptersByBookIdDataLoader. */
  chapters: Array<Chapter>;
  id: Scalars['Int']['output'];
  languageCode: Scalars['String']['output'];
  title: Scalars['String']['output'];
};

/** Spaced-repetition progress record for a single vocabulary card. */
export type CardProgress = {
  __typename?: 'CardProgress';
  difficulty: Scalars['Float']['output'];
  gloss: Scalars['String']['output'];
  lapses: Scalars['Int']['output'];
  nextReviewDate: Scalars['String']['output'];
  reviewCount: Scalars['Int']['output'];
  root: Scalars['String']['output'];
  stability: Scalars['Float']['output'];
  state: Scalars['String']['output'];
  vocabularyId: Scalars['Int']['output'];
};

/** A chapter within a book, containing a tree of rendered units. */
export type Chapter = {
  __typename?: 'Chapter';
  bookId: Scalars['Int']['output'];
  chapterIndex: Scalars['Int']['output'];
  createdAt: Scalars['String']['output'];
  id: Scalars['Int']['output'];
  title?: Maybe<Scalars['String']['output']>;
  /** Words in this chapter, resolved via WordsByChapterIdDataLoader. */
  words: Array<Word>;
};

/** Input for marking a lesson as completed. */
export type CompleteLessonInput = {
  /** ID of the lesson being completed. */
  lessonId: Scalars['Int']['input'];
  /** Optional score achieved in the lesson (0–100). */
  score?: InputMaybe<Scalars['Int']['input']>;
};

/** Input for creating a new book in the corpus. */
export type CreateBookInput = {
  /** BCP-47 language code (e.g. 'grc' for Ancient Greek). */
  languageCode: Scalars['String']['input'];
  /** Display title of the book. */
  title: Scalars['String']['input'];
};

/** Input for creating a new chapter within a book. */
export type CreateChapterInput = {
  /** 1-based position of the chapter within the book. */
  chapterIndex: Scalars['Int']['input'];
  /** Optional display title for the chapter. */
  title?: InputMaybe<Scalars['String']['input']>;
};

/** Input for adding a new vocabulary word to the corpus. */
export type CreateVocabularyInput = {
  /** English gloss (short definition). */
  gloss: Scalars['String']['input'];
  /** Number of occurrences in the corpus. */
  occurrences?: InputMaybe<Scalars['Int']['input']>;
  /** Grammatical part of speech (e.g. noun, verb). */
  partOfSpeech?: InputMaybe<Scalars['String']['input']>;
  /** Greek root form of the word. */
  root: Scalars['String']['input'];
  /** Optional Latin transliteration. */
  transliteration?: InputMaybe<Scalars['String']['input']>;
};

/** Input for creating a new user vocabulary set. */
export type CreateVocabularySetInput = {
  /** Short description of the set's content or purpose. */
  description: Scalars['String']['input'];
  /** Display title for the vocabulary set. */
  title: Scalars['String']['input'];
  /** IDs of vocabulary words to include in the set. */
  vocabularyIds: Array<Scalars['Int']['input']>;
};

/** Study dashboard showing card counts and review history for the current user. */
export type Dashboard = {
  __typename?: 'Dashboard';
  currentStreak: Scalars['Int']['output'];
  dueToday: Scalars['Int']['output'];
  learningCards: Scalars['Int']['output'];
  newCards: Scalars['Int']['output'];
  relearningCards: Scalars['Int']['output'];
  reviewCards: Scalars['Int']['output'];
  reviewHistory: Array<ReviewHistoryPoint>;
  totalCards: Scalars['Int']['output'];
};

/** A single lesson within a lesson track. */
export type Lesson = {
  __typename?: 'Lesson';
  contentMarkdown: Scalars['String']['output'];
  grammaticalFeatureIds: Array<Scalars['Int']['output']>;
  id: Scalars['Int']['output'];
  isCompleted: Scalars['Boolean']['output'];
  lessonIndex: Scalars['Int']['output'];
  lessonType: Scalars['String']['output'];
  slug: Scalars['String']['output'];
  syntacticalFeatureIds: Array<Scalars['Int']['output']>;
  title: Scalars['String']['output'];
  trackId: Scalars['Int']['output'];
  trackSlug: Scalars['String']['output'];
  vocabularyIds: Array<Scalars['Int']['output']>;
};

/** Result returned after a user completes a lesson. */
export type LessonCompletionResult = {
  __typename?: 'LessonCompletionResult';
  firstCompletion: Scalars['Boolean']['output'];
  message: Scalars['String']['output'];
  totalExperience: Scalars['Int']['output'];
  xpGained: Scalars['Int']['output'];
};

/** An ordered collection of lessons forming a study track. */
export type LessonTrack = {
  __typename?: 'LessonTrack';
  completedLessons: Scalars['Int']['output'];
  description: Scalars['String']['output'];
  id: Scalars['Int']['output'];
  lessons: Array<Lesson>;
  nextLessonId?: Maybe<Scalars['Int']['output']>;
  nextLessonSlug?: Maybe<Scalars['String']['output']>;
  nextLessonTitle?: Maybe<Scalars['String']['output']>;
  percentComplete: Scalars['Float']['output'];
  slug: Scalars['String']['output'];
  sortOrder: Scalars['Int']['output'];
  title: Scalars['String']['output'];
  totalLessons: Scalars['Int']['output'];
};

/** Root mutation type for the Koine GraphQL API. */
export type Mutation = {
  __typename?: 'Mutation';
  /** Adds a vocabulary word to a set owned by the authenticated user. */
  addVocabularyToSet: Scalars['Boolean']['output'];
  /** Marks a lesson as completed for the authenticated user. */
  completeLesson?: Maybe<LessonCompletionResult>;
  /** Completes the given study session and returns a summary. */
  completeStudySession?: Maybe<SessionSummary>;
  /** Creates a new book in the corpus. Requires admin role. */
  createBook: Book;
  /** Creates a new chapter within a book. Requires admin role. */
  createChapter: Chapter;
  /** Adds a new vocabulary word to the corpus. Requires admin role. */
  createVocabulary: VocabularyResult;
  /** Creates a new vocabulary set for the authenticated user. */
  createVocabularySet: VocabularySet;
  /** Deletes a book from the corpus. Requires admin role. */
  deleteBook: Scalars['Boolean']['output'];
  /** Deletes a chapter. Requires admin role. */
  deleteChapter: Scalars['Boolean']['output'];
  /** Deletes a vocabulary word from the corpus. Requires admin role. */
  deleteVocabulary: Scalars['Boolean']['output'];
  /** Deletes a vocabulary set owned by the authenticated user. */
  deleteVocabularySet: Scalars['Boolean']['output'];
  /** Records a rating for a card in the given session. */
  rateCard?: Maybe<RateCardResult>;
  /** Removes a vocabulary word from a set owned by the authenticated user. */
  removeVocabularyFromSet: Scalars['Boolean']['output'];
  /** Starts a new spaced-repetition study session for the authenticated user. */
  startStudySession: Session;
  /** Updates an existing book. Requires admin role. */
  updateBook?: Maybe<Book>;
  /** Updates an existing chapter. Requires admin role. */
  updateChapter?: Maybe<Chapter>;
  /** Updates the authenticated user's overall progress record. */
  updateProgress: Scalars['Boolean']['output'];
  /** Updates an existing vocabulary word. Requires admin role. */
  updateVocabulary?: Maybe<VocabularyResult>;
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationAddVocabularyToSetArgs = {
  setId: Scalars['Int']['input'];
  vocabularyId: Scalars['Int']['input'];
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationCompleteLessonArgs = {
  input: CompleteLessonInput;
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationCompleteStudySessionArgs = {
  sessionId: Scalars['ID']['input'];
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationCreateBookArgs = {
  input: CreateBookInput;
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationCreateChapterArgs = {
  bookId: Scalars['Int']['input'];
  input: CreateChapterInput;
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationCreateVocabularyArgs = {
  input: CreateVocabularyInput;
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationCreateVocabularySetArgs = {
  input: CreateVocabularySetInput;
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationDeleteBookArgs = {
  id: Scalars['Int']['input'];
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationDeleteChapterArgs = {
  id: Scalars['Int']['input'];
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationDeleteVocabularyArgs = {
  id: Scalars['Int']['input'];
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationDeleteVocabularySetArgs = {
  id: Scalars['Int']['input'];
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationRateCardArgs = {
  rating: Scalars['Int']['input'];
  sessionId: Scalars['ID']['input'];
  vocabularyId: Scalars['Int']['input'];
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationRemoveVocabularyFromSetArgs = {
  setId: Scalars['Int']['input'];
  vocabularyId: Scalars['Int']['input'];
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationStartStudySessionArgs = {
  input: StartSessionInput;
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationUpdateBookArgs = {
  id: Scalars['Int']['input'];
  input: UpdateBookInput;
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationUpdateChapterArgs = {
  id: Scalars['Int']['input'];
  input: UpdateChapterInput;
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationUpdateProgressArgs = {
  input: UserProgressInput;
};


/** Root mutation type for the Koine GraphQL API. */
export type MutationUpdateVocabularyArgs = {
  id: Scalars['Int']['input'];
  input: UpdateVocabularyInput;
};

/** Root query type for the Koine GraphQL API. */
export type Query = {
  __typename?: 'Query';
  /** A single book by its integer ID, or null if not found. */
  book?: Maybe<Book>;
  /** All books in the corpus. */
  books?: Maybe<Array<Maybe<Book>>>;
  /** All chapters belonging to the specified book. */
  chapters?: Maybe<Array<Maybe<Chapter>>>;
  /** A single lesson by its ID, with completion status for the authenticated user. */
  lessonById?: Maybe<Lesson>;
  /** All lesson tracks with completion metadata for the authenticated user. */
  lessonTracks: Array<LessonTrack>;
  /** All lessons for the authenticated user, with completion status. */
  lessons?: Maybe<Array<Maybe<Lesson>>>;
  /** All lessons within a specific track for the authenticated user. */
  lessonsByTrack: Array<Lesson>;
  /** The next incomplete lesson in a track for the authenticated user, or null if all complete. */
  nextLesson?: Maybe<Lesson>;
  /** Aggregated progress record for the authenticated user. */
  progress?: Maybe<UserProgress>;
  /** Renders a chapter for reading, with optional language override. */
  reader?: Maybe<RenderedChapter>;
  /** Study dashboard with card counts and review history for the authenticated user. */
  studyDashboard: Dashboard;
  /** Card-level SRS progress records for the authenticated user. */
  studyProgress: Array<CardProgress>;
  /** All vocabulary sets belonging to the authenticated user. */
  studySets?: Maybe<Array<Maybe<VocabularySet>>>;
  /** All lessons the authenticated user has interacted with, with completion status. */
  userLessons: Array<Lesson>;
  /** Vocabulary words, optionally filtered by occurrence count. */
  vocabulary?: Maybe<Array<Maybe<Word>>>;
};


/** Root query type for the Koine GraphQL API. */
export type QueryBookArgs = {
  id: Scalars['Int']['input'];
};


/** Root query type for the Koine GraphQL API. */
export type QueryChaptersArgs = {
  bookId: Scalars['Int']['input'];
};


/** Root query type for the Koine GraphQL API. */
export type QueryLessonByIdArgs = {
  id: Scalars['Int']['input'];
};


/** Root query type for the Koine GraphQL API. */
export type QueryLessonsByTrackArgs = {
  trackSlug: Scalars['String']['input'];
};


/** Root query type for the Koine GraphQL API. */
export type QueryNextLessonArgs = {
  trackSlug: Scalars['String']['input'];
};


/** Root query type for the Koine GraphQL API. */
export type QueryReaderArgs = {
  bookId: Scalars['Int']['input'];
  chapterNumber: Scalars['Int']['input'];
  lang?: InputMaybe<Scalars['String']['input']>;
};


/** Root query type for the Koine GraphQL API. */
export type QueryVocabularyArgs = {
  comparison?: InputMaybe<Scalars['String']['input']>;
  occurrences?: InputMaybe<Scalars['Int']['input']>;
};

/** Result returned after rating a flashcard, including the next scheduled review. */
export type RateCardResult = {
  __typename?: 'RateCardResult';
  newState: Scalars['String']['output'];
  nextReviewDate: Scalars['String']['output'];
  scheduledDays: Scalars['Float']['output'];
  sessionComplete: Scalars['Boolean']['output'];
};

/** A fully rendered chapter with its tree of display units. */
export type RenderedChapter = {
  __typename?: 'RenderedChapter';
  chapterId: Scalars['Int']['output'];
  title: Scalars['String']['output'];
  units: Array<RenderedUnit>;
};

/** A single rendered unit node within a chapter (word, phrase, or structural marker). */
export type RenderedUnit = {
  __typename?: 'RenderedUnit';
  children: Array<RenderedUnit>;
  gramFeatureIds: Array<Scalars['Int']['output']>;
  hints: Array<Scalars['String']['output']>;
  marker?: Maybe<Scalars['String']['output']>;
  original?: Maybe<Scalars['String']['output']>;
  path?: Maybe<Scalars['String']['output']>;
  synFeatureIds: Array<Scalars['Int']['output']>;
  text?: Maybe<Scalars['String']['output']>;
  type: Scalars['String']['output'];
  vocabId?: Maybe<Scalars['Int']['output']>;
};

/** The number of cards reviewed on a specific date. */
export type ReviewHistoryPoint = {
  __typename?: 'ReviewHistoryPoint';
  count: Scalars['Int']['output'];
  date: Scalars['String']['output'];
};

/** An active or completed spaced-repetition study session. */
export type Session = {
  __typename?: 'Session';
  cardsReviewed: Scalars['Int']['output'];
  completedAt?: Maybe<Scalars['String']['output']>;
  direction: Scalars['String']['output'];
  id: Scalars['ID']['output'];
  mode: Scalars['String']['output'];
  pool: Scalars['String']['output'];
  startedAt: Scalars['String']['output'];
  totalCards: Scalars['Int']['output'];
  vocabularySetId?: Maybe<Scalars['Int']['output']>;
};

/** Summary statistics returned when a study session is completed. */
export type SessionSummary = {
  __typename?: 'SessionSummary';
  correctCount: Scalars['Int']['output'];
  correctPercentage: Scalars['Float']['output'];
  firstCompletionReward: Scalars['Boolean']['output'];
  totalExperience: Scalars['Int']['output'];
  totalReviewed: Scalars['Int']['output'];
  xpGained: Scalars['Int']['output'];
};

/** Input for starting a new spaced-repetition study session. */
export type StartSessionInput = {
  /** Number of cards to include (-1 for all due cards). Defaults to 10. */
  cardCount?: InputMaybe<Scalars['Int']['input']>;
  /** Study direction (e.g. GreekToEnglish, EnglishToGreek). */
  direction: Scalars['String']['input'];
  /** Interaction mode (e.g. Flashcard, MultipleChoice, Mix). */
  mode: Scalars['String']['input'];
  /** Card pool to draw from (e.g. Mixed, NewOnly, DueOnly). */
  pool: Scalars['String']['input'];
  /** Session source (e.g. StandardStudy, VocabularySet). */
  source: Scalars['String']['input'];
  /** Optional explicit list of vocabulary IDs to study. */
  vocabularyIds?: InputMaybe<Array<Scalars['Int']['input']>>;
  /** Optional vocabulary set to restrict cards to. */
  vocabularySetId?: InputMaybe<Scalars['Int']['input']>;
};

/** Input for updating an existing book. All fields are optional. */
export type UpdateBookInput = {
  /** New BCP-47 language code. */
  languageCode?: InputMaybe<Scalars['String']['input']>;
  /** New display title for the book. */
  title?: InputMaybe<Scalars['String']['input']>;
};

/** Input for updating an existing chapter. All fields are optional. */
export type UpdateChapterInput = {
  /** New 1-based position of the chapter within the book. */
  chapterIndex?: InputMaybe<Scalars['Int']['input']>;
  /** New display title for the chapter. */
  title?: InputMaybe<Scalars['String']['input']>;
};

/** Input for updating an existing vocabulary word. All fields are optional. */
export type UpdateVocabularyInput = {
  /** New English gloss. */
  gloss?: InputMaybe<Scalars['String']['input']>;
  /** Updated occurrence count. */
  occurrences?: InputMaybe<Scalars['Int']['input']>;
  /** New part of speech. */
  partOfSpeech?: InputMaybe<Scalars['String']['input']>;
  /** New Greek root form. */
  root?: InputMaybe<Scalars['String']['input']>;
  /** New Latin transliteration. */
  transliteration?: InputMaybe<Scalars['String']['input']>;
};

/** Aggregated progress record for an authenticated user. */
export type UserProgress = {
  __typename?: 'UserProgress';
  completedLessonIds: Array<Scalars['Int']['output']>;
  totalExperience: Scalars['Int']['output'];
  updatedAt: Scalars['String']['output'];
};

/** Input for updating a user's overall progress record. */
export type UserProgressInput = {
  /** Full list of lesson IDs the user has completed. */
  completedLessonIds: Array<Scalars['Int']['input']>;
  /** Total XP accumulated by the user. */
  totalExperience: Scalars['Int']['input'];
};

/** A full vocabulary record returned from admin create/update operations. */
export type VocabularyResult = {
  __typename?: 'VocabularyResult';
  gloss: Scalars['String']['output'];
  id: Scalars['Int']['output'];
  occurrences?: Maybe<Scalars['Int']['output']>;
  partOfSpeech?: Maybe<Scalars['String']['output']>;
  root: Scalars['String']['output'];
  transliteration?: Maybe<Scalars['String']['output']>;
};

/** A named collection of vocabulary words used for spaced-repetition study. */
export type VocabularySet = {
  __typename?: 'VocabularySet';
  bookId?: Maybe<Scalars['Int']['output']>;
  createdAt: Scalars['String']['output'];
  description: Scalars['String']['output'];
  id: Scalars['Int']['output'];
  isSystem: Scalars['Boolean']['output'];
  items: Array<VocabularySetItem>;
  knownCount: Scalars['Int']['output'];
  lastPracticed?: Maybe<Scalars['String']['output']>;
  learningCount: Scalars['Int']['output'];
  ownerUserId?: Maybe<Scalars['Int']['output']>;
  percentComplete: Scalars['Float']['output'];
  slug: Scalars['String']['output'];
  title: Scalars['String']['output'];
  totalCount: Scalars['Int']['output'];
};

/** A single vocabulary item within a vocabulary set, including mastery state. */
export type VocabularySetItem = {
  __typename?: 'VocabularySetItem';
  gloss: Scalars['String']['output'];
  id: Scalars['Int']['output'];
  lastSeen?: Maybe<Scalars['String']['output']>;
  masteryLevel: Scalars['Int']['output'];
  root: Scalars['String']['output'];
  vocabularyId: Scalars['Int']['output'];
};

/** A vocabulary word with its gloss and occurrence count. */
export type Word = {
  __typename?: 'Word';
  gloss: Scalars['String']['output'];
  id: Scalars['Int']['output'];
  occurrences: Scalars['Int']['output'];
  root: Scalars['String']['output'];
};

export type CreateBookMutationVariables = Exact<{
  input: CreateBookInput;
}>;


export type CreateBookMutation = { __typename?: 'Mutation', createBook: { __typename?: 'Book', id: number, title: string, languageCode: string, chapterCount: number } };

export type UpdateBookMutationVariables = Exact<{
  id: Scalars['Int']['input'];
  input: UpdateBookInput;
}>;


export type UpdateBookMutation = { __typename?: 'Mutation', updateBook?: { __typename?: 'Book', id: number, title: string, languageCode: string, chapterCount: number } | null };

export type DeleteBookMutationVariables = Exact<{
  id: Scalars['Int']['input'];
}>;


export type DeleteBookMutation = { __typename?: 'Mutation', deleteBook: boolean };

export type CreateChapterMutationVariables = Exact<{
  bookId: Scalars['Int']['input'];
  input: CreateChapterInput;
}>;


export type CreateChapterMutation = { __typename?: 'Mutation', createChapter: { __typename?: 'Chapter', id: number, bookId: number, chapterIndex: number, title?: string | null, createdAt: string } };

export type UpdateChapterMutationVariables = Exact<{
  id: Scalars['Int']['input'];
  input: UpdateChapterInput;
}>;


export type UpdateChapterMutation = { __typename?: 'Mutation', updateChapter?: { __typename?: 'Chapter', id: number, bookId: number, chapterIndex: number, title?: string | null, createdAt: string } | null };

export type DeleteChapterMutationVariables = Exact<{
  id: Scalars['Int']['input'];
}>;


export type DeleteChapterMutation = { __typename?: 'Mutation', deleteChapter: boolean };

export type CreateVocabularyMutationVariables = Exact<{
  input: CreateVocabularyInput;
}>;


export type CreateVocabularyMutation = { __typename?: 'Mutation', createVocabulary: { __typename?: 'VocabularyResult', id: number, root: string, transliteration?: string | null, gloss: string, partOfSpeech?: string | null, occurrences?: number | null } };

export type UpdateVocabularyMutationVariables = Exact<{
  id: Scalars['Int']['input'];
  input: UpdateVocabularyInput;
}>;


export type UpdateVocabularyMutation = { __typename?: 'Mutation', updateVocabulary?: { __typename?: 'VocabularyResult', id: number, root: string, transliteration?: string | null, gloss: string, partOfSpeech?: string | null, occurrences?: number | null } | null };

export type DeleteVocabularyMutationVariables = Exact<{
  id: Scalars['Int']['input'];
}>;


export type DeleteVocabularyMutation = { __typename?: 'Mutation', deleteVocabulary: boolean };

export type CompleteLessonMutationVariables = Exact<{
  input: CompleteLessonInput;
}>;


export type CompleteLessonMutation = { __typename?: 'Mutation', completeLesson?: { __typename?: 'LessonCompletionResult', message: string, xpGained: number, totalExperience: number, firstCompletion: boolean } | null };

export type UpdateProgressMutationVariables = Exact<{
  input: UserProgressInput;
}>;


export type UpdateProgressMutation = { __typename?: 'Mutation', updateProgress: boolean };

export type StartStudySessionMutationVariables = Exact<{
  input: StartSessionInput;
}>;


export type StartStudySessionMutation = { __typename?: 'Mutation', startStudySession: { __typename?: 'Session', id: string, totalCards: number, cardsReviewed: number, startedAt: string, completedAt?: string | null, pool: string, direction: string, mode: string, vocabularySetId?: number | null } };

export type RateCardMutationVariables = Exact<{
  sessionId: Scalars['ID']['input'];
  vocabularyId: Scalars['Int']['input'];
  rating: Scalars['Int']['input'];
}>;


export type RateCardMutation = { __typename?: 'Mutation', rateCard?: { __typename?: 'RateCardResult', nextReviewDate: string, scheduledDays: number, newState: string, sessionComplete: boolean } | null };

export type CompleteStudySessionMutationVariables = Exact<{
  sessionId: Scalars['ID']['input'];
}>;


export type CompleteStudySessionMutation = { __typename?: 'Mutation', completeStudySession?: { __typename?: 'SessionSummary', totalReviewed: number, correctCount: number, correctPercentage: number, xpGained: number, totalExperience: number, firstCompletionReward: boolean } | null };

export type CreateVocabularySetMutationVariables = Exact<{
  input: CreateVocabularySetInput;
}>;


export type CreateVocabularySetMutation = { __typename?: 'Mutation', createVocabularySet: { __typename?: 'VocabularySet', id: number, slug: string, title: string, description: string, isSystem: boolean, totalCount: number, knownCount: number, learningCount: number, percentComplete: number, createdAt: string, items: Array<{ __typename?: 'VocabularySetItem', id: number, vocabularyId: number, root: string, gloss: string, masteryLevel: number, lastSeen?: string | null }> } };

export type DeleteVocabularySetMutationVariables = Exact<{
  id: Scalars['Int']['input'];
}>;


export type DeleteVocabularySetMutation = { __typename?: 'Mutation', deleteVocabularySet: boolean };

export type AddVocabularyToSetMutationVariables = Exact<{
  setId: Scalars['Int']['input'];
  vocabularyId: Scalars['Int']['input'];
}>;


export type AddVocabularyToSetMutation = { __typename?: 'Mutation', addVocabularyToSet: boolean };

export type RemoveVocabularyFromSetMutationVariables = Exact<{
  setId: Scalars['Int']['input'];
  vocabularyId: Scalars['Int']['input'];
}>;


export type RemoveVocabularyFromSetMutation = { __typename?: 'Mutation', removeVocabularyFromSet: boolean };

export type GetBooksQueryVariables = Exact<{ [key: string]: never; }>;


export type GetBooksQuery = { __typename?: 'Query', books?: Array<{ __typename?: 'Book', id: number, title: string, languageCode: string, chapterCount: number } | null> | null };

export type GetBookQueryVariables = Exact<{
  id: Scalars['Int']['input'];
}>;


export type GetBookQuery = { __typename?: 'Query', book?: { __typename?: 'Book', id: number, title: string, languageCode: string, chapterCount: number, chapters: Array<{ __typename?: 'Chapter', id: number, bookId: number, chapterIndex: number, title?: string | null, createdAt: string }> } | null };

export type GetLessonTracksQueryVariables = Exact<{ [key: string]: never; }>;


export type GetLessonTracksQuery = { __typename?: 'Query', lessonTracks: Array<{ __typename?: 'LessonTrack', id: number, slug: string, title: string, description: string, sortOrder: number, totalLessons: number, completedLessons: number, percentComplete: number, nextLessonId?: number | null, nextLessonSlug?: string | null, nextLessonTitle?: string | null }> };

export type GetLessonsByTrackQueryVariables = Exact<{
  trackSlug: Scalars['String']['input'];
}>;


export type GetLessonsByTrackQuery = { __typename?: 'Query', lessonsByTrack: Array<{ __typename?: 'Lesson', id: number, trackId: number, trackSlug: string, slug: string, title: string, lessonIndex: number, lessonType: string, isCompleted: boolean, grammaticalFeatureIds: Array<number>, syntacticalFeatureIds: Array<number>, vocabularyIds: Array<number> }> };

export type GetNextLessonQueryVariables = Exact<{
  trackSlug: Scalars['String']['input'];
}>;


export type GetNextLessonQuery = { __typename?: 'Query', nextLesson?: { __typename?: 'Lesson', id: number, trackId: number, trackSlug: string, slug: string, title: string, lessonIndex: number, contentMarkdown: string, lessonType: string, isCompleted: boolean, grammaticalFeatureIds: Array<number>, syntacticalFeatureIds: Array<number>, vocabularyIds: Array<number> } | null };

export type GetLessonByIdQueryVariables = Exact<{
  id: Scalars['Int']['input'];
}>;


export type GetLessonByIdQuery = { __typename?: 'Query', lessonById?: { __typename?: 'Lesson', id: number, trackId: number, trackSlug: string, slug: string, title: string, lessonIndex: number, contentMarkdown: string, lessonType: string, isCompleted: boolean, grammaticalFeatureIds: Array<number>, syntacticalFeatureIds: Array<number>, vocabularyIds: Array<number> } | null };

export type GetUserProgressQueryVariables = Exact<{ [key: string]: never; }>;


export type GetUserProgressQuery = { __typename?: 'Query', progress?: { __typename?: 'UserProgress', completedLessonIds: Array<number>, totalExperience: number, updatedAt: string } | null };

export type GetUserLessonsQueryVariables = Exact<{ [key: string]: never; }>;


export type GetUserLessonsQuery = { __typename?: 'Query', userLessons: Array<{ __typename?: 'Lesson', id: number, trackId: number, trackSlug: string, slug: string, title: string, lessonIndex: number, lessonType: string, isCompleted: boolean }> };

export type GetUserVocabularyQueryVariables = Exact<{ [key: string]: never; }>;


export type GetUserVocabularyQuery = { __typename?: 'Query', studyProgress: Array<{ __typename?: 'CardProgress', vocabularyId: number, root: string, gloss: string, state: string, difficulty: number, stability: number, nextReviewDate: string, reviewCount: number, lapses: number }> };

export type FetchChapterQueryVariables = Exact<{
  bookId: Scalars['Int']['input'];
  chapterNumber: Scalars['Int']['input'];
  lang?: InputMaybe<Scalars['String']['input']>;
}>;


export type FetchChapterQuery = { __typename?: 'Query', reader?: { __typename?: 'RenderedChapter', chapterId: number, title: string, units: Array<{ __typename?: 'RenderedUnit', type: string, text?: string | null, original?: string | null, path?: string | null, marker?: string | null, vocabId?: number | null, hints: Array<string>, gramFeatureIds: Array<number>, synFeatureIds: Array<number>, children: Array<{ __typename?: 'RenderedUnit', type: string, text?: string | null, original?: string | null, path?: string | null, marker?: string | null, vocabId?: number | null, hints: Array<string>, gramFeatureIds: Array<number>, synFeatureIds: Array<number>, children: Array<{ __typename?: 'RenderedUnit', type: string, text?: string | null, original?: string | null, path?: string | null, marker?: string | null, vocabId?: number | null, hints: Array<string>, gramFeatureIds: Array<number>, synFeatureIds: Array<number> }> }> }> } | null };

export type GetStudyDashboardQueryVariables = Exact<{ [key: string]: never; }>;


export type GetStudyDashboardQuery = { __typename?: 'Query', studyDashboard: { __typename?: 'Dashboard', totalCards: number, dueToday: number, newCards: number, learningCards: number, reviewCards: number, relearningCards: number, currentStreak: number, reviewHistory: Array<{ __typename?: 'ReviewHistoryPoint', date: string, count: number }> } };

export type GetStudyProgressQueryVariables = Exact<{ [key: string]: never; }>;


export type GetStudyProgressQuery = { __typename?: 'Query', studyProgress: Array<{ __typename?: 'CardProgress', vocabularyId: number, root: string, gloss: string, state: string, difficulty: number, stability: number, nextReviewDate: string, reviewCount: number, lapses: number }> };

export type GetVocabularySetsQueryVariables = Exact<{ [key: string]: never; }>;


export type GetVocabularySetsQuery = { __typename?: 'Query', studySets?: Array<{ __typename?: 'VocabularySet', id: number, ownerUserId?: number | null, isSystem: boolean, slug: string, bookId?: number | null, title: string, description: string, createdAt: string, lastPracticed?: string | null, totalCount: number, knownCount: number, learningCount: number, percentComplete: number, items: Array<{ __typename?: 'VocabularySetItem', id: number, vocabularyId: number, root: string, gloss: string, masteryLevel: number, lastSeen?: string | null }> } | null> | null };

export type GetVocabularyQueryVariables = Exact<{
  occurrences?: InputMaybe<Scalars['Int']['input']>;
  comparison?: InputMaybe<Scalars['String']['input']>;
}>;


export type GetVocabularyQuery = { __typename?: 'Query', vocabulary?: Array<{ __typename?: 'Word', id: number, root: string, gloss: string, occurrences: number } | null> | null };


export const CreateBookDocument = gql`
    mutation CreateBook($input: CreateBookInput!) {
  createBook(input: $input) {
    id
    title
    languageCode
    chapterCount
  }
}
    `;
export type CreateBookMutationFn = Apollo.MutationFunction<CreateBookMutation, CreateBookMutationVariables>;

/**
 * __useCreateBookMutation__
 *
 * To run a mutation, you first call `useCreateBookMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useCreateBookMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [createBookMutation, { data, loading, error }] = useCreateBookMutation({
 *   variables: {
 *      input: // value for 'input'
 *   },
 * });
 */
export function useCreateBookMutation(baseOptions?: Apollo.MutationHookOptions<CreateBookMutation, CreateBookMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<CreateBookMutation, CreateBookMutationVariables>(CreateBookDocument, options);
      }
export type CreateBookMutationHookResult = ReturnType<typeof useCreateBookMutation>;
export type CreateBookMutationResult = Apollo.MutationResult<CreateBookMutation>;
export type CreateBookMutationOptions = Apollo.BaseMutationOptions<CreateBookMutation, CreateBookMutationVariables>;
export const UpdateBookDocument = gql`
    mutation UpdateBook($id: Int!, $input: UpdateBookInput!) {
  updateBook(id: $id, input: $input) {
    id
    title
    languageCode
    chapterCount
  }
}
    `;
export type UpdateBookMutationFn = Apollo.MutationFunction<UpdateBookMutation, UpdateBookMutationVariables>;

/**
 * __useUpdateBookMutation__
 *
 * To run a mutation, you first call `useUpdateBookMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useUpdateBookMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [updateBookMutation, { data, loading, error }] = useUpdateBookMutation({
 *   variables: {
 *      id: // value for 'id'
 *      input: // value for 'input'
 *   },
 * });
 */
export function useUpdateBookMutation(baseOptions?: Apollo.MutationHookOptions<UpdateBookMutation, UpdateBookMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<UpdateBookMutation, UpdateBookMutationVariables>(UpdateBookDocument, options);
      }
export type UpdateBookMutationHookResult = ReturnType<typeof useUpdateBookMutation>;
export type UpdateBookMutationResult = Apollo.MutationResult<UpdateBookMutation>;
export type UpdateBookMutationOptions = Apollo.BaseMutationOptions<UpdateBookMutation, UpdateBookMutationVariables>;
export const DeleteBookDocument = gql`
    mutation DeleteBook($id: Int!) {
  deleteBook(id: $id)
}
    `;
export type DeleteBookMutationFn = Apollo.MutationFunction<DeleteBookMutation, DeleteBookMutationVariables>;

/**
 * __useDeleteBookMutation__
 *
 * To run a mutation, you first call `useDeleteBookMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useDeleteBookMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [deleteBookMutation, { data, loading, error }] = useDeleteBookMutation({
 *   variables: {
 *      id: // value for 'id'
 *   },
 * });
 */
export function useDeleteBookMutation(baseOptions?: Apollo.MutationHookOptions<DeleteBookMutation, DeleteBookMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<DeleteBookMutation, DeleteBookMutationVariables>(DeleteBookDocument, options);
      }
export type DeleteBookMutationHookResult = ReturnType<typeof useDeleteBookMutation>;
export type DeleteBookMutationResult = Apollo.MutationResult<DeleteBookMutation>;
export type DeleteBookMutationOptions = Apollo.BaseMutationOptions<DeleteBookMutation, DeleteBookMutationVariables>;
export const CreateChapterDocument = gql`
    mutation CreateChapter($bookId: Int!, $input: CreateChapterInput!) {
  createChapter(bookId: $bookId, input: $input) {
    id
    bookId
    chapterIndex
    title
    createdAt
  }
}
    `;
export type CreateChapterMutationFn = Apollo.MutationFunction<CreateChapterMutation, CreateChapterMutationVariables>;

/**
 * __useCreateChapterMutation__
 *
 * To run a mutation, you first call `useCreateChapterMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useCreateChapterMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [createChapterMutation, { data, loading, error }] = useCreateChapterMutation({
 *   variables: {
 *      bookId: // value for 'bookId'
 *      input: // value for 'input'
 *   },
 * });
 */
export function useCreateChapterMutation(baseOptions?: Apollo.MutationHookOptions<CreateChapterMutation, CreateChapterMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<CreateChapterMutation, CreateChapterMutationVariables>(CreateChapterDocument, options);
      }
export type CreateChapterMutationHookResult = ReturnType<typeof useCreateChapterMutation>;
export type CreateChapterMutationResult = Apollo.MutationResult<CreateChapterMutation>;
export type CreateChapterMutationOptions = Apollo.BaseMutationOptions<CreateChapterMutation, CreateChapterMutationVariables>;
export const UpdateChapterDocument = gql`
    mutation UpdateChapter($id: Int!, $input: UpdateChapterInput!) {
  updateChapter(id: $id, input: $input) {
    id
    bookId
    chapterIndex
    title
    createdAt
  }
}
    `;
export type UpdateChapterMutationFn = Apollo.MutationFunction<UpdateChapterMutation, UpdateChapterMutationVariables>;

/**
 * __useUpdateChapterMutation__
 *
 * To run a mutation, you first call `useUpdateChapterMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useUpdateChapterMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [updateChapterMutation, { data, loading, error }] = useUpdateChapterMutation({
 *   variables: {
 *      id: // value for 'id'
 *      input: // value for 'input'
 *   },
 * });
 */
export function useUpdateChapterMutation(baseOptions?: Apollo.MutationHookOptions<UpdateChapterMutation, UpdateChapterMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<UpdateChapterMutation, UpdateChapterMutationVariables>(UpdateChapterDocument, options);
      }
export type UpdateChapterMutationHookResult = ReturnType<typeof useUpdateChapterMutation>;
export type UpdateChapterMutationResult = Apollo.MutationResult<UpdateChapterMutation>;
export type UpdateChapterMutationOptions = Apollo.BaseMutationOptions<UpdateChapterMutation, UpdateChapterMutationVariables>;
export const DeleteChapterDocument = gql`
    mutation DeleteChapter($id: Int!) {
  deleteChapter(id: $id)
}
    `;
export type DeleteChapterMutationFn = Apollo.MutationFunction<DeleteChapterMutation, DeleteChapterMutationVariables>;

/**
 * __useDeleteChapterMutation__
 *
 * To run a mutation, you first call `useDeleteChapterMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useDeleteChapterMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [deleteChapterMutation, { data, loading, error }] = useDeleteChapterMutation({
 *   variables: {
 *      id: // value for 'id'
 *   },
 * });
 */
export function useDeleteChapterMutation(baseOptions?: Apollo.MutationHookOptions<DeleteChapterMutation, DeleteChapterMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<DeleteChapterMutation, DeleteChapterMutationVariables>(DeleteChapterDocument, options);
      }
export type DeleteChapterMutationHookResult = ReturnType<typeof useDeleteChapterMutation>;
export type DeleteChapterMutationResult = Apollo.MutationResult<DeleteChapterMutation>;
export type DeleteChapterMutationOptions = Apollo.BaseMutationOptions<DeleteChapterMutation, DeleteChapterMutationVariables>;
export const CreateVocabularyDocument = gql`
    mutation CreateVocabulary($input: CreateVocabularyInput!) {
  createVocabulary(input: $input) {
    id
    root
    transliteration
    gloss
    partOfSpeech
    occurrences
  }
}
    `;
export type CreateVocabularyMutationFn = Apollo.MutationFunction<CreateVocabularyMutation, CreateVocabularyMutationVariables>;

/**
 * __useCreateVocabularyMutation__
 *
 * To run a mutation, you first call `useCreateVocabularyMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useCreateVocabularyMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [createVocabularyMutation, { data, loading, error }] = useCreateVocabularyMutation({
 *   variables: {
 *      input: // value for 'input'
 *   },
 * });
 */
export function useCreateVocabularyMutation(baseOptions?: Apollo.MutationHookOptions<CreateVocabularyMutation, CreateVocabularyMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<CreateVocabularyMutation, CreateVocabularyMutationVariables>(CreateVocabularyDocument, options);
      }
export type CreateVocabularyMutationHookResult = ReturnType<typeof useCreateVocabularyMutation>;
export type CreateVocabularyMutationResult = Apollo.MutationResult<CreateVocabularyMutation>;
export type CreateVocabularyMutationOptions = Apollo.BaseMutationOptions<CreateVocabularyMutation, CreateVocabularyMutationVariables>;
export const UpdateVocabularyDocument = gql`
    mutation UpdateVocabulary($id: Int!, $input: UpdateVocabularyInput!) {
  updateVocabulary(id: $id, input: $input) {
    id
    root
    transliteration
    gloss
    partOfSpeech
    occurrences
  }
}
    `;
export type UpdateVocabularyMutationFn = Apollo.MutationFunction<UpdateVocabularyMutation, UpdateVocabularyMutationVariables>;

/**
 * __useUpdateVocabularyMutation__
 *
 * To run a mutation, you first call `useUpdateVocabularyMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useUpdateVocabularyMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [updateVocabularyMutation, { data, loading, error }] = useUpdateVocabularyMutation({
 *   variables: {
 *      id: // value for 'id'
 *      input: // value for 'input'
 *   },
 * });
 */
export function useUpdateVocabularyMutation(baseOptions?: Apollo.MutationHookOptions<UpdateVocabularyMutation, UpdateVocabularyMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<UpdateVocabularyMutation, UpdateVocabularyMutationVariables>(UpdateVocabularyDocument, options);
      }
export type UpdateVocabularyMutationHookResult = ReturnType<typeof useUpdateVocabularyMutation>;
export type UpdateVocabularyMutationResult = Apollo.MutationResult<UpdateVocabularyMutation>;
export type UpdateVocabularyMutationOptions = Apollo.BaseMutationOptions<UpdateVocabularyMutation, UpdateVocabularyMutationVariables>;
export const DeleteVocabularyDocument = gql`
    mutation DeleteVocabulary($id: Int!) {
  deleteVocabulary(id: $id)
}
    `;
export type DeleteVocabularyMutationFn = Apollo.MutationFunction<DeleteVocabularyMutation, DeleteVocabularyMutationVariables>;

/**
 * __useDeleteVocabularyMutation__
 *
 * To run a mutation, you first call `useDeleteVocabularyMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useDeleteVocabularyMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [deleteVocabularyMutation, { data, loading, error }] = useDeleteVocabularyMutation({
 *   variables: {
 *      id: // value for 'id'
 *   },
 * });
 */
export function useDeleteVocabularyMutation(baseOptions?: Apollo.MutationHookOptions<DeleteVocabularyMutation, DeleteVocabularyMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<DeleteVocabularyMutation, DeleteVocabularyMutationVariables>(DeleteVocabularyDocument, options);
      }
export type DeleteVocabularyMutationHookResult = ReturnType<typeof useDeleteVocabularyMutation>;
export type DeleteVocabularyMutationResult = Apollo.MutationResult<DeleteVocabularyMutation>;
export type DeleteVocabularyMutationOptions = Apollo.BaseMutationOptions<DeleteVocabularyMutation, DeleteVocabularyMutationVariables>;
export const CompleteLessonDocument = gql`
    mutation CompleteLesson($input: CompleteLessonInput!) {
  completeLesson(input: $input) {
    message
    xpGained
    totalExperience
    firstCompletion
  }
}
    `;
export type CompleteLessonMutationFn = Apollo.MutationFunction<CompleteLessonMutation, CompleteLessonMutationVariables>;

/**
 * __useCompleteLessonMutation__
 *
 * To run a mutation, you first call `useCompleteLessonMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useCompleteLessonMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [completeLessonMutation, { data, loading, error }] = useCompleteLessonMutation({
 *   variables: {
 *      input: // value for 'input'
 *   },
 * });
 */
export function useCompleteLessonMutation(baseOptions?: Apollo.MutationHookOptions<CompleteLessonMutation, CompleteLessonMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<CompleteLessonMutation, CompleteLessonMutationVariables>(CompleteLessonDocument, options);
      }
export type CompleteLessonMutationHookResult = ReturnType<typeof useCompleteLessonMutation>;
export type CompleteLessonMutationResult = Apollo.MutationResult<CompleteLessonMutation>;
export type CompleteLessonMutationOptions = Apollo.BaseMutationOptions<CompleteLessonMutation, CompleteLessonMutationVariables>;
export const UpdateProgressDocument = gql`
    mutation UpdateProgress($input: UserProgressInput!) {
  updateProgress(input: $input)
}
    `;
export type UpdateProgressMutationFn = Apollo.MutationFunction<UpdateProgressMutation, UpdateProgressMutationVariables>;

/**
 * __useUpdateProgressMutation__
 *
 * To run a mutation, you first call `useUpdateProgressMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useUpdateProgressMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [updateProgressMutation, { data, loading, error }] = useUpdateProgressMutation({
 *   variables: {
 *      input: // value for 'input'
 *   },
 * });
 */
export function useUpdateProgressMutation(baseOptions?: Apollo.MutationHookOptions<UpdateProgressMutation, UpdateProgressMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<UpdateProgressMutation, UpdateProgressMutationVariables>(UpdateProgressDocument, options);
      }
export type UpdateProgressMutationHookResult = ReturnType<typeof useUpdateProgressMutation>;
export type UpdateProgressMutationResult = Apollo.MutationResult<UpdateProgressMutation>;
export type UpdateProgressMutationOptions = Apollo.BaseMutationOptions<UpdateProgressMutation, UpdateProgressMutationVariables>;
export const StartStudySessionDocument = gql`
    mutation StartStudySession($input: StartSessionInput!) {
  startStudySession(input: $input) {
    id
    totalCards
    cardsReviewed
    startedAt
    completedAt
    pool
    direction
    mode
    vocabularySetId
  }
}
    `;
export type StartStudySessionMutationFn = Apollo.MutationFunction<StartStudySessionMutation, StartStudySessionMutationVariables>;

/**
 * __useStartStudySessionMutation__
 *
 * To run a mutation, you first call `useStartStudySessionMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useStartStudySessionMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [startStudySessionMutation, { data, loading, error }] = useStartStudySessionMutation({
 *   variables: {
 *      input: // value for 'input'
 *   },
 * });
 */
export function useStartStudySessionMutation(baseOptions?: Apollo.MutationHookOptions<StartStudySessionMutation, StartStudySessionMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<StartStudySessionMutation, StartStudySessionMutationVariables>(StartStudySessionDocument, options);
      }
export type StartStudySessionMutationHookResult = ReturnType<typeof useStartStudySessionMutation>;
export type StartStudySessionMutationResult = Apollo.MutationResult<StartStudySessionMutation>;
export type StartStudySessionMutationOptions = Apollo.BaseMutationOptions<StartStudySessionMutation, StartStudySessionMutationVariables>;
export const RateCardDocument = gql`
    mutation RateCard($sessionId: ID!, $vocabularyId: Int!, $rating: Int!) {
  rateCard(sessionId: $sessionId, vocabularyId: $vocabularyId, rating: $rating) {
    nextReviewDate
    scheduledDays
    newState
    sessionComplete
  }
}
    `;
export type RateCardMutationFn = Apollo.MutationFunction<RateCardMutation, RateCardMutationVariables>;

/**
 * __useRateCardMutation__
 *
 * To run a mutation, you first call `useRateCardMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useRateCardMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [rateCardMutation, { data, loading, error }] = useRateCardMutation({
 *   variables: {
 *      sessionId: // value for 'sessionId'
 *      vocabularyId: // value for 'vocabularyId'
 *      rating: // value for 'rating'
 *   },
 * });
 */
export function useRateCardMutation(baseOptions?: Apollo.MutationHookOptions<RateCardMutation, RateCardMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<RateCardMutation, RateCardMutationVariables>(RateCardDocument, options);
      }
export type RateCardMutationHookResult = ReturnType<typeof useRateCardMutation>;
export type RateCardMutationResult = Apollo.MutationResult<RateCardMutation>;
export type RateCardMutationOptions = Apollo.BaseMutationOptions<RateCardMutation, RateCardMutationVariables>;
export const CompleteStudySessionDocument = gql`
    mutation CompleteStudySession($sessionId: ID!) {
  completeStudySession(sessionId: $sessionId) {
    totalReviewed
    correctCount
    correctPercentage
    xpGained
    totalExperience
    firstCompletionReward
  }
}
    `;
export type CompleteStudySessionMutationFn = Apollo.MutationFunction<CompleteStudySessionMutation, CompleteStudySessionMutationVariables>;

/**
 * __useCompleteStudySessionMutation__
 *
 * To run a mutation, you first call `useCompleteStudySessionMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useCompleteStudySessionMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [completeStudySessionMutation, { data, loading, error }] = useCompleteStudySessionMutation({
 *   variables: {
 *      sessionId: // value for 'sessionId'
 *   },
 * });
 */
export function useCompleteStudySessionMutation(baseOptions?: Apollo.MutationHookOptions<CompleteStudySessionMutation, CompleteStudySessionMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<CompleteStudySessionMutation, CompleteStudySessionMutationVariables>(CompleteStudySessionDocument, options);
      }
export type CompleteStudySessionMutationHookResult = ReturnType<typeof useCompleteStudySessionMutation>;
export type CompleteStudySessionMutationResult = Apollo.MutationResult<CompleteStudySessionMutation>;
export type CompleteStudySessionMutationOptions = Apollo.BaseMutationOptions<CompleteStudySessionMutation, CompleteStudySessionMutationVariables>;
export const CreateVocabularySetDocument = gql`
    mutation CreateVocabularySet($input: CreateVocabularySetInput!) {
  createVocabularySet(input: $input) {
    id
    slug
    title
    description
    isSystem
    totalCount
    knownCount
    learningCount
    percentComplete
    createdAt
    items {
      id
      vocabularyId
      root
      gloss
      masteryLevel
      lastSeen
    }
  }
}
    `;
export type CreateVocabularySetMutationFn = Apollo.MutationFunction<CreateVocabularySetMutation, CreateVocabularySetMutationVariables>;

/**
 * __useCreateVocabularySetMutation__
 *
 * To run a mutation, you first call `useCreateVocabularySetMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useCreateVocabularySetMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [createVocabularySetMutation, { data, loading, error }] = useCreateVocabularySetMutation({
 *   variables: {
 *      input: // value for 'input'
 *   },
 * });
 */
export function useCreateVocabularySetMutation(baseOptions?: Apollo.MutationHookOptions<CreateVocabularySetMutation, CreateVocabularySetMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<CreateVocabularySetMutation, CreateVocabularySetMutationVariables>(CreateVocabularySetDocument, options);
      }
export type CreateVocabularySetMutationHookResult = ReturnType<typeof useCreateVocabularySetMutation>;
export type CreateVocabularySetMutationResult = Apollo.MutationResult<CreateVocabularySetMutation>;
export type CreateVocabularySetMutationOptions = Apollo.BaseMutationOptions<CreateVocabularySetMutation, CreateVocabularySetMutationVariables>;
export const DeleteVocabularySetDocument = gql`
    mutation DeleteVocabularySet($id: Int!) {
  deleteVocabularySet(id: $id)
}
    `;
export type DeleteVocabularySetMutationFn = Apollo.MutationFunction<DeleteVocabularySetMutation, DeleteVocabularySetMutationVariables>;

/**
 * __useDeleteVocabularySetMutation__
 *
 * To run a mutation, you first call `useDeleteVocabularySetMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useDeleteVocabularySetMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [deleteVocabularySetMutation, { data, loading, error }] = useDeleteVocabularySetMutation({
 *   variables: {
 *      id: // value for 'id'
 *   },
 * });
 */
export function useDeleteVocabularySetMutation(baseOptions?: Apollo.MutationHookOptions<DeleteVocabularySetMutation, DeleteVocabularySetMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<DeleteVocabularySetMutation, DeleteVocabularySetMutationVariables>(DeleteVocabularySetDocument, options);
      }
export type DeleteVocabularySetMutationHookResult = ReturnType<typeof useDeleteVocabularySetMutation>;
export type DeleteVocabularySetMutationResult = Apollo.MutationResult<DeleteVocabularySetMutation>;
export type DeleteVocabularySetMutationOptions = Apollo.BaseMutationOptions<DeleteVocabularySetMutation, DeleteVocabularySetMutationVariables>;
export const AddVocabularyToSetDocument = gql`
    mutation AddVocabularyToSet($setId: Int!, $vocabularyId: Int!) {
  addVocabularyToSet(setId: $setId, vocabularyId: $vocabularyId)
}
    `;
export type AddVocabularyToSetMutationFn = Apollo.MutationFunction<AddVocabularyToSetMutation, AddVocabularyToSetMutationVariables>;

/**
 * __useAddVocabularyToSetMutation__
 *
 * To run a mutation, you first call `useAddVocabularyToSetMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useAddVocabularyToSetMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [addVocabularyToSetMutation, { data, loading, error }] = useAddVocabularyToSetMutation({
 *   variables: {
 *      setId: // value for 'setId'
 *      vocabularyId: // value for 'vocabularyId'
 *   },
 * });
 */
export function useAddVocabularyToSetMutation(baseOptions?: Apollo.MutationHookOptions<AddVocabularyToSetMutation, AddVocabularyToSetMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<AddVocabularyToSetMutation, AddVocabularyToSetMutationVariables>(AddVocabularyToSetDocument, options);
      }
export type AddVocabularyToSetMutationHookResult = ReturnType<typeof useAddVocabularyToSetMutation>;
export type AddVocabularyToSetMutationResult = Apollo.MutationResult<AddVocabularyToSetMutation>;
export type AddVocabularyToSetMutationOptions = Apollo.BaseMutationOptions<AddVocabularyToSetMutation, AddVocabularyToSetMutationVariables>;
export const RemoveVocabularyFromSetDocument = gql`
    mutation RemoveVocabularyFromSet($setId: Int!, $vocabularyId: Int!) {
  removeVocabularyFromSet(setId: $setId, vocabularyId: $vocabularyId)
}
    `;
export type RemoveVocabularyFromSetMutationFn = Apollo.MutationFunction<RemoveVocabularyFromSetMutation, RemoveVocabularyFromSetMutationVariables>;

/**
 * __useRemoveVocabularyFromSetMutation__
 *
 * To run a mutation, you first call `useRemoveVocabularyFromSetMutation` within a React component and pass it any options that fit your needs.
 * When your component renders, `useRemoveVocabularyFromSetMutation` returns a tuple that includes:
 * - A mutate function that you can call at any time to execute the mutation
 * - An object with fields that represent the current status of the mutation's execution
 *
 * @param baseOptions options that will be passed into the mutation, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options-2;
 *
 * @example
 * const [removeVocabularyFromSetMutation, { data, loading, error }] = useRemoveVocabularyFromSetMutation({
 *   variables: {
 *      setId: // value for 'setId'
 *      vocabularyId: // value for 'vocabularyId'
 *   },
 * });
 */
export function useRemoveVocabularyFromSetMutation(baseOptions?: Apollo.MutationHookOptions<RemoveVocabularyFromSetMutation, RemoveVocabularyFromSetMutationVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useMutation<RemoveVocabularyFromSetMutation, RemoveVocabularyFromSetMutationVariables>(RemoveVocabularyFromSetDocument, options);
      }
export type RemoveVocabularyFromSetMutationHookResult = ReturnType<typeof useRemoveVocabularyFromSetMutation>;
export type RemoveVocabularyFromSetMutationResult = Apollo.MutationResult<RemoveVocabularyFromSetMutation>;
export type RemoveVocabularyFromSetMutationOptions = Apollo.BaseMutationOptions<RemoveVocabularyFromSetMutation, RemoveVocabularyFromSetMutationVariables>;
export const GetBooksDocument = gql`
    query GetBooks {
  books {
    id
    title
    languageCode
    chapterCount
  }
}
    `;

/**
 * __useGetBooksQuery__
 *
 * To run a query within a React component, call `useGetBooksQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetBooksQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetBooksQuery({
 *   variables: {
 *   },
 * });
 */
export function useGetBooksQuery(baseOptions?: Apollo.QueryHookOptions<GetBooksQuery, GetBooksQueryVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetBooksQuery, GetBooksQueryVariables>(GetBooksDocument, options);
      }
export function useGetBooksLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetBooksQuery, GetBooksQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetBooksQuery, GetBooksQueryVariables>(GetBooksDocument, options);
        }
// @ts-ignore
export function useGetBooksSuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetBooksQuery, GetBooksQueryVariables>): Apollo.UseSuspenseQueryResult<GetBooksQuery, GetBooksQueryVariables>;
export function useGetBooksSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetBooksQuery, GetBooksQueryVariables>): Apollo.UseSuspenseQueryResult<GetBooksQuery | undefined, GetBooksQueryVariables>;
export function useGetBooksSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetBooksQuery, GetBooksQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetBooksQuery, GetBooksQueryVariables>(GetBooksDocument, options);
        }
export type GetBooksQueryHookResult = ReturnType<typeof useGetBooksQuery>;
export type GetBooksLazyQueryHookResult = ReturnType<typeof useGetBooksLazyQuery>;
export type GetBooksSuspenseQueryHookResult = ReturnType<typeof useGetBooksSuspenseQuery>;
export type GetBooksQueryResult = Apollo.QueryResult<GetBooksQuery, GetBooksQueryVariables>;
export const GetBookDocument = gql`
    query GetBook($id: Int!) {
  book(id: $id) {
    id
    title
    languageCode
    chapterCount
    chapters {
      id
      bookId
      chapterIndex
      title
      createdAt
    }
  }
}
    `;

/**
 * __useGetBookQuery__
 *
 * To run a query within a React component, call `useGetBookQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetBookQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetBookQuery({
 *   variables: {
 *      id: // value for 'id'
 *   },
 * });
 */
export function useGetBookQuery(baseOptions: Apollo.QueryHookOptions<GetBookQuery, GetBookQueryVariables> & ({ variables: GetBookQueryVariables; skip?: boolean; } | { skip: boolean; }) ) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetBookQuery, GetBookQueryVariables>(GetBookDocument, options);
      }
export function useGetBookLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetBookQuery, GetBookQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetBookQuery, GetBookQueryVariables>(GetBookDocument, options);
        }
// @ts-ignore
export function useGetBookSuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetBookQuery, GetBookQueryVariables>): Apollo.UseSuspenseQueryResult<GetBookQuery, GetBookQueryVariables>;
export function useGetBookSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetBookQuery, GetBookQueryVariables>): Apollo.UseSuspenseQueryResult<GetBookQuery | undefined, GetBookQueryVariables>;
export function useGetBookSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetBookQuery, GetBookQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetBookQuery, GetBookQueryVariables>(GetBookDocument, options);
        }
export type GetBookQueryHookResult = ReturnType<typeof useGetBookQuery>;
export type GetBookLazyQueryHookResult = ReturnType<typeof useGetBookLazyQuery>;
export type GetBookSuspenseQueryHookResult = ReturnType<typeof useGetBookSuspenseQuery>;
export type GetBookQueryResult = Apollo.QueryResult<GetBookQuery, GetBookQueryVariables>;
export const GetLessonTracksDocument = gql`
    query GetLessonTracks {
  lessonTracks {
    id
    slug
    title
    description
    sortOrder
    totalLessons
    completedLessons
    percentComplete
    nextLessonId
    nextLessonSlug
    nextLessonTitle
  }
}
    `;

/**
 * __useGetLessonTracksQuery__
 *
 * To run a query within a React component, call `useGetLessonTracksQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetLessonTracksQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetLessonTracksQuery({
 *   variables: {
 *   },
 * });
 */
export function useGetLessonTracksQuery(baseOptions?: Apollo.QueryHookOptions<GetLessonTracksQuery, GetLessonTracksQueryVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetLessonTracksQuery, GetLessonTracksQueryVariables>(GetLessonTracksDocument, options);
      }
export function useGetLessonTracksLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetLessonTracksQuery, GetLessonTracksQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetLessonTracksQuery, GetLessonTracksQueryVariables>(GetLessonTracksDocument, options);
        }
// @ts-ignore
export function useGetLessonTracksSuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetLessonTracksQuery, GetLessonTracksQueryVariables>): Apollo.UseSuspenseQueryResult<GetLessonTracksQuery, GetLessonTracksQueryVariables>;
export function useGetLessonTracksSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetLessonTracksQuery, GetLessonTracksQueryVariables>): Apollo.UseSuspenseQueryResult<GetLessonTracksQuery | undefined, GetLessonTracksQueryVariables>;
export function useGetLessonTracksSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetLessonTracksQuery, GetLessonTracksQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetLessonTracksQuery, GetLessonTracksQueryVariables>(GetLessonTracksDocument, options);
        }
export type GetLessonTracksQueryHookResult = ReturnType<typeof useGetLessonTracksQuery>;
export type GetLessonTracksLazyQueryHookResult = ReturnType<typeof useGetLessonTracksLazyQuery>;
export type GetLessonTracksSuspenseQueryHookResult = ReturnType<typeof useGetLessonTracksSuspenseQuery>;
export type GetLessonTracksQueryResult = Apollo.QueryResult<GetLessonTracksQuery, GetLessonTracksQueryVariables>;
export const GetLessonsByTrackDocument = gql`
    query GetLessonsByTrack($trackSlug: String!) {
  lessonsByTrack(trackSlug: $trackSlug) {
    id
    trackId
    trackSlug
    slug
    title
    lessonIndex
    lessonType
    isCompleted
    grammaticalFeatureIds
    syntacticalFeatureIds
    vocabularyIds
  }
}
    `;

/**
 * __useGetLessonsByTrackQuery__
 *
 * To run a query within a React component, call `useGetLessonsByTrackQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetLessonsByTrackQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetLessonsByTrackQuery({
 *   variables: {
 *      trackSlug: // value for 'trackSlug'
 *   },
 * });
 */
export function useGetLessonsByTrackQuery(baseOptions: Apollo.QueryHookOptions<GetLessonsByTrackQuery, GetLessonsByTrackQueryVariables> & ({ variables: GetLessonsByTrackQueryVariables; skip?: boolean; } | { skip: boolean; }) ) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetLessonsByTrackQuery, GetLessonsByTrackQueryVariables>(GetLessonsByTrackDocument, options);
      }
export function useGetLessonsByTrackLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetLessonsByTrackQuery, GetLessonsByTrackQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetLessonsByTrackQuery, GetLessonsByTrackQueryVariables>(GetLessonsByTrackDocument, options);
        }
// @ts-ignore
export function useGetLessonsByTrackSuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetLessonsByTrackQuery, GetLessonsByTrackQueryVariables>): Apollo.UseSuspenseQueryResult<GetLessonsByTrackQuery, GetLessonsByTrackQueryVariables>;
export function useGetLessonsByTrackSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetLessonsByTrackQuery, GetLessonsByTrackQueryVariables>): Apollo.UseSuspenseQueryResult<GetLessonsByTrackQuery | undefined, GetLessonsByTrackQueryVariables>;
export function useGetLessonsByTrackSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetLessonsByTrackQuery, GetLessonsByTrackQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetLessonsByTrackQuery, GetLessonsByTrackQueryVariables>(GetLessonsByTrackDocument, options);
        }
export type GetLessonsByTrackQueryHookResult = ReturnType<typeof useGetLessonsByTrackQuery>;
export type GetLessonsByTrackLazyQueryHookResult = ReturnType<typeof useGetLessonsByTrackLazyQuery>;
export type GetLessonsByTrackSuspenseQueryHookResult = ReturnType<typeof useGetLessonsByTrackSuspenseQuery>;
export type GetLessonsByTrackQueryResult = Apollo.QueryResult<GetLessonsByTrackQuery, GetLessonsByTrackQueryVariables>;
export const GetNextLessonDocument = gql`
    query GetNextLesson($trackSlug: String!) {
  nextLesson(trackSlug: $trackSlug) {
    id
    trackId
    trackSlug
    slug
    title
    lessonIndex
    contentMarkdown
    lessonType
    isCompleted
    grammaticalFeatureIds
    syntacticalFeatureIds
    vocabularyIds
  }
}
    `;

/**
 * __useGetNextLessonQuery__
 *
 * To run a query within a React component, call `useGetNextLessonQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetNextLessonQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetNextLessonQuery({
 *   variables: {
 *      trackSlug: // value for 'trackSlug'
 *   },
 * });
 */
export function useGetNextLessonQuery(baseOptions: Apollo.QueryHookOptions<GetNextLessonQuery, GetNextLessonQueryVariables> & ({ variables: GetNextLessonQueryVariables; skip?: boolean; } | { skip: boolean; }) ) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetNextLessonQuery, GetNextLessonQueryVariables>(GetNextLessonDocument, options);
      }
export function useGetNextLessonLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetNextLessonQuery, GetNextLessonQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetNextLessonQuery, GetNextLessonQueryVariables>(GetNextLessonDocument, options);
        }
// @ts-ignore
export function useGetNextLessonSuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetNextLessonQuery, GetNextLessonQueryVariables>): Apollo.UseSuspenseQueryResult<GetNextLessonQuery, GetNextLessonQueryVariables>;
export function useGetNextLessonSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetNextLessonQuery, GetNextLessonQueryVariables>): Apollo.UseSuspenseQueryResult<GetNextLessonQuery | undefined, GetNextLessonQueryVariables>;
export function useGetNextLessonSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetNextLessonQuery, GetNextLessonQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetNextLessonQuery, GetNextLessonQueryVariables>(GetNextLessonDocument, options);
        }
export type GetNextLessonQueryHookResult = ReturnType<typeof useGetNextLessonQuery>;
export type GetNextLessonLazyQueryHookResult = ReturnType<typeof useGetNextLessonLazyQuery>;
export type GetNextLessonSuspenseQueryHookResult = ReturnType<typeof useGetNextLessonSuspenseQuery>;
export type GetNextLessonQueryResult = Apollo.QueryResult<GetNextLessonQuery, GetNextLessonQueryVariables>;
export const GetLessonByIdDocument = gql`
    query GetLessonById($id: Int!) {
  lessonById(id: $id) {
    id
    trackId
    trackSlug
    slug
    title
    lessonIndex
    contentMarkdown
    lessonType
    isCompleted
    grammaticalFeatureIds
    syntacticalFeatureIds
    vocabularyIds
  }
}
    `;

/**
 * __useGetLessonByIdQuery__
 *
 * To run a query within a React component, call `useGetLessonByIdQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetLessonByIdQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetLessonByIdQuery({
 *   variables: {
 *      id: // value for 'id'
 *   },
 * });
 */
export function useGetLessonByIdQuery(baseOptions: Apollo.QueryHookOptions<GetLessonByIdQuery, GetLessonByIdQueryVariables> & ({ variables: GetLessonByIdQueryVariables; skip?: boolean; } | { skip: boolean; }) ) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetLessonByIdQuery, GetLessonByIdQueryVariables>(GetLessonByIdDocument, options);
      }
export function useGetLessonByIdLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetLessonByIdQuery, GetLessonByIdQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetLessonByIdQuery, GetLessonByIdQueryVariables>(GetLessonByIdDocument, options);
        }
// @ts-ignore
export function useGetLessonByIdSuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetLessonByIdQuery, GetLessonByIdQueryVariables>): Apollo.UseSuspenseQueryResult<GetLessonByIdQuery, GetLessonByIdQueryVariables>;
export function useGetLessonByIdSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetLessonByIdQuery, GetLessonByIdQueryVariables>): Apollo.UseSuspenseQueryResult<GetLessonByIdQuery | undefined, GetLessonByIdQueryVariables>;
export function useGetLessonByIdSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetLessonByIdQuery, GetLessonByIdQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetLessonByIdQuery, GetLessonByIdQueryVariables>(GetLessonByIdDocument, options);
        }
export type GetLessonByIdQueryHookResult = ReturnType<typeof useGetLessonByIdQuery>;
export type GetLessonByIdLazyQueryHookResult = ReturnType<typeof useGetLessonByIdLazyQuery>;
export type GetLessonByIdSuspenseQueryHookResult = ReturnType<typeof useGetLessonByIdSuspenseQuery>;
export type GetLessonByIdQueryResult = Apollo.QueryResult<GetLessonByIdQuery, GetLessonByIdQueryVariables>;
export const GetUserProgressDocument = gql`
    query GetUserProgress {
  progress {
    completedLessonIds
    totalExperience
    updatedAt
  }
}
    `;

/**
 * __useGetUserProgressQuery__
 *
 * To run a query within a React component, call `useGetUserProgressQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetUserProgressQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetUserProgressQuery({
 *   variables: {
 *   },
 * });
 */
export function useGetUserProgressQuery(baseOptions?: Apollo.QueryHookOptions<GetUserProgressQuery, GetUserProgressQueryVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetUserProgressQuery, GetUserProgressQueryVariables>(GetUserProgressDocument, options);
      }
export function useGetUserProgressLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetUserProgressQuery, GetUserProgressQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetUserProgressQuery, GetUserProgressQueryVariables>(GetUserProgressDocument, options);
        }
// @ts-ignore
export function useGetUserProgressSuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetUserProgressQuery, GetUserProgressQueryVariables>): Apollo.UseSuspenseQueryResult<GetUserProgressQuery, GetUserProgressQueryVariables>;
export function useGetUserProgressSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetUserProgressQuery, GetUserProgressQueryVariables>): Apollo.UseSuspenseQueryResult<GetUserProgressQuery | undefined, GetUserProgressQueryVariables>;
export function useGetUserProgressSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetUserProgressQuery, GetUserProgressQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetUserProgressQuery, GetUserProgressQueryVariables>(GetUserProgressDocument, options);
        }
export type GetUserProgressQueryHookResult = ReturnType<typeof useGetUserProgressQuery>;
export type GetUserProgressLazyQueryHookResult = ReturnType<typeof useGetUserProgressLazyQuery>;
export type GetUserProgressSuspenseQueryHookResult = ReturnType<typeof useGetUserProgressSuspenseQuery>;
export type GetUserProgressQueryResult = Apollo.QueryResult<GetUserProgressQuery, GetUserProgressQueryVariables>;
export const GetUserLessonsDocument = gql`
    query GetUserLessons {
  userLessons {
    id
    trackId
    trackSlug
    slug
    title
    lessonIndex
    lessonType
    isCompleted
  }
}
    `;

/**
 * __useGetUserLessonsQuery__
 *
 * To run a query within a React component, call `useGetUserLessonsQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetUserLessonsQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetUserLessonsQuery({
 *   variables: {
 *   },
 * });
 */
export function useGetUserLessonsQuery(baseOptions?: Apollo.QueryHookOptions<GetUserLessonsQuery, GetUserLessonsQueryVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetUserLessonsQuery, GetUserLessonsQueryVariables>(GetUserLessonsDocument, options);
      }
export function useGetUserLessonsLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetUserLessonsQuery, GetUserLessonsQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetUserLessonsQuery, GetUserLessonsQueryVariables>(GetUserLessonsDocument, options);
        }
// @ts-ignore
export function useGetUserLessonsSuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetUserLessonsQuery, GetUserLessonsQueryVariables>): Apollo.UseSuspenseQueryResult<GetUserLessonsQuery, GetUserLessonsQueryVariables>;
export function useGetUserLessonsSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetUserLessonsQuery, GetUserLessonsQueryVariables>): Apollo.UseSuspenseQueryResult<GetUserLessonsQuery | undefined, GetUserLessonsQueryVariables>;
export function useGetUserLessonsSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetUserLessonsQuery, GetUserLessonsQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetUserLessonsQuery, GetUserLessonsQueryVariables>(GetUserLessonsDocument, options);
        }
export type GetUserLessonsQueryHookResult = ReturnType<typeof useGetUserLessonsQuery>;
export type GetUserLessonsLazyQueryHookResult = ReturnType<typeof useGetUserLessonsLazyQuery>;
export type GetUserLessonsSuspenseQueryHookResult = ReturnType<typeof useGetUserLessonsSuspenseQuery>;
export type GetUserLessonsQueryResult = Apollo.QueryResult<GetUserLessonsQuery, GetUserLessonsQueryVariables>;
export const GetUserVocabularyDocument = gql`
    query GetUserVocabulary {
  studyProgress {
    vocabularyId
    root
    gloss
    state
    difficulty
    stability
    nextReviewDate
    reviewCount
    lapses
  }
}
    `;

/**
 * __useGetUserVocabularyQuery__
 *
 * To run a query within a React component, call `useGetUserVocabularyQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetUserVocabularyQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetUserVocabularyQuery({
 *   variables: {
 *   },
 * });
 */
export function useGetUserVocabularyQuery(baseOptions?: Apollo.QueryHookOptions<GetUserVocabularyQuery, GetUserVocabularyQueryVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetUserVocabularyQuery, GetUserVocabularyQueryVariables>(GetUserVocabularyDocument, options);
      }
export function useGetUserVocabularyLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetUserVocabularyQuery, GetUserVocabularyQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetUserVocabularyQuery, GetUserVocabularyQueryVariables>(GetUserVocabularyDocument, options);
        }
// @ts-ignore
export function useGetUserVocabularySuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetUserVocabularyQuery, GetUserVocabularyQueryVariables>): Apollo.UseSuspenseQueryResult<GetUserVocabularyQuery, GetUserVocabularyQueryVariables>;
export function useGetUserVocabularySuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetUserVocabularyQuery, GetUserVocabularyQueryVariables>): Apollo.UseSuspenseQueryResult<GetUserVocabularyQuery | undefined, GetUserVocabularyQueryVariables>;
export function useGetUserVocabularySuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetUserVocabularyQuery, GetUserVocabularyQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetUserVocabularyQuery, GetUserVocabularyQueryVariables>(GetUserVocabularyDocument, options);
        }
export type GetUserVocabularyQueryHookResult = ReturnType<typeof useGetUserVocabularyQuery>;
export type GetUserVocabularyLazyQueryHookResult = ReturnType<typeof useGetUserVocabularyLazyQuery>;
export type GetUserVocabularySuspenseQueryHookResult = ReturnType<typeof useGetUserVocabularySuspenseQuery>;
export type GetUserVocabularyQueryResult = Apollo.QueryResult<GetUserVocabularyQuery, GetUserVocabularyQueryVariables>;
export const FetchChapterDocument = gql`
    query FetchChapter($bookId: Int!, $chapterNumber: Int!, $lang: String) {
  reader(bookId: $bookId, chapterNumber: $chapterNumber, lang: $lang) {
    chapterId
    title
    units {
      type
      text
      original
      path
      marker
      vocabId
      hints
      gramFeatureIds
      synFeatureIds
      children {
        type
        text
        original
        path
        marker
        vocabId
        hints
        gramFeatureIds
        synFeatureIds
        children {
          type
          text
          original
          path
          marker
          vocabId
          hints
          gramFeatureIds
          synFeatureIds
        }
      }
    }
  }
}
    `;

/**
 * __useFetchChapterQuery__
 *
 * To run a query within a React component, call `useFetchChapterQuery` and pass it any options that fit your needs.
 * When your component renders, `useFetchChapterQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useFetchChapterQuery({
 *   variables: {
 *      bookId: // value for 'bookId'
 *      chapterNumber: // value for 'chapterNumber'
 *      lang: // value for 'lang'
 *   },
 * });
 */
export function useFetchChapterQuery(baseOptions: Apollo.QueryHookOptions<FetchChapterQuery, FetchChapterQueryVariables> & ({ variables: FetchChapterQueryVariables; skip?: boolean; } | { skip: boolean; }) ) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<FetchChapterQuery, FetchChapterQueryVariables>(FetchChapterDocument, options);
      }
export function useFetchChapterLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<FetchChapterQuery, FetchChapterQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<FetchChapterQuery, FetchChapterQueryVariables>(FetchChapterDocument, options);
        }
// @ts-ignore
export function useFetchChapterSuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<FetchChapterQuery, FetchChapterQueryVariables>): Apollo.UseSuspenseQueryResult<FetchChapterQuery, FetchChapterQueryVariables>;
export function useFetchChapterSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<FetchChapterQuery, FetchChapterQueryVariables>): Apollo.UseSuspenseQueryResult<FetchChapterQuery | undefined, FetchChapterQueryVariables>;
export function useFetchChapterSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<FetchChapterQuery, FetchChapterQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<FetchChapterQuery, FetchChapterQueryVariables>(FetchChapterDocument, options);
        }
export type FetchChapterQueryHookResult = ReturnType<typeof useFetchChapterQuery>;
export type FetchChapterLazyQueryHookResult = ReturnType<typeof useFetchChapterLazyQuery>;
export type FetchChapterSuspenseQueryHookResult = ReturnType<typeof useFetchChapterSuspenseQuery>;
export type FetchChapterQueryResult = Apollo.QueryResult<FetchChapterQuery, FetchChapterQueryVariables>;
export const GetStudyDashboardDocument = gql`
    query GetStudyDashboard {
  studyDashboard {
    totalCards
    dueToday
    newCards
    learningCards
    reviewCards
    relearningCards
    currentStreak
    reviewHistory {
      date
      count
    }
  }
}
    `;

/**
 * __useGetStudyDashboardQuery__
 *
 * To run a query within a React component, call `useGetStudyDashboardQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetStudyDashboardQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetStudyDashboardQuery({
 *   variables: {
 *   },
 * });
 */
export function useGetStudyDashboardQuery(baseOptions?: Apollo.QueryHookOptions<GetStudyDashboardQuery, GetStudyDashboardQueryVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetStudyDashboardQuery, GetStudyDashboardQueryVariables>(GetStudyDashboardDocument, options);
      }
export function useGetStudyDashboardLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetStudyDashboardQuery, GetStudyDashboardQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetStudyDashboardQuery, GetStudyDashboardQueryVariables>(GetStudyDashboardDocument, options);
        }
// @ts-ignore
export function useGetStudyDashboardSuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetStudyDashboardQuery, GetStudyDashboardQueryVariables>): Apollo.UseSuspenseQueryResult<GetStudyDashboardQuery, GetStudyDashboardQueryVariables>;
export function useGetStudyDashboardSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetStudyDashboardQuery, GetStudyDashboardQueryVariables>): Apollo.UseSuspenseQueryResult<GetStudyDashboardQuery | undefined, GetStudyDashboardQueryVariables>;
export function useGetStudyDashboardSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetStudyDashboardQuery, GetStudyDashboardQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetStudyDashboardQuery, GetStudyDashboardQueryVariables>(GetStudyDashboardDocument, options);
        }
export type GetStudyDashboardQueryHookResult = ReturnType<typeof useGetStudyDashboardQuery>;
export type GetStudyDashboardLazyQueryHookResult = ReturnType<typeof useGetStudyDashboardLazyQuery>;
export type GetStudyDashboardSuspenseQueryHookResult = ReturnType<typeof useGetStudyDashboardSuspenseQuery>;
export type GetStudyDashboardQueryResult = Apollo.QueryResult<GetStudyDashboardQuery, GetStudyDashboardQueryVariables>;
export const GetStudyProgressDocument = gql`
    query GetStudyProgress {
  studyProgress {
    vocabularyId
    root
    gloss
    state
    difficulty
    stability
    nextReviewDate
    reviewCount
    lapses
  }
}
    `;

/**
 * __useGetStudyProgressQuery__
 *
 * To run a query within a React component, call `useGetStudyProgressQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetStudyProgressQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetStudyProgressQuery({
 *   variables: {
 *   },
 * });
 */
export function useGetStudyProgressQuery(baseOptions?: Apollo.QueryHookOptions<GetStudyProgressQuery, GetStudyProgressQueryVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetStudyProgressQuery, GetStudyProgressQueryVariables>(GetStudyProgressDocument, options);
      }
export function useGetStudyProgressLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetStudyProgressQuery, GetStudyProgressQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetStudyProgressQuery, GetStudyProgressQueryVariables>(GetStudyProgressDocument, options);
        }
// @ts-ignore
export function useGetStudyProgressSuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetStudyProgressQuery, GetStudyProgressQueryVariables>): Apollo.UseSuspenseQueryResult<GetStudyProgressQuery, GetStudyProgressQueryVariables>;
export function useGetStudyProgressSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetStudyProgressQuery, GetStudyProgressQueryVariables>): Apollo.UseSuspenseQueryResult<GetStudyProgressQuery | undefined, GetStudyProgressQueryVariables>;
export function useGetStudyProgressSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetStudyProgressQuery, GetStudyProgressQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetStudyProgressQuery, GetStudyProgressQueryVariables>(GetStudyProgressDocument, options);
        }
export type GetStudyProgressQueryHookResult = ReturnType<typeof useGetStudyProgressQuery>;
export type GetStudyProgressLazyQueryHookResult = ReturnType<typeof useGetStudyProgressLazyQuery>;
export type GetStudyProgressSuspenseQueryHookResult = ReturnType<typeof useGetStudyProgressSuspenseQuery>;
export type GetStudyProgressQueryResult = Apollo.QueryResult<GetStudyProgressQuery, GetStudyProgressQueryVariables>;
export const GetVocabularySetsDocument = gql`
    query GetVocabularySets {
  studySets {
    id
    ownerUserId
    isSystem
    slug
    bookId
    title
    description
    createdAt
    lastPracticed
    totalCount
    knownCount
    learningCount
    percentComplete
    items {
      id
      vocabularyId
      root
      gloss
      masteryLevel
      lastSeen
    }
  }
}
    `;

/**
 * __useGetVocabularySetsQuery__
 *
 * To run a query within a React component, call `useGetVocabularySetsQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetVocabularySetsQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetVocabularySetsQuery({
 *   variables: {
 *   },
 * });
 */
export function useGetVocabularySetsQuery(baseOptions?: Apollo.QueryHookOptions<GetVocabularySetsQuery, GetVocabularySetsQueryVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetVocabularySetsQuery, GetVocabularySetsQueryVariables>(GetVocabularySetsDocument, options);
      }
export function useGetVocabularySetsLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetVocabularySetsQuery, GetVocabularySetsQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetVocabularySetsQuery, GetVocabularySetsQueryVariables>(GetVocabularySetsDocument, options);
        }
// @ts-ignore
export function useGetVocabularySetsSuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetVocabularySetsQuery, GetVocabularySetsQueryVariables>): Apollo.UseSuspenseQueryResult<GetVocabularySetsQuery, GetVocabularySetsQueryVariables>;
export function useGetVocabularySetsSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetVocabularySetsQuery, GetVocabularySetsQueryVariables>): Apollo.UseSuspenseQueryResult<GetVocabularySetsQuery | undefined, GetVocabularySetsQueryVariables>;
export function useGetVocabularySetsSuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetVocabularySetsQuery, GetVocabularySetsQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetVocabularySetsQuery, GetVocabularySetsQueryVariables>(GetVocabularySetsDocument, options);
        }
export type GetVocabularySetsQueryHookResult = ReturnType<typeof useGetVocabularySetsQuery>;
export type GetVocabularySetsLazyQueryHookResult = ReturnType<typeof useGetVocabularySetsLazyQuery>;
export type GetVocabularySetsSuspenseQueryHookResult = ReturnType<typeof useGetVocabularySetsSuspenseQuery>;
export type GetVocabularySetsQueryResult = Apollo.QueryResult<GetVocabularySetsQuery, GetVocabularySetsQueryVariables>;
export const GetVocabularyDocument = gql`
    query GetVocabulary($occurrences: Int, $comparison: String) {
  vocabulary(occurrences: $occurrences, comparison: $comparison) {
    id
    root
    gloss
    occurrences
  }
}
    `;

/**
 * __useGetVocabularyQuery__
 *
 * To run a query within a React component, call `useGetVocabularyQuery` and pass it any options that fit your needs.
 * When your component renders, `useGetVocabularyQuery` returns an object from Apollo Client that contains loading, error, and data properties
 * you can use to render your UI.
 *
 * @param baseOptions options that will be passed into the query, supported options are listed on: https://www.apollographql.com/docs/react/api/react-hooks/#options;
 *
 * @example
 * const { data, loading, error } = useGetVocabularyQuery({
 *   variables: {
 *      occurrences: // value for 'occurrences'
 *      comparison: // value for 'comparison'
 *   },
 * });
 */
export function useGetVocabularyQuery(baseOptions?: Apollo.QueryHookOptions<GetVocabularyQuery, GetVocabularyQueryVariables>) {
        const options = {...defaultOptions, ...baseOptions}
        return Apollo.useQuery<GetVocabularyQuery, GetVocabularyQueryVariables>(GetVocabularyDocument, options);
      }
export function useGetVocabularyLazyQuery(baseOptions?: Apollo.LazyQueryHookOptions<GetVocabularyQuery, GetVocabularyQueryVariables>) {
          const options = {...defaultOptions, ...baseOptions}
          return Apollo.useLazyQuery<GetVocabularyQuery, GetVocabularyQueryVariables>(GetVocabularyDocument, options);
        }
// @ts-ignore
export function useGetVocabularySuspenseQuery(baseOptions?: Apollo.SuspenseQueryHookOptions<GetVocabularyQuery, GetVocabularyQueryVariables>): Apollo.UseSuspenseQueryResult<GetVocabularyQuery, GetVocabularyQueryVariables>;
export function useGetVocabularySuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetVocabularyQuery, GetVocabularyQueryVariables>): Apollo.UseSuspenseQueryResult<GetVocabularyQuery | undefined, GetVocabularyQueryVariables>;
export function useGetVocabularySuspenseQuery(baseOptions?: Apollo.SkipToken | Apollo.SuspenseQueryHookOptions<GetVocabularyQuery, GetVocabularyQueryVariables>) {
          const options = baseOptions === Apollo.skipToken ? baseOptions : {...defaultOptions, ...baseOptions}
          return Apollo.useSuspenseQuery<GetVocabularyQuery, GetVocabularyQueryVariables>(GetVocabularyDocument, options);
        }
export type GetVocabularyQueryHookResult = ReturnType<typeof useGetVocabularyQuery>;
export type GetVocabularyLazyQueryHookResult = ReturnType<typeof useGetVocabularyLazyQuery>;
export type GetVocabularySuspenseQueryHookResult = ReturnType<typeof useGetVocabularySuspenseQuery>;
export type GetVocabularyQueryResult = Apollo.QueryResult<GetVocabularyQuery, GetVocabularyQueryVariables>;