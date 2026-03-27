import type { Meta, StoryObj } from '@storybook/react';
import React, { useState } from 'react';
import ChapterSelector from './ChapterSelector';

const meta = {
  title: 'Design System/Reader/ChapterSelector',
  component: ChapterSelector,
  args: {
    books: [],
    selectedBook: '',
    selectedChapter: 1,
    onBookChange: () => {},
    onChapterChange: () => {},
  },
} satisfies Meta<typeof ChapterSelector>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {
  render: () => {
    const [book, setBook] = useState('john');
    const [chapter, setChapter] = useState(1);
    return (
      <ChapterSelector
        books={[
          { id: 'john', name: 'John', chapters: 21 },
          { id: 'mark', name: 'Mark', chapters: 16 },
        ]}
        selectedBook={book}
        selectedChapter={chapter}
        onBookChange={setBook}
        onChapterChange={setChapter}
      />
    );
  },
};
