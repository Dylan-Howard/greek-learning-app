# AI Agent UI Design Context

This directory contains consolidated documentation for an AI agent to design UI components using Material UI v7, following Material Design 3 motion principles and GitHub Primer design aesthetics.

## Directory Structure

- [theming/](./theming/mui-v7-theming.md): MUI v7 theme configuration, TypeScript module augmentation, and styling approaches.
- [components/](./components/mui-v7-components.md): API summaries for core MUI components (Button, TextField, Card, etc.) updated for v7.
- [animations/](./animations/m3-motion-specs.md): Material Design 3 motion specifications, including easing and duration tokens.
- [design-reference/](./design-reference/github-primer-specs.md): GitHub Primer design system tokens for color, spacing, and borders.

## High-Level Guidance for the Agent
1. **Prefer Native ESM:** Use top-level imports from `@mui/material`.
2. **Use Slot API:** Always use `slots` and `slotProps` for internal component customization in MUI v7.
3. **Typography & Spacing:** Follow the GitHub Primer base-8 scale for layout and M3 typography for content.
4. **Motion:** Apply M3 "Emphasized" easing for expressive transitions and "Standard" for utility interactions.
5. **TypeScript:** Ensure all custom theme properties are properly augmented via interfaces.

## Key Reference Links
- [MUI Documentation](https://mui.com/)
- [Material Design 3](https://m3.material.io/)
- [GitHub Primer](https://primer.style/)
