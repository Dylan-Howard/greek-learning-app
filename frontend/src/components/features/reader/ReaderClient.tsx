'use client';

import React, { useCallback, useEffect, useMemo, useState } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import { useRouter } from 'next/navigation';
import { AppShell } from '@/components/layout/AppShell';
import ReaderInterface from '@/components/features/reader/ReaderInterface';
import ChapterSelector from '@/design-system-v2/components/reader/ChapterSelector';
import VerseDisplay from '@/design-system-v2/components/reader/VerseDisplay';
import { ChapterNavigatorWrapper } from '@/design-system-v2/components/reader/ChapterNavigator';
import ReaderTopBar from '@/design-system-v2/components/reader/ReaderTopBar';
import ReaderPanels from '@/design-system-v2/components/reader/ReaderPanels';
import { ReaderSkeleton } from '@/design-system-v2/components/shared/LoadingSkeleton';
import { tokens } from '@/design-system-v2/theme/theme';
import { type Unitv2 } from '@/lib/types/domain/text';
import { buildVerseDisplayData } from './readerAdapters';
import { useReaderContext } from '@/app/reader/ReaderPage/ReaderPageContext';

interface ReaderClientProps {
  bookId: number;
  chapterId: number;
  selection: {
    texts: { textId: number; title: string }[];
    chapters: { chapterId: number; chapterNumber: number }[];
  };
  title: string;
  text: Unitv2[];
}

function ReaderInner({
  bookId,
  chapterId,
  selection,
  title,
  text,
}: ReaderClientProps) {
  const router = useRouter();
  const { verses, unitByTokenId } = useMemo(() => buildVerseDisplayData(text), [text]);
  const [selectedWordId, setSelectedWordId] = useState<string | null>(null);
  const { page, setPage } = useReaderContext();

  const chapters = selection.chapters.map((ch) => ch.chapterNumber).sort((a, b) => a - b);
  const minChapter = chapters[0] ?? chapterId;
  const maxChapter = chapters[chapters.length - 1] ?? chapterId;

  const books = selection.texts.map((txt) => ({
    id: String(txt.textId),
    name: txt.title,
    chapters: chapters.length || 1,
  }));

  useEffect(() => {
    setSelectedWordId(null);
    setPage({
      ...page,
      tabId: 0,
      morphologyId: 0,
      selectedUnit: undefined,
      studyFocusWordId: undefined,
    });
  }, [bookId, chapterId, page, setPage]);

  const handleWordSelect = useCallback((wordId: string) => {
    setSelectedWordId(wordId);
    const unit = unitByTokenId.get(wordId);
    if (!unit) {
      return;
    }
    setPage({
      ...page,
      tabId: 3,
      morphologyId: unit.morphologyId ?? 0,
      selectedUnit: {
        unitId: unit.unitId,
        content: unit.content,
        helpText: unit.helpText,
        morphologyId: unit.morphologyId,
        type: unit.type,
        path: unit.path,
        original: unit.original,
        translation: unit.translation,
        grammarFeatureIds: unit.grammarFeatureIds,
        syntacticalFeatureIds: unit.syntacticalFeatureIds,
        parentPhrases: unit.parentPhrases,
      },
      studyFocusWordId: unit.morphologyId,
    });
  }, [page, setPage, unitByTokenId]);

  const handleBookChange = (nextBookId: string) => {
    router.push(`/reader/${nextBookId}/1`);
  };

  const handleChapterChange = (nextChapter: number) => {
    router.push(`/reader/${bookId}/${nextChapter}`);
  };

  if (verses.length === 0) {
    return (
      <AppShell>
        <ReaderSkeleton />
      </AppShell>
    );
  }

  return (
    <AppShell>
      <ReaderTopBar
        activeTab={page?.tabId ?? 0}
        onTabChange={(tabId) => setPage({ ...page, tabId })}
        ttsContent={text.map((unit) => unit.content).join(' ')}
      />
      <Box sx={{ minHeight: '100vh', display: 'flex', flexDirection: 'column' }}>
        <ChapterNavigatorWrapper
          hasPrev={chapterId > minChapter}
          hasNext={chapterId < maxChapter}
          onPrev={() => handleChapterChange(chapterId - 1)}
          onNext={() => handleChapterChange(chapterId + 1)}
        >
          <ChapterSelector
            books={books}
            selectedBook={String(bookId)}
            selectedChapter={chapterId}
            onBookChange={handleBookChange}
            onChapterChange={handleChapterChange}
          />

          <VerseDisplay
            verses={verses}
            selectedWordId={selectedWordId}
            onWordSelect={handleWordSelect}
          />

          <Typography
            variant="body2"
            sx={{
              textAlign: 'center',
              color: tokens.color.textMuted,
              py: 4,
              fontSize: '0.75rem',
            }}
          >
            {title}
          </Typography>
        </ChapterNavigatorWrapper>
      </Box>

      <ReaderPanels />
    </AppShell>
  );
}

export function ReaderClient(props: ReaderClientProps) {
  return (
    <ReaderInterface
      bookId={props.bookId}
      chapterId={props.chapterId}
      chapterUnits={props.text}
    >
      <ReaderInner {...props} />
    </ReaderInterface>
  );
}
