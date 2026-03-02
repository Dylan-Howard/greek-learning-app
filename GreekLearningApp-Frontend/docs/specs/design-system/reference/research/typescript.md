# MUI v7 TypeScript Usage

## Minimum Requirements
MUI v7 requires at least **TypeScript v4.9**.

## Module Augmentation
When adding custom variables to your theme (e.g., a new color or typography variant), use module augmentation for type safety.

```typescript
declare module '@mui/material/styles' {
  interface Palette {
    footer: {
      main: string;
      contrastText: string;
    };
  }
  interface PaletteOptions {
    footer?: {
      main?: string;
      contrastText?: string;
    };
  }
  interface TypographyVariants {
    readerBody: React.CSSProperties;
    readerHelp: React.CSSProperties;
  }
  interface TypographyVariantsOptions {
    readerBody?: React.CSSProperties;
    readerHelp?: React.CSSProperties;
  }
}
```

## Import Changes
Deep imports (e.g., `@mui/material/styles/createTypography`) are no longer supported. All style-related types and functions should be imported directly from `@mui/material/styles`.

```typescript
// v7 Standard
import { createTheme, ThemeOptions } from '@mui/material/styles';
```

## Using Types with Components
Types for components are available directly under the component names.

```typescript
import { ButtonProps } from '@mui/material/Button';

const MyCustomButton = (props: ButtonProps) => {
  return <Button {...props} />;
};
```

## Typed Slots
The `slotProps` API is fully typed in v7, providing better developer experience when customizing internal component parts.

```tsx
<Accordion 
  slotProps={{ 
    transition: { unmountOnExit: true } // Correctly typed for Transition component props
  }} 
/>
```
