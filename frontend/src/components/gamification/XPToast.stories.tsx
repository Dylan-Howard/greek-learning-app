import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Box from '@mui/material/Box';
import XPToast from './XPToast';

const meta = {
  title: 'Design System/Gamification/XPToast',
  component: XPToast,
  args: {
    xp: 8,
    onDone: () => {},
  },
} satisfies Meta<typeof XPToast>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {
  render: (args) => (
    <Box sx={{ position: 'relative', height: 120 }}>
      <XPToast {...args} />
    </Box>
  ),
};
