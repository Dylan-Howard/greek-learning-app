'use client';

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import { useReaderContext } from './ReaderPageContext';
import { RenderedUnitDto } from '../../../types/api';

export default function ReaderPageUnitControl({ unit }: { unit: RenderedUnitDto }) {
  const { page, setPage } = useReaderContext();

  const handleClick = () => {
    if (unit.vocabId) {
      setPage({ ...page, tabId: 3, morphologyId: unit.vocabId });
    }
  };

  return (
    <Box
      component="span"
      onClick={handleClick}
      sx={{
        display: 'inline-flex',
        flexDirection: 'column',
        alignItems: 'center',
        verticalAlign: 'top',
        mx: 0.5,
        cursor: unit.vocabId ? 'pointer' : 'default',
      }}
    >
      <Typography
        variant="body1"
        sx={{
          fontFamily: '"Noto Serif", serif',
          fontSize: '1.2rem',
          lineHeight: 1.2,
        }}
      >
        {unit.original}
      </Typography>
      <Typography
        variant="caption"
        sx={{
          fontSize: '0.75rem',
          color: 'text.secondary',
          lineHeight: 1.2,
        }}
      >
        {unit.text}
      </Typography>
    </Box>
  );
}
