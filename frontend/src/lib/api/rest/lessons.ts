// TODO: remove after GraphQL transition complete
import { ApiResult, apiClient } from '@/lib/api/rest/client';
import {
  CompleteLessonDto,
  LessonCompletionResponseDto,
  LessonDto,
  LessonTrackDto,
} from '@/lib/types/api';

function withDevUserHeader(userId?: string) {
  if (!userId) {
    return undefined;
  }
  return { headers: { 'X-Dev-User-Id': userId } };
}

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

export function completeLesson(
  lessonId: number,
  payload?: Omit<CompleteLessonDto, 'lessonId'>,
  userId?: string,
): Promise<ApiResult<LessonCompletionResponseDto>> {
  return apiClient.postResult<LessonCompletionResponseDto>(
    `lessons/${lessonId}/complete`,
    {
      lessonId,
      score: payload?.score ?? null,
    },
    undefined,
    withDevUserHeader(userId),
  );
}
