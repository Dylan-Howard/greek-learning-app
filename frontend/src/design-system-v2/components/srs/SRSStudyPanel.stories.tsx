import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import SRSStudyPanel, { type SRSCard } from './SRSStudyPanel';

const sampleCards: SRSCard[] = [
  {
    id: 'c1',
    front: 'λόγος',
    back: { definition: 'word, message', parsing: 'Noun • masculine' },
    intervals: { again: '10m', hard: '1d', good: '3d', easy: '7d' },
  },
  {
    id: 'c2',
    front: 'ζωή',
    back: { definition: 'life', parsing: 'Noun • feminine' },
    intervals: { again: '10m', hard: '1d', good: '3d', easy: '7d' },
  },
];

const meta = {
  title: 'Design System/SRS/SRSStudyPanel',
  component: SRSStudyPanel,
  args: {
    cards: sampleCards,
    onRate: () => {},
    onClose: () => {},
    size: 'full',
  },
  parameters: {
    layout: 'fullscreen',
  },
} satisfies Meta<typeof SRSStudyPanel>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
