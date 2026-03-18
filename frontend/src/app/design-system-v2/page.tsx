'use client';

import React, { useMemo, useState } from 'react';
import Box from '@mui/material/Box';
import Container from '@mui/material/Container';
import Divider from '@mui/material/Divider';
import Grid from '@mui/material/Grid';
import Stack from '@mui/material/Stack';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import Paper from '@mui/material/Paper';
import MenuItem from '@mui/material/MenuItem';
import Select from '@mui/material/Select';
import InputLabel from '@mui/material/InputLabel';
import FormControl from '@mui/material/FormControl';
import SchoolOutlinedIcon from '@mui/icons-material/SchoolOutlined';
import AutoGraphOutlinedIcon from '@mui/icons-material/AutoGraphOutlined';
import MenuBookOutlinedIcon from '@mui/icons-material/MenuBookOutlined';
import ThemeProvider from '@/design-system-v2/theme/ThemeProvider';
import { tokens } from '@/design-system-v2/theme/theme';

import AppShell from '@/design-system-v2/components/layouts/AppShell';
import AuthShell from '@/design-system-v2/components/layouts/AuthShell';
import RTLWrapper from '@/design-system-v2/components/layouts/RTLWrapper';

import ChapterSelector from '@/design-system-v2/components/reader/ChapterSelector';
import VerseDisplay, { type Verse } from '@/design-system-v2/components/reader/VerseDisplay';
import { ChapterNavigatorWrapper } from '@/design-system-v2/components/reader/ChapterNavigator';

import ReaderSidebar from '@/design-system-v2/components/sidebar/ReaderSidebar';
import WordDetailPanel, { type ParsedWord } from '@/design-system-v2/components/sidebar/WordDetailPanel';
import StudyLaunchPanel from '@/design-system-v2/components/sidebar/StudyLaunchPanel';

import BottomSheet, { type SnapPoint } from '@/design-system-v2/components/mobile/BottomSheet';

import FlashCard from '@/design-system-v2/components/srs/FlashCard';
import SRSRatingButtons from '@/design-system-v2/components/srs/SRSRatingButtons';
import SRSSessionProgress from '@/design-system-v2/components/srs/SRSSessionProgress';
import SRSStudyPanel, { type SRSCard } from '@/design-system-v2/components/srs/SRSStudyPanel';

import VocabSetCard, { type VocabSet } from '@/design-system-v2/components/vocab/VocabSetCard';
import VocabWordRow, { type VocabWord } from '@/design-system-v2/components/vocab/VocabWordRow';
import TransliterationSearchInput from '@/design-system-v2/components/vocab/TransliterationSearchInput';

import LessonCompletionBanner from '@/design-system-v2/components/lessons/LessonCompletionBanner';
import {
  LessonCard,
  type LessonMeta,
} from '@/design-system-v2/components/lessons/LessonCard';
import {
  TextBlock,
  ImageBlock,
  VideoBlock,
  ConfirmCheckbox,
  MultipleChoice,
  TextInputQuestion,
} from '@/design-system-v2/components/lessons/LessonBlocks';

import StatCard from '@/design-system-v2/components/profile/StatCard';
import ActivityHeatmap from '@/design-system-v2/components/profile/ActivityHeatmap';

import XPToast from '@/design-system-v2/components/gamification/XPToast';
import TierUpModal from '@/design-system-v2/components/gamification/TierUpModal';

import { PageHeader } from '@/design-system-v2/components/shared/PageHeader';
import EmptyState from '@/design-system-v2/components/shared/EmptyState';
import ProgressChip from '@/design-system-v2/components/shared/ProgressChip';
import {
  ReaderSkeleton,
  VocabCardSkeleton,
  LessonCardSkeleton,
  SidebarSkeleton,
} from '@/design-system-v2/components/shared/LoadingSkeleton';

import {
  LoginForm,
  SignUpForm,
  ForgotPasswordForm,
} from '@/design-system-v2/components/auth/AuthForms';

const BOOKS = [
  { id: 'JHN', name: 'John', chapters: 21 },
  { id: 'ROM', name: 'Romans', chapters: 16 },
  { id: 'GEN', name: 'Genesis', chapters: 50 },
];

const STUB_VERSES: Verse[] = [
  {
    verse: 1,
    tokens: [
      { id: 'JHN.1.1.1', text: 'Ἐν', status: 'mastered' },
      { id: 'JHN.1.1.2', text: 'ἀρχῇ', status: 'due' },
      { id: 'JHN.1.1.3', text: 'ἦν', status: 'mastered' },
      { id: 'JHN.1.1.4', text: 'ὁ', status: 'mastered' },
      { id: 'JHN.1.1.5', text: 'λόγος,', status: 'new' },
    ],
  },
  {
    verse: 2,
    tokens: [
      { id: 'JHN.1.2.1', text: 'οὗτος', status: 'due' },
      { id: 'JHN.1.2.2', text: 'ἦν', status: 'mastered' },
      { id: 'JHN.1.2.3', text: 'ἐν', status: 'mastered' },
      { id: 'JHN.1.2.4', text: 'ἀρχῇ', status: 'due' },
      { id: 'JHN.1.2.5', text: 'πρὸς', status: 'default' },
      { id: 'JHN.1.2.6', text: 'τὸν', status: 'mastered' },
      { id: 'JHN.1.2.7', text: 'θεόν.', status: 'new' },
    ],
  },
];

const STUB_WORD: ParsedWord = {
  id: 'JHN.1.1.5',
  greek: 'λόγος',
  lexicalForm: 'λόγος, ου, ὁ',
  definition: 'word, message, reason',
  parsing: {
    partOfSpeech: 'Noun',
    case: 'Nominative',
    number: 'Singular',
    gender: 'Masculine',
  },
  srsStatus: 'new',
  frequency: 330,
  sets: ['Core 500', 'Johannine Vocabulary'],
};

const STUB_CARDS: SRSCard[] = [
  {
    id: 'card-1',
    front: 'λόγος',
    back: { definition: 'word, message, reason', parsing: 'Noun, Masculine' },
    intervals: { again: '<10m', hard: '1d', good: '4d', easy: '1w' },
  },
  {
    id: 'card-2',
    front: 'ἀρχή',
    back: { definition: 'beginning, origin, rule', parsing: 'Noun, Feminine' },
    intervals: { again: '<10m', hard: '1d', good: '3d', easy: '5d' },
  },
];

const STUB_VOCAB_SETS: VocabSet[] = [
  {
    id: 'core-500',
    title: 'Core 500',
    description: 'The 500 most frequent words in the Greek NT.',
    wordCount: 500,
    mastered: 220,
    dueCount: 14,
    lastStudied: new Date(Date.now() - 86_400_000).toISOString(),
  },
  {
    id: 'john',
    title: 'Johannine Vocabulary',
    description: 'Words unique to John and related writings.',
    wordCount: 180,
    mastered: 40,
    dueCount: 0,
    lastStudied: null,
  },
];

const STUB_VOCAB_WORDS: VocabWord[] = [
  {
    id: 'w1',
    greek: 'λόγος',
    transliteration: 'logos',
    definition: 'word, message, reason',
    partOfSpeech: 'Noun',
    frequency: 330,
    srsStatus: 'due',
  },
  {
    id: 'w2',
    greek: 'ἀρχή',
    transliteration: 'archē',
    definition: 'beginning, origin, rule',
    partOfSpeech: 'Noun',
    frequency: 55,
    srsStatus: 'mastered',
  },
];

const STUB_LESSONS: LessonMeta[] = [
  { id: 'l1', number: 1, title: 'Alphabet & Pronunciation', type: 'Grammar', readTime: 8, completed: true },
  { id: 'l2', number: 2, title: 'Noun Endings Overview', type: 'Grammar', readTime: 12, completed: false },
  { id: 'l3', number: 3, title: 'Core Vocabulary: Faith', type: 'Vocabulary', readTime: 10, completed: false },
];

export default function DesignSystemV2Page() {
  const [selectedBook, setSelectedBook] = useState('JHN');
  const [selectedChapter, setSelectedChapter] = useState(1);
  const [selectedWordId, setSelectedWordId] = useState<string | null>('JHN.1.1.5');
  const [sheetSnap, setSheetSnap] = useState<SnapPoint>('hidden');
  const [showToast, setShowToast] = useState(false);
  const [tierModalOpen, setTierModalOpen] = useState(false);
  const [confirmChecked, setConfirmChecked] = useState(false);
  const [translitValue, setTranslitValue] = useState('logos');
  const [rtlMode, setRtlMode] = useState<'ltr' | 'rtl'>('ltr');

  const selectedWord = selectedWordId === STUB_WORD.id ? STUB_WORD : null;

  const heatmapData = useMemo(() => {
    const data: { date: string; count: number }[] = [];
    for (let i = 0; i < 60; i += 1) {
      const date = new Date();
      date.setDate(date.getDate() - i);
      data.push({ date: date.toISOString().slice(0, 10), count: i % 9 });
    }
    return data;
  }, []);

  const sidebar = (
    <ReaderSidebar
      selectedWord={selectedWord}
      dueCards={STUB_CARDS}
      onRate={() => undefined}
      onXPEarned={() => setShowToast(true)}
    />
  );

  return (
    <ThemeProvider>
      <AppShell sidebar={sidebar} userInitials="DH" xpPercent={72} tier="apprentice">
        <Box sx={{ px: { xs: 2, md: 4 }, py: 4 }}>
          <Container maxWidth="lg">
            <Stack spacing={6}>
              <Box>
                <Typography variant="h1" sx={{ mb: 1 }}>
                  Design System v2 Demo
                </Typography>
                <Typography variant="body1" sx={{ color: tokens.color.textSecondary }}>
                  All v2 components rendered in one place to validate styling and integration.
                </Typography>
              </Box>

              <Divider />

              <Box>
                <PageHeader
                  title="Reader"
                  subtitle="Reader layout, chapter selector, and verse display"
                  actions={
                    <Button variant="outlined" onClick={() => setSheetSnap('peek')}>
                      Open Bottom Sheet
                    </Button>
                  }
                />

                <ChapterNavigatorWrapper
                  hasPrev={selectedChapter > 1}
                  hasNext={selectedChapter < (BOOKS.find((b) => b.id === selectedBook)?.chapters ?? 1)}
                  onPrev={() => setSelectedChapter((c) => Math.max(1, c - 1))}
                  onNext={() => setSelectedChapter((c) => c + 1)}
                >
                  <Box sx={{ border: `1px solid ${tokens.color.border}`, borderRadius: tokens.radius.lg }}>
                    <ChapterSelector
                      books={BOOKS}
                      selectedBook={selectedBook}
                      selectedChapter={selectedChapter}
                      onBookChange={setSelectedBook}
                      onChapterChange={setSelectedChapter}
                    />
                    <VerseDisplay
                      verses={STUB_VERSES}
                      selectedWordId={selectedWordId}
                      onWordSelect={(id) => {
                        setSelectedWordId(id);
                        setSheetSnap('peek');
                      }}
                    />
                  </Box>
                </ChapterNavigatorWrapper>

                <BottomSheet snap={sheetSnap} onSnapChange={setSheetSnap}>
                  <WordDetailPanel word={selectedWord} />
                </BottomSheet>
              </Box>

              <Divider />

              <Box>
                <PageHeader title="Study & SRS" subtitle="Flashcards, ratings, and session progress" />
                <Grid container spacing={3}>
                  <Grid size={{ xs: 12, md: 6 }}>
                    <FlashCard
                      front="ἀγάπη"
                      back={{ definition: 'love', parsing: 'Noun, Feminine' }}
                      flipped={false}
                      onFlip={() => undefined}
                      size="full"
                    />
                  </Grid>
                  <Grid size={{ xs: 12, md: 6 }}>
                    <Stack spacing={2}>
                      <SRSSessionProgress current={2} total={10} />
                      <SRSRatingButtons
                        onRate={() => undefined}
                        intervals={{ again: '<10m', hard: '1d', good: '4d', easy: '1w' }}
                      />
                      <Paper variant="outlined" sx={{ p: 2, borderRadius: tokens.radius.lg }}>
                        <SRSStudyPanel
                          cards={STUB_CARDS}
                          onRate={() => undefined}
                          onClose={() => undefined}
                          size="compact"
                        />
                      </Paper>
                    </Stack>
                  </Grid>
                </Grid>
              </Box>

              <Divider />

              <Box>
                <PageHeader title="Vocabulary" subtitle="Cards, search, and word rows" />
                <Stack spacing={3}>
                  <Grid container spacing={3}>
                    {STUB_VOCAB_SETS.map((set) => (
                      <Grid key={set.id} size={{ xs: 12, md: 6 }}>
                        <VocabSetCard
                          set={set}
                          onClick={() => undefined}
                          onStudy={() => undefined}
                        />
                      </Grid>
                    ))}
                  </Grid>

                  <TransliterationSearchInput
                    value={translitValue}
                    onChange={setTranslitValue}
                  />

                  <Paper variant="outlined" sx={{ borderRadius: tokens.radius.lg, overflow: 'hidden' }}>
                    <Table>
                      <TableHead>
                        <TableRow>
                          <TableCell>Greek</TableCell>
                          <TableCell>Transliteration</TableCell>
                          <TableCell>Definition</TableCell>
                          <TableCell sx={{ display: { xs: 'none', md: 'table-cell' } }}>Part of Speech</TableCell>
                          <TableCell align="right" sx={{ display: { xs: 'none', sm: 'table-cell' } }}>Frequency</TableCell>
                          <TableCell>Status</TableCell>
                        </TableRow>
                      </TableHead>
                      <TableBody>
                        {STUB_VOCAB_WORDS.map((word) => (
                          <VocabWordRow key={word.id} word={word} onClick={() => undefined} />
                        ))}
                      </TableBody>
                    </Table>
                  </Paper>
                </Stack>
              </Box>

              <Divider />

              <Box>
                <PageHeader title="Lessons" subtitle="Lesson cards and content blocks" />
                <Stack spacing={2}>
                  {STUB_LESSONS.map((lesson) => (
                    <LessonCard key={lesson.id} lesson={lesson} onClick={() => undefined} />
                  ))}
                  <Box sx={{ mt: 2 }}>
                    <TextBlock content="<p>Greek text uses the <span class='greek'>Noto Serif</span> font inside lesson content.</p>" />
                    <ImageBlock src="/Onboarding-1.svg" alt="Lesson illustration" caption="Example illustration" />
                    <VideoBlock src="https://www.youtube.com/embed/5qap5aO4i9A" title="Lesson video" />
                    <ConfirmCheckbox
                      id="confirm-1"
                      checked={confirmChecked}
                      onChange={(_, checked) => setConfirmChecked(checked)}
                    />
                    <MultipleChoice
                      id="mc-1"
                      question="Which word means 'love'?"
                      options={[
                        { id: 'a', text: 'ἀγάπη' },
                        { id: 'b', text: 'λόγος' },
                        { id: 'c', text: 'ἔργον' },
                      ]}
                      correctId="a"
                    />
                    <TextInputQuestion
                      id="ti-1"
                      question="Write the transliteration for λόγος"
                      answer="logos"
                    />
                    <LessonCompletionBanner
                      xpEarned={35}
                      nextLessonId="l2"
                      nextLessonTitle="Noun Endings Overview"
                      onNextLesson={() => undefined}
                    />
                  </Box>
                </Stack>
              </Box>

              <Divider />

              <Box>
                <PageHeader title="Profile" subtitle="Stats, activity heatmap, and progress chips" />
                <Grid container spacing={3}>
                  <Grid size={{ xs: 12, md: 4 }}>
                    <StatCard value={128} label="Words Mastered" icon={<MenuBookOutlinedIcon />} />
                  </Grid>
                  <Grid size={{ xs: 12, md: 4 }}>
                    <StatCard value={28} label="Streak" icon={<AutoGraphOutlinedIcon />} color={tokens.color.srsGood} />
                  </Grid>
                  <Grid size={{ xs: 12, md: 4 }}>
                    <StatCard value="Scholar" label="Tier" icon={<SchoolOutlinedIcon />} color={tokens.color.tierScholar} />
                  </Grid>
                </Grid>

                <Box sx={{ mt: 3 }}>
                  <ActivityHeatmap data={heatmapData} weeks={16} />
                </Box>

                <Stack direction="row" spacing={1.5} sx={{ mt: 2, flexWrap: 'wrap' }}>
                  <ProgressChip status="unseen" />
                  <ProgressChip status="new" />
                  <ProgressChip status="due" />
                  <ProgressChip status="mastered" />
                </Stack>
              </Box>

              <Divider />

              <Box>
                <PageHeader title="Auth" subtitle="Login, signup, and reset states" />
                <Grid container spacing={3}>
                  <Grid size={{ xs: 12, md: 4 }}>
                    <AuthShell>
                      <LoginForm
                        onSubmit={async () => undefined}
                        onSignUp={() => undefined}
                        onGuest={() => undefined}
                      />
                    </AuthShell>
                  </Grid>
                  <Grid size={{ xs: 12, md: 4 }}>
                    <AuthShell>
                      <SignUpForm
                        onSubmit={async () => undefined}
                        onLogin={() => undefined}
                        onGuest={() => undefined}
                      />
                    </AuthShell>
                  </Grid>
                  <Grid size={{ xs: 12, md: 4 }}>
                    <AuthShell>
                      <ForgotPasswordForm
                        onSubmit={async () => undefined}
                        onBack={() => undefined}
                      />
                    </AuthShell>
                  </Grid>
                </Grid>
              </Box>

              <Divider />

              <Box>
                <PageHeader title="Shared" subtitle="Empty states, skeletons, and side panels" />
                <Grid container spacing={3}>
                  <Grid size={{ xs: 12, md: 4 }}>
                    <EmptyState
                      title="No items yet"
                      description="Start a session to see your vocabulary list."
                      action={{ label: 'Start Studying', onClick: () => undefined }}
                    />
                  </Grid>
                  <Grid size={{ xs: 12, md: 4 }}>
                    <ReaderSkeleton />
                  </Grid>
                  <Grid size={{ xs: 12, md: 4 }}>
                    <Stack spacing={2}>
                      <VocabCardSkeleton />
                      <LessonCardSkeleton />
                      <SidebarSkeleton />
                    </Stack>
                  </Grid>
                </Grid>

                <Box sx={{ mt: 3 }}>
                  <StudyLaunchPanel dueCount={8} onStartStudy={() => undefined} />
                </Box>
              </Box>

              <Divider />

              <Box>
                <PageHeader title="Utilities" subtitle="Gamification toasts, tier modal, and RTL" />
                <Stack spacing={2}>
                  <Stack direction="row" spacing={2}>
                    <Button variant="contained" onClick={() => setShowToast(true)}>
                      Show XP Toast
                    </Button>
                    <Button variant="outlined" onClick={() => setTierModalOpen(true)}>
                      Show Tier Modal
                    </Button>
                    <FormControl size="small" sx={{ minWidth: 160 }}>
                      <InputLabel id="rtl-select">Direction</InputLabel>
                      <Select
                        labelId="rtl-select"
                        label="Direction"
                        value={rtlMode}
                        onChange={(e) => setRtlMode(e.target.value as 'ltr' | 'rtl')}
                      >
                        <MenuItem value="ltr">LTR</MenuItem>
                        <MenuItem value="rtl">RTL</MenuItem>
                      </Select>
                    </FormControl>
                  </Stack>

                  <RTLWrapper direction={rtlMode}>
                    <Box
                      sx={{
                        border: `1px solid ${tokens.color.border}`,
                        borderRadius: tokens.radius.lg,
                        p: 2,
                        display: 'flex',
                        justifyContent: 'space-between',
                        alignItems: 'center',
                      }}
                    >
                      <Typography variant="body1">
                        RTL container sample
                      </Typography>
                      <Button variant="outlined">Action</Button>
                    </Box>
                  </RTLWrapper>
                </Stack>
              </Box>
            </Stack>
          </Container>
        </Box>

        {showToast && (
          <XPToast xp={12} onDone={() => setShowToast(false)} />
        )}
        <TierUpModal
          open={tierModalOpen}
          tier="scholar"
          totalXP={1240}
          onClose={() => setTierModalOpen(false)}
        />
      </AppShell>
    </ThemeProvider>
  );
}
