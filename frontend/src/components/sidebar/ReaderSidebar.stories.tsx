import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import ReaderSidebar from './ReaderSidebar';
import { type SRSCard } from '@/components/srs/SRSStudyPanel';

const sampleCards: SRSCard[] = [
  {
    id: 'c1',
    front: 'πίστις',
    back: { definition: 'faith', parsing: 'Noun • feminine' },
    intervals: { again: '10m', hard: '1d', good: '3d', easy: '7d' },
  },
];

const meta = {
  title: 'Design System/Sidebar/ReaderSidebar',
  component: ReaderSidebar,
  args: {
    selectedWord: {
      id: '1',
      greek: 'πίστις',
      lexicalForm: 'πίστις',
      definition: 'faith',
      parsing: {
        partOfSpeech: 'Noun',
        case: 'Nominative',
        number: 'Singular',
        gender: 'Feminine',
      },
      srsStatus: 'new',
      frequency: 243,
      sets: ['Romans'],
    },
    dueCards: sampleCards,
    onRate: () => {},
    onXPEarned: () => {},
  },
} satisfies Meta<typeof ReaderSidebar>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
