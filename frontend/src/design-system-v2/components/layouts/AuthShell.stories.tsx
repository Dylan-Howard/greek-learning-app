import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Typography from '@mui/material/Typography';
import AuthShell from './AuthShell';

const meta = {
  title: 'Design System/Layouts/AuthShell',
  component: AuthShell,
  args: {
    children: (
      <>
        <Typography variant="h3" sx={{ mb: 1 }}>
          Welcome back
        </Typography>
        <Typography variant="body2" color="text.secondary">
          Sign in to continue reading.
        </Typography>
      </>
    ),
  },
} satisfies Meta<typeof AuthShell>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
