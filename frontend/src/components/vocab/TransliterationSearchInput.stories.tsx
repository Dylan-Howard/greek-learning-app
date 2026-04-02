import type { Meta, StoryObj } from '@storybook/react';
import React, { useState } from 'react';
import TransliterationSearchInput from './TransliterationSearchInput';

const meta = {
  title: 'Design System/Vocab/TransliterationSearchInput',
  component: TransliterationSearchInput,
  args: {
    value: '',
    onChange: () => {},
  },
} satisfies Meta<typeof TransliterationSearchInput>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {
  render: () => {
    const [value, setValue] = useState('');
    return (
      <TransliterationSearchInput value={value} onChange={setValue} />
    );
  },
};
