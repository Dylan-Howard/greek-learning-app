// ============================================
// THEME.TS - MUI V7 THEME CONFIGURATION
// Suggested file: src/theme/theme.ts
// ============================================

import { createTheme, alpha, Theme as MuiTheme, ThemeOptions as MuiThemeOptions } from '@mui/material/styles';

declare module '@mui/material/styles' {
  interface Palette {
    canvas: {
      default: string;
      subtle: string;
      inset: string;
    };
    border: {
      default: string;
      muted: string;
      subtle: string;
    };
    neutral: {
      emphasis: string;
      emphasisPlus: string;
      muted: string;
      subtle: string;
    };
  }
  interface PaletteOptions {
    canvas?: {
      default?: string;
      subtle?: string;
      inset?: string;
    };
    border?: {
      default?: string;
      muted?: string;
      subtle?: string;
    };
    neutral?: {
      emphasis?: string;
      emphasisPlus?: string;
      muted?: string;
      subtle?: string;
    };
  }

  interface TypographyVariants {
    greekBody: React.CSSProperties;
    greekHelp: React.CSSProperties;
    prose: React.CSSProperties;
  }

  interface TypographyVariantsOptions {
    greekBody?: React.CSSProperties;
    greekHelp?: React.CSSProperties;
    prose?: React.CSSProperties;
  }

  interface Theme {
    vars: Omit<MuiTheme, 'vars'> & {
      palette: Palette;
    };
  }
  interface ThemeOptions extends MuiThemeOptions {
    vars?: unknown;
  }
}

declare module '@mui/material/Typography' {
  interface TypographyPropsVariantOverrides {
    greekBody: true;
    greekHelp: true;
    prose: true;
  }
}

const theme = createTheme({
  // ============================================
  // COLOR SCHEMES (Light & Dark)
  // ============================================
  colorSchemes: {
    light: {
      palette: {
        primary: {
          main: '#0969da', // GitHub blue
          light: '#218bff',
          dark: '#0550ae',
          contrastText: '#ffffff',
        },
        secondary: {
          main: '#6e7781', // Neutral gray
          light: '#8c959f',
          dark: '#57606a',
          contrastText: '#ffffff',
        },
        error: {
          main: '#d1242f',
          light: '#ff6a69',
          dark: '#a40e26',
          contrastText: '#ffffff',
        },
        warning: {
          main: '#bf8700',
          light: '#d4a72c',
          dark: '#9a6700',
          contrastText: '#24292f',
        },
        info: {
          main: '#0969da',
          light: '#218bff',
          dark: '#0550ae',
          contrastText: '#ffffff',
        },
        success: {
          main: '#1a7f37',
          light: '#2da44e',
          dark: '#116329',
          contrastText: '#ffffff',
        },
        background: {
          default: '#ffffff',
          paper: '#f6f8fa',
        },
        text: {
          primary: '#24292f',
          secondary: '#57606a',
          disabled: '#8c959f',
        },
        divider: '#d0d7de',
        // Custom Primer-inspired tokens
        canvas: {
          default: '#ffffff',
          subtle: '#f6f8fa',
          inset: '#f6f8fa',
        },
        border: {
          default: '#d0d7de',
          muted: '#d8dee4',
          subtle: '#eaeef2',
        },
        neutral: {
          emphasis: '#6e7781',
          emphasisPlus: '#24292f',
          muted: 'rgba(175, 184, 193, 0.2)',
          subtle: 'rgba(234, 238, 242, 0.5)',
        },
      },
    },
    dark: {
      palette: {
        primary: {
          main: '#58a6ff',
          light: '#79c0ff',
          dark: '#388bfd',
          contrastText: '#0d1117',
        },
        secondary: {
          main: '#8b949e',
          light: '#b1bac4',
          dark: '#6e7681',
          contrastText: '#0d1117',
        },
        error: {
          main: '#f85149',
          light: '#ff7b72',
          dark: '#da3633',
          contrastText: '#0d1117',
        },
        warning: {
          main: '#d29922',
          light: '#e3b341',
          dark: '#bb8009',
          contrastText: '#0d1117',
        },
        info: {
          main: '#58a6ff',
          light: '#79c0ff',
          dark: '#388bfd',
          contrastText: '#0d1117',
        },
        success: {
          main: '#3fb950',
          light: '#56d364',
          dark: '#2ea043',
          contrastText: '#0d1117',
        },
        background: {
          default: '#0d1117',
          paper: '#161b22',
        },
        text: {
          primary: '#e6edf3',
          secondary: '#8b949e',
          disabled: '#6e7681',
        },
        divider: '#30363d',
        // Custom Primer-inspired tokens
        canvas: {
          default: '#0d1117',
          subtle: '#161b22',
          inset: '#010409',
        },
        border: {
          default: '#30363d',
          muted: '#21262d',
          subtle: '#21262d',
        },
        neutral: {
          emphasis: '#8b949e',
          emphasisPlus: '#e6edf3',
          muted: 'rgba(110, 118, 129, 0.4)',
          subtle: 'rgba(110, 118, 129, 0.1)',
        },
      },
    },
  },

  // ============================================
  // TYPOGRAPHY
  // ============================================
  typography: {
    fontFamily:
      '-apple-system, BlinkMacSystemFont, "Segoe UI", "Noto Sans", Helvetica, Arial, sans-serif, "Apple Color Emoji", "Segoe UI Emoji"',
    fontSize: 14,
    fontWeightLight: 300,
    fontWeightRegular: 400,
    fontWeightMedium: 500,
    fontWeightBold: 600,
    h1: {
      fontSize: '2rem',
      fontWeight: 600,
      lineHeight: 1.25,
      letterSpacing: '-0.01em',
    },
    h2: {
      fontSize: '1.5rem',
      fontWeight: 600,
      lineHeight: 1.25,
      letterSpacing: '-0.01em',
    },
    h3: {
      fontSize: '1.25rem',
      fontWeight: 600,
      lineHeight: 1.25,
    },
    h4: {
      fontSize: '1rem',
      fontWeight: 600,
      lineHeight: 1.25,
    },
    h5: {
      fontSize: '0.875rem',
      fontWeight: 600,
      lineHeight: 1.25,
    },
    h6: {
      fontSize: '0.75rem',
      fontWeight: 600,
      lineHeight: 1.25,
      textTransform: 'uppercase',
      letterSpacing: '0.05em',
    },
    body1: {
      fontSize: '0.875rem',
      lineHeight: 1.5,
    },
    body2: {
      fontSize: '0.75rem',
      lineHeight: 1.5,
    },
    button: {
      fontSize: '0.875rem',
      fontWeight: 500,
      textTransform: 'none',
      lineHeight: 1.5,
    },
    caption: {
      fontSize: '0.75rem',
      lineHeight: 1.5,
      color: 'text.secondary',
    },
    overline: {
      fontSize: '0.75rem',
      fontWeight: 600,
      lineHeight: 1.5,
      textTransform: 'uppercase',
      letterSpacing: '0.05em',
    },
    // Custom Greek typography
    greekBody: {
      fontFamily: '"Noto Serif", Georgia, serif',
      fontSize: '1.125rem',
      lineHeight: 1.8,
      fontWeight: 400,
    },
    greekHelp: {
      fontFamily:
        '-apple-system, BlinkMacSystemFont, "Segoe UI", "Noto Sans", Helvetica, Arial, sans-serif',
      fontSize: '0.75rem',
      lineHeight: 1.5,
      fontWeight: 400,
      color: 'text.secondary',
    },
    prose: {
      fontSize: '1rem',
      lineHeight: 1.7,
      fontWeight: 400,
    },
  },

  // ============================================
  // SPACING (8px base grid)
  // ============================================
  spacing: 8,

  // ============================================
  // BREAKPOINTS
  // ============================================
  breakpoints: {
    values: {
      xs: 0,
      sm: 640,
      md: 768,
      lg: 1024,
      xl: 1280,
    },
  },

  // ============================================
  // SHAPE (Border radius)
  // ============================================
  shape: {
    borderRadius: 6,
  },

  // ============================================
  // TRANSITIONS (Material Design 3)
  // ============================================
  transitions: {
    easing: {
      // Emphasized (default for most transitions)
      easeInOut: 'cubic-bezier(0.2, 0, 0, 1)',
      // Standard (utility transitions)
      easeOut: 'cubic-bezier(0, 0, 0.2, 1)',
      // Decelerate (entering)
      easeIn: 'cubic-bezier(0.4, 0, 1, 1)',
      // Accelerate (exiting)
      sharp: 'cubic-bezier(0.4, 0, 0.6, 1)',
    },
    duration: {
      shortest: 100,
      shorter: 150,
      short: 200,
      standard: 300,
      complex: 375,
      enteringScreen: 250,
      leavingScreen: 200,
    },
  },

  // ============================================
  // COMPONENT OVERRIDES
  // ============================================
  components: {
    MuiCssBaseline: {
      styleOverrides: {
        body: {
          scrollbarColor: '#6b6b6b #2b2b2b',
          '&::-webkit-scrollbar, & *::-webkit-scrollbar': {
            width: 12,
            height: 12,
          },
          '&::-webkit-scrollbar-thumb, & *::-webkit-scrollbar-thumb': {
            borderRadius: 8,
            backgroundColor: '#6b6b6b',
            minHeight: 24,
            border: '3px solid #2b2b2b',
          },
          '&::-webkit-scrollbar-thumb:focus, & *::-webkit-scrollbar-thumb:focus': {
            backgroundColor: '#959595',
          },
          '&::-webkit-scrollbar-thumb:active, & *::-webkit-scrollbar-thumb:active': {
            backgroundColor: '#959595',
          },
          '&::-webkit-scrollbar-thumb:hover, & *::-webkit-scrollbar-thumb:hover': {
            backgroundColor: '#959595',
          },
          '&::-webkit-scrollbar-corner, & *::-webkit-scrollbar-corner': {
            backgroundColor: '#2b2b2b',
          },
        },
      },
    },
    MuiButton: {
      defaultProps: {
        disableElevation: true,
      },
      styleOverrides: {
        root: {
          borderRadius: 6,
          textTransform: 'none',
          fontWeight: 500,
          padding: '8px 16px',
          transition: 'all 150ms cubic-bezier(0, 0, 0.2, 1)',
        },
        sizeLarge: {
          padding: '12px 24px',
          fontSize: '1rem',
        },
        sizeSmall: {
          padding: '4px 12px',
          fontSize: '0.8125rem',
        },
      },
    },
    MuiIconButton: {
      styleOverrides: {
        root: {
          borderRadius: 6,
          transition: 'all 150ms cubic-bezier(0, 0, 0.2, 1)',
        },
      },
    },
    MuiCard: {
      defaultProps: {
        elevation: 0,
      },
      styleOverrides: {
        root: ({ theme }) => ({
          borderRadius: 6,
          border: `1px solid ${theme.vars.palette.border.default}`,
          backgroundColor: theme.vars.palette.canvas.default,
        }),
      },
    },
    MuiPaper: {
      defaultProps: {
        elevation: 0,
      },
      styleOverrides: {
        root: ({ theme }) => ({
          borderRadius: 6,
          border: `1px solid ${theme.vars.palette.border.default}`,
          backgroundColor: theme.vars.palette.canvas.default,
        }),
        outlined: ({ theme }) => ({
          border: `1px solid ${theme.vars.palette.border.default}`,
        }),
      },
    },
    MuiTextField: {
      defaultProps: {
        variant: 'outlined',
      },
    },
    MuiOutlinedInput: {
      styleOverrides: {
        root: ({ theme }) => ({
          borderRadius: 6,
          backgroundColor: theme.vars.palette.canvas.inset,
          transition: 'border-color 150ms cubic-bezier(0, 0, 0.2, 1)',
          '&:hover .MuiOutlinedInput-notchedOutline': {
            borderColor: theme.vars.palette.border.default,
          },
          '&.Mui-focused .MuiOutlinedInput-notchedOutline': {
            borderWidth: '2px',
          },
        }),
        notchedOutline: ({ theme }) => ({
          borderColor: theme.vars.palette.border.muted,
        }),
      },
    },
    MuiChip: {
      styleOverrides: {
        root: {
          borderRadius: 12,
          fontWeight: 500,
        },
      },
    },
    MuiAlert: {
      styleOverrides: {
        root: {
          borderRadius: 6,
        },
        standardSuccess: ({ theme }) => ({
          backgroundColor: alpha(theme.vars.palette.success.main, 0.1),
          color: theme.vars.palette.success.dark,
          border: `1px solid ${alpha(theme.vars.palette.success.main, 0.3)}`,
        }),
        standardError: ({ theme }) => ({
          backgroundColor: alpha(theme.vars.palette.error.main, 0.1),
          color: theme.vars.palette.error.dark,
          border: `1px solid ${alpha(theme.vars.palette.error.main, 0.3)}`,
        }),
        standardWarning: ({ theme }) => ({
          backgroundColor: alpha(theme.vars.palette.warning.main, 0.1),
          color: theme.vars.palette.warning.dark,
          border: `1px solid ${alpha(theme.vars.palette.warning.main, 0.3)}`,
        }),
        standardInfo: ({ theme }) => ({
          backgroundColor: alpha(theme.vars.palette.info.main, 0.1),
          color: theme.vars.palette.info.dark,
          border: `1px solid ${alpha(theme.vars.palette.info.main, 0.3)}`,
        }),
      },
    },
    MuiDialog: {
      styleOverrides: {
        paper: {
          borderRadius: 12,
        },
      },
    },
    MuiTooltip: {
      styleOverrides: {
        tooltip: {
          borderRadius: 6,
          fontSize: '0.75rem',
          padding: '6px 12px',
        },
      },
    },
    MuiTab: {
      styleOverrides: {
        root: {
          textTransform: 'none',
          fontWeight: 500,
          minHeight: 48,
        },
      },
    },
  },
});

export default theme;
