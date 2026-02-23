# AGENTS.md - Greek Learning App Refactoring Agents

This document defines specialized agents for the OpenAI Codex CLI to systematically refactor the Greek Learning App from microservices to a monolithic hexagonal architecture.

---

## Table of Contents

1. [Agent Definitions](#agent-definitions)
2. [Execution Strategy](#execution-strategy)
3. [Agent Workflows](#agent-workflows)
4. [Handoff Protocols](#handoff-protocols)
5. [Quality Gates](#quality-gates)
6. [Troubleshooting](#troubleshooting)

---

## Agent Definitions

### 1. Discovery Agent (`@discovery`)

**Purpose:** Analyze existing microservices and document current functionality, API contracts, and data models.

**Responsibilities:**
- Audit Go ReaderService codebase
- Audit .NET TextService codebase
- Audit .NET UserService codebase
- Analyze Frontend API integration points
- Document "units" table structure and query patterns
- Create feature inventory and data flow diagrams

**Key Outputs:**
- `discovery/reader-service-audit.md`
- `discovery/text-service-audit.md`
- `discovery/user-service-audit.md`
- `discovery/frontend-api-contracts.md`
- `discovery/units-table-analysis.md`
- `discovery/feature-matrix.md`

**Prompts to Execute:** Phase 1 (Prompts 1.1 - 1.4)

**Skills Required:**
- Go language proficiency
- C#/.NET proficiency
- API design understanding
- Database schema analysis
- Frontend framework knowledge

**Success Criteria:**
- All endpoints documented with request/response schemas
- All database tables and relationships mapped
- All business logic flows documented
- Units table migration requirements clearly defined
- No missing features or edge cases

---

### 2. Architecture Agent (`@architect`)

**Purpose:** Design the hexagonal architecture for the monolithic backend, ensuring clean separation of concerns.

**Responsibilities:**
- Define Domain Layer (aggregates, entities, value objects)
- Define Application Layer (commands, queries, handlers)
- Define Infrastructure Layer (repositories, EF Core configurations)
- Define API Layer (controllers, middleware)
- Design Units JSON schema and migration strategy
- Create architecture diagrams and documentation

**Key Outputs:**
- `architecture/domain-model.md`
- `architecture/application-layer.md`
- `architecture/infrastructure-layer.md`
- `architecture/api-layer.md`
- `architecture/units-json-schema.json`
- `architecture/c4-diagrams/`

**Prompts to Execute:** Phase 2 (Prompts 2.1 - 2.4)

**Dependencies:**
- Requires completion of `@discovery` agent
- Must reference `discovery/feature-matrix.md`
- Must reference `discovery/units-table-analysis.md`

**Skills Required:**
- Domain-Driven Design (DDD)
- Hexagonal/Clean Architecture
- CQRS patterns
- C#/.NET 8+ features
- EF Core JSON support

**Success Criteria:**
- Clear aggregate boundaries defined
- All domain invariants identified
- Application services follow SRP
- Infrastructure properly isolated
- Units JSON schema optimized for common queries

---

### 3. Frontend Integration Agent (`@frontend-integrator`)

**Purpose:** Create type-safe frontend API client and ensure seamless integration with the new monolithic backend.

**Responsibilities:**
- Generate TypeScript types from OpenAPI spec
- Implement unified API client utility
- Create React hooks for API integration
- Design error handling and retry logic
- Implement type-safe request/response handling
- Create integration tests

**Key Outputs:**
- `frontend/types/api-types.ts` (generated)
- `frontend/lib/api-client.ts`
- `frontend/hooks/useApi.ts`
- `frontend/lib/api-error-handler.ts`
- `frontend/tests/api-client.test.ts`

**Prompts to Execute:** Phase 3 (Prompts 3.1 - 3.3)

**Dependencies:**
- Requires OpenAPI spec from `@architect` agent
- Must reference `discovery/frontend-api-contracts.md`

**Skills Required:**
- TypeScript advanced types
- React hooks and patterns
- API client design
- Error handling strategies
- Testing (Jest/Vitest)

**Success Criteria:**
- 100% type coverage for API calls
- All API methods return discriminated unions
- Automatic token refresh implemented
- Comprehensive error handling
- All tests passing

---

### 4. Implementation Agent (`@implementer`)

**Purpose:** Implement the monolithic backend following the architectural design.

**Responsibilities:**
- Implement Domain Layer (entities, value objects, domain services)
- Implement Application Layer (command/query handlers)
- Implement Infrastructure Layer (repositories, DbContext, migrations)
- Implement API Layer (controllers, middleware)
- Implement Units JSON value converter and repository methods
- Write unit tests for all layers

**Key Outputs:**
- `backend/src/Domain/`
- `backend/src/Application/`
- `backend/src/Infrastructure/`
- `backend/src/API/`
- `backend/tests/`

**Prompts to Execute:** Derived from Phase 2 outputs (implementation phase)

**Dependencies:**
- Requires completion of `@architect` agent
- Must follow architectural guidelines strictly
- Must reference `architecture/` documentation

**Skills Required:**
- C#/.NET 8+ expertise
- EF Core 8+ expertise
- MediatR, FluentValidation, AutoMapper
- xUnit testing framework
- SQL Server/PostgreSQL

**Success Criteria:**
- All domain logic is testable and tested
- Application layer follows CQRS pattern
- Infrastructure properly implements ports (interfaces)
- Controllers are thin and delegate to handlers
- Test coverage > 80%
- All tests passing

---

### 5. Migration Agent (`@migrator`)

**Purpose:** Design and execute data migration from microservices databases to monolithic database, with special focus on Units table to JSON column transformation.

**Responsibilities:**
- Design database consolidation strategy
- Create migration scripts (EF migrations + custom SQL)
- Implement Units table to JSON column transformation
- Create data validation scripts
- Design rollback procedures
- Execute migration with verification

**Key Outputs:**
- `migration/consolidation-plan.md`
- `migration/scripts/01_create_unified_schema.sql`
- `migration/scripts/02_migrate_users.sql`
- `migration/scripts/03_migrate_texts.sql`
- `migration/scripts/04_migrate_units_to_json.sql`
- `migration/scripts/05_create_json_indexes.sql`
- `migration/validation/verify_data_integrity.sql`
- `migration/rollback/rollback_procedures.md`

**Prompts to Execute:** Phase 4 (Prompt 4.1)

**Dependencies:**
- Requires schema designs from `@architect` agent
- Requires understanding of current data from `@discovery` agent
- Must have backup strategy before execution

**Skills Required:**
- SQL expertise (T-SQL or PostgreSQL)
- EF Core migrations
- Data transformation
- JSON query optimization
- Database performance tuning

**Success Criteria:**
- Zero data loss
- All relationships preserved
- Units JSON queries perform as well or better than table-based
- All validation checks pass
- Rollback procedures tested and documented

---

### 6. Testing Agent (`@tester`)

**Purpose:** Ensure feature parity and quality through comprehensive testing.

**Responsibilities:**
- Create feature parity test suite
- Implement unit tests
- Implement integration tests
- Implement E2E tests
- Create performance benchmarks
- Verify Units JSON query performance
- Execute regression tests

**Key Outputs:**
- `tests/feature-parity/test-plan.md`
- `tests/backend/unit/`
- `tests/backend/integration/`
- `tests/e2e/`
- `tests/performance/benchmarks.md`
- `tests/performance/units-json-benchmark.md`

**Prompts to Execute:** Phase 4 (Prompts 4.2 - 4.3)

**Dependencies:**
- Requires implementation from `@implementer` agent
- Requires migration completion from `@migrator` agent
- Must reference `discovery/feature-matrix.md` for test cases

**Skills Required:**
- xUnit, Moq, FluentAssertions
- Playwright/Cypress
- Performance testing tools
- Test data management

**Success Criteria:**
- All feature parity tests passing
- Integration tests cover all critical paths
- E2E tests cover main user journeys
- Performance benchmarks meet or exceed microservices
- Units JSON queries meet performance requirements

---

### 7. DevOps Agent (`@devops`)

**Purpose:** Configure Docker, CI/CD, and local development environment.

**Responsibilities:**
- Create Docker Compose configuration
- Create optimized Dockerfiles (backend, frontend)
- Configure CI/CD pipeline
- Set up database initialization scripts
- Create local development scripts
- Configure health checks and monitoring

**Key Outputs:**
- `docker-compose.yml`
- `backend/Dockerfile`
- `frontend/Dockerfile`
- `.github/workflows/ci-cd.yml` (or GitLab equivalent)
- `scripts/dev-setup.sh`
- `scripts/run-tests.sh`
- `scripts/reset-db.sh`

**Prompts to Execute:** Phase 5 (Prompts 5.1 - 5.4)

**Dependencies:**
- Requires implementation from `@implementer` agent
- Requires tests from `@tester` agent
- Must have backend and frontend ready to containerize

**Skills Required:**
- Docker and Docker Compose
- CI/CD (GitHub Actions/GitLab CI)
- Shell scripting
- Container optimization
- Networking

**Success Criteria:**
- `docker-compose up` starts all services successfully
- Hot reload works for both backend and frontend
- CI/CD pipeline runs all tests automatically
- Docker images are optimized (minimal size)
- Local development workflow is smooth

---

### 8. Performance Agent (`@optimizer`)

**Purpose:** Optimize system performance, with special focus on Units JSON queries.

**Responsibilities:**
- Benchmark Units JSON vs table-based queries
- Optimize slow queries
- Implement caching strategies
- Configure EF Core for optimal performance
- Create computed columns and indexes for JSON
- Perform load testing
- Generate performance reports

**Key Outputs:**
- `optimization/units-json-optimization.md`
- `optimization/query-optimizations.sql`
- `optimization/ef-core-configurations.cs`
- `optimization/caching-strategy.md`
- `optimization/load-test-results.md`
- `optimization/performance-comparison.md`

**Prompts to Execute:** Phase 6 (Prompts 6.1 - 6.2)

**Dependencies:**
- Requires implementation from `@implementer` agent
- Requires migration from `@migrator` agent
- Should run after initial testing by `@tester` agent

**Skills Required:**
- SQL query optimization
- EF Core performance tuning
- JSON indexing strategies
- Load testing (k6, JMeter)
- Performance profiling

**Success Criteria:**
- Units JSON queries perform within 10% of table-based queries
- No N+1 query problems
- Critical endpoints respond under 200ms (p95)
- Load tests pass without degradation
- Caching strategy reduces database load

---

### 9. Documentation Agent (`@documenter`)

**Purpose:** Create comprehensive documentation for the refactored system.

**Responsibilities:**
- Write architecture documentation
- Create API documentation
- Write development guides
- Create operational runbooks
- Document migration process
- Create troubleshooting guides

**Key Outputs:**
- `docs/architecture/README.md`
- `docs/api/openapi.yaml`
- `docs/development/getting-started.md`
- `docs/development/coding-standards.md`
- `docs/operations/deployment.md`
- `docs/operations/runbook.md`
- `docs/migration/migration-guide.md`

**Prompts to Execute:** Phase 7 (Prompts 7.1 - 7.2)

**Dependencies:**
- Requires outputs from all previous agents
- Should be continuous throughout project
- Final pass at project completion

**Skills Required:**
- Technical writing
- Diagram creation (C4, UML)
- API documentation (OpenAPI/Swagger)
- Markdown

**Success Criteria:**
- New developers can get started in < 30 minutes
- All APIs are documented with examples
- Operations team can deploy without assistance
- Troubleshooting guide covers common issues
- Migration process is fully documented

---

## Execution Strategy

### Overview

The refactoring will be executed in **phases**, with **parallel workstreams** where possible. Each agent has clear dependencies and handoff points.

### Phase Breakdown

```
Phase 1: Discovery (Week 1)
├── @discovery: Audit all services (parallel)
└── Output: Complete feature inventory

Phase 2: Design (Week 2-3)
├── @architect: Design all layers (sequential)
└── Output: Complete architectural blueprint

Phase 3: Frontend Preparation (Week 3-4)
├── @frontend-integrator: API client implementation
└── Output: Type-safe API client ready

Phase 4: Backend Implementation (Week 4-7)
├── @implementer: Implement all layers (sequential by layer)
│   ├── Domain Layer (Week 4)
│   ├── Application Layer (Week 5)
│   ├── Infrastructure Layer (Week 6)
│   └── API Layer (Week 7)
└── Output: Working monolithic backend

Phase 5: Data Migration (Week 8)
├── @migrator: Execute migration (critical)
└── Output: Consolidated database with Units as JSON

Phase 6: Testing & Verification (Week 9-10)
├── @tester: Feature parity & performance testing
└── Output: Verified system with all tests passing

Phase 7: DevOps & Deployment (Week 11)
├── @devops: Docker & CI/CD setup
└── Output: Deployable system

Phase 8: Optimization (Week 12)
├── @optimizer: Performance tuning
└── Output: Optimized system

Phase 9: Documentation (Week 13)
├── @documenter: Final documentation pass
└── Output: Complete documentation
```

### Parallel Workstreams

Where possible, agents can work in parallel:

```
Weeks 1-2: Discovery + Architecture Design
├── @discovery (Week 1)
└── @architect (Week 2, requires discovery completion)

Week 3: Architecture Finalization + Frontend Prep
├── @architect (finalize)
└── @frontend-integrator (start, uses OpenAPI spec from architect)

Weeks 4-7: Backend Implementation
├── @implementer (primary)
└── @documenter (continuous, documenting as built)

Week 8: Migration
├── @migrator (primary)
├── @tester (prep test environments)
└── @devops (prep Docker configs)

Weeks 9-10: Testing + DevOps
├── @tester (primary)
└── @devops (run tests in Docker)

Weeks 11-12: Optimization + Deployment
├── @optimizer (primary)
├── @devops (finalize CI/CD)
└── @documenter (operations docs)

Week 13: Final Polish
├── @documenter (final pass)
├── @tester (final regression)
└── ALL: Final review
```

---

## Agent Workflows

### Workflow 1: Discovery to Design

```mermaid
graph LR
    A[@discovery] -->|feature-matrix.md| B[@architect]
    A -->|units-table-analysis.md| B
    A -->|api-contracts.md| C[@frontend-integrator]
    B -->|openapi.yaml| C
```

**Steps:**
1. `@discovery` completes all audits
2. `@discovery` creates consolidated `feature-matrix.md`
3. `@discovery` hands off to `@architect` with findings
4. `@architect` designs system using discovery outputs
5. `@architect` generates OpenAPI spec
6. `@frontend-integrator` uses OpenAPI spec to generate types

**Handoff Checklist:**
- [ ] All microservice endpoints documented
- [ ] All database schemas mapped
- [ ] Units table structure fully documented
- [ ] Feature matrix complete and reviewed
- [ ] API contracts validated with frontend team

---

### Workflow 2: Design to Implementation

```mermaid
graph LR
    A[@architect] -->|domain-model.md| B[@implementer]
    A -->|application-layer.md| B
    A -->|infrastructure-layer.md| B
    A -->|api-layer.md| B
    A -->|units-json-schema.json| C[@migrator]
```

**Steps:**
1. `@architect` completes all layer designs
2. `@architect` reviews designs with technical lead
3. `@implementer` receives architectural blueprints
4. `@implementer` implements layer by layer (Domain → App → Infra → API)
5. `@implementer` writes unit tests alongside implementation
6. `@migrator` receives Units JSON schema for migration planning

**Handoff Checklist:**
- [ ] All aggregate boundaries defined
- [ ] All commands/queries identified
- [ ] Repository interfaces defined
- [ ] API endpoints designed
- [ ] Units JSON schema finalized
- [ ] Architecture review completed

---

### Workflow 3: Implementation to Migration

```mermaid
graph LR
    A[@implementer] -->|EF migrations| B[@migrator]
    A[@implementer] -->|DbContext| B
    C[@architect] -->|units-json-schema| B
    B -->|migrated DB| D[@tester]
```

**Steps:**
1. `@implementer` creates EF Core migrations for new schema
2. `@implementer` implements Units value converter
3. `@migrator` receives schema and converter
4. `@migrator` writes custom migration scripts (especially for Units)
5. `@migrator` creates validation queries
6. `@migrator` executes migration in test environment
7. `@migrator` validates data integrity
8. `@migrator` hands off to `@tester` for verification

**Handoff Checklist:**
- [ ] EF migrations complete and tested
- [ ] Units JSON converter implemented
- [ ] Custom migration scripts written
- [ ] Validation scripts prepared
- [ ] Rollback procedures documented
- [ ] Test migration successful
- [ ] Data integrity verified (zero data loss)

**CRITICAL: Units Migration**
This is the highest-risk step. Extra validation required:
- [ ] Units table data backed up
- [ ] JSON transformation tested with sample data
- [ ] Query performance benchmarked before/after
- [ ] Indexes on JSON columns created
- [ ] Rollback tested successfully

---

### Workflow 4: Testing to Deployment

```mermaid
graph LR
    A[@tester] -->|test results| B[@devops]
    B[@devops] -->|CI/CD pipeline| C[@optimizer]
    C -->|optimizations| A
```

**Steps:**
1. `@tester` creates comprehensive test suite
2. `@tester` executes feature parity tests
3. `@devops` containerizes application
4. `@devops` sets up CI/CD to run tests automatically
5. `@tester` runs tests in Docker environment
6. `@optimizer` analyzes performance bottlenecks
7. `@optimizer` implements optimizations
8. `@tester` re-runs tests to verify improvements
9. `@devops` deploys to staging environment

**Handoff Checklist:**
- [ ] All feature parity tests passing
- [ ] Integration tests passing
- [ ] E2E tests passing
- [ ] Performance benchmarks met
- [ ] Docker Compose working locally
- [ ] CI/CD pipeline green
- [ ] Staging deployment successful

---

## Handoff Protocols

### Formal Handoff Process

Each agent handoff requires:

1. **Completion Criteria Met**
   - All outputs in "Key Outputs" section produced
   - All "Success Criteria" validated
   - Quality gate passed (see below)

2. **Handoff Document**
   - Create `handoff/<from-agent>-to-<to-agent>.md`
   - Include: What was completed, what's ready, known issues, next steps
   - Example: `handoff/discovery-to-architect.md`

3. **Review Meeting** (if needed)
   - Technical lead reviews handoff document
   - Receiving agent asks clarifying questions
   - Decisions documented in handoff doc

4. **Acknowledgment**
   - Receiving agent acknowledges readiness
   - Receiving agent reviews all outputs
   - Receiving agent creates work plan

### Handoff Document Template

```markdown
# Handoff: <From Agent> → <To Agent>

**Date:** YYYY-MM-DD
**From:** @<agent-name>
**To:** @<agent-name>

## Completed Work

### Outputs Delivered
- [ ] Output 1: path/to/file
- [ ] Output 2: path/to/file
- [ ] ...

### Success Criteria Met
- [ ] Criterion 1: Details
- [ ] Criterion 2: Details
- [ ] ...

## Key Findings

### Important Decisions Made
1. Decision 1: Rationale
2. Decision 2: Rationale

### Deviations from Plan
- Any changes from original prompts
- Reasons for deviations

### Challenges Encountered
- Challenge 1: How resolved
- Challenge 2: How resolved

## Known Issues

### Blockers
- None / List blockers

### Open Questions
1. Question 1: Context
2. Question 2: Context

### Technical Debt Incurred
- Debt item 1: Why incurred, plan to address

## Next Steps for Receiving Agent

### Immediate Actions
1. Action 1
2. Action 2

### Dependencies
- Dependency 1: Who/what blocks this
- Dependency 2: Who/what blocks this

### Recommendations
- Recommendation 1
- Recommendation 2

## Sign-off

**Handing Off Agent:** @<agent> - [Signature/Approval]
**Receiving Agent:** @<agent> - [Acknowledged]
**Technical Lead:** [Name] - [Reviewed]
```

---

## Quality Gates

Each phase has quality gates that must be passed before proceeding.

### Gate 1: Discovery Complete

**Criteria:**
- [ ] All three microservices fully documented
- [ ] Frontend API contracts documented
- [ ] Units table structure and queries analyzed
- [ ] Feature matrix complete (no missing features)
- [ ] At least 2 team members reviewed findings
- [ ] No blockers identified

**Review Checklist:**
- Are all API endpoints documented?
- Are all database tables mapped?
- Are all business rules captured?
- Is the Units migration fully understood?
- Are there any surprises or unknowns?

**Gate Owner:** Technical Lead

---

### Gate 2: Architecture Approved

**Criteria:**
- [ ] All layer designs complete
- [ ] Aggregate boundaries validated
- [ ] Units JSON schema optimized for queries
- [ ] API design reviewed with frontend team
- [ ] Architecture diagrams created
- [ ] Technical lead approves design
- [ ] Team walkthrough completed

**Review Checklist:**
- Does the design follow hexagonal architecture principles?
- Are domain invariants properly enforced?
- Is the Units JSON schema optimal?
- Are there any architectural smells?
- Is the design testable?
- Can the design accommodate future features?

**Gate Owner:** Technical Lead + Senior Architect

---

### Gate 3: Implementation Review

**Criteria:**
- [ ] All layers implemented
- [ ] Unit test coverage > 80%
- [ ] All unit tests passing
- [ ] Code review completed
- [ ] No critical code smells (SonarQube/Roslyn Analyzers)
- [ ] Integration tests written
- [ ] Units JSON implementation tested

**Review Checklist:**
- Does code follow SOLID principles?
- Are dependencies properly injected?
- Is error handling consistent?
- Are there any performance concerns?
- Is the Units value converter working correctly?
- Do tests cover edge cases?

**Gate Owner:** Tech Lead + Senior Developer

---

### Gate 4: Migration Validated

**Criteria:**
- [ ] Migration scripts peer-reviewed
- [ ] Test migration successful (100% data integrity)
- [ ] Units JSON transformation validated
- [ ] Query performance benchmarked
- [ ] Rollback tested successfully
- [ ] Production migration plan approved
- [ ] Backup strategy confirmed

**Review Checklist:**
- Is there any data loss? (Answer must be NO)
- Do all relationships still work?
- Are Units JSON queries performing well?
- Is the rollback procedure tested?
- Are all validation queries passing?
- Is the production migration planned for low-traffic window?

**Gate Owner:** Database Admin + Technical Lead

**CRITICAL GATE:** This is the highest-risk gate. Extra scrutiny required.

---

### Gate 5: Testing Complete

**Criteria:**
- [ ] All feature parity tests passing
- [ ] Integration tests passing
- [ ] E2E tests passing
- [ ] Performance benchmarks met or exceeded
- [ ] Units JSON queries meet performance targets
- [ ] No critical bugs
- [ ] Regression testing complete

**Review Checklist:**
- Are all features from microservices working?
- Are there any performance regressions?
- Do E2E tests cover main user journeys?
- Are error scenarios tested?
- Is the Units JSON functionality fully tested?

**Gate Owner:** QA Lead + Technical Lead

---

### Gate 6: Deployment Ready

**Criteria:**
- [ ] Docker Compose working locally
- [ ] CI/CD pipeline green
- [ ] All tests running in CI/CD
- [ ] Staging deployment successful
- [ ] Health checks configured
- [ ] Monitoring set up
- [ ] Documentation complete
- [ ] Rollback plan tested

**Review Checklist:**
- Can the system be deployed with one command?
- Are all environments configured?
- Is monitoring in place?
- Is the rollback plan clear?
- Is the operations team trained?

**Gate Owner:** DevOps Lead + Technical Lead

---

## Troubleshooting

### Common Issues and Solutions

#### Issue: Discovery phase taking too long

**Symptoms:**
- Agent struggling to understand legacy code
- Incomplete documentation
- Many unknown edge cases

**Solutions:**
1. **Break down the work:** Assign sub-agents per microservice
2. **Time-box:** Set strict deadlines, document unknowns separately
3. **Pair with original developers:** Get direct knowledge transfer
4. **Use code analysis tools:** Generate automated documentation first

**Prevention:**
- Allocate more time for discovery
- Ensure original developers available for questions

---

#### Issue: Units JSON migration concerns

**Symptoms:**
- Uncertain about query performance
- Complex queries hard to translate to JSON queries
- Migration script complexity

**Solutions:**
1. **Benchmark early:** Test JSON queries with production-like data before committing
2. **Hybrid approach:** Keep most-queried fields as columns, put rest in JSON
3. **Computed columns:** Create computed columns for frequently-queried JSON paths
4. **Index everything:** Create indexes on computed columns
5. **Phased migration:** Migrate in stages, validate each stage

**Prevention:**
- Proof of concept early in Phase 2
- Load production data into test environment
- Run benchmarks before architectural decisions locked

---

#### Issue: Feature parity gaps discovered late

**Symptoms:**
- Tests failing for features not in discovery
- Frontend expecting APIs that don't exist
- Business rules not implemented

**Solutions:**
1. **Gap analysis:** Compare discovery docs with test results
2. **Emergency discovery:** Re-run discovery for missed areas
3. **Prioritize:** Implement critical features first, defer nice-to-haves
4. **Frontend coordination:** Ensure frontend team aware of gaps

**Prevention:**
- Thorough discovery phase
- Early integration testing
- Regular syncs between backend and frontend teams

---

#### Issue: Performance regressions

**Symptoms:**
- Monolith slower than microservices
- Units JSON queries slow
- High database load

**Solutions:**
1. **Profile everything:** Use profiling tools to find bottlenecks
2. **Optimize queries:** Add indexes, use compiled queries, enable query caching
3. **Implement caching:** Add Redis for frequently accessed data
4. **Optimize Units queries:** Add computed columns, improve JSON indexes
5. **Scale database:** Increase resources if queries are optimal

**Prevention:**
- Set performance baselines early
- Continuous performance monitoring
- Load testing before production

---

#### Issue: Docker environment issues

**Symptoms:**
- Services not communicating
- Database connection failures
- Hot reload not working

**Solutions:**
1. **Check networking:** Verify Docker network configuration
2. **Check env variables:** Ensure connection strings correct for Docker network
3. **Check volumes:** Ensure volumes mounted correctly for hot reload
4. **Check health checks:** Verify services starting up correctly

**Prevention:**
- Test Docker setup early
- Document Docker networking
- Use Docker Compose profiles for different scenarios

---

#### Issue: CI/CD pipeline failures

**Symptoms:**
- Tests passing locally but failing in CI
- Build failures in CI
- Timeout issues

**Solutions:**
1. **Replicate CI environment:** Run tests in Docker locally
2. **Check environment variables:** Ensure test DB configured in CI
3. **Increase timeouts:** CI may be slower than local
4. **Parallelize tests:** Speed up test execution

**Prevention:**
- Test CI/CD early
- Mirror CI environment locally
- Keep build times reasonable

---

## Agent Coordination Tips

### Daily Standups

Hold brief daily standups with active agents:
- What did you complete yesterday?
- What are you working on today?
- Any blockers?
- Any handoffs needed?

### Shared Knowledge Base

Maintain a shared wiki/docs folder with:
- Architectural decisions (ADRs)
- Current status of each phase
- Open questions and answers
- Common problems and solutions

### Communication Channels

Establish clear communication:
- **Slack/Teams channel** for quick questions
- **GitHub Issues/Jira** for tracking work
- **Wiki/Confluence** for documentation
- **Weekly review meetings** for major decisions

### Agent Context Management

When working with Codex CLI:
- **Start each session** with: "I am agent @<name>, continuing work on <phase>"
- **Reference previous work:** Point to relevant files from handoffs
- **Stay in scope:** Focus on assigned responsibilities
- **Ask for help:** If blocked, escalate to technical lead

---

## Success Metrics

### Project-Level Metrics

- **On-time delivery:** Each phase completed within estimated time
- **Quality:** All quality gates passed on first attempt
- **Feature parity:** 100% of microservices features working in monolith
- **Performance:** Monolith matches or exceeds microservices performance
- **Test coverage:** > 80% code coverage
- **Zero data loss:** Migration completes with perfect data integrity

### Agent-Level Metrics

Track per agent:
- **Output completeness:** All "Key Outputs" delivered
- **Success criteria met:** All criteria validated
- **Handoff quality:** Receiving agent has no blockers
- **Rework:** Minimal rework required (< 10% of time)

---

## Final Checklist

Before considering the project complete:

### Functionality
- [ ] All microservices features working
- [ ] All frontend API calls working
- [ ] Units JSON functionality complete and performant
- [ ] All tests passing (unit, integration, E2E)
- [ ] No critical bugs

### Performance
- [ ] Performance benchmarks met
- [ ] Units JSON queries optimized
- [ ] Load testing passed
- [ ] No N+1 queries
- [ ] Caching implemented where needed

### DevOps
- [ ] Docker Compose working
- [ ] CI/CD pipeline green
- [ ] Staging deployment successful
- [ ] Production deployment plan ready
- [ ] Rollback procedures tested
- [ ] Monitoring configured

### Documentation
- [ ] Architecture documented
- [ ] API documented (OpenAPI/Swagger)
- [ ] Development guide complete
- [ ] Operations runbook complete
- [ ] Migration documented
- [ ] Troubleshooting guide complete

### Quality
- [ ] Code review completed
- [ ] All quality gates passed
- [ ] Technical debt documented
- [ ] Security review completed
- [ ] Performance review completed

### Team
- [ ] Team trained on new system
- [ ] Operations team ready
- [ ] Support team ready
- [ ] Documentation accessible

---

## Appendix: Agent Prompt Reference

Quick reference to which prompts each agent should execute:

| Agent | Phase | Prompts |
|-------|-------|---------|
| @discovery | 1 | 1.1, 1.2, 1.3, 1.4 |
| @architect | 2 | 2.1, 2.2, 2.3, 2.4 |
| @frontend-integrator | 3 | 3.1, 3.2, 3.3 |
| @implementer | - | (Derived from Phase 2 outputs) |
| @migrator | 4 | 4.1 |
| @tester | 4 | 4.2, 4.3 |
| @devops | 5 | 5.1, 5.2, 5.3, 5.4 |
| @optimizer | 6 | 6.1, 6.2 |
| @documenter | 7 | 7.1, 7.2 (+ continuous) |

---

## Appendix: Codex CLI Usage Examples

### Starting a New Agent Session

```bash
# Start discovery agent
codex --agent discovery

# In the session, provide context:
"I am the @discovery agent for the Greek Learning App refactoring project. 
I need to audit the ReaderService (Go) as defined in Phase 1, Prompt 1.1 
of the refactoring-prompt-series.md. The service is located at 
GreekLearningApp-ReaderService/. Please analyze the codebase and provide 
a complete API endpoints inventory, core business logic, database interactions, 
key features, and edge cases as specified."
```

### Continuing Work

```bash
# Continue as the same agent
codex --agent architect --continue

# In the session:
"Continuing as @architect. I've reviewed the discovery outputs in discovery/. 
Now I need to design the Domain Layer as specified in Phase 2, Prompt 2.1. 
Please create aggregate roots and entities based on the feature audit findings, 
with special attention to the Units JSON value object design."
```

### Handoff Between Agents

```bash
# Agent 1 completes work
codex --agent discovery

"I've completed all discovery audits. Please create a handoff document 
for @architect using the template in AGENTS.md, summarizing findings 
and key outputs."

# Agent 2 picks up
codex --agent architect

"I am @architect, receiving handoff from @discovery. Please review 
handoff/discovery-to-architect.md and begin designing the Domain Layer 
based on the findings."
```

### Requesting Quality Gate Review

```bash
codex --agent implementer

"I've completed the implementation. Please prepare for Quality Gate 3 review 
by generating a summary of:
1. Unit test coverage report
2. Code quality metrics
3. Open issues or technical debt
4. Readiness for next phase

Format this according to Gate 3 criteria in AGENTS.md."
```

---

## License & Maintenance

**Document Owner:** Technical Lead  
**Last Updated:** [Date]  
**Review Frequency:** After each phase completion  

**Change Log:**
- [Date]: Initial version
- [Date]: Updated after Phase 1 learnings
- [Date]: Added troubleshooting section

---

## Questions or Issues?

If you encounter problems not covered in this document:

1. Check the troubleshooting section
2. Review handoff documents for context
3. Consult with technical lead
4. Update this document with the solution

**Remember:** This is a living document. Update it as you learn!