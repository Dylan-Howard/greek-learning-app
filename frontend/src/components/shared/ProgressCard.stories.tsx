import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Typography from '@mui/material/Typography';
import { ProgressCard } from './ProgressCard';

const meta = {
  title: 'Design System/Shared/ProgressCard',
  component: ProgressCard,
  args: {
    title: 'Lesson Track',
    subtitle: 'Basics of Greek verbs',
    progress: 62,
    progressLabel: 'Complete',
    children: (
      <Typography variant="body2" color="text.secondary">
        You have completed 5 of 8 lessons.
      </Typography>
    ),
  },
} satisfies Meta<typeof ProgressCard>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
