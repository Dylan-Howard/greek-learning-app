'use client';

import React from 'react';
import { useRouter } from 'next/navigation';
import { useSignUp } from '@clerk/nextjs';
import AuthShell from '@/design-system-v2/components/layouts/AuthShell';
import { SignUpForm } from '@/design-system-v2/components/auth/AuthForms';

export default function SignUpPage() {
  const router = useRouter();
  const { signUp, setActive } = useSignUp();

  async function handleSignup(email: string, password: string): Promise<void> {
    if (!signUp || !setActive) return;
    try {
      const result = await signUp.create({ emailAddress: email, password });
      if (result.status === 'complete') {
        await setActive({ session: result.createdSessionId });
        router.push('/onboarding');
      }
      // If email verification required, result.status === 'missing_requirements' — no redirect yet
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
    if (!button || !signUp) return;
    const text = button.textContent ?? '';
    if (text.includes('Google')) {
      void signUp.authenticateWithRedirect({
        strategy: 'oauth_google',
        redirectUrl: '/sso-callback',
        redirectUrlComplete: '/onboarding',
      });
    } else if (text.includes('Apple')) {
      void signUp.authenticateWithRedirect({
        strategy: 'oauth_apple',
        redirectUrl: '/sso-callback',
        redirectUrlComplete: '/onboarding',
      });
    }
  }

  return (
    <div role="presentation" onClick={handleOAuthClick}>
      <AuthShell>
        <SignUpForm
          onSubmit={handleSignup}
          onLogin={() => router.push('/auth/login')}
          onGuest={() => router.push('/reader')}
        />
      </AuthShell>
    </div>
  );
}
