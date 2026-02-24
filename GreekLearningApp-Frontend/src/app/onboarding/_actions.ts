'use server';

export default async function completeOnboarding() {
  // TODO(next phase): Persist onboarding completion once auth is restored.
  return { message: 'Onboarding complete', error: undefined as string | undefined };
}
