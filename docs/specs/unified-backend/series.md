# Greek Learning App: Microservices to Monolith Refactoring - Evaluation Prompts

## Phase 1: Discovery & Feature Inventory

### Prompt 1.1: ReaderService Feature Audit (Go)
```
Analyze the GreekLearningApp-ReaderService (Go) codebase and provide:

1. **API Endpoints Inventory**
   - List all HTTP endpoints with methods (GET/POST/PUT/DELETE)
   - Document request/response schemas
   - Identify authentication/authorization requirements
   - Note any middleware or interceptors

2. **Core Business Logic**
   - Identify domain models and their relationships
   - Document key business rules and validation logic
   - List any external service dependencies
   - Identify data access patterns

3. **Database Interactions**
   - Document all database tables accessed
   - List queries and their purposes
   - Identify transaction boundaries
   - Note any stored procedures or raw SQL

4. **Key Features**
   - Reading session management
   - Text parsing and word analysis
   - User progress tracking
   - Any caching mechanisms

5. **Edge Cases & Error Handling**
   - Document error scenarios
   - Identify retry logic or circuit breakers
   - Note any rate limiting

Please structure the response as a detailed feature matrix with current implementation details.
```

### Prompt 1.2: TextService Feature Audit (C#)
```
Analyze the GreekLearningApp-TextService (.NET) codebase and provide:

1. **API Endpoints Inventory**
   - List all controllers and action methods
   - Document DTOs and request/response models
   - Identify filter, middleware, and attribute usage
   - Note authentication/authorization policies

2. **Core Business Logic**
   - Document domain entities and value objects
   - List business services and their responsibilities
   - Identify any domain events or messaging
   - Document validation rules (FluentValidation, Data Annotations)

3. **Database Interactions**
   - Document Entity Framework models and configurations
   - List DbContext operations
   - Identify any LINQ queries or stored procedures
   - Note migration history and schema changes

4. **Key Features**
   - Text management (CRUD operations)
   - Text parsing and tokenization
   - Metadata management (difficulty, tags, etc.)
   - Text search and filtering

5. **Units Data Model** (CRITICAL)
   - Document current "units" table structure
   - Identify all queries that fetch units data
   - List relationships with other entities
   - Note query patterns and frequency
   - Identify any performance concerns with current model

Please provide code samples for complex logic that needs preservation.
```

### Prompt 1.3: UserService Feature Audit (C#)
```
Analyze the GreekLearningApp-UserService (.NET) codebase and provide:

1. **API Endpoints Inventory**
   - List all user-related endpoints
   - Document authentication endpoints (login, register, refresh)
   - Identify profile management endpoints
   - Note any admin or privileged endpoints

2. **Core Business Logic**
   - Document user entity and related models
   - List authentication/authorization logic
   - Identify password hashing and security measures
   - Document user preferences and settings management

3. **Database Interactions**
   - Document user-related tables
   - List user progress/statistics tracking
   - Identify any user-text relationships
   - Note soft delete or audit trail patterns

4. **Key Features**
   - User registration and authentication
   - Profile management
   - User progress tracking
   - Role-based access control (if applicable)
   - User preferences and settings

5. **Security & Compliance**
   - JWT token generation and validation
   - Password policies
   - Session management
   - Any GDPR or data privacy considerations

Please include authentication flow diagrams and security-critical code.
```

### Prompt 1.4: Frontend API Contract Analysis
```
Analyze the GreekLearningApp-FrontendService codebase and provide:

1. **Current API Integration Points**
   - List all API calls to ReaderService
   - List all API calls to TextService
   - List all API calls to UserService
   - Document request/response formats for each

2. **Frontend Data Models**
   - List TypeScript interfaces/types used
   - Identify any API client libraries or utilities
   - Document state management patterns (Redux, Context, etc.)

3. **API Call Patterns**
   - Identify common fetch/axios patterns
   - Note error handling approaches
   - Document loading states and retry logic
   - List any optimistic updates or caching

4. **Type Safety Gaps**
   - Identify areas lacking type definitions
   - Note any 'any' types used for API responses
   - Document manual type assertions or casts

5. **Feature-to-Endpoint Mapping**
   - Create a matrix mapping UI features to backend endpoints
   - Identify any unused endpoints
   - Note any client-side business logic that should move to backend

Please provide examples of current API utility functions and their usage.
```

---

## Phase 2: Hexagonal Architecture Design

### Prompt 2.1: Domain Layer Design
```
Based on the feature audits from Phase 1, design the Domain Layer for the monolithic backend:

1. **Aggregate Roots & Entities**
   - Define User aggregate (with embedded preferences)
   - Define Text aggregate (with metadata)
   - Define ReadingSession aggregate
   - Define Units as JSON value object
   - Identify aggregate boundaries

2. **Value Objects**
   - Design Units value object (for JSON storage)
   - Design TextMetadata value object
   - Design UserProgress value object
   - Define any other immutable domain concepts

3. **Domain Services**
   - TextParser service (for tokenization)
   - ProgressCalculator service
   - Units serialization/deserialization service

4. **Domain Events** (if applicable)
   - TextCreated, TextUpdated
   - ReadingSessionCompleted
   - UserProgressUpdated

5. **Units JSON Schema Design** (CRITICAL)
   - Define JSON structure for units data
   - Design efficient query patterns for JSON column
   - Consider indexing strategies (JSON path, computed columns)
   - Provide migration strategy from table-based to JSON-based storage

Provide C# code examples using records, value objects, and domain-driven design patterns.
```

### Prompt 2.2: Application Layer Design
```
Design the Application Layer (Use Cases) for the monolith:

1. **Command Handlers** (Write Operations)
   - CreateTextCommand & Handler
   - UpdateTextCommand & Handler
   - CreateUserCommand & Handler
   - StartReadingSessionCommand & Handler
   - UpdateUserProgressCommand & Handler

2. **Query Handlers** (Read Operations)
   - GetTextByIdQuery & Handler
   - ListTextsQuery & Handler (with filtering, pagination)
   - GetUserProgressQuery & Handler
   - GetReadingSessionQuery & Handler

3. **DTOs & Request/Response Models**
   - Design command/query DTOs
   - Design response models
   - Map domain entities to DTOs (consider AutoMapper)

4. **Validation**
   - Define FluentValidation rules for each command
   - Design validation pipeline

5. **Units Query Optimization**
   - Design efficient queries for JSON units column
   - Consider EF Core JSON support or raw SQL where needed
   - Plan for indexes and performance monitoring

Provide C# code examples using MediatR or similar CQRS pattern implementation.
```

### Prompt 2.3: Infrastructure Layer Design
```
Design the Infrastructure Layer (Adapters) for the monolith:

1. **Database Repositories**
   - IUserRepository interface and implementation
   - ITextRepository interface and implementation
   - IReadingSessionRepository interface and implementation
   - Repository base class with common operations

2. **EF Core DbContext**
   - Design unified DbContext
   - Define entity configurations (Fluent API)
   - Configure Units as JSON column (with value conversion)
   - Design migration strategy from multiple DBs to single DB

3. **External Services Adapters** (if any)
   - Email service adapter
   - Logging adapter
   - Caching adapter (Redis, Memory)

4. **Units Storage Implementation** (CRITICAL)
   - Implement Units JSON serialization/deserialization
   - Create EF Core value converter for Units
   - Design indexes for JSON column queries
   - Implement efficient query methods in repository

5. **Persistence Concerns**
   - Transaction management
   - Concurrency handling
   - Connection resilience

Provide C# code examples with EF Core 8+ features, including JSON column support.
```

### Prompt 2.4: API Layer Design (Controllers)
```
Design the API Layer (REST Controllers) for the monolith:

1. **Controller Structure**
   - UsersController (authentication, profile, preferences)
   - TextsController (CRUD, search, filtering)
   - ReadingSessionsController (sessions, progress)
   - Design RESTful endpoint naming conventions

2. **Unified API Versioning**
   - Define versioning strategy (URL, header, query string)
   - Plan for backward compatibility during migration

3. **API Documentation**
   - Design Swagger/OpenAPI specification
   - Include examples and descriptions
   - Document authentication requirements

4. **Cross-Cutting Concerns**
   - Authentication middleware (JWT)
   - Authorization policies
   - Global exception handling
   - Request/response logging
   - CORS configuration

5. **Performance Considerations**
   - Response compression
   - Pagination standards
   - ETag support for caching
   - Query optimization for Units JSON fields

Provide C# code examples for controllers with proper attribute routing, validation, and error handling.
```

---

## Phase 3: Frontend API Utility Design

### Prompt 3.1: TypeScript Type Generation
```
Design a TypeScript type generation strategy for the unified API:

1. **Type Generation Approach**
   - Evaluate NSwag, OpenAPI Generator, or manual approach
   - Define build-time vs. runtime type generation
   - Establish versioning strategy for types

2. **Core Types Structure**
   ```typescript
   // Define structure for:
   - API request types (e.g., CreateTextRequest)
   - API response types (e.g., TextResponse)
   - Domain model types (e.g., Text, User, ReadingSession)
   - Pagination/filtering types
   - Error response types
   - Units type (matching backend JSON schema)
   ```

3. **Type Safety Enhancements**
   - Use discriminated unions for API results (success/error)
   - Define strict null checking patterns
   - Use branded types for IDs

4. **Generation Configuration**
   - Configure generator to produce idiomatic TypeScript
   - Define naming conventions
   - Handle enums properly
   - Configure JSON serialization (camelCase vs PascalCase)

Provide example generated types and configuration files.
```

### Prompt 3.2: Unified API Client Design
```
Design a unified, type-safe API client utility for the frontend:

1. **Base HTTP Client**
   ```typescript
   // Design ApiClient class with:
   - Configurable base URL
   - Automatic JWT token attachment
   - Request/response interceptors
   - Retry logic with exponential backoff
   - Timeout configuration
   - Cancellation token support (AbortController)
   ```

2. **Typed API Methods**
   ```typescript
   // Design resource-specific clients:
   - UserApiClient (login, register, getProfile, updateProfile)
   - TextApiClient (getTexts, getTextById, createText, updateText)
   - ReadingSessionApiClient (start, update, getProgress)
   
   // Each method should:
   - Accept typed request parameters
   - Return typed Promise<ApiResult<T>>
   - Handle errors consistently
   ```

3. **Result Type Design**
   ```typescript
   type ApiResult<T> = 
     | { success: true; data: T; }
     | { success: false; error: ApiError; };

   interface ApiError {
     message: string;
     statusCode: number;
     validationErrors?: Record<string, string[]>;
   }
   ```

4. **React Integration**
   - Design custom hooks (useApi, useQuery, useMutation)
   - Handle loading/error states
   - Integrate with React Query or SWR (optional)
   - Provide examples of usage in components

5. **Error Handling Strategy**
   - Global error interceptor
   - Token refresh logic
   - Network error recovery
   - User-friendly error messages

Provide complete TypeScript code implementation with examples.
```

### Prompt 3.3: API Client Testing Strategy
```
Design a testing strategy for the unified API client:

1. **Unit Tests**
   - Test individual API client methods
   - Mock HTTP responses
   - Test error handling paths
   - Test retry logic

2. **Mock Service Setup**
   - Design MSW (Mock Service Worker) handlers
   - Create mock data factories
   - Implement realistic API responses

3. **Integration Tests**
   - Test API client with actual backend (in test environment)
   - Verify type correctness
   - Test authentication flows

4. **Type Safety Tests**
   - Ensure compile-time type checking catches errors
   - Test that runtime data matches expected types

Provide Jest/Vitest test examples and MSW configuration.
```

---

## Phase 4: Migration & Feature Parity Verification

### Prompt 4.1: Data Migration Strategy
```
Design a comprehensive data migration strategy:

1. **Database Consolidation**
   - Plan migration from 3 separate DBs to 1 unified DB
   - Design migration scripts (T-SQL or EF migrations)
   - Handle foreign key relationships across services
   - Preserve data integrity

2. **Units Table to JSON Column Migration** (CRITICAL)
   ```sql
   -- Design migration script to:
   - Read existing units table data
   - Transform to JSON format
   - Populate new JSON column in parent table
   - Verify data integrity
   - Create necessary indexes for JSON queries
   - Provide rollback strategy
   ```

3. **Data Validation**
   - Design validation queries to verify migration accuracy
   - Compare record counts before/after
   - Validate Units JSON structure
   - Verify all relationships are preserved

4. **Migration Execution Plan**
   - Define maintenance window requirements
   - Create step-by-step migration checklist
   - Plan for rollback scenarios
   - Design monitoring during migration

5. **Performance Testing Post-Migration**
   - Compare query performance (table-based vs JSON)
   - Identify any performance regressions
   - Optimize slow queries

Provide migration scripts, validation queries, and rollback procedures.
```

### Prompt 4.2: Feature Parity Test Suite
```
Create a comprehensive test plan to verify feature parity:

1. **Functional Test Cases**
   For each feature identified in Phase 1, create test cases:
   
   **User Management**
   - [ ] User registration with validation
   - [ ] User login and JWT token generation
   - [ ] Profile retrieval
   - [ ] Profile update
   - [ ] Password change
   - [ ] User preferences management

   **Text Management**
   - [ ] Create text with metadata
   - [ ] Retrieve text by ID
   - [ ] List texts with filtering (difficulty, tags)
   - [ ] Update text
   - [ ] Delete text
   - [ ] Search texts
   - [ ] Text parsing/tokenization

   **Reading Sessions**
   - [ ] Start reading session
   - [ ] Update progress
   - [ ] Complete session
   - [ ] Retrieve session history
   - [ ] Progress statistics

   **Units Queries** (CRITICAL)
   - [ ] Retrieve units as JSON
   - [ ] Filter/query within JSON structure
   - [ ] Performance matches or exceeds table-based queries
   - [ ] Complex queries involving units work correctly

2. **Integration Tests**
   - Test end-to-end flows
   - Verify database transactions
   - Test authentication/authorization
   - Verify Units JSON querying

3. **API Contract Tests**
   - Verify frontend expectations match backend responses
   - Test error responses match expected format
   - Validate all required fields are present

4. **Performance Tests**
   - Benchmark critical endpoints
   - Compare with microservices performance
   - Test under load
   - Verify Units JSON query performance

Provide xUnit test examples with proper setup/teardown and assertions.
```

### Prompt 4.3: Frontend Integration Verification
```
Verify frontend integration with the new monolith backend:

1. **API Client Integration Tests**
   - Test all API methods from unified client
   - Verify type safety (no compilation errors)
   - Test error handling flows
   - Verify authentication flow

2. **Component Integration Tests**
   - Test components using the new API client
   - Verify loading states work correctly
   - Test error state rendering
   - Verify data flows correctly through application

3. **E2E Tests**
   - Design Playwright/Cypress tests for critical user flows:
     - User registration → login → text selection → reading session
     - Text creation → editing → deletion (admin flow)
     - Profile management
   - Verify Units data displays correctly in UI

4. **Regression Testing**
   - Test all existing features still work
   - Verify no UI breaking changes
   - Check for any performance regressions

5. **Cross-Browser Testing**
   - Test in Chrome, Firefox, Safari
   - Verify mobile responsiveness

Provide test scripts and CI/CD configuration for automated testing.
```

---

## Phase 5: Docker Configuration & Local Development

### Prompt 5.1: Docker Compose Setup
```
Design a Docker Compose configuration for local development and testing:

1. **Services Configuration**
   ```yaml
   services:
     backend:
       # C# monolithic backend
       - Build configuration
       - Environment variables
       - Volume mounts for hot reload
       - Health checks
     
     frontend:
       # React/Angular/Vue frontend
       - Build configuration
       - Environment variables
       - Proxy configuration to backend
       - Hot reload support
     
     database:
       # PostgreSQL or SQL Server
       - Persistent volume configuration
       - Initialization scripts
       - Port mapping
       - Health checks
     
     redis: (optional)
       # Caching layer
       - Configuration
       - Persistent volume
   ```

2. **Networking**
   - Define network topology
   - Service discovery
   - Internal vs external ports

3. **Environment Configuration**
   - Design .env file structure
   - Separate dev/test/prod configurations
   - Secret management approach

4. **Database Initialization**
   - Create database initialization script
   - Run EF migrations on startup
   - Seed test data

5. **Development Workflow**
   - Hot reload configuration for backend
   - Hot reload for frontend
   - Database reset scripts
   - Log aggregation

Provide complete docker-compose.yml and supporting Dockerfiles.
```

### Prompt 5.2: Backend Dockerfile Optimization
```
Create an optimized multi-stage Dockerfile for the C# backend:

1. **Build Stage**
   ```dockerfile
   # Design efficient build:
   - Use SDK image for build
   - Copy only necessary files
   - Restore dependencies separately (layer caching)
   - Build in Release mode
   - Run tests during build (optional)
   ```

2. **Runtime Stage**
   ```dockerfile
   # Design minimal runtime image:
   - Use aspnet runtime image
   - Copy only published artifacts
   - Configure non-root user
   - Set environment variables
   - Configure health check endpoint
   ```

3. **Development Stage** (optional)
   ```dockerfile
   # Design dev-specific stage:
   - Include debugging tools
   - Hot reload support
   - Development certificates
   ```

4. **Build Arguments & Environment**
   - Define build-time arguments
   - Runtime environment configuration
   - Connection strings management

Provide complete Dockerfile with comments explaining optimizations.
```

### Prompt 5.3: Frontend Dockerfile & Build
```
Create an optimized Dockerfile for the frontend service:

1. **Build Stage**
   ```dockerfile
   # Design efficient frontend build:
   - Use Node.js image
   - Copy package files separately (layer caching)
   - Install dependencies
   - Build production bundle
   - Generate API types from backend OpenAPI spec
   ```

2. **Production Serving** (Option A: nginx)
   ```dockerfile
   # Serve with nginx:
   - Use nginx:alpine
   - Copy built assets
   - Configure nginx.conf
   - Set up proxy to backend
   - Enable gzip compression
   ```

   **Production Serving** (Option B: Node server)
   ```dockerfile
   # Serve with Node:
   - Use minimal Node runtime
   - Copy built assets
   - Configure Express/serve
   ```

3. **Development Mode**
   - Hot reload configuration
   - Source maps
   - Development proxy to backend

4. **Build Configuration**
   - Environment variable injection
   - API URL configuration
   - Build optimizations

Provide complete Dockerfile and nginx configuration (if applicable).
```

### Prompt 5.4: Local Testing & CI/CD Pipeline
```
Design a comprehensive testing and CI/CD strategy:

1. **Local Testing Scripts**
   ```bash
   # Create npm/make scripts for:
   - Starting all services (docker-compose up)
   - Running backend unit tests
   - Running backend integration tests
   - Running frontend unit tests
   - Running E2E tests
   - Database migrations
   - Data seeding
   - Service health checks
   ```

2. **CI/CD Pipeline** (GitHub Actions / GitLab CI)
   ```yaml
   # Design pipeline stages:
   
   Build:
   - Restore dependencies
   - Build backend
   - Build frontend
   - Generate API types
   
   Test:
   - Run backend unit tests with coverage
   - Run backend integration tests (with test DB)
   - Run frontend unit tests
   - Run E2E tests (with Docker Compose)
   
   Quality:
   - Run linters (C# analyzers, ESLint)
   - Run code formatters
   - Security scanning
   - Dependency vulnerability checks
   
   Package:
   - Build Docker images
   - Push to registry
   - Tag with version/commit SHA
   
   Deploy:
   - Deploy to staging (automatic)
   - Deploy to production (manual approval)
   ```

3. **Testing Database Management**
   - Spin up test database in container
   - Run migrations
   - Seed test data
   - Clean up after tests

4. **Monitoring & Alerts**
   - Configure health check endpoints
   - Set up logging aggregation
   - Define CI/CD failure notifications

Provide complete CI/CD configuration files and testing scripts.
```

---

## Phase 6: Performance & Optimization

### Prompt 6.1: Units JSON Query Optimization
```
Optimize and benchmark Units JSON storage and querying:

1. **Query Performance Analysis**
   - Benchmark common Units queries (table-based vs JSON)
   - Identify slow queries
   - Analyze execution plans

2. **Optimization Strategies**
   ```csharp
   // Implement optimizations:
   - Add computed columns for frequently queried JSON paths
   - Create indexes on computed columns
   - Use JSON_VALUE and JSON_QUERY efficiently
   - Consider materialized views for complex aggregations
   - Implement query result caching where appropriate
   ```

3. **EF Core JSON Configuration**
   ```csharp
   // Optimize EF Core for JSON:
   - Configure JSON column mapping efficiently
   - Use compiled queries
   - Implement proper navigation property handling
   - Use AsNoTracking() where appropriate
   ```

4. **Monitoring & Metrics**
   - Set up query performance logging
   - Track slow query alerts
   - Monitor JSON column storage size

5. **Comparison Report**
   - Compare performance metrics: table-based vs JSON
   - Document any trade-offs
   - Justify the design decision

Provide benchmarking code, optimization scripts, and performance reports.
```

### Prompt 6.2: API Performance Optimization
```
Optimize API endpoint performance:

1. **Response Caching**
   - Identify cacheable endpoints
   - Implement response caching middleware
   - Configure cache invalidation strategies
   - Use ETag for conditional requests

2. **Database Query Optimization**
   - Review N+1 query issues
   - Implement eager loading where needed
   - Use projection to load only required fields
   - Optimize pagination queries

3. **Async/Await Best Practices**
   - Review all async code
   - Ensure proper async/await usage
   - Avoid blocking calls

4. **Connection Pooling**
   - Configure optimal connection pool size
   - Monitor connection usage

5. **Load Testing**
   - Use k6, JMeter, or similar tool
   - Test critical endpoints under load
   - Identify bottlenecks
   - Set performance baselines

Provide optimized code examples and load testing scripts.
```

---

## Phase 7: Documentation & Handoff

### Prompt 7.1: Architecture Documentation
```
Create comprehensive architecture documentation:

1. **Architecture Overview**
   - High-level system diagram
   - Hexagonal architecture layers explanation
   - Dependency flow
   - Design decisions and rationale

2. **Domain Model Documentation**
   - Aggregate diagrams
   - Entity relationship diagrams
   - Value object descriptions
   - Units JSON schema documentation

3. **API Documentation**
   - Complete OpenAPI/Swagger spec
   - Authentication guide
   - Rate limiting policies
   - Versioning strategy

4. **Development Guide**
   - Local setup instructions
   - How to add new features
   - Testing guidelines
   - Coding standards

5. **Migration Documentation**
   - What changed from microservices
   - Data migration process
   - Frontend API changes
   - Breaking changes and mitigation

Use diagrams (C4 model, UML) and code examples where helpful.
```

### Prompt 7.2: Runbook & Operations Guide
```
Create operational documentation for the monolith:

1. **Deployment Guide**
   - Docker deployment steps
   - Kubernetes deployment (if applicable)
   - Environment configuration
   - Database migration procedures

2. **Monitoring & Alerting**
   - Health check endpoints
   - Key metrics to monitor
   - Log aggregation setup
   - Alert thresholds

3. **Troubleshooting Guide**
   - Common issues and solutions
   - Performance troubleshooting
   - Database connection issues
   - Units JSON query issues

4. **Backup & Recovery**
   - Database backup procedures
   - Disaster recovery plan
   - Data retention policies

5. **Scaling Strategies**
   - Horizontal scaling approach
   - Database scaling considerations
   - Caching strategies
   - CDN configuration for frontend

Provide checklists and runbook templates.
```

---

## Summary Checklist

Use this checklist to track progress through all phases:

### Phase 1: Discovery ✓
- [ ] ReaderService feature audit complete
- [ ] TextService feature audit complete
- [ ] UserService feature audit complete
- [ ] Frontend API contract analysis complete
- [ ] Units table structure documented

### Phase 2: Architecture Design ✓
- [ ] Domain layer designed
- [ ] Application layer designed
- [ ] Infrastructure layer designed
- [ ] API layer designed
- [ ] Units JSON schema finalized

### Phase 3: Frontend Integration ✓
- [ ] TypeScript types generated
- [ ] Unified API client implemented
- [ ] React hooks/utilities created
- [ ] API client tests written

### Phase 4: Migration & Verification ✓
- [ ] Data migration scripts written
- [ ] Units migration tested
- [ ] Feature parity tests passing
- [ ] Frontend integration verified
- [ ] Performance benchmarks met

### Phase 5: Docker & DevOps ✓
- [ ] Docker Compose configured
- [ ] Backend Dockerfile optimized
- [ ] Frontend Dockerfile optimized
- [ ] CI/CD pipeline configured
- [ ] Local testing workflow verified

### Phase 6: Optimization ✓
- [ ] Units JSON queries optimized
- [ ] API performance optimized
- [ ] Load testing completed
- [ ] Performance baselines established

### Phase 7: Documentation ✓
- [ ] Architecture documentation complete
- [ ] API documentation complete
- [ ] Runbook created
- [ ] Development guide written
- [ ] Migration guide complete

---

## Recommended Tools & Libraries

**Backend (C#/.NET)**
- MediatR (CQRS pattern)
- FluentValidation
- AutoMapper
- Serilog
- xUnit + FluentAssertions + Moq

**Frontend (TypeScript)**
- NSwag or OpenAPI Generator (type generation)
- Axios or Fetch API
- React Query or SWR (optional)
- MSW (Mock Service Worker)
- Jest/Vitest + Testing Library

**DevOps**
- Docker & Docker Compose
- GitHub Actions or GitLab CI
- k6 or JMeter (load testing)
- EF Core Migrations

**Database**
- SQL Server or PostgreSQL (with JSON support)
- Redis (caching)

---

## Notes on Execution Order

1. **Start with Phase 1** - You need complete understanding before refactoring
2. **Units migration is critical** - Allocate extra time for this transformation
3. **Build incrementally** - Don't try to migrate everything at once
4. **Test continuously** - Write tests as you implement
5. **Frontend last** - Ensure backend is solid before integrating frontend
6. **Performance early** - Don't wait until the end to benchmark