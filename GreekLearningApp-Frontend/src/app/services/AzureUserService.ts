// GreekLearningApp-Frontend/src/app/services/AzureUserService.ts
import { apiClient } from './apiClient';
import { UserDto, RegisterRequestDto } from '../../types/api';

export function getDefaultUserState(): UserDto {
  return {
    id: 0,
    username: '',
    email: '',
    settings: [],
  };
}

export async function fetchUser(userId: string): Promise<UserDto | null> {
  try {
    return await apiClient.get<UserDto>(`users/${userId}`);
  } catch (error) {
    return null;
  }
}

export async function createUser(externalId: string, email: string, username: string): Promise<UserDto | null> {
  try {
    const registerDto: RegisterRequestDto = {
      email,
      username,
      password: externalId, // Temporary: using externalId as password for simplicity
    };
    return await apiClient.post<UserDto>('Auth/register', registerDto);
  } catch (error) {
    return null;
  }
}
