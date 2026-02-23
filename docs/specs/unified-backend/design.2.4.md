The API Layer serves as the entry point for all frontend and external integrations, providing a unified, secure, and documented interface to the system.

---

### 1. Controller Structure & RESTful Naming

Controllers are thin and delegate all logic to MediatR handlers. We use **Attribute Routing** with a consistent prefix.

```csharp
// Koine.API/Controllers/TextsController.cs
[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/texts")]
[Authorize]
public class TextsController : ControllerBase
{
    private readonly IMediator _mediator;

    public TextsController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    [AllowAnonymous] // Public access for reading
    public async Task<ActionResult<PagedList<TextDto>>> GetTexts([FromQuery] TextParameters parameters)
    {
        var result = await _mediator.Send(new ListTextsQuery(parameters));
        return Ok(result);
    }

    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<TextDto>> GetText(int id)
    {
        var result = await _mediator.Send(new GetTextByIdQuery(id));
        return result.Match(Ok, Problem); // Using custom result matching
    }
}
```

### 2. Unified API Versioning

We adopt **URL-based versioning** (`/api/v1/...`) for its simplicity and clear visibility in logs.

```csharp
// Koine.API/Program.cs (Configuration)
builder.Services.AddApiVersioning(options => {
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ReportApiVersions = true;
});
```

---

### 3. Cross-Cutting Concerns

#### **Global Exception Handling**
We implement a `GlobalExceptionMiddleware` that returns **RFC 7807 (Problem Details)** responses to ensure consistency across all error types.

```csharp
public async Task InvokeAsync(HttpContext context)
{
    try { await _next(context); }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Unhandled Exception");
        await HandleExceptionAsync(context, ex);
    }
}
```

#### **Authentication & Authorization**
- **JWT Auth:** Integrated via `builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)`.
- **Policies:** We define policies like `"AdminOnly"` and `"UserIsOwner"` to protect user-specific data (e.g., progress, sessions).

---

### 4. API Documentation (Swagger)

Swagger is configured to handle JWT headers and API versions automatically.

```csharp
builder.Services.AddSwaggerGen(c => {
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme {
        Description = "JWT Authorization header using the Bearer scheme.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey
    });
    // Additional configuration for versioned docs...
});
```

---

### 5. Performance Considerations

#### **Response Compression**
We enable `Brotli` and `Gzip` compression to minimize the payload size for large JSON blobs (like chapter units).

#### **ETag Support (Optimistic Concurrency)**
For the high-volume `UserProgress` and `Units` data, we implement ETag-based caching:
1.  **Server:** Generates an MD5/SHA hash of the JSON response and returns it in the `ETag` header.
2.  **Client:** Sends the hash back in the `If-None-Match` header.
3.  **Result:** Server returns `304 Not Modified` if the data hasn't changed, saving bandwidth.

#### **JSON Query Optimization**
By using `System.Text.Json` source generation and `AsNoTracking()` in the underlying data layer, the controllers can stream large results directly to the response buffer without holding massive strings in memory.

### Summary of Endpoint Conventions
| Resource | Route | Purpose |
| :--- | :--- | :--- |
| **Auth** | `POST /api/v1/auth/login` | Authenticate and get JWT. |
| **Profile**| `GET /api/v1/users/me` | Current user details. |
| **Texts** | `GET /api/v1/texts` | Paginated list of books/chapters. |
| **Reader** | `GET /api/v1/texts/{id}/reader`| Fetch chapter units + user context. |
| **Session**| `POST /api/v1/sessions` | Start a new reading/study session. |