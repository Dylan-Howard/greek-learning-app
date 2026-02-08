# Unified Backend Review

Date: 2026-02-08

Reviewer: Gemini

## 1. Summary

The new unified backend in the `@backend/` directory was reviewed for feature parity with the four existing microservices (`UserService`, `TextService`, `ReaderService`, `StudyService`) as per the `unified-backend-enhancements.md` plan.

**Conclusion: The rewrite is NOT approved for implementation.**

The project is in a highly incomplete state. While it has a sound architectural foundation based on Clean Architecture, the majority of the business logic and feature implementation is either missing entirely or consists of non-functional placeholder code. It is a skeleton of an application and is not ready to replace the existing services.

## 2. Findings by Service

### 2.1. UserService (`UsersController`, `ProgressController`)

*   **Status:** Highly Incomplete
*   **`POST /users` (User Creation):** **NOT IMPLEMENTED**. The controller method returns a `501 Not Implemented` status. This is a critical failure for feature parity.
*   **`GET /users/{id}/settings`:** **NOT IMPLEMENTED**.
*   **`GET /users/{id}/lessons` & `/words`:** The functionality for retrieving user progress on lessons and vocabulary has been moved to a new `ProgressController` under the `GET /api/progress` endpoint. While architecturally sound, this deviates from the specification document. The implementation in `ProgressController` appears functional, but it relies on data from the non-existent `TextService`.

### 2.2. TextService (Multiple Controllers)

*   **Status:** Not Implemented
*   **`LessonsController`:** The `GetAll`, `GetById`, and `Create` endpoints are **placeholders** that return hardcoded data. They are not connected to a database or a real service layer. The application's core content is therefore unavailable.
*   **`VocabularyController`:** Similar to the `LessonsController`, the `GetAll` and `GetById` endpoints are **placeholders**. More advanced, functional-looking methods for search, create, update, and delete are **commented out**, indicating an abandoned or incomplete implementation.
*   **Other Content Controllers:** It is assumed that the other content-related controllers (`BooksController`, `ChaptersController`, etc.) are in a similar placeholder state. The `TextService` functionality is effectively non-existent.

### 2.3. ReaderService (`ReaderController`)

*   **Status:** Partially Implemented (Blocked)
*   The `ReaderController` itself is well-implemented. It uses a clean, RESTful `GET` endpoint and correctly delegates logic to a service layer (`IReaderService`). This is the most promising part of the new backend.
*   **Major Risk:** This service is fundamentally dependent on data from the `UserService` and `TextService`. Since those services are not implemented, the `ReaderService` is **guaranteed to fail** in its current state. It cannot "render" a chapter without lessons, words, and user progress.

### 2.4. StudyService

*   **Status:** Not Implemented
*   The plan required a new `StudyController` to be created to handle vocabulary sets. This controller **does not exist**, and there is no evidence that any work has been started on this feature.

## 3. Recommendations

The unified backend cannot be implemented. It would result in a complete loss of application functionality. The following actions are required before another review:

1.  **Implement Core Data Services:** The highest priority is to fully implement the business logic and data access for the `TextService`. The application cannot function without its content. All placeholder code in the controllers must be replaced with calls to a functional service layer.
2.  **Complete the UserService:** The critical `POST /users` endpoint for user creation must be implemented. Endpoints for user settings should also be completed.
3.  **Update Documentation:** The enhancement plan must be updated to reflect the architectural decision to create a `ProgressController`. The reasoning for this deviation should be documented.
4.  **Test the ReaderService:** Once the underlying data services are functional, the `ReaderService` must be thoroughly tested to ensure its complex orchestration and text-rendering logic works as expected.
5.  **Implement the StudyService:** The planned `StudyController` and associated vocabulary set features must be implemented.
6.  **Code Cleanup:** The commented-out code in `VocabularyController` should be either completed and enabled or removed to avoid confusion.

This project requires significant implementation effort to reach a state of minimum viability. It is not approved to move forward.
