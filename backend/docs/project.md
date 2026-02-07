Koine.sln
│
├── Koine.Domain/              # Core domain models (no dependencies)
│   ├── Entities/
│   ├── Enums/
│   └── ValueObjects/
│
├── Koine.Application/         # Business logic & DTOs
│   ├── DTOs/
│   ├── Interfaces/
│   ├── Services/
│   ├── Mappers/
│   └── Common/
│
├── Koine.Infrastructure/      # Data access & external services
│   ├── Data/
│   │   ├── Context/
│   │   ├── Repositories/
│   │   └── Configurations/
│   ├── Migrations/
│   └── Services/
│
├── Koine.API/                 # Web API layer
│   ├── Controllers/
│   ├── Middleware/
│   ├── Filters/
│   └── Extensions/
│
└── Koine.Tests/
    ├── Unit/
    └── Integration/