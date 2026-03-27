import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import { OnboardingOptionBox } from './OnboardingOptionBox';

const meta = {
  title: 'Design System/Onboarding/OnboardingOptionBox',
  component: OnboardingOptionBox,
  args: {
    title: 'I am new to Greek',
    value: 1,
    checked: true,
    onChange: () => {},
  },
} satisfies Meta<typeof OnboardingOptionBox>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Checked: Story = {};

export const Unchecked: Story = {
  args: {
    checked: false,
  },
};
