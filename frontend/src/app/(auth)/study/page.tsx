import NextLink from 'next/link';
import {
  Breadcrumbs,
  Grid,
  Skeleton,
  Stack,
  Typography,
} from '@mui/material';
import { cookies } from 'next/headers';
import DashboardStats from '@/components/features/study/DashboardStats';
import { getDashboard } from '@/lib/api/rest/study';
import { Button } from '@/components/shared';
import { DEFAULT_DEV_USER_ID, DEV_USER_COOKIE_KEY, sanitizeDevUserId } from '@/lib/services/auth/devSession';

export const dynamic = 'force-dynamic';

export default async function StudyDashboardPage() {
  const cookieStore = await cookies();
  const userId = sanitizeDevUserId(cookieStore.get(DEV_USER_COOKIE_KEY)?.value || DEFAULT_DEV_USER_ID);
  const dashboardResult = await getDashboard(userId);
  const error = dashboardResult.ok ? undefined : dashboardResult.error.message;
  const dashboard = dashboardResult.ok ? dashboardResult.data : null;

  return (
    <Grid container justifyContent="center" sx={{ mt: 4 }}>
      <Grid size={{ sm: 11 }} sx={{ mb: 4 }}>
        <Breadcrumbs aria-label="breadcrumb">
          <NextLink href="/reader">Koine Reader</NextLink>
          <Typography color="primary.main">Study</Typography>
        </Breadcrumbs>
      </Grid>

      <Grid size={{ xs: 11 }} sx={{ mb: 4 }}>
        <Stack direction="row" justifyContent="space-between" alignItems="center">
          <Typography variant="h2">Study Dashboard</Typography>
          <NextLink href="/study/session">
            <Button variant="contained">Start Study Session</Button>
          </NextLink>
        </Stack>
      </Grid>

      {error && (
        <Grid size={{ xs: 11 }} sx={{ mb: 3 }}>
          <Typography color="error.main">Unable to load dashboard: {error}</Typography>
        </Grid>
      )}

      <Grid size={{ xs: 11 }}>
        {!dashboard && !error && (
          <Stack spacing={2}>
            <Skeleton variant="rectangular" height={120} />
            <Skeleton variant="rectangular" height={120} />
          </Stack>
        )}
        {dashboard && <DashboardStats data={dashboard} />}
      </Grid>
    </Grid>
  );
}
