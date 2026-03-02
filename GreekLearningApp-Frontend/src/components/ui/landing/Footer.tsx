'use client';

import React from 'react';
import {
  Box,
  Container as MuiContainer,
  Divider as MuiDivider,
  Grid,
  Link,
  Stack,
  Typography,
  styled,
} from '@mui/material';
import IconButton from '../inputs/IconButton';

export interface FooterLink {
  label: string;
  href: string;
}

export interface FooterSection {
  title: string;
  links: FooterLink[];
}

export interface FooterProps {
  /**
   * Footer sections with links
   */
  sections: FooterSection[];
  /**
   * Copyright text
   */
  copyright?: string;
  /**
   * Social media links
   */
  socialLinks?: Array<{
    icon: React.ReactNode;
    href: string;
    label: string;
  }>;
}

const FooterRoot = styled(Box)(({ theme }) => {
  const palette = theme.vars?.palette ?? theme.palette;
  return {
    backgroundColor: palette.canvas.subtle,
    borderTop: `1px solid ${palette.border.default}`,
    padding: theme.spacing(6, 0, 3),
    marginTop: 'auto',
  };
});

/**
 * Footer with links and copyright
 */
export const Footer: React.FC<FooterProps> = ({
  sections,
  copyright,
  socialLinks,
}) => {
  return (
    <FooterRoot>
      <MuiContainer maxWidth="lg">
        <Grid container spacing={4}>
          {sections.map((section, index) => (
            <Grid key={index} size={{ xs: 12, sm: 6, md: 3 }}>
              <Typography variant="h6" gutterBottom>
                {section.title}
              </Typography>
              <Stack spacing={1}>
                {section.links.map((link, linkIndex) => (
                  <Link
                    key={linkIndex}
                    href={link.href}
                    color="text.secondary"
                    underline="hover"
                  >
                    {link.label}
                  </Link>
                ))}
              </Stack>
            </Grid>
          ))}
        </Grid>
        <MuiDivider sx={{ my: 4 }} />
        <Box
          sx={{
            display: 'flex',
            justifyContent: 'space-between',
            alignItems: 'center',
            flexWrap: 'wrap',
            gap: 2,
          }}
        >
          <Typography variant="body2" color="text.secondary">
            {copyright || `© ${new Date().getFullYear()} All rights reserved.`}
          </Typography>
          {socialLinks && (
            <Stack direction="row" spacing={1}>
              {socialLinks.map((social, index) => (
                <IconButton
                  key={index}
                  href={social.href}
                  tooltip={social.label}
                  size="small"
                >
                  {social.icon}
                </IconButton>
              ))}
            </Stack>
          )}
        </Box>
      </MuiContainer>
    </FooterRoot>
  );
};

export default Footer;
