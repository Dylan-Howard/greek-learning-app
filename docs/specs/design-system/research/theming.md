# MUI v7 Theming & Dark Mode

## Theme Configuration
MUI v7 emphasizes the use of **CSS variables** and **Color Schemes** for more robust dark mode support.

### Built-in Color Schemes
Enable light and dark modes directly within the theme configuration using the `colorSchemes` node.

```typescript
import { createTheme } from '@mui/material/styles';

const theme = createTheme({
  colorSchemes: {
    light: true, // Enables default light palette
    dark: true,  // Enables default dark palette
  },
});
```

### Customizing Schemes
You can customize the light and dark palettes within the `colorSchemes` object.

```typescript
const theme = createTheme({
  colorSchemes: {
    light: {
      palette: {
        primary: { main: '#4A89BF' },
        background: { default: '#F8F8FC' },
      },
    },
    dark: {
      palette: {
        primary: { main: '#689CCA' },
        background: { default: '#1B2021' },
      },
    },
  },
});
```

## Dark Mode Implementation
- **CssBaseline**: Always include `<CssBaseline />` inside your `<ThemeProvider>` to ensure background and text colors update correctly.
- **Dynamic Styling**: Use `theme.applyStyles('dark', { ... })` for custom styling that changes based on the mode.

```typescript
const CustomBox = styled('div')(({ theme }) => ({
  backgroundColor: '#fff',
  ...theme.applyStyles('dark', {
    backgroundColor: '#000',
  }),
}));
```

## Theme Tokens
MUI v7 encourages using theme tokens (e.g., `theme.vars.palette.primary.main`) which map to CSS variables, enabling instant theme switching without re-rendering the component tree.
