import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import StudyDashboardStats from './StudyDashboardStats';
import { type DashboardDto } from '@/lib/types/api';

const sampleData: DashboardDto = {
  totalCards: 640,
  dueToday: 28,
  newCards: 12,
  learningCards: 80,
  reviewCards: 520,
  relearningCards: 28,
  currentStreak: 14,
  reviewHistory: [
    { date: 'Mon', count: 24 },
    { date: 'Tue', count: 32 },
    { date: 'Wed', count: 18 },
    { date: 'Thu', count: 40 },
    { date: 'Fri', count: 26 },
    { date: 'Sat', count: 12 },
    { date: 'Sun', count: 8 },
  ],
};

const meta = {
  title: 'Design System/SRS/StudyDashboardStats',
  component: StudyDashboardStats,
  args: {
    data: sampleData,
  },
} satisfies Meta<typeof StudyDashboardStats>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
