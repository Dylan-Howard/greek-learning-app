'use client';

import { useFetchChapterQuery } from '@/lib/api/graphql/generated/index';
import { mapRenderedUnitsToDisplayUnits } from '@/lib/api/rest/reader';
import { ReaderClient } from '@/components/features/reader/ReaderClient';

interface ReaderPageLoaderProps {
  bookId: number;
  chapterId: number;
  chapterNumber: number;
  selection: {
    texts: { textId: number; title: string }[];
    chapters: { chapterId: number; chapterNumber: number }[];
  };
}

export function ReaderPageLoader({ bookId, chapterId, chapterNumber, selection }: ReaderPageLoaderProps) {
  const { data, loading, error } = useFetchChapterQuery({
    variables: { bookId, chapterNumber },
  });

  if (loading) {
    return null;
  }

  if (error || !data?.reader) {
    throw new Error('Error fetching the reader page.');
  }

  const { title, units } = data.reader;
  const text = mapRenderedUnitsToDisplayUnits(units);

  return (
    <ReaderClient
      bookId={bookId}
      chapterId={chapterId}
      selection={selection}
      title={title}
      text={text}
    />
  );
}
