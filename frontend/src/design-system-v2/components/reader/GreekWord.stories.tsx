import type { Meta, StoryObj } from '@storybook/react';
import GreekWord from './GreekWord';

const meta = {
  title: 'Design System/Reader/GreekWord',
  component: GreekWord,
  args: {
    word: 'λόγος',
    status: 'new',
    selected: false,
    onClick: () => {},
  },
} satisfies Meta<typeof GreekWord>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};

export const Selected: Story = {
  args: {
    selected: true,
    status: 'mastered',
  },
};
