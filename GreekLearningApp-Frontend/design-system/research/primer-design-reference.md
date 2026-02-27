# GitHub Primer Design Reference

## Color Palette & Usage Guidelines
Primer uses a **functional color system** based on design tokens. This is the primary recommendation for the new design system.

### Functional Token Layers
- **Text (`fg`)**: `fg.default`, `fg.muted`, `fg.subtle`.
- **Background (`canvas`)**: `canvas.default`, `canvas.subtle`, `canvas.inset`.
- **Border (`border`)**: `border.default`, `border.muted`.

### Semantic Color Usage
- **Success**: Use `success.fg` and `success.emphasis` for positive results.
- **Danger**: Use `danger.fg` and `danger.emphasis` for errors or destructive actions.
- **Attention**: Use `attention.fg` and `attention.emphasis` for warnings.

## Spacing Scale
Primer follows an **8px grid** system (with 4px for fine-grained spacing).

| Token | Value | Shorthand |
| :--- | :--- | :--- |
| `space-1` | 4px | `p: 0.5` |
| `space-2` | 8px | `p: 1` |
| `space-3` | 16px | `p: 2` |
| `space-4` | 24px | `p: 3` |
| `space-5` | 32px | `p: 4` |
| `space-6` | 40px | `p: 5` |

### Layout Rhythm
- **Containers**: Use `space-3` (16px) or `space-4` (24px) for inner container padding.
- **Stacking**: Use `space-2` (8px) for stacking closely related items and `space-3` (16px) for distinct sections.

## Typography System
Primer prioritizes readability and clean hierarchy using system fonts for performance.

### Font Stacks
- **Standard**: `-apple-system, BlinkMacSystemFont, "Segoe UI", Helvetica, Arial, sans-serif, "Apple Color Emoji", "Segoe UI Emoji"`
- **Mono**: `ui-monospace, SFMono-Regular, "SF Mono", Menlo, Consolas, "Liberation Mono", monospace`

### Typography Scale
- **Base Size**: 14px or 16px (1rem) for body text.
- **Line Height**: 1.5 for body text, 1.25 for headings.
- **Weights**: Regular (400), Medium (500), Semi-bold (600).

## Component Design Patterns
- **Cards**: Use `canvas.default` with a `border.default` and no shadow for a "flat" GitHub look, or a very subtle shadow for emphasis.
- **Buttons**: Consistent border radius (6px), centered text, and clear hover/active states using functional color tokens.
- **Sidebars**: Use `canvas.subtle` for sidebar backgrounds to distinguish from the main content.

## Accessibility Considerations
- **Contrast**: Ensure all functional color tokens meet **WCAG 2.2 AA** contrast standards.
- **Focus Indicators**: Always provide a clear visual indicator for keyboard focus, often a 2px blue outline.
- **Semantic HTML**: Use correct tags (`nav`, `main`, `header`, `footer`) to ensure screen reader compatibility.
