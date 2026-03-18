'use client';
// src/components/nav/BottomNav.tsx

import React from 'react';
import BottomNavigation from '@mui/material/BottomNavigation';
import BottomNavigationAction from '@mui/material/BottomNavigationAction';
import Box from '@mui/material/Box';
import { usePathname, useRouter } from 'next/navigation';
import { tokens } from '@/design-system-v2/theme/theme';

import MenuBookOutlinedIcon  from '@mui/icons-material/MenuBookOutlined';
import StyleOutlinedIcon     from '@mui/icons-material/StyleOutlined';
import ListAltOutlinedIcon   from '@mui/icons-material/ListAltOutlined';
import SchoolOutlinedIcon    from '@mui/icons-material/SchoolOutlined';
import PersonOutlineIcon     from '@mui/icons-material/PersonOutline';

const NAV_ITEMS = [
  { label: 'Read',       icon: <MenuBookOutlinedIcon />,  path: '/read' },
  { label: 'Study',      icon: <StyleOutlinedIcon />,     path: '/study' },
  { label: 'Vocabulary', icon: <ListAltOutlinedIcon />,   path: '/vocabulary' },
  { label: 'Lessons',    icon: <SchoolOutlinedIcon />,    path: '/lessons' },
  { label: 'Profile',    icon: <PersonOutlineIcon />,     path: '/profile' },
];

export default function BottomNav() {
  const pathname = usePathname();
  const router   = useRouter();

  const activeIndex = NAV_ITEMS.findIndex(({ path }) => pathname?.startsWith(path));

  return (
    <Box
      component="nav"
      aria-label="Main navigation"
      sx={{
        position:    'fixed',
        bottom:      0,
        left:        0,
        right:       0,
        zIndex:      1200,
        borderTop:   `1px solid ${tokens.color.border}`,
        // Safe area inset for iOS notch
        pb:          'env(safe-area-inset-bottom, 0px)',
      }}
    >
      <BottomNavigation
        value={activeIndex >= 0 ? activeIndex : false}
        onChange={(_, newValue) => {
          router.push(NAV_ITEMS[newValue].path);
        }}
        sx={{
          height:  56,
          bgcolor: tokens.color.bg,
          '& .MuiBottomNavigationAction-root': {
            minWidth: 0,
            padding:  '6px 0 8px',
            color:    tokens.color.textSecondary,
            '& svg':  { fontSize: 24 },
          },
          '& .Mui-selected': {
            color: tokens.color.primary,
          },
          // Hide labels — icons only
          '& .MuiBottomNavigationAction-label': { display: 'none' },
        }}
      >
        {NAV_ITEMS.map(({ label, icon, path }) => (
          <BottomNavigationAction
            key={path}
            label={label}
            icon={icon}
            aria-label={label}
          />
        ))}
      </BottomNavigation>
    </Box>
  );
}
