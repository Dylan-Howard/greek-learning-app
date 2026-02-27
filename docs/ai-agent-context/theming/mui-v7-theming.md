# MUI v7 Theming & TypeScript Configuration

## Overview
Material UI (MUI) v7 focuses on full ESM support, standardized slot patterns, and CSS Layers integration for tools like Tailwind v4.

## Theme Configuration
In v7, deep imports are restricted. Use the top-level `/styles` or main package.

### Basic Setup
```typescript
import { createTheme, ThemeOptions } from '@mui/material/styles';

const themeOptions: ThemeOptions = {
  palette: {
    primary: { main: '#1976d2' },
  },
  enableCssLayer: true, // Opt-in to CSS layers (improves Tailwind v4 integration)
};

export const theme = createTheme(themeOptions);
```

### TypeScript Module Augmentation
To add custom tokens to the theme, use module augmentation in a `.d.ts` file or at the top of your theme file.

```typescript
import { Palette, PaletteOptions } from '@mui/material/styles';

declare module '@mui/material/styles' {
  interface Palette {
    neutral: Palette['primary'];
  }
  interface PaletteOptions {
    neutral?: PaletteOptions['primary'];
  }
}

// Custom Typography
declare module '@mui/material/styles' {
  interface TypographyVariants {
    poster: React.CSSProperties;
  }
  interface TypographyVariantsOptions {
    poster?: React.CSSProperties;
  }
}
declare module '@mui/material/Typography' {
  interface TypographyPropsVariantOverrides {
    poster: true;
  }
}
```

## Styling Approaches
1. **The `sx` Prop:** Still the standard for one-off styles. Optimized in v7 for performance.
2. **`styled` Components:** Recommended for reusable, logic-heavy components.
3. **Slot Pattern:** Standardized in v7. Use `slots` and `slotProps` to style internal elements.
   ```jsx
   <TextField 
     slotProps={{ 
       input: { sx: { borderRadius: 0 } },
       inputLabel: { shrink: true } 
     }} 
   />
   ```

## Dark Mode Implementation
MUI v7 uses CSS variables by default when `cssVariables: true` is enabled in the theme.
```typescript
const theme = createTheme({
  cssVariables: true,
  colorSchemes: {
    light: true,
    dark: true,
  },
});
```

## Reference URLs
- [MUI v7 Migration Guide](https://mui.com/material-ui/migration/v6-to-v7/)
- [MUI Theming Documentation](https://mui.com/material-ui/customization/theming/)
