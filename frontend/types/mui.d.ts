// src/theme/mui.d.ts
// MUI v7: interface augmentation uses @mui/material/styles (no deep imports)
import '@mui/material/styles';

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

  // v7 renamed: TypographyOptions → TypographyVariantsOptions
  interface TypographyVariantsOptions {
    greekBody?:   React.CSSProperties;
    greekHelp?:   React.CSSProperties;
    prose?:       React.CSSProperties;
    greekDisplay?: React.CSSProperties;
    greekCard?:    React.CSSProperties;
    greekInline?:  React.CSSProperties;
    greekSmall?:   React.CSSProperties;
  }
  interface TypographyVariants {
    greekBody:   React.CSSProperties;
    greekHelp:   React.CSSProperties;
    prose:       React.CSSProperties;
    greekDisplay: React.CSSProperties;
    greekCard:    React.CSSProperties;
    greekInline:  React.CSSProperties;
    greekSmall:   React.CSSProperties;
  }
}

declare module '@mui/material/Typography' {
  interface TypographyPropsVariantOverrides {
    greekBody:   true;
    greekHelp:   true;
    prose:       true;
    greekDisplay: true;
    greekCard:    true;
    greekInline:  true;
    greekSmall:   true;
  }
}
