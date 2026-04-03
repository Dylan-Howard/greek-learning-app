import { describe, it, expect, vi, afterEach } from 'vitest';
import React from 'react';

// Top-level hoisted mocks
vi.mock('@clerk/nextjs', () => ({
  ClerkProvider: ({ children }: { children: React.ReactNode }) => (
    <div data-testid="clerk-provider">{children}</div>
  ),
}));
vi.mock('@mui/material/InitColorSchemeScript', () => ({ default: () => null }));
vi.mock('next/font/google', () => ({
  Noto_Sans: () => ({ variable: 'noto-sans' }),
  Noto_Serif: () => ({ variable: 'noto-serif' }),
}));
vi.mock('@/theme/ThemeProvider', () => ({
  default: ({ children }: { children: React.ReactNode }) => (
    <div data-testid="theme-provider">{children}</div>
  ),
}));
vi.mock('@/components/layout/ClientProviders', () => ({
  default: ({ children }: { children: React.ReactNode }) => (
    <div data-testid="client-providers">{children}</div>
  ),
}));
vi.mock('@/styles/globals.css', () => ({}));

/**
 * Walk a React element tree and return true if any node has the given type.
 */
function containsType(node: React.ReactNode, type: unknown): boolean {
  if (!React.isValidElement(node)) return false;
  if (node.type === type) return true;
  const props = node.props as Record<string, unknown>;
  const children = props['children'];
  if (Array.isArray(children)) {
    return children.some((c) => containsType(c as React.ReactNode, type));
  }
  return containsType(children as React.ReactNode, type);
}

/**
 * Return the outermost React element type from a JSX tree.
 */
function outermostType(node: React.ReactNode): unknown {
  if (!React.isValidElement(node)) return null;
  return node.type;
}

type RootLayoutComponent = (props: {
  children: React.ReactNode;
}) => Promise<React.ReactElement> | React.ReactElement;

describe('RootLayout', () => {
  afterEach(() => {
    vi.unstubAllEnvs();
  });

  it('renders ClerkProvider as the outermost wrapper', async () => {
    vi.stubEnv('NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY', 'pk_test_abc123');

    const { default: RootLayout } = await import('./layout.js') as unknown as { default: RootLayoutComponent };
    const { ClerkProvider } = await import('@clerk/nextjs');

    const jsx = await RootLayout({ children: <span>hello</span> });

    // ClerkProvider must be the outermost element
    expect(outermostType(jsx)).toBe(ClerkProvider);
  });

  it('passes signInUrl, signUpUrl, afterSignInUrl, afterSignUpUrl from env vars', async () => {
    vi.stubEnv('NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY', 'pk_test_abc123');
    vi.stubEnv('NEXT_PUBLIC_CLERK_SIGN_IN_URL', '/auth/login');
    vi.stubEnv('NEXT_PUBLIC_CLERK_SIGN_UP_URL', '/auth/signup');
    vi.stubEnv('NEXT_PUBLIC_CLERK_SIGN_IN_FALLBACK_REDIRECT_URL', '/reader');
    vi.stubEnv('NEXT_PUBLIC_CLERK_SIGN_UP_FORCE_REDIRECT_URL', '/onboarding');

    const { default: RootLayout } = await import('./layout.js') as unknown as { default: RootLayoutComponent };

    const jsx = await RootLayout({ children: <span>hello</span> });

    expect(React.isValidElement(jsx)).toBe(true);
    const props = (jsx as React.ReactElement<Record<string, unknown>>).props;
    expect(props['signInUrl']).toBe('/auth/login');
    expect(props['signUpUrl']).toBe('/auth/signup');
    expect(props['afterSignInUrl']).toBe('/reader');
    expect(props['afterSignUpUrl']).toBe('/onboarding');
  });

  it('throws when NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY is absent', async () => {
    vi.resetModules();
    delete process.env.NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY;

    vi.doMock('@clerk/nextjs', () => ({
      ClerkProvider: ({ children }: { children: React.ReactNode }) => (
        <div data-testid="clerk-provider">{children}</div>
      ),
    }));
    vi.doMock('@mui/material/InitColorSchemeScript', () => ({ default: () => null }));
    vi.doMock('@/theme/ThemeProvider', () => ({
      default: ({ children }: { children: React.ReactNode }) => <div>{children}</div>,
    }));
    vi.doMock('@/components/layout/ClientProviders', () => ({
      default: ({ children }: { children: React.ReactNode }) => <div>{children}</div>,
    }));
    vi.doMock('@/styles/globals.css', () => ({}));

    await expect(import('./layout.js')).rejects.toThrow(
      'NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY is required'
    );
  });
});
