import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Button from '@mui/material/Button';
import { LessonTrackCard } from './LessonTrackCard';

const meta = {
  title: 'Design System/Lessons/LessonTrackCard',
  component: LessonTrackCard,
  args: {
    title: 'Greek Basics',
    description: 'Build your foundation with core grammar concepts.',
    completedLessons: 4,
    totalLessons: 8,
    percentComplete: 50,
    nextLessonTitle: 'Cases and Declensions',
  },
} satisfies Meta<typeof LessonTrackCard>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};

export const WithActions: Story = {
  args: {
    actions: (
      <Button variant="outlined" size="small">
        Resume
      </Button>
    ),
  },
};
