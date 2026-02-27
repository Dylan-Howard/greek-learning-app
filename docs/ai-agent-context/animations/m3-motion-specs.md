# Material Design 3 Motion Specifications

## Easing (Timing Functions)
M3 uses two primary sets of easing: **Emphasized** and **Standard**.

| Token | Cubic Bezier | Description |
| :--- | :--- | :--- |
| `emphasized` | `(0.05, 0.7, 0.1, 1.0)` | Default for M3. Snappy start, soft landing. |
| `emphasized.decelerate` | `(0.05, 0.7, 0.1, 1.0)` | Used for elements entering the screen. |
| `emphasized.accelerate` | `(0.3, 0.0, 0.8, 0.15)` | Used for elements exiting the screen. |
| `standard` | `(0.2, 0.0, 0, 1.0)` | For simple utility transitions. |

## Duration Tokens
| Token | Duration | Use Case |
| :--- | :--- | :--- |
| `short1-4` | 50ms - 200ms | Small components (switches, tooltips). |
| `medium1-4` | 250ms - 400ms | Medium components (menus, snackbars). |
| `long1-4` | 450ms - 600ms | Large transitions (full-screen, dialogs). |

## Common Transition Patterns

### 1. Container Transform
- **Easing:** `emphasized`
- **Duration:** `long2` (500ms) or `long4` (600ms).
- **Goal:** Morphing a small element (card) into a large one (details page).

### 2. Enter / Exit
- **Enter:** `emphasized.decelerate` + `medium4` (400ms).
- **Exit:** `emphasized.accelerate` + `short4` (200ms).
- **Note:** Exits are faster to avoid blocking the user.

### 3. Shared Axis
- **Easing:** `emphasized`
- **Duration:** `medium2` (300ms).
- **Goal:** Transitioning between peer elements (e.g., onboarding steps).

## Interaction States
- **Hover:** 8% state layer opacity (usually `primary` or `onSurface`).
- **Focus:** 10% state layer opacity + 2dp outline.
- **Pressed:** 10% state layer opacity + Ripple effect.

## Reference URLs
- [Material Design 3 Motion Guidelines](https://m3.material.io/styles/motion/overview)
- [M3 Motion Tokens](https://m3.material.io/styles/motion/tokens)
