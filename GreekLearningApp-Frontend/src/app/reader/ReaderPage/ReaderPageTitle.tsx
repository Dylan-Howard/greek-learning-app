'use client';

import React from 'react';
import Typography from '@mui/material/Typography';

export default function ReaderPageTitle({ children }: { children: React.ReactNode }) {
  return (
    <Typography
      variant="h1"
      sx={{
        textAlign: 'center',
        fontSize: { xs: '2.5rem', sm: '3.5rem' },
        mt: 4,
        mb: 2,
      }}
    >
      {children}
    </Typography>
  );
}
