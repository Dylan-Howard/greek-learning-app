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
import { useParams, useRouter } from 'next/navigation';
import { AppShell } from '@/components/layout/AppShell';
import VocabWordRow, { type VocabWord } from '@/components/vocab/VocabWordRow';
import { fetchVocabularySetById } from '@/lib/api/rest/vocabulary';
import { VocabularySetItemDto } from '@/lib/types/api';
import { useUserContext } from '@/lib/types/domain/user';

export const dynamic = 'force-dynamic';

export default function VocabularySetDetailsPage() {
  const router = useRouter();
  const params = useParams();
  const { user } = useUserContext();
  const setIdParam = params?.setId;
  const setId = Array.isArray(setIdParam) ? setIdParam[0] : setIdParam;
  const numericId = Number.parseInt(setId || '', 10);

  const [set, setSet] = useState<{ title: string; description: string; knownCount: number; totalCount: number; percentComplete: number; items: VocabularySetItemDto[] } | null>(null);
  const [errorMessage, setErrorMessage] = useState<string | undefined>();

  useEffect(() => {
    if (Number.isNaN(numericId)) {
      setSet(null);
      return;
    }
    if (!user?.id) return;
    fetchVocabularySetById(numericId, user.id).then((result) => {
      if (result.ok) {
        setSet(result.data);
        setErrorMessage(undefined);
      } else {
        setSet(null);
        setErrorMessage(result.error.message);
      }
    });
  }, [numericId, user?.id]);

  const mappedWords: VocabWord[] = useMemo(() => (set?.items || []).map((item) => ({
    id: String(item.vocabularyId),
    greek: item.root,
    transliteration: '',
    definition: item.gloss,
    partOfSpeech: '—',
    frequency: 0,
    srsStatus: item.masteryLevel >= 90 ? 'mastered' : item.masteryLevel >= 70 ? 'due' : 'new',
  })), [set?.items]);

  if (!set) {
    return (
      <AppShell>
        <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
          <Typography variant="h3" sx={{ mb: 2 }}>Vocabulary set not found</Typography>
          {errorMessage && (
            <Typography color="error.main" sx={{ mb: 2 }}>
              Error: {errorMessage}
            </Typography>
          )}
          <NextLink href="/vocabulary/sets">Back to sets</NextLink>
        </Box>
      </AppShell>
    );
  }

  return (
    <AppShell>
      <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
        <Breadcrumbs aria-label="breadcrumb" sx={{ mb: 4 }}>
          <NextLink href="/reader">Koine Reader</NextLink>
          <NextLink href="/vocabulary/sets">Vocabulary Sets</NextLink>
          <Typography color="primary.main">{set.title}</Typography>
        </Breadcrumbs>

        <Typography variant="h2" sx={{ mb: 1 }}>{set.title}</Typography>
        <Typography variant="body1" sx={{ mb: 2 }}>{set.description}</Typography>
        <Typography variant="body2" sx={{ mb: 3 }}>
          Progress: {set.knownCount}/{set.totalCount} known ({Math.round(set.percentComplete)}%)
        </Typography>

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

        <Stack direction="row" spacing={2} sx={{ mt: 4, mb: 6 }}>
          <Button variant="contained" onClick={() => router.push(`/study/session?setId=${numericId}`)}>
            Study This Set
          </Button>
          <Button onClick={() => router.push('/vocabulary/sets')}>
            Back to Sets
          </Button>
        </Stack>
      </Box>
    </AppShell>
  );
}
