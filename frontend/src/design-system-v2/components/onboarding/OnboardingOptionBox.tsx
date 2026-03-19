'use client';

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import { tokens } from '@/design-system-v2/theme/theme';
import { OnboardingIllustration1, OnboardingIllustration2, OnboardingIllustration3 } from './OnboardingIllustrations';

const illustrationMap: Record<number, React.ComponentType> = {
  1: OnboardingIllustration1,
  2: OnboardingIllustration2,
  3: OnboardingIllustration3,
};

export interface OnboardingOptionBoxProps {
  title: string;
  value: number;
  checked: boolean;
  onChange: React.ChangeEventHandler<HTMLInputElement>;
}

export function OnboardingOptionBox({
  title,
  value,
  checked,
  onChange,
}: OnboardingOptionBoxProps) {
  const Illustration = illustrationMap[value] ?? OnboardingIllustration1;

  return (
    <label htmlFor={`onboarding-radio-${value}`} style={{ cursor: 'pointer', display: 'block' }}>
      <input
        className="OptionRadio"
        type="radio"
        id={`onboarding-radio-${value}`}
        name="userLevel"
        value={value}
        onChange={onChange}
        checked={checked}
        style={{ position: 'absolute', opacity: 0, pointerEvents: 'none' }}
      />
      <Box
        sx={{
          p: 2,
          border: `1px solid ${checked ? tokens.color.primary : tokens.color.border}`,
          borderRadius: tokens.radius.md,
          cursor: 'pointer',
          opacity: checked ? 1 : 0.7,
          bgcolor: checked ? tokens.color.primaryLight : tokens.color.bg,
          transition: `all ${tokens.motion.fast} ${tokens.motion.ease}`,
          '&:hover': {
            borderColor: tokens.color.primary,
          },
        }}
      >
        <Illustration />
        <Typography variant="h6" align="center">
          {title}
        </Typography>
      </Box>
    </label>
  );
}
