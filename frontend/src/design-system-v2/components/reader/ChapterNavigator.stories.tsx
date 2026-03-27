import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import { ChapterNavigatorWrapper } from './ChapterNavigator';

const meta = {
  title: 'Design System/Reader/ChapterNavigator',
  component: ChapterNavigatorWrapper,
  parameters: {
    layout: 'fullscreen',
  },
} satisfies Meta<typeof ChapterNavigatorWrapper>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {
  render: (args) => (
    <ChapterNavigatorWrapper {...args}>
      <Box sx={{ p: 6, maxWidth: 600, mx: 'auto' }}>
        <Typography variant="h2" sx={{ mb: 2 }}>
          Chapter Content
        </Typography>
        <Typography variant="body1" color="text.secondary">
          Hover near the edges to reveal navigation arrows.
        </Typography>
      </Box>
    </ChapterNavigatorWrapper>
  ),
  args: {
    children: null,
    hasPrev: true,
    hasNext: true,
    onPrev: () => {},
    onNext: () => {},
  },
};
