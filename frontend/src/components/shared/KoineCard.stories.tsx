import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import { KoineCard } from './KoineCard';

const meta = {
  title: 'Design System/Shared/KoineCard',
  component: KoineCard,
  args: {
    title: 'Reader Progress',
    subtitle: '1 John 1',
    children: (
      <Typography variant="body2" color="text.secondary">
        You have mastered 12/24 vocabulary items in this chapter.
      </Typography>
    ),
  },
} satisfies Meta<typeof KoineCard>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};

export const WithActions: Story = {
  render: (args) => (
    <KoineCard
      {...args}
      actions={(
        <Button size="small" variant="contained">
          Continue
        </Button>
      )}
    />
  ),
};
