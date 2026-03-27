import type { StorybookConfig } from '@storybook/nextjs-vite';
import { resolve, dirname } from 'node:path';
import { fileURLToPath } from 'node:url';

const rootDir = dirname(fileURLToPath(import.meta.url));

const config: StorybookConfig = {
  stories: ['../src/design-system-v2/**/*.stories.@(ts|tsx)'],
  addons: ['@storybook/addon-a11y', '@storybook/addon-docs'],
  framework: '@storybook/nextjs-vite',
  staticDirs: ['../public'],
  viteFinal: async (config) => {
    config.resolve = config.resolve ?? {};
    config.resolve.alias = {
      ...(config.resolve.alias ?? {}),
      '@/components/features/reader/Navigation/DetailsMenu': resolve(rootDir, 'mocks/DetailsMenu.tsx'),
      '@/components/features/reader/Navigation/SettingsMenu': resolve(rootDir, 'mocks/SettingsMenu.tsx'),
      '@/components/features/reader/Navigation/ReaderStudyMenu': resolve(rootDir, 'mocks/ReaderStudyMenu.tsx'),
    };
    return config;
  },
};

export default config;
