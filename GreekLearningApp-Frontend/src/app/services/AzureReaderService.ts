// GreekLearningApp-Frontend/src/app/services/AzureReaderService.ts
import { apiClient } from './apiClient';
import { RenderedChapterDto } from '../../types/api';

export async function fetchPage(chapterId: number, userId: string): Promise<RenderedChapterDto | null> {
  try {
    return await apiClient.get<RenderedChapterDto>(`reader?book=1&chapter=${chapterId}`);
    // Note: The backend ReaderController expects 'book' and 'chapter' query params
    // and gets userId from claims. Adjusting accordingly.
  } catch (error) {
    return null;
  }
}

export default fetchPage;
