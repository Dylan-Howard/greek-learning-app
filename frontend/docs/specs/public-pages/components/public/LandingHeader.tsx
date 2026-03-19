'use client';
// src/components/public/LandingHeader.tsx
// Minimal sticky header for public-facing pages.
// Transparent → white on scroll.

import React, { useEffect, useState } from 'react';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Link from '@mui/material/Link';
import { useRouter } from 'next/navigation';
import { tokens } from '@/theme/theme';

export default function LandingHeader() {
  const router = useRouter();
  const [scrolled, setScrolled] = useState(false);

  useEffect(() => {
    const fn = () => setScrolled(window.scrollY > 24);
    window.addEventListener('scroll', fn, { passive: true });
    return () => window.removeEventListener('scroll', fn);
  }, []);

  return (
    <Box
      component="header"
      sx={{
        position:   'fixed',
        top:        0,
        left:       0,
        right:      0,
        zIndex:     1300,
        height:     64,
        display:    'flex',
        alignItems: 'center',
        px:         { xs: 3, md: 6 },
        justifyContent: 'space-between',
        bgcolor:    scrolled ? 'rgba(255,255,255,0.92)' : 'transparent',
        backdropFilter: scrolled ? 'blur(12px)' : 'none',
        borderBottom: scrolled ? `1px solid ${tokens.color.border}` : '1px solid transparent',
        transition: 'background-color 200ms ease, border-color 200ms ease, backdrop-filter 200ms ease',
      }}
    >
      {/* Logo */}
      <Link
        href="/"
        underline="none"
        sx={{ display: 'flex', alignItems: 'center', gap: 1.5 }}
      >
        <Box
          sx={{
            width:          36,
            height:         36,
            borderRadius:   tokens.radius.md,
            bgcolor:        tokens.color.primary,
            color:          '#FFF',
            display:        'flex',
            alignItems:     'center',
            justifyContent: 'center',
            fontFamily:     '"Noto Serif", serif',
            fontSize:       20,
            flexShrink:     0,
          }}
        >
          α
        </Box>
        <Box
          sx={{
            fontFamily: '"Noto Serif", serif',
            fontWeight: 400,
            fontSize:   '1.0625rem',
            color:      tokens.color.primaryDark,
            display:    { xs: 'none', sm: 'block' },
          }}
        >
          Greek NT Reader
        </Box>
      </Link>

      {/* Nav links + CTAs */}
      <Box sx={{ display: 'flex', alignItems: 'center', gap: { xs: 1, md: 3 } }}>
        <Box sx={{ display: { xs: 'none', md: 'flex' }, gap: 3 }}>
          {[
            { label: 'How it works', href: '/#how-it-works' },
            { label: 'Lessons',      href: '/lessons' },
            { label: 'Contact',      href: '/contact' },
          ].map(({ label, href }) => (
            <Link
              key={href}
              href={href}
              underline="none"
              sx={{
                fontSize:   '0.875rem',
                fontWeight: 500,
                color:      tokens.color.textSecondary,
                '&:hover':  { color: tokens.color.primary },
                transition: `color ${tokens.motion.fast}`,
              }}
            >
              {label}
            </Link>
          ))}
        </Box>

        <Button
          variant="text"
          onClick={() => router.push('/auth/login')}
          sx={{ color: tokens.color.textSecondary, fontWeight: 500, fontSize: '0.875rem', display: { xs: 'none', sm: 'flex' } }}
        >
          Sign in
        </Button>
        <Button
          variant="contained"
          onClick={() => router.push('/auth/signup')}
          sx={{
            bgcolor:      tokens.color.primary,
            '&:hover':    { bgcolor: tokens.color.primaryDark },
            fontWeight:   700,
            px:           2.5,
            py:           0.875,
            fontSize:     '0.875rem',
            borderRadius: tokens.radius.sm,
          }}
        >
          Start free
        </Button>
      </Box>
    </Box>
  );
}
