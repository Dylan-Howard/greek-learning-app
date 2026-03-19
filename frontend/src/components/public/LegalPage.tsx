'use client';

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Divider from '@mui/material/Divider';
import PublicLayout from './PublicLayout';
import { tokens } from '@/design-system-v2/theme/theme';

interface Section {
  id: string;
  heading: string;
  children: React.ReactNode;
}

interface Props {
  title: string;
  subtitle?: string;
  lastUpdated: string;
  sections: Section[];
}

export default function LegalPage({ title, subtitle, lastUpdated, sections }: Props) {
  return (
    <PublicLayout>
      <Box sx={{ maxWidth: 1100, mx: 'auto', px: { xs: 3, md: 6 }, py: { xs: 8, md: 10 } }}>
        <Box sx={{ display: 'grid', gridTemplateColumns: { xs: '1fr', md: '220px 1fr' }, gap: { xs: 4, md: 8 }, alignItems: 'flex-start' }}>
          <Box sx={{ position: { md: 'sticky' }, top: { md: 88 } }}>
            <Typography
              sx={{ fontSize: '0.625rem', fontWeight: 700, color: tokens.color.textMuted, textTransform: 'uppercase', letterSpacing: '0.08em', mb: 1.5 }}
            >
              Contents
            </Typography>
            <Box sx={{ display: 'flex', flexDirection: 'column', gap: 0.5 }}>
              {sections.map(({ id, heading }) => (
                <Box
                  key={id}
                  component="a"
                  href={`#${id}`}
                  sx={{
                    textDecoration: 'none',
                    fontSize: '0.875rem',
                    color: tokens.color.textSecondary,
                    py: 0.375,
                    pl: 1,
                    borderLeft: '2px solid transparent',
                    transition: 'color 150ms, border-color 150ms',
                    '&:hover': { color: tokens.color.primary, borderLeftColor: tokens.color.primary },
                  }}
                >
                  {heading}
                </Box>
              ))}
            </Box>
          </Box>

          <Box>
            <Typography
              component="h1"
              sx={{ fontFamily: '"Noto Serif", serif', fontSize: { xs: '2rem', md: '2.5rem' }, color: tokens.color.textPrimary, mb: 0.75 }}
            >
              {title}
            </Typography>
            {subtitle && (
              <Typography variant="body1" sx={{ color: tokens.color.textSecondary, mb: 1 }}>
                {subtitle}
              </Typography>
            )}
            <Typography variant="body2" sx={{ color: tokens.color.textMuted, mb: 3 }}>
              Last updated: {lastUpdated}
            </Typography>
            <Divider sx={{ mb: 4 }} />

            {sections.map(({ id, heading, children }) => (
              <Box key={id} id={id} sx={{ mb: 5 }}>
                <Typography
                  component="h2"
                  sx={{ fontFamily: '"Noto Serif", serif', fontSize: '1.375rem', fontWeight: 700, color: tokens.color.primaryDark, mb: 1.5 }}
                >
                  {heading}
                </Typography>
                <Box sx={{ '& p': { mb: 1.5, lineHeight: 1.8, color: tokens.color.textSecondary, fontSize: '0.9375rem' }, '& ul': { pl: 2.5, mb: 1.5 }, '& li': { mb: 0.75, lineHeight: 1.8, color: tokens.color.textSecondary, fontSize: '0.9375rem' }, '& strong': { color: tokens.color.textPrimary, fontWeight: 600 } }}>
                  {children}
                </Box>
              </Box>
            ))}
          </Box>
        </Box>
      </Box>
    </PublicLayout>
  );
}
