import { afterEach } from 'vitest';
import { vi } from 'vitest';
import '@testing-library/jest-dom';

afterEach(() => {
  vi.restoreAllMocks();
});
