'use client';

import { useState } from 'react';
import { useRouter } from 'next/navigation';

import Grid from '@mui/material/Grid';
import Stack from '@mui/material/Stack';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';

import WelcomeIllustration from '@/app/(public)/welcome/WelcomeIllustration';
import * as AzureUserService from '@/lib/api/rest/user';
import { getActiveDevUserId } from '@/lib/services/auth/devSession';
import completeOnboarding from '@/app/(public)/onboarding/_actions';
import { OnboardingOptionBox } from '@/design-system-v2/components/onboarding/OnboardingOptionBox';

const userLevelContent = [
  {
    title: 'Newcomer',
    description: "I'm new and excited to learn!",
    imageUrl: '/DynamicInterlinear/static/img/Onboarding-1.svg',
  },
  {
    title: 'Verse Voyager',
    description: 'I know most of the grammar and know every word that occures more than 50 times.',
    imageUrl: '/DynamicInterlinear/static/img/Onboarding-2.svg',
  },
  {
    title: 'Textual Titan',
    description: "I'm fluent in the grammar and I've learned every word that occurs more than 15 times.",
    imageUrl: '/DynamicInterlinear/static/img/Onboarding-3.svg',
  },
];

export default function OnboardingPage() {
  const router = useRouter();
  const [userLevel, setUserLevel] = useState(0);
  const [error, setError] = useState('');

  const onOptionChange = (value: number) => setUserLevel(value);
  const submitDisabled = userLevel === 0;

  const handleSubmit = async () => {
    const userId = getActiveDevUserId();

    const userCreateResult = await AzureUserService.createUser(
      userId,
      `Dev User ${userId}`,
      userLevel,
    );

    if (!userCreateResult) {
      return;
    }

    const res = await completeOnboarding();
    if (res?.message) {
      router.push('/reader');
    }
    if (res?.error) {
      setError(res?.error);
    }
  };

  return (
    <Grid container sx={{ backgroundColor: 'background.tertiary' }}>
      <Grid
        size={{ sm: 6 }}
        sx={{
          background: 'background.default',
          borderTopRightRadius: { xs: 0, sm: '1rem' },
          borderBottomRightRadius: { xs: 0, sm: '1rem' },
          boxShadow: 3,
          height: 'calc(100vh - env(safe-area-inset-bottom))',
          p: 3,
          pb: 'calc(16px + env(safe-area-inset-bottom))',
        }}
      >
        <form action={handleSubmit}>
          <Typography
            variant="h2"
            sx={{ textAlign: 'center', mt: 8, mb: 2 }}
          >
            Welcome, Scholar!
          </Typography>
          <Typography variant="body1" sx={{ textAlign: 'center', mb: 6 }}>To get you started on your learning journey, let us know how comfortable you already feel with Koine Greek.</Typography>
          <Grid
            container
            spacing={0}
            justifyContent="space-between"
            alignItems="stretch"
            columns={10}
            sx={{ mb: 5 }}
          >
            {
          userLevelContent.map(({ title }, i) => (
            <Grid  size={{ sm: 3 }} key={`onboarding-${title}`}>
              <OnboardingOptionBox
                title={title}
                value={i + 1}
                checked={userLevel === i + 1}
                onChange={() => onOptionChange(i + 1)}
              />
            </Grid>
          ))
        }
          </Grid>
          <Typography variant="body1" sx={{ textAlign: 'center', mb: 6 }}>
            {
          userLevel ? userLevelContent[userLevel - 1].description : ''
        }
          </Typography>
          <Stack flexDirection="row" justifyContent="center" sx={{ mb: 2 }}>
            {
          error && (
            <p>
              Error:
              {error}
            </p>
          )
        }
            <Button variant="contained" type="submit" disabled={submitDisabled}>Create Account</Button>
          </Stack>
        </form>
      </Grid>
      <Grid  size={{ sm: 6 }} sx={{ display: { xs: 'none', sm: 'block' } }}>
        <Stack flexDirection="column" justifyContent="center" alignItems="center" sx={{ height: '100vh' }}>
          <WelcomeIllustration />
        </Stack>
      </Grid>
    </Grid>
  );
}
