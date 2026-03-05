'use client';

import React from 'react';
import {
  AppBar as MuiAppBar,
  Box,
  Drawer,
  IconButton,
  List,
  ListItem,
  ListItemButton,
  ListItemIcon,
  ListItemText,
  Toolbar,
  styled,
  useTheme,
} from '@mui/material';
import { Menu as MenuIcon } from '@mui/icons-material';

export interface AppShellProps {
  /**
   * Main content
   */
  children: React.ReactNode;
  /**
   * Navigation items
   */
  navItems?: Array<{
    icon: React.ReactNode;
    label: string;
    href: string;
    active?: boolean;
  }>;
  /**
   * Show navigation
   */
  showNav?: boolean;
  /**
   * App bar content
   */
  appBarContent?: React.ReactNode;
}

const AppShellRoot = styled(Box)({
  display: 'flex',
  minHeight: '100vh',
});

const MainContent = styled(Box)(({ theme }) => ({
  flexGrow: 1,
  display: 'flex',
  flexDirection: 'column',
}));

/**
 * Application shell with navigation and app bar
 */
export const AppShell: React.FC<AppShellProps> = ({
  children,
  navItems,
  showNav = true,
  appBarContent,
}) => {
  const [mobileOpen, setMobileOpen] = React.useState(false);
  const theme = useTheme();
  const palette = theme.vars?.palette ?? theme.palette;

  const drawer = navItems && (
    <Box
      sx={{
        width: 240,
        height: '100%',
        borderRight: `1px solid ${palette.border.default}`,
        bgcolor: 'canvas.default',
      }}
    >
      <List sx={{ pt: 2 }}>
        {navItems.map((item, index) => (
          <ListItem key={index} disablePadding>
            <ListItemButton
              href={item.href}
              selected={item.active}
              sx={{
                borderRadius: 1,
                mx: 1,
                mb: 0.5,
              }}
            >
              <ListItemIcon>{item.icon}</ListItemIcon>
              <ListItemText primary={item.label} />
            </ListItemButton>
          </ListItem>
        ))}
      </List>
    </Box>
  );

  return (
    <AppShellRoot>
      {showNav && (
        <>
          {/* Mobile drawer */}
          <Drawer
            variant="temporary"
            open={mobileOpen}
            onClose={() => setMobileOpen(false)}
            ModalProps={{ keepMounted: true }}
            sx={{
              display: { xs: 'block', md: 'none' },
              '& .MuiDrawer-paper': { width: 240 },
            }}
          >
            {drawer}
          </Drawer>
          {/* Desktop drawer */}
          <Drawer
            variant="permanent"
            sx={{
              display: { xs: 'none', md: 'block' },
              '& .MuiDrawer-paper': { width: 240, position: 'relative' },
            }}
            open
          >
            {drawer}
          </Drawer>
        </>
      )}
      <MainContent>
        {appBarContent && (
          <MuiAppBar
            position="sticky"
            elevation={0}
            sx={{
              bgcolor: 'canvas.default',
              color: 'text.primary',
              borderBottom: `1px solid ${palette.border.default}`,
            }}
          >
            <Toolbar>
              {showNav && (
                <IconButton
                  edge="start"
                  onClick={() => setMobileOpen(!mobileOpen)}
                  sx={{ mr: 2, display: { md: 'none' } }}
                >
                  <MenuIcon />
                </IconButton>
              )}
              {appBarContent}
            </Toolbar>
          </MuiAppBar>
        )}
        <Box component="main" sx={{ flexGrow: 1, p: 3 }}>
          {children}
        </Box>
      </MainContent>
    </AppShellRoot>
  );
};

export default AppShell;
