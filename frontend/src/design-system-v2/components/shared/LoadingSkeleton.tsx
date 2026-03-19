'use client';
// src/components/shared/LoadingSkeleton.tsx
// MUI v7: Skeleton is now in @mui/material (not @mui/lab)

import React from 'react';
import Box from '@mui/material/Box';
import Skeleton from '@mui/material/Skeleton'; // v7: from @mui/material, not @mui/lab
import { tokens } from '@/design-system-v2/theme/theme';

// ── Reader skeleton ─────────────────────────────────────────────────────────
export function ReaderSkeleton() {
  return (
    <Box sx={{ maxWidth: 560, mx: 'auto', px: 6, py: 5 }}>
      {/* Chapter selector */}
      <Box sx={{ display: 'flex', justifyContent: 'center', mb: 3, gap: 1 }}>
        <Skeleton variant="rounded" width={80} height={24} />
        <Skeleton variant="rounded" width={80} height={24} />
      </Box>
      {/* Verse lines */}
      {Array.from({ length: 12 }).map((_, i) => (
        <Skeleton
          key={i}
          variant="text"
          width={`${70 + Math.random() * 30}%`}
          height={52}
          sx={{ mb: 1 }}
        />
      ))}
    </Box>
  );
}

// ── Vocab set card skeleton ──────────────────────────────────────────────────
export function VocabCardSkeleton() {
  return (
    <Box
      sx={{
        p:            2.5,
        border:       `1px solid ${tokens.color.border}`,
        borderRadius: tokens.radius.lg,
        height:       200,
      }}
    >
      <Skeleton variant="text"   width="60%"  height={28} sx={{ mb: 0.5 }} />
      <Skeleton variant="text"   width="100%" height={20} />
      <Skeleton variant="text"   width="80%"  height={20} sx={{ mb: 2 }} />
      <Skeleton variant="rounded" width="100%" height={6}  sx={{ mb: 1 }} />
      <Skeleton variant="text"   width="40%"  height={16} />
    </Box>
  );
}

// ── Lesson card skeleton ─────────────────────────────────────────────────────
export function LessonCardSkeleton() {
  return (
    <Box
      sx={{
        p:            2,
        border:       `1px solid ${tokens.color.border}`,
        borderRadius: tokens.radius.md,
        display:      'flex',
        alignItems:   'center',
        gap:          2,
      }}
    >
      <Skeleton variant="circular" width={36} height={36} />
      <Box sx={{ flex: 1 }}>
        <Skeleton variant="text" width="50%" height={22} />
        <Skeleton variant="text" width="30%" height={16} />
      </Box>
      <Skeleton variant="rounded" width={60} height={24} />
    </Box>
  );
}

// ── Sidebar skeleton ─────────────────────────────────────────────────────────
export function SidebarSkeleton() {
  return (
    <Box sx={{ p: 2.5 }}>
      <Skeleton variant="text"   width="40%" height={14} sx={{ mb: 1.5 }} />
      <Skeleton variant="text"   width="55%" height={32} sx={{ mb: 0.5 }} />
      <Skeleton variant="text"   width="80%" height={22} sx={{ mb: 1.5 }} />
      <Box sx={{ display: 'flex', gap: 1, mb: 1.5 }}>
        <Skeleton variant="rounded" width={64} height={22} />
        <Skeleton variant="text"    width={80} height={22} />
      </Box>
      <Skeleton variant="rounded" width="100%" height={1} sx={{ my: 1.5 }} />
      <Box sx={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: 1 }}>
        {Array.from({ length: 6 }).map((_, i) => (
          <Box key={i}>
            <Skeleton variant="text" width="50%" height={12} />
            <Skeleton variant="text" width="70%" height={18} />
          </Box>
        ))}
      </Box>
    </Box>
  );
}

// ── Reader settings tab skeleton ─────────────────────────────────────────────
export function SettingsMenuTabSkeleton() {
  return (
    <Box sx={{ p: 2 }}>
      <Skeleton variant="text" width="60%" height={40} />
      <Skeleton variant="rounded" width="100%" height={100} sx={{ mt: 2 }} />
    </Box>
  );
}

// ── Reader details skeleton ──────────────────────────────────────────────────
export function DetailsSkeleton() {
  return (
    <Box sx={{ p: 2 }}>
      <Skeleton variant="circular" width={40} height={40} />
      <Skeleton variant="text" width="80%" height={60} sx={{ mt: 2 }} />
      <Skeleton variant="rounded" width="100%" height={200} sx={{ mt: 2 }} />
    </Box>
  );
}
