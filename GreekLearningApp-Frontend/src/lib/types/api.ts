// GreekLearningApp-Frontend/src/types/api.ts

export interface BookDto {
  id: number;
  title: string;
  languageCode: string;
  createdAt: string;
}

export interface CreateBookDto {
  title: string;
  languageCode?: string | null;
}

export interface UpdateBookDto {
  title: string;
  languageCode?: string | null;
}

export interface ChapterDto {
  id: number;
  bookId: number;
  chapterIndex: number;
  title?: string | null;
  unitTree: UnitNodeDto[];
  createdAt: string;
}

export interface UnitNodeDto {
  type: string;
  synFeatureIds?: number[] | null;
  translation?: string | null;
  children?: UnitNodeDto[] | null;
  content?: string | null;
  marker?: string | null;
}

export interface RenderedChapterDto {
  chapterId: number;
  title: string;
  units: RenderedUnitDto[];
}

export interface RenderedUnitDto {
  type: string;
  text?: string | null;
  original?: string | null;
  path?: string | null;
  hints?: string[] | null;
  vocabId?: number | null;
  gramFeatureIds?: number[] | null;
  synFeatureIds?: number[] | null;
  marker?: string | null;
  children?: RenderedUnitDto[] | null;
}

export interface SimpleWordDto {
  rootGUID: string;
  rootId: number;
  content: string;
  occurrences: number;
  gloss?: string | null;
}

export interface VocabularyDto {
  id: number;
  root: string;
  transliteration?: string | null;
  gloss: string;
  partOfSpeech?: string | null;
  occurrences?: number | null;
}

export interface UserDto {
  id: number;
  email: string;
  username: string;
  displayName?: string | null;
  settings?: UserSettingDto[] | null;
}

export interface UserSettingDto {
  settingName?: string | null;
  settingValue?: string | null;
}

export interface UserLessonDto {
  lessonId: number;
  name?: string | null;
  isComplete: boolean;
}

export interface UserWordDto {
  wordId: number;
  greekWord?: string | null;
  englishMeaning?: string | null;
  knowledgeLevel: number;
}

export interface LessonDto {
  id: number;
  trackId: number;
  trackSlug: string;
  slug: string;
  title: string;
  lessonIndex: number;
  contentMarkdown: string;
  contentPath?: string | null;
  lessonType: string;
  grammaticalFeatureIds: number[];
  syntacticalFeatureIds: number[];
  vocabularyIds: number[];
  isCompleted: boolean;
}

export interface LessonTrackDto {
  id: number;
  slug: string;
  title: string;
  description: string;
  sortOrder: number;
  totalLessons: number;
  completedLessons: number;
  percentComplete: number;
  nextLessonId?: number | null;
  nextLessonSlug?: string | null;
  nextLessonTitle?: string | null;
  lessons: LessonDto[];
}

export interface CompleteLessonDto {
  lessonId: number;
  score?: number | null;
}

export interface UserProgressDto {
  completedLessonIds: number[];
  grammaticalFeatureProgress: { [key: string]: FeatureProgressDto };
  syntacticalFeatureProgress: { [key: string]: FeatureProgressDto };
  vocabularyProgress: { [key: string]: VocabularyProgressDto };
  updatedAt: string;
}

export interface FeatureProgressDto {
  masteryLevel: number;
  needsPractice: boolean;
  lastPracticed: string;
}

export interface VocabularyProgressDto {
  masteryLevel: number;
  needsPractice: boolean;
  lastPracticed: string;
  timesSeen: number;
}

export interface SelectionsDto {
  texts: TextSelectionDto[];
  chapters: ChapterSelectionDto[];
}

export interface TextSelectionDto {
  textId: number;
  title: string;
}

export interface ChapterSelectionDto {
  chapterId: number;
  chapterNumber: number;
}

export interface VocabularySetDto {
  id: number;
  ownerUserId?: number | null;
  isSystem: boolean;
  slug: string;
  bookId?: number | null;
  title: string;
  description: string;
  items: VocabularySetItemDto[];
  createdAt: string;
  lastPracticed?: string | null;
  totalCount: number;
  knownCount: number;
  learningCount: number;
  percentComplete: number;
}

export interface VocabularySetItemDto {
  id: number;
  vocabularyId: number;
  root: string;
  gloss: string;
  masteryLevel: number;
  lastSeen?: string | null;
}

export interface CreateVocabularySetDto {
  title: string;
  description: string;
  vocabularyIds: number[];
}

export type CardPool = 'DueOnly' | 'NewOnly' | 'Mixed';
export type StudyDirection = 'GreekToEnglish' | 'EnglishToGreek' | 'Random';
export type InteractionMode = 'Flip' | 'MultipleChoice' | 'Mix';
export type Rating = 'Again' | 'Hard' | 'Good' | 'Easy';
export type CardState = 'New' | 'Learning' | 'Review' | 'Relearning';

export interface StartSessionRequest {
  cardCount: number;
  pool: CardPool;
  direction: StudyDirection;
  mode: InteractionMode;
  vocabularySetId?: number | null;
  vocabularyIds?: number[] | null;
}

export interface SessionDto {
  id: string;
  totalCards: number;
  cardsReviewed: number;
  startedAt: string;
  completedAt?: string | null;
  pool: CardPool;
  direction: StudyDirection;
  mode: InteractionMode;
  vocabularySetId?: number | null;
}

export interface CardDto {
  sessionCardId: number;
  vocabularyId: number;
  position: number;
  totalCards: number;
  front: {
    root: string;
    transliteration?: string | null;
    partOfSpeech?: string | null;
    occurrences?: number | null;
  };
  back: {
    gloss: string;
  };
  interactionMode: InteractionMode;
  choices?: string[] | null;
  direction: StudyDirection;
}

export interface RateCardRequest {
  rating: Rating;
}

export interface RateCardResponse {
  nextReviewDate: string;
  scheduledDays: number;
  newState: CardState;
  sessionComplete: boolean;
}

export interface ReviewHistoryDto {
  date: string;
  count: number;
}

export interface DashboardDto {
  totalCards: number;
  dueToday: number;
  newCards: number;
  learningCards: number;
  reviewCards: number;
  relearningCards: number;
  currentStreak: number;
  reviewHistory: ReviewHistoryDto[];
}

export interface SessionSummaryDto {
  totalReviewed: number;
  correctCount: number;
  correctPercentage: number;
  ratings: Record<Rating, number>;
}

export interface CardProgressDto {
  vocabularyId: number;
  root: string;
  gloss: string;
  state: CardState;
  difficulty: number;
  stability: number;
  nextReviewDate: string;
  reviewCount: number;
  lapses: number;
}

export interface UpdateVocabularySetDto {
  title: string;
  description: string;
}

export interface AddVocabularySetItemDto {
  vocabularyId: number;
}

export interface UpdateVocabularySetProgressDto {
  masteryLevel: number;
}

export interface RegisterRequestDto {
  email?: string | null;
  username?: string | null;
  password?: string | null;
}

export interface CreateUserDto {
  email?: string | null;
  username?: string | null;
  password?: string | null;
}
