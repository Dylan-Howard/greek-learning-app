'use client';

import React from 'react';
import {
  Box,
  Breadcrumbs,
  Grid,
  Typography,
} from '@mui/material';
import NextLink from 'next/link';
import { AppShell } from '@/components/layout/AppShell';
import StatCard from '@/design-system-v2/components/profile/StatCard';
import ActivityHeatmap from '@/design-system-v2/components/profile/ActivityHeatmap';
import { useUserContext } from '@/lib/types/domain/user';
import {
  experienceProgressPercent,
  levelFromExperience,
} from '@/lib/services/user/gamification';
import MenuBookOutlinedIcon from '@mui/icons-material/MenuBookOutlined';
import StyleOutlinedIcon from '@mui/icons-material/StyleOutlined';
import StarOutlineIcon from '@mui/icons-material/StarOutline';

export const dynamic = 'force-dynamic';

export default function ProfilePage() {
  const { user } = useUserContext();

  const totalExp = user?.totalExp ?? 0;
  const level = levelFromExperience(totalExp);
  const progress = experienceProgressPercent(totalExp);

  return (
    <AppShell>
      <Box sx={{ px: { xs: 3, md: 6 }, py: 4 }}>
        <Breadcrumbs aria-label="breadcrumb" sx={{ mb: 4 }}>
          <NextLink href="/reader">Reader</NextLink>
          <Typography color="text.primary">Profile</Typography>
        </Breadcrumbs>

        <Typography variant="h2" sx={{ mb: 3 }}>
          {user?.name || 'Scholar'}
        </Typography>

        <Grid container spacing={2} sx={{ mb: 4 }}>
          <Grid size={{ xs: 12, sm: 4 }}>
            <StatCard value={`Lv ${level}`} label="Current Level" icon={<StarOutlineIcon />} />
          </Grid>
          <Grid size={{ xs: 12, sm: 4 }}>
            <StatCard value={`${totalExp}`} label="Total XP" icon={<StyleOutlinedIcon />} />
          </Grid>
          <Grid size={{ xs: 12, sm: 4 }}>
            <StatCard value={`${Math.round(progress)}%`} label="Progress to Next" icon={<MenuBookOutlinedIcon />} />
          </Grid>
        </Grid>

        <ActivityHeatmap data={[]} />
      </Box>
    </AppShell>
  );
}
