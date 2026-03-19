'use client';

import React from 'react';
import { useRouter } from 'next/navigation';
import AuthShell from '@/design-system-v2/components/layouts/AuthShell';
import { SignUpForm } from '@/design-system-v2/components/auth/AuthForms';

export default function SignUpPage() {
  const router = useRouter();

  async function handleSignup(_email: string, _password: string) {
    await new Promise((r) => setTimeout(r, 300));
    router.push('/reader');
  }

  return (
    <AuthShell>
      <SignUpForm
        onSubmit={handleSignup}
        onLogin={() => router.push('/auth/login')}
        onGuest={() => router.push('/reader')}
      />
    </AuthShell>
  );
}
