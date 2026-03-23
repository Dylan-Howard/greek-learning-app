import { ClerkProvider } from '@clerk/nextjs';
import InitColorSchemeScript from '@mui/material/InitColorSchemeScript';
import ThemeProvider from '@/design-system-v2/theme/ThemeProvider';
import ClientProviders from '@/components/layout/ClientProviders';
import '@/styles/globals.css';

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
          <meta name="theme-color" content="#0969da" media="(prefers-color-scheme: light)" />
          <meta name="theme-color" content="#0d1117" media="(prefers-color-scheme: dark)" />
          <meta
            name="description"
            content="Koine: Your Companion to Reading the Bible in its Original Languages"
          />
          <title>Koine</title>
        </head>
        <body>
          <noscript>You need to enable JavaScript to run this app.</noscript>
          <div id="root">
            <ThemeProvider>
              <ClientProviders>{children}</ClientProviders>
            </ThemeProvider>
          </div>
        </body>
        <link rel="preconnect" href="https://fonts.googleapis.com" />
        <link rel="preconnect" href="https://fonts.gstatic.com" />
        <link href="https://fonts.googleapis.com/css2?family=Noto+Serif&display=swap" rel="stylesheet" precedence="default" />
        <link href="https://fonts.googleapis.com/css2?family=Noto+Sans:ital,wght@0,100..900;1,100..900&family=Noto+Serif:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet" precedence="default" />
        <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@24,400,0,0" precedence="default" />
      </html>
    </ClerkProvider>
  );
}
