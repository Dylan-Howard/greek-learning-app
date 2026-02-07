
// frontend/src/api/client.ts
import { Configuration } from './generated/api-client';

const API_BASE_URL = import.meta.env.VITE_API_BASE_URL || 'http://localhost:5000';

// Get dev token on app start in development
export async function getDevToken(): Promise<string> {
  if (import.meta.env.PROD) {
    throw new Error('Dev token not available in production');
  }

  const response = await fetch(`${API_BASE_URL}/api/dev/token?username=intermediate`);
  const data = await response.json();
  
  if (data.token) {
    localStorage.setItem('auth_token', data.token);
    return data.token;
  }
  
  throw new Error('Failed to get dev token');
}

export function getApiConfig(): Configuration {
  const token = localStorage.getItem('auth_token');
  
  return new Configuration({
    basePath: API_BASE_URL,
    headers: token ? { Authorization: `Bearer ${token}` } : undefined
  });
}