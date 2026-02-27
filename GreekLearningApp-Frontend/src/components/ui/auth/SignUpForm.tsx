'use client';

import React from 'react';
import {
  Checkbox as MuiCheckbox,
  FormControlLabel,
  Link,
  Paper as MuiPaper,
  Stack,
  Typography,
} from '@mui/material';
import {
  Email as EmailIcon,
  Lock as LockIcon,
  Person as PersonIcon,
  Visibility as VisibilityIcon,
  VisibilityOff as VisibilityOffIcon,
} from '@mui/icons-material';
import Button from '../inputs/Button';
import IconButton from '../inputs/IconButton';
import TextField from '../inputs/TextField';
import Alert from '../feedback/Alert';

export interface SignUpFormProps {
  /**
   * Submit handler
   */
  onSubmit: (name: string, email: string, password: string) => void;
  /**
   * Loading state
   */
  loading?: boolean;
  /**
   * Error message
   */
  error?: string;
  /**
   * Link to sign in page
   */
  signInLink?: string;
}

/**
 * Sign up form with name, email, and password
 */
export const SignUpForm: React.FC<SignUpFormProps> = ({
  onSubmit,
  loading,
  error,
  signInLink,
}) => {
  const [name, setName] = React.useState('');
  const [email, setEmail] = React.useState('');
  const [password, setPassword] = React.useState('');
  const [confirmPassword, setConfirmPassword] = React.useState('');
  const [showPassword, setShowPassword] = React.useState(false);
  const [agreedToTerms, setAgreedToTerms] = React.useState(false);

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    if (password !== confirmPassword) {
      return;
    }
    if (!agreedToTerms) {
      return;
    }
    onSubmit(name, email, password);
  };

  const passwordsMatch = password === confirmPassword || confirmPassword === '';

  return (
    <MuiPaper sx={{ p: 4, maxWidth: 400, mx: 'auto' }}>
      <Typography variant="h2" gutterBottom textAlign="center">
        Sign Up
      </Typography>
      <form onSubmit={handleSubmit}>
        <Stack spacing={3} sx={{ mt: 3 }}>
          {error && <Alert severity="error" message={error} />}
          <TextField
            label="Full Name"
            type="text"
            value={name}
            onChange={(e) => setName(e.target.value)}
            required
            fullWidth
            InputProps={{
              startAdornment: <PersonIcon sx={{ mr: 1, color: 'text.secondary' }} />,
            }}
          />
          <TextField
            label="Email"
            type="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
            fullWidth
            InputProps={{
              startAdornment: <EmailIcon sx={{ mr: 1, color: 'text.secondary' }} />,
            }}
          />
          <TextField
            label="Password"
            type={showPassword ? 'text' : 'password'}
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            required
            fullWidth
            helperText="At least 8 characters"
            InputProps={{
              startAdornment: <LockIcon sx={{ mr: 1, color: 'text.secondary' }} />,
              endAdornment: (
                <IconButton
                  onClick={() => setShowPassword(!showPassword)}
                  edge="end"
                  size="small"
                >
                  {showPassword ? <VisibilityOffIcon /> : <VisibilityIcon />}
                </IconButton>
              ),
            }}
          />
          <TextField
            label="Confirm Password"
            type={showPassword ? 'text' : 'password'}
            value={confirmPassword}
            onChange={(e) => setConfirmPassword(e.target.value)}
            required
            fullWidth
            error={!passwordsMatch}
            helperText={!passwordsMatch ? 'Passwords do not match' : ''}
            InputProps={{
              startAdornment: <LockIcon sx={{ mr: 1, color: 'text.secondary' }} />,
            }}
          />
          <FormControlLabel
            control={
              <MuiCheckbox
                checked={agreedToTerms}
                onChange={(e) => setAgreedToTerms(e.target.checked)}
              />
            }
            label={
              <Typography variant="body2">
                I agree to the{' '}
                <Link href="/terms" color="primary">
                  Terms of Service
                </Link>{' '}
                and{' '}
                <Link href="/privacy" color="primary">
                  Privacy Policy
                </Link>
              </Typography>
            }
          />
          <Button
            type="submit"
            variant="contained"
            size="large"
            fullWidth
            loading={loading}
            disabled={!passwordsMatch || !agreedToTerms}
          >
            Sign Up
          </Button>
          {signInLink && (
            <Typography variant="body2" textAlign="center">
              Already have an account?{' '}
              <Link href={signInLink} color="primary">
                Sign in
              </Link>
            </Typography>
          )}
        </Stack>
      </form>
    </MuiPaper>
  );
};

export default SignUpForm;
