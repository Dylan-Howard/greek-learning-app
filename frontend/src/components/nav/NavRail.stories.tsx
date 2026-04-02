import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Box from '@mui/material/Box';
import NavRail from './NavRail';

const meta = {
  title: 'Design System/Nav/NavRail',
  component: NavRail,
  parameters: {
    layout: 'fullscreen',
  },
  args: {
    userInitials: 'GR',
    xpPercent: 68,
    tier: 'apprentice',
  },
} satisfies Meta<typeof NavRail>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {
  render: (args) => (
    <Box sx={{ height: '100vh' }}>
      <NavRail {...args} />
    </Box>
  ),
};
