import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import SearchOffOutlinedIcon from '@mui/icons-material/SearchOffOutlined';
import EmptyState from './EmptyState';

const meta = {
  title: 'Design System/Shared/EmptyState',
  component: EmptyState,
  args: {
    icon: <SearchOffOutlinedIcon />,
    title: 'No Results',
    description: 'Try adjusting your filters or searching for a different term.',
    action: { label: 'Reset Filters', onClick: () => {} },
  },
} satisfies Meta<typeof EmptyState>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
