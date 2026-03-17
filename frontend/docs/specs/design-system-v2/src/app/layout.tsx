// src/app/layout.tsx
// Next.js App Router root layout.

import type { Metadata } from 'next';
import ThemeProvider from '@/theme/ThemeProvider';

export const metadata: Metadata = {
  title:       'Greek NT Reader',
  description: 'Read the Greek New Testament with integrated spaced-repetition vocabulary.',
};

export default function RootLayout({ children }: { children: React.ReactNode }) {
  return (
    <html lang="en">
      <body>
        <ThemeProvider>{children}</ThemeProvider>
      </body>
    </html>
  );
}
