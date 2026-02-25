Designing the Application Layer for the monolithic backend involves transitioning to a **CQRS (Command Query Responsibility Segregation)** pattern using **MediatR**. This separates the "write" side (Commands) from the "read" side (Queries), allowing for independent scaling and optimization of each.

---

### 1. Command Handlers (Write Operations)

Commands represent user intent to change the state of the system. Each command is paired with a handler that executes the business logic within the Domain Layer.

```csharp
// Koine.Application/Features/Users/Commands/UpdateUserProgressCommand.cs
public record UpdateUserProgressCommand(
    int UserId, 
    int LessonId, 
    bool IsComplete
) : IRequest<Result<UserProgressDto>>;

public class UpdateUserProgressHandler : IRequestHandler<UpdateUserProgressCommand, Result<UserProgressDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateUserProgressHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<UserProgressDto>> Handle(UpdateUserProgressCommand request, CancellationToken ct)
    {
        var user = await _unitOfWork.Users.GetByIdAsync(request.UserId);
        if (user == null) return Result.Failure<UserProgressDto>("User not found");

        user.UpdateProgress(request.LessonId, request.IsComplete);
        await _unitOfWork.SaveChangesAsync(ct);

        return Result.Success(_mapper.Map<UserProgressDto>(user.Progress));
    }
}
```

### 2. Query Handlers (Read Operations)

Queries are optimized for data retrieval, often bypassing the domain aggregate rules to improve performance.

```csharp
// Koine.Application/Features/Texts/Queries/GetChapterWithUnitsQuery.cs
public record GetChapterWithUnitsQuery(int ChapterId) : IRequest<Result<ChapterDto>>;

public class GetChapterWithUnitsHandler : IRequestHandler<GetChapterWithUnitsQuery, Result<ChapterDto>>
{
    private readonly IDbConnection _db; // Use Dapper or EF Core Raw SQL for high-speed reads

    public async Task<Result<ChapterDto>> Handle(GetChapterWithUnitsQuery query, CancellationToken ct)
    {
        // Optimized query to fetch the JSON column directly
        var sql = "SELECT Id, BookId, Title, Units FROM Chapters WHERE Id = @Id";
        var chapter = await _db.QuerySingleOrDefaultAsync<ChapterDto>(sql, new { Id = query.ChapterId });

        return chapter != null ? Result.Success(chapter) : Result.Failure<ChapterDto>("Chapter not found");
    }
}
```

---

### 3. Validation (FluentValidation)

Using a MediatR pipeline behavior ensures that validation occurs automatically before any command handler is executed.

```csharp
// Koine.Application/Features/Users/Validators/CreateUserCommandValidator.cs
public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.Username).NotEmpty().MinimumLength(3);
        RuleFor(x => x.Password).NotEmpty().Matches(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")
            .WithMessage("Password must be at least 8 characters and contain letters and numbers.");
    }
}
```

---

### 4. Units Query Optimization (JSON Column)

When querying the `Units` JSON column, we leverage database-specific features to avoid fetching the entire blob when only a subset of data is needed.

#### **Querying with EF Core (PostgreSQL example)**
EF Core 8+ allows querying into JSON columns using standard LINQ.
```csharp
var wordCount = await _context.Chapters
    .Where(c => c.Id == chapterId)
    .SelectMany(c => c.Units.Tokens)
    .CountAsync();
```

#### **Indexing for Performance**
To optimize cross-chapter searches (e.g., "Find all chapters where word 'αγαπη' appears"), we create a GIN index:
```sql
CREATE INDEX idx_chapters_units_content 
ON Chapters USING GIN ((Units -> 'Tokens') jsonb_path_ops);
```

---

### 5. DTOs & Mapping

We use **Records** for DTOs to ensure immutability during transport.

```csharp
// Koine.Application/DTOs/Texts/ChapterDto.cs
public record ChapterDto(
    int Id,
    int BookId,
    string Title,
    List<UnitTokenDto> Units // Deserialized from JSON column
);

// Koine.Application/Mappers/TextMappingProfile.cs
public class TextMappingProfile : Profile
{
    public TextMappingProfile()
    {
        CreateMap<Chapter, ChapterDto>();
        CreateMap<UnitToken, UnitTokenDto>();
    }
}
```

### Summary of Application Layer Benefits
1.  **Atomicity:** Command handlers ensure that complex updates (like updating progress + logging a session) occur within a single transaction.
2.  **Performance:** Query handlers can bypass the overhead of EF Core Change Tracking and Domain logic, using raw SQL or specialized JSON queries.
3.  **Safety:** FluentValidation + MediatR Pipeline prevents invalid data from ever reaching the domain logic.
4.  **Consistency:** Domain events (e.g., `ReadingSessionCompleted`) can be handled asynchronously by `MediatR` notifications to update statistics without slowing down the user experience.