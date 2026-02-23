'use client';

import React from 'react';
import {
  Container,
  Typography,
  Box,
  Grid,
  Card,
  CardContent,
  Stack,
  Button,
} from '@mui/material';
import NextLink from 'next/link';

export default function AboutPage() {
  return (
    <Container maxWidth="md" sx={{ py: 8 }}>
      <Typography variant="h2" gutterBottom align="center">
        About Koine
      </Typography>
      <Typography variant="h5" gutterBottom align="center" color="text.secondary" sx={{ mb: 6 }}>
        Your Companion to Reading the Bible in its Original Language
      </Typography>
      
      <Grid container spacing={4}>
        <Grid size={{ xs: 12, md: 6 }}>
          <Typography variant="h4" gutterBottom>
            Our Mission
          </Typography>
          <Typography variant="body1" paragraph>
            Koine is designed to bridge the gap between translations and the original Greek text
            of the New Testament. We believe that everyone should have the tools to engage
            directly with the scriptures.
          </Typography>
        </Grid>
        <Grid size={{ xs: 12, md: 6 }}>
          <Typography variant="h4" gutterBottom>
            How it Works
          </Typography>
          <Typography variant="body1" paragraph>
            Our adaptive interlinear reader adjusts to your knowledge level. As you learn more
            vocabulary, the English glosses fade away, encouraging you to read the Greek directly.
          </Typography>
        </Grid>
      </Grid>

      <Box sx={{ mt: 8, textAlign: 'center' }}>
        <NextLink href="/reader" passHref legacyBehavior>
          <Button variant="contained" size="large">
            Start Reading Now
          </Button>
        </NextLink>
      </Box>
    </Container>
  );
}
