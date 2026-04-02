import type { Meta, StoryObj } from '@storybook/react';
import React, { useState } from 'react';
import ReaderTopBar from './ReaderTopBar';

const meta = {
  title: 'Design System/Reader/ReaderTopBar',
  component: ReaderTopBar,
  args: {
    activeTab: 0,
    onTabChange: () => {},
    ttsContent: 'Sample text',
  },
  parameters: {
    layout: 'fullscreen',
  },
} satisfies Meta<typeof ReaderTopBar>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {
  render: () => {
    const [activeTab, setActiveTab] = useState(0);
    return (
      <ReaderTopBar
        activeTab={activeTab}
        onTabChange={setActiveTab}
        ttsContent="In the beginning was the Word."
      />
    );
  },
};
