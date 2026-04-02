import type { Meta, StoryObj } from '@storybook/react';
import ProgressChip from './ProgressChip';

const meta = {
  title: 'Design System/Shared/ProgressChip',
  component: ProgressChip,
  args: {
    status: 'new',
  },
} satisfies Meta<typeof ProgressChip>;

export default meta;
type Story = StoryObj<typeof meta>;

export const New: Story = {};

export const Due: Story = {
  args: { status: 'due' },
};

export const Mastered: Story = {
  args: { status: 'mastered' },
};

export const Unseen: Story = {
  args: { status: 'unseen' },
};
