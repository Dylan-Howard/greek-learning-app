import users from '@/app/services/data/userData.json';
import { apiClient } from '@/lib/api/rest/client';
import { User } from '@/lib/types/domain/user';

type ApiUser = {
  id: number;
  username?: string;
  displayName?: string | null;
  totalExperience?: number | null;
};

type ApiUserLesson = {
  lessonId: number;
  isComplete: boolean;
};

type ApiUserWord = {
  wordId: number;
  knowledgeLevel: number;
};

type ApiUserSetting = {
  settingName?: string | null;
  settingValue?: string | null;
};

const toNumericUserId = (id: string): number | null => {
  const parsed = Number.parseInt(id, 10);
  return Number.isNaN(parsed) ? null : parsed;
};

const fallbackProgressByLevel = (userLevel: number): User['progress'] => {
  if (userLevel === 1) return users.users[1].progress as User['progress'];
  if (userLevel === 2) return users.users[2].progress as User['progress'];
  return {
    lessons: [],
    vocabulary: [],
  };
};

const settingsFromApi = (settings: ApiUserSetting[] = []): User['settings'] => {
  const translation = settings.find((s) => s.settingName === 'translation')?.settingValue ?? 'esv';
  const prefersDarkMode = settings.find((s) => s.settingName === 'prefersDarkMode')?.settingValue === 'true';

  return {
    prefersDarkMode,
    translation,
  };
};

export const getDefaultUserState = (): User => ({
  id: 'guest',
  name: 'Guest',
  totalExp: 0,
  progress: {
    lessons: [],
    vocabulary: [],
  },
  settings: {
    prefersDarkMode: false,
    translation: 'esv',
  },
});

export async function createUser(id: string, name: string, userLevel: number): Promise<User> {
  const numericId = toNumericUserId(id);
  if (numericId === null) {
    return {
      id,
      name,
      totalExp: 0,
      progress: fallbackProgressByLevel(userLevel),
      settings: {
        prefersDarkMode: false,
        translation: 'esv',
      },
    };
  }

  try {
    const existing = await fetchUser(id);
    if (existing.id !== 'guest') {
      return existing;
    }
  } catch {
    // Continue to create flow.
  }

  try {
    const username = name?.trim() ? name.replace(/\s+/g, '_').toLowerCase() : `user_${numericId}`;
    await apiClient.post<ApiUser>('users', {
      email: `${username}@placeholder.local`,
      username,
      password: `Temp_${numericId}_Password!`,
    });
  } catch {
    // If creation fails (already exists/validation), try reading current state.
  }

  return fetchUser(id);
}

export async function fetchUser(id: string): Promise<User> {
  if (!id || id === 'guest') {
    return getDefaultUserState();
  }

  const numericId = toNumericUserId(id);
  if (numericId === null) {
    return {
      ...getDefaultUserState(),
      id,
      name: 'Scholar',
      totalExp: 0,
    };
  }

  try {
    const [userDto, lessons, words, settings] = await Promise.all([
      apiClient.get<ApiUser>(`users/${numericId}`),
      apiClient.get<ApiUserLesson[]>(`users/${numericId}/lessons`),
      apiClient.get<ApiUserWord[]>(`users/${numericId}/words`),
      apiClient.get<ApiUserSetting[]>(`users/${numericId}/settings`),
    ]);

    return {
      id: `${userDto.id}`,
      name: userDto.displayName || userDto.username || 'Scholar',
      totalExp: userDto.totalExperience ?? 0,
      progress: {
        lessons: (lessons || []).map((l) => ({
          lessonId: l.lessonId,
          isComplete: !!l.isComplete,
        })),
        vocabulary: (words || []).map((w) => ({
          wordId: w.wordId,
          isComplete: w.knowledgeLevel > 0,
        })),
      },
      settings: settingsFromApi(settings),
    };
  } catch {
    return {
      ...getDefaultUserState(),
      id,
      name: 'Scholar',
      totalExp: 0,
    };
  }
}

export async function fetchUserLessons(id: string) {
  const user = await fetchUser(id);
  return user.progress.lessons;
}

export async function updateUser(userData: User): Promise<User> {
  if (userData.id === 'guest') {
    return userData;
  }

  const numericId = toNumericUserId(userData.id);
  if (numericId === null) {
    return userData;
  }

  try {
    await Promise.all([
      apiClient.put<void>(`users/${numericId}`, {
        displayName: userData.name,
      }),
      apiClient.put<void>(`users/${numericId}/settings`, {
        settingName: 'translation',
        settingValue: userData.settings.translation,
      }),
      apiClient.put<void>(`users/${numericId}/settings`, {
        settingName: 'prefersDarkMode',
        settingValue: `${userData.settings.prefersDarkMode}`,
      }),
    ]);
  } catch {
    // Return latest local state on partial API failure to preserve UX continuity.
  }

  return userData;
}
