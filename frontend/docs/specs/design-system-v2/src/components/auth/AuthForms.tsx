'use client';
// src/components/auth/AuthForms.tsx
// All auth form components. Pages import from here.

import React, { useState } from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import Divider from '@mui/material/Divider';
import Link from '@mui/material/Link';
import Alert from '@mui/material/Alert'; // MUI v7: from @mui/material
import GoogleIcon from '@mui/icons-material/Google';
import AppleIcon  from '@mui/icons-material/Apple';
import { tokens } from '@/theme/theme';

// ── Shared OAuth buttons ──────────────────────────────────────────────────────
function OAuthButtons({ action }: { action: 'sign in' | 'sign up' }) {
  return (
    <Box sx={{ display: 'flex', flexDirection: 'column', gap: 1.25 }}>
      <Button
        variant="outlined"
        fullWidth
        startIcon={<GoogleIcon />}
        sx={{
          borderColor: tokens.color.border,
          color:       tokens.color.textPrimary,
          '&:hover':   { borderColor: tokens.color.borderStrong, bgcolor: tokens.color.surfaceAlt },
        }}
      >
        Continue with Google
      </Button>
      <Button
        variant="outlined"
        fullWidth
        startIcon={<AppleIcon />}
        sx={{
          borderColor: tokens.color.border,
          color:       tokens.color.textPrimary,
          '&:hover':   { borderColor: tokens.color.borderStrong, bgcolor: tokens.color.surfaceAlt },
        }}
      >
        Continue with Apple
      </Button>
    </Box>
  );
}

function OrDivider() {
  return (
    <Divider sx={{ my: 2 }}>
      <Typography variant="body2" sx={{ color: tokens.color.textMuted, px: 1 }}>
        or
      </Typography>
    </Divider>
  );
}

// ── Login Form ────────────────────────────────────────────────────────────────
interface LoginFormProps {
  onSubmit:   (email: string, password: string) => Promise<void>;
  onSignUp:   () => void;
  onGuest?:   () => void;
}
export function LoginForm({ onSubmit, onSignUp, onGuest }: LoginFormProps) {
  const [email,    setEmail]    = useState('');
  const [password, setPassword] = useState('');
  const [loading,  setLoading]  = useState(false);
  const [error,    setError]    = useState('');

  async function handleSubmit(e: React.FormEvent) {
    e.preventDefault();
    setError('');
    setLoading(true);
    try {
      await onSubmit(email, password);
    } catch (err: any) {
      setError(err.message ?? 'Failed to log in.');
    } finally {
      setLoading(false);
    }
  }

  return (
    <Box component="form" onSubmit={handleSubmit} noValidate>
      <Typography variant="h2" sx={{ mb: 2 }}>Welcome back</Typography>

      {error && <Alert severity="error" sx={{ mb: 2, borderRadius: tokens.radius.sm }}>{error}</Alert>}

      <OAuthButtons action="sign in" />
      <OrDivider />

      <Box sx={{ display: 'flex', flexDirection: 'column', gap: 1.5 }}>
        <TextField
          label="Email"
          type="email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
          required
          autoComplete="email"
          fullWidth
        />
        <Box>
          <TextField
            label="Password"
            type="password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            required
            autoComplete="current-password"
            fullWidth
          />
          <Box sx={{ textAlign: 'right', mt: 0.5 }}>
            <Link href="/auth/forgot-password" variant="body2" sx={{ color: tokens.color.primary }}>
              Forgot password?
            </Link>
          </Box>
        </Box>

        <Button
          type="submit"
          variant="contained"
          fullWidth
          disabled={loading}
          sx={{ bgcolor: tokens.color.primary, '&:hover': { bgcolor: tokens.color.primaryDark }, mt: 0.5 }}
        >
          {loading ? 'Logging in…' : 'Log In'}
        </Button>
      </Box>

      <Typography variant="body2" sx={{ textAlign: 'center', mt: 2.5, color: tokens.color.textSecondary }}>
        Don't have an account?{' '}
        <Link component="button" type="button" onClick={onSignUp} sx={{ color: tokens.color.primary, fontWeight: 600 }}>
          Sign up
        </Link>
      </Typography>

      {onGuest && (
        <Typography variant="body2" sx={{ textAlign: 'center', mt: 1 }}>
          <Link component="button" type="button" onClick={onGuest} sx={{ color: tokens.color.textMuted }}>
            Just browsing? Continue as guest →
          </Link>
        </Typography>
      )}
    </Box>
  );
}

// ── Sign Up Form ──────────────────────────────────────────────────────────────
interface SignUpFormProps {
  onSubmit:  (email: string, password: string) => Promise<void>;
  onLogin:   () => void;
  onGuest?:  () => void;
}
export function SignUpForm({ onSubmit, onLogin, onGuest }: SignUpFormProps) {
  const [email,    setEmail]    = useState('');
  const [password, setPassword] = useState('');
  const [confirm,  setConfirm]  = useState('');
  const [loading,  setLoading]  = useState(false);
  const [error,    setError]    = useState('');

  async function handleSubmit(e: React.FormEvent) {
    e.preventDefault();
    if (password !== confirm) { setError('Passwords do not match.'); return; }
    setError('');
    setLoading(true);
    try {
      await onSubmit(email, password);
    } catch (err: any) {
      setError(err.message ?? 'Failed to create account.');
    } finally {
      setLoading(false);
    }
  }

  return (
    <Box component="form" onSubmit={handleSubmit} noValidate>
      <Typography variant="h2" sx={{ mb: 2 }}>Create account</Typography>

      {error && <Alert severity="error" sx={{ mb: 2, borderRadius: tokens.radius.sm }}>{error}</Alert>}

      <OAuthButtons action="sign up" />
      <OrDivider />

      <Box sx={{ display: 'flex', flexDirection: 'column', gap: 1.5 }}>
        <TextField label="Email"            type="email"    value={email}    onChange={(e) => setEmail(e.target.value)}    required fullWidth autoComplete="email" />
        <TextField label="Password"         type="password" value={password} onChange={(e) => setPassword(e.target.value)} required fullWidth autoComplete="new-password" />
        <TextField label="Confirm password" type="password" value={confirm}  onChange={(e) => setConfirm(e.target.value)}  required fullWidth autoComplete="new-password" />

        <Button
          type="submit"
          variant="contained"
          fullWidth
          disabled={loading}
          sx={{ bgcolor: tokens.color.primary, '&:hover': { bgcolor: tokens.color.primaryDark } }}
        >
          {loading ? 'Creating account…' : 'Create Account'}
        </Button>
      </Box>

      <Typography variant="body2" sx={{ textAlign: 'center', mt: 1.5, color: tokens.color.textMuted }}>
        Free forever · No credit card required
      </Typography>

      <Typography variant="body2" sx={{ textAlign: 'center', mt: 1.5, color: tokens.color.textSecondary }}>
        Already have an account?{' '}
        <Link component="button" type="button" onClick={onLogin} sx={{ color: tokens.color.primary, fontWeight: 600 }}>
          Log in
        </Link>
      </Typography>

      {onGuest && (
        <Typography variant="body2" sx={{ textAlign: 'center', mt: 1 }}>
          <Link component="button" type="button" onClick={onGuest} sx={{ color: tokens.color.textMuted }}>
            Just browsing? Continue as guest →
          </Link>
        </Typography>
      )}
    </Box>
  );
}

// ── Forgot Password Form ──────────────────────────────────────────────────────
interface ForgotPasswordFormProps {
  onSubmit:  (email: string) => Promise<void>;
  onBack:    () => void;
}
export function ForgotPasswordForm({ onSubmit, onBack }: ForgotPasswordFormProps) {
  const [email,    setEmail]    = useState('');
  const [loading,  setLoading]  = useState(false);
  const [sent,     setSent]     = useState(false);
  const [error,    setError]    = useState('');

  async function handleSubmit(e: React.FormEvent) {
    e.preventDefault();
    setError('');
    setLoading(true);
    try {
      await onSubmit(email);
      setSent(true);
    } catch (err: any) {
      setError(err.message ?? 'Failed to send reset email.');
    } finally {
      setLoading(false);
    }
  }

  if (sent) {
    return (
      <Box sx={{ textAlign: 'center' }}>
        <Typography sx={{ fontSize: '2.5rem', mb: 1.5 }}>📬</Typography>
        <Typography variant="h2" sx={{ mb: 1 }}>Check your email</Typography>
        <Typography variant="body1" sx={{ color: tokens.color.textSecondary, mb: 2 }}>
          We've sent a password reset link to <strong>{email}</strong>.
        </Typography>
        <Link component="button" onClick={() => setSent(false)} sx={{ color: tokens.color.primary, fontSize: '0.875rem' }}>
          Didn't receive it? Send again
        </Link>
        <Box sx={{ mt: 2 }}>
          <Link component="button" onClick={onBack} sx={{ color: tokens.color.textMuted, fontSize: '0.875rem' }}>
            ← Back to login
          </Link>
        </Box>
      </Box>
    );
  }

  return (
    <Box component="form" onSubmit={handleSubmit} noValidate>
      <Typography variant="h2" sx={{ mb: 0.75 }}>Reset password</Typography>
      <Typography variant="body2" sx={{ color: tokens.color.textSecondary, mb: 2.5 }}>
        Enter your email and we'll send you a reset link.
      </Typography>

      {error && <Alert severity="error" sx={{ mb: 2, borderRadius: tokens.radius.sm }}>{error}</Alert>}

      <TextField
        label="Email"
        type="email"
        value={email}
        onChange={(e) => setEmail(e.target.value)}
        required
        fullWidth
        autoComplete="email"
        sx={{ mb: 1.5 }}
      />

      <Button
        type="submit"
        variant="contained"
        fullWidth
        disabled={loading}
        sx={{ bgcolor: tokens.color.primary, '&:hover': { bgcolor: tokens.color.primaryDark }, mb: 2 }}
      >
        {loading ? 'Sending…' : 'Send Reset Link'}
      </Button>

      <Typography variant="body2" sx={{ textAlign: 'center' }}>
        <Link component="button" type="button" onClick={onBack} sx={{ color: tokens.color.textMuted }}>
          ← Back to login
        </Link>
      </Typography>
    </Box>
  );
}

// ── Guest Banner (in NavRail for guest users) ─────────────────────────────────
interface GuestCTAProps { onSignUp: () => void; }
export function GuestCTA({ onSignUp }: GuestCTAProps) {
  return (
    <Box
      sx={{
        px:           1,
        py:           1.5,
        bgcolor:      tokens.color.primaryLight,
        borderTop:    `1px solid ${tokens.color.border}`,
        display:      'flex',
        flexDirection: 'column',
        alignItems:   'center',
        gap:          0.75,
        textAlign:    'center',
      }}
    >
      <Typography sx={{ fontSize: '0.625rem', color: tokens.color.primaryDark, lineHeight: 1.3 }}>
        Sign up to save progress
      </Typography>
      <Button
        variant="contained"
        size="small"
        onClick={onSignUp}
        sx={{
          bgcolor:    tokens.color.primary,
          '&:hover':  { bgcolor: tokens.color.primaryDark },
          fontSize:   '0.6875rem',
          py:         0.5,
          px:         1.5,
          minWidth:   0,
        }}
      >
        Sign Up
      </Button>
    </Box>
  );
}
