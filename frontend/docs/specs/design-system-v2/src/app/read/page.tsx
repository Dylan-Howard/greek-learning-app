'use client';
// src/app/read/page.tsx

import React, { useState, useCallback } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import AppShell from '@/components/layouts/AppShell';
import ChapterSelector from '@/components/reader/ChapterSelector';
import VerseDisplay, { type Verse } from '@/components/reader/VerseDisplay';
import { ChapterNavigatorWrapper } from '@/components/reader/ChapterNavigator';
import ReaderSidebar from '@/components/sidebar/ReaderSidebar';
import BottomSheet, { type SnapPoint } from '@/components/mobile/BottomSheet';
import WordDetailPanel, { type ParsedWord } from '@/components/sidebar/WordDetailPanel';
import SRSStudyPanel, { type SRSCard } from '@/components/srs/SRSStudyPanel';
import { ReaderSkeleton } from '@/components/shared/LoadingSkeleton';
import { type SRSRating } from '@/components/srs/SRSRatingButtons';
import { tokens } from '@/theme/theme';

// ── Stub data (replace with API calls) ───────────────────────────────────────
const BOOKS = [
  { id: 'JHN', name: 'John',     chapters: 21 },
  { id: 'ROM', name: 'Romans',   chapters: 16 },
  { id: 'GEN', name: 'Genesis',  chapters: 50 },
];

const STUB_VERSES: Verse[] = [
  {
    verse: 1,
    tokens: [
      { id: 'JHN.1.1.1', text: 'Ἐν',    status: 'mastered' },
      { id: 'JHN.1.1.2', text: 'ἀρχῇ',  status: 'due' },
      { id: 'JHN.1.1.3', text: 'ἦν',    status: 'mastered' },
      { id: 'JHN.1.1.4', text: 'ὁ',     status: 'mastered' },
      { id: 'JHN.1.1.5', text: 'λόγος,', status: 'new' },
    ],
  },
  {
    verse: 2,
    tokens: [
      { id: 'JHN.1.2.1', text: 'οὗτος', status: 'due' },
      { id: 'JHN.1.2.2', text: 'ἦν',    status: 'mastered' },
      { id: 'JHN.1.2.3', text: 'ἐν',    status: 'mastered' },
      { id: 'JHN.1.2.4', text: 'ἀρχῇ',  status: 'due' },
      { id: 'JHN.1.2.5', text: 'πρὸς',  status: 'default' },
      { id: 'JHN.1.2.6', text: 'τὸν',   status: 'mastered' },
      { id: 'JHN.1.2.7', text: 'θεόν.', status: 'new' },
    ],
  },
];

const STUB_WORD: ParsedWord = {
  id:          'JHN.1.1.5',
  greek:       'λόγος',
  lexicalForm: 'λόγος, ου, ὁ',
  definition:  'word, message, reason',
  parsing: {
    partOfSpeech: 'Noun',
    case:         'Nominative',
    number:       'Singular',
    gender:       'Masculine',
  },
  srsStatus:   'new',
  frequency:   330,
  sets:        ['Core 500', 'Johannine Vocabulary'],
};

const STUB_CARDS: SRSCard[] = [
  {
    id:        'card-1',
    front:     'λόγος',
    back:      { definition: 'word, message, reason', parsing: 'Noun, Masculine' },
    intervals: { again: '<10m', hard: '1d', good: '4d', easy: '1w' },
  },
  {
    id:        'card-2',
    front:     'ἀρχή',
    back:      { definition: 'beginning, origin, rule', parsing: 'Noun, Feminine' },
    intervals: { again: '<10m', hard: '1d', good: '3d', easy: '5d' },
  },
];

// ── Component ────────────────────────────────────────────────────────────────
export default function ReadPage() {
  const [book,           setBook]           = useState('JHN');
  const [chapter,        setChapter]        = useState(1);
  const [selectedWordId, setSelectedWordId] = useState<string | null>(null);
  const [sheetSnap,      setSheetSnap]      = useState<SnapPoint>('hidden');

  const selectedWord = selectedWordId === STUB_WORD.id ? STUB_WORD : null;

  const handleWordSelect = useCallback((wordId: string) => {
    setSelectedWordId(wordId);
    setSheetSnap('peek'); // mobile: open sheet
  }, []);

  const handleRate = useCallback((_cardId: string, _rating: SRSRating) => {
    // TODO: send rating to SRS backend
  }, []);

  const sidebar = (
    <ReaderSidebar
      selectedWord={selectedWord}
      dueCards={STUB_CARDS}
      onRate={handleRate}
    />
  );

  return (
    <AppShell sidebar={sidebar}>
      <Box sx={{ minHeight: '100vh', display: 'flex', flexDirection: 'column' }}>
        <ChapterNavigatorWrapper
          hasPrev={chapter > 1}
          hasNext={chapter < (BOOKS.find((b) => b.id === book)?.chapters ?? 1)}
          onPrev={() => setChapter((c) => c - 1)}
          onNext={() => setChapter((c) => c + 1)}
        >
          {/* Chapter selector */}
          <ChapterSelector
            books={BOOKS}
            selectedBook={book}
            selectedChapter={chapter}
            onBookChange={setBook}
            onChapterChange={setChapter}
          />

          {/* Verses */}
          <VerseDisplay
            verses={STUB_VERSES}
            selectedWordId={selectedWordId}
            onWordSelect={handleWordSelect}
          />

          {/* Copyright */}
          <Typography
            variant="body2"
            sx={{
              textAlign: 'center',
              color:     tokens.color.textMuted,
              py:        4,
              fontSize:  '0.75rem',
            }}
          >
            Greek text: NA28 © Deutsche Bibelgesellschaft
          </Typography>
        </ChapterNavigatorWrapper>
      </Box>

      {/* Mobile bottom sheet */}
      <Box sx={{ display: { xs: 'block', md: 'none' } }}>
        <BottomSheet snap={sheetSnap} onSnapChange={setSheetSnap}>
          {selectedWord && (
            <WordDetailPanel word={selectedWord} />
          )}
        </BottomSheet>
      </Box>
    </AppShell>
  );
}
