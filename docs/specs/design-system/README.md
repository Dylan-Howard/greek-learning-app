# Koine Greek Learning App - Design System Documentation

## Overview

This is a complete Material UI v7 design system built for the Koine Greek Learning App. It follows GitHub Primer's design philosophy with a clean, structured, and functional aesthetic while leveraging Material Design 3's motion specifications.

## Design Principles

### Visual Identity
- **Clean & Structured**: Emphasis on borders and background colors over drop shadows
- **Functional Aesthetic**: Systematic approach to color and spacing
- **Cool-Toned Palette**: Blues and grays used sparingly for a professional feel
- **Hierarchy Through Space**: Clear visual hierarchy using typography and spacing

### Technical Foundation
- Material UI v7 with TypeScript
- CSS Variables for instant theme switching
- 8px base grid system
- Material Design 3 motion specifications
- WCAG 2.2 AA accessibility compliance

## File Structure

```
src/
├── theme/
│   └── theme.ts                      # Core theme configuration
├── components/
│   ├── inputs/
│   │   ├── Button.tsx                # Primary button with loading state
│   │   ├── IconButton.tsx            # Icon button with tooltip
│   │   ├── ButtonGroup.tsx           # Group of related buttons
│   │   ├── ToggleButton.tsx          # Toggle button group
│   │   ├── TextField.tsx             # Enhanced text field with character count
│   │   ├── Select.tsx                # Select dropdown
│   │   ├── Checkbox.tsx              # Checkbox with label
│   │   ├── RadioGroup.tsx            # Radio group component
│   │   ├── Switch.tsx                # Switch with label
│   │   └── Fab.tsx                   # Floating action button
│   ├── display/
│   │   ├── Card.tsx                  # Versatile card component
│   │   ├── ProgressCard.tsx          # Card with progress indicator
│   │   └── KoineCard.tsx             # Specialized card for Greek content
│   ├── feedback/
│   │   ├── Alert.tsx                 # Alert/notification component
│   │   └── Dialog.tsx                # Modal dialog
│   ├── navigation/
│   │   ├── NavRail.tsx               # Vertical navigation rail
│   │   └── AppShell.tsx              # Complete app layout wrapper
│   ├── content/
│   │   └── ProseBlock.tsx            # Styled prose container for content pages
│   ├── educational/
│   │   ├── MultipleChoice.tsx        # Multiple choice question component
│   │   ├── AcknowledgementButton.tsx # Confirmation button
│   │   └── GreekTextUnit.tsx         # Interactive Greek text with interlinear help
│   ├── landing/
│   │   ├── Hero.tsx                  # Hero section for landing pages
│   │   ├── FeatureSection.tsx        # Feature showcase section
│   │   └── Footer.tsx                # Footer with links
│   └── auth/
│       ├── SignInForm.tsx            # Sign in form
│       └── SignUpForm.tsx            # Sign up form
├── styles/
│   └── globals.css                   # Global styles and animations
└── app/
    └── showcase/
        └── page.tsx                  # Component showcase page

```

## Theme Configuration

### Color System

The theme uses a functional color token system inspired by GitHub Primer:

#### Light Mode
- **Primary**: `#0969da` (GitHub blue)
- **Canvas**: `#ffffff` (default), `#f6f8fa` (subtle)
- **Border**: `#d0d7de` (default), `#d8dee4` (muted)
- **Text**: `#24292f` (primary), `#57606a` (secondary)

#### Dark Mode
- **Primary**: `#58a6ff` (lighter blue for dark backgrounds)
- **Canvas**: `#0d1117` (default), `#161b22` (subtle)
- **Border**: `#30363d` (default), `#21262d` (muted)
- **Text**: `#e6edf3` (primary), `#8b949e` (secondary)

### Typography

#### Font Families
- **UI Text**: System font stack (San Francisco, Segoe UI, etc.)
- **Greek Text**: Noto Serif for authenticity and readability
- **Code**: Monospace stack

#### Scale
- **h1**: 2rem (32px) - Page titles
- **h2**: 1.5rem (24px) - Section headers
- **h3**: 1.25rem (20px) - Subsection headers
- **h4**: 1rem (16px) - Card titles
- **body1**: 0.875rem (14px) - Default body text
- **body2**: 0.75rem (12px) - Secondary text

#### Custom Variants
- **greekBody**: Large, serif font for Greek text (1.125rem, line-height 1.8)
- **greekHelp**: Small sans-serif for interlinear help (0.75rem)
- **prose**: Content-optimized body text (1rem, line-height 1.7)

### Spacing

Based on an 8px grid:
- **0**: 0px
- **1**: 8px
- **2**: 16px
- **3**: 24px
- **4**: 32px
- **5**: 40px
- **6**: 48px

### Motion

Following Material Design 3 specifications:

#### Easing Functions
- **Emphasized** (default): `cubic-bezier(0.2, 0, 0, 1)` - 300ms
- **Standard** (utility): `cubic-bezier(0, 0, 0.2, 1)` - 150-200ms
- **Decelerate** (entering): `cubic-bezier(0, 0, 0.2, 1)` - 250ms
- **Accelerate** (exiting): `cubic-bezier(0.4, 0, 1, 1)` - 200ms

#### Duration Guidelines
- **Shortest**: 100ms - Icon rotations, toggles
- **Shorter**: 150ms - Hover states, focus rings
- **Short**: 200ms - Small element transitions
- **Standard**: 300ms - Default transitions
- **Complex**: 375ms - Multi-property transitions

## Component Usage

### Basic Example

```tsx
import { Button, Card, TextField } from '@/components';
import { ThemeProvider } from '@mui/material/styles';
import theme from '@/theme/theme';

function MyComponent() {
  return (
    <ThemeProvider theme={theme}>
      <Card title="Welcome">
        <TextField label="Name" />
        <Button variant="contained" color="primary">
          Submit
        </Button>
      </Card>
    </ThemeProvider>
  );
}
```

### Using Dark Mode

```tsx
'use client';

import { useColorScheme } from '@mui/material/styles';

function DarkModeToggle() {
  const { mode, setMode } = useColorScheme();
  
  return (
    <Button onClick={() => setMode(mode === 'light' ? 'dark' : 'light')}>
      Toggle {mode === 'light' ? 'Dark' : 'Light'} Mode
    </Button>
  );
}
```

### Application Layout

```tsx
import { AppShell } from '@/components/layout/AppShell';

function App({ children }) {
  return (
    <AppShell
      showNav
      navItems={[
        { icon: <HomeIcon />, label: 'Home', href: '/', active: true },
        { icon: <BookIcon />, label: 'Reader', href: '/reader' },
      ]}
      appBarContent={
        <Typography variant="h4">Koine Greek</Typography>
      }
    >
      {children}
    </AppShell>
  );
}
```

## Component Categories

### Input Components
- **Button**: Primary actions with variants (contained, outlined, text)
- **IconButton**: Actions with icon-only display
- **ButtonGroup**: Related actions grouped together
- **ToggleButton**: Mutually exclusive options
- **TextField**: Text input with validation and character count
- **Select**: Dropdown selection
- **Checkbox**: Binary selection with label
- **RadioGroup**: Single selection from multiple options
- **Switch**: Toggle on/off state
- **Fab**: Floating action button for primary actions

### Display Components
- **Card**: General-purpose content container
- **ProgressCard**: Card with integrated progress indicator
- **KoineCard**: Specialized card for Greek learning content
- **Alert**: Feedback messages (success, error, warning, info)
- **Dialog**: Modal dialogs for important actions
- **ProseBlock**: Formatted content container for articles/documentation

### Navigation Components
- **NavRail**: Fixed vertical navigation (desktop) / bottom bar (mobile)
- **AppShell**: Complete application layout with drawer and app bar

### Educational Components
- **MultipleChoice**: Quiz question with multiple options
- **GreekTextUnit**: Interactive Greek text with interlinear help
- **AcknowledgementButton**: Confirmation button with state

### Landing Page Components
- **Hero**: Large hero section with CTA buttons
- **FeatureSection**: Grid of feature cards
- **Footer**: Site footer with links and social media

### Authentication Components
- **SignInForm**: Email/password login form
- **SignUpForm**: Registration form with validation

## Accessibility Features

### Keyboard Navigation
- All interactive elements support keyboard navigation
- Focus indicators follow WCAG guidelines (2px outline with offset)
- Tab order is logical and predictable

### Screen Readers
- Semantic HTML elements (`nav`, `main`, `header`, `footer`)
- ARIA labels on icon-only buttons
- Proper heading hierarchy

### Color Contrast
- All text meets WCAG 2.2 AA standards (4.5:1 for normal text, 3:1 for large text)
- Interactive elements maintain contrast in all states
- Focus indicators are always visible

### Motion
- Respects `prefers-reduced-motion` media query
- Animations can be disabled for accessibility
- No motion-critical information (alternatives provided)

## Responsive Design

### Breakpoints
- **xs**: 0px - Mobile portrait
- **sm**: 640px - Mobile landscape
- **md**: 768px - Tablet
- **lg**: 1024px - Desktop
- **xl**: 1280px - Large desktop

### Mobile-First Approach
- Components are designed for mobile first
- Progressive enhancement for larger screens
- Touch targets meet minimum 44x44px standard
- Safe area insets for iOS devices

## Best Practices

### Component Composition
```tsx
// ✅ Good: Compose with existing components
<Card title="Lesson Progress">
  <ProgressCard progress={75} />
</Card>

// ❌ Avoid: Creating custom components from scratch
<div className="custom-card">
  <div className="custom-progress">...</div>
</div>
```

### Theme Tokens
```tsx
// ✅ Good: Use theme tokens
sx={{ color: 'primary.main', bgcolor: 'canvas.subtle' }}

// ❌ Avoid: Hardcoded colors
sx={{ color: '#0969da', bgcolor: '#f6f8fa' }}
```

### Spacing
```tsx
// ✅ Good: Use spacing scale
sx={{ p: 2, mt: 3, gap: 1 }}

// ❌ Avoid: Hardcoded pixels
sx={{ padding: '16px', marginTop: '24px', gap: '8px' }}
```

### Responsive Design
```tsx
// ✅ Good: Object syntax for breakpoints
sx={{ width: { xs: '100%', md: '50%' } }}

// ❌ Avoid: Media queries in sx
sx={{ '@media (min-width: 768px)': { width: '50%' } }}
```

## Performance Considerations

### Code Splitting
- Components are designed for tree-shaking
- Import only what you need
- Use dynamic imports for large components

### CSS Variables
- Theme uses CSS variables for instant switching
- No JavaScript re-renders on theme change
- Better performance than styled-components props

### Animations
- GPU-accelerated transforms
- Will-change for smooth animations
- RequestAnimationFrame for complex animations

## Testing

### Component Testing
```tsx
import { render, screen } from '@testing-library/react';
import { Button } from '@/components/inputs/Button';

test('button renders with text', () => {
  render(<Button>Click me</Button>);
  expect(screen.getByText('Click me')).toBeInTheDocument();
});
```

### Accessibility Testing
- Use `@axe-core/react` for automated accessibility testing
- Manual keyboard navigation testing
- Screen reader testing with NVDA/JAWS

## Migration Guide

### From Custom Components
1. Identify component equivalents in the design system
2. Replace hardcoded styles with theme tokens
3. Update props to match component interfaces
4. Test for visual and functional parity

### Adding New Components
1. Follow existing patterns and conventions
2. Use theme tokens for all colors and spacing
3. Include TypeScript interfaces with JSDoc
4. Add to showcase page with examples
5. Document accessibility considerations

## Common Patterns

### Loading States
```tsx
<Button loading={isSubmitting}>Submit</Button>
```

### Error Handling
```tsx
<TextField
  error={!!errors.email}
  helperText={errors.email?.message}
/>
<Alert severity="error" message={errorMessage} />
```

### Conditional Rendering
```tsx
{isSuccess && (
  <Alert severity="success" message="Saved successfully!" />
)}
```

### Form Validation
```tsx
const [errors, setErrors] = useState({});

const validate = () => {
  const newErrors = {};
  if (!email) newErrors.email = 'Email is required';
  setErrors(newErrors);
  return Object.keys(newErrors).length === 0;
};
```

## Resources

### External Documentation
- [Material UI v7 Documentation](https://mui.com/material-ui/getting-started/)
- [Material Design 3 Motion](https://m3.material.io/styles/motion/overview)
- [GitHub Primer Design](https://primer.style/)
- [WCAG 2.2 Guidelines](https://www.w3.org/WAI/WCAG22/quickref/)

### Internal Resources
- Component Showcase: `/showcase`
- Theme Configuration: `src/theme/theme.ts`
- Global Styles: `src/styles/globals.css`

## Support

For questions or issues with the design system:
1. Check the showcase page for usage examples
2. Review component documentation in source files
3. Consult Material UI v7 documentation for advanced features
4. Open an issue with details and reproduction steps

## Changelog

### v1.0.0 (2024)
- Initial design system release
- Complete component library
- Theme configuration with light/dark modes
- Material Design 3 motion specifications
- GitHub Primer-inspired visual design
- Full TypeScript support
- Accessibility features
- Mobile-first responsive design

---

**Design System Version**: 1.0.0  
**Material UI Version**: 7.x  
**Last Updated**: 2024
