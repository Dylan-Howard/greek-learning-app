import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import TierUpModal from './TierUpModal';

const meta = {
  title: 'Design System/Gamification/TierUpModal',
  component: TierUpModal,
  args: {
    open: true,
    tier: 'scholar',
    totalXP: 12450,
    onClose: () => {},
  },
} satisfies Meta<typeof TierUpModal>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
