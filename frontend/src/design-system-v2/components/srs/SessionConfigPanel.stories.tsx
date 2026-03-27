import type { Meta, StoryObj } from '@storybook/react';
import React, { useState } from 'react';
import SessionConfigPanel from './SessionConfigPanel';
import { type StartSessionRequest, type VocabularySetDto } from '@/lib/types/api';

const sampleSets: VocabularySetDto[] = [
  {
    id: 1,
    ownerUserId: null,
    isSystem: true,
    slug: 'john-1',
    bookId: 43,
    title: 'John Chapter 1',
    description: 'Core vocabulary from John 1.',
    items: [],
    createdAt: new Date().toISOString(),
    lastPracticed: null,
    totalCount: 120,
    knownCount: 72,
    learningCount: 48,
    percentComplete: 60,
  },
];

const meta = {
  title: 'Design System/SRS/SessionConfigPanel',
  component: SessionConfigPanel,
  args: {
    sets: [],
    config: {
      cardCount: 10,
      pool: 'Mixed',
      direction: 'GreekToEnglish',
      mode: 'Flip',
      vocabularySetId: null,
    },
    onChange: () => {},
    onStart: () => {},
  },
} satisfies Meta<typeof SessionConfigPanel>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {
  render: () => {
    const [config, setConfig] = useState<StartSessionRequest>({
      cardCount: 10,
      pool: 'Mixed',
      direction: 'GreekToEnglish',
      mode: 'Flip',
      vocabularySetId: null,
    });
    return (
      <SessionConfigPanel
        sets={sampleSets}
        config={config}
        onChange={setConfig}
        onStart={() => {}}
      />
    );
  },
};
