import { AppRouterCacheProvider } from '@mui/material-nextjs/v15-appRouter';
import { ClerkProvider } from '@clerk/nextjs';
import { ThemeProvider } from '@mui/material';
import { light } from './Theme';
import './index.css';

export default async function RootLayout({ children }: { children: React.ReactNode }) {
  return (
    <html lang="en">
      <body>
        <AppRouterCacheProvider>
          <ClerkProvider>
            <ThemeProvider theme={light}>
              {children}
            </ThemeProvider>
          </ClerkProvider>
        </AppRouterCacheProvider>
      </body>
    </html>
  );
}
