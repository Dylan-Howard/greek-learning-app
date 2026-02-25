'use client';

import React from 'react';
import {
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Paper,
} from '@mui/material';
import { SimpleWordDto } from '../../types/api';

export default function VocabularyTable({ words }: { words: SimpleWordDto[] }) {
  return (
    <TableContainer component={Paper}>
      <Table aria-label="vocabulary table">
        <TableHead>
          <TableRow>
            <TableCell>Greek</TableCell>
            <TableCell>Translation</TableCell>
            <TableCell align="right">Count</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {words.map((word) => (
            <TableRow key={word.rootId}>
              <TableCell component="th" scope="row" sx={{ fontFamily: '"Noto Serif", serif', fontSize: '1.1rem' }}>
                {word.content}
              </TableCell>
              <TableCell>{word.gloss}</TableCell>
              <TableCell align="right">{word.occurrences}</TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
}
