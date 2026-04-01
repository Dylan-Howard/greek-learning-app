/**
 * Unit tests for sign-out flow in AppShell.
 * Validates: Requirements 13.1, 13.2, 13.3, 13.4
 */
import { render, screen, fireEvent, waitFor } from '@testing-library/react';
import { vi, describe, it, expect, beforeEach } from 'vitest';
import React from 'react';

// ── Mocks ────────────────────────────────────────────────────────────────────

const mockPush = vi.fn();
vi.mock('next/navigation', () => ({
  useRouter: () => ({ push: mockPush }),
}));

const mockSignOut = vi.fn();
vi.mock('@clerk/nextjs', () => ({
  useClerk: () => ({ signOut: mockSignOut }),
}));

const mockResetApollo = vi.fn();
vi.mock('@/lib/api/graphql/client', () => ({
  _resetApolloClientForTesting: () => mockResetApollo(),
}));

const mockGetDefaultUserState = vi.fn();
vi.mock('@/lib/api/rest/user', () => ({
  getDefaultUserState: () => mockGetDefaultUserState(),
}));

const mockSetUser = vi.fn();
vi.mock('@/lib/types/domain/user', () => ({
  useUserContext: () => ({
    user: { id: 'user_abc', name: 'Test User', totalExp: 100, progress: { lessons: [], vocabulary: [] }, settings: { prefersDarkMode: false, translation: 'esv' } },
    setUser: mockSetUser,
    syncUser: vi.fn(),
    awardExp: vi.fn(),
    expQueue: [],
    consumeExp: vi.fn(),
  }),
}));

vi.mock('@/lib/services/user/gamification', () => ({
  avatarInitial: (name: string) => name?.[0] ?? 'G',
  experienceProgressPercent: () => 0,
  levelFromExperience: () => 1,
}));

vi.mock('@/design-system-v2/components/layouts/AppShell', () => ({
  default: ({ children }: { children: React.ReactNode }) => (
    <div data-testid="app-shell-layout">{children}</div>
  ),
}));

vi.mock('@/design-system-v2/components/nav/UserAvatarBadge', () => ({
  default: () => <div />,
}));

import { AppShell } from '../AppShell';

const guestState = {
  id: 'guest',
  name: 'Guest',
  totalExp: 0,
  progress: { lessons: [], vocabulary: [] },
  settings: { prefersDarkMode: false, translation: 'esv' },
};

beforeEach(() => {
  vi.clearAllMocks();
  mockSignOut.mockResolvedValue(undefined);
  mockGetDefaultUserState.mockReturnValue(guestState);
});

describe('AppShell sign-out flow', () => {
  it('calls signOut() when the sign-out button is clicked', async () => {
    render(<AppShell><div>content</div></AppShell>);
    fireEvent.click(screen.getByRole('button', { name: /sign out/i }));
    await waitFor(() => expect(mockSignOut).toHaveBeenCalledTimes(1));
  });

  it('redirects to /welcome after sign-out', async () => {
    render(<AppShell><div>content</div></AppShell>);
    fireEvent.click(screen.getByRole('button', { name: /sign out/i }));
    await waitFor(() => expect(mockPush).toHaveBeenCalledWith('/welcome'));
  });

  it('resets UserContext to guest state after sign-out', async () => {
    render(<AppShell><div>content</div></AppShell>);
    fireEvent.click(screen.getByRole('button', { name: /sign out/i }));
    await waitFor(() => expect(mockSetUser).toHaveBeenCalledWith(guestState));
  });

  it('resets Apollo cache after sign-out', async () => {
    render(<AppShell><div>content</div></AppShell>);
    fireEvent.click(screen.getByRole('button', { name: /sign out/i }));
    await waitFor(() => expect(mockResetApollo).toHaveBeenCalled());
  });
});
