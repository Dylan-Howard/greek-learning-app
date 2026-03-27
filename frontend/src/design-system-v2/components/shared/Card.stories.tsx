import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import { Card } from './Card';

const meta = {
  title: 'Design System/Shared/Card',
  component: Card,
  args: {
    title: 'Vocabulary Set',
    subtitle: 'Common verbs in John',
    hoverable: true,
    children: (
      <Typography variant="body2" color="text.secondary">
        Track mastery progress and review your upcoming cards.
      </Typography>
    ),
  },
} satisfies Meta<typeof Card>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};

export const WithActions: Story = {
  render: (args) => (
    <Card
      {...args}
      actions={(
        <Button size="small" variant="outlined">
          Review
        </Button>
      )}
    />
  ),
};
