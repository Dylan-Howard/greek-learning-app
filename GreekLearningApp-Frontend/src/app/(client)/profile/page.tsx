'use client';

import React from 'react';
import { Container, Typography, Box, Paper, Stack, Breadcrumbs, Link } from '@mui/material';
import NextLink from 'next/link';
import { useUser } from '@clerk/nextjs';

export default function ProfilePage() {
  const { user } = useUser();

  return (
    <Container maxWidth="md" sx={{ py: 4 }}>
      <Breadcrumbs aria-label="breadcrumb" sx={{ mb: 4 }}>
        <Link component={NextLink} href="/reader" color="inherit">
          Reader
        </Link>
        <Typography color="text.primary">Profile</Typography>
      </Breadcrumbs>

      <Typography variant="h2" gutterBottom>
        User Profile
      </Typography>

      <Paper sx={{ p: 4, mt: 4 }}>
        <Stack spacing={3}>
          <Box>
            <Typography variant="overline">Name</Typography>
            <Typography variant="h5">{user?.fullName || 'Scholar'}</Typography>
          </Box>
          <Box>
            <Typography variant="overline">Email</Typography>
            <Typography variant="body1">{user?.primaryEmailAddress?.emailAddress}</Typography>
          </Box>
          <Box>
            <Typography variant="overline">Account Status</Typography>
            <Typography variant="body1">Active</Typography>
          </Box>
        </Stack>
      </Paper>
    </Container>
  );
}
