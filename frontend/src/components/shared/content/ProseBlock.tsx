'use client';

import React from 'react';
import {
  Box,
  styled,
} from '@mui/material';

export interface ProseBlockProps {
  /**
   * Content to display
   */
  children: React.ReactNode;
  /**
   * Maximum width
   */
  maxWidth?: 'sm' | 'md' | 'lg';
}

const ProseRoot = styled(Box)(({ theme }) => {
  const palette = theme.vars?.palette ?? theme.palette;
  return {
  '& h1, & h2, & h3, & h4, & h5, & h6': {
    marginTop: theme.spacing(4),
    marginBottom: theme.spacing(2),
    fontWeight: 600,
    lineHeight: 1.25,
  },
  '& h1': {
    fontSize: '2rem',
  },
  '& h2': {
    fontSize: '1.5rem',
  },
  '& h3': {
    fontSize: '1.25rem',
  },
  '& p': {
    marginBottom: theme.spacing(2),
    lineHeight: 1.7,
  },
  '& ul, & ol': {
    marginBottom: theme.spacing(2),
    paddingLeft: theme.spacing(3),
  },
  '& li': {
    marginBottom: theme.spacing(1),
  },
  '& a': {
    color: palette.primary.main,
    textDecoration: 'none',
    '&:hover': {
      textDecoration: 'underline',
    },
  },
  '& code': {
    backgroundColor: palette.neutral.subtle,
    padding: '2px 6px',
    borderRadius: 4,
    fontSize: '0.875em',
    fontFamily: 'monospace',
  },
  '& pre': {
    backgroundColor: palette.canvas.inset,
    padding: theme.spacing(2),
    borderRadius: 6,
    overflow: 'auto',
    marginBottom: theme.spacing(2),
  },
  '& blockquote': {
    borderLeft: `4px solid ${palette.border.default}`,
    paddingLeft: theme.spacing(2),
    marginLeft: 0,
    fontStyle: 'italic',
    color: palette.text.secondary,
  },
  };
});

/**
 * Styled prose container for content pages
 */
export const ProseBlock: React.FC<ProseBlockProps> = ({
  children,
  maxWidth = 'md',
}) => {
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
};

export default ProseBlock;
