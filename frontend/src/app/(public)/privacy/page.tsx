import React from 'react';
import Link from '@mui/material/Link';
import LegalPage from '@/components/public/LegalPage';

export const metadata = {
  title: 'Privacy Policy — Greek NT Reader',
};

export default function PrivacyPage() {
  return (
    <LegalPage
      title="Privacy Policy"
      subtitle="How we handle your data."
      lastUpdated="March 2026"
      sections={[
        {
          id: 'overview',
          heading: '1. Overview',
          children: (
            <>
              <p>We respect your privacy. This policy explains what data we collect and how we use it.</p>
              <p>By using Greek NT Reader, you agree to the collection and use of information as described here.</p>
            </>
          ),
        },
        {
          id: 'data-collected',
          heading: '2. Data We Collect',
          children: (
            <>
              <p>We collect information you provide directly, such as your email address and study progress.</p>
              <p>We may collect basic analytics data to improve the service, such as page visits and feature usage.</p>
            </>
          ),
        },
        {
          id: 'cookies',
          heading: '3. Cookies',
          children: (
            <>
              <p>We use cookies to maintain sessions and improve your experience.</p>
              <p>You can disable cookies in your browser, but some features may not function properly.</p>
            </>
          ),
        },
        {
          id: 'sharing',
          heading: '4. Sharing',
          children: (
            <>
              <p>We do not sell your personal data. We only share data with service providers necessary to operate the app.</p>
            </>
          ),
        },
        {
          id: 'contact',
          heading: '5. Contact',
          children: (
            <>
              <p>Questions about privacy? Email us at <Link href="mailto:hello@gntreader.app">hello@gntreader.app</Link>.</p>
            </>
          ),
        },
      ]}
    />
  );
}
