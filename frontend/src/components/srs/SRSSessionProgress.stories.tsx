import type { Meta, StoryObj } from '@storybook/react';
import SRSSessionProgress from './SRSSessionProgress';

const meta = {
  title: 'Design System/SRS/SRSSessionProgress',
  component: SRSSessionProgress,
  args: {
    current: 3,
    total: 10,
  },
} satisfies Meta<typeof SRSSessionProgress>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
