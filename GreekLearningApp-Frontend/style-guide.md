# Frontend Style Guide (Design System)

## Component Usage
- Use `@/components/ui` wrappers for interactive and reusable display primitives:
  - `Button`, `Fab`, `TextField`, `IconButton`, alert/dialog wrappers where applicable.
- Keep direct `@mui/material` usage for low-level layout and specialized primitives:
  - `Box`, `Stack`, `Grid`, `Container`, table primitives, and niche controls.

## Theme Tokens
- Prefer semantic token references over literals:
  - Colors: `primary.main`, `text.secondary`, `background.default`, custom tokens like `border.default`.
  - Spacing: numeric spacing scale (`p: 2`, `mt: 4`) where possible.
- Avoid hardcoded hex values in `sx` unless explicitly required.

## Typography
- Prefer theme variants (`h1`-`h6`, `body1`, `body2`, `caption`) over numeric `fontSize` literals.

## Theming Safety
- For style callbacks using `theme.vars`, always provide a fallback:
  - `const palette = theme.vars?.palette ?? theme.palette;`
