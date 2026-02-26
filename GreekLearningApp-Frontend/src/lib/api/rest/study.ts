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

export function startSession(payload: StartSessionRequest): Promise<ApiResult<SessionDto>> {
  return apiClient.postResult<SessionDto>('study/sessions', payload);
}

export function getSession(sessionId: string): Promise<ApiResult<SessionDto>> {
  return apiClient.getResult<SessionDto>(`study/sessions/${sessionId}`);
}

export function getNextCard(sessionId: string): Promise<ApiResult<CardDto>> {
  return apiClient.getResult<CardDto>(`study/sessions/${sessionId}/next-card`);
}

export function rateCard(
  sessionId: string,
  vocabId: number,
  payload: RateCardRequest,
): Promise<ApiResult<RateCardResponse>> {
  return apiClient.postResult<RateCardResponse>(`study/sessions/${sessionId}/cards/${vocabId}/rate`, payload);
}

export function completeSession(sessionId: string): Promise<ApiResult<SessionSummaryDto>> {
  return apiClient.postResult<SessionSummaryDto>(`study/sessions/${sessionId}/complete`, {});
}

export function getDashboard(): Promise<ApiResult<DashboardDto>> {
  return apiClient.getResult<DashboardDto>('study/dashboard');
}

export function getProgress(): Promise<ApiResult<CardProgressDto[]>> {
  return apiClient.getResult<CardProgressDto[]>('study/progress');
}
