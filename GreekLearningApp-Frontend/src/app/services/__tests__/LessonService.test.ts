import * as LessonService from '../LessonService';

describe('LessonService', () => {
  beforeEach(() => {
    process.env.NEXT_PUBLIC_API_URL = 'http://localhost:5999/api';
  });

  it('fetches lesson tracks with typed response', async () => {
    vi.stubGlobal('fetch', vi.fn().mockResolvedValue({
      ok: true,
      status: 200,
      headers: {
        get: (name: string) => (name === 'Content-Type' ? 'application/json' : null),
      },
      json: async () => ([{ id: 1, slug: 'core', title: 'Core', lessons: [] }]),
    }));

    const result = await LessonService.fetchLessonTracks();
    expect(result.ok).toBe(true);
    if (result.ok) {
      expect(result.data[0].slug).toBe('core');
    }
  });

  it('posts completion to the correct endpoint', async () => {
    const fetchMock = vi.fn().mockResolvedValue({
      ok: true,
      status: 200,
      headers: {
        get: (name: string) => (name === 'Content-Type' ? 'application/json' : null),
      },
      json: async () => ({ message: 'ok' }),
    });
    vi.stubGlobal('fetch', fetchMock);

    const result = await LessonService.completeLesson(7, { score: 100 });
    expect(result.ok).toBe(true);
    expect(fetchMock).toHaveBeenCalledWith(
      expect.stringContaining('/lessons/7/complete'),
      expect.objectContaining({ method: 'POST' }),
    );
  });
});
