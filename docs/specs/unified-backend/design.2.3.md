The Infrastructure Layer for the monolithic backend translates domain-level requirements into physical storage and service interactions. We leverage **EF Core 8+** for its native JSON support and performance features.

---

### 1. Database Repositories (Persistence Adapters)

The repository pattern abstracts data access. We extend a generic `Repository<T>` for common CRUD operations and implement entity-specific interfaces for complex queries.

```csharp
// Koine.Infrastructure/Data/Repositories/ChapterRepository.cs
public class ChapterRepository : Repository<Chapter>, IChapterRepository
{
    public ChapterRepository(KoineDbContext context) : base(context) { }

    public async Task<Chapter?> GetWithUnitsAsync(int id)
    {
        // EF Core 8+ handles JSON deserialization automatically when mapped
        return await _dbSet
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<List<Chapter>> GetByBookIdAsync(int bookId)
    {
        return await _dbSet
            .Where(c => c.BookId == bookId)
            .OrderBy(c => c.ChapterIndex)
            .ToListAsync();
    }
}
```

---

### 2. EF Core DbContext & JSON Column Mapping

The unified `KoineDbContext` manages all domain entities. The `Units` column in the `Chapter` table is mapped as a JSON column, allowing LINQ-to-JSON queries.

```csharp
// Koine.Infrastructure/Data/Configurations/ChapterConfiguration.cs
public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
{
    public void Configure(EntityTypeBuilder<Chapter> builder)
    {
        builder.ToTable("Chapters");
        builder.HasKey(c => c.Id);

        // MAP TO JSON COLUMN (EF CORE 8+)
        builder.OwnsOne(c => c.Units, unitsBuilder =>
        {
            unitsBuilder.ToJson(); // Persists as JSONB (Postgres) or JSON (SQL Server)
            
            // Nested configuration for the Tokens collection
            unitsBuilder.OwnsMany(u => u.Tokens);
        });

        // Index for performance on the Book/Index combination
        builder.HasIndex(c => new { c.BookId, c.ChapterIndex }).IsUnique();
    }
}
```

---

### 3. External Service Adapters (Caching & Logging)

We implement adapters for infrastructure services like **Redis** and **Azure Application Insights** to keep the core application logic clean.

```csharp
// Koine.Infrastructure/Services/Caching/RedisCacheService.cs
public class RedisCacheService : ICacheService
{
    private readonly IDatabase _redis;
    private readonly ILogger<RedisCacheService> _logger;

    public RedisCacheService(IConnectionMultiplexer redis, ILogger<RedisCacheService> logger)
    {
        _redis = redis.GetDatabase();
        _logger = logger;
    }

    public async Task<T?> GetAsync<T>(string key)
    {
        var value = await _redis.StringGetAsync(key);
        return value.HasValue ? JsonSerializer.Deserialize<T>(value!) : default;
    }

    public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
    {
        var json = JsonSerializer.Serialize(value);
        await _redis.StringSetAsync(key, json, expiry);
    }
}
```

---

### 4. Units Storage Implementation (CRITICAL)

To optimize the migration from the legacy table-based `Units` to the JSON-based `Chapters.Units`, we implement efficient serialization logic.

-   **Efficient Deserialization:** By using `AsNoTracking()` in queries, EF Core skips change tracking for the large JSON blob, significantly reducing memory overhead.
-   **JSON Schema Optimization:** We use short property names (e.g., `p` for `Placement`) in the JSON serialization to reduce storage size, handled via `[JsonPropertyName]` attributes on the `UnitToken` record.

---

### 5. Persistence & Resilience

We ensure data integrity through **Transaction Management** and **Connection Resilience**.

-   **Transaction Management:** Managed by the `UnitOfWork`, ensuring that complex operations (e.g., creating a user + initializing their progress) are atomic.
-   **Connection Resilience:** Configured during service registration to handle transient network issues:
    ```csharp
    services.AddDbContext<KoineDbContext>(options =>
        options.UseSqlServer(connectionString, sqlOptions =>
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null)));
    ```
-   **Concurrency:** We implement `RowVersion` (Timestamp) on the `User` entity to prevent lost updates during concurrent profile or progress modifications.

### Migration Strategy
1.  **Unified Schema:** Consolidate the four legacy databases into a single schema with explicit foreign keys.
2.  **Data Scrubbing:** Normalize user names and email addresses during the migration.
3.  **JSON Packing:** A background job will aggregate rows from the legacy `Units` table into the new `Chapters.Units` JSON column, validating Greek token counts for consistency.