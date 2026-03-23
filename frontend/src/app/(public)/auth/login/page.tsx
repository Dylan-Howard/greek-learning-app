'use client';

import React from 'react';
import { useRouter } from 'next/navigation';
import { useSignIn } from '@clerk/nextjs';
import AuthShell from '@/design-system-v2/components/layouts/AuthShell';
import { LoginForm } from '@/design-system-v2/components/auth/AuthForms';

export default function LoginPage() {
  const router = useRouter();
  const { signIn, setActive } = useSignIn();

  async function handleLogin(email: string, password: string): Promise<void> {
    if (!signIn || !setActive) return;

    try {
      const result = await signIn.create({ identifier: email, password });
      if (result.status === 'complete') {
        await setActive({ session: result.createdSessionId });
        router.push('/reader');
      }
    } catch (err: unknown) {
      const clerkErr = err as { errors?: Array<{ longMessage?: string; message: string }> };
      if (clerkErr.errors?.[0]) {
        throw new Error(clerkErr.errors[0].longMessage ?? clerkErr.errors[0].message);
      }
      throw err;
    }
  }

  function handleOAuthClick(e: React.MouseEvent<HTMLDivElement>): void {
    const target = e.target as HTMLElement;
    const button = target.closest('button');
    if (!button || !signIn) return;
    const text = button.textContent ?? '';
    if (text.includes('Google')) {
      void signIn.authenticateWithRedirect({
        strategy: 'oauth_google',
        redirectUrl: '/sso-callback',
        redirectUrlComplete: '/reader',
      });
    } else if (text.includes('Apple')) {
      void signIn.authenticateWithRedirect({
        strategy: 'oauth_apple',
        redirectUrl: '/sso-callback',
        redirectUrlComplete: '/reader',
      });
    }
  }

  return (
    <div role="presentation" onClick={handleOAuthClick}>
      <AuthShell>
        <LoginForm
          onSubmit={handleLogin}
          onSignUp={() => router.push('/auth/signup')}
          onGuest={() => router.push('/reader')}
        />
      </AuthShell>
    </div>
  );
}
