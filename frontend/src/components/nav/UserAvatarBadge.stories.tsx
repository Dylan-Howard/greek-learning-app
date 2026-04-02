import type { Meta, StoryObj } from '@storybook/react';
import UserAvatarBadge from './UserAvatarBadge';

const meta = {
  title: 'Design System/Nav/UserAvatarBadge',
  component: UserAvatarBadge,
  args: {
    initials: 'DL',
    xpPercent: 45,
    tier: 'novice',
  },
} satisfies Meta<typeof UserAvatarBadge>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};

export const MasterTier: Story = {
  args: {
    xpPercent: 90,
    tier: 'master',
  },
};
