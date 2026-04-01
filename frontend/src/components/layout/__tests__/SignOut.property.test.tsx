/**
 * Property 12: Sign-out resets UserContext to guest state
 * Validates: Requirements 13.3
 */
import { render, fireEvent, waitFor } from '@testing-library/react';
import { vi, describe, it, beforeEach } from 'vitest';
import * as fc from 'fast-check';
import React from 'react';

// ── Mocks ────────────────────────────────────────────────────────────────────

vi.mock('next/navigation', () => ({
  useRouter: () => ({ push: vi.fn() }),
}));

const mockSignOut = vi.fn();
vi.mock('@clerk/nextjs', () => ({
  useClerk: () => ({ signOut: mockSignOut }),
}));

vi.mock('@/lib/api/graphql/client', () => ({
  _resetApolloClientForTesting: vi.fn(),
}));

const mockSetUser = vi.fn();
let mockUser = { id: 'user_abc', name: 'Test', totalExp: 0, progress: { lessons: [], vocabulary: [] }, settings: { prefersDarkMode: false, translation: 'esv' } };

vi.mock('@/lib/types/domain/user', () => ({
  useUserContext: () => ({
    user: mockUser,
    setUser: mockSetUser,
    syncUser: vi.fn(),
    awardExp: vi.fn(),
    expQueue: [],
    consumeExp: vi.fn(),
  }),
}));

vi.mock('@/lib/services/user/gamification', () => ({
  avatarInitial: () => 'T',
  experienceProgressPercent: () => 0,
  levelFromExperience: () => 1,
}));

vi.mock('@/design-system-v2/components/layouts/AppShell', () => ({
  default: ({ children }: { children: React.ReactNode }) => <div>{children}</div>,
}));

vi.mock('@/design-system-v2/components/nav/UserAvatarBadge', () => ({
  default: () => <div />,
}));

const guestState = {
  id: 'guest',
  name: 'Guest',
  totalExp: 0,
  progress: { lessons: [], vocabulary: [] },
  settings: { prefersDarkMode: false, translation: 'esv' },
};

vi.mock('@/lib/api/rest/user', () => ({
  getDefaultUserState: () => guestState,
}));

import { AppShell } from '../AppShell';

beforeEach(() => {
  vi.clearAllMocks();
  mockSignOut.mockResolvedValue(undefined);
});

describe('Property 12: Sign-out resets UserContext to guest state', () => {
  it('always calls setUser with getDefaultUserState() for any authenticated user shape', async () => {
    await fc.assert(
      fc.asyncProperty(
        fc.record({
          id: fc.string({ minLength: 1 }),
          name: fc.string({ minLength: 1 }),
          totalExp: fc.integer({ min: 0, max: 100000 }),
        }),
        async (userShape) => {
          mockSetUser.mockClear();
          mockUser = {
            ...userShape,
            progress: { lessons: [], vocabulary: [] },
            settings: { prefersDarkMode: false, translation: 'esv' },
          };

          const { unmount, getByRole } = render(
            <AppShell><div /></AppShell>
          );

          fireEvent.click(getByRole('button', { name: /sign out/i }));

          await waitFor(() => {
            expect(mockSetUser).toHaveBeenCalledWith(guestState);
          });

          unmount();
        }
      ),
      { numRuns: 50 }
    );
  }, 30000);
});
