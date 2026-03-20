'use client';

import NextLink from 'next/link';
import {
  Box,
  Breadcrumbs,
  Button,
  Grid,
  Stack,
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableRow,
  Typography,
} from '@mui/material';
import { useEffect, useMemo, useState } from 'react';
import { useRouter } from 'next/navigation';
import * as AzureTextService from '@/lib/api/rest/text';
import { AppShell } from '@/components/layout/AppShell';
import VocabSetCard, { type VocabSet } from '@/design-system-v2/components/vocab/VocabSetCard';
import VocabWordRow, { type VocabWord } from '@/design-system-v2/components/vocab/VocabWordRow';
import TransliterationSearchInput from '@/design-system-v2/components/vocab/TransliterationSearchInput';
import { SimpleWordDto } from '@/lib/types/api';
import { useGetVocabularySetsQuery } from '@/lib/api/graphql/generated';

export const dynamic = 'force-dynamic';

export default function Vocabulary() {
  const router = useRouter();
  const [words, setWords] = useState<SimpleWordDto[]>([]);
  const [query, setQuery] = useState('');

  const { data: setsData, error: setsError } = useGetVocabularySetsQuery();

  useEffect(() => {
    AzureTextService.fetchVocabulary().then((vocab) => {
      setWords(vocab);
    });
  }, []);

  const sets = useMemo(() => setsData?.studySets?.filter((s) => s != null) ?? [], [setsData]);

  const featuredSets = useMemo(() => (
    sets
      .filter((set) => set.isSystem)
      .sort((a, b) => b.totalCount - a.totalCount)
      .slice(0, 3)
  ), [sets]);

  const mappedSets: VocabSet[] = useMemo(() => featuredSets.map((set) => ({
    id: String(set.id),
    title: set.title,
    description: set.description,
    wordCount: set.totalCount,
    mastered: set.knownCount,
    dueCount: set.learningCount,
    lastStudied: set.lastPracticed ?? null,
  })), [featuredSets]);

  const filteredWords = useMemo(() => {
    if (!query.trim()) return words;
    const lower = query.toLowerCase();
    return words.filter((word) => word.content.toLowerCase().includes(lower) || (word.gloss || '').toLowerCase().includes(lower));
  }, [query, words]);

  const mappedWords: VocabWord[] = useMemo(() => filteredWords.map((word) => ({
    id: String(word.rootId),
    greek: word.content,
    transliteration: '',
    definition: word.gloss || '—',
    partOfSpeech: '—',
    frequency: word.occurrences ?? 0,
    srsStatus: 'new',
  })), [filteredWords]);

  return (
    <AppShell>
      <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
        <Breadcrumbs aria-label="breadcrumb" sx={{ mb: 4 }}>
          <NextLink href="/reader">Koine Reader</NextLink>
          <Typography color="primary.main">Vocabulary</Typography>
        </Breadcrumbs>

        <Typography variant="h2" sx={{ mb: 3 }}>Vocabulary Sets</Typography>

        {setsError && (
          <Typography color="error.main" sx={{ mb: 3 }}>Unable to load vocabulary sets: {setsError.message}</Typography>
        )}

        <Grid container spacing={2} sx={{ mb: 4 }}>
          {mappedSets.map((set) => (
            <Grid key={set.id} size={{ xs: 12, sm: 6, md: 4 }}>
              <VocabSetCard
                set={set}
                onClick={(setId) => { router.push(`/vocabulary/sets/${setId}`); }}
                onStudy={(setId) => { router.push(`/study/session?setId=${setId}`); }}
              />
            </Grid>
          ))}
          {mappedSets.length === 0 && (
            <Grid size={{ xs: 12 }}>
              <Typography variant="body1">No vocabulary sets are currently available.</Typography>
            </Grid>
          )}
        </Grid>

        <Stack direction="row" justifyContent="center" sx={{ mb: 6 }}>
          <Button component={NextLink} href="/vocabulary/sets">
            See More
          </Button>
        </Stack>

        <Stack direction={{ xs: 'column', sm: 'row' }} spacing={2} alignItems={{ xs: 'stretch', sm: 'center' }} sx={{ mb: 2 }}>
          <Typography variant="h2">All Vocabulary</Typography>
          <Box sx={{ flex: 1 }}>
            <TransliterationSearchInput value={query} onChange={setQuery} placeholder="Search Greek or gloss..." />
          </Box>
        </Stack>

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
            {mappedWords.map((word) => (
              <VocabWordRow key={word.id} word={word} onClick={() => {}} />
            ))}
          </TableBody>
        </Table>
      </Box>
    </AppShell>
  );
}
