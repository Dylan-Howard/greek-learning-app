import type { Meta, StoryObj } from '@storybook/react';
import ReaderSettingsPanel from './ReaderSettingsPanel';

const meta = {
  title: 'Design System/Reader/ReaderSettingsPanel',
  component: ReaderSettingsPanel,
  args: {
    title: 'Settings',
  },
} satisfies Meta<typeof ReaderSettingsPanel>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
