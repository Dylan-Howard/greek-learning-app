import { test, expect } from '@playwright/test';

test('public navigation flows', async ({ page }) => {
  await page.goto('/');
  await page.getByRole('button', { name: 'Create account' }).click();
  await expect(page).toHaveURL(/\/auth\/signup/);

  await page.goto('/welcome');
  await expect(page.getByText('Authentication is disabled', { exact: false })).toBeVisible();

  await page.goto('/about');
  await expect(page.getByRole('heading', { level: 1 })).toBeVisible();
});
