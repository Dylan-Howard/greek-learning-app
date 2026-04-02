import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Box from '@mui/material/Box';
import BottomNav from './BottomNav';

const meta = {
  title: 'Design System/Nav/BottomNav',
  component: BottomNav,
  parameters: {
    layout: 'fullscreen',
  },
} satisfies Meta<typeof BottomNav>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {
  render: () => (
    <Box sx={{ height: '100vh', position: 'relative' }}>
      <BottomNav />
    </Box>
  ),
};
