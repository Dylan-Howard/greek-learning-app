import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import LessonCompletionBanner from './LessonCompletionBanner';

const meta = {
  title: 'Design System/Lessons/LessonCompletionBanner',
  component: LessonCompletionBanner,
  args: {
    xpEarned: 24,
    nextLessonId: 'lesson-4',
    nextLessonTitle: 'Case Endings',
    onNextLesson: () => {},
  },
} satisfies Meta<typeof LessonCompletionBanner>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
