import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import VocabSetCard from './VocabSetCard';

const meta = {
  title: 'Design System/Vocab/VocabSetCard',
  component: VocabSetCard,
  args: {
    set: {
      id: 'set-1',
      title: 'Johannine Verbs',
      description: 'High-frequency verbs from the Gospel of John.',
      wordCount: 120,
      mastered: 54,
      dueCount: 8,
      lastStudied: new Date().toISOString(),
    },
    onStudy: () => {},
    onClick: () => {},
  },
} satisfies Meta<typeof VocabSetCard>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
