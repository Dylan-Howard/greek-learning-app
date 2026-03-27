import type { Meta, StoryObj } from '@storybook/react';
import React, { useState } from 'react';
import VerseDisplay from './VerseDisplay';

const meta = {
  title: 'Design System/Reader/VerseDisplay',
  component: VerseDisplay,
  args: {
    verses: [],
    selectedWordId: null,
    onWordSelect: () => {},
  },
} satisfies Meta<typeof VerseDisplay>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {
  render: () => {
    const [selectedWordId, setSelectedWordId] = useState<string | null>(null);
    return (
      <VerseDisplay
        verses={[
          {
            verse: 1,
            tokens: [
              { id: 'w1', text: 'Ἐν', status: 'mastered' },
              { id: 'w2', text: 'ἀρχῇ', status: 'due' },
              { id: 'w3', text: 'ἦν', status: 'new' },
              { id: 'w4', text: 'ὁ', status: 'default' },
              { id: 'w5', text: 'λόγος', status: 'new' },
            ],
          },
        ]}
        selectedWordId={selectedWordId}
        onWordSelect={setSelectedWordId}
      />
    );
  },
};
