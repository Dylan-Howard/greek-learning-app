import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import { LessonCard } from './LessonCard';

const meta = {
  title: 'Design System/Lessons/LessonCard',
  component: LessonCard,
  args: {
    lesson: {
      id: 'lesson-1',
      number: 3,
      title: 'Verb Tenses Overview',
      type: 'Grammar',
      readTime: 12,
      completed: false,
    },
    onClick: () => {},
  },
} satisfies Meta<typeof LessonCard>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};

export const Completed: Story = {
  args: {
    lesson: {
      id: 'lesson-2',
      number: 1,
      title: 'Alphabet Practice',
      type: 'Culture',
      readTime: 6,
      completed: true,
    },
  },
};
