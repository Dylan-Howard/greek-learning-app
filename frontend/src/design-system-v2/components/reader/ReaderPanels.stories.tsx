import type { Meta, StoryObj } from '@storybook/react';
import React, { useState } from 'react';
import ReaderPanels from './ReaderPanels';
import { ReaderContext, type ReaderPage } from '@/app/reader/ReaderPage/ReaderPageContext';

const meta = {
  title: 'Design System/Reader/ReaderPanels',
  component: ReaderPanels,
  parameters: {
    layout: 'fullscreen',
  },
} satisfies Meta<typeof ReaderPanels>;

export default meta;
type Story = StoryObj<typeof meta>;

const initialPage: ReaderPage = {
  bookId: 43,
  chapterId: 1,
  tabId: 3,
  morphologyId: 0,
  chapterUnits: [],
};

export const Default: Story = {
  render: () => {
    const [page, setPage] = useState<ReaderPage>(initialPage);
    return (
      <ReaderContext.Provider value={{ page, setPage }}>
        <ReaderPanels />
      </ReaderContext.Provider>
    );
  },
};
