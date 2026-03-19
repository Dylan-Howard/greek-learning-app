'use client';

import React from 'react';
import { useRouter } from 'next/navigation';
import AuthShell from '@/design-system-v2/components/layouts/AuthShell';
import { LoginForm } from '@/design-system-v2/components/auth/AuthForms';

export default function LoginPage() {
  const router = useRouter();

  async function handleLogin(_email: string, _password: string) {
    await new Promise((r) => setTimeout(r, 300));
    router.push('/reader');
  }

  return (
    <AuthShell>
      <LoginForm
        onSubmit={handleLogin}
        onSignUp={() => router.push('/auth/signup')}
        onGuest={() => router.push('/reader')}
      />
    </AuthShell>
  );
}
