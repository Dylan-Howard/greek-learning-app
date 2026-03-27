import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import { Dialog } from './Dialog';

const meta = {
  title: 'Design System/Shared/Dialog',
  component: Dialog,
  args: {
    open: true,
    title: 'Delete Vocabulary Set',
    dialogContent: (
      <Typography variant="body2">
        This action cannot be undone. Are you sure you want to delete this set?
      </Typography>
    ),
  },
} satisfies Meta<typeof Dialog>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};

export const WithActions: Story = {
  render: (args) => (
    <Dialog
      {...args}
      actions={(
        <>
          <Button variant="outlined">Cancel</Button>
          <Button variant="contained" color="error">Delete</Button>
        </>
      )}
      showClose
      onClose={() => {}}
    />
  ),
};
