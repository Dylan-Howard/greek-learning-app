'use client';

import React from 'react';
import Skeleton from '@mui/material/Skeleton';
import Box from '@mui/material/Box';

export function SettingsMenuTabSkeleton() {
  return (
    <Box sx={{ p: 2 }}>
      <Skeleton variant="text" width="60%" height={40} />
      <Skeleton variant="rectangular" width="100%" height={100} sx={{ mt: 2 }} />
    </Box>
  );
}

export function DetailsSkeleton() {
  return (
    <Box sx={{ p: 2 }}>
      <Skeleton variant="circular" width={40} height={40} />
      <Skeleton variant="text" width="80%" height={60} sx={{ mt: 2 }} />
      <Skeleton variant="rectangular" width="100%" height={200} sx={{ mt: 2 }} />
    </Box>
  );
}
