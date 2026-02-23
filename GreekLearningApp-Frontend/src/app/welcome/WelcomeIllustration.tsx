'use client';

import React from 'react';
import './WelcomeIllustration.css';

export default function WelcomeIllustration() {
  return (
    <div className="WelcomeIllustration">
      {/* Placeholder for illustration */}
      <svg width="100%" height="100%" viewBox="0 0 400 400">
        <circle cx="200" cy="200" r="100" fill="#4A5D23" opacity="0.2" />
        <rect x="150" y="150" width="100" height="100" fill="#4A5D23" />
      </svg>
    </div>
  );
}
