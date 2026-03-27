import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import StarOutlineIcon from '@mui/icons-material/StarOutline';
import StatCard from './StatCard';

const meta = {
  title: 'Design System/Profile/StatCard',
  component: StatCard,
  args: {
    value: 1280,
    label: 'Total XP',
    icon: <StarOutlineIcon />,
  },
} satisfies Meta<typeof StatCard>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
