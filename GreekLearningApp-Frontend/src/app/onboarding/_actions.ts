'use server';

import { auth } from '@clerk/nextjs/server';

export default async function completeOnboarding() {
  const { userId } = await auth();

  if (!userId) {
    return { error: 'No user ID found' };
  }

  // In a real app, you would update Clerk metadata here via their SDK
  // or update your own database.
  
  return { message: 'Onboarding complete' };
}
