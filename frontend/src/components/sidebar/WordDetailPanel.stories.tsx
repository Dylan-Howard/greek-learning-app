import type { Meta, StoryObj } from '@storybook/react';
import WordDetailPanel from './WordDetailPanel';

const meta = {
  title: 'Design System/Sidebar/WordDetailPanel',
  component: WordDetailPanel,
  args: {
    word: {
      id: '1',
      greek: 'λόγος',
      lexicalForm: 'λόγος',
      definition: 'word, message',
      parsing: {
        partOfSpeech: 'Noun',
        case: 'Nominative',
        number: 'Singular',
        gender: 'Masculine',
      },
      srsStatus: 'due',
      frequency: 330,
      sets: ['John 1', 'Common Words'],
    },
  },
} satisfies Meta<typeof WordDetailPanel>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};

export const Empty: Story = {
  args: {
    word: null,
  },
};
