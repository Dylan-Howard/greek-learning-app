import { ApiResult, apiClient } from '@/lib/api/rest/client';
import { CompleteLessonDto, LessonDto, LessonTrackDto } from '@/lib/types/api';

export function fetchLessonTracks(includeLessons = false): Promise<ApiResult<LessonTrackDto[]>> {
  return apiClient.getResult<LessonTrackDto[]>(`lessons/tracks?includeLessons=${includeLessons}`);
}

export function fetchLessonTrack(trackSlug: string): Promise<ApiResult<LessonTrackDto>> {
  return apiClient.getResult<LessonTrackDto>(`lessons/tracks/${encodeURIComponent(trackSlug)}`);
}

export function fetchNextLesson(trackSlug: string): Promise<ApiResult<LessonDto>> {
  return apiClient.getResult<LessonDto>(`lessons/tracks/${encodeURIComponent(trackSlug)}/next`);
}

export function fetchLessonsByTrack(trackSlug: string): Promise<ApiResult<LessonDto[]>> {
  return apiClient.getResult<LessonDto[]>(`lessons?trackSlug=${encodeURIComponent(trackSlug)}`);
}

export function fetchLesson(lessonId: number): Promise<ApiResult<LessonDto>> {
  return apiClient.getResult<LessonDto>(`lessons/${lessonId}`);
}

export function completeLesson(lessonId: number, payload?: Omit<CompleteLessonDto, 'lessonId'>): Promise<ApiResult<{ message: string }>> {
  return apiClient.postResult<{ message: string }>(`lessons/${lessonId}/complete`, {
    lessonId,
    score: payload?.score ?? null,
  });
}
