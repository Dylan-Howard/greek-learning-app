import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Box from '@mui/material/Box';
import {
  ReaderSkeleton,
  VocabCardSkeleton,
  LessonCardSkeleton,
  SidebarSkeleton,
  SettingsMenuTabSkeleton,
  DetailsSkeleton,
} from './LoadingSkeleton';

const meta = {
  title: 'Design System/Shared/LoadingSkeleton',
  component: ReaderSkeleton,
} satisfies Meta<typeof ReaderSkeleton>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Reader: Story = {};

export const VocabCard: Story = {
  render: () => <VocabCardSkeleton />,
};

export const LessonCard: Story = {
  render: () => <LessonCardSkeleton />,
};

export const Sidebar: Story = {
  render: () => <SidebarSkeleton />,
};

export const SettingsMenuTab: Story = {
  render: () => <SettingsMenuTabSkeleton />,
};

export const Details: Story = {
  render: () => (
    <Box sx={{ maxWidth: 420 }}>
      <DetailsSkeleton />
    </Box>
  ),
};
