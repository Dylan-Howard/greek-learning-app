'use client';

import { createContext, useContext } from 'react';

export interface ReaderPage {
  bookId: number;
  chapterId: number;
  tabId: number;
  morphologyId: number;
}

export interface ReaderContextType {
  page: ReaderPage;
  setPage: (page: ReaderPage) => void;
}

export const ReaderContext = createContext<ReaderContextType | null>(null);

export function useReaderContext() {
  const context = useContext(ReaderContext);
  if (!context) {
    throw new Error('useReaderContext must be used within a ReaderInterface');
  }
  return context;
}
