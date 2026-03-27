import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import Box from '@mui/material/Box';
import {
  LoginForm,
  SignUpForm,
  ForgotPasswordForm,
  GuestCTA,
} from './AuthForms';

const meta = {
  title: 'Design System/Auth/AuthForms',
  component: LoginForm,
  args: {
    onSubmit: async () => {},
    onSignUp: () => {},
    onGuest: () => {},
  },
} satisfies Meta<typeof LoginForm>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Login: Story = {
  render: () => (
    <Box sx={{ maxWidth: 420 }}>
      <LoginForm onSubmit={async () => {}} onSignUp={() => {}} onGuest={() => {}} />
    </Box>
  ),
};

export const SignUp: Story = {
  render: () => (
    <Box sx={{ maxWidth: 420 }}>
      <SignUpForm onSubmit={async () => {}} onLogin={() => {}} onGuest={() => {}} />
    </Box>
  ),
};

export const ForgotPassword: Story = {
  render: () => (
    <Box sx={{ maxWidth: 420 }}>
      <ForgotPasswordForm onSubmit={async () => {}} onBack={() => {}} />
    </Box>
  ),
};

export const GuestBanner: Story = {
  render: () => (
    <Box sx={{ width: 180 }}>
      <GuestCTA onSignUp={() => {}} />
    </Box>
  ),
};
