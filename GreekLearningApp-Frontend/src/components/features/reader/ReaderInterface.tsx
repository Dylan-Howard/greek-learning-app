'use client';

import { ReactNode, useMemo, useState } from 'react';
import { ReaderContext, ReaderPage } from '@/app/reader/ReaderPage/ReaderPageContext';
import { Unitv2 } from '@/lib/types/domain/text';

export default function ReaderInterface(
  {
    children,
    bookId,
    chapterId,
    chapterUnits,
  } : { children: ReactNode, bookId: number, chapterId: number, chapterUnits: Unitv2[] },
) {
  const [page, setPage] = useState<ReaderPage>({
    bookId,
    chapterId,
    tabId: 0,
    morphologyId: 0,
    chapterUnits,
    study: {
      queueWordIds: [],
      currentIndex: 0,
      ratedStates: {},
      completed: false,
    },
    selectedUnit: undefined,
  });

  return (
    <ReaderContext.Provider value={useMemo(() => ({ page, setPage }), [page])}>
      {children}
    </ReaderContext.Provider>
  );
}
