'use client';

import dynamic from 'next/dynamic';

const ShowcaseClient = dynamic(
  () => import('./ShowcaseClient.js').then((mod) => mod.default),
  { ssr: false },
);

export default function ShowcasePage() {
  return <ShowcaseClient />;
}
