'use client';

import React from 'react';
import Stack from '@mui/material/Stack';
import Fab from '@mui/material/Fab';
import NavigateBeforeIcon from '@mui/icons-material/NavigateBefore';
import NavigateNextIcon from '@mui/icons-material/NavigateNext';
import { useReaderContext } from './ReaderPageContext';

export default function ReaderPageControls() {
  const { page, setPage } = useReaderContext();

  const handleNext = () => {
    if (page) {
      setPage({ ...page, chapterId: page.chapterId + 1 });
    }
  };

  const handlePrev = () => {
    if (page && page.chapterId > 1) {
      setPage({ ...page, chapterId: page.chapterId - 1 });
    }
  };

  return (
    <Stack
      direction="row"
      spacing={2}
      sx={{
        position: 'fixed',
        bottom: 16,
        right: 16,
        zIndex: 1000,
      }}
    >
      <Fab color="primary" onClick={handlePrev} disabled={!page || page.chapterId <= 1}>
        <NavigateBeforeIcon />
      </Fab>
      <Fab color="primary" onClick={handleNext} disabled={!page}>
        <NavigateNextIcon />
      </Fab>
    </Stack>
  );
}
