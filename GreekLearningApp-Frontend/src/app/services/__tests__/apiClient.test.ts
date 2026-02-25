import { apiClient } from '../apiClient';

describe('apiClient', () => {
  beforeEach(() => {
    process.env.NEXT_PUBLIC_API_URL = 'http://localhost:5999/api';
  });

  it('returns parsed JSON payload for successful GET requests', async () => {
    vi.stubGlobal('fetch', vi.fn().mockResolvedValue({
      ok: true,
      status: 200,
      headers: {
        get: (name: string) => (name === 'Content-Type' ? 'application/json' : null),
      },
      json: async () => ({ ok: true }),
    }));

    const result = await apiClient.get<{ ok: boolean }>('books');
    expect(result.ok).toBe(true);
  });

  it('throws API message for failing responses', async () => {
    vi.stubGlobal('fetch', vi.fn().mockResolvedValue({
      ok: false,
      status: 400,
      statusText: 'Bad Request',
      headers: {
        get: (name: string) => (name === 'Content-Type' ? 'application/json' : null),
      },
      json: async () => ({ message: 'validation failed' }),
    }));

    await expect(apiClient.post('books', { title: 'x' })).rejects.toThrow('validation failed');
  });

  it('returns typed error with getResult', async () => {
    vi.stubGlobal('fetch', vi.fn().mockResolvedValue({
      ok: false,
      status: 401,
      statusText: 'Unauthorized',
      headers: {
        get: (name: string) => (name === 'Content-Type' ? 'application/json' : null),
      },
      json: async () => ({ message: 'token expired' }),
    }));

    const result = await apiClient.getResult<{ id: number }>('books');
    expect(result.ok).toBe(false);
    if (!result.ok) {
      expect(result.error.message).toBe('token expired');
      expect(result.status).toBe(401);
    }
  });

  it('handles 204 empty responses', async () => {
    vi.stubGlobal('fetch', vi.fn().mockResolvedValue({
      ok: true,
      status: 204,
      headers: { get: () => null },
    }));

    const result = await apiClient.delete<Record<string, never>>('books/1');
    expect(result).toEqual({});
  });
});
