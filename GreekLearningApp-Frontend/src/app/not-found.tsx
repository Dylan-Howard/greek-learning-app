'use client';

import React from 'react';
import Box from '@mui/material/Box';
import Stack from '@mui/material/Stack';
import Typography from '@mui/material/Typography';
import NextLink from 'next/link';
import { Button } from '@/components/ui';

export default function NotFound() {
  return (
    <Box sx={{ p: 4, textAlign: 'center' }}>
      <Typography variant="h2">404 - Not Found</Typography>
      <Stack direction="row" spacing={2} justifyContent="center" sx={{ mt: 4 }}>
        <NextLink href="/reader">
          <Button variant="contained">
            Go Home
          </Button>
        </NextLink>
      </Stack>
    </Box>
  );
}
