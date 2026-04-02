'use client';

import NextLink from 'next/link';
import {
  Box,
  Breadcrumbs,
  Button,
  Grid,
  Skeleton,
  Stack,
  Typography,
} from '@mui/material';
import { AppShell } from '@/components/layout/AppShell';
import StudyDashboardStats from '@/components/srs/StudyDashboardStats';
import { useGetStudyDashboardQuery } from '@/lib/api/graphql/generated';

export const dynamic = 'force-dynamic';

export default function StudyDashboardPage() {
  const { data, loading, error } = useGetStudyDashboardQuery();

  const dashboard = data?.studyDashboard ?? null;

  return (
    <AppShell>
      <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
        <Breadcrumbs aria-label="breadcrumb" sx={{ mb: 4 }}>
          <NextLink href="/reader">Koine Reader</NextLink>
          <Typography color="primary.main">Study</Typography>
        </Breadcrumbs>

        <Grid container spacing={2} sx={{ mb: 3 }}>
          <Grid size={{ xs: 12 }}>
            <Stack direction={{ xs: 'column', sm: 'row' }} justifyContent="space-between" alignItems={{ xs: 'flex-start', sm: 'center' }} spacing={2}>
              <Typography variant="h2">Study Dashboard</Typography>
              <Button component={NextLink} href="/study/session" variant="contained">
                Start Study Session
              </Button>
            </Stack>
          </Grid>
        </Grid>

        {error && (
          <Box sx={{ mb: 3 }}>
            <Typography color="error.main">Unable to load dashboard: {error.message}</Typography>
          </Box>
        )}

        <Box>
          {loading && (
            <Stack spacing={2}>
              <Skeleton variant="rectangular" height={120} />
              <Skeleton variant="rectangular" height={120} />
            </Stack>
          )}
          {!loading && dashboard && <StudyDashboardStats data={dashboard} />}
        </Box>
      </Box>
    </AppShell>
  );
}
