// src/app/terms/page.tsx

import React from 'react';
import Link from '@mui/material/Link';
import LegalPage from '@/components/public/LegalPage';

export const metadata = {
  title: 'Terms of Service — Greek NT Reader',
};

export default function TermsPage() {
  return (
    <LegalPage
      title="Terms of Service"
      subtitle="The rules for using Greek NT Reader."
      lastUpdated="March 2026"
      sections={[
        {
          id: 'acceptance',
          heading: '1. Acceptance of Terms',
          children: (
            <>
              <p>By accessing or using Greek NT Reader ("the Service"), you agree to be bound by these Terms of Service. If you do not agree, do not use the Service.</p>
              <p>We may update these terms from time to time. Continued use of the Service after changes are posted constitutes acceptance of the revised terms. We will notify registered users of material changes by email.</p>
            </>
          ),
        },
        {
          id: 'description',
          heading: '2. Description of Service',
          children: (
            <>
              <p>Greek NT Reader is a free web application for reading the Greek New Testament with integrated vocabulary tools and spaced-repetition flashcards. The Service is provided free of charge and is sustained by optional donations.</p>
              <p>We reserve the right to modify, suspend, or discontinue the Service at any time, with or without notice. We are not liable to you for any such changes.</p>
            </>
          ),
        },
        {
          id: 'accounts',
          heading: '3. User Accounts',
          children: (
            <>
              <p>You may use much of the Service without an account. To save progress and access your SRS history, you must create an account with a valid email address and password.</p>
              <p>You are responsible for maintaining the security of your account credentials. You may not share your account with others. Notify us immediately at <Link href="mailto:hello@gntreader.app">hello@gntreader.app</Link> if you suspect unauthorised access.</p>
              <p>We may terminate or suspend accounts that violate these terms, at our discretion.</p>
            </>
          ),
        },
        {
          id: 'acceptable-use',
          heading: '4. Acceptable Use',
          children: (
            <>
              <p>You may use the Service for personal, educational, research, and ministry purposes. You agree not to:</p>
              <ul>
                <li>Attempt to gain unauthorised access to the Service or its underlying systems</li>
                <li>Use the Service to scrape, harvest, or mass-download content in an automated manner</li>
                <li>Interfere with or disrupt the Service or servers connected to it</li>
                <li>Use the Service for any unlawful purpose</li>
                <li>Impersonate any person or entity</li>
              </ul>
            </>
          ),
        },
        {
          id: 'intellectual-property',
          heading: '5. Intellectual Property',
          children: (
            <>
              <p><strong>Greek text.</strong> The Greek New Testament text displayed in this Service is the <em>SBL Greek New Testament</em>, © 2010 Logos Bible Software and the Society of Biblical Literature. It is used in accordance with its license terms. The Greek text may be freely quoted for personal, educational, and non-commercial purposes with attribution.</p>
              <p><strong>App code and content.</strong> All other content in the Service — including but not limited to the application code, UI design, lesson text, and vocabulary data — is proprietary to Greek NT Reader. You may not reproduce or redistribute it without prior written permission.</p>
              <p><strong>Your data.</strong> Content you create in the Service (such as notes, if and when supported) belongs to you. By submitting content, you grant us a licence to store and display it to provide the Service.</p>
            </>
          ),
        },
        {
          id: 'disclaimers',
          heading: '6. Disclaimers',
          children: (
            <>
              <p>The Service is provided "as is" and "as available" without warranties of any kind, express or implied, including fitness for a particular purpose or uninterrupted availability.</p>
              <p>Parsing data, definitions, and grammatical information are provided for educational purposes. We make reasonable efforts to ensure accuracy but cannot guarantee that all data is error-free. For scholarly work, always verify against primary sources.</p>
            </>
          ),
        },
        {
          id: 'limitation',
          heading: '7. Limitation of Liability',
          children: (
            <>
              <p>To the fullest extent permitted by applicable law, Greek NT Reader and its operators shall not be liable for any indirect, incidental, special, consequential, or punitive damages arising from your use of or inability to use the Service, even if we have been advised of the possibility of such damages.</p>
              <p>Our total liability to you for any claims arising from these terms or the Service shall not exceed the amount you have paid us in the twelve months preceding the claim (which may be zero, as the Service is free).</p>
            </>
          ),
        },
        {
          id: 'governing-law',
          heading: '8. Governing Law',
          children: (
            <>
              <p>These terms are governed by and construed in accordance with applicable law. Any disputes shall be resolved in the courts of the jurisdiction in which the Service is operated. If you are a consumer in the EU or UK, you also benefit from any mandatory protections provided by the laws of your country of residence.</p>
            </>
          ),
        },
        {
          id: 'contact',
          heading: '9. Contact',
          children: (
            <>
              <p>Questions about these terms? Email us at <Link href="mailto:hello@gntreader.app">hello@gntreader.app</Link> or use the <Link href="/contact">contact form</Link>.</p>
            </>
          ),
        },
      ]}
    />
  );
}
