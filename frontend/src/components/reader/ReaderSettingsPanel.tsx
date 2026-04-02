'use client';

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import { tokens } from '@/theme/theme';
import SettingsMenu from '@/components/features/reader/Navigation/SettingsMenu';

interface Props {
  title: string;
}

export default function ReaderSettingsPanel({ title }: Props) {
  return (
    <Box sx={{ p: 2.5 }}>
      <Typography variant="overline" sx={{ color: tokens.color.textMuted }}>
        {title}
      </Typography>
      <SettingsMenu title={title} />
    </Box>
  );
}
