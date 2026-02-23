// GreekLearningApp-Frontend/src/app/services/apiClient.ts

// Determine if we're on the server or the client
const isServer = typeof window === 'undefined';

// Use internal service name when on server (Docker), otherwise use public URL for browser
const API_BASE_URL = isServer
  ? (process.env.INTERNAL_API_URL || 'http://backend/api')
  : (process.env.NEXT_PUBLIC_API_URL || 'http://localhost:5001/api');

async function request<T>(
  endpoint: string,
  options: RequestInit = {}
): Promise<T> {
  const url = `${API_BASE_URL}/${endpoint.startsWith('/') ? endpoint.slice(1) : endpoint}`;
  
  const headers: Record<string, string> = {
    'Content-Type': 'application/json',
  };

  if (options.headers) {
    const customHeaders = options.headers as Record<string, string>;
    Object.keys(customHeaders).forEach(key => {
      headers[key] = customHeaders[key];
    });
  }

  const config = {
    ...options,
    headers,
  };

  try {
    const response = await fetch(url, config);

    if (response.status === 204 || response.headers.get('Content-Length') === '0') {
      return {} as T;
    }

    const contentType = response.headers.get('Content-Type');
    const isJson = contentType && contentType.includes('application/json');
    const data = isJson ? await response.json() : null;

    if (!response.ok) {
      const errorMessage = data?.message || response.statusText || 'API Request Failed';
      throw new Error(errorMessage);
    }

    return data as T;
  } catch (error) {
    console.error(`API Request Error [${endpoint}]:`, error);
    throw error;
  }
}

export const apiClient = {
  get: <T>(endpoint: string, token?: string | null, options?: RequestInit) => {
    const headers: Record<string, string> = token ? { Authorization: `Bearer ${token}` } : {};
    return request<T>(endpoint, { ...options, method: 'GET', headers });
  },

  post: <T>(endpoint: string, body: any, token?: string | null, options?: RequestInit) => {
    const headers: Record<string, string> = token ? { Authorization: `Bearer ${token}` } : {};
    return request<T>(endpoint, {
      ...options,
      method: 'POST',
      body: JSON.stringify(body),
      headers
    });
  },

  put: <T>(endpoint: string, body: any, token?: string | null, options?: RequestInit) => {
    const headers: Record<string, string> = token ? { Authorization: `Bearer ${token}` } : {};
    return request<T>(endpoint, {
      ...options,
      method: 'PUT',
      body: JSON.stringify(body),
      headers
    });
  },

  delete: <T>(endpoint: string, token?: string | null, options?: RequestInit) => {
    const headers: Record<string, string> = token ? { Authorization: `Bearer ${token}` } : {};
    return request<T>(endpoint, { ...options, method: 'DELETE', headers });
  },
};
