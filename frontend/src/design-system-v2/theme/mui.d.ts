// src/theme/mui.d.ts
// MUI v7: interface augmentation uses @mui/material/styles (no deep imports)
import '@mui/material/styles';

declare module '@mui/material/styles' {
  // v7 renamed: TypographyOptions → TypographyVariantsOptions
  interface TypographyVariantsOptions {
    greekDisplay?: React.CSSProperties;
    greekCard?:    React.CSSProperties;
    greekInline?:  React.CSSProperties;
    greekSmall?:   React.CSSProperties;
  }
  interface TypographyVariants {
    greekDisplay: React.CSSProperties;
    greekCard:    React.CSSProperties;
    greekInline:  React.CSSProperties;
    greekSmall:   React.CSSProperties;
  }
}

declare module '@mui/material/Typography' {
  interface TypographyPropsVariantOverrides {
    greekDisplay: true;
    greekCard:    true;
    greekInline:  true;
    greekSmall:   true;
  }
}
