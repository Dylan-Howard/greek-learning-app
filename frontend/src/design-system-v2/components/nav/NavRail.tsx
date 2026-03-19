'use client';
// src/components/nav/NavRail.tsx

import React from 'react';
import Box from '@mui/material/Box';
import Tooltip from '@mui/material/Tooltip';
import NextLink from 'next/link';
import { usePathname } from 'next/navigation';
import { tokens } from '@/design-system-v2/theme/theme';
import UserAvatarBadge, { type Tier } from './UserAvatarBadge';
import { useDirection } from '@/design-system-v2/components/layouts/RTLWrapper';

// MUI icons (Material Symbols Outlined)
import MenuBookOutlinedIcon     from '@mui/icons-material/MenuBookOutlined';
import StyleOutlinedIcon        from '@mui/icons-material/StyleOutlined';
import ListAltOutlinedIcon      from '@mui/icons-material/ListAltOutlined';
import SchoolOutlinedIcon       from '@mui/icons-material/SchoolOutlined';
import PersonOutlineIcon        from '@mui/icons-material/PersonOutline';

interface NavItem {
  label:   string;
  icon:    React.ReactNode;
  path:    string;
}

const NAV_ITEMS: NavItem[] = [
  { label: 'Read',       icon: <MenuBookOutlinedIcon />,  path: '/reader' },
  { label: 'Study',      icon: <StyleOutlinedIcon />,     path: '/study' },
  { label: 'Vocabulary', icon: <ListAltOutlinedIcon />,   path: '/vocabulary' },
  { label: 'Lessons',    icon: <SchoolOutlinedIcon />,    path: '/lessons' },
  { label: 'Profile',    icon: <PersonOutlineIcon />,     path: '/profile' },
];

interface Props {
  userInitials:  string;
  xpPercent:     number;
  tier:          Tier;
}

export default function NavRail({ userInitials, xpPercent, tier }: Props) {
  const pathname  = usePathname();
  const direction = useDirection();

  return (
    <Box
      component="nav"
      aria-label="Main navigation"
      sx={{
        width:          72,
        height:         '100vh',
        position:       'fixed',
        top:            0,
        [direction === 'rtl' ? 'right' : 'left']: 0,
        zIndex:         1200,
        bgcolor:        tokens.color.surface,
        borderRight:    direction === 'rtl' ? 'none' : `1px solid ${tokens.color.border}`,
        borderLeft:     direction === 'rtl' ? `1px solid ${tokens.color.border}` : 'none',
        display:        'flex',
        flexDirection:  'column',
        alignItems:     'center',
        py:             2,
      }}
    >
      {/* Logo mark */}
      <Box
        sx={{
          width:          36,
          height:         36,
          borderRadius:   tokens.radius.md,
          bgcolor:        tokens.color.primary,
          color:          '#FFFFFF',
          display:        'flex',
          alignItems:     'center',
          justifyContent: 'center',
          fontFamily:     '"Noto Serif", serif',
          fontSize:       20,
          mb:             4,
          userSelect:     'none',
          flexShrink:     0,
        }}
        aria-label="Greek NT Reader"
      >
        α
      </Box>

      {/* Nav items */}
      <Box sx={{ display: 'flex', flexDirection: 'column', gap: 1, flex: 1 }}>
        {NAV_ITEMS.map(({ label, icon, path }) => {
          const active = pathname?.startsWith(path) ?? false;
          return (
            <Tooltip
              key={path}
              title={label}
              placement={direction === 'rtl' ? 'left' : 'right'}
              arrow
              enterDelay={500}
            >
              <Box
                component={NextLink}
                href={path}
                aria-label={label}
                aria-current={active ? 'page' : undefined}
                sx={{
                  width:          52,
                  height:         44,
                  borderRadius:   tokens.radius.md,
                  border:         'none',
                  cursor:         'pointer',
                  display:        'flex',
                  alignItems:     'center',
                  justifyContent: 'center',
                  textDecoration: 'none',
                  bgcolor:        active ? tokens.color.primaryLight : 'transparent',
                  color:          active ? tokens.color.primary : tokens.color.textSecondary,
                  transition:     `background-color ${tokens.motion.fast} ${tokens.motion.ease}, color ${tokens.motion.fast} ${tokens.motion.ease}`,
                  '&:hover': {
                    bgcolor: active ? tokens.color.primaryLight : tokens.color.surfaceAlt,
                    color:   tokens.color.primary,
                  },
                  '&:focus-visible': {
                    outline: `2px solid ${tokens.color.primary}`,
                    outlineOffset: 2,
                  },
                  '& svg': { fontSize: 24 },
                }}
              >
                {icon}
              </Box>
            </Tooltip>
          );
        })}
      </Box>

      {/* Avatar + XP ring at bottom */}
      <Tooltip
        title="Profile"
        placement={direction === 'rtl' ? 'left' : 'right'}
        arrow
        enterDelay={500}
      >
        <Box
          component={NextLink}
          href="/profile"
          aria-label="Profile"
          sx={{ textDecoration: 'none' }}
        >
          <UserAvatarBadge
            initials={userInitials}
            xpPercent={xpPercent}
            tier={tier}
            size={40}
          />
        </Box>
      </Tooltip>
    </Box>
  );
}
