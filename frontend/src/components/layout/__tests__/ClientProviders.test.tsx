import { render, screen, waitFor } from '@testing-library/react';
import { vi, describe, it, expect, beforeEach } from 'vitest';
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
    <div data-testid="apollo-provider">{children}</div>
  ),
}));

// Import after mocks are set up
import ClientProviders from '../ClientProviders';

const guestState = {
  id: 'guest',
  name: 'Guest',
  totalExp: 0,
  progress: { lessons: [], vocabulary: [] },
  settings: { prefersDarkMode: false, translation: 'esv' },
};

const mockUser = {
  id: 'user_abc123',
  name: 'Test User',
  totalExp: 100,
  progress: { lessons: [], vocabulary: [] },
  settings: { prefersDarkMode: false, translation: 'esv' },
};

beforeEach(() => {
  vi.clearAllMocks();
  mockGetDefaultUserState.mockReturnValue(guestState);
  mockFetchUser.mockResolvedValue(mockUser);
});

describe('ClientProviders', () => {
  it('renders nothing (null) when isLoaded is false, and does not call fetchUser', async () => {
    mockUseUser.mockReturnValue({ isLoaded: false, isSignedIn: false, user: null });

    const { container } = render(
      <ClientProviders>
        <div data-testid="child">child content</div>
      </ClientProviders>
    );

    // Component returns null when not loaded
    expect(container.firstChild).toBeNull();
    expect(mockFetchUser).not.toHaveBeenCalled();
  });

  it('sets guest state when isSignedIn is false, and does not call fetchUser', async () => {
    mockUseUser.mockReturnValue({ isLoaded: true, isSignedIn: false, user: null });

    render(
      <ClientProviders>
        <div data-testid="child">child content</div>
      </ClientProviders>
    );

    // Children should render (isLoaded is true)
    expect(screen.getByTestId('child')).toBeTruthy();

    // fetchUser should NOT be called
    expect(mockFetchUser).not.toHaveBeenCalled();

    // getDefaultUserState should have been called (for initial state + effect)
    expect(mockGetDefaultUserState).toHaveBeenCalled();
  });

  it('calls fetchUser with user.id when isSignedIn is true', async () => {
    const clerkUserId = 'user_clerk_xyz789';
    mockUseUser.mockReturnValue({
      isLoaded: true,
      isSignedIn: true,
      user: { id: clerkUserId },
    });

    render(
      <ClientProviders>
        <div data-testid="child">child content</div>
      </ClientProviders>
    );

    await waitFor(() => {
      expect(mockFetchUser).toHaveBeenCalledWith(clerkUserId);
    });
  });
});
