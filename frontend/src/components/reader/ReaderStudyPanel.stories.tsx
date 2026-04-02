import type { Meta, StoryObj } from '@storybook/react';
import ReaderStudyPanel from './ReaderStudyPanel';

const meta = {
  title: 'Design System/Reader/ReaderStudyPanel',
  component: ReaderStudyPanel,
} satisfies Meta<typeof ReaderStudyPanel>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
