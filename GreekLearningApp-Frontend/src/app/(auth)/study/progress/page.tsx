'use client';

import React, { useEffect, useMemo, useState } from 'react';
import {
  Chip,
  Grid,
  Paper,
  Stack,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Typography,
} from '@mui/material';
import { getProgress } from '@/lib/api/rest/study';
import { CardProgressDto, CardState } from '@/lib/types/api';
import { TextField } from '@/components/ui';

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

export default function ProgressPage() {
  const [progress, setProgress] = useState<CardProgressDto[]>([]);
  const [query, setQuery] = useState('');

  useEffect(() => {
    getProgress().then((result) => {
      if (result.ok) {
        setProgress(result.data);
      }
    });
  }, []);

  const filtered = useMemo(() => {
    if (!query) return progress;
    const q = query.toLowerCase();
    return progress.filter((p) =>
      p.root.toLowerCase().includes(q) || p.gloss.toLowerCase().includes(q));
  }, [progress, query]);

  return (
    <Grid container justifyContent="center" sx={{ mt: 4 }}>
      <Grid size={{ xs: 11 }}>
        <Stack spacing={3}>
          <Typography variant="h2">Card Progress</Typography>
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
                {filtered.map((row) => (
                  <TableRow key={row.vocabularyId}>
                    <TableCell sx={{ fontFamily: '"Noto Serif", serif' }}>{row.root}</TableCell>
                    <TableCell>{row.gloss}</TableCell>
                    <TableCell>
                      <Chip label={row.state} color={stateColor(row.state)} variant="outlined" />
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
  );
}
