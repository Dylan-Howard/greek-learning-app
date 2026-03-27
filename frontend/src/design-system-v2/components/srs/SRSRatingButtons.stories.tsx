import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import SRSRatingButtons from './SRSRatingButtons';

const meta = {
  title: 'Design System/SRS/SRSRatingButtons',
  component: SRSRatingButtons,
  args: {
    onRate: () => {},
    intervals: {
      again: '10m',
      hard: '1d',
      good: '3d',
      easy: '7d',
    },
  },
} satisfies Meta<typeof SRSRatingButtons>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
