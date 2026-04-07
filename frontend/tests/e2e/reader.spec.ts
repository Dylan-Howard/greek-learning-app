import { test, expect } from '@playwright/test';

const apiBaseURL = process.env.PLAYWRIGHT_API_BASE_URL ?? 'http://localhost:5001';

test('reader page renders chapter content', async ({ page, request }) => {
  const response = await request.post(`${apiBaseURL}/graphql`, {
    data: {
      query: 'query { reader(bookId: 1, chapterNumber: 1) { title } }',
    },
  });

  expect(response.ok()).toBeTruthy();
  const payload = await response.json();
  const title = payload?.data?.reader?.title as string | undefined;
  expect(title).toBeTruthy();

  await page.goto('/reader/1/1');
  await expect(page).toHaveURL(/\/reader\/1\/1/);
  if (title) {
    await expect(page.getByText(title)).toBeVisible();
  }
});
