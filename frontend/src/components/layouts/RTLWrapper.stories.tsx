import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import RTLWrapper from './RTLWrapper';

const meta = {
  title: 'Design System/Layouts/RTLWrapper',
  component: RTLWrapper,
} satisfies Meta<typeof RTLWrapper>;

export default meta;
type Story = StoryObj<typeof meta>;

export const LeftToRight: Story = {
  args: {
    direction: 'ltr',
    children: (
      <Box sx={{ p: 3 }}>
        <Typography variant="h3">Left-to-right content</Typography>
        <Typography variant="body2" color="text.secondary">
          This content renders using the default direction.
        </Typography>
      </Box>
    ),
  },
};

export const RightToLeft: Story = {
  args: {
    direction: 'rtl',
    children: (
      <Box sx={{ p: 3 }}>
        <Typography variant="h3">محتوى من اليمين إلى اليسار</Typography>
        <Typography variant="body2" color="text.secondary">
          This content renders using RTL layout.
        </Typography>
      </Box>
    ),
  },
};
