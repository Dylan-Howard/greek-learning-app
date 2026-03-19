'use client';

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import { tokens } from '@/design-system-v2/theme/theme';
import DetailsMenu from '@/components/features/reader/Navigation/DetailsMenu';

export default function ReaderDetailsPanel() {
  return (
    <Box sx={{ p: 2.5 }}>
      <Typography variant="overline" sx={{ color: tokens.color.textMuted, mb: 1, display: 'block' }}>
        Details
      </Typography>
      <DetailsMenu />
    </Box>
  );
}
