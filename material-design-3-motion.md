# Material Design 3 Motion Specifications

## Easing Functions
M3 introduces the **Emphasized** easing set as the default for most transitions to capture a natural, expressive style.

| Easing Type | Usage | Description |
| :--- | :--- | :--- |
| **Emphasized** | Default / Most transitions | Complex, multi-stage curve for expressive movement. |
| **Standard** | Small utility transitions | Simple, symmetrical curve for quick, functional changes. |
| **Decelerate** | Entering the screen | Starts fast and slows down to a stop. |
| **Accelerate** | Exiting the screen | Starts slow and speeds up as it leaves. |

## Duration Guidelines
Durations in M3 are generally longer than in M2 to accommodate the natural easing curves.

| Transition Type | Emphasized (Rec.) | Standard (Utility) |
| :--- | :--- | :--- |
| **Begin & End on screen** | 500ms | 300ms |
| **Enter the screen** | 400ms | 250ms |
| **Exit the screen** | 200ms | 200ms |

*Note: For desktop, durations should be **30-50% faster** (150ms–200ms) to maintain responsiveness on larger displays.*

## Interaction Guidelines
### Hover States
- **Scale**: Use subtle scaling (e.g., `1.02x` or `1.05x`) for interactive elements.
- **Overlay**: Use a semi-transparent overlay (e.g., `primary.main` with 0.08 alpha) for hover highlights.

### Transitions
- **Immediate Response**: Animations should start within 10ms of user input.
- **Natural Rest**: Objects should feel like they have weight, slowing down smoothly using the decelerate easing.

## Implementation in MUI
MUI allows custom transitions via the `transitions` key in `createTheme`.

```typescript
const theme = createTheme({
  transitions: {
    easing: {
      easeInOut: 'cubic-bezier(0.4, 0, 0.2, 1)', // Emphasized default
      easeOut: 'cubic-bezier(0.0, 0, 0.2, 1)', // Decelerate
      easeIn: 'cubic-bezier(0.4, 0, 1, 1)', // Accelerate
      sharp: 'cubic-bezier(0.4, 0, 0.6, 1)',
    },
    duration: {
      shortest: 150,
      shorter: 200,
      short: 250,
      standard: 300,
      complex: 375,
      enteringScreen: 225,
      leavingScreen: 195,
    },
  },
});
```
