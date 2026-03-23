'use client';

import React, { useMemo, useState } from 'react';
import {
  Chip,
  Box,
  Grid,
  Paper,
  Stack,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  TextField,
  Typography,
} from '@mui/material';
import { AppShell } from '@/components/layout/AppShell';
import { useGetUserVocabularyQuery } from '@/lib/api/graphql/generated';
import { CardState } from '@/lib/types/api';

const stateColor = (state: CardState) => {
  switch (state) {
    case 'Learning':
      return 'warning';
    case 'Review':
      return 'success';
    case 'Relearning':
      return 'error';
    default:
      return 'default';
  }
};

export function ProgressPage() {
  const [query, setQuery] = useState('');
  const { data, loading, error } = useGetUserVocabularyQuery();

  const progress = data?.studyProgress ?? [];

  const filtered = useMemo(() => {
    if (!query) return progress;
    const q = query.toLowerCase();
    return progress.filter((p) =>
      p.root.toLowerCase().includes(q) || p.gloss.toLowerCase().includes(q));
  }, [progress, query]);

  return (
    <AppShell>
      <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
        <Grid container justifyContent="center">
          <Grid size={{ xs: 12 }}>
            <Stack spacing={3}>
              <Typography variant="h2">Card Progress</Typography>

              {error && (
                <Typography color="error.main">
                  {error.message || 'Failed to load progress data.'}
                </Typography>
              )}

              <TextField
                label="Search"
                value={query}
                onChange={(event) => setQuery(event.target.value)}
                placeholder="Filter by Greek or gloss"
              />

              <TableContainer component={Paper}>
                <Table>
                  <TableHead>
                    <TableRow>
                      <TableCell>Greek</TableCell>
                      <TableCell>Gloss</TableCell>
                      <TableCell>State</TableCell>
                      <TableCell align="right">Difficulty</TableCell>
                      <TableCell align="right">Stability</TableCell>
                      <TableCell>Next Review</TableCell>
                      <TableCell align="right">Reviews</TableCell>
                      <TableCell align="right">Lapses</TableCell>
                    </TableRow>
                  </TableHead>
                  <TableBody>
                    {loading && (
                      <TableRow>
                        <TableCell colSpan={8}>
                          <Typography color="text.secondary">Loading...</Typography>
                        </TableCell>
                      </TableRow>
                    )}
                    {!loading && filtered.map((row) => (
                      <TableRow key={row.vocabularyId}>
                        <TableCell sx={{ fontFamily: '"Noto Serif", serif' }}>{row.root}</TableCell>
                        <TableCell>{row.gloss}</TableCell>
                        <TableCell>
                          <Chip label={row.state} color={stateColor(row.state as CardState)} variant="outlined" />
                        </TableCell>
                        <TableCell align="right">{row.difficulty.toFixed(2)}</TableCell>
                        <TableCell align="right">{row.stability.toFixed(2)}</TableCell>
                        <TableCell>{new Date(row.nextReviewDate).toLocaleDateString()}</TableCell>
                        <TableCell align="right">{row.reviewCount}</TableCell>
                        <TableCell align="right">{row.lapses}</TableCell>
                      </TableRow>
                    ))}
                  </TableBody>
                </Table>
              </TableContainer>
            </Stack>
          </Grid>
        </Grid>
      </Box>
    </AppShell>
  );
}

export default ProgressPage;
