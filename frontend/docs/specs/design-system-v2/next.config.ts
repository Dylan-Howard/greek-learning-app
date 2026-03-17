import type { NextConfig } from 'next';

const nextConfig: NextConfig = {
  // MUI v7 requires transpilation for proper ESM + server component support
  transpilePackages: [
    '@mui/material',
    '@mui/system',
    '@mui/icons-material',
    '@mui/material-nextjs',
  ],
};

export default nextConfig;
