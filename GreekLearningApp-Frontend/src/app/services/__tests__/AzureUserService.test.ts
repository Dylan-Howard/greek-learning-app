import { beforeEach, describe, expect, it, vi } from 'vitest';

const getMock = vi.fn();
const postMock = vi.fn();
const putMock = vi.fn();

vi.mock('../apiClient', () => ({
  apiClient: {
    get: (...args: unknown[]) => getMock(...args),
    post: (...args: unknown[]) => postMock(...args),
    put: (...args: unknown[]) => putMock(...args),
  },
}));

import {
  createUser,
  fetchUser,
  getDefaultUserState,
  updateUser,
} from '../AzureUserService';

describe('AzureUserService', () => {
  beforeEach(() => {
    getMock.mockReset();
    postMock.mockReset();
    putMock.mockReset();
  });

  it('returns default guest state', () => {
    const guest = getDefaultUserState();
    expect(guest.id).toBe('guest');
    expect(guest.settings.translation).toBe('esv');
  });

  it('fetchUser returns fallback for non-numeric IDs', async () => {
    const user = await fetchUser('clerk_abc');
    expect(user.id).toBe('clerk_abc');
    expect(user.name).toBe('Scholar');
  });

  it('fetchUser maps backend payloads for numeric IDs', async () => {
    getMock
      .mockResolvedValueOnce({ id: 3, username: 'andrew', displayName: 'Andrew' })
      .mockResolvedValueOnce([{ lessonId: 2, isComplete: true }])
      .mockResolvedValueOnce([{ wordId: 9, knowledgeLevel: 2 }])
      .mockResolvedValueOnce([
        { settingName: 'translation', settingValue: 'niv' },
        { settingName: 'prefersDarkMode', settingValue: 'true' },
      ]);

    const user = await fetchUser('3');

    expect(user.id).toBe('3');
    expect(user.name).toBe('Andrew');
    expect(user.progress.lessons).toEqual([{ lessonId: 2, isComplete: true }]);
    expect(user.progress.vocabulary).toEqual([{ wordId: 9, isComplete: true }]);
    expect(user.settings).toEqual({ prefersDarkMode: true, translation: 'niv' });
  });

  it('createUser returns fallback template for non-numeric IDs', async () => {
    const created = await createUser('clerk_123', 'Reader', 1);
    expect(created.id).toBe('clerk_123');
    expect(created.progress.lessons.length).toBeGreaterThan(0);
  });

  it('updateUser persists numeric user settings via API', async () => {
    putMock.mockResolvedValue(undefined);

    const updated = await updateUser({
      id: '4',
      name: 'Theo',
      progress: { lessons: [], vocabulary: [] },
      settings: { prefersDarkMode: false, translation: 'esv' },
    });

    expect(updated.name).toBe('Theo');
    expect(putMock).toHaveBeenCalledTimes(3);
  });
});
