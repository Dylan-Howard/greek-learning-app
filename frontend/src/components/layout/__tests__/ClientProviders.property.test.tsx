/**
 * Property 7: Authenticated Clerk user always triggers `fetchUser`
 * Validates: Requirements 7.2
 */
import { render, waitFor } from '@testing-library/react';
import { vi, describe, it, expect, beforeEach } from 'vitest';
import * as fc from 'fast-check';
import React from 'react';

// Mock @clerk/nextjs
const mockUseUser = vi.fn();
vi.mock('@clerk/nextjs', () => ({
  useUser: () => mockUseUser(),
}));

// Mock UserService
const mockFetchUser = vi.fn();
const mockGetDefaultUserState = vi.fn();
vi.mock('@/lib/api/rest/user', () => ({
  fetchUser: (...args: unknown[]) => mockFetchUser(...args),
  getDefaultUserState: () => mockGetDefaultUserState(),
}));

// Mock ApolloClientProvider — render children passthrough
vi.mock('@/components/layout/ApolloClientProvider', () => ({
  ApolloClientProvider: ({ children }: { children: React.ReactNode }) => (
    <div>{children}</div>
  ),
}));

import ClientProviders from '../ClientProviders';

const guestState = {
  id: 'guest',
  name: 'Guest',
  totalExp: 0,
  progress: { lessons: [], vocabulary: [] },
  settings: { prefersDarkMode: false, translation: 'esv' },
};

beforeEach(() => {
  vi.clearAllMocks();
  mockGetDefaultUserState.mockReturnValue(guestState);
  mockFetchUser.mockResolvedValue(guestState);
});

describe('Property 7: Authenticated Clerk user always triggers fetchUser', () => {
  it('calls fetchUser with the exact Clerk user ID for any arbitrary ID string', async () => {
    await fc.assert(
      fc.asyncProperty(
        fc.string({ minLength: 5 }),
        async (clerkId) => {
          mockFetchUser.mockClear();
          mockUseUser.mockReturnValue({
            isLoaded: true,
            isSignedIn: true,
            user: { id: clerkId },
          });

          const { unmount } = render(
            <ClientProviders>
              <div />
            </ClientProviders>
          );

          await waitFor(() => {
            expect(mockFetchUser).toHaveBeenCalledWith(clerkId);
          });

          unmount();
        }
      ),
      { numRuns: 100 }
    );
  });
});
