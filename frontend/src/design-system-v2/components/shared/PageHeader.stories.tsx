import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Button from '@mui/material/Button';
import { PageHeader } from './PageHeader';

const meta = {
  title: 'Design System/Shared/PageHeader',
  component: PageHeader,
  args: {
    title: 'Vocabulary',
    subtitle: 'Track your mastery and review schedule.',
  },
} satisfies Meta<typeof PageHeader>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};

export const WithActions: Story = {
  args: {
    actions: (
      <Button variant="contained" size="small">
        New Set
      </Button>
    ),
  },
};
