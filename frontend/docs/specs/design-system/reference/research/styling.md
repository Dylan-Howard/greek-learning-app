# MUI v7 Styling Approaches

## Using CSS Variables
MUI v7 encourages the use of CSS variables for theming. This enables instant theme switching and more performant styles.

### The `theme.vars` Token
Access the CSS variables through `theme.vars`.

```tsx
<Box sx={{ color: (theme) => theme.vars.palette.primary.main }} />
```

## Styling Utilities
### The `sx` Prop
Still the most common way to apply styles. In v7, it's more efficient as it maps directly to CSS variables.

```tsx
<Box sx={{
  p: 2,
  bgcolor: 'background.paper',
  borderRadius: 1,
  boxShadow: 1,
}} />
```

### Styled Components
Recommended for complex styling and reuse.

```tsx
const Root = styled('div')(({ theme }) => ({
  display: 'flex',
  flexDirection: 'column',
  ...theme.applyStyles('dark', {
    backgroundColor: theme.vars.palette.background.default,
  }),
}));
```

## CSS Layers
MUI v7 introduces opt-in support for CSS layers via the `enableCssLayer` prop in `StyledEngineProvider`. This prevents style specificity conflicts, especially when using other CSS frameworks like Tailwind.

## Best Practices
- **Avoid Hardcoded Colors**: Use `theme.vars.palette` or MUI system shorthand (e.g., `bgcolor: 'primary.main'`).
- **Responsive Values**: Use the object syntax for responsive styles: `sx={{ width: { xs: '100%', md: '50%' } }}`.
- **Spacing Scale**: Always use the numeric spacing scale (e.g., `p: 2` = 16px) instead of raw pixel values.
