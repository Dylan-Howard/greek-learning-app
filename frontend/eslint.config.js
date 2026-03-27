const js = require('@eslint/js');
const tseslint = require('@typescript-eslint/eslint-plugin');
const tsParser = require('@typescript-eslint/parser');
const nextPlugin = require('@next/eslint-plugin-next');
const storybookPlugin = require('eslint-plugin-storybook');

const nextRecommended = nextPlugin.configs?.recommended ?? {};
const storybookRecommended = storybookPlugin.configs?.recommended ?? {};

const sharedGlobals = {
  window: 'readonly',
  document: 'readonly',
  console: 'readonly',
  process: 'readonly',
  module: 'readonly',
  require: 'readonly',
  __dirname: 'readonly',
  __filename: 'readonly',
  fetch: 'readonly',
  RequestInit: 'readonly',
  Response: 'readonly',
  Storage: 'readonly',
  CustomEvent: 'readonly',
};

module.exports = [
  {
    ignores: [
      '**/.next/**',
      '**/node_modules/**',
      '**/coverage/**',
      '**/storybook-static/**',
      '**/dist/**',
      '**/build/**',
      '**/src/lib/api/graphql/generated/**',
    ],
  },
  js.configs.recommended,
  {
    files: ['**/*.{ts,tsx}'],
    languageOptions: {
      parser: tsParser,
      parserOptions: {
        ecmaVersion: 'latest',
        sourceType: 'module',
        ecmaFeatures: { jsx: true },
      },
    },
    plugins: {
      '@typescript-eslint': tseslint,
      '@next/next': nextPlugin,
      storybook: storybookPlugin,
    },
    rules: {
      ...nextRecommended.rules,
      ...storybookRecommended.rules,
      'no-undef': 'off',
      'no-unused-vars': 'off',
      'preserve-caught-error': 'off',
      '@next/next/no-img-element': 'warn',
      '@next/next/no-page-custom-font': 'warn',
      '@next/next/google-font-display': 'warn',
    },
  },
  {
    files: ['**/*.{js,jsx}'],
    languageOptions: {
      ecmaVersion: 'latest',
      sourceType: 'module',
      parserOptions: {
        ecmaFeatures: { jsx: true },
      },
      globals: sharedGlobals,
    },
    plugins: {
      '@next/next': nextPlugin,
      storybook: storybookPlugin,
    },
    rules: {
      ...nextRecommended.rules,
      ...storybookRecommended.rules,
    },
  },
];
