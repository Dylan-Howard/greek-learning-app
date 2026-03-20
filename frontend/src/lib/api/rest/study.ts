// TODO: remove after GraphQL transition complete
import { ApiResult, apiClient } from '@/lib/api/rest/client';
import {
  CardDto,
  CardProgressDto,
  DashboardDto,
  RateCardRequest,
  RateCardResponse,
  SessionDto,
  SessionSummaryDto,
  StartSessionRequest,
} from '@/lib/types/api';

function withDevUserHeader(userId?: string) {
  if (!userId) {
    return undefined;
  }
  return { headers: { 'X-Dev-User-Id': userId } };
}

export function startSession(payload: StartSessionRequest, userId?: string): Promise<ApiResult<SessionDto>> {
  return apiClient.postResult<SessionDto>('study/sessions', payload, undefined, withDevUserHeader(userId));
}

export function getSession(sessionId: string, userId?: string): Promise<ApiResult<SessionDto>> {
  return apiClient.getResult<SessionDto>(`study/sessions/${sessionId}`, undefined, withDevUserHeader(userId));
}

export function getNextCard(sessionId: string, userId?: string): Promise<ApiResult<CardDto>> {
  return apiClient.getResult<CardDto>(`study/sessions/${sessionId}/next-card`, undefined, withDevUserHeader(userId));
}

export function rateCard(
  sessionId: string,
  vocabId: number,
  payload: RateCardRequest,
  userId?: string,
): Promise<ApiResult<RateCardResponse>> {
  return apiClient.postResult<RateCardResponse>(
    `study/sessions/${sessionId}/cards/${vocabId}/rate`,
    payload,
    undefined,
    withDevUserHeader(userId),
  );
}

export function completeSession(sessionId: string, userId?: string): Promise<ApiResult<SessionSummaryDto>> {
  return apiClient.postResult<SessionSummaryDto>(
    `study/sessions/${sessionId}/complete`,
    {},
    undefined,
    withDevUserHeader(userId),
  );
}

export function getDashboard(userId?: string): Promise<ApiResult<DashboardDto>> {
  return apiClient.getResult<DashboardDto>('study/dashboard', undefined, withDevUserHeader(userId));
}

export function getProgress(userId?: string): Promise<ApiResult<CardProgressDto[]>> {
  return apiClient.getResult<CardProgressDto[]>('study/progress', undefined, withDevUserHeader(userId));
}
