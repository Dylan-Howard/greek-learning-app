export const DEV_USER_STORAGE_KEY = 'koine-dev-user-id';
export const DEV_USER_COOKIE_KEY = 'koine_dev_user_id';
export const DEV_USER_CHANGED_EVENT = 'koine-dev-user-changed';
export const DEFAULT_DEV_USER_ID = '1';
export const DEV_USER_OPTIONS = ['1', '2', '3', '4', '5'];

export function sanitizeDevUserId(id?: string | null): string {
  if (!id) return DEFAULT_DEV_USER_ID;
  return DEV_USER_OPTIONS.includes(id) ? id : DEFAULT_DEV_USER_ID;
}

export function setActiveDevUserId(id: string): string {
  const sanitized = sanitizeDevUserId(id);

  if (typeof window !== 'undefined') {
    window.localStorage.setItem(DEV_USER_STORAGE_KEY, sanitized);
    window.dispatchEvent(new CustomEvent(DEV_USER_CHANGED_EVENT, { detail: sanitized }));
  }

  if (typeof document !== 'undefined') {
    document.cookie = `${DEV_USER_COOKIE_KEY}=${sanitized}; path=/; max-age=2592000; samesite=lax`;
  }

  return sanitized;
}

export function getActiveDevUserId(): string {
  if (typeof window === 'undefined') {
    return DEFAULT_DEV_USER_ID;
  }

  const saved = window.localStorage.getItem(DEV_USER_STORAGE_KEY);
  if (saved) {
    return sanitizeDevUserId(saved);
  }

  return setActiveDevUserId(DEFAULT_DEV_USER_ID);
}
