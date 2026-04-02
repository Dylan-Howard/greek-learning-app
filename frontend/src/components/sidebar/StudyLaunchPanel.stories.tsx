import type { Meta, StoryObj } from '@storybook/react';
import StudyLaunchPanel from './StudyLaunchPanel';

const meta = {
  title: 'Design System/Sidebar/StudyLaunchPanel',
  component: StudyLaunchPanel,
  args: {
    dueCount: 6,
    onStartStudy: () => {},
  },
} satisfies Meta<typeof StudyLaunchPanel>;

export default meta;
type Story = StoryObj<typeof meta>;

export const WithDue: Story = {};

export const NoDue: Story = {
  args: {
    dueCount: 0,
  },
};
