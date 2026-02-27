'use client';

import React from 'react';
import {
  Link,
  Paper as MuiPaper,
  Stack,
  Typography,
} from '@mui/material';
import {
  Email as EmailIcon,
  Lock as LockIcon,
  Visibility as VisibilityIcon,
  VisibilityOff as VisibilityOffIcon,
} from '@mui/icons-material';
import Button from '../inputs/Button';
import IconButton from '../inputs/IconButton';
import TextField from '../inputs/TextField';
import Alert from '../feedback/Alert';

export interface SignInFormProps {
  /**
   * Submit handler
   */
  onSubmit: (email: string, password: string) => void;
  /**
   * Loading state
   */
  loading?: boolean;
  /**
   * Error message
   */
  error?: string;
  /**
   * Link to sign up page
   */
  signUpLink?: string;
  /**
   * Link to forgot password
   */
  forgotPasswordLink?: string;
}

/**
 * Sign in form with email and password
 */
export const SignInForm: React.FC<SignInFormProps> = ({
  onSubmit,
  loading,
  error,
  signUpLink,
  forgotPasswordLink,
}) => {
  const [email, setEmail] = React.useState('');
  const [password, setPassword] = React.useState('');
  const [showPassword, setShowPassword] = React.useState(false);

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    onSubmit(email, password);
  };

  return (
    <MuiPaper sx={{ p: 4, maxWidth: 400, mx: 'auto' }}>
      <Typography variant="h2" gutterBottom textAlign="center">
        Sign In
      </Typography>
      <form onSubmit={handleSubmit}>
        <Stack spacing={3} sx={{ mt: 3 }}>
          {error && <Alert severity="error" message={error} />}
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
          {forgotPasswordLink && (
            <Link
              href={forgotPasswordLink}
              variant="body2"
              textAlign="right"
              color="primary"
            >
              Forgot password?
            </Link>
          )}
          <Button
            type="submit"
            variant="contained"
            size="large"
            fullWidth
            loading={loading}
          >
            Sign In
          </Button>
          {signUpLink && (
            <Typography variant="body2" textAlign="center">
              Don't have an account?{' '}
              <Link href={signUpLink} color="primary">
                Sign up
              </Link>
            </Typography>
          )}
        </Stack>
      </form>
    </MuiPaper>
  );
};

export default SignInForm;
