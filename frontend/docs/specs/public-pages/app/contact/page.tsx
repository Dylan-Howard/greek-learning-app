'use client';
// src/app/contact/page.tsx

import React, { useState } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import Alert from '@mui/material/Alert';
import Select, { SelectChangeEvent } from '@mui/material/Select';
import MenuItem from '@mui/material/MenuItem';
import InputLabel from '@mui/material/InputLabel';
import FormControl from '@mui/material/FormControl';
import Link from '@mui/material/Link';
import Divider from '@mui/material/Divider';
import PublicLayout from '@/components/public/PublicLayout';
import { tokens } from '@/theme/theme';

const SUBJECTS = [
  'General question',
  'Bug report',
  'Feature request',
  'Content issue (Greek text)',
  'Donation enquiry',
  'Other',
];

export default function ContactPage() {
  const [name,    setName]    = useState('');
  const [email,   setEmail]   = useState('');
  const [subject, setSubject] = useState('');
  const [message, setMessage] = useState('');
  const [status,  setStatus]  = useState<'idle' | 'sending' | 'sent' | 'error'>('idle');

  async function handleSubmit(e: React.FormEvent) {
    e.preventDefault();
    setStatus('sending');
    // TODO: wire up to your email/form backend (e.g. Resend, Formspree, SendGrid)
    await new Promise((r) => setTimeout(r, 900));
    setStatus('sent');
  }

  return (
    <PublicLayout>
      <Box sx={{ maxWidth: 1100, mx: 'auto', px: { xs: 3, md: 6 }, py: { xs: 8, md: 12 } }}>
        <Box
          sx={{
            display: 'grid',
            gridTemplateColumns: { xs: '1fr', md: '2fr 3fr' },
            gap: { xs: 6, md: 10 },
            alignItems: 'flex-start',
          }}
        >
          {/* Left: info */}
          <Box>
            <Typography
              sx={{ fontFamily: '"Noto Serif", serif', fontSize: { xs: '2rem', md: '2.5rem' }, color: tokens.color.textPrimary, mb: 2, lineHeight: 1.2 }}
            >
              Get in touch
            </Typography>
            <Typography variant="body1" sx={{ color: tokens.color.textSecondary, lineHeight: 1.8, mb: 3 }}>
              Have a question, found a bug, or want to suggest a feature? We read every message and try to respond within a few days.
            </Typography>

            <Box sx={{ display: 'flex', flexDirection: 'column', gap: 2.5 }}>
              {[
                {
                  icon: '📧',
                  label: 'Email',
                  value: 'hello@gntreader.app',
                  href: 'mailto:hello@gntreader.app',
                },
                {
                  icon: '☕',
                  label: 'Donate',
                  value: 'Support the project',
                  href: '#donate',
                },
              ].map(({ icon, label, value, href }) => (
                <Box key={label} sx={{ display: 'flex', gap: 1.5, alignItems: 'flex-start' }}>
                  <Typography sx={{ fontSize: '1.25rem', lineHeight: 1.4, flexShrink: 0 }}>{icon}</Typography>
                  <Box>
                    <Typography sx={{ fontSize: '0.6875rem', fontWeight: 700, color: tokens.color.textMuted, textTransform: 'uppercase', letterSpacing: '0.07em', mb: 0.25 }}>
                      {label}
                    </Typography>
                    <Link href={href} underline="hover" sx={{ fontSize: '0.9375rem', color: tokens.color.primary }}>
                      {value}
                    </Link>
                  </Box>
                </Box>
              ))}
            </Box>

            <Divider sx={{ my: 4 }} />

            {/* Donate section */}
            <Box id="donate">
              <Typography variant="h3" sx={{ mb: 1, color: tokens.color.textPrimary }}>Support this project</Typography>
              <Typography variant="body2" sx={{ color: tokens.color.textSecondary, lineHeight: 1.8, mb: 2 }}>
                Greek NT Reader is free and will remain so. If it helps your study or ministry, a donation helps cover hosting and ongoing development.
              </Typography>
              <Typography variant="body2" sx={{ color: tokens.color.textSecondary, lineHeight: 1.8, mb: 2 }}>
                {/* Replace with your actual donation link — Ko-fi, PayPal, Stripe, etc. */}
                To donate, email us at <Link href="mailto:hello@gntreader.app" sx={{ color: tokens.color.primary }}>hello@gntreader.app</Link> and we'll share payment details. We're working on a proper donation page.
              </Typography>
              <Typography variant="body2" sx={{ color: tokens.color.textMuted, fontStyle: 'italic' }}>
                The app is completely free whether or not you donate.
              </Typography>
            </Box>
          </Box>

          {/* Right: form */}
          <Box
            component="form"
            onSubmit={handleSubmit}
            noValidate
            sx={{
              p:            { xs: 3, md: 4 },
              border:       '1px solid ' + tokens.color.border,
              borderRadius: tokens.radius.lg,
              bgcolor:      tokens.color.bg,
              boxShadow:    '0 2px 12px rgba(0,0,0,0.05)',
              display:      'flex',
              flexDirection:'column',
              gap:          2.5,
            }}
          >
            {status === 'sent' ? (
              <Box sx={{ py: 4, textAlign: 'center' }}>
                <Typography sx={{ fontSize: '2.5rem', mb: 2 }}>✉️</Typography>
                <Typography variant="h3" sx={{ mb: 1 }}>Message sent!</Typography>
                <Typography variant="body1" sx={{ color: tokens.color.textSecondary }}>
                  Thanks for reaching out. We'll get back to you within a few days.
                </Typography>
                <Button
                  variant="text"
                  onClick={() => { setStatus('idle'); setName(''); setEmail(''); setSubject(''); setMessage(''); }}
                  sx={{ mt: 2, color: tokens.color.primary }}
                >
                  Send another message
                </Button>
              </Box>
            ) : (
              <>
                {status === 'error' && (
                  <Alert severity="error" sx={{ borderRadius: tokens.radius.sm }}>
                    Something went wrong. Please try emailing us directly.
                  </Alert>
                )}

                <Box sx={{ display: 'grid', gridTemplateColumns: { xs: '1fr', sm: '1fr 1fr' }, gap: 2 }}>
                  <TextField label="Your name" value={name} onChange={(e) => setName(e.target.value)} required fullWidth />
                  <TextField label="Email address" type="email" value={email} onChange={(e) => setEmail(e.target.value)} required fullWidth />
                </Box>

                <FormControl fullWidth size="small">
                  <InputLabel id="subject-label">Subject</InputLabel>
                  <Select
                    labelId="subject-label"
                    value={subject}
                    label="Subject"
                    onChange={(e: SelectChangeEvent) => setSubject(e.target.value)}
                    sx={{ borderRadius: tokens.radius.sm }}
                  >
                    {SUBJECTS.map((s) => (
                      <MenuItem key={s} value={s}>{s}</MenuItem>
                    ))}
                  </Select>
                </FormControl>

                <TextField
                  label="Message"
                  value={message}
                  onChange={(e) => setMessage(e.target.value)}
                  required
                  fullWidth
                  multiline
                  rows={6}
                  placeholder="Tell us what's on your mind…"
                />

                <Button
                  type="submit"
                  variant="contained"
                  size="large"
                  disabled={status === 'sending' || !name || !email || !message}
                  sx={{
                    bgcolor:      tokens.color.primary,
                    '&:hover':    { bgcolor: tokens.color.primaryDark },
                    fontWeight:   700,
                    borderRadius: tokens.radius.sm,
                    py:           1.375,
                  }}
                >
                  {status === 'sending' ? 'Sending…' : 'Send message'}
                </Button>

                <Typography variant="body2" sx={{ color: tokens.color.textMuted, textAlign: 'center' }}>
                  We typically respond within 2–4 days.
                </Typography>
              </>
            )}
          </Box>
        </Box>
      </Box>
    </PublicLayout>
  );
}
