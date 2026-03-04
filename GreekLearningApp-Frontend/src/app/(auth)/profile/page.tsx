'use client';

import React from 'react';
import {
  Avatar,
  Box,
  Breadcrumbs,
  Chip,
  Container,
  LinearProgress,
  Link,
  Paper,
  Stack,
  Typography,
} from '@mui/material';
import NextLink from 'next/link';
import { useUserContext } from '@/lib/types/domain/user';
import {
  avatarColorFromUserId,
  avatarInitial,
  experienceProgressPercent,
  inLevelExperience,
  levelFromExperience,
  XP_PER_LEVEL,
} from '@/lib/services/user/gamification';

export const dynamic = 'force-dynamic';

export default function ProfilePage() {
  const { user } = useUserContext();

  const totalExp = user?.totalExp ?? 0;
  const level = levelFromExperience(totalExp);
  const inLevelExp = inLevelExperience(totalExp);
  const progress = experienceProgressPercent(totalExp);

  return (
    <Container maxWidth="md" sx={{ py: 4 }}>
      <Breadcrumbs aria-label="breadcrumb" sx={{ mb: 4 }}>
        <Link component={NextLink} href="/reader" color="inherit">
          Reader
        </Link>
        <Typography color="text.primary">Profile</Typography>
      </Breadcrumbs>

      <Typography variant="h2" gutterBottom>
        Profile
      </Typography>

      <Paper sx={{ p: 4, mt: 4 }}>
        <Stack spacing={3}>
          <Stack direction="row" spacing={2} alignItems="center">
            <Avatar
              sx={{
                width: 56,
                height: 56,
                bgcolor: avatarColorFromUserId(user?.id),
                fontWeight: 700,
              }}
            >
              {avatarInitial(user?.name)}
            </Avatar>
            <Box>
              <Typography variant="h5">{user?.name || 'Scholar'}</Typography>
              <Typography variant="body2" color="text.secondary">
                {`Development User ${user?.id || 'guest'}`}
              </Typography>
            </Box>
          </Stack>

          <Stack direction="row" spacing={1} alignItems="center">
            <Chip label={`Level ${level}`} color="primary" />
            <Chip label={`${totalExp} XP`} variant="outlined" />
          </Stack>

          <Box>
            <Typography variant="overline">Progress to Next Level</Typography>
            <LinearProgress variant="determinate" value={progress} sx={{ mt: 1, height: 8, borderRadius: 999 }} />
            <Typography variant="caption" color="text.secondary" sx={{ mt: 1, display: 'block' }}>
              {`${inLevelExp} / ${XP_PER_LEVEL} XP`}
            </Typography>
          </Box>
        </Stack>
      </Paper>
    </Container>
  );
}
