import { AppRouterCacheProvider } from '@mui/material-nextjs/v15-appRouter';
import InitColorSchemeScript from '@mui/material/InitColorSchemeScript';
import AppThemeProvider from '@/components/layout/AppThemeProvider';
import ClientProviders from '@/components/layout/ClientProviders';
import '@/styles/globals.css';

export default async function RootLayout({ children }: { children: React.ReactNode }) {
  return (
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
          <AppRouterCacheProvider options={{ enableCssLayer: true }}>
            <AppThemeProvider>
              <ClientProviders>{children}</ClientProviders>
            </AppThemeProvider>
          </AppRouterCacheProvider>
        </div>
      </body>
      <link rel="preconnect" href="https://fonts.googleapis.com" />
      <link rel="preconnect" href="https://fonts.gstatic.com" />
      <link href="https://fonts.googleapis.com/css2?family=Noto+Serif&display=swap" rel="stylesheet" precedence="default" />
      <link href="https://fonts.googleapis.com/css2?family=Noto+Sans:ital,wght@0,100..900;1,100..900&family=Noto+Serif:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet" precedence="default" />
      <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@24,400,0,0" precedence="default" />
    </html>
  );
}
