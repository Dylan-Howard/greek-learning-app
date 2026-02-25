import * as VocabularySetService from '../VocabularySetService';

describe('VocabularySetService', () => {
  beforeEach(() => {
    process.env.NEXT_PUBLIC_API_URL = 'http://localhost:5999/api';
  });

  it('fetches vocabulary sets', async () => {
    vi.stubGlobal('fetch', vi.fn().mockResolvedValue({
      ok: true,
      status: 200,
      headers: {
        get: (name: string) => (name === 'Content-Type' ? 'application/json' : null),
      },
      json: async () => ([{ id: 1, title: 'Set', isSystem: true }]),
    }));

    const result = await VocabularySetService.fetchVocabularySets();
    expect(result.ok).toBe(true);
    if (result.ok) {
      expect(result.data).toHaveLength(1);
      expect(result.data[0].id).toBe(1);
    }
  });

  it('posts progress updates to the correct endpoint', async () => {
    const fetchMock = vi.fn().mockResolvedValue({
      ok: true,
      status: 204,
      headers: { get: () => null },
    });
    vi.stubGlobal('fetch', fetchMock);

    const result = await VocabularySetService.updateVocabularySetProgress(7, 9, { masteryLevel: 88 });
    expect(result.ok).toBe(true);

    expect(fetchMock).toHaveBeenCalledWith(
      expect.stringContaining('/vocabulary-sets/7/progress/9'),
      expect.objectContaining({
        method: 'PUT',
      }),
    );
  });

  it('returns typed error payload when set fetch fails', async () => {
    vi.stubGlobal('fetch', vi.fn().mockResolvedValue({
      ok: false,
      status: 404,
      statusText: 'Not Found',
      headers: {
        get: (name: string) => (name === 'Content-Type' ? 'application/json' : null),
      },
      json: async () => ({ message: 'set not found' }),
    }));

    const result = await VocabularySetService.fetchVocabularySetById(999);
    expect(result.ok).toBe(false);
    if (!result.ok) {
      expect(result.error.message).toBe('set not found');
      expect(result.status).toBe(404);
    }
  });
});
