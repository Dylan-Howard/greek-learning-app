For the unified Greek Learning App, we will move away from manual `any`-typed fetching and adopt an **automated, contract-first type generation strategy** using the backend's OpenAPI (Swagger) definition as the single source of truth.

---

### 1. Type Generation Approach

#### **Strategy: Automated Build-Time Generation**
We will use **`swagger-typescript-api`** or **`nswag`** to generate a complete TypeScript client and type definitions.

*   **Approach:** Build-time generation. Types are updated whenever the backend API changes, ensuring the frontend is immediately aware of breaking changes.
*   **Workflow:** 
    1.  Backend builds and exposes `swagger.json`.
    2.  Frontend runs a pre-build script: `npm run generate-api`.
    3.  A unified `api.ts` file is generated containing all Request/Response interfaces and a typed Fetch/Axios client.
*   **Versioning:** Types will be versioned alongside the API (`v1`, `v2`). We will generate separate namespaces for each major version to allow for a gradual migration.

---

### 2. Core Types Structure (Generated)

The generated `api.ts` will follow this structure to ensure type safety across the entire application:

#### **Units & Tokens (The Critical JSON Schema)**
The frontend must perfectly match the backend's optimized JSON storage format.
```typescript
/** 
 * Matches the optimized JSON column in the Chapters table.
 * Uses short keys for payload efficiency.
 */
export interface UnitToken {
  id: string;      // Guid
  p: number;       // Placement
  c: string;       // Content (Greek Word)
  m: number;       // MorphologyId
  v: number;       // VerseId
  r?: string;      // RootContent (Optional Hint)
}

export interface ChapterUnits {
  tokens: UnitToken[];
}
```

#### **Domain & Response Models**
```typescript
export interface TextResponse {
  id: number;
  bookId: number;
  title: string;
  chapters: ChapterSummary[];
}

export interface UserProfile {
  id: string;
  email: string;
  username: string;
  settings: UserSettings;
  progress: UserProgress;
}

export interface UserProgress {
  lessons: { id: number; isComplete: boolean }[];
  vocabulary: { id: number; isComplete: boolean }[];
}
```

#### **Pagination & Global Error Handling**
```typescript
export interface PagedResponse<T> {
  items: T[];
  pageNumber: number;
  pageSize: number;
  totalCount: number;
  totalPages: number;
}

/** RFC 7807 Problem Details for consistent error handling */
export interface ApiError {
  type: string;
  title: string;
  status: number;
  detail: string;
  instance?: string;
  errors?: Record<string, string[]>; // Validation errors
}
```

---

### 3. Usage Pattern in Next.js

By automating this, the `AzureTextService.ts` (which should be renamed to `TextService.ts`) becomes much cleaner and type-safe:

```typescript
// Proposed refactor using generated types
import { ApiClient, TextResponse, ChapterUnits } from '@/api/generated';

const client = new ApiClient({ baseUrl: process.env.NEXT_PUBLIC_API_URL });

export async function fetchText(id: number): Promise<TextResponse> {
  const response = await client.v1.texts.getById(id);
  return response.data; // Fully typed as TextResponse
}

export async function fetchChapterUnits(chapterId: number): Promise<ChapterUnits> {
  const response = await client.v1.texts.getUnits(chapterId);
  return response.data; // Fully typed, including the JSON-mapped Tokens
}
```

### Benefits of this Strategy
1.  **Zero Manual Mapping:** No more `JSON.parse()` or manual interface maintenance.
2.  **Compile-Time Safety:** If a field name changes in the C# backend, the TypeScript build will fail, preventing runtime "undefined" bugs.
3.  **Intellisense:** Developers get full autocompletion for the complex `UnitToken` and `Morphology` structures directly in the IDE.