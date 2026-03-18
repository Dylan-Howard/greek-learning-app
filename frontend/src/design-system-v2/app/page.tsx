// src/app/page.tsx — landing page (minimal redirect for now)
import { redirect } from 'next/navigation';

// TODO: replace with full landing page component
export default function HomePage() {
  redirect('/read');
}
