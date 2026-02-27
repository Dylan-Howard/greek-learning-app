# MUI v7 Component API References

## Global Changes in v7
- **Grid:** `Grid` now refers to the newer `Grid2`. `GridLegacy` is the old version.
- **Slots:** `components` and `componentsProps` are replaced by `slots` and `slotProps`.
- **Sizes:** `size="normal"` is removed; use `size="medium"`.

## Core Components

### Button
- **Variants:** `text`, `contained`, `outlined`.
- **Colors:** `primary`, `secondary`, `success`, `error`, `info`, `warning`, `inherit`.
- **Standardization:** `startIcon` and `endIcon` are the primary way to add icons.

### TextField
- **Variants:** `outlined`, `filled`, `standard`.
- **v7 Slots:** Use `slotProps.input` and `slotProps.inputLabel` for internal customization.
- **Error State:** Use the `error` prop and `helperText` for validation messages.

### Card
- **Structure:** `CardHeader`, `CardMedia`, `CardContent`, `CardActions`.
- **v7 Update:** `CardHeader` uses slots for `avatar`, `action`, `title`, and `subheader`.

### AppBar
- **Positions:** `fixed`, `absolute`, `sticky`, `static`, `relative`.
- **v7 Update:** Better support for `inherit` color CSS variables and standard slot patterns for layout elements.

### Drawer
- **Variants:** `temporary`, `persistent`, `permanent`.
- **v7 Slots:** 
  - `ModalProps` -> `slotProps.modal`
  - `PaperProps` -> `slotProps.paper`
  - `TransitionComponent` -> `slots.transition`

## Reference URLs
- [MUI Component API](https://mui.com/material-ui/api/button/)
- [MUI v7 Breaking Changes](https://mui.com/material-ui/migration/v6-to-v7/#breaking-changes)
