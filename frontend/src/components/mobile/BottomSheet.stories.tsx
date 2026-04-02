import type { Meta, StoryObj } from '@storybook/react';
import React, { useState } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import BottomSheet, { type SnapPoint } from './BottomSheet';

const meta = {
  title: 'Design System/Mobile/BottomSheet',
  component: BottomSheet,
  args: {
    snap: 'peek',
    onSnapChange: () => {},
    children: null,
  },
  parameters: {
    layout: 'fullscreen',
  },
} satisfies Meta<typeof BottomSheet>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Peek: Story = {
  render: () => {
    const [snap, setSnap] = useState<SnapPoint>('peek');
    return (
      <Box sx={{ height: '100vh', bgcolor: 'background.default' }}>
        <BottomSheet snap={snap} onSnapChange={setSnap}>
          <Box sx={{ p: 2 }}>
            <Typography variant="h3">Bottom Sheet</Typography>
            <Typography variant="body2" color="text.secondary">
              Drag the handle to expand or collapse.
            </Typography>
          </Box>
        </BottomSheet>
      </Box>
    );
  },
};
