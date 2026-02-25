# Unified Backend Enhancement Plan

This document outlines the necessary enhancements to consolidate the existing backend microservices into the new unified `@backend/` project.

## 1. API Endpoint Implementation

The API surface of the unified backend must be compatible with the calls made by the `@GreekLearningApp-Frontend/`. The controllers in `Koine.API` must be updated to match the routes and data contracts of the existing microservices.

**Action Items:**

*   **2.1. User API:** Implement all user-related endpoints from `GreekLearningApp-UserService` in a `UsersController`.
    *   `GET /users/{id}`
    *   `POST /users`
    *   `PUT /users/{id}`
    *   `GET /users/{id}/lessons`
    *   `GET /users/{id}/words`
    *   `GET /users/{id}/settings`
*   **2.2. Text API:** Implement all content-related endpoints from `GreekLearningApp-TextService` in the relevant controllers (`LessonsController`, `TextsController`, `WordsController`, etc.). This is the largest set of endpoints and includes GET and POST/UPDATE for numerous resources.
*   **2.3. Reader API:** Implement the `GET /reader/page` endpoint from `GreekLearningApp-ReaderService` in the `ReaderController`.
*   **2.4. Study API:** Create a new `StudyController` to handle the "Coming Soon" vocabulary sets feature.
    *   `GET /users/{id}/sets`
    *   `GET /sets/{id}`

## 3. Business Logic Porting & Implementation

The business logic from the existing services must be ported to C# and integrated into the `Koine.Application` layer.

**Action Items:**

*   **3.1. Port ReaderService Logic:** The core logic of the Go-based `ReaderService` needs to be analyzed, translated to C#, and implemented in a `ReaderService.cs` in the `Koine.Application/Services` directory. This service will be responsible for composing the personalized reader pages.
*   **3.2. Implement Service Logic:** Implement the application services required by the new controllers (e.g., `UserService`, `TextService`, `StudyService`). These services will contain the business logic for interacting with the database and performing operations.

## 4. Authentication & Authorization

The unified backend will handle authentication and authorization for the entire application.

**Action Items:**

*   **4.1. Authentication Strategy:** Implement a single, consistent authentication strategy (e.g., JWT-based) for all endpoints.
*   **4.2. Authorization Policies:** Define and implement authorization policies to ensure that users can only access their own data and that administrative endpoints are protected.

## 5. Frontend Integration

The frontend application will need to be updated to point to the new unified backend.

**Action Items:**

*   **5.1. Update API Base URL:** Change the `NEXT_PUBLIC_API_URL` in the frontend's environment variables to point to the new unified backend's URL.
*   **5.2. API Client Regeneration:** If the unified backend generates a client library (e.g., via NSwag), regenerate it and update the frontend's API service files. If not, manually update the frontend services (`AzureUserService.ts`, etc.) to align with any changes in the API contracts. Given the plan is to match the existing contracts, this may be minimal.
*   **5.3. Rename Frontend Services:** For clarity, rename the frontend service files from `Azure*.ts` to something more appropriate, like `api.ts` or split by domain (`userService.ts`, `textService.ts`).

This plan provides a high-level overview of the tasks required to unify the backend services. Each action item will require further detailed planning and implementation.
