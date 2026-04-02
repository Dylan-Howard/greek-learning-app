import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import ActivityHeatmap from './ActivityHeatmap';

const now = new Date();
const sampleData = Array.from({ length: 120 }, (_, i) => {
  const date = new Date(now);
  date.setDate(now.getDate() - i);
  return {
    date: date.toISOString().slice(0, 10),
    count: i % 7 === 0 ? 12 : (i % 5) * 2,
  };
});

const meta = {
  title: 'Design System/Profile/ActivityHeatmap',
  component: ActivityHeatmap,
  args: {
    data: sampleData,
    weeks: 18,
  },
} satisfies Meta<typeof ActivityHeatmap>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
