import { apiClient } from '@/lib/api/rest/client';
import { UserProgressDto } from '@/lib/types/api';

export function fetchProgress(userId: string): Promise<UserProgressDto> {
  return apiClient.get<UserProgressDto>(`progress?userId=${encodeURIComponent(userId)}`);
}

export function updateProgress(userId: string, payload: UserProgressDto): Promise<void> {
  return apiClient.put<void>(`progress?userId=${encodeURIComponent(userId)}`, payload);
}

