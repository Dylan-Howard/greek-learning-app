import type { Meta, StoryObj } from '@storybook/react';
import ReaderDetailsPanel from './ReaderDetailsPanel';

const meta = {
  title: 'Design System/Reader/ReaderDetailsPanel',
  component: ReaderDetailsPanel,
} satisfies Meta<typeof ReaderDetailsPanel>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
