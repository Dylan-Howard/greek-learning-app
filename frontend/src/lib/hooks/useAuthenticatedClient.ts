'use client';

import { useAuth } from '@clerk/nextjs';
import { apiClient } from '@/lib/api/rest/client';

/**
 * Returns a wrapped apiClient that automatically injects the current Clerk
 * session token as a Bearer token on every request.
 *
 * Token is fetched fresh from Clerk on each call — never stored in
 * localStorage, sessionStorage, or cookies.
 */
export function useAuthenticatedClient(): typeof apiClient {
  const { getToken } = useAuth();

  return {
    getResult: async (endpoint, _token, options) => {
      const token = await getToken();
      return apiClient.getResult(endpoint, token, options);
    },
    postResult: async (endpoint, body, _token, options) => {
      const token = await getToken();
      return apiClient.postResult(endpoint, body, token, options);
    },
    putResult: async (endpoint, body, _token, options) => {
      const token = await getToken();
      return apiClient.putResult(endpoint, body, token, options);
    },
    deleteResult: async (endpoint, _token, options) => {
      const token = await getToken();
      return apiClient.deleteResult(endpoint, token, options);
    },
    get: async (endpoint, _token, options) => {
      const token = await getToken();
      return apiClient.get(endpoint, token, options);
    },
    post: async (endpoint, body, _token, options) => {
      const token = await getToken();
      return apiClient.post(endpoint, body, token, options);
    },
    put: async (endpoint, body, _token, options) => {
      const token = await getToken();
      return apiClient.put(endpoint, body, token, options);
    },
    delete: async (endpoint, _token, options) => {
      const token = await getToken();
      return apiClient.delete(endpoint, token, options);
    },
  };
}
