// src/app/privacy/page.tsx

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
      subtitle="How we collect, use, and protect your information."
      lastUpdated="March 2026"
      sections={[
        {
          id: 'overview',
          heading: '1. Overview',
          children: (
            <>
              <p>Greek NT Reader ("we", "our", or "us") is committed to protecting your privacy. This policy explains what data we collect when you use this app, how we use it, and your rights regarding that data.</p>
              <p>We collect the minimum amount of data necessary to provide the service. We do not sell your data. We do not show you ads.</p>
            </>
          ),
        },
        {
          id: 'data-collected',
          heading: '2. Data We Collect',
          children: (
            <>
              <p><strong>Account data.</strong> If you create an account, we store your email address and a cryptographic hash of your password. We never store your password in plain text.</p>
              <p><strong>Usage data.</strong> We store your reading progress (which books and chapters you have opened), your SRS review history (which words you have reviewed and when, and your recall ratings), your vocabulary set progress, and your lesson completion status. This data is necessary to operate the spaced-repetition system and progress tracking.</p>
              <p><strong>Session data.</strong> We use a session cookie to keep you logged in. See the <Link href="#cookies">Cookie Policy</Link> section below.</p>
              <p><strong>Guest users.</strong> If you use the app without creating an account, we store no personal data. Any progress made as a guest is stored only in your browser's local storage and is not synced or retained on our servers.</p>
              <p><strong>Contact form submissions.</strong> If you contact us via the contact form, we receive your name, email address, and message. We use this only to respond to your enquiry.</p>
            </>
          ),
        },
        {
          id: 'how-we-use',
          heading: '3. How We Use Your Data',
          children: (
            <>
              <p>We use your data solely to:</p>
              <ul>
                <li>Operate and improve the service (e.g., power your SRS scheduler, save reading position)</li>
                <li>Authenticate you and maintain your session</li>
                <li>Respond to support or contact requests</li>
                <li>Understand aggregate usage patterns to guide development (e.g., which books are read most)</li>
              </ul>
              <p>We do not use your data for advertising, profiling, or any purpose unrelated to providing this service.</p>
            </>
          ),
        },
        {
          id: 'data-sharing',
          heading: '4. Data Sharing',
          children: (
            <>
              <p>We do not sell, rent, or share your personal data with third parties, except:</p>
              <ul>
                <li><strong>Hosting provider.</strong> Our servers are hosted on a third-party cloud provider. Your data is stored on those servers under their data-processing agreement with us.</li>
                <li><strong>Legal obligation.</strong> We may disclose data if required by applicable law or a valid legal process.</li>
              </ul>
              <p>We have no advertising partners and use no third-party tracking or analytics SDKs that collect personal data.</p>
            </>
          ),
        },
        {
          id: 'data-retention',
          heading: '5. Data Retention',
          children: (
            <>
              <p>We retain your account and usage data for as long as your account is active. If you delete your account, we delete all associated personal data within 30 days, except where retention is required by law.</p>
              <p>Contact form messages are retained for up to 12 months to allow follow-up.</p>
            </>
          ),
        },
        {
          id: 'your-rights',
          heading: '6. Your Rights',
          children: (
            <>
              <p>Depending on where you live, you may have the following rights regarding your personal data:</p>
              <ul>
                <li><strong>Access.</strong> Request a copy of the personal data we hold about you.</li>
                <li><strong>Correction.</strong> Request that inaccurate data be corrected.</li>
                <li><strong>Deletion.</strong> Request that we delete your account and associated data.</li>
                <li><strong>Portability.</strong> Request your SRS and progress data in a machine-readable format.</li>
                <li><strong>Objection.</strong> Object to certain processing activities.</li>
              </ul>
              <p>To exercise any of these rights, email us at <Link href="mailto:hello@gntreader.app">hello@gntreader.app</Link>. We will respond within 30 days.</p>
            </>
          ),
        },
        {
          id: 'cookies',
          heading: '7. Cookie Policy',
          children: (
            <>
              <p>We use only <strong>strictly necessary cookies</strong> — specifically, a single session cookie that keeps you logged in while you use the app. This cookie is set only when you log in and is deleted when you log out or it expires.</p>
              <p>We do not use analytics cookies, advertising cookies, or any third-party tracking cookies. Because we use only strictly necessary cookies, we are not required to obtain your consent before setting them under GDPR or ePrivacy rules. However, you can disable cookies entirely in your browser settings; note that doing so will prevent you from staying logged in.</p>
              <p><strong>Cookie name:</strong> <code>gnt_session</code> · <strong>Purpose:</strong> Authentication · <strong>Duration:</strong> 30 days (or until logout) · <strong>Type:</strong> HttpOnly, Secure, SameSite=Strict</p>
            </>
          ),
        },
        {
          id: 'security',
          heading: '8. Security',
          children: (
            <>
              <p>We use industry-standard security practices: HTTPS for all data in transit, bcrypt hashing for passwords, and access controls on our database. No system is perfectly secure, but we take reasonable measures to protect your data.</p>
              <p>If you discover a security vulnerability, please disclose it responsibly by emailing <Link href="mailto:hello@gntreader.app">hello@gntreader.app</Link>.</p>
            </>
          ),
        },
        {
          id: 'children',
          heading: '9. Children',
          children: (
            <>
              <p>This service is not directed at children under the age of 13. We do not knowingly collect personal data from children. If you believe a child has provided us with personal data, please contact us and we will delete it promptly.</p>
            </>
          ),
        },
        {
          id: 'changes',
          heading: '10. Changes to This Policy',
          children: (
            <>
              <p>We may update this policy from time to time. If we make material changes, we will notify registered users by email. The "Last updated" date at the top of this page reflects the most recent revision.</p>
            </>
          ),
        },
        {
          id: 'contact',
          heading: '11. Contact',
          children: (
            <>
              <p>Questions about this policy? Email us at <Link href="mailto:hello@gntreader.app">hello@gntreader.app</Link> or use the <Link href="/contact">contact form</Link>.</p>
            </>
          ),
        },
      ]}
    />
  );
}
