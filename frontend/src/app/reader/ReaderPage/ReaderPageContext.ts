'use client';

import { createContext, useContext } from 'react';
import { Unitv2 } from '@/lib/types/domain/text';

export type ReaderRatedWordState = 'accepted' | 'rejected';

export interface ReaderStudyState {
  queueWordIds: number[];
  currentWordId?: number;
  currentIndex: number;
  sessionId?: string;
  ratedStates: Record<number, ReaderRatedWordState>;
  completed: boolean;
  completionXpApplied?: boolean;
}

export interface ReaderPage {
  bookId: number;
  chapterId: number;
  tabId: number;
  morphologyId: number;
  chapterUnits?: Unitv2[];
  studyFocusWordId?: number;
  study?: ReaderStudyState;
  selectedUnit?: {
    unitId: number;
    content: string;
    helpText: string;
    morphologyId: number;
    type?: string;
    path?: string;
    original?: string;
    translation?: string;
    grammarFeatureIds?: number[];
    syntacticalFeatureIds?: number[];
    parentPhrases?: {
      path: string;
      original: string;
      translation: string;
      syntacticalFeatureIds: number[];
    }[];
  };
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
