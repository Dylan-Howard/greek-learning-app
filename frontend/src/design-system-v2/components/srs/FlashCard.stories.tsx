import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import FlashCard from './FlashCard';

const meta = {
  title: 'Design System/SRS/FlashCard',
  component: FlashCard,
  args: {
    front: 'λόγος',
    back: { definition: 'word, message', parsing: 'Noun • masculine' },
    flipped: false,
    onFlip: () => {},
    size: 'full',
  },
} satisfies Meta<typeof FlashCard>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Front: Story = {};

export const Back: Story = {
  args: { flipped: true },
};
