'use client';
// src/components/shared/PageHeader.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Divider from '@mui/material/Divider';
import { tokens } from '@/design-system-v2/theme/theme';

interface PageHeaderProps {
  title:     string;
  subtitle?: string;
  actions?:  React.ReactNode;
}

export function PageHeader({ title, subtitle, actions }: PageHeaderProps) {
  return (
    <Box sx={{ mb: 3 }}>
      <Box sx={{ display: 'flex', alignItems: 'flex-start', justifyContent: 'space-between', gap: 2, pb: 2 }}>
        <Box>
          <Typography variant="h1" sx={{ color: tokens.color.textPrimary, mb: subtitle ? 0.5 : 0 }}>
            {title}
          </Typography>
          {subtitle && (
            <Typography variant="body1" sx={{ color: tokens.color.textSecondary }}>
              {subtitle}
            </Typography>
          )}
        </Box>
        {actions && <Box sx={{ flexShrink: 0 }}>{actions}</Box>}
      </Box>
      <Divider />
    </Box>
  );
}
