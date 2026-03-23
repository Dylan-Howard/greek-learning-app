import { describe, it, expect, vi, beforeEach } from 'vitest';
import React from 'react';
import { render, screen, fireEvent, waitFor } from '@testing-library/react';

// ── Mocks ────────────────────────────────────────────────────────────────────

const mockPush = vi.fn();
vi.mock('next/navigation', () => ({
  useRouter: () => ({ push: mockPush }),
}));

const mockSetActive = vi.fn();
const mockSignUpCreate = vi.fn();

vi.mock('@clerk/nextjs', () => ({
  useSignUp: () => ({
    signUp: { create: mockSignUpCreate },
    setActive: mockSetActive,
  }),
}));

vi.mock('@/design-system-v2/components/layouts/AuthShell', () => ({
  default: ({ children }: { children: React.ReactNode }) => (
    <div data-testid="auth-shell">{children}</div>
  ),
}));

// Minimal SignUpForm: renders a form that calls onSubmit(email, password) on submit
// and surfaces errors via an Alert role="alert" element.
vi.mock('@/design-system-v2/components/auth/AuthForms', () => ({
  SignUpForm: ({
    onSubmit,
  }: {
    onSubmit: (email: string, password: string) => Promise<void>;
    onLogin: () => void;
    onGuest?: () => void;
  }) => {
    const [error, setError] = React.useState('');
    async function handleSubmit(e: React.FormEvent<HTMLFormElement>) {
      e.preventDefault();
      const form = e.currentTarget;
      const email = (form.elements.namedItem('email') as HTMLInputElement).value;
      const password = (form.elements.namedItem('password') as HTMLInputElement).value;
      try {
        await onSubmit(email, password);
      } catch (err: unknown) {
        setError((err as Error).message ?? 'Error');
      }
    }
    return (
      <form onSubmit={handleSubmit}>
        {error && <div role="alert">{error}</div>}
        <input name="email" defaultValue="user@example.com" />
        <input name="password" type="password" defaultValue="secret" />
        <button type="submit">Create Account</button>
      </form>
    );
  },
}));

// ── Tests ────────────────────────────────────────────────────────────────────

describe('SignUpPage', () => {
  beforeEach(() => {
    vi.clearAllMocks();
  });

  it('calls setActive with the session ID and navigates to /onboarding on successful sign-up', async () => {
    mockSignUpCreate.mockResolvedValue({
      status: 'complete',
      createdSessionId: 'sess_xyz789',
    });
    mockSetActive.mockResolvedValue(undefined);

    const { default: SignUpPage } = await import('../page');
    render(<SignUpPage />);

    fireEvent.click(screen.getByRole('button', { name: /create account/i }));

    await waitFor(() => {
      expect(mockSignUpCreate).toHaveBeenCalledWith({
        emailAddress: 'user@example.com',
        password: 'secret',
      });
      expect(mockSetActive).toHaveBeenCalledWith({ session: 'sess_xyz789' });
      expect(mockPush).toHaveBeenCalledWith('/onboarding');
    });
  });

  it('surfaces Clerk error message via the SignUpForm onSubmit rejection', async () => {
    mockSignUpCreate.mockRejectedValue({
      errors: [{ longMessage: 'Email already in use', message: 'Email already in use' }],
    });

    const { default: SignUpPage } = await import('../page');
    render(<SignUpPage />);

    fireEvent.click(screen.getByRole('button', { name: /create account/i }));

    await waitFor(() => {
      expect(screen.getByRole('alert')).toHaveTextContent('Email already in use');
    });

    expect(mockSetActive).not.toHaveBeenCalled();
    expect(mockPush).not.toHaveBeenCalled();
  });
});
