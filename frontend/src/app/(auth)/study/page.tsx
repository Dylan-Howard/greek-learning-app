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
import { useEffect, useState } from 'react';
import { AppShell } from '@/components/layout/AppShell';
import StudyDashboardStats from '@/design-system-v2/components/srs/StudyDashboardStats';
import { getDashboard } from '@/lib/api/rest/study';
import { getActiveDevUserId } from '@/lib/services/auth/devSession';
import { type DashboardDto } from '@/lib/types/api';

export const dynamic = 'force-dynamic';

export default function StudyDashboardPage() {
  const [dashboard, setDashboard] = useState<DashboardDto | null>(null);
  const [error, setError] = useState<string | undefined>();
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const userId = getActiveDevUserId();
    getDashboard(userId).then((result) => {
      if (result.ok) {
        setDashboard(result.data);
        setError(undefined);
      } else {
        setDashboard(null);
        setError(result.error.message);
      }
      setLoading(false);
    });
  }, []);

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
            <Typography color="error.main">Unable to load dashboard: {error}</Typography>
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
