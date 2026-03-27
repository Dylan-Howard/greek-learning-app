# Frontend

## Docker Workflows

### 1. Production Build Validation (used by root compose)
From the repository root:

```bash
docker compose build frontend
```

This uses the frontend `Dockerfile` multi-stage build and runs `npm run build` during image creation.

### 2. Full Stack Build Validation
From the repository root:

```bash
docker compose build
```

### 3. Frontend Local Dev Server (hot reload)
From `frontend/`:

```bash
docker compose -f docker-compose.dev.yml up --build
```

Stop the dev workflow:

```bash
docker compose -f docker-compose.dev.yml down
```

## Local Non-Docker Commands

```bash
npx tsc --noEmit
npm run build
npm run test
```

## Storybook (Developer Only)

Storybook is a local developer resource for browsing components and layouts. It is not part of the public app.

```bash
npm run storybook
```
