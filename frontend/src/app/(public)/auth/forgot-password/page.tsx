'use client';

import React from 'react';
import { useRouter } from 'next/navigation';
import AuthShell from '@/components/layouts/AuthShell';
import { ForgotPasswordForm } from '@/components/auth/AuthForms';

export default function ForgotPasswordPage() {
  const router = useRouter();

  async function handleReset(_email: string) {
    await new Promise((r) => setTimeout(r, 300));
  }

  return (
    <AuthShell>
      <ForgotPasswordForm
        onSubmit={handleReset}
        onBack={() => router.push('/auth/login')}
      />
    </AuthShell>
  );
}
