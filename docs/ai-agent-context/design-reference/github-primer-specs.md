# GitHub Primer Design System Reference

## Color Palette
Primer uses a functional token system that adapts to themes (Light, Dark, Dimmed).

### Functional Tokens
- `fgColor-default`: Primary text color.
- `bgColor-default`: Primary background.
- `bgColor-muted`: Secondary background (e.g., sidebars).
- `borderColor-default`: Standard 1px border.
- `accent-emphasis`: Primary brand color for important actions.

## Spacing Scale
Primer follows a **base-8 spacing scale**.

| Token | Value |
| :--- | :--- |
| `spacer-1` | 4px |
| `spacer-2` | 8px |
| `spacer-3` | 16px |
| `spacer-4` | 24px |
| `spacer-5` | 32px |
| `spacer-6` | 40px |

## Border Styles
- **Width:** Default is `1px`.
- **Radius:**
  - `rounded-1`: 4px (labels, small buttons).
  - `rounded-2`: 6px (standard buttons, inputs, cards).
  - `rounded-3`: 8px (larger containers).
  - `circle`: 50% (avatars).

## UI Patterns
1. **Blankslate:** For empty states. Uses `bgColor-muted`, centered text, and a call-to-action button.
2. **Flash:** For global banners. `success`, `warning`, or `error` variants.
3. **ActionList:** Standard menu/list pattern with icons and labels.
4. **UnderlineNav:** Navigation pattern using underlines for active states.

## Reference URLs
- [Primer Design System](https://primer.style/)
- [Primer Primitives (Tokens)](https://primer.style/primitives)
- [Primer CSS Documentation](https://primer.style/css)
