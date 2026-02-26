import { ApiResult, apiClient } from '@/lib/api/rest/client';
import {
  AddVocabularySetItemDto,
  CreateVocabularySetDto,
  UpdateVocabularySetDto,
  UpdateVocabularySetProgressDto,
  VocabularySetDto,
} from '@/lib/types/api';

export function fetchVocabularySets(): Promise<ApiResult<VocabularySetDto[]>> {
  return apiClient.getResult<VocabularySetDto[]>('vocabulary-sets');
}

export function fetchVocabularySetById(id: number): Promise<ApiResult<VocabularySetDto>> {
  return apiClient.getResult<VocabularySetDto>(`vocabulary-sets/${id}`);
}

export function createVocabularySet(payload: CreateVocabularySetDto): Promise<ApiResult<VocabularySetDto>> {
  return apiClient.postResult<VocabularySetDto>('vocabulary-sets', payload);
}

export function updateVocabularySet(id: number, payload: UpdateVocabularySetDto): Promise<ApiResult<VocabularySetDto>> {
  return apiClient.putResult<VocabularySetDto>(`vocabulary-sets/${id}`, payload);
}

export function deleteVocabularySet(id: number): Promise<ApiResult<Record<string, never>>> {
  return apiClient.deleteResult<Record<string, never>>(`vocabulary-sets/${id}`);
}

export function addVocabularyToSet(
  id: number,
  payload: AddVocabularySetItemDto,
): Promise<ApiResult<Record<string, string>>> {
  return apiClient.postResult<Record<string, string>>(`vocabulary-sets/${id}/items`, payload);
}

export function removeVocabularyFromSet(
  id: number,
  vocabularyId: number,
): Promise<ApiResult<Record<string, never>>> {
  return apiClient.deleteResult<Record<string, never>>(`vocabulary-sets/${id}/items/${vocabularyId}`);
}

export function updateVocabularySetProgress(
  id: number,
  vocabularyId: number,
  payload: UpdateVocabularySetProgressDto,
): Promise<ApiResult<Record<string, never>>> {
  return apiClient.putResult<Record<string, never>>(`vocabulary-sets/${id}/progress/${vocabularyId}`, payload);
}
