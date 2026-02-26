import { apiClient } from '@/lib/api/rest/client';
import { ChapterDto, SimpleWordDto } from '@/lib/types/api';

export type SelectionText = { textId: number; title: string };
export type SelectionChapter = { chapterId: number; chapterNumber: number };

const toNumber = (value: unknown, fallback = 0): number => {
  if (typeof value === 'number') return value;
  if (typeof value === 'string') {
    const n = Number.parseInt(value, 10);
    return Number.isNaN(n) ? fallback : n;
  }
  return fallback;
};

export async function fetchLessons() {
  try {
    return await apiClient.get<any[]>('lessons');
  } catch {
    return [];
  }
}

export async function fetchLessonByForm(grammarId: number) {
  try {
    const lessons = await fetchLessons();
    return lessons.filter((lesson) => (lesson.grammaticalFeatureIds || []).includes(grammarId));
  } catch {
    return [];
  }
}

export async function fetchTexts() {
  try {
    const books = await apiClient.get<any[]>('books');
    return books.map((book) => ({ textId: toNumber(book.id), title: book.title || `Book ${book.id}` }));
  } catch {
    return [];
  }
}

export async function fetchText(textId: number) {
  try {
    const book = await apiClient.get<any>(`books/${textId}`);
    return { textId: toNumber(book.id), title: book.title || `Book ${book.id}` };
  } catch {
    return undefined;
  }
}

export async function fetchVocabulary() {
  try {
    return await apiClient.get<SimpleWordDto[]>('words');
  } catch {
    return [];
  }
}

export async function fetchVocabularyByChapter(chapterId: number) {
  try {
    return await apiClient.get<SimpleWordDto[]>(`chapters/${chapterId}/words`);
  } catch {
    return [];
  }
}

export async function fetchUnitsByChapter(_chapterId: number) {
  return [];
}

export async function fetchChapter(chapterId: number) {
  try {
    return await apiClient.get<ChapterDto>(`chapters/${chapterId}`);
  } catch {
    return undefined;
  }
}

export async function fetchChaptersByText(textId: number) {
  try {
    const chapters = await apiClient.get<any[]>(`books/${textId}/chapters`);
    return chapters.map((chapter) => ({
      chapterId: toNumber(chapter.id),
      chapterNumber: toNumber(chapter.chapterIndex, toNumber(chapter.id)),
      chapterIndex: toNumber(chapter.chapterIndex, toNumber(chapter.id)),
      textId,
      title: chapter.title || `Chapter ${chapter.chapterIndex}`,
    }));
  } catch {
    return [];
  }
}

export async function fetchTextSelectionOptions(currTextId: number): Promise<{
  texts: SelectionText[];
  chapters: SelectionChapter[];
}> {
  const [texts, chapters] = await Promise.all([
    fetchTexts(),
    fetchChaptersByText(currTextId),
  ]);

  return {
    texts,
    chapters: chapters.map((chapter) => ({
      chapterId: chapter.chapterId,
      chapterNumber: chapter.chapterNumber,
    })),
  };
}

export async function fetchMorphology(morphologyId: number) {
  return fetchMorphologyDetails(morphologyId);
}

export async function fetchMorphologyDetails(morphologyId: number) {
  try {
    const word = await apiClient.get<any>(`words/${morphologyId}`);
    return {
      content: word.content || '',
      posName: 'Word',
      caseName: '',
      tenseName: '',
      voiceName: '',
      moodName: '',
      personName: '',
      numberName: '',
      genderName: '',
      patternName: '',
      degreeName: '',
      rootName: word.gloss || '',
    };
  } catch {
    return undefined;
  }
}

export async function fetchMorphologyAbbreviation(morphologyId: number) {
  const details = await fetchMorphologyDetails(morphologyId);
  return details?.posName || '';
}

export type SyntacticalFeatureDetails = {
  id: number;
  code: string;
  name: string;
  definition?: string;
};

export async function fetchSyntacticalFeatureDetails(featureId: number): Promise<SyntacticalFeatureDetails | undefined> {
  try {
    const feature = await apiClient.get<any>(`syntactical-features/${featureId}`);
    return {
      id: toNumber(feature.id),
      code: feature.code || `Feature ${featureId}`,
      name: feature.name || `Feature ${featureId}`,
      definition: feature.definition || '',
    };
  } catch {
    return undefined;
  }
}
