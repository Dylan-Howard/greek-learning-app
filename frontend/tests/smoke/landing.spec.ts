import { test, expect } from '@playwright/test';

const apiBaseURL = process.env.PLAYWRIGHT_API_BASE_URL ?? 'http://localhost:5001';

test('landing page loads', async ({ page }) => {
  await page.goto('/');
  await expect(page.getByRole('heading', { level: 1 })).toContainText('Read the Greek New Testament');
});

test('backend books endpoint responds', async ({ request }) => {
  const response = await request.get(`${apiBaseURL}/api/books`);
  expect(response.ok()).toBeTruthy();
  const payload = await response.json();
  expect(Array.isArray(payload)).toBeTruthy();
  expect(payload.length).toBeGreaterThan(0);
});
