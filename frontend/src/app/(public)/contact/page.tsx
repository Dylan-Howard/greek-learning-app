import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import Link from '@mui/material/Link';
import PublicLayout from '@/components/public/PublicLayout';
import { tokens } from '@/design-system-v2/theme/theme';

export const metadata = {
  title: 'Contact — Greek NT Reader',
};

export default function ContactPage() {
  return (
    <PublicLayout>
      <Box sx={{ maxWidth: 800, mx: 'auto', px: { xs: 3, md: 6 }, py: { xs: 8, md: 10 } }}>
        <Typography variant="h2" sx={{ mb: 1 }}>Contact</Typography>
        <Typography variant="body1" sx={{ color: tokens.color.textSecondary, mb: 4 }}>
          Questions, feedback, or support? Send a note and we’ll respond as soon as we can.
        </Typography>

        <Box
          component="form"
          sx={{
            display: 'grid',
            gridTemplateColumns: { xs: '1fr', md: '1fr 1fr' },
            gap: 2,
            mb: 4,
          }}
        >
          <TextField label="Name" fullWidth />
          <TextField label="Email" type="email" fullWidth />
          <TextField label="Subject" fullWidth sx={{ gridColumn: { xs: '1 / -1' } }} />
          <TextField label="Message" multiline minRows={5} fullWidth sx={{ gridColumn: { xs: '1 / -1' } }} />
          <Button
            variant="contained"
            sx={{ gridColumn: { xs: '1 / -1' }, maxWidth: 200, bgcolor: tokens.color.primary, '&:hover': { bgcolor: tokens.color.primaryDark } }}
          >
            Send Message
          </Button>
        </Box>

        <Box id="donate" sx={{ mt: 6, p: 3, border: `1px solid ${tokens.color.border}`, borderRadius: tokens.radius.md, bgcolor: tokens.color.surface }}>
          <Typography variant="h3" sx={{ mb: 1 }}>Support the project</Typography>
          <Typography variant="body2" sx={{ color: tokens.color.textSecondary, mb: 2 }}>
            Greek NT Reader is free forever. If this tool serves you, consider donating to keep it sustainable.
          </Typography>
          <Link href="mailto:hello@gntreader.app" underline="none" sx={{ color: tokens.color.primary }}>
            Contact us for donation options →
          </Link>
        </Box>
      </Box>
    </PublicLayout>
  );
}
