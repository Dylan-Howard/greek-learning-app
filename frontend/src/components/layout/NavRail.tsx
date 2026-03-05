'use client';

import React from 'react';
import {
  Box,
  IconButton,
  Tooltip as MuiTooltip,
  Typography,
  styled,
  alpha,
} from '@mui/material';

export interface NavRailItem {
  icon: React.ReactNode;
  label: string;
  href: string;
  badge?: number;
}

export interface NavRailProps {
  /**
   * Navigation items
   */
  items: NavRailItem[];
  /**
   * Active item index
   */
  activeIndex?: number;
  /**
   * Show labels
   */
  showLabels?: boolean;
}

const NavRailRoot = styled(Box)(({ theme }) => {
  const palette = theme.vars?.palette ?? theme.palette;
  return {
  width: 80,
  height: '100vh',
  position: 'fixed',
  left: 0,
  top: 0,
  backgroundColor: palette.canvas.subtle,
  borderRight: `1px solid ${palette.border.default}`,
  display: 'flex',
  flexDirection: 'column',
  alignItems: 'center',
  paddingTop: theme.spacing(2),
  gap: theme.spacing(1),
  [theme.breakpoints.down('md')]: {
    width: '100%',
    height: 'auto',
    position: 'fixed',
    bottom: 0,
    top: 'auto',
    left: 0,
    right: 0,
    flexDirection: 'row',
    justifyContent: 'space-around',
    paddingTop: theme.spacing(1),
    paddingBottom: theme.spacing(1),
    borderRight: 'none',
    borderTop: `1px solid ${palette.border.default}`,
  },
  };
});

const NavRailButton = styled(IconButton, {
  shouldForwardProp: (prop) => prop !== 'isActive',
})<{ isActive?: boolean }>(({ theme, isActive }) => {
  const palette = theme.vars?.palette ?? theme.palette;
  return {
  width: 56,
  height: 56,
  borderRadius: 12,
  flexDirection: 'column',
  gap: theme.spacing(0.5),
  ...(isActive && {
    backgroundColor: alpha(palette.primary.main, 0.1),
    color: palette.primary.main,
  }),
  };
});

/**
 * Vertical navigation rail for primary navigation
 */
export const NavRail: React.FC<NavRailProps> = ({
  items,
  activeIndex,
  showLabels = false,
}) => {
  const handleNavigate = (href: string) => () => {
    window.location.assign(href);
  };

  return (
    <NavRailRoot>
      {items.map((item, index) => (
        <MuiTooltip key={index} title={item.label} placement="right">
          <NavRailButton isActive={activeIndex === index} onClick={handleNavigate(item.href)}>
            <Box sx={{ position: 'relative' }}>
              {item.icon}
              {item.badge !== undefined && item.badge > 0 && (
                <Box
                  sx={{
                    position: 'absolute',
                    top: -4,
                    right: -4,
                    minWidth: 18,
                    height: 18,
                    borderRadius: '9px',
                    bgcolor: 'error.main',
                    color: 'error.contrastText',
                    fontSize: '0.625rem',
                    fontWeight: 600,
                    display: 'flex',
                    alignItems: 'center',
                    justifyContent: 'center',
                    px: 0.5,
                  }}
                >
                  {item.badge > 99 ? '99+' : item.badge}
                </Box>
              )}
            </Box>
            {showLabels && (
              <Typography variant="caption" fontSize="0.625rem">
                {item.label}
              </Typography>
            )}
          </NavRailButton>
        </MuiTooltip>
      ))}
    </NavRailRoot>
  );
};

export default NavRail;
