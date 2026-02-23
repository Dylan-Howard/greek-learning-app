'use client';

import React from 'react';
import Typography from '@mui/material/Typography';
import { useTheme } from '@mui/material/styles';
import { Box } from '@mui/material';
import { RenderedUnitDto } from '../../../types/api';

export default function ReaderPageUnit({ unit }: { unit: RenderedUnitDto }) {
  const theme = useTheme();

  // Handle expanded units (recursive)
  if (unit.type === 'expanded' && unit.children) {
    return (
      <Box component="span" sx={{ display: 'inline-flex', flexWrap: 'wrap', borderBottom: '1px dotted #ccc', pb: 0.5 }}>
        {unit.children.map((child, idx) => (
          <ReaderPageUnit key={idx} unit={child} />
        ))}
      </Box>
    );
  }

  // Handle leaf units
  return (
    <Typography
      component="span"
      sx={{
        fontSize: '1.2rem',
        mr: 1,
        cursor: 'pointer',
        color: unit.type === 'translated' ? 'text.secondary' : 'inherit',
        fontStyle: unit.type === 'translated' ? 'italic' : 'normal',
        '&:hover': {
          color: theme.palette.primary.main,
        },
      }}
    >
      {unit.text || unit.original}
    </Typography>
  );
}
