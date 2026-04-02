import type { Meta, StoryObj } from '@storybook/react';
import { Alert } from './Alert';

const meta = {
  title: 'Design System/Shared/Alert',
  component: Alert,
  args: {
    message: 'Your progress has been saved.',
    severity: 'success',
  },
} satisfies Meta<typeof Alert>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Success: Story = {};

export const Error: Story = {
  args: {
    message: 'Something went wrong while saving.',
    severity: 'error',
  },
};

export const Closable: Story = {
  args: {
    message: 'This alert can be dismissed.',
    severity: 'info',
    closable: true,
    onClose: () => {},
  },
};
