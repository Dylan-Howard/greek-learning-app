'use client';

import React from 'react';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Stack from '@mui/material/Stack';
import Typography from '@mui/material/Typography';

export default function ErrorBoundary({
  error,
  reset,
}: {
  error: Error & { digest?: string };
  reset: () => void;
}) {
  return (
    <Box sx={{ p: 4, textAlign: 'center' }}>
      <Typography variant="h2">Something went wrong!</Typography>
      <Typography variant="body1" sx={{ mt: 2, color: 'text.secondary' }}>
        {error.message}
      </Typography>
      <Stack direction="row" spacing={2} justifyContent="center" sx={{ mt: 4 }}>
        <Button variant="contained" onClick={() => reset()}>
          Try again
        </Button>
      </Stack>
    </Box>
  );
}
