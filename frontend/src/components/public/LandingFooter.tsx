'use client';

import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Link from '@mui/material/Link';
import Divider from '@mui/material/Divider';
import { tokens } from '@/theme/theme';

const LINKS = {
  App: [
    { label: 'Reader', href: '/reader' },
    { label: 'Vocabulary', href: '/vocabulary' },
    { label: 'Lessons', href: '/lessons' },
    { label: 'Sign up', href: '/auth/signup' },
  ],
  Legal: [
    { label: 'Privacy Policy', href: '/privacy' },
    { label: 'Terms of Service', href: '/terms' },
    { label: 'Cookie Policy', href: '/privacy#cookies' },
  ],
  Support: [
    { label: 'Contact', href: '/contact' },
    { label: 'Donate', href: '/contact#donate' },
  ],
};

export default function LandingFooter() {
  return (
    <Box
      component="footer"
      sx={{
        bgcolor: tokens.color.surface,
        borderTop: `1px solid ${tokens.color.border}`,
        pt: 6,
        pb: 4,
        px: { xs: 3, md: 6 },
      }}
    >
      <Box
        sx={{
          maxWidth: 1100,
          mx: 'auto',
          display: 'grid',
          gridTemplateColumns: { xs: '1fr 1fr', md: '2fr 1fr 1fr 1fr' },
          gap: 4,
          mb: 4,
        }}
      >
        <Box>
          <Box sx={{ display: 'flex', alignItems: 'center', gap: 1.5, mb: 1.5 }}>
            <Box
              sx={{
                width: 32,
                height: 32,
                borderRadius: tokens.radius.sm,
                bgcolor: tokens.color.primary,
                color: '#FFF',
                display: 'flex',
                alignItems: 'center',
                justifyContent: 'center',
                fontFamily: '"Noto Serif", serif',
                fontSize: 18,
              }}
            >
              α
            </Box>
            <Typography sx={{ fontFamily: '"Noto Serif", serif', color: tokens.color.primaryDark, fontSize: '0.9375rem' }}>
              Greek NT Reader
            </Typography>
          </Box>
          <Typography variant="body2" sx={{ color: tokens.color.textMuted, maxWidth: 240, lineHeight: 1.7 }}>
            Free, open access to the Greek New Testament — with integrated vocabulary learning and spaced repetition.
          </Typography>
          <Typography variant="body2" sx={{ color: tokens.color.textMuted, mt: 1.5, fontStyle: 'italic' }}>
            Free forever. Donation-supported.
          </Typography>
        </Box>

        {Object.entries(LINKS).map(([heading, links]) => (
          <Box key={heading}>
            <Typography
              sx={{
                fontSize: '0.625rem',
                fontWeight: 700,
                color: tokens.color.textMuted,
                textTransform: 'uppercase',
                letterSpacing: '0.09em',
                mb: 1.5,
              }}
            >
              {heading}
            </Typography>
            <Box sx={{ display: 'flex', flexDirection: 'column', gap: 1 }}>
              {links.map(({ label, href }) => (
                <Link
                  key={href}
                  href={href}
                  underline="none"
                  sx={{
                    fontSize: '0.875rem',
                    color: tokens.color.textSecondary,
                    '&:hover': { color: tokens.color.primary },
                    transition: `color ${tokens.motion.fast}`,
                  }}
                >
                  {label}
                </Link>
              ))}
            </Box>
          </Box>
        ))}
      </Box>

      <Divider sx={{ mb: 3 }} />

      <Box
        sx={{
          maxWidth: 1100,
          mx: 'auto',
          display: 'flex',
          flexDirection: { xs: 'column', sm: 'row' },
          justifyContent: 'space-between',
          alignItems: { xs: 'flex-start', sm: 'center' },
          gap: 1,
        }}
      >
        <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
          © {new Date().getFullYear()} Greek NT Reader. Greek text: SBL Greek New Testament © Logos Bible Software &amp; SBL, 2010.
        </Typography>
        <Typography variant="body2" sx={{ color: tokens.color.textMuted }}>
          Made with care for scholars and students.
        </Typography>
      </Box>
    </Box>
  );
}
