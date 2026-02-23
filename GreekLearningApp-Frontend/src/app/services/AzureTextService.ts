// GreekLearningApp-Frontend/src/app/services/AzureTextService.ts
import { apiClient } from './apiClient';
import { SimpleWordDto, RenderedChapterDto } from '../../types/api';

export async function fetchVocabulary(): Promise<SimpleWordDto[]> {
  try {
    return await apiClient.get<SimpleWordDto[]>('words');
  } catch (error) {
    return [];
  }
}

export async function fetchMorphologyDetails(morphologyId: number): Promise<any> {
  // Placeholder - adjust endpoint as needed based on actual controller
  try {
    return await apiClient.get<any>(`grammaticalfeatures/${morphologyId}`);
  } catch (error) {
    return null;
  }
}

export async function fetchRenderedChapter(bookId: number, chapterId: number): Promise<RenderedChapterDto | null> {
  try {
    return await apiClient.get<RenderedChapterDto>(`reader?book=${bookId}&chapter=${chapterId}`);
  } catch (error) {
    return null;
  }
}
