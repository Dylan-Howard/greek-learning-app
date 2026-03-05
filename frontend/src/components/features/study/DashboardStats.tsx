'use client';

import React from 'react';
import {
  Card,
  CardContent,
  Grid,
  LinearProgress,
  Stack,
  Typography,
} from '@mui/material';
import { DashboardDto } from '@/lib/types/api';

interface DashboardStatsProps {
  data: DashboardDto;
}

export default function DashboardStats({ data }: DashboardStatsProps) {
  const maxHistory = Math.max(1, ...data.reviewHistory.map((h) => h.count));

  return (
    <Grid container spacing={3}>
      <Grid size={{ xs: 12, sm: 4 }}>
        <Card variant="outlined">
          <CardContent>
            <Typography variant="h6">Total Cards</Typography>
            <Typography variant="h3">{data.totalCards}</Typography>
          </CardContent>
        </Card>
      </Grid>
      <Grid size={{ xs: 12, sm: 4 }}>
        <Card variant="outlined">
          <CardContent>
            <Typography variant="h6">Due Today</Typography>
            <Typography variant="h3">{data.dueToday}</Typography>
          </CardContent>
        </Card>
      </Grid>
      <Grid size={{ xs: 12, sm: 4 }}>
        <Card variant="outlined">
          <CardContent>
            <Typography variant="h6">Current Streak</Typography>
            <Typography variant="h3">{data.currentStreak}</Typography>
          </CardContent>
        </Card>
      </Grid>

      <Grid size={{ xs: 12 }}>
        <Card variant="outlined">
          <CardContent>
            <Typography variant="h6" sx={{ mb: 2 }}>Last 7 Days</Typography>
            <Stack spacing={1}>
              {data.reviewHistory.map((point) => (
                <Stack key={point.date} direction="row" spacing={2} alignItems="center">
                  <Typography variant="body2" sx={{ width: 90 }}>
                    {point.date}
                  </Typography>
                  <LinearProgress
                    variant="determinate"
                    value={(point.count / maxHistory) * 100}
                    sx={{ flexGrow: 1, height: 10, borderRadius: 6 }}
                  />
                  <Typography variant="body2" sx={{ width: 32, textAlign: 'right' }}>
                    {point.count}
                  </Typography>
                </Stack>
              ))}
            </Stack>
          </CardContent>
        </Card>
      </Grid>
    </Grid>
  );
}
