import { describe, expect, it } from 'vitest';
import {
  DEFAULT_DEV_USER_ID,
  DEV_USER_STORAGE_KEY,
  getActiveDevUserId,
  sanitizeDevUserId,
  setActiveDevUserId,
} from '@/app/services/devUserSession';

describe('devUserSession', () => {
  it('sanitizes invalid values to default', () => {
    expect(sanitizeDevUserId('invalid')).toBe(DEFAULT_DEV_USER_ID);
    expect(sanitizeDevUserId(undefined)).toBe(DEFAULT_DEV_USER_ID);
  });

  it('sets and gets active dev user id from storage', () => {
    const id = setActiveDevUserId('2');
    expect(id).toBe('2');
    expect(window.localStorage.getItem(DEV_USER_STORAGE_KEY)).toBe('2');
    expect(getActiveDevUserId()).toBe('2');
  });
});
