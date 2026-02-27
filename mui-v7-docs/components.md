# MUI v7 Component API & Customization

## Slot Pattern
Standardization of the slot pattern is the most significant change in v7. Older props like `TransitionComponent` or `InputProps` are replaced by unified `slots` and `slotProps` APIs.

### Example: Accordion
```tsx
// v7 Standard
<Accordion 
  slots={{ transition: CustomTransition }} 
  slotProps={{ transition: { unmountOnExit: true } }} 
/>
```

### Common Component Overrides
Customize all instances of a component via the `components` key in `createTheme`.

```typescript
const theme = createTheme({
  components: {
    MuiButton: {
      styleOverrides: {
        root: { 
          borderRadius: 8,
          textTransform: 'none',
        },
      },
    },
    MuiCard: {
      styleOverrides: {
        root: {
          boxShadow: '0px 2px 4px rgba(0, 0, 0, 0.05)',
        },
      },
    },
  },
});
```

## Updated Component References
- **Grid v2**: The original `Grid` is now `GridLegacy`. The newer `Grid2` is the default `Grid`.
- **Button**: Continued support for `variant="contained"`, `variant="outlined"`, and `variant="text"`.
- **TextField**: Enhanced with `slots` for start/end adornments.
- **Drawer/AppBar**: Standardized slot names for better consistency.

## Usage Guidelines
- **Elevation**: Use `elevation` props on `Paper` and `Card` components for consistent shadowing.
- **Coloring**: Prefer theme-aware colors (e.g., `color="primary"`) over hardcoded hex values.
- **Accessibility**: All MUI v7 components are designed with keyboard and screen reader accessibility in mind, often requiring minimal extra configuration.
