'use client';

import React from 'react';
import { Container, Typography, Grid, Breadcrumbs, Link } from '@mui/material';
import NextLink from 'next/link';

export default function VocabularySetsPage() {
  return (
    <Container maxWidth="lg" sx={{ py: 4 }}>
      <Breadcrumbs aria-label="breadcrumb" sx={{ mb: 4 }}>
        <Link component={NextLink} href="/reader" color="inherit">
          Reader
        </Link>
        <Link component={NextLink} href="/vocabulary" color="inherit">
          Vocabulary
        </Link>
        <Typography color="text.primary">Sets</Typography>
      </Breadcrumbs>

      <Typography variant="h2" gutterBottom align="center" sx={{ mb: 6 }}>
        Vocabulary Sets
      </Typography>

      <Grid container spacing={4} justifyContent="center">
        <Typography variant="h5" color="text.secondary">
          More sets coming soon!
        </Typography>
      </Grid>
    </Container>
  );
}
