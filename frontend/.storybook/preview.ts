import type { Preview } from '@storybook/nextjs-vite';
import React from 'react';
import ThemeProvider from '@/theme/ThemeProvider';
import '@/styles/globals.css';

const preview: Preview = {
  decorators: [
    (Story) => React.createElement(ThemeProvider, null, React.createElement(Story)),
  ],
  parameters: {
    nextjs: {
      appDirectory: true,
    },
    actions: { argTypesRegex: '^on[A-Z].*' },
    controls: {
      matchers: {
        color: /(background|color)$/i,
        date: /Date$/i,
      },
    },
  },
};

export default preview;
