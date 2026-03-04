import { ApiResult, apiClient } from '@/lib/api/rest/client';
import {
  AddVocabularySetItemDto,
  CreateVocabularySetDto,
  UpdateVocabularySetDto,
  UpdateVocabularySetProgressDto,
  VocabularySetDto,
} from '@/lib/types/api';

function withDevUserHeader(userId?: string) {
  if (!userId) {
    return undefined;
  }
  return { headers: { 'X-Dev-User-Id': userId } };
}

export function fetchVocabularySets(userId?: string): Promise<ApiResult<VocabularySetDto[]>> {
  return apiClient.getResult<VocabularySetDto[]>('vocabulary-sets', undefined, withDevUserHeader(userId));
}

export function fetchVocabularySetById(id: number, userId?: string): Promise<ApiResult<VocabularySetDto>> {
  return apiClient.getResult<VocabularySetDto>(`vocabulary-sets/${id}`, undefined, withDevUserHeader(userId));
}

export function createVocabularySet(payload: CreateVocabularySetDto, userId?: string): Promise<ApiResult<VocabularySetDto>> {
  return apiClient.postResult<VocabularySetDto>('vocabulary-sets', payload, undefined, withDevUserHeader(userId));
}

export function updateVocabularySet(id: number, payload: UpdateVocabularySetDto, userId?: string): Promise<ApiResult<VocabularySetDto>> {
  return apiClient.putResult<VocabularySetDto>(`vocabulary-sets/${id}`, payload, undefined, withDevUserHeader(userId));
}

export function deleteVocabularySet(id: number, userId?: string): Promise<ApiResult<Record<string, never>>> {
  return apiClient.deleteResult<Record<string, never>>(`vocabulary-sets/${id}`, undefined, withDevUserHeader(userId));
}

export function addVocabularyToSet(
  id: number,
  payload: AddVocabularySetItemDto,
  userId?: string,
): Promise<ApiResult<Record<string, string>>> {
  return apiClient.postResult<Record<string, string>>(`vocabulary-sets/${id}/items`, payload, undefined, withDevUserHeader(userId));
}

export function removeVocabularyFromSet(
  id: number,
  vocabularyId: number,
  userId?: string,
): Promise<ApiResult<Record<string, never>>> {
  return apiClient.deleteResult<Record<string, never>>(`vocabulary-sets/${id}/items/${vocabularyId}`, undefined, withDevUserHeader(userId));
}

export function updateVocabularySetProgress(
  id: number,
  vocabularyId: number,
  payload: UpdateVocabularySetProgressDto,
  userId?: string,
): Promise<ApiResult<Record<string, never>>> {
  return apiClient.putResult<Record<string, never>>(`vocabulary-sets/${id}/progress/${vocabularyId}`, payload, undefined, withDevUserHeader(userId));
}
