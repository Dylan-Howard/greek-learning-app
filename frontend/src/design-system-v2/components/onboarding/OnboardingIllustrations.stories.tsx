import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import {
  OnboardingIllustration1,
  OnboardingIllustration2,
  OnboardingIllustration3,
} from './OnboardingIllustrations';

const meta = {
  title: 'Design System/Onboarding/OnboardingIllustrations',
  component: OnboardingIllustration1,
} satisfies Meta<typeof OnboardingIllustration1>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Level1: Story = {
  render: () => <OnboardingIllustration1 />,
};

export const Level2: Story = {
  render: () => <OnboardingIllustration2 />,
};

export const Level3: Story = {
  render: () => <OnboardingIllustration3 />,
};
