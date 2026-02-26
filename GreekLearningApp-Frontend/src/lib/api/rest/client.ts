// GreekLearningApp-Frontend/src/app/services/apiClient.ts

// Determine if we're on the server or the client.
const isServer = typeof window === 'undefined';

// Resolve API base URL for both local and containerized server rendering:
// 1) INTERNAL_API_URL (Docker/compose)
// 2) NEXT_PUBLIC_API_URL (local dev)
// 3) localhost fallback
const API_BASE_URL = (() => {
  const internalApiUrl = process.env.INTERNAL_API_URL;
  const publicApiUrl = process.env.NEXT_PUBLIC_API_URL;

  if (isServer) {
    return internalApiUrl || publicApiUrl || 'http://localhost:5001/api';
  }

  return publicApiUrl || 'http://localhost:5001/api';
})();

export interface ApiError {
  endpoint: string;
  message: string;
  status: number;
  details?: unknown;
}

export type ApiResult<T> =
  | { ok: true; status: number; data: T }
  | { ok: false; status: number; error: ApiError };

function buildUrl(endpoint: string): string {
  return `${API_BASE_URL}/${endpoint.startsWith('/') ? endpoint.slice(1) : endpoint}`;
}

function buildHeaders(options: RequestInit, token?: string | null): Record<string, string> {
  const headers: Record<string, string> = {
    'Content-Type': 'application/json',
  };

  if (token) {
    headers.Authorization = `Bearer ${token}`;
  }

  if (options.headers) {
    const customHeaders = options.headers as Record<string, string>;
    Object.keys(customHeaders).forEach((key) => {
      headers[key] = customHeaders[key];
    });
  }

  return headers;
}

async function requestResult<T>(
  endpoint: string,
  options: RequestInit = {},
  token?: string | null,
): Promise<ApiResult<T>> {
  const url = buildUrl(endpoint);
  const config: RequestInit = {
    cache: 'no-store',
    ...options,
    headers: buildHeaders(options, token),
  };

  try {
    const response = await fetch(url, config);
    const contentType = response.headers.get('Content-Type');
    const isJson = contentType?.includes('application/json') ?? false;
    const isEmpty = response.status === 204 || response.headers.get('Content-Length') === '0';
    const payload = isEmpty ? null : (isJson ? await response.json() : null);

    if (!response.ok) {
      return {
        ok: false,
        status: response.status,
        error: {
          endpoint,
          status: response.status,
          message: (payload as { message?: string } | null)?.message || response.statusText || 'API Request Failed',
          details: payload,
        },
      };
    }

    return {
      ok: true,
      status: response.status,
      data: (isEmpty ? ({} as T) : (payload as T)),
    };
  } catch (error) {
    const message = error instanceof Error ? error.message : 'Network request failed';
    return {
      ok: false,
      status: 0,
      error: {
        endpoint,
        status: 0,
        message,
        details: error,
      },
    };
  }
}

async function request<T>(
  endpoint: string,
  options: RequestInit = {},
  token?: string | null,
): Promise<T> {
  const result = await requestResult<T>(endpoint, options, token);
  if (result.ok) {
    return result.data;
  }

  console.error(`API Request Error [${endpoint}]:`, result.error);
  throw new Error(result.error.message);
}

export const apiClient = {
  getResult: <T>(endpoint: string, token?: string | null, options?: RequestInit) =>
    requestResult<T>(endpoint, { ...options, method: 'GET' }, token),

  postResult: <T>(endpoint: string, body: unknown, token?: string | null, options?: RequestInit) =>
    requestResult<T>(
      endpoint,
      {
        ...options,
        method: 'POST',
        body: JSON.stringify(body),
      },
      token,
    ),

  putResult: <T>(endpoint: string, body: unknown, token?: string | null, options?: RequestInit) =>
    requestResult<T>(
      endpoint,
      {
        ...options,
        method: 'PUT',
        body: JSON.stringify(body),
      },
      token,
    ),

  deleteResult: <T>(endpoint: string, token?: string | null, options?: RequestInit) =>
    requestResult<T>(endpoint, { ...options, method: 'DELETE' }, token),

  get: <T>(endpoint: string, token?: string | null, options?: RequestInit) =>
    request<T>(endpoint, { ...options, method: 'GET' }, token),

  post: <T>(endpoint: string, body: unknown, token?: string | null, options?: RequestInit) =>
    request<T>(
      endpoint,
      {
        ...options,
        method: 'POST',
        body: JSON.stringify(body),
      },
      token,
    ),

  put: <T>(endpoint: string, body: unknown, token?: string | null, options?: RequestInit) =>
    request<T>(
      endpoint,
      {
        ...options,
        method: 'PUT',
        body: JSON.stringify(body),
      },
      token,
    ),

  delete: <T>(endpoint: string, token?: string | null, options?: RequestInit) =>
    request<T>(endpoint, { ...options, method: 'DELETE' }, token),
};
