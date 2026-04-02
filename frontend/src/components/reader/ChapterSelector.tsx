'use client';
// src/components/reader/ChapterSelector.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Select, { SelectChangeEvent } from '@mui/material/Select';
import MenuItem from '@mui/material/MenuItem';
import Typography from '@mui/material/Typography';
import { tokens } from '@/theme/theme';

interface BookOption { id: string; name: string; chapters: number; }
interface Props {
  books:           BookOption[];
  selectedBook:    string;
  selectedChapter: number;
  onBookChange:    (bookId: string) => void;
  onChapterChange: (chapter: number) => void;
}

const GHOST_SELECT_SX = {
  '& .MuiOutlinedInput-notchedOutline': { border: 'none' },
  '&:hover .MuiOutlinedInput-notchedOutline': { border: 'none' },
  '&.Mui-focused .MuiOutlinedInput-notchedOutline': { border: 'none' },
  '& .MuiSelect-select': {
    py:         0.5,
    px:         0.75,
    fontFamily: '"Noto Sans", sans-serif',
    fontSize:   '0.8125rem',
    color:      tokens.color.textSecondary,
    fontWeight: 500,
    '&:hover':  { color: tokens.color.primary },
  },
  '& .MuiSelect-icon': {
    color:    tokens.color.textMuted,
    fontSize: '1rem',
  },
  bgcolor:      'transparent',
  borderRadius: tokens.radius.sm,
  '&:hover': {
    bgcolor: tokens.color.primaryLight,
    '& .MuiSelect-select': { color: tokens.color.primary },
  },
};

export default function ChapterSelector({
  books,
  selectedBook,
  selectedChapter,
  onBookChange,
  onChapterChange,
}: Props) {
  const currentBook = books.find((b) => b.id === selectedBook);
  const chapterCount = currentBook?.chapters ?? 1;

  return (
    <Box
      sx={{
        maxWidth:       560,
        mx:             'auto',
        px:             { xs: 3, md: 6 },
        pt:             3,
        pb:             1,
        display:        'flex',
        alignItems:     'center',
        justifyContent: 'center',
        gap:            0.5,
      }}
    >
      {/* Book selector */}
      <Select
        value={selectedBook}
        onChange={(e: SelectChangeEvent) => onBookChange(e.target.value)}
        size="small"
        variant="outlined"
        aria-label="Select book"
        sx={GHOST_SELECT_SX}
        MenuProps={{
          PaperProps: {
            sx: { maxHeight: 320, borderRadius: tokens.radius.md },
          },
        }}
      >
        {books.map((book) => (
          <MenuItem key={book.id} value={book.id} sx={{ fontSize: '0.875rem' }}>
            {book.name}
          </MenuItem>
        ))}
      </Select>

      {/* Divider */}
      <Typography
        sx={{ color: tokens.color.borderStrong, fontSize: '0.875rem', mx: 0.5, userSelect: 'none' }}
      >
        /
      </Typography>

      {/* Chapter selector */}
      <Select
        value={selectedChapter}
        onChange={(e: SelectChangeEvent<number>) => onChapterChange(Number(e.target.value))}
        size="small"
        variant="outlined"
        aria-label="Select chapter"
        sx={GHOST_SELECT_SX}
        MenuProps={{
          PaperProps: {
            sx: { maxHeight: 320, borderRadius: tokens.radius.md },
          },
        }}
      >
        {Array.from({ length: chapterCount }, (_, i) => i + 1).map((ch) => (
          <MenuItem key={ch} value={ch} sx={{ fontSize: '0.875rem' }}>
            Chapter {ch}
          </MenuItem>
        ))}
      </Select>
    </Box>
  );
}
