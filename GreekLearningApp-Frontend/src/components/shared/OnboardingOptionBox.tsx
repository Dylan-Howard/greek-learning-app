'use client';

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import { OnboardingIllustration1, OnboardingIllustration2, OnboardingIllustration3 } from '@/components/shared/OnboardingIllustrations';

const illustrationMap: { [key: number]: any } = {
  1: OnboardingIllustration1,
  2: OnboardingIllustration2,
  3: OnboardingIllustration3,
};

export default function OnboardingOptionBox({
  title,
  value,
  checked,
  onChange,
}: {
  title: string;
  value: number;
  checked: boolean;
  onChange: React.ChangeEventHandler<HTMLInputElement>;
}) {
  const Illustration = illustrationMap[value] || OnboardingIllustration1;
  return (
    <label htmlFor={`onboarding-radio-${value}`} className="OptionContainer">
      <input
        className="OptionRadio"
        type="radio"
        id={`onboarding-radio-${value}`}
        name="userLevel"
        value={value}
        onChange={onChange}
        checked={checked}
      />
      <Box className="OptionContent" sx={{ p: 2, border: '1px solid #ccc', cursor: 'pointer', opacity: checked ? 1 : 0.6 }}>
        <Illustration />
        <Typography variant="h6" align="center">{title}</Typography>
      </Box>
    </label>
  );
}
