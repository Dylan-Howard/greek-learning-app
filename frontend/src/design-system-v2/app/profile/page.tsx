'use client';
// src/app/profile/page.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import LinearProgress from '@mui/material/LinearProgress';
import Divider from '@mui/material/Divider';
import Grid from '@mui/material/Grid';
import AppShell from '@/design-system-v2/components/layouts/AppShell';
import { PageHeader } from '@/design-system-v2/components/shared/PageHeader';
import UserAvatarBadge from '@/design-system-v2/components/nav/UserAvatarBadge';
import StatCard from '@/design-system-v2/components/profile/StatCard';
import ActivityHeatmap from '@/design-system-v2/components/profile/ActivityHeatmap';
import TierUpModal from '@/design-system-v2/components/gamification/TierUpModal';
import { tokens } from '@/design-system-v2/theme/theme';
import LocalFireDepartmentIcon from '@mui/icons-material/LocalFireDepartment';
import StyleOutlinedIcon from '@mui/icons-material/StyleOutlined';
import MenuBookOutlinedIcon from '@mui/icons-material/MenuBookOutlined';
import SchoolOutlinedIcon from '@mui/icons-material/SchoolOutlined';

// Demo data — replace with session/API
const USER = {
  name:        'Ανδρέας Κ.',
  initials:    'AK',
  tier:        'apprentice' as const,
  xpCurrent:   1840,
  xpForNext:   2500,
  totalXP:     1840,
  streak:      14,
  mastered:    89,
  chapters:    7,
  lessons:     2,
};

const XP_PCT = Math.round((USER.xpCurrent / USER.xpForNext) * 100);

const TIER_NAMES = { novice: 'Novice', apprentice: 'Apprentice', scholar: 'Scholar', master: 'Master' };
const NEXT_TIER  = { novice: 'Apprentice', apprentice: 'Scholar', scholar: 'Master', master: 'Master' };

// Generate mock heatmap data
function generateHeatmapData() {
  const data = [];
  const now = new Date();
  for (let i = 180; i >= 0; i--) {
    const d = new Date(now);
    d.setDate(d.getDate() - i);
    const iso = d.toISOString().slice(0, 10);
    const active = Math.random() > 0.45;
    data.push({ date: iso, count: active ? Math.floor(Math.random() * 20) + 1 : 0 });
  }
  return data;
}
const HEATMAP_DATA = generateHeatmapData();

export default function ProfilePage() {
  const [tierModal, setTierModal] = React.useState(false);

  return (
    <AppShell>
      <Box sx={{ p: { xs: 3, md: 4 }, maxWidth: 1000, mx: 'auto' }}>
        <PageHeader title="Profile" />

        <Grid container spacing={4}>
          {/* Left column: identity + stats */}
          <Grid size={{ xs: 12, md: 5 }}>
            {/* Identity */}
            <Box sx={{ display: 'flex', alignItems: 'center', gap: 2, mb: 3 }}>
              <UserAvatarBadge initials={USER.initials} xpPercent={XP_PCT} tier={USER.tier} size={64} />
              <Box>
                <Typography variant="h2">{USER.name}</Typography>
                <Typography variant="body2" sx={{ color: tokens.color.textSecondary }}>
                  {TIER_NAMES[USER.tier]}
                </Typography>
                <Typography sx={{ fontWeight: 700, fontSize: '1.125rem', color: tokens.color.xpGold }}>
                  {USER.totalXP.toLocaleString()} XP
                </Typography>
              </Box>
            </Box>

            {/* Tier progress */}
            <Box sx={{ mb: 3, p: 2, border: '1px solid ' + tokens.color.border, borderRadius: tokens.radius.md }}>
              <Box sx={{ display: 'flex', justifyContent: 'space-between', mb: 0.75 }}>
                <Typography variant="body2" sx={{ fontWeight: 600, color: tokens.color.textPrimary }}>
                  {TIER_NAMES[USER.tier]}
                </Typography>
                <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
                  {USER.xpCurrent.toLocaleString()} / {USER.xpForNext.toLocaleString()} XP
                </Typography>
              </Box>
              <LinearProgress
                variant="determinate"
                value={XP_PCT}
                sx={{ height: 8, bgcolor: tokens.color.xpRingBg, '& .MuiLinearProgress-bar': { bgcolor: tokens.color.xpGold } }}
              />
              <Typography variant="body2" sx={{ color: tokens.color.textMuted, mt: 0.75 }}>
                {(USER.xpForNext - USER.xpCurrent).toLocaleString()} XP to {NEXT_TIER[USER.tier]}
              </Typography>
            </Box>

            {/* Stat cards */}
            <Grid container spacing={1.5}>
              <Grid size={6}><StatCard value={USER.streak}   label="Day streak"         icon={<LocalFireDepartmentIcon />} color={tokens.color.srsHard} /></Grid>
              <Grid size={6}><StatCard value={USER.mastered} label="Words mastered"      icon={<StyleOutlinedIcon />} /></Grid>
              <Grid size={6}><StatCard value={USER.chapters} label="Chapters read"       icon={<MenuBookOutlinedIcon />} /></Grid>
              <Grid size={6}><StatCard value={USER.lessons}  label="Lessons completed"   icon={<SchoolOutlinedIcon />} /></Grid>
            </Grid>
          </Grid>

          {/* Right column: activity */}
          <Grid size={{ xs: 12, md: 7 }}>
            <ActivityHeatmap data={HEATMAP_DATA} weeks={26} />
            <Divider sx={{ my: 3 }} />

            {/* Recent activity feed */}
            <Typography
              sx={{ fontSize: '0.625rem', fontWeight: 600, color: tokens.color.textMuted, textTransform: 'uppercase', letterSpacing: '0.08em', mb: 1.5 }}
            >
              Recent Activity
            </Typography>
            {[
              { text: 'Reviewed 12 cards in John Chapter 1', when: '2 hours ago', icon: '🎴' },
              { text: 'Completed Lesson 3: The Article',      when: 'Yesterday',   icon: '✅' },
              { text: 'Read John 1:1–18',                     when: 'Yesterday',   icon: '📖' },
              { text: 'Mastered: λόγος · ἀρχή · θεός',        when: '2 days ago',  icon: '⭐' },
            ].map((item, i) => (
              <Box key={i} sx={{ display: 'flex', gap: 1.5, mb: 1.5 }}>
                <Typography sx={{ fontSize: '1.125rem', lineHeight: 1.4, flexShrink: 0 }}>{item.icon}</Typography>
                <Box>
                  <Typography variant="body2" sx={{ color: tokens.color.textPrimary }}>{item.text}</Typography>
                  <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>{item.when}</Typography>
                </Box>
              </Box>
            ))}
          </Grid>
        </Grid>
      </Box>

      {/* Demo tier-up modal trigger — remove in production */}
      <TierUpModal open={tierModal} tier="scholar" totalXP={2500} onClose={() => setTierModal(false)} />
    </AppShell>
  );
}
