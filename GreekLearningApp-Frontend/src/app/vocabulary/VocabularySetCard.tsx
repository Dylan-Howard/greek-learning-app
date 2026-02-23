'use client';

import React from 'react';
import {
  Card,
  CardContent,
  Typography,
  LinearProgress,
  Box,
  Link,
} from '@mui/material';
import NextLink from 'next/link';

export default function VocabularySetCard({
  title,
  description,
  link,
  progress,
}: {
  title: string;
  description: string;
  link: string;
  progress: number;
}) {
  return (
    <Card variant="outlined" sx={{ height: '100%' }}>
      <CardContent>
        <Typography variant="h5" component="div">
          {title}
        </Typography>
        <Typography variant="body2" color="text.secondary" sx={{ mb: 2 }}>
          {description}
        </Typography>
        <Box sx={{ mt: 2 }}>
          <Box sx={{ display: 'flex', alignItems: 'center' }}>
            <Box sx={{ width: '100%', mr: 1 }}>
              <LinearProgress variant="determinate" value={progress} />
            </Box>
            <Box sx={{ minWidth: 35 }}>
              <Typography variant="body2" color="text.secondary">{`${Math.round(
                progress,
              )}%`}</Typography>
            </Box>
          </Box>
        </Box>
        <Box sx={{ mt: 2 }}>
          <Link href={link} component={NextLink} sx={{ textDecoration: 'none' }}>
            View Set
          </Link>
        </Box>
      </CardContent>
    </Card>
  );
}
