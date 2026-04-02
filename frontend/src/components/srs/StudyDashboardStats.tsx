'use client';

import React from 'react';
import {
  Box,
  Grid,
  LinearProgress,
  Stack,
  Typography,
} from '@mui/material';
import { tokens } from '@/design-system-v2/theme/theme';
import { DashboardDto } from '@/lib/types/api';
import StatCard from '@/design-system-v2/components/profile/StatCard';
import StyleOutlinedIcon from '@mui/icons-material/StyleOutlined';
import AutoAwesomeOutlinedIcon from '@mui/icons-material/AutoAwesomeOutlined';
import CalendarTodayOutlinedIcon from '@mui/icons-material/CalendarTodayOutlined';

interface Props {
  data: DashboardDto;
}

export default function StudyDashboardStats({ data }: Props) {
  const maxHistory = Math.max(1, ...data.reviewHistory.map((h) => h.count));

  return (
    <Stack spacing={3}>
      <Grid container spacing={2}>
        <Grid size={{ xs: 12, sm: 4 }}>
          <StatCard value={data.totalCards} label="Total Cards" icon={<StyleOutlinedIcon />} />
        </Grid>
        <Grid size={{ xs: 12, sm: 4 }}>
          <StatCard value={data.dueToday} label="Due Today" icon={<CalendarTodayOutlinedIcon />} />
        </Grid>
        <Grid size={{ xs: 12, sm: 4 }}>
          <StatCard value={data.currentStreak} label="Current Streak" icon={<AutoAwesomeOutlinedIcon />} />
        </Grid>
      </Grid>

      <Box>
        <Typography variant="overline" sx={{ color: tokens.color.textMuted }}>
          Last 7 Days
        </Typography>
        <Stack spacing={1.5} sx={{ mt: 1 }}>
          {data.reviewHistory.map((point) => (
            <Stack key={point.date} direction="row" spacing={2} alignItems="center">
              <Typography variant="body2" sx={{ width: 90, color: tokens.color.textMuted }}>
                {point.date}
              </Typography>
              <LinearProgress
                variant="determinate"
                value={(point.count / maxHistory) * 100}
                sx={{
                  flexGrow: 1,
                  height: 8,
                  borderRadius: tokens.radius.full,
                  bgcolor: tokens.color.surfaceAlt,
                  '& .MuiLinearProgress-bar': { bgcolor: tokens.color.primary },
                }}
              />
              <Typography variant="body2" sx={{ width: 32, textAlign: 'right', color: tokens.color.textSecondary }}>
                {point.count}
              </Typography>
            </Stack>
          ))}
        </Stack>
      </Box>
    </Stack>
  );
}
