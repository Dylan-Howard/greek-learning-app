import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import MultipleChoiceCard from './MultipleChoiceCard';
import { type CardDto } from '@/lib/types/api';

const sampleCard: CardDto = {
  sessionCardId: 1,
  vocabularyId: 101,
  position: 1,
  totalCards: 10,
  front: {
    root: 'ἀγάπη',
    transliteration: 'agape',
    partOfSpeech: 'Noun',
    occurrences: 116,
  },
  back: {
    gloss: 'love',
  },
  interactionMode: 'MultipleChoice',
  choices: ['love', 'word', 'life', 'truth'],
  direction: 'GreekToEnglish',
};

const meta = {
  title: 'Design System/SRS/MultipleChoiceCard',
  component: MultipleChoiceCard,
  args: {
    card: sampleCard,
    onAnswer: () => {},
  },
} satisfies Meta<typeof MultipleChoiceCard>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
