import { ClerkProvider } from '@clerk/nextjs';
import InitColorSchemeScript from '@mui/material/InitColorSchemeScript';
import { Noto_Sans, Noto_Serif } from 'next/font/google';
import ThemeProvider from '@/theme/ThemeProvider';
import ClientProviders from '@/components/layout/ClientProviders';
import '@/styles/globals.css';

const notoSans = Noto_Sans({
  subsets: ['latin'],
  display: 'optional',
  variable: '--font-noto-sans',
});

const notoSerif = Noto_Serif({
  subsets: ['latin'],
  display: 'optional',
  variable: '--font-noto-serif',
});

const THEME_COLOR_LIGHT = '#6B4226';
const THEME_COLOR_DARK = '#4A2C17';

if (!process.env.NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY) {
  throw new Error('NEXT_PUBLIC_CLERK_PUBLISHABLE_KEY is required');
}

export default async function RootLayout({ children }: { children: React.ReactNode }) {
  return (
    <ClerkProvider
      signInUrl={process.env.NEXT_PUBLIC_CLERK_SIGN_IN_URL}
      signUpUrl={process.env.NEXT_PUBLIC_CLERK_SIGN_UP_URL}
      afterSignInUrl={process.env.NEXT_PUBLIC_CLERK_SIGN_IN_FALLBACK_REDIRECT_URL}
      afterSignUpUrl={process.env.NEXT_PUBLIC_CLERK_SIGN_UP_FORCE_REDIRECT_URL}
    >
      <html lang="en" suppressHydrationWarning>
        <head>
          <InitColorSchemeScript defaultMode="light" />
          <meta name="theme-color" content={THEME_COLOR_LIGHT} media="(prefers-color-scheme: light)" />
          <meta name="theme-color" content={THEME_COLOR_DARK} media="(prefers-color-scheme: dark)" />
          <meta
            name="description"
            content="Koine: Your Companion to Reading the Bible in its Original Languages"
          />
          <title>Koine</title>
        </head>
        <body className={`${notoSans.variable} ${notoSerif.variable}`}>
          <noscript>You need to enable JavaScript to run this app.</noscript>
          <div id="root">
            <ThemeProvider>
              <ClientProviders>{children}</ClientProviders>
            </ThemeProvider>
          </div>
        </body>
      </html>
    </ClerkProvider>
  );
}
