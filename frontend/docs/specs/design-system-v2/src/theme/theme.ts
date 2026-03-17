import { createTheme } from '@mui/material/styles';

// ─── Design Tokens ────────────────────────────────────────────────────────────
export const tokens = {
  color: {
    primary:           '#6B4226',
    primaryLight:      '#FBF3EE',
    primaryDark:       '#4A2C17',
    bg:                '#FFFFFF',
    surface:           '#FAFAFA',
    surfaceAlt:        '#F5F5F5',
    border:            '#E0E0E0',
    borderStrong:      '#BDBDBD',
    textPrimary:       '#212121',
    textSecondary:     '#616161',
    textMuted:         '#9E9E9E',
    // SRS semantic
    srsNew:            '#1565C0',
    srsAgain:          '#C62828',
    srsHard:           '#E65100',
    srsGood:           '#2E7D32',
    srsEasy:           '#00695C',
    // Gamification
    xpGold:            '#C9A84C',
    xpRingBg:          '#E8E0CC',
    tierNovice:        '#78909C',
    tierApprentice:    '#1976D2',
    tierScholar:       '#6A1B9A',
    tierMaster:        '#C9A84C',
  },
  radius: {
    xs:   '4px',
    sm:   '6px',
    md:   '8px',
    lg:   '12px',
    xl:   '16px',
    full: '9999px',
  },
  motion: {
    fast:   '150ms',
    normal: '250ms',
    slow:   '400ms',
    ease:   'cubic-bezier(0.4, 0, 0.2, 1)',
    decel:  'cubic-bezier(0, 0, 0.2, 1)',
    accel:  'cubic-bezier(0.4, 0, 1, 1)',
  },
} as const;

// ─── MUI Theme ────────────────────────────────────────────────────────────────
const theme = createTheme({
  // MUI v7: CSS variables enabled by default for better dark-mode support
  cssVariables: true,

  palette: {
    primary: {
      main:         tokens.color.primary,
      light:        tokens.color.primaryLight,
      dark:         tokens.color.primaryDark,
      contrastText: '#FFFFFF',
    },
    background: {
      default: tokens.color.bg,
      paper:   tokens.color.surface,
    },
    text: {
      primary:   tokens.color.textPrimary,
      secondary: tokens.color.textSecondary,
      disabled:  tokens.color.textMuted,
    },
    divider: tokens.color.border,
    // Custom palette entries via module augmentation (see types/mui.d.ts)
  },

  typography: {
    fontFamily: '"Noto Sans", "Helvetica Neue", Arial, sans-serif',
    // Display — Noto Serif, for Greek word showcase
    h1: { fontFamily: '"Noto Sans"', fontSize: '1.75rem', fontWeight: 700, lineHeight: 1.3 },
    h2: { fontFamily: '"Noto Sans"', fontSize: '1.375rem', fontWeight: 600, lineHeight: 1.35 },
    h3: { fontFamily: '"Noto Sans"', fontSize: '1.125rem', fontWeight: 600, lineHeight: 1.4 },
    h4: { fontFamily: '"Noto Sans"', fontSize: '0.9375rem', fontWeight: 600, lineHeight: 1.4 },
    h5: { fontFamily: '"Noto Sans"', fontSize: '0.875rem', fontWeight: 600, lineHeight: 1.4 },
    h6: { fontFamily: '"Noto Sans"', fontSize: '0.8125rem', fontWeight: 600, lineHeight: 1.4 },
    body1: { fontSize: '0.9375rem', lineHeight: 1.6 },
    body2: { fontSize: '0.8125rem', lineHeight: 1.5 },
    caption: { fontSize: '0.75rem', lineHeight: 1.4 },
    overline: { fontSize: '0.6875rem', fontWeight: 600, letterSpacing: '0.08em', lineHeight: 1.2 },
    button: { fontFamily: '"Noto Sans"', fontWeight: 600, fontSize: '0.875rem', textTransform: 'none' },
  },

  shape: { borderRadius: 8 },

  spacing: 4, // 1 unit = 4px

  components: {
    MuiCssBaseline: {
      styleOverrides: `
        @import url('https://fonts.googleapis.com/css2?family=Noto+Sans:ital,wght@0,400;0,600;0,700;1,400&family=Noto+Serif:ital,wght@0,400;0,700;1,400&display=swap');
        *, *::before, *::after { box-sizing: border-box; }
        html { -webkit-font-smoothing: antialiased; }
      `,
    },
    MuiButton: {
      styleOverrides: {
        root: {
          borderRadius: tokens.radius.sm,
          fontWeight: 600,
          textTransform: 'none',
        },
        containedPrimary: {
          backgroundColor: tokens.color.primary,
          '&:hover': { backgroundColor: tokens.color.primaryDark },
        },
      },
    },
    MuiChip: {
      styleOverrides: {
        root: { borderRadius: tokens.radius.xs, fontWeight: 600, fontSize: '0.75rem' },
      },
    },
    MuiCard: {
      styleOverrides: {
        root: {
          borderRadius: tokens.radius.lg,
          border: `1px solid ${tokens.color.border}`,
          boxShadow: '0 1px 3px rgba(0,0,0,0.08)',
          '&:hover': { boxShadow: '0 3px 8px rgba(0,0,0,0.10)' },
        },
      },
    },
    MuiTextField: {
      defaultProps: { variant: 'outlined', size: 'small' },
      styleOverrides: {
        root: {
          '& .MuiOutlinedInput-root': {
            borderRadius: tokens.radius.sm,
            '& fieldset': { borderColor: tokens.color.border },
          },
        },
      },
    },
    MuiTooltip: {
      styleOverrides: {
        tooltip: {
          backgroundColor: tokens.color.textPrimary,
          color: '#FFFFFF',
          fontSize: '0.75rem',
          borderRadius: tokens.radius.xs,
          padding: '4px 8px',
        },
        arrow: { color: tokens.color.textPrimary },
      },
    },
    MuiLinearProgress: {
      styleOverrides: {
        root: { borderRadius: tokens.radius.full, height: 6 },
        bar: { borderRadius: tokens.radius.full },
      },
    },
    MuiDialog: {
      styleOverrides: {
        paper: { borderRadius: tokens.radius.lg },
      },
    },
    // MUI v7: Grid is now the Grid2 API
    MuiGrid: {
      defaultProps: { spacing: 0 },
    },
  },
});

export default theme;
