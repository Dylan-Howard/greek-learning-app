import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import AppShell from './AppShell';

const meta = {
  title: 'Design System/Layouts/AppShell',
  component: AppShell,
  parameters: {
    layout: 'fullscreen',
  },
} satisfies Meta<typeof AppShell>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {
  args: {
    children: (
      <Box sx={{ p: 4 }}>
        <Typography variant="h2" sx={{ mb: 2 }}>
          Reader Content
        </Typography>
        <Typography variant="body1" color="text.secondary">
          This is the main reading area inside the app shell.
        </Typography>
      </Box>
    ),
  },
};

export const WithSidebar: Story = {
  args: {
    sidebar: (
      <Box sx={{ p: 2 }}>
        <Typography variant="h3" sx={{ mb: 1 }}>
          Sidebar
        </Typography>
        <Typography variant="body2" color="text.secondary">
          Supplemental study details live here.
        </Typography>
      </Box>
    ),
    children: (
      <Box sx={{ p: 4 }}>
        <Typography variant="h2" sx={{ mb: 2 }}>
          Reader Content
        </Typography>
        <Typography variant="body1" color="text.secondary">
          Main content with an active sidebar.
        </Typography>
      </Box>
    ),
  },
};
