'use client';

import { useState } from 'react';
import { useUser } from '@clerk/nextjs';
import { useRouter } from 'next/navigation';

import Button from '@mui/material/Button';
import Grid from '@mui/material/Grid';
import Stack from '@mui/material/Stack';
import Typography from '@mui/material/Typography';

import WelcomeIllustration from '../welcome/WelcomeIllustration';
import * as AzureUserService from '../services/AzureUserService';
import completeOnboarding from './_actions';
import OnboardingOptionBox from './OnboardingOptionBox';

export default function OnboardingPage() {
  const [userLevel, setUserLevel] = useState(0);
  return (
    <Grid container>
      <Typography variant="h2">Onboarding</Typography>
      <OnboardingOptionBox title="Beginner" value={1} checked={userLevel === 1} onChange={() => setUserLevel(1)} />
    </Grid>
  );
}
