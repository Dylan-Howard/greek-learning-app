import { defineConfig } from '@playwright/test';

const baseURL = process.env.PLAYWRIGHT_BASE_URL ?? 'http://localhost:3000';
const apiBaseURL = process.env.PLAYWRIGHT_API_BASE_URL ?? 'http://localhost:5001';

export default defineConfig({
  testDir: './tests',
  timeout: 60_000,
  expect: {
    timeout: 10_000,
  },
  retries: process.env.CI ? 1 : 0,
  use: {
    baseURL,
    trace: 'retain-on-failure',
    video: 'retain-on-failure',
    screenshot: 'only-on-failure',
  },
  projects: [
    {
      name: 'smoke',
      testMatch: ['tests/smoke/**/*.spec.ts'],
      use: {
        baseURL,
        extraHTTPHeaders: {
          'X-Playwright-API-Base': apiBaseURL,
        },
      },
    },
    {
      name: 'e2e',
      testMatch: ['tests/e2e/**/*.spec.ts'],
      use: {
        baseURL,
        extraHTTPHeaders: {
          'X-Playwright-API-Base': apiBaseURL,
        },
      },
    },
  ],
  reporter: [['list']],
  outputDir: 'test-results/playwright',
});
