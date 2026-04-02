'use client';

import React from 'react';
import { Box, styled } from '@mui/material';
import { tokens } from '@/design-system-v2/theme/theme';

export interface ProseBlockProps {
  children: React.ReactNode;
  maxWidth?: 'sm' | 'md' | 'lg';
}

const ProseRoot = styled(Box)(({ theme }) => ({
  '& h1, & h2, & h3, & h4, & h5, & h6': {
    marginTop: theme.spacing(4),
    marginBottom: theme.spacing(2),
    fontWeight: 600,
    lineHeight: 1.25,
  },
  '& h1': { fontSize: '2rem' },
  '& h2': { fontSize: '1.5rem' },
  '& h3': { fontSize: '1.25rem' },
  '& p': {
    marginBottom: theme.spacing(2),
    lineHeight: 1.7,
  },
  '& ul, & ol': {
    marginBottom: theme.spacing(2),
    paddingLeft: theme.spacing(3),
  },
  '& li': { marginBottom: theme.spacing(1) },
  '& a': {
    color: tokens.color.primary,
    textDecoration: 'none',
    '&:hover': { textDecoration: 'underline' },
  },
  '& code': {
    backgroundColor: tokens.color.surfaceAlt,
    padding: '2px 6px',
    borderRadius: tokens.radius.xs,
    fontSize: '0.875em',
    fontFamily: 'monospace',
  },
  '& pre': {
    backgroundColor: tokens.color.surfaceAlt,
    padding: theme.spacing(2),
    borderRadius: tokens.radius.sm,
    overflow: 'auto',
    marginBottom: theme.spacing(2),
  },
  '& blockquote': {
    borderLeft: `4px solid ${tokens.color.border}`,
    paddingLeft: theme.spacing(2),
    marginLeft: 0,
    fontStyle: 'italic',
    color: tokens.color.textSecondary,
  },
}));

export function ProseBlock({ children, maxWidth = 'md' }: ProseBlockProps) {
  const maxWidthMap = {
    sm: 640,
    md: 768,
    lg: 896,
  };

  return (
    <ProseRoot sx={{ maxWidth: maxWidthMap[maxWidth], mx: 'auto', py: 4 }}>
      {children}
    </ProseRoot>
  );
}
